using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using GraphQLParser.AST;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.Client;
using RubrikSecurityCloud.Client.Models;
using System.Reflection;

namespace RubrikSecurityCloud.NetSDK.Client
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
        public Task<T> InvokeGenericCallAsync<T>(
            string operationString,
            OperationVariableSet variables = null,
            IRscLogger logger = null,
            Dictionary<string, string> metricsTags = null
        )
        {
            var request = new GraphQLRequest { Query = operationString };

            return InvokeGenericCallAsync<T>(
                request,
                variables,
                logger,
                metricsTags);
        }

        public dynamic Invoke(
            GraphQLRequest request,
            OperationVariableSet variables = null,
            string fieldTypeName = null,
            IRscLogger logger = null,
            Dictionary<string, string> metricsTags = null
        )
        {
            // Get the Type from the string
            Type t = ReflectionUtils.GetType(fieldTypeName);

            // Get method info for generic method
            MethodInfo genericMethod = this.GetType()
                .GetMethod("InvokeGenericCallSync");

            // Make the generic method with the correct type
            MethodInfo method = genericMethod.MakeGenericMethod(t);

            // Prepare the parameters for the method invocation
            object[] parameters = new object[] {
                request,
                variables,
                logger,
                metricsTags };

            // call this.InvokeGenericCallAsync<T>()
            dynamic result = method.Invoke(this, parameters);

            logger?.Flush();
            return result;
        }

        public dynamic InvokeGenericCallSync<T>(
            GraphQLRequest request,
            OperationVariableSet variables = null,
            IRscLogger logger = null,
            Dictionary<string, string> metricsTags = null
)
        {
            dynamic task = InvokeGenericCallAsync<T>(
                request,
                variables,
                logger,
                metricsTags);
            try
            {
                task.Wait();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                if (ex.InnerException != null)
                {
                    message += "\n" + ex.InnerException.Message;
                }
                throw new RscInvokeException(message);
            }
            return task.Result;
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
            string parentSelectorName = "";
            GraphQLDocument queryDocument;
            try
            {
                queryDocument = GraphQLParser.Parser
                    .Parse(request.Query);
            }
            catch (GraphQLParser.Exceptions.GraphQLSyntaxErrorException ex)
            {
                throw new FormatException(
                    $"Could not parse query:\n\n{request.Query}\n\n{ex}"
                );
            }
            if (queryDocument.Definitions != null)
            {
                var parent = (ASTNode)(
                    ((GraphQLOperationDefinition)queryDocument.Definitions[0])
                        .SelectionSet
                        .Selections[0]
                );
                var parentJson = JsonConvert.SerializeObject(parent);
                JObject parentJObject = JObject.Parse(parentJson);
                parentSelectorName = parentJObject["Name"]["StringValue"]
                    .ToString();
            }

            if (variables != null)
            {
                try
                {
                    request.Variables = variables.AsJson(logger);
                }
                catch (Exception ex)
                {
                    throw new ArgumentException(
                        $"Could not serialize variables {request.Variables}"
                            + $": {ex}"
                    );
                }
            }

            request.Query = StringUtils.InsertTypeNamesInGqlQuery(
                request.Query);

            // Send query to server:

            JObject response =
                await InvokeGraphQLQuery<JObject>(request, logger, metricsTags)
                ?? throw new InvalidOperationException(
                    "server response is null");

            string returnAsJson;
            JObject parentSelectorObj = response[parentSelectorName] as JObject;
            if (parentSelectorObj == null)
            {
                parentSelectorObj = response as JObject;
            }

            returnAsJson = JsonConvert.SerializeObject(
                response[parentSelectorName]);

            T responseData = JsonConvert.DeserializeObject<T>(
                returnAsJson,
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    Converters =
                    {
                        //new EnumJsonConverter(), //Might be needed in the future.
                        new GraphQLInterfaceConverter(typeof(T).FullName,logger)
                    },
                }
            );

            return responseData;
        }

        /// <summary>
        /// Send custom query to API server,
        /// If the root field is identified in the schema,
        /// the response is returned as a schema type object.
        /// If not, it is returned as a JObject.
        /// </summary>
        public object InvokeRawQuery(
            string queryStr,
            Hashtable variables,
            IRscLogger logger = null,
            Dictionary<string, string> metricsTags = null
        )
        {

            Type queryType = null;
            queryStr = queryStr.Trim();
            if (queryStr.StartsWith("query"))
            {
                queryType = typeof(RubrikSecurityCloud.Types.Query);
            }
            else if (queryStr.StartsWith("mutation"))
            {
                queryType = typeof(RubrikSecurityCloud.Types.Mutation);

            }
            else
            {
                throw new InvalidOperationException(
                    "query must start with 'query' or 'mutation'");
            }

            var queryName = "";
            for (int i = queryStr.IndexOf('{') + 1; i < queryStr.Length; ++i)
            {
                if (
                    !Char.IsLetter(queryStr[i]) &&
                    !Char.IsWhiteSpace(queryStr[i])
                )
                {
                    break;
                }
                queryName += queryStr[i];
            }
            queryName = queryName.Trim();

            // queryName at this point is the GraphQL root field name
            string gqlReplyTypeStr = StringUtils.GqlTypeToType(
                SchemaMeta.ReturnTypeLookupByGqlRootField(queryName),
                convertListToScalar: false);
            
            // Convert GraphQL field name to .NET field name
            queryName = StringUtils.StrictPascalCase(queryName);

            if ( string.IsNullOrEmpty(gqlReplyTypeStr) )
            {
                logger?.Warning("Root field " + queryName + " not found in " + queryType.ToString() + ". Will not cast server response to a specific type.");
            }

            if (!gqlReplyTypeStr.StartsWith("System"))
            {
                gqlReplyTypeStr = gqlReplyTypeStr.Split('.').Last();
            }

            var request = new GraphQLRequest
            {
                Query = queryStr,
                Variables = SerializeVariables(variables)
            };

            var response = Invoke(
                request,
                null, // variables
                gqlReplyTypeStr,
                logger,
                metricsTags
            );

            return response;
        }
    }
}
