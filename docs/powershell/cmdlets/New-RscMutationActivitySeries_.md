# New-RscMutationActivitySeries
## Subcommands
### cancel
Cancel an activity series.

- There is a single argument of type CancelActivitySeriesInput.
- Returns System.Boolean.
### downloadusercsv
Schedule a download CSV job for a user's activity.

- There is a single argument of type DownloadUserActivityCsvInput.
- Returns DownloadCsvReply.
### downloaduserfilecsv
Schedule a download CSV job for user activity on a specific file.

- There is a single argument of type DownloadUserFileActivityCsvInput.
- Returns DownloadCsvReply.
### exportusersummaries
Export the user activity summaries.

- There are 3 arguments.
    - filter - ExportUserActivitySummariesFilterInput: Export user activity summaries filter.
    - endTime - DateTime: End time in ISO string format (YYYY-MM-DDThh:mm:ssZ).
    - timePeriod - TimePeriod: Time period for the activity.
- Returns ExportUserActivitySummariesResp.
