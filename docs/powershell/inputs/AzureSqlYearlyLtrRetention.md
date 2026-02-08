### AzureSqlYearlyLtrRetention
AzureSqlYearlyLtrRetention specifies the long-term retention (LTR)
configuration for yearly backups in Azure SQL databases, including
the retention period and the specific week of the year for the backup.

- ltrRetention: AzureSqlLtrRetention
  - Specifies the retention duration and unit for yearly backups.
- weekOfYear: System.Int32
  - Specifies the week number (1-52) of the year for which yearly backup
should be retained.
