# New-RscMutationReport
## Subcommands
### createscheduled
Create a scheduled report.

- There is a single argument of type CreateScheduledReportInput.
- Returns CreateScheduledReportReply.
### deletecustom
Delete a custom report.

- There is a single argument of type DeleteCustomReportInput.
- Returns System.String.
### deletescheduledreport
Delete a scheduled report.

- There is a single argument of type DeleteScheduledReportInput.
- Returns System.String.
### sendpdf
DHRC PDF report generation.

- There is a single argument of type SendPdfReportInput.
- Returns SendPdfReportReply.
### sendscheduledreportasync
Send a scheduled report now asynchronously via email.

- There is a single argument of type SendScheduledReportAsyncInput.
- Returns AsyncDownloadReply.
### startclustermigrationjob
Start a job to migrate reports from Rubrik cluster to RSC.

- There is a single argument of type StartClusterReportMigrationJobInput.
- Returns StartClusterReportMigrationJobReply.
### updatedatabaselogingpropertiesforcluster
Update the database log backup report properties

Supported in v5.3+
Update the properties for the database (SQL and Oracle) log backup delay email notification creation. The properties are logDelayThresholdInMin and logDelayNotificationFrequencyInMin.

- There is a single argument of type UpdateDatabaseLogReportingPropertiesForClusterInput.
- Returns DbLogReportProperties.
### updatescheduledreport
Update a scheduled report.

- There is a single argument of type UpdateScheduledReportInput.
- Returns UpdateScheduledReportReply.
