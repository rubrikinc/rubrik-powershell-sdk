using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

// ignore warning 'Missing XML comment'
#pragma warning disable 1591

// namespace is RubrikSecurityCloud (and not private)
// because this class is used by the public cmdlets
// and is visible to the user
namespace RubrikSecurityCloud
{
    /// <summary>
    ///  A GraphQL Operation.
    /// </summary>
    public class RscGqlOperation
    {
        
        /// <summary>
        /// The kind of operation: "query" or "mutation".
        /// </summary>
        public string Kind { get; set; }

        /// <summary>
        /// The name of the operation.
        /// By convention, the name of the operation is the capitalized version of the name of the root field. e.g. :
        /// - root field: "clusterConnection",
        /// - operation name: "ClusterConnection"
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The arguments of the operation. e.g. : "(id: $id)"
        /// </summary>
        public string Args { get; set; }

        /// <summary>
        /// The return type of the operation, which can either be
        /// a simple type (int, string, etc.) or a RubrikSecurityCloud.Schema
        /// type (e.g. "ClusterConnection", "Cluster", etc.)
        /// </summary>
        public string ReturnType { get; set; }

        /// <summary>
        /// The field spec of the operation. e.g. : "id name"
        /// </summary>
        public string FieldSpec { get; set; }

        /// <summary>
        /// Create a new RscGqlOperation object.
        /// 
        /// The RscGqlOperation is a collection of string properties
        /// that are assembled by the Query() method to produce
        /// the exact, final GraphQL query that is sent to the API server.
        /// </summary>
        /// <param name="kind">The kind of operation (query, mutation, subscription).</param>
        /// <param name="name">The name of the operation.</param>
        /// <param name="args">The arguments of the operation.</param>
        /// <param name="returnType">The return type of the operation.</param>
        /// <param name="fieldSpec">The field spec of the operation.</param>
        /// <returns>A new RscGqlOperation object.</returns>
        public RscGqlOperation(
            string kind = "",
            string name = "",
            string args = "",
            string returnType = "",
            string fieldSpec = "")
        {
            this.Kind = kind;
            this.Name = name;
            this.Args = args;
            this.ReturnType = returnType;
            this.FieldSpec = fieldSpec;
        }

        /// <summary>
        /// Return the query for the API server.
        /// </summary>
        public string Query()
        {
            var spec = this.FieldSpec;
            // fix spec indenting if needed:
            if (!string.IsNullOrEmpty(spec) && spec[0] != ' ')
            {
                spec = "  " + spec.Replace("\n", "\n  ").TrimEnd(new char[] { ' ' });
            }
            return this.Kind + " " + this.Name + this.Args + "\n{\n" + spec + "}\n";
        }
    }
}