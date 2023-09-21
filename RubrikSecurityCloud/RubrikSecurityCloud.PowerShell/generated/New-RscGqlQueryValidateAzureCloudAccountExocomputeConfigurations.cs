// New-RscGqlQueryValidateAzureCloudAccountExocomputeConfigurations.cs
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
    /// Create new GraphQL Query validateAzureCloudAccountExocomputeConfigurations
    /// validateAzureCloudAccountExocomputeConfigurations(input: ValidateAzureCloudAccountExocomputeConfigurationsInput!): ValidateAzureSubnetsForCloudAccountExocomputeReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryValidateAzureCloudAccountExocomputeConfigurations")
    ]
    public class New_RscGqlQueryValidateAzureCloudAccountExocomputeConfigurations : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("validateAzureCloudAccountExocomputeConfigurations");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query validateAzureCloudAccountExocomputeConfigurations
        /// validateAzureCloudAccountExocomputeConfigurations(input: ValidateAzureCloudAccountExocomputeConfigurationsInput!): ValidateAzureSubnetsForCloudAccountExocomputeReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_validateAzureCloudAccountExocomputeConfigurations();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_validateAzureCloudAccountExocomputeConfigurations()
        {
            this._logger.name += " -validateAzureCloudAccountExocomputeConfigurations";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ValidateAzureCloudAccountExocomputeConfigurationsInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryValidateAzureCloudAccountExocomputeConfigurations",
                "($input: ValidateAzureCloudAccountExocomputeConfigurationsInput!)",
                "ValidateAzureSubnetsForCloudAccountExocomputeReply",
                Query.ValidateAzureCloudAccountExocomputeConfigurations_ObjectFieldSpec,
                Query.ValidateAzureCloudAccountExocomputeConfigurationsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	azureExocomputeRegionConfigs = @(
		@{
			# REQUIRED
			region = <AzureCloudAccountRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
			# REQUIRED
			subnetNativeId = <System.String>
			# REQUIRED
			isRscManaged = <System.Boolean>
			# OPTIONAL
			podSubnetNativeId = <System.String>
		}
	)
}"
            );
        }

    } // class New-RscGqlQueryValidateAzureCloudAccountExocomputeConfigurations
}