### TriggerRansomwareDetectionInput
Request to initiate a ransomware detection job on a snapshot.

- clusterUuid: System.String
  - The ID of the Rubrik cluster where the snapshot is available.
- snapshotId: System.String
  - The ID of the snapshot.
- managedId: System.String
  - The managed ID of the object.
- previousSnapshotId: System.String
  - The ID of the snapshot that was taken prior to the snapshot selected for ransomware detection.
