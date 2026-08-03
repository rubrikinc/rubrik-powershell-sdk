### DownloadPureStorageProtectionGroupSnapshotFromLocationInput
Input for downloading a Pure Storage protection group snapshot from a remote location.

- id: System.String
  - Required. ID of the snapshot to be downloaded.
- downloadConfig: PureStorageSnapshotDownloadRequestInput
  - Configuration for the download job.
- locationId: System.String
  - Required. ID of the archival or replication location.
