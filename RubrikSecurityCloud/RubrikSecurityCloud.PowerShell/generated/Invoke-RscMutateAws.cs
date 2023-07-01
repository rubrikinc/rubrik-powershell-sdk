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
        // CreateExocomputeConfig parameter set
        //
        // [GraphQL: createAwsExocomputeConfigs]
        //
        [Parameter(
            ParameterSetName = "CreateExocomputeConfig",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create AWS Exocompute configs.
[GraphQL: createAwsExocomputeConfigs]",
            Position = 0
        )]
        public SwitchParameter CreateExocomputeConfig { get; set; }

        
        // -------------------------------------------------------------------
        // DeleteExocomputeConfig parameter set
        //
        // [GraphQL: deleteAwsExocomputeConfigs]
        //
        [Parameter(
            ParameterSetName = "DeleteExocomputeConfig",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Deletes AWS Exocompute configs.
[GraphQL: deleteAwsExocomputeConfigs]",
            Position = 0
        )]
        public SwitchParameter DeleteExocomputeConfig { get; set; }

        
        // -------------------------------------------------------------------
        // UpdateExocomputeConfig parameter set
        //
        // [GraphQL: updateAwsExocomputeConfigs]
        //
        [Parameter(
            ParameterSetName = "UpdateExocomputeConfig",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update AWS Exocompute configs.
[GraphQL: updateAwsExocomputeConfigs]",
            Position = 0
        )]
        public SwitchParameter UpdateExocomputeConfig { get; set; }

        
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
        // UpgradeIamUserBasedCloudAccountPermission parameter set
        //
        // [GraphQL: upgradeAwsIamUserBasedCloudAccountPermissions]
        //
        [Parameter(
            ParameterSetName = "UpgradeIamUserBasedCloudAccountPermission",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Set IAM user-based AWS account features status to Connected from Update Permissions state. It should be used by caution from cloud accounts only after latest required permissions are granted to authorized IAM user.
[GraphQL: upgradeAwsIamUserBasedCloudAccountPermissions]",
            Position = 0
        )]
        public SwitchParameter UpgradeIamUserBasedCloudAccountPermission { get; set; }

        
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
                    case "CreateExocomputeConfig":
                        this.ProcessRecord_CreateExocomputeConfig();
                        break;
                    case "DeleteExocomputeConfig":
                        this.ProcessRecord_DeleteExocomputeConfig();
                        break;
                    case "UpdateExocomputeConfig":
                        this.ProcessRecord_UpdateExocomputeConfig();
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
                    case "UpgradeIamUserBasedCloudAccountPermission":
                        this.ProcessRecord_UpgradeIamUserBasedCloudAccountPermission();
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
        protected void ProcessRecord_CreateExocomputeConfig()
        {
            this._logger.name += " -CreateExocomputeConfig";
            // Invoke graphql operation createAwsExocomputeConfigs
            InvokeMutationCreateAwsExocomputeConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAwsExocomputeConfigs.
        protected void ProcessRecord_DeleteExocomputeConfig()
        {
            this._logger.name += " -DeleteExocomputeConfig";
            // Invoke graphql operation deleteAwsExocomputeConfigs
            InvokeMutationDeleteAwsExocomputeConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // updateAwsExocomputeConfigs.
        protected void ProcessRecord_UpdateExocomputeConfig()
        {
            this._logger.name += " -UpdateExocomputeConfig";
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
        protected void ProcessRecord_UpgradeIamUserBasedCloudAccountPermission()
        {
            this._logger.name += " -UpgradeIamUserBasedCloudAccountPermission";
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
            BatchAsyncJobStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (BatchAsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (BatchAsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.StartAwsNativeEc2InstanceSnapshotsJob(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.StartAwsNativeEc2InstanceSnapshotsJob");
            var parameters = "($input: StartAwsNativeEc2InstanceSnapshotsJobInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationStartAwsNativeEc2InstanceSnapshotsJob" + parameters + "{" + document + "}",
                OperationName = "MutationStartAwsNativeEc2InstanceSnapshotsJob",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "BatchAsyncJobStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // startRestoreAwsNativeEc2InstanceSnapshotJob(input: StartRestoreAwsNativeEc2InstanceSnapshotJobInput!): AsyncJobStatus!
        protected void InvokeMutationStartRestoreAwsNativeEc2InstanceSnapshotJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartRestoreAwsNativeEc2InstanceSnapshotJobInput!"),
            };
            AsyncJobStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.StartRestoreAwsNativeEc2InstanceSnapshotJob(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.StartRestoreAwsNativeEc2InstanceSnapshotJob");
            var parameters = "($input: StartRestoreAwsNativeEc2InstanceSnapshotJobInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationStartRestoreAwsNativeEc2InstanceSnapshotJob" + parameters + "{" + document + "}",
                OperationName = "MutationStartRestoreAwsNativeEc2InstanceSnapshotJob",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncJobStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // startRefreshAwsNativeAccountsJob(input: StartRefreshAwsNativeAccountsJobInput!): BatchAsyncJobStatus!
        protected void InvokeMutationStartRefreshAwsNativeAccountsJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartRefreshAwsNativeAccountsJobInput!"),
            };
            BatchAsyncJobStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (BatchAsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (BatchAsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.StartRefreshAwsNativeAccountsJob(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.StartRefreshAwsNativeAccountsJob");
            var parameters = "($input: StartRefreshAwsNativeAccountsJobInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationStartRefreshAwsNativeAccountsJob" + parameters + "{" + document + "}",
                OperationName = "MutationStartRefreshAwsNativeAccountsJob",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "BatchAsyncJobStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // startCreateAwsNativeEbsVolumeSnapshotsJob(input: StartCreateAwsNativeEbsVolumeSnapshotsJobInput!): BatchAsyncJobStatus!
        protected void InvokeMutationStartCreateAwsNativeEbsVolumeSnapshotsJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartCreateAwsNativeEbsVolumeSnapshotsJobInput!"),
            };
            BatchAsyncJobStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (BatchAsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (BatchAsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.StartCreateAwsNativeEbsVolumeSnapshotsJob(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.StartCreateAwsNativeEbsVolumeSnapshotsJob");
            var parameters = "($input: StartCreateAwsNativeEbsVolumeSnapshotsJobInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationStartCreateAwsNativeEbsVolumeSnapshotsJob" + parameters + "{" + document + "}",
                OperationName = "MutationStartCreateAwsNativeEbsVolumeSnapshotsJob",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "BatchAsyncJobStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // startAwsNativeAccountDisableJob(input: StartAwsNativeAccountDisableJobInput!): AsyncJobStatus!
        protected void InvokeMutationStartAwsNativeAccountDisableJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartAwsNativeAccountDisableJobInput!"),
            };
            AsyncJobStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.StartAwsNativeAccountDisableJob(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.StartAwsNativeAccountDisableJob");
            var parameters = "($input: StartAwsNativeAccountDisableJobInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationStartAwsNativeAccountDisableJob" + parameters + "{" + document + "}",
                OperationName = "MutationStartAwsNativeAccountDisableJob",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncJobStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // startExportAwsNativeEbsVolumeSnapshotJob(input: StartExportAwsNativeEbsVolumeSnapshotJobInput!): AsyncJobStatus!
        protected void InvokeMutationStartExportAwsNativeEbsVolumeSnapshotJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartExportAwsNativeEbsVolumeSnapshotJobInput!"),
            };
            AsyncJobStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.StartExportAwsNativeEbsVolumeSnapshotJob(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.StartExportAwsNativeEbsVolumeSnapshotJob");
            var parameters = "($input: StartExportAwsNativeEbsVolumeSnapshotJobInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationStartExportAwsNativeEbsVolumeSnapshotJob" + parameters + "{" + document + "}",
                OperationName = "MutationStartExportAwsNativeEbsVolumeSnapshotJob",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncJobStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // excludeAwsNativeEbsVolumesFromSnapshot(input: ExcludeAwsNativeEbsVolumesFromSnapshotInput!): Void
        protected void InvokeMutationExcludeAwsNativeEbsVolumesFromSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExcludeAwsNativeEbsVolumesFromSnapshotInput!"),
            };
            System.String? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (System.String)psObject.BaseObject;
                } else {
                    fields = (System.String)this.Field;
                }
            }
            string document = Mutation.ExcludeAwsNativeEbsVolumesFromSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.ExcludeAwsNativeEbsVolumesFromSnapshot");
            var parameters = "($input: ExcludeAwsNativeEbsVolumesFromSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationExcludeAwsNativeEbsVolumesFromSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationExcludeAwsNativeEbsVolumesFromSnapshot",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "System.String", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // startAwsNativeRdsInstanceSnapshotsJob(input: StartAwsNativeRdsInstanceSnapshotsJobInput!): BatchAsyncJobStatus!
        protected void InvokeMutationStartAwsNativeRdsInstanceSnapshotsJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartAwsNativeRdsInstanceSnapshotsJobInput!"),
            };
            BatchAsyncJobStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (BatchAsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (BatchAsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.StartAwsNativeRdsInstanceSnapshotsJob(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.StartAwsNativeRdsInstanceSnapshotsJob");
            var parameters = "($input: StartAwsNativeRdsInstanceSnapshotsJobInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationStartAwsNativeRdsInstanceSnapshotsJob" + parameters + "{" + document + "}",
                OperationName = "MutationStartAwsNativeRdsInstanceSnapshotsJob",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "BatchAsyncJobStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // createAwsAccount(input: CreateAwsAccountInput!): CloudAccount!
        protected void InvokeMutationCreateAwsAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAwsAccountInput!"),
            };
            CloudAccount? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (CloudAccount)psObject.BaseObject;
                } else {
                    fields = (CloudAccount)this.Field;
                }
            }
            string document = Mutation.CreateAwsAccount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateAwsAccount");
            var parameters = "($input: CreateAwsAccountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateAwsAccount" + parameters + "{" + document + "}",
                OperationName = "MutationCreateAwsAccount",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "CloudAccount", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // updateAwsAccount(input: UpdateAwsAccountInput!): CloudAccount!
        protected void InvokeMutationUpdateAwsAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAwsAccountInput!"),
            };
            CloudAccount? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (CloudAccount)psObject.BaseObject;
                } else {
                    fields = (CloudAccount)this.Field;
                }
            }
            string document = Mutation.UpdateAwsAccount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateAwsAccount");
            var parameters = "($input: UpdateAwsAccountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateAwsAccount" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateAwsAccount",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "CloudAccount", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // createAutomaticAwsTargetMapping(input: CreateAutomaticAwsTargetMappingInput!): TargetMapping!
        protected void InvokeMutationCreateAutomaticAwsTargetMapping()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAutomaticAwsTargetMappingInput!"),
            };
            TargetMapping? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (TargetMapping)psObject.BaseObject;
                } else {
                    fields = (TargetMapping)this.Field;
                }
            }
            string document = Mutation.CreateAutomaticAwsTargetMapping(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateAutomaticAwsTargetMapping");
            var parameters = "($input: CreateAutomaticAwsTargetMappingInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateAutomaticAwsTargetMapping" + parameters + "{" + document + "}",
                OperationName = "MutationCreateAutomaticAwsTargetMapping",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "TargetMapping", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // createCloudNativeAwsStorageSetting(input: CreateCloudNativeAwsStorageSettingInput!): CreateCloudNativeAwsStorageSettingReply!
        protected void InvokeMutationCreateCloudNativeAwsStorageSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateCloudNativeAwsStorageSettingInput!"),
            };
            CreateCloudNativeAwsStorageSettingReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (CreateCloudNativeAwsStorageSettingReply)psObject.BaseObject;
                } else {
                    fields = (CreateCloudNativeAwsStorageSettingReply)this.Field;
                }
            }
            string document = Mutation.CreateCloudNativeAwsStorageSetting(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateCloudNativeAwsStorageSetting");
            var parameters = "($input: CreateCloudNativeAwsStorageSettingInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateCloudNativeAwsStorageSetting" + parameters + "{" + document + "}",
                OperationName = "MutationCreateCloudNativeAwsStorageSetting",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "CreateCloudNativeAwsStorageSettingReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // updateAutomaticAwsTargetMapping(input: UpdateAutomaticAwsTargetMappingInput!): TargetMapping!
        protected void InvokeMutationUpdateAutomaticAwsTargetMapping()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAutomaticAwsTargetMappingInput!"),
            };
            TargetMapping? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (TargetMapping)psObject.BaseObject;
                } else {
                    fields = (TargetMapping)this.Field;
                }
            }
            string document = Mutation.UpdateAutomaticAwsTargetMapping(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateAutomaticAwsTargetMapping");
            var parameters = "($input: UpdateAutomaticAwsTargetMappingInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateAutomaticAwsTargetMapping" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateAutomaticAwsTargetMapping",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "TargetMapping", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // updateCloudNativeAwsStorageSetting(input: UpdateCloudNativeAwsStorageSettingInput!): UpdateCloudNativeAwsStorageSettingReply!
        protected void InvokeMutationUpdateCloudNativeAwsStorageSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateCloudNativeAwsStorageSettingInput!"),
            };
            UpdateCloudNativeAwsStorageSettingReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (UpdateCloudNativeAwsStorageSettingReply)psObject.BaseObject;
                } else {
                    fields = (UpdateCloudNativeAwsStorageSettingReply)this.Field;
                }
            }
            string document = Mutation.UpdateCloudNativeAwsStorageSetting(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateCloudNativeAwsStorageSetting");
            var parameters = "($input: UpdateCloudNativeAwsStorageSettingInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateCloudNativeAwsStorageSetting" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateCloudNativeAwsStorageSetting",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "UpdateCloudNativeAwsStorageSettingReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // createAwsTarget(input: CreateAwsTargetInput!): Target!
        protected void InvokeMutationCreateAwsTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAwsTargetInput!"),
            };
            Target? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (Target)psObject.BaseObject;
                } else {
                    fields = (Target)this.Field;
                }
            }
            string document = Mutation.CreateAwsTarget(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateAwsTarget");
            var parameters = "($input: CreateAwsTargetInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateAwsTarget" + parameters + "{" + document + "}",
                OperationName = "MutationCreateAwsTarget",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "Target", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // updateAwsTarget(input: UpdateAwsTargetInput!): Target!
        protected void InvokeMutationUpdateAwsTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAwsTargetInput!"),
            };
            Target? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (Target)psObject.BaseObject;
                } else {
                    fields = (Target)this.Field;
                }
            }
            string document = Mutation.UpdateAwsTarget(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateAwsTarget");
            var parameters = "($input: UpdateAwsTargetInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateAwsTarget" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateAwsTarget",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "Target", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // createAwsReaderTarget(input: CreateAwsReaderTargetInput!): Target!
        protected void InvokeMutationCreateAwsReaderTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAwsReaderTargetInput!"),
            };
            Target? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (Target)psObject.BaseObject;
                } else {
                    fields = (Target)this.Field;
                }
            }
            string document = Mutation.CreateAwsReaderTarget(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateAwsReaderTarget");
            var parameters = "($input: CreateAwsReaderTargetInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateAwsReaderTarget" + parameters + "{" + document + "}",
                OperationName = "MutationCreateAwsReaderTarget",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "Target", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // createAwsComputeSetting(input: CreateAwsComputeSettingInput!): AwsComputeSettings!
        protected void InvokeMutationCreateAwsComputeSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAwsComputeSettingInput!"),
            };
            AwsComputeSettings? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AwsComputeSettings)psObject.BaseObject;
                } else {
                    fields = (AwsComputeSettings)this.Field;
                }
            }
            string document = Mutation.CreateAwsComputeSetting(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateAwsComputeSetting");
            var parameters = "($input: CreateAwsComputeSettingInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateAwsComputeSetting" + parameters + "{" + document + "}",
                OperationName = "MutationCreateAwsComputeSetting",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AwsComputeSettings", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // updateAwsComputeSetting(input: UpdateAwsComputeSettingInput!): AwsComputeSettings!
        protected void InvokeMutationUpdateAwsComputeSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAwsComputeSettingInput!"),
            };
            AwsComputeSettings? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AwsComputeSettings)psObject.BaseObject;
                } else {
                    fields = (AwsComputeSettings)this.Field;
                }
            }
            string document = Mutation.UpdateAwsComputeSetting(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateAwsComputeSetting");
            var parameters = "($input: UpdateAwsComputeSettingInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateAwsComputeSetting" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateAwsComputeSetting",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AwsComputeSettings", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // deleteAwsComputeSetting(input: DeleteAwsComputeSettingInput!): Void
        protected void InvokeMutationDeleteAwsComputeSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAwsComputeSettingInput!"),
            };
            System.String? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (System.String)psObject.BaseObject;
                } else {
                    fields = (System.String)this.Field;
                }
            }
            string document = Mutation.DeleteAwsComputeSetting(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteAwsComputeSetting");
            var parameters = "($input: DeleteAwsComputeSettingInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteAwsComputeSetting" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteAwsComputeSetting",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "System.String", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // awsCloudAccountValidate(awsCloudAccountValidateArg: AwsCloudAccountValidateInput!): AwsCloudAccountValidateResponse!
        protected void InvokeMutationAwsCloudAccountValidate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsCloudAccountValidateArg", "AwsCloudAccountValidateInput!"),
            };
            AwsCloudAccountValidateResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AwsCloudAccountValidateResponse)psObject.BaseObject;
                } else {
                    fields = (AwsCloudAccountValidateResponse)this.Field;
                }
            }
            string document = Mutation.AwsCloudAccountValidate(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.AwsCloudAccountValidate");
            var parameters = "($awsCloudAccountValidateArg: AwsCloudAccountValidateInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationAwsCloudAccountValidate" + parameters + "{" + document + "}",
                OperationName = "MutationAwsCloudAccountValidate",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AwsCloudAccountValidateResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // awsCloudAccountInitiate(awsCloudAccountInitiateArg: AwsCloudAccountInitiateInput!): AwsCloudAccountCreateResponse!
        protected void InvokeMutationAwsCloudAccountInitiate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsCloudAccountInitiateArg", "AwsCloudAccountInitiateInput!"),
            };
            AwsCloudAccountCreateResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AwsCloudAccountCreateResponse)psObject.BaseObject;
                } else {
                    fields = (AwsCloudAccountCreateResponse)this.Field;
                }
            }
            string document = Mutation.AwsCloudAccountInitiate(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.AwsCloudAccountInitiate");
            var parameters = "($awsCloudAccountInitiateArg: AwsCloudAccountInitiateInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationAwsCloudAccountInitiate" + parameters + "{" + document + "}",
                OperationName = "MutationAwsCloudAccountInitiate",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AwsCloudAccountCreateResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // awsNativeProtectionAccountAdd(awsNativeProtectionAccountAddArg: AwsNativeProtectionAccountAddRequest!): AwsNativeProtectionAccountAddResponse!
        protected void InvokeMutationAwsNativeProtectionAccountAdd()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsNativeProtectionAccountAddArg", "AwsNativeProtectionAccountAddRequest!"),
            };
            AwsNativeProtectionAccountAddResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AwsNativeProtectionAccountAddResponse)psObject.BaseObject;
                } else {
                    fields = (AwsNativeProtectionAccountAddResponse)this.Field;
                }
            }
            string document = Mutation.AwsNativeProtectionAccountAdd(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.AwsNativeProtectionAccountAdd");
            var parameters = "($awsNativeProtectionAccountAddArg: AwsNativeProtectionAccountAddRequest!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationAwsNativeProtectionAccountAdd" + parameters + "{" + document + "}",
                OperationName = "MutationAwsNativeProtectionAccountAdd",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AwsNativeProtectionAccountAddResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // validateAndCreateAwsCloudAccount(input: ValidateAndCreateAwsCloudAccountInput!): ValidateAndCreateAwsCloudAccountReply!
        protected void InvokeMutationValidateAndCreateAwsCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ValidateAndCreateAwsCloudAccountInput!"),
            };
            ValidateAndCreateAwsCloudAccountReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (ValidateAndCreateAwsCloudAccountReply)psObject.BaseObject;
                } else {
                    fields = (ValidateAndCreateAwsCloudAccountReply)this.Field;
                }
            }
            string document = Mutation.ValidateAndCreateAwsCloudAccount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.ValidateAndCreateAwsCloudAccount");
            var parameters = "($input: ValidateAndCreateAwsCloudAccountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationValidateAndCreateAwsCloudAccount" + parameters + "{" + document + "}",
                OperationName = "MutationValidateAndCreateAwsCloudAccount",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "ValidateAndCreateAwsCloudAccountReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // finalizeAwsCloudAccountProtection(input: FinalizeAwsCloudAccountProtectionInput!): FinalizeAwsCloudAccountProtectionReply!
        protected void InvokeMutationFinalizeAwsCloudAccountProtection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "FinalizeAwsCloudAccountProtectionInput!"),
            };
            FinalizeAwsCloudAccountProtectionReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (FinalizeAwsCloudAccountProtectionReply)psObject.BaseObject;
                } else {
                    fields = (FinalizeAwsCloudAccountProtectionReply)this.Field;
                }
            }
            string document = Mutation.FinalizeAwsCloudAccountProtection(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.FinalizeAwsCloudAccountProtection");
            var parameters = "($input: FinalizeAwsCloudAccountProtectionInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationFinalizeAwsCloudAccountProtection" + parameters + "{" + document + "}",
                OperationName = "MutationFinalizeAwsCloudAccountProtection",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "FinalizeAwsCloudAccountProtectionReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // prepareAwsCloudAccountDeletion(input: PrepareAwsCloudAccountDeletionInput!): PrepareAwsCloudAccountDeletionReply!
        protected void InvokeMutationPrepareAwsCloudAccountDeletion()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PrepareAwsCloudAccountDeletionInput!"),
            };
            PrepareAwsCloudAccountDeletionReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (PrepareAwsCloudAccountDeletionReply)psObject.BaseObject;
                } else {
                    fields = (PrepareAwsCloudAccountDeletionReply)this.Field;
                }
            }
            string document = Mutation.PrepareAwsCloudAccountDeletion(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.PrepareAwsCloudAccountDeletion");
            var parameters = "($input: PrepareAwsCloudAccountDeletionInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationPrepareAwsCloudAccountDeletion" + parameters + "{" + document + "}",
                OperationName = "MutationPrepareAwsCloudAccountDeletion",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "PrepareAwsCloudAccountDeletionReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // finalizeAwsCloudAccountDeletion(input: FinalizeAwsCloudAccountDeletionInput!): FinalizeAwsCloudAccountDeletionReply!
        protected void InvokeMutationFinalizeAwsCloudAccountDeletion()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "FinalizeAwsCloudAccountDeletionInput!"),
            };
            FinalizeAwsCloudAccountDeletionReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (FinalizeAwsCloudAccountDeletionReply)psObject.BaseObject;
                } else {
                    fields = (FinalizeAwsCloudAccountDeletionReply)this.Field;
                }
            }
            string document = Mutation.FinalizeAwsCloudAccountDeletion(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.FinalizeAwsCloudAccountDeletion");
            var parameters = "($input: FinalizeAwsCloudAccountDeletionInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationFinalizeAwsCloudAccountDeletion" + parameters + "{" + document + "}",
                OperationName = "MutationFinalizeAwsCloudAccountDeletion",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "FinalizeAwsCloudAccountDeletionReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // updateAwsCloudAccountFeature(input: UpdateAwsCloudAccountFeatureInput!): UpdateAwsCloudAccountFeatureReply!
        protected void InvokeMutationUpdateAwsCloudAccountFeature()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAwsCloudAccountFeatureInput!"),
            };
            UpdateAwsCloudAccountFeatureReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (UpdateAwsCloudAccountFeatureReply)psObject.BaseObject;
                } else {
                    fields = (UpdateAwsCloudAccountFeatureReply)this.Field;
                }
            }
            string document = Mutation.UpdateAwsCloudAccountFeature(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateAwsCloudAccountFeature");
            var parameters = "($input: UpdateAwsCloudAccountFeatureInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateAwsCloudAccountFeature" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateAwsCloudAccountFeature",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "UpdateAwsCloudAccountFeatureReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // updateAwsCloudAccount(input: UpdateAwsCloudAccountInput!): Void
        protected void InvokeMutationUpdateAwsCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAwsCloudAccountInput!"),
            };
            System.String? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (System.String)psObject.BaseObject;
                } else {
                    fields = (System.String)this.Field;
                }
            }
            string document = Mutation.UpdateAwsCloudAccount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateAwsCloudAccount");
            var parameters = "($input: UpdateAwsCloudAccountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateAwsCloudAccount" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateAwsCloudAccount",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "System.String", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // prepareFeatureUpdateForAwsCloudAccount(input: PrepareFeatureUpdateForAwsCloudAccountInput!): PrepareFeatureUpdateForAwsCloudAccountReply!
        protected void InvokeMutationPrepareFeatureUpdateForAwsCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PrepareFeatureUpdateForAwsCloudAccountInput!"),
            };
            PrepareFeatureUpdateForAwsCloudAccountReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (PrepareFeatureUpdateForAwsCloudAccountReply)psObject.BaseObject;
                } else {
                    fields = (PrepareFeatureUpdateForAwsCloudAccountReply)this.Field;
                }
            }
            string document = Mutation.PrepareFeatureUpdateForAwsCloudAccount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.PrepareFeatureUpdateForAwsCloudAccount");
            var parameters = "($input: PrepareFeatureUpdateForAwsCloudAccountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationPrepareFeatureUpdateForAwsCloudAccount" + parameters + "{" + document + "}",
                OperationName = "MutationPrepareFeatureUpdateForAwsCloudAccount",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "PrepareFeatureUpdateForAwsCloudAccountReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // awsCloudAccountUpdateFeature(cloudAccountUuid: UUID!, features: [CloudAccountFeature!]!): AwsCloudAccountUpdateFeatureResponse!
        protected void InvokeMutationAwsCloudAccountUpdateFeature()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountUuid", "UUID!"),
                Tuple.Create("features", "[CloudAccountFeature!]!"),
            };
            AwsCloudAccountUpdateFeatureResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AwsCloudAccountUpdateFeatureResponse)psObject.BaseObject;
                } else {
                    fields = (AwsCloudAccountUpdateFeatureResponse)this.Field;
                }
            }
            string document = Mutation.AwsCloudAccountUpdateFeature(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.AwsCloudAccountUpdateFeature");
            var parameters = "($cloudAccountUuid: UUID!,$features: [CloudAccountFeature!]!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationAwsCloudAccountUpdateFeature" + parameters + "{" + document + "}",
                OperationName = "MutationAwsCloudAccountUpdateFeature",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AwsCloudAccountUpdateFeatureResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // createAwsExocomputeConfigs(input: CreateAwsExocomputeConfigsInput!): CreateAwsExocomputeConfigsReply!
        protected void InvokeMutationCreateAwsExocomputeConfigs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAwsExocomputeConfigsInput!"),
            };
            CreateAwsExocomputeConfigsReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (CreateAwsExocomputeConfigsReply)psObject.BaseObject;
                } else {
                    fields = (CreateAwsExocomputeConfigsReply)this.Field;
                }
            }
            string document = Mutation.CreateAwsExocomputeConfigs(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateAwsExocomputeConfigs");
            var parameters = "($input: CreateAwsExocomputeConfigsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateAwsExocomputeConfigs" + parameters + "{" + document + "}",
                OperationName = "MutationCreateAwsExocomputeConfigs",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "CreateAwsExocomputeConfigsReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // deleteAwsExocomputeConfigs(input: DeleteAwsExocomputeConfigsInput!): DeleteAwsExocomputeConfigsReply!
        protected void InvokeMutationDeleteAwsExocomputeConfigs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAwsExocomputeConfigsInput!"),
            };
            DeleteAwsExocomputeConfigsReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (DeleteAwsExocomputeConfigsReply)psObject.BaseObject;
                } else {
                    fields = (DeleteAwsExocomputeConfigsReply)this.Field;
                }
            }
            string document = Mutation.DeleteAwsExocomputeConfigs(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteAwsExocomputeConfigs");
            var parameters = "($input: DeleteAwsExocomputeConfigsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteAwsExocomputeConfigs" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteAwsExocomputeConfigs",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "DeleteAwsExocomputeConfigsReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // updateAwsExocomputeConfigs(input: UpdateAwsExocomputeConfigsInput!): UpdateAwsExocomputeConfigsReply!
        protected void InvokeMutationUpdateAwsExocomputeConfigs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAwsExocomputeConfigsInput!"),
            };
            UpdateAwsExocomputeConfigsReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (UpdateAwsExocomputeConfigsReply)psObject.BaseObject;
                } else {
                    fields = (UpdateAwsExocomputeConfigsReply)this.Field;
                }
            }
            string document = Mutation.UpdateAwsExocomputeConfigs(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateAwsExocomputeConfigs");
            var parameters = "($input: UpdateAwsExocomputeConfigsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateAwsExocomputeConfigs" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateAwsExocomputeConfigs",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "UpdateAwsExocomputeConfigsReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // startAwsExocomputeDisableJob(input: StartAwsExocomputeDisableJobInput!): AsyncJobStatus!
        protected void InvokeMutationStartAwsExocomputeDisableJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartAwsExocomputeDisableJobInput!"),
            };
            AsyncJobStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.StartAwsExocomputeDisableJob(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.StartAwsExocomputeDisableJob");
            var parameters = "($input: StartAwsExocomputeDisableJobInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationStartAwsExocomputeDisableJob" + parameters + "{" + document + "}",
                OperationName = "MutationStartAwsExocomputeDisableJob",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncJobStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // addAwsIamUserBasedCloudAccount(input: AddAwsIamUserBasedCloudAccountInput!): AddAwsIamUserBasedCloudAccountReply!
        protected void InvokeMutationAddAwsIamUserBasedCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddAwsIamUserBasedCloudAccountInput!"),
            };
            AddAwsIamUserBasedCloudAccountReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AddAwsIamUserBasedCloudAccountReply)psObject.BaseObject;
                } else {
                    fields = (AddAwsIamUserBasedCloudAccountReply)this.Field;
                }
            }
            string document = Mutation.AddAwsIamUserBasedCloudAccount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.AddAwsIamUserBasedCloudAccount");
            var parameters = "($input: AddAwsIamUserBasedCloudAccountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationAddAwsIamUserBasedCloudAccount" + parameters + "{" + document + "}",
                OperationName = "MutationAddAwsIamUserBasedCloudAccount",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AddAwsIamUserBasedCloudAccountReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // deleteAwsIamUserBasedCloudAccount(input: DeleteAwsIamUserBasedCloudAccountInput!): DeleteAwsIamUserBasedCloudAccountReply!
        protected void InvokeMutationDeleteAwsIamUserBasedCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAwsIamUserBasedCloudAccountInput!"),
            };
            DeleteAwsIamUserBasedCloudAccountReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (DeleteAwsIamUserBasedCloudAccountReply)psObject.BaseObject;
                } else {
                    fields = (DeleteAwsIamUserBasedCloudAccountReply)this.Field;
                }
            }
            string document = Mutation.DeleteAwsIamUserBasedCloudAccount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteAwsIamUserBasedCloudAccount");
            var parameters = "($input: DeleteAwsIamUserBasedCloudAccountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteAwsIamUserBasedCloudAccount" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteAwsIamUserBasedCloudAccount",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "DeleteAwsIamUserBasedCloudAccountReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // deleteAwsCloudAccountWithoutCft(input: DeleteAwsCloudAccountWithoutCftInput!): DeleteAwsCloudAccountWithoutCftReply!
        protected void InvokeMutationDeleteAwsCloudAccountWithoutCft()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAwsCloudAccountWithoutCftInput!"),
            };
            DeleteAwsCloudAccountWithoutCftReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (DeleteAwsCloudAccountWithoutCftReply)psObject.BaseObject;
                } else {
                    fields = (DeleteAwsCloudAccountWithoutCftReply)this.Field;
                }
            }
            string document = Mutation.DeleteAwsCloudAccountWithoutCft(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteAwsCloudAccountWithoutCft");
            var parameters = "($input: DeleteAwsCloudAccountWithoutCftInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteAwsCloudAccountWithoutCft" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteAwsCloudAccountWithoutCft",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "DeleteAwsCloudAccountWithoutCftReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // upgradeAwsIamUserBasedCloudAccountPermissions(input: UpgradeAwsIamUserBasedCloudAccountPermissionsInput!): Boolean!
        protected void InvokeMutationUpgradeAwsIamUserBasedCloudAccountPermissions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpgradeAwsIamUserBasedCloudAccountPermissionsInput!"),
            };
            System.Boolean? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (System.Boolean)psObject.BaseObject;
                } else {
                    fields = (System.Boolean)this.Field;
                }
            }
            string document = Mutation.UpgradeAwsIamUserBasedCloudAccountPermissions(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpgradeAwsIamUserBasedCloudAccountPermissions");
            var parameters = "($input: UpgradeAwsIamUserBasedCloudAccountPermissionsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpgradeAwsIamUserBasedCloudAccountPermissions" + parameters + "{" + document + "}",
                OperationName = "MutationUpgradeAwsIamUserBasedCloudAccountPermissions",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "System.Boolean", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // upgradeAwsCloudAccountFeaturesWithoutCft(input: UpgradeAwsCloudAccountFeaturesWithoutCftInput!): Boolean!
        protected void InvokeMutationUpgradeAwsCloudAccountFeaturesWithoutCft()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpgradeAwsCloudAccountFeaturesWithoutCftInput!"),
            };
            System.Boolean? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (System.Boolean)psObject.BaseObject;
                } else {
                    fields = (System.Boolean)this.Field;
                }
            }
            string document = Mutation.UpgradeAwsCloudAccountFeaturesWithoutCft(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpgradeAwsCloudAccountFeaturesWithoutCft");
            var parameters = "($input: UpgradeAwsCloudAccountFeaturesWithoutCftInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpgradeAwsCloudAccountFeaturesWithoutCft" + parameters + "{" + document + "}",
                OperationName = "MutationUpgradeAwsCloudAccountFeaturesWithoutCft",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "System.Boolean", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // addAwsAuthenticationServerBasedCloudAccount(input: AddAwsAuthenticationServerBasedCloudAccountInput!): AddAwsAuthenticationServerBasedCloudAccountReply!
        protected void InvokeMutationAddAwsAuthenticationServerBasedCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddAwsAuthenticationServerBasedCloudAccountInput!"),
            };
            AddAwsAuthenticationServerBasedCloudAccountReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AddAwsAuthenticationServerBasedCloudAccountReply)psObject.BaseObject;
                } else {
                    fields = (AddAwsAuthenticationServerBasedCloudAccountReply)this.Field;
                }
            }
            string document = Mutation.AddAwsAuthenticationServerBasedCloudAccount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.AddAwsAuthenticationServerBasedCloudAccount");
            var parameters = "($input: AddAwsAuthenticationServerBasedCloudAccountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationAddAwsAuthenticationServerBasedCloudAccount" + parameters + "{" + document + "}",
                OperationName = "MutationAddAwsAuthenticationServerBasedCloudAccount",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AddAwsAuthenticationServerBasedCloudAccountReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // patchAwsAuthenticationServerBasedCloudAccount(input: PatchAwsAuthenticationServerBasedCloudAccountInput!): Boolean!
        protected void InvokeMutationPatchAwsAuthenticationServerBasedCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PatchAwsAuthenticationServerBasedCloudAccountInput!"),
            };
            System.Boolean? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (System.Boolean)psObject.BaseObject;
                } else {
                    fields = (System.Boolean)this.Field;
                }
            }
            string document = Mutation.PatchAwsAuthenticationServerBasedCloudAccount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.PatchAwsAuthenticationServerBasedCloudAccount");
            var parameters = "($input: PatchAwsAuthenticationServerBasedCloudAccountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationPatchAwsAuthenticationServerBasedCloudAccount" + parameters + "{" + document + "}",
                OperationName = "MutationPatchAwsAuthenticationServerBasedCloudAccount",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "System.Boolean", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // patchAwsIamUserBasedCloudAccount(input: PatchAwsIamUserBasedCloudAccountInput!): Boolean!
        protected void InvokeMutationPatchAwsIamUserBasedCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PatchAwsIamUserBasedCloudAccountInput!"),
            };
            System.Boolean? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (System.Boolean)psObject.BaseObject;
                } else {
                    fields = (System.Boolean)this.Field;
                }
            }
            string document = Mutation.PatchAwsIamUserBasedCloudAccount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.PatchAwsIamUserBasedCloudAccount");
            var parameters = "($input: PatchAwsIamUserBasedCloudAccountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationPatchAwsIamUserBasedCloudAccount" + parameters + "{" + document + "}",
                OperationName = "MutationPatchAwsIamUserBasedCloudAccount",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "System.Boolean", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // createAwsCluster(input: CreateAwsClusterInput!): CcProvisionJobReply!
        protected void InvokeMutationCreateAwsCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAwsClusterInput!"),
            };
            CcProvisionJobReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (CcProvisionJobReply)psObject.BaseObject;
                } else {
                    fields = (CcProvisionJobReply)this.Field;
                }
            }
            string document = Mutation.CreateAwsCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateAwsCluster");
            var parameters = "($input: CreateAwsClusterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateAwsCluster" + parameters + "{" + document + "}",
                OperationName = "MutationCreateAwsCluster",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "CcProvisionJobReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // deleteAwsCluster(input: DeleteAwsClusterInput!): CcProvisionJobReply!
        protected void InvokeMutationDeleteAwsCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAwsClusterInput!"),
            };
            CcProvisionJobReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (CcProvisionJobReply)psObject.BaseObject;
                } else {
                    fields = (CcProvisionJobReply)this.Field;
                }
            }
            string document = Mutation.DeleteAwsCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteAwsCluster");
            var parameters = "($input: DeleteAwsClusterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteAwsCluster" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteAwsCluster",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "CcProvisionJobReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }


    } // class Invoke_RscMutateAws
}