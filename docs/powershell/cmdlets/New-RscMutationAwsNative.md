# New-RscMutationAwsNative
## Subcommands
### excludeebsvolumesfromsnapshot
ExcludeAwsNativeEbsVolumesFromSnapshot marks EBS volumes attached to an
EC2 instance as excluded from, or included in, that instance's
snapshots. The change is applied atomically.

- There is a single argument of type ExcludeAwsNativeEbsVolumesFromSnapshotInput.
- Returns System.String.
### startaccountdisablejob
StartAwsNativeAccountDisableJob starts the job that disables one
protection feature of an AWS Native account, optionally deleting the
snapshots the feature took.

- There is a single argument of type StartAwsNativeAccountDisableJobInput.
- Returns AsyncJobStatus.
### startcreateebsvolumesnapshotsjob
StartCreateAwsNativeEbsVolumeSnapshotsJob starts on-demand snapshot jobs
for a list of EBS volumes. Each volume id succeeds or fails
independently, so the reply reports a job id for every volume a job was
submitted for and an error for every volume it was not.

- There is a single argument of type StartCreateAwsNativeEbsVolumeSnapshotsJobInput.
- Returns BatchAsyncJobStatus.
### startec2instancesnapshotsjob
StartAwsNativeEc2InstanceSnapshotsJob starts on-demand snapshot jobs for
a list of EC2 instances. Each instance id succeeds or fails
independently, so the reply reports a job id for every instance a job
was submitted for and an error for every instance it was not.

- There is a single argument of type StartAwsNativeEc2InstanceSnapshotsJobInput.
- Returns BatchAsyncJobStatus.
### startexportebsvolumesnapshotjob
StartExportAwsNativeEbsVolumeSnapshotJob starts an on-demand job that
exports an EBS volume snapshot into a new EBS volume, optionally
replacing the volume attached to the source EC2 instance.

- There is a single argument of type StartExportAwsNativeEbsVolumeSnapshotJobInput.
- Returns AsyncJobStatus.
### startrdsinstancesnapshotsjob
StartAwsNativeRdsInstanceSnapshotsJob starts on-demand snapshot jobs for
a list of RDS or Aurora instances. Each resource id succeeds or fails
independently, so the reply reports a job id for every instance a job was
submitted for and an error for every instance it was not.

- There is a single argument of type StartAwsNativeRdsInstanceSnapshotsJobInput.
- Returns BatchAsyncJobStatus.
### startrefreshaccountsjob
StartRefreshAwsNativeAccountsJob starts on-demand refresh jobs for a list
of AWS Native accounts. Each account id succeeds or fails independently,
so the reply reports a job id for every account a job was submitted for
and an error for every account it was not.

- There is a single argument of type StartRefreshAwsNativeAccountsJobInput.
- Returns BatchAsyncJobStatus.
### startrestoreec2instancesnapshotjob
StartRestoreAwsNativeEc2InstanceSnapshotJob starts an in-place restore of
an EC2 instance from one of its snapshots. A retrieval tier the caller
leaves unset is read as the bulk tier.

- There is a single argument of type StartRestoreAwsNativeEc2InstanceSnapshotJobInput.
- Returns AsyncJobStatus.
