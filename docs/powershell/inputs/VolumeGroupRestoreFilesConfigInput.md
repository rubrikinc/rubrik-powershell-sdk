### VolumeGroupRestoreFilesConfigInput
Supported in v5.0+

- targetHostId: System.String
  - Supported in v5.0+
      Windows Host ID to restore files to. If left empty, the host ID of the Volume Group will be used.
- restoreConfigs: list of VolumeGroupRestoreFileConfigInputs
  - Required. Supported in v5.0+
      Directory of folder to copy files into.
