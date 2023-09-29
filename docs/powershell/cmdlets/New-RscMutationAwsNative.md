# New-RscMutationAwsNative
## Subcommands
### excludeebsvolumesfromsnapshot
Mark AWS Native EBS Volumes to be excluded from EC2 Instance snapshot. By default, all EBS Volumes are marked as included.

- There is a single argument of type ExcludeAwsNativeEbsVolumesFromSnapshotInput.
- Returns System.String.
### startaccountdisablejob
Starts a job to disable a specific AWS Native account. When complete, the job will disable protection for the specified AWS Native account.

- There is a single argument of type StartAwsNativeAccountDisableJobInput.
- Returns AsyncJobStatus.
### startcreateebsvolumesnapshotsjob
Start job to create snapshots of EBS Volumes with given IDs. When completed, this will start taking an on-demand snapshot of the selected EBS Volumes  as per the SLA Policy assigned to the respective volumes.

- There is a single argument of type StartCreateAwsNativeEbsVolumeSnapshotsJobInput.
- Returns BatchAsyncJobStatus.
### startec2instancesnapshotsjob
Start an on demand create snapshot job for AWS EC2 Instances.When completed, this will start taking an on-demand snapshot of the selected EC2 Instances  as per the SLA Policy assigned to the respective instances.

- There is a single argument of type StartAwsNativeEc2InstanceSnapshotsJobInput.
- Returns BatchAsyncJobStatus.
### startexportebsvolumesnapshotjob
Start a job to export EBS Volume. The job creates a new EBS Volume with the same properties as that of the snapshot that is exported.

- There is a single argument of type StartExportAwsNativeEbsVolumeSnapshotJobInput.
- Returns AsyncJobStatus.
### startrdsinstancesnapshotsjob
Start job to create snapshots of RDS Instance with given IDs. When completed, this will start taking an on-demand snapshot of the selected RDS Instances  as per the SLA Policy assigned to the respective instances.

- There is a single argument of type StartAwsNativeRdsInstanceSnapshotsJobInput.
- Returns BatchAsyncJobStatus.
### startrefreshaccountsjob
Start an on demand job to refresh AWS accounts. The job updates the Rubrik platform with changes to the AWS Native accounts.

- There is a single argument of type StartRefreshAwsNativeAccountsJobInput.
- Returns BatchAsyncJobStatus.
### startrestoreec2instancesnapshotjob
Start an on demand restore snapshot job for AWS EC2 Instance. When completed, this will replace the original EC2 Instance with the selected snapshot.

- There is a single argument of type StartRestoreAwsNativeEc2InstanceSnapshotJobInput.
- Returns AsyncJobStatus.
