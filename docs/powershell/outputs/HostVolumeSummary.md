### HostVolumeSummary
Supported in v5.0+

- isCurrentlyPresentOnSystem: System.Boolean
  - Required. Supported in v5.0+
v5.0-v5.2: A boolean value that describes whether a volume is present on the host. When 'true', the volume is present. When 'false', the volume is not present. Volumes that are not present on the host are still included in snapshots and trigger warnings until the missing volumes are excluded from snapshots.
v5.3+: Indicates whether a volume is present on the host. When 'true', the volume is present. When 'false', the volume is not present. Volumes that are not present on the host are still included in snapshots and trigger warnings until the missing volumes are excluded from snapshots.
- naturalId: System.String
  - Required. Supported in v5.0+
v5.0-v5.2: Windows ID on the Host
v5.3+: The unique ID of the volume on the Windows host.
- volumeGroupId: System.String
  - Supported in v5.0+
v5.0-v5.2: The Volume Group ID of the volume.
v5.3+: The unique ID of the Volume Group.
- volumeGroupSnapshotVolumeSummary: VolumeGroupSnapshotVolumeSummary
