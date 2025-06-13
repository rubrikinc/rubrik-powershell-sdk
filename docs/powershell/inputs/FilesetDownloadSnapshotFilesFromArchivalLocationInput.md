### FilesetDownloadSnapshotFilesFromArchivalLocationInput
Input for Fileset Download Snapshot files from archival location.

- id: System.String
  - ID assigned to a fileset snapshot object.
- nextSnapshotId: System.String
  - The ID of the next fileset snapshot.
- userNote: System.String
  - Optional user note.
- zipPassword: System.String
  - Rubrik CDM is version 9.0.1 or later. Password for zip archive created.
- config: FilesetDownloadFilesJobConfigInput
  - Configuration information for a job to download files and folders from a fileset backup.
- deltaTypeFilter: list of DeltaTypes
  - Filter for delta type.
- locationId: System.String
  - Required. ID of the archival location.
