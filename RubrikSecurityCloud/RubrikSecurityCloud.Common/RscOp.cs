using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace RubrikSecurityCloud
{
    public class RscOp
    {
        public delegate string StringGqlRootFieldNameLookupByRscOp(RscOp rscOp);
        public static StringGqlRootFieldNameLookupByRscOp? GqlRootFieldLookup=null;

        public delegate string ReturnTypeLookupByGqlRootField(string gqlRootField);
        public static ReturnTypeLookupByGqlRootField? ReturnTypeLookup=null;

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
            if (string.IsNullOrEmpty(this.GqlRootFieldName) && RscOp.GqlRootFieldLookup != null)
            {
                this.GqlRootFieldName = RscOp.GqlRootFieldLookup(this);
            }
            if(string.IsNullOrEmpty(this.GqlReturnTypeName) && RscOp.ReturnTypeLookup != null && !string.IsNullOrEmpty(this.GqlRootFieldName))
            {
                this.GqlReturnTypeName = RscOp.ReturnTypeLookup(this.GqlRootFieldName);
            }
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
            if(string.IsNullOrEmpty(this.GqlReturnTypeName)||
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