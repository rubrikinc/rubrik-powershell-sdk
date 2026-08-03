### DatabaseLogRetentionConfigType
Log retention policy for a single database workload. Used as the
value side of a DatabaseLogRetentionConfigEntry.

- logRetentionInMs: System.Int64
  - Duration in milliseconds for which database transaction logs are
retained at this archival or replication location.
- isDisabled: System.Boolean
  - When true, transaction log backups are turned off for this
workload at this archival or replication location.
