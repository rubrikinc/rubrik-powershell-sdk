### StartVolumeGroupMountInput
Input to mount volume group snapshot.

- config: VolumeGroupMountSnapshotJobConfigInput
  - Required. Configuration for the mount request. The mount will expose an SMB address per recovered volume. In addition, if a target host is specified, each volume must specify a mount path. If a target host is specified but no mount paths are, they will be generated for every volume. In all cases, a single SMB share will be created for this mount. If a target host is specified, the share will only be accessible by that host.
- id: System.String
  - Required. ID of snapshot.
