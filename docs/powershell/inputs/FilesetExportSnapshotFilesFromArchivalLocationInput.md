### FilesetExportSnapshotFilesFromArchivalLocationInput
Input for exporting fileset snapshot files from a specific archival location.

- id: System.String
  - Unique identifier for the snapshot.
- nextSnapshotId: System.String
  - The ID of the next fileset snapshot.
- locationId: System.String
  - Required. ID of the archival location to read the snapshot from.
- osType: GuestOsType
  - OS type of the fileset host.
- shareType: ShareTypeEnum
  - Share type of the fileset.
- config: FilesetExportFilesJobConfigInput
  - The configuration of a job that exports one or more files or folders from
a fileset backup.
- deltaTypeFilter: list of DeltaTypes
  - Filter for the delta type.
- recoveryPurpose: RecoveryPurpose
  - Purpose of the recovery operation. Set to SURGICAL_RECOVERY to
automatically exclude quarantined files from the restore (subject to
feature availability for the account). Defaults to
RECOVERY_PURPOSE_UNSPECIFIED, which preserves prior behavior.
