### PureStorageProtectionGroupExportSnapshotJobConfigInput
Configuration for exporting a Pure Storage protection group snapshot.

- arrayId: System.String
  - The ID of the target Pure Storage array for exporting the snapshot.
- protectionGroupName: System.String
  - An optional prefix to prepend to the original protection group and volume
names during export. When provided, the exported protection group is named
{prefix}-{originalName} and each volume is named
{prefix}-{originalVolumeName}. When omitted, names are auto-generated.
- snapshotVolumeIds: list of System.Strings
  - Optional. Volume IDs in the source snapshot to include in the export.
Values are the disk IDs as recorded on the snapshot at snapshot-creation
time and may differ from the protection group's current volume membership.
When omitted or empty, all volumes in the snapshot are exported (default).
When non-empty, only the listed volumes are exported. Each ID must
reference a disk present in the snapshot, otherwise the request is
rejected. Each ID must be at most 256 characters and contain no control
characters.
