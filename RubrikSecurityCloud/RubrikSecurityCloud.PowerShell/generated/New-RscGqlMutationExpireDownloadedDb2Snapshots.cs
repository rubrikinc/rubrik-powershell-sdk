// New-RscGqlMutationExpireDownloadedDb2Snapshots.cs
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
    /// Create new GraphQL Mutation expireDownloadedDb2Snapshots
    /// expireDownloadedDb2Snapshots(input: ExpireDownloadedDb2SnapshotsInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationExpireDownloadedDb2Snapshots")
    ]
    public class New_RscGqlMutationExpireDownloadedDb2Snapshots : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("expireDownloadedDb2Snapshots");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation expireDownloadedDb2Snapshots
        /// expireDownloadedDb2Snapshots(input: ExpireDownloadedDb2SnapshotsInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_expireDownloadedDb2Snapshots();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_expireDownloadedDb2Snapshots()
        {
            this._logger.name += " -expireDownloadedDb2Snapshots";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExpireDownloadedDb2SnapshotsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExpireDownloadedDb2Snapshots",
                "($input: ExpireDownloadedDb2SnapshotsInput!)",
                "AsyncRequestStatus",
                Mutation.ExpireDownloadedDb2Snapshots_ObjectFieldSpec,
                Mutation.ExpireDownloadedDb2SnapshotsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	afterTime = <DateTime>
	# OPTIONAL
	beforeTime = <DateTime>
	# OPTIONAL
	shouldExpireLogsOnly = <System.Boolean>
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationExpireDownloadedDb2Snapshots
}