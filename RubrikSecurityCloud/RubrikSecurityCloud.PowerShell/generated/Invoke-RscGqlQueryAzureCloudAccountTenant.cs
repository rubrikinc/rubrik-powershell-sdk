// Invoke-RscGqlQueryAzureCloudAccountTenant.cs
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
    /// Invoke GraphQL Query azureCloudAccountTenant
    /// azureCloudAccountTenant(
    ///     tenantId: UUID!
    ///     feature: CloudAccountFeature!
    ///     subscriptionStatusFilters: [CloudAccountStatus!]!
    ///     subscriptionSearchText: String!
    ///     subscriptionIdsFilter: [UUID!]
    ///   ): AzureCloudAccountTenant!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlQueryAzureCloudAccountTenant")
    ]
    public class Invoke_RscGqlQueryAzureCloudAccountTenant : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("azureCloudAccountTenant");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Query azureCloudAccountTenant
        /// azureCloudAccountTenant(
        ///     tenantId: UUID!
        ///     feature: CloudAccountFeature!
        ///     subscriptionStatusFilters: [CloudAccountStatus!]!
        ///     subscriptionSearchText: String!
        ///     subscriptionIdsFilter: [UUID!]
        ///   ): AzureCloudAccountTenant!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_azureCloudAccountTenant();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_azureCloudAccountTenant()
        {
            this._logger.name += " -azureCloudAccountTenant";
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
                "QueryAzureCloudAccountTenant",
                "($tenantId: UUID!,$feature: CloudAccountFeature!,$subscriptionStatusFilters: [CloudAccountStatus!]!,$subscriptionSearchText: String!,$subscriptionIdsFilter: [UUID!])",
                "AzureCloudAccountTenant",
                Query.AzureCloudAccountTenant_ObjectFieldSpec,
                Query.AzureCloudAccountTenantFieldSpec,
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

    } // class Invoke-RscGqlQueryAzureCloudAccountTenant
}