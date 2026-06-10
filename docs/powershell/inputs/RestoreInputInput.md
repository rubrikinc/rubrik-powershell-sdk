### RestoreInputInput
Supported in v9.4+
Specifies the input required to perform the restore for the workload.

- locationMap: list of SnapshotPreferredLocationInputs
  - Required. Supported in v9.4+
List of preferred locations for the snapshots.
- restoreSettings: RestoreSettingsInput
  - Provides various settings to customize the restore for the workload.
- restoreName: System.String
  - Required. Supported in v9.4+
Custom name for the restore operation.
- restoreTime: DateTime
  - Supported in v9.4+
v9.4-v9.5: Restore time at which entities needs to be restored.
v9.6: Restore time at which entities needs to be restored. Mutually exclusive with preferredDataSnapshotId; one of the two must be provided.
- restoreEntities: list of System.Strings
  - Required. Supported in v9.4+
List of entities to be restored to the given time.
- hostRestoreTargets: list of HostDiscoveryInfoInputs
  - Supported in v9.4+
List of target hosts for restore.
- preferredDataSnapshotId: System.String
  - Supported in v9.6
The data snapshot to restore from. When set, this snapshot
is used as the anchor for the restore and the recovery time is
derived from it.
