### ScaleRuntime
Runtime state of a scaling operation on a cluster.

- oldCount: System.Int32
  - Existing node count.
- newCount: System.Int32
  - Desired node count.
- taskchainUuid: System.String
  - Taskchain triggered for this scaling operation.
- deadline: DateTime
  - After deadline, trigger taskchain forcefully.
