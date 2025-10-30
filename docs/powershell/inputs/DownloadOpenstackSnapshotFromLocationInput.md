### DownloadOpenstackSnapshotFromLocationInput
Input for downloading OpenStack snapshot.

- snapshotId: System.String
  - Required. ID of the snapshot to be downloaded.
- downloadConfig: OpenstackVmSnapshotDownloadConfigInput
  - Additional configuration for the operation. This consists of the SLA Domain to be applied to the snapshot after it is downloaded.
- locationId: System.String
  - Required. ID of the archival or replication location.
