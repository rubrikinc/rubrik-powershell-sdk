### DownloadActiveDirectorySnapshotFromLocationInput
Input for downloading an Active Directory domain controller snapshot from a replicated or archived location.

- downloadConfig: ActiveDirectorySnapshotDownloadConfigInput
  - Additional configuration for the operation. This consists of the SLA Domain to be applied to the snapshot after it is downloaded.
- locationId: System.String
  - Required. ID of the replication location.
- snapshotId: System.String
  - Required. ID of the snapshot to be downloaded.
