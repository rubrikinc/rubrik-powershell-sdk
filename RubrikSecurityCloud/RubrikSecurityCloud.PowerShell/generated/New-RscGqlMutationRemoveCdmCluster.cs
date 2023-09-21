// New-RscGqlMutationRemoveCdmCluster.cs
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
    /// Create new GraphQL Mutation removeCdmCluster
    /// removeCdmCluster(clusterUUID: UUID!, isForce: Boolean!, expireInDays: Long): Boolean!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationRemoveCdmCluster")
    ]
    public class New_RscGqlMutationRemoveCdmCluster : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("removeCdmCluster");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation removeCdmCluster
        /// removeCdmCluster(clusterUUID: UUID!, isForce: Boolean!, expireInDays: Long): Boolean!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_removeCdmCluster();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_removeCdmCluster()
        {
            this._logger.name += " -removeCdmCluster";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUUID", "UUID!"),
                Tuple.Create("isForce", "Boolean!"),
                Tuple.Create("expireInDays", "Long"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRemoveCdmCluster",
                "($clusterUUID: UUID!,$isForce: Boolean!,$expireInDays: Long)",
                "System.Boolean",
                Mutation.RemoveCdmCluster_ObjectFieldSpec,
                Mutation.RemoveCdmClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.clusterUUID = <System.String>
# REQUIRED
$inputs.Var.isForce = <System.Boolean>
# OPTIONAL
$inputs.Var.expireInDays = <System.Int64>"
            );
        }

    } // class New-RscGqlMutationRemoveCdmCluster
}