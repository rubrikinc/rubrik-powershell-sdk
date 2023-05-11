### FilesetExportSnapshotFilesInput
Input for Fileset export snapshot files.

- config: FilesetExportFilesJobConfigInput
  - The configuration of a job that exports one or more files or folders from a fileset backup.
- deltaTypeFilter: a list of DeltaTypes
  - Filter for delta type.
- id: System.String
  - Corresponds to snapshot forever UUID in Rubrik tables.
- nextSnapshotFid: System.String
  - The fid of the next fileset snapshot.
- osType: GuestOsType
  - OS Type of the Fileset Host.
- shareType: ShareTypeEnum
  - Share type of fileset.
