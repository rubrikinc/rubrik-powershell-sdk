// New-RscQueryActivitySeries.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.PowerShell.Private;

// ignore warning 'Missing XML comment'
#pragma warning disable 1591

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Create a new RscQuery object for any of the 4
    /// operations in the 'Activity series' API domain:
    /// ActivitySeries, List, UserFileTimeline, or UserTimeline.
    /// </summary>
    /// <description>
    /// New-RscQueryActivitySeries creates a new
    /// query object for operations
    /// in the 'Activity series' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 4 operations
    /// in the 'Activity series' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: ActivitySeries, List, UserFileTimeline, or UserTimeline.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryActivitySeries -ActivitySeries).Info().
    /// Each operation also has its own set of fields that can be
    /// selected for retrieval. If you do not specify any fields,
    /// a set of default fields will be selected. The selection is
    /// rule-based, and tries to select the most commonly used fields.
    /// For example if a field is named 'id' or 'name', 
    /// it will be selected. If you give -FieldProfile DETAIL, then
    /// another set of rules will be used to select more fields on top
    /// of the default fields. The set of rules for selecting fields
    /// is called a field profile. You can specify a field profile
    /// with the -FieldProfile parameter. You can add or remove fields
    /// from the field profile with the -AddField and -RemoveField
    /// parameters. If you end up with too many -AddField and -RemoveField
    /// parameters, you can list them in a text file, one per line,
    /// with a '+' or '-' prefix, and pass the file name to the
    /// -FilePatch parameter. Profiles and Patches are one way to
    /// customize the fields that are selected. Another way is to
    /// specify the fields by passing the -Field parameter an object
    /// that contains the fields you want to select as properties.
    /// Any property that is not null in that object is interpreted
    /// as a field to select
    /// (and the actual values they are set to do not matter).
    /// The [RubrikSecurityCloud.Types] namespace
    /// contains a set of classes that you can use to specify fields.
    /// To know what [RubrikSecurityCloud.Types] object to use
    /// for a specific operation,
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryActivitySeries -ActivitySeries).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the ActivitySeries operation
    /// of the 'Activity series' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ActivitySeries
    /// # API Operation: ActivitySeries
    /// 
    /// $query = New-RscQueryActivitySeries -ActivitySeries
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	activitySeriesId = $someString
    /// 	# OPTIONAL
    /// 	clusterUuid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ActivitySeries
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the List operation
    /// of the 'Activity series' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ActivitySeries
    /// # API Operation: List
    /// 
    /// $query = New-RscQueryActivitySeries -List
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortBy = $someActivitySeriesSortField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivitySeriesSortField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filters = @{
    /// 	# OPTIONAL
    /// 	lastActivityStatus = @(
    /// 		$someEventStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventStatus]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	lastActivityType = @(
    /// 		$someEventType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventType]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	severity = @(
    /// 		$someEventSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventSeverity]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	objectName = $someString
    /// 	# OPTIONAL
    /// 	objectType = @(
    /// 		$someEventObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventObjectType]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	startTimeGt = $someDateTime
    /// 	# OPTIONAL
    /// 	startTimeLt = $someDateTime
    /// 	# OPTIONAL
    /// 	lastUpdatedTimeGt = $someDateTime
    /// 	# OPTIONAL
    /// 	lastUpdatedTimeLt = $someDateTime
    /// 	# OPTIONAL
    /// 	clusterId = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	clusterType = @(
    /// 		$someEventClusterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventClusterType]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	objectFid = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	ancestorId = $someString
    /// 	# OPTIONAL
    /// 	searchTerm = $someString
    /// 	# OPTIONAL
    /// 	orgIds = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ActivitySeriesConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UserFileTimeline operation
    /// of the 'Activity series' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ActivitySeries
    /// # API Operation: UserFileTimeline
    /// 
    /// $query = New-RscQueryActivitySeries -UserFileTimeline
    /// 
    /// # REQUIRED
    /// $query.Var.userId = $someString
    /// # OPTIONAL
    /// $query.Var.resource = @{
    /// 	# OPTIONAL
    /// 	snappableFid = $someString
    /// 	# OPTIONAL
    /// 	snapshotFid = $someString
    /// }
    /// # REQUIRED
    /// $query.Var.nativePath = $someString
    /// # REQUIRED
    /// $query.Var.startDay = $someString
    /// # REQUIRED
    /// $query.Var.timezone = $someString
    /// # REQUIRED
    /// $query.Var.timeGranularity = $someTimeGranularity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TimeGranularity]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ActivityTimelineResultConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UserTimeline operation
    /// of the 'Activity series' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ActivitySeries
    /// # API Operation: UserTimeline
    /// 
    /// $query = New-RscQueryActivitySeries -UserTimeline
    /// 
    /// # REQUIRED
    /// $query.Var.userId = $someString
    /// # REQUIRED
    /// $query.Var.startDay = $someString
    /// # REQUIRED
    /// $query.Var.timezone = $someString
    /// # REQUIRED
    /// $query.Var.uniqueActivities = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ActivityTimelineResultConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscQueryActivitySeries",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQueryActivitySeries : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "ActivitySeries",
                "List",
                "UserFileTimeline",
                "UserTimeline",
                IgnoreCase = true)]
        public string Operation { get; set; } = "";

        internal override string GetOperationParameter()
        {
            return this.Operation;
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(this.GetOp().OpName())
                {
                    case "ActivitySeries":
                        this.ProcessRecord_ActivitySeries();
                        break;
                    case "List":
                        this.ProcessRecord_List();
                        break;
                    case "UserFileTimeline":
                        this.ProcessRecord_UserFileTimeline();
                        break;
                    case "UserTimeline":
                        this.ProcessRecord_UserTimeline();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + this.GetOp().OpName());
                }
           }
           catch (Exception ex)
           {
                ThrowTerminatingException(ex);
           }
        }

        // This parameter set invokes a single graphql operation:
        // activitySeries.
        internal void ProcessRecord_ActivitySeries()
        {
            this._logger.name += " -ActivitySeries";
            // Create new graphql operation activitySeries
            InitQueryActivitySeries();
        }

        // This parameter set invokes a single graphql operation:
        // activitySeriesConnection.
        internal void ProcessRecord_List()
        {
            this._logger.name += " -List";
            // Create new graphql operation activitySeriesConnection
            InitQueryActivitySeriesConnection();
        }

        // This parameter set invokes a single graphql operation:
        // userFileActivityTimeline.
        internal void ProcessRecord_UserFileTimeline()
        {
            this._logger.name += " -UserFileTimeline";
            // Create new graphql operation userFileActivityTimeline
            InitQueryUserFileActivityTimeline();
        }

        // This parameter set invokes a single graphql operation:
        // userActivityTimeline.
        internal void ProcessRecord_UserTimeline()
        {
            this._logger.name += " -UserTimeline";
            // Create new graphql operation userActivityTimeline
            InitQueryUserActivityTimeline();
        }


        // Create new GraphQL Query:
        // activitySeries(input: ActivitySeriesInput!): ActivitySeries!
        internal void InitQueryActivitySeries()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ActivitySeriesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryActivitySeries",
                "($input: ActivitySeriesInput!)",
                "ActivitySeries",
                Query.ActivitySeries,
                Query.ActivitySeriesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	activitySeriesId = $someString
	# OPTIONAL
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // activitySeriesConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortOrder: SortOrder
        //     sortBy: ActivitySeriesSortField
        //     filters: ActivitySeriesFilter
        //   ): ActivitySeriesConnection!
        internal void InitQueryActivitySeriesConnection()
        {
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
                Query.ActivitySeriesConnection,
                Query.ActivitySeriesConnectionFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.sortBy = $someActivitySeriesSortField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivitySeriesSortField]) for enum values.
# OPTIONAL
$query.Var.filters = @{
	# OPTIONAL
	lastActivityStatus = @(
		$someEventStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventStatus]) for enum values.
	)
	# OPTIONAL
	lastActivityType = @(
		$someEventType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventType]) for enum values.
	)
	# OPTIONAL
	severity = @(
		$someEventSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventSeverity]) for enum values.
	)
	# OPTIONAL
	objectName = $someString
	# OPTIONAL
	objectType = @(
		$someEventObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventObjectType]) for enum values.
	)
	# OPTIONAL
	startTimeGt = $someDateTime
	# OPTIONAL
	startTimeLt = $someDateTime
	# OPTIONAL
	lastUpdatedTimeGt = $someDateTime
	# OPTIONAL
	lastUpdatedTimeLt = $someDateTime
	# OPTIONAL
	clusterId = @(
		$someString
	)
	# OPTIONAL
	clusterType = @(
		$someEventClusterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventClusterType]) for enum values.
	)
	# OPTIONAL
	objectFid = @(
		$someString
	)
	# OPTIONAL
	ancestorId = $someString
	# OPTIONAL
	searchTerm = $someString
	# OPTIONAL
	orgIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Query:
        // userFileActivityTimeline(
        //     userId: String!
        //     resource: ResourceInput
        //     nativePath: String!
        //     startDay: String!
        //     timezone: String!
        //     timeGranularity: TimeGranularity!
        //   ): ActivityTimelineResultConnection!
        internal void InitQueryUserFileActivityTimeline()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("userId", "String!"),
                Tuple.Create("resource", "ResourceInput"),
                Tuple.Create("nativePath", "String!"),
                Tuple.Create("startDay", "String!"),
                Tuple.Create("timezone", "String!"),
                Tuple.Create("timeGranularity", "TimeGranularity!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryUserFileActivityTimeline",
                "($userId: String!,$resource: ResourceInput,$nativePath: String!,$startDay: String!,$timezone: String!,$timeGranularity: TimeGranularity!)",
                "ActivityTimelineResultConnection",
                Query.UserFileActivityTimeline,
                Query.UserFileActivityTimelineFieldSpec,
                @"# REQUIRED
$query.Var.userId = $someString
# OPTIONAL
$query.Var.resource = @{
	# OPTIONAL
	snappableFid = $someString
	# OPTIONAL
	snapshotFid = $someString
}
# REQUIRED
$query.Var.nativePath = $someString
# REQUIRED
$query.Var.startDay = $someString
# REQUIRED
$query.Var.timezone = $someString
# REQUIRED
$query.Var.timeGranularity = $someTimeGranularity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TimeGranularity]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // userActivityTimeline(
        //     userId: String!
        //     startDay: String!
        //     timezone: String!
        //     uniqueActivities: Boolean!
        //   ): ActivityTimelineResultConnection!
        internal void InitQueryUserActivityTimeline()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("userId", "String!"),
                Tuple.Create("startDay", "String!"),
                Tuple.Create("timezone", "String!"),
                Tuple.Create("uniqueActivities", "Boolean!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryUserActivityTimeline",
                "($userId: String!,$startDay: String!,$timezone: String!,$uniqueActivities: Boolean!)",
                "ActivityTimelineResultConnection",
                Query.UserActivityTimeline,
                Query.UserActivityTimelineFieldSpec,
                @"# REQUIRED
$query.Var.userId = $someString
# REQUIRED
$query.Var.startDay = $someString
# REQUIRED
$query.Var.timezone = $someString
# REQUIRED
$query.Var.uniqueActivities = $someBoolean"
            );
        }


    } // class New_RscQueryActivitySeries
}