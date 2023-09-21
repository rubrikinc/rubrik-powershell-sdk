// New-RscGqlMutationCompleteAzureAdAppSetup.cs
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
    /// Create new GraphQL Mutation completeAzureAdAppSetup
    /// completeAzureAdAppSetup(input: CompleteAzureAdAppSetupInput!): CompleteAzureAdAppSetupReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationCompleteAzureAdAppSetup")
    ]
    public class New_RscGqlMutationCompleteAzureAdAppSetup : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("completeAzureAdAppSetup");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation completeAzureAdAppSetup
        /// completeAzureAdAppSetup(input: CompleteAzureAdAppSetupInput!): CompleteAzureAdAppSetupReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_completeAzureAdAppSetup();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_completeAzureAdAppSetup()
        {
            this._logger.name += " -completeAzureAdAppSetup";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CompleteAzureAdAppSetupInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCompleteAzureAdAppSetup",
                "($input: CompleteAzureAdAppSetupInput!)",
                "CompleteAzureAdAppSetupReply",
                Mutation.CompleteAzureAdAppSetup_ObjectFieldSpec,
                Mutation.CompleteAzureAdAppSetupFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	domainName = <System.String>
	# REQUIRED
	stateToken = <System.String>
	# OPTIONAL
	kmsSpec = @{
		# OPTIONAL
		cloudType = <O365AzureCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365AzureCloudType]) for enum values.
		# OPTIONAL
		tenantId = <System.String>
		# OPTIONAL
		kmsId = <System.String>
		# OPTIONAL
		appId = <System.String>
		# OPTIONAL
		appSecret = <System.String>
		# OPTIONAL
		keyName = <System.String>
		# OPTIONAL
		kekNameColossus = <System.String>
	}
}"
            );
        }

    } // class New-RscGqlMutationCompleteAzureAdAppSetup
}