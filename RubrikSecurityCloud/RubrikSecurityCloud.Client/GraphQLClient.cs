using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Rubrik.SecurityCloud.NetSDK.Client.Models.Authentication;
using RubrikSecurityCloud.Client;
namespace Rubrik.SecurityCloud.NetSDK.Client
{
    public class LoggingDelegatingHandler : DelegatingHandler
    {
        public String Message { get; set; }
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            HttpResponseMessage response = await base.SendAsync(request, cancellationToken);

            if (!response.IsSuccessStatusCode)
            {
                string contentString = await response.Content.ReadAsStringAsync();
                JObject jsonContent = JObject.Parse(contentString);
                if (jsonContent.ContainsKey("message"))
                {
                    this.Message = jsonContent["message"].Value<string>();
                }
            }
            return response;
        }
    }

    public partial class RscGraphQLClient
    {
        private readonly string _clientId;
        private readonly string _clientSecret;
        private readonly string _polarisBaseUrl;
        private readonly string _polarisUrlScheme;

        private AuthenticationState _authenticationState = AuthenticationState.NOT_AUTHORIZED;

        private JsonSerializerSettings SerializerSettings = new JsonSerializerSettings
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver()
        };

        private string SerializeVariables(object variables)
        {
            return JsonConvert.SerializeObject(variables, SerializerSettings);
        }

        public AuthenticationState AuthenticationState
        {
            get
            {
                return _authenticationState;
            }
            private set
            {
                _authenticationState = value;
            }
        }

        private ClientToken _clientToken;

        private string GetGraphQLQuery(string queryName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            string resouceName = assembly.GetManifestResourceNames().Where(n => n.Contains(queryName)).FirstOrDefault();

            var results = assembly.GetManifestResourceNames();
            Stream stream = assembly.GetManifestResourceStream(resouceName);
            StreamReader reader = new StreamReader(stream);

            return reader.ReadToEnd();
        }

        /// <summary>
        /// Instantiate a new Rubrik Polaris API Client
        /// </summary>
        /// <param name="ClientId">Client ID</param>
        /// <param name="ClientSecret">Client secret</param>
        /// <param name="PolarisBaseUrl">Polaris URL, in the format: "domain.my.rubrik.com"</param>
        public RscGraphQLClient(string ClientId, string ClientSecret, string PolarisBaseUrl)
        {
            _clientId = ClientId;
            _clientSecret = ClientSecret;

            //Check if the supplied PolarisBaseUrl is a url or a hostname
            if (Uri.IsWellFormedUriString(PolarisBaseUrl, UriKind.Absolute))
            {
                Uri suppliedUri = new Uri(PolarisBaseUrl);
                _polarisBaseUrl = suppliedUri.Host;
                if (_polarisBaseUrl == "localhost")
                {
                    _polarisBaseUrl += $":{suppliedUri.Port.ToString()}";
                    _polarisUrlScheme = "http";
                }
                else
                {
                    _polarisUrlScheme = "https";
                }
            }
            else
            {
                _polarisBaseUrl = PolarisBaseUrl;
                if (PolarisBaseUrl.Contains("localhost"))
                {
                    _polarisUrlScheme = "http";
                }
                else
                {
                    _polarisUrlScheme = "https";
                }
            }
        }

        public async Task AuthAsync()
        {
            HttpClientHandler httpHandler = new HttpClientHandler();
            HttpClient apiClient = new HttpClient(httpHandler)
            {
                BaseAddress = new Uri($"{_polarisUrlScheme}://{_polarisBaseUrl}")
            };
            apiClient.DefaultRequestHeaders.Accept.Clear();
            apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            ClientCredential clientCredential = new ClientCredential(_clientId, _clientSecret);

            HttpContent requestcontent = new StringContent(JsonConvert.SerializeObject(clientCredential), Encoding.UTF8, "application/json");

            HttpResponseMessage response = await apiClient.PostAsync("api/client_token", requestcontent).ConfigureAwait(false);

            if (response.IsSuccessStatusCode)
            {
                IList<JToken> data;

                JObject responsecontent = JObject.Parse(await response.Content.ReadAsStringAsync().ConfigureAwait(false));

                data = responsecontent;

                _clientToken = JsonConvert.DeserializeObject<ClientToken>(JsonConvert.SerializeObject(data));
                _authenticationState = AuthenticationState.AUTHORIZED;
            }
            else
            {
                throw new Exception($"Call to \"api/client_token\" failed with : {response.ReasonPhrase}");
            }
        }

        private async Task<T> InvokeGraphQLQuery<T>(GraphQLRequest Request, IRscLogger logger = null)
        {
            HttpClientHandler httpHandler = new HttpClientHandler();
            var loggingHandler = new LoggingDelegatingHandler { InnerHandler = httpHandler };

            HttpClient apiClient = new HttpClient(loggingHandler)
            {
                BaseAddress = new Uri($"{_polarisUrlScheme}://{_polarisBaseUrl}")
            };
            GraphQLHttpClientOptions myOptions = new GraphQLHttpClientOptions
            {
                EndPoint = new Uri($"{_polarisUrlScheme}://{_polarisBaseUrl}/api/graphql"),
                MediaType = "application/json",
            };

            apiClient.DefaultRequestHeaders.Accept.Clear();
            apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            apiClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _clientToken.AccessToken);

            JsonSerializerSettings jsonSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Include
            };
            var graphQLClient = new GraphQLHttpClient(
                myOptions,
                new NewtonsoftJsonSerializer(jsonSettings),
                apiClient);

            if (logger != null)
            {
                logger.Debug(this.GraphQLRequestToString(Request));
            }
            GraphQLResponse<T> response;
            try
            {
                response = await graphQLClient.SendQueryAsync<T>(Request);
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    $"ERROR: API Server responded: \"{ex.Message}\"\n" +
                    $"  Query: {Request.Query}\n" +
                    $"  Variables: {Request.Variables}\n\n" + 
                    loggingHandler.Message);
                //return default;
                throw ex;
            }
            if (logger != null)
            {
                logger.Debug(this.GraphQLResponseToString<T>(response));
            }
            if (response.Data == null)
            {
                var httpResp = response as GraphQLHttpResponse<T>;
                throw new Exception(
                    $"API Server error: {httpResp.StatusCode}\n" +
                    $"  Query: {Request.Query}\n" +
                    $"  Variables: {Request.Variables}\n\n" +
                    loggingHandler.Message);
            }
            return response.Data;
        }

        private string GraphQLRequestToString(GraphQLRequest request)
        {
            StringBuilder logContent = new StringBuilder();
            logContent.Append(
                request.GetType().ToString() + "\n\tQuery: " +
                request.Query.Replace("\n", string.Empty).Replace("  ", " ") +
                "\n\tVariables: ");

            if (request.Variables == null)
            {
                logContent.AppendLine("null");
            }
            else
            {
                if (request.Variables is string variablesString)
                {
                    logContent.AppendLine(variablesString);
                }
                else if (request.Variables is IDictionary<string, object> variablesDictionary)
                {
                    logContent.AppendLine("");
                    foreach (var variable in variablesDictionary)
                    {
                        logContent.AppendLine($"\t\t{variable.Key}: " +
                            JsonConvert.SerializeObject(variable.Value, Formatting.Indented));
                    }
                }
            }

            if (!string.IsNullOrEmpty(request.OperationName))
            {
                logContent.AppendLine("\tOperation Name: " + request.OperationName);
            }

            return logContent.ToString();
        }


        private string GraphQLResponseToString<T>(GraphQLResponse<T> response)
        {
            StringBuilder logContent = new StringBuilder();
            logContent.Append($"GraphQLResponse<{typeof(T).Name}>\n\tData:");

            if (response.Data != null)
            {
                var text = JsonConvert.SerializeObject(response.Data, Formatting.Indented);
                logContent.AppendLine(text.Replace("\n", "\n\t"));
            }
            else
            {
                logContent.AppendLine(" null");
            }

            if (response.Errors != null && response.Errors.Length > 0)
            {
                logContent.AppendLine("Errors:");

                foreach (var error in response.Errors)
                {
                    logContent.AppendLine("  " + error.Message);
                    if (error.Locations != null)
                    {
                        logContent.AppendLine("  Locations:");
                        foreach (var location in error.Locations)
                        {
                            logContent.AppendLine($"    Line: {location.Line}, Column: {location.Column}");
                        }
                    }

                    if (error.Path != null)
                    {
                        logContent.AppendLine("  Path: " + string.Join(".", error.Path));
                    }

                    if (error.Extensions != null)
                    {
                        logContent.AppendLine("  Extensions:");
                        logContent.AppendLine(JsonConvert.SerializeObject(error.Extensions, Formatting.Indented));
                    }
                }
            }
            if (response is GraphQLHttpResponse<T>)
            {
                var r = response as GraphQLHttpResponse<T>;
                if (r.StatusCode >= System.Net.HttpStatusCode.Ambiguous)
                {
                    logContent.AppendLine($" HTTP Status Code: {(int)r.StatusCode} {r.StatusCode}");
                }
            }
            return logContent.ToString();
        }
    }
}
