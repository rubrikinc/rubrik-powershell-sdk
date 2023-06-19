### ManagedVolumeSnapshotReferenceDefinitionInput
Supported in v5.0+
  v5.0-v8.0: 
  v8.1+: Reference for a Managed Volume snapshot.

- managedVolumeSnapshotReferencePatch: ManagedVolumeSnapshotReferencePatchInput
  - Reference for a Managed Volume snapshot.
- ownerId: System.String
  - Required. Supported in v5.0+
      v5.0-v5.1: An ID representing the owner of a snapshot. This must be the same for all references of a snapshot.
      v5.2-v6.0: An ID representing the owner of a snapshot. All references to a snapshot must use the same ID.
      v7.0+: An ID representing the owner of a snapshot. All references to the snapshot must use the same ID.
