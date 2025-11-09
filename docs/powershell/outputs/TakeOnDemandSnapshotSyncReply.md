### TakeOnDemandSnapshotSyncReply
Represents the response to the synchronous take on-demand snapshot operation. For each workload ID that the on-demand snapshot was triggered, the response contains either taskchainUUID and snapshotCreationTimestamp of the snapshot or an error message.

- workloadDetails: list of WorkloadSnapshotDetailss
  - The list of on-demand snapshot details for each workload.
