### SendScheduledReportInput
Input for sending a scheduled report.

- id: System.Int32
  - ID of the scheduled report to edit.
- recipients: list of System.Strings
  - Auth0 IDs of Rubrik recipients. This field has been deprecated in favor of rubrikRecipientIDs.
- attachmentTypes: list of ReportAttachmentTypes
  - Report attachment types, which can be CSV, PDF, both, or none.
