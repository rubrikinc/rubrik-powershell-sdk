# Invoke-RscQueryActivitySeries
## Subcommands
### activityseries
Retrieve an activity series.

- There is a single argument of type ActivitySeriesInput.
- Returns ActivitySeries.
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
- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortOrder - SortOrder: Activity sort order
    - sortBy - ActivitySeriesSortField: Sort activity series by field.
    - filters - ActivitySeriesFilter
- Returns ActivitySeriesConnection.
