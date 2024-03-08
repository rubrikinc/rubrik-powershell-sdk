using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Language;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.NetSDK.Client.Models.Authentication;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.PowerShell.Private;
using GraphQL;


// ignore warning 'Missing XML comment'
#pragma warning disable 1591

// until we use #nullable enable
#pragma warning disable CS8632

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    [CmdletBinding()]
    [Cmdlet(
    "New",
    "RscQuery",
    DefaultParameterSetName = "GqlRootField")]


    public abstract class New_GqlRootField : RscGqlPSCmdlet
    {
        static RscGqlPSCmdletConfig New_RscQueryConfig =
           new RscGqlPSCmdletConfig
           {
               HasDynParam_AddField = true,
               HasDynParam_RemoveField = true
           };

        [Parameter(
            Mandatory = false,
            HelpMessage = "API Domain.",
            ValueFromPipelineByPropertyName = true
        )]
        public SchemaMeta.ApiDomainName Domain { get; set; } = SchemaMeta.ApiDomainName.Unknown;

        /// <summary>
        /// The kind of root field this object is:
        /// a Query, a Mutation, or something unknown.
        /// </summary>
        public SchemaMeta.RootFieldKind RootFieldKind { get; set; } = SchemaMeta.RootFieldKind.Query;

        internal string gqlRootFieldParamHelpMessage = "Name of the GraphQL query.";

        public New_GqlRootField() : base(New_RscQueryConfig)
        {
            this.AddDynParamMethod(MakeDynParam_Operation);
        }

        override public SchemaMeta.ApiDomainName ApiDomainName()
        {
            if (this.Domain != SchemaMeta.ApiDomainName.Unknown)
            {
                return this.Domain;
            }
            if (this.Copy != null && this.Copy.rscOp != null)
            {
                string d = this.Copy.rscOp.DomainName();
                if (d != null)
                {
                    return (SchemaMeta.ApiDomainName)Enum.Parse(
                        typeof(SchemaMeta.ApiDomainName), d);
                }
            }
            return SchemaMeta.ApiDomainName.Unknown;
        }
        protected RuntimeDefinedParameter MakeDynParam_Operation()
        {
            var attrs = new Collection<Attribute>();
            attrs.Add(new ParameterAttribute
            {
                HelpMessage = "API Operation."
            });
            var domain = this.ApiDomainName();
            if (domain != SchemaMeta.ApiDomainName.Unknown)
            {
                List<string> validValues = SchemaMeta.ApiOperationsByApiDomainName(domain);
                if (validValues != null)
                {
                    var attr = new ValidateSetAttribute(validValues.ToArray());
                    attrs.Add(attr);
                }
            }
            return new RuntimeDefinedParameter(
                "Operation", typeof(string), attrs);
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            // We only want to determine domain and operation
            // to know what cmdlet to invoke and pass it
            // all parameters passed to this cmdlet.

            if (!string.IsNullOrEmpty(this.gqlRootField))
            {
                if (!string.IsNullOrEmpty(this.GetStringDynParam("Operation")))
                {
                    throw new Exception("Cannot specify both GraphQL field name and Operation");
                }
                RscOp op = SchemaMeta.RscOpLookupByGqlRootField(this.gqlRootField);
                _logger?.Debug($"Gql root field {this.gqlRootField} maps to {op}. cmdletName={op.CmdletName}, cmdletSwitchName={op.CmdletSwitchName}, gqlRootFieldName={op.GqlRootFieldName}, gqlReturnTypeName={op.GqlReturnTypeName}, gqlReturnTypeName={op.GqlReturnTypeName},DomainName={op.DomainName()},OpName={op.OpName()}");
                ProcessDomainOp(op.DomainName(), op.OpName());
                return;
            }

            if (this.ApiDomainName() == SchemaMeta.ApiDomainName.Unknown)
            {
                throw new Exception("Operation not supported");
            }

            string operation = "";
            string? dynOp = this.GetStringDynParam("Operation");
            if (!string.IsNullOrEmpty(dynOp))
            {
                operation = (dynOp ?? "").Trim();
                _logger?.Debug("Operation from -Operation: " + operation);
            }
            else if (this.Copy != null && this.Copy.rscOp != null)
            {
                operation = this.Copy.rscOp.OpName();
                _logger?.Debug("Operation from Copy: " + operation);
            }
            operation = this.ValidateOperation(operation, unknownOk: false);
            ProcessDomainOp(this.ApiDomainName().ToString(), operation);
        }

        protected void ProcessDomainOp(string domain, string op)
        {
            var cmdletName = "New-Rsc" + this.RootFieldKind.ToString() +
                domain;
            _logger?.Debug($"CmdletName: {cmdletName}");
            using (System.Management.Automation.PowerShell cmd = System.Management.Automation.PowerShell.Create(RunspaceMode.CurrentRunspace))
            {
                cmd.AddCommand(cmdletName);
                if (!string.IsNullOrEmpty(op))
                    cmd.AddParameter("Operation", op);
                if (this.Copy != null)
                    cmd.AddParameter("Copy", this.Copy);
                if (this.Var != null)
                    cmd.AddParameter("Var", this.Var);
                if (this.Field != null)
                    cmd.AddParameter("Field", this.Field);
                if (this.FilePatch != null)
                    cmd.AddParameter("FilePatch", this.FilePatch);
                if (this.FieldProfile != Exploration.Profile.UNSET)
                    cmd.AddParameter("FieldProfile", this.FieldProfile);
                if (this.GetDynParam("AddField") != null)
                    cmd.AddParameter("AddField", this.GetDynParam("AddField"));
                if (this.GetDynParam("RemoveField") != null)
                    cmd.AddParameter("RemoveField", this.GetDynParam("RemoveField"));

                var results = cmd.Invoke();
                foreach (var result in results)
                {
                    object r = result;
                    if (result is PSObject pSobject)
                    {
                        r = pSobject.BaseObject;
                    }
                    if (r is RscQuery query)
                    {
                        _query = query;
                        // RscGqlPSCmdlet.EndProcessing()
                        // will write the object to the pipeline
                    }
                    else
                    {
                        throw new Exception("Unexpected result type: " + r.GetType().FullName);
                    }
                }
            }
        }

    }


    [CmdletBinding()]
    [Cmdlet(
    "New",
    "RscMutation",
    DefaultParameterSetName = "DomainOp")]
    public class New_RscMutation : New_GqlRootField
    {
        [Parameter(
            Mandatory = false,
            ParameterSetName = "GqlMutation",
            HelpMessage = "The root GraphQL mutation to be called",
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
        public SchemaMeta.GqlMutationName? GqlMutation
        {
            get {
                if (gqlRootField == null)
                {
                    return null;
                }
                return (SchemaMeta.GqlMutationName) Enum.Parse(typeof(SchemaMeta.GqlMutationName), gqlRootField);
            }
            set { gqlRootField = value.ToString().Trim(); }
        }

        public New_RscMutation()
        {
            this.RootFieldKind = SchemaMeta.RootFieldKind.Mutation;
            this.gqlRootFieldParamHelpMessage = "Name of the GraphQL mutation.";
        }
    }

    [CmdletBinding()]
    [Cmdlet(
    "New",
    "RscQuery",
    DefaultParameterSetName = "DomainOp")]
    public class New_RscQuery : New_GqlRootField
    {
        [Parameter(
            Mandatory = false,
            ParameterSetName = "GqlQuery",
            HelpMessage = "The root GraphQL query to be called",
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
        public SchemaMeta.GqlQueryName? GqlQuery
        {
            get {
                if (gqlRootField == null)
                {
                    return null;
                }
                return (SchemaMeta.GqlQueryName)Enum.Parse(typeof(SchemaMeta.GqlQueryName), gqlRootField);
            }
            set { gqlRootField = value.ToString().Trim(); }
        }

        public New_RscQuery()
        {
            this.RootFieldKind = SchemaMeta.RootFieldKind.Query;
            this.gqlRootFieldParamHelpMessage = "Name of the GraphQL query.";
        }
    }
}
