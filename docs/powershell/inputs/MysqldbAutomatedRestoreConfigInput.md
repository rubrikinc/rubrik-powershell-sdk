### MysqldbAutomatedRestoreConfigInput
Supported in v9.5+
MySQL instance restore configuration.

- mysqldbAutomatedRestoreInstanceDetails: MysqldbAutomatedRestoreInstanceDetailsInput
  - Supported in v9.5+
Configuration to customize the MySQL Instance level restore.
- targetMysqldbInstanceId: System.String
  - Required. Supported in v9.5+
MySQL target instance Id for recovery.
- restoreInfo: RestoreInputInput
  - Required. Supported in v9.5+
Specifies the input required to perform the restore for the given MySQL instance.
- mysqldbAutomatedRestoreConnectionInfo: MysqldbAutomatedRestoreConnectionInfoInput
  - Supported in v9.5+
Credentials to be used during MySQL recovery.
- mysqldbAutomatedRestoreDatabaseDetails: MysqldbAutomatedRestoreDatabaseDetailsInput
  - Supported in v9.5+
Configuration to customize the MySQL Database level restore.
