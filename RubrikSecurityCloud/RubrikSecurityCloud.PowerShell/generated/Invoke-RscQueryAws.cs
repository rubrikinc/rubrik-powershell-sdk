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
        DefaultParameterSetName = "AllVpcs")
    ]
    public class Invoke_RscQueryAws : RscPSCmdlet
    {
        
        /// <summary>
        /// NativeRoot parameter set
        ///
        /// [GraphQL: awsNativeRoot]
        /// </summary>
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

        
        /// <summary>
        /// NativeAccount parameter set
        ///
        /// [GraphQL: awsNativeAccount]
        /// </summary>
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

        
        /// <summary>
        /// NativeEc2Instance parameter set
        ///
        /// [GraphQL: awsNativeEc2Instance]
        /// </summary>
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

        
        /// <summary>
        /// NativeEbsVolume parameter set
        ///
        /// [GraphQL: awsNativeEbsVolume]
        /// </summary>
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

        
        /// <summary>
        /// NativeS3Bucket parameter set
        ///
        /// [GraphQL: awsNativeS3Bucket]
        /// </summary>
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

        
        /// <summary>
        /// NativeAccounts parameter set
        ///
        /// [GraphQL: awsNativeAccounts]
        /// </summary>
        [Parameter(
            ParameterSetName = "NativeAccounts",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of all AWS Native accounts.
[GraphQL: awsNativeAccounts]",
            Position = 0
        )]
        public SwitchParameter NativeAccounts { get; set; }

        
        /// <summary>
        /// NativeEc2InstancesByName parameter set
        ///
        /// [GraphQL: awsNativeEc2InstancesByName]
        /// </summary>
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

        
        /// <summary>
        /// NativeEc2Instances parameter set
        ///
        /// [GraphQL: awsNativeEc2Instances]
        /// </summary>
        [Parameter(
            ParameterSetName = "NativeEc2Instances",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of all AWS EC2 Instances.
[GraphQL: awsNativeEc2Instances]",
            Position = 0
        )]
        public SwitchParameter NativeEc2Instances { get; set; }

        
        /// <summary>
        /// NativeEbsVolumesByName parameter set
        ///
        /// [GraphQL: awsNativeEbsVolumesByName]
        /// </summary>
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

        
        /// <summary>
        /// NativeEbsVolumes parameter set
        ///
        /// [GraphQL: awsNativeEbsVolumes]
        /// </summary>
        [Parameter(
            ParameterSetName = "NativeEbsVolumes",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of all AWS EBS Volumes.
[GraphQL: awsNativeEbsVolumes]",
            Position = 0
        )]
        public SwitchParameter NativeEbsVolumes { get; set; }

        
        /// <summary>
        /// AllVpcsByRegion parameter set
        ///
        /// [GraphQL: allVpcsByRegionFromAws]
        /// </summary>
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

        
        /// <summary>
        /// AllVpcs parameter set
        ///
        /// [GraphQL: allVpcsFromAws]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllVpcs",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all Virtual Private Clouds (VPCs) in the AWS Native account.
[GraphQL: allVpcsFromAws]",
            Position = 0
        )]
        public SwitchParameter AllVpcs { get; set; }

        
        /// <summary>
        /// IsNativeEbsVolumeSnapshotRestorable parameter set
        ///
        /// [GraphQL: isAwsNativeEbsVolumeSnapshotRestorable]
        /// </summary>
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

        
        /// <summary>
        /// AllAvailabilityZonesByRegion parameter set
        ///
        /// [GraphQL: allAvailabilityZonesByRegionFromAws]
        /// </summary>
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

        
        /// <summary>
        /// AllKmsEncryptionKeysByRegion parameter set
        ///
        /// [GraphQL: allKmsEncryptionKeysByRegionFromAws]
        /// </summary>
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

        
        /// <summary>
        /// IsS3BucketNameAvailable parameter set
        ///
        /// [GraphQL: isAwsS3BucketNameAvailable]
        /// </summary>
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

        
        /// <summary>
        /// AllS3Buckets parameter set
        ///
        /// [GraphQL: allS3BucketsFromAws]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllS3Buckets",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all S3 bucket names across regions for the AWS Native account.
[GraphQL: allS3BucketsFromAws]",
            Position = 0
        )]
        public SwitchParameter AllS3Buckets { get; set; }

        
        /// <summary>
        /// AllS3BucketsDetails parameter set
        ///
        /// [GraphQL: allS3BucketsDetailsFromAws]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllS3BucketsDetails",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all S3 bucket details across regions for the AWS Native account.
[GraphQL: allS3BucketsDetailsFromAws]",
            Position = 0
        )]
        public SwitchParameter AllS3BucketsDetails { get; set; }

        
        /// <summary>
        /// NativeRdsInstance parameter set
        ///
        /// [GraphQL: awsNativeRdsInstance]
        /// </summary>
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

        
        /// <summary>
        /// NativeRdsInstances parameter set
        ///
        /// [GraphQL: awsNativeRdsInstances]
        /// </summary>
        [Parameter(
            ParameterSetName = "NativeRdsInstances",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of AWS RDS Instances on AWS Native account.
[GraphQL: awsNativeRdsInstances]",
            Position = 0
        )]
        public SwitchParameter NativeRdsInstances { get; set; }

        
        /// <summary>
        /// NativeRdsPointInTimeRestoreWindow parameter set
        ///
        /// [GraphQL: awsNativeRdsPointInTimeRestoreWindow]
        /// </summary>
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

        
        /// <summary>
        /// RdsInstanceDetails parameter set
        ///
        /// [GraphQL: rdsInstanceDetailsFromAws]
        /// </summary>
        [Parameter(
            ParameterSetName = "RdsInstanceDetails",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Details of the RDS Instance in the AWS Native account.
[GraphQL: rdsInstanceDetailsFromAws]",
            Position = 0
        )]
        public SwitchParameter RdsInstanceDetails { get; set; }

        
        /// <summary>
        /// IsNativeRdsInstanceLaunchConfigurationValid parameter set
        ///
        /// [GraphQL: isAwsNativeRdsInstanceLaunchConfigurationValid]
        /// </summary>
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

        
        /// <summary>
        /// AllOptionGroupsByRegion parameter set
        ///
        /// [GraphQL: allOptionGroupsByRegionFromAws]
        /// </summary>
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

        
        /// <summary>
        /// AllDbParameterGroupsByRegion parameter set
        ///
        /// [GraphQL: allDbParameterGroupsByRegionFromAws]
        /// </summary>
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

        
        /// <summary>
        /// AllDbSubnetGroupsByRegion parameter set
        ///
        /// [GraphQL: allDbSubnetGroupsByRegionFromAws]
        /// </summary>
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

        
        /// <summary>
        /// ValidateNativeRdsInstanceNameForExport parameter set
        ///
        /// [GraphQL: validateAwsNativeRdsInstanceNameForExport]
        /// </summary>
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

        
        /// <summary>
        /// ValidateNativeRdsClusterNameForExport parameter set
        ///
        /// [GraphQL: validateAwsNativeRdsClusterNameForExport]
        /// </summary>
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

        
        /// <summary>
        /// NativeRdsExportDefaults parameter set
        ///
        /// [GraphQL: awsNativeRdsExportDefaults]
        /// </summary>
        [Parameter(
            ParameterSetName = "NativeRdsExportDefaults",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Refers to the default values for the export operation of the RDS DB Instance in the AWS Native account.
[GraphQL: awsNativeRdsExportDefaults]",
            Position = 0
        )]
        public SwitchParameter NativeRdsExportDefaults { get; set; }

        
        /// <summary>
        /// AllEc2KeyPairsByRegion parameter set
        ///
        /// [GraphQL: allEc2KeyPairsByRegionFromAws]
        /// </summary>
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

        
        /// <summary>
        /// AmiTypeForNativeArchivedSnapshotExport parameter set
        ///
        /// [GraphQL: amiTypeForAwsNativeArchivedSnapshotExport]
        /// </summary>
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

        
        /// <summary>
        /// AllRdsAuroraInstanceClasses parameter set
        ///
        /// [GraphQL: allAwsRdsAuroraInstanceClasses]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllRdsAuroraInstanceClasses",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all the database instance classes supported by AWS RDS Aurora databases.
[GraphQL: allAwsRdsAuroraInstanceClasses]",
            Position = 0
        )]
        public SwitchParameter AllRdsAuroraInstanceClasses { get; set; }

        
        /// <summary>
        /// AllSupportedRdsDatabaseInstanceClasses parameter set
        ///
        /// [GraphQL: allSupportedAwsRdsDatabaseInstanceClasses]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllSupportedRdsDatabaseInstanceClasses",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all the database instance classes supported by AWS RDS database for the provided DB engine and engine version. DB engine version is a optional argument, it can be ignored if we want to retrieve all the supported instance class for a DB engine irrespective of DB engine version.
[GraphQL: allSupportedAwsRdsDatabaseInstanceClasses]",
            Position = 0
        )]
        public SwitchParameter AllSupportedRdsDatabaseInstanceClasses { get; set; }

        
        /// <summary>
        /// ComputeSettings parameter set
        ///
        /// [GraphQL: awsComputeSettings]
        /// </summary>
        [Parameter(
            ParameterSetName = "ComputeSettings",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieve aws compute settings.
[GraphQL: awsComputeSettings]",
            Position = 0
        )]
        public SwitchParameter ComputeSettings { get; set; }

        
        /// <summary>
        /// AllComputeSettings parameter set
        ///
        /// [GraphQL: allAwsComputeSettings]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllComputeSettings",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List all aws compute settings.
[GraphQL: allAwsComputeSettings]",
            Position = 0
        )]
        public SwitchParameter AllComputeSettings { get; set; }

        
        /// <summary>
        /// AllCloudAccountsWithFeatures parameter set
        ///
        /// [GraphQL: allAwsCloudAccountsWithFeatures]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllCloudAccountsWithFeatures",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of active AWS cloud accounts and the features for the accounts. A cloud account is an AWS account added to the Rubrik platform.
[GraphQL: allAwsCloudAccountsWithFeatures]",
            Position = 0
        )]
        public SwitchParameter AllCloudAccountsWithFeatures { get; set; }

        
        /// <summary>
        /// AllCloudAccountsFeaturesWithExoConfigs parameter set
        ///
        /// [GraphQL: allAwsCloudAccountsFeaturesWithExoConfigs]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllCloudAccountsFeaturesWithExoConfigs",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of active AWS cloud account features and the Exocompute mapping information for the accounts. A cloud account is an AWS account added to the Rubrik platform.
[GraphQL: allAwsCloudAccountsFeaturesWithExoConfigs]",
            Position = 0
        )]
        public SwitchParameter AllCloudAccountsFeaturesWithExoConfigs { get; set; }

        
        /// <summary>
        /// CloudAccountWithFeatures parameter set
        ///
        /// [GraphQL: awsCloudAccountWithFeatures]
        /// </summary>
        [Parameter(
            ParameterSetName = "CloudAccountWithFeatures",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of AWS cloud accounts and the features for each account, classified by ID.
[GraphQL: awsCloudAccountWithFeatures]",
            Position = 0
        )]
        public SwitchParameter CloudAccountWithFeatures { get; set; }

        
        /// <summary>
        /// CloudAccountListVpcs parameter set
        ///
        /// [GraphQL: awsCloudAccountListVpcs]
        /// </summary>
        [Parameter(
            ParameterSetName = "CloudAccountListVpcs",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a list of virtual private clouds (VPCs) in the specific cloud account.
[GraphQL: awsCloudAccountListVpcs]",
            Position = 0
        )]
        public SwitchParameter CloudAccountListVpcs { get; set; }

        
        /// <summary>
        /// CloudAccountListSubnets parameter set
        ///
        /// [GraphQL: awsCloudAccountListSubnets]
        /// </summary>
        [Parameter(
            ParameterSetName = "CloudAccountListSubnets",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a list of subnets in the specified cloud account and virtual private cloud (VPC).
[GraphQL: awsCloudAccountListSubnets]",
            Position = 0
        )]
        public SwitchParameter CloudAccountListSubnets { get; set; }

        
        /// <summary>
        /// CloudAccountListSecurityGroups parameter set
        ///
        /// [GraphQL: awsCloudAccountListSecurityGroups]
        /// </summary>
        [Parameter(
            ParameterSetName = "CloudAccountListSecurityGroups",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a list of security groups in the specified cloud account and virtual private cloud (VPC).
[GraphQL: awsCloudAccountListSecurityGroups]",
            Position = 0
        )]
        public SwitchParameter CloudAccountListSecurityGroups { get; set; }

        
        /// <summary>
        /// CloudAccountListKMSKeys parameter set
        ///
        /// [GraphQL: AwsCloudAccountListKMSKeys]
        /// </summary>
        [Parameter(
            ParameterSetName = "CloudAccountListKMSKeys",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: AwsCloudAccountListKMSKeys]",
            Position = 0
        )]
        public SwitchParameter CloudAccountListKMSKeys { get; set; }

        
        /// <summary>
        /// AllExocomputeConfigs parameter set
        ///
        /// [GraphQL: allAwsExocomputeConfigs]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllExocomputeConfigs",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all AWS exocompute configurations filtered by a cloud account ID or a cloud account name prefix.
[GraphQL: allAwsExocomputeConfigs]",
            Position = 0
        )]
        public SwitchParameter AllExocomputeConfigs { get; set; }

        
        /// <summary>
        /// AllCloudAccountConfigs parameter set
        ///
        /// [GraphQL: allAwsCloudAccountConfigs]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllCloudAccountConfigs",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all AWS cloud account configurations with the given search query.
[GraphQL: allAwsCloudAccountConfigs]",
            Position = 0
        )]
        public SwitchParameter AllCloudAccountConfigs { get; set; }

        
        /// <summary>
        /// TrustPolicy parameter set
        ///
        /// [GraphQL: awsTrustPolicy]
        /// </summary>
        [Parameter(
            ParameterSetName = "TrustPolicy",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves the AWS trust policy that will be attached with each role (cross-account, exocompute, etc.) in the customer's environment.
[GraphQL: awsTrustPolicy]",
            Position = 0
        )]
        public SwitchParameter TrustPolicy { get; set; }

        
        /// <summary>
        /// AllPermissionPolicies parameter set
        ///
        /// [GraphQL: allAwsPermissionPolicies]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllPermissionPolicies",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves the permissions policy for all the input features along with any AWS-managed policy ARNs which need to be attached to the roles. Each policy document can be used to create an AWS-managed policy which then needs to be attached to corresponding role.
[GraphQL: allAwsPermissionPolicies]",
            Position = 0
        )]
        public SwitchParameter AllPermissionPolicies { get; set; }

        
        /// <summary>
        /// ArtifactsToDelete parameter set
        ///
        /// [GraphQL: awsArtifactsToDelete]
        /// </summary>
        [Parameter(
            ParameterSetName = "ArtifactsToDelete",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves the AWS artifacts that need to be deleted when an account is being deleted.
[GraphQL: awsArtifactsToDelete]",
            Position = 0
        )]
        public SwitchParameter ArtifactsToDelete { get; set; }

        
        /// <summary>
        /// AllRegions parameter set
        ///
        /// [GraphQL: allAwsRegions]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllRegions",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"All valid AWS regions for this cloud account.
[GraphQL: allAwsRegions]",
            Position = 0
        )]
        public SwitchParameter AllRegions { get; set; }

        
        /// <summary>
        /// AllCdmVersions parameter set
        ///
        /// [GraphQL: allAwsCdmVersions]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllCdmVersions",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get all Rubrik CDM versions in the AWS marketplace.
[GraphQL: allAwsCdmVersions]",
            Position = 0
        )]
        public SwitchParameter AllCdmVersions { get; set; }

        
        /// <summary>
        /// AllInstanceProfileNames parameter set
        ///
        /// [GraphQL: allAwsInstanceProfileNames]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllInstanceProfileNames",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"All Rubrik CC-ES instance profiles in the AWS account.
[GraphQL: allAwsInstanceProfileNames]",
            Position = 0
        )]
        public SwitchParameter AllInstanceProfileNames { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
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
                    case "NativeAccounts":
                        this.ProcessRecord_NativeAccounts();
                        break;
                    case "NativeEc2InstancesByName":
                        this.ProcessRecord_NativeEc2InstancesByName();
                        break;
                    case "NativeEc2Instances":
                        this.ProcessRecord_NativeEc2Instances();
                        break;
                    case "NativeEbsVolumesByName":
                        this.ProcessRecord_NativeEbsVolumesByName();
                        break;
                    case "NativeEbsVolumes":
                        this.ProcessRecord_NativeEbsVolumes();
                        break;
                    case "AllVpcsByRegion":
                        this.ProcessRecord_AllVpcsByRegion();
                        break;
                    case "AllVpcs":
                        this.ProcessRecord_AllVpcs();
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
                    case "AllS3Buckets":
                        this.ProcessRecord_AllS3Buckets();
                        break;
                    case "AllS3BucketsDetails":
                        this.ProcessRecord_AllS3BucketsDetails();
                        break;
                    case "NativeRdsInstance":
                        this.ProcessRecord_NativeRdsInstance();
                        break;
                    case "NativeRdsInstances":
                        this.ProcessRecord_NativeRdsInstances();
                        break;
                    case "NativeRdsPointInTimeRestoreWindow":
                        this.ProcessRecord_NativeRdsPointInTimeRestoreWindow();
                        break;
                    case "RdsInstanceDetails":
                        this.ProcessRecord_RdsInstanceDetails();
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
                    case "NativeRdsExportDefaults":
                        this.ProcessRecord_NativeRdsExportDefaults();
                        break;
                    case "AllEc2KeyPairsByRegion":
                        this.ProcessRecord_AllEc2KeyPairsByRegion();
                        break;
                    case "AmiTypeForNativeArchivedSnapshotExport":
                        this.ProcessRecord_AmiTypeForNativeArchivedSnapshotExport();
                        break;
                    case "AllRdsAuroraInstanceClasses":
                        this.ProcessRecord_AllRdsAuroraInstanceClasses();
                        break;
                    case "AllSupportedRdsDatabaseInstanceClasses":
                        this.ProcessRecord_AllSupportedRdsDatabaseInstanceClasses();
                        break;
                    case "ComputeSettings":
                        this.ProcessRecord_ComputeSettings();
                        break;
                    case "AllComputeSettings":
                        this.ProcessRecord_AllComputeSettings();
                        break;
                    case "AllCloudAccountsWithFeatures":
                        this.ProcessRecord_AllCloudAccountsWithFeatures();
                        break;
                    case "AllCloudAccountsFeaturesWithExoConfigs":
                        this.ProcessRecord_AllCloudAccountsFeaturesWithExoConfigs();
                        break;
                    case "CloudAccountWithFeatures":
                        this.ProcessRecord_CloudAccountWithFeatures();
                        break;
                    case "CloudAccountListVpcs":
                        this.ProcessRecord_CloudAccountListVpcs();
                        break;
                    case "CloudAccountListSubnets":
                        this.ProcessRecord_CloudAccountListSubnets();
                        break;
                    case "CloudAccountListSecurityGroups":
                        this.ProcessRecord_CloudAccountListSecurityGroups();
                        break;
                    case "CloudAccountListKMSKeys":
                        this.ProcessRecord_CloudAccountListKMSKeys();
                        break;
                    case "AllExocomputeConfigs":
                        this.ProcessRecord_AllExocomputeConfigs();
                        break;
                    case "AllCloudAccountConfigs":
                        this.ProcessRecord_AllCloudAccountConfigs();
                        break;
                    case "TrustPolicy":
                        this.ProcessRecord_TrustPolicy();
                        break;
                    case "AllPermissionPolicies":
                        this.ProcessRecord_AllPermissionPolicies();
                        break;
                    case "ArtifactsToDelete":
                        this.ProcessRecord_ArtifactsToDelete();
                        break;
                    case "AllRegions":
                        this.ProcessRecord_AllRegions();
                        break;
                    case "AllCdmVersions":
                        this.ProcessRecord_AllCdmVersions();
                        break;
                    case "AllInstanceProfileNames":
                        this.ProcessRecord_AllInstanceProfileNames();
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
        // awsNativeRoot.
        internal void ProcessRecord_NativeRoot()
        {
            this._logger.name += " -NativeRoot";
            // Invoke graphql operation awsNativeRoot
            InvokeQueryAwsNativeRoot();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeAccount.
        internal void ProcessRecord_NativeAccount()
        {
            this._logger.name += " -NativeAccount";
            // Invoke graphql operation awsNativeAccount
            InvokeQueryAwsNativeAccount();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeEc2Instance.
        internal void ProcessRecord_NativeEc2Instance()
        {
            this._logger.name += " -NativeEc2Instance";
            // Invoke graphql operation awsNativeEc2Instance
            InvokeQueryAwsNativeEc2Instance();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeEbsVolume.
        internal void ProcessRecord_NativeEbsVolume()
        {
            this._logger.name += " -NativeEbsVolume";
            // Invoke graphql operation awsNativeEbsVolume
            InvokeQueryAwsNativeEbsVolume();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeS3Bucket.
        internal void ProcessRecord_NativeS3Bucket()
        {
            this._logger.name += " -NativeS3Bucket";
            // Invoke graphql operation awsNativeS3Bucket
            InvokeQueryAwsNativeS3Bucket();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeAccounts.
        internal void ProcessRecord_NativeAccounts()
        {
            this._logger.name += " -NativeAccounts";
            // Invoke graphql operation awsNativeAccounts
            InvokeQueryAwsNativeAccounts();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeEc2InstancesByName.
        internal void ProcessRecord_NativeEc2InstancesByName()
        {
            this._logger.name += " -NativeEc2InstancesByName";
            // Invoke graphql operation awsNativeEc2InstancesByName
            InvokeQueryAwsNativeEc2InstancesByName();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeEc2Instances.
        internal void ProcessRecord_NativeEc2Instances()
        {
            this._logger.name += " -NativeEc2Instances";
            // Invoke graphql operation awsNativeEc2Instances
            InvokeQueryAwsNativeEc2Instances();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeEbsVolumesByName.
        internal void ProcessRecord_NativeEbsVolumesByName()
        {
            this._logger.name += " -NativeEbsVolumesByName";
            // Invoke graphql operation awsNativeEbsVolumesByName
            InvokeQueryAwsNativeEbsVolumesByName();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeEbsVolumes.
        internal void ProcessRecord_NativeEbsVolumes()
        {
            this._logger.name += " -NativeEbsVolumes";
            // Invoke graphql operation awsNativeEbsVolumes
            InvokeQueryAwsNativeEbsVolumes();
        }

        // This parameter set invokes a single graphql operation:
        // allVpcsByRegionFromAws.
        internal void ProcessRecord_AllVpcsByRegion()
        {
            this._logger.name += " -AllVpcsByRegion";
            // Invoke graphql operation allVpcsByRegionFromAws
            InvokeQueryAllVpcsByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allVpcsFromAws.
        internal void ProcessRecord_AllVpcs()
        {
            this._logger.name += " -AllVpcs";
            // Invoke graphql operation allVpcsFromAws
            InvokeQueryAllVpcsFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // isAwsNativeEbsVolumeSnapshotRestorable.
        internal void ProcessRecord_IsNativeEbsVolumeSnapshotRestorable()
        {
            this._logger.name += " -IsNativeEbsVolumeSnapshotRestorable";
            // Invoke graphql operation isAwsNativeEbsVolumeSnapshotRestorable
            InvokeQueryIsAwsNativeEbsVolumeSnapshotRestorable();
        }

        // This parameter set invokes a single graphql operation:
        // allAvailabilityZonesByRegionFromAws.
        internal void ProcessRecord_AllAvailabilityZonesByRegion()
        {
            this._logger.name += " -AllAvailabilityZonesByRegion";
            // Invoke graphql operation allAvailabilityZonesByRegionFromAws
            InvokeQueryAllAvailabilityZonesByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allKmsEncryptionKeysByRegionFromAws.
        internal void ProcessRecord_AllKmsEncryptionKeysByRegion()
        {
            this._logger.name += " -AllKmsEncryptionKeysByRegion";
            // Invoke graphql operation allKmsEncryptionKeysByRegionFromAws
            InvokeQueryAllKmsEncryptionKeysByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // isAwsS3BucketNameAvailable.
        internal void ProcessRecord_IsS3BucketNameAvailable()
        {
            this._logger.name += " -IsS3BucketNameAvailable";
            // Invoke graphql operation isAwsS3BucketNameAvailable
            InvokeQueryIsAwsS3BucketNameAvailable();
        }

        // This parameter set invokes a single graphql operation:
        // allS3BucketsFromAws.
        internal void ProcessRecord_AllS3Buckets()
        {
            this._logger.name += " -AllS3Buckets";
            // Invoke graphql operation allS3BucketsFromAws
            InvokeQueryAllS3BucketsFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allS3BucketsDetailsFromAws.
        internal void ProcessRecord_AllS3BucketsDetails()
        {
            this._logger.name += " -AllS3BucketsDetails";
            // Invoke graphql operation allS3BucketsDetailsFromAws
            InvokeQueryAllS3BucketsDetailsFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeRdsInstance.
        internal void ProcessRecord_NativeRdsInstance()
        {
            this._logger.name += " -NativeRdsInstance";
            // Invoke graphql operation awsNativeRdsInstance
            InvokeQueryAwsNativeRdsInstance();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeRdsInstances.
        internal void ProcessRecord_NativeRdsInstances()
        {
            this._logger.name += " -NativeRdsInstances";
            // Invoke graphql operation awsNativeRdsInstances
            InvokeQueryAwsNativeRdsInstances();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeRdsPointInTimeRestoreWindow.
        internal void ProcessRecord_NativeRdsPointInTimeRestoreWindow()
        {
            this._logger.name += " -NativeRdsPointInTimeRestoreWindow";
            // Invoke graphql operation awsNativeRdsPointInTimeRestoreWindow
            InvokeQueryAwsNativeRdsPointInTimeRestoreWindow();
        }

        // This parameter set invokes a single graphql operation:
        // rdsInstanceDetailsFromAws.
        internal void ProcessRecord_RdsInstanceDetails()
        {
            this._logger.name += " -RdsInstanceDetails";
            // Invoke graphql operation rdsInstanceDetailsFromAws
            InvokeQueryRdsInstanceDetailsFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // isAwsNativeRdsInstanceLaunchConfigurationValid.
        internal void ProcessRecord_IsNativeRdsInstanceLaunchConfigurationValid()
        {
            this._logger.name += " -IsNativeRdsInstanceLaunchConfigurationValid";
            // Invoke graphql operation isAwsNativeRdsInstanceLaunchConfigurationValid
            InvokeQueryIsAwsNativeRdsInstanceLaunchConfigurationValid();
        }

        // This parameter set invokes a single graphql operation:
        // allOptionGroupsByRegionFromAws.
        internal void ProcessRecord_AllOptionGroupsByRegion()
        {
            this._logger.name += " -AllOptionGroupsByRegion";
            // Invoke graphql operation allOptionGroupsByRegionFromAws
            InvokeQueryAllOptionGroupsByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allDbParameterGroupsByRegionFromAws.
        internal void ProcessRecord_AllDbParameterGroupsByRegion()
        {
            this._logger.name += " -AllDbParameterGroupsByRegion";
            // Invoke graphql operation allDbParameterGroupsByRegionFromAws
            InvokeQueryAllDbParameterGroupsByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allDbSubnetGroupsByRegionFromAws.
        internal void ProcessRecord_AllDbSubnetGroupsByRegion()
        {
            this._logger.name += " -AllDbSubnetGroupsByRegion";
            // Invoke graphql operation allDbSubnetGroupsByRegionFromAws
            InvokeQueryAllDbSubnetGroupsByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // validateAwsNativeRdsInstanceNameForExport.
        internal void ProcessRecord_ValidateNativeRdsInstanceNameForExport()
        {
            this._logger.name += " -ValidateNativeRdsInstanceNameForExport";
            // Invoke graphql operation validateAwsNativeRdsInstanceNameForExport
            InvokeQueryValidateAwsNativeRdsInstanceNameForExport();
        }

        // This parameter set invokes a single graphql operation:
        // validateAwsNativeRdsClusterNameForExport.
        internal void ProcessRecord_ValidateNativeRdsClusterNameForExport()
        {
            this._logger.name += " -ValidateNativeRdsClusterNameForExport";
            // Invoke graphql operation validateAwsNativeRdsClusterNameForExport
            InvokeQueryValidateAwsNativeRdsClusterNameForExport();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeRdsExportDefaults.
        internal void ProcessRecord_NativeRdsExportDefaults()
        {
            this._logger.name += " -NativeRdsExportDefaults";
            // Invoke graphql operation awsNativeRdsExportDefaults
            InvokeQueryAwsNativeRdsExportDefaults();
        }

        // This parameter set invokes a single graphql operation:
        // allEc2KeyPairsByRegionFromAws.
        internal void ProcessRecord_AllEc2KeyPairsByRegion()
        {
            this._logger.name += " -AllEc2KeyPairsByRegion";
            // Invoke graphql operation allEc2KeyPairsByRegionFromAws
            InvokeQueryAllEc2KeyPairsByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // amiTypeForAwsNativeArchivedSnapshotExport.
        internal void ProcessRecord_AmiTypeForNativeArchivedSnapshotExport()
        {
            this._logger.name += " -AmiTypeForNativeArchivedSnapshotExport";
            // Invoke graphql operation amiTypeForAwsNativeArchivedSnapshotExport
            InvokeQueryAmiTypeForAwsNativeArchivedSnapshotExport();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsRdsAuroraInstanceClasses.
        internal void ProcessRecord_AllRdsAuroraInstanceClasses()
        {
            this._logger.name += " -AllRdsAuroraInstanceClasses";
            // Invoke graphql operation allAwsRdsAuroraInstanceClasses
            InvokeQueryAllAwsRdsAuroraInstanceClasses();
        }

        // This parameter set invokes a single graphql operation:
        // allSupportedAwsRdsDatabaseInstanceClasses.
        internal void ProcessRecord_AllSupportedRdsDatabaseInstanceClasses()
        {
            this._logger.name += " -AllSupportedRdsDatabaseInstanceClasses";
            // Invoke graphql operation allSupportedAwsRdsDatabaseInstanceClasses
            InvokeQueryAllSupportedAwsRdsDatabaseInstanceClasses();
        }

        // This parameter set invokes a single graphql operation:
        // awsComputeSettings.
        internal void ProcessRecord_ComputeSettings()
        {
            this._logger.name += " -ComputeSettings";
            // Invoke graphql operation awsComputeSettings
            InvokeQueryAwsComputeSettings();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsComputeSettings.
        internal void ProcessRecord_AllComputeSettings()
        {
            this._logger.name += " -AllComputeSettings";
            // Invoke graphql operation allAwsComputeSettings
            InvokeQueryAllAwsComputeSettings();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsCloudAccountsWithFeatures.
        internal void ProcessRecord_AllCloudAccountsWithFeatures()
        {
            this._logger.name += " -AllCloudAccountsWithFeatures";
            // Invoke graphql operation allAwsCloudAccountsWithFeatures
            InvokeQueryAllAwsCloudAccountsWithFeatures();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsCloudAccountsFeaturesWithExoConfigs.
        internal void ProcessRecord_AllCloudAccountsFeaturesWithExoConfigs()
        {
            this._logger.name += " -AllCloudAccountsFeaturesWithExoConfigs";
            // Invoke graphql operation allAwsCloudAccountsFeaturesWithExoConfigs
            InvokeQueryAllAwsCloudAccountsFeaturesWithExoConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // awsCloudAccountWithFeatures.
        internal void ProcessRecord_CloudAccountWithFeatures()
        {
            this._logger.name += " -CloudAccountWithFeatures";
            // Invoke graphql operation awsCloudAccountWithFeatures
            InvokeQueryAwsCloudAccountWithFeatures();
        }

        // This parameter set invokes a single graphql operation:
        // awsCloudAccountListVpcs.
        internal void ProcessRecord_CloudAccountListVpcs()
        {
            this._logger.name += " -CloudAccountListVpcs";
            // Invoke graphql operation awsCloudAccountListVpcs
            InvokeQueryAwsCloudAccountListVpcs();
        }

        // This parameter set invokes a single graphql operation:
        // awsCloudAccountListSubnets.
        internal void ProcessRecord_CloudAccountListSubnets()
        {
            this._logger.name += " -CloudAccountListSubnets";
            // Invoke graphql operation awsCloudAccountListSubnets
            InvokeQueryAwsCloudAccountListSubnets();
        }

        // This parameter set invokes a single graphql operation:
        // awsCloudAccountListSecurityGroups.
        internal void ProcessRecord_CloudAccountListSecurityGroups()
        {
            this._logger.name += " -CloudAccountListSecurityGroups";
            // Invoke graphql operation awsCloudAccountListSecurityGroups
            InvokeQueryAwsCloudAccountListSecurityGroups();
        }

        // This parameter set invokes a single graphql operation:
        // AwsCloudAccountListKMSKeys.
        internal void ProcessRecord_CloudAccountListKMSKeys()
        {
            this._logger.name += " -CloudAccountListKMSKeys";
            // Invoke graphql operation AwsCloudAccountListKMSKeys
            InvokeQueryAwsCloudAccountListKmsKeys();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsExocomputeConfigs.
        internal void ProcessRecord_AllExocomputeConfigs()
        {
            this._logger.name += " -AllExocomputeConfigs";
            // Invoke graphql operation allAwsExocomputeConfigs
            InvokeQueryAllAwsExocomputeConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsCloudAccountConfigs.
        internal void ProcessRecord_AllCloudAccountConfigs()
        {
            this._logger.name += " -AllCloudAccountConfigs";
            // Invoke graphql operation allAwsCloudAccountConfigs
            InvokeQueryAllAwsCloudAccountConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // awsTrustPolicy.
        internal void ProcessRecord_TrustPolicy()
        {
            this._logger.name += " -TrustPolicy";
            // Invoke graphql operation awsTrustPolicy
            InvokeQueryAwsTrustPolicy();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsPermissionPolicies.
        internal void ProcessRecord_AllPermissionPolicies()
        {
            this._logger.name += " -AllPermissionPolicies";
            // Invoke graphql operation allAwsPermissionPolicies
            InvokeQueryAllAwsPermissionPolicies();
        }

        // This parameter set invokes a single graphql operation:
        // awsArtifactsToDelete.
        internal void ProcessRecord_ArtifactsToDelete()
        {
            this._logger.name += " -ArtifactsToDelete";
            // Invoke graphql operation awsArtifactsToDelete
            InvokeQueryAwsArtifactsToDelete();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsRegions.
        internal void ProcessRecord_AllRegions()
        {
            this._logger.name += " -AllRegions";
            // Invoke graphql operation allAwsRegions
            InvokeQueryAllAwsRegions();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsCdmVersions.
        internal void ProcessRecord_AllCdmVersions()
        {
            this._logger.name += " -AllCdmVersions";
            // Invoke graphql operation allAwsCdmVersions
            InvokeQueryAllAwsCdmVersions();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsInstanceProfileNames.
        internal void ProcessRecord_AllInstanceProfileNames()
        {
            this._logger.name += " -AllInstanceProfileNames";
            // Invoke graphql operation allAwsInstanceProfileNames
            InvokeQueryAllAwsInstanceProfileNames();
        }


        // Invoke GraphQL Query:
        // awsNativeRoot: AwsNativeRoot!
        internal void InvokeQueryAwsNativeRoot()
        {
            Tuple<string, string>[] argDefs = {
            };
            AwsNativeRoot? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AwsNativeRoot)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AwsNativeRoot)this.Field;
                }
            }
            string fieldSpecDoc = Query.AwsNativeRoot(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAwsNativeRoot",
                "",
                fieldSpecDoc,
                "AwsNativeRoot"
            );
        }

        // Invoke GraphQL Query:
        // awsNativeAccount(awsNativeAccountRubrikId: UUID!, awsNativeProtectionFeature: AwsNativeProtectionFeature!): AwsNativeAccount!
        internal void InvokeQueryAwsNativeAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsNativeAccountRubrikId", "UUID!"),
                Tuple.Create("awsNativeProtectionFeature", "AwsNativeProtectionFeature!"),
            };
            AwsNativeAccount? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AwsNativeAccount)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AwsNativeAccount)this.Field;
                }
            }
            string fieldSpecDoc = Query.AwsNativeAccount(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAwsNativeAccount",
                "($awsNativeAccountRubrikId: UUID!,$awsNativeProtectionFeature: AwsNativeProtectionFeature!)",
                fieldSpecDoc,
                "AwsNativeAccount"
            );
        }

        // Invoke GraphQL Query:
        // awsNativeEc2Instance(ec2InstanceRubrikId: UUID!): AwsNativeEc2Instance!
        internal void InvokeQueryAwsNativeEc2Instance()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("ec2InstanceRubrikId", "UUID!"),
            };
            AwsNativeEc2Instance? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AwsNativeEc2Instance)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AwsNativeEc2Instance)this.Field;
                }
            }
            string fieldSpecDoc = Query.AwsNativeEc2Instance(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAwsNativeEc2Instance",
                "($ec2InstanceRubrikId: UUID!)",
                fieldSpecDoc,
                "AwsNativeEc2Instance"
            );
        }

        // Invoke GraphQL Query:
        // awsNativeEbsVolume(ebsVolumeRubrikId: UUID!): AwsNativeEbsVolume!
        internal void InvokeQueryAwsNativeEbsVolume()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("ebsVolumeRubrikId", "UUID!"),
            };
            AwsNativeEbsVolume? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AwsNativeEbsVolume)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AwsNativeEbsVolume)this.Field;
                }
            }
            string fieldSpecDoc = Query.AwsNativeEbsVolume(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAwsNativeEbsVolume",
                "($ebsVolumeRubrikId: UUID!)",
                fieldSpecDoc,
                "AwsNativeEbsVolume"
            );
        }

        // Invoke GraphQL Query:
        // awsNativeS3Bucket(s3BucketRubrikId: UUID!): AwsNativeS3Bucket!
        internal void InvokeQueryAwsNativeS3Bucket()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("s3BucketRubrikId", "UUID!"),
            };
            AwsNativeS3Bucket? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AwsNativeS3Bucket)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AwsNativeS3Bucket)this.Field;
                }
            }
            string fieldSpecDoc = Query.AwsNativeS3Bucket(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAwsNativeS3Bucket",
                "($s3BucketRubrikId: UUID!)",
                fieldSpecDoc,
                "AwsNativeS3Bucket"
            );
        }

        // Invoke GraphQL Query:
        // awsNativeAccounts(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AwsNativeAccountSortFields
        //     sortOrder: SortOrder
        //     accountFilters: AwsNativeAccountFilters
        //     authorizedOperationFilter: Operation
        //     awsNativeProtectionFeature: AwsNativeProtectionFeature!
        //   ): AwsNativeAccountConnection!
        internal void InvokeQueryAwsNativeAccounts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AwsNativeAccountSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("accountFilters", "AwsNativeAccountFilters"),
                Tuple.Create("authorizedOperationFilter", "Operation"),
                Tuple.Create("awsNativeProtectionFeature", "AwsNativeProtectionFeature!"),
            };
            AwsNativeAccountConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AwsNativeAccountConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AwsNativeAccountConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.AwsNativeAccounts(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAwsNativeAccounts",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AwsNativeAccountSortFields,$sortOrder: SortOrder,$accountFilters: AwsNativeAccountFilters,$authorizedOperationFilter: Operation,$awsNativeProtectionFeature: AwsNativeProtectionFeature!)",
                fieldSpecDoc,
                "AwsNativeAccountConnection"
            );
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
        internal void InvokeQueryAwsNativeEc2InstancesByName()
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
            AwsNativeEc2InstanceConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AwsNativeEc2InstanceConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AwsNativeEc2InstanceConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.AwsNativeEc2InstancesByName(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAwsNativeEc2InstancesByName",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AwsNativeEc2InstanceSortFields,$sortOrder: SortOrder,$ec2InstanceName: String!)",
                fieldSpecDoc,
                "AwsNativeEc2InstanceConnection"
            );
        }

        // Invoke GraphQL Query:
        // awsNativeEc2Instances(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AwsNativeEc2InstanceSortFields
        //     sortOrder: SortOrder
        //     descendantTypeFilter: [HierarchyObjectTypeEnum!]
        //     ec2InstanceFilters: AwsNativeEc2InstanceFilters
        //   ): AwsNativeEc2InstanceConnection!
        internal void InvokeQueryAwsNativeEc2Instances()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AwsNativeEc2InstanceSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("descendantTypeFilter", "[HierarchyObjectTypeEnum!]"),
                Tuple.Create("ec2InstanceFilters", "AwsNativeEc2InstanceFilters"),
            };
            AwsNativeEc2InstanceConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AwsNativeEc2InstanceConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AwsNativeEc2InstanceConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.AwsNativeEc2Instances(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAwsNativeEc2Instances",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AwsNativeEc2InstanceSortFields,$sortOrder: SortOrder,$descendantTypeFilter: [HierarchyObjectTypeEnum!],$ec2InstanceFilters: AwsNativeEc2InstanceFilters)",
                fieldSpecDoc,
                "AwsNativeEc2InstanceConnection"
            );
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
        internal void InvokeQueryAwsNativeEbsVolumesByName()
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
            AwsNativeEbsVolumeConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AwsNativeEbsVolumeConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AwsNativeEbsVolumeConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.AwsNativeEbsVolumesByName(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAwsNativeEbsVolumesByName",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AwsNativeEbsVolumeSortFields,$sortOrder: SortOrder,$ebsVolumeName: String!)",
                fieldSpecDoc,
                "AwsNativeEbsVolumeConnection"
            );
        }

        // Invoke GraphQL Query:
        // awsNativeEbsVolumes(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AwsNativeEbsVolumeSortFields
        //     sortOrder: SortOrder
        //     ebsVolumeFilters: AwsNativeEbsVolumeFilters
        //   ): AwsNativeEbsVolumeConnection!
        internal void InvokeQueryAwsNativeEbsVolumes()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AwsNativeEbsVolumeSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("ebsVolumeFilters", "AwsNativeEbsVolumeFilters"),
            };
            AwsNativeEbsVolumeConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AwsNativeEbsVolumeConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AwsNativeEbsVolumeConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.AwsNativeEbsVolumes(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAwsNativeEbsVolumes",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AwsNativeEbsVolumeSortFields,$sortOrder: SortOrder,$ebsVolumeFilters: AwsNativeEbsVolumeFilters)",
                fieldSpecDoc,
                "AwsNativeEbsVolumeConnection"
            );
        }

        // Invoke GraphQL Query:
        // allVpcsByRegionFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion!): [AwsVpc!]!
        internal void InvokeQueryAllVpcsByRegionFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
            };
            List<AwsVpc>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<AwsVpc>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<AwsVpc>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllVpcsByRegionFromAws(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllVpcsByRegionFromAws",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!)",
                fieldSpecDoc,
                "List<AwsVpc>"
            );
        }

        // Invoke GraphQL Query:
        // allVpcsFromAws(awsAccountRubrikId: UUID): [AwsVpc!]!
        internal void InvokeQueryAllVpcsFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID"),
            };
            List<AwsVpc>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<AwsVpc>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<AwsVpc>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllVpcsFromAws(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllVpcsFromAws",
                "($awsAccountRubrikId: UUID)",
                fieldSpecDoc,
                "List<AwsVpc>"
            );
        }

        // Invoke GraphQL Query:
        // isAwsNativeEbsVolumeSnapshotRestorable(snapshotId: String!): IsVolumeSnapshotRestorableReply!
        internal void InvokeQueryIsAwsNativeEbsVolumeSnapshotRestorable()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snapshotId", "String!"),
            };
            IsVolumeSnapshotRestorableReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (IsVolumeSnapshotRestorableReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (IsVolumeSnapshotRestorableReply)this.Field;
                }
            }
            string fieldSpecDoc = Query.IsAwsNativeEbsVolumeSnapshotRestorable(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryIsAwsNativeEbsVolumeSnapshotRestorable",
                "($snapshotId: String!)",
                fieldSpecDoc,
                "IsVolumeSnapshotRestorableReply"
            );
        }

        // Invoke GraphQL Query:
        // allAvailabilityZonesByRegionFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion!): [String!]!
        internal void InvokeQueryAllAvailabilityZonesByRegionFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
            };
            List<System.String>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<System.String>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<System.String>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAvailabilityZonesByRegionFromAws(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAvailabilityZonesByRegionFromAws",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!)",
                fieldSpecDoc,
                "List<System.String>"
            );
        }

        // Invoke GraphQL Query:
        // allKmsEncryptionKeysByRegionFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion!): [KmsEncryptionKey!]!
        internal void InvokeQueryAllKmsEncryptionKeysByRegionFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
            };
            List<KmsEncryptionKey>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<KmsEncryptionKey>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<KmsEncryptionKey>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllKmsEncryptionKeysByRegionFromAws(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllKmsEncryptionKeysByRegionFromAws",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!)",
                fieldSpecDoc,
                "List<KmsEncryptionKey>"
            );
        }

        // Invoke GraphQL Query:
        // isAwsS3BucketNameAvailable(bucketName: String!, awsAccountRubrikId: UUID!): Boolean!
        internal void InvokeQueryIsAwsS3BucketNameAvailable()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("bucketName", "String!"),
                Tuple.Create("awsAccountRubrikId", "UUID!"),
            };
            System.Boolean? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (System.Boolean)psObject.BaseObject;
                } else {
                    fieldSpecObj = (System.Boolean)this.Field;
                }
            }
            string fieldSpecDoc = Query.IsAwsS3BucketNameAvailable(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryIsAwsS3BucketNameAvailable",
                "($bucketName: String!,$awsAccountRubrikId: UUID!)",
                fieldSpecDoc,
                "System.Boolean"
            );
        }

        // Invoke GraphQL Query:
        // allS3BucketsFromAws(awsAccountRubrikId: UUID!): [String!]!
        internal void InvokeQueryAllS3BucketsFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
            };
            List<System.String>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<System.String>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<System.String>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllS3BucketsFromAws(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllS3BucketsFromAws",
                "($awsAccountRubrikId: UUID!)",
                fieldSpecDoc,
                "List<System.String>"
            );
        }

        // Invoke GraphQL Query:
        // allS3BucketsDetailsFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion): [S3BucketDetails!]!
        internal void InvokeQueryAllS3BucketsDetailsFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion"),
            };
            List<S3BucketDetails>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<S3BucketDetails>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<S3BucketDetails>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllS3BucketsDetailsFromAws(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllS3BucketsDetailsFromAws",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion)",
                fieldSpecDoc,
                "List<S3BucketDetails>"
            );
        }

        // Invoke GraphQL Query:
        // awsNativeRdsInstance(rdsInstanceRubrikId: UUID!): AwsNativeRdsInstance!
        internal void InvokeQueryAwsNativeRdsInstance()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("rdsInstanceRubrikId", "UUID!"),
            };
            AwsNativeRdsInstance? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AwsNativeRdsInstance)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AwsNativeRdsInstance)this.Field;
                }
            }
            string fieldSpecDoc = Query.AwsNativeRdsInstance(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAwsNativeRdsInstance",
                "($rdsInstanceRubrikId: UUID!)",
                fieldSpecDoc,
                "AwsNativeRdsInstance"
            );
        }

        // Invoke GraphQL Query:
        // awsNativeRdsInstances(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AwsNativeRdsInstanceSortFields
        //     sortOrder: SortOrder
        //     rdsInstanceFilters: AwsNativeRdsInstanceFilters
        //   ): AwsNativeRdsInstanceConnection!
        internal void InvokeQueryAwsNativeRdsInstances()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AwsNativeRdsInstanceSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("rdsInstanceFilters", "AwsNativeRdsInstanceFilters"),
            };
            AwsNativeRdsInstanceConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AwsNativeRdsInstanceConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AwsNativeRdsInstanceConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.AwsNativeRdsInstances(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAwsNativeRdsInstances",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AwsNativeRdsInstanceSortFields,$sortOrder: SortOrder,$rdsInstanceFilters: AwsNativeRdsInstanceFilters)",
                fieldSpecDoc,
                "AwsNativeRdsInstanceConnection"
            );
        }

        // Invoke GraphQL Query:
        // awsNativeRdsPointInTimeRestoreWindow(
        //     awsAccountRubrikId: UUID!
        //     region: AwsNativeRegion!
        //     rdsInstanceName: String!
        //     rdsDatabaseRubrikId: UUID
        //   ): AwsNativeRdsPointInTimeRestoreWindow!
        internal void InvokeQueryAwsNativeRdsPointInTimeRestoreWindow()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("rdsInstanceName", "String!"),
                Tuple.Create("rdsDatabaseRubrikId", "UUID"),
            };
            AwsNativeRdsPointInTimeRestoreWindow? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AwsNativeRdsPointInTimeRestoreWindow)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AwsNativeRdsPointInTimeRestoreWindow)this.Field;
                }
            }
            string fieldSpecDoc = Query.AwsNativeRdsPointInTimeRestoreWindow(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAwsNativeRdsPointInTimeRestoreWindow",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$rdsInstanceName: String!,$rdsDatabaseRubrikId: UUID)",
                fieldSpecDoc,
                "AwsNativeRdsPointInTimeRestoreWindow"
            );
        }

        // Invoke GraphQL Query:
        // rdsInstanceDetailsFromAws(
        //     awsAccountRubrikId: UUID!
        //     region: AwsNativeRegion!
        //     rdsInstanceName: String!
        //     rdsDatabaseRubrikId: UUID
        //   ): RdsInstanceDetailsFromAws!
        internal void InvokeQueryRdsInstanceDetailsFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("rdsInstanceName", "String!"),
                Tuple.Create("rdsDatabaseRubrikId", "UUID"),
            };
            RdsInstanceDetailsFromAws? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (RdsInstanceDetailsFromAws)psObject.BaseObject;
                } else {
                    fieldSpecObj = (RdsInstanceDetailsFromAws)this.Field;
                }
            }
            string fieldSpecDoc = Query.RdsInstanceDetailsFromAws(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryRdsInstanceDetailsFromAws",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$rdsInstanceName: String!,$rdsDatabaseRubrikId: UUID)",
                fieldSpecDoc,
                "RdsInstanceDetailsFromAws"
            );
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
        internal void InvokeQueryIsAwsNativeRdsInstanceLaunchConfigurationValid()
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
            System.Boolean? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (System.Boolean)psObject.BaseObject;
                } else {
                    fieldSpecObj = (System.Boolean)this.Field;
                }
            }
            string fieldSpecDoc = Query.IsAwsNativeRdsInstanceLaunchConfigurationValid(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryIsAwsNativeRdsInstanceLaunchConfigurationValid",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$dbEngine: AwsNativeRdsDbEngine!,$dbEngineVersion: String!,$dbClass: AwsNativeRdsDbInstanceClass!,$databaseInstanceClass: String,$primaryAz: String,$storageType: AwsNativeRdsStorageType,$isMultiAz: Boolean!,$kmsKeyId: String,$iops: Int)",
                fieldSpecDoc,
                "System.Boolean"
            );
        }

        // Invoke GraphQL Query:
        // allOptionGroupsByRegionFromAws(
        //     awsAccountRubrikId: UUID!
        //     region: AwsNativeRegion!
        //     dbEngine: AwsNativeRdsDbEngine!
        //     dbEngineVersion: String!
        //     majorEngineVersion: String!
        //   ): [OptionGroup!]!
        internal void InvokeQueryAllOptionGroupsByRegionFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("dbEngine", "AwsNativeRdsDbEngine!"),
                Tuple.Create("dbEngineVersion", "String!"),
                Tuple.Create("majorEngineVersion", "String!"),
            };
            List<OptionGroup>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<OptionGroup>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<OptionGroup>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllOptionGroupsByRegionFromAws(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllOptionGroupsByRegionFromAws",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$dbEngine: AwsNativeRdsDbEngine!,$dbEngineVersion: String!,$majorEngineVersion: String!)",
                fieldSpecDoc,
                "List<OptionGroup>"
            );
        }

        // Invoke GraphQL Query:
        // allDbParameterGroupsByRegionFromAws(
        //     awsAccountRubrikId: UUID!
        //     region: AwsNativeRegion!
        //     dbEngine: AwsNativeRdsDbEngine!
        //     dbEngineVersion: String!
        //     rdsType: AwsNativeRdsType
        //   ): [DbParameterGroup!]!
        internal void InvokeQueryAllDbParameterGroupsByRegionFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("dbEngine", "AwsNativeRdsDbEngine!"),
                Tuple.Create("dbEngineVersion", "String!"),
                Tuple.Create("rdsType", "AwsNativeRdsType"),
            };
            List<DbParameterGroup>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<DbParameterGroup>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<DbParameterGroup>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllDbParameterGroupsByRegionFromAws(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllDbParameterGroupsByRegionFromAws",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$dbEngine: AwsNativeRdsDbEngine!,$dbEngineVersion: String!,$rdsType: AwsNativeRdsType)",
                fieldSpecDoc,
                "List<DbParameterGroup>"
            );
        }

        // Invoke GraphQL Query:
        // allDbSubnetGroupsByRegionFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion!): [SubnetGroup!]!
        internal void InvokeQueryAllDbSubnetGroupsByRegionFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
            };
            List<SubnetGroup>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<SubnetGroup>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<SubnetGroup>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllDbSubnetGroupsByRegionFromAws(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllDbSubnetGroupsByRegionFromAws",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!)",
                fieldSpecDoc,
                "List<SubnetGroup>"
            );
        }

        // Invoke GraphQL Query:
        // validateAwsNativeRdsInstanceNameForExport(awsAccountRubrikId: UUID!, region: AwsNativeRegion!, rdsInstanceName: String!): ValidateAwsNativeRdsInstanceNameForExportReply!
        internal void InvokeQueryValidateAwsNativeRdsInstanceNameForExport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("rdsInstanceName", "String!"),
            };
            ValidateAwsNativeRdsInstanceNameForExportReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (ValidateAwsNativeRdsInstanceNameForExportReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (ValidateAwsNativeRdsInstanceNameForExportReply)this.Field;
                }
            }
            string fieldSpecDoc = Query.ValidateAwsNativeRdsInstanceNameForExport(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryValidateAwsNativeRdsInstanceNameForExport",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$rdsInstanceName: String!)",
                fieldSpecDoc,
                "ValidateAwsNativeRdsInstanceNameForExportReply"
            );
        }

        // Invoke GraphQL Query:
        // validateAwsNativeRdsClusterNameForExport(awsAccountRubrikId: UUID!, region: AwsNativeRegion!, rdsClusterName: String!): ValidateAwsNativeRdsClusterNameForExportReply!
        internal void InvokeQueryValidateAwsNativeRdsClusterNameForExport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("rdsClusterName", "String!"),
            };
            ValidateAwsNativeRdsClusterNameForExportReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (ValidateAwsNativeRdsClusterNameForExportReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (ValidateAwsNativeRdsClusterNameForExportReply)this.Field;
                }
            }
            string fieldSpecDoc = Query.ValidateAwsNativeRdsClusterNameForExport(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryValidateAwsNativeRdsClusterNameForExport",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$rdsClusterName: String!)",
                fieldSpecDoc,
                "ValidateAwsNativeRdsClusterNameForExportReply"
            );
        }

        // Invoke GraphQL Query:
        // awsNativeRdsExportDefaults(rdsInstanceRubrikId: UUID!, snapshotId: String, isPointInTime: Boolean!): RdsInstanceExportDefaults!
        internal void InvokeQueryAwsNativeRdsExportDefaults()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("rdsInstanceRubrikId", "UUID!"),
                Tuple.Create("snapshotId", "String"),
                Tuple.Create("isPointInTime", "Boolean!"),
            };
            RdsInstanceExportDefaults? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (RdsInstanceExportDefaults)psObject.BaseObject;
                } else {
                    fieldSpecObj = (RdsInstanceExportDefaults)this.Field;
                }
            }
            string fieldSpecDoc = Query.AwsNativeRdsExportDefaults(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAwsNativeRdsExportDefaults",
                "($rdsInstanceRubrikId: UUID!,$snapshotId: String,$isPointInTime: Boolean!)",
                fieldSpecDoc,
                "RdsInstanceExportDefaults"
            );
        }

        // Invoke GraphQL Query:
        // allEc2KeyPairsByRegionFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion!): [String!]!
        internal void InvokeQueryAllEc2KeyPairsByRegionFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
            };
            List<System.String>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<System.String>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<System.String>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllEc2KeyPairsByRegionFromAws(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllEc2KeyPairsByRegionFromAws",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!)",
                fieldSpecDoc,
                "List<System.String>"
            );
        }

        // Invoke GraphQL Query:
        // amiTypeForAwsNativeArchivedSnapshotExport(input: AmiTypeForAwsNativeArchivedSnapshotExportInput!): AmiTypeForAwsNativeArchivedSnapshotExportReply!
        internal void InvokeQueryAmiTypeForAwsNativeArchivedSnapshotExport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AmiTypeForAwsNativeArchivedSnapshotExportInput!"),
            };
            AmiTypeForAwsNativeArchivedSnapshotExportReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AmiTypeForAwsNativeArchivedSnapshotExportReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AmiTypeForAwsNativeArchivedSnapshotExportReply)this.Field;
                }
            }
            string fieldSpecDoc = Query.AmiTypeForAwsNativeArchivedSnapshotExport(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAmiTypeForAwsNativeArchivedSnapshotExport",
                "($input: AmiTypeForAwsNativeArchivedSnapshotExportInput!)",
                fieldSpecDoc,
                "AmiTypeForAwsNativeArchivedSnapshotExportReply"
            );
        }

        // Invoke GraphQL Query:
        // allAwsRdsAuroraInstanceClasses: AwsNativeRdsAuroraInstanceClassesReply!
        internal void InvokeQueryAllAwsRdsAuroraInstanceClasses()
        {
            Tuple<string, string>[] argDefs = {
            };
            AwsNativeRdsAuroraInstanceClassesReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AwsNativeRdsAuroraInstanceClassesReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AwsNativeRdsAuroraInstanceClassesReply)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAwsRdsAuroraInstanceClasses(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAwsRdsAuroraInstanceClasses",
                "",
                fieldSpecDoc,
                "AwsNativeRdsAuroraInstanceClassesReply"
            );
        }

        // Invoke GraphQL Query:
        // allSupportedAwsRdsDatabaseInstanceClasses(
        //     awsAccountRubrikId: UUID!
        //     region: AwsNativeRegion!
        //     dbEngine: AwsNativeRdsDbEngine!
        //     dbEngineVersion: String
        //   ): [String!]!
        internal void InvokeQueryAllSupportedAwsRdsDatabaseInstanceClasses()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("dbEngine", "AwsNativeRdsDbEngine!"),
                Tuple.Create("dbEngineVersion", "String"),
            };
            List<System.String>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<System.String>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<System.String>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllSupportedAwsRdsDatabaseInstanceClasses(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllSupportedAwsRdsDatabaseInstanceClasses",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$dbEngine: AwsNativeRdsDbEngine!,$dbEngineVersion: String)",
                fieldSpecDoc,
                "List<System.String>"
            );
        }

        // Invoke GraphQL Query:
        // awsComputeSettings(computeSettingId: UUID!): AwsComputeSettings!
        internal void InvokeQueryAwsComputeSettings()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("computeSettingId", "UUID!"),
            };
            AwsComputeSettings? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AwsComputeSettings)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AwsComputeSettings)this.Field;
                }
            }
            string fieldSpecDoc = Query.AwsComputeSettings(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAwsComputeSettings",
                "($computeSettingId: UUID!)",
                fieldSpecDoc,
                "AwsComputeSettings"
            );
        }

        // Invoke GraphQL Query:
        // allAwsComputeSettings(
        //     sortBy: AwsCloudComputeSettingQuerySortByField
        //     sortOrder: SortOrder
        //     filter: [AwsCloudComputeSettingFilterInput!]
        //     contextFilter: ContextFilterTypeEnum
        //   ): [AwsComputeSettings!]!
        internal void InvokeQueryAllAwsComputeSettings()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("sortBy", "AwsCloudComputeSettingQuerySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[AwsCloudComputeSettingFilterInput!]"),
                Tuple.Create("contextFilter", "ContextFilterTypeEnum"),
            };
            List<AwsComputeSettings>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<AwsComputeSettings>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<AwsComputeSettings>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAwsComputeSettings(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAwsComputeSettings",
                "($sortBy: AwsCloudComputeSettingQuerySortByField,$sortOrder: SortOrder,$filter: [AwsCloudComputeSettingFilterInput!],$contextFilter: ContextFilterTypeEnum)",
                fieldSpecDoc,
                "List<AwsComputeSettings>"
            );
        }

        // Invoke GraphQL Query:
        // allAwsCloudAccountsWithFeatures(awsCloudAccountsArg: AwsCloudAccountsWithFeaturesInput!): [AwsCloudAccountWithFeatures!]!
        internal void InvokeQueryAllAwsCloudAccountsWithFeatures()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsCloudAccountsArg", "AwsCloudAccountsWithFeaturesInput!"),
            };
            List<AwsCloudAccountWithFeatures>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<AwsCloudAccountWithFeatures>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<AwsCloudAccountWithFeatures>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAwsCloudAccountsWithFeatures(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAwsCloudAccountsWithFeatures",
                "($awsCloudAccountsArg: AwsCloudAccountsWithFeaturesInput!)",
                fieldSpecDoc,
                "List<AwsCloudAccountWithFeatures>"
            );
        }

        // Invoke GraphQL Query:
        // allAwsCloudAccountsFeaturesWithExoConfigs(awsCloudAccountsArg: AwsCloudAccountsWithFeaturesInput!): [AwsCloudAccountFeaturesWithExoConfigs!]!
        internal void InvokeQueryAllAwsCloudAccountsFeaturesWithExoConfigs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsCloudAccountsArg", "AwsCloudAccountsWithFeaturesInput!"),
            };
            List<AwsCloudAccountFeaturesWithExoConfigs>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<AwsCloudAccountFeaturesWithExoConfigs>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<AwsCloudAccountFeaturesWithExoConfigs>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAwsCloudAccountsFeaturesWithExoConfigs(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAwsCloudAccountsFeaturesWithExoConfigs",
                "($awsCloudAccountsArg: AwsCloudAccountsWithFeaturesInput!)",
                fieldSpecDoc,
                "List<AwsCloudAccountFeaturesWithExoConfigs>"
            );
        }

        // Invoke GraphQL Query:
        // awsCloudAccountWithFeatures(cloudAccountId: UUID!, awsCloudAccountArg: AwsCloudAccountWithFeaturesInput!): AwsCloudAccountWithFeatures!
        internal void InvokeQueryAwsCloudAccountWithFeatures()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "UUID!"),
                Tuple.Create("awsCloudAccountArg", "AwsCloudAccountWithFeaturesInput!"),
            };
            AwsCloudAccountWithFeatures? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AwsCloudAccountWithFeatures)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AwsCloudAccountWithFeatures)this.Field;
                }
            }
            string fieldSpecDoc = Query.AwsCloudAccountWithFeatures(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAwsCloudAccountWithFeatures",
                "($cloudAccountId: UUID!,$awsCloudAccountArg: AwsCloudAccountWithFeaturesInput!)",
                fieldSpecDoc,
                "AwsCloudAccountWithFeatures"
            );
        }

        // Invoke GraphQL Query:
        // awsCloudAccountListVpcs(cloudAccountUuid: UUID!, feature: CloudAccountFeature!, region: AwsRegion!): AwsCloudAccountListVpcResponse!
        internal void InvokeQueryAwsCloudAccountListVpcs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountUuid", "UUID!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("region", "AwsRegion!"),
            };
            AwsCloudAccountListVpcResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AwsCloudAccountListVpcResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AwsCloudAccountListVpcResponse)this.Field;
                }
            }
            string fieldSpecDoc = Query.AwsCloudAccountListVpcs(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAwsCloudAccountListVpcs",
                "($cloudAccountUuid: UUID!,$feature: CloudAccountFeature!,$region: AwsRegion!)",
                fieldSpecDoc,
                "AwsCloudAccountListVpcResponse"
            );
        }

        // Invoke GraphQL Query:
        // awsCloudAccountListSubnets(
        //     cloudAccountUuid: UUID!
        //     feature: CloudAccountFeature!
        //     region: AwsRegion!
        //     vpcID: String!
        //   ): AwsCloudAccountListSubnetsResponse!
        internal void InvokeQueryAwsCloudAccountListSubnets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountUuid", "UUID!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("region", "AwsRegion!"),
                Tuple.Create("vpcID", "String!"),
            };
            AwsCloudAccountListSubnetsResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AwsCloudAccountListSubnetsResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AwsCloudAccountListSubnetsResponse)this.Field;
                }
            }
            string fieldSpecDoc = Query.AwsCloudAccountListSubnets(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAwsCloudAccountListSubnets",
                "($cloudAccountUuid: UUID!,$feature: CloudAccountFeature!,$region: AwsRegion!,$vpcID: String!)",
                fieldSpecDoc,
                "AwsCloudAccountListSubnetsResponse"
            );
        }

        // Invoke GraphQL Query:
        // awsCloudAccountListSecurityGroups(
        //     cloudAccountUuid: UUID!
        //     feature: CloudAccountFeature!
        //     region: AwsRegion!
        //     vpcID: String!
        //   ): AwsCloudAccountListSecurityGroupsResponse!
        internal void InvokeQueryAwsCloudAccountListSecurityGroups()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountUuid", "UUID!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("region", "AwsRegion!"),
                Tuple.Create("vpcID", "String!"),
            };
            AwsCloudAccountListSecurityGroupsResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AwsCloudAccountListSecurityGroupsResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AwsCloudAccountListSecurityGroupsResponse)this.Field;
                }
            }
            string fieldSpecDoc = Query.AwsCloudAccountListSecurityGroups(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAwsCloudAccountListSecurityGroups",
                "($cloudAccountUuid: UUID!,$feature: CloudAccountFeature!,$region: AwsRegion!,$vpcID: String!)",
                fieldSpecDoc,
                "AwsCloudAccountListSecurityGroupsResponse"
            );
        }

        // Invoke GraphQL Query:
        // AwsCloudAccountListKMSKeys(cloudAccountUuid: UUID!, feature: CloudAccountFeature!, region: AwsRegion!): AwsCloudAccountListKMSKeysResponse!
        internal void InvokeQueryAwsCloudAccountListKmsKeys()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountUuid", "UUID!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("region", "AwsRegion!"),
            };
            AwsCloudAccountListKmsKeysResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AwsCloudAccountListKmsKeysResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AwsCloudAccountListKmsKeysResponse)this.Field;
                }
            }
            string fieldSpecDoc = Query.AwsCloudAccountListKmsKeys(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAwsCloudAccountListKmsKeys",
                "($cloudAccountUuid: UUID!,$feature: CloudAccountFeature!,$region: AwsRegion!)",
                fieldSpecDoc,
                "AwsCloudAccountListKmsKeysResponse"
            );
        }

        // Invoke GraphQL Query:
        // allAwsExocomputeConfigs(awsNativeAccountIdOrNamePrefix: String!): [AwsExocomputeConfig!]!
        internal void InvokeQueryAllAwsExocomputeConfigs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsNativeAccountIdOrNamePrefix", "String!"),
            };
            List<AwsExocomputeConfig>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<AwsExocomputeConfig>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<AwsExocomputeConfig>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAwsExocomputeConfigs(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAwsExocomputeConfigs",
                "($awsNativeAccountIdOrNamePrefix: String!)",
                fieldSpecDoc,
                "List<AwsExocomputeConfig>"
            );
        }

        // Invoke GraphQL Query:
        // allAwsCloudAccountConfigs(awsCloudAccountsArg: AwsCloudAccountConfigsInput!): [AwsFeatureConfig!]!
        internal void InvokeQueryAllAwsCloudAccountConfigs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsCloudAccountsArg", "AwsCloudAccountConfigsInput!"),
            };
            List<AwsFeatureConfig>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<AwsFeatureConfig>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<AwsFeatureConfig>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAwsCloudAccountConfigs(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAwsCloudAccountConfigs",
                "($awsCloudAccountsArg: AwsCloudAccountConfigsInput!)",
                fieldSpecDoc,
                "List<AwsFeatureConfig>"
            );
        }

        // Invoke GraphQL Query:
        // awsTrustPolicy(input: AwsTrustPolicyInput!): AwsTrustPolicy!
        internal void InvokeQueryAwsTrustPolicy()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AwsTrustPolicyInput!"),
            };
            AwsTrustPolicy? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AwsTrustPolicy)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AwsTrustPolicy)this.Field;
                }
            }
            string fieldSpecDoc = Query.AwsTrustPolicy(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAwsTrustPolicy",
                "($input: AwsTrustPolicyInput!)",
                fieldSpecDoc,
                "AwsTrustPolicy"
            );
        }

        // Invoke GraphQL Query:
        // allAwsPermissionPolicies(input: AwsGetPermissionPoliciesInput!): [PermissionPolicy!]!
        internal void InvokeQueryAllAwsPermissionPolicies()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AwsGetPermissionPoliciesInput!"),
            };
            List<PermissionPolicy>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<PermissionPolicy>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<PermissionPolicy>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAwsPermissionPolicies(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAwsPermissionPolicies",
                "($input: AwsGetPermissionPoliciesInput!)",
                fieldSpecDoc,
                "List<PermissionPolicy>"
            );
        }

        // Invoke GraphQL Query:
        // awsArtifactsToDelete(input: AwsArtifactsToDeleteInput!): AwsArtifactsToDelete!
        internal void InvokeQueryAwsArtifactsToDelete()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AwsArtifactsToDeleteInput!"),
            };
            AwsArtifactsToDelete? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AwsArtifactsToDelete)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AwsArtifactsToDelete)this.Field;
                }
            }
            string fieldSpecDoc = Query.AwsArtifactsToDelete(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAwsArtifactsToDelete",
                "($input: AwsArtifactsToDeleteInput!)",
                fieldSpecDoc,
                "AwsArtifactsToDelete"
            );
        }

        // Invoke GraphQL Query:
        // allAwsRegions(cloudAccountId: String!): [AwsCloudAccountRegion!]!
        internal void InvokeQueryAllAwsRegions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "String!"),
            };
            List<AwsCloudAccountRegion>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<AwsCloudAccountRegion>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<AwsCloudAccountRegion>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAwsRegions(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAwsRegions",
                "($cloudAccountId: String!)",
                fieldSpecDoc,
                "List<AwsCloudAccountRegion>"
            );
        }

        // Invoke GraphQL Query:
        // allAwsCdmVersions(input: AwsCdmVersionRequest!): [AwsCdmVersion!]!
        internal void InvokeQueryAllAwsCdmVersions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AwsCdmVersionRequest!"),
            };
            List<AwsCdmVersion>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<AwsCdmVersion>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<AwsCdmVersion>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAwsCdmVersions(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAwsCdmVersions",
                "($input: AwsCdmVersionRequest!)",
                fieldSpecDoc,
                "List<AwsCdmVersion>"
            );
        }

        // Invoke GraphQL Query:
        // allAwsInstanceProfileNames(cloudAccountId: String!, region: String!): [String!]!
        internal void InvokeQueryAllAwsInstanceProfileNames()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "String!"),
                Tuple.Create("region", "String!"),
            };
            List<System.String>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<System.String>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<System.String>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAwsInstanceProfileNames(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAwsInstanceProfileNames",
                "($cloudAccountId: String!,$region: String!)",
                fieldSpecDoc,
                "List<System.String>"
            );
        }


    } // class Invoke_RscQueryAws
}