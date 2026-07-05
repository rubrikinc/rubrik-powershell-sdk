# New-RscQueryActivitySeries
## Subcommands
### activityseries
Retrieve an activity series.

- There is a single argument of type ActivitySeriesInput.
- Returns ActivitySeries.
### crowdstrikealertsummary
Compact actor summary for a single CrowdStrike alert.

- There is a single argument of type System.String.
- Returns CrowdstrikeAlertActivitySummary.
### crowdstrikecasesummary
Compact case-level actor summary across the alerts that compose a
CrowdStrike incident.

- There is a single argument of type list of System.Strings.
- Returns CrowdstrikeCaseActivitySummary.
### list
Paginated list of event series objects. Each page of the results will include at most 50 entries unless otherwise specified using the first parameter. Query the pageInfo.hasNextPage field to know whether all objects were returned.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortOrder - SortOrder: Activity sort order
    - sortBy - ActivitySeriesSortField: Sort activity series by field.
    - filters - ActivitySeriesFilter
- Returns ActivitySeriesConnection.
### sessionintimeoutinseconds
The session inactivity timeout in seconds for the authenticated user.

- The sessionintimeoutinseconds subcommand takes no arguments.
- Returns System.Int64.
### userfiletimeline
Returns a paginated timeline of a single user's access activity on a
specific file, bucketed by the requested time granularity.

- There are 10 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - userId - System.String: Stable identifier of the user.
    - resource - ResourceInput: Snapshot identifier of the workload containing the file. Optional; when absent the latest available snapshot is used.
    - nativePath - System.String: Native (filesystem-relative) path of the file.
    - startDay - System.String: Day to anchor the timeline window, in YYYY-MM-DD format.
    - timezone - System.String: Official IANA timezone name.
    - timeGranularity - TimeGranularity: Time-bucket granularity for the returned timeline entries.
- Returns ActivityTimelineResultConnection.
### usertimeline
Returns a paginated timeline of a user's data access activity, aggregated
per day over the requested window.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - userId - System.String: Stable identifier of the user.
    - startDay - System.String: Day to anchor the timeline window, in YYYY-MM-DD format.
    - timezone - System.String: Official IANA timezone name.
    - uniqueActivities - System.Boolean: When true, collapse identical activities to a single entry per day.
- Returns ActivityTimelineResultConnection.
