### FilesetExportSnapshotFilesInput
Input for Fileset export snapshot files.

- config: FilesetExportFilesJobConfigInput
  - The configuration of a job that exports one or more files or folders from a fileset backup.
- id: System.String
  - Corresponds to snapshot forever UUID in Rubrik tables.
- osType: GuestOsType
  - OS Type of the Fileset Host.
- shareType: ShareTypeEnum
  - Share type of fileset.
- deltaTypeFilter: list of DeltaTypes
  - Filter for delta type.
- nextSnapshotFid: System.String
  - The fid of the next fileset snapshot.
- recoveryPurpose: RecoveryPurpose
  - Purpose of the recovery operation. Set to SURGICAL_RECOVERY to automatically exclude quarantined files from the restore (subject to feature availability for the account). Defaults to RECOVERY_PURPOSE_UNSPECIFIED, which preserves prior behavior.
