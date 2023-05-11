### MountSnapshotJobConfigForBatchV1Input
Supported in v5.0+

- config: MountSnapshotJobConfigV1Input
  - Required. Supported in v5.0+
      v5.0-v5.3: Snapshot mount config
      v6.0+: Configuration for Snapshot mount.
- snapshotAfterDate: DateTime
  - Supported in v5.0+
      Mounts the oldest snapshot taken after the specified date. This parameter is only evaluated when no values are set for snapshotId and snapshotBeforeDate.
- snapshotBeforeDate: DateTime
  - Supported in v5.0+
      v5.0-v5.3: Mounts the most recent snapshot prior to the specified date. This parameter is only evaluated when no value is set for snapshotId.
      v6.0+: Mounts the most recent snapshot taken prior to the specified date. This parameter is only evaluated when no value is set for snapshotId.
- snapshotId: System.String
  - Supported in v5.0+
      v5.0-v5.3: ID of snapshot to mount. Optional. The snapshot to mount is determined from the other parameters in this call when the ID is not provided.
      v6.0+: The ID of the snapshot to export. This parameter is optional if either of the `snapshotBeforeDate` or `snapshotAfterDate` parameters is configured.
- vmId: System.String
  - Required. Supported in v5.0+
      v5.0: Mount a snapshot from this virtual machine.
      v5.1-v5.3: Mount a snapshot from this virtual machine
      v6.0+: ID of the virtual machine whose snapshot needs to be mounted.
