# New-RscQueryReport
## Subcommands
### clustermigrationcount
Retrieve the counts of the Rubrik cluster reports migration.

- There are 2 arguments.
    - clusterUuid - System.String: The Rubrik cluster ID.
    - status - list of CdmReportMigrationStatuss: Rubrik cluster report migration status.
- Returns ReportsMigrationCount.
### clustermigrationjobstatus
Retrieve the status of the cluster report migration job.

- There is a single argument of type System.String.
- Returns ClusterReportMigrationJobStatus.
### clustermigrationstatus
Retrieve details of the Rubrik clusters' reports migration.

- There are 6 arguments.
    - clusterUuid - System.String: The Rubrik cluster ID.
    - status - list of CdmReportMigrationStatuss: Rubrik cluster report migration status.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
- Returns ReportMigrationStatusConnection.
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
### databaselogforcluster
Get the database log backup delay information

Supported in v5.3+
v5.3: 
v6.0+: Get the database log backup delay information.

- There is a single argument of type QueryLogReportInput.
- Returns DbLogReportSummaryListReply.
### databaselogingpropertiesforcluster
Get the database log backup report properties

Supported in v5.3+
Get the properties for the database (SQL and Oracle) log backup delay email notification creation. The properties are logDelayThresholdInMin and logDelayNotificationFrequencyInMin.

- There is a single argument of type QueryReportPropertiesInput.
- Returns DbLogReportProperties.
### scheduledreport
Retrieve details of a scheduled report.

- There is a single argument of type System.Int32.
- Returns ScheduledReport.
### scheduledreports
Retrieve details of scheduled reports. If the reportId is None, return schedules of all reports. Otherwise, return the schedules of reportId.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - filter - ScheduledReportFilterInput: Filter report schedules.
- Returns ScheduledReportConnection.
### sonar
Returns groupBy for SonarReport.

- There are 3 arguments.
    - sonarReportGroupBy - DiscoveryReportGroupBy
    - filter - list of System.Strings
    - timeFilter - TimeFilterInput
- Returns SonarReportConnection.
### sonarcontent
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
### sonarrow
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
