### DayToDayModeBackupStats
Stores the backup stats of a workload type in day-to-day mode.

- backupStatsBuckets: list of BackupStatsBuckets
  - Contains backup stats in different time range buckets.
- numFullsSucceeded: System.Int32
  - Total number of fulls succeeded in the chosen time range.
- numFullsFailed: System.Int32
  - Total number of fulls failed in the chosen time range.
- numIncrementalsSucceeded: System.Int32
  - Total number of incrementals succeeded in the chosen time range.
- numIncrementalsFailed: System.Int32
  - Total number of incrementals failed in the chosen time range.
- totalNewObjectsAdded: System.Int32
  - Total number of new objects added in the chosen time range.
