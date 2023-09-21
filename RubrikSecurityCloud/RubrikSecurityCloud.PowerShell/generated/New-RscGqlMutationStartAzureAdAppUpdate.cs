// New-RscGqlMutationStartAzureAdAppUpdate.cs
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
    /// Create new GraphQL Mutation startAzureAdAppUpdate
    /// startAzureAdAppUpdate(input: StartAzureAdAppUpdateInput!): StartAzureAdAppUpdateReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationStartAzureAdAppUpdate")
    ]
    public class New_RscGqlMutationStartAzureAdAppUpdate : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("startAzureAdAppUpdate");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation startAzureAdAppUpdate
        /// startAzureAdAppUpdate(input: StartAzureAdAppUpdateInput!): StartAzureAdAppUpdateReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_startAzureAdAppUpdate();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_startAzureAdAppUpdate()
        {
            this._logger.name += " -startAzureAdAppUpdate";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartAzureAdAppUpdateInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartAzureAdAppUpdate",
                "($input: StartAzureAdAppUpdateInput!)",
                "StartAzureAdAppUpdateReply",
                Mutation.StartAzureAdAppUpdate_ObjectFieldSpec,
                Mutation.StartAzureAdAppUpdateFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	workloadFid = <System.String>
	# OPTIONAL
	azureAdApp = @{
		# OPTIONAL
		clientId = <System.String>
		# OPTIONAL
		clientSecret = <System.String>
	}
}"
            );
        }

    } // class New-RscGqlMutationStartAzureAdAppUpdate
}