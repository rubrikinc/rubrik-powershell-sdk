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
- isTlsEnabledAtSnapshot: System.Boolean
  - Supported in v9.7
Read-only. Whether the NFSv4 TLS option was active on the Managed Volume when this snapshot was taken. Captured at the start of the snapshot write window. Read-only by placement (this field appears only on the snapshot read model, never on a request model). Absent for snapshots taken before this field existed or when the option was never set.
