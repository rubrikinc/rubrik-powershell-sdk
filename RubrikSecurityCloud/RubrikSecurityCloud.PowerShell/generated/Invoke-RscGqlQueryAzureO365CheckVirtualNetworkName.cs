// Invoke-RscGqlQueryAzureO365CheckVirtualNetworkName.cs
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
    /// Invoke GraphQL Query azureO365CheckVirtualNetworkName
    /// azureO365CheckVirtualNetworkName(
    ///     tenantId: String!
    ///     subscriptionId: UUID!
    ///     groupName: String!
    ///     vnet_name: String!
    ///   ): AzureResourceAvailabilityResp!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlQueryAzureO365CheckVirtualNetworkName")
    ]
    public class Invoke_RscGqlQueryAzureO365CheckVirtualNetworkName : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("azureO365CheckVirtualNetworkName");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Query azureO365CheckVirtualNetworkName
        /// azureO365CheckVirtualNetworkName(
        ///     tenantId: String!
        ///     subscriptionId: UUID!
        ///     groupName: String!
        ///     vnet_name: String!
        ///   ): AzureResourceAvailabilityResp!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_azureO365CheckVirtualNetworkName();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_azureO365CheckVirtualNetworkName()
        {
            this._logger.name += " -azureO365CheckVirtualNetworkName";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("groupName", "String!"),
                Tuple.Create("vnet_name", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureO365CheckVirtualNetworkName",
                "($tenantId: String!,$subscriptionId: UUID!,$groupName: String!,$vnet_name: String!)",
                "AzureResourceAvailabilityResp",
                Query.AzureO365CheckVirtualNetworkName_ObjectFieldSpec,
                Query.AzureO365CheckVirtualNetworkNameFieldSpec,
                @"# REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.groupName = <System.String>
# REQUIRED
$inputs.Var.vnet_name = <System.String>"
            );
        }

    } // class Invoke-RscGqlQueryAzureO365CheckVirtualNetworkName
}