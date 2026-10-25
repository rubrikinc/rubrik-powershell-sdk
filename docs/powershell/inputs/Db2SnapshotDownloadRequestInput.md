### Db2SnapshotDownloadRequestInput
Input for snapshot download from location for V2 API of Db2.

- cloudRehydrationSpeed: CloudStorageRehydrationSpeed
  - Optional. Overrides the archival location's rehydration speed for this download only. Applies only when the snapshot is in a cold (offline) storage tier of an AWS S3 or Azure archival location. Not supported for Rubrik Cloud Vault locations.
- slaId: System.String
  - Supported in v9.2+
ID of the SLA Domain used to manage downloaded snapshot retention. This configuration does not manage log snapshot retention.
