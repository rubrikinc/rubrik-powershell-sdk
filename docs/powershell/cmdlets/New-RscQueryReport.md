# New-RscQueryReport
## Subcommands
### clouddirecteventseriestask
Retrieves a CSV report of failed file paths for a completed
Cloud Direct job which completed with errors. The report is made available for
download.

- There are 3 arguments.
    - eventSeriesId - System.String: The event series ID for the completed job.
    - clusterId - System.String: The UUID of the cluster.
    - objectId - System.String: The ID of the object whose job has completed.
- Returns CloudDirectEventSeriesTaskReportReply.
### clouddirectjobrecenterrors
Retrieves a CSV report of recent per-file errors for an in-progress
Cloud Direct job. The report is made available for download.

- There are 3 arguments.
    - eventSeriesId - System.String: The event series ID for the job.
    - clusterId - System.String: The UUID of the cluster.
    - objectId - System.String: The ID of the object whose job is running.
- Returns CloudDirectJobRecentErrorsReportReply.
### clustermigrationcount
Retrieve details of the Rubrik clusters' reports migration.

- There are 2 arguments.
    - status - list of CdmReportMigrationStatuss: Rubrik cluster report migration status.
    - clusterUuid - System.String: The Rubrik cluster ID.
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
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
- Returns ReportMigrationStatusConnection.
### custom
Retrieves reports created by users with pagination support.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - filter - CustomReportsFilter: Filter criteria for custom reports.
    - sortBy - CustomReportSortByField: Field used to sort custom reports.
    - sortOrder - SortOrder: Sort order (ascending or descending).
- Returns CustomReportInfoConnection.
### customreports
Retrieve reports created by users.

- There is a single argument of type AllCustomReportsInput.
- Returns list of CustomReportInfos.
### data
- There are 13 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
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
        
    - sortBy - System.String: Name of the column to sort results by.
    - sortOrder - SortOrder: Sorts the order of results.
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
### generateclouddirecttask
GenerateCloudDirectTaskReport generates a task report for failed paths of a Cloud Direct task.

- There is a single argument of type GenerateCloudDirectTaskReportReq.
- Returns GenerateCloudDirectTaskReportReply.
### healthcheckerror
GetHealthCheckErrorReport returns the detailed failure information for
health checks that can have multiple components succeed/fail independently.
The failure information is returned in CSV format.

- There is a single argument of type GetHealthCheckErrorReportReq.
- Returns GetHealthCheckErrorReportReply.
### objects
Get report objects with report-specific filtering and pagination.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - filter - list of ReportObjectFilterInputs: Generic filters for compatibility with existing queries.
    - sortBy - ReportObjectSortByField: Field to sort by.
    - sortOrder - SortOrder: Sort order (ASC/DESC).
- Returns ReportObjectConnection.
### scheduledreport
Retrieve details of a scheduled report.

- There is a single argument of type System.Int32.
- Returns ScheduledReport.
### scheduledreports
Retrieve details of scheduled reports. If the reportId is None, return schedules of all reports. Otherwise, return the schedules of reportId.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - filter - ScheduledReportFilterInput: Filter report schedules.
- Returns ScheduledReportConnection.
### skippedteamssite
GetSkippedTeamsSiteReport returns back a report of the skipped teams
sites for sharepoint bulk recovery.

- There is a single argument of type GetSkippedTeamsSiteReportReq.
- Returns GetSkippedTeamsSiteReportResp.
### sonar
Returns groupBy for SonarReport.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sonarReportGroupBy - DiscoveryReportGroupBy: Group-by field for the report.
    - filter - list of System.Strings: Optional list of policy IDs to filter by.
    - timeFilter - TimeFilterInput: Optional time range filter.
- Returns SonarReportConnection.
### sonarcontent
Returns groupBy results for SonarContentReport.

- There are 11 arguments.
    - groupBy - DiscoveryContentReportGroupBy
    - sortBy - DiscoveryContentReportSortBy
    - sortOrder - SortOrder: Sorts the order of results.
    - filters - SonarContentReportFilter
    - day - System.String: Date in the format (YYYY-MM-DD).
    - timezone - System.String: The timezone in which to display timestamps.
    - workloadTypes - list of DataGovObjectTypes: Types of workloads that can be used for filtering query results.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
- Returns SonarContentReportConnection.
### sonarrow
Endpoints for DC Reports
Returns rows for SonarReport table.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortBy - DiscoveryReportSortBy: Field to sort the report rows by.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of System.Strings: Optional list of policy IDs to filter by.
    - endTime - System.String: Timestamp in RFC3339 (UTC) to filter rows by.
- Returns SonarReportRowConnection.
### templatesbycategories
Retrieve all report templates by category.

- There is a single argument of type AllReportTemplatesByCategoriesInput.
- Returns list of ReportTemplatesByCategorys.
