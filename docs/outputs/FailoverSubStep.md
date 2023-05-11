### FailoverSubStep
The specific failover sub-step for a step within a failover job.

- elapsedTime: System.Int64
  - The time taken for the specific failover sub-step.
- endTime: System.Int64
  - The end time for the specific failover sub-step.
- events: a list of FailoverEvents
  - The events that occured within the specific failover sub-step.
- message: System.String
  - The latest event message for the specific failover sub-step.
- seq: System.Int32
  - The sequence number for the specific failover sub-step.
- startTime: System.Int64
  - The start time for the specific failover sub-step.
- status: System.String
  - The status of the specific failover sub-step.
- weight: System.Int32
  - The weight assigned to the specific failover sub-step.
