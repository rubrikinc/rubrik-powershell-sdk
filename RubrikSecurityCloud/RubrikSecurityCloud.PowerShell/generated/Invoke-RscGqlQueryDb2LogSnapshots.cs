// Invoke-RscGqlQueryDb2LogSnapshots.cs
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
    /// Invoke GraphQL Query db2LogSnapshots
    /// db2LogSnapshots(
    ///     first: Int
    ///     after: String
    ///     last: Int
    ///     before: String
    ///     sortOrder: SortOrder
    ///     sortBy: Db2LogSnapshotSortBy
    ///     filter: Db2LogSnapshotFilterInput
    ///   ): Db2LogSnapshotConnection!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlQueryDb2LogSnapshots")
    ]
    public class Invoke_RscGqlQueryDb2LogSnapshots : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("db2LogSnapshots");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Query db2LogSnapshots
        /// db2LogSnapshots(
        ///     first: Int
        ///     after: String
        ///     last: Int
        ///     before: String
        ///     sortOrder: SortOrder
        ///     sortBy: Db2LogSnapshotSortBy
        ///     filter: Db2LogSnapshotFilterInput
        ///   ): Db2LogSnapshotConnection!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_db2LogSnapshots();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_db2LogSnapshots()
        {
            this._logger.name += " -db2LogSnapshots";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("sortBy", "Db2LogSnapshotSortBy"),
                Tuple.Create("filter", "Db2LogSnapshotFilterInput"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryDb2LogSnapshots",
                "($first: Int,$after: String,$last: Int,$before: String,$sortOrder: SortOrder,$sortBy: Db2LogSnapshotSortBy,$filter: Db2LogSnapshotFilterInput)",
                "Db2LogSnapshotConnection",
                Query.Db2LogSnapshots_ObjectFieldSpec,
                Query.Db2LogSnapshotsFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.sortBy = <Db2LogSnapshotSortBy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Db2LogSnapshotSortBy]) for enum values.
# OPTIONAL
$inputs.Var.filter = @{
	# OPTIONAL
	workloadId = @(
		<System.String>
	)
	# OPTIONAL
	clusterUuid = @(
		<System.String>
	)
	# OPTIONAL
	fromTime = <DateTime>
	# OPTIONAL
	toTime = <DateTime>
	# OPTIONAL
	isArchived = <System.Boolean>
}"
            );
        }

    } // class Invoke-RscGqlQueryDb2LogSnapshots
}