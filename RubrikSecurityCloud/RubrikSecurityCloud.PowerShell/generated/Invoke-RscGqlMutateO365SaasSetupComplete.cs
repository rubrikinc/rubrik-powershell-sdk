// Invoke-RscGqlMutateO365SaasSetupComplete.cs
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
    /// Invoke GraphQL Mutation o365SaasSetupComplete
    /// o365SaasSetupComplete(input: O365SaasSetupCompleteInput!): AddO365OrgResponse!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlMutateO365SaasSetupComplete")
    ]
    public class Invoke_RscGqlMutateO365SaasSetupComplete : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("o365SaasSetupComplete");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Mutation o365SaasSetupComplete
        /// o365SaasSetupComplete(input: O365SaasSetupCompleteInput!): AddO365OrgResponse!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_o365SaasSetupComplete();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_o365SaasSetupComplete()
        {
            this._logger.name += " -o365SaasSetupComplete";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "O365SaasSetupCompleteInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationO365SaasSetupComplete",
                "($input: O365SaasSetupCompleteInput!)",
                "AddO365OrgResponse",
                Mutation.O365SaasSetupComplete_ObjectFieldSpec,
                Mutation.O365SaasSetupCompleteFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	tenantId = <System.String>
	# REQUIRED
	regionName = <System.String>
	# REQUIRED
	stateToken = <System.String>
	# REQUIRED
	appTypes = @(
		<System.String>
	)
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
	# REQUIRED
	storeBackupInSameRegionAsData = <System.Boolean>
}"
            );
        }

    } // class Invoke-RscGqlMutateO365SaasSetupComplete
}