// New-RscGqlQueryClusterVlans.cs
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
    /// Create new GraphQL Query clusterVlans
    /// clusterVlans(input: GetVlanInput!): VlanConfigListResponse!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryClusterVlans")
    ]
    public class New_RscGqlQueryClusterVlans : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("clusterVlans");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query clusterVlans
        /// clusterVlans(input: GetVlanInput!): VlanConfigListResponse!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_clusterVlans();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_clusterVlans()
        {
            this._logger.name += " -clusterVlans";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetVlanInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterVlans",
                "($input: GetVlanInput!)",
                "VlanConfigListResponse",
                Query.ClusterVlans_ObjectFieldSpec,
                Query.ClusterVlansFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	vlan = <System.Int32>
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryClusterVlans
}