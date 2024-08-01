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
    /// Create a new RscQuery object for any of the 13
    /// operations in the 'Activity series' API domain:
    /// ActivitySeries, BrowseFileSummaries, BrowseFileUsers, GroupByList, List, ObjectDetails, ObjectSummaries, PrincipalsSummaryCount, Trend, UserFileTimeline, UserMetrics, UserSummaries, or UserTimeline.
    /// </summary>
    /// <description>
    /// New-RscQueryActivitySeries creates a new
    /// query object for operations
    /// in the 'Activity series' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 13 operations
    /// in the 'Activity series' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: ActivitySeries, BrowseFileSummaries, BrowseFileUsers, GroupByList, List, ObjectDetails, ObjectSummaries, PrincipalsSummaryCount, Trend, UserFileTimeline, UserMetrics, UserSummaries, or UserTimeline.
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
    /// Runs the BrowseFileSummaries operation
    /// of the 'Activity series' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ActivitySeries
    /// # API Operation: BrowseFileSummaries
    /// 
    /// $query = New-RscQueryActivitySeries -BrowseFileSummaries
    /// 
    /// # REQUIRED
    /// $query.Var.timePeriod = $someTimePeriod # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TimePeriod]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	sid = $someString
    /// 	# OPTIONAL
    /// 	policyIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	searchText = $someString
    /// 	# OPTIONAL
    /// 	userActivityType = $someUserActivityType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserActivityType]) for enum values.
    /// }
    /// # OPTIONAL
    /// $query.Var.sortBy = $someBrowseFilesActivitySummariesSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BrowseFilesActivitySummariesSortBy]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # REQUIRED
    /// $query.Var.endTime = $someDateTime
    /// # REQUIRED
    /// $query.Var.objectId = $someString
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: FileActivitySummaryConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BrowseFileUsers operation
    /// of the 'Activity series' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ActivitySeries
    /// # API Operation: BrowseFileUsers
    /// 
    /// $query = New-RscQueryActivitySeries -BrowseFileUsers
    /// 
    /// # REQUIRED
    /// $query.Var.timePeriod = $someTimePeriod # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TimePeriod]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	userActivityType = $someUserActivityType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserActivityType]) for enum values.
    /// }
    /// # OPTIONAL
    /// $query.Var.sortBy = $someBrowseFileUsersActivitySortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BrowseFileUsersActivitySortBy]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # REQUIRED
    /// $query.Var.endTime = $someDateTime
    /// # REQUIRED
    /// $query.Var.objectId = $someString
    /// # REQUIRED
    /// $query.Var.standardPath = $someString
    /// # OPTIONAL
    /// $query.Var.indexId = $someString
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BrowseFileUsersActivityResultConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the GroupByList operation
    /// of the 'Activity series' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ActivitySeries
    /// # API Operation: GroupByList
    /// 
    /// $query = New-RscQueryActivitySeries -GroupByList
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # REQUIRED
    /// $query.Var.groupBy = $someActivitySeriesGroupByEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivitySeriesGroupByEnum]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filters = @{
    /// 	# OPTIONAL
    /// 	lastActivityStatus = @(
    /// 		$someActivityStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityStatusEnum]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	lastActivityType = @(
    /// 		$someActivityTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityTypeEnum]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	severity = @(
    /// 		$someActivitySeverityEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivitySeverityEnum]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	objectName = $someString
    /// 	# OPTIONAL
    /// 	objectType = @(
    /// 		$someActivityObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityObjectTypeEnum]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	startTimeGt = $someDateTime
    /// 	# OPTIONAL
    /// 	startTimeLt = $someDateTime
    /// 	# OPTIONAL
    /// 	lastUpdatedGt = $someDateTime
    /// 	# OPTIONAL
    /// 	lastUpdatedLt = $someDateTime
    /// 	# OPTIONAL
    /// 	cluster = @{
    /// 		# OPTIONAL
    /// 		id = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		type = @(
    /// 			$someClusterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterTypeEnum]) for enum values.
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	objectFids = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	ancestorId = $someString
    /// 	# OPTIONAL
    /// 	searchTerm = $someString
    /// }
    /// # OPTIONAL
    /// $query.Var.timezoneOffset = $someSingle
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ActivitySeriesGroupByConnection
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
    /// 	# OPTIONAL
    /// 	userIds = @(
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
    /// Runs the ObjectDetails operation
    /// of the 'Activity series' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ActivitySeries
    /// # API Operation: ObjectDetails
    /// 
    /// $query = New-RscQueryActivitySeries -ObjectDetails
    /// 
    /// # REQUIRED
    /// $query.Var.timePeriod = $someTimePeriod # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TimePeriod]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	sid = $someString
    /// 	# OPTIONAL
    /// 	policyId = $someString
    /// 	# OPTIONAL
    /// 	objectIds = @(
    /// 		$someString
    /// 	)
    /// }
    /// # REQUIRED
    /// $query.Var.endTime = $someDateTime
    /// # OPTIONAL
    /// $query.Var.sortBy = $someListObjectActivityDetailsSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ListObjectActivityDetailsSortBy]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ObjectActivityDetailsConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ObjectSummaries operation
    /// of the 'Activity series' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ActivitySeries
    /// # API Operation: ObjectSummaries
    /// 
    /// $query = New-RscQueryActivitySeries -ObjectSummaries
    /// 
    /// # REQUIRED
    /// $query.Var.timePeriod = $someTimePeriod # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TimePeriod]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	objectIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	sid = $someString
    /// 	# OPTIONAL
    /// 	policyId = $someString
    /// 	# OPTIONAL
    /// 	searchStrForObjectName = $someString
    /// 	# OPTIONAL
    /// 	userActivityType = $someUserActivityType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserActivityType]) for enum values.
    /// 	# OPTIONAL
    /// 	risk = $someRiskLevelType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RiskLevelType]) for enum values.
    /// }
    /// # REQUIRED
    /// $query.Var.endTime = $someDateTime
    /// # OPTIONAL
    /// $query.Var.sortBy = $someListObjectActivitySummariesSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ListObjectActivitySummariesSortBy]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ObjectActivitySummariesConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the PrincipalsSummaryCount operation
    /// of the 'Activity series' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ActivitySeries
    /// # API Operation: PrincipalsSummaryCount
    /// 
    /// $query = New-RscQueryActivitySeries -PrincipalsSummaryCount
    /// 
    /// # REQUIRED
    /// $query.Var.timePeriod = $someTimePeriod # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TimePeriod]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	groupId = $someString
    /// 	# OPTIONAL
    /// 	objectId = $someString
    /// 	# OPTIONAL
    /// 	policyId = $someString
    /// 	# OPTIONAL
    /// 	userRisk = $someRiskLevelType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RiskLevelType]) for enum values.
    /// 	# OPTIONAL
    /// 	principalSummaryCategory = $somePrincipalSummaryCategory # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PrincipalSummaryCategory]) for enum values.
    /// 	# OPTIONAL
    /// 	userActivityType = $someUserActivityType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserActivityType]) for enum values.
    /// }
    /// # REQUIRED
    /// $query.Var.endTime = $someDateTime
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: PrincipalsActivitySummaryCountResultType
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Trend operation
    /// of the 'Activity series' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ActivitySeries
    /// # API Operation: Trend
    /// 
    /// $query = New-RscQueryActivitySeries -Trend
    /// 
    /// # REQUIRED
    /// $query.Var.timePeriod = $someTimePeriod # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TimePeriod]) for enum values.
    /// # REQUIRED
    /// $query.Var.endTime = $someDateTime
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	sid = $someString
    /// 	# OPTIONAL
    /// 	policyId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GetActivityTrendResp
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
    /// Runs the UserMetrics operation
    /// of the 'Activity series' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ActivitySeries
    /// # API Operation: UserMetrics
    /// 
    /// $query = New-RscQueryActivitySeries -UserMetrics
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UserActivityMetrics
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UserSummaries operation
    /// of the 'Activity series' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ActivitySeries
    /// # API Operation: UserSummaries
    /// 
    /// $query = New-RscQueryActivitySeries -UserSummaries
    /// 
    /// # REQUIRED
    /// $query.Var.timePeriod = $someTimePeriod # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TimePeriod]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	userNamePrefix = $someString
    /// 	# OPTIONAL
    /// 	objectId = $someString
    /// 	# OPTIONAL
    /// 	groupId = $someString
    /// 	# OPTIONAL
    /// 	policyId = $someString
    /// 	# REQUIRED
    /// 	userRisk = $someRiskLevelType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RiskLevelType]) for enum values.
    /// 	# REQUIRED
    /// 	principalSummaryCategory = $somePrincipalSummaryCategory # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PrincipalSummaryCategory]) for enum values.
    /// 	# OPTIONAL
    /// 	userActivityType = $someUserActivityType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserActivityType]) for enum values.
    /// }
    /// # REQUIRED
    /// $query.Var.endTime = $someDateTime
    /// # OPTIONAL
    /// $query.Var.sort = $someUserActivityType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserActivityType]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UserActivitySummaryConnection
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
                "BrowseFileSummaries",
                "BrowseFileUsers",
                "GroupByList",
                "List",
                "ObjectDetails",
                "ObjectSummaries",
                "PrincipalsSummaryCount",
                "Trend",
                "UserFileTimeline",
                "UserMetrics",
                "UserSummaries",
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
                    case "BrowseFileSummaries":
                        this.ProcessRecord_BrowseFileSummaries();
                        break;
                    case "BrowseFileUsers":
                        this.ProcessRecord_BrowseFileUsers();
                        break;
                    case "GroupByList":
                        this.ProcessRecord_GroupByList();
                        break;
                    case "List":
                        this.ProcessRecord_List();
                        break;
                    case "ObjectDetails":
                        this.ProcessRecord_ObjectDetails();
                        break;
                    case "ObjectSummaries":
                        this.ProcessRecord_ObjectSummaries();
                        break;
                    case "PrincipalsSummaryCount":
                        this.ProcessRecord_PrincipalsSummaryCount();
                        break;
                    case "Trend":
                        this.ProcessRecord_Trend();
                        break;
                    case "UserFileTimeline":
                        this.ProcessRecord_UserFileTimeline();
                        break;
                    case "UserMetrics":
                        this.ProcessRecord_UserMetrics();
                        break;
                    case "UserSummaries":
                        this.ProcessRecord_UserSummaries();
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
        // browseFileActivitySummaries.
        internal void ProcessRecord_BrowseFileSummaries()
        {
            this._logger.name += " -BrowseFileSummaries";
            // Create new graphql operation browseFileActivitySummaries
            InitQueryBrowseFileActivitySummaries();
        }

        // This parameter set invokes a single graphql operation:
        // browseFileUsersActivity.
        internal void ProcessRecord_BrowseFileUsers()
        {
            this._logger.name += " -BrowseFileUsers";
            // Create new graphql operation browseFileUsersActivity
            InitQueryBrowseFileUsersActivity();
        }

        // This parameter set invokes a single graphql operation:
        // activitySeriesGroupByConnection.
        internal void ProcessRecord_GroupByList()
        {
            this._logger.name += " -GroupByList";
            // Create new graphql operation activitySeriesGroupByConnection
            InitQueryActivitySeriesGroupByConnection();
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
        // objectActivityDetails.
        internal void ProcessRecord_ObjectDetails()
        {
            this._logger.name += " -ObjectDetails";
            // Create new graphql operation objectActivityDetails
            InitQueryObjectActivityDetails();
        }

        // This parameter set invokes a single graphql operation:
        // objectActivitySummaries.
        internal void ProcessRecord_ObjectSummaries()
        {
            this._logger.name += " -ObjectSummaries";
            // Create new graphql operation objectActivitySummaries
            InitQueryObjectActivitySummaries();
        }

        // This parameter set invokes a single graphql operation:
        // principalsActivitySummaryCount.
        internal void ProcessRecord_PrincipalsSummaryCount()
        {
            this._logger.name += " -PrincipalsSummaryCount";
            // Create new graphql operation principalsActivitySummaryCount
            InitQueryPrincipalsActivitySummaryCount();
        }

        // This parameter set invokes a single graphql operation:
        // activityTrend.
        internal void ProcessRecord_Trend()
        {
            this._logger.name += " -Trend";
            // Create new graphql operation activityTrend
            InitQueryActivityTrend();
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
        // userActivityMetrics.
        internal void ProcessRecord_UserMetrics()
        {
            this._logger.name += " -UserMetrics";
            // Create new graphql operation userActivityMetrics
            InitQueryUserActivityMetrics();
        }

        // This parameter set invokes a single graphql operation:
        // userActivitySummaries.
        internal void ProcessRecord_UserSummaries()
        {
            this._logger.name += " -UserSummaries";
            // Create new graphql operation userActivitySummaries
            InitQueryUserActivitySummaries();
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
        // browseFileActivitySummaries(
        //     timePeriod: TimePeriod!
        //     filter: BrowseFilesActivitySummariesFilterInput
        //     sortBy: BrowseFilesActivitySummariesSortBy
        //     sortOrder: SortOrder
        //     endTime: DateTime!
        //     objectId: String!
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //   ): FileActivitySummaryConnection!
        internal void InitQueryBrowseFileActivitySummaries()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("timePeriod", "TimePeriod!"),
                Tuple.Create("filter", "BrowseFilesActivitySummariesFilterInput"),
                Tuple.Create("sortBy", "BrowseFilesActivitySummariesSortBy"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("endTime", "DateTime!"),
                Tuple.Create("objectId", "String!"),
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryBrowseFileActivitySummaries",
                "($timePeriod: TimePeriod!,$filter: BrowseFilesActivitySummariesFilterInput,$sortBy: BrowseFilesActivitySummariesSortBy,$sortOrder: SortOrder,$endTime: DateTime!,$objectId: String!,$first: Int,$after: String,$last: Int,$before: String)",
                "FileActivitySummaryConnection",
                Query.BrowseFileActivitySummaries,
                Query.BrowseFileActivitySummariesFieldSpec,
                @"# REQUIRED
$query.Var.timePeriod = $someTimePeriod # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TimePeriod]) for enum values.
# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	sid = $someString
	# OPTIONAL
	policyIds = @(
		$someString
	)
	# OPTIONAL
	searchText = $someString
	# OPTIONAL
	userActivityType = $someUserActivityType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserActivityType]) for enum values.
}
# OPTIONAL
$query.Var.sortBy = $someBrowseFilesActivitySummariesSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BrowseFilesActivitySummariesSortBy]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# REQUIRED
$query.Var.endTime = $someDateTime
# REQUIRED
$query.Var.objectId = $someString
# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString"
            );
        }

        // Create new GraphQL Query:
        // browseFileUsersActivity(
        //     timePeriod: TimePeriod!
        //     filter: BrowseFileUsersActivityFilterInput
        //     sortBy: BrowseFileUsersActivitySortBy
        //     sortOrder: SortOrder
        //     endTime: DateTime!
        //     objectId: String!
        //     standardPath: String!
        //     indexId: String
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //   ): BrowseFileUsersActivityResultConnection!
        internal void InitQueryBrowseFileUsersActivity()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("timePeriod", "TimePeriod!"),
                Tuple.Create("filter", "BrowseFileUsersActivityFilterInput"),
                Tuple.Create("sortBy", "BrowseFileUsersActivitySortBy"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("endTime", "DateTime!"),
                Tuple.Create("objectId", "String!"),
                Tuple.Create("standardPath", "String!"),
                Tuple.Create("indexId", "String"),
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryBrowseFileUsersActivity",
                "($timePeriod: TimePeriod!,$filter: BrowseFileUsersActivityFilterInput,$sortBy: BrowseFileUsersActivitySortBy,$sortOrder: SortOrder,$endTime: DateTime!,$objectId: String!,$standardPath: String!,$indexId: String,$first: Int,$after: String,$last: Int,$before: String)",
                "BrowseFileUsersActivityResultConnection",
                Query.BrowseFileUsersActivity,
                Query.BrowseFileUsersActivityFieldSpec,
                @"# REQUIRED
$query.Var.timePeriod = $someTimePeriod # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TimePeriod]) for enum values.
# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	userActivityType = $someUserActivityType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserActivityType]) for enum values.
}
# OPTIONAL
$query.Var.sortBy = $someBrowseFileUsersActivitySortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BrowseFileUsersActivitySortBy]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# REQUIRED
$query.Var.endTime = $someDateTime
# REQUIRED
$query.Var.objectId = $someString
# REQUIRED
$query.Var.standardPath = $someString
# OPTIONAL
$query.Var.indexId = $someString
# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString"
            );
        }

        // Create new GraphQL Query:
        // activitySeriesGroupByConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     groupBy: ActivitySeriesGroupByEnum!
        //     filters: ActivitySeriesFilterInput
        //     timezoneOffset: Float = 0.0
        //   ): ActivitySeriesGroupByConnection!
        internal void InitQueryActivitySeriesGroupByConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("groupBy", "ActivitySeriesGroupByEnum!"),
                Tuple.Create("filters", "ActivitySeriesFilterInput"),
                Tuple.Create("timezoneOffset", "Float"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryActivitySeriesGroupByConnection",
                "($first: Int,$after: String,$last: Int,$before: String,$groupBy: ActivitySeriesGroupByEnum!,$filters: ActivitySeriesFilterInput,$timezoneOffset: Float)",
                "ActivitySeriesGroupByConnection",
                Query.ActivitySeriesGroupByConnection,
                Query.ActivitySeriesGroupByConnectionFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# REQUIRED
$query.Var.groupBy = $someActivitySeriesGroupByEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivitySeriesGroupByEnum]) for enum values.
# OPTIONAL
$query.Var.filters = @{
	# OPTIONAL
	lastActivityStatus = @(
		$someActivityStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityStatusEnum]) for enum values.
	)
	# OPTIONAL
	lastActivityType = @(
		$someActivityTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityTypeEnum]) for enum values.
	)
	# OPTIONAL
	severity = @(
		$someActivitySeverityEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivitySeverityEnum]) for enum values.
	)
	# OPTIONAL
	objectName = $someString
	# OPTIONAL
	objectType = @(
		$someActivityObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityObjectTypeEnum]) for enum values.
	)
	# OPTIONAL
	startTimeGt = $someDateTime
	# OPTIONAL
	startTimeLt = $someDateTime
	# OPTIONAL
	lastUpdatedGt = $someDateTime
	# OPTIONAL
	lastUpdatedLt = $someDateTime
	# OPTIONAL
	cluster = @{
		# OPTIONAL
		id = @(
			$someString
		)
		# OPTIONAL
		type = @(
			$someClusterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterTypeEnum]) for enum values.
		)
	}
	# OPTIONAL
	objectFids = @(
		$someString
	)
	# OPTIONAL
	ancestorId = $someString
	# OPTIONAL
	searchTerm = $someString
}
# OPTIONAL
$query.Var.timezoneOffset = $someSingle"
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
	# OPTIONAL
	userIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Query:
        // objectActivityDetails(
        //     timePeriod: TimePeriod!
        //     filter: ObjectActivityDetailsFilterInput
        //     endTime: DateTime!
        //     sortBy: ListObjectActivityDetailsSortBy
        //     sortOrder: SortOrder
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //   ): ObjectActivityDetailsConnection!
        internal void InitQueryObjectActivityDetails()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("timePeriod", "TimePeriod!"),
                Tuple.Create("filter", "ObjectActivityDetailsFilterInput"),
                Tuple.Create("endTime", "DateTime!"),
                Tuple.Create("sortBy", "ListObjectActivityDetailsSortBy"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryObjectActivityDetails",
                "($timePeriod: TimePeriod!,$filter: ObjectActivityDetailsFilterInput,$endTime: DateTime!,$sortBy: ListObjectActivityDetailsSortBy,$sortOrder: SortOrder,$first: Int,$after: String,$last: Int,$before: String)",
                "ObjectActivityDetailsConnection",
                Query.ObjectActivityDetails,
                Query.ObjectActivityDetailsFieldSpec,
                @"# REQUIRED
$query.Var.timePeriod = $someTimePeriod # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TimePeriod]) for enum values.
# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	sid = $someString
	# OPTIONAL
	policyId = $someString
	# OPTIONAL
	objectIds = @(
		$someString
	)
}
# REQUIRED
$query.Var.endTime = $someDateTime
# OPTIONAL
$query.Var.sortBy = $someListObjectActivityDetailsSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ListObjectActivityDetailsSortBy]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString"
            );
        }

        // Create new GraphQL Query:
        // objectActivitySummaries(
        //     timePeriod: TimePeriod!
        //     filter: ObjectActivitySummariesFilterInput
        //     endTime: DateTime!
        //     sortBy: ListObjectActivitySummariesSortBy
        //     sortOrder: SortOrder
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //   ): ObjectActivitySummariesConnection!
        internal void InitQueryObjectActivitySummaries()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("timePeriod", "TimePeriod!"),
                Tuple.Create("filter", "ObjectActivitySummariesFilterInput"),
                Tuple.Create("endTime", "DateTime!"),
                Tuple.Create("sortBy", "ListObjectActivitySummariesSortBy"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryObjectActivitySummaries",
                "($timePeriod: TimePeriod!,$filter: ObjectActivitySummariesFilterInput,$endTime: DateTime!,$sortBy: ListObjectActivitySummariesSortBy,$sortOrder: SortOrder,$first: Int,$after: String,$last: Int,$before: String)",
                "ObjectActivitySummariesConnection",
                Query.ObjectActivitySummaries,
                Query.ObjectActivitySummariesFieldSpec,
                @"# REQUIRED
$query.Var.timePeriod = $someTimePeriod # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TimePeriod]) for enum values.
# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	objectIds = @(
		$someString
	)
	# OPTIONAL
	sid = $someString
	# OPTIONAL
	policyId = $someString
	# OPTIONAL
	searchStrForObjectName = $someString
	# OPTIONAL
	userActivityType = $someUserActivityType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserActivityType]) for enum values.
	# OPTIONAL
	risk = $someRiskLevelType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RiskLevelType]) for enum values.
}
# REQUIRED
$query.Var.endTime = $someDateTime
# OPTIONAL
$query.Var.sortBy = $someListObjectActivitySummariesSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ListObjectActivitySummariesSortBy]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString"
            );
        }

        // Create new GraphQL Query:
        // principalsActivitySummaryCount(timePeriod: TimePeriod!, filter: PrincipalsActivitySummaryCountFilterInput, endTime: DateTime!): PrincipalsActivitySummaryCountResultType!
        internal void InitQueryPrincipalsActivitySummaryCount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("timePeriod", "TimePeriod!"),
                Tuple.Create("filter", "PrincipalsActivitySummaryCountFilterInput"),
                Tuple.Create("endTime", "DateTime!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryPrincipalsActivitySummaryCount",
                "($timePeriod: TimePeriod!,$filter: PrincipalsActivitySummaryCountFilterInput,$endTime: DateTime!)",
                "PrincipalsActivitySummaryCountResultType",
                Query.PrincipalsActivitySummaryCount,
                Query.PrincipalsActivitySummaryCountFieldSpec,
                @"# REQUIRED
$query.Var.timePeriod = $someTimePeriod # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TimePeriod]) for enum values.
# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	groupId = $someString
	# OPTIONAL
	objectId = $someString
	# OPTIONAL
	policyId = $someString
	# OPTIONAL
	userRisk = $someRiskLevelType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RiskLevelType]) for enum values.
	# OPTIONAL
	principalSummaryCategory = $somePrincipalSummaryCategory # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PrincipalSummaryCategory]) for enum values.
	# OPTIONAL
	userActivityType = $someUserActivityType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserActivityType]) for enum values.
}
# REQUIRED
$query.Var.endTime = $someDateTime"
            );
        }

        // Create new GraphQL Query:
        // activityTrend(timePeriod: TimePeriod!, endTime: DateTime!, filter: ActivityTrendFilter): GetActivityTrendResp!
        internal void InitQueryActivityTrend()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("timePeriod", "TimePeriod!"),
                Tuple.Create("endTime", "DateTime!"),
                Tuple.Create("filter", "ActivityTrendFilter"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryActivityTrend",
                "($timePeriod: TimePeriod!,$endTime: DateTime!,$filter: ActivityTrendFilter)",
                "GetActivityTrendResp",
                Query.ActivityTrend,
                Query.ActivityTrendFieldSpec,
                @"# REQUIRED
$query.Var.timePeriod = $someTimePeriod # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TimePeriod]) for enum values.
# REQUIRED
$query.Var.endTime = $someDateTime
# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	sid = $someString
	# OPTIONAL
	policyId = $someString
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
        // userActivityMetrics: UserActivityMetrics!
        internal void InitQueryUserActivityMetrics()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryUserActivityMetrics",
                "",
                "UserActivityMetrics",
                Query.UserActivityMetrics,
                Query.UserActivityMetricsFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // userActivitySummaries(
        //     timePeriod: TimePeriod!
        //     filter: UserActivitySummariesFilterInput
        //     endTime: DateTime!
        //     sort: UserActivityType
        //     sortOrder: SortOrder
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //   ): UserActivitySummaryConnection!
        internal void InitQueryUserActivitySummaries()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("timePeriod", "TimePeriod!"),
                Tuple.Create("filter", "UserActivitySummariesFilterInput"),
                Tuple.Create("endTime", "DateTime!"),
                Tuple.Create("sort", "UserActivityType"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryUserActivitySummaries",
                "($timePeriod: TimePeriod!,$filter: UserActivitySummariesFilterInput,$endTime: DateTime!,$sort: UserActivityType,$sortOrder: SortOrder,$first: Int,$after: String,$last: Int,$before: String)",
                "UserActivitySummaryConnection",
                Query.UserActivitySummaries,
                Query.UserActivitySummariesFieldSpec,
                @"# REQUIRED
$query.Var.timePeriod = $someTimePeriod # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TimePeriod]) for enum values.
# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	userNamePrefix = $someString
	# OPTIONAL
	objectId = $someString
	# OPTIONAL
	groupId = $someString
	# OPTIONAL
	policyId = $someString
	# REQUIRED
	userRisk = $someRiskLevelType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RiskLevelType]) for enum values.
	# REQUIRED
	principalSummaryCategory = $somePrincipalSummaryCategory # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PrincipalSummaryCategory]) for enum values.
	# OPTIONAL
	userActivityType = $someUserActivityType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserActivityType]) for enum values.
}
# REQUIRED
$query.Var.endTime = $someDateTime
# OPTIONAL
$query.Var.sort = $someUserActivityType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserActivityType]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString"
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