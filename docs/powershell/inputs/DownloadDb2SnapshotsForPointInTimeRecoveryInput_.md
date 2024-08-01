### DownloadDb2SnapshotsForPointInTimeRecoveryInput
Download Db2 snapshots from archival location to the local Rubrik cluster for point-in-time (PIT) recovery.

- downloadConfig: Db2DownloadRecoverableRangeRequestInput
  - Required. Object containing information required for downloading snapshots for a point in time recovery. The object includes the point in time and the ID of the archival location for the snapshots to be downloaded.
- id: System.String
  - Required. ID of the Db2 database.
