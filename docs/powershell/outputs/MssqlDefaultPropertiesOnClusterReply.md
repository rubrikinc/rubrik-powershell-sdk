### MssqlDefaultPropertiesOnClusterReply
Supported in v5.0+

- cbtStatus: System.Boolean
  - Required. Supported in v5.0+
v5.0-v5.2: True to enable CBT based backup, false to disable.
v5.3+: True to enable a CBT-based backup, false to disable a CBT-based backup.
- logBackupFrequencyInSeconds: System.Int64
  - Required. Supported in v5.0+
- logRetentionTimeInHours: System.Int32
  - Supported in v5.3+
- shouldUseDefaultBackupLocation: System.Boolean
  - Supported in v7.0+
Use the default backup location configured in SQL Server for file-based log backups.
