### RecoveryAnalysisMetadata
Metadata about the recovery analysis including time range and data source information.

- taskchainId: System.String
  - The ID of the recovery analysis taskchain.
- orgId: System.String
  - The O365 organization ID.
- groupId: System.String
  - The O365 group ID used for filtering.
- analysisStartTime: System.Int64
  - The start time, in Unix epoch milliseconds, of the analysis period.
- analysisEndTime: System.Int64
  - The end time, in Unix epoch milliseconds, of the analysis period.
- analysisIntervalDays: System.Int64
  - The number of days covered by the analysis interval.
- sharepointBlobPath: System.String
  - The GCS blob path containing raw SharePoint analysis data.
- exchangeBlobPath: System.String
  - The GCS blob path containing raw Exchange analysis data.
- onedriveBlobPath: System.String
  - The GCS blob path containing raw OneDrive analysis data.
- workloads: list of O365MvbWorkloadTypes
  - The workloads types of the analysis.
- shouldExcludeArchivedMailbox: System.Boolean
  - Whether to exclude archived mailboxes.
- snapshotTime: DateTime
  - Time of the recovery point snapshot.
