// New-RscGqlMutationCompleteAzureAdAppUpdate.cs
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
    /// Create new GraphQL Mutation completeAzureAdAppUpdate
    /// completeAzureAdAppUpdate(input: CompleteAzureAdAppUpdateInput!): Void
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationCompleteAzureAdAppUpdate")
    ]
    public class New_RscGqlMutationCompleteAzureAdAppUpdate : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("completeAzureAdAppUpdate");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation completeAzureAdAppUpdate
        /// completeAzureAdAppUpdate(input: CompleteAzureAdAppUpdateInput!): Void
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_completeAzureAdAppUpdate();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_completeAzureAdAppUpdate()
        {
            this._logger.name += " -completeAzureAdAppUpdate";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CompleteAzureAdAppUpdateInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCompleteAzureAdAppUpdate",
                "($input: CompleteAzureAdAppUpdateInput!)",
                "System.String",
                Mutation.CompleteAzureAdAppUpdate_ObjectFieldSpec,
                Mutation.CompleteAzureAdAppUpdateFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	workloadFid = <System.String>
	# REQUIRED
	stateToken = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationCompleteAzureAdAppUpdate
}