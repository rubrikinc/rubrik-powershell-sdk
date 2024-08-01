### OnboardingModeBackupStats
Stores the backup stats of a workload type in on-boarding mode.

- backupStatsBuckets: list of BackupStatsBuckets
  - Contains backup stats in different time range buckets.
- numFullsSucceeded: System.Int32
  - Total number of fulls succeeded in the chosen time range.
- numFullsFailed: System.Int32
  - Total number of fulls failed in the chosen time range.
- numItemsBackedUp: System.Int64
  - Total number of items backed up in the chosen time range.
