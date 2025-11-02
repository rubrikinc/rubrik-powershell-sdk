### MssqlNonSlaPropertiesInput
Non-SLA-Domain properties of a SQL Server object.

- copyOnly: System.Boolean
  - Supported in v5.0
Boolean value that specifies whether or not to perform copy-only backups of the database. When true, database backups are copy-only backups. When false, database backups are full backups.
- logBackupFrequencyInSeconds: System.Int32
  - Supported in v5.0
Seconds between two log backups. A value of 0 disables log backup.
- logRetentionHours: System.Int32
  - Supported in v5.0
Number of hours to retain a log backup. When the value is set to -1 the Rubrik cluster retains the log backup until the database snapshots that precede the log backup have expired.
