# Invoke-RscMutateOracle
## Subcommands
### bulkUpdateDatabase
Update Oracle Databases

Supported in v5.2+
Update the properties of the objects that represent the specified Oracle Databases.

- The Input parameter takes a single value of type BulkUpdateOracleDatabasesInput.
- Returns BulkUpdateOracleDatabasesReply.
### bulkUpdateHost
Update Oracle Hosts

Supported in v5.2+
Update properties to Oracle Host objects.

- The Input parameter takes a single value of type BulkUpdateOracleHostsInput.
- Returns BulkUpdateOracleHostsReply.
### bulkUpdateRac
Update Oracle RACs

Supported in v5.2+
Update the properties of the objects that represent the specified Oracle RAC.

- The Input parameter takes a single value of type BulkUpdateOracleRacsInput.
- Returns BulkUpdateOracleRacsReply.
### createPdbRestore
Restore PDBs on an Oracle database

Supported in v8.0+
Initiates an asynchronous request to restore PDBs on an Oracle database from a specified snapshot or timestamp.

- The Input parameter takes a single value of type CreateOraclePdbRestoreInput.
- Returns AsyncRequestStatus.
### deleteAllDatabaseSnapshot
Delete Oracle database snapshots

Supported in v5.0+
Delete all snapshots for a specified Oracle database object. For the operation to succeed the referenced database must not be assigned to an SLA Domain.

- The Input parameter takes a single value of type DeleteAllOracleDatabaseSnapshotsInput.
- Returns System.String.
### deleteMount
Delete an Oracle database Live Mount

Supported in v5.0+
Request an asynchronous job to delete a specified Live Mount of an Oracle database snapshot. Poll the job status by using /oracle/request/{id}.

- The Input parameter takes a single value of type DeleteOracleMountInput.
- Returns AsyncRequestStatus.
### downloadDatabaseSnapshot
Download Oracle snapshot from cloud

Supported in v5.0+
Create an asynchronous job to download an Oracle database snapshot and associated logs using the snapshot ID. The response includes the ID of the asynchronous job request. To see the status of the request, poll /oracle/request/{id}.

- The Input parameter takes a single value of type DownloadOracleDatabaseSnapshotInput.
- Returns AsyncRequestStatus.
### exportDatabase
Export an Oracle database

Supported in v5.0+
Request an asynchronous job to export an Oracle database from a specified snapshot or timestamp.

- The Input parameter takes a single value of type ExportOracleDatabaseInput.
- Returns AsyncRequestStatus.
### exportTablespace
Export an Oracle tablespace

Supported in v5.0+
Request an asynchronous job to export an Oracle tablespace from a specified snapshot or timestamp.

- The Input parameter takes a single value of type ExportOracleTablespaceInput.
- Returns AsyncRequestStatus.
### instantRecoverSnapshot
Instant recovery of a database

Supported in v5.0+
Creates an instant recover request that restores a target database from the given snapshot.

- The Input parameter takes a single value of type InstantRecoverOracleSnapshotInput.
- Returns AsyncRequestStatus.
### mountDatabase
Live Mount an Oracle database snapshot

Supported in v5.0+
Create an asynchronous job to Live Mount an Oracle database from a snapshot.

- The Input parameter takes a single value of type MountOracleDatabaseInput.
- Returns AsyncRequestStatus.
### refreshDatabase
Refresh an Oracle database

Supported in v6.0+
Starts an asynchronous job to refresh the Oracle database metadata by querying the database instances on all the underlying hosts.

- The Input parameter takes a single value of type RefreshOracleDatabaseInput.
- Returns AsyncRequestStatus.
### restoreLog
Restore archive logs of an Oracle database

Supported in v6.0+
v6.0: Create an asynchronous job to restore archive logs of an Oracle database.
v7.0+: Starts an asynchronous job to restore archive logs of an Oracle database.

- The Input parameter takes a single value of type RestoreOracleLogsInput.
- Returns AsyncRequestStatus.
### takeOnDemandDatabaseSnapshot
On-demand backup of an Oracle database

Supported in v5.0+
Create an asynchronous job for an on-demand snapshot of an Oracle database. The response includes an ID for the asynchronous job request. To see the status of the request, poll /oracle/request/{id}.

- The Input parameter takes a single value of type TakeOnDemandOracleDatabaseSnapshotInput.
- Returns AsyncRequestStatus.
### takeOnDemandLogSnapshot
On-demand log backup for an Oracle database log

Supported in v5.0+
Create an asynchronous job for an on-demand backup of an Oracle database log. The response includes an ID for the asynchronous job request.  To see the status of the request, poll /oracle/request/{id}.

- The Input parameter takes a single value of type TakeOnDemandOracleLogSnapshotInput.
- Returns AsyncRequestStatus.
### updateDataGuardGroup
Update an Oracle Data Guard group

Supported in v6.0+
Update properties of an Oracle Data Guard group object.

- The Input parameter takes a single value of type UpdateOracleDataGuardGroupInput.
- Returns OracleDbDetail.
### validateAcoFile
Validate Oracle ACO file

Supported in v6.0+
Validate the provided Oracle ACO (Advanced Cloning Options) file.

- The Input parameter takes a single value of type ValidateOracleAcoFileInput.
- Returns ValidateOracleAcoFileReply.
### validateDatabaseBackup
Validate Oracle database backups

Supported in v5.3+
Queue a job to validate Oracle backups for a database snapshot or a specified timestamp.

- The Input parameter takes a single value of type ValidateOracleDatabaseBackupsInput.
- Returns AsyncRequestStatus.
