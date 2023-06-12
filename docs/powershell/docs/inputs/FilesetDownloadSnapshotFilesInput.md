### FilesetDownloadSnapshotFilesInput
Input for Fileset Download Snapshot files.

- id: System.String
  - ID assigned to a fileset snapshot object.
- nextSnapshotFid: System.String
  - The fid of the next fileset snapshot.
- userNote: System.String
  - Optional User note.
- config: FilesetDownloadFilesJobConfigInput
  - Configuration information for a job to download files and folders from a fileset backup.
- deltaTypeFilter: list of DeltaTypes
  - Filter for delta type.
