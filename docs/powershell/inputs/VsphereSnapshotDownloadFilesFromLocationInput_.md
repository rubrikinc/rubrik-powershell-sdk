### VsphereSnapshotDownloadFilesFromLocationInput
Input for downloading vSphere snapshot files from a location.

- clusterUuid: System.String
  - UUID used to identify the cluster the request goes to.
- snapshotFid: System.String
  - ID of the virtual machine snapshot.
- locationId: System.String
  - ID of the location.
- config: DownloadFilesJobConfigInput
  - Configuration for the download request.
