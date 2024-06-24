# New-RscMutationMssql
## Subcommands
### addhost
Register hosts

Supported in v5.3+
Register multiple hosts and perform discovery for databases and Microsoft SQL Server instances. When called, this API returns a success message, but completes the host registration in the background. Monitor the status of the background host discovery with the "status" field in GET API on /hosts. The POST API on /hosts can take longer for discovery, depending on the number of hosts on the system. POST on this API can be used instead to perform the discovery in the background and quickly register the host. Doing this requires that you install RBS for Linux and Windows hosts, similar to regular register using POST on /hosts.

- There is a single argument of type BulkRegisterHostAsyncInput.
- Returns BulkRegisterHostAsyncReply.
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
### bulkupdateavailabilitygroup
Update multiple Microsoft SQL Availability Groups with the specified properties.

- There is a single argument of type BulkUpdateMssqlAvailabilityGroupInput.
- Returns BulkUpdateMssqlAvailabilityGroupReply.
### bulkupdatedbs
Update multiple Microsoft SQL databases with the specified properties.

- There is a single argument of type BulkUpdateMssqlDbsInput.
- Returns BulkUpdateMssqlDbsReply.
### bulkupdateinstance
Update multiple Microsoft SQL instances with the specified properties.

- There is a single argument of type BulkUpdateMssqlInstanceInput.
- Returns BulkUpdateMssqlInstanceReply.
### bulkupdatepropertiesonhost
Update multiple Microsoft SQL hosts with the specified properties.

- There is a single argument of type BulkUpdateMssqlPropertiesOnHostInput.
- Returns BulkUpdateMssqlPropertiesOnHostReply.
### bulkupdatepropertiesonwindowscluster
Update multiple Microsoft SQL Windows Clusters with the specified properties.

- There is a single argument of type BulkUpdateMssqlPropertiesOnWindowsClusterInput.
- Returns BulkUpdateMssqlPropertiesOnWindowsClusterReply.
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
### deletelogshipping
Delete a specified log shipping configuration.

- There is a single argument of type DeleteLogShippingInput.
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
