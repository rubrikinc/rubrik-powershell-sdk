// Invoke-RscMutateAws.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using Rubrik.SecurityCloud.Types;
using Rubrik.SecurityCloud.NetSDK.Client;
using Rubrik.SecurityCloud.PowerShell.Private;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using RubrikSecurityCloud.Schema.Utils;
using GraphQL;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
{
    [Cmdlet(
        "Invoke",
        "RscMutateAws",
        DefaultParameterSetName = "createTarget")
    ]
    public class Invoke_RscMutateAws : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // startNativeEc2InstanceSnapshotsJob parameter set
        //
        // GraphQL operation: startAwsNativeEc2InstanceSnapshotsJob(input: StartAwsNativeEc2InstanceSnapshotsJobInput!):BatchAsyncJobStatus!
        //
        [Parameter(
            ParameterSetName = "startNativeEc2InstanceSnapshotsJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Start an on demand create snapshot job for AWS EC2 Instances.When completed, this will start taking an on-demand snapshot of the selected EC2 Instances  as per the SLA Policy assigned to the respective instances.
                GraphQL operation: startAwsNativeEc2InstanceSnapshotsJob(input: StartAwsNativeEc2InstanceSnapshotsJobInput!):BatchAsyncJobStatus!
                ",
            Position = 0
        )]
        public SwitchParameter startNativeEc2InstanceSnapshotsJob { get; set; }

        [Parameter(
            ParameterSetName = "startNativeEc2InstanceSnapshotsJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Input for create AWS EC2 Instance snapshots job.
                GraphQL argument input: StartAwsNativeEc2InstanceSnapshotsJobInput!
                "
        )]
        public StartAwsNativeEc2InstanceSnapshotsJobInput? Input { get; set; }
        
        // -------------------------------------------------------------------
        // startRestoreNativeEc2InstanceSnapshotJob parameter set
        //
        // GraphQL operation: startRestoreAwsNativeEc2InstanceSnapshotJob(input: StartRestoreAwsNativeEc2InstanceSnapshotJobInput!):AsyncJobStatus!
        //
        [Parameter(
            ParameterSetName = "startRestoreNativeEc2InstanceSnapshotJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Start an on demand restore snapshot job for AWS EC2 Instance. When completed, this will replace the original EC2 Instance with the selected snapshot.
                GraphQL operation: startRestoreAwsNativeEc2InstanceSnapshotJob(input: StartRestoreAwsNativeEc2InstanceSnapshotJobInput!):AsyncJobStatus!
                ",
            Position = 0
        )]
        public SwitchParameter startRestoreNativeEc2InstanceSnapshotJob { get; set; }

        
        // -------------------------------------------------------------------
        // startRefreshNativeAccountsJob parameter set
        //
        // GraphQL operation: startRefreshAwsNativeAccountsJob(input: StartRefreshAwsNativeAccountsJobInput!):BatchAsyncJobStatus!
        //
        [Parameter(
            ParameterSetName = "startRefreshNativeAccountsJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Start an on demand job to refresh AWS accounts. The job updates the Rubrik platform with changes to the AWS Native accounts.
                GraphQL operation: startRefreshAwsNativeAccountsJob(input: StartRefreshAwsNativeAccountsJobInput!):BatchAsyncJobStatus!
                ",
            Position = 0
        )]
        public SwitchParameter startRefreshNativeAccountsJob { get; set; }

        
        // -------------------------------------------------------------------
        // startCreateNativeEbsVolumeSnapshotsJob parameter set
        //
        // GraphQL operation: startCreateAwsNativeEbsVolumeSnapshotsJob(input: StartCreateAwsNativeEbsVolumeSnapshotsJobInput!):BatchAsyncJobStatus!
        //
        [Parameter(
            ParameterSetName = "startCreateNativeEbsVolumeSnapshotsJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Start job to create snapshots of EBS Volumes with given IDs. When completed, this will start taking an on-demand snapshot of the selected EBS Volumes  as per the SLA Policy assigned to the respective volumes.
                GraphQL operation: startCreateAwsNativeEbsVolumeSnapshotsJob(input: StartCreateAwsNativeEbsVolumeSnapshotsJobInput!):BatchAsyncJobStatus!
                ",
            Position = 0
        )]
        public SwitchParameter startCreateNativeEbsVolumeSnapshotsJob { get; set; }

        
        // -------------------------------------------------------------------
        // startNativeAccountDisableJob parameter set
        //
        // GraphQL operation: startAwsNativeAccountDisableJob(input: StartAwsNativeAccountDisableJobInput!):AsyncJobStatus!
        //
        [Parameter(
            ParameterSetName = "startNativeAccountDisableJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Starts a job to disable a specific AWS Native account. When complete, the job will disable protection for the specified AWS Native account.
                GraphQL operation: startAwsNativeAccountDisableJob(input: StartAwsNativeAccountDisableJobInput!):AsyncJobStatus!
                ",
            Position = 0
        )]
        public SwitchParameter startNativeAccountDisableJob { get; set; }

        
        // -------------------------------------------------------------------
        // startExportNativeEbsVolumeSnapshotJob parameter set
        //
        // GraphQL operation: startExportAwsNativeEbsVolumeSnapshotJob(input: StartExportAwsNativeEbsVolumeSnapshotJobInput!):AsyncJobStatus!
        //
        [Parameter(
            ParameterSetName = "startExportNativeEbsVolumeSnapshotJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Start a job to export EBS Volume. The job creates a new EBS Volume with the same properties as that of the snapshot that is exported.
                GraphQL operation: startExportAwsNativeEbsVolumeSnapshotJob(input: StartExportAwsNativeEbsVolumeSnapshotJobInput!):AsyncJobStatus!
                ",
            Position = 0
        )]
        public SwitchParameter startExportNativeEbsVolumeSnapshotJob { get; set; }

        
        // -------------------------------------------------------------------
        // excludeNativeEbsVolumesFromSnapshot parameter set
        //
        // GraphQL operation: excludeAwsNativeEbsVolumesFromSnapshot(input: ExcludeAwsNativeEbsVolumesFromSnapshotInput!):Void
        //
        [Parameter(
            ParameterSetName = "excludeNativeEbsVolumesFromSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Mark AWS Native EBS Volumes to be excluded from EC2 Instance snapshot. By default, all EBS Volumes are marked as included.
                GraphQL operation: excludeAwsNativeEbsVolumesFromSnapshot(input: ExcludeAwsNativeEbsVolumesFromSnapshotInput!):Void
                ",
            Position = 0
        )]
        public SwitchParameter excludeNativeEbsVolumesFromSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // startNativeRdsInstanceSnapshotsJob parameter set
        //
        // GraphQL operation: startAwsNativeRdsInstanceSnapshotsJob(input: StartAwsNativeRdsInstanceSnapshotsJobInput!):BatchAsyncJobStatus!
        //
        [Parameter(
            ParameterSetName = "startNativeRdsInstanceSnapshotsJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Start job to create snapshots of RDS Instance with given IDs. When completed, this will start taking an on-demand snapshot of the selected RDS Instances  as per the SLA Policy assigned to the respective instances.
                GraphQL operation: startAwsNativeRdsInstanceSnapshotsJob(input: StartAwsNativeRdsInstanceSnapshotsJobInput!):BatchAsyncJobStatus!
                ",
            Position = 0
        )]
        public SwitchParameter startNativeRdsInstanceSnapshotsJob { get; set; }

        
        // -------------------------------------------------------------------
        // createAccount parameter set
        //
        // GraphQL operation: createAwsAccount(input: CreateAwsAccountInput!):CloudAccount!
        //
        [Parameter(
            ParameterSetName = "createAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: createAwsAccount(input: CreateAwsAccountInput!):CloudAccount!
                ",
            Position = 0
        )]
        public SwitchParameter createAccount { get; set; }

        
        // -------------------------------------------------------------------
        // updateAccount parameter set
        //
        // GraphQL operation: updateAwsAccount(input: UpdateAwsAccountInput!):CloudAccount!
        //
        [Parameter(
            ParameterSetName = "updateAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: updateAwsAccount(input: UpdateAwsAccountInput!):CloudAccount!
                ",
            Position = 0
        )]
        public SwitchParameter updateAccount { get; set; }

        
        // -------------------------------------------------------------------
        // createAutomaticTargetMapping parameter set
        //
        // GraphQL operation: createAutomaticAwsTargetMapping(input: CreateAutomaticAwsTargetMappingInput!):TargetMapping!
        //
        [Parameter(
            ParameterSetName = "createAutomaticTargetMapping",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: createAutomaticAwsTargetMapping(input: CreateAutomaticAwsTargetMappingInput!):TargetMapping!
                ",
            Position = 0
        )]
        public SwitchParameter createAutomaticTargetMapping { get; set; }

        
        // -------------------------------------------------------------------
        // createCloudNativeStorageSetting parameter set
        //
        // GraphQL operation: createCloudNativeAwsStorageSetting(input: CreateCloudNativeAwsStorageSettingInput!):CreateCloudNativeAwsStorageSettingReply!
        //
        [Parameter(
            ParameterSetName = "createCloudNativeStorageSetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: createCloudNativeAwsStorageSetting(input: CreateCloudNativeAwsStorageSettingInput!):CreateCloudNativeAwsStorageSettingReply!
                ",
            Position = 0
        )]
        public SwitchParameter createCloudNativeStorageSetting { get; set; }

        
        // -------------------------------------------------------------------
        // updateAutomaticTargetMapping parameter set
        //
        // GraphQL operation: updateAutomaticAwsTargetMapping(input: UpdateAutomaticAwsTargetMappingInput!):TargetMapping!
        //
        [Parameter(
            ParameterSetName = "updateAutomaticTargetMapping",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: updateAutomaticAwsTargetMapping(input: UpdateAutomaticAwsTargetMappingInput!):TargetMapping!
                ",
            Position = 0
        )]
        public SwitchParameter updateAutomaticTargetMapping { get; set; }

        
        // -------------------------------------------------------------------
        // updateCloudNativeStorageSetting parameter set
        //
        // GraphQL operation: updateCloudNativeAwsStorageSetting(input: UpdateCloudNativeAwsStorageSettingInput!):UpdateCloudNativeAwsStorageSettingReply!
        //
        [Parameter(
            ParameterSetName = "updateCloudNativeStorageSetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: updateCloudNativeAwsStorageSetting(input: UpdateCloudNativeAwsStorageSettingInput!):UpdateCloudNativeAwsStorageSettingReply!
                ",
            Position = 0
        )]
        public SwitchParameter updateCloudNativeStorageSetting { get; set; }

        
        // -------------------------------------------------------------------
        // createTarget parameter set
        //
        // GraphQL operation: createAwsTarget(input: CreateAwsTargetInput!):Target!
        //
        [Parameter(
            ParameterSetName = "createTarget",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: createAwsTarget(input: CreateAwsTargetInput!):Target!
                ",
            Position = 0
        )]
        public SwitchParameter createTarget { get; set; }

        
        // -------------------------------------------------------------------
        // updateTarget parameter set
        //
        // GraphQL operation: updateAwsTarget(input: UpdateAwsTargetInput!):Target!
        //
        [Parameter(
            ParameterSetName = "updateTarget",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: updateAwsTarget(input: UpdateAwsTargetInput!):Target!
                ",
            Position = 0
        )]
        public SwitchParameter updateTarget { get; set; }

        
        // -------------------------------------------------------------------
        // createReaderTarget parameter set
        //
        // GraphQL operation: createAwsReaderTarget(input: CreateAwsReaderTargetInput!):Target!
        //
        [Parameter(
            ParameterSetName = "createReaderTarget",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Create a reader type for AWS archival location on a Rubrik cluster.
                GraphQL operation: createAwsReaderTarget(input: CreateAwsReaderTargetInput!):Target!
                ",
            Position = 0
        )]
        public SwitchParameter createReaderTarget { get; set; }

        
        // -------------------------------------------------------------------
        // createComputeSetting parameter set
        //
        // GraphQL operation: createAwsComputeSetting(input: CreateAwsComputeSettingInput!):AwsComputeSettings!
        //
        [Parameter(
            ParameterSetName = "createComputeSetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: createAwsComputeSetting(input: CreateAwsComputeSettingInput!):AwsComputeSettings!
                ",
            Position = 0
        )]
        public SwitchParameter createComputeSetting { get; set; }

        
        // -------------------------------------------------------------------
        // updateComputeSetting parameter set
        //
        // GraphQL operation: updateAwsComputeSetting(input: UpdateAwsComputeSettingInput!):AwsComputeSettings!
        //
        [Parameter(
            ParameterSetName = "updateComputeSetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: updateAwsComputeSetting(input: UpdateAwsComputeSettingInput!):AwsComputeSettings!
                ",
            Position = 0
        )]
        public SwitchParameter updateComputeSetting { get; set; }

        
        // -------------------------------------------------------------------
        // deleteComputeSetting parameter set
        //
        // GraphQL operation: deleteAwsComputeSetting(input: DeleteAwsComputeSettingInput!):Void
        //
        [Parameter(
            ParameterSetName = "deleteComputeSetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: deleteAwsComputeSetting(input: DeleteAwsComputeSettingInput!):Void
                ",
            Position = 0
        )]
        public SwitchParameter deleteComputeSetting { get; set; }

        
        // -------------------------------------------------------------------
        // CloudAccountValidate parameter set
        //
        // GraphQL operation: awsCloudAccountValidate(awsCloudAccountValidateArg: AwsCloudAccountValidateInput!):AwsCloudAccountValidateResponse!
        //
        [Parameter(
            ParameterSetName = "CloudAccountValidate",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                This endpoint is deprecated.
                GraphQL operation: awsCloudAccountValidate(awsCloudAccountValidateArg: AwsCloudAccountValidateInput!):AwsCloudAccountValidateResponse!
                ",
            Position = 0
        )]
        public SwitchParameter CloudAccountValidate { get; set; }

        [Parameter(
            ParameterSetName = "CloudAccountValidate",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Arguments for validate aws cloud accounts.
                GraphQL argument awsCloudAccountValidateArg: AwsCloudAccountValidateInput!
                "
        )]
        public AwsCloudAccountValidateInput? AwsCloudAccountValidateArg { get; set; }
        
        // -------------------------------------------------------------------
        // CloudAccountInitiate parameter set
        //
        // GraphQL operation: awsCloudAccountInitiate(awsCloudAccountInitiateArg: AwsCloudAccountInitiateInput!):AwsCloudAccountCreateResponse!
        //
        [Parameter(
            ParameterSetName = "CloudAccountInitiate",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                This endpoint is deprecated.
                GraphQL operation: awsCloudAccountInitiate(awsCloudAccountInitiateArg: AwsCloudAccountInitiateInput!):AwsCloudAccountCreateResponse!
                ",
            Position = 0
        )]
        public SwitchParameter CloudAccountInitiate { get; set; }

        [Parameter(
            ParameterSetName = "CloudAccountInitiate",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Arguments for initiate aws cloud accounts for creation.
                GraphQL argument awsCloudAccountInitiateArg: AwsCloudAccountInitiateInput!
                "
        )]
        public AwsCloudAccountInitiateInput? AwsCloudAccountInitiateArg { get; set; }
        
        // -------------------------------------------------------------------
        // NativeProtectionAccountAdd parameter set
        //
        // GraphQL operation: awsNativeProtectionAccountAdd(awsNativeProtectionAccountAddArg: AwsNativeProtectionAccountAddRequest!):AwsNativeProtectionAccountAddResponse!
        //
        [Parameter(
            ParameterSetName = "NativeProtectionAccountAdd",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                This endpoint is deprecated.
                GraphQL operation: awsNativeProtectionAccountAdd(awsNativeProtectionAccountAddArg: AwsNativeProtectionAccountAddRequest!):AwsNativeProtectionAccountAddResponse!
                ",
            Position = 0
        )]
        public SwitchParameter NativeProtectionAccountAdd { get; set; }

        [Parameter(
            ParameterSetName = "NativeProtectionAccountAdd",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Arguments to add account for native protection.
                GraphQL argument awsNativeProtectionAccountAddArg: AwsNativeProtectionAccountAddRequest!
                "
        )]
        public AwsNativeProtectionAccountAddRequest? AwsNativeProtectionAccountAddArg { get; set; }
        
        // -------------------------------------------------------------------
        // validateAndCreateCloudAccount parameter set
        //
        // GraphQL operation: validateAndCreateAwsCloudAccount(input: ValidateAndCreateAwsCloudAccountInput!):ValidateAndCreateAwsCloudAccountReply!
        //
        [Parameter(
            ParameterSetName = "validateAndCreateCloudAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Validate and create AWS cloud account. If validation fails, no error is returned and the cause is present in the ""message"" field of return object or within admin/child accounts of return object. In case validation succeeds, it initiates creation of AWS cloud account. This is the first step to set up native protection.
                GraphQL operation: validateAndCreateAwsCloudAccount(input: ValidateAndCreateAwsCloudAccountInput!):ValidateAndCreateAwsCloudAccountReply!
                ",
            Position = 0
        )]
        public SwitchParameter validateAndCreateCloudAccount { get; set; }

        
        // -------------------------------------------------------------------
        // finalizeCloudAccountProtection parameter set
        //
        // GraphQL operation: finalizeAwsCloudAccountProtection(input: FinalizeAwsCloudAccountProtectionInput!):FinalizeAwsCloudAccountProtectionReply!
        //
        [Parameter(
            ParameterSetName = "finalizeCloudAccountProtection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Process cloud account. This is the second step after validate and create in addition of a feature for cloud account.The CloudFormation stack should be created after this step using the CloudFormation URL provided in the first step.
                GraphQL operation: finalizeAwsCloudAccountProtection(input: FinalizeAwsCloudAccountProtectionInput!):FinalizeAwsCloudAccountProtectionReply!
                ",
            Position = 0
        )]
        public SwitchParameter finalizeCloudAccountProtection { get; set; }

        
        // -------------------------------------------------------------------
        // prepareCloudAccountDeletion parameter set
        //
        // GraphQL operation: prepareAwsCloudAccountDeletion(input: PrepareAwsCloudAccountDeletionInput!):PrepareAwsCloudAccountDeletionReply!
        //
        [Parameter(
            ParameterSetName = "prepareCloudAccountDeletion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Prepare deletion of cloud account. This is the first step to delete AWS cloud account. It generated template for deletion of cloud account and does not change any state of account.
                GraphQL operation: prepareAwsCloudAccountDeletion(input: PrepareAwsCloudAccountDeletionInput!):PrepareAwsCloudAccountDeletionReply!
                ",
            Position = 0
        )]
        public SwitchParameter prepareCloudAccountDeletion { get; set; }

        
        // -------------------------------------------------------------------
        // finalizeCloudAccountDeletion parameter set
        //
        // GraphQL operation: finalizeAwsCloudAccountDeletion(input: FinalizeAwsCloudAccountDeletionInput!):FinalizeAwsCloudAccountDeletionReply!
        //
        [Parameter(
            ParameterSetName = "finalizeCloudAccountDeletion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Process and finalize deletion of cloud account is the last step in deletion of a feature from cloud account. This endpoint is a MUST for deletion of disconnected features.
                GraphQL operation: finalizeAwsCloudAccountDeletion(input: FinalizeAwsCloudAccountDeletionInput!):FinalizeAwsCloudAccountDeletionReply!
                ",
            Position = 0
        )]
        public SwitchParameter finalizeCloudAccountDeletion { get; set; }

        
        // -------------------------------------------------------------------
        // updateCloudAccountFeature parameter set
        //
        // GraphQL operation: updateAwsCloudAccountFeature(input: UpdateAwsCloudAccountFeatureInput!):UpdateAwsCloudAccountFeatureReply!
        //
        [Parameter(
            ParameterSetName = "updateCloudAccountFeature",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Updates regions, stack ARN, and role ARN for a feature for a given cloud account.
                GraphQL operation: updateAwsCloudAccountFeature(input: UpdateAwsCloudAccountFeatureInput!):UpdateAwsCloudAccountFeatureReply!
                ",
            Position = 0
        )]
        public SwitchParameter updateCloudAccountFeature { get; set; }

        
        // -------------------------------------------------------------------
        // updateCloudAccount parameter set
        //
        // GraphQL operation: updateAwsCloudAccount(input: UpdateAwsCloudAccountInput!):Void
        //
        [Parameter(
            ParameterSetName = "updateCloudAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Update properties for a given AWS cloud account.
                GraphQL operation: updateAwsCloudAccount(input: UpdateAwsCloudAccountInput!):Void
                ",
            Position = 0
        )]
        public SwitchParameter updateCloudAccount { get; set; }

        
        // -------------------------------------------------------------------
        // prepareFeatureUpdateForCloudAccount parameter set
        //
        // GraphQL operation: prepareFeatureUpdateForAwsCloudAccount(input: PrepareFeatureUpdateForAwsCloudAccountInput!):PrepareFeatureUpdateForAwsCloudAccountReply!
        //
        [Parameter(
            ParameterSetName = "prepareFeatureUpdateForCloudAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Prepare manual update features to latest version.
                GraphQL operation: prepareFeatureUpdateForAwsCloudAccount(input: PrepareFeatureUpdateForAwsCloudAccountInput!):PrepareFeatureUpdateForAwsCloudAccountReply!
                ",
            Position = 0
        )]
        public SwitchParameter prepareFeatureUpdateForCloudAccount { get; set; }

        
        // -------------------------------------------------------------------
        // CloudAccountUpdateFeature parameter set
        //
        // GraphQL operation: awsCloudAccountUpdateFeature(cloudAccountUuid: UUID!, features: [CloudAccountFeature!]!):AwsCloudAccountUpdateFeatureResponse!
        //
        [Parameter(
            ParameterSetName = "CloudAccountUpdateFeature",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                This endpoint is deprecated.
                GraphQL operation: awsCloudAccountUpdateFeature(cloudAccountUuid: UUID!, features: [CloudAccountFeature!]!):AwsCloudAccountUpdateFeatureResponse!
                ",
            Position = 0
        )]
        public SwitchParameter CloudAccountUpdateFeature { get; set; }

        [Parameter(
            ParameterSetName = "CloudAccountUpdateFeature",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                The ID of the cloud account.
                GraphQL argument cloudAccountUuid: UUID!
                "
        )]
        public System.String? CloudAccountUuid { get; set; }
        [Parameter(
            ParameterSetName = "CloudAccountUpdateFeature",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Cloud Account Features.
                GraphQL argument features: [CloudAccountFeature!]!
                "
        )]
        public List<CloudAccountFeature>? Features { get; set; }
        
        // -------------------------------------------------------------------
        // createExocomputeConfig parameter set
        //
        // GraphQL operation: createAwsExocomputeConfigs(input: CreateAwsExocomputeConfigsInput!):CreateAwsExocomputeConfigsReply!
        //
        [Parameter(
            ParameterSetName = "createExocomputeConfig",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Create AWS Exocompute configs.
                GraphQL operation: createAwsExocomputeConfigs(input: CreateAwsExocomputeConfigsInput!):CreateAwsExocomputeConfigsReply!
                ",
            Position = 0
        )]
        public SwitchParameter createExocomputeConfig { get; set; }

        
        // -------------------------------------------------------------------
        // deleteExocomputeConfig parameter set
        //
        // GraphQL operation: deleteAwsExocomputeConfigs(input: DeleteAwsExocomputeConfigsInput!):DeleteAwsExocomputeConfigsReply!
        //
        [Parameter(
            ParameterSetName = "deleteExocomputeConfig",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Deletes AWS Exocompute configs.
                GraphQL operation: deleteAwsExocomputeConfigs(input: DeleteAwsExocomputeConfigsInput!):DeleteAwsExocomputeConfigsReply!
                ",
            Position = 0
        )]
        public SwitchParameter deleteExocomputeConfig { get; set; }

        
        // -------------------------------------------------------------------
        // updateExocomputeConfig parameter set
        //
        // GraphQL operation: updateAwsExocomputeConfigs(input: UpdateAwsExocomputeConfigsInput!):UpdateAwsExocomputeConfigsReply!
        //
        [Parameter(
            ParameterSetName = "updateExocomputeConfig",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Update AWS Exocompute configs.
                GraphQL operation: updateAwsExocomputeConfigs(input: UpdateAwsExocomputeConfigsInput!):UpdateAwsExocomputeConfigsReply!
                ",
            Position = 0
        )]
        public SwitchParameter updateExocomputeConfig { get; set; }

        
        // -------------------------------------------------------------------
        // startExocomputeDisableJob parameter set
        //
        // GraphQL operation: startAwsExocomputeDisableJob(input: StartAwsExocomputeDisableJobInput!):AsyncJobStatus!
        //
        [Parameter(
            ParameterSetName = "startExocomputeDisableJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Starts a job to disable AWS Exocompute feature. When complete, the job will disable exocompute feature for the specified AWS Native account.
                GraphQL operation: startAwsExocomputeDisableJob(input: StartAwsExocomputeDisableJobInput!):AsyncJobStatus!
                ",
            Position = 0
        )]
        public SwitchParameter startExocomputeDisableJob { get; set; }

        
        // -------------------------------------------------------------------
        // addIamUserBasedCloudAccount parameter set
        //
        // GraphQL operation: addAwsIamUserBasedCloudAccount(input: AddAwsIamUserBasedCloudAccountInput!):AddAwsIamUserBasedCloudAccountReply!
        //
        [Parameter(
            ParameterSetName = "addIamUserBasedCloudAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Adds an IAM user-based AWS cloud account and enables the features specified in the input after successful validation of the request.
                GraphQL operation: addAwsIamUserBasedCloudAccount(input: AddAwsIamUserBasedCloudAccountInput!):AddAwsIamUserBasedCloudAccountReply!
                ",
            Position = 0
        )]
        public SwitchParameter addIamUserBasedCloudAccount { get; set; }

        
        // -------------------------------------------------------------------
        // deleteIamUserBasedCloudAccount parameter set
        //
        // GraphQL operation: deleteAwsIamUserBasedCloudAccount(input: DeleteAwsIamUserBasedCloudAccountInput!):DeleteAwsIamUserBasedCloudAccountReply!
        //
        [Parameter(
            ParameterSetName = "deleteIamUserBasedCloudAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Deletes IAM user-based AWS cloud account.
                GraphQL operation: deleteAwsIamUserBasedCloudAccount(input: DeleteAwsIamUserBasedCloudAccountInput!):DeleteAwsIamUserBasedCloudAccountReply!
                ",
            Position = 0
        )]
        public SwitchParameter deleteIamUserBasedCloudAccount { get; set; }

        
        // -------------------------------------------------------------------
        // deleteCloudAccountWithoutCft parameter set
        //
        // GraphQL operation: deleteAwsCloudAccountWithoutCft(input: DeleteAwsCloudAccountWithoutCftInput!):DeleteAwsCloudAccountWithoutCftReply!
        //
        [Parameter(
            ParameterSetName = "deleteCloudAccountWithoutCft",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Removes AWS cloud account without cleaning up the associated permissions from the AWS cloud account. Customer needs to clean up the permissions in the AWS account themselves. This mutation is supported only for IAM user-based and authentication server-based AWS cloud accounts.
                GraphQL operation: deleteAwsCloudAccountWithoutCft(input: DeleteAwsCloudAccountWithoutCftInput!):DeleteAwsCloudAccountWithoutCftReply!
                ",
            Position = 0
        )]
        public SwitchParameter deleteCloudAccountWithoutCft { get; set; }

        
        // -------------------------------------------------------------------
        // upgradeIamUserBasedCloudAccountPermission parameter set
        //
        // GraphQL operation: upgradeAwsIamUserBasedCloudAccountPermissions(input: UpgradeAwsIamUserBasedCloudAccountPermissionsInput!):Boolean!
        //
        [Parameter(
            ParameterSetName = "upgradeIamUserBasedCloudAccountPermission",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Set IAM user-based AWS account features status to Connected from Update Permissions state. It should be used by caution from cloud accounts only after latest required permissions are granted to authorized IAM user.
                GraphQL operation: upgradeAwsIamUserBasedCloudAccountPermissions(input: UpgradeAwsIamUserBasedCloudAccountPermissionsInput!):Boolean!
                ",
            Position = 0
        )]
        public SwitchParameter upgradeIamUserBasedCloudAccountPermission { get; set; }

        
        // -------------------------------------------------------------------
        // upgradeCloudAccountFeaturesWithoutCft parameter set
        //
        // GraphQL operation: upgradeAwsCloudAccountFeaturesWithoutCft(input: UpgradeAwsCloudAccountFeaturesWithoutCftInput!):Boolean!
        //
        [Parameter(
            ParameterSetName = "upgradeCloudAccountFeaturesWithoutCft",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Updates status of AWS cloud account features to connected if they are in update permissions state. This mutation should be used with caution. It should be invoked only after the latest required permissions are granted to the AWS cloud account user used by Rubrik. This mutation does not verify if the required permissions are actually granted to the user or not. Its usage is restricted to only IAM user-based and authentication server-based AWS cloud accounts.
                GraphQL operation: upgradeAwsCloudAccountFeaturesWithoutCft(input: UpgradeAwsCloudAccountFeaturesWithoutCftInput!):Boolean!
                ",
            Position = 0
        )]
        public SwitchParameter upgradeCloudAccountFeaturesWithoutCft { get; set; }

        
        // -------------------------------------------------------------------
        // addAuthenticationServerBasedCloudAccount parameter set
        //
        // GraphQL operation: addAwsAuthenticationServerBasedCloudAccount(input: AddAwsAuthenticationServerBasedCloudAccountInput!):AddAwsAuthenticationServerBasedCloudAccountReply!
        //
        [Parameter(
            ParameterSetName = "addAuthenticationServerBasedCloudAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Validates and adds an authentication server-based AWS cloud account. When validation succeeds, the AWS cloud account is added and the features specified in the request are enabled. When validation fails, an error is not returned, but the cause of the failure is specified in the ""message"" field of the response object.
                GraphQL operation: addAwsAuthenticationServerBasedCloudAccount(input: AddAwsAuthenticationServerBasedCloudAccountInput!):AddAwsAuthenticationServerBasedCloudAccountReply!
                ",
            Position = 0
        )]
        public SwitchParameter addAuthenticationServerBasedCloudAccount { get; set; }

        
        // -------------------------------------------------------------------
        // patchAuthenticationServerBasedCloudAccount parameter set
        //
        // GraphQL operation: patchAwsAuthenticationServerBasedCloudAccount(input: PatchAwsAuthenticationServerBasedCloudAccountInput!):Boolean!
        //
        [Parameter(
            ParameterSetName = "patchAuthenticationServerBasedCloudAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Updates authentication server-based AWS cloud account. Use this mutation to update account details related to role name, certificates, features. The mutation can update one or more certificates associated to an account in a single request. All input fields except account identifier are optional so that any combination of account attributes can be updated in a single call. If none of the optional fields are provided in the input then no updates are performed, and the response does not contain any error message.
                GraphQL operation: patchAwsAuthenticationServerBasedCloudAccount(input: PatchAwsAuthenticationServerBasedCloudAccountInput!):Boolean!
                ",
            Position = 0
        )]
        public SwitchParameter patchAuthenticationServerBasedCloudAccount { get; set; }

        
        // -------------------------------------------------------------------
        // patchIamUserBasedCloudAccount parameter set
        //
        // GraphQL operation: patchAwsIamUserBasedCloudAccount(input: PatchAwsIamUserBasedCloudAccountInput!):Boolean!
        //
        [Parameter(
            ParameterSetName = "patchIamUserBasedCloudAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Updates IAM user-based AWS cloud account. Use this mutation to update account details access/secret keys, role ARN and regions. All input fields except account ID are optional so that any combination of account attributes can be updated in a single call. If none of the optional fields are provided in the input then no updates are performed, and the response does not contain any error message.
                GraphQL operation: patchAwsIamUserBasedCloudAccount(input: PatchAwsIamUserBasedCloudAccountInput!):Boolean!
                ",
            Position = 0
        )]
        public SwitchParameter patchIamUserBasedCloudAccount { get; set; }

        
        // -------------------------------------------------------------------
        // createCluster parameter set
        //
        // GraphQL operation: createAwsCluster(input: CreateAwsClusterInput!):CcProvisionJobReply!
        //
        [Parameter(
            ParameterSetName = "createCluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Create a Rubrik Cloud Cluster on AWS.
                GraphQL operation: createAwsCluster(input: CreateAwsClusterInput!):CcProvisionJobReply!
                ",
            Position = 0
        )]
        public SwitchParameter createCluster { get; set; }

        
        // -------------------------------------------------------------------
        // deleteCluster parameter set
        //
        // GraphQL operation: deleteAwsCluster(input: DeleteAwsClusterInput!):CcProvisionJobReply!
        //
        [Parameter(
            ParameterSetName = "deleteCluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Delete a Rubrik Cloud Cluster on AWS.
                GraphQL operation: deleteAwsCluster(input: DeleteAwsClusterInput!):CcProvisionJobReply!
                ",
            Position = 0
        )]
        public SwitchParameter deleteCluster { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "startNativeEc2InstanceSnapshotsJob":
                        this.ProcessRecord_startNativeEc2InstanceSnapshotsJob();
                        break;
                    case "startRestoreNativeEc2InstanceSnapshotJob":
                        this.ProcessRecord_startRestoreNativeEc2InstanceSnapshotJob();
                        break;
                    case "startRefreshNativeAccountsJob":
                        this.ProcessRecord_startRefreshNativeAccountsJob();
                        break;
                    case "startCreateNativeEbsVolumeSnapshotsJob":
                        this.ProcessRecord_startCreateNativeEbsVolumeSnapshotsJob();
                        break;
                    case "startNativeAccountDisableJob":
                        this.ProcessRecord_startNativeAccountDisableJob();
                        break;
                    case "startExportNativeEbsVolumeSnapshotJob":
                        this.ProcessRecord_startExportNativeEbsVolumeSnapshotJob();
                        break;
                    case "excludeNativeEbsVolumesFromSnapshot":
                        this.ProcessRecord_excludeNativeEbsVolumesFromSnapshot();
                        break;
                    case "startNativeRdsInstanceSnapshotsJob":
                        this.ProcessRecord_startNativeRdsInstanceSnapshotsJob();
                        break;
                    case "createAccount":
                        this.ProcessRecord_createAccount();
                        break;
                    case "updateAccount":
                        this.ProcessRecord_updateAccount();
                        break;
                    case "createAutomaticTargetMapping":
                        this.ProcessRecord_createAutomaticTargetMapping();
                        break;
                    case "createCloudNativeStorageSetting":
                        this.ProcessRecord_createCloudNativeStorageSetting();
                        break;
                    case "updateAutomaticTargetMapping":
                        this.ProcessRecord_updateAutomaticTargetMapping();
                        break;
                    case "updateCloudNativeStorageSetting":
                        this.ProcessRecord_updateCloudNativeStorageSetting();
                        break;
                    case "createTarget":
                        this.ProcessRecord_createTarget();
                        break;
                    case "updateTarget":
                        this.ProcessRecord_updateTarget();
                        break;
                    case "createReaderTarget":
                        this.ProcessRecord_createReaderTarget();
                        break;
                    case "createComputeSetting":
                        this.ProcessRecord_createComputeSetting();
                        break;
                    case "updateComputeSetting":
                        this.ProcessRecord_updateComputeSetting();
                        break;
                    case "deleteComputeSetting":
                        this.ProcessRecord_deleteComputeSetting();
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
                    case "validateAndCreateCloudAccount":
                        this.ProcessRecord_validateAndCreateCloudAccount();
                        break;
                    case "finalizeCloudAccountProtection":
                        this.ProcessRecord_finalizeCloudAccountProtection();
                        break;
                    case "prepareCloudAccountDeletion":
                        this.ProcessRecord_prepareCloudAccountDeletion();
                        break;
                    case "finalizeCloudAccountDeletion":
                        this.ProcessRecord_finalizeCloudAccountDeletion();
                        break;
                    case "updateCloudAccountFeature":
                        this.ProcessRecord_updateCloudAccountFeature();
                        break;
                    case "updateCloudAccount":
                        this.ProcessRecord_updateCloudAccount();
                        break;
                    case "prepareFeatureUpdateForCloudAccount":
                        this.ProcessRecord_prepareFeatureUpdateForCloudAccount();
                        break;
                    case "CloudAccountUpdateFeature":
                        this.ProcessRecord_CloudAccountUpdateFeature();
                        break;
                    case "createExocomputeConfig":
                        this.ProcessRecord_createExocomputeConfig();
                        break;
                    case "deleteExocomputeConfig":
                        this.ProcessRecord_deleteExocomputeConfig();
                        break;
                    case "updateExocomputeConfig":
                        this.ProcessRecord_updateExocomputeConfig();
                        break;
                    case "startExocomputeDisableJob":
                        this.ProcessRecord_startExocomputeDisableJob();
                        break;
                    case "addIamUserBasedCloudAccount":
                        this.ProcessRecord_addIamUserBasedCloudAccount();
                        break;
                    case "deleteIamUserBasedCloudAccount":
                        this.ProcessRecord_deleteIamUserBasedCloudAccount();
                        break;
                    case "deleteCloudAccountWithoutCft":
                        this.ProcessRecord_deleteCloudAccountWithoutCft();
                        break;
                    case "upgradeIamUserBasedCloudAccountPermission":
                        this.ProcessRecord_upgradeIamUserBasedCloudAccountPermission();
                        break;
                    case "upgradeCloudAccountFeaturesWithoutCft":
                        this.ProcessRecord_upgradeCloudAccountFeaturesWithoutCft();
                        break;
                    case "addAuthenticationServerBasedCloudAccount":
                        this.ProcessRecord_addAuthenticationServerBasedCloudAccount();
                        break;
                    case "patchAuthenticationServerBasedCloudAccount":
                        this.ProcessRecord_patchAuthenticationServerBasedCloudAccount();
                        break;
                    case "patchIamUserBasedCloudAccount":
                        this.ProcessRecord_patchIamUserBasedCloudAccount();
                        break;
                    case "createCluster":
                        this.ProcessRecord_createCluster();
                        break;
                    case "deleteCluster":
                        this.ProcessRecord_deleteCluster();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + Op);
                }
           }
           catch (Exception ex)
           {
                this._logger.Flush();
                var error = new ErrorRecord(
                    ex,
                    "Invoke-RscMutateAws",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(error);
           }
        }

        // This parameter set invokes a single graphql operation:
        // startAwsNativeEc2InstanceSnapshotsJob.
        protected void ProcessRecord_startNativeEc2InstanceSnapshotsJob()
        {
            this._logger.name += " -startNativeEc2InstanceSnapshotsJob";
            // Invoke graphql operation startAwsNativeEc2InstanceSnapshotsJob
            InvokeMutationStartAwsNativeEc2InstanceSnapshotsJob();
        }

        // This parameter set invokes a single graphql operation:
        // startRestoreAwsNativeEc2InstanceSnapshotJob.
        protected void ProcessRecord_startRestoreNativeEc2InstanceSnapshotJob()
        {
            this._logger.name += " -startRestoreNativeEc2InstanceSnapshotJob";
            // Invoke graphql operation startRestoreAwsNativeEc2InstanceSnapshotJob
            InvokeMutationStartRestoreAwsNativeEc2InstanceSnapshotJob();
        }

        // This parameter set invokes a single graphql operation:
        // startRefreshAwsNativeAccountsJob.
        protected void ProcessRecord_startRefreshNativeAccountsJob()
        {
            this._logger.name += " -startRefreshNativeAccountsJob";
            // Invoke graphql operation startRefreshAwsNativeAccountsJob
            InvokeMutationStartRefreshAwsNativeAccountsJob();
        }

        // This parameter set invokes a single graphql operation:
        // startCreateAwsNativeEbsVolumeSnapshotsJob.
        protected void ProcessRecord_startCreateNativeEbsVolumeSnapshotsJob()
        {
            this._logger.name += " -startCreateNativeEbsVolumeSnapshotsJob";
            // Invoke graphql operation startCreateAwsNativeEbsVolumeSnapshotsJob
            InvokeMutationStartCreateAwsNativeEbsVolumeSnapshotsJob();
        }

        // This parameter set invokes a single graphql operation:
        // startAwsNativeAccountDisableJob.
        protected void ProcessRecord_startNativeAccountDisableJob()
        {
            this._logger.name += " -startNativeAccountDisableJob";
            // Invoke graphql operation startAwsNativeAccountDisableJob
            InvokeMutationStartAwsNativeAccountDisableJob();
        }

        // This parameter set invokes a single graphql operation:
        // startExportAwsNativeEbsVolumeSnapshotJob.
        protected void ProcessRecord_startExportNativeEbsVolumeSnapshotJob()
        {
            this._logger.name += " -startExportNativeEbsVolumeSnapshotJob";
            // Invoke graphql operation startExportAwsNativeEbsVolumeSnapshotJob
            InvokeMutationStartExportAwsNativeEbsVolumeSnapshotJob();
        }

        // This parameter set invokes a single graphql operation:
        // excludeAwsNativeEbsVolumesFromSnapshot.
        protected void ProcessRecord_excludeNativeEbsVolumesFromSnapshot()
        {
            this._logger.name += " -excludeNativeEbsVolumesFromSnapshot";
            // Invoke graphql operation excludeAwsNativeEbsVolumesFromSnapshot
            InvokeMutationExcludeAwsNativeEbsVolumesFromSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // startAwsNativeRdsInstanceSnapshotsJob.
        protected void ProcessRecord_startNativeRdsInstanceSnapshotsJob()
        {
            this._logger.name += " -startNativeRdsInstanceSnapshotsJob";
            // Invoke graphql operation startAwsNativeRdsInstanceSnapshotsJob
            InvokeMutationStartAwsNativeRdsInstanceSnapshotsJob();
        }

        // This parameter set invokes a single graphql operation:
        // createAwsAccount.
        protected void ProcessRecord_createAccount()
        {
            this._logger.name += " -createAccount";
            // Invoke graphql operation createAwsAccount
            InvokeMutationCreateAwsAccount();
        }

        // This parameter set invokes a single graphql operation:
        // updateAwsAccount.
        protected void ProcessRecord_updateAccount()
        {
            this._logger.name += " -updateAccount";
            // Invoke graphql operation updateAwsAccount
            InvokeMutationUpdateAwsAccount();
        }

        // This parameter set invokes a single graphql operation:
        // createAutomaticAwsTargetMapping.
        protected void ProcessRecord_createAutomaticTargetMapping()
        {
            this._logger.name += " -createAutomaticTargetMapping";
            // Invoke graphql operation createAutomaticAwsTargetMapping
            InvokeMutationCreateAutomaticAwsTargetMapping();
        }

        // This parameter set invokes a single graphql operation:
        // createCloudNativeAwsStorageSetting.
        protected void ProcessRecord_createCloudNativeStorageSetting()
        {
            this._logger.name += " -createCloudNativeStorageSetting";
            // Invoke graphql operation createCloudNativeAwsStorageSetting
            InvokeMutationCreateCloudNativeAwsStorageSetting();
        }

        // This parameter set invokes a single graphql operation:
        // updateAutomaticAwsTargetMapping.
        protected void ProcessRecord_updateAutomaticTargetMapping()
        {
            this._logger.name += " -updateAutomaticTargetMapping";
            // Invoke graphql operation updateAutomaticAwsTargetMapping
            InvokeMutationUpdateAutomaticAwsTargetMapping();
        }

        // This parameter set invokes a single graphql operation:
        // updateCloudNativeAwsStorageSetting.
        protected void ProcessRecord_updateCloudNativeStorageSetting()
        {
            this._logger.name += " -updateCloudNativeStorageSetting";
            // Invoke graphql operation updateCloudNativeAwsStorageSetting
            InvokeMutationUpdateCloudNativeAwsStorageSetting();
        }

        // This parameter set invokes a single graphql operation:
        // createAwsTarget.
        protected void ProcessRecord_createTarget()
        {
            this._logger.name += " -createTarget";
            // Invoke graphql operation createAwsTarget
            InvokeMutationCreateAwsTarget();
        }

        // This parameter set invokes a single graphql operation:
        // updateAwsTarget.
        protected void ProcessRecord_updateTarget()
        {
            this._logger.name += " -updateTarget";
            // Invoke graphql operation updateAwsTarget
            InvokeMutationUpdateAwsTarget();
        }

        // This parameter set invokes a single graphql operation:
        // createAwsReaderTarget.
        protected void ProcessRecord_createReaderTarget()
        {
            this._logger.name += " -createReaderTarget";
            // Invoke graphql operation createAwsReaderTarget
            InvokeMutationCreateAwsReaderTarget();
        }

        // This parameter set invokes a single graphql operation:
        // createAwsComputeSetting.
        protected void ProcessRecord_createComputeSetting()
        {
            this._logger.name += " -createComputeSetting";
            // Invoke graphql operation createAwsComputeSetting
            InvokeMutationCreateAwsComputeSetting();
        }

        // This parameter set invokes a single graphql operation:
        // updateAwsComputeSetting.
        protected void ProcessRecord_updateComputeSetting()
        {
            this._logger.name += " -updateComputeSetting";
            // Invoke graphql operation updateAwsComputeSetting
            InvokeMutationUpdateAwsComputeSetting();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAwsComputeSetting.
        protected void ProcessRecord_deleteComputeSetting()
        {
            this._logger.name += " -deleteComputeSetting";
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
        protected void ProcessRecord_validateAndCreateCloudAccount()
        {
            this._logger.name += " -validateAndCreateCloudAccount";
            // Invoke graphql operation validateAndCreateAwsCloudAccount
            InvokeMutationValidateAndCreateAwsCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // finalizeAwsCloudAccountProtection.
        protected void ProcessRecord_finalizeCloudAccountProtection()
        {
            this._logger.name += " -finalizeCloudAccountProtection";
            // Invoke graphql operation finalizeAwsCloudAccountProtection
            InvokeMutationFinalizeAwsCloudAccountProtection();
        }

        // This parameter set invokes a single graphql operation:
        // prepareAwsCloudAccountDeletion.
        protected void ProcessRecord_prepareCloudAccountDeletion()
        {
            this._logger.name += " -prepareCloudAccountDeletion";
            // Invoke graphql operation prepareAwsCloudAccountDeletion
            InvokeMutationPrepareAwsCloudAccountDeletion();
        }

        // This parameter set invokes a single graphql operation:
        // finalizeAwsCloudAccountDeletion.
        protected void ProcessRecord_finalizeCloudAccountDeletion()
        {
            this._logger.name += " -finalizeCloudAccountDeletion";
            // Invoke graphql operation finalizeAwsCloudAccountDeletion
            InvokeMutationFinalizeAwsCloudAccountDeletion();
        }

        // This parameter set invokes a single graphql operation:
        // updateAwsCloudAccountFeature.
        protected void ProcessRecord_updateCloudAccountFeature()
        {
            this._logger.name += " -updateCloudAccountFeature";
            // Invoke graphql operation updateAwsCloudAccountFeature
            InvokeMutationUpdateAwsCloudAccountFeature();
        }

        // This parameter set invokes a single graphql operation:
        // updateAwsCloudAccount.
        protected void ProcessRecord_updateCloudAccount()
        {
            this._logger.name += " -updateCloudAccount";
            // Invoke graphql operation updateAwsCloudAccount
            InvokeMutationUpdateAwsCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // prepareFeatureUpdateForAwsCloudAccount.
        protected void ProcessRecord_prepareFeatureUpdateForCloudAccount()
        {
            this._logger.name += " -prepareFeatureUpdateForCloudAccount";
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
        protected void ProcessRecord_createExocomputeConfig()
        {
            this._logger.name += " -createExocomputeConfig";
            // Invoke graphql operation createAwsExocomputeConfigs
            InvokeMutationCreateAwsExocomputeConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAwsExocomputeConfigs.
        protected void ProcessRecord_deleteExocomputeConfig()
        {
            this._logger.name += " -deleteExocomputeConfig";
            // Invoke graphql operation deleteAwsExocomputeConfigs
            InvokeMutationDeleteAwsExocomputeConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // updateAwsExocomputeConfigs.
        protected void ProcessRecord_updateExocomputeConfig()
        {
            this._logger.name += " -updateExocomputeConfig";
            // Invoke graphql operation updateAwsExocomputeConfigs
            InvokeMutationUpdateAwsExocomputeConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // startAwsExocomputeDisableJob.
        protected void ProcessRecord_startExocomputeDisableJob()
        {
            this._logger.name += " -startExocomputeDisableJob";
            // Invoke graphql operation startAwsExocomputeDisableJob
            InvokeMutationStartAwsExocomputeDisableJob();
        }

        // This parameter set invokes a single graphql operation:
        // addAwsIamUserBasedCloudAccount.
        protected void ProcessRecord_addIamUserBasedCloudAccount()
        {
            this._logger.name += " -addIamUserBasedCloudAccount";
            // Invoke graphql operation addAwsIamUserBasedCloudAccount
            InvokeMutationAddAwsIamUserBasedCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAwsIamUserBasedCloudAccount.
        protected void ProcessRecord_deleteIamUserBasedCloudAccount()
        {
            this._logger.name += " -deleteIamUserBasedCloudAccount";
            // Invoke graphql operation deleteAwsIamUserBasedCloudAccount
            InvokeMutationDeleteAwsIamUserBasedCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAwsCloudAccountWithoutCft.
        protected void ProcessRecord_deleteCloudAccountWithoutCft()
        {
            this._logger.name += " -deleteCloudAccountWithoutCft";
            // Invoke graphql operation deleteAwsCloudAccountWithoutCft
            InvokeMutationDeleteAwsCloudAccountWithoutCft();
        }

        // This parameter set invokes a single graphql operation:
        // upgradeAwsIamUserBasedCloudAccountPermissions.
        protected void ProcessRecord_upgradeIamUserBasedCloudAccountPermission()
        {
            this._logger.name += " -upgradeIamUserBasedCloudAccountPermission";
            // Invoke graphql operation upgradeAwsIamUserBasedCloudAccountPermissions
            InvokeMutationUpgradeAwsIamUserBasedCloudAccountPermissions();
        }

        // This parameter set invokes a single graphql operation:
        // upgradeAwsCloudAccountFeaturesWithoutCft.
        protected void ProcessRecord_upgradeCloudAccountFeaturesWithoutCft()
        {
            this._logger.name += " -upgradeCloudAccountFeaturesWithoutCft";
            // Invoke graphql operation upgradeAwsCloudAccountFeaturesWithoutCft
            InvokeMutationUpgradeAwsCloudAccountFeaturesWithoutCft();
        }

        // This parameter set invokes a single graphql operation:
        // addAwsAuthenticationServerBasedCloudAccount.
        protected void ProcessRecord_addAuthenticationServerBasedCloudAccount()
        {
            this._logger.name += " -addAuthenticationServerBasedCloudAccount";
            // Invoke graphql operation addAwsAuthenticationServerBasedCloudAccount
            InvokeMutationAddAwsAuthenticationServerBasedCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // patchAwsAuthenticationServerBasedCloudAccount.
        protected void ProcessRecord_patchAuthenticationServerBasedCloudAccount()
        {
            this._logger.name += " -patchAuthenticationServerBasedCloudAccount";
            // Invoke graphql operation patchAwsAuthenticationServerBasedCloudAccount
            InvokeMutationPatchAwsAuthenticationServerBasedCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // patchAwsIamUserBasedCloudAccount.
        protected void ProcessRecord_patchIamUserBasedCloudAccount()
        {
            this._logger.name += " -patchIamUserBasedCloudAccount";
            // Invoke graphql operation patchAwsIamUserBasedCloudAccount
            InvokeMutationPatchAwsIamUserBasedCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // createAwsCluster.
        protected void ProcessRecord_createCluster()
        {
            this._logger.name += " -createCluster";
            // Invoke graphql operation createAwsCluster
            InvokeMutationCreateAwsCluster();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAwsCluster.
        protected void ProcessRecord_deleteCluster()
        {
            this._logger.name += " -deleteCluster";
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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