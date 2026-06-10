### VsphereSnapshotDownloadFilesFromLocationInput
Input for downloading vSphere snapshot files from a location.

- snapshotFid: System.String
  - Required. ID of the virtual machine snapshot.
- config: DownloadFilesJobConfigInput
  - Required. Configuration for the download request.
- clusterUuid: System.String
  - Required. UUID used to identify the cluster the request goes to.
- locationId: System.String
  - Required. ID of the location.
