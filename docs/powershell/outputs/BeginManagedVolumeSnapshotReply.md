### BeginManagedVolumeSnapshotReply
Supported in v7.0+

- asyncRequestStatus: AsyncRequestStatus
  - Supported in v7.0+
  Status of the asynchronous request that was initiated for the Managed Volume Begin Snapshot job.
- ownerId: System.String
  - Supported in v7.0+
  An ID representing the owner of a snapshot.
- snapshotId: System.String
  - Required. Supported in v7.0+
  ID of the snapshot. All writes to the Managed Volume until the next end-snapshot call will be part of this snapshot.
