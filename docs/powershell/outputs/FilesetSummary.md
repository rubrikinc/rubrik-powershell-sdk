### FilesetSummary
Supported in v5.0+

- arraySpec: FilesetArraySpec
  - Supported in v5.0+
- effectiveSlaDomainId: System.String
  - Supported in v5.0+
  v5.0: The ID of the effective SLA domain for this Fileset
  v5.1+: The ID of the effective SLA Domain for this fileset.
- effectiveSlaDomainName: System.String
  - Supported in v5.0+
  v5.0: The name of the effective SLA domain for this Fileset
  v5.1+: The name of the effective SLA Domain for this fileset.
- effectiveSlaDomainPolarisManagedId: System.String
  - Supported in v5.0+
  v5.0: Optional field containing Polaris managed id of the effective SLA domain if it is Polaris managed.
  v5.1+: Optional field containing Polaris managed ID of the effective SLA domain if it is Polaris managed.
- exceptions: list of System.Strings
  - Supported in v5.0+
- excludes: list of System.Strings
  - Supported in v5.0+
- hostId: System.String
  - Supported in v5.0+
- hostName: System.String
  - Required. Supported in v5.0+
- includes: list of System.Strings
  - Required. Supported in v5.0+
- isPassthrough: System.Boolean
  - Supported in v5.0+
  v5.0: A Boolean value that determines whether to take a direct archive backup. When 'true,' performs a direct archive backup. When 'false,' performs a normal backup.
  v5.1+: A Boolean value that determines whether to take a direct archive backup. When 'true,' performs a direct archive backup. When 'false,' performs a normal backup. If not specified, this defaults to false.
- isRelic: System.Boolean
  - Required. Supported in v5.0+
- operatingSystemType: System.String
  - Supported in v5.0+
- shareId: System.String
  - Supported in v5.0+
- templateId: System.String
  - Required. Supported in v5.0+
- templateName: System.String
  - Required. Supported in v5.0+
- enableHardlinkSupport: System.Boolean
  - Supported in v5.1+
  A Boolean value that determines whether to recognize and dedupe hardlinks in a fileset. When 'true,' performs a hardlink deduplication. When 'false,' performs a normal backup that treats hardlinks as normal files. If not specified, this defaults to false.
- enableSymlinkResolution: System.Boolean
  - Supported in v5.1+
  A Boolean value that determines whether to resolve symlink in a fileset. When 'true,' performs a symlink resolution. When 'false,' performs no symlink resolution. If not specified, this defaults to false.
- isEffectiveSlaDomainRetentionLocked: System.Boolean
  - Supported in v5.1+
  An optional Boolean value that specifies whether the effective SLA Domain of a fileset is Retention Locked. When this value is 'true,' the SLA Domain is retention locked. When this value is 'false,' the SLA Domain is not Retention Locked.
- failoverClusterAppId: System.String
  - Supported in v5.2+
  ID of the failover cluster app.
- pendingSlaDomain: ManagedObjectPendingSlaInfo
  - Supported in v5.2+
  v5.2: Describes any pending SLA Domain assignment to this object.
  v5.3+: Describes any pending SLA Domain assignment on this object.
- failoverClusterAppName: System.String
  - Supported in v5.3+
  The name of the failover cluster app.
- snapMirrorLabelForFullBackup: System.String
  - Supported in v5.3+
  Rubrik CDM uses a prefix match to select the latest SnapMirror snapshot that matches this value during a full backup of a SnapMirror destination share.
- snapMirrorLabelForIncrementalBackup: System.String
  - Supported in v5.3+
  Rubrik CDM selects the latest SnapMirror snapshot that matches this value using a prefix match during an incremental backup of a SnapMirror destination share.
- filesetOptions: FilesetOptions
  - 
- slaAssignable: SlaAssignable
  - 
