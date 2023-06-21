### ManagedVolumeSlaExportConfigInput
Supported in v5.3+
  v5.3-v8.0: 
  v8.1+: Config for an SLA Managed Volume Export.

- managedVolumeExportConfig: ManagedVolumeExportConfigInput
  - Configuration for a Managed Volume Export.
- hostId: System.String
  - Required. Supported in v5.3+
      v5.3-v8.0: Managed ID of the host on which this snapshot export is supposed to be mounted.
      v8.1+: Managed ID of the host to mount the snapshot export.
- hostMountPaths: list of System.Strings
  - Required. Supported in v5.3+
      v5.3-v8.0: Valid paths on the host where the NFS/SMB mount points from this snapshot export are to be mounted.
      v8.1+: Valid paths on the host to mount the NFS or SMB mount points from the snapshot export.
