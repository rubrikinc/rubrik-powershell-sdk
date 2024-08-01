# New-RscQueryActivitySeries
## Subcommands
### activityseries
Retrieve an activity series.

- There is a single argument of type ActivitySeriesInput.
- Returns ActivitySeries.
### browsefilesummaries
Browse file activity summaries.

- There are 10 arguments.
    - timePeriod - TimePeriod: Time period for the activity.
    - filter - BrowseFilesActivitySummariesFilterInput: Browse files activity summaries filter.
    - sortBy - BrowseFilesActivitySummariesSortBy: Field on which to perform the sorting operation.
    - sortOrder - SortOrder: Sort order of result.
    - endTime - DateTime: End time in ISO string format (YYYY-MM-DDThh:mm:ssZ).
    - objectId - System.String: Object ID.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
- Returns FileActivitySummaryConnection.
### browsefileusers
Browse file users activity.

- There are 12 arguments.
    - timePeriod - TimePeriod: Time period for the activity.
    - filter - BrowseFileUsersActivityFilterInput: Browse file users activity filter.
    - sortBy - BrowseFileUsersActivitySortBy: Field on which to perform the sorting operation.
    - sortOrder - SortOrder: Sort order of result.
    - endTime - DateTime: End time in ISO string format (YYYY-MM-DDThh:mm:ssZ).
    - objectId - System.String: Object ID.
    - standardPath - System.String: Standard unix path.
    - indexId - System.String: Index id.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
- Returns BrowseFileUsersActivityResultConnection.
### groupbylist
- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - groupBy - ActivitySeriesGroupByEnum: group activity series by a field
    - filters - ActivitySeriesFilterInput
    - timezoneOffset - System.Single: Offset based on customer timezone.
- Returns ActivitySeriesGroupByConnection.
### list
Paginated list of event series objects. Each page of the results will include at most 50 entries unless otherwise specified using the first parameter. Query the pageInfo.hasNextPage field to know whether all objects were returned.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortOrder - SortOrder: Activity sort order
    - sortBy - ActivitySeriesSortField: Sort activity series by field.
    - filters - ActivitySeriesFilter
- Returns ActivitySeriesConnection.
### objectdetails
Object activity details.

- There are 9 arguments.
    - timePeriod - TimePeriod: Time period for the activity.
    - filter - ObjectActivityDetailsFilterInput: Object activity details filter.
    - endTime - DateTime: End time in ISO string format (YYYY-MM-DDThh:mm:ssZ).
    - sortBy - ListObjectActivityDetailsSortBy: Field on which to perform the sorting operation.
    - sortOrder - SortOrder: Sort order of result.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
- Returns ObjectActivityDetailsConnection.
### objectsummaries
Object activity summaries.

- There are 9 arguments.
    - timePeriod - TimePeriod: Time period for the activity.
    - filter - ObjectActivitySummariesFilterInput: Object activity summaries filter.
    - endTime - DateTime: End time in ISO string format (YYYY-MM-DDThh:mm:ssZ).
    - sortBy - ListObjectActivitySummariesSortBy: Field on which to perform the sorting operation.
    - sortOrder - SortOrder: Sort order of result.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
- Returns ObjectActivitySummariesConnection.
### principalssummarycount
Count of principals in the summary bar.

- There are 3 arguments.
    - timePeriod - TimePeriod: Time period for the activity.
    - filter - PrincipalsActivitySummaryCountFilterInput: Principals activity summary count filter.
    - endTime - DateTime: End time in ISO string format (YYYY-MM-DDThh:mm:ssZ).
- Returns PrincipalsActivitySummaryCountResultType.
### trend
Get activity trend.

- There are 3 arguments.
    - timePeriod - TimePeriod: Time period for the activity.
    - endTime - DateTime: End time in ISO string format (YYYY-MM-DDThh:mm:ssZ).
    - filter - ActivityTrendFilter: Activity trend filter.
- Returns GetActivityTrendResp.
### userfiletimeline
- There are 6 arguments.
    - userId - System.String
    - resource - ResourceInput
    - nativePath - System.String
    - startDay - System.String: Start time, in string format (YYYY-MM-DD).
    - timezone - System.String
    - timeGranularity - TimeGranularity
- Returns ActivityTimelineResultConnection.
### usermetrics
User activity metrics.

- The usermetrics subcommand takes no arguments.
- Returns UserActivityMetrics.
### usersummaries
User activity summaries.

- There are 9 arguments.
    - timePeriod - TimePeriod: Time period for the activity.
    - filter - UserActivitySummariesFilterInput: User activity summaries filter.
    - endTime - DateTime: End time in ISO string format (YYYY-MM-DDThh:mm:ssZ).
    - sort - UserActivityType: Field on which to perform the sorting operation.
    - sortOrder - SortOrder: Sort order of result.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
- Returns UserActivitySummaryConnection.
### usertimeline
- There are 4 arguments.
    - userId - System.String
    - startDay - System.String: Start time, in string format (YYYY-MM-DD).
    - timezone - System.String
    - uniqueActivities - System.Boolean
- Returns ActivityTimelineResultConnection.
