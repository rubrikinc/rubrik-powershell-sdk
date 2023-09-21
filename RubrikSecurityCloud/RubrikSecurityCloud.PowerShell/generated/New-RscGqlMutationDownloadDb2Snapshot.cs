// New-RscGqlMutationDownloadDb2Snapshot.cs
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
    /// Create new GraphQL Mutation downloadDb2Snapshot
    /// downloadDb2Snapshot(input: DownloadDb2SnapshotInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationDownloadDb2Snapshot")
    ]
    public class New_RscGqlMutationDownloadDb2Snapshot : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("downloadDb2Snapshot");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation downloadDb2Snapshot
        /// downloadDb2Snapshot(input: DownloadDb2SnapshotInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_downloadDb2Snapshot();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_downloadDb2Snapshot()
        {
            this._logger.name += " -downloadDb2Snapshot";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadDb2SnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadDb2Snapshot",
                "($input: DownloadDb2SnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadDb2Snapshot_ObjectFieldSpec,
                Mutation.DownloadDb2SnapshotFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	locationId = <System.String>
	# REQUIRED
	snapshotId = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationDownloadDb2Snapshot
}