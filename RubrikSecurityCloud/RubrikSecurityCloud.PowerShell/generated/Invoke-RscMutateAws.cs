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
        
        // -------------------------------------------------------------------
        // StartNativeEc2InstanceSnapshotsJob parameter set
        //
        // [GraphQL: startAwsNativeEc2InstanceSnapshotsJob]
        //
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

        
        // -------------------------------------------------------------------
        // StartRestoreNativeEc2InstanceSnapshotJob parameter set
        //
        // [GraphQL: startRestoreAwsNativeEc2InstanceSnapshotJob]
        //
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

        
        // -------------------------------------------------------------------
        // StartRefreshNativeAccountsJob parameter set
        //
        // [GraphQL: startRefreshAwsNativeAccountsJob]
        //
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

        
        // -------------------------------------------------------------------
        // StartCreateNativeEbsVolumeSnapshotsJob parameter set
        //
        // [GraphQL: startCreateAwsNativeEbsVolumeSnapshotsJob]
        //
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

        
        // -------------------------------------------------------------------
        // StartNativeAccountDisableJob parameter set
        //
        // [GraphQL: startAwsNativeAccountDisableJob]
        //
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

        
        // -------------------------------------------------------------------
        // StartExportNativeEbsVolumeSnapshotJob parameter set
        //
        // [GraphQL: startExportAwsNativeEbsVolumeSnapshotJob]
        //
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

        
        // -------------------------------------------------------------------
        // ExcludeNativeEbsVolumesFromSnapshot parameter set
        //
        // [GraphQL: excludeAwsNativeEbsVolumesFromSnapshot]
        //
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

        
        // -------------------------------------------------------------------
        // StartNativeRdsInstanceSnapshotsJob parameter set
        //
        // [GraphQL: startAwsNativeRdsInstanceSnapshotsJob]
        //
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

        
        // -------------------------------------------------------------------
        // CreateAccount parameter set
        //
        // [GraphQL: createAwsAccount]
        //
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

        
        // -------------------------------------------------------------------
        // UpdateAccount parameter set
        //
        // [GraphQL: updateAwsAccount]
        //
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

        
        // -------------------------------------------------------------------
        // CreateAutomaticTargetMapping parameter set
        //
        // [GraphQL: createAutomaticAwsTargetMapping]
        //
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

        
        // -------------------------------------------------------------------
        // CreateCloudNativeStorageSetting parameter set
        //
        // [GraphQL: createCloudNativeAwsStorageSetting]
        //
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

        
        // -------------------------------------------------------------------
        // UpdateAutomaticTargetMapping parameter set
        //
        // [GraphQL: updateAutomaticAwsTargetMapping]
        //
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

        
        // -------------------------------------------------------------------
        // UpdateCloudNativeStorageSetting parameter set
        //
        // [GraphQL: updateCloudNativeAwsStorageSetting]
        //
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

        
        // -------------------------------------------------------------------
        // CreateTarget parameter set
        //
        // [GraphQL: createAwsTarget]
        //
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

        
        // -------------------------------------------------------------------
        // UpdateTarget parameter set
        //
        // [GraphQL: updateAwsTarget]
        //
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

        
        // -------------------------------------------------------------------
        // CreateReaderTarget parameter set
        //
        // [GraphQL: createAwsReaderTarget]
        //
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

        
        // -------------------------------------------------------------------
        // CreateComputeSetting parameter set
        //
        // [GraphQL: createAwsComputeSetting]
        //
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

        
        // -------------------------------------------------------------------
        // UpdateComputeSetting parameter set
        //
        // [GraphQL: updateAwsComputeSetting]
        //
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

        
        // -------------------------------------------------------------------
        // DeleteComputeSetting parameter set
        //
        // [GraphQL: deleteAwsComputeSetting]
        //
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

        
        // -------------------------------------------------------------------
        // CloudAccountValidate parameter set
        //
        // [GraphQL: awsCloudAccountValidate]
        //
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

        
        // -------------------------------------------------------------------
        // CloudAccountInitiate parameter set
        //
        // [GraphQL: awsCloudAccountInitiate]
        //
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

        
        // -------------------------------------------------------------------
        // NativeProtectionAccountAdd parameter set
        //
        // [GraphQL: awsNativeProtectionAccountAdd]
        //
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

        
        // -------------------------------------------------------------------
        // ValidateAndCreateCloudAccount parameter set
        //
        // [GraphQL: validateAndCreateAwsCloudAccount]
        //
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

        
        // -------------------------------------------------------------------
        // FinalizeCloudAccountProtection parameter set
        //
        // [GraphQL: finalizeAwsCloudAccountProtection]
        //
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

        
        // -------------------------------------------------------------------
        // PrepareCloudAccountDeletion parameter set
        //
        // [GraphQL: prepareAwsCloudAccountDeletion]
        //
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

        
        // -------------------------------------------------------------------
        // FinalizeCloudAccountDeletion parameter set
        //
        // [GraphQL: finalizeAwsCloudAccountDeletion]
        //
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

        
        // -------------------------------------------------------------------
        // UpdateCloudAccountFeature parameter set
        //
        // [GraphQL: updateAwsCloudAccountFeature]
        //
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

        
        // -------------------------------------------------------------------
        // UpdateCloudAccount parameter set
        //
        // [GraphQL: updateAwsCloudAccount]
        //
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

        
        // -------------------------------------------------------------------
        // PrepareFeatureUpdateForCloudAccount parameter set
        //
        // [GraphQL: prepareFeatureUpdateForAwsCloudAccount]
        //
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

        
        // -------------------------------------------------------------------
        // CloudAccountUpdateFeature parameter set
        //
        // [GraphQL: awsCloudAccountUpdateFeature]
        //
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

        
        // -------------------------------------------------------------------
        // CreateExocomputeConfigs parameter set
        //
        // [GraphQL: createAwsExocomputeConfigs]
        //
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

        
        // -------------------------------------------------------------------
        // DeleteExocomputeConfigs parameter set
        //
        // [GraphQL: deleteAwsExocomputeConfigs]
        //
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

        
        // -------------------------------------------------------------------
        // UpdateExocomputeConfigs parameter set
        //
        // [GraphQL: updateAwsExocomputeConfigs]
        //
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

        
        // -------------------------------------------------------------------
        // StartExocomputeDisableJob parameter set
        //
        // [GraphQL: startAwsExocomputeDisableJob]
        //
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

        
        // -------------------------------------------------------------------
        // AddIamUserBasedCloudAccount parameter set
        //
        // [GraphQL: addAwsIamUserBasedCloudAccount]
        //
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

        
        // -------------------------------------------------------------------
        // DeleteIamUserBasedCloudAccount parameter set
        //
        // [GraphQL: deleteAwsIamUserBasedCloudAccount]
        //
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

        
        // -------------------------------------------------------------------
        // DeleteCloudAccountWithoutCft parameter set
        //
        // [GraphQL: deleteAwsCloudAccountWithoutCft]
        //
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

        
        // -------------------------------------------------------------------
        // UpgradeIamUserBasedCloudAccountPermissions parameter set
        //
        // [GraphQL: upgradeAwsIamUserBasedCloudAccountPermissions]
        //
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

        
        // -------------------------------------------------------------------
        // UpgradeCloudAccountFeaturesWithoutCft parameter set
        //
        // [GraphQL: upgradeAwsCloudAccountFeaturesWithoutCft]
        //
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

        
        // -------------------------------------------------------------------
        // AddAuthenticationServerBasedCloudAccount parameter set
        //
        // [GraphQL: addAwsAuthenticationServerBasedCloudAccount]
        //
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

        
        // -------------------------------------------------------------------
        // PatchAuthenticationServerBasedCloudAccount parameter set
        //
        // [GraphQL: patchAwsAuthenticationServerBasedCloudAccount]
        //
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

        
        // -------------------------------------------------------------------
        // PatchIamUserBasedCloudAccount parameter set
        //
        // [GraphQL: patchAwsIamUserBasedCloudAccount]
        //
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

        
        // -------------------------------------------------------------------
        // RegisterFeatureArtifacts parameter set
        //
        // [GraphQL: registerAwsFeatureArtifacts]
        //
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

        
        // -------------------------------------------------------------------
        // BulkDeleteCloudAccountWithoutCft parameter set
        //
        // [GraphQL: bulkDeleteAwsCloudAccountWithoutCft]
        //
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

        
        // -------------------------------------------------------------------
        // CreateCluster parameter set
        //
        // [GraphQL: createAwsCluster]
        //
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

        
        // -------------------------------------------------------------------
        // DeleteCluster parameter set
        //
        // [GraphQL: deleteAwsCluster]
        //
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

        // This parameter set invokes a single graphql operation:
        // startAwsNativeEc2InstanceSnapshotsJob.
        protected void ProcessRecord_StartNativeEc2InstanceSnapshotsJob()
        {
            this._logger.name += " -StartNativeEc2InstanceSnapshotsJob";
            // Invoke graphql operation startAwsNativeEc2InstanceSnapshotsJob
            InvokeMutationStartAwsNativeEc2InstanceSnapshotsJob();
        }

        // This parameter set invokes a single graphql operation:
        // startRestoreAwsNativeEc2InstanceSnapshotJob.
        protected void ProcessRecord_StartRestoreNativeEc2InstanceSnapshotJob()
        {
            this._logger.name += " -StartRestoreNativeEc2InstanceSnapshotJob";
            // Invoke graphql operation startRestoreAwsNativeEc2InstanceSnapshotJob
            InvokeMutationStartRestoreAwsNativeEc2InstanceSnapshotJob();
        }

        // This parameter set invokes a single graphql operation:
        // startRefreshAwsNativeAccountsJob.
        protected void ProcessRecord_StartRefreshNativeAccountsJob()
        {
            this._logger.name += " -StartRefreshNativeAccountsJob";
            // Invoke graphql operation startRefreshAwsNativeAccountsJob
            InvokeMutationStartRefreshAwsNativeAccountsJob();
        }

        // This parameter set invokes a single graphql operation:
        // startCreateAwsNativeEbsVolumeSnapshotsJob.
        protected void ProcessRecord_StartCreateNativeEbsVolumeSnapshotsJob()
        {
            this._logger.name += " -StartCreateNativeEbsVolumeSnapshotsJob";
            // Invoke graphql operation startCreateAwsNativeEbsVolumeSnapshotsJob
            InvokeMutationStartCreateAwsNativeEbsVolumeSnapshotsJob();
        }

        // This parameter set invokes a single graphql operation:
        // startAwsNativeAccountDisableJob.
        protected void ProcessRecord_StartNativeAccountDisableJob()
        {
            this._logger.name += " -StartNativeAccountDisableJob";
            // Invoke graphql operation startAwsNativeAccountDisableJob
            InvokeMutationStartAwsNativeAccountDisableJob();
        }

        // This parameter set invokes a single graphql operation:
        // startExportAwsNativeEbsVolumeSnapshotJob.
        protected void ProcessRecord_StartExportNativeEbsVolumeSnapshotJob()
        {
            this._logger.name += " -StartExportNativeEbsVolumeSnapshotJob";
            // Invoke graphql operation startExportAwsNativeEbsVolumeSnapshotJob
            InvokeMutationStartExportAwsNativeEbsVolumeSnapshotJob();
        }

        // This parameter set invokes a single graphql operation:
        // excludeAwsNativeEbsVolumesFromSnapshot.
        protected void ProcessRecord_ExcludeNativeEbsVolumesFromSnapshot()
        {
            this._logger.name += " -ExcludeNativeEbsVolumesFromSnapshot";
            // Invoke graphql operation excludeAwsNativeEbsVolumesFromSnapshot
            InvokeMutationExcludeAwsNativeEbsVolumesFromSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // startAwsNativeRdsInstanceSnapshotsJob.
        protected void ProcessRecord_StartNativeRdsInstanceSnapshotsJob()
        {
            this._logger.name += " -StartNativeRdsInstanceSnapshotsJob";
            // Invoke graphql operation startAwsNativeRdsInstanceSnapshotsJob
            InvokeMutationStartAwsNativeRdsInstanceSnapshotsJob();
        }

        // This parameter set invokes a single graphql operation:
        // createAwsAccount.
        protected void ProcessRecord_CreateAccount()
        {
            this._logger.name += " -CreateAccount";
            // Invoke graphql operation createAwsAccount
            InvokeMutationCreateAwsAccount();
        }

        // This parameter set invokes a single graphql operation:
        // updateAwsAccount.
        protected void ProcessRecord_UpdateAccount()
        {
            this._logger.name += " -UpdateAccount";
            // Invoke graphql operation updateAwsAccount
            InvokeMutationUpdateAwsAccount();
        }

        // This parameter set invokes a single graphql operation:
        // createAutomaticAwsTargetMapping.
        protected void ProcessRecord_CreateAutomaticTargetMapping()
        {
            this._logger.name += " -CreateAutomaticTargetMapping";
            // Invoke graphql operation createAutomaticAwsTargetMapping
            InvokeMutationCreateAutomaticAwsTargetMapping();
        }

        // This parameter set invokes a single graphql operation:
        // createCloudNativeAwsStorageSetting.
        protected void ProcessRecord_CreateCloudNativeStorageSetting()
        {
            this._logger.name += " -CreateCloudNativeStorageSetting";
            // Invoke graphql operation createCloudNativeAwsStorageSetting
            InvokeMutationCreateCloudNativeAwsStorageSetting();
        }

        // This parameter set invokes a single graphql operation:
        // updateAutomaticAwsTargetMapping.
        protected void ProcessRecord_UpdateAutomaticTargetMapping()
        {
            this._logger.name += " -UpdateAutomaticTargetMapping";
            // Invoke graphql operation updateAutomaticAwsTargetMapping
            InvokeMutationUpdateAutomaticAwsTargetMapping();
        }

        // This parameter set invokes a single graphql operation:
        // updateCloudNativeAwsStorageSetting.
        protected void ProcessRecord_UpdateCloudNativeStorageSetting()
        {
            this._logger.name += " -UpdateCloudNativeStorageSetting";
            // Invoke graphql operation updateCloudNativeAwsStorageSetting
            InvokeMutationUpdateCloudNativeAwsStorageSetting();
        }

        // This parameter set invokes a single graphql operation:
        // createAwsTarget.
        protected void ProcessRecord_CreateTarget()
        {
            this._logger.name += " -CreateTarget";
            // Invoke graphql operation createAwsTarget
            InvokeMutationCreateAwsTarget();
        }

        // This parameter set invokes a single graphql operation:
        // updateAwsTarget.
        protected void ProcessRecord_UpdateTarget()
        {
            this._logger.name += " -UpdateTarget";
            // Invoke graphql operation updateAwsTarget
            InvokeMutationUpdateAwsTarget();
        }

        // This parameter set invokes a single graphql operation:
        // createAwsReaderTarget.
        protected void ProcessRecord_CreateReaderTarget()
        {
            this._logger.name += " -CreateReaderTarget";
            // Invoke graphql operation createAwsReaderTarget
            InvokeMutationCreateAwsReaderTarget();
        }

        // This parameter set invokes a single graphql operation:
        // createAwsComputeSetting.
        protected void ProcessRecord_CreateComputeSetting()
        {
            this._logger.name += " -CreateComputeSetting";
            // Invoke graphql operation createAwsComputeSetting
            InvokeMutationCreateAwsComputeSetting();
        }

        // This parameter set invokes a single graphql operation:
        // updateAwsComputeSetting.
        protected void ProcessRecord_UpdateComputeSetting()
        {
            this._logger.name += " -UpdateComputeSetting";
            // Invoke graphql operation updateAwsComputeSetting
            InvokeMutationUpdateAwsComputeSetting();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAwsComputeSetting.
        protected void ProcessRecord_DeleteComputeSetting()
        {
            this._logger.name += " -DeleteComputeSetting";
            // Invoke graphql operation deleteAwsComputeSetting
            InvokeMutationDeleteAwsComputeSetting();
        }

        // This parameter set invokes a single graphql operation:
        // awsCloudAccountValidate.
        protected void ProcessRecord_CloudAccountValidate()
        {
            this._logger.name += " -CloudAccountValidate";
            // Invoke graphql operation awsCloudAccountValidate
            InvokeMutationAwsCloudAccountValidate();
        }

        // This parameter set invokes a single graphql operation:
        // awsCloudAccountInitiate.
        protected void ProcessRecord_CloudAccountInitiate()
        {
            this._logger.name += " -CloudAccountInitiate";
            // Invoke graphql operation awsCloudAccountInitiate
            InvokeMutationAwsCloudAccountInitiate();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeProtectionAccountAdd.
        protected void ProcessRecord_NativeProtectionAccountAdd()
        {
            this._logger.name += " -NativeProtectionAccountAdd";
            // Invoke graphql operation awsNativeProtectionAccountAdd
            InvokeMutationAwsNativeProtectionAccountAdd();
        }

        // This parameter set invokes a single graphql operation:
        // validateAndCreateAwsCloudAccount.
        protected void ProcessRecord_ValidateAndCreateCloudAccount()
        {
            this._logger.name += " -ValidateAndCreateCloudAccount";
            // Invoke graphql operation validateAndCreateAwsCloudAccount
            InvokeMutationValidateAndCreateAwsCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // finalizeAwsCloudAccountProtection.
        protected void ProcessRecord_FinalizeCloudAccountProtection()
        {
            this._logger.name += " -FinalizeCloudAccountProtection";
            // Invoke graphql operation finalizeAwsCloudAccountProtection
            InvokeMutationFinalizeAwsCloudAccountProtection();
        }

        // This parameter set invokes a single graphql operation:
        // prepareAwsCloudAccountDeletion.
        protected void ProcessRecord_PrepareCloudAccountDeletion()
        {
            this._logger.name += " -PrepareCloudAccountDeletion";
            // Invoke graphql operation prepareAwsCloudAccountDeletion
            InvokeMutationPrepareAwsCloudAccountDeletion();
        }

        // This parameter set invokes a single graphql operation:
        // finalizeAwsCloudAccountDeletion.
        protected void ProcessRecord_FinalizeCloudAccountDeletion()
        {
            this._logger.name += " -FinalizeCloudAccountDeletion";
            // Invoke graphql operation finalizeAwsCloudAccountDeletion
            InvokeMutationFinalizeAwsCloudAccountDeletion();
        }

        // This parameter set invokes a single graphql operation:
        // updateAwsCloudAccountFeature.
        protected void ProcessRecord_UpdateCloudAccountFeature()
        {
            this._logger.name += " -UpdateCloudAccountFeature";
            // Invoke graphql operation updateAwsCloudAccountFeature
            InvokeMutationUpdateAwsCloudAccountFeature();
        }

        // This parameter set invokes a single graphql operation:
        // updateAwsCloudAccount.
        protected void ProcessRecord_UpdateCloudAccount()
        {
            this._logger.name += " -UpdateCloudAccount";
            // Invoke graphql operation updateAwsCloudAccount
            InvokeMutationUpdateAwsCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // prepareFeatureUpdateForAwsCloudAccount.
        protected void ProcessRecord_PrepareFeatureUpdateForCloudAccount()
        {
            this._logger.name += " -PrepareFeatureUpdateForCloudAccount";
            // Invoke graphql operation prepareFeatureUpdateForAwsCloudAccount
            InvokeMutationPrepareFeatureUpdateForAwsCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // awsCloudAccountUpdateFeature.
        protected void ProcessRecord_CloudAccountUpdateFeature()
        {
            this._logger.name += " -CloudAccountUpdateFeature";
            // Invoke graphql operation awsCloudAccountUpdateFeature
            InvokeMutationAwsCloudAccountUpdateFeature();
        }

        // This parameter set invokes a single graphql operation:
        // createAwsExocomputeConfigs.
        protected void ProcessRecord_CreateExocomputeConfigs()
        {
            this._logger.name += " -CreateExocomputeConfigs";
            // Invoke graphql operation createAwsExocomputeConfigs
            InvokeMutationCreateAwsExocomputeConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAwsExocomputeConfigs.
        protected void ProcessRecord_DeleteExocomputeConfigs()
        {
            this._logger.name += " -DeleteExocomputeConfigs";
            // Invoke graphql operation deleteAwsExocomputeConfigs
            InvokeMutationDeleteAwsExocomputeConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // updateAwsExocomputeConfigs.
        protected void ProcessRecord_UpdateExocomputeConfigs()
        {
            this._logger.name += " -UpdateExocomputeConfigs";
            // Invoke graphql operation updateAwsExocomputeConfigs
            InvokeMutationUpdateAwsExocomputeConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // startAwsExocomputeDisableJob.
        protected void ProcessRecord_StartExocomputeDisableJob()
        {
            this._logger.name += " -StartExocomputeDisableJob";
            // Invoke graphql operation startAwsExocomputeDisableJob
            InvokeMutationStartAwsExocomputeDisableJob();
        }

        // This parameter set invokes a single graphql operation:
        // addAwsIamUserBasedCloudAccount.
        protected void ProcessRecord_AddIamUserBasedCloudAccount()
        {
            this._logger.name += " -AddIamUserBasedCloudAccount";
            // Invoke graphql operation addAwsIamUserBasedCloudAccount
            InvokeMutationAddAwsIamUserBasedCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAwsIamUserBasedCloudAccount.
        protected void ProcessRecord_DeleteIamUserBasedCloudAccount()
        {
            this._logger.name += " -DeleteIamUserBasedCloudAccount";
            // Invoke graphql operation deleteAwsIamUserBasedCloudAccount
            InvokeMutationDeleteAwsIamUserBasedCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAwsCloudAccountWithoutCft.
        protected void ProcessRecord_DeleteCloudAccountWithoutCft()
        {
            this._logger.name += " -DeleteCloudAccountWithoutCft";
            // Invoke graphql operation deleteAwsCloudAccountWithoutCft
            InvokeMutationDeleteAwsCloudAccountWithoutCft();
        }

        // This parameter set invokes a single graphql operation:
        // upgradeAwsIamUserBasedCloudAccountPermissions.
        protected void ProcessRecord_UpgradeIamUserBasedCloudAccountPermissions()
        {
            this._logger.name += " -UpgradeIamUserBasedCloudAccountPermissions";
            // Invoke graphql operation upgradeAwsIamUserBasedCloudAccountPermissions
            InvokeMutationUpgradeAwsIamUserBasedCloudAccountPermissions();
        }

        // This parameter set invokes a single graphql operation:
        // upgradeAwsCloudAccountFeaturesWithoutCft.
        protected void ProcessRecord_UpgradeCloudAccountFeaturesWithoutCft()
        {
            this._logger.name += " -UpgradeCloudAccountFeaturesWithoutCft";
            // Invoke graphql operation upgradeAwsCloudAccountFeaturesWithoutCft
            InvokeMutationUpgradeAwsCloudAccountFeaturesWithoutCft();
        }

        // This parameter set invokes a single graphql operation:
        // addAwsAuthenticationServerBasedCloudAccount.
        protected void ProcessRecord_AddAuthenticationServerBasedCloudAccount()
        {
            this._logger.name += " -AddAuthenticationServerBasedCloudAccount";
            // Invoke graphql operation addAwsAuthenticationServerBasedCloudAccount
            InvokeMutationAddAwsAuthenticationServerBasedCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // patchAwsAuthenticationServerBasedCloudAccount.
        protected void ProcessRecord_PatchAuthenticationServerBasedCloudAccount()
        {
            this._logger.name += " -PatchAuthenticationServerBasedCloudAccount";
            // Invoke graphql operation patchAwsAuthenticationServerBasedCloudAccount
            InvokeMutationPatchAwsAuthenticationServerBasedCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // patchAwsIamUserBasedCloudAccount.
        protected void ProcessRecord_PatchIamUserBasedCloudAccount()
        {
            this._logger.name += " -PatchIamUserBasedCloudAccount";
            // Invoke graphql operation patchAwsIamUserBasedCloudAccount
            InvokeMutationPatchAwsIamUserBasedCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // registerAwsFeatureArtifacts.
        protected void ProcessRecord_RegisterFeatureArtifacts()
        {
            this._logger.name += " -RegisterFeatureArtifacts";
            // Invoke graphql operation registerAwsFeatureArtifacts
            InvokeMutationRegisterAwsFeatureArtifacts();
        }

        // This parameter set invokes a single graphql operation:
        // bulkDeleteAwsCloudAccountWithoutCft.
        protected void ProcessRecord_BulkDeleteCloudAccountWithoutCft()
        {
            this._logger.name += " -BulkDeleteCloudAccountWithoutCft";
            // Invoke graphql operation bulkDeleteAwsCloudAccountWithoutCft
            InvokeMutationBulkDeleteAwsCloudAccountWithoutCft();
        }

        // This parameter set invokes a single graphql operation:
        // createAwsCluster.
        protected void ProcessRecord_CreateCluster()
        {
            this._logger.name += " -CreateCluster";
            // Invoke graphql operation createAwsCluster
            InvokeMutationCreateAwsCluster();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAwsCluster.
        protected void ProcessRecord_DeleteCluster()
        {
            this._logger.name += " -DeleteCluster";
            // Invoke graphql operation deleteAwsCluster
            InvokeMutationDeleteAwsCluster();
        }


        // Invoke GraphQL Mutation:
        // startAwsNativeEc2InstanceSnapshotsJob(input: StartAwsNativeEc2InstanceSnapshotsJobInput!): BatchAsyncJobStatus!
        protected void InvokeMutationStartAwsNativeEc2InstanceSnapshotsJob()
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
        protected void InvokeMutationStartRestoreAwsNativeEc2InstanceSnapshotJob()
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
        protected void InvokeMutationStartRefreshAwsNativeAccountsJob()
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
        protected void InvokeMutationStartCreateAwsNativeEbsVolumeSnapshotsJob()
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
        protected void InvokeMutationStartAwsNativeAccountDisableJob()
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
        protected void InvokeMutationStartExportAwsNativeEbsVolumeSnapshotJob()
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
        protected void InvokeMutationExcludeAwsNativeEbsVolumesFromSnapshot()
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
        protected void InvokeMutationStartAwsNativeRdsInstanceSnapshotsJob()
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
        protected void InvokeMutationCreateAwsAccount()
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
        protected void InvokeMutationUpdateAwsAccount()
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
        protected void InvokeMutationCreateAutomaticAwsTargetMapping()
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
        protected void InvokeMutationCreateCloudNativeAwsStorageSetting()
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
        protected void InvokeMutationUpdateAutomaticAwsTargetMapping()
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
        protected void InvokeMutationUpdateCloudNativeAwsStorageSetting()
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
        protected void InvokeMutationCreateAwsTarget()
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
        protected void InvokeMutationUpdateAwsTarget()
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
        protected void InvokeMutationCreateAwsReaderTarget()
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
        protected void InvokeMutationCreateAwsComputeSetting()
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
        protected void InvokeMutationUpdateAwsComputeSetting()
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
        protected void InvokeMutationDeleteAwsComputeSetting()
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
        protected void InvokeMutationAwsCloudAccountValidate()
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
        protected void InvokeMutationAwsCloudAccountInitiate()
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
        protected void InvokeMutationAwsNativeProtectionAccountAdd()
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
        protected void InvokeMutationValidateAndCreateAwsCloudAccount()
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
        protected void InvokeMutationFinalizeAwsCloudAccountProtection()
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
        protected void InvokeMutationPrepareAwsCloudAccountDeletion()
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
        protected void InvokeMutationFinalizeAwsCloudAccountDeletion()
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
        protected void InvokeMutationUpdateAwsCloudAccountFeature()
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
        protected void InvokeMutationUpdateAwsCloudAccount()
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
        protected void InvokeMutationPrepareFeatureUpdateForAwsCloudAccount()
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
        protected void InvokeMutationAwsCloudAccountUpdateFeature()
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
        protected void InvokeMutationCreateAwsExocomputeConfigs()
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
        protected void InvokeMutationDeleteAwsExocomputeConfigs()
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
        protected void InvokeMutationUpdateAwsExocomputeConfigs()
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
        protected void InvokeMutationStartAwsExocomputeDisableJob()
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
        protected void InvokeMutationAddAwsIamUserBasedCloudAccount()
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
        protected void InvokeMutationDeleteAwsIamUserBasedCloudAccount()
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
        protected void InvokeMutationDeleteAwsCloudAccountWithoutCft()
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
        protected void InvokeMutationUpgradeAwsIamUserBasedCloudAccountPermissions()
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
        protected void InvokeMutationUpgradeAwsCloudAccountFeaturesWithoutCft()
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
        protected void InvokeMutationAddAwsAuthenticationServerBasedCloudAccount()
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
        protected void InvokeMutationPatchAwsAuthenticationServerBasedCloudAccount()
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
        protected void InvokeMutationPatchAwsIamUserBasedCloudAccount()
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
        protected void InvokeMutationRegisterAwsFeatureArtifacts()
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
        protected void InvokeMutationBulkDeleteAwsCloudAccountWithoutCft()
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
        protected void InvokeMutationCreateAwsCluster()
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
        protected void InvokeMutationDeleteAwsCluster()
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