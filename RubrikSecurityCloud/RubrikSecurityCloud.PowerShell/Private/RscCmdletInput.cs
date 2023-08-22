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
        public RscGqlVars Var { get; set; }
        public System.Object Field { get; set; }
        internal RscGqlOperation _gqlOperation = null;

        /// <summary>
        /// Create a new RscCmdletInput object.
        /// </summary>
        public RscCmdletInput(
            string op,
            RscGqlVars vars,
            System.Object field,
            RscGqlOperation gqlOperation)
        {
            this.Op = op;
            this.Var = vars;
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

        /// <summary>
        /// Return documentation links for the Field object.
        /// </summary>
        public string FieldInfo()
        {
            return StringUtils.DocLinkForGqlType(this._gqlOperation.ReturnType);
        }

        /// <summary>
        /// Return documentation links for the variables.
        /// </summary>
        public Hashtable VarInfo()
        {
            return this.Var.Info();
        }

        /// <summary>
        /// Return documentation links for variables and Field object.
        /// </summary>
        public Hashtable Info()
        {
            var info = this.Var.Info();
            info[this.Field.GetType().Name] = this.FieldInfo();
            return info;
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
            return $"RscCmdletInput(Op: {this.Op}, Var: {this.Var}, Field: {FieldStr})";
        }
    }
}