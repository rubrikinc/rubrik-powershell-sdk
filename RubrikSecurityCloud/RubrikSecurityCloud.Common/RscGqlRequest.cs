using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using RubrikSecurityCloud.Types;
using GraphQL;

namespace RubrikSecurityCloud
{

    public class RscGqlRequest : GraphQL.GraphQLRequest
    {
        public string ReturnTypeName { get; set; } = "";

        public string DefaultSaveDir { get; set; } = "";

        public RscGqlRequest(
            string? operationName = null,
            string? variables = null,
            string? returnTypeName = null,
            string? query = null,
            string? defaultSaveDir = null
            )
        {
            Init(operationName, variables, returnTypeName, query,
                defaultSaveDir);
        }

        /// <summary>
        /// Initialize the RscGqlRequest object.
        /// Nulls are ignored,
        /// method can be called multiple times.
        /// </summary>
        public void Init(
            string? operationName = null,
            string? variables = null,
            string? returnTypeName = null,
            string? query = null,
            string? defaultSaveDir = null
            )
        {
            if (operationName != null)
            {
                this.OperationName = operationName;
            }
            if (variables != null)
            {
                this.Variables = variables;
            }
            if (returnTypeName != null)
            {
                this.ReturnTypeName = returnTypeName;
            }
            if (query != null)
            {
                this.Query = query;
            }
            if (defaultSaveDir != null)
            {
                this.DefaultSaveDir = defaultSaveDir;
            }
        }

        public string DefaultFileName()
        {
            var opName = string.IsNullOrEmpty(this.OperationName) ?
                                "query" : this.OperationName;
            return System.IO.Path.Combine(this.DefaultSaveDir, opName + ".gql");
        }
        
        /// <summary>
        /// Save the query (just the query, not the variables) to a file.
        /// If no filename is provided, DefaultQueryFileName is used.
        /// </summary>
        public string SaveQueryToFile(string? filename = null)
        {
            if (filename == null)
            {
                filename = DefaultFileName();
            }
            Files.WriteFile(filename, this.Query, true);
            return filename;
        }
    }
}
