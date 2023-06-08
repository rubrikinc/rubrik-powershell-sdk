### InstantRecoveryJobConfigForBatchInput
Supported in v6.0+

- snapshotAfterDate: DateTime
  - Supported in v6.0+
      Mounts the oldest snapshot taken after the specified date. This parameter is only evaluated when no values are set for snapshotId and snapshotBeforeDate.
- snapshotBeforeDate: DateTime
  - Supported in v6.0+
      Mounts the most recent snapshot taken prior to the specified date. This parameter is only evaluated when no value is set for snapshotId.
- snapshotId: System.String
  - Supported in v6.0+
      The ID of the snapshot to mount. This parameter is optional if either of the snapshotBeforeDate or snapshotAfterDate parameters is configured.
- config: InstantRecoveryJobConfigV2Input
  - Required. Supported in v6.0+
      Configuration for snapshot export.
- vmId: System.String
  - Required. Supported in v6.0+
      ID of the virtual machine whose snapshot needs to be mounted.
