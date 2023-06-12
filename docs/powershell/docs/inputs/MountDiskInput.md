### MountDiskInput
Input required to mount disks.

- accountId: System.String
  - Customer account name.
- snapshotId: System.String
  - Snapshot ID from which disk will be mounted.
- targetWorkloadId: System.String
  - Target workload ID on which the disk must be mounted.
- snapshotType: SnapshotType
  - Snapshot types.
- mountDiskIds: list of System.Strings
  - List of disk IDs that would be mounted.
