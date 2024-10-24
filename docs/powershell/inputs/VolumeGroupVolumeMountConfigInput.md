### VolumeGroupVolumeMountConfigInput
Supported in v5.0+

- mountPointOnHost: System.String
  - Supported in v5.0+
      v5.0-v9.2: The path on the Host on which the Volume will be mounted. It must be either an untaken drive letter name, a directory that does not exist but on a valid drive letter, or an empty directory that already exists.
      v9.3: The path on the host on which the volume is mounted. It must be an unused drive letter name, a directory that does not exist but on a valid drive letter, or an empty directory that already exists.
- volumeId: System.String
  - Required. Supported in v5.0+
      ID of the Volume to mount.
