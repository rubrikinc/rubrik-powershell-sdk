// New-RscGqlMutationAzureOauthConsentComplete.cs
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
    /// Create new GraphQL Mutation azureOauthConsentComplete
    /// azureOauthConsentComplete(input: AzureOauthConsentCompleteInput!): RequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationAzureOauthConsentComplete")
    ]
    public class New_RscGqlMutationAzureOauthConsentComplete : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("azureOauthConsentComplete");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation azureOauthConsentComplete
        /// azureOauthConsentComplete(input: AzureOauthConsentCompleteInput!): RequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_azureOauthConsentComplete();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_azureOauthConsentComplete()
        {
            this._logger.name += " -azureOauthConsentComplete";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AzureOauthConsentCompleteInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAzureOauthConsentComplete",
                "($input: AzureOauthConsentCompleteInput!)",
                "RequestStatus",
                Mutation.AzureOauthConsentComplete_ObjectFieldSpec,
                Mutation.AzureOauthConsentCompleteFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	tenantId = <System.String>
	# REQUIRED
	code = <System.String>
	# REQUIRED
	stateToken = <System.String>
	# REQUIRED
	redirectUrl = <System.String>
	# OPTIONAL
	azureAppId = <System.String>
	# OPTIONAL
	azureAppSecret = <System.String>
	# REQUIRED
	azureCloudType = <O365AzureCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365AzureCloudType]) for enum values.
}"
            );
        }

    } // class New-RscGqlMutationAzureOauthConsentComplete
}