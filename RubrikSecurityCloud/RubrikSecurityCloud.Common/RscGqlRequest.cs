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
        internal string? _customOperationsDir = null;
        internal string? _queryFileName = null;
        
        public void Init(
            string? operationName = null,
            string? query = null,
            string? variables = null,
            string? customOperationsDir = null)
        {
            if ( operationName != null )
            {
                this.OperationName = operationName;
            }
            if ( query != null )
            {
                this.Query = query;
            }
            if ( variables != null )
            {
                this.Variables = variables;
            }
            if (customOperationsDir != null)
            {
                this._customOperationsDir = customOperationsDir;
            }
        }

        public string SaveQueryToFile( string? filename = null )
        {
            if (filename == null)
            {
                filename = QueryFileName();
            } else {
                this._queryFileName = filename;
            }
            System.IO.File.WriteAllText(filename, this.Query);
            return filename;
        }

        public string DefaultQueryFileName()
        {
            string filename = this.OperationName + ".gql" ;
            if ( ! string.IsNullOrEmpty(this._customOperationsDir) )
            {
                filename = System.IO.Path.Combine(this._customOperationsDir, filename);
            }
            return filename;
        }

        public string QueryFileName()
        {
            if ( string.IsNullOrEmpty(this._queryFileName) )
            {
                this._queryFileName = DefaultQueryFileName();
            }
            return this._queryFileName;
        }
    }
}
