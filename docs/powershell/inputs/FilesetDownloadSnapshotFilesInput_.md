### FilesetDownloadSnapshotFilesInput
Input for Fileset Download Snapshot files.

- id: System.String
  - ID assigned to a fileset snapshot object.
- nextSnapshotFid: System.String
  - The fid of the next fileset snapshot.
- userNote: System.String
  - Optional User note.
- zipPassword: System.String
  - Rubrik CDM is version 9.0.1 or later. Password for zip archive created.
- config: FilesetDownloadFilesJobConfigInput
  - Configuration information for a job to download files and folders from a fileset backup.
- deltaTypeFilter: list of DeltaTypes
  - Filter for delta type.
