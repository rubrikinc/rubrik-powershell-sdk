### Db2DownloadRecoverableRangeRequestInput
Supported in v8.0+

- pointInTime: DateTime
  - Supported in v8.0+
Point in time for which the snapshots should be downloaded for recovery. The date-time string must be in the ISO8601 format. For example, "2016-01-01T01:23:45.678". The timezone is same as the timezone of the Rubrik cluster.
- preferredLocationId: System.String
  - Required. Supported in v8.0+
ID of the location preferred for downloading the base full and log snapshots required for point in time recovery. The snapshots not available at the preferred location will be downloaded from the location where they are available.
- cloudRehydrationSpeed: CloudStorageRehydrationSpeed
  - Optional. Overrides the archival location's rehydration speed for this download only. Applies only when the base full snapshot is in a cold (offline) storage tier of an AWS S3 or Azure archival location. Log snapshots are not affected. Not supported for Rubrik Cloud Vault locations.
