### FilesetCreateInput
Supported in v5.0+

- arraySpec: FilesetArraySpecInput
  - Supported in v5.0+
- hostId: System.String
  - Supported in v5.0+
- isPassthrough: System.Boolean
  - Supported in v5.0+
v5.0: A Boolean value that determines whether to take a direct archive backup. When 'true,' performs a direct archive backup. When 'false,' performs a normal backup.
v5.1+: A Boolean value that determines whether to take a direct archive backup. When 'true,' performs a direct archive backup. When 'false,' performs a normal backup. If not specified, this defaults to false.
- shareId: System.String
  - Supported in v5.0+
- templateId: System.String
  - Required. Supported in v5.0+
- enableHardlinkSupport: System.Boolean
  - Supported in v5.1+
A Boolean value that determines whether to recognize and dedupe hardlinks in a fileset. When 'true,' performs a hardlink deduplication. When 'false,' performs a normal backup that treats hardlinks as normal files. If not specified, this defaults to false.
- enableSymlinkResolution: System.Boolean
  - Supported in v5.1+
A Boolean value that determines whether to resolve symlink in a fileset. When 'true,' performs a symlink resolution. When 'false,' performs no symlink resolution. If not specified, this defaults to false.
- failoverClusterAppId: System.String
  - Supported in v5.2+
ID of the failover cluster app.
- snapMirrorLabelForFullBackup: System.String
  - Supported in v5.3+
Rubrik CDM uses a prefix match to select the latest SnapMirror snapshot that matches this value during a full backup of a SnapMirror destination share.
- snapMirrorLabelForIncrementalBackup: System.String
  - Supported in v5.3+
Rubrik CDM selects the latest SnapMirror snapshot that matches this value using a prefix match during an incremental backup of a SnapMirror destination share.
- isManagedByPolaris: System.Boolean
  - Specifies whether the fileset is managed by Rubrik Security Cloud.
- isPolarisNasModel: System.Boolean
  - Specifies whether the fileset is created in Rubrik Security Cloud and is based on the new NAS model.
