# New-RscMutationDb2
## Subcommands
### addinstance
Mutation to add a new Db2 instance.

- There is a single argument of type AddDb2InstanceInput.
- Returns AddDb2InstanceReply.
### createondemandbackup
Create on demand database snapshot

Supported in v8.0+
Initiates a job to take an on demand, full snapshot of a specified Db2 database object. Use the GET /db2/db/request/{id} endpoint to monitor the progress of the job.

- There is a single argument of type CreateOnDemandDb2BackupInput.
- Returns AsyncRequestStatus.
### deletedatabase
Delete Db2 database

Supported in v8.1+
Deletes a Db2 database.

- There is a single argument of type DeleteDb2DatabaseInput.
- Returns AsyncRequestStatus.
### deleteinstance
Mutation to delete existing Db2 instance.

- There is a single argument of type DeleteDb2InstanceInput.
- Returns AsyncRequestStatus.
### discoverinstance
On-demand discovery of a Db2 instance

Supported in v7.0+
Initiates an on-demand job to discover a Db2 instance.

- There is a single argument of type DiscoverDb2InstanceInput.
- Returns AsyncRequestStatus.
### downloadsnapshot
Download Db2 database snapshot from archive

Supported in v8.0+
Downloads a specific Db2 database snapshot from the specified archival location.

- There is a single argument of type DownloadDb2SnapshotInput.
- Returns AsyncRequestStatus.
### downloadsnapshotsforpointintimerecovery
Download Db2 database snapshots from archive for a point in time recovery

Supported in v8.0+
Downloads the most recent full snapshot and the log snapshots taken after the full snapshot, required for the point in time recovery of a Db2 database.

- There is a single argument of type DownloadDb2SnapshotsForPointInTimeRecoveryInput.
- Returns AsyncRequestStatus.
### expiredownloadedsnapshots
Expire downloaded snapshots of a Db2 database

Supported in v8.0+
Requests an asynchronous job to expire all downloaded data and log snapshots. You can specify a begin time or an end time or both to provide a time range to expire only the downloaded data and log snapshots that were taken within the specified time range. The time is relative to when the snapshot was originally taken, not when it was downloaded. You can also configure a flag to expire only the log snapshots.

- There is a single argument of type ExpireDownloadedDb2SnapshotsInput.
- Returns AsyncRequestStatus.
### patchdatabase
Update a Db2 database

Supported in v9.0+
Updating a Db2 database involves modifying the metadata associated with the Db2 database using the provided input values.

- There is a single argument of type PatchDb2DatabaseInput.
- Returns PatchDb2DatabaseReply.
### patchinstance
Mutation to update an existing Db2 instance.

- There is a single argument of type PatchDb2InstanceInput.
- Returns PatchDb2InstanceReply.
### refreshdatabase
On-demand refresh of a Db2 database

Supported in v8.1+
Initiates an on-demand job to refresh a Db2 database. Currently, this is allowed only for Db2 HADR databases.

- There is a single argument of type RefreshDb2DatabaseInput.
- Returns AsyncRequestStatus.
