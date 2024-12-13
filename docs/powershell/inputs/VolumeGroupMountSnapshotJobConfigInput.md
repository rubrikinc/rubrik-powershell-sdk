### VolumeGroupMountSnapshotJobConfigInput
Supported in v5.0+

- smbDomainName: System.String
  - Supported in v5.0+
      Domain name of the users that are authenticated to access the SMB share.
- smbValidIps: list of System.Strings
  - Supported in v5.0+
      IP address of the hosts that are authenticated to access the SMB share.
- smbValidUsers: list of System.Strings
  - Supported in v5.0+
      Usernames of the users that are authenticated to access the SMB share.
- targetHostId: System.String
  - Supported in v5.0+
      v5.0-v9.1: Only specified if mounting on a specific Host is desired. If not specified, Rubrik will simply expose addresses of SMB mounts per recovered Volume. If a mount point is specified in any of the volumeConfigs, this must be defined. If this is specified, but no mount points are, Rubrik will generate mount paths to mount on the target Host for each volume.
      v9.2+: Specify only if mounting on a specific host is desired. If not specified, Rubrik exposes addresses of SMB mounts for each recovered volume by default. If a mount point is specified in any of the volumeConfigs, this field must be defined. If a host is specified but no mount points are provided, Rubrik generates mount paths for each volume to mount on the target host.
- volumeConfigs: list of VolumeGroupVolumeMountConfigInputs
  - Required. Supported in v5.0+
      v5.0-v9.1: The configuration of the Volumes to be mounted on the Host.
      v9.2+: The configuration of the Volume Group snapshots to be mounted on the host.
