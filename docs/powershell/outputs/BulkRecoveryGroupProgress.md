### BulkRecoveryGroupProgress
Bulk recovery group level progress.

- seq: System.Int32
  - Sequence number.
- groupName: System.String
  - Group name.
- groupType: System.String
  - Group type.
- startTime: System.Int64
  - Start time.
- endTime: System.Int64
  - End time.
- createTime: System.Int64
  - Create time.
- elapsedTime: System.Int64
  - Elapsed time.
- workloadProgresses: list of BulkRecoveryGroupWorkloadProgresss
  - Workload level progresses.
- groupId: System.String
  - Group natural ID.
- status: BulkRecoveryGroupStatus
