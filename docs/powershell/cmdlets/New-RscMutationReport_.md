# New-RscMutationReport
## Subcommands
### blueprintfailovergenerate
- There is a single argument of type BlueprintFailoverReportGeneratorJobInfo.
- Returns CreateOnDemandJobReply.
### create
- There is a single argument of type ReportConfigInput.
- Returns System.Int32.
### createcustom
Create a custom report.

- There are 2 arguments.
    - input - CreateCustomReportInput
    - reportRoom - System.String: Room of the report.
- Returns CreateCustomReportReply.
### createpolaris
Create a new report with the specified configuration.

- There is a single argument of type CreatePolarisReportInput.
- Returns CreatePolarisReportReply.
### createscheduled
Create a scheduled report.

- There is a single argument of type CreateScheduledReportInput.
- Returns CreateScheduledReportReply.
### delete
- There is a single argument of type System.Int32.
- Returns System.String.
### deletecustom
Delete a custom report.

- There is a single argument of type DeleteCustomReportInput.
- Returns System.String.
### deletescheduledreport
Delete a scheduled report.

- There is a single argument of type DeleteScheduledReportInput.
- Returns System.String.
### refreshtrial
Refreshes the trial reports to have up-to-date values. The metrics contained in the report can be up to 4 hours stale.

- There is a single argument of type RefreshTrialReportsInput.
- Returns System.String.
### sendpdf
DHRC PDF report generation.

- There is a single argument of type SendPdfReportInput.
- Returns SendPdfReportReply.
### sendscheduled
Send a scheduled report via email. Returns true if the report was sent successfully, false otherwise.

- There is a single argument of type SendScheduledReportInput.
- Returns System.Boolean.
### sendscheduledreportasync
Send a scheduled report now asynchronously via email.

- There is a single argument of type SendScheduledReportAsyncInput.
- Returns AsyncDownloadReply.
### sharetrial
Emails the trial report to the specified email addresses.

- There is a single argument of type ShareTrialReportInput.
- Returns ShareTrialReportReply.
### startclustermigrationjob
Start a job to migrate reports from Rubrik cluster to RSC.

- There is a single argument of type StartClusterReportMigrationJobInput.
- Returns StartClusterReportMigrationJobReply.
### update
- There are 2 arguments.
    - reportID - System.Int32: The report ID.
    - reportConfig - ReportConfigInput
- Returns System.Boolean.
### updatecustom
Update a custom report.

- There is a single argument of type UpdateCustomReportInput.
- Returns UpdateCustomReportReply.
### updatedatabaselogingpropertiesforcluster
Update the database log backup report properties

Supported in v5.3+
Update the properties for the database (SQL and Oracle) log backup delay email notification creation. The properties are logDelayThresholdInMin and logDelayNotificationFrequencyInMin.

- There is a single argument of type UpdateDatabaseLogReportingPropertiesForClusterInput.
- Returns DbLogReportProperties.
### updatepolaris
Update the configuration of a report.

- There is a single argument of type UpdatePolarisReportInput.
- Returns System.String.
### updatescheduledreport
Update a scheduled report.

- There is a single argument of type UpdateScheduledReportInput.
- Returns UpdateScheduledReportReply.
