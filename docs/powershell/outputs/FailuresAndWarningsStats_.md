### FailuresAndWarningsStats
Stores the failures and warnings stats within a time range bucket.

- startTime: DateTime
  - Start time of the bucket.
- endTime: DateTime
  - End time of the bucket.
- workloadTypeToFailureCount: list of WorkloadTypeToEventCounts
  - Number of failures per workload type.
- workloadTypeToWarningCount: list of WorkloadTypeToEventCounts
  - Number of warnings per workload type.
