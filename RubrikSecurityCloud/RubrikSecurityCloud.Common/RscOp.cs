using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace RubrikSecurityCloud
{
    /// <summary>
    ///  RscOp is a class that represents an API operation.
    /// </summary>
    public class RscOp
    {
        public delegate bool SchemaMeta_FillInRscOp(RscOp rscOp);
        public static SchemaMeta_FillInRscOp? FillInRscOp = null;

        public string CmdletName { get; set; }
        public string CmdletSwitchName { get; set; }
        public string GqlRootFieldName { get; set; }
        public string GqlReturnTypeName { get; set; }

        public RscOp(
            string cmdletName = "",
            string cmdletSwitchName = "",
            string gqlRootFieldName = "",
            string gqlReturnTypeName = "")
        {
            this.CmdletName = cmdletName;
            this.CmdletSwitchName = cmdletSwitchName;
            this.GqlRootFieldName = gqlRootFieldName;
            this.GqlReturnTypeName = gqlReturnTypeName;
        }

        /// <summary>
        /// Fill in the missing fields of this RscOp object
        /// (if possible).
        /// </summary>
        public RscOp Finalize()
        {
            if (RscOp.FillInRscOp != null)
            {
                RscOp.FillInRscOp(this);
            }
            return this;
        }

        public string OpName()
        {
            return this.CmdletSwitchName;
        }

        public string OpKind()
        {
            if (string.IsNullOrEmpty(this.CmdletName))
            {
                return "";
            }
            if (this.CmdletName.Contains("Query"))
            {
                return "query";
            }
            if (this.CmdletName.Contains("Mutation"))
            {
                return "mutation";
            }
            return "";
        }

        public string DomainName()
        {
            var kind = this.OpKind();
            if ( kind == "query" )
            {
                // assume CmdletName is like "New-RscQueryXxx"
                return this.CmdletName.Replace("New-RscQuery", "");
            }
            if ( kind == "mutation" )
            {
                // assume CmdletName is like "New-RscMutationXxx"
                return this.CmdletName.Replace("New-RscMutation", "");
            }
            return "";
        }

        public bool IsDetermined()
        {
            return !string.IsNullOrEmpty(this.CmdletName) &&
                !string.IsNullOrEmpty(this.CmdletSwitchName) &&
                !string.IsNullOrEmpty(this.GqlRootFieldName) &&
                !string.IsNullOrEmpty(this.GqlReturnTypeName);
        }

        public string Syntax()
        {
            if (string.IsNullOrEmpty(this.CmdletName))
            {
                return "";
            }
            if (string.IsNullOrEmpty(this.CmdletSwitchName))
            {
                return this.CmdletName;
            }
            return $"{this.CmdletName} -{this.CmdletSwitchName}";
        }

        public override string ToString()
        {
            var s = this.Syntax() + "# Gql: ";
            if (string.IsNullOrEmpty(this.GqlRootFieldName) ||
                this.GqlRootFieldName.ToLower() == "unknown")
            {
                s += "Unknown";
            }
            else
            {
                s += this.GqlRootFieldName;
            }
            if (string.IsNullOrEmpty(this.GqlReturnTypeName) ||
                this.GqlReturnTypeName.ToLower() == "unknown")
            {
                s += " (Unknown)";
            }
            else
            {
                s += $" ({this.GqlReturnTypeName})";
            }
            return s;
        }
    }
}