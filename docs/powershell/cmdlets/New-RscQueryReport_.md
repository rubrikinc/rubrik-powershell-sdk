# New-RscQueryReport
## Subcommands
### chartdata
Report chart data.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - chartView - ChartViewType: Type of the chart view.
    - reportRoom - ReportRoomType: Room of the report view.
    - filters - list of ReportFilterInputs: A list of filters to filter result with
    - timezone - System.String: The timezone to be used in the results.
- Returns ChartDataResult.
### chema
- There are 2 arguments.
    - dataView - DataViewTypeEnum
    - timezone - System.String: The timezone to be used in the results.
- Returns ReportSchema.
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
### config
- There is a single argument of type System.Int32.
- Returns ReportConfig.
### configs
- There are 3 arguments.
    - dataView - DataViewTypeEnum
    - searchTerm - System.String: Search term to be used for testing all the report names.
    - createdBy - System.String: ID of the report creator.
- Returns list of ReportConfigs.
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
        
    - sortBy - System.String: Name of the column to sort results by.
    - sortOrder - SortOrder: Sort order of result.
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
### failover
The report for the failover job.

- There is a single argument of type System.String.
- Returns FailoverReport.
### failoverjob
Failover job reports.

- There are 2 arguments.
    - fid - System.String: The Rubrik UUID for the object.
    - recoveryJobID - System.String: The recovery job ID.
- Returns list of FailoverJobReports.
### fromconfig
- There is a single argument of type CustomReportCreate.
- Returns CustomReport.
### generatenasmigration
Generate NAS migration report.

- There are 3 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - hostIds - list of System.Strings: Host UUIDs to generate the migration report for.
- Returns NasMigrationHostDetailConnection.
### groupbylist
- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - groupBy - CustomReportGroupByEnum: group by field
    - filter - CustomReportFilterInput: filter custom reports by input
- Returns CustomReportGroupByConnection.
### list
- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortOrder - SortOrder: Sort order of result.
    - sortBy - CustomReportSortByEnum: sort by field
    - filter - CustomReportFilterInput: filter custom reports by input
- Returns CustomReportConnection.
### metadata
NG version report metadata.

- There are 2 arguments.
    - searchTerm - System.String: Search term to be used for testing all the report names.
    - polarisReportsFilters - list of PolarisReportsFilterInputs: A list of filters for CustomReports.
- Returns list of ReportMetadatas.
### polarischema
The structure of a Polaris Report.

- There are 2 arguments.
    - polarisReportViewType - PolarisReportViewType
    - reportRoom - ReportRoomType: Room of the report view.
- Returns PolarisReportSchema.
### polarisconfig
The saved configurations of a report.

- There is a single argument of type System.Int32.
- Returns PolarisReportConfig.
### polaristableintrospection
The structure of a Polaris Report Table.

- There are 3 arguments.
    - tableView - TableViewType: Type of the table view.
    - reportRoom - ReportRoomType: Room of the report view.
    - reportId - System.Int32: The report ID.
- Returns PolarisReportTableIntrospection.
### report
- There is a single argument of type System.Int32.
- Returns CustomReport.
### rscconfigs
A list of report configurations.

- There is a single argument of type list of PolarisReportsFilterInputs.
- Returns list of PolarisReportConfigs.
### s3bucketsnapshotdownloadurl
URL which contains the summary details of the objects which are part of the snapshot.

- There are 2 arguments.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - snapshotId - System.String: UUID of the snapshot.
- Returns S3BucketDownloadUrlReply.
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
### screenshot
- There is a single argument of type System.String.
- Returns TakeScreenshotReply.
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
    - sortOrder - SortOrder: Sort order of result.
    - filters - SonarContentReportFilter
    - day - System.String: Date in the format (YYYY-MM-DD).
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
    - sortOrder - SortOrder: Sort order of result.
    - filter - list of System.Strings
    - endTime - System.String
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
- Returns SonarReportRowConnection.
### tabledata
Report table data.

- There are 10 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - tableView - TableViewType: Type of the table view.
    - reportRoom - ReportRoomType: Room of the report view.
    - filters - list of ReportFilterInputs: A list of filters to filter result with
    - sortBy - System.String: Name of the column to sort results by.
    - sortOrder - SortOrder: Sort order of result.
    - timezone - System.String: The timezone to be used in the results.
- Returns RowConnection.
### trial
Returns the report metrics for the specified trial.

- There is a single argument of type System.String.
- Returns TrialReport.
### trialdownloadurl
Returns a URL to download the trial report. The link is valid for 30 minutes.

- There is a single argument of type System.String.
- Returns TrialReportDownloadUrl.
### version
The report version.

- There is a single argument of type System.Int32.
- Returns ReportVersion.
