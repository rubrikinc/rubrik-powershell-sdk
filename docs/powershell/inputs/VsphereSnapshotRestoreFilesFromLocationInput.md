### VsphereSnapshotRestoreFilesFromLocationInput
Input for recovering files from snapshot.

- snapshotFid: System.String
  - Required. ID of the virtual machine snapshot.
- config: RestoreFilesJobConfigInput
  - Required. Configuration for the restore request.
- clusterUuid: System.String
  - Required. UUID used to identify the cluster the request goes to.
- locationId: System.String
  - Required. ID of the location.
