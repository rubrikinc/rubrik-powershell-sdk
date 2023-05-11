### WorkloadGroupByAggregationData
The aggregation data of a workload group by query.

- archiveStorage: System.Int64
  - The amount of storage used by archived snapshots.
- count: System.Int32
  - The total count of workload.
- lastSnapshotLogicalBytes: System.Int64
  - Logical bytes of the last snapshot of the workload.
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
