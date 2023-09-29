# New-RscMutationSapHana
## Subcommands
### addsystem
Add a SAP HANA system

Supported in v5.3+
Add a SAP HANA system to the Rubrik cluster.

- There is a single argument of type AddSapHanaSystemInput.
- Returns AddSapHanaSystemReply.
### configurerestore
Configure the target database for system copy restore

Supported in v6.0+
Initiates a job to configure the specified target database for a system copy restore by sending metadata about the source database. System copy restore in SAP HANA is done across different databases.

- There is a single argument of type ConfigureSapHanaRestoreInput.
- Returns AsyncRequestStatus.
### createondemandbackup
Create on demand database snapshot

Supported in v5.3+
Initiates a job to take an on demand full snapshot of a specified SAP HANA database object. The GET /sap_hana/db/request/{id} endpoint can be used to monitor the progress of the job.

- There is a single argument of type CreateOnDemandSapHanaBackupInput.
- Returns AsyncRequestStatus.
### createsystemrefresh
Refresh SAP HANA system metadata

Supported in v5.3+
Initiates a job to refresh metadata of a SAP HANA system object. The GET /sap_hana/system/request/{id} endpoint can be used to monitor the progress of the job.

- There is a single argument of type CreateSapHanaSystemRefreshInput.
- Returns AsyncRequestStatus.
### deletedbsnapshot
Delete a particular full snapshot of a SAP HANA database

Supported in v5.3+
Initiates a request to delete a particular full snapshot of a SAP HANA database. If the log retention period for the database is still in effect, the snapshot will be deleted when the log retention period ends.

- There is a single argument of type DeleteSapHanaDbSnapshotInput.
- Returns ResponseSuccess.
### deletesystem
Delete a SAP HANA system

Supported in v5.3+
Initiates a job to delete a SAP HANA system object. GET /sap_hana/system/request/{id} endpoint can be used to monitor the progress of the job.

- There is a single argument of type DeleteSapHanaSystemInput.
- Returns AsyncRequestStatus.
### expiredownloadedsnapshots
Expire downloaded snapshots of an SAP HANA database

Supported in v8.0+
Requests an asynchronous job to expire all downloaded data and log snapshots. You can specify a begin time or an end time or both to provide a time range to expire only the downloaded data and log snapshots that were taken within the specified time range. The time is relative to when the snapshot was originally taken, not when it was downloaded. You can also configure a flag to expire only the log snapshots.

- There is a single argument of type ExpireDownloadedSapHanaSnapshotsInput.
- Returns AsyncRequestStatus.
### patchsystem
v5.3-v8.1: Update the SLA Domain for a SAP HANA system
v9.0+: Update the system properties of the SAP HANA system

Supported in v5.3+
v5.3-v8.1: Update the SLA Domain that is configured for a SAP HANA system.
v9.0+: Update the system properties for the SAP HANA system.

- There is a single argument of type PatchSapHanaSystemInput.
- Returns PatchSapHanaSystemReply.
### unconfigurerestore
Reset the configuration for system copy restore on target database

Supported in v6.0+
Initiates a job to reset the configuration for the system copy restore on the specified target database. System copy restore in SAP HANA is done across different databases.

- There is a single argument of type UnconfigureSapHanaRestoreInput.
- Returns AsyncRequestStatus.
