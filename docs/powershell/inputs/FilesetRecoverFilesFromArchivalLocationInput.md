### FilesetRecoverFilesFromArchivalLocationInput
Input for Fileset recover files from an archival location.

- snapshotId: System.String
  - Corresponds to the snapshot ID in Rubrik tables.
- nextSnapshotId: System.String
  - The ID of the next fileset snapshot.
- restorePathPairList: list of OldRestorePathPairInputs
  - List of restore path pairs.
- deltaTypeFilter: list of DeltaTypes
  - Filter for the delta type.
- config: FilesetRestoreFilesJobConfigInput
  - Configuration for job to restore one or more files or folders from a fileset backup.
- shareType: ShareTypeEnum
  - Share type of the fileset.
- osType: GuestOsType
  - OS type of the fileset host.
- locationId: System.String
  - Required. ID of the archival location.
- recoveryPurpose: RecoveryPurpose
  - Purpose of the recovery operation. Set to SURGICAL_RECOVERY to automatically exclude quarantined files from the restore (subject to feature availability for the account). Defaults to RECOVERY_PURPOSE_UNSPECIFIED, which preserves prior behavior.
