### DownloadVolumeGroupSnapshotFilesInput
Input for downloading volume group snapshot files.

- config: VolumeGroupDownloadFilesJobConfigInput
  - Configuration information for a job to download files and folders from a volume group backup.
- deltaTypeFilter: a list of DeltaTypes
  - Filter for delta type.
- id: System.String
  - Required. ID of Snapshot.
- nextSnapshotFid: System.String
  - The FID of the next fileset snapshot.
