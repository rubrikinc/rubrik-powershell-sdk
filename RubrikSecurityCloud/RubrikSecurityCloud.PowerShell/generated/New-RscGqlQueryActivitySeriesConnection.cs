// New-RscGqlQueryActivitySeriesConnection.cs
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
    /// Create new GraphQL Query activitySeriesConnection
    /// activitySeriesConnection(
    ///     first: Int
    ///     after: String
    ///     last: Int
    ///     before: String
    ///     sortOrder: SortOrder
    ///     sortBy: ActivitySeriesSortField
    ///     filters: ActivitySeriesFilter
    ///   ): ActivitySeriesConnection!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryActivitySeriesConnection")
    ]
    public class New_RscGqlQueryActivitySeriesConnection : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("activitySeriesConnection");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query activitySeriesConnection
        /// activitySeriesConnection(
        ///     first: Int
        ///     after: String
        ///     last: Int
        ///     before: String
        ///     sortOrder: SortOrder
        ///     sortBy: ActivitySeriesSortField
        ///     filters: ActivitySeriesFilter
        ///   ): ActivitySeriesConnection!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_activitySeriesConnection();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_activitySeriesConnection()
        {
            this._logger.name += " -activitySeriesConnection";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("sortBy", "ActivitySeriesSortField"),
                Tuple.Create("filters", "ActivitySeriesFilter"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryActivitySeriesConnection",
                "($first: Int,$after: String,$last: Int,$before: String,$sortOrder: SortOrder,$sortBy: ActivitySeriesSortField,$filters: ActivitySeriesFilter)",
                "ActivitySeriesConnection",
                Query.ActivitySeriesConnection_ObjectFieldSpec,
                Query.ActivitySeriesConnectionFieldSpec,
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
$inputs.Var.sortBy = <ActivitySeriesSortField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivitySeriesSortField]) for enum values.
# OPTIONAL
$inputs.Var.filters = @{
	# OPTIONAL
	lastActivityStatus = @(
		<EventStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventStatus]) for enum values.
	)
	# OPTIONAL
	lastActivityType = @(
		<EventType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventType]) for enum values.
	)
	# OPTIONAL
	severity = @(
		<EventSeverity> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventSeverity]) for enum values.
	)
	# OPTIONAL
	objectName = <System.String>
	# OPTIONAL
	objectType = @(
		<EventObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventObjectType]) for enum values.
	)
	# OPTIONAL
	startTimeGt = <DateTime>
	# OPTIONAL
	startTimeLt = <DateTime>
	# OPTIONAL
	lastUpdatedTimeGt = <DateTime>
	# OPTIONAL
	lastUpdatedTimeLt = <DateTime>
	# OPTIONAL
	clusterId = @(
		<System.String>
	)
	# OPTIONAL
	clusterType = @(
		<EventClusterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventClusterType]) for enum values.
	)
	# OPTIONAL
	objectFid = @(
		<System.String>
	)
	# OPTIONAL
	ancestorId = <System.String>
	# OPTIONAL
	searchTerm = <System.String>
	# OPTIONAL
	orgIds = @(
		<System.String>
	)
}"
            );
        }

    } // class New-RscGqlQueryActivitySeriesConnection
}