# New-RscMutationSnapshot
## Subcommands
### batchquarantine
Batch quarantine snapshots.

- There is a single argument of type BatchQuarantineSnapshotInput.
- Returns BatchQuarantineSnapshotReply.
### batchreleasefromquarantine
Release snapshots from quarantine.

- There is a single argument of type BatchReleaseFromQuarantineSnapshotInput.
- Returns BatchReleaseFromQuarantineSnapshotReply.
### bulktierexistings
Bulk tier existing snapshots to cold storage

Supported in v6.0+
Schedules a job to tier existing snapshots of the specified objects to cold storage.

- There is a single argument of type BulkTierExistingSnapshotsInput.
- Returns AsyncRequestStatus.
### createdomaincontroller
On-demand snapshot of an Active Directory Domain Controller

Supported in v9.0+
Initiates an on-demand snapshot job of a specified Active Directory Domain Controller.

- There is a single argument of type CreateDomainControllerSnapshotInput.
- Returns AsyncRequestStatus.
### createdownloadforvolumegroup
Creates a download from archival request

Supported in v5.0+
Download a snapshot from archival.

- There is a single argument of type CreateDownloadSnapshotForVolumeGroupInput.
- Returns AsyncRequestStatus.
### createfileset
- There is a single argument of type CreateFilesetSnapshotInput.
- Returns AsyncRequestStatus.
### deletecloudworkloadsnapshot
Deletes the Rubrik Security Cloud on-demand snapshot by ID.

- There is a single argument of type DeleteCloudWorkloadSnapshotInput.
- Returns System.Boolean.
### deletefilesetsnapshots
- There is a single argument of type DeleteFilesetSnapshotsInput.
- Returns ResponseSuccess.
### filesetdownloadfiles
Download files from a fileset backup

Supported in v5.0+
Start an asynchronous job to download multiple files and folders from a specified fileset backup. The response returns an asynchronous request ID. Get the URL for downloading the ZIP file including the specific files/folders by sending a GET request to 'fileset/request/{id}'.

- There is a single argument of type FilesetDownloadSnapshotFilesInput.
- Returns AsyncRequestStatus.
### filesetexportfiles
Create an export job to export multiple files or directories

Supported in v5.0+
Starts a job that exports one or more files or folders from a fileset backup to the destination host. Returns the job status as of the job creation time. This job status includes the job ID.

- There is a single argument of type FilesetExportSnapshotFilesInput.
- Returns AsyncRequestStatus.
### restoredomaincontroller
Initiate Active Directory restore job

Supported in v9.0+
Initiates a job to restore Active Directory snapshots to their corresponding Domain Controllers or alternate hosts. Returns the job instance ID.

- There is a single argument of type RestoreDomainControllerSnapshotInput.
- Returns AsyncRequestStatus.
### restorevolumegroupfiles
Restore files from the Volume Group snapshot

Supported in v5.0+
Restore filess to the original Host.

- There is a single argument of type RestoreVolumeGroupSnapshotFilesInput.
- Returns AsyncRequestStatus.
### startec2instanceexportjob
Starts a job to export an EC2 Instance snapshot. The job creates a new EC2 Instance with the same properties as that of the snapshot that is exported.

- There is a single argument of type StartEc2InstanceSnapshotExportJobInput.
- Returns AsyncJobStatus.
### startrecovers3job
Starts an on-demand snapshot recovery job for the specified AWS S3 bucket. Returns the ID of the taskchain initiated for the recovery job.

- There is a single argument of type StartRecoverS3SnapshotJobInput.
- Returns AsyncJobStatus.
### takeondemand
Triggers on-demand snapshot for the given workloads.

- There is a single argument of type TakeOnDemandSnapshotInput.
- Returns TakeOnDemandSnapshotReply.
### uploaddatabasetoblobstore
Start a job to upload a database snapshot to a target blobstore.

- There is a single argument of type UploadDatabaseSnapshotToBlobstoreInput.
- Returns AsyncJobStatus.
