### GcpNativeRestoreGceInstanceInput
Input required to restore a GCP GCE instance snapshot.

- snapshotId: System.String
  - Snapshot Rubrik ID.
- shouldAddRubrikLabels: System.Boolean
  - Specifies whether to allow Rubrik labels on the restored disk or not.
- shouldRestoreLabels: System.Boolean
  - Specifies whether to restore labels of the instance from snapshot or not.
- shouldStartRestoredInstance: System.Boolean
  - Specfies whether the the restored instance should be started or not.
- snapshotType: GcpSnapshotType
  - The type of the snapshot to recover from.
