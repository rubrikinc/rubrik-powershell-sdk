# Invoke-RscMutateMssql
## Subcommands
### assignSlaDomainPropertie
Assign SLA domain properties to Mssql objects.

- The Input parameter takes a single value of type AssignMssqlSlaDomainPropertiesInput.
- Returns ResponseSuccess.
### assignSlaDomainPropertiesAsync
Assign SLA domain properties to Mssql objects.

- The Input parameter takes a single value of type AssignMssqlSlaDomainPropertiesAsyncInput.
- Returns AssignMssqlSlaDomainPropertiesAsyncReply.
### browseDatabaseSnapshot
List snapshots and logs from a Mssql Database. This endpoint is only used to fetch data, but uses a mutation instead of a query due to limitations with the CDM API.

- The Input parameter takes a single value of type BrowseMssqlDatabaseSnapshotInput.
- Returns BrowseMssqlDatabaseSnapshotReply.
### bulkCreateOnDemandBackup
Take a bulk on-demand backup of a Microsoft SQL Database.

- The Input parameter takes a single value of type BulkCreateOnDemandMssqlBackupInput.
- Returns AsyncRequestStatus.
### bulkUpdateDb
Update multiple Microsoft SQL databases with the specified properties.

- The Input parameter takes a single value of type BulkUpdateMssqlDbsInput.
- Returns BulkUpdateMssqlDbsReply.
### createLiveMount
Create live mount of a Microsoft SQL Database.

- The Input parameter takes a single value of type CreateMssqlLiveMountInput.
- Returns AsyncRequestStatus.
### createLogShippingConfiguration
Create log shipping configuration of a Microsoft SQL Database.

- The Input parameter takes a single value of type CreateMssqlLogShippingConfigurationInput.
- Returns AsyncRequestStatus.
### createOnDemandBackup
Take an on-demand backup of a Microsoft SQL Database

- The Input parameter takes a single value of type CreateOnDemandMssqlBackupInput.
- Returns AsyncRequestStatus.
### deleteDbSnapshot
Delete snapshots of a Microsoft SQL Database.

- The Input parameter takes a single value of type DeleteMssqlDbSnapshotsInput.
- Returns ResponseSuccess.
### deleteLiveMount
Delete a Live Mount of a SQL Server database

Supported in v5.0+
Create an async request to delete a Live Mount of a SQL Server database. Poll the task status by using /mssql/request/{id}.

- The Input parameter takes a single value of type DeleteMssqlLiveMountInput.
- Returns AsyncRequestStatus.
### downloadDatabaseBackupFile
Downloads a list of snapshot and log backups from a Microsoft SQL database

Supported in v5.2+
Downloads a list of snapshot and log backups from a Microsoft SQL database.

- The Input parameter takes a single value of type DownloadMssqlDatabaseBackupFilesInput.
- Returns AsyncRequestStatus.
### downloadDatabaseFilesFromArchivalLocation
Download Microsoft SQL Database backup files from archival location.

- The Input parameter takes a single value of type DownloadMssqlDatabaseFilesFromArchivalLocationInput.
- Returns AsyncRequestStatus.
### exportDatabase
Create a request to export a Microsoft SQL database.

- The Input parameter takes a single value of type ExportMssqlDatabaseInput.
- Returns AsyncRequestStatus.
### restoreDatabase
Create a request to restore a Microsoft SQL database.

- The Input parameter takes a single value of type RestoreMssqlDatabaseInput.
- Returns AsyncRequestStatus.
### takeLogBackup
Take an on-demand log backup for a Microsoft SQL database.

- The Input parameter takes a single value of type TakeMssqlLogBackupInput.
- Returns AsyncRequestStatus.
### updateDefaultPropertie
Update the default properties for Microsoft SQL databases.

- The Input parameter takes a single value of type UpdateMssqlDefaultPropertiesInput.
- Returns UpdateMssqlDefaultPropertiesReply.
### updateLogShippingConfiguration
Update log shipping configuration of a Microsoft SQL Database.

- The Input parameter takes a single value of type UpdateMssqlLogShippingConfigurationInput.
- Returns UpdateMssqlLogShippingConfigurationReply.
