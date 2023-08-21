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
        /// <summary>
        /// Default for when SaveQueryToFile() is called without a filename.
        /// </summary>
        public string DefaultQueryFileName { get; set; } = "query.gql";
        
// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        public void Init(
            string customOperationsDir,
            string? operationName = null,
            string? query = null,
            string? variables = null)
        {
            if ( operationName != null )
            {
                this.OperationName = operationName;
            }
            
            if ( string.IsNullOrEmpty(this.OperationName))
            {
                this.DefaultQueryFileName = "query.gql";
            }
            else 
            {
                this.DefaultQueryFileName = this.OperationName + ".gql" ;
            }

            if ( ! string.IsNullOrEmpty(customOperationsDir) )
            {
                this.DefaultQueryFileName = System.IO.Path.Combine(
                    customOperationsDir, 
                    this.DefaultQueryFileName);
            }
            if ( query != null )
            {
                this.Query = query;
            }
            if ( variables != null )
            {
                this.Variables = variables;
            }
        }
#pragma warning restore 1591

        /// <summary>
        /// Save the query (just the query, not the variables) to a file.
        /// If no filename is provided, DefaultQueryFileName is used.
        /// </summary>
        public string SaveQueryToFile( string? filename = null )
        {
            if (filename == null)
            {
                filename = this.DefaultQueryFileName;
            }
            Files.WriteFile(filename, this.Query, true);
            return filename;
        }
    }
}
