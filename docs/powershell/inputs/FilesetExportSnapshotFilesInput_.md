### FilesetExportSnapshotFilesInput
Input for Fileset export snapshot files.

- id: System.String
  - Corresponds to snapshot forever UUID in Rubrik tables.
- nextSnapshotFid: System.String
  - The fid of the next fileset snapshot.
- deltaTypeFilter: list of DeltaTypes
  - Filter for delta type.
- config: FilesetExportFilesJobConfigInput
  - The configuration of a job that exports one or more files or folders from a fileset backup.
- shareType: ShareTypeEnum
  - Share type of fileset.
- osType: GuestOsType
  - OS Type of the Fileset Host.
