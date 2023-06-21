# Invoke-RscMutateAws
## Subcommands
### Addauthenticationserverbasedcloudaccount
Validates and adds an authentication server-based AWS cloud account. When validation succeeds, the AWS cloud account is added and the features specified in the request are enabled. When validation fails, an error is not returned, but the cause of the failure is specified in the "message" field of the response object.

- There is a single argument of type AddAwsAuthenticationServerBasedCloudAccountInput.
- Returns AddAwsAuthenticationServerBasedCloudAccountReply.
### Addiamuserbasedcloudaccount
Adds an IAM user-based AWS cloud account and enables the features specified in the input after successful validation of the request.

- There is a single argument of type AddAwsIamUserBasedCloudAccountInput.
- Returns AddAwsIamUserBasedCloudAccountReply.
### Cloudaccountinitiate
This endpoint is deprecated.

- There is a single argument of type AwsCloudAccountInitiateInput.
- Returns AwsCloudAccountCreateResponse.
### Cloudaccountupdatefeature
This endpoint is deprecated.

- There are 2 arguments.
    - cloudAccountUuid - System.String: The ID of the cloud account.
    - features - list of CloudAccountFeatures: Cloud Account Features.
- Returns AwsCloudAccountUpdateFeatureResponse.
### Cloudaccountvalidate
This endpoint is deprecated.

- There is a single argument of type AwsCloudAccountValidateInput.
- Returns AwsCloudAccountValidateResponse.
### Createaccount
- There is a single argument of type CreateAwsAccountInput.
- Returns CloudAccount.
### Createautomatictargetmapping
- There is a single argument of type CreateAutomaticAwsTargetMappingInput.
- Returns TargetMapping.
### Createcloudnativestoragesetting
- There is a single argument of type CreateCloudNativeAwsStorageSettingInput.
- Returns CreateCloudNativeAwsStorageSettingReply.
### Createcluster
Create a Rubrik Cloud Cluster on AWS.

- There is a single argument of type CreateAwsClusterInput.
- Returns CcProvisionJobReply.
### Createcomputesetting
- There is a single argument of type CreateAwsComputeSettingInput.
- Returns AwsComputeSettings.
### Createexocomputeconfig
Create AWS Exocompute configs.

- There is a single argument of type CreateAwsExocomputeConfigsInput.
- Returns CreateAwsExocomputeConfigsReply.
### Createreadertarget
Create a reader type for AWS archival location on a Rubrik cluster.

- There is a single argument of type CreateAwsReaderTargetInput.
- Returns Target.
### Createtarget
- There is a single argument of type CreateAwsTargetInput.
- Returns Target.
### Deletecloudaccountwithoutcft
Removes AWS cloud account without cleaning up the associated permissions from the AWS cloud account. Customer needs to clean up the permissions in the AWS account themselves. This mutation is supported only for IAM user-based and authentication server-based AWS cloud accounts.

- There is a single argument of type DeleteAwsCloudAccountWithoutCftInput.
- Returns DeleteAwsCloudAccountWithoutCftReply.
### Deletecluster
Delete a Rubrik Cloud Cluster on AWS.

- There is a single argument of type DeleteAwsClusterInput.
- Returns CcProvisionJobReply.
### Deletecomputesetting
- There is a single argument of type DeleteAwsComputeSettingInput.
- Returns System.String.
### Deleteexocomputeconfig
Deletes AWS Exocompute configs.

- There is a single argument of type DeleteAwsExocomputeConfigsInput.
- Returns DeleteAwsExocomputeConfigsReply.
### Deleteiamuserbasedcloudaccount
Deletes IAM user-based AWS cloud account.

- There is a single argument of type DeleteAwsIamUserBasedCloudAccountInput.
- Returns DeleteAwsIamUserBasedCloudAccountReply.
### Excludenativeebsvolumesfromsnapshot
Mark AWS Native EBS Volumes to be excluded from EC2 Instance snapshot. By default, all EBS Volumes are marked as included.

- There is a single argument of type ExcludeAwsNativeEbsVolumesFromSnapshotInput.
- Returns System.String.
### Finalizecloudaccountdeletion
Process and finalize deletion of cloud account is the last step in deletion of a feature from cloud account. This endpoint is a MUST for deletion of disconnected features.

- There is a single argument of type FinalizeAwsCloudAccountDeletionInput.
- Returns FinalizeAwsCloudAccountDeletionReply.
### Finalizecloudaccountprotection
Process cloud account. This is the second step after validate and create in addition of a feature for cloud account.The CloudFormation stack should be created after this step using the CloudFormation URL provided in the first step.

- There is a single argument of type FinalizeAwsCloudAccountProtectionInput.
- Returns FinalizeAwsCloudAccountProtectionReply.
### Nativeprotectionaccountadd
This endpoint is deprecated.

- There is a single argument of type AwsNativeProtectionAccountAddRequest.
- Returns AwsNativeProtectionAccountAddResponse.
### Patchauthenticationserverbasedcloudaccount
Updates authentication server-based AWS cloud account. Use this mutation to update account details related to role name, certificates, features. The mutation can update one or more certificates associated to an account in a single request. All input fields except account identifier are optional so that any combination of account attributes can be updated in a single call. If none of the optional fields are provided in the input then no updates are performed, and the response does not contain any error message.

- There is a single argument of type PatchAwsAuthenticationServerBasedCloudAccountInput.
- Returns System.Boolean.
### Patchiamuserbasedcloudaccount
Updates IAM user-based AWS cloud account. Use this mutation to update account details access/secret keys, role ARN and regions. All input fields except account ID are optional so that any combination of account attributes can be updated in a single call. If none of the optional fields are provided in the input then no updates are performed, and the response does not contain any error message.

- There is a single argument of type PatchAwsIamUserBasedCloudAccountInput.
- Returns System.Boolean.
### Preparecloudaccountdeletion
Prepare deletion of cloud account. This is the first step to delete AWS cloud account. It generated template for deletion of cloud account and does not change any state of account.

- There is a single argument of type PrepareAwsCloudAccountDeletionInput.
- Returns PrepareAwsCloudAccountDeletionReply.
### Preparefeatureupdateforcloudaccount
Prepare manual update features to latest version.

- There is a single argument of type PrepareFeatureUpdateForAwsCloudAccountInput.
- Returns PrepareFeatureUpdateForAwsCloudAccountReply.
### Startcreatenativeebsvolumesnapshotsjob
Start job to create snapshots of EBS Volumes with given IDs. When completed, this will start taking an on-demand snapshot of the selected EBS Volumes  as per the SLA Policy assigned to the respective volumes.

- There is a single argument of type StartCreateAwsNativeEbsVolumeSnapshotsJobInput.
- Returns BatchAsyncJobStatus.
### Startexocomputedisablejob
Starts a job to disable AWS Exocompute feature. When complete, the job will disable exocompute feature for the specified AWS Native account.

- There is a single argument of type StartAwsExocomputeDisableJobInput.
- Returns AsyncJobStatus.
### Startexportnativeebsvolumesnapshotjob
Start a job to export EBS Volume. The job creates a new EBS Volume with the same properties as that of the snapshot that is exported.

- There is a single argument of type StartExportAwsNativeEbsVolumeSnapshotJobInput.
- Returns AsyncJobStatus.
### Startnativeaccountdisablejob
Starts a job to disable a specific AWS Native account. When complete, the job will disable protection for the specified AWS Native account.

- There is a single argument of type StartAwsNativeAccountDisableJobInput.
- Returns AsyncJobStatus.
### Startnativeec2instancesnapshotsjob
Start an on demand create snapshot job for AWS EC2 Instances.When completed, this will start taking an on-demand snapshot of the selected EC2 Instances  as per the SLA Policy assigned to the respective instances.

- There is a single argument of type StartAwsNativeEc2InstanceSnapshotsJobInput.
- Returns BatchAsyncJobStatus.
### Startnativerdsinstancesnapshotsjob
Start job to create snapshots of RDS Instance with given IDs. When completed, this will start taking an on-demand snapshot of the selected RDS Instances  as per the SLA Policy assigned to the respective instances.

- There is a single argument of type StartAwsNativeRdsInstanceSnapshotsJobInput.
- Returns BatchAsyncJobStatus.
### Startrefreshnativeaccountsjob
Start an on demand job to refresh AWS accounts. The job updates the Rubrik platform with changes to the AWS Native accounts.

- There is a single argument of type StartRefreshAwsNativeAccountsJobInput.
- Returns BatchAsyncJobStatus.
### Startrestorenativeec2instancesnapshotjob
Start an on demand restore snapshot job for AWS EC2 Instance. When completed, this will replace the original EC2 Instance with the selected snapshot.

- There is a single argument of type StartRestoreAwsNativeEc2InstanceSnapshotJobInput.
- Returns AsyncJobStatus.
### Updateaccount
- There is a single argument of type UpdateAwsAccountInput.
- Returns CloudAccount.
### Updateautomatictargetmapping
- There is a single argument of type UpdateAutomaticAwsTargetMappingInput.
- Returns TargetMapping.
### Updatecloudaccount
Update properties for a given AWS cloud account.

- There is a single argument of type UpdateAwsCloudAccountInput.
- Returns System.String.
### Updatecloudaccountfeature
Updates regions, stack ARN, and role ARN for a feature for a given cloud account.

- There is a single argument of type UpdateAwsCloudAccountFeatureInput.
- Returns UpdateAwsCloudAccountFeatureReply.
### Updatecloudnativestoragesetting
- There is a single argument of type UpdateCloudNativeAwsStorageSettingInput.
- Returns UpdateCloudNativeAwsStorageSettingReply.
### Updatecomputesetting
- There is a single argument of type UpdateAwsComputeSettingInput.
- Returns AwsComputeSettings.
### Updateexocomputeconfig
Update AWS Exocompute configs.

- There is a single argument of type UpdateAwsExocomputeConfigsInput.
- Returns UpdateAwsExocomputeConfigsReply.
### Updatetarget
- There is a single argument of type UpdateAwsTargetInput.
- Returns Target.
### Upgradecloudaccountfeatureswithoutcft
Updates status of AWS cloud account features to connected if they are in update permissions state. This mutation should be used with caution. It should be invoked only after the latest required permissions are granted to the AWS cloud account user used by Rubrik. This mutation does not verify if the required permissions are actually granted to the user or not. Its usage is restricted to only IAM user-based and authentication server-based AWS cloud accounts.

- There is a single argument of type UpgradeAwsCloudAccountFeaturesWithoutCftInput.
- Returns System.Boolean.
### Upgradeiamuserbasedcloudaccountpermission
Set IAM user-based AWS account features status to Connected from Update Permissions state. It should be used by caution from cloud accounts only after latest required permissions are granted to authorized IAM user.

- There is a single argument of type UpgradeAwsIamUserBasedCloudAccountPermissionsInput.
- Returns System.Boolean.
### Validateandcreatecloudaccount
Validate and create AWS cloud account. If validation fails, no error is returned and the cause is present in the "message" field of return object or within admin/child accounts of return object. In case validation succeeds, it initiates creation of AWS cloud account. This is the first step to set up native protection.

- There is a single argument of type ValidateAndCreateAwsCloudAccountInput.
- Returns ValidateAndCreateAwsCloudAccountReply.
