### BulkGenerateFilesetBackupReportReply
Response message for bulk generation of fileset backup reports.

- snapshotResults: list of AsyncRequestStatuss
  - Results for each snapshot that was processed.
Each result contains either a successful AsyncRequestStatus or error information.
