# Invoke-RscMutateMssql
## Subcommands
### Assignsladomainpropertie
Assign SLA domain properties to Mssql objects.

- There is a single argument of type AssignMssqlSlaDomainPropertiesInput.
- Returns ResponseSuccess.
### Assignsladomainpropertiesasync
Assign SLA domain properties to Mssql objects.

- There is a single argument of type AssignMssqlSlaDomainPropertiesAsyncInput.
- Returns AssignMssqlSlaDomainPropertiesAsyncReply.
### Browsedatabasesnapshot
List snapshots and logs from a Mssql Database. This endpoint is only used to fetch data, but uses a mutation instead of a query due to limitations with the CDM API.

- There is a single argument of type BrowseMssqlDatabaseSnapshotInput.
- Returns BrowseMssqlDatabaseSnapshotReply.
### Bulkcreateondemandbackup
Take a bulk on-demand backup of a Microsoft SQL Database.

- There is a single argument of type BulkCreateOnDemandMssqlBackupInput.
- Returns AsyncRequestStatus.
### Bulkupdatedb
Update multiple Microsoft SQL databases with the specified properties.

- There is a single argument of type BulkUpdateMssqlDbsInput.
- Returns BulkUpdateMssqlDbsReply.
### Createlivemount
Create live mount of a Microsoft SQL Database.

- There is a single argument of type CreateMssqlLiveMountInput.
- Returns AsyncRequestStatus.
### Createlogshippingconfiguration
Create log shipping configuration of a Microsoft SQL Database.

- There is a single argument of type CreateMssqlLogShippingConfigurationInput.
- Returns AsyncRequestStatus.
### Createondemandbackup
Take an on-demand backup of a Microsoft SQL Database

- There is a single argument of type CreateOnDemandMssqlBackupInput.
- Returns AsyncRequestStatus.
### Deletedbsnapshot
Delete snapshots of a Microsoft SQL Database.

- There is a single argument of type DeleteMssqlDbSnapshotsInput.
- Returns ResponseSuccess.
### Deletelivemount
Delete a Live Mount of a SQL Server database

Supported in v5.0+
Create an async request to delete a Live Mount of a SQL Server database. Poll the task status by using /mssql/request/{id}.

- There is a single argument of type DeleteMssqlLiveMountInput.
- Returns AsyncRequestStatus.
### Downloaddatabasebackupfile
Downloads a list of snapshot and log backups from a Microsoft SQL database

Supported in v5.2+
Downloads a list of snapshot and log backups from a Microsoft SQL database.

- There is a single argument of type DownloadMssqlDatabaseBackupFilesInput.
- Returns AsyncRequestStatus.
### Downloaddatabasefilesfromarchivallocation
Download Microsoft SQL Database backup files from archival location.

- There is a single argument of type DownloadMssqlDatabaseFilesFromArchivalLocationInput.
- Returns AsyncRequestStatus.
### Exportdatabase
Create a request to export a Microsoft SQL database.

- There is a single argument of type ExportMssqlDatabaseInput.
- Returns AsyncRequestStatus.
### Restoredatabase
Create a request to restore a Microsoft SQL database.

- There is a single argument of type RestoreMssqlDatabaseInput.
- Returns AsyncRequestStatus.
### Takelogbackup
Take an on-demand log backup for a Microsoft SQL database.

- There is a single argument of type TakeMssqlLogBackupInput.
- Returns AsyncRequestStatus.
### Updatedefaultpropertie
Update the default properties for Microsoft SQL databases.

- There is a single argument of type UpdateMssqlDefaultPropertiesInput.
- Returns UpdateMssqlDefaultPropertiesReply.
### Updatelogshippingconfiguration
Update log shipping configuration of a Microsoft SQL Database.

- There is a single argument of type UpdateMssqlLogShippingConfigurationInput.
- Returns UpdateMssqlLogShippingConfigurationReply.
