### NutanixMountSnapshotJobConfigForBatchInput
Supported in v7.0+

- snapshotAfterDate: DateTime
  - Supported in v7.0+
      Mounts the first snapshot taken after the specified date. The value of 'snapshotAfterDate' is considered only when 'snapshotId' and 'snapshotBeforeDate' are not configured.
- snapshotBeforeDate: DateTime
  - Supported in v7.0+
      Mounts the snapshot taken most recently before the specified date. The value of 'snapshotBeforeDate' is considered only when a snapshot ID is not set using 'snapshotId'.
- snapshotId: System.String
  - Supported in v7.0+
      ID of the snapshot to mount. This parameter is optional if the 'snapshotBeforeDate' or 'snapshotAfterDate' parameters are configured.
- vmNamePrefix: System.String
  - Supported in v7.0+
      Prefix to be added to the name of the mounted virtual machine.
- mountConfig: NutanixVmMountSnapshotJobConfigInput
  - Required. Supported in v7.0+
      Configuration for mounting the snapshot.
- vmId: System.String
  - Required. Supported in v7.0+
      ID of the virtual machine whose snapshot requires mounting.
