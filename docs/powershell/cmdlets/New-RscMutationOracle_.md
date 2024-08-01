# New-RscMutationOracle
## Subcommands
### bulkupdatedatabases
Update Oracle Databases

Supported in v5.2+
Update the properties of the objects that represent the specified Oracle Databases.

- There is a single argument of type BulkUpdateOracleDatabasesInput.
- Returns BulkUpdateOracleDatabasesReply.
### bulkupdatehosts
Update Oracle Hosts

Supported in v5.2+
Update properties to Oracle Host objects.

- There is a single argument of type BulkUpdateOracleHostsInput.
- Returns BulkUpdateOracleHostsReply.
### bulkupdateracs
Update Oracle RACs

Supported in v5.2+
Update the properties of the objects that represent the specified Oracle RAC.

- There is a single argument of type BulkUpdateOracleRacsInput.
- Returns BulkUpdateOracleRacsReply.
### createpdbrestore
Restore PDBs on an Oracle database

Supported in v8.0+
Initiates an asynchronous request to restore PDBs on an Oracle database from a specified snapshot or timestamp.

- There is a single argument of type CreateOraclePdbRestoreInput.
- Returns AsyncRequestStatus.
### deletealldatabasesnapshots
Delete Oracle database snapshots

Supported in v5.0+
Delete all snapshots for a specified Oracle database object. For the operation to succeed the referenced database must not be assigned to an SLA Domain.

- There is a single argument of type DeleteAllOracleDatabaseSnapshotsInput.
- Returns System.String.
### deletemount
Delete an Oracle database Live Mount

Supported in v5.0+
Request an asynchronous job to delete a specified Live Mount of an Oracle database snapshot. Poll the job status by using /oracle/request/{id}.

- There is a single argument of type DeleteOracleMountInput.
- Returns AsyncRequestStatus.
### downloaddatabasesnapshot
Download Oracle snapshot from cloud

Supported in v5.0+
Create an asynchronous job to download an Oracle database snapshot and associated logs using the snapshot ID. The response includes the ID of the asynchronous job request. To see the status of the request, poll /oracle/request/{id}.

- There is a single argument of type DownloadOracleDatabaseSnapshotInput.
- Returns AsyncRequestStatus.
### downloadsnapshotfromlocation
Download Oracle snapshot from an archival location

Supported in v9.0+
Initiates an asynchronous job to download an Oracle database snapshot and associated log snapshots using the snapshot ID. The response includes the ID of the asynchronous job request. To see the status of the request, poll /oracle/request/{id}.

- There is a single argument of type DownloadOracleSnapshotFromLocationInput.
- Returns AsyncRequestStatus.
### exportdatabase
Export an Oracle database

Supported in v5.0+
Request an asynchronous job to export an Oracle database from a specified snapshot or timestamp.

- There is a single argument of type ExportOracleDatabaseInput.
- Returns AsyncRequestStatus.
### exporttablespace
Export an Oracle tablespace

Supported in v5.0+
Request an asynchronous job to export an Oracle tablespace from a specified snapshot or timestamp.

- There is a single argument of type ExportOracleTablespaceInput.
- Returns AsyncRequestStatus.
### instantrecoversnapshot
Instant recovery of a database

Supported in v5.0+
Creates an instant recover request that restores a target database from the given snapshot.

- There is a single argument of type InstantRecoverOracleSnapshotInput.
- Returns AsyncRequestStatus.
### mountdatabase
Live Mount an Oracle database snapshot

Supported in v5.0+
Create an asynchronous job to Live Mount an Oracle database from a snapshot.

- There is a single argument of type MountOracleDatabaseInput.
- Returns AsyncRequestStatus.
### refreshdatabase
Refresh an Oracle database

Supported in v6.0+
Starts an asynchronous job to refresh the Oracle database metadata by querying the database instances on all the underlying hosts.

- There is a single argument of type RefreshOracleDatabaseInput.
- Returns AsyncRequestStatus.
### restorelogs
Restore archive logs of an Oracle database

Supported in v6.0+
v6.0: Create an asynchronous job to restore archive logs of an Oracle database.
v7.0+: Starts an asynchronous job to restore archive logs of an Oracle database.

- There is a single argument of type RestoreOracleLogsInput.
- Returns AsyncRequestStatus.
### takeondemanddatabasesnapshot
On-demand backup of an Oracle database

Supported in v5.0+
Create an asynchronous job for an on-demand snapshot of an Oracle database. The response includes an ID for the asynchronous job request. To see the status of the request, poll /oracle/request/{id}.

- There is a single argument of type TakeOnDemandOracleDatabaseSnapshotInput.
- Returns AsyncRequestStatus.
### takeondemandlogsnapshot
On-demand log backup for an Oracle database log

Supported in v5.0+
Create an asynchronous job for an on-demand backup of an Oracle database log. The response includes an ID for the asynchronous job request.  To see the status of the request, poll /oracle/request/{id}.

- There is a single argument of type TakeOnDemandOracleLogSnapshotInput.
- Returns AsyncRequestStatus.
### updatedataguardgroup
Update an Oracle Data Guard group

Supported in v6.0+
Update properties of an Oracle Data Guard group object.

- There is a single argument of type UpdateOracleDataGuardGroupInput.
- Returns OracleDbDetail.
### validateacofile
Validate Oracle ACO file

Supported in v6.0+
Validate the provided Oracle ACO (Advanced Cloning Options) file.

- There is a single argument of type ValidateOracleAcoFileInput.
- Returns ValidateOracleAcoFileReply.
### validatedatabasebackups
Validate Oracle database backups

Supported in v5.3+
Queue a job to validate Oracle backups for a database snapshot or a specified timestamp.

- There is a single argument of type ValidateOracleDatabaseBackupsInput.
- Returns AsyncRequestStatus.
