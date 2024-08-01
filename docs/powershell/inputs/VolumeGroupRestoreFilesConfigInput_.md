### VolumeGroupRestoreFilesConfigInput
Supported in v5.0+

- targetHostId: System.String
  - Supported in v5.0+
      Windows Host ID to restore files to. If left empty, the host ID of the Volume Group will be used.
- shouldIgnoreError: System.Boolean
  - Supported in v9.1+
      v9.1: Specifies whether to ignore the error during restoration.
      v9.2+: Specify whether to ignore the error during restoration.
- restoreConfigs: list of VolumeGroupRestoreFileConfigInputs
  - Required. Supported in v5.0+
      Directory of folder to copy files into.
