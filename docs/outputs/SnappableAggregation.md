### SnappableAggregation
The aggregation data of some workload statistics.

- archiveStorage: System.Int64
  - The amount of storage used by archived snapshots.
- lastSnapshotLogicalBytes: System.Int64
  - The logical size of the workload's last snapshot.
- logicalBytes: System.Int64
  - Logical bytes used by snapshots of this workload.
- missedSnapshots: System.Int32
  - The number of snapshots that were missed.
- physicalBytes: System.Int64
  - Physical bytes used by snapshots of this workload.
- replicaStorage: System.Int64
  - The amount of storage used by replicated snapshots.
- totalSnapshots: System.Int32
  - The total number of snapshots present for the workload.
- transferredBytes: System.Int64
  - Bytes ingested over the network for this workload.
