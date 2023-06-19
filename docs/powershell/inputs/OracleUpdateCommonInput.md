### OracleUpdateCommonInput
Supported in v6.0+

- hostLogRetentionHours: System.Int32
  - Supported in v6.0+
      Specifies an interval in hours. For Oracle archived redo log files whose nextTime is before (now - interval), the next log snapshot job will delete them from the host. Set to 0 for inheriting the value from its parent; -1 for immediate deletion; and -2 to skip log deletion.
- hostMount: System.String
  - Supported in v6.0+
      Path where the NFS share is mounted on the host.
- logBackupFrequencyInMinutes: System.Int32
  - Supported in v6.0+
      Specifies an interval in minutes. This interval is the period between successive log backups.
- logRetentionHours: System.Int32
  - Supported in v6.0+
      Specifies an interval in hours. Log backups are retained for the duration of the interval.
- numChannels: System.Int32
  - Supported in v6.0+
      Number of channels used to backup the Oracle database.
- hasLogConfigFromSla: System.Boolean
  - Supported in v7.0+
      Boolean value specifying whether the database obtains the log backup configurations from the SLA Domain.
- shouldEnableHighFileCountSupport: System.Boolean
  - Supported in v8.0+
      Boolean value specifying whether to use the high file count format for database backups.
- shouldUseSecureThriftForDataTransfer: System.Boolean
  - Supported in v8.0+
      Boolean value specifying whether to use secure thrift as the data transfer mechanism between the Rubrik cluster and the Oracle database instead of NFS. The default data transfer mechanism is NFS.
- sectionSizeInGb: System.Int32
  - Supported in Rubrik CDM version 9.0 and later. Specifies the section size, in gigabytes, to be used during database backup.
