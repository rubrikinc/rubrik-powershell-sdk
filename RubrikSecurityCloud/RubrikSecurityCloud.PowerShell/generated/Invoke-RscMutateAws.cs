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
        DefaultParameterSetName = "Createtarget")
    ]
    public class Invoke_RscMutateAws : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // Startnativeec2instancesnapshotsjob parameter set
        //
        // [GraphQL: startAwsNativeEc2InstanceSnapshotsJob]
        //
        [Parameter(
            ParameterSetName = "Startnativeec2instancesnapshotsjob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Start an on demand create snapshot job for AWS EC2 Instances.When completed, this will start taking an on-demand snapshot of the selected EC2 Instances  as per the SLA Policy assigned to the respective instances.
[GraphQL: startAwsNativeEc2InstanceSnapshotsJob]",
            Position = 0
        )]
        public SwitchParameter Startnativeec2instancesnapshotsjob { get; set; }

        [Parameter(
            ParameterSetName = "Startnativeec2instancesnapshotsjob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Input for create AWS EC2 Instance snapshots job.
GraphQL argument input: StartAwsNativeEc2InstanceSnapshotsJobInput!"
        )]
        public StartAwsNativeEc2InstanceSnapshotsJobInput? Input { get; set; }
        
        // -------------------------------------------------------------------
        // Startrestorenativeec2instancesnapshotjob parameter set
        //
        // [GraphQL: startRestoreAwsNativeEc2InstanceSnapshotJob]
        //
        [Parameter(
            ParameterSetName = "Startrestorenativeec2instancesnapshotjob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Start an on demand restore snapshot job for AWS EC2 Instance. When completed, this will replace the original EC2 Instance with the selected snapshot.
[GraphQL: startRestoreAwsNativeEc2InstanceSnapshotJob]",
            Position = 0
        )]
        public SwitchParameter Startrestorenativeec2instancesnapshotjob { get; set; }

        
        // -------------------------------------------------------------------
        // Startrefreshnativeaccountsjob parameter set
        //
        // [GraphQL: startRefreshAwsNativeAccountsJob]
        //
        [Parameter(
            ParameterSetName = "Startrefreshnativeaccountsjob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Start an on demand job to refresh AWS accounts. The job updates the Rubrik platform with changes to the AWS Native accounts.
[GraphQL: startRefreshAwsNativeAccountsJob]",
            Position = 0
        )]
        public SwitchParameter Startrefreshnativeaccountsjob { get; set; }

        
        // -------------------------------------------------------------------
        // Startcreatenativeebsvolumesnapshotsjob parameter set
        //
        // [GraphQL: startCreateAwsNativeEbsVolumeSnapshotsJob]
        //
        [Parameter(
            ParameterSetName = "Startcreatenativeebsvolumesnapshotsjob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Start job to create snapshots of EBS Volumes with given IDs. When completed, this will start taking an on-demand snapshot of the selected EBS Volumes  as per the SLA Policy assigned to the respective volumes.
[GraphQL: startCreateAwsNativeEbsVolumeSnapshotsJob]",
            Position = 0
        )]
        public SwitchParameter Startcreatenativeebsvolumesnapshotsjob { get; set; }

        
        // -------------------------------------------------------------------
        // Startnativeaccountdisablejob parameter set
        //
        // [GraphQL: startAwsNativeAccountDisableJob]
        //
        [Parameter(
            ParameterSetName = "Startnativeaccountdisablejob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Starts a job to disable a specific AWS Native account. When complete, the job will disable protection for the specified AWS Native account.
[GraphQL: startAwsNativeAccountDisableJob]",
            Position = 0
        )]
        public SwitchParameter Startnativeaccountdisablejob { get; set; }

        
        // -------------------------------------------------------------------
        // Startexportnativeebsvolumesnapshotjob parameter set
        //
        // [GraphQL: startExportAwsNativeEbsVolumeSnapshotJob]
        //
        [Parameter(
            ParameterSetName = "Startexportnativeebsvolumesnapshotjob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Start a job to export EBS Volume. The job creates a new EBS Volume with the same properties as that of the snapshot that is exported.
[GraphQL: startExportAwsNativeEbsVolumeSnapshotJob]",
            Position = 0
        )]
        public SwitchParameter Startexportnativeebsvolumesnapshotjob { get; set; }

        
        // -------------------------------------------------------------------
        // Excludenativeebsvolumesfromsnapshot parameter set
        //
        // [GraphQL: excludeAwsNativeEbsVolumesFromSnapshot]
        //
        [Parameter(
            ParameterSetName = "Excludenativeebsvolumesfromsnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Mark AWS Native EBS Volumes to be excluded from EC2 Instance snapshot. By default, all EBS Volumes are marked as included.
[GraphQL: excludeAwsNativeEbsVolumesFromSnapshot]",
            Position = 0
        )]
        public SwitchParameter Excludenativeebsvolumesfromsnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // Startnativerdsinstancesnapshotsjob parameter set
        //
        // [GraphQL: startAwsNativeRdsInstanceSnapshotsJob]
        //
        [Parameter(
            ParameterSetName = "Startnativerdsinstancesnapshotsjob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Start job to create snapshots of RDS Instance with given IDs. When completed, this will start taking an on-demand snapshot of the selected RDS Instances  as per the SLA Policy assigned to the respective instances.
[GraphQL: startAwsNativeRdsInstanceSnapshotsJob]",
            Position = 0
        )]
        public SwitchParameter Startnativerdsinstancesnapshotsjob { get; set; }

        
        // -------------------------------------------------------------------
        // Createaccount parameter set
        //
        // [GraphQL: createAwsAccount]
        //
        [Parameter(
            ParameterSetName = "Createaccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: createAwsAccount]",
            Position = 0
        )]
        public SwitchParameter Createaccount { get; set; }

        
        // -------------------------------------------------------------------
        // Updateaccount parameter set
        //
        // [GraphQL: updateAwsAccount]
        //
        [Parameter(
            ParameterSetName = "Updateaccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: updateAwsAccount]",
            Position = 0
        )]
        public SwitchParameter Updateaccount { get; set; }

        
        // -------------------------------------------------------------------
        // Createautomatictargetmapping parameter set
        //
        // [GraphQL: createAutomaticAwsTargetMapping]
        //
        [Parameter(
            ParameterSetName = "Createautomatictargetmapping",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: createAutomaticAwsTargetMapping]",
            Position = 0
        )]
        public SwitchParameter Createautomatictargetmapping { get; set; }

        
        // -------------------------------------------------------------------
        // Createcloudnativestoragesetting parameter set
        //
        // [GraphQL: createCloudNativeAwsStorageSetting]
        //
        [Parameter(
            ParameterSetName = "Createcloudnativestoragesetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: createCloudNativeAwsStorageSetting]",
            Position = 0
        )]
        public SwitchParameter Createcloudnativestoragesetting { get; set; }

        
        // -------------------------------------------------------------------
        // Updateautomatictargetmapping parameter set
        //
        // [GraphQL: updateAutomaticAwsTargetMapping]
        //
        [Parameter(
            ParameterSetName = "Updateautomatictargetmapping",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: updateAutomaticAwsTargetMapping]",
            Position = 0
        )]
        public SwitchParameter Updateautomatictargetmapping { get; set; }

        
        // -------------------------------------------------------------------
        // Updatecloudnativestoragesetting parameter set
        //
        // [GraphQL: updateCloudNativeAwsStorageSetting]
        //
        [Parameter(
            ParameterSetName = "Updatecloudnativestoragesetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: updateCloudNativeAwsStorageSetting]",
            Position = 0
        )]
        public SwitchParameter Updatecloudnativestoragesetting { get; set; }

        
        // -------------------------------------------------------------------
        // Createtarget parameter set
        //
        // [GraphQL: createAwsTarget]
        //
        [Parameter(
            ParameterSetName = "Createtarget",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: createAwsTarget]",
            Position = 0
        )]
        public SwitchParameter Createtarget { get; set; }

        
        // -------------------------------------------------------------------
        // Updatetarget parameter set
        //
        // [GraphQL: updateAwsTarget]
        //
        [Parameter(
            ParameterSetName = "Updatetarget",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: updateAwsTarget]",
            Position = 0
        )]
        public SwitchParameter Updatetarget { get; set; }

        
        // -------------------------------------------------------------------
        // Createreadertarget parameter set
        //
        // [GraphQL: createAwsReaderTarget]
        //
        [Parameter(
            ParameterSetName = "Createreadertarget",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a reader type for AWS archival location on a Rubrik cluster.
[GraphQL: createAwsReaderTarget]",
            Position = 0
        )]
        public SwitchParameter Createreadertarget { get; set; }

        
        // -------------------------------------------------------------------
        // Createcomputesetting parameter set
        //
        // [GraphQL: createAwsComputeSetting]
        //
        [Parameter(
            ParameterSetName = "Createcomputesetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: createAwsComputeSetting]",
            Position = 0
        )]
        public SwitchParameter Createcomputesetting { get; set; }

        
        // -------------------------------------------------------------------
        // Updatecomputesetting parameter set
        //
        // [GraphQL: updateAwsComputeSetting]
        //
        [Parameter(
            ParameterSetName = "Updatecomputesetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: updateAwsComputeSetting]",
            Position = 0
        )]
        public SwitchParameter Updatecomputesetting { get; set; }

        
        // -------------------------------------------------------------------
        // Deletecomputesetting parameter set
        //
        // [GraphQL: deleteAwsComputeSetting]
        //
        [Parameter(
            ParameterSetName = "Deletecomputesetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: deleteAwsComputeSetting]",
            Position = 0
        )]
        public SwitchParameter Deletecomputesetting { get; set; }

        
        // -------------------------------------------------------------------
        // Cloudaccountvalidate parameter set
        //
        // [GraphQL: awsCloudAccountValidate]
        //
        [Parameter(
            ParameterSetName = "Cloudaccountvalidate",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"This endpoint is deprecated.
[GraphQL: awsCloudAccountValidate]",
            Position = 0
        )]
        public SwitchParameter Cloudaccountvalidate { get; set; }

        [Parameter(
            ParameterSetName = "Cloudaccountvalidate",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Arguments for validate aws cloud accounts.
GraphQL argument awsCloudAccountValidateArg: AwsCloudAccountValidateInput!"
        )]
        public AwsCloudAccountValidateInput? AwsCloudAccountValidateArg { get; set; }
        
        // -------------------------------------------------------------------
        // Cloudaccountinitiate parameter set
        //
        // [GraphQL: awsCloudAccountInitiate]
        //
        [Parameter(
            ParameterSetName = "Cloudaccountinitiate",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"This endpoint is deprecated.
[GraphQL: awsCloudAccountInitiate]",
            Position = 0
        )]
        public SwitchParameter Cloudaccountinitiate { get; set; }

        [Parameter(
            ParameterSetName = "Cloudaccountinitiate",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Arguments for initiate aws cloud accounts for creation.
GraphQL argument awsCloudAccountInitiateArg: AwsCloudAccountInitiateInput!"
        )]
        public AwsCloudAccountInitiateInput? AwsCloudAccountInitiateArg { get; set; }
        
        // -------------------------------------------------------------------
        // Nativeprotectionaccountadd parameter set
        //
        // [GraphQL: awsNativeProtectionAccountAdd]
        //
        [Parameter(
            ParameterSetName = "Nativeprotectionaccountadd",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"This endpoint is deprecated.
[GraphQL: awsNativeProtectionAccountAdd]",
            Position = 0
        )]
        public SwitchParameter Nativeprotectionaccountadd { get; set; }

        [Parameter(
            ParameterSetName = "Nativeprotectionaccountadd",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Arguments to add account for native protection.
GraphQL argument awsNativeProtectionAccountAddArg: AwsNativeProtectionAccountAddRequest!"
        )]
        public AwsNativeProtectionAccountAddRequest? AwsNativeProtectionAccountAddArg { get; set; }
        
        // -------------------------------------------------------------------
        // Validateandcreatecloudaccount parameter set
        //
        // [GraphQL: validateAndCreateAwsCloudAccount]
        //
        [Parameter(
            ParameterSetName = "Validateandcreatecloudaccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Validate and create AWS cloud account. If validation fails, no error is returned and the cause is present in the ""message"" field of return object or within admin/child accounts of return object. In case validation succeeds, it initiates creation of AWS cloud account. This is the first step to set up native protection.
[GraphQL: validateAndCreateAwsCloudAccount]",
            Position = 0
        )]
        public SwitchParameter Validateandcreatecloudaccount { get; set; }

        
        // -------------------------------------------------------------------
        // Finalizecloudaccountprotection parameter set
        //
        // [GraphQL: finalizeAwsCloudAccountProtection]
        //
        [Parameter(
            ParameterSetName = "Finalizecloudaccountprotection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Process cloud account. This is the second step after validate and create in addition of a feature for cloud account.The CloudFormation stack should be created after this step using the CloudFormation URL provided in the first step.
[GraphQL: finalizeAwsCloudAccountProtection]",
            Position = 0
        )]
        public SwitchParameter Finalizecloudaccountprotection { get; set; }

        
        // -------------------------------------------------------------------
        // Preparecloudaccountdeletion parameter set
        //
        // [GraphQL: prepareAwsCloudAccountDeletion]
        //
        [Parameter(
            ParameterSetName = "Preparecloudaccountdeletion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Prepare deletion of cloud account. This is the first step to delete AWS cloud account. It generated template for deletion of cloud account and does not change any state of account.
[GraphQL: prepareAwsCloudAccountDeletion]",
            Position = 0
        )]
        public SwitchParameter Preparecloudaccountdeletion { get; set; }

        
        // -------------------------------------------------------------------
        // Finalizecloudaccountdeletion parameter set
        //
        // [GraphQL: finalizeAwsCloudAccountDeletion]
        //
        [Parameter(
            ParameterSetName = "Finalizecloudaccountdeletion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Process and finalize deletion of cloud account is the last step in deletion of a feature from cloud account. This endpoint is a MUST for deletion of disconnected features.
[GraphQL: finalizeAwsCloudAccountDeletion]",
            Position = 0
        )]
        public SwitchParameter Finalizecloudaccountdeletion { get; set; }

        
        // -------------------------------------------------------------------
        // Updatecloudaccountfeature parameter set
        //
        // [GraphQL: updateAwsCloudAccountFeature]
        //
        [Parameter(
            ParameterSetName = "Updatecloudaccountfeature",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Updates regions, stack ARN, and role ARN for a feature for a given cloud account.
[GraphQL: updateAwsCloudAccountFeature]",
            Position = 0
        )]
        public SwitchParameter Updatecloudaccountfeature { get; set; }

        
        // -------------------------------------------------------------------
        // Updatecloudaccount parameter set
        //
        // [GraphQL: updateAwsCloudAccount]
        //
        [Parameter(
            ParameterSetName = "Updatecloudaccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update properties for a given AWS cloud account.
[GraphQL: updateAwsCloudAccount]",
            Position = 0
        )]
        public SwitchParameter Updatecloudaccount { get; set; }

        
        // -------------------------------------------------------------------
        // Preparefeatureupdateforcloudaccount parameter set
        //
        // [GraphQL: prepareFeatureUpdateForAwsCloudAccount]
        //
        [Parameter(
            ParameterSetName = "Preparefeatureupdateforcloudaccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Prepare manual update features to latest version.
[GraphQL: prepareFeatureUpdateForAwsCloudAccount]",
            Position = 0
        )]
        public SwitchParameter Preparefeatureupdateforcloudaccount { get; set; }

        
        // -------------------------------------------------------------------
        // Cloudaccountupdatefeature parameter set
        //
        // [GraphQL: awsCloudAccountUpdateFeature]
        //
        [Parameter(
            ParameterSetName = "Cloudaccountupdatefeature",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"This endpoint is deprecated.
[GraphQL: awsCloudAccountUpdateFeature]",
            Position = 0
        )]
        public SwitchParameter Cloudaccountupdatefeature { get; set; }

        [Parameter(
            ParameterSetName = "Cloudaccountupdatefeature",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"The ID of the cloud account.
GraphQL argument cloudAccountUuid: UUID!"
        )]
        public System.String? CloudAccountUuid { get; set; }
        [Parameter(
            ParameterSetName = "Cloudaccountupdatefeature",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Cloud Account Features.
GraphQL argument features: [CloudAccountFeature!]!"
        )]
        public List<CloudAccountFeature>? Features { get; set; }
        
        // -------------------------------------------------------------------
        // Createexocomputeconfig parameter set
        //
        // [GraphQL: createAwsExocomputeConfigs]
        //
        [Parameter(
            ParameterSetName = "Createexocomputeconfig",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create AWS Exocompute configs.
[GraphQL: createAwsExocomputeConfigs]",
            Position = 0
        )]
        public SwitchParameter Createexocomputeconfig { get; set; }

        
        // -------------------------------------------------------------------
        // Deleteexocomputeconfig parameter set
        //
        // [GraphQL: deleteAwsExocomputeConfigs]
        //
        [Parameter(
            ParameterSetName = "Deleteexocomputeconfig",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Deletes AWS Exocompute configs.
[GraphQL: deleteAwsExocomputeConfigs]",
            Position = 0
        )]
        public SwitchParameter Deleteexocomputeconfig { get; set; }

        
        // -------------------------------------------------------------------
        // Updateexocomputeconfig parameter set
        //
        // [GraphQL: updateAwsExocomputeConfigs]
        //
        [Parameter(
            ParameterSetName = "Updateexocomputeconfig",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update AWS Exocompute configs.
[GraphQL: updateAwsExocomputeConfigs]",
            Position = 0
        )]
        public SwitchParameter Updateexocomputeconfig { get; set; }

        
        // -------------------------------------------------------------------
        // Startexocomputedisablejob parameter set
        //
        // [GraphQL: startAwsExocomputeDisableJob]
        //
        [Parameter(
            ParameterSetName = "Startexocomputedisablejob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Starts a job to disable AWS Exocompute feature. When complete, the job will disable exocompute feature for the specified AWS Native account.
[GraphQL: startAwsExocomputeDisableJob]",
            Position = 0
        )]
        public SwitchParameter Startexocomputedisablejob { get; set; }

        
        // -------------------------------------------------------------------
        // Addiamuserbasedcloudaccount parameter set
        //
        // [GraphQL: addAwsIamUserBasedCloudAccount]
        //
        [Parameter(
            ParameterSetName = "Addiamuserbasedcloudaccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Adds an IAM user-based AWS cloud account and enables the features specified in the input after successful validation of the request.
[GraphQL: addAwsIamUserBasedCloudAccount]",
            Position = 0
        )]
        public SwitchParameter Addiamuserbasedcloudaccount { get; set; }

        
        // -------------------------------------------------------------------
        // Deleteiamuserbasedcloudaccount parameter set
        //
        // [GraphQL: deleteAwsIamUserBasedCloudAccount]
        //
        [Parameter(
            ParameterSetName = "Deleteiamuserbasedcloudaccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Deletes IAM user-based AWS cloud account.
[GraphQL: deleteAwsIamUserBasedCloudAccount]",
            Position = 0
        )]
        public SwitchParameter Deleteiamuserbasedcloudaccount { get; set; }

        
        // -------------------------------------------------------------------
        // Deletecloudaccountwithoutcft parameter set
        //
        // [GraphQL: deleteAwsCloudAccountWithoutCft]
        //
        [Parameter(
            ParameterSetName = "Deletecloudaccountwithoutcft",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Removes AWS cloud account without cleaning up the associated permissions from the AWS cloud account. Customer needs to clean up the permissions in the AWS account themselves. This mutation is supported only for IAM user-based and authentication server-based AWS cloud accounts.
[GraphQL: deleteAwsCloudAccountWithoutCft]",
            Position = 0
        )]
        public SwitchParameter Deletecloudaccountwithoutcft { get; set; }

        
        // -------------------------------------------------------------------
        // Upgradeiamuserbasedcloudaccountpermission parameter set
        //
        // [GraphQL: upgradeAwsIamUserBasedCloudAccountPermissions]
        //
        [Parameter(
            ParameterSetName = "Upgradeiamuserbasedcloudaccountpermission",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Set IAM user-based AWS account features status to Connected from Update Permissions state. It should be used by caution from cloud accounts only after latest required permissions are granted to authorized IAM user.
[GraphQL: upgradeAwsIamUserBasedCloudAccountPermissions]",
            Position = 0
        )]
        public SwitchParameter Upgradeiamuserbasedcloudaccountpermission { get; set; }

        
        // -------------------------------------------------------------------
        // Upgradecloudaccountfeatureswithoutcft parameter set
        //
        // [GraphQL: upgradeAwsCloudAccountFeaturesWithoutCft]
        //
        [Parameter(
            ParameterSetName = "Upgradecloudaccountfeatureswithoutcft",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Updates status of AWS cloud account features to connected if they are in update permissions state. This mutation should be used with caution. It should be invoked only after the latest required permissions are granted to the AWS cloud account user used by Rubrik. This mutation does not verify if the required permissions are actually granted to the user or not. Its usage is restricted to only IAM user-based and authentication server-based AWS cloud accounts.
[GraphQL: upgradeAwsCloudAccountFeaturesWithoutCft]",
            Position = 0
        )]
        public SwitchParameter Upgradecloudaccountfeatureswithoutcft { get; set; }

        
        // -------------------------------------------------------------------
        // Addauthenticationserverbasedcloudaccount parameter set
        //
        // [GraphQL: addAwsAuthenticationServerBasedCloudAccount]
        //
        [Parameter(
            ParameterSetName = "Addauthenticationserverbasedcloudaccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Validates and adds an authentication server-based AWS cloud account. When validation succeeds, the AWS cloud account is added and the features specified in the request are enabled. When validation fails, an error is not returned, but the cause of the failure is specified in the ""message"" field of the response object.
[GraphQL: addAwsAuthenticationServerBasedCloudAccount]",
            Position = 0
        )]
        public SwitchParameter Addauthenticationserverbasedcloudaccount { get; set; }

        
        // -------------------------------------------------------------------
        // Patchauthenticationserverbasedcloudaccount parameter set
        //
        // [GraphQL: patchAwsAuthenticationServerBasedCloudAccount]
        //
        [Parameter(
            ParameterSetName = "Patchauthenticationserverbasedcloudaccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Updates authentication server-based AWS cloud account. Use this mutation to update account details related to role name, certificates, features. The mutation can update one or more certificates associated to an account in a single request. All input fields except account identifier are optional so that any combination of account attributes can be updated in a single call. If none of the optional fields are provided in the input then no updates are performed, and the response does not contain any error message.
[GraphQL: patchAwsAuthenticationServerBasedCloudAccount]",
            Position = 0
        )]
        public SwitchParameter Patchauthenticationserverbasedcloudaccount { get; set; }

        
        // -------------------------------------------------------------------
        // Patchiamuserbasedcloudaccount parameter set
        //
        // [GraphQL: patchAwsIamUserBasedCloudAccount]
        //
        [Parameter(
            ParameterSetName = "Patchiamuserbasedcloudaccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Updates IAM user-based AWS cloud account. Use this mutation to update account details access/secret keys, role ARN and regions. All input fields except account ID are optional so that any combination of account attributes can be updated in a single call. If none of the optional fields are provided in the input then no updates are performed, and the response does not contain any error message.
[GraphQL: patchAwsIamUserBasedCloudAccount]",
            Position = 0
        )]
        public SwitchParameter Patchiamuserbasedcloudaccount { get; set; }

        
        // -------------------------------------------------------------------
        // Createcluster parameter set
        //
        // [GraphQL: createAwsCluster]
        //
        [Parameter(
            ParameterSetName = "Createcluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a Rubrik Cloud Cluster on AWS.
[GraphQL: createAwsCluster]",
            Position = 0
        )]
        public SwitchParameter Createcluster { get; set; }

        
        // -------------------------------------------------------------------
        // Deletecluster parameter set
        //
        // [GraphQL: deleteAwsCluster]
        //
        [Parameter(
            ParameterSetName = "Deletecluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete a Rubrik Cloud Cluster on AWS.
[GraphQL: deleteAwsCluster]",
            Position = 0
        )]
        public SwitchParameter Deletecluster { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "Startnativeec2instancesnapshotsjob":
                        this.ProcessRecord_Startnativeec2instancesnapshotsjob();
                        break;
                    case "Startrestorenativeec2instancesnapshotjob":
                        this.ProcessRecord_Startrestorenativeec2instancesnapshotjob();
                        break;
                    case "Startrefreshnativeaccountsjob":
                        this.ProcessRecord_Startrefreshnativeaccountsjob();
                        break;
                    case "Startcreatenativeebsvolumesnapshotsjob":
                        this.ProcessRecord_Startcreatenativeebsvolumesnapshotsjob();
                        break;
                    case "Startnativeaccountdisablejob":
                        this.ProcessRecord_Startnativeaccountdisablejob();
                        break;
                    case "Startexportnativeebsvolumesnapshotjob":
                        this.ProcessRecord_Startexportnativeebsvolumesnapshotjob();
                        break;
                    case "Excludenativeebsvolumesfromsnapshot":
                        this.ProcessRecord_Excludenativeebsvolumesfromsnapshot();
                        break;
                    case "Startnativerdsinstancesnapshotsjob":
                        this.ProcessRecord_Startnativerdsinstancesnapshotsjob();
                        break;
                    case "Createaccount":
                        this.ProcessRecord_Createaccount();
                        break;
                    case "Updateaccount":
                        this.ProcessRecord_Updateaccount();
                        break;
                    case "Createautomatictargetmapping":
                        this.ProcessRecord_Createautomatictargetmapping();
                        break;
                    case "Createcloudnativestoragesetting":
                        this.ProcessRecord_Createcloudnativestoragesetting();
                        break;
                    case "Updateautomatictargetmapping":
                        this.ProcessRecord_Updateautomatictargetmapping();
                        break;
                    case "Updatecloudnativestoragesetting":
                        this.ProcessRecord_Updatecloudnativestoragesetting();
                        break;
                    case "Createtarget":
                        this.ProcessRecord_Createtarget();
                        break;
                    case "Updatetarget":
                        this.ProcessRecord_Updatetarget();
                        break;
                    case "Createreadertarget":
                        this.ProcessRecord_Createreadertarget();
                        break;
                    case "Createcomputesetting":
                        this.ProcessRecord_Createcomputesetting();
                        break;
                    case "Updatecomputesetting":
                        this.ProcessRecord_Updatecomputesetting();
                        break;
                    case "Deletecomputesetting":
                        this.ProcessRecord_Deletecomputesetting();
                        break;
                    case "Cloudaccountvalidate":
                        this.ProcessRecord_Cloudaccountvalidate();
                        break;
                    case "Cloudaccountinitiate":
                        this.ProcessRecord_Cloudaccountinitiate();
                        break;
                    case "Nativeprotectionaccountadd":
                        this.ProcessRecord_Nativeprotectionaccountadd();
                        break;
                    case "Validateandcreatecloudaccount":
                        this.ProcessRecord_Validateandcreatecloudaccount();
                        break;
                    case "Finalizecloudaccountprotection":
                        this.ProcessRecord_Finalizecloudaccountprotection();
                        break;
                    case "Preparecloudaccountdeletion":
                        this.ProcessRecord_Preparecloudaccountdeletion();
                        break;
                    case "Finalizecloudaccountdeletion":
                        this.ProcessRecord_Finalizecloudaccountdeletion();
                        break;
                    case "Updatecloudaccountfeature":
                        this.ProcessRecord_Updatecloudaccountfeature();
                        break;
                    case "Updatecloudaccount":
                        this.ProcessRecord_Updatecloudaccount();
                        break;
                    case "Preparefeatureupdateforcloudaccount":
                        this.ProcessRecord_Preparefeatureupdateforcloudaccount();
                        break;
                    case "Cloudaccountupdatefeature":
                        this.ProcessRecord_Cloudaccountupdatefeature();
                        break;
                    case "Createexocomputeconfig":
                        this.ProcessRecord_Createexocomputeconfig();
                        break;
                    case "Deleteexocomputeconfig":
                        this.ProcessRecord_Deleteexocomputeconfig();
                        break;
                    case "Updateexocomputeconfig":
                        this.ProcessRecord_Updateexocomputeconfig();
                        break;
                    case "Startexocomputedisablejob":
                        this.ProcessRecord_Startexocomputedisablejob();
                        break;
                    case "Addiamuserbasedcloudaccount":
                        this.ProcessRecord_Addiamuserbasedcloudaccount();
                        break;
                    case "Deleteiamuserbasedcloudaccount":
                        this.ProcessRecord_Deleteiamuserbasedcloudaccount();
                        break;
                    case "Deletecloudaccountwithoutcft":
                        this.ProcessRecord_Deletecloudaccountwithoutcft();
                        break;
                    case "Upgradeiamuserbasedcloudaccountpermission":
                        this.ProcessRecord_Upgradeiamuserbasedcloudaccountpermission();
                        break;
                    case "Upgradecloudaccountfeatureswithoutcft":
                        this.ProcessRecord_Upgradecloudaccountfeatureswithoutcft();
                        break;
                    case "Addauthenticationserverbasedcloudaccount":
                        this.ProcessRecord_Addauthenticationserverbasedcloudaccount();
                        break;
                    case "Patchauthenticationserverbasedcloudaccount":
                        this.ProcessRecord_Patchauthenticationserverbasedcloudaccount();
                        break;
                    case "Patchiamuserbasedcloudaccount":
                        this.ProcessRecord_Patchiamuserbasedcloudaccount();
                        break;
                    case "Createcluster":
                        this.ProcessRecord_Createcluster();
                        break;
                    case "Deletecluster":
                        this.ProcessRecord_Deletecluster();
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
        protected void ProcessRecord_Startnativeec2instancesnapshotsjob()
        {
            this._logger.name += " -Startnativeec2instancesnapshotsjob";
            // Invoke graphql operation startAwsNativeEc2InstanceSnapshotsJob
            InvokeMutationStartAwsNativeEc2InstanceSnapshotsJob();
        }

        // This parameter set invokes a single graphql operation:
        // startRestoreAwsNativeEc2InstanceSnapshotJob.
        protected void ProcessRecord_Startrestorenativeec2instancesnapshotjob()
        {
            this._logger.name += " -Startrestorenativeec2instancesnapshotjob";
            // Invoke graphql operation startRestoreAwsNativeEc2InstanceSnapshotJob
            InvokeMutationStartRestoreAwsNativeEc2InstanceSnapshotJob();
        }

        // This parameter set invokes a single graphql operation:
        // startRefreshAwsNativeAccountsJob.
        protected void ProcessRecord_Startrefreshnativeaccountsjob()
        {
            this._logger.name += " -Startrefreshnativeaccountsjob";
            // Invoke graphql operation startRefreshAwsNativeAccountsJob
            InvokeMutationStartRefreshAwsNativeAccountsJob();
        }

        // This parameter set invokes a single graphql operation:
        // startCreateAwsNativeEbsVolumeSnapshotsJob.
        protected void ProcessRecord_Startcreatenativeebsvolumesnapshotsjob()
        {
            this._logger.name += " -Startcreatenativeebsvolumesnapshotsjob";
            // Invoke graphql operation startCreateAwsNativeEbsVolumeSnapshotsJob
            InvokeMutationStartCreateAwsNativeEbsVolumeSnapshotsJob();
        }

        // This parameter set invokes a single graphql operation:
        // startAwsNativeAccountDisableJob.
        protected void ProcessRecord_Startnativeaccountdisablejob()
        {
            this._logger.name += " -Startnativeaccountdisablejob";
            // Invoke graphql operation startAwsNativeAccountDisableJob
            InvokeMutationStartAwsNativeAccountDisableJob();
        }

        // This parameter set invokes a single graphql operation:
        // startExportAwsNativeEbsVolumeSnapshotJob.
        protected void ProcessRecord_Startexportnativeebsvolumesnapshotjob()
        {
            this._logger.name += " -Startexportnativeebsvolumesnapshotjob";
            // Invoke graphql operation startExportAwsNativeEbsVolumeSnapshotJob
            InvokeMutationStartExportAwsNativeEbsVolumeSnapshotJob();
        }

        // This parameter set invokes a single graphql operation:
        // excludeAwsNativeEbsVolumesFromSnapshot.
        protected void ProcessRecord_Excludenativeebsvolumesfromsnapshot()
        {
            this._logger.name += " -Excludenativeebsvolumesfromsnapshot";
            // Invoke graphql operation excludeAwsNativeEbsVolumesFromSnapshot
            InvokeMutationExcludeAwsNativeEbsVolumesFromSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // startAwsNativeRdsInstanceSnapshotsJob.
        protected void ProcessRecord_Startnativerdsinstancesnapshotsjob()
        {
            this._logger.name += " -Startnativerdsinstancesnapshotsjob";
            // Invoke graphql operation startAwsNativeRdsInstanceSnapshotsJob
            InvokeMutationStartAwsNativeRdsInstanceSnapshotsJob();
        }

        // This parameter set invokes a single graphql operation:
        // createAwsAccount.
        protected void ProcessRecord_Createaccount()
        {
            this._logger.name += " -Createaccount";
            // Invoke graphql operation createAwsAccount
            InvokeMutationCreateAwsAccount();
        }

        // This parameter set invokes a single graphql operation:
        // updateAwsAccount.
        protected void ProcessRecord_Updateaccount()
        {
            this._logger.name += " -Updateaccount";
            // Invoke graphql operation updateAwsAccount
            InvokeMutationUpdateAwsAccount();
        }

        // This parameter set invokes a single graphql operation:
        // createAutomaticAwsTargetMapping.
        protected void ProcessRecord_Createautomatictargetmapping()
        {
            this._logger.name += " -Createautomatictargetmapping";
            // Invoke graphql operation createAutomaticAwsTargetMapping
            InvokeMutationCreateAutomaticAwsTargetMapping();
        }

        // This parameter set invokes a single graphql operation:
        // createCloudNativeAwsStorageSetting.
        protected void ProcessRecord_Createcloudnativestoragesetting()
        {
            this._logger.name += " -Createcloudnativestoragesetting";
            // Invoke graphql operation createCloudNativeAwsStorageSetting
            InvokeMutationCreateCloudNativeAwsStorageSetting();
        }

        // This parameter set invokes a single graphql operation:
        // updateAutomaticAwsTargetMapping.
        protected void ProcessRecord_Updateautomatictargetmapping()
        {
            this._logger.name += " -Updateautomatictargetmapping";
            // Invoke graphql operation updateAutomaticAwsTargetMapping
            InvokeMutationUpdateAutomaticAwsTargetMapping();
        }

        // This parameter set invokes a single graphql operation:
        // updateCloudNativeAwsStorageSetting.
        protected void ProcessRecord_Updatecloudnativestoragesetting()
        {
            this._logger.name += " -Updatecloudnativestoragesetting";
            // Invoke graphql operation updateCloudNativeAwsStorageSetting
            InvokeMutationUpdateCloudNativeAwsStorageSetting();
        }

        // This parameter set invokes a single graphql operation:
        // createAwsTarget.
        protected void ProcessRecord_Createtarget()
        {
            this._logger.name += " -Createtarget";
            // Invoke graphql operation createAwsTarget
            InvokeMutationCreateAwsTarget();
        }

        // This parameter set invokes a single graphql operation:
        // updateAwsTarget.
        protected void ProcessRecord_Updatetarget()
        {
            this._logger.name += " -Updatetarget";
            // Invoke graphql operation updateAwsTarget
            InvokeMutationUpdateAwsTarget();
        }

        // This parameter set invokes a single graphql operation:
        // createAwsReaderTarget.
        protected void ProcessRecord_Createreadertarget()
        {
            this._logger.name += " -Createreadertarget";
            // Invoke graphql operation createAwsReaderTarget
            InvokeMutationCreateAwsReaderTarget();
        }

        // This parameter set invokes a single graphql operation:
        // createAwsComputeSetting.
        protected void ProcessRecord_Createcomputesetting()
        {
            this._logger.name += " -Createcomputesetting";
            // Invoke graphql operation createAwsComputeSetting
            InvokeMutationCreateAwsComputeSetting();
        }

        // This parameter set invokes a single graphql operation:
        // updateAwsComputeSetting.
        protected void ProcessRecord_Updatecomputesetting()
        {
            this._logger.name += " -Updatecomputesetting";
            // Invoke graphql operation updateAwsComputeSetting
            InvokeMutationUpdateAwsComputeSetting();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAwsComputeSetting.
        protected void ProcessRecord_Deletecomputesetting()
        {
            this._logger.name += " -Deletecomputesetting";
            // Invoke graphql operation deleteAwsComputeSetting
            InvokeMutationDeleteAwsComputeSetting();
        }

        // This parameter set invokes a single graphql operation:
        // awsCloudAccountValidate.
        protected void ProcessRecord_Cloudaccountvalidate()
        {
            this._logger.name += " -Cloudaccountvalidate";
            // Invoke graphql operation awsCloudAccountValidate
            InvokeMutationAwsCloudAccountValidate();
        }

        // This parameter set invokes a single graphql operation:
        // awsCloudAccountInitiate.
        protected void ProcessRecord_Cloudaccountinitiate()
        {
            this._logger.name += " -Cloudaccountinitiate";
            // Invoke graphql operation awsCloudAccountInitiate
            InvokeMutationAwsCloudAccountInitiate();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeProtectionAccountAdd.
        protected void ProcessRecord_Nativeprotectionaccountadd()
        {
            this._logger.name += " -Nativeprotectionaccountadd";
            // Invoke graphql operation awsNativeProtectionAccountAdd
            InvokeMutationAwsNativeProtectionAccountAdd();
        }

        // This parameter set invokes a single graphql operation:
        // validateAndCreateAwsCloudAccount.
        protected void ProcessRecord_Validateandcreatecloudaccount()
        {
            this._logger.name += " -Validateandcreatecloudaccount";
            // Invoke graphql operation validateAndCreateAwsCloudAccount
            InvokeMutationValidateAndCreateAwsCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // finalizeAwsCloudAccountProtection.
        protected void ProcessRecord_Finalizecloudaccountprotection()
        {
            this._logger.name += " -Finalizecloudaccountprotection";
            // Invoke graphql operation finalizeAwsCloudAccountProtection
            InvokeMutationFinalizeAwsCloudAccountProtection();
        }

        // This parameter set invokes a single graphql operation:
        // prepareAwsCloudAccountDeletion.
        protected void ProcessRecord_Preparecloudaccountdeletion()
        {
            this._logger.name += " -Preparecloudaccountdeletion";
            // Invoke graphql operation prepareAwsCloudAccountDeletion
            InvokeMutationPrepareAwsCloudAccountDeletion();
        }

        // This parameter set invokes a single graphql operation:
        // finalizeAwsCloudAccountDeletion.
        protected void ProcessRecord_Finalizecloudaccountdeletion()
        {
            this._logger.name += " -Finalizecloudaccountdeletion";
            // Invoke graphql operation finalizeAwsCloudAccountDeletion
            InvokeMutationFinalizeAwsCloudAccountDeletion();
        }

        // This parameter set invokes a single graphql operation:
        // updateAwsCloudAccountFeature.
        protected void ProcessRecord_Updatecloudaccountfeature()
        {
            this._logger.name += " -Updatecloudaccountfeature";
            // Invoke graphql operation updateAwsCloudAccountFeature
            InvokeMutationUpdateAwsCloudAccountFeature();
        }

        // This parameter set invokes a single graphql operation:
        // updateAwsCloudAccount.
        protected void ProcessRecord_Updatecloudaccount()
        {
            this._logger.name += " -Updatecloudaccount";
            // Invoke graphql operation updateAwsCloudAccount
            InvokeMutationUpdateAwsCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // prepareFeatureUpdateForAwsCloudAccount.
        protected void ProcessRecord_Preparefeatureupdateforcloudaccount()
        {
            this._logger.name += " -Preparefeatureupdateforcloudaccount";
            // Invoke graphql operation prepareFeatureUpdateForAwsCloudAccount
            InvokeMutationPrepareFeatureUpdateForAwsCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // awsCloudAccountUpdateFeature.
        protected void ProcessRecord_Cloudaccountupdatefeature()
        {
            this._logger.name += " -Cloudaccountupdatefeature";
            // Invoke graphql operation awsCloudAccountUpdateFeature
            InvokeMutationAwsCloudAccountUpdateFeature();
        }

        // This parameter set invokes a single graphql operation:
        // createAwsExocomputeConfigs.
        protected void ProcessRecord_Createexocomputeconfig()
        {
            this._logger.name += " -Createexocomputeconfig";
            // Invoke graphql operation createAwsExocomputeConfigs
            InvokeMutationCreateAwsExocomputeConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAwsExocomputeConfigs.
        protected void ProcessRecord_Deleteexocomputeconfig()
        {
            this._logger.name += " -Deleteexocomputeconfig";
            // Invoke graphql operation deleteAwsExocomputeConfigs
            InvokeMutationDeleteAwsExocomputeConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // updateAwsExocomputeConfigs.
        protected void ProcessRecord_Updateexocomputeconfig()
        {
            this._logger.name += " -Updateexocomputeconfig";
            // Invoke graphql operation updateAwsExocomputeConfigs
            InvokeMutationUpdateAwsExocomputeConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // startAwsExocomputeDisableJob.
        protected void ProcessRecord_Startexocomputedisablejob()
        {
            this._logger.name += " -Startexocomputedisablejob";
            // Invoke graphql operation startAwsExocomputeDisableJob
            InvokeMutationStartAwsExocomputeDisableJob();
        }

        // This parameter set invokes a single graphql operation:
        // addAwsIamUserBasedCloudAccount.
        protected void ProcessRecord_Addiamuserbasedcloudaccount()
        {
            this._logger.name += " -Addiamuserbasedcloudaccount";
            // Invoke graphql operation addAwsIamUserBasedCloudAccount
            InvokeMutationAddAwsIamUserBasedCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAwsIamUserBasedCloudAccount.
        protected void ProcessRecord_Deleteiamuserbasedcloudaccount()
        {
            this._logger.name += " -Deleteiamuserbasedcloudaccount";
            // Invoke graphql operation deleteAwsIamUserBasedCloudAccount
            InvokeMutationDeleteAwsIamUserBasedCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAwsCloudAccountWithoutCft.
        protected void ProcessRecord_Deletecloudaccountwithoutcft()
        {
            this._logger.name += " -Deletecloudaccountwithoutcft";
            // Invoke graphql operation deleteAwsCloudAccountWithoutCft
            InvokeMutationDeleteAwsCloudAccountWithoutCft();
        }

        // This parameter set invokes a single graphql operation:
        // upgradeAwsIamUserBasedCloudAccountPermissions.
        protected void ProcessRecord_Upgradeiamuserbasedcloudaccountpermission()
        {
            this._logger.name += " -Upgradeiamuserbasedcloudaccountpermission";
            // Invoke graphql operation upgradeAwsIamUserBasedCloudAccountPermissions
            InvokeMutationUpgradeAwsIamUserBasedCloudAccountPermissions();
        }

        // This parameter set invokes a single graphql operation:
        // upgradeAwsCloudAccountFeaturesWithoutCft.
        protected void ProcessRecord_Upgradecloudaccountfeatureswithoutcft()
        {
            this._logger.name += " -Upgradecloudaccountfeatureswithoutcft";
            // Invoke graphql operation upgradeAwsCloudAccountFeaturesWithoutCft
            InvokeMutationUpgradeAwsCloudAccountFeaturesWithoutCft();
        }

        // This parameter set invokes a single graphql operation:
        // addAwsAuthenticationServerBasedCloudAccount.
        protected void ProcessRecord_Addauthenticationserverbasedcloudaccount()
        {
            this._logger.name += " -Addauthenticationserverbasedcloudaccount";
            // Invoke graphql operation addAwsAuthenticationServerBasedCloudAccount
            InvokeMutationAddAwsAuthenticationServerBasedCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // patchAwsAuthenticationServerBasedCloudAccount.
        protected void ProcessRecord_Patchauthenticationserverbasedcloudaccount()
        {
            this._logger.name += " -Patchauthenticationserverbasedcloudaccount";
            // Invoke graphql operation patchAwsAuthenticationServerBasedCloudAccount
            InvokeMutationPatchAwsAuthenticationServerBasedCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // patchAwsIamUserBasedCloudAccount.
        protected void ProcessRecord_Patchiamuserbasedcloudaccount()
        {
            this._logger.name += " -Patchiamuserbasedcloudaccount";
            // Invoke graphql operation patchAwsIamUserBasedCloudAccount
            InvokeMutationPatchAwsIamUserBasedCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // createAwsCluster.
        protected void ProcessRecord_Createcluster()
        {
            this._logger.name += " -Createcluster";
            // Invoke graphql operation createAwsCluster
            InvokeMutationCreateAwsCluster();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAwsCluster.
        protected void ProcessRecord_Deletecluster()
        {
            this._logger.name += " -Deletecluster";
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