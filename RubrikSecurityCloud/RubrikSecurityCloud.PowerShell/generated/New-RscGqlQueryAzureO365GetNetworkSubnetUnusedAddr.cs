// New-RscGqlQueryAzureO365GetNetworkSubnetUnusedAddr.cs
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
    /// Create new GraphQL Query azureO365GetNetworkSubnetUnusedAddr
    /// azureO365GetNetworkSubnetUnusedAddr(
    ///     tenantId: String!
    ///     subscriptionId: UUID!
    ///     resourceGroupName: String!
    ///     vnet_name: String!
    ///     subnet_name: String!
    ///     strict_addr_check: Boolean!
    ///   ): AzureNetworkSubnetUnusedAddrResp!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAzureO365GetNetworkSubnetUnusedAddr")
    ]
    public class New_RscGqlQueryAzureO365GetNetworkSubnetUnusedAddr : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("azureO365GetNetworkSubnetUnusedAddr");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query azureO365GetNetworkSubnetUnusedAddr
        /// azureO365GetNetworkSubnetUnusedAddr(
        ///     tenantId: String!
        ///     subscriptionId: UUID!
        ///     resourceGroupName: String!
        ///     vnet_name: String!
        ///     subnet_name: String!
        ///     strict_addr_check: Boolean!
        ///   ): AzureNetworkSubnetUnusedAddrResp!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_azureO365GetNetworkSubnetUnusedAddr();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_azureO365GetNetworkSubnetUnusedAddr()
        {
            this._logger.name += " -azureO365GetNetworkSubnetUnusedAddr";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("resourceGroupName", "String!"),
                Tuple.Create("vnet_name", "String!"),
                Tuple.Create("subnet_name", "String!"),
                Tuple.Create("strict_addr_check", "Boolean!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureO365GetNetworkSubnetUnusedAddr",
                "($tenantId: String!,$subscriptionId: UUID!,$resourceGroupName: String!,$vnet_name: String!,$subnet_name: String!,$strict_addr_check: Boolean!)",
                "AzureNetworkSubnetUnusedAddrResp",
                Query.AzureO365GetNetworkSubnetUnusedAddr_ObjectFieldSpec,
                Query.AzureO365GetNetworkSubnetUnusedAddrFieldSpec,
                @"# REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.resourceGroupName = <System.String>
# REQUIRED
$inputs.Var.vnet_name = <System.String>
# REQUIRED
$inputs.Var.subnet_name = <System.String>
# REQUIRED
$inputs.Var.strict_addr_check = <System.Boolean>"
            );
        }

    } // class New-RscGqlQueryAzureO365GetNetworkSubnetUnusedAddr
}