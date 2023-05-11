# Invoke-RscMutateAws
## Subcommands
### CloudAccountInitiate
This endpoint is deprecated.

- The Input parameter takes a single value of type AwsCloudAccountInitiateInput.
- Returns AwsCloudAccountCreateResponse.
### CloudAccountUpdateFeature
This endpoint is deprecated.

- The Input parameter takes a hashtable with 2 name and value pairs.
    - cloudAccountUuid - System.String: The ID of the cloud account.
    - features - a list of CloudAccountFeatures: Cloud Account Features.
- Returns AwsCloudAccountUpdateFeatureResponse.
### CloudAccountValidate
This endpoint is deprecated.

- The Input parameter takes a single value of type AwsCloudAccountValidateInput.
- Returns AwsCloudAccountValidateResponse.
### NativeProtectionAccountAdd
This endpoint is deprecated.

- The Input parameter takes a single value of type AwsNativeProtectionAccountAddRequest.
- Returns AwsNativeProtectionAccountAddResponse.
### addAuthenticationServerBasedCloudAccount
Validates and adds an authentication server-based AWS cloud account. When validation succeeds, the AWS cloud account is added and the features specified in the request are enabled. When validation fails, an error is not returned, but the cause of the failure is specified in the "message" field of the response object.

- The Input parameter takes a single value of type AddAwsAuthenticationServerBasedCloudAccountInput.
- Returns AddAwsAuthenticationServerBasedCloudAccountReply.
### addIamUserBasedCloudAccount
Adds an IAM user-based AWS cloud account and enables the features specified in the input after successful validation of the request.

- The Input parameter takes a single value of type AddAwsIamUserBasedCloudAccountInput.
- Returns AddAwsIamUserBasedCloudAccountReply.
### createAccount
- The Input parameter takes a single value of type CreateAwsAccountInput.
- Returns CloudAccount.
### createAutomaticTargetMapping
- The Input parameter takes a single value of type CreateAutomaticAwsTargetMappingInput.
- Returns TargetMapping.
### createCloudNativeStorageSetting
- The Input parameter takes a single value of type CreateCloudNativeAwsStorageSettingInput.
- Returns CreateCloudNativeAwsStorageSettingReply.
### createCluster
Create a Rubrik Cloud Cluster on AWS.

- The Input parameter takes a single value of type CreateAwsClusterInput.
- Returns CcProvisionJobReply.
### createComputeSetting
- The Input parameter takes a single value of type CreateAwsComputeSettingInput.
- Returns AwsComputeSettings.
### createExocomputeConfig
Create AWS Exocompute configs.

- The Input parameter takes a single value of type CreateAwsExocomputeConfigsInput.
- Returns CreateAwsExocomputeConfigsReply.
### createReaderTarget
Create a reader type for AWS archival location on a Rubrik cluster.

- The Input parameter takes a single value of type CreateAwsReaderTargetInput.
- Returns Target.
### createTarget
- The Input parameter takes a single value of type CreateAwsTargetInput.
- Returns Target.
### deleteCloudAccountWithoutCft
Removes AWS cloud account without cleaning up the associated permissions from the AWS cloud account. Customer needs to clean up the permissions in the AWS account themselves. This mutation is supported only for IAM user-based and authentication server-based AWS cloud accounts.

- The Input parameter takes a single value of type DeleteAwsCloudAccountWithoutCftInput.
- Returns DeleteAwsCloudAccountWithoutCftReply.
### deleteCluster
Delete a Rubrik Cloud Cluster on AWS.

- The Input parameter takes a single value of type DeleteAwsClusterInput.
- Returns CcProvisionJobReply.
### deleteComputeSetting
- The Input parameter takes a single value of type DeleteAwsComputeSettingInput.
- Returns System.String.
### deleteExocomputeConfig
Deletes AWS Exocompute configs.

- The Input parameter takes a single value of type DeleteAwsExocomputeConfigsInput.
- Returns DeleteAwsExocomputeConfigsReply.
### deleteIamUserBasedCloudAccount
Deletes IAM user-based AWS cloud account.

- The Input parameter takes a single value of type DeleteAwsIamUserBasedCloudAccountInput.
- Returns DeleteAwsIamUserBasedCloudAccountReply.
### excludeNativeEbsVolumesFromSnapshot
Mark AWS Native EBS Volumes to be excluded from EC2 Instance snapshot. By default, all EBS Volumes are marked as included.

- The Input parameter takes a single value of type ExcludeAwsNativeEbsVolumesFromSnapshotInput.
- Returns System.String.
### finalizeCloudAccountDeletion
Process and finalize deletion of cloud account is the last step in deletion of a feature from cloud account. This endpoint is a MUST for deletion of disconnected features.

- The Input parameter takes a single value of type FinalizeAwsCloudAccountDeletionInput.
- Returns FinalizeAwsCloudAccountDeletionReply.
### finalizeCloudAccountProtection
Process cloud account. This is the second step after validate and create in addition of a feature for cloud account.The CloudFormation stack should be created after this step using the CloudFormation URL provided in the first step.

- The Input parameter takes a single value of type FinalizeAwsCloudAccountProtectionInput.
- Returns FinalizeAwsCloudAccountProtectionReply.
### patchAuthenticationServerBasedCloudAccount
Updates authentication server-based AWS cloud account. Use this mutation to update account details related to role name, certificates, features. The mutation can update one or more certificates associated to an account in a single request. All input fields except account identifier are optional so that any combination of account attributes can be updated in a single call. If none of the optional fields are provided in the input then no updates are performed, and the response does not contain any error message.

- The Input parameter takes a single value of type PatchAwsAuthenticationServerBasedCloudAccountInput.
- Returns System.Boolean.
### patchIamUserBasedCloudAccount
Updates IAM user-based AWS cloud account. Use this mutation to update account details access/secret keys, role ARN and regions. All input fields except account ID are optional so that any combination of account attributes can be updated in a single call. If none of the optional fields are provided in the input then no updates are performed, and the response does not contain any error message.

- The Input parameter takes a single value of type PatchAwsIamUserBasedCloudAccountInput.
- Returns System.Boolean.
### prepareCloudAccountDeletion
Prepare deletion of cloud account. This is the first step to delete AWS cloud account. It generated template for deletion of cloud account and does not change any state of account.

- The Input parameter takes a single value of type PrepareAwsCloudAccountDeletionInput.
- Returns PrepareAwsCloudAccountDeletionReply.
### prepareFeatureUpdateForCloudAccount
Prepare manual update features to latest version.

- The Input parameter takes a single value of type PrepareFeatureUpdateForAwsCloudAccountInput.
- Returns PrepareFeatureUpdateForAwsCloudAccountReply.
### startCreateNativeEbsVolumeSnapshotsJob
Start job to create snapshots of EBS Volumes with given IDs. When completed, this will start taking an on-demand snapshot of the selected EBS Volumes  as per the SLA Policy assigned to the respective volumes.

- The Input parameter takes a single value of type StartCreateAwsNativeEbsVolumeSnapshotsJobInput.
- Returns BatchAsyncJobStatus.
### startExocomputeDisableJob
Starts a job to disable AWS Exocompute feature. When complete, the job will disable exocompute feature for the specified AWS Native account.

- The Input parameter takes a single value of type StartAwsExocomputeDisableJobInput.
- Returns AsyncJobStatus.
### startExportNativeEbsVolumeSnapshotJob
Start a job to export EBS Volume. The job creates a new EBS Volume with the same properties as that of the snapshot that is exported.

- The Input parameter takes a single value of type StartExportAwsNativeEbsVolumeSnapshotJobInput.
- Returns AsyncJobStatus.
### startNativeAccountDisableJob
Starts a job to disable a specific AWS Native account. When complete, the job will disable protection for the specified AWS Native account.

- The Input parameter takes a single value of type StartAwsNativeAccountDisableJobInput.
- Returns AsyncJobStatus.
### startNativeEc2InstanceSnapshotsJob
Start an on demand create snapshot job for AWS EC2 Instances.When completed, this will start taking an on-demand snapshot of the selected EC2 Instances  as per the SLA Policy assigned to the respective instances.

- The Input parameter takes a single value of type StartAwsNativeEc2InstanceSnapshotsJobInput.
- Returns BatchAsyncJobStatus.
### startNativeRdsInstanceSnapshotsJob
Start job to create snapshots of RDS Instance with given IDs. When completed, this will start taking an on-demand snapshot of the selected RDS Instances  as per the SLA Policy assigned to the respective instances.

- The Input parameter takes a single value of type StartAwsNativeRdsInstanceSnapshotsJobInput.
- Returns BatchAsyncJobStatus.
### startRefreshNativeAccountsJob
Start an on demand job to refresh AWS accounts. The job updates the Rubrik platform with changes to the AWS Native accounts.

- The Input parameter takes a single value of type StartRefreshAwsNativeAccountsJobInput.
- Returns BatchAsyncJobStatus.
### startRestoreNativeEc2InstanceSnapshotJob
Start an on demand restore snapshot job for AWS EC2 Instance. When completed, this will replace the original EC2 Instance with the selected snapshot.

- The Input parameter takes a single value of type StartRestoreAwsNativeEc2InstanceSnapshotJobInput.
- Returns AsyncJobStatus.
### updateAccount
- The Input parameter takes a single value of type UpdateAwsAccountInput.
- Returns CloudAccount.
### updateAutomaticTargetMapping
- The Input parameter takes a single value of type UpdateAutomaticAwsTargetMappingInput.
- Returns TargetMapping.
### updateCloudAccount
Update properties for a given AWS cloud account.

- The Input parameter takes a single value of type UpdateAwsCloudAccountInput.
- Returns System.String.
### updateCloudAccountFeature
Updates regions, stack ARN, and role ARN for a feature for a given cloud account.

- The Input parameter takes a single value of type UpdateAwsCloudAccountFeatureInput.
- Returns UpdateAwsCloudAccountFeatureReply.
### updateCloudNativeStorageSetting
- The Input parameter takes a single value of type UpdateCloudNativeAwsStorageSettingInput.
- Returns UpdateCloudNativeAwsStorageSettingReply.
### updateComputeSetting
- The Input parameter takes a single value of type UpdateAwsComputeSettingInput.
- Returns AwsComputeSettings.
### updateTarget
- The Input parameter takes a single value of type UpdateAwsTargetInput.
- Returns Target.
### upgradeCloudAccountFeaturesWithoutCft
Updates status of AWS cloud account features to connected if they are in update permissions state. This mutation should be used with caution. It should be invoked only after the latest required permissions are granted to the AWS cloud account user used by Rubrik. This mutation does not verify if the required permissions are actually granted to the user or not. Its usage is restricted to only IAM user-based and authentication server-based AWS cloud accounts.

- The Input parameter takes a single value of type UpgradeAwsCloudAccountFeaturesWithoutCftInput.
- Returns System.Boolean.
### upgradeIamUserBasedCloudAccountPermission
Set IAM user-based AWS account features status to Connected from Update Permissions state. It should be used by caution from cloud accounts only after latest required permissions are granted to authorized IAM user.

- The Input parameter takes a single value of type UpgradeAwsIamUserBasedCloudAccountPermissionsInput.
- Returns System.Boolean.
### validateAndCreateCloudAccount
Validate and create AWS cloud account. If validation fails, no error is returned and the cause is present in the "message" field of return object or within admin/child accounts of return object. In case validation succeeds, it initiates creation of AWS cloud account. This is the first step to set up native protection.

- The Input parameter takes a single value of type ValidateAndCreateAwsCloudAccountInput.
- Returns ValidateAndCreateAwsCloudAccountReply.
