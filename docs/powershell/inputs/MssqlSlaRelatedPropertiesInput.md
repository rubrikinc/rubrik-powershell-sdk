### MssqlSlaRelatedPropertiesInput
Supported in v5.1+

- copyOnly: System.Boolean
  - Supported in v5.1+
      Boolean value that specifies whether or not to perform copy-only backups of the database. When true, database backups are copy-only backups. When false, database backups are full backups.
- logBackupFrequencyInSeconds: System.Int32
  - Supported in v5.1+
      Seconds between two log backups. A value of 0 disables log backup.
- logRetentionHours: System.Int32
  - Supported in v5.1+
      Number of hours to retain a log backup. When the value is set to -1 the Rubrik cluster retains the log backup until the database snapshots that precede the log backup have expired.
- hasLogConfigFromSla: System.Boolean
  - Supported in v7.0+
      A boolean value specifying whether the database obtains the log backup configurations from the SLA Domain.
- hostLogRetention: System.Int32
  - Supported in v9.0
      Specifies the interval, in seconds, the Rubrik cluster waits before the next log backup job deletes MSSQL log files whose 'nextTime' field specifies a time longer than this interval. To specify a wait interval, enter a positive integer. To immediately delete log files regardless of age, specify an interval of -1. To preserve all log files, specify an interval of -2.
