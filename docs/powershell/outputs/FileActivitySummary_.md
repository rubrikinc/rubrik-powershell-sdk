### FileActivitySummary
File activity summary.

- fileName: System.String
  - File name.
- currentActivitySummary: ActivitySummary
  - Current activity summary.
- deltaActivitySummary: ActivitySummary
  - Delta activity summary.
- lastAccessTimestamp: System.Int64
  - Last accessed timestamp of the file.
- paginationId: System.String
  - Unique identifier for the file activity summary results.
 Used to paginate results.
- snapshotId: System.String
  - SDD Snapshot ID which was used for defining the sensitivity for the
 path.
- risk: RiskLevelType
  - Risk level enum type.
