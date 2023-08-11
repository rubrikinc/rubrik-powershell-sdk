// Invoke-RscMutateAws.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using GraphQL;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.PowerShell.Private;

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    [Cmdlet(
        "Invoke",
        "RscMutateAws",
        DefaultParameterSetName = "CreateTarget")
    ]
    public class Invoke_RscMutateAws : RscPSCmdlet
    {
        
        /// <summary>
        /// StartNativeEc2InstanceSnapshotsJob parameter set
        ///
        /// [GraphQL: startAwsNativeEc2InstanceSnapshotsJob]
        /// </summary>
        [Parameter(
            ParameterSetName = "StartNativeEc2InstanceSnapshotsJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Start an on demand create snapshot job for AWS EC2 Instances.When completed, this will start taking an on-demand snapshot of the selected EC2 Instances  as per the SLA Policy assigned to the respective instances.
[GraphQL: startAwsNativeEc2InstanceSnapshotsJob]",
            Position = 0
        )]
        public SwitchParameter StartNativeEc2InstanceSnapshotsJob { get; set; }

        
        /// <summary>
        /// StartRestoreNativeEc2InstanceSnapshotJob parameter set
        ///
        /// [GraphQL: startRestoreAwsNativeEc2InstanceSnapshotJob]
        /// </summary>
        [Parameter(
            ParameterSetName = "StartRestoreNativeEc2InstanceSnapshotJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Start an on demand restore snapshot job for AWS EC2 Instance. When completed, this will replace the original EC2 Instance with the selected snapshot.
[GraphQL: startRestoreAwsNativeEc2InstanceSnapshotJob]",
            Position = 0
        )]
        public SwitchParameter StartRestoreNativeEc2InstanceSnapshotJob { get; set; }

        
        /// <summary>
        /// StartRefreshNativeAccountsJob parameter set
        ///
        /// [GraphQL: startRefreshAwsNativeAccountsJob]
        /// </summary>
        [Parameter(
            ParameterSetName = "StartRefreshNativeAccountsJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Start an on demand job to refresh AWS accounts. The job updates the Rubrik platform with changes to the AWS Native accounts.
[GraphQL: startRefreshAwsNativeAccountsJob]",
            Position = 0
        )]
        public SwitchParameter StartRefreshNativeAccountsJob { get; set; }

        
        /// <summary>
        /// StartCreateNativeEbsVolumeSnapshotsJob parameter set
        ///
        /// [GraphQL: startCreateAwsNativeEbsVolumeSnapshotsJob]
        /// </summary>
        [Parameter(
            ParameterSetName = "StartCreateNativeEbsVolumeSnapshotsJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Start job to create snapshots of EBS Volumes with given IDs. When completed, this will start taking an on-demand snapshot of the selected EBS Volumes  as per the SLA Policy assigned to the respective volumes.
[GraphQL: startCreateAwsNativeEbsVolumeSnapshotsJob]",
            Position = 0
        )]
        public SwitchParameter StartCreateNativeEbsVolumeSnapshotsJob { get; set; }

        
        /// <summary>
        /// StartNativeAccountDisableJob parameter set
        ///
        /// [GraphQL: startAwsNativeAccountDisableJob]
        /// </summary>
        [Parameter(
            ParameterSetName = "StartNativeAccountDisableJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Starts a job to disable a specific AWS Native account. When complete, the job will disable protection for the specified AWS Native account.
[GraphQL: startAwsNativeAccountDisableJob]",
            Position = 0
        )]
        public SwitchParameter StartNativeAccountDisableJob { get; set; }

        
        /// <summary>
        /// StartExportNativeEbsVolumeSnapshotJob parameter set
        ///
        /// [GraphQL: startExportAwsNativeEbsVolumeSnapshotJob]
        /// </summary>
        [Parameter(
            ParameterSetName = "StartExportNativeEbsVolumeSnapshotJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Start a job to export EBS Volume. The job creates a new EBS Volume with the same properties as that of the snapshot that is exported.
[GraphQL: startExportAwsNativeEbsVolumeSnapshotJob]",
            Position = 0
        )]
        public SwitchParameter StartExportNativeEbsVolumeSnapshotJob { get; set; }

        
        /// <summary>
        /// ExcludeNativeEbsVolumesFromSnapshot parameter set
        ///
        /// [GraphQL: excludeAwsNativeEbsVolumesFromSnapshot]
        /// </summary>
        [Parameter(
            ParameterSetName = "ExcludeNativeEbsVolumesFromSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Mark AWS Native EBS Volumes to be excluded from EC2 Instance snapshot. By default, all EBS Volumes are marked as included.
[GraphQL: excludeAwsNativeEbsVolumesFromSnapshot]",
            Position = 0
        )]
        public SwitchParameter ExcludeNativeEbsVolumesFromSnapshot { get; set; }

        
        /// <summary>
        /// StartNativeRdsInstanceSnapshotsJob parameter set
        ///
        /// [GraphQL: startAwsNativeRdsInstanceSnapshotsJob]
        /// </summary>
        [Parameter(
            ParameterSetName = "StartNativeRdsInstanceSnapshotsJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Start job to create snapshots of RDS Instance with given IDs. When completed, this will start taking an on-demand snapshot of the selected RDS Instances  as per the SLA Policy assigned to the respective instances.
[GraphQL: startAwsNativeRdsInstanceSnapshotsJob]",
            Position = 0
        )]
        public SwitchParameter StartNativeRdsInstanceSnapshotsJob { get; set; }

        
        /// <summary>
        /// CreateAccount parameter set
        ///
        /// [GraphQL: createAwsAccount]
        /// </summary>
        [Parameter(
            ParameterSetName = "CreateAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: createAwsAccount]",
            Position = 0
        )]
        public SwitchParameter CreateAccount { get; set; }

        
        /// <summary>
        /// UpdateAccount parameter set
        ///
        /// [GraphQL: updateAwsAccount]
        /// </summary>
        [Parameter(
            ParameterSetName = "UpdateAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: updateAwsAccount]",
            Position = 0
        )]
        public SwitchParameter UpdateAccount { get; set; }

        
        /// <summary>
        /// CreateAutomaticTargetMapping parameter set
        ///
        /// [GraphQL: createAutomaticAwsTargetMapping]
        /// </summary>
        [Parameter(
            ParameterSetName = "CreateAutomaticTargetMapping",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: createAutomaticAwsTargetMapping]",
            Position = 0
        )]
        public SwitchParameter CreateAutomaticTargetMapping { get; set; }

        
        /// <summary>
        /// CreateCloudNativeStorageSetting parameter set
        ///
        /// [GraphQL: createCloudNativeAwsStorageSetting]
        /// </summary>
        [Parameter(
            ParameterSetName = "CreateCloudNativeStorageSetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: createCloudNativeAwsStorageSetting]",
            Position = 0
        )]
        public SwitchParameter CreateCloudNativeStorageSetting { get; set; }

        
        /// <summary>
        /// UpdateAutomaticTargetMapping parameter set
        ///
        /// [GraphQL: updateAutomaticAwsTargetMapping]
        /// </summary>
        [Parameter(
            ParameterSetName = "UpdateAutomaticTargetMapping",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: updateAutomaticAwsTargetMapping]",
            Position = 0
        )]
        public SwitchParameter UpdateAutomaticTargetMapping { get; set; }

        
        /// <summary>
        /// UpdateCloudNativeStorageSetting parameter set
        ///
        /// [GraphQL: updateCloudNativeAwsStorageSetting]
        /// </summary>
        [Parameter(
            ParameterSetName = "UpdateCloudNativeStorageSetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: updateCloudNativeAwsStorageSetting]",
            Position = 0
        )]
        public SwitchParameter UpdateCloudNativeStorageSetting { get; set; }

        
        /// <summary>
        /// CreateTarget parameter set
        ///
        /// [GraphQL: createAwsTarget]
        /// </summary>
        [Parameter(
            ParameterSetName = "CreateTarget",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: createAwsTarget]",
            Position = 0
        )]
        public SwitchParameter CreateTarget { get; set; }

        
        /// <summary>
        /// UpdateTarget parameter set
        ///
        /// [GraphQL: updateAwsTarget]
        /// </summary>
        [Parameter(
            ParameterSetName = "UpdateTarget",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: updateAwsTarget]",
            Position = 0
        )]
        public SwitchParameter UpdateTarget { get; set; }

        
        /// <summary>
        /// CreateReaderTarget parameter set
        ///
        /// [GraphQL: createAwsReaderTarget]
        /// </summary>
        [Parameter(
            ParameterSetName = "CreateReaderTarget",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a reader type for AWS archival location on a Rubrik cluster.
[GraphQL: createAwsReaderTarget]",
            Position = 0
        )]
        public SwitchParameter CreateReaderTarget { get; set; }

        
        /// <summary>
        /// CreateComputeSetting parameter set
        ///
        /// [GraphQL: createAwsComputeSetting]
        /// </summary>
        [Parameter(
            ParameterSetName = "CreateComputeSetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: createAwsComputeSetting]",
            Position = 0
        )]
        public SwitchParameter CreateComputeSetting { get; set; }

        
        /// <summary>
        /// UpdateComputeSetting parameter set
        ///
        /// [GraphQL: updateAwsComputeSetting]
        /// </summary>
        [Parameter(
            ParameterSetName = "UpdateComputeSetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: updateAwsComputeSetting]",
            Position = 0
        )]
        public SwitchParameter UpdateComputeSetting { get; set; }

        
        /// <summary>
        /// DeleteComputeSetting parameter set
        ///
        /// [GraphQL: deleteAwsComputeSetting]
        /// </summary>
        [Parameter(
            ParameterSetName = "DeleteComputeSetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: deleteAwsComputeSetting]",
            Position = 0
        )]
        public SwitchParameter DeleteComputeSetting { get; set; }

        
        /// <summary>
        /// CloudAccountValidate parameter set
        ///
        /// [GraphQL: awsCloudAccountValidate]
        /// </summary>
        [Parameter(
            ParameterSetName = "CloudAccountValidate",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"This endpoint is deprecated.
[GraphQL: awsCloudAccountValidate]",
            Position = 0
        )]
        public SwitchParameter CloudAccountValidate { get; set; }

        
        /// <summary>
        /// CloudAccountInitiate parameter set
        ///
        /// [GraphQL: awsCloudAccountInitiate]
        /// </summary>
        [Parameter(
            ParameterSetName = "CloudAccountInitiate",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"This endpoint is deprecated.
[GraphQL: awsCloudAccountInitiate]",
            Position = 0
        )]
        public SwitchParameter CloudAccountInitiate { get; set; }

        
        /// <summary>
        /// NativeProtectionAccountAdd parameter set
        ///
        /// [GraphQL: awsNativeProtectionAccountAdd]
        /// </summary>
        [Parameter(
            ParameterSetName = "NativeProtectionAccountAdd",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"This endpoint is deprecated.
[GraphQL: awsNativeProtectionAccountAdd]",
            Position = 0
        )]
        public SwitchParameter NativeProtectionAccountAdd { get; set; }

        
        /// <summary>
        /// ValidateAndCreateCloudAccount parameter set
        ///
        /// [GraphQL: validateAndCreateAwsCloudAccount]
        /// </summary>
        [Parameter(
            ParameterSetName = "ValidateAndCreateCloudAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Validate and create AWS cloud account. If validation fails, no error is returned and the cause is present in the ""message"" field of return object or within admin/child accounts of return object. In case validation succeeds, it initiates creation of AWS cloud account. This is the first step to set up native protection.
[GraphQL: validateAndCreateAwsCloudAccount]",
            Position = 0
        )]
        public SwitchParameter ValidateAndCreateCloudAccount { get; set; }

        
        /// <summary>
        /// FinalizeCloudAccountProtection parameter set
        ///
        /// [GraphQL: finalizeAwsCloudAccountProtection]
        /// </summary>
        [Parameter(
            ParameterSetName = "FinalizeCloudAccountProtection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Process cloud account. This is the second step after validate and create in addition of a feature for cloud account.The CloudFormation stack should be created after this step using the CloudFormation URL provided in the first step.
[GraphQL: finalizeAwsCloudAccountProtection]",
            Position = 0
        )]
        public SwitchParameter FinalizeCloudAccountProtection { get; set; }

        
        /// <summary>
        /// PrepareCloudAccountDeletion parameter set
        ///
        /// [GraphQL: prepareAwsCloudAccountDeletion]
        /// </summary>
        [Parameter(
            ParameterSetName = "PrepareCloudAccountDeletion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Prepare deletion of cloud account. This is the first step to delete AWS cloud account. It generated template for deletion of cloud account and does not change any state of account.
[GraphQL: prepareAwsCloudAccountDeletion]",
            Position = 0
        )]
        public SwitchParameter PrepareCloudAccountDeletion { get; set; }

        
        /// <summary>
        /// FinalizeCloudAccountDeletion parameter set
        ///
        /// [GraphQL: finalizeAwsCloudAccountDeletion]
        /// </summary>
        [Parameter(
            ParameterSetName = "FinalizeCloudAccountDeletion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Process and finalize deletion of cloud account is the last step in deletion of a feature from cloud account. This endpoint is a MUST for deletion of disconnected features.
[GraphQL: finalizeAwsCloudAccountDeletion]",
            Position = 0
        )]
        public SwitchParameter FinalizeCloudAccountDeletion { get; set; }

        
        /// <summary>
        /// UpdateCloudAccountFeature parameter set
        ///
        /// [GraphQL: updateAwsCloudAccountFeature]
        /// </summary>
        [Parameter(
            ParameterSetName = "UpdateCloudAccountFeature",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Updates regions, stack ARN, and role ARN for a feature for a given cloud account.
[GraphQL: updateAwsCloudAccountFeature]",
            Position = 0
        )]
        public SwitchParameter UpdateCloudAccountFeature { get; set; }

        
        /// <summary>
        /// UpdateCloudAccount parameter set
        ///
        /// [GraphQL: updateAwsCloudAccount]
        /// </summary>
        [Parameter(
            ParameterSetName = "UpdateCloudAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update properties for a given AWS cloud account.
[GraphQL: updateAwsCloudAccount]",
            Position = 0
        )]
        public SwitchParameter UpdateCloudAccount { get; set; }

        
        /// <summary>
        /// PrepareFeatureUpdateForCloudAccount parameter set
        ///
        /// [GraphQL: prepareFeatureUpdateForAwsCloudAccount]
        /// </summary>
        [Parameter(
            ParameterSetName = "PrepareFeatureUpdateForCloudAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Prepare manual update features to latest version.
[GraphQL: prepareFeatureUpdateForAwsCloudAccount]",
            Position = 0
        )]
        public SwitchParameter PrepareFeatureUpdateForCloudAccount { get; set; }

        
        /// <summary>
        /// CloudAccountUpdateFeature parameter set
        ///
        /// [GraphQL: awsCloudAccountUpdateFeature]
        /// </summary>
        [Parameter(
            ParameterSetName = "CloudAccountUpdateFeature",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"This endpoint is deprecated.
[GraphQL: awsCloudAccountUpdateFeature]",
            Position = 0
        )]
        public SwitchParameter CloudAccountUpdateFeature { get; set; }

        
        /// <summary>
        /// CreateExocomputeConfigs parameter set
        ///
        /// [GraphQL: createAwsExocomputeConfigs]
        /// </summary>
        [Parameter(
            ParameterSetName = "CreateExocomputeConfigs",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create AWS Exocompute configs.
[GraphQL: createAwsExocomputeConfigs]",
            Position = 0
        )]
        public SwitchParameter CreateExocomputeConfigs { get; set; }

        
        /// <summary>
        /// DeleteExocomputeConfigs parameter set
        ///
        /// [GraphQL: deleteAwsExocomputeConfigs]
        /// </summary>
        [Parameter(
            ParameterSetName = "DeleteExocomputeConfigs",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Deletes AWS Exocompute configs.
[GraphQL: deleteAwsExocomputeConfigs]",
            Position = 0
        )]
        public SwitchParameter DeleteExocomputeConfigs { get; set; }

        
        /// <summary>
        /// UpdateExocomputeConfigs parameter set
        ///
        /// [GraphQL: updateAwsExocomputeConfigs]
        /// </summary>
        [Parameter(
            ParameterSetName = "UpdateExocomputeConfigs",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update AWS Exocompute configs.
[GraphQL: updateAwsExocomputeConfigs]",
            Position = 0
        )]
        public SwitchParameter UpdateExocomputeConfigs { get; set; }

        
        /// <summary>
        /// StartExocomputeDisableJob parameter set
        ///
        /// [GraphQL: startAwsExocomputeDisableJob]
        /// </summary>
        [Parameter(
            ParameterSetName = "StartExocomputeDisableJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Starts a job to disable AWS Exocompute feature. When complete, the job will disable exocompute feature for the specified AWS Native account.
[GraphQL: startAwsExocomputeDisableJob]",
            Position = 0
        )]
        public SwitchParameter StartExocomputeDisableJob { get; set; }

        
        /// <summary>
        /// AddIamUserBasedCloudAccount parameter set
        ///
        /// [GraphQL: addAwsIamUserBasedCloudAccount]
        /// </summary>
        [Parameter(
            ParameterSetName = "AddIamUserBasedCloudAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Adds an IAM user-based AWS cloud account and enables the features specified in the input after successful validation of the request.
[GraphQL: addAwsIamUserBasedCloudAccount]",
            Position = 0
        )]
        public SwitchParameter AddIamUserBasedCloudAccount { get; set; }

        
        /// <summary>
        /// DeleteIamUserBasedCloudAccount parameter set
        ///
        /// [GraphQL: deleteAwsIamUserBasedCloudAccount]
        /// </summary>
        [Parameter(
            ParameterSetName = "DeleteIamUserBasedCloudAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Deletes IAM user-based AWS cloud account.
[GraphQL: deleteAwsIamUserBasedCloudAccount]",
            Position = 0
        )]
        public SwitchParameter DeleteIamUserBasedCloudAccount { get; set; }

        
        /// <summary>
        /// DeleteCloudAccountWithoutCft parameter set
        ///
        /// [GraphQL: deleteAwsCloudAccountWithoutCft]
        /// </summary>
        [Parameter(
            ParameterSetName = "DeleteCloudAccountWithoutCft",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Removes AWS cloud account without cleaning up the associated permissions from the AWS cloud account. Customer needs to clean up the permissions in the AWS account themselves. This mutation is supported only for IAM user-based and authentication server-based AWS cloud accounts.
[GraphQL: deleteAwsCloudAccountWithoutCft]",
            Position = 0
        )]
        public SwitchParameter DeleteCloudAccountWithoutCft { get; set; }

        
        /// <summary>
        /// UpgradeIamUserBasedCloudAccountPermissions parameter set
        ///
        /// [GraphQL: upgradeAwsIamUserBasedCloudAccountPermissions]
        /// </summary>
        [Parameter(
            ParameterSetName = "UpgradeIamUserBasedCloudAccountPermissions",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Set IAM user-based AWS account features status to Connected from Update Permissions state. It should be used by caution from cloud accounts only after latest required permissions are granted to authorized IAM user.
[GraphQL: upgradeAwsIamUserBasedCloudAccountPermissions]",
            Position = 0
        )]
        public SwitchParameter UpgradeIamUserBasedCloudAccountPermissions { get; set; }

        
        /// <summary>
        /// UpgradeCloudAccountFeaturesWithoutCft parameter set
        ///
        /// [GraphQL: upgradeAwsCloudAccountFeaturesWithoutCft]
        /// </summary>
        [Parameter(
            ParameterSetName = "UpgradeCloudAccountFeaturesWithoutCft",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Updates status of AWS cloud account features to connected if they are in update permissions state. This mutation should be used with caution. It should be invoked only after the latest required permissions are granted to the AWS cloud account user used by Rubrik. This mutation does not verify if the required permissions are actually granted to the user or not. Its usage is restricted to only IAM user-based and authentication server-based AWS cloud accounts.
[GraphQL: upgradeAwsCloudAccountFeaturesWithoutCft]",
            Position = 0
        )]
        public SwitchParameter UpgradeCloudAccountFeaturesWithoutCft { get; set; }

        
        /// <summary>
        /// AddAuthenticationServerBasedCloudAccount parameter set
        ///
        /// [GraphQL: addAwsAuthenticationServerBasedCloudAccount]
        /// </summary>
        [Parameter(
            ParameterSetName = "AddAuthenticationServerBasedCloudAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Validates and adds an authentication server-based AWS cloud account. When validation succeeds, the AWS cloud account is added and the features specified in the request are enabled. When validation fails, an error is not returned, but the cause of the failure is specified in the ""message"" field of the response object.
[GraphQL: addAwsAuthenticationServerBasedCloudAccount]",
            Position = 0
        )]
        public SwitchParameter AddAuthenticationServerBasedCloudAccount { get; set; }

        
        /// <summary>
        /// PatchAuthenticationServerBasedCloudAccount parameter set
        ///
        /// [GraphQL: patchAwsAuthenticationServerBasedCloudAccount]
        /// </summary>
        [Parameter(
            ParameterSetName = "PatchAuthenticationServerBasedCloudAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Updates authentication server-based AWS cloud account. Use this mutation to update account details related to role name, certificates, features. The mutation can update one or more certificates associated to an account in a single request. All input fields except account identifier are optional so that any combination of account attributes can be updated in a single call. If none of the optional fields are provided in the input then no updates are performed, and the response does not contain any error message.
[GraphQL: patchAwsAuthenticationServerBasedCloudAccount]",
            Position = 0
        )]
        public SwitchParameter PatchAuthenticationServerBasedCloudAccount { get; set; }

        
        /// <summary>
        /// PatchIamUserBasedCloudAccount parameter set
        ///
        /// [GraphQL: patchAwsIamUserBasedCloudAccount]
        /// </summary>
        [Parameter(
            ParameterSetName = "PatchIamUserBasedCloudAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Updates IAM user-based AWS cloud account. Use this mutation to update account details access/secret keys, role ARN and regions. All input fields except account ID are optional so that any combination of account attributes can be updated in a single call. If none of the optional fields are provided in the input then no updates are performed, and the response does not contain any error message.
[GraphQL: patchAwsIamUserBasedCloudAccount]",
            Position = 0
        )]
        public SwitchParameter PatchIamUserBasedCloudAccount { get; set; }

        
        /// <summary>
        /// RegisterFeatureArtifacts parameter set
        ///
        /// [GraphQL: registerAwsFeatureArtifacts]
        /// </summary>
        [Parameter(
            ParameterSetName = "RegisterFeatureArtifacts",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Registers the AWS account artifacts such as roles in RSC backend while onboarding AWS account in manual flow.
[GraphQL: registerAwsFeatureArtifacts]",
            Position = 0
        )]
        public SwitchParameter RegisterFeatureArtifacts { get; set; }

        
        /// <summary>
        /// BulkDeleteCloudAccountWithoutCft parameter set
        ///
        /// [GraphQL: bulkDeleteAwsCloudAccountWithoutCft]
        /// </summary>
        [Parameter(
            ParameterSetName = "BulkDeleteCloudAccountWithoutCft",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Deletes specified AWS cloud accounts without using CloudFormation Template (CFT).
[GraphQL: bulkDeleteAwsCloudAccountWithoutCft]",
            Position = 0
        )]
        public SwitchParameter BulkDeleteCloudAccountWithoutCft { get; set; }

        
        /// <summary>
        /// CreateCluster parameter set
        ///
        /// [GraphQL: createAwsCluster]
        /// </summary>
        [Parameter(
            ParameterSetName = "CreateCluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a Rubrik Cloud Cluster on AWS.
[GraphQL: createAwsCluster]",
            Position = 0
        )]
        public SwitchParameter CreateCluster { get; set; }

        
        /// <summary>
        /// DeleteCluster parameter set
        ///
        /// [GraphQL: deleteAwsCluster]
        /// </summary>
        [Parameter(
            ParameterSetName = "DeleteCluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete a Rubrik Cloud Cluster on AWS.
[GraphQL: deleteAwsCluster]",
            Position = 0
        )]
        public SwitchParameter DeleteCluster { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "StartNativeEc2InstanceSnapshotsJob":
                        this.ProcessRecord_StartNativeEc2InstanceSnapshotsJob();
                        break;
                    case "StartRestoreNativeEc2InstanceSnapshotJob":
                        this.ProcessRecord_StartRestoreNativeEc2InstanceSnapshotJob();
                        break;
                    case "StartRefreshNativeAccountsJob":
                        this.ProcessRecord_StartRefreshNativeAccountsJob();
                        break;
                    case "StartCreateNativeEbsVolumeSnapshotsJob":
                        this.ProcessRecord_StartCreateNativeEbsVolumeSnapshotsJob();
                        break;
                    case "StartNativeAccountDisableJob":
                        this.ProcessRecord_StartNativeAccountDisableJob();
                        break;
                    case "StartExportNativeEbsVolumeSnapshotJob":
                        this.ProcessRecord_StartExportNativeEbsVolumeSnapshotJob();
                        break;
                    case "ExcludeNativeEbsVolumesFromSnapshot":
                        this.ProcessRecord_ExcludeNativeEbsVolumesFromSnapshot();
                        break;
                    case "StartNativeRdsInstanceSnapshotsJob":
                        this.ProcessRecord_StartNativeRdsInstanceSnapshotsJob();
                        break;
                    case "CreateAccount":
                        this.ProcessRecord_CreateAccount();
                        break;
                    case "UpdateAccount":
                        this.ProcessRecord_UpdateAccount();
                        break;
                    case "CreateAutomaticTargetMapping":
                        this.ProcessRecord_CreateAutomaticTargetMapping();
                        break;
                    case "CreateCloudNativeStorageSetting":
                        this.ProcessRecord_CreateCloudNativeStorageSetting();
                        break;
                    case "UpdateAutomaticTargetMapping":
                        this.ProcessRecord_UpdateAutomaticTargetMapping();
                        break;
                    case "UpdateCloudNativeStorageSetting":
                        this.ProcessRecord_UpdateCloudNativeStorageSetting();
                        break;
                    case "CreateTarget":
                        this.ProcessRecord_CreateTarget();
                        break;
                    case "UpdateTarget":
                        this.ProcessRecord_UpdateTarget();
                        break;
                    case "CreateReaderTarget":
                        this.ProcessRecord_CreateReaderTarget();
                        break;
                    case "CreateComputeSetting":
                        this.ProcessRecord_CreateComputeSetting();
                        break;
                    case "UpdateComputeSetting":
                        this.ProcessRecord_UpdateComputeSetting();
                        break;
                    case "DeleteComputeSetting":
                        this.ProcessRecord_DeleteComputeSetting();
                        break;
                    case "CloudAccountValidate":
                        this.ProcessRecord_CloudAccountValidate();
                        break;
                    case "CloudAccountInitiate":
                        this.ProcessRecord_CloudAccountInitiate();
                        break;
                    case "NativeProtectionAccountAdd":
                        this.ProcessRecord_NativeProtectionAccountAdd();
                        break;
                    case "ValidateAndCreateCloudAccount":
                        this.ProcessRecord_ValidateAndCreateCloudAccount();
                        break;
                    case "FinalizeCloudAccountProtection":
                        this.ProcessRecord_FinalizeCloudAccountProtection();
                        break;
                    case "PrepareCloudAccountDeletion":
                        this.ProcessRecord_PrepareCloudAccountDeletion();
                        break;
                    case "FinalizeCloudAccountDeletion":
                        this.ProcessRecord_FinalizeCloudAccountDeletion();
                        break;
                    case "UpdateCloudAccountFeature":
                        this.ProcessRecord_UpdateCloudAccountFeature();
                        break;
                    case "UpdateCloudAccount":
                        this.ProcessRecord_UpdateCloudAccount();
                        break;
                    case "PrepareFeatureUpdateForCloudAccount":
                        this.ProcessRecord_PrepareFeatureUpdateForCloudAccount();
                        break;
                    case "CloudAccountUpdateFeature":
                        this.ProcessRecord_CloudAccountUpdateFeature();
                        break;
                    case "CreateExocomputeConfigs":
                        this.ProcessRecord_CreateExocomputeConfigs();
                        break;
                    case "DeleteExocomputeConfigs":
                        this.ProcessRecord_DeleteExocomputeConfigs();
                        break;
                    case "UpdateExocomputeConfigs":
                        this.ProcessRecord_UpdateExocomputeConfigs();
                        break;
                    case "StartExocomputeDisableJob":
                        this.ProcessRecord_StartExocomputeDisableJob();
                        break;
                    case "AddIamUserBasedCloudAccount":
                        this.ProcessRecord_AddIamUserBasedCloudAccount();
                        break;
                    case "DeleteIamUserBasedCloudAccount":
                        this.ProcessRecord_DeleteIamUserBasedCloudAccount();
                        break;
                    case "DeleteCloudAccountWithoutCft":
                        this.ProcessRecord_DeleteCloudAccountWithoutCft();
                        break;
                    case "UpgradeIamUserBasedCloudAccountPermissions":
                        this.ProcessRecord_UpgradeIamUserBasedCloudAccountPermissions();
                        break;
                    case "UpgradeCloudAccountFeaturesWithoutCft":
                        this.ProcessRecord_UpgradeCloudAccountFeaturesWithoutCft();
                        break;
                    case "AddAuthenticationServerBasedCloudAccount":
                        this.ProcessRecord_AddAuthenticationServerBasedCloudAccount();
                        break;
                    case "PatchAuthenticationServerBasedCloudAccount":
                        this.ProcessRecord_PatchAuthenticationServerBasedCloudAccount();
                        break;
                    case "PatchIamUserBasedCloudAccount":
                        this.ProcessRecord_PatchIamUserBasedCloudAccount();
                        break;
                    case "RegisterFeatureArtifacts":
                        this.ProcessRecord_RegisterFeatureArtifacts();
                        break;
                    case "BulkDeleteCloudAccountWithoutCft":
                        this.ProcessRecord_BulkDeleteCloudAccountWithoutCft();
                        break;
                    case "CreateCluster":
                        this.ProcessRecord_CreateCluster();
                        break;
                    case "DeleteCluster":
                        this.ProcessRecord_DeleteCluster();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + Op);
                }
           }
           catch (Exception ex)
           {
                ThrowTerminatingException(ex);
           }
        }
#pragma warning restore 1591

        // This parameter set invokes a single graphql operation:
        // startAwsNativeEc2InstanceSnapshotsJob.
        internal void ProcessRecord_StartNativeEc2InstanceSnapshotsJob()
        {
            this._logger.name += " -StartNativeEc2InstanceSnapshotsJob";
            // Invoke graphql operation startAwsNativeEc2InstanceSnapshotsJob
            InvokeMutationStartAwsNativeEc2InstanceSnapshotsJob();
        }

        // This parameter set invokes a single graphql operation:
        // startRestoreAwsNativeEc2InstanceSnapshotJob.
        internal void ProcessRecord_StartRestoreNativeEc2InstanceSnapshotJob()
        {
            this._logger.name += " -StartRestoreNativeEc2InstanceSnapshotJob";
            // Invoke graphql operation startRestoreAwsNativeEc2InstanceSnapshotJob
            InvokeMutationStartRestoreAwsNativeEc2InstanceSnapshotJob();
        }

        // This parameter set invokes a single graphql operation:
        // startRefreshAwsNativeAccountsJob.
        internal void ProcessRecord_StartRefreshNativeAccountsJob()
        {
            this._logger.name += " -StartRefreshNativeAccountsJob";
            // Invoke graphql operation startRefreshAwsNativeAccountsJob
            InvokeMutationStartRefreshAwsNativeAccountsJob();
        }

        // This parameter set invokes a single graphql operation:
        // startCreateAwsNativeEbsVolumeSnapshotsJob.
        internal void ProcessRecord_StartCreateNativeEbsVolumeSnapshotsJob()
        {
            this._logger.name += " -StartCreateNativeEbsVolumeSnapshotsJob";
            // Invoke graphql operation startCreateAwsNativeEbsVolumeSnapshotsJob
            InvokeMutationStartCreateAwsNativeEbsVolumeSnapshotsJob();
        }

        // This parameter set invokes a single graphql operation:
        // startAwsNativeAccountDisableJob.
        internal void ProcessRecord_StartNativeAccountDisableJob()
        {
            this._logger.name += " -StartNativeAccountDisableJob";
            // Invoke graphql operation startAwsNativeAccountDisableJob
            InvokeMutationStartAwsNativeAccountDisableJob();
        }

        // This parameter set invokes a single graphql operation:
        // startExportAwsNativeEbsVolumeSnapshotJob.
        internal void ProcessRecord_StartExportNativeEbsVolumeSnapshotJob()
        {
            this._logger.name += " -StartExportNativeEbsVolumeSnapshotJob";
            // Invoke graphql operation startExportAwsNativeEbsVolumeSnapshotJob
            InvokeMutationStartExportAwsNativeEbsVolumeSnapshotJob();
        }

        // This parameter set invokes a single graphql operation:
        // excludeAwsNativeEbsVolumesFromSnapshot.
        internal void ProcessRecord_ExcludeNativeEbsVolumesFromSnapshot()
        {
            this._logger.name += " -ExcludeNativeEbsVolumesFromSnapshot";
            // Invoke graphql operation excludeAwsNativeEbsVolumesFromSnapshot
            InvokeMutationExcludeAwsNativeEbsVolumesFromSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // startAwsNativeRdsInstanceSnapshotsJob.
        internal void ProcessRecord_StartNativeRdsInstanceSnapshotsJob()
        {
            this._logger.name += " -StartNativeRdsInstanceSnapshotsJob";
            // Invoke graphql operation startAwsNativeRdsInstanceSnapshotsJob
            InvokeMutationStartAwsNativeRdsInstanceSnapshotsJob();
        }

        // This parameter set invokes a single graphql operation:
        // createAwsAccount.
        internal void ProcessRecord_CreateAccount()
        {
            this._logger.name += " -CreateAccount";
            // Invoke graphql operation createAwsAccount
            InvokeMutationCreateAwsAccount();
        }

        // This parameter set invokes a single graphql operation:
        // updateAwsAccount.
        internal void ProcessRecord_UpdateAccount()
        {
            this._logger.name += " -UpdateAccount";
            // Invoke graphql operation updateAwsAccount
            InvokeMutationUpdateAwsAccount();
        }

        // This parameter set invokes a single graphql operation:
        // createAutomaticAwsTargetMapping.
        internal void ProcessRecord_CreateAutomaticTargetMapping()
        {
            this._logger.name += " -CreateAutomaticTargetMapping";
            // Invoke graphql operation createAutomaticAwsTargetMapping
            InvokeMutationCreateAutomaticAwsTargetMapping();
        }

        // This parameter set invokes a single graphql operation:
        // createCloudNativeAwsStorageSetting.
        internal void ProcessRecord_CreateCloudNativeStorageSetting()
        {
            this._logger.name += " -CreateCloudNativeStorageSetting";
            // Invoke graphql operation createCloudNativeAwsStorageSetting
            InvokeMutationCreateCloudNativeAwsStorageSetting();
        }

        // This parameter set invokes a single graphql operation:
        // updateAutomaticAwsTargetMapping.
        internal void ProcessRecord_UpdateAutomaticTargetMapping()
        {
            this._logger.name += " -UpdateAutomaticTargetMapping";
            // Invoke graphql operation updateAutomaticAwsTargetMapping
            InvokeMutationUpdateAutomaticAwsTargetMapping();
        }

        // This parameter set invokes a single graphql operation:
        // updateCloudNativeAwsStorageSetting.
        internal void ProcessRecord_UpdateCloudNativeStorageSetting()
        {
            this._logger.name += " -UpdateCloudNativeStorageSetting";
            // Invoke graphql operation updateCloudNativeAwsStorageSetting
            InvokeMutationUpdateCloudNativeAwsStorageSetting();
        }

        // This parameter set invokes a single graphql operation:
        // createAwsTarget.
        internal void ProcessRecord_CreateTarget()
        {
            this._logger.name += " -CreateTarget";
            // Invoke graphql operation createAwsTarget
            InvokeMutationCreateAwsTarget();
        }

        // This parameter set invokes a single graphql operation:
        // updateAwsTarget.
        internal void ProcessRecord_UpdateTarget()
        {
            this._logger.name += " -UpdateTarget";
            // Invoke graphql operation updateAwsTarget
            InvokeMutationUpdateAwsTarget();
        }

        // This parameter set invokes a single graphql operation:
        // createAwsReaderTarget.
        internal void ProcessRecord_CreateReaderTarget()
        {
            this._logger.name += " -CreateReaderTarget";
            // Invoke graphql operation createAwsReaderTarget
            InvokeMutationCreateAwsReaderTarget();
        }

        // This parameter set invokes a single graphql operation:
        // createAwsComputeSetting.
        internal void ProcessRecord_CreateComputeSetting()
        {
            this._logger.name += " -CreateComputeSetting";
            // Invoke graphql operation createAwsComputeSetting
            InvokeMutationCreateAwsComputeSetting();
        }

        // This parameter set invokes a single graphql operation:
        // updateAwsComputeSetting.
        internal void ProcessRecord_UpdateComputeSetting()
        {
            this._logger.name += " -UpdateComputeSetting";
            // Invoke graphql operation updateAwsComputeSetting
            InvokeMutationUpdateAwsComputeSetting();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAwsComputeSetting.
        internal void ProcessRecord_DeleteComputeSetting()
        {
            this._logger.name += " -DeleteComputeSetting";
            // Invoke graphql operation deleteAwsComputeSetting
            InvokeMutationDeleteAwsComputeSetting();
        }

        // This parameter set invokes a single graphql operation:
        // awsCloudAccountValidate.
        internal void ProcessRecord_CloudAccountValidate()
        {
            this._logger.name += " -CloudAccountValidate";
            // Invoke graphql operation awsCloudAccountValidate
            InvokeMutationAwsCloudAccountValidate();
        }

        // This parameter set invokes a single graphql operation:
        // awsCloudAccountInitiate.
        internal void ProcessRecord_CloudAccountInitiate()
        {
            this._logger.name += " -CloudAccountInitiate";
            // Invoke graphql operation awsCloudAccountInitiate
            InvokeMutationAwsCloudAccountInitiate();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeProtectionAccountAdd.
        internal void ProcessRecord_NativeProtectionAccountAdd()
        {
            this._logger.name += " -NativeProtectionAccountAdd";
            // Invoke graphql operation awsNativeProtectionAccountAdd
            InvokeMutationAwsNativeProtectionAccountAdd();
        }

        // This parameter set invokes a single graphql operation:
        // validateAndCreateAwsCloudAccount.
        internal void ProcessRecord_ValidateAndCreateCloudAccount()
        {
            this._logger.name += " -ValidateAndCreateCloudAccount";
            // Invoke graphql operation validateAndCreateAwsCloudAccount
            InvokeMutationValidateAndCreateAwsCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // finalizeAwsCloudAccountProtection.
        internal void ProcessRecord_FinalizeCloudAccountProtection()
        {
            this._logger.name += " -FinalizeCloudAccountProtection";
            // Invoke graphql operation finalizeAwsCloudAccountProtection
            InvokeMutationFinalizeAwsCloudAccountProtection();
        }

        // This parameter set invokes a single graphql operation:
        // prepareAwsCloudAccountDeletion.
        internal void ProcessRecord_PrepareCloudAccountDeletion()
        {
            this._logger.name += " -PrepareCloudAccountDeletion";
            // Invoke graphql operation prepareAwsCloudAccountDeletion
            InvokeMutationPrepareAwsCloudAccountDeletion();
        }

        // This parameter set invokes a single graphql operation:
        // finalizeAwsCloudAccountDeletion.
        internal void ProcessRecord_FinalizeCloudAccountDeletion()
        {
            this._logger.name += " -FinalizeCloudAccountDeletion";
            // Invoke graphql operation finalizeAwsCloudAccountDeletion
            InvokeMutationFinalizeAwsCloudAccountDeletion();
        }

        // This parameter set invokes a single graphql operation:
        // updateAwsCloudAccountFeature.
        internal void ProcessRecord_UpdateCloudAccountFeature()
        {
            this._logger.name += " -UpdateCloudAccountFeature";
            // Invoke graphql operation updateAwsCloudAccountFeature
            InvokeMutationUpdateAwsCloudAccountFeature();
        }

        // This parameter set invokes a single graphql operation:
        // updateAwsCloudAccount.
        internal void ProcessRecord_UpdateCloudAccount()
        {
            this._logger.name += " -UpdateCloudAccount";
            // Invoke graphql operation updateAwsCloudAccount
            InvokeMutationUpdateAwsCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // prepareFeatureUpdateForAwsCloudAccount.
        internal void ProcessRecord_PrepareFeatureUpdateForCloudAccount()
        {
            this._logger.name += " -PrepareFeatureUpdateForCloudAccount";
            // Invoke graphql operation prepareFeatureUpdateForAwsCloudAccount
            InvokeMutationPrepareFeatureUpdateForAwsCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // awsCloudAccountUpdateFeature.
        internal void ProcessRecord_CloudAccountUpdateFeature()
        {
            this._logger.name += " -CloudAccountUpdateFeature";
            // Invoke graphql operation awsCloudAccountUpdateFeature
            InvokeMutationAwsCloudAccountUpdateFeature();
        }

        // This parameter set invokes a single graphql operation:
        // createAwsExocomputeConfigs.
        internal void ProcessRecord_CreateExocomputeConfigs()
        {
            this._logger.name += " -CreateExocomputeConfigs";
            // Invoke graphql operation createAwsExocomputeConfigs
            InvokeMutationCreateAwsExocomputeConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAwsExocomputeConfigs.
        internal void ProcessRecord_DeleteExocomputeConfigs()
        {
            this._logger.name += " -DeleteExocomputeConfigs";
            // Invoke graphql operation deleteAwsExocomputeConfigs
            InvokeMutationDeleteAwsExocomputeConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // updateAwsExocomputeConfigs.
        internal void ProcessRecord_UpdateExocomputeConfigs()
        {
            this._logger.name += " -UpdateExocomputeConfigs";
            // Invoke graphql operation updateAwsExocomputeConfigs
            InvokeMutationUpdateAwsExocomputeConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // startAwsExocomputeDisableJob.
        internal void ProcessRecord_StartExocomputeDisableJob()
        {
            this._logger.name += " -StartExocomputeDisableJob";
            // Invoke graphql operation startAwsExocomputeDisableJob
            InvokeMutationStartAwsExocomputeDisableJob();
        }

        // This parameter set invokes a single graphql operation:
        // addAwsIamUserBasedCloudAccount.
        internal void ProcessRecord_AddIamUserBasedCloudAccount()
        {
            this._logger.name += " -AddIamUserBasedCloudAccount";
            // Invoke graphql operation addAwsIamUserBasedCloudAccount
            InvokeMutationAddAwsIamUserBasedCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAwsIamUserBasedCloudAccount.
        internal void ProcessRecord_DeleteIamUserBasedCloudAccount()
        {
            this._logger.name += " -DeleteIamUserBasedCloudAccount";
            // Invoke graphql operation deleteAwsIamUserBasedCloudAccount
            InvokeMutationDeleteAwsIamUserBasedCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAwsCloudAccountWithoutCft.
        internal void ProcessRecord_DeleteCloudAccountWithoutCft()
        {
            this._logger.name += " -DeleteCloudAccountWithoutCft";
            // Invoke graphql operation deleteAwsCloudAccountWithoutCft
            InvokeMutationDeleteAwsCloudAccountWithoutCft();
        }

        // This parameter set invokes a single graphql operation:
        // upgradeAwsIamUserBasedCloudAccountPermissions.
        internal void ProcessRecord_UpgradeIamUserBasedCloudAccountPermissions()
        {
            this._logger.name += " -UpgradeIamUserBasedCloudAccountPermissions";
            // Invoke graphql operation upgradeAwsIamUserBasedCloudAccountPermissions
            InvokeMutationUpgradeAwsIamUserBasedCloudAccountPermissions();
        }

        // This parameter set invokes a single graphql operation:
        // upgradeAwsCloudAccountFeaturesWithoutCft.
        internal void ProcessRecord_UpgradeCloudAccountFeaturesWithoutCft()
        {
            this._logger.name += " -UpgradeCloudAccountFeaturesWithoutCft";
            // Invoke graphql operation upgradeAwsCloudAccountFeaturesWithoutCft
            InvokeMutationUpgradeAwsCloudAccountFeaturesWithoutCft();
        }

        // This parameter set invokes a single graphql operation:
        // addAwsAuthenticationServerBasedCloudAccount.
        internal void ProcessRecord_AddAuthenticationServerBasedCloudAccount()
        {
            this._logger.name += " -AddAuthenticationServerBasedCloudAccount";
            // Invoke graphql operation addAwsAuthenticationServerBasedCloudAccount
            InvokeMutationAddAwsAuthenticationServerBasedCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // patchAwsAuthenticationServerBasedCloudAccount.
        internal void ProcessRecord_PatchAuthenticationServerBasedCloudAccount()
        {
            this._logger.name += " -PatchAuthenticationServerBasedCloudAccount";
            // Invoke graphql operation patchAwsAuthenticationServerBasedCloudAccount
            InvokeMutationPatchAwsAuthenticationServerBasedCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // patchAwsIamUserBasedCloudAccount.
        internal void ProcessRecord_PatchIamUserBasedCloudAccount()
        {
            this._logger.name += " -PatchIamUserBasedCloudAccount";
            // Invoke graphql operation patchAwsIamUserBasedCloudAccount
            InvokeMutationPatchAwsIamUserBasedCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // registerAwsFeatureArtifacts.
        internal void ProcessRecord_RegisterFeatureArtifacts()
        {
            this._logger.name += " -RegisterFeatureArtifacts";
            // Invoke graphql operation registerAwsFeatureArtifacts
            InvokeMutationRegisterAwsFeatureArtifacts();
        }

        // This parameter set invokes a single graphql operation:
        // bulkDeleteAwsCloudAccountWithoutCft.
        internal void ProcessRecord_BulkDeleteCloudAccountWithoutCft()
        {
            this._logger.name += " -BulkDeleteCloudAccountWithoutCft";
            // Invoke graphql operation bulkDeleteAwsCloudAccountWithoutCft
            InvokeMutationBulkDeleteAwsCloudAccountWithoutCft();
        }

        // This parameter set invokes a single graphql operation:
        // createAwsCluster.
        internal void ProcessRecord_CreateCluster()
        {
            this._logger.name += " -CreateCluster";
            // Invoke graphql operation createAwsCluster
            InvokeMutationCreateAwsCluster();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAwsCluster.
        internal void ProcessRecord_DeleteCluster()
        {
            this._logger.name += " -DeleteCluster";
            // Invoke graphql operation deleteAwsCluster
            InvokeMutationDeleteAwsCluster();
        }


        // Invoke GraphQL Mutation:
        // startAwsNativeEc2InstanceSnapshotsJob(input: StartAwsNativeEc2InstanceSnapshotsJobInput!): BatchAsyncJobStatus!
        internal void InvokeMutationStartAwsNativeEc2InstanceSnapshotsJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartAwsNativeEc2InstanceSnapshotsJobInput!"),
            };
            BatchAsyncJobStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (BatchAsyncJobStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (BatchAsyncJobStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.StartAwsNativeEc2InstanceSnapshotsJob(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationStartAwsNativeEc2InstanceSnapshotsJob",
                "($input: StartAwsNativeEc2InstanceSnapshotsJobInput!)",
                fieldSpecDoc,
                "BatchAsyncJobStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // startRestoreAwsNativeEc2InstanceSnapshotJob(input: StartRestoreAwsNativeEc2InstanceSnapshotJobInput!): AsyncJobStatus!
        internal void InvokeMutationStartRestoreAwsNativeEc2InstanceSnapshotJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartRestoreAwsNativeEc2InstanceSnapshotJobInput!"),
            };
            AsyncJobStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncJobStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncJobStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.StartRestoreAwsNativeEc2InstanceSnapshotJob(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationStartRestoreAwsNativeEc2InstanceSnapshotJob",
                "($input: StartRestoreAwsNativeEc2InstanceSnapshotJobInput!)",
                fieldSpecDoc,
                "AsyncJobStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // startRefreshAwsNativeAccountsJob(input: StartRefreshAwsNativeAccountsJobInput!): BatchAsyncJobStatus!
        internal void InvokeMutationStartRefreshAwsNativeAccountsJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartRefreshAwsNativeAccountsJobInput!"),
            };
            BatchAsyncJobStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (BatchAsyncJobStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (BatchAsyncJobStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.StartRefreshAwsNativeAccountsJob(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationStartRefreshAwsNativeAccountsJob",
                "($input: StartRefreshAwsNativeAccountsJobInput!)",
                fieldSpecDoc,
                "BatchAsyncJobStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // startCreateAwsNativeEbsVolumeSnapshotsJob(input: StartCreateAwsNativeEbsVolumeSnapshotsJobInput!): BatchAsyncJobStatus!
        internal void InvokeMutationStartCreateAwsNativeEbsVolumeSnapshotsJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartCreateAwsNativeEbsVolumeSnapshotsJobInput!"),
            };
            BatchAsyncJobStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (BatchAsyncJobStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (BatchAsyncJobStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.StartCreateAwsNativeEbsVolumeSnapshotsJob(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationStartCreateAwsNativeEbsVolumeSnapshotsJob",
                "($input: StartCreateAwsNativeEbsVolumeSnapshotsJobInput!)",
                fieldSpecDoc,
                "BatchAsyncJobStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // startAwsNativeAccountDisableJob(input: StartAwsNativeAccountDisableJobInput!): AsyncJobStatus!
        internal void InvokeMutationStartAwsNativeAccountDisableJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartAwsNativeAccountDisableJobInput!"),
            };
            AsyncJobStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncJobStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncJobStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.StartAwsNativeAccountDisableJob(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationStartAwsNativeAccountDisableJob",
                "($input: StartAwsNativeAccountDisableJobInput!)",
                fieldSpecDoc,
                "AsyncJobStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // startExportAwsNativeEbsVolumeSnapshotJob(input: StartExportAwsNativeEbsVolumeSnapshotJobInput!): AsyncJobStatus!
        internal void InvokeMutationStartExportAwsNativeEbsVolumeSnapshotJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartExportAwsNativeEbsVolumeSnapshotJobInput!"),
            };
            AsyncJobStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncJobStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncJobStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.StartExportAwsNativeEbsVolumeSnapshotJob(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationStartExportAwsNativeEbsVolumeSnapshotJob",
                "($input: StartExportAwsNativeEbsVolumeSnapshotJobInput!)",
                fieldSpecDoc,
                "AsyncJobStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // excludeAwsNativeEbsVolumesFromSnapshot(input: ExcludeAwsNativeEbsVolumesFromSnapshotInput!): Void
        internal void InvokeMutationExcludeAwsNativeEbsVolumesFromSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExcludeAwsNativeEbsVolumesFromSnapshotInput!"),
            };
            System.String? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (System.String)psObject.BaseObject;
                } else {
                    fieldSpecObj = (System.String)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.ExcludeAwsNativeEbsVolumesFromSnapshot(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationExcludeAwsNativeEbsVolumesFromSnapshot",
                "($input: ExcludeAwsNativeEbsVolumesFromSnapshotInput!)",
                fieldSpecDoc,
                "System.String"
            );
        }

        // Invoke GraphQL Mutation:
        // startAwsNativeRdsInstanceSnapshotsJob(input: StartAwsNativeRdsInstanceSnapshotsJobInput!): BatchAsyncJobStatus!
        internal void InvokeMutationStartAwsNativeRdsInstanceSnapshotsJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartAwsNativeRdsInstanceSnapshotsJobInput!"),
            };
            BatchAsyncJobStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (BatchAsyncJobStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (BatchAsyncJobStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.StartAwsNativeRdsInstanceSnapshotsJob(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationStartAwsNativeRdsInstanceSnapshotsJob",
                "($input: StartAwsNativeRdsInstanceSnapshotsJobInput!)",
                fieldSpecDoc,
                "BatchAsyncJobStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // createAwsAccount(input: CreateAwsAccountInput!): CloudAccount!
        internal void InvokeMutationCreateAwsAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAwsAccountInput!"),
            };
            CloudAccount? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CloudAccount)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CloudAccount)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.CreateAwsAccount(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationCreateAwsAccount",
                "($input: CreateAwsAccountInput!)",
                fieldSpecDoc,
                "CloudAccount"
            );
        }

        // Invoke GraphQL Mutation:
        // updateAwsAccount(input: UpdateAwsAccountInput!): CloudAccount!
        internal void InvokeMutationUpdateAwsAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAwsAccountInput!"),
            };
            CloudAccount? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CloudAccount)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CloudAccount)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.UpdateAwsAccount(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationUpdateAwsAccount",
                "($input: UpdateAwsAccountInput!)",
                fieldSpecDoc,
                "CloudAccount"
            );
        }

        // Invoke GraphQL Mutation:
        // createAutomaticAwsTargetMapping(input: CreateAutomaticAwsTargetMappingInput!): TargetMapping!
        internal void InvokeMutationCreateAutomaticAwsTargetMapping()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAutomaticAwsTargetMappingInput!"),
            };
            TargetMapping? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (TargetMapping)psObject.BaseObject;
                } else {
                    fieldSpecObj = (TargetMapping)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.CreateAutomaticAwsTargetMapping(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationCreateAutomaticAwsTargetMapping",
                "($input: CreateAutomaticAwsTargetMappingInput!)",
                fieldSpecDoc,
                "TargetMapping"
            );
        }

        // Invoke GraphQL Mutation:
        // createCloudNativeAwsStorageSetting(input: CreateCloudNativeAwsStorageSettingInput!): CreateCloudNativeAwsStorageSettingReply!
        internal void InvokeMutationCreateCloudNativeAwsStorageSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateCloudNativeAwsStorageSettingInput!"),
            };
            CreateCloudNativeAwsStorageSettingReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CreateCloudNativeAwsStorageSettingReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CreateCloudNativeAwsStorageSettingReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.CreateCloudNativeAwsStorageSetting(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationCreateCloudNativeAwsStorageSetting",
                "($input: CreateCloudNativeAwsStorageSettingInput!)",
                fieldSpecDoc,
                "CreateCloudNativeAwsStorageSettingReply"
            );
        }

        // Invoke GraphQL Mutation:
        // updateAutomaticAwsTargetMapping(input: UpdateAutomaticAwsTargetMappingInput!): TargetMapping!
        internal void InvokeMutationUpdateAutomaticAwsTargetMapping()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAutomaticAwsTargetMappingInput!"),
            };
            TargetMapping? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (TargetMapping)psObject.BaseObject;
                } else {
                    fieldSpecObj = (TargetMapping)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.UpdateAutomaticAwsTargetMapping(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationUpdateAutomaticAwsTargetMapping",
                "($input: UpdateAutomaticAwsTargetMappingInput!)",
                fieldSpecDoc,
                "TargetMapping"
            );
        }

        // Invoke GraphQL Mutation:
        // updateCloudNativeAwsStorageSetting(input: UpdateCloudNativeAwsStorageSettingInput!): UpdateCloudNativeAwsStorageSettingReply!
        internal void InvokeMutationUpdateCloudNativeAwsStorageSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateCloudNativeAwsStorageSettingInput!"),
            };
            UpdateCloudNativeAwsStorageSettingReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (UpdateCloudNativeAwsStorageSettingReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (UpdateCloudNativeAwsStorageSettingReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.UpdateCloudNativeAwsStorageSetting(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationUpdateCloudNativeAwsStorageSetting",
                "($input: UpdateCloudNativeAwsStorageSettingInput!)",
                fieldSpecDoc,
                "UpdateCloudNativeAwsStorageSettingReply"
            );
        }

        // Invoke GraphQL Mutation:
        // createAwsTarget(input: CreateAwsTargetInput!): Target!
        internal void InvokeMutationCreateAwsTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAwsTargetInput!"),
            };
            Target? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (Target)psObject.BaseObject;
                } else {
                    fieldSpecObj = (Target)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.CreateAwsTarget(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationCreateAwsTarget",
                "($input: CreateAwsTargetInput!)",
                fieldSpecDoc,
                "Target"
            );
        }

        // Invoke GraphQL Mutation:
        // updateAwsTarget(input: UpdateAwsTargetInput!): Target!
        internal void InvokeMutationUpdateAwsTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAwsTargetInput!"),
            };
            Target? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (Target)psObject.BaseObject;
                } else {
                    fieldSpecObj = (Target)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.UpdateAwsTarget(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationUpdateAwsTarget",
                "($input: UpdateAwsTargetInput!)",
                fieldSpecDoc,
                "Target"
            );
        }

        // Invoke GraphQL Mutation:
        // createAwsReaderTarget(input: CreateAwsReaderTargetInput!): Target!
        internal void InvokeMutationCreateAwsReaderTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAwsReaderTargetInput!"),
            };
            Target? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (Target)psObject.BaseObject;
                } else {
                    fieldSpecObj = (Target)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.CreateAwsReaderTarget(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationCreateAwsReaderTarget",
                "($input: CreateAwsReaderTargetInput!)",
                fieldSpecDoc,
                "Target"
            );
        }

        // Invoke GraphQL Mutation:
        // createAwsComputeSetting(input: CreateAwsComputeSettingInput!): AwsComputeSettings!
        internal void InvokeMutationCreateAwsComputeSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAwsComputeSettingInput!"),
            };
            AwsComputeSettings? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AwsComputeSettings)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AwsComputeSettings)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.CreateAwsComputeSetting(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationCreateAwsComputeSetting",
                "($input: CreateAwsComputeSettingInput!)",
                fieldSpecDoc,
                "AwsComputeSettings"
            );
        }

        // Invoke GraphQL Mutation:
        // updateAwsComputeSetting(input: UpdateAwsComputeSettingInput!): AwsComputeSettings!
        internal void InvokeMutationUpdateAwsComputeSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAwsComputeSettingInput!"),
            };
            AwsComputeSettings? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AwsComputeSettings)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AwsComputeSettings)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.UpdateAwsComputeSetting(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationUpdateAwsComputeSetting",
                "($input: UpdateAwsComputeSettingInput!)",
                fieldSpecDoc,
                "AwsComputeSettings"
            );
        }

        // Invoke GraphQL Mutation:
        // deleteAwsComputeSetting(input: DeleteAwsComputeSettingInput!): Void
        internal void InvokeMutationDeleteAwsComputeSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAwsComputeSettingInput!"),
            };
            System.String? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (System.String)psObject.BaseObject;
                } else {
                    fieldSpecObj = (System.String)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.DeleteAwsComputeSetting(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationDeleteAwsComputeSetting",
                "($input: DeleteAwsComputeSettingInput!)",
                fieldSpecDoc,
                "System.String"
            );
        }

        // Invoke GraphQL Mutation:
        // awsCloudAccountValidate(awsCloudAccountValidateArg: AwsCloudAccountValidateInput!): AwsCloudAccountValidateResponse!
        internal void InvokeMutationAwsCloudAccountValidate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsCloudAccountValidateArg", "AwsCloudAccountValidateInput!"),
            };
            AwsCloudAccountValidateResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AwsCloudAccountValidateResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AwsCloudAccountValidateResponse)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.AwsCloudAccountValidate(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationAwsCloudAccountValidate",
                "($awsCloudAccountValidateArg: AwsCloudAccountValidateInput!)",
                fieldSpecDoc,
                "AwsCloudAccountValidateResponse"
            );
        }

        // Invoke GraphQL Mutation:
        // awsCloudAccountInitiate(awsCloudAccountInitiateArg: AwsCloudAccountInitiateInput!): AwsCloudAccountCreateResponse!
        internal void InvokeMutationAwsCloudAccountInitiate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsCloudAccountInitiateArg", "AwsCloudAccountInitiateInput!"),
            };
            AwsCloudAccountCreateResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AwsCloudAccountCreateResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AwsCloudAccountCreateResponse)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.AwsCloudAccountInitiate(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationAwsCloudAccountInitiate",
                "($awsCloudAccountInitiateArg: AwsCloudAccountInitiateInput!)",
                fieldSpecDoc,
                "AwsCloudAccountCreateResponse"
            );
        }

        // Invoke GraphQL Mutation:
        // awsNativeProtectionAccountAdd(awsNativeProtectionAccountAddArg: AwsNativeProtectionAccountAddRequest!): AwsNativeProtectionAccountAddResponse!
        internal void InvokeMutationAwsNativeProtectionAccountAdd()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsNativeProtectionAccountAddArg", "AwsNativeProtectionAccountAddRequest!"),
            };
            AwsNativeProtectionAccountAddResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AwsNativeProtectionAccountAddResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AwsNativeProtectionAccountAddResponse)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.AwsNativeProtectionAccountAdd(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationAwsNativeProtectionAccountAdd",
                "($awsNativeProtectionAccountAddArg: AwsNativeProtectionAccountAddRequest!)",
                fieldSpecDoc,
                "AwsNativeProtectionAccountAddResponse"
            );
        }

        // Invoke GraphQL Mutation:
        // validateAndCreateAwsCloudAccount(input: ValidateAndCreateAwsCloudAccountInput!): ValidateAndCreateAwsCloudAccountReply!
        internal void InvokeMutationValidateAndCreateAwsCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ValidateAndCreateAwsCloudAccountInput!"),
            };
            ValidateAndCreateAwsCloudAccountReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (ValidateAndCreateAwsCloudAccountReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (ValidateAndCreateAwsCloudAccountReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.ValidateAndCreateAwsCloudAccount(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationValidateAndCreateAwsCloudAccount",
                "($input: ValidateAndCreateAwsCloudAccountInput!)",
                fieldSpecDoc,
                "ValidateAndCreateAwsCloudAccountReply"
            );
        }

        // Invoke GraphQL Mutation:
        // finalizeAwsCloudAccountProtection(input: FinalizeAwsCloudAccountProtectionInput!): FinalizeAwsCloudAccountProtectionReply!
        internal void InvokeMutationFinalizeAwsCloudAccountProtection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "FinalizeAwsCloudAccountProtectionInput!"),
            };
            FinalizeAwsCloudAccountProtectionReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (FinalizeAwsCloudAccountProtectionReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (FinalizeAwsCloudAccountProtectionReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.FinalizeAwsCloudAccountProtection(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationFinalizeAwsCloudAccountProtection",
                "($input: FinalizeAwsCloudAccountProtectionInput!)",
                fieldSpecDoc,
                "FinalizeAwsCloudAccountProtectionReply"
            );
        }

        // Invoke GraphQL Mutation:
        // prepareAwsCloudAccountDeletion(input: PrepareAwsCloudAccountDeletionInput!): PrepareAwsCloudAccountDeletionReply!
        internal void InvokeMutationPrepareAwsCloudAccountDeletion()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PrepareAwsCloudAccountDeletionInput!"),
            };
            PrepareAwsCloudAccountDeletionReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (PrepareAwsCloudAccountDeletionReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (PrepareAwsCloudAccountDeletionReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.PrepareAwsCloudAccountDeletion(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationPrepareAwsCloudAccountDeletion",
                "($input: PrepareAwsCloudAccountDeletionInput!)",
                fieldSpecDoc,
                "PrepareAwsCloudAccountDeletionReply"
            );
        }

        // Invoke GraphQL Mutation:
        // finalizeAwsCloudAccountDeletion(input: FinalizeAwsCloudAccountDeletionInput!): FinalizeAwsCloudAccountDeletionReply!
        internal void InvokeMutationFinalizeAwsCloudAccountDeletion()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "FinalizeAwsCloudAccountDeletionInput!"),
            };
            FinalizeAwsCloudAccountDeletionReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (FinalizeAwsCloudAccountDeletionReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (FinalizeAwsCloudAccountDeletionReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.FinalizeAwsCloudAccountDeletion(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationFinalizeAwsCloudAccountDeletion",
                "($input: FinalizeAwsCloudAccountDeletionInput!)",
                fieldSpecDoc,
                "FinalizeAwsCloudAccountDeletionReply"
            );
        }

        // Invoke GraphQL Mutation:
        // updateAwsCloudAccountFeature(input: UpdateAwsCloudAccountFeatureInput!): UpdateAwsCloudAccountFeatureReply!
        internal void InvokeMutationUpdateAwsCloudAccountFeature()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAwsCloudAccountFeatureInput!"),
            };
            UpdateAwsCloudAccountFeatureReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (UpdateAwsCloudAccountFeatureReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (UpdateAwsCloudAccountFeatureReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.UpdateAwsCloudAccountFeature(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationUpdateAwsCloudAccountFeature",
                "($input: UpdateAwsCloudAccountFeatureInput!)",
                fieldSpecDoc,
                "UpdateAwsCloudAccountFeatureReply"
            );
        }

        // Invoke GraphQL Mutation:
        // updateAwsCloudAccount(input: UpdateAwsCloudAccountInput!): Void
        internal void InvokeMutationUpdateAwsCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAwsCloudAccountInput!"),
            };
            System.String? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (System.String)psObject.BaseObject;
                } else {
                    fieldSpecObj = (System.String)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.UpdateAwsCloudAccount(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationUpdateAwsCloudAccount",
                "($input: UpdateAwsCloudAccountInput!)",
                fieldSpecDoc,
                "System.String"
            );
        }

        // Invoke GraphQL Mutation:
        // prepareFeatureUpdateForAwsCloudAccount(input: PrepareFeatureUpdateForAwsCloudAccountInput!): PrepareFeatureUpdateForAwsCloudAccountReply!
        internal void InvokeMutationPrepareFeatureUpdateForAwsCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PrepareFeatureUpdateForAwsCloudAccountInput!"),
            };
            PrepareFeatureUpdateForAwsCloudAccountReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (PrepareFeatureUpdateForAwsCloudAccountReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (PrepareFeatureUpdateForAwsCloudAccountReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.PrepareFeatureUpdateForAwsCloudAccount(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationPrepareFeatureUpdateForAwsCloudAccount",
                "($input: PrepareFeatureUpdateForAwsCloudAccountInput!)",
                fieldSpecDoc,
                "PrepareFeatureUpdateForAwsCloudAccountReply"
            );
        }

        // Invoke GraphQL Mutation:
        // awsCloudAccountUpdateFeature(cloudAccountUuid: UUID!, features: [CloudAccountFeature!]!): AwsCloudAccountUpdateFeatureResponse!
        internal void InvokeMutationAwsCloudAccountUpdateFeature()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountUuid", "UUID!"),
                Tuple.Create("features", "[CloudAccountFeature!]!"),
            };
            AwsCloudAccountUpdateFeatureResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AwsCloudAccountUpdateFeatureResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AwsCloudAccountUpdateFeatureResponse)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.AwsCloudAccountUpdateFeature(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationAwsCloudAccountUpdateFeature",
                "($cloudAccountUuid: UUID!,$features: [CloudAccountFeature!]!)",
                fieldSpecDoc,
                "AwsCloudAccountUpdateFeatureResponse"
            );
        }

        // Invoke GraphQL Mutation:
        // createAwsExocomputeConfigs(input: CreateAwsExocomputeConfigsInput!): CreateAwsExocomputeConfigsReply!
        internal void InvokeMutationCreateAwsExocomputeConfigs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAwsExocomputeConfigsInput!"),
            };
            CreateAwsExocomputeConfigsReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CreateAwsExocomputeConfigsReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CreateAwsExocomputeConfigsReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.CreateAwsExocomputeConfigs(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationCreateAwsExocomputeConfigs",
                "($input: CreateAwsExocomputeConfigsInput!)",
                fieldSpecDoc,
                "CreateAwsExocomputeConfigsReply"
            );
        }

        // Invoke GraphQL Mutation:
        // deleteAwsExocomputeConfigs(input: DeleteAwsExocomputeConfigsInput!): DeleteAwsExocomputeConfigsReply!
        internal void InvokeMutationDeleteAwsExocomputeConfigs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAwsExocomputeConfigsInput!"),
            };
            DeleteAwsExocomputeConfigsReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (DeleteAwsExocomputeConfigsReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (DeleteAwsExocomputeConfigsReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.DeleteAwsExocomputeConfigs(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationDeleteAwsExocomputeConfigs",
                "($input: DeleteAwsExocomputeConfigsInput!)",
                fieldSpecDoc,
                "DeleteAwsExocomputeConfigsReply"
            );
        }

        // Invoke GraphQL Mutation:
        // updateAwsExocomputeConfigs(input: UpdateAwsExocomputeConfigsInput!): UpdateAwsExocomputeConfigsReply!
        internal void InvokeMutationUpdateAwsExocomputeConfigs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAwsExocomputeConfigsInput!"),
            };
            UpdateAwsExocomputeConfigsReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (UpdateAwsExocomputeConfigsReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (UpdateAwsExocomputeConfigsReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.UpdateAwsExocomputeConfigs(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationUpdateAwsExocomputeConfigs",
                "($input: UpdateAwsExocomputeConfigsInput!)",
                fieldSpecDoc,
                "UpdateAwsExocomputeConfigsReply"
            );
        }

        // Invoke GraphQL Mutation:
        // startAwsExocomputeDisableJob(input: StartAwsExocomputeDisableJobInput!): AsyncJobStatus!
        internal void InvokeMutationStartAwsExocomputeDisableJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartAwsExocomputeDisableJobInput!"),
            };
            AsyncJobStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncJobStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncJobStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.StartAwsExocomputeDisableJob(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationStartAwsExocomputeDisableJob",
                "($input: StartAwsExocomputeDisableJobInput!)",
                fieldSpecDoc,
                "AsyncJobStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // addAwsIamUserBasedCloudAccount(input: AddAwsIamUserBasedCloudAccountInput!): AddAwsIamUserBasedCloudAccountReply!
        internal void InvokeMutationAddAwsIamUserBasedCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddAwsIamUserBasedCloudAccountInput!"),
            };
            AddAwsIamUserBasedCloudAccountReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AddAwsIamUserBasedCloudAccountReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AddAwsIamUserBasedCloudAccountReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.AddAwsIamUserBasedCloudAccount(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationAddAwsIamUserBasedCloudAccount",
                "($input: AddAwsIamUserBasedCloudAccountInput!)",
                fieldSpecDoc,
                "AddAwsIamUserBasedCloudAccountReply"
            );
        }

        // Invoke GraphQL Mutation:
        // deleteAwsIamUserBasedCloudAccount(input: DeleteAwsIamUserBasedCloudAccountInput!): DeleteAwsIamUserBasedCloudAccountReply!
        internal void InvokeMutationDeleteAwsIamUserBasedCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAwsIamUserBasedCloudAccountInput!"),
            };
            DeleteAwsIamUserBasedCloudAccountReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (DeleteAwsIamUserBasedCloudAccountReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (DeleteAwsIamUserBasedCloudAccountReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.DeleteAwsIamUserBasedCloudAccount(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationDeleteAwsIamUserBasedCloudAccount",
                "($input: DeleteAwsIamUserBasedCloudAccountInput!)",
                fieldSpecDoc,
                "DeleteAwsIamUserBasedCloudAccountReply"
            );
        }

        // Invoke GraphQL Mutation:
        // deleteAwsCloudAccountWithoutCft(input: DeleteAwsCloudAccountWithoutCftInput!): DeleteAwsCloudAccountWithoutCftReply!
        internal void InvokeMutationDeleteAwsCloudAccountWithoutCft()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAwsCloudAccountWithoutCftInput!"),
            };
            DeleteAwsCloudAccountWithoutCftReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (DeleteAwsCloudAccountWithoutCftReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (DeleteAwsCloudAccountWithoutCftReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.DeleteAwsCloudAccountWithoutCft(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationDeleteAwsCloudAccountWithoutCft",
                "($input: DeleteAwsCloudAccountWithoutCftInput!)",
                fieldSpecDoc,
                "DeleteAwsCloudAccountWithoutCftReply"
            );
        }

        // Invoke GraphQL Mutation:
        // upgradeAwsIamUserBasedCloudAccountPermissions(input: UpgradeAwsIamUserBasedCloudAccountPermissionsInput!): Boolean!
        internal void InvokeMutationUpgradeAwsIamUserBasedCloudAccountPermissions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpgradeAwsIamUserBasedCloudAccountPermissionsInput!"),
            };
            System.Boolean? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (System.Boolean)psObject.BaseObject;
                } else {
                    fieldSpecObj = (System.Boolean)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.UpgradeAwsIamUserBasedCloudAccountPermissions(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationUpgradeAwsIamUserBasedCloudAccountPermissions",
                "($input: UpgradeAwsIamUserBasedCloudAccountPermissionsInput!)",
                fieldSpecDoc,
                "System.Boolean"
            );
        }

        // Invoke GraphQL Mutation:
        // upgradeAwsCloudAccountFeaturesWithoutCft(input: UpgradeAwsCloudAccountFeaturesWithoutCftInput!): Boolean!
        internal void InvokeMutationUpgradeAwsCloudAccountFeaturesWithoutCft()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpgradeAwsCloudAccountFeaturesWithoutCftInput!"),
            };
            System.Boolean? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (System.Boolean)psObject.BaseObject;
                } else {
                    fieldSpecObj = (System.Boolean)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.UpgradeAwsCloudAccountFeaturesWithoutCft(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationUpgradeAwsCloudAccountFeaturesWithoutCft",
                "($input: UpgradeAwsCloudAccountFeaturesWithoutCftInput!)",
                fieldSpecDoc,
                "System.Boolean"
            );
        }

        // Invoke GraphQL Mutation:
        // addAwsAuthenticationServerBasedCloudAccount(input: AddAwsAuthenticationServerBasedCloudAccountInput!): AddAwsAuthenticationServerBasedCloudAccountReply!
        internal void InvokeMutationAddAwsAuthenticationServerBasedCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddAwsAuthenticationServerBasedCloudAccountInput!"),
            };
            AddAwsAuthenticationServerBasedCloudAccountReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AddAwsAuthenticationServerBasedCloudAccountReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AddAwsAuthenticationServerBasedCloudAccountReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.AddAwsAuthenticationServerBasedCloudAccount(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationAddAwsAuthenticationServerBasedCloudAccount",
                "($input: AddAwsAuthenticationServerBasedCloudAccountInput!)",
                fieldSpecDoc,
                "AddAwsAuthenticationServerBasedCloudAccountReply"
            );
        }

        // Invoke GraphQL Mutation:
        // patchAwsAuthenticationServerBasedCloudAccount(input: PatchAwsAuthenticationServerBasedCloudAccountInput!): Boolean!
        internal void InvokeMutationPatchAwsAuthenticationServerBasedCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PatchAwsAuthenticationServerBasedCloudAccountInput!"),
            };
            System.Boolean? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (System.Boolean)psObject.BaseObject;
                } else {
                    fieldSpecObj = (System.Boolean)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.PatchAwsAuthenticationServerBasedCloudAccount(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationPatchAwsAuthenticationServerBasedCloudAccount",
                "($input: PatchAwsAuthenticationServerBasedCloudAccountInput!)",
                fieldSpecDoc,
                "System.Boolean"
            );
        }

        // Invoke GraphQL Mutation:
        // patchAwsIamUserBasedCloudAccount(input: PatchAwsIamUserBasedCloudAccountInput!): Boolean!
        internal void InvokeMutationPatchAwsIamUserBasedCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PatchAwsIamUserBasedCloudAccountInput!"),
            };
            System.Boolean? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (System.Boolean)psObject.BaseObject;
                } else {
                    fieldSpecObj = (System.Boolean)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.PatchAwsIamUserBasedCloudAccount(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationPatchAwsIamUserBasedCloudAccount",
                "($input: PatchAwsIamUserBasedCloudAccountInput!)",
                fieldSpecDoc,
                "System.Boolean"
            );
        }

        // Invoke GraphQL Mutation:
        // registerAwsFeatureArtifacts(input: RegisterAwsFeatureArtifactsInput!): RegisterAwsFeatureArtifactsReply!
        internal void InvokeMutationRegisterAwsFeatureArtifacts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RegisterAwsFeatureArtifactsInput!"),
            };
            RegisterAwsFeatureArtifactsReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (RegisterAwsFeatureArtifactsReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (RegisterAwsFeatureArtifactsReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.RegisterAwsFeatureArtifacts(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationRegisterAwsFeatureArtifacts",
                "($input: RegisterAwsFeatureArtifactsInput!)",
                fieldSpecDoc,
                "RegisterAwsFeatureArtifactsReply"
            );
        }

        // Invoke GraphQL Mutation:
        // bulkDeleteAwsCloudAccountWithoutCft(input: BulkDeleteAwsCloudAccountWithoutCftInput!): BulkDeleteAwsCloudAccountWithoutCftReply!
        internal void InvokeMutationBulkDeleteAwsCloudAccountWithoutCft()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkDeleteAwsCloudAccountWithoutCftInput!"),
            };
            BulkDeleteAwsCloudAccountWithoutCftReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (BulkDeleteAwsCloudAccountWithoutCftReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (BulkDeleteAwsCloudAccountWithoutCftReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.BulkDeleteAwsCloudAccountWithoutCft(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationBulkDeleteAwsCloudAccountWithoutCft",
                "($input: BulkDeleteAwsCloudAccountWithoutCftInput!)",
                fieldSpecDoc,
                "BulkDeleteAwsCloudAccountWithoutCftReply"
            );
        }

        // Invoke GraphQL Mutation:
        // createAwsCluster(input: CreateAwsClusterInput!): CcProvisionJobReply!
        internal void InvokeMutationCreateAwsCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAwsClusterInput!"),
            };
            CcProvisionJobReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CcProvisionJobReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CcProvisionJobReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.CreateAwsCluster(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationCreateAwsCluster",
                "($input: CreateAwsClusterInput!)",
                fieldSpecDoc,
                "CcProvisionJobReply"
            );
        }

        // Invoke GraphQL Mutation:
        // deleteAwsCluster(input: DeleteAwsClusterInput!): CcProvisionJobReply!
        internal void InvokeMutationDeleteAwsCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAwsClusterInput!"),
            };
            CcProvisionJobReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CcProvisionJobReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CcProvisionJobReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.DeleteAwsCluster(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationDeleteAwsCluster",
                "($input: DeleteAwsClusterInput!)",
                fieldSpecDoc,
                "CcProvisionJobReply"
            );
        }


    } // class Invoke_RscMutateAws
}