# New-RscMutationReport
## Subcommands
### createcustom
Create a custom report.

- There are 2 arguments.
    - input - CreateCustomReportInput
    - reportRoom - System.String: Room of the report.
- Returns CreateCustomReportReply.
### createscheduled
Create a scheduled report.

- There is a single argument of type CreateScheduledReportInput.
- Returns CreateScheduledReportReply.
### deletecustom
Delete a custom report.

- There is a single argument of type DeleteCustomReportInput.
- Returns System.String.
### deletescheduled
Delete a scheduled report.

- There is a single argument of type DeleteScheduledReportInput.
- Returns System.String.
### sendpdf
DHRC PDF report generation.

- There is a single argument of type SendPdfReportInput.
- Returns SendPdfReportReply.
### sendscheduledasync
Send a scheduled report now asynchronously via email.

- There is a single argument of type SendScheduledReportAsyncInput.
- Returns AsyncDownloadReply.
### startclustermigrationjob
Start a job to migrate reports from Rubrik cluster to RSC.

- There is a single argument of type StartClusterReportMigrationJobInput.
- Returns StartClusterReportMigrationJobReply.
### updatecustom
Update a custom report.

- There is a single argument of type UpdateCustomReportInput.
- Returns UpdateCustomReportReply.
### updatescheduled
Update a scheduled report.

- There is a single argument of type UpdateScheduledReportInput.
- Returns UpdateScheduledReportReply.
