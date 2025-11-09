### WorkloadSnapshotDetails
Represents the snapshot details for a workload in response to triggering the synchronous on-demand snapshot operation.

- workloadId: System.String
  - The Rubrik UUID of the workload.
- taskchainUuid: System.String
  - The UUID of the job instance. Present if the operation succeeded.
- snapshotCreationTimestamp: System.String
  - The timestamp when the snapshot was created. Present if the operation succeeded.
- error: System.String
  - The error message. Present if the operation failed.
