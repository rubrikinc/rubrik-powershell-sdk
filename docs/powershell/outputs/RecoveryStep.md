### RecoveryStep
Information about steps of recovery.

- seq: System.Int32
  - Sequence number of the step.
- message: System.String
  - Message.
- startTime: System.Int64
  - Timestamp, in Unix seconds, when the recovery step started.
- elapsedTime: System.Int64
  - Time elapsed since the step started in seconds.
- progress: System.Single
  - The progress percentage for the failover.
- subSteps: list of RecoverySubSteps
  - Information about substeps of this step.
- endTime: System.Int64
  - Timestamp, in Unix seconds, when the recovery step ended.
- stepStatus: RecoveryStepStatus
  - Status of the recovery step.
