### WorkloadGroupByAggregationData
The aggregation data of a workload group by query.

- count: System.Int32
  - The total count of workload.
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
  - Logical bytes of the last snapshot of the workload.
