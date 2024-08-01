### FilesetTemplateCreateInput
Supported in v5.0+

- backupScriptErrorHandling: System.String
  - Supported in v5.0+
      Action taken if script fails. Options are "abort", "continue".
- backupScriptTimeout: System.Int64
  - Supported in v5.0+
      Number of seconds after which the script is killed if it has not completed execution.
- exceptions: list of System.Strings
  - Supported in v5.0+
- excludes: list of System.Strings
  - Supported in v5.0+
- isArrayEnabled: System.Boolean
  - Supported in v5.0+
      Boolean value that determines whether the fileset is array-enabled. Set to true to indicate that the fileset is array-enabled. Set to false to indicate that the fileset is not array-enabled. When a fileset is array-enabled, the includes must be top-level LVM logical volume mount points.
- postBackupScript: System.String
  - Supported in v5.0+
      Script to run after backup of this fileset ends.
- preBackupScript: System.String
  - Supported in v5.0+
      Script to run before backup of this fileset starts.
- isCreatedByKupr: System.Boolean
  - Supported in v7.0+
      Specifies whether this is created by a Kupr Host.
- isCreatedByPolarisNas: System.Boolean
  - Specifies whether the template was created for Rubrik Security Cloud NAS.
- operatingSystemType: FilesetTemplateCreateOperatingSystemType
  - Supported in v5.0+
      Operating system type of filesets created by template.
- shareType: FilesetTemplateCreateShareType
  - Supported in v5.0+
- filesetOptions: FilesetOptionsInput
  - Fileset options.
- includes: list of System.Strings
  - Required. Supported in v5.0+
- name: System.String
  - Required. Supported in v5.0+
