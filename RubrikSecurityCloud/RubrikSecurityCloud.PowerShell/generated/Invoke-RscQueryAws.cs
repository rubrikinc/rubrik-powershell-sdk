// Invoke-RscQueryAws.cs
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
        "RscQueryAws",
        DefaultParameterSetName = "AllVpc")
    ]
    public class Invoke_RscQueryAws : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // NativeRoot parameter set
        //
        // [GraphQL: awsNativeRoot]
        //
        [Parameter(
            ParameterSetName = "NativeRoot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Root of AWS native hierarchy.
[GraphQL: awsNativeRoot]",
            Position = 0
        )]
        public SwitchParameter NativeRoot { get; set; }

        
        // -------------------------------------------------------------------
        // NativeAccount parameter set
        //
        // [GraphQL: awsNativeAccount]
        //
        [Parameter(
            ParameterSetName = "NativeAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Refers to the AWS Native account that serves as a container for all your AWS resources. The AWS Native account contains information about the metadata related to the AWS Native resources.
[GraphQL: awsNativeAccount]",
            Position = 0
        )]
        public SwitchParameter NativeAccount { get; set; }

        
        // -------------------------------------------------------------------
        // NativeEc2Instance parameter set
        //
        // [GraphQL: awsNativeEc2Instance]
        //
        [Parameter(
            ParameterSetName = "NativeEc2Instance",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Refers to Amazon Elastic Compute Cloud (EC2) Instance represented by a specific ID. For more information, see https://aws.amazon.com/ec2/.
[GraphQL: awsNativeEc2Instance]",
            Position = 0
        )]
        public SwitchParameter NativeEc2Instance { get; set; }

        
        // -------------------------------------------------------------------
        // NativeEbsVolume parameter set
        //
        // [GraphQL: awsNativeEbsVolume]
        //
        [Parameter(
            ParameterSetName = "NativeEbsVolume",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Refers to the Amazon Elastic Block Store (EBS) Volume represented by a specific ID. For more information, see https://aws.amazon.com/ebs/.
[GraphQL: awsNativeEbsVolume]",
            Position = 0
        )]
        public SwitchParameter NativeEbsVolume { get; set; }

        
        // -------------------------------------------------------------------
        // NativeS3Bucket parameter set
        //
        // [GraphQL: awsNativeS3Bucket]
        //
        [Parameter(
            ParameterSetName = "NativeS3Bucket",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Represents the Amazon S3 Bucket with a specific ID. For more information, see https://aws.amazon.com/s3/.
[GraphQL: awsNativeS3Bucket]",
            Position = 0
        )]
        public SwitchParameter NativeS3Bucket { get; set; }

        
        // -------------------------------------------------------------------
        // NativeEc2InstancesByName parameter set
        //
        // [GraphQL: awsNativeEc2InstancesByName]
        //
        [Parameter(
            ParameterSetName = "NativeEc2InstancesByName",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of all AWS EC2 Instances by name or substring of name.
[GraphQL: awsNativeEc2InstancesByName]",
            Position = 0
        )]
        public SwitchParameter NativeEc2InstancesByName { get; set; }

        
        // -------------------------------------------------------------------
        // NativeEbsVolumesByName parameter set
        //
        // [GraphQL: awsNativeEbsVolumesByName]
        //
        [Parameter(
            ParameterSetName = "NativeEbsVolumesByName",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of all AWS EBS Volumes by name or substring of name.
[GraphQL: awsNativeEbsVolumesByName]",
            Position = 0
        )]
        public SwitchParameter NativeEbsVolumesByName { get; set; }

        
        // -------------------------------------------------------------------
        // AllVpcsByRegion parameter set
        //
        // [GraphQL: allVpcsByRegionFromAws]
        //
        [Parameter(
            ParameterSetName = "AllVpcsByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all Virtual Private Clouds (VPCs) in the AWS Native account, classified by region.
[GraphQL: allVpcsByRegionFromAws]",
            Position = 0
        )]
        public SwitchParameter AllVpcsByRegion { get; set; }

        
        // -------------------------------------------------------------------
        // AllVpc parameter set
        //
        // [GraphQL: allVpcsFromAws]
        //
        [Parameter(
            ParameterSetName = "AllVpc",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all Virtual Private Clouds (VPCs) in the AWS Native account.
[GraphQL: allVpcsFromAws]",
            Position = 0
        )]
        public SwitchParameter AllVpc { get; set; }

        
        // -------------------------------------------------------------------
        // IsNativeEbsVolumeSnapshotRestorable parameter set
        //
        // [GraphQL: isAwsNativeEbsVolumeSnapshotRestorable]
        //
        [Parameter(
            ParameterSetName = "IsNativeEbsVolumeSnapshotRestorable",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Specified whether an EBS volume is restorable. For an EBS Volume to be restorable, the volume should be able to replace where attached.
[GraphQL: isAwsNativeEbsVolumeSnapshotRestorable]",
            Position = 0
        )]
        public SwitchParameter IsNativeEbsVolumeSnapshotRestorable { get; set; }

        
        // -------------------------------------------------------------------
        // AllAvailabilityZonesByRegion parameter set
        //
        // [GraphQL: allAvailabilityZonesByRegionFromAws]
        //
        [Parameter(
            ParameterSetName = "AllAvailabilityZonesByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of Availability Zones (AZs) in the specified region on the specified AWS Native account.
[GraphQL: allAvailabilityZonesByRegionFromAws]",
            Position = 0
        )]
        public SwitchParameter AllAvailabilityZonesByRegion { get; set; }

        
        // -------------------------------------------------------------------
        // AllKmsEncryptionKeysByRegion parameter set
        //
        // [GraphQL: allKmsEncryptionKeysByRegionFromAws]
        //
        [Parameter(
            ParameterSetName = "AllKmsEncryptionKeysByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of encryption keys in the specified region on the specified AWS Native account. All the encrytion keys listed are managed by AWS Key Management System (KMS). For more information, see https://aws.amazon.com/kms/.
[GraphQL: allKmsEncryptionKeysByRegionFromAws]",
            Position = 0
        )]
        public SwitchParameter AllKmsEncryptionKeysByRegion { get; set; }

        
        // -------------------------------------------------------------------
        // IsS3BucketNameAvailable parameter set
        //
        // [GraphQL: isAwsS3BucketNameAvailable]
        //
        [Parameter(
            ParameterSetName = "IsS3BucketNameAvailable",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Specifies whether an S3 bucket name is available for use in AWS or not. When true, the bucket name is available for use.
[GraphQL: isAwsS3BucketNameAvailable]",
            Position = 0
        )]
        public SwitchParameter IsS3BucketNameAvailable { get; set; }

        
        // -------------------------------------------------------------------
        // AllS3Bucket parameter set
        //
        // [GraphQL: allS3BucketsFromAws]
        //
        [Parameter(
            ParameterSetName = "AllS3Bucket",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all S3 bucket names across regions for the AWS Native account.
[GraphQL: allS3BucketsFromAws]",
            Position = 0
        )]
        public SwitchParameter AllS3Bucket { get; set; }

        
        // -------------------------------------------------------------------
        // AllS3BucketsDetail parameter set
        //
        // [GraphQL: allS3BucketsDetailsFromAws]
        //
        [Parameter(
            ParameterSetName = "AllS3BucketsDetail",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all S3 bucket details across regions for the AWS Native account.
[GraphQL: allS3BucketsDetailsFromAws]",
            Position = 0
        )]
        public SwitchParameter AllS3BucketsDetail { get; set; }

        
        // -------------------------------------------------------------------
        // NativeRdsInstance parameter set
        //
        // [GraphQL: awsNativeRdsInstance]
        //
        [Parameter(
            ParameterSetName = "NativeRdsInstance",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Refers to AWS Relational Database Service (RDS) represented by a specific ID. For more information, see https://aws.amazon.com/rds/.
[GraphQL: awsNativeRdsInstance]",
            Position = 0
        )]
        public SwitchParameter NativeRdsInstance { get; set; }

        
        // -------------------------------------------------------------------
        // NativeRdsPointInTimeRestoreWindow parameter set
        //
        // [GraphQL: awsNativeRdsPointInTimeRestoreWindow]
        //
        [Parameter(
            ParameterSetName = "NativeRdsPointInTimeRestoreWindow",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Point-in-Time (PiT) restore window of the RDS Instance in the AWS Native account. Refers to the range of time within which the database is available to be restored to a particular point in time. For more information,see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_PIT.html.
[GraphQL: awsNativeRdsPointInTimeRestoreWindow]",
            Position = 0
        )]
        public SwitchParameter NativeRdsPointInTimeRestoreWindow { get; set; }

        
        // -------------------------------------------------------------------
        // RdsInstanceDetail parameter set
        //
        // [GraphQL: rdsInstanceDetailsFromAws]
        //
        [Parameter(
            ParameterSetName = "RdsInstanceDetail",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Details of the RDS Instance in the AWS Native account.
[GraphQL: rdsInstanceDetailsFromAws]",
            Position = 0
        )]
        public SwitchParameter RdsInstanceDetail { get; set; }

        
        // -------------------------------------------------------------------
        // IsNativeRdsInstanceLaunchConfigurationValid parameter set
        //
        // [GraphQL: isAwsNativeRdsInstanceLaunchConfigurationValid]
        //
        [Parameter(
            ParameterSetName = "IsNativeRdsInstanceLaunchConfigurationValid",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Specifies whether the given DbInstance class, storage type, multi-az capability, encryption capability, iops value are supported for the given dbEngine, dbEngineVersion in the specified availability zone. When true, the specification is valid for a RDS Instance and can be used to create a new Instance.
[GraphQL: isAwsNativeRdsInstanceLaunchConfigurationValid]",
            Position = 0
        )]
        public SwitchParameter IsNativeRdsInstanceLaunchConfigurationValid { get; set; }

        
        // -------------------------------------------------------------------
        // AllOptionGroupsByRegion parameter set
        //
        // [GraphQL: allOptionGroupsByRegionFromAws]
        //
        [Parameter(
            ParameterSetName = "AllOptionGroupsByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all RDS option groups in a given region. Refers to settings of how a particular option works for an RDS Instance. For more information, see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_WorkingWithOptionGroups.html.
[GraphQL: allOptionGroupsByRegionFromAws]",
            Position = 0
        )]
        public SwitchParameter AllOptionGroupsByRegion { get; set; }

        
        // -------------------------------------------------------------------
        // AllDbParameterGroupsByRegion parameter set
        //
        // [GraphQL: allDbParameterGroupsByRegionFromAws]
        //
        [Parameter(
            ParameterSetName = "AllDbParameterGroupsByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all DB parameter groups in a given region. Refers to container for engine configuration that applies to one or more DB Instances. For more information, see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_WorkingWithOptionGroups.html.
[GraphQL: allDbParameterGroupsByRegionFromAws]",
            Position = 0
        )]
        public SwitchParameter AllDbParameterGroupsByRegion { get; set; }

        
        // -------------------------------------------------------------------
        // AllDbSubnetGroupsByRegion parameter set
        //
        // [GraphQL: allDbSubnetGroupsByRegionFromAws]
        //
        [Parameter(
            ParameterSetName = "AllDbSubnetGroupsByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"All DB subnet groups in a given region. Refers to logical isolation of RDS on a network. For more information, see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_VPC.WorkingWithRDSInstanceinaVPC.html.
[GraphQL: allDbSubnetGroupsByRegionFromAws]",
            Position = 0
        )]
        public SwitchParameter AllDbSubnetGroupsByRegion { get; set; }

        
        // -------------------------------------------------------------------
        // ValidateNativeRdsInstanceNameForExport parameter set
        //
        // [GraphQL: validateAwsNativeRdsInstanceNameForExport]
        //
        [Parameter(
            ParameterSetName = "ValidateNativeRdsInstanceNameForExport",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Validates the name used for an RDS Instance during an export operation. Returns true if the RDS Instance name is valid. Returns false, with an error message, if the RDS Instance name validation fails. Returns false, without an error message for all other failures.
[GraphQL: validateAwsNativeRdsInstanceNameForExport]",
            Position = 0
        )]
        public SwitchParameter ValidateNativeRdsInstanceNameForExport { get; set; }

        
        // -------------------------------------------------------------------
        // ValidateNativeRdsClusterNameForExport parameter set
        //
        // [GraphQL: validateAwsNativeRdsClusterNameForExport]
        //
        [Parameter(
            ParameterSetName = "ValidateNativeRdsClusterNameForExport",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Validates the name used for an RDS cluster during an export operation. Returns true if the RDS cluster name is valid. Returns false, with an error message, if the RDS cluster name validation fails. Returns false, without an error message for all other failures.
[GraphQL: validateAwsNativeRdsClusterNameForExport]",
            Position = 0
        )]
        public SwitchParameter ValidateNativeRdsClusterNameForExport { get; set; }

        
        // -------------------------------------------------------------------
        // NativeRdsExportDefault parameter set
        //
        // [GraphQL: awsNativeRdsExportDefaults]
        //
        [Parameter(
            ParameterSetName = "NativeRdsExportDefault",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Refers to the default values for the export operation of the RDS DB Instance in the AWS Native account.
[GraphQL: awsNativeRdsExportDefaults]",
            Position = 0
        )]
        public SwitchParameter NativeRdsExportDefault { get; set; }

        
        // -------------------------------------------------------------------
        // AllEc2KeyPairsByRegion parameter set
        //
        // [GraphQL: allEc2KeyPairsByRegionFromAws]
        //
        [Parameter(
            ParameterSetName = "AllEc2KeyPairsByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all key pairs for a given region. A key pair, consisting of a public key and a private key, is a set of security credentials that you use to prove your identity when connecting to an EC2 instance. For more information, see https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html.
[GraphQL: allEc2KeyPairsByRegionFromAws]",
            Position = 0
        )]
        public SwitchParameter AllEc2KeyPairsByRegion { get; set; }

        
        // -------------------------------------------------------------------
        // AmiTypeForNativeArchivedSnapshotExport parameter set
        //
        // [GraphQL: amiTypeForAwsNativeArchivedSnapshotExport]
        //
        [Parameter(
            ParameterSetName = "AmiTypeForNativeArchivedSnapshotExport",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Amazon Machine Image (AMI) type for export of an archived EC2 Instance snapshot. For more information, see https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instances-and-amis.html.
[GraphQL: amiTypeForAwsNativeArchivedSnapshotExport]",
            Position = 0
        )]
        public SwitchParameter AmiTypeForNativeArchivedSnapshotExport { get; set; }

        
        // -------------------------------------------------------------------
        // AllRdsAuroraInstanceClass parameter set
        //
        // [GraphQL: allAwsRdsAuroraInstanceClasses]
        //
        [Parameter(
            ParameterSetName = "AllRdsAuroraInstanceClass",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all the database instance classes supported by AWS RDS Aurora databases.
[GraphQL: allAwsRdsAuroraInstanceClasses]",
            Position = 0
        )]
        public SwitchParameter AllRdsAuroraInstanceClass { get; set; }

        
        // -------------------------------------------------------------------
        // AllSupportedRdsDatabaseInstanceClass parameter set
        //
        // [GraphQL: allSupportedAwsRdsDatabaseInstanceClasses]
        //
        [Parameter(
            ParameterSetName = "AllSupportedRdsDatabaseInstanceClass",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all the database instance classes supported by AWS RDS database for the provided DB engine and engine version. DB engine version is a optional argument, it can be ignored if we want to retrieve all the supported instance class for a DB engine irrespective of DB engine version.
[GraphQL: allSupportedAwsRdsDatabaseInstanceClasses]",
            Position = 0
        )]
        public SwitchParameter AllSupportedRdsDatabaseInstanceClass { get; set; }

        
        // -------------------------------------------------------------------
        // ComputeSetting parameter set
        //
        // [GraphQL: awsComputeSettings]
        //
        [Parameter(
            ParameterSetName = "ComputeSetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieve aws compute settings.
[GraphQL: awsComputeSettings]",
            Position = 0
        )]
        public SwitchParameter ComputeSetting { get; set; }

        
        // -------------------------------------------------------------------
        // AllComputeSetting parameter set
        //
        // [GraphQL: allAwsComputeSettings]
        //
        [Parameter(
            ParameterSetName = "AllComputeSetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List all aws compute settings.
[GraphQL: allAwsComputeSettings]",
            Position = 0
        )]
        public SwitchParameter AllComputeSetting { get; set; }

        
        // -------------------------------------------------------------------
        // AllCloudAccountsWithFeature parameter set
        //
        // [GraphQL: allAwsCloudAccountsWithFeatures]
        //
        [Parameter(
            ParameterSetName = "AllCloudAccountsWithFeature",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of active AWS cloud accounts and the features for the accounts. A cloud account is an AWS account added to the Rubrik platform.
[GraphQL: allAwsCloudAccountsWithFeatures]",
            Position = 0
        )]
        public SwitchParameter AllCloudAccountsWithFeature { get; set; }

        
        // -------------------------------------------------------------------
        // AllCloudAccountsFeaturesWithExoConfig parameter set
        //
        // [GraphQL: allAwsCloudAccountsFeaturesWithExoConfigs]
        //
        [Parameter(
            ParameterSetName = "AllCloudAccountsFeaturesWithExoConfig",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of active AWS cloud account features and the Exocompute mapping information for the accounts. A cloud account is an AWS account added to the Rubrik platform.
[GraphQL: allAwsCloudAccountsFeaturesWithExoConfigs]",
            Position = 0
        )]
        public SwitchParameter AllCloudAccountsFeaturesWithExoConfig { get; set; }

        
        // -------------------------------------------------------------------
        // CloudAccountWithFeature parameter set
        //
        // [GraphQL: awsCloudAccountWithFeatures]
        //
        [Parameter(
            ParameterSetName = "CloudAccountWithFeature",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of AWS cloud accounts and the features for each account, classified by ID.
[GraphQL: awsCloudAccountWithFeatures]",
            Position = 0
        )]
        public SwitchParameter CloudAccountWithFeature { get; set; }

        
        // -------------------------------------------------------------------
        // CloudAccountListVpc parameter set
        //
        // [GraphQL: awsCloudAccountListVpcs]
        //
        [Parameter(
            ParameterSetName = "CloudAccountListVpc",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a list of virtual private clouds (VPCs) in the specific cloud account.
[GraphQL: awsCloudAccountListVpcs]",
            Position = 0
        )]
        public SwitchParameter CloudAccountListVpc { get; set; }

        
        // -------------------------------------------------------------------
        // CloudAccountListSubnet parameter set
        //
        // [GraphQL: awsCloudAccountListSubnets]
        //
        [Parameter(
            ParameterSetName = "CloudAccountListSubnet",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a list of subnets in the specified cloud account and virtual private cloud (VPC).
[GraphQL: awsCloudAccountListSubnets]",
            Position = 0
        )]
        public SwitchParameter CloudAccountListSubnet { get; set; }

        
        // -------------------------------------------------------------------
        // CloudAccountListSecurityGroup parameter set
        //
        // [GraphQL: awsCloudAccountListSecurityGroups]
        //
        [Parameter(
            ParameterSetName = "CloudAccountListSecurityGroup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a list of security groups in the specified cloud account and virtual private cloud (VPC).
[GraphQL: awsCloudAccountListSecurityGroups]",
            Position = 0
        )]
        public SwitchParameter CloudAccountListSecurityGroup { get; set; }

        
        // -------------------------------------------------------------------
        // CloudAccountListKMSKey parameter set
        //
        // [GraphQL: AwsCloudAccountListKMSKeys]
        //
        [Parameter(
            ParameterSetName = "CloudAccountListKMSKey",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: AwsCloudAccountListKMSKeys]",
            Position = 0
        )]
        public SwitchParameter CloudAccountListKMSKey { get; set; }

        
        // -------------------------------------------------------------------
        // AllExocomputeConfig parameter set
        //
        // [GraphQL: allAwsExocomputeConfigs]
        //
        [Parameter(
            ParameterSetName = "AllExocomputeConfig",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all AWS exocompute configurations filtered by a cloud account ID or a cloud account name prefix.
[GraphQL: allAwsExocomputeConfigs]",
            Position = 0
        )]
        public SwitchParameter AllExocomputeConfig { get; set; }

        
        // -------------------------------------------------------------------
        // AllCloudAccountConfig parameter set
        //
        // [GraphQL: allAwsCloudAccountConfigs]
        //
        [Parameter(
            ParameterSetName = "AllCloudAccountConfig",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all AWS cloud account configurations with the given search query.
[GraphQL: allAwsCloudAccountConfigs]",
            Position = 0
        )]
        public SwitchParameter AllCloudAccountConfig { get; set; }

        
        // -------------------------------------------------------------------
        // AllRegion parameter set
        //
        // [GraphQL: allAwsRegions]
        //
        [Parameter(
            ParameterSetName = "AllRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"All valid AWS regions for this cloud account.
[GraphQL: allAwsRegions]",
            Position = 0
        )]
        public SwitchParameter AllRegion { get; set; }

        
        // -------------------------------------------------------------------
        // AllCdmVersion parameter set
        //
        // [GraphQL: allAwsCdmVersions]
        //
        [Parameter(
            ParameterSetName = "AllCdmVersion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get all Rubrik CDM versions in the AWS marketplace.
[GraphQL: allAwsCdmVersions]",
            Position = 0
        )]
        public SwitchParameter AllCdmVersion { get; set; }

        
        // -------------------------------------------------------------------
        // AllInstanceProfileName parameter set
        //
        // [GraphQL: allAwsInstanceProfileNames]
        //
        [Parameter(
            ParameterSetName = "AllInstanceProfileName",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"All Rubrik CC-ES instance profiles in the AWS account.
[GraphQL: allAwsInstanceProfileNames]",
            Position = 0
        )]
        public SwitchParameter AllInstanceProfileName { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "NativeRoot":
                        this.ProcessRecord_NativeRoot();
                        break;
                    case "NativeAccount":
                        this.ProcessRecord_NativeAccount();
                        break;
                    case "NativeEc2Instance":
                        this.ProcessRecord_NativeEc2Instance();
                        break;
                    case "NativeEbsVolume":
                        this.ProcessRecord_NativeEbsVolume();
                        break;
                    case "NativeS3Bucket":
                        this.ProcessRecord_NativeS3Bucket();
                        break;
                    case "NativeEc2InstancesByName":
                        this.ProcessRecord_NativeEc2InstancesByName();
                        break;
                    case "NativeEbsVolumesByName":
                        this.ProcessRecord_NativeEbsVolumesByName();
                        break;
                    case "AllVpcsByRegion":
                        this.ProcessRecord_AllVpcsByRegion();
                        break;
                    case "AllVpc":
                        this.ProcessRecord_AllVpc();
                        break;
                    case "IsNativeEbsVolumeSnapshotRestorable":
                        this.ProcessRecord_IsNativeEbsVolumeSnapshotRestorable();
                        break;
                    case "AllAvailabilityZonesByRegion":
                        this.ProcessRecord_AllAvailabilityZonesByRegion();
                        break;
                    case "AllKmsEncryptionKeysByRegion":
                        this.ProcessRecord_AllKmsEncryptionKeysByRegion();
                        break;
                    case "IsS3BucketNameAvailable":
                        this.ProcessRecord_IsS3BucketNameAvailable();
                        break;
                    case "AllS3Bucket":
                        this.ProcessRecord_AllS3Bucket();
                        break;
                    case "AllS3BucketsDetail":
                        this.ProcessRecord_AllS3BucketsDetail();
                        break;
                    case "NativeRdsInstance":
                        this.ProcessRecord_NativeRdsInstance();
                        break;
                    case "NativeRdsPointInTimeRestoreWindow":
                        this.ProcessRecord_NativeRdsPointInTimeRestoreWindow();
                        break;
                    case "RdsInstanceDetail":
                        this.ProcessRecord_RdsInstanceDetail();
                        break;
                    case "IsNativeRdsInstanceLaunchConfigurationValid":
                        this.ProcessRecord_IsNativeRdsInstanceLaunchConfigurationValid();
                        break;
                    case "AllOptionGroupsByRegion":
                        this.ProcessRecord_AllOptionGroupsByRegion();
                        break;
                    case "AllDbParameterGroupsByRegion":
                        this.ProcessRecord_AllDbParameterGroupsByRegion();
                        break;
                    case "AllDbSubnetGroupsByRegion":
                        this.ProcessRecord_AllDbSubnetGroupsByRegion();
                        break;
                    case "ValidateNativeRdsInstanceNameForExport":
                        this.ProcessRecord_ValidateNativeRdsInstanceNameForExport();
                        break;
                    case "ValidateNativeRdsClusterNameForExport":
                        this.ProcessRecord_ValidateNativeRdsClusterNameForExport();
                        break;
                    case "NativeRdsExportDefault":
                        this.ProcessRecord_NativeRdsExportDefault();
                        break;
                    case "AllEc2KeyPairsByRegion":
                        this.ProcessRecord_AllEc2KeyPairsByRegion();
                        break;
                    case "AmiTypeForNativeArchivedSnapshotExport":
                        this.ProcessRecord_AmiTypeForNativeArchivedSnapshotExport();
                        break;
                    case "AllRdsAuroraInstanceClass":
                        this.ProcessRecord_AllRdsAuroraInstanceClass();
                        break;
                    case "AllSupportedRdsDatabaseInstanceClass":
                        this.ProcessRecord_AllSupportedRdsDatabaseInstanceClass();
                        break;
                    case "ComputeSetting":
                        this.ProcessRecord_ComputeSetting();
                        break;
                    case "AllComputeSetting":
                        this.ProcessRecord_AllComputeSetting();
                        break;
                    case "AllCloudAccountsWithFeature":
                        this.ProcessRecord_AllCloudAccountsWithFeature();
                        break;
                    case "AllCloudAccountsFeaturesWithExoConfig":
                        this.ProcessRecord_AllCloudAccountsFeaturesWithExoConfig();
                        break;
                    case "CloudAccountWithFeature":
                        this.ProcessRecord_CloudAccountWithFeature();
                        break;
                    case "CloudAccountListVpc":
                        this.ProcessRecord_CloudAccountListVpc();
                        break;
                    case "CloudAccountListSubnet":
                        this.ProcessRecord_CloudAccountListSubnet();
                        break;
                    case "CloudAccountListSecurityGroup":
                        this.ProcessRecord_CloudAccountListSecurityGroup();
                        break;
                    case "CloudAccountListKMSKey":
                        this.ProcessRecord_CloudAccountListKMSKey();
                        break;
                    case "AllExocomputeConfig":
                        this.ProcessRecord_AllExocomputeConfig();
                        break;
                    case "AllCloudAccountConfig":
                        this.ProcessRecord_AllCloudAccountConfig();
                        break;
                    case "AllRegion":
                        this.ProcessRecord_AllRegion();
                        break;
                    case "AllCdmVersion":
                        this.ProcessRecord_AllCdmVersion();
                        break;
                    case "AllInstanceProfileName":
                        this.ProcessRecord_AllInstanceProfileName();
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
        // awsNativeRoot.
        protected void ProcessRecord_NativeRoot()
        {
            this._logger.name += " -NativeRoot";
            // Invoke graphql operation awsNativeRoot
            InvokeQueryAwsNativeRoot();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeAccount.
        protected void ProcessRecord_NativeAccount()
        {
            this._logger.name += " -NativeAccount";
            // Invoke graphql operation awsNativeAccount
            InvokeQueryAwsNativeAccount();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeEc2Instance.
        protected void ProcessRecord_NativeEc2Instance()
        {
            this._logger.name += " -NativeEc2Instance";
            // Invoke graphql operation awsNativeEc2Instance
            InvokeQueryAwsNativeEc2Instance();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeEbsVolume.
        protected void ProcessRecord_NativeEbsVolume()
        {
            this._logger.name += " -NativeEbsVolume";
            // Invoke graphql operation awsNativeEbsVolume
            InvokeQueryAwsNativeEbsVolume();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeS3Bucket.
        protected void ProcessRecord_NativeS3Bucket()
        {
            this._logger.name += " -NativeS3Bucket";
            // Invoke graphql operation awsNativeS3Bucket
            InvokeQueryAwsNativeS3Bucket();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeEc2InstancesByName.
        protected void ProcessRecord_NativeEc2InstancesByName()
        {
            this._logger.name += " -NativeEc2InstancesByName";
            // Invoke graphql operation awsNativeEc2InstancesByName
            InvokeQueryAwsNativeEc2InstancesByName();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeEbsVolumesByName.
        protected void ProcessRecord_NativeEbsVolumesByName()
        {
            this._logger.name += " -NativeEbsVolumesByName";
            // Invoke graphql operation awsNativeEbsVolumesByName
            InvokeQueryAwsNativeEbsVolumesByName();
        }

        // This parameter set invokes a single graphql operation:
        // allVpcsByRegionFromAws.
        protected void ProcessRecord_AllVpcsByRegion()
        {
            this._logger.name += " -AllVpcsByRegion";
            // Invoke graphql operation allVpcsByRegionFromAws
            InvokeQueryAllVpcsByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allVpcsFromAws.
        protected void ProcessRecord_AllVpc()
        {
            this._logger.name += " -AllVpc";
            // Invoke graphql operation allVpcsFromAws
            InvokeQueryAllVpcsFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // isAwsNativeEbsVolumeSnapshotRestorable.
        protected void ProcessRecord_IsNativeEbsVolumeSnapshotRestorable()
        {
            this._logger.name += " -IsNativeEbsVolumeSnapshotRestorable";
            // Invoke graphql operation isAwsNativeEbsVolumeSnapshotRestorable
            InvokeQueryIsAwsNativeEbsVolumeSnapshotRestorable();
        }

        // This parameter set invokes a single graphql operation:
        // allAvailabilityZonesByRegionFromAws.
        protected void ProcessRecord_AllAvailabilityZonesByRegion()
        {
            this._logger.name += " -AllAvailabilityZonesByRegion";
            // Invoke graphql operation allAvailabilityZonesByRegionFromAws
            InvokeQueryAllAvailabilityZonesByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allKmsEncryptionKeysByRegionFromAws.
        protected void ProcessRecord_AllKmsEncryptionKeysByRegion()
        {
            this._logger.name += " -AllKmsEncryptionKeysByRegion";
            // Invoke graphql operation allKmsEncryptionKeysByRegionFromAws
            InvokeQueryAllKmsEncryptionKeysByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // isAwsS3BucketNameAvailable.
        protected void ProcessRecord_IsS3BucketNameAvailable()
        {
            this._logger.name += " -IsS3BucketNameAvailable";
            // Invoke graphql operation isAwsS3BucketNameAvailable
            InvokeQueryIsAwsS3BucketNameAvailable();
        }

        // This parameter set invokes a single graphql operation:
        // allS3BucketsFromAws.
        protected void ProcessRecord_AllS3Bucket()
        {
            this._logger.name += " -AllS3Bucket";
            // Invoke graphql operation allS3BucketsFromAws
            InvokeQueryAllS3BucketsFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allS3BucketsDetailsFromAws.
        protected void ProcessRecord_AllS3BucketsDetail()
        {
            this._logger.name += " -AllS3BucketsDetail";
            // Invoke graphql operation allS3BucketsDetailsFromAws
            InvokeQueryAllS3BucketsDetailsFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeRdsInstance.
        protected void ProcessRecord_NativeRdsInstance()
        {
            this._logger.name += " -NativeRdsInstance";
            // Invoke graphql operation awsNativeRdsInstance
            InvokeQueryAwsNativeRdsInstance();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeRdsPointInTimeRestoreWindow.
        protected void ProcessRecord_NativeRdsPointInTimeRestoreWindow()
        {
            this._logger.name += " -NativeRdsPointInTimeRestoreWindow";
            // Invoke graphql operation awsNativeRdsPointInTimeRestoreWindow
            InvokeQueryAwsNativeRdsPointInTimeRestoreWindow();
        }

        // This parameter set invokes a single graphql operation:
        // rdsInstanceDetailsFromAws.
        protected void ProcessRecord_RdsInstanceDetail()
        {
            this._logger.name += " -RdsInstanceDetail";
            // Invoke graphql operation rdsInstanceDetailsFromAws
            InvokeQueryRdsInstanceDetailsFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // isAwsNativeRdsInstanceLaunchConfigurationValid.
        protected void ProcessRecord_IsNativeRdsInstanceLaunchConfigurationValid()
        {
            this._logger.name += " -IsNativeRdsInstanceLaunchConfigurationValid";
            // Invoke graphql operation isAwsNativeRdsInstanceLaunchConfigurationValid
            InvokeQueryIsAwsNativeRdsInstanceLaunchConfigurationValid();
        }

        // This parameter set invokes a single graphql operation:
        // allOptionGroupsByRegionFromAws.
        protected void ProcessRecord_AllOptionGroupsByRegion()
        {
            this._logger.name += " -AllOptionGroupsByRegion";
            // Invoke graphql operation allOptionGroupsByRegionFromAws
            InvokeQueryAllOptionGroupsByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allDbParameterGroupsByRegionFromAws.
        protected void ProcessRecord_AllDbParameterGroupsByRegion()
        {
            this._logger.name += " -AllDbParameterGroupsByRegion";
            // Invoke graphql operation allDbParameterGroupsByRegionFromAws
            InvokeQueryAllDbParameterGroupsByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allDbSubnetGroupsByRegionFromAws.
        protected void ProcessRecord_AllDbSubnetGroupsByRegion()
        {
            this._logger.name += " -AllDbSubnetGroupsByRegion";
            // Invoke graphql operation allDbSubnetGroupsByRegionFromAws
            InvokeQueryAllDbSubnetGroupsByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // validateAwsNativeRdsInstanceNameForExport.
        protected void ProcessRecord_ValidateNativeRdsInstanceNameForExport()
        {
            this._logger.name += " -ValidateNativeRdsInstanceNameForExport";
            // Invoke graphql operation validateAwsNativeRdsInstanceNameForExport
            InvokeQueryValidateAwsNativeRdsInstanceNameForExport();
        }

        // This parameter set invokes a single graphql operation:
        // validateAwsNativeRdsClusterNameForExport.
        protected void ProcessRecord_ValidateNativeRdsClusterNameForExport()
        {
            this._logger.name += " -ValidateNativeRdsClusterNameForExport";
            // Invoke graphql operation validateAwsNativeRdsClusterNameForExport
            InvokeQueryValidateAwsNativeRdsClusterNameForExport();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeRdsExportDefaults.
        protected void ProcessRecord_NativeRdsExportDefault()
        {
            this._logger.name += " -NativeRdsExportDefault";
            // Invoke graphql operation awsNativeRdsExportDefaults
            InvokeQueryAwsNativeRdsExportDefaults();
        }

        // This parameter set invokes a single graphql operation:
        // allEc2KeyPairsByRegionFromAws.
        protected void ProcessRecord_AllEc2KeyPairsByRegion()
        {
            this._logger.name += " -AllEc2KeyPairsByRegion";
            // Invoke graphql operation allEc2KeyPairsByRegionFromAws
            InvokeQueryAllEc2KeyPairsByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // amiTypeForAwsNativeArchivedSnapshotExport.
        protected void ProcessRecord_AmiTypeForNativeArchivedSnapshotExport()
        {
            this._logger.name += " -AmiTypeForNativeArchivedSnapshotExport";
            // Invoke graphql operation amiTypeForAwsNativeArchivedSnapshotExport
            InvokeQueryAmiTypeForAwsNativeArchivedSnapshotExport();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsRdsAuroraInstanceClasses.
        protected void ProcessRecord_AllRdsAuroraInstanceClass()
        {
            this._logger.name += " -AllRdsAuroraInstanceClass";
            // Invoke graphql operation allAwsRdsAuroraInstanceClasses
            InvokeQueryAllAwsRdsAuroraInstanceClasses();
        }

        // This parameter set invokes a single graphql operation:
        // allSupportedAwsRdsDatabaseInstanceClasses.
        protected void ProcessRecord_AllSupportedRdsDatabaseInstanceClass()
        {
            this._logger.name += " -AllSupportedRdsDatabaseInstanceClass";
            // Invoke graphql operation allSupportedAwsRdsDatabaseInstanceClasses
            InvokeQueryAllSupportedAwsRdsDatabaseInstanceClasses();
        }

        // This parameter set invokes a single graphql operation:
        // awsComputeSettings.
        protected void ProcessRecord_ComputeSetting()
        {
            this._logger.name += " -ComputeSetting";
            // Invoke graphql operation awsComputeSettings
            InvokeQueryAwsComputeSettings();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsComputeSettings.
        protected void ProcessRecord_AllComputeSetting()
        {
            this._logger.name += " -AllComputeSetting";
            // Invoke graphql operation allAwsComputeSettings
            InvokeQueryAllAwsComputeSettings();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsCloudAccountsWithFeatures.
        protected void ProcessRecord_AllCloudAccountsWithFeature()
        {
            this._logger.name += " -AllCloudAccountsWithFeature";
            // Invoke graphql operation allAwsCloudAccountsWithFeatures
            InvokeQueryAllAwsCloudAccountsWithFeatures();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsCloudAccountsFeaturesWithExoConfigs.
        protected void ProcessRecord_AllCloudAccountsFeaturesWithExoConfig()
        {
            this._logger.name += " -AllCloudAccountsFeaturesWithExoConfig";
            // Invoke graphql operation allAwsCloudAccountsFeaturesWithExoConfigs
            InvokeQueryAllAwsCloudAccountsFeaturesWithExoConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // awsCloudAccountWithFeatures.
        protected void ProcessRecord_CloudAccountWithFeature()
        {
            this._logger.name += " -CloudAccountWithFeature";
            // Invoke graphql operation awsCloudAccountWithFeatures
            InvokeQueryAwsCloudAccountWithFeatures();
        }

        // This parameter set invokes a single graphql operation:
        // awsCloudAccountListVpcs.
        protected void ProcessRecord_CloudAccountListVpc()
        {
            this._logger.name += " -CloudAccountListVpc";
            // Invoke graphql operation awsCloudAccountListVpcs
            InvokeQueryAwsCloudAccountListVpcs();
        }

        // This parameter set invokes a single graphql operation:
        // awsCloudAccountListSubnets.
        protected void ProcessRecord_CloudAccountListSubnet()
        {
            this._logger.name += " -CloudAccountListSubnet";
            // Invoke graphql operation awsCloudAccountListSubnets
            InvokeQueryAwsCloudAccountListSubnets();
        }

        // This parameter set invokes a single graphql operation:
        // awsCloudAccountListSecurityGroups.
        protected void ProcessRecord_CloudAccountListSecurityGroup()
        {
            this._logger.name += " -CloudAccountListSecurityGroup";
            // Invoke graphql operation awsCloudAccountListSecurityGroups
            InvokeQueryAwsCloudAccountListSecurityGroups();
        }

        // This parameter set invokes a single graphql operation:
        // AwsCloudAccountListKMSKeys.
        protected void ProcessRecord_CloudAccountListKMSKey()
        {
            this._logger.name += " -CloudAccountListKMSKey";
            // Invoke graphql operation AwsCloudAccountListKMSKeys
            InvokeQueryAwsCloudAccountListKmsKeys();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsExocomputeConfigs.
        protected void ProcessRecord_AllExocomputeConfig()
        {
            this._logger.name += " -AllExocomputeConfig";
            // Invoke graphql operation allAwsExocomputeConfigs
            InvokeQueryAllAwsExocomputeConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsCloudAccountConfigs.
        protected void ProcessRecord_AllCloudAccountConfig()
        {
            this._logger.name += " -AllCloudAccountConfig";
            // Invoke graphql operation allAwsCloudAccountConfigs
            InvokeQueryAllAwsCloudAccountConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsRegions.
        protected void ProcessRecord_AllRegion()
        {
            this._logger.name += " -AllRegion";
            // Invoke graphql operation allAwsRegions
            InvokeQueryAllAwsRegions();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsCdmVersions.
        protected void ProcessRecord_AllCdmVersion()
        {
            this._logger.name += " -AllCdmVersion";
            // Invoke graphql operation allAwsCdmVersions
            InvokeQueryAllAwsCdmVersions();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsInstanceProfileNames.
        protected void ProcessRecord_AllInstanceProfileName()
        {
            this._logger.name += " -AllInstanceProfileName";
            // Invoke graphql operation allAwsInstanceProfileNames
            InvokeQueryAllAwsInstanceProfileNames();
        }


        // Invoke GraphQL Query:
        // awsNativeRoot: AwsNativeRoot!
        protected void InvokeQueryAwsNativeRoot()
        {
            Tuple<string, string>[] argDefs = {
            };
            AwsNativeRoot? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AwsNativeRoot)psObject.BaseObject;
                } else {
                    fields = (AwsNativeRoot)this.Field;
                }
            }
            string document = Query.AwsNativeRoot(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AwsNativeRoot");
            var parameters = "";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAwsNativeRoot" + parameters + "{" + document + "}",
                OperationName = "QueryAwsNativeRoot",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            var result = this._rbkClient.Invoke(
                request, vars, "AwsNativeRoot", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // awsNativeAccount(awsNativeAccountRubrikId: UUID!, awsNativeProtectionFeature: AwsNativeProtectionFeature!): AwsNativeAccount!
        protected void InvokeQueryAwsNativeAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsNativeAccountRubrikId", "UUID!"),
                Tuple.Create("awsNativeProtectionFeature", "AwsNativeProtectionFeature!"),
            };
            AwsNativeAccount? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AwsNativeAccount)psObject.BaseObject;
                } else {
                    fields = (AwsNativeAccount)this.Field;
                }
            }
            string document = Query.AwsNativeAccount(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AwsNativeAccount");
            var parameters = "($awsNativeAccountRubrikId: UUID!,$awsNativeProtectionFeature: AwsNativeProtectionFeature!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAwsNativeAccount" + parameters + "{" + document + "}",
                OperationName = "QueryAwsNativeAccount",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AwsNativeAccount", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // awsNativeEc2Instance(ec2InstanceRubrikId: UUID!): AwsNativeEc2Instance!
        protected void InvokeQueryAwsNativeEc2Instance()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("ec2InstanceRubrikId", "UUID!"),
            };
            AwsNativeEc2Instance? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AwsNativeEc2Instance)psObject.BaseObject;
                } else {
                    fields = (AwsNativeEc2Instance)this.Field;
                }
            }
            string document = Query.AwsNativeEc2Instance(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AwsNativeEc2Instance");
            var parameters = "($ec2InstanceRubrikId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAwsNativeEc2Instance" + parameters + "{" + document + "}",
                OperationName = "QueryAwsNativeEc2Instance",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AwsNativeEc2Instance", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // awsNativeEbsVolume(ebsVolumeRubrikId: UUID!): AwsNativeEbsVolume!
        protected void InvokeQueryAwsNativeEbsVolume()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("ebsVolumeRubrikId", "UUID!"),
            };
            AwsNativeEbsVolume? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AwsNativeEbsVolume)psObject.BaseObject;
                } else {
                    fields = (AwsNativeEbsVolume)this.Field;
                }
            }
            string document = Query.AwsNativeEbsVolume(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AwsNativeEbsVolume");
            var parameters = "($ebsVolumeRubrikId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAwsNativeEbsVolume" + parameters + "{" + document + "}",
                OperationName = "QueryAwsNativeEbsVolume",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AwsNativeEbsVolume", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // awsNativeS3Bucket(s3BucketRubrikId: UUID!): AwsNativeS3Bucket!
        protected void InvokeQueryAwsNativeS3Bucket()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("s3BucketRubrikId", "UUID!"),
            };
            AwsNativeS3Bucket? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AwsNativeS3Bucket)psObject.BaseObject;
                } else {
                    fields = (AwsNativeS3Bucket)this.Field;
                }
            }
            string document = Query.AwsNativeS3Bucket(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AwsNativeS3Bucket");
            var parameters = "($s3BucketRubrikId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAwsNativeS3Bucket" + parameters + "{" + document + "}",
                OperationName = "QueryAwsNativeS3Bucket",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AwsNativeS3Bucket", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // awsNativeEc2InstancesByName(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AwsNativeEc2InstanceSortFields
        //     sortOrder: SortOrder
        //     ec2InstanceName: String!
        //   ): AwsNativeEc2InstanceConnection!
        protected void InvokeQueryAwsNativeEc2InstancesByName()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AwsNativeEc2InstanceSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("ec2InstanceName", "String!"),
            };
            AwsNativeEc2InstanceConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AwsNativeEc2InstanceConnection)psObject.BaseObject;
                } else {
                    fields = (AwsNativeEc2InstanceConnection)this.Field;
                }
            }
            string document = Query.AwsNativeEc2InstancesByName(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AwsNativeEc2InstancesByName");
            var parameters = "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AwsNativeEc2InstanceSortFields,$sortOrder: SortOrder,$ec2InstanceName: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAwsNativeEc2InstancesByName" + parameters + "{" + document + "}",
                OperationName = "QueryAwsNativeEc2InstancesByName",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AwsNativeEc2InstanceConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // awsNativeEbsVolumesByName(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AwsNativeEbsVolumeSortFields
        //     sortOrder: SortOrder
        //     ebsVolumeName: String!
        //   ): AwsNativeEbsVolumeConnection!
        protected void InvokeQueryAwsNativeEbsVolumesByName()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AwsNativeEbsVolumeSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("ebsVolumeName", "String!"),
            };
            AwsNativeEbsVolumeConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AwsNativeEbsVolumeConnection)psObject.BaseObject;
                } else {
                    fields = (AwsNativeEbsVolumeConnection)this.Field;
                }
            }
            string document = Query.AwsNativeEbsVolumesByName(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AwsNativeEbsVolumesByName");
            var parameters = "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AwsNativeEbsVolumeSortFields,$sortOrder: SortOrder,$ebsVolumeName: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAwsNativeEbsVolumesByName" + parameters + "{" + document + "}",
                OperationName = "QueryAwsNativeEbsVolumesByName",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AwsNativeEbsVolumeConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allVpcsByRegionFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion!): [AwsVpc!]!
        protected void InvokeQueryAllVpcsByRegionFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
            };
            List<AwsVpc>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<AwsVpc>)psObject.BaseObject;
                } else {
                    fields = (List<AwsVpc>)this.Field;
                }
            }
            string document = Query.AllVpcsByRegionFromAws(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllVpcsByRegionFromAws");
            var parameters = "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllVpcsByRegionFromAws" + parameters + "{" + document + "}",
                OperationName = "QueryAllVpcsByRegionFromAws",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<AwsVpc>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allVpcsFromAws(awsAccountRubrikId: UUID): [AwsVpc!]!
        protected void InvokeQueryAllVpcsFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID"),
            };
            List<AwsVpc>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<AwsVpc>)psObject.BaseObject;
                } else {
                    fields = (List<AwsVpc>)this.Field;
                }
            }
            string document = Query.AllVpcsFromAws(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllVpcsFromAws");
            var parameters = "($awsAccountRubrikId: UUID)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllVpcsFromAws" + parameters + "{" + document + "}",
                OperationName = "QueryAllVpcsFromAws",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<AwsVpc>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // isAwsNativeEbsVolumeSnapshotRestorable(snapshotId: String!): IsVolumeSnapshotRestorableReply!
        protected void InvokeQueryIsAwsNativeEbsVolumeSnapshotRestorable()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snapshotId", "String!"),
            };
            IsVolumeSnapshotRestorableReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (IsVolumeSnapshotRestorableReply)psObject.BaseObject;
                } else {
                    fields = (IsVolumeSnapshotRestorableReply)this.Field;
                }
            }
            string document = Query.IsAwsNativeEbsVolumeSnapshotRestorable(ref fields);
            this._input.Initialize(argDefs, fields, "Query.IsAwsNativeEbsVolumeSnapshotRestorable");
            var parameters = "($snapshotId: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryIsAwsNativeEbsVolumeSnapshotRestorable" + parameters + "{" + document + "}",
                OperationName = "QueryIsAwsNativeEbsVolumeSnapshotRestorable",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "IsVolumeSnapshotRestorableReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allAvailabilityZonesByRegionFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion!): [String!]!
        protected void InvokeQueryAllAvailabilityZonesByRegionFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
            };
            List<System.String>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<System.String>)psObject.BaseObject;
                } else {
                    fields = (List<System.String>)this.Field;
                }
            }
            string document = Query.AllAvailabilityZonesByRegionFromAws(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAvailabilityZonesByRegionFromAws");
            var parameters = "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAvailabilityZonesByRegionFromAws" + parameters + "{" + document + "}",
                OperationName = "QueryAllAvailabilityZonesByRegionFromAws",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<System.String>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allKmsEncryptionKeysByRegionFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion!): [KmsEncryptionKey!]!
        protected void InvokeQueryAllKmsEncryptionKeysByRegionFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
            };
            List<KmsEncryptionKey>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<KmsEncryptionKey>)psObject.BaseObject;
                } else {
                    fields = (List<KmsEncryptionKey>)this.Field;
                }
            }
            string document = Query.AllKmsEncryptionKeysByRegionFromAws(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllKmsEncryptionKeysByRegionFromAws");
            var parameters = "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllKmsEncryptionKeysByRegionFromAws" + parameters + "{" + document + "}",
                OperationName = "QueryAllKmsEncryptionKeysByRegionFromAws",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<KmsEncryptionKey>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // isAwsS3BucketNameAvailable(bucketName: String!, awsAccountRubrikId: UUID!): Boolean!
        protected void InvokeQueryIsAwsS3BucketNameAvailable()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("bucketName", "String!"),
                Tuple.Create("awsAccountRubrikId", "UUID!"),
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
            string document = Query.IsAwsS3BucketNameAvailable(ref fields);
            this._input.Initialize(argDefs, fields, "Query.IsAwsS3BucketNameAvailable");
            var parameters = "($bucketName: String!,$awsAccountRubrikId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryIsAwsS3BucketNameAvailable" + parameters + "{" + document + "}",
                OperationName = "QueryIsAwsS3BucketNameAvailable",
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

        // Invoke GraphQL Query:
        // allS3BucketsFromAws(awsAccountRubrikId: UUID!): [String!]!
        protected void InvokeQueryAllS3BucketsFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
            };
            List<System.String>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<System.String>)psObject.BaseObject;
                } else {
                    fields = (List<System.String>)this.Field;
                }
            }
            string document = Query.AllS3BucketsFromAws(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllS3BucketsFromAws");
            var parameters = "($awsAccountRubrikId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllS3BucketsFromAws" + parameters + "{" + document + "}",
                OperationName = "QueryAllS3BucketsFromAws",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<System.String>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allS3BucketsDetailsFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion): [S3BucketDetails!]!
        protected void InvokeQueryAllS3BucketsDetailsFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion"),
            };
            List<S3BucketDetails>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<S3BucketDetails>)psObject.BaseObject;
                } else {
                    fields = (List<S3BucketDetails>)this.Field;
                }
            }
            string document = Query.AllS3BucketsDetailsFromAws(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllS3BucketsDetailsFromAws");
            var parameters = "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllS3BucketsDetailsFromAws" + parameters + "{" + document + "}",
                OperationName = "QueryAllS3BucketsDetailsFromAws",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<S3BucketDetails>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // awsNativeRdsInstance(rdsInstanceRubrikId: UUID!): AwsNativeRdsInstance!
        protected void InvokeQueryAwsNativeRdsInstance()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("rdsInstanceRubrikId", "UUID!"),
            };
            AwsNativeRdsInstance? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AwsNativeRdsInstance)psObject.BaseObject;
                } else {
                    fields = (AwsNativeRdsInstance)this.Field;
                }
            }
            string document = Query.AwsNativeRdsInstance(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AwsNativeRdsInstance");
            var parameters = "($rdsInstanceRubrikId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAwsNativeRdsInstance" + parameters + "{" + document + "}",
                OperationName = "QueryAwsNativeRdsInstance",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AwsNativeRdsInstance", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // awsNativeRdsPointInTimeRestoreWindow(
        //     awsAccountRubrikId: UUID!
        //     region: AwsNativeRegion!
        //     rdsInstanceName: String!
        //     rdsDatabaseRubrikId: UUID
        //   ): AwsNativeRdsPointInTimeRestoreWindow!
        protected void InvokeQueryAwsNativeRdsPointInTimeRestoreWindow()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("rdsInstanceName", "String!"),
                Tuple.Create("rdsDatabaseRubrikId", "UUID"),
            };
            AwsNativeRdsPointInTimeRestoreWindow? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AwsNativeRdsPointInTimeRestoreWindow)psObject.BaseObject;
                } else {
                    fields = (AwsNativeRdsPointInTimeRestoreWindow)this.Field;
                }
            }
            string document = Query.AwsNativeRdsPointInTimeRestoreWindow(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AwsNativeRdsPointInTimeRestoreWindow");
            var parameters = "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$rdsInstanceName: String!,$rdsDatabaseRubrikId: UUID)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAwsNativeRdsPointInTimeRestoreWindow" + parameters + "{" + document + "}",
                OperationName = "QueryAwsNativeRdsPointInTimeRestoreWindow",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AwsNativeRdsPointInTimeRestoreWindow", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // rdsInstanceDetailsFromAws(
        //     awsAccountRubrikId: UUID!
        //     region: AwsNativeRegion!
        //     rdsInstanceName: String!
        //     rdsDatabaseRubrikId: UUID
        //   ): RdsInstanceDetailsFromAws!
        protected void InvokeQueryRdsInstanceDetailsFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("rdsInstanceName", "String!"),
                Tuple.Create("rdsDatabaseRubrikId", "UUID"),
            };
            RdsInstanceDetailsFromAws? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (RdsInstanceDetailsFromAws)psObject.BaseObject;
                } else {
                    fields = (RdsInstanceDetailsFromAws)this.Field;
                }
            }
            string document = Query.RdsInstanceDetailsFromAws(ref fields);
            this._input.Initialize(argDefs, fields, "Query.RdsInstanceDetailsFromAws");
            var parameters = "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$rdsInstanceName: String!,$rdsDatabaseRubrikId: UUID)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryRdsInstanceDetailsFromAws" + parameters + "{" + document + "}",
                OperationName = "QueryRdsInstanceDetailsFromAws",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "RdsInstanceDetailsFromAws", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // isAwsNativeRdsInstanceLaunchConfigurationValid(
        //     awsAccountRubrikId: UUID!
        //     region: AwsNativeRegion!
        //     dbEngine: AwsNativeRdsDbEngine!
        //     dbEngineVersion: String!
        //     dbClass: AwsNativeRdsDbInstanceClass!
        //     databaseInstanceClass: String
        //     primaryAz: String
        //     storageType: AwsNativeRdsStorageType
        //     isMultiAz: Boolean!
        //     kmsKeyId: String
        //     iops: Int
        //   ): Boolean!
        protected void InvokeQueryIsAwsNativeRdsInstanceLaunchConfigurationValid()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("dbEngine", "AwsNativeRdsDbEngine!"),
                Tuple.Create("dbEngineVersion", "String!"),
                Tuple.Create("dbClass", "AwsNativeRdsDbInstanceClass!"),
                Tuple.Create("databaseInstanceClass", "String"),
                Tuple.Create("primaryAz", "String"),
                Tuple.Create("storageType", "AwsNativeRdsStorageType"),
                Tuple.Create("isMultiAz", "Boolean!"),
                Tuple.Create("kmsKeyId", "String"),
                Tuple.Create("iops", "Int"),
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
            string document = Query.IsAwsNativeRdsInstanceLaunchConfigurationValid(ref fields);
            this._input.Initialize(argDefs, fields, "Query.IsAwsNativeRdsInstanceLaunchConfigurationValid");
            var parameters = "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$dbEngine: AwsNativeRdsDbEngine!,$dbEngineVersion: String!,$dbClass: AwsNativeRdsDbInstanceClass!,$databaseInstanceClass: String,$primaryAz: String,$storageType: AwsNativeRdsStorageType,$isMultiAz: Boolean!,$kmsKeyId: String,$iops: Int)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryIsAwsNativeRdsInstanceLaunchConfigurationValid" + parameters + "{" + document + "}",
                OperationName = "QueryIsAwsNativeRdsInstanceLaunchConfigurationValid",
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

        // Invoke GraphQL Query:
        // allOptionGroupsByRegionFromAws(
        //     awsAccountRubrikId: UUID!
        //     region: AwsNativeRegion!
        //     dbEngine: AwsNativeRdsDbEngine!
        //     dbEngineVersion: String!
        //     majorEngineVersion: String!
        //   ): [OptionGroup!]!
        protected void InvokeQueryAllOptionGroupsByRegionFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("dbEngine", "AwsNativeRdsDbEngine!"),
                Tuple.Create("dbEngineVersion", "String!"),
                Tuple.Create("majorEngineVersion", "String!"),
            };
            List<OptionGroup>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<OptionGroup>)psObject.BaseObject;
                } else {
                    fields = (List<OptionGroup>)this.Field;
                }
            }
            string document = Query.AllOptionGroupsByRegionFromAws(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllOptionGroupsByRegionFromAws");
            var parameters = "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$dbEngine: AwsNativeRdsDbEngine!,$dbEngineVersion: String!,$majorEngineVersion: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllOptionGroupsByRegionFromAws" + parameters + "{" + document + "}",
                OperationName = "QueryAllOptionGroupsByRegionFromAws",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<OptionGroup>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allDbParameterGroupsByRegionFromAws(
        //     awsAccountRubrikId: UUID!
        //     region: AwsNativeRegion!
        //     dbEngine: AwsNativeRdsDbEngine!
        //     dbEngineVersion: String!
        //     rdsType: AwsNativeRdsType
        //   ): [DbParameterGroup!]!
        protected void InvokeQueryAllDbParameterGroupsByRegionFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("dbEngine", "AwsNativeRdsDbEngine!"),
                Tuple.Create("dbEngineVersion", "String!"),
                Tuple.Create("rdsType", "AwsNativeRdsType"),
            };
            List<DbParameterGroup>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<DbParameterGroup>)psObject.BaseObject;
                } else {
                    fields = (List<DbParameterGroup>)this.Field;
                }
            }
            string document = Query.AllDbParameterGroupsByRegionFromAws(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllDbParameterGroupsByRegionFromAws");
            var parameters = "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$dbEngine: AwsNativeRdsDbEngine!,$dbEngineVersion: String!,$rdsType: AwsNativeRdsType)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllDbParameterGroupsByRegionFromAws" + parameters + "{" + document + "}",
                OperationName = "QueryAllDbParameterGroupsByRegionFromAws",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<DbParameterGroup>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allDbSubnetGroupsByRegionFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion!): [SubnetGroup!]!
        protected void InvokeQueryAllDbSubnetGroupsByRegionFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
            };
            List<SubnetGroup>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<SubnetGroup>)psObject.BaseObject;
                } else {
                    fields = (List<SubnetGroup>)this.Field;
                }
            }
            string document = Query.AllDbSubnetGroupsByRegionFromAws(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllDbSubnetGroupsByRegionFromAws");
            var parameters = "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllDbSubnetGroupsByRegionFromAws" + parameters + "{" + document + "}",
                OperationName = "QueryAllDbSubnetGroupsByRegionFromAws",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<SubnetGroup>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // validateAwsNativeRdsInstanceNameForExport(awsAccountRubrikId: UUID!, region: AwsNativeRegion!, rdsInstanceName: String!): ValidateAwsNativeRdsInstanceNameForExportReply!
        protected void InvokeQueryValidateAwsNativeRdsInstanceNameForExport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("rdsInstanceName", "String!"),
            };
            ValidateAwsNativeRdsInstanceNameForExportReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (ValidateAwsNativeRdsInstanceNameForExportReply)psObject.BaseObject;
                } else {
                    fields = (ValidateAwsNativeRdsInstanceNameForExportReply)this.Field;
                }
            }
            string document = Query.ValidateAwsNativeRdsInstanceNameForExport(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ValidateAwsNativeRdsInstanceNameForExport");
            var parameters = "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$rdsInstanceName: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryValidateAwsNativeRdsInstanceNameForExport" + parameters + "{" + document + "}",
                OperationName = "QueryValidateAwsNativeRdsInstanceNameForExport",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "ValidateAwsNativeRdsInstanceNameForExportReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // validateAwsNativeRdsClusterNameForExport(awsAccountRubrikId: UUID!, region: AwsNativeRegion!, rdsClusterName: String!): ValidateAwsNativeRdsClusterNameForExportReply!
        protected void InvokeQueryValidateAwsNativeRdsClusterNameForExport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("rdsClusterName", "String!"),
            };
            ValidateAwsNativeRdsClusterNameForExportReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (ValidateAwsNativeRdsClusterNameForExportReply)psObject.BaseObject;
                } else {
                    fields = (ValidateAwsNativeRdsClusterNameForExportReply)this.Field;
                }
            }
            string document = Query.ValidateAwsNativeRdsClusterNameForExport(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ValidateAwsNativeRdsClusterNameForExport");
            var parameters = "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$rdsClusterName: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryValidateAwsNativeRdsClusterNameForExport" + parameters + "{" + document + "}",
                OperationName = "QueryValidateAwsNativeRdsClusterNameForExport",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "ValidateAwsNativeRdsClusterNameForExportReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // awsNativeRdsExportDefaults(rdsInstanceRubrikId: UUID!, snapshotId: String, isPointInTime: Boolean!): RdsInstanceExportDefaults!
        protected void InvokeQueryAwsNativeRdsExportDefaults()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("rdsInstanceRubrikId", "UUID!"),
                Tuple.Create("snapshotId", "String"),
                Tuple.Create("isPointInTime", "Boolean!"),
            };
            RdsInstanceExportDefaults? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (RdsInstanceExportDefaults)psObject.BaseObject;
                } else {
                    fields = (RdsInstanceExportDefaults)this.Field;
                }
            }
            string document = Query.AwsNativeRdsExportDefaults(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AwsNativeRdsExportDefaults");
            var parameters = "($rdsInstanceRubrikId: UUID!,$snapshotId: String,$isPointInTime: Boolean!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAwsNativeRdsExportDefaults" + parameters + "{" + document + "}",
                OperationName = "QueryAwsNativeRdsExportDefaults",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "RdsInstanceExportDefaults", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allEc2KeyPairsByRegionFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion!): [String!]!
        protected void InvokeQueryAllEc2KeyPairsByRegionFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
            };
            List<System.String>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<System.String>)psObject.BaseObject;
                } else {
                    fields = (List<System.String>)this.Field;
                }
            }
            string document = Query.AllEc2KeyPairsByRegionFromAws(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllEc2KeyPairsByRegionFromAws");
            var parameters = "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllEc2KeyPairsByRegionFromAws" + parameters + "{" + document + "}",
                OperationName = "QueryAllEc2KeyPairsByRegionFromAws",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<System.String>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // amiTypeForAwsNativeArchivedSnapshotExport(input: AmiTypeForAwsNativeArchivedSnapshotExportInput!): AmiTypeForAwsNativeArchivedSnapshotExportReply!
        protected void InvokeQueryAmiTypeForAwsNativeArchivedSnapshotExport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AmiTypeForAwsNativeArchivedSnapshotExportInput!"),
            };
            AmiTypeForAwsNativeArchivedSnapshotExportReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AmiTypeForAwsNativeArchivedSnapshotExportReply)psObject.BaseObject;
                } else {
                    fields = (AmiTypeForAwsNativeArchivedSnapshotExportReply)this.Field;
                }
            }
            string document = Query.AmiTypeForAwsNativeArchivedSnapshotExport(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AmiTypeForAwsNativeArchivedSnapshotExport");
            var parameters = "($input: AmiTypeForAwsNativeArchivedSnapshotExportInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAmiTypeForAwsNativeArchivedSnapshotExport" + parameters + "{" + document + "}",
                OperationName = "QueryAmiTypeForAwsNativeArchivedSnapshotExport",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AmiTypeForAwsNativeArchivedSnapshotExportReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allAwsRdsAuroraInstanceClasses: AwsNativeRdsAuroraInstanceClassesReply!
        protected void InvokeQueryAllAwsRdsAuroraInstanceClasses()
        {
            Tuple<string, string>[] argDefs = {
            };
            AwsNativeRdsAuroraInstanceClassesReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AwsNativeRdsAuroraInstanceClassesReply)psObject.BaseObject;
                } else {
                    fields = (AwsNativeRdsAuroraInstanceClassesReply)this.Field;
                }
            }
            string document = Query.AllAwsRdsAuroraInstanceClasses(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAwsRdsAuroraInstanceClasses");
            var parameters = "";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAwsRdsAuroraInstanceClasses" + parameters + "{" + document + "}",
                OperationName = "QueryAllAwsRdsAuroraInstanceClasses",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            var result = this._rbkClient.Invoke(
                request, vars, "AwsNativeRdsAuroraInstanceClassesReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allSupportedAwsRdsDatabaseInstanceClasses(
        //     awsAccountRubrikId: UUID!
        //     region: AwsNativeRegion!
        //     dbEngine: AwsNativeRdsDbEngine!
        //     dbEngineVersion: String
        //   ): [String!]!
        protected void InvokeQueryAllSupportedAwsRdsDatabaseInstanceClasses()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("dbEngine", "AwsNativeRdsDbEngine!"),
                Tuple.Create("dbEngineVersion", "String"),
            };
            List<System.String>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<System.String>)psObject.BaseObject;
                } else {
                    fields = (List<System.String>)this.Field;
                }
            }
            string document = Query.AllSupportedAwsRdsDatabaseInstanceClasses(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllSupportedAwsRdsDatabaseInstanceClasses");
            var parameters = "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$dbEngine: AwsNativeRdsDbEngine!,$dbEngineVersion: String)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllSupportedAwsRdsDatabaseInstanceClasses" + parameters + "{" + document + "}",
                OperationName = "QueryAllSupportedAwsRdsDatabaseInstanceClasses",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<System.String>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // awsComputeSettings(computeSettingId: UUID!): AwsComputeSettings!
        protected void InvokeQueryAwsComputeSettings()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("computeSettingId", "UUID!"),
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
            string document = Query.AwsComputeSettings(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AwsComputeSettings");
            var parameters = "($computeSettingId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAwsComputeSettings" + parameters + "{" + document + "}",
                OperationName = "QueryAwsComputeSettings",
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

        // Invoke GraphQL Query:
        // allAwsComputeSettings(
        //     sortBy: AwsCloudComputeSettingQuerySortByField
        //     sortOrder: SortOrder
        //     filter: [AwsCloudComputeSettingFilterInput!]
        //     contextFilter: ContextFilterTypeEnum
        //   ): [AwsComputeSettings!]!
        protected void InvokeQueryAllAwsComputeSettings()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("sortBy", "AwsCloudComputeSettingQuerySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[AwsCloudComputeSettingFilterInput!]"),
                Tuple.Create("contextFilter", "ContextFilterTypeEnum"),
            };
            List<AwsComputeSettings>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<AwsComputeSettings>)psObject.BaseObject;
                } else {
                    fields = (List<AwsComputeSettings>)this.Field;
                }
            }
            string document = Query.AllAwsComputeSettings(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAwsComputeSettings");
            var parameters = "($sortBy: AwsCloudComputeSettingQuerySortByField,$sortOrder: SortOrder,$filter: [AwsCloudComputeSettingFilterInput!],$contextFilter: ContextFilterTypeEnum)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAwsComputeSettings" + parameters + "{" + document + "}",
                OperationName = "QueryAllAwsComputeSettings",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<AwsComputeSettings>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allAwsCloudAccountsWithFeatures(awsCloudAccountsArg: AwsCloudAccountsWithFeaturesInput!): [AwsCloudAccountWithFeatures!]!
        protected void InvokeQueryAllAwsCloudAccountsWithFeatures()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsCloudAccountsArg", "AwsCloudAccountsWithFeaturesInput!"),
            };
            List<AwsCloudAccountWithFeatures>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<AwsCloudAccountWithFeatures>)psObject.BaseObject;
                } else {
                    fields = (List<AwsCloudAccountWithFeatures>)this.Field;
                }
            }
            string document = Query.AllAwsCloudAccountsWithFeatures(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAwsCloudAccountsWithFeatures");
            var parameters = "($awsCloudAccountsArg: AwsCloudAccountsWithFeaturesInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAwsCloudAccountsWithFeatures" + parameters + "{" + document + "}",
                OperationName = "QueryAllAwsCloudAccountsWithFeatures",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<AwsCloudAccountWithFeatures>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allAwsCloudAccountsFeaturesWithExoConfigs(awsCloudAccountsArg: AwsCloudAccountsWithFeaturesInput!): [AwsCloudAccountFeaturesWithExoConfigs!]!
        protected void InvokeQueryAllAwsCloudAccountsFeaturesWithExoConfigs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsCloudAccountsArg", "AwsCloudAccountsWithFeaturesInput!"),
            };
            List<AwsCloudAccountFeaturesWithExoConfigs>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<AwsCloudAccountFeaturesWithExoConfigs>)psObject.BaseObject;
                } else {
                    fields = (List<AwsCloudAccountFeaturesWithExoConfigs>)this.Field;
                }
            }
            string document = Query.AllAwsCloudAccountsFeaturesWithExoConfigs(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAwsCloudAccountsFeaturesWithExoConfigs");
            var parameters = "($awsCloudAccountsArg: AwsCloudAccountsWithFeaturesInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAwsCloudAccountsFeaturesWithExoConfigs" + parameters + "{" + document + "}",
                OperationName = "QueryAllAwsCloudAccountsFeaturesWithExoConfigs",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<AwsCloudAccountFeaturesWithExoConfigs>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // awsCloudAccountWithFeatures(cloudAccountId: UUID!, awsCloudAccountArg: AwsCloudAccountWithFeaturesInput!): AwsCloudAccountWithFeatures!
        protected void InvokeQueryAwsCloudAccountWithFeatures()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "UUID!"),
                Tuple.Create("awsCloudAccountArg", "AwsCloudAccountWithFeaturesInput!"),
            };
            AwsCloudAccountWithFeatures? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AwsCloudAccountWithFeatures)psObject.BaseObject;
                } else {
                    fields = (AwsCloudAccountWithFeatures)this.Field;
                }
            }
            string document = Query.AwsCloudAccountWithFeatures(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AwsCloudAccountWithFeatures");
            var parameters = "($cloudAccountId: UUID!,$awsCloudAccountArg: AwsCloudAccountWithFeaturesInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAwsCloudAccountWithFeatures" + parameters + "{" + document + "}",
                OperationName = "QueryAwsCloudAccountWithFeatures",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AwsCloudAccountWithFeatures", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // awsCloudAccountListVpcs(cloudAccountUuid: UUID!, feature: CloudAccountFeature!, region: AwsRegion!): AwsCloudAccountListVpcResponse!
        protected void InvokeQueryAwsCloudAccountListVpcs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountUuid", "UUID!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("region", "AwsRegion!"),
            };
            AwsCloudAccountListVpcResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AwsCloudAccountListVpcResponse)psObject.BaseObject;
                } else {
                    fields = (AwsCloudAccountListVpcResponse)this.Field;
                }
            }
            string document = Query.AwsCloudAccountListVpcs(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AwsCloudAccountListVpcs");
            var parameters = "($cloudAccountUuid: UUID!,$feature: CloudAccountFeature!,$region: AwsRegion!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAwsCloudAccountListVpcs" + parameters + "{" + document + "}",
                OperationName = "QueryAwsCloudAccountListVpcs",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AwsCloudAccountListVpcResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // awsCloudAccountListSubnets(
        //     cloudAccountUuid: UUID!
        //     feature: CloudAccountFeature!
        //     region: AwsRegion!
        //     vpcID: String!
        //   ): AwsCloudAccountListSubnetsResponse!
        protected void InvokeQueryAwsCloudAccountListSubnets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountUuid", "UUID!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("region", "AwsRegion!"),
                Tuple.Create("vpcID", "String!"),
            };
            AwsCloudAccountListSubnetsResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AwsCloudAccountListSubnetsResponse)psObject.BaseObject;
                } else {
                    fields = (AwsCloudAccountListSubnetsResponse)this.Field;
                }
            }
            string document = Query.AwsCloudAccountListSubnets(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AwsCloudAccountListSubnets");
            var parameters = "($cloudAccountUuid: UUID!,$feature: CloudAccountFeature!,$region: AwsRegion!,$vpcID: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAwsCloudAccountListSubnets" + parameters + "{" + document + "}",
                OperationName = "QueryAwsCloudAccountListSubnets",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AwsCloudAccountListSubnetsResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // awsCloudAccountListSecurityGroups(
        //     cloudAccountUuid: UUID!
        //     feature: CloudAccountFeature!
        //     region: AwsRegion!
        //     vpcID: String!
        //   ): AwsCloudAccountListSecurityGroupsResponse!
        protected void InvokeQueryAwsCloudAccountListSecurityGroups()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountUuid", "UUID!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("region", "AwsRegion!"),
                Tuple.Create("vpcID", "String!"),
            };
            AwsCloudAccountListSecurityGroupsResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AwsCloudAccountListSecurityGroupsResponse)psObject.BaseObject;
                } else {
                    fields = (AwsCloudAccountListSecurityGroupsResponse)this.Field;
                }
            }
            string document = Query.AwsCloudAccountListSecurityGroups(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AwsCloudAccountListSecurityGroups");
            var parameters = "($cloudAccountUuid: UUID!,$feature: CloudAccountFeature!,$region: AwsRegion!,$vpcID: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAwsCloudAccountListSecurityGroups" + parameters + "{" + document + "}",
                OperationName = "QueryAwsCloudAccountListSecurityGroups",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AwsCloudAccountListSecurityGroupsResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // AwsCloudAccountListKMSKeys(cloudAccountUuid: UUID!, feature: CloudAccountFeature!, region: AwsRegion!): AwsCloudAccountListKMSKeysResponse!
        protected void InvokeQueryAwsCloudAccountListKmsKeys()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountUuid", "UUID!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("region", "AwsRegion!"),
            };
            AwsCloudAccountListKmsKeysResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AwsCloudAccountListKmsKeysResponse)psObject.BaseObject;
                } else {
                    fields = (AwsCloudAccountListKmsKeysResponse)this.Field;
                }
            }
            string document = Query.AwsCloudAccountListKmsKeys(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AwsCloudAccountListKmsKeys");
            var parameters = "($cloudAccountUuid: UUID!,$feature: CloudAccountFeature!,$region: AwsRegion!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAwsCloudAccountListKmsKeys" + parameters + "{" + document + "}",
                OperationName = "QueryAwsCloudAccountListKmsKeys",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AwsCloudAccountListKmsKeysResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allAwsExocomputeConfigs(awsNativeAccountIdOrNamePrefix: String!): [AwsExocomputeConfig!]!
        protected void InvokeQueryAllAwsExocomputeConfigs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsNativeAccountIdOrNamePrefix", "String!"),
            };
            List<AwsExocomputeConfig>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<AwsExocomputeConfig>)psObject.BaseObject;
                } else {
                    fields = (List<AwsExocomputeConfig>)this.Field;
                }
            }
            string document = Query.AllAwsExocomputeConfigs(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAwsExocomputeConfigs");
            var parameters = "($awsNativeAccountIdOrNamePrefix: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAwsExocomputeConfigs" + parameters + "{" + document + "}",
                OperationName = "QueryAllAwsExocomputeConfigs",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<AwsExocomputeConfig>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allAwsCloudAccountConfigs(awsCloudAccountsArg: AwsCloudAccountConfigsInput!): [AwsFeatureConfig!]!
        protected void InvokeQueryAllAwsCloudAccountConfigs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsCloudAccountsArg", "AwsCloudAccountConfigsInput!"),
            };
            List<AwsFeatureConfig>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<AwsFeatureConfig>)psObject.BaseObject;
                } else {
                    fields = (List<AwsFeatureConfig>)this.Field;
                }
            }
            string document = Query.AllAwsCloudAccountConfigs(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAwsCloudAccountConfigs");
            var parameters = "($awsCloudAccountsArg: AwsCloudAccountConfigsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAwsCloudAccountConfigs" + parameters + "{" + document + "}",
                OperationName = "QueryAllAwsCloudAccountConfigs",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<AwsFeatureConfig>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allAwsRegions(cloudAccountId: String!): [AwsCloudAccountRegion!]!
        protected void InvokeQueryAllAwsRegions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "String!"),
            };
            List<AwsCloudAccountRegion>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<AwsCloudAccountRegion>)psObject.BaseObject;
                } else {
                    fields = (List<AwsCloudAccountRegion>)this.Field;
                }
            }
            string document = Query.AllAwsRegions(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAwsRegions");
            var parameters = "($cloudAccountId: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAwsRegions" + parameters + "{" + document + "}",
                OperationName = "QueryAllAwsRegions",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<AwsCloudAccountRegion>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allAwsCdmVersions(input: AwsCdmVersionRequest!): [AwsCdmVersion!]!
        protected void InvokeQueryAllAwsCdmVersions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AwsCdmVersionRequest!"),
            };
            List<AwsCdmVersion>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<AwsCdmVersion>)psObject.BaseObject;
                } else {
                    fields = (List<AwsCdmVersion>)this.Field;
                }
            }
            string document = Query.AllAwsCdmVersions(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAwsCdmVersions");
            var parameters = "($input: AwsCdmVersionRequest!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAwsCdmVersions" + parameters + "{" + document + "}",
                OperationName = "QueryAllAwsCdmVersions",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<AwsCdmVersion>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allAwsInstanceProfileNames(cloudAccountId: String!, region: String!): [String!]!
        protected void InvokeQueryAllAwsInstanceProfileNames()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "String!"),
                Tuple.Create("region", "String!"),
            };
            List<System.String>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<System.String>)psObject.BaseObject;
                } else {
                    fields = (List<System.String>)this.Field;
                }
            }
            string document = Query.AllAwsInstanceProfileNames(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAwsInstanceProfileNames");
            var parameters = "($cloudAccountId: String!,$region: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAwsInstanceProfileNames" + parameters + "{" + document + "}",
                OperationName = "QueryAllAwsInstanceProfileNames",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<System.String>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }


    } // class Invoke_RscQueryAws
}