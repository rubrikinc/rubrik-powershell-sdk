### PureStorageSnapshotDownloadRequestInput
Input for downloading a Pure Storage snapshot.

- cloudRehydrationSpeed: CloudStorageRehydrationSpeed
  - Optional. Overrides the archival location's rehydration speed for this download only. Applies only when the snapshot is in a cold (offline) storage tier of an AWS S3 or Azure archival location. Not supported for Rubrik Cloud Vault locations.
- slaId: System.String
  - Supported in v9.6+
ID of the SLA Domain that manages the retention of the downloaded snapshot.
