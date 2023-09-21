// New-RscGqlQueryCluster.cs
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
    /// Create new GraphQL Query cluster
    /// cluster(clusterUuid: UUID!): Cluster!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryCluster")
    ]
    public class New_RscGqlQueryCluster : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("cluster");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query cluster
        /// cluster(clusterUuid: UUID!): Cluster!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_cluster();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_cluster()
        {
            this._logger.name += " -cluster";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCluster",
                "($clusterUuid: UUID!)",
                "Cluster",
                Query.Cluster_ObjectFieldSpec,
                Query.ClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.clusterUuid = <System.String>"
            );
        }

    } // class New-RscGqlQueryCluster
}