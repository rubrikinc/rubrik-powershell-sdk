### SelectorStepEvent
Selector step events.

- seq: System.Int32
  - Sequence number.
- message: System.String
  - Message.
- status: System.String
  - Current status.
- startTime: System.Int64
  - Start time.
- endTime: System.Int64
  - End time.
- elapsedTime: System.Int64
  - Elapsed time.
- failed: System.Int32
  - Number of workloads for which recovery failed.
- total: System.Int32
  - Total number of workloads.
- inProgress: System.Int32
  - Number of workloads for which recovery is in progress.
- objectsWithoutSnapshot: System.Int32
  - Number of objects for which recovery was skipped due to no snapshot.
