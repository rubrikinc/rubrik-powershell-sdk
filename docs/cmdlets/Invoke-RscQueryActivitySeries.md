# Invoke-RscQueryActivitySeries
## Subcommands
### ActivitySeries
Retrieve an activity series.

- The Input parameter takes a single value of type ActivitySeriesInput.
- Returns ActivitySeries.
### GroupByList
- The Input parameter takes a hashtable with 7 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - filters - ActivitySeriesFilterInput
    - first - System.Int32: Returns the first n elements from the list.
    - groupBy - ActivitySeriesGroupByEnum: group activity series by a field
    - last - System.Int32: Returns the last n elements from the list.
    - timezoneOffset - System.Single: Offset based on customer timezone.
- Returns ActivitySeriesGroupByConnection.
### List
- The Input parameter takes a hashtable with 7 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - filters - ActivitySeriesFilter
    - first - System.Int32: Returns the first n elements from the list.
    - last - System.Int32: Returns the last n elements from the list.
    - sortBy - ActivitySeriesSortField: Sort activity series by field.
    - sortOrder - SortOrder: Activity sort order
- Returns ActivitySeriesConnection.
