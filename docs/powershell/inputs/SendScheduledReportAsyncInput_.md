### SendScheduledReportAsyncInput
Input for sending report email to one or more recipients.

- reportId: System.Int32
  - ID of the report that needs to be emailed.
- rubrikUserIds: list of System.Strings
  - Auth0 IDs of Rubrik user recipients of the report.
- nonRubrikUserEmails: list of System.Strings
  - Email addresses of non-Rubrik user recipients of the report.
- attachmentTypes: list of ReportAttachmentTypes
  - Report attachment types, which can be CSV, PDF, both, or none.
