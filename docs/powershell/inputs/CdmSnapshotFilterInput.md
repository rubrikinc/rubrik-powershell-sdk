### CdmSnapshotFilterInput


- clusterUuid: list of System.Strings
- snappableId: list of System.Strings
- snapshotId: list of System.Strings
- timeRange: TimeRangeInput
- isOnDemandSnapshot: System.Boolean
- isIndexed: System.Boolean
  - Filter on whether the snapshot is indexed.
- localSnapshotsOnly: System.Boolean
  - Specifies whether RSC only queries for local snapshots.
- isOpenstackStorageSnapshot: System.Boolean
  - OpenStack virtual machines only: filter by Cinder storage snapshot (true)
vs regular Rubrik backup (false). Ignored for non-OpenStack workloads.
