// New-RscGqlMutationArchiveK8sCluster.cs
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
    /// Create new GraphQL Mutation archiveK8sCluster
    /// archiveK8sCluster(input: ArchiveK8sClusterInput!): ArchiveK8sClusterReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationArchiveK8sCluster")
    ]
    public class New_RscGqlMutationArchiveK8sCluster : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("archiveK8sCluster");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation archiveK8sCluster
        /// archiveK8sCluster(input: ArchiveK8sClusterInput!): ArchiveK8sClusterReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_archiveK8sCluster();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_archiveK8sCluster()
        {
            this._logger.name += " -archiveK8sCluster";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ArchiveK8sClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationArchiveK8sCluster",
                "($input: ArchiveK8sClusterInput!)",
                "ArchiveK8sClusterReply",
                Mutation.ArchiveK8sCluster_ObjectFieldSpec,
                Mutation.ArchiveK8sClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterId = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationArchiveK8sCluster
}