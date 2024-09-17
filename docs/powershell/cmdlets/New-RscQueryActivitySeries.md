# New-RscQueryActivitySeries
## Subcommands
### activityseries
Retrieve an activity series.

- There is a single argument of type ActivitySeriesInput.
- Returns ActivitySeries.
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
### sessionintimeoutinseconds
The session inactivity timeout in seconds.

- The sessionintimeoutinseconds subcommand takes no arguments.
- Returns System.Int64.
### userfiletimeline
- There are 6 arguments.
    - userId - System.String
    - resource - ResourceInput
    - nativePath - System.String
    - startDay - System.String: Start time, in string format (YYYY-MM-DD).
    - timezone - System.String
    - timeGranularity - TimeGranularity
- Returns ActivityTimelineResultConnection.
### usertimeline
- There are 4 arguments.
    - userId - System.String
    - startDay - System.String: Start time, in string format (YYYY-MM-DD).
    - timezone - System.String
    - uniqueActivities - System.Boolean
- Returns ActivityTimelineResultConnection.
