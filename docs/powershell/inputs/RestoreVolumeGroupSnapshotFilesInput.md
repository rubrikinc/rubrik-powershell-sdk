### RestoreVolumeGroupSnapshotFilesInput
Input for restoring volume group snapshot files.

- id: System.String
  - Required. ID of Snapshot.
- nextSnapshotFid: System.String
  - The FID of the next fileset snapshot.
- config: VolumeGroupRestoreFilesConfigInput
  - Configuration information for a job to download files and folders from a volume group backup.
- deltaTypeFilter: list of DeltaTypes
  - Filter for delta type.
