// New-RscGqlQueryClusterFloatingIps.cs
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
    /// Create new GraphQL Query clusterFloatingIps
    /// clusterFloatingIps(input: GetClusterIpsInput!): InternalGetClusterIpsResponse!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryClusterFloatingIps")
    ]
    public class New_RscGqlQueryClusterFloatingIps : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("clusterFloatingIps");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query clusterFloatingIps
        /// clusterFloatingIps(input: GetClusterIpsInput!): InternalGetClusterIpsResponse!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_clusterFloatingIps();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_clusterFloatingIps()
        {
            this._logger.name += " -clusterFloatingIps";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetClusterIpsInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterFloatingIps",
                "($input: GetClusterIpsInput!)",
                "InternalGetClusterIpsResponse",
                Query.ClusterFloatingIps_ObjectFieldSpec,
                Query.ClusterFloatingIpsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryClusterFloatingIps
}