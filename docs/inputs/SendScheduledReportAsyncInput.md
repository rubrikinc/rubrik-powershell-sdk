### SendScheduledReportAsyncInput
Input for sending report email to one or more recipients.

- nonRubrikUserEmails: a list of System.Strings
  - Email addresses of non-Rubrik user recipients of the report.
- reportId: System.Int32
  - ID of the report that needs to be emailed.
- rubrikUserIds: a list of System.Strings
  - Auth0 IDs of Rubrik user recipients of the report.
