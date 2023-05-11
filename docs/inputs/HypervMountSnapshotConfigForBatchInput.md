### HypervMountSnapshotConfigForBatchInput
Supported in v7.0+

- mountConfig: HypervMountSnapshotJobConfigInput
  - Required. Supported in v7.0+
      Configuration for mounting the snapshot.
- snapshotAfterDate: DateTime
  - Supported in v7.0+
      Mounts the first snapshot taken after the specified date. The value of 'snapshotAfterDate' is considered only when 'snapshotId' and 'snapshotBeforeDate' are not configured.
- snapshotBeforeDate: DateTime
  - Supported in v7.0+
      Mounts the snapshot most recently taken before the specified date. The value of 'snapshotBeforeDate' is considered only when a snapshot ID is not set using 'snapshotId'.
- snapshotId: System.String
  - Supported in v7.0+
      ID of the snapshot to mount. This parameter is optional if the snapshotBeforeDate or snapshotAfterDate parameters are configured.
- vmId: System.String
  - Required. Supported in v7.0+
      ID of the virtual machine with snapshot that requires mounting.
- vmNamePrefix: System.String
  - Supported in v7.0+
      Prefix to be added to the name of the mounted virtual machine.
