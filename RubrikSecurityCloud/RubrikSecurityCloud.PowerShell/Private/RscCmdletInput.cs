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
    public class RscCmdletInput
    {
        public String Op { get; set; }
        public RscGqlVars Arg { get; set; }
        public System.Object Field { get; set; }
        internal RscGqlOperation _gqlOperation = null;

        /// <summary>
        /// Create a new RscCmdletInput object.
        /// </summary>
        public RscCmdletInput(
            string op,
            RscGqlVars arg,
            System.Object field,
            RscGqlOperation gqlOperation)
        {
            this.Op = op;
            this.Arg = arg;
            this.Field = field;
            this._gqlOperation = gqlOperation;
        }

        /// <summary>
        /// The name of the underlying GQL operation.
        /// </summary>
        public RscGqlOperation GqlOperation()
        {
            return _gqlOperation;
        }

        public string FieldInfo()
        {
            if (string.IsNullOrEmpty(this._gqlOperation.ReturnType))
            {
                return "";
            }
            // example:
            // https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/clusterconnection.doc.html
            var gqlTypeName = this._gqlOperation.ReturnType.Replace("!", "").Replace("[", "").Replace("]", "").ToLower();
            return "https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/" + gqlTypeName + ".doc.html";
        }

        /// <summary>
        ///  String representation of this object.
        /// </summary>
        public override string ToString()
        {
            var FieldStr = this.Field == null ? "null" : this.Field.ToString();
            if (this.Field != null && this.Field is IFieldSpec)
            {
                FieldStr = ((IFieldSpec)this.Field).AsFieldSpec()
                    .Replace("\n", " ");
            }
            return $"RscCmdletInput(Op: {this.Op}, Arg: {this.Arg}, Field: {FieldStr})";
        }
    }
}