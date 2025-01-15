### FilesetTemplatePatchInput
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
- includes: list of System.Strings
  - Supported in v5.0+
- name: System.String
  - Supported in v5.0+
- postBackupScript: System.String
  - Supported in v5.0+
      Script to run after backup of this Fileset ends.
- preBackupScript: System.String
  - Supported in v5.0+
      Script to run before backup of this Fileset starts.
- isCreatedByKupr: System.Boolean
  - Supported in v7.0+
      Specifies whether this is created by a Kupr Host.
- isCreatedByPolarisNas: System.Boolean
  - Specifies whether the template was created for Rubrik Security Cloud NAS.
- shouldRetryPrescriptIfBackupFails: System.Boolean
  - Supported in v9.3+
      Specifies whether to retry the pre-backup script if the backup fails. If set to true, the pre-backup script will be retried if the backup fails. If set to false, the pre-backup script will not be retried if the backup fails.
- operatingSystemType: FilesetTemplatePatchOperatingSystemType
  - Supported in v5.0+
      Operating system type of filesets created by template.
- shareType: FilesetTemplatePatchShareType
  - Supported in v5.0+
- filesetOptions: FilesetOptionsInput
  - Fileset options.
- id: System.String
  - Required. Supported in v5.0+
