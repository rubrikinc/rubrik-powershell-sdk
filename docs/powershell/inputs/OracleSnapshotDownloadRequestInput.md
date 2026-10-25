### OracleSnapshotDownloadRequestInput
Input for snapshot download from location for V2 API.

- cloudRehydrationSpeed: CloudStorageRehydrationSpeed
  - Optional. Overrides the archival location's rehydration speed for this download only. Applies only when the snapshot is in a cold (offline) storage tier of an AWS S3 or Azure archival location. Not supported for Rubrik Cloud Vault locations.
- slaId: System.String
  - Supported in v9.2+
ID of the SLA Domain to manage downloaded snapshot retention. Log snapshot retention is not managed by this configuration.
