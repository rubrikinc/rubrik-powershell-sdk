### DownloadDb2SnapshotV2Input
Input for downloading Db2 snapshot from location for V2 API.

- userNote: System.String
  - Required. User note to associate with audits.
- snapshotId: System.String
  - Required. ID of the Db2 database snapshot.
- downloadConfig: Db2SnapshotDownloadRequestInput
  - Additional configuration for the snapshot download operation.
- locationId: System.String
  - Required. ID of the location from where the Db2 database snapshot is downloaded.
