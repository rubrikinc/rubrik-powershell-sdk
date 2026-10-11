### GcpNativeRestoreGceInstanceInput
Input required to restore a GCP GCE instance snapshot.

- snapshotId: System.String
  - Snapshot Rubrik ID.
- shouldRestoreLabels: System.Boolean
  - Specifies whether to restore labels of the instance from snapshot or not.
- shouldAddRubrikLabels: System.Boolean
  - Specifies whether to allow Rubrik labels on the restored disk or not.
- shouldStartRestoredInstance: System.Boolean
  - Specifies whether the the restored instance should be started or not.
- archivedSnapshotId: System.String
  - The archived snapshot ID from which the recovery should happen.
- recoveryPurpose: RecoveryPurpose
  - Purpose of the recovery operation. Set to SURGICAL_RECOVERY to automatically exclude quarantined files from the restored instance (subject to feature availability for the account). Defaults to RECOVERY_PURPOSE_UNSPECIFIED, which preserves prior behavior.
- snapshotType: GcpSnapshotType
  - The type of the snapshot to recover from.
