// New-RscGqlQueryAllAzureCloudAccountTenants.cs
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
    /// Create new GraphQL Query allAzureCloudAccountTenants
    /// allAzureCloudAccountTenants(features: [CloudAccountFeature!], feature: CloudAccountFeature!, includeSubscriptionDetails: Boolean!): [AzureCloudAccountTenant!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllAzureCloudAccountTenants")
    ]
    public class New_RscGqlQueryAllAzureCloudAccountTenants : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allAzureCloudAccountTenants");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allAzureCloudAccountTenants
        /// allAzureCloudAccountTenants(features: [CloudAccountFeature!], feature: CloudAccountFeature!, includeSubscriptionDetails: Boolean!): [AzureCloudAccountTenant!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allAzureCloudAccountTenants();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allAzureCloudAccountTenants()
        {
            this._logger.name += " -allAzureCloudAccountTenants";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("features", "[CloudAccountFeature!]"),
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("includeSubscriptionDetails", "Boolean!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureCloudAccountTenants",
                "($features: [CloudAccountFeature!],$feature: CloudAccountFeature!,$includeSubscriptionDetails: Boolean!)",
                "List<AzureCloudAccountTenant>",
                Query.AllAzureCloudAccountTenants_ObjectFieldSpec,
                Query.AllAzureCloudAccountTenantsFieldSpec,
                @"# OPTIONAL
$inputs.Var.features = @(
	<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
)
# REQUIRED
$inputs.Var.feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
# REQUIRED
$inputs.Var.includeSubscriptionDetails = <System.Boolean>"
            );
        }

    } // class New-RscGqlQueryAllAzureCloudAccountTenants
}