// Mutate-RscAws.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:44.
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
using Rubrik.SecurityCloud.NetSDK.Library.HelperClasses;
using Rubrik.SecurityCloud.Operations;
using GraphQL;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
{
    [Cmdlet(
        "Mutate",
        "RscAws",
        DefaultParameterSetName = "createTarget")
    ]
    public class Mutate_RscAws : RscPSCmdlet
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
            HelpMessage = "GraphQL operation: startAwsNativeEc2InstanceSnapshotsJob(input: StartAwsNativeEc2InstanceSnapshotsJobInput!):BatchAsyncJobStatus!",
            Position = 0
        )]
        public SwitchParameter startNativeEc2InstanceSnapshotsJob { get; set; }

        [Parameter(
            ParameterSetName = "startNativeEc2InstanceSnapshotsJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument input: StartAwsNativeEc2InstanceSnapshotsJobInput!"
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
            HelpMessage = "GraphQL operation: startRestoreAwsNativeEc2InstanceSnapshotJob(input: StartRestoreAwsNativeEc2InstanceSnapshotJobInput!):AsyncJobStatus!",
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
            HelpMessage = "GraphQL operation: startRefreshAwsNativeAccountsJob(input: StartRefreshAwsNativeAccountsJobInput!):BatchAsyncJobStatus!",
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
            HelpMessage = "GraphQL operation: startCreateAwsNativeEbsVolumeSnapshotsJob(input: StartCreateAwsNativeEbsVolumeSnapshotsJobInput!):BatchAsyncJobStatus!",
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
            HelpMessage = "GraphQL operation: startAwsNativeAccountDisableJob(input: StartAwsNativeAccountDisableJobInput!):AsyncJobStatus!",
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
            HelpMessage = "GraphQL operation: startExportAwsNativeEbsVolumeSnapshotJob(input: StartExportAwsNativeEbsVolumeSnapshotJobInput!):AsyncJobStatus!",
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
            HelpMessage = "GraphQL operation: excludeAwsNativeEbsVolumesFromSnapshot(input: ExcludeAwsNativeEbsVolumesFromSnapshotInput!):Void",
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
            HelpMessage = "GraphQL operation: startAwsNativeRdsInstanceSnapshotsJob(input: StartAwsNativeRdsInstanceSnapshotsJobInput!):BatchAsyncJobStatus!",
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
            HelpMessage = "GraphQL operation: createAwsAccount(input: CreateAwsAccountInput!):CloudAccount!",
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
            HelpMessage = "GraphQL operation: updateAwsAccount(input: UpdateAwsAccountInput!):CloudAccount!",
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
            HelpMessage = "GraphQL operation: createAutomaticAwsTargetMapping(input: CreateAutomaticAwsTargetMappingInput!):TargetMapping!",
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
            HelpMessage = "GraphQL operation: createCloudNativeAwsStorageSetting(input: CreateCloudNativeAwsStorageSettingInput!):CreateCloudNativeAwsStorageSettingReply!",
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
            HelpMessage = "GraphQL operation: updateAutomaticAwsTargetMapping(input: UpdateAutomaticAwsTargetMappingInput!):TargetMapping!",
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
            HelpMessage = "GraphQL operation: updateCloudNativeAwsStorageSetting(input: UpdateCloudNativeAwsStorageSettingInput!):UpdateCloudNativeAwsStorageSettingReply!",
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
            HelpMessage = "GraphQL operation: createAwsTarget(input: CreateAwsTargetInput!):Target!",
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
            HelpMessage = "GraphQL operation: updateAwsTarget(input: UpdateAwsTargetInput!):Target!",
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
            HelpMessage = "GraphQL operation: createAwsReaderTarget(input: CreateAwsReaderTargetInput!):Target!",
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
            HelpMessage = "GraphQL operation: createAwsComputeSetting(input: CreateAwsComputeSettingInput!):AwsComputeSettings!",
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
            HelpMessage = "GraphQL operation: updateAwsComputeSetting(input: UpdateAwsComputeSettingInput!):AwsComputeSettings!",
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
            HelpMessage = "GraphQL operation: deleteAwsComputeSetting(input: DeleteAwsComputeSettingInput!):Void",
            Position = 0
        )]
        public SwitchParameter deleteComputeSetting { get; set; }

        
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
            HelpMessage = "GraphQL operation: validateAndCreateAwsCloudAccount(input: ValidateAndCreateAwsCloudAccountInput!):ValidateAndCreateAwsCloudAccountReply!",
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
            HelpMessage = "GraphQL operation: finalizeAwsCloudAccountProtection(input: FinalizeAwsCloudAccountProtectionInput!):FinalizeAwsCloudAccountProtectionReply!",
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
            HelpMessage = "GraphQL operation: prepareAwsCloudAccountDeletion(input: PrepareAwsCloudAccountDeletionInput!):PrepareAwsCloudAccountDeletionReply!",
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
            HelpMessage = "GraphQL operation: finalizeAwsCloudAccountDeletion(input: FinalizeAwsCloudAccountDeletionInput!):FinalizeAwsCloudAccountDeletionReply!",
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
            HelpMessage = "GraphQL operation: updateAwsCloudAccountFeature(input: UpdateAwsCloudAccountFeatureInput!):UpdateAwsCloudAccountFeatureReply!",
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
            HelpMessage = "GraphQL operation: updateAwsCloudAccount(input: UpdateAwsCloudAccountInput!):Void",
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
            HelpMessage = "GraphQL operation: prepareFeatureUpdateForAwsCloudAccount(input: PrepareFeatureUpdateForAwsCloudAccountInput!):PrepareFeatureUpdateForAwsCloudAccountReply!",
            Position = 0
        )]
        public SwitchParameter prepareFeatureUpdateForCloudAccount { get; set; }

        
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
            HelpMessage = "GraphQL operation: createAwsExocomputeConfigs(input: CreateAwsExocomputeConfigsInput!):CreateAwsExocomputeConfigsReply!",
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
            HelpMessage = "GraphQL operation: deleteAwsExocomputeConfigs(input: DeleteAwsExocomputeConfigsInput!):DeleteAwsExocomputeConfigsReply!",
            Position = 0
        )]
        public SwitchParameter deleteExocomputeConfig { get; set; }

        
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
            HelpMessage = "GraphQL operation: startAwsExocomputeDisableJob(input: StartAwsExocomputeDisableJobInput!):AsyncJobStatus!",
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
            HelpMessage = "GraphQL operation: addAwsIamUserBasedCloudAccount(input: AddAwsIamUserBasedCloudAccountInput!):AddAwsIamUserBasedCloudAccountReply!",
            Position = 0
        )]
        public SwitchParameter addIamUserBasedCloudAccount { get; set; }

        
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
            HelpMessage = "GraphQL operation: upgradeAwsIamUserBasedCloudAccountPermissions(input: UpgradeAwsIamUserBasedCloudAccountPermissionsInput!):Boolean!",
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
            HelpMessage = "GraphQL operation: upgradeAwsCloudAccountFeaturesWithoutCft(input: UpgradeAwsCloudAccountFeaturesWithoutCftInput!):Boolean!",
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
            HelpMessage = "GraphQL operation: addAwsAuthenticationServerBasedCloudAccount(input: AddAwsAuthenticationServerBasedCloudAccountInput!):AddAwsAuthenticationServerBasedCloudAccountReply!",
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
            HelpMessage = "GraphQL operation: patchAwsAuthenticationServerBasedCloudAccount(input: PatchAwsAuthenticationServerBasedCloudAccountInput!):Boolean!",
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
            HelpMessage = "GraphQL operation: patchAwsIamUserBasedCloudAccount(input: PatchAwsIamUserBasedCloudAccountInput!):Boolean!",
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
            HelpMessage = "GraphQL operation: createAwsCluster(input: CreateAwsClusterInput!):CcProvisionJobReply!",
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
            HelpMessage = "GraphQL operation: deleteAwsCluster(input: DeleteAwsClusterInput!):CcProvisionJobReply!",
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
                    case "createExocomputeConfig":
                        this.ProcessRecord_createExocomputeConfig();
                        break;
                    case "deleteExocomputeConfig":
                        this.ProcessRecord_deleteExocomputeConfig();
                        break;
                    case "startExocomputeDisableJob":
                        this.ProcessRecord_startExocomputeDisableJob();
                        break;
                    case "addIamUserBasedCloudAccount":
                        this.ProcessRecord_addIamUserBasedCloudAccount();
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
                    "Mutate-RscAws",
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (BatchAsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (BatchAsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.StartAwsNativeEc2InstanceSnapshotsJob(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.StartAwsNativeEc2InstanceSnapshotsJob");
            string parameters = "($input: StartAwsNativeEc2InstanceSnapshotsJobInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationStartAwsNativeEc2InstanceSnapshotsJob" + parameters + "{" + document + "}",
                OperationName = "MutationStartAwsNativeEc2InstanceSnapshotsJob",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<BatchAsyncJobStatus> task = this._rbkClient.InvokeGenericCallAsync<BatchAsyncJobStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.StartRestoreAwsNativeEc2InstanceSnapshotJob(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.StartRestoreAwsNativeEc2InstanceSnapshotJob");
            string parameters = "($input: StartRestoreAwsNativeEc2InstanceSnapshotJobInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationStartRestoreAwsNativeEc2InstanceSnapshotJob" + parameters + "{" + document + "}",
                OperationName = "MutationStartRestoreAwsNativeEc2InstanceSnapshotJob",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncJobStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncJobStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (BatchAsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (BatchAsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.StartRefreshAwsNativeAccountsJob(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.StartRefreshAwsNativeAccountsJob");
            string parameters = "($input: StartRefreshAwsNativeAccountsJobInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationStartRefreshAwsNativeAccountsJob" + parameters + "{" + document + "}",
                OperationName = "MutationStartRefreshAwsNativeAccountsJob",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<BatchAsyncJobStatus> task = this._rbkClient.InvokeGenericCallAsync<BatchAsyncJobStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (BatchAsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (BatchAsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.StartCreateAwsNativeEbsVolumeSnapshotsJob(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.StartCreateAwsNativeEbsVolumeSnapshotsJob");
            string parameters = "($input: StartCreateAwsNativeEbsVolumeSnapshotsJobInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationStartCreateAwsNativeEbsVolumeSnapshotsJob" + parameters + "{" + document + "}",
                OperationName = "MutationStartCreateAwsNativeEbsVolumeSnapshotsJob",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<BatchAsyncJobStatus> task = this._rbkClient.InvokeGenericCallAsync<BatchAsyncJobStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.StartAwsNativeAccountDisableJob(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.StartAwsNativeAccountDisableJob");
            string parameters = "($input: StartAwsNativeAccountDisableJobInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationStartAwsNativeAccountDisableJob" + parameters + "{" + document + "}",
                OperationName = "MutationStartAwsNativeAccountDisableJob",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncJobStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncJobStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.StartExportAwsNativeEbsVolumeSnapshotJob(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.StartExportAwsNativeEbsVolumeSnapshotJob");
            string parameters = "($input: StartExportAwsNativeEbsVolumeSnapshotJobInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationStartExportAwsNativeEbsVolumeSnapshotJob" + parameters + "{" + document + "}",
                OperationName = "MutationStartExportAwsNativeEbsVolumeSnapshotJob",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncJobStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncJobStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (System.String)psObject.BaseObject;
                } else {
                    fields = (System.String)this.Field;
                }
            }
            string document = Mutation.ExcludeAwsNativeEbsVolumesFromSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.ExcludeAwsNativeEbsVolumesFromSnapshot");
            string parameters = "($input: ExcludeAwsNativeEbsVolumesFromSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationExcludeAwsNativeEbsVolumesFromSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationExcludeAwsNativeEbsVolumesFromSnapshot",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<System.String> task = this._rbkClient.InvokeGenericCallAsync<System.String>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (BatchAsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (BatchAsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.StartAwsNativeRdsInstanceSnapshotsJob(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.StartAwsNativeRdsInstanceSnapshotsJob");
            string parameters = "($input: StartAwsNativeRdsInstanceSnapshotsJobInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationStartAwsNativeRdsInstanceSnapshotsJob" + parameters + "{" + document + "}",
                OperationName = "MutationStartAwsNativeRdsInstanceSnapshotsJob",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<BatchAsyncJobStatus> task = this._rbkClient.InvokeGenericCallAsync<BatchAsyncJobStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (CloudAccount)psObject.BaseObject;
                } else {
                    fields = (CloudAccount)this.Field;
                }
            }
            string document = Mutation.CreateAwsAccount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateAwsAccount");
            string parameters = "($input: CreateAwsAccountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateAwsAccount" + parameters + "{" + document + "}",
                OperationName = "MutationCreateAwsAccount",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<CloudAccount> task = this._rbkClient.InvokeGenericCallAsync<CloudAccount>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (CloudAccount)psObject.BaseObject;
                } else {
                    fields = (CloudAccount)this.Field;
                }
            }
            string document = Mutation.UpdateAwsAccount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateAwsAccount");
            string parameters = "($input: UpdateAwsAccountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateAwsAccount" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateAwsAccount",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<CloudAccount> task = this._rbkClient.InvokeGenericCallAsync<CloudAccount>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (TargetMapping)psObject.BaseObject;
                } else {
                    fields = (TargetMapping)this.Field;
                }
            }
            string document = Mutation.CreateAutomaticAwsTargetMapping(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateAutomaticAwsTargetMapping");
            string parameters = "($input: CreateAutomaticAwsTargetMappingInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateAutomaticAwsTargetMapping" + parameters + "{" + document + "}",
                OperationName = "MutationCreateAutomaticAwsTargetMapping",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<TargetMapping> task = this._rbkClient.InvokeGenericCallAsync<TargetMapping>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (CreateCloudNativeAwsStorageSettingReply)psObject.BaseObject;
                } else {
                    fields = (CreateCloudNativeAwsStorageSettingReply)this.Field;
                }
            }
            string document = Mutation.CreateCloudNativeAwsStorageSetting(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateCloudNativeAwsStorageSetting");
            string parameters = "($input: CreateCloudNativeAwsStorageSettingInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateCloudNativeAwsStorageSetting" + parameters + "{" + document + "}",
                OperationName = "MutationCreateCloudNativeAwsStorageSetting",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<CreateCloudNativeAwsStorageSettingReply> task = this._rbkClient.InvokeGenericCallAsync<CreateCloudNativeAwsStorageSettingReply>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (TargetMapping)psObject.BaseObject;
                } else {
                    fields = (TargetMapping)this.Field;
                }
            }
            string document = Mutation.UpdateAutomaticAwsTargetMapping(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateAutomaticAwsTargetMapping");
            string parameters = "($input: UpdateAutomaticAwsTargetMappingInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateAutomaticAwsTargetMapping" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateAutomaticAwsTargetMapping",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<TargetMapping> task = this._rbkClient.InvokeGenericCallAsync<TargetMapping>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (UpdateCloudNativeAwsStorageSettingReply)psObject.BaseObject;
                } else {
                    fields = (UpdateCloudNativeAwsStorageSettingReply)this.Field;
                }
            }
            string document = Mutation.UpdateCloudNativeAwsStorageSetting(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateCloudNativeAwsStorageSetting");
            string parameters = "($input: UpdateCloudNativeAwsStorageSettingInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateCloudNativeAwsStorageSetting" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateCloudNativeAwsStorageSetting",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<UpdateCloudNativeAwsStorageSettingReply> task = this._rbkClient.InvokeGenericCallAsync<UpdateCloudNativeAwsStorageSettingReply>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (Target)psObject.BaseObject;
                } else {
                    fields = (Target)this.Field;
                }
            }
            string document = Mutation.CreateAwsTarget(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateAwsTarget");
            string parameters = "($input: CreateAwsTargetInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateAwsTarget" + parameters + "{" + document + "}",
                OperationName = "MutationCreateAwsTarget",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<Target> task = this._rbkClient.InvokeGenericCallAsync<Target>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (Target)psObject.BaseObject;
                } else {
                    fields = (Target)this.Field;
                }
            }
            string document = Mutation.UpdateAwsTarget(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateAwsTarget");
            string parameters = "($input: UpdateAwsTargetInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateAwsTarget" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateAwsTarget",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<Target> task = this._rbkClient.InvokeGenericCallAsync<Target>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (Target)psObject.BaseObject;
                } else {
                    fields = (Target)this.Field;
                }
            }
            string document = Mutation.CreateAwsReaderTarget(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateAwsReaderTarget");
            string parameters = "($input: CreateAwsReaderTargetInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateAwsReaderTarget" + parameters + "{" + document + "}",
                OperationName = "MutationCreateAwsReaderTarget",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<Target> task = this._rbkClient.InvokeGenericCallAsync<Target>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AwsComputeSettings)psObject.BaseObject;
                } else {
                    fields = (AwsComputeSettings)this.Field;
                }
            }
            string document = Mutation.CreateAwsComputeSetting(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateAwsComputeSetting");
            string parameters = "($input: CreateAwsComputeSettingInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateAwsComputeSetting" + parameters + "{" + document + "}",
                OperationName = "MutationCreateAwsComputeSetting",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AwsComputeSettings> task = this._rbkClient.InvokeGenericCallAsync<AwsComputeSettings>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AwsComputeSettings)psObject.BaseObject;
                } else {
                    fields = (AwsComputeSettings)this.Field;
                }
            }
            string document = Mutation.UpdateAwsComputeSetting(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateAwsComputeSetting");
            string parameters = "($input: UpdateAwsComputeSettingInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateAwsComputeSetting" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateAwsComputeSetting",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AwsComputeSettings> task = this._rbkClient.InvokeGenericCallAsync<AwsComputeSettings>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (System.String)psObject.BaseObject;
                } else {
                    fields = (System.String)this.Field;
                }
            }
            string document = Mutation.DeleteAwsComputeSetting(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteAwsComputeSetting");
            string parameters = "($input: DeleteAwsComputeSettingInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteAwsComputeSetting" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteAwsComputeSetting",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<System.String> task = this._rbkClient.InvokeGenericCallAsync<System.String>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (ValidateAndCreateAwsCloudAccountReply)psObject.BaseObject;
                } else {
                    fields = (ValidateAndCreateAwsCloudAccountReply)this.Field;
                }
            }
            string document = Mutation.ValidateAndCreateAwsCloudAccount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.ValidateAndCreateAwsCloudAccount");
            string parameters = "($input: ValidateAndCreateAwsCloudAccountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationValidateAndCreateAwsCloudAccount" + parameters + "{" + document + "}",
                OperationName = "MutationValidateAndCreateAwsCloudAccount",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<ValidateAndCreateAwsCloudAccountReply> task = this._rbkClient.InvokeGenericCallAsync<ValidateAndCreateAwsCloudAccountReply>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (FinalizeAwsCloudAccountProtectionReply)psObject.BaseObject;
                } else {
                    fields = (FinalizeAwsCloudAccountProtectionReply)this.Field;
                }
            }
            string document = Mutation.FinalizeAwsCloudAccountProtection(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.FinalizeAwsCloudAccountProtection");
            string parameters = "($input: FinalizeAwsCloudAccountProtectionInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationFinalizeAwsCloudAccountProtection" + parameters + "{" + document + "}",
                OperationName = "MutationFinalizeAwsCloudAccountProtection",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<FinalizeAwsCloudAccountProtectionReply> task = this._rbkClient.InvokeGenericCallAsync<FinalizeAwsCloudAccountProtectionReply>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (PrepareAwsCloudAccountDeletionReply)psObject.BaseObject;
                } else {
                    fields = (PrepareAwsCloudAccountDeletionReply)this.Field;
                }
            }
            string document = Mutation.PrepareAwsCloudAccountDeletion(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.PrepareAwsCloudAccountDeletion");
            string parameters = "($input: PrepareAwsCloudAccountDeletionInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationPrepareAwsCloudAccountDeletion" + parameters + "{" + document + "}",
                OperationName = "MutationPrepareAwsCloudAccountDeletion",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<PrepareAwsCloudAccountDeletionReply> task = this._rbkClient.InvokeGenericCallAsync<PrepareAwsCloudAccountDeletionReply>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (FinalizeAwsCloudAccountDeletionReply)psObject.BaseObject;
                } else {
                    fields = (FinalizeAwsCloudAccountDeletionReply)this.Field;
                }
            }
            string document = Mutation.FinalizeAwsCloudAccountDeletion(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.FinalizeAwsCloudAccountDeletion");
            string parameters = "($input: FinalizeAwsCloudAccountDeletionInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationFinalizeAwsCloudAccountDeletion" + parameters + "{" + document + "}",
                OperationName = "MutationFinalizeAwsCloudAccountDeletion",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<FinalizeAwsCloudAccountDeletionReply> task = this._rbkClient.InvokeGenericCallAsync<FinalizeAwsCloudAccountDeletionReply>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (UpdateAwsCloudAccountFeatureReply)psObject.BaseObject;
                } else {
                    fields = (UpdateAwsCloudAccountFeatureReply)this.Field;
                }
            }
            string document = Mutation.UpdateAwsCloudAccountFeature(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateAwsCloudAccountFeature");
            string parameters = "($input: UpdateAwsCloudAccountFeatureInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateAwsCloudAccountFeature" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateAwsCloudAccountFeature",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<UpdateAwsCloudAccountFeatureReply> task = this._rbkClient.InvokeGenericCallAsync<UpdateAwsCloudAccountFeatureReply>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (System.String)psObject.BaseObject;
                } else {
                    fields = (System.String)this.Field;
                }
            }
            string document = Mutation.UpdateAwsCloudAccount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateAwsCloudAccount");
            string parameters = "($input: UpdateAwsCloudAccountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateAwsCloudAccount" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateAwsCloudAccount",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<System.String> task = this._rbkClient.InvokeGenericCallAsync<System.String>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (PrepareFeatureUpdateForAwsCloudAccountReply)psObject.BaseObject;
                } else {
                    fields = (PrepareFeatureUpdateForAwsCloudAccountReply)this.Field;
                }
            }
            string document = Mutation.PrepareFeatureUpdateForAwsCloudAccount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.PrepareFeatureUpdateForAwsCloudAccount");
            string parameters = "($input: PrepareFeatureUpdateForAwsCloudAccountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationPrepareFeatureUpdateForAwsCloudAccount" + parameters + "{" + document + "}",
                OperationName = "MutationPrepareFeatureUpdateForAwsCloudAccount",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<PrepareFeatureUpdateForAwsCloudAccountReply> task = this._rbkClient.InvokeGenericCallAsync<PrepareFeatureUpdateForAwsCloudAccountReply>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (CreateAwsExocomputeConfigsReply)psObject.BaseObject;
                } else {
                    fields = (CreateAwsExocomputeConfigsReply)this.Field;
                }
            }
            string document = Mutation.CreateAwsExocomputeConfigs(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateAwsExocomputeConfigs");
            string parameters = "($input: CreateAwsExocomputeConfigsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateAwsExocomputeConfigs" + parameters + "{" + document + "}",
                OperationName = "MutationCreateAwsExocomputeConfigs",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<CreateAwsExocomputeConfigsReply> task = this._rbkClient.InvokeGenericCallAsync<CreateAwsExocomputeConfigsReply>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (DeleteAwsExocomputeConfigsReply)psObject.BaseObject;
                } else {
                    fields = (DeleteAwsExocomputeConfigsReply)this.Field;
                }
            }
            string document = Mutation.DeleteAwsExocomputeConfigs(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteAwsExocomputeConfigs");
            string parameters = "($input: DeleteAwsExocomputeConfigsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteAwsExocomputeConfigs" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteAwsExocomputeConfigs",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<DeleteAwsExocomputeConfigsReply> task = this._rbkClient.InvokeGenericCallAsync<DeleteAwsExocomputeConfigsReply>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.StartAwsExocomputeDisableJob(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.StartAwsExocomputeDisableJob");
            string parameters = "($input: StartAwsExocomputeDisableJobInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationStartAwsExocomputeDisableJob" + parameters + "{" + document + "}",
                OperationName = "MutationStartAwsExocomputeDisableJob",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncJobStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncJobStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AddAwsIamUserBasedCloudAccountReply)psObject.BaseObject;
                } else {
                    fields = (AddAwsIamUserBasedCloudAccountReply)this.Field;
                }
            }
            string document = Mutation.AddAwsIamUserBasedCloudAccount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.AddAwsIamUserBasedCloudAccount");
            string parameters = "($input: AddAwsIamUserBasedCloudAccountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationAddAwsIamUserBasedCloudAccount" + parameters + "{" + document + "}",
                OperationName = "MutationAddAwsIamUserBasedCloudAccount",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AddAwsIamUserBasedCloudAccountReply> task = this._rbkClient.InvokeGenericCallAsync<AddAwsIamUserBasedCloudAccountReply>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (System.Boolean)psObject.BaseObject;
                } else {
                    fields = (System.Boolean)this.Field;
                }
            }
            string document = Mutation.UpgradeAwsIamUserBasedCloudAccountPermissions(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpgradeAwsIamUserBasedCloudAccountPermissions");
            string parameters = "($input: UpgradeAwsIamUserBasedCloudAccountPermissionsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpgradeAwsIamUserBasedCloudAccountPermissions" + parameters + "{" + document + "}",
                OperationName = "MutationUpgradeAwsIamUserBasedCloudAccountPermissions",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<System.Boolean> task = this._rbkClient.InvokeGenericCallAsync<System.Boolean>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (System.Boolean)psObject.BaseObject;
                } else {
                    fields = (System.Boolean)this.Field;
                }
            }
            string document = Mutation.UpgradeAwsCloudAccountFeaturesWithoutCft(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpgradeAwsCloudAccountFeaturesWithoutCft");
            string parameters = "($input: UpgradeAwsCloudAccountFeaturesWithoutCftInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpgradeAwsCloudAccountFeaturesWithoutCft" + parameters + "{" + document + "}",
                OperationName = "MutationUpgradeAwsCloudAccountFeaturesWithoutCft",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<System.Boolean> task = this._rbkClient.InvokeGenericCallAsync<System.Boolean>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AddAwsAuthenticationServerBasedCloudAccountReply)psObject.BaseObject;
                } else {
                    fields = (AddAwsAuthenticationServerBasedCloudAccountReply)this.Field;
                }
            }
            string document = Mutation.AddAwsAuthenticationServerBasedCloudAccount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.AddAwsAuthenticationServerBasedCloudAccount");
            string parameters = "($input: AddAwsAuthenticationServerBasedCloudAccountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationAddAwsAuthenticationServerBasedCloudAccount" + parameters + "{" + document + "}",
                OperationName = "MutationAddAwsAuthenticationServerBasedCloudAccount",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AddAwsAuthenticationServerBasedCloudAccountReply> task = this._rbkClient.InvokeGenericCallAsync<AddAwsAuthenticationServerBasedCloudAccountReply>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (System.Boolean)psObject.BaseObject;
                } else {
                    fields = (System.Boolean)this.Field;
                }
            }
            string document = Mutation.PatchAwsAuthenticationServerBasedCloudAccount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.PatchAwsAuthenticationServerBasedCloudAccount");
            string parameters = "($input: PatchAwsAuthenticationServerBasedCloudAccountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationPatchAwsAuthenticationServerBasedCloudAccount" + parameters + "{" + document + "}",
                OperationName = "MutationPatchAwsAuthenticationServerBasedCloudAccount",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<System.Boolean> task = this._rbkClient.InvokeGenericCallAsync<System.Boolean>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (System.Boolean)psObject.BaseObject;
                } else {
                    fields = (System.Boolean)this.Field;
                }
            }
            string document = Mutation.PatchAwsIamUserBasedCloudAccount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.PatchAwsIamUserBasedCloudAccount");
            string parameters = "($input: PatchAwsIamUserBasedCloudAccountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationPatchAwsIamUserBasedCloudAccount" + parameters + "{" + document + "}",
                OperationName = "MutationPatchAwsIamUserBasedCloudAccount",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<System.Boolean> task = this._rbkClient.InvokeGenericCallAsync<System.Boolean>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (CcProvisionJobReply)psObject.BaseObject;
                } else {
                    fields = (CcProvisionJobReply)this.Field;
                }
            }
            string document = Mutation.CreateAwsCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateAwsCluster");
            string parameters = "($input: CreateAwsClusterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateAwsCluster" + parameters + "{" + document + "}",
                OperationName = "MutationCreateAwsCluster",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<CcProvisionJobReply> task = this._rbkClient.InvokeGenericCallAsync<CcProvisionJobReply>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (CcProvisionJobReply)psObject.BaseObject;
                } else {
                    fields = (CcProvisionJobReply)this.Field;
                }
            }
            string document = Mutation.DeleteAwsCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteAwsCluster");
            string parameters = "($input: DeleteAwsClusterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteAwsCluster" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteAwsCluster",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<CcProvisionJobReply> task = this._rbkClient.InvokeGenericCallAsync<CcProvisionJobReply>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }


    } // class Mutate_RscAws
}