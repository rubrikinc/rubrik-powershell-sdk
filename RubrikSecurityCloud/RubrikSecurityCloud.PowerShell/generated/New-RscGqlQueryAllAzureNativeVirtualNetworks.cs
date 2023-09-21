// New-RscGqlQueryAllAzureNativeVirtualNetworks.cs
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
    /// Create new GraphQL Query allAzureNativeVirtualNetworks
    /// allAzureNativeVirtualNetworks(azureSubscriptionRubrikId: UUID): [AzureNativeVirtualNetwork!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllAzureNativeVirtualNetworks")
    ]
    public class New_RscGqlQueryAllAzureNativeVirtualNetworks : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allAzureNativeVirtualNetworks");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allAzureNativeVirtualNetworks
        /// allAzureNativeVirtualNetworks(azureSubscriptionRubrikId: UUID): [AzureNativeVirtualNetwork!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allAzureNativeVirtualNetworks();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allAzureNativeVirtualNetworks()
        {
            this._logger.name += " -allAzureNativeVirtualNetworks";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureNativeVirtualNetworks",
                "($azureSubscriptionRubrikId: UUID)",
                "List<AzureNativeVirtualNetwork>",
                Query.AllAzureNativeVirtualNetworks_ObjectFieldSpec,
                Query.AllAzureNativeVirtualNetworksFieldSpec,
                @"# OPTIONAL
$inputs.Var.azureSubscriptionRubrikId = <System.String>"
            );
        }

    } // class New-RscGqlQueryAllAzureNativeVirtualNetworks
}