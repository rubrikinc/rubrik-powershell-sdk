### FilesetDetail
Supported in v5.0+

- archiveStorage: System.Int64
  - Supported in v5.0+
- archivedSnapshotCount: System.Int32
  - Supported in v5.0+
- backupScriptErrorHandling: System.String
  - Supported in v5.0+
Action taken if script fails. Options are "abort", "continue".
- backupScriptTimeout: System.Int64
  - Supported in v5.0+
Number of seconds after which the script is killed if it has not completed execution.
- localStorage: System.Int64
  - Supported in v5.0+
- postBackupScript: System.String
  - Supported in v5.0+
Script to run after backup of this Fileset ends.
- preBackupScript: System.String
  - Supported in v5.0+
Script to run before backup of this Fileset starts.
- protectionDate: DateTime
  - Supported in v5.0+
- snapshotCount: System.Int32
  - Required. Supported in v5.0+
- snapshots: list of FilesetSnapshotSummarys
  - Supported in v5.0+
- filesetSummary: FilesetSummary
- filesetUpdate: FilesetUpdate
