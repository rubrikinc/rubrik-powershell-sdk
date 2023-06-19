### FailoverStep
The specific failover step for a failover job.

- seq: System.Int32
  - The sequence number for the specific failover step.
- message: System.String
  - The latest event message for the specific failover step.
- startTime: System.Int64
  - The start time for the specific failover step.
- elapsedTime: System.Int64
  - The elapsed time for the specific failover step.
- status: System.String
  - The status of the specific failover step.
- progress: System.Single
  - The progress percentage for the specific failover step.
- subSteps: list of FailoverSubSteps
  - The sub-steps that belong to the specific failover step.
- endTime: System.Int64
  - The end time for the specific failover step.
- weight: System.Int32
  - The weight for the specific failover step.
