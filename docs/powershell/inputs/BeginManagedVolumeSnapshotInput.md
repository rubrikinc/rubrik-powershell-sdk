### BeginManagedVolumeSnapshotInput
Input for invoking the API endpoint to begin a Managed Volume snapshot.

- config: BeginSnapshotManagedVolumeRequestInput
  - Details about the reference to be added to the snapshot and the type of request.
- ownerId: System.String
  - A string representing the owner of a snapshot. This owner ID must be used when adding a reference to this snapshot.
- id: System.String
  - Required. Managed Volume ID.
