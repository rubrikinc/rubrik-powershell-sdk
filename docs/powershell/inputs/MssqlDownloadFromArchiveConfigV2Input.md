### MssqlDownloadFromArchiveConfigV2Input
Supported in Rubrik CDM v9.1.2+.

- recoveryPoint: MssqlRecoveryPointInput
  - Required. Supported in Rubrik CDM v9.1.2+.
- cloudRehydrationSpeed: CloudStorageRehydrationSpeed
  - Optional. Overrides the archival location's rehydration speed for this download only. Applies only when the snapshot is in a cold (offline) storage tier of an AWS S3 or Azure archival location. Not supported for Rubrik Cloud Vault locations.
- slaId: System.String
  - Supported in Rubrik CDM v9.1.2+. ID of the SLA Domain that manages the retention of downloaded snapshots.
