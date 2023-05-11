### TakeOnDemandSnapshotReply
Represents the response to the take on-demand snapshot operation. For each workload ID that the on-demand snapshot was triggered, it either ends up being in the taskchainUuids or the errors map depending on if the operation succeeded or failed respectively.

- errors: a list of TakeOnDemandSnapshotErrors
  - The errors in response to taking the on-demand snapshots.
- taskchainUuids: a list of TakeOnDemandSnapshotTaskchainUuids
  - The UUIDs of the on-demand snapshot taskchains.
