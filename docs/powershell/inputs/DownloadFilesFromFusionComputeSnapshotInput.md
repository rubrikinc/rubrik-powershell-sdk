### DownloadFilesFromFusionComputeSnapshotInput
Input for downloading files from a FusionCompute virtual machine snapshot.

- id: System.String
  - Required. ID assigned to a FusionCompute virtual machine backup object.
- config: DownloadFilesJobConfigInput
  - Required. Configuration object containing an array with the full paths of the files and folders to download. The array must contain at least one full path.
- locationId: System.String
  - ID of the archival location. When not provided, downloads from local backup.
