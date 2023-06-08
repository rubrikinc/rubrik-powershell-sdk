### InPlaceRecoveryJobConfigForBatchInput
Supported in v6.0+

- snapshotAfterDate: DateTime
  - Supported in v6.0+
      Runs in-place recovery with the oldest snapshot taken after the specified date. This parameter is only evaluated when no values are set for snapshotId and snapshotBeforeDate.
- snapshotBeforeDate: DateTime
  - Supported in v6.0+
      Runs in-plance recovery with the most recent snapshot taken prior to the specified date. This parameter is only evaluated when no value is set for snapshotId.
- snapshotId: System.String
  - Supported in v6.0+
      The ID of the snapshot to use for in-place recovery. This parameter is optional if either of the snapshotBeforeDate or snapshotAfterDate parameters is configured.
- config: InPlaceRecoveryJobConfigV2Input
  - Required. Supported in v6.0+
      Configuration for in-place recovery.
- vmId: System.String
  - Required. Supported in v6.0+
      ID of the virtual machine to be recovered.
