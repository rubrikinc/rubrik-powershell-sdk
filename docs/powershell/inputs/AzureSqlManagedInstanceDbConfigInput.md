### AzureSqlManagedInstanceDbConfigInput
Input to configure the SLA Domain for Azure SQL Managed Instance DB.

- logRetentionInDays: System.Int32
  - Specifies the number of days for which the Azure SQL Managed Instance DB logs will be retained. Number of days can range from 1 to 35.
- ltrConfig: AzureSqlLtrConfig
  - Specifies the long-term retention configuration for weekly, monthly, and yearly backups.
