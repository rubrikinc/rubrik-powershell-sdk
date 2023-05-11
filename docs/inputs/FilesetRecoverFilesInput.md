### FilesetRecoverFilesInput
Input for Fileset recover files.

- config: FilesetRestoreFilesJobConfigInput
  - Configuration for job to restore one or more files or folders from a fileset backup.
- deltaTypeFilter: a list of DeltaTypes
  - Filter for delta type.
- nextSnapshotFid: System.String
  - The fid of the next fileset snapshot.
- osType: GuestOsType
  - OS Type of the Fileset Host.
- restorePathPairList: a list of OldRestorePathPairInputs
  - List of restore path pairs.
- shareType: ShareTypeEnum
  - Share type of fileset.
- snapshotFid: System.String
  - Corresponds to snapshot forever UUID in Rubrik tables.
