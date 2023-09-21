// New-RscGqlQueryAllClusterReplicationTargets.cs
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
    /// Create new GraphQL Query allClusterReplicationTargets
    /// allClusterReplicationTargets(clusterUuid: UUID!): [ClusterReplicationTarget!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllClusterReplicationTargets")
    ]
    public class New_RscGqlQueryAllClusterReplicationTargets : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allClusterReplicationTargets");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allClusterReplicationTargets
        /// allClusterReplicationTargets(clusterUuid: UUID!): [ClusterReplicationTarget!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allClusterReplicationTargets();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allClusterReplicationTargets()
        {
            this._logger.name += " -allClusterReplicationTargets";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllClusterReplicationTargets",
                "($clusterUuid: UUID!)",
                "List<ClusterReplicationTarget>",
                Query.AllClusterReplicationTargets_ObjectFieldSpec,
                Query.AllClusterReplicationTargetsFieldSpec,
                @"# REQUIRED
$inputs.Var.clusterUuid = <System.String>"
            );
        }

    } // class New-RscGqlQueryAllClusterReplicationTargets
}