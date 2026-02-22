### AzureSqlLtrConfigType
AzureSqlLtrConfig specifies the long-term retention (LTR) configuration
for Azure SQL databases. It defines retention policies for weekly, monthly,
and yearly backups.

- weeklyBackupRetention: AzureSqlLtrRetentionType
  - Specifies the retention policy for weekly backups.
- monthlyBackupRetention: AzureSqlLtrRetentionType
  - Specifies the retention policy for monthly backups.
- yearlyBackupRetention: AzureSqlYearlyLtrRetentionType
  - Specifies the retention policy for yearly backups, including the specific
week of the year for the backup.
