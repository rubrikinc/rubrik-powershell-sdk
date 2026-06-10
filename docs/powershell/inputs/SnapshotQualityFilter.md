### SnapshotQualityFilter
SnapshotQualityFilter specifies quality and status
filters for snapshot queries. These filters are applied
per workload type according to the workload type's
filter policy (e.g., EC2 gets all filters, RDS gets
time-only).

- excludeQuarantined: System.Boolean
  - Whether to exclude quarantined snapshots.
- excludeAnomalous: System.Boolean
  - Whether to exclude anomalous snapshots.
- excludeNonIndexed: System.Boolean
  - Whether to exclude non-indexed snapshots.
- quarantinedOnly: System.Boolean
  - Whether to only include quarantined snapshots.
- anomalousOnly: System.Boolean
  - Whether to only include anomalous snapshots.
- excludeReplica: System.Boolean
  - Whether to exclude replica snapshots.
- excludeArchivalLocationTypes: list of System.Strings
  - Archival location types to exclude from results.
