### DownloadFilesetSnapshotFromLocationInput
Input for downloading the fileset snapshot from a location.

- downloadConfig: FilesetDownloadRequestInput
  - Additional configuration for the operation. This consists of the SLA Domain to be applied to the snapshot after it is downloaded.
- locationId: System.String
  - Required. ID of the replication location.
- snapshotId: System.String
  - Required. ID of the snapshot to be downloaded.
