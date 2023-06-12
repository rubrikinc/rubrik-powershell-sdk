### BulkRecoveryGroupWorkloadProgress
Bulk recovery progress at the group workload level.

- seq: System.Int32
  - Sequence number.
- workloadType: System.String
  - Workload type.
- startTime: System.Int64
  - Start time.
- endTime: System.Int64
  - End time.
- elapsedTime: System.Int64
  - Elapsed time.
- failedWorkloads: System.Int32
  - Number of workloads for which recovery failed.
- canceledWorkloads: System.Int32
  - Number of workloads for which recovery was canceled.
- succeededWorkloads: System.Int32
  - Number of workloads succeeded.
- inProgressWorkloads: System.Int32
  - Number of workloads for which recovery is in progress.
- totalWorkloads: System.Int32
  - Total number of workloads.
- selectorSteps: list of BulkRecoverySelectorSteps
  - Selector level steps.
- workloadsWithoutSnapshot: System.Int32
  - Number of workloads for which recovery was skipped due to no snapshot.
- status: BulkRecoveryGroupWorkloadStatus
