// New-RscGqlMutationDownloadOracleDatabaseSnapshot.cs
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
    /// Create new GraphQL Mutation downloadOracleDatabaseSnapshot
    /// downloadOracleDatabaseSnapshot(input: DownloadOracleDatabaseSnapshotInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationDownloadOracleDatabaseSnapshot")
    ]
    public class New_RscGqlMutationDownloadOracleDatabaseSnapshot : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("downloadOracleDatabaseSnapshot");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation downloadOracleDatabaseSnapshot
        /// downloadOracleDatabaseSnapshot(input: DownloadOracleDatabaseSnapshotInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_downloadOracleDatabaseSnapshot();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_downloadOracleDatabaseSnapshot()
        {
            this._logger.name += " -downloadOracleDatabaseSnapshot";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadOracleDatabaseSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadOracleDatabaseSnapshot",
                "($input: DownloadOracleDatabaseSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadOracleDatabaseSnapshot_ObjectFieldSpec,
                Mutation.DownloadOracleDatabaseSnapshotFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snapshotId = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationDownloadOracleDatabaseSnapshot
}