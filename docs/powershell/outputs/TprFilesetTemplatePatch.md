### TprFilesetTemplatePatch
Fileset template patch.

- backupScriptErrorHandling: System.String
  - Action taken if script fails. Options are 'abort' and 'continue'.
- exceptions: list of System.Strings
  - Paths that are exceptions to the excluded paths.
- excludes: list of System.Strings
  - Paths to exclude from the fileset.
- id: System.String
  - ID of the fileset template.
- includes: list of System.Strings
  - Paths to include in the fileset.
- name: System.String
  - Name of the fileset template.
- postBackupScript: System.String
  - Script to run after backup of this fileset ends.
- preBackupScript: System.String
  - Script to run before backup of this fileset starts.
- templateBlocklistedFilesystemPaths: System.String
  - Comma-separated list of blocklisted filesystem paths specific to this template.
- shouldRetryPrescriptIfBackupFails: System.Boolean
  - Specifies whether to retry the pre-backup script if the backup fails.
- shouldOverrideClusterWideBlocklistedFilesystemPaths: System.Boolean
  - Specifies whether to override the cluster-wide blocklisted filesystem paths.
- filesetOptions: TprFilesetOptions
  - Fileset options.
