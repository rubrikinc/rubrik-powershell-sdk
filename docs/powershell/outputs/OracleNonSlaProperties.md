### OracleNonSlaProperties
Supported in v5.0+

- hostMount: System.String
  - Required. Supported in v5.0+
  Path where the NFS share is mounted on the host.
- logBackupFrequencyInMinutes: System.Int32
  - Required. Supported in v5.0+
  Specifies an interval in minutes. This interval is the period between successive log backups.
- logRetentionHours: System.Int32
  - Required. Supported in v5.0+
  Specifies an interval in hours. Log backups are retained for the duration of the interval.
- numChannels: System.Int32
  - Required. Supported in v5.0+
  Number of channels used to backup the Oracle database.
- hostLogRetentionHours: System.Int32
  - Supported in v5.2+
  Specifies an interval in hours. The next log snapshot job deletes archived Oracle redo log files whose 'nextTime' field specifies a time more than the specified number of hours ago. To immediately delete archived redo log files regardless of age, specify an interval of -1. To preserve all archived redo log files, specify an interval of -2.
