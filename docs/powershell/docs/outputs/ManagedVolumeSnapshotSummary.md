### ManagedVolumeSnapshotSummary
Supported in v5.0+
  v5.0-v8.0: 
  v8.1+: Summary of the managed volume snapshot.

- links: ManagedVolumeSnapshotLinks
  - Required. Supported in v5.0+
  Links to actions available on the snapshot.
- isQueuedSnapshot: System.Boolean
  - Supported in v5.2+
  A Boolean that specifies whether the snapshot is queued to be stored as a patch file. When this value is 'true', the snapshot is in queue and not yet stored as a patch file.
- baseSnapshotSummary: BaseSnapshotSummary
  - The base snapshot summary for Managed Volume snapshot.
