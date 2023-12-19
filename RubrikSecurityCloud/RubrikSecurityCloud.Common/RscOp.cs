using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using RubrikSecurityCloud.Types;

namespace RubrikSecurityCloud
{
    /// <summary>
    ///  RscOp is a class that represents an API operation.
    /// </summary>
    public class RscOp
    {
        public static RscOp NullRscOp = new RscOp();
        public delegate bool SchemaMeta_FillInRscOp(RscOp rscOp);
        public static SchemaMeta_FillInRscOp? FillInRscOp = null;

        public delegate string SchemaMeta_GetRootFieldKind(string rootFieldName);

        public static SchemaMeta_GetRootFieldKind? GetRootFieldKind = null;

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
            if (RscOp.GetRootFieldKind != null)
            {
                string kind = RscOp.GetRootFieldKind(this.GqlRootFieldName);
                if (kind != "")
                {
                    return kind;
                }
            }

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
            if (kind == "query")
            {
                // assume CmdletName is like "New-RscQueryXxx"
                return this.CmdletName.Replace("New-RscQuery", "");
            }
            if (kind == "mutation")
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
            if (!string.IsNullOrEmpty(this.GqlRootFieldName))
            {
                var kind = this.OpKind();
                if (kind == "mutation")
                {
                    return $"New-RscMutation -GqlMutation {this.GqlRootFieldName}";
                }
                return $"New-RscQuery -GqlQuery {this.GqlRootFieldName}";
            }
            if (string.IsNullOrEmpty(this.CmdletName))
            {
                return "";
            }
            if (string.IsNullOrEmpty(this.CmdletSwitchName))
            {
                return this.CmdletName;
            }
            return $"{this.CmdletName} -Op {this.CmdletSwitchName}";
        }

        public List<Tuple<string, string>> Info()
        {
            return new List<Tuple<string, string>>() {
                new Tuple<string,string>(
                "API Domain",
                    this.DomainName()
                ),
                new Tuple<string,string>(
                    "API Operation",
                    this.OpName()
                ),
                new Tuple<string,string>(
                    "Invocation",
                    this.Syntax()
                ),
                new Tuple<string,string>(
                    "GQL Root Field",
                    this.GqlRootFieldName
                ),
                new Tuple<string,string>(
                    "GQL Return Type",
                    this.GqlReturnTypeName
                ),
            };
        }

        public override string ToString()
        {
            return this.DomainName() + "." + this.OpName();
        }
    }
}