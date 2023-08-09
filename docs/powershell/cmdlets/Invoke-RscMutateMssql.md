# Invoke-RscMutateMssql
## Subcommands
### assignsladomainproperties
Assign SLA domain properties to Mssql objects.

- There is a single argument of type AssignMssqlSlaDomainPropertiesInput.
- Returns ResponseSuccess.
### assignsladomainpropertiesasync
Assign SLA domain properties to Mssql objects.

- There is a single argument of type AssignMssqlSlaDomainPropertiesAsyncInput.
- Returns AssignMssqlSlaDomainPropertiesAsyncReply.
### browsedatabasesnapshot
List snapshots and logs from a Mssql Database. This endpoint is only used to fetch data, but uses a mutation instead of a query due to limitations with the CDM API.

- There is a single argument of type BrowseMssqlDatabaseSnapshotInput.
- Returns BrowseMssqlDatabaseSnapshotReply.
### bulkcreateondemandbackup
Take a bulk on-demand backup of a Microsoft SQL Database.

- There is a single argument of type BulkCreateOnDemandMssqlBackupInput.
- Returns AsyncRequestStatus.
### bulkupdatedbs
Update multiple Microsoft SQL databases with the specified properties.

- There is a single argument of type BulkUpdateMssqlDbsInput.
- Returns BulkUpdateMssqlDbsReply.
### createlivemount
Create live mount of a Microsoft SQL Database.

- There is a single argument of type CreateMssqlLiveMountInput.
- Returns AsyncRequestStatus.
### createlogshippingconfiguration
Create log shipping configuration of a Microsoft SQL Database.

- There is a single argument of type CreateMssqlLogShippingConfigurationInput.
- Returns AsyncRequestStatus.
### createondemandbackup
Take an on-demand backup of a Microsoft SQL Database

- There is a single argument of type CreateOnDemandMssqlBackupInput.
- Returns AsyncRequestStatus.
### deletedbsnapshots
Delete snapshots of a Microsoft SQL Database.

- There is a single argument of type DeleteMssqlDbSnapshotsInput.
- Returns ResponseSuccess.
### deletelivemount
Delete a Live Mount of a SQL Server database

Supported in v5.0+
Create an async request to delete a Live Mount of a SQL Server database. Poll the task status by using /mssql/request/{id}.

- There is a single argument of type DeleteMssqlLiveMountInput.
- Returns AsyncRequestStatus.
### downloaddatabasebackupfiles
Downloads a list of snapshot and log backups from a Microsoft SQL database

Supported in v5.2+
Downloads a list of snapshot and log backups from a Microsoft SQL database.

- There is a single argument of type DownloadMssqlDatabaseBackupFilesInput.
- Returns AsyncRequestStatus.
### downloaddatabasefilesfromarchivallocation
Download Microsoft SQL Database backup files from archival location.

- There is a single argument of type DownloadMssqlDatabaseFilesFromArchivalLocationInput.
- Returns AsyncRequestStatus.
### exportdatabase
Create a request to export a Microsoft SQL database.

- There is a single argument of type ExportMssqlDatabaseInput.
- Returns AsyncRequestStatus.
### restoredatabase
Create a request to restore a Microsoft SQL database.

- There is a single argument of type RestoreMssqlDatabaseInput.
- Returns AsyncRequestStatus.
### takelogbackup
Take an on-demand log backup for a Microsoft SQL database.

- There is a single argument of type TakeMssqlLogBackupInput.
- Returns AsyncRequestStatus.
### updatedefaultproperties
Update the default properties for Microsoft SQL databases.

- There is a single argument of type UpdateMssqlDefaultPropertiesInput.
- Returns UpdateMssqlDefaultPropertiesReply.
### updatelogshippingconfiguration
Update log shipping configuration of a Microsoft SQL Database.

- There is a single argument of type UpdateMssqlLogShippingConfigurationInput.
- Returns UpdateMssqlLogShippingConfigurationReply.
