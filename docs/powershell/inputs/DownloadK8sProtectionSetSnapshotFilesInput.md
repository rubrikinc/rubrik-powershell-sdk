### DownloadK8sProtectionSetSnapshotFilesInput
Input for downloading files from a Kubernetes protection set snapshot.

- id: System.String
  - Required. ID assigned to a Kubernetes protection set snapshot.
- config: DownloadFilesJobConfigInput
  - Required. Configuration object containing an array with the full paths of the files and folders to download. The array must contain at least one full path.
- locationId: System.String
  - Required. ID of the archival location.
