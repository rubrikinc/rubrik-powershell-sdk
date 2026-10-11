### ManagedVolumeAppMetadata
Managed Volume workload related app metadata for a snapshot.

- stats: ManagedVolumeSnapshotStats
  - Stats related to Managed Volume snapshot.
- isTlsAtSnapshot: System.Boolean
  - Whether NFSv4 TLS was active when this snapshot was taken. Returns null for pre-v9.7 snapshots.
