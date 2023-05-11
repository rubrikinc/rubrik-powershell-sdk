### MountSnapshotJobConfigForBatchV2Input
Supported in v6.0+

- config: MountSnapshotJobConfigV2Input
  - Required. Supported in v6.0+
      Snapshot mount configuration.
- snapshotAfterDate: DateTime
  - Supported in v6.0+
      Mounts the oldest snapshot taken after the specified date. This parameter is evaluated only snapshotId and snapshotBeforeDate. do not have values set.
- snapshotBeforeDate: DateTime
  - Supported in v6.0+
      Mounts the most recent snapshot taken prior to the specified date. This parameter is evaluated only when snapshotId does not have a value set.
- snapshotId: System.String
  - Supported in v6.0+
      ID of the snapshot to mount. This parameter is optional if either the `snapshotBeforeDate` or `snapshotAfterDate` parameters are configured.
- vmId: System.String
  - Required. Supported in v6.0+
      ID of the virtual machine whose snapshot must be mounted.
- vmNamePrefix: System.String
  - Supported in v7.0+
      Prefix added to the name of new virtual machines created by the mount or export operation.
