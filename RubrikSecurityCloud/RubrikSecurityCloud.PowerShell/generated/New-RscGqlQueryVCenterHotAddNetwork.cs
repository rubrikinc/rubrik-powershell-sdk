// New-RscGqlQueryVCenterHotAddNetwork.cs
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
    /// Create new GraphQL Query vCenterHotAddNetwork
    /// vCenterHotAddNetwork(input: GetHotAddNetworkInput!): HotAddNetworkConfigWithName!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryVCenterHotAddNetwork")
    ]
    public class New_RscGqlQueryVCenterHotAddNetwork : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("vCenterHotAddNetwork");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query vCenterHotAddNetwork
        /// vCenterHotAddNetwork(input: GetHotAddNetworkInput!): HotAddNetworkConfigWithName!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_vCenterHotAddNetwork();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_vCenterHotAddNetwork()
        {
            this._logger.name += " -vCenterHotAddNetwork";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetHotAddNetworkInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVcenterHotAddNetwork",
                "($input: GetHotAddNetworkInput!)",
                "HotAddNetworkConfigWithName",
                Query.VcenterHotAddNetwork_ObjectFieldSpec,
                Query.VcenterHotAddNetworkFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryVCenterHotAddNetwork
}