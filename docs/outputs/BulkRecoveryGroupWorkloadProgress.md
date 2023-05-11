### BulkRecoveryGroupWorkloadProgress
Bulk recovery progress at the group workload level.

- canceledWorkloads: System.Int32
  - Number of workloads for which recovery was canceled.
- elapsedTime: System.Int64
  - Elapsed time.
- endTime: System.Int64
  - End time.
- failedWorkloads: System.Int32
  - Number of workloads for which recovery failed.
- inProgressWorkloads: System.Int32
  - Number of workloads for which recovery is in progress.
- selectorSteps: a list of BulkRecoverySelectorSteps
  - Selector level steps.
- seq: System.Int32
  - Sequence number.
- startTime: System.Int64
  - Start time.
- status: BulkRecoveryGroupWorkloadStatus
  - None
- succeededWorkloads: System.Int32
  - Number of workloads succeeded.
- totalWorkloads: System.Int32
  - Total number of workloads.
- workloadType: System.String
  - Workload type.
