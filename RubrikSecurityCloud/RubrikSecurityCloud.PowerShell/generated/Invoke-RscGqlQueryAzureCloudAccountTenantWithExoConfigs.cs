// Invoke-RscGqlQueryAzureCloudAccountTenantWithExoConfigs.cs
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
    /// Invoke GraphQL Query azureCloudAccountTenantWithExoConfigs
    /// azureCloudAccountTenantWithExoConfigs(
    ///     tenantId: UUID!
    ///     feature: CloudAccountFeature!
    ///     subscriptionStatusFilters: [CloudAccountStatus!]!
    ///     subscriptionSearchText: String!
    ///     subscriptionIdsFilter: [UUID!]
    ///   ): AzureCloudAccountTenantWithExoConfigs!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlQueryAzureCloudAccountTenantWithExoConfigs")
    ]
    public class Invoke_RscGqlQueryAzureCloudAccountTenantWithExoConfigs : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("azureCloudAccountTenantWithExoConfigs");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Query azureCloudAccountTenantWithExoConfigs
        /// azureCloudAccountTenantWithExoConfigs(
        ///     tenantId: UUID!
        ///     feature: CloudAccountFeature!
        ///     subscriptionStatusFilters: [CloudAccountStatus!]!
        ///     subscriptionSearchText: String!
        ///     subscriptionIdsFilter: [UUID!]
        ///   ): AzureCloudAccountTenantWithExoConfigs!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_azureCloudAccountTenantWithExoConfigs();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_azureCloudAccountTenantWithExoConfigs()
        {
            this._logger.name += " -azureCloudAccountTenantWithExoConfigs";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "UUID!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("subscriptionStatusFilters", "[CloudAccountStatus!]!"),
                Tuple.Create("subscriptionSearchText", "String!"),
                Tuple.Create("subscriptionIdsFilter", "[UUID!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureCloudAccountTenantWithExoConfigs",
                "($tenantId: UUID!,$feature: CloudAccountFeature!,$subscriptionStatusFilters: [CloudAccountStatus!]!,$subscriptionSearchText: String!,$subscriptionIdsFilter: [UUID!])",
                "AzureCloudAccountTenantWithExoConfigs",
                Query.AzureCloudAccountTenantWithExoConfigs_ObjectFieldSpec,
                Query.AzureCloudAccountTenantWithExoConfigsFieldSpec,
                @"# REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
# REQUIRED
$inputs.Var.subscriptionStatusFilters = @(
	<CloudAccountStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountStatus]) for enum values.
)
# REQUIRED
$inputs.Var.subscriptionSearchText = <System.String>
# OPTIONAL
$inputs.Var.subscriptionIdsFilter = @(
	<System.String>
)"
            );
        }

    } // class Invoke-RscGqlQueryAzureCloudAccountTenantWithExoConfigs
}