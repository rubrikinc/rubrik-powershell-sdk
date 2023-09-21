// New-RscGqlMutationStartAzureAdAppSetup.cs
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
    /// Create new GraphQL Mutation startAzureAdAppSetup
    /// startAzureAdAppSetup(input: StartAzureAdAppSetupInput!): StartAzureAdAppSetupReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationStartAzureAdAppSetup")
    ]
    public class New_RscGqlMutationStartAzureAdAppSetup : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("startAzureAdAppSetup");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation startAzureAdAppSetup
        /// startAzureAdAppSetup(input: StartAzureAdAppSetupInput!): StartAzureAdAppSetupReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_startAzureAdAppSetup();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_startAzureAdAppSetup()
        {
            this._logger.name += " -startAzureAdAppSetup";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartAzureAdAppSetupInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartAzureAdAppSetup",
                "($input: StartAzureAdAppSetupInput!)",
                "StartAzureAdAppSetupReply",
                Mutation.StartAzureAdAppSetup_ObjectFieldSpec,
                Mutation.StartAzureAdAppSetupFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	domainName = <System.String>
	# REQUIRED
	region = <AzureAdRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureAdRegion]) for enum values.
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

    } // class New-RscGqlMutationStartAzureAdAppSetup
}