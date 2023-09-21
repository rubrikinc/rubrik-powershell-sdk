// New-RscGqlQueryMssqlDatabaseMissedSnapshots.cs
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
    /// Create new GraphQL Query mssqlDatabaseMissedSnapshots
    /// mssqlDatabaseMissedSnapshots(input: GetMissedMssqlDbSnapshotsInput!): MissedSnapshotListResponse!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryMssqlDatabaseMissedSnapshots")
    ]
    public class New_RscGqlQueryMssqlDatabaseMissedSnapshots : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("mssqlDatabaseMissedSnapshots");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query mssqlDatabaseMissedSnapshots
        /// mssqlDatabaseMissedSnapshots(input: GetMissedMssqlDbSnapshotsInput!): MissedSnapshotListResponse!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_mssqlDatabaseMissedSnapshots();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_mssqlDatabaseMissedSnapshots()
        {
            this._logger.name += " -mssqlDatabaseMissedSnapshots";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetMissedMssqlDbSnapshotsInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMssqlDatabaseMissedSnapshots",
                "($input: GetMissedMssqlDbSnapshotsInput!)",
                "MissedSnapshotListResponse",
                Query.MssqlDatabaseMissedSnapshots_ObjectFieldSpec,
                Query.MssqlDatabaseMissedSnapshotsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	afterTime = <DateTime>
	# OPTIONAL
	beforeTime = <DateTime>
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryMssqlDatabaseMissedSnapshots
}