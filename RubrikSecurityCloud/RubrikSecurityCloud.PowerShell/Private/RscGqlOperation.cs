using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Reflection;
using Newtonsoft.Json.Linq;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.PowerShell.Private;

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
        public string Kind { get; set; }
        public string Name { get; set; }
        public string Args { get; set; }
        public string ReturnType { get; set; }
        public string FieldSpec { get; set; }

        /// <summary>
        /// Create a new RscGqlOperation object.
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