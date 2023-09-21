// New-RscGqlMutationDownloadDb2SnapshotsForPointInTimeRecovery.cs
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
    /// Create new GraphQL Mutation downloadDb2SnapshotsForPointInTimeRecovery
    /// downloadDb2SnapshotsForPointInTimeRecovery(input: DownloadDb2SnapshotsForPointInTimeRecoveryInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationDownloadDb2SnapshotsForPointInTimeRecovery")
    ]
    public class New_RscGqlMutationDownloadDb2SnapshotsForPointInTimeRecovery : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("downloadDb2SnapshotsForPointInTimeRecovery");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation downloadDb2SnapshotsForPointInTimeRecovery
        /// downloadDb2SnapshotsForPointInTimeRecovery(input: DownloadDb2SnapshotsForPointInTimeRecoveryInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_downloadDb2SnapshotsForPointInTimeRecovery();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_downloadDb2SnapshotsForPointInTimeRecovery()
        {
            this._logger.name += " -downloadDb2SnapshotsForPointInTimeRecovery";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadDb2SnapshotsForPointInTimeRecoveryInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadDb2SnapshotsForPointInTimeRecovery",
                "($input: DownloadDb2SnapshotsForPointInTimeRecoveryInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadDb2SnapshotsForPointInTimeRecovery_ObjectFieldSpec,
                Mutation.DownloadDb2SnapshotsForPointInTimeRecoveryFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	downloadConfig = @{
		# OPTIONAL
		pointInTime = <DateTime>
		# REQUIRED
		preferredLocationId = <System.String>
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationDownloadDb2SnapshotsForPointInTimeRecovery
}