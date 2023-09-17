// Invoke-RscGqlMutateCreateO365AppKickoff.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using GraphQL;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.PowerShell.Private;

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Invoke GraphQL Mutation createO365AppKickoff
    /// createO365AppKickoff(input: CreateO365AppKickoffInput!): CreateO365AppKickoffResp!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlMutateCreateO365AppKickoff")
    ]
    public class Invoke_RscGqlMutateCreateO365AppKickoff : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("createO365AppKickoff");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Mutation createO365AppKickoff
        /// createO365AppKickoff(input: CreateO365AppKickoffInput!): CreateO365AppKickoffResp!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_createO365AppKickoff();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_createO365AppKickoff()
        {
            this._logger.name += " -createO365AppKickoff";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateO365AppKickoffInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateO365AppKickoff",
                "($input: CreateO365AppKickoffInput!)",
                "CreateO365AppKickoffResp",
                Mutation.CreateO365AppKickoff_ObjectFieldSpec,
                Mutation.CreateO365AppKickoffFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	orgId = <System.String>
	# REQUIRED
	appType = <System.String>
}"
            );
        }

    } // class Invoke-RscGqlMutateCreateO365AppKickoff
}