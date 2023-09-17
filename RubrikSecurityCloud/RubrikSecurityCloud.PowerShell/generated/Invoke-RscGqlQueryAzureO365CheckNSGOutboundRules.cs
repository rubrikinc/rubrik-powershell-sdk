// Invoke-RscGqlQueryAzureO365CheckNSGOutboundRules.cs
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
    /// Invoke GraphQL Query azureO365CheckNSGOutboundRules
    /// azureO365CheckNSGOutboundRules(
    ///     tenantId: String!
    ///     subscriptionId: UUID!
    ///     resourceGroupName: String!
    ///     vnet_name: String!
    ///     subnet_name: String!
    ///   ): AzureNetworkSecurityGroupResp!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlQueryAzureO365CheckNSGOutboundRules")
    ]
    public class Invoke_RscGqlQueryAzureO365CheckNSGOutboundRules : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("azureO365CheckNSGOutboundRules");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Query azureO365CheckNSGOutboundRules
        /// azureO365CheckNSGOutboundRules(
        ///     tenantId: String!
        ///     subscriptionId: UUID!
        ///     resourceGroupName: String!
        ///     vnet_name: String!
        ///     subnet_name: String!
        ///   ): AzureNetworkSecurityGroupResp!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_azureO365CheckNSGOutboundRules();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_azureO365CheckNSGOutboundRules()
        {
            this._logger.name += " -azureO365CheckNSGOutboundRules";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("resourceGroupName", "String!"),
                Tuple.Create("vnet_name", "String!"),
                Tuple.Create("subnet_name", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureO365CheckNsgOutboundRules",
                "($tenantId: String!,$subscriptionId: UUID!,$resourceGroupName: String!,$vnet_name: String!,$subnet_name: String!)",
                "AzureNetworkSecurityGroupResp",
                Query.AzureO365CheckNsgOutboundRules_ObjectFieldSpec,
                Query.AzureO365CheckNsgOutboundRulesFieldSpec,
                @"# REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.resourceGroupName = <System.String>
# REQUIRED
$inputs.Var.vnet_name = <System.String>
# REQUIRED
$inputs.Var.subnet_name = <System.String>"
            );
        }

    } // class Invoke-RscGqlQueryAzureO365CheckNSGOutboundRules
}