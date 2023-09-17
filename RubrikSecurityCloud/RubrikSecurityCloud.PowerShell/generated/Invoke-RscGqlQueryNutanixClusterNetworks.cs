// Invoke-RscGqlQueryNutanixClusterNetworks.cs
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
    /// Invoke GraphQL Query nutanixClusterNetworks
    /// nutanixClusterNetworks(input: GetNutanixNetworksInput!): NutanixNetworkListResponse!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlQueryNutanixClusterNetworks")
    ]
    public class Invoke_RscGqlQueryNutanixClusterNetworks : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("nutanixClusterNetworks");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Query nutanixClusterNetworks
        /// nutanixClusterNetworks(input: GetNutanixNetworksInput!): NutanixNetworkListResponse!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_nutanixClusterNetworks();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_nutanixClusterNetworks()
        {
            this._logger.name += " -nutanixClusterNetworks";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetNutanixNetworksInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryNutanixClusterNetworks",
                "($input: GetNutanixNetworksInput!)",
                "NutanixNetworkListResponse",
                Query.NutanixClusterNetworks_ObjectFieldSpec,
                Query.NutanixClusterNetworksFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class Invoke-RscGqlQueryNutanixClusterNetworks
}