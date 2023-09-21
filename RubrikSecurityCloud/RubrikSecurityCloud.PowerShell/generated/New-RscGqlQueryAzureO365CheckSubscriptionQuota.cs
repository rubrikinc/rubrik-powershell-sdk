// New-RscGqlQueryAzureO365CheckSubscriptionQuota.cs
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
    /// Create new GraphQL Query azureO365CheckSubscriptionQuota
    /// azureO365CheckSubscriptionQuota(tenantId: String!, subscriptionId: UUID!, regionName: String!): AzureResourceAvailabilityResp!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAzureO365CheckSubscriptionQuota")
    ]
    public class New_RscGqlQueryAzureO365CheckSubscriptionQuota : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("azureO365CheckSubscriptionQuota");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query azureO365CheckSubscriptionQuota
        /// azureO365CheckSubscriptionQuota(tenantId: String!, subscriptionId: UUID!, regionName: String!): AzureResourceAvailabilityResp!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_azureO365CheckSubscriptionQuota();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_azureO365CheckSubscriptionQuota()
        {
            this._logger.name += " -azureO365CheckSubscriptionQuota";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("regionName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureO365CheckSubscriptionQuota",
                "($tenantId: String!,$subscriptionId: UUID!,$regionName: String!)",
                "AzureResourceAvailabilityResp",
                Query.AzureO365CheckSubscriptionQuota_ObjectFieldSpec,
                Query.AzureO365CheckSubscriptionQuotaFieldSpec,
                @"# REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.regionName = <System.String>"
            );
        }

    } // class New-RscGqlQueryAzureO365CheckSubscriptionQuota
}