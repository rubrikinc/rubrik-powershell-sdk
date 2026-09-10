### SnappableAggregationsEnum
Columns of a workload that can be aggregated.

- Count - Total count of all workloads matching the aggregation.
- TotalSnapshots - The total number of snapshots present for this workload.
- MissedSnapshots - The number of snapshots that were missed.
- ArchiveStorage - The amount of storage used by archived snapshots.
- ReplicaStorage - The amount of storage used by replicated snapshots.
- PhysicalBytes - Physical bytes used by snapshots of this workload.
- LogicalBytes - Logical bytes used by snapshots of this workload.
- LAST_SNAPSHOT_LOGICAL_BYTES - The logical size of the workload's last snapshot.
- TRANSFERRED_BYTES - Bytes ingested over the network for this workload.
