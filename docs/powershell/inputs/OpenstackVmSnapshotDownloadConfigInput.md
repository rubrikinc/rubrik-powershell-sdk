### OpenstackVmSnapshotDownloadConfigInput
Supported in v9.4+
Input to download an archived or replicated OpenStack virtual machine snapshot.

- cloudRehydrationSpeed: CloudStorageRehydrationSpeed
  - Optional. Overrides the archival location's rehydration speed for this download only. Applies only when the snapshot is in a cold (offline) storage tier of an AWS S3 or Azure archival location. Not supported for Rubrik Cloud Vault locations.
- slaId: System.String
  - Supported in v9.4+
ID of the SLA Domain to manage retention of the downloaded snapshot.
