using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using RubrikSecurityCloud;
using RubrikSecurityCloud.NetSDK.Client.Models.Authentication;
using RubrikSecurityCloud.Client;
namespace RubrikSecurityCloud.NetSDK.Client
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

        private ulong _apiCallCount = 0;

        // Keep version number in sync with ModuleVersion in
        // RubrikSecurityCloud.psd1. Version number is represented
        // with underscores instead of dots, since operation names
        // cannot contain dots. For example, 1.0.0 would be represented
        // as 1_0_0.

        private AuthenticationState _authenticationState = AuthenticationState.NOT_AUTHORIZED;

        private JsonSerializerSettings SerializerSettings = new JsonSerializerSettings
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver()
        };

        private string SerializeVariables(object variables)
        {
            return JsonConvert.SerializeObject(variables, SerializerSettings);
        }

        public string ClientId
        {
            get
            {
                return _clientId;
            }
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

        public async Task RenewAuthAsyncIfNeeded()
        {
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            JwtSecurityToken jwtToken = tokenHandler.ReadJwtToken(_clientToken.AccessToken);
            var expirationTime = jwtToken.ValidTo; // we assume UTC
            DateTime currentTime = DateTime.UtcNow;

            if (
                expirationTime.Subtract(currentTime).TotalMinutes <=
                    RubrikSecurityCloud.Config.TokenRefreshThresholdMinutes
            ) {
                Console.WriteLine("Client session is about to expire, attempting to renew...");
                await Disconnect();
                await AuthAsync();
                Console.WriteLine("Client session renewed.");
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

        public async Task Disconnect()
        {
            if (this._authenticationState != AuthenticationState.AUTHORIZED)
            {
                //Session isn't valid, do nothing
                return;
            }

            HttpClientHandler httpHandler = new HttpClientHandler();
            HttpClient apiClient = new HttpClient(httpHandler)
            {
                BaseAddress = new Uri($"{_polarisUrlScheme}://{_polarisBaseUrl}")
            };
            apiClient.DefaultRequestHeaders.Accept.Clear();
            apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            apiClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _clientToken.AccessToken);

            HttpResponseMessage response = await apiClient.DeleteAsync("api/session").ConfigureAwait(false);

            if (response.IsSuccessStatusCode)
            {
                this.AuthenticationState = AuthenticationState.NOT_AUTHORIZED;
                return;
            }
            else
            {
                throw new Exception($"Call DELETE to \"api/session\" failed with : {response.ReasonPhrase}");
            }
        }

        private async Task<T> InvokeGraphQLQuery<T>(
            GraphQLRequest Request,
            IRscLogger logger = null,
            Dictionary<string, string> metricsTags = null
        )
        {
            HttpClientHandler httpHandler = new HttpClientHandler();
            var loggingHandler = new LoggingDelegatingHandler { InnerHandler = httpHandler };

            HttpClient apiClient = new HttpClient(loggingHandler)
            {
                BaseAddress = new Uri($"{_polarisUrlScheme}://{_polarisBaseUrl}")
            };
            apiClient.Timeout = TimeSpan.FromMinutes(
                RubrikSecurityCloud.Config.ApiClientTimeOutMinutes
            );
            GraphQLHttpClientOptions myOptions = new GraphQLHttpClientOptions
            {
                EndPoint = new Uri($"{_polarisUrlScheme}://{_polarisBaseUrl}/api/graphql"),
                MediaType = "application/json",
            };

            apiClient.DefaultRequestHeaders.Accept.Clear();
            apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            apiClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _clientToken.AccessToken);
            if (metricsTags != null)
            {
                foreach (var header in metricsTags)
                {
                    apiClient
                        .DefaultRequestHeaders
                        .Add(header.Key, header.Value);
                }
            }

            JsonSerializerSettings jsonSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Include
            };
            var graphQLClient = new GraphQLHttpClient(
                myOptions,
                new NewtonsoftJsonSerializer(jsonSettings),
                apiClient);

            // ----------------------------------------
            // Send query to server:
            // ----------------------------------------
            _apiCallCount++;
            logGraphQLRequest(Request, logger);
            GraphQL.Client.Http.GraphQLHttpResponse<T> response = null;
            string localError = null;
            try
            {
                response = (GraphQL.Client.Http.GraphQLHttpResponse<T>) await graphQLClient.SendQueryAsync<T>(Request);
            }
            catch (Exception ex)
            {
                // When a token has expired,
                // set the authentication state to EXPIRED
                if (ex.Message.Contains("TIME_CONSTRAINT_FAILURE"))
                {
                    this.AuthenticationState = AuthenticationState.EXPIRED;
                }
                localError = ex.Message;
            }
            logGraphQLResponse<T>(response, logger);
            
            if (response.Errors != null ||
                response.StatusCode >= System.Net.HttpStatusCode.BadRequest ||
                localError != null)
            {
                string msg = "The request generated an error.\n" +
                    this.GraphQLRequestToString(Request) + "\n\n" +
                    this.GraphQLResponseToString<T>(response) + "\n\n" +
                    loggingHandler.Message;
                if (localError != null)
                {
                    msg += "\n\n" + localError;
                }
                throw new System.Net.Http.HttpRequestException(msg);
            }

            return response.Data;
        }

        private string GraphQLRequestToString(GraphQLRequest request)
        {
            if (request == null)
            {
                return "null";
            }

            StringBuilder logContent = new StringBuilder();
            logContent.Append("\nQuery: ");
            logContent.Append(request.Query);
            logContent.Append("\nVariables: ");

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
                        logContent.Append($"  {variable.Key}: ");
                        logContent.AppendLine(JsonConvert.SerializeObject(variable.Value, Formatting.Indented));
                    }
                }
            }

            if (!string.IsNullOrEmpty(request.OperationName))
            {
                logContent.Append("Operation Name: ").AppendLine(request.OperationName);
            }

            return logContent.ToString();
        }

        private void logGraphQLRequest(GraphQLRequest request, IRscLogger logger)
        {
            logger?.Debug("Sending to API Server:\n" + 
                this.GraphQLRequestToString(request));
            if (RubrikSecurityCloud.Config.SaveApiTrafficToFile)
            {
                // log request to file in cwd
                string logFileName = Path.GetFullPath($"RscApiRequest_{_apiCallCount}_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.gql");
                File.WriteAllText(logFileName, $"/*\nVariables:\n{request.Variables}\n*/\n{request.Query}\n");
                logger?.Info($"API request saved to file: {logFileName}");
            }
        }

        private void logGraphQLResponse<T>(GraphQLResponse<T> response, IRscLogger logger)
        {
            logger?.Debug("=========> Received from API Server:\n" + 
                this.GraphQLResponseToString<T>(response));
            if (RubrikSecurityCloud.Config.SaveApiTrafficToFile)
            {
                // log response to file in cwd
                string logFileName = Path.GetFullPath($"RscApiResponse_{_apiCallCount}_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.json");
                File.WriteAllText(logFileName, JsonConvert.SerializeObject(response, Formatting.Indented));
                logger?.Info($"API response saved to file: {logFileName}");
            }
        }

        private string GraphQLResponseToString<T>(GraphQLResponse<T> response)
        {
            StringBuilder logContent = new StringBuilder();
            logContent.Append($"GraphQLResponse<{typeof(T).Name}>:\n");
            if(response==null)
            {
                logContent.Append("null");
                return logContent.ToString();
            }

            logContent.Append("Data:");
            if (response.Data != null)
            {
                var text = JsonConvert.SerializeObject(response.Data, Formatting.Indented);
                logContent.AppendLine("\n\n" + text + "\n");
            }
            else
            {
                logContent.AppendLine(" null");
            }

            logContent.Append("Errors:");
            if (response.Errors != null && response.Errors.Length > 0)
            {
                logContent.AppendLine("\n");
                foreach (var e in response.Errors)
                {
                    var errCode =(e.Extensions != null && e.Extensions.ContainsKey("code")) ?
                        e.Extensions["code"] : "";
                    logContent.AppendLine($"{errCode} {e.Message}");
                    if (e.Locations != null)
                    {
                        logContent.AppendLine("  Locations:");
                        foreach (var location in e.Locations)
                        {
                            logContent.AppendLine($"    Line: {location.Line}, Column: {location.Column}");
                        }
                    }

                    if (e.Path != null)
                    {
                        logContent.AppendLine("  Path: " + string.Join(".", e.Path));
                    }

                    if (e.Extensions != null)
                    {
                        logContent.AppendLine("  Extensions:");
                        logContent.AppendLine(JsonConvert.SerializeObject(e.Extensions, Formatting.Indented));
                    }
                }
                logContent.AppendLine("\n");
            } else {
                logContent.AppendLine(" null");
            }

            if (response is GraphQLHttpResponse<T>)
            {
                var r = response as GraphQLHttpResponse<T>;
                logContent.AppendLine($"HTTP Status Code: {(int)r.StatusCode} {r.StatusCode}");
            }
            return logContent.ToString();
        }
    }
}
