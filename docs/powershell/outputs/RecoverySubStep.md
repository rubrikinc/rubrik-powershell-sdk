### RecoverySubStep
Information about a particular substep.

- seq: System.Int32
  - Sequence number of the substep.
- message: System.String
  - Message.
- events: list of RecoveryEvents
  - Events related to substep.
- startTime: System.Int64
  - Timestamp, in Unix seconds, for when the recovery sub step started.
- endTime: System.Int64
  - Timestamp, in Unix seconds, for when the recovery sub step ended.
- elapsedTime: System.Int64
  - Time elapsed, in seconds, since the recovery sub step started.
- substepStatus: RecoveryStepStatus
  - Status of the recovery substep.
