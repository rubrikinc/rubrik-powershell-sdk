### VsphereSnapshotRestoreFilesFromLocationInput
Input for recovering files from snapshot.

- clusterUuid: System.String
  - UUID used to identify the cluster the request goes to.
- snapshotFid: System.String
  - ID of the virtual machine snapshot.
- locationId: System.String
  - ID of the location.
- config: RestoreFilesJobConfigInput
  - Configuration for the restore request.
