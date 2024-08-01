### RestoreEntityInputInput
Supported in v9.2+
  All the inputs required for restoring the entity.

- hostRecoveryTargets: list of HostRecoveryTargetInputs
  - Required. Supported in v9.2+
      List of target hosts for recovery.
- logSnapshotTimeRange: RestoreLogSnapshotTimeRangeInput
  - Supported in v9.2+
      Time range for the log snapshots to be restored.
- snapshotId: System.String
  - Required. Supported in v9.2+
      Snapshot ID to be used for recovery.
