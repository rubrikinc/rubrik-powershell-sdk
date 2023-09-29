# New-RscQueryReport
## Subcommands
### data
- There are 13 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - dataView - DataViewTypeEnum
    - columns - list of System.Strings: A list of columns to include in the result. It can be omitted when
           requesting aggregations, and server will derive columns by
           concatenating groupBy and aggregation arguments.
        
    - filters - list of ReportFilterInputs: A list of filters to filter result with
    - groupBy - list of System.Strings: A list of the names of the columns to group result by, it must be
           used in conjunction of aggregations.
        
    - secondaryGroupBy - System.String: SecondaryGroupBy used for when groupBy values need to be pivoted.
        
    - aggregations - list of System.Strings: A list of aggregations to apply to the grouped rows, it must be used
           in conjunction with groupBy arg (except for count(*)). Supported
           aggregations are:
           hour, day, week, month, year for datetime columns
           sum, avg for integer columns
           count(*)
        
    - sortBy - System.String: Name of the column to sort result by
    - sortOrder - SortOrder: Sorting order for the results.
    - timezone - System.String: The timezone to be used in the results.
- Returns RowConnection.
### scheduled
Retrieve details of a scheduled report.

- There is a single argument of type System.Int32.
- Returns ScheduledReport.
