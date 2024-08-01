### DbLogReportSummary
Supported in v5.3+

- id: System.String
  - Required. Supported in v5.3+
- name: System.String
  - Required. Supported in v5.3+
  Name of the database.
- lastSnapshotTime: DateTime
  - Supported in v5.3+
  Time, in UTC, of the last database backup.
- logBackupDelay: System.Int64
  - Supported in v5.3+
  Amount of time, in seconds, that has elapsed since the next expected log backup.
- primaryClusterId: System.String
  - Required. Supported in v5.3+
  ID of the primary Rubrik cluster on which the database is located.
- latestRecoveryTime: DateTime
  - Supported in v5.3+
  Latest point in time, in UTC, to which the database can be restored.
- effectiveSlaDomainId: System.String
  - Required. Supported in v5.3+
  ID of the SLA Domain controlling the database protection.
- effectiveSlaDomainName: System.String
  - Required. Supported in v5.3+
  Name of the SLA Domain controlling the database protection.
- logBackupFrequency: System.Int32
  - Supported in v5.3+
  Frequency, in seconds, of the database log backup.
- location: System.String
  - Required. Supported in v5.3+
  Location of the customer database. For a standalone SQL database, this includes the host and instance name.
- databaseType: DatabaseType
  - The type of the database.
