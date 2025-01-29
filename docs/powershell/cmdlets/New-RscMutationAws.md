# New-RscMutationAws
## Subcommands
### addauthenticationserverbasedcloudaccount
Validates and adds an authentication server-based AWS cloud account. When validation succeeds, the AWS cloud account is added and the features specified in the request are enabled. When validation fails, an error is not returned, but the cause of the failure is specified in the "message" field of the response object.

- There is a single argument of type AddAwsAuthenticationServerBasedCloudAccountInput.
- Returns AddAwsAuthenticationServerBasedCloudAccountReply.
### addiamuserbasedcloudaccount
Adds an IAM user-based AWS cloud account and enables the features specified in the input after successful validation of the request.

- There is a single argument of type AddAwsIamUserBasedCloudAccountInput.
- Returns AddAwsIamUserBasedCloudAccountReply.
### bulkdeletecloudaccountwithoutcft
Deletes specified AWS cloud accounts without using CloudFormation Template (CFT).

- There is a single argument of type BulkDeleteAwsCloudAccountWithoutCftInput.
- Returns BulkDeleteAwsCloudAccountWithoutCftReply.
### cloudaccountsmigrateinitiate
Generate CFT for migrating an existing AWS cloud accounts to AWS organizations.

- There is a single argument of type AwsCloudAccountsMigrateInitiateInput.
- Returns AwsCloudAccountsMigrateInitiateReply.
### createaccount
- There is a single argument of type CreateAwsAccountInput.
- Returns CloudAccount.
### createautomatictargetmapping
- There is a single argument of type CreateAutomaticAwsTargetMappingInput.
- Returns TargetMapping.
### createcloudnativestoragesetting
- There is a single argument of type CreateCloudNativeAwsStorageSettingInput.
- Returns CreateCloudNativeAwsStorageSettingReply.
### createcluster
Create a Rubrik Cloud Cluster on AWS.

- There is a single argument of type CreateAwsClusterInput.
- Returns CcProvisionJobReply.
### createcomputesetting
- There is a single argument of type CreateAwsComputeSettingInput.
- Returns AwsComputeSettings.
### createexocomputeconfigs
Create AWS Exocompute configs.

- There is a single argument of type CreateAwsExocomputeConfigsInput.
- Returns CreateAwsExocomputeConfigsReply.
### createreadertarget
Create a reader type for AWS archival location on a Rubrik cluster.

- There is a single argument of type CreateAwsReaderTargetInput.
- Returns Target.
### createtarget
- There is a single argument of type CreateAwsTargetInput.
- Returns Target.
### deletecomputesetting
- There is a single argument of type DeleteAwsComputeSettingInput.
- Returns System.String.
### deleteexocomputeconfigs
Deletes AWS Exocompute configs.

- There is a single argument of type DeleteAwsExocomputeConfigsInput.
- Returns DeleteAwsExocomputeConfigsReply.
### disconnectexocomputecluster
Disconnects a customer-managed cluster from RSC.

- There is a single argument of type DisconnectAwsExocomputeClusterInput.
- Returns System.String.
### exocomputeclusterconnect
Connects a customer-managed cluster to RSC and obtains the connection command.

- There is a single argument of type AwsExocomputeClusterConnectInput.
- Returns AwsExocomputeClusterConnectReply.
### finalizecloudaccountdeletion
Process and finalize deletion of cloud account is the last step in deletion of a feature from cloud account. This endpoint is a MUST for deletion of disconnected features.

- There is a single argument of type FinalizeAwsCloudAccountDeletionInput.
- Returns FinalizeAwsCloudAccountDeletionReply.
### finalizecloudaccountprotection
Process cloud account. This is the second step after validate and create in addition of a feature for cloud account.The CloudFormation stack should be created after this step using the CloudFormation URL provided in the first step.

- There is a single argument of type FinalizeAwsCloudAccountProtectionInput.
- Returns FinalizeAwsCloudAccountProtectionReply.
### patchauthenticationserverbasedcloudaccount
Updates authentication server-based AWS cloud account. Use this mutation to update account details related to role name, certificates, features. The mutation can update one or more certificates associated to an account in a single request. All input fields except account identifier are optional so that any combination of account attributes can be updated in a single call. If none of the optional fields are provided in the input then no updates are performed, and the response does not contain any error message.

- There is a single argument of type PatchAwsAuthenticationServerBasedCloudAccountInput.
- Returns System.Boolean.
### patchiamuserbasedcloudaccount
Updates IAM user-based AWS cloud account. Use this mutation to update account details access/secret keys, role ARN and regions. All input fields except account ID are optional so that any combination of account attributes can be updated in a single call. If none of the optional fields are provided in the input then no updates are performed, and the response does not contain any error message.

- There is a single argument of type PatchAwsIamUserBasedCloudAccountInput.
- Returns System.Boolean.
### preparecloudaccountdeletion
Prepare deletion of cloud account. This is the first step to delete AWS cloud account. It generated template for deletion of cloud account and does not change any state of account.

- There is a single argument of type PrepareAwsCloudAccountDeletionInput.
- Returns PrepareAwsCloudAccountDeletionReply.
### preparefeatureupdateforcloudaccount
Prepare manual update features to latest version.

- There is a single argument of type PrepareFeatureUpdateForAwsCloudAccountInput.
- Returns PrepareFeatureUpdateForAwsCloudAccountReply.
### registerfeatureartifacts
Registers the AWS account artifacts such as roles in RSC backend while onboarding AWS account in manual flow.

- There is a single argument of type RegisterAwsFeatureArtifactsInput.
- Returns RegisterAwsFeatureArtifactsReply.
### startexocomputedisablejob
Starts a job to disable AWS Exocompute feature. When complete, the job will disable exocompute feature for the specified AWS Native account.

- There is a single argument of type StartAwsExocomputeDisableJobInput.
- Returns AsyncJobStatus.
### updateaccount
- There is a single argument of type UpdateAwsAccountInput.
- Returns CloudAccount.
### updateautomatictargetmapping
- There is a single argument of type UpdateAutomaticAwsTargetMappingInput.
- Returns TargetMapping.
### updatecloudaccount
Update properties for a given AWS cloud account.

- There is a single argument of type UpdateAwsCloudAccountInput.
- Returns System.String.
### updatecloudaccountfeature
Updates regions, stack ARN, and role ARN for a feature for a given cloud account.

- There is a single argument of type UpdateAwsCloudAccountFeatureInput.
- Returns UpdateAwsCloudAccountFeatureReply.
### updatecloudnativestoragesetting
- There is a single argument of type UpdateCloudNativeAwsStorageSettingInput.
- Returns UpdateCloudNativeAwsStorageSettingReply.
### updatecomputesetting
- There is a single argument of type UpdateAwsComputeSettingInput.
- Returns AwsComputeSettings.
### updateexocomputeconfigs
Update AWS Exocompute configs.

- There is a single argument of type UpdateAwsExocomputeConfigsInput.
- Returns UpdateAwsExocomputeConfigsReply.
### updateiampair
Updates the role name for AWS IAM pair.

- There is a single argument of type UpdateAwsIamPairInput.
- Returns System.String.
### updatetarget
- There is a single argument of type UpdateAwsTargetInput.
- Returns Target.
### upgradecloudaccountfeatureswithoutcft
Updates status of AWS cloud account features to connected if they are in update permissions state. This mutation should be used with caution. It should be invoked only after the latest required permissions are granted to the AWS cloud account user used by Rubrik. This mutation does not verify if the required permissions are actually granted to the user or not. Its usage is restricted to only IAM user-based and authentication server-based AWS cloud accounts.

- There is a single argument of type UpgradeAwsCloudAccountFeaturesWithoutCftInput.
- Returns System.Boolean.
### upgradeiamuserbasedcloudaccountpermissions
Set IAM user-based AWS account features status to Connected from Update Permissions state. It should be used by caution from cloud accounts only after latest required permissions are granted to authorized IAM user.

- There is a single argument of type UpgradeAwsIamUserBasedCloudAccountPermissionsInput.
- Returns System.Boolean.
### validateandcreatecloudaccount
Validate and create AWS cloud account. If validation fails, no error is returned and the cause is present in the "message" field of return object or within admin/child accounts of return object. In case validation succeeds, it initiates creation of AWS cloud account. This is the first step to set up native protection.

- There is a single argument of type ValidateAndCreateAwsCloudAccountInput.
- Returns ValidateAndCreateAwsCloudAccountReply.
### validateandinitiateoutpostaccount
Validate and initiates the setup of AWS Outpost account. If validation fails, no error is returned and the cause is present in the "message" field of return object In case validation succeeds, it initiates creation of AWS Outpost account cloud formation stack. This is the first step to set up Laminar data classification on RSC.

- There is a single argument of type ValidateAndInitiateAwsOutpostAccountInput.
- Returns ValidateAndInitiateAwsOutpostAccountReply.
