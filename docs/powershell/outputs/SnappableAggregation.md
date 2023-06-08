### SnappableAggregation
The aggregation data of some workload statistics.

- totalSnapshots: System.Int32
  - The total number of snapshots present for the workload.
- missedSnapshots: System.Int32
  - The number of snapshots that were missed.
- archiveStorage: System.Int64
  - The amount of storage used by archived snapshots.
- replicaStorage: System.Int64
  - The amount of storage used by replicated snapshots.
- physicalBytes: System.Int64
  - Physical bytes used by snapshots of this workload.
- logicalBytes: System.Int64
  - Logical bytes used by snapshots of this workload.
- lastSnapshotLogicalBytes: System.Int64
  - The logical size of the workload's last snapshot.
- transferredBytes: System.Int64
  - Bytes ingested over the network for this workload.
