# New-RscQuerySonar
## Subcommands
### contentreport
Returns groupBy results for SonarContentReport.

- There are 11 arguments.
    - groupBy - DiscoveryContentReportGroupBy
    - sortBy - DiscoveryContentReportSortBy
    - sortOrder - SortOrder: Sorting order for the results.
    - filters - SonarContentReportFilter
    - day - System.String: Day in the format (YYYY-MM-DD).
    - timezone - System.String
    - workloadTypes - list of DataGovObjectTypes: Types of workloads that can be used for filtering query results.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
- Returns SonarContentReportConnection.
### report
Returns groupBy for SonarReport.

- There are 3 arguments.
    - sonarReportGroupBy - DiscoveryReportGroupBy
    - filter - list of System.Strings
    - timeFilter - TimeFilterInput
- Returns SonarReportConnection.
### reportrow
Returns rows for SonarReport table.

- There are 8 arguments.
    - sortBy - DiscoveryReportSortBy
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of System.Strings
    - endTime - System.String
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
- Returns SonarReportRowConnection.
### usergroups
- There are 5 arguments.
    - filter - ListAccessGroupsFilterInput
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
- Returns AccessGroupConnection.
### users
- There are 6 arguments.
    - sort - ListAccessUsersSortInput
    - filter - ListAccessUsersFilterInput
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
- Returns AccessUserConnection.
