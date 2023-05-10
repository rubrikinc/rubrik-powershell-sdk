using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GraphQL;
using GraphQLParser.AST;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Rubrik.SecurityCloud.NetSDK.Library.HelperClasses;
using System.Management.Automation;
using RubrikSecurityCloud.Client;

public class GraphQLInterfaceConverter : JsonConverter
{
    public override bool CanConvert(Type objectType)
    {
        return objectType.AssemblyQualifiedName.StartsWith("Rubrik")
            && objectType.BaseType == null;
    }

    public override object ReadJson(
        JsonReader reader,
        Type objectType,
        object existingValue,
        JsonSerializer serializer
    )
    {
        JObject jsonObject = JObject.Load(reader);

        var gqlTypeName = jsonObject.Last.First.Value<string>();
        var gqlType = Type.GetType(
            String.Format(
                "Rubrik.SecurityCloud.Types.{0}, RubrikSecurityCloud.Schema",
                gqlTypeName
            )
        );
        object gqlObject = Activator.CreateInstance(gqlType);
        serializer.Populate(jsonObject.CreateReader(), gqlObject);

        return gqlObject;
    }

    public override void WriteJson(
        JsonWriter writer,
        object value,
        JsonSerializer serializer
    )
    {
        throw new NotImplementedException();
    }
}

namespace Rubrik.SecurityCloud.NetSDK.Client
{
    public partial class RscGraphQLClient
    {

        /// <summary>
        /// Overloaded method that be used to get an GraphQL query document
        /// from an embedded resource .graphql file.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="operationName"></param>
        /// <param name="variables"></param>
        /// <returns></returns>
        public async Task<T> InvokeGenericCallAsync<T>(
            string operationString,
            OperationVariableSet variables = null,
            IRscLogger logger = null,
            Dictionary<string, string> metricsTags = null
        )
        {
            //var request = new GraphQLRequest
            //{
            //    Query = Library.LibraryHelper.GetEmbeddedGrahQLOperation(operationName)
            //};


            var request = new GraphQLRequest
            {
                Query = operationString
            };

            return await InvokeGenericCallAsync<T>(
                request,
                variables,
                logger,
                metricsTags
            );
        }

        /// <summary>
        /// Get an object or data from the Rubrik Security Cloud GraphQL API.
        /// Data is returned as type T.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <param name="variables"></param>
        /// <returns></returns>
        public async Task<T> InvokeGenericCallAsync<T>(
            GraphQLRequest request,
            OperationVariableSet variables = null,
            IRscLogger logger = null,
            Dictionary<string, string> metricsTags = null
        )
        {
            // Verbose log request and variables:
            String parentSelectorName = "";
            GraphQLDocument queryDocument = GraphQLParser.Parser.Parse(request.Query);
            if (queryDocument.Definitions != null)
            {
                var parent = (ASTNode)(((GraphQLOperationDefinition)queryDocument.Definitions[0]).SelectionSet.Selections[0]);
                var parentJson = JsonConvert.SerializeObject(parent);
                JObject parentJObject = JObject.Parse(parentJson);
                parentSelectorName = parentJObject["Name"]["StringValue"].ToString();
            }

            if (variables != null)
            {
                try
                {
                    request.Variables = variables.AsJson();
                }
                catch ( Exception ex )
                {
                    throw new ArgumentException(
                        $"Could not serialize variables {request.Variables}" +
                        $": {ex}");
                }
            }

            // inserting __typename field into all response objects
            const string typename = "__typename";
            request.Query = request.Query.Replace(typename, String.Empty);
            request.Query = request.Query.Replace(
                "}",
                string.Format(" {0}}}", typename)
            );
            

            JObject response = await InvokeGraphQLQuery<JObject>(
                request,
                logger,
                metricsTags
            )
                ?? throw new InvalidOperationException("server response is null");
            String returnAsJson = "";
            JObject parentSelectorObj = response[parentSelectorName] as JObject;
            if (parentSelectorObj == null)
            {
                parentSelectorObj = response as JObject;
            }

            returnAsJson = JsonConvert.SerializeObject(response[parentSelectorName]);


            T responseData = JsonConvert.DeserializeObject<T>(returnAsJson,
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    Converters =
                    {
                        //new EnumJsonConverter(), //Might be needed in the future.
                        new GraphQLInterfaceConverter()
                    },
                }
            );

            return responseData;
        }

        /// <summary>
        /// Request data from the Rubrik Security Cloud GraphQL API,
        /// using a custom query. Data is returned as type Object
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public async Task<Object> InvokeGenericCall(
            string content,
            Dictionary<string, string> metricsTags = null
        )
        {
            JObject contentAsJson = JObject.Parse(content);
            if (!contentAsJson.ContainsKey("query"))
            {
                return "Input content should have a 'query' key.";
            }

            var request = new GraphQLRequest
            {
                Query = contentAsJson.GetValue("query").ToString()
            };

            if (contentAsJson.ContainsKey("vars"))
            {
                request.Variables = SerializeVariables(contentAsJson.GetValue("vars"));
            }

            var response = await InvokeGraphQLQuery<Object>(
                request,
                null, // logger
                metricsTags
            );

            return response;
        }
    }
}