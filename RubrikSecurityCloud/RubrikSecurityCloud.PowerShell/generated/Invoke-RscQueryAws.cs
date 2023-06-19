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
        DefaultParameterSetName = "Allvpc")
    ]
    public class Invoke_RscQueryAws : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // Nativeroot parameter set
        //
        // [GraphQL: awsNativeRoot]
        //
        [Parameter(
            ParameterSetName = "Nativeroot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Root of AWS native hierarchy.
[GraphQL: awsNativeRoot]",
            Position = 0
        )]
        public SwitchParameter Nativeroot { get; set; }

        
        // -------------------------------------------------------------------
        // Nativeaccount parameter set
        //
        // [GraphQL: awsNativeAccount]
        //
        [Parameter(
            ParameterSetName = "Nativeaccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Refers to the AWS Native account that serves as a container for all your AWS resources. The AWS Native account contains information about the metadata related to the AWS Native resources.
[GraphQL: awsNativeAccount]",
            Position = 0
        )]
        public SwitchParameter Nativeaccount { get; set; }

        [Parameter(
            ParameterSetName = "Nativeaccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"The Rubrik ID for the AWS Native account.
GraphQL argument awsNativeAccountRubrikId: UUID!"
        )]
        public System.String? AwsNativeAccountRubrikId { get; set; }
        [Parameter(
            ParameterSetName = "Nativeaccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Cloud native protection feature.
GraphQL argument awsNativeProtectionFeature: AwsNativeProtectionFeature!"
        )]
        public AwsNativeProtectionFeature? AwsNativeProtectionFeature { get; set; }
        
        // -------------------------------------------------------------------
        // Nativeec2instance parameter set
        //
        // [GraphQL: awsNativeEc2Instance]
        //
        [Parameter(
            ParameterSetName = "Nativeec2instance",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Refers to Amazon Elastic Compute Cloud (EC2) Instance represented by a specific ID. For more information, see https://aws.amazon.com/ec2/.
[GraphQL: awsNativeEc2Instance]",
            Position = 0
        )]
        public SwitchParameter Nativeec2instance { get; set; }

        [Parameter(
            ParameterSetName = "Nativeec2instance",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Rubrik ID for the AWS EC2 Instance.
GraphQL argument ec2InstanceRubrikId: UUID!"
        )]
        public System.String? Ec2InstanceRubrikId { get; set; }
        
        // -------------------------------------------------------------------
        // Nativeebsvolume parameter set
        //
        // [GraphQL: awsNativeEbsVolume]
        //
        [Parameter(
            ParameterSetName = "Nativeebsvolume",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Refers to the Amazon Elastic Block Store (EBS) Volume represented by a specific ID. For more information, see https://aws.amazon.com/ebs/.
[GraphQL: awsNativeEbsVolume]",
            Position = 0
        )]
        public SwitchParameter Nativeebsvolume { get; set; }

        [Parameter(
            ParameterSetName = "Nativeebsvolume",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Rubrik ID for the AWS EBS Volume object.
GraphQL argument ebsVolumeRubrikId: UUID!"
        )]
        public System.String? EbsVolumeRubrikId { get; set; }
        
        // -------------------------------------------------------------------
        // Natives3bucket parameter set
        //
        // [GraphQL: awsNativeS3Bucket]
        //
        [Parameter(
            ParameterSetName = "Natives3bucket",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Represents the Amazon S3 Bucket with a specific ID. For more information, see https://aws.amazon.com/s3/.
[GraphQL: awsNativeS3Bucket]",
            Position = 0
        )]
        public SwitchParameter Natives3bucket { get; set; }

        [Parameter(
            ParameterSetName = "Natives3bucket",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Rubrik ID for the AWS S3 bucket object.
GraphQL argument s3BucketRubrikId: UUID!"
        )]
        public System.String? S3BucketRubrikId { get; set; }
        
        // -------------------------------------------------------------------
        // Nativeec2instancesbyname parameter set
        //
        // [GraphQL: awsNativeEc2InstancesByName]
        //
        [Parameter(
            ParameterSetName = "Nativeec2instancesbyname",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of all AWS EC2 Instances by name or substring of name.
[GraphQL: awsNativeEc2InstancesByName]",
            Position = 0
        )]
        public SwitchParameter Nativeec2instancesbyname { get; set; }

        [Parameter(
            ParameterSetName = "Nativeec2instancesbyname",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns the first n elements from the list.
GraphQL argument first: Int"
        )]
        public System.Int32? First { get; set; }
        [Parameter(
            ParameterSetName = "Nativeec2instancesbyname",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns the elements in the list that come after the specified cursor.
GraphQL argument after: String"
        )]
        public System.String? After { get; set; }
        [Parameter(
            ParameterSetName = "Nativeec2instancesbyname",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns the last n elements from the list.
GraphQL argument last: Int"
        )]
        public System.Int32? Last { get; set; }
        [Parameter(
            ParameterSetName = "Nativeec2instancesbyname",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns the elements in the list that come before the specified cursor.
GraphQL argument before: String"
        )]
        public System.String? Before { get; set; }
        [Parameter(
            ParameterSetName = "Nativeec2instancesbyname",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Sort fields for list of AWS EC2 instances.
GraphQL argument sortBy: AwsNativeEc2InstanceSortFields"
        )]
        public AwsNativeEc2InstanceSortFields? SortBy { get; set; }
        [Parameter(
            ParameterSetName = "Nativeec2instancesbyname",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Sorting order for the results.
GraphQL argument sortOrder: SortOrder"
        )]
        public SortOrder? SortOrder { get; set; }
        [Parameter(
            ParameterSetName = "Nativeec2instancesbyname",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Native name for the AWS EC2 Instance object.
GraphQL argument ec2InstanceName: String!"
        )]
        public System.String? Ec2InstanceName { get; set; }
        
        // -------------------------------------------------------------------
        // Nativeebsvolumesbyname parameter set
        //
        // [GraphQL: awsNativeEbsVolumesByName]
        //
        [Parameter(
            ParameterSetName = "Nativeebsvolumesbyname",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of all AWS EBS Volumes by name or substring of name.
[GraphQL: awsNativeEbsVolumesByName]",
            Position = 0
        )]
        public SwitchParameter Nativeebsvolumesbyname { get; set; }

        [Parameter(
            ParameterSetName = "Nativeebsvolumesbyname",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"The native name for the AWS EBS Volume object.
GraphQL argument ebsVolumeName: String!"
        )]
        public System.String? EbsVolumeName { get; set; }
        
        // -------------------------------------------------------------------
        // Allvpcsbyregion parameter set
        //
        // [GraphQL: allVpcsByRegionFromAws]
        //
        [Parameter(
            ParameterSetName = "Allvpcsbyregion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all Virtual Private Clouds (VPCs) in the AWS Native account, classified by region.
[GraphQL: allVpcsByRegionFromAws]",
            Position = 0
        )]
        public SwitchParameter Allvpcsbyregion { get; set; }

        [Parameter(
            ParameterSetName = "Allvpcsbyregion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Rubrik ID for AWS account.
GraphQL argument awsAccountRubrikId: UUID!"
        )]
        public System.String? AwsAccountRubrikId { get; set; }
        [Parameter(
            ParameterSetName = "Allvpcsbyregion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Region in AWS.
GraphQL argument region: AwsNativeRegion!"
        )]
        public AwsNativeRegion? Region { get; set; }
        
        // -------------------------------------------------------------------
        // Allvpc parameter set
        //
        // [GraphQL: allVpcsFromAws]
        //
        [Parameter(
            ParameterSetName = "Allvpc",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all Virtual Private Clouds (VPCs) in the AWS Native account.
[GraphQL: allVpcsFromAws]",
            Position = 0
        )]
        public SwitchParameter Allvpc { get; set; }

        
        // -------------------------------------------------------------------
        // Isnativeebsvolumesnapshotrestorable parameter set
        //
        // [GraphQL: isAwsNativeEbsVolumeSnapshotRestorable]
        //
        [Parameter(
            ParameterSetName = "Isnativeebsvolumesnapshotrestorable",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Specified whether an EBS volume is restorable. For an EBS Volume to be restorable, the volume should be able to replace where attached.
[GraphQL: isAwsNativeEbsVolumeSnapshotRestorable]",
            Position = 0
        )]
        public SwitchParameter Isnativeebsvolumesnapshotrestorable { get; set; }

        [Parameter(
            ParameterSetName = "Isnativeebsvolumesnapshotrestorable",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"UUID of the snapshot
GraphQL argument snapshotId: String!"
        )]
        public System.String? SnapshotId { get; set; }
        
        // -------------------------------------------------------------------
        // Allavailabilityzonesbyregion parameter set
        //
        // [GraphQL: allAvailabilityZonesByRegionFromAws]
        //
        [Parameter(
            ParameterSetName = "Allavailabilityzonesbyregion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of Availability Zones (AZs) in the specified region on the specified AWS Native account.
[GraphQL: allAvailabilityZonesByRegionFromAws]",
            Position = 0
        )]
        public SwitchParameter Allavailabilityzonesbyregion { get; set; }

        
        // -------------------------------------------------------------------
        // Allkmsencryptionkeysbyregion parameter set
        //
        // [GraphQL: allKmsEncryptionKeysByRegionFromAws]
        //
        [Parameter(
            ParameterSetName = "Allkmsencryptionkeysbyregion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of encryption keys in the specified region on the specified AWS Native account. All the encrytion keys listed are managed by AWS Key Management System (KMS). For more information, see https://aws.amazon.com/kms/.
[GraphQL: allKmsEncryptionKeysByRegionFromAws]",
            Position = 0
        )]
        public SwitchParameter Allkmsencryptionkeysbyregion { get; set; }

        
        // -------------------------------------------------------------------
        // Iss3bucketnameavailable parameter set
        //
        // [GraphQL: isAwsS3BucketNameAvailable]
        //
        [Parameter(
            ParameterSetName = "Iss3bucketnameavailable",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Specifies whether an S3 bucket name is available for use in AWS or not. When true, the bucket name is available for use.
[GraphQL: isAwsS3BucketNameAvailable]",
            Position = 0
        )]
        public SwitchParameter Iss3bucketnameavailable { get; set; }

        [Parameter(
            ParameterSetName = "Iss3bucketnameavailable",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Name of the AWS S3 bucket.
GraphQL argument bucketName: String!"
        )]
        public System.String? BucketName { get; set; }
        
        // -------------------------------------------------------------------
        // Alls3bucket parameter set
        //
        // [GraphQL: allS3BucketsFromAws]
        //
        [Parameter(
            ParameterSetName = "Alls3bucket",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all S3 bucket names across regions for the AWS Native account.
[GraphQL: allS3BucketsFromAws]",
            Position = 0
        )]
        public SwitchParameter Alls3bucket { get; set; }

        
        // -------------------------------------------------------------------
        // Alls3bucketsdetail parameter set
        //
        // [GraphQL: allS3BucketsDetailsFromAws]
        //
        [Parameter(
            ParameterSetName = "Alls3bucketsdetail",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all S3 bucket details across regions for the AWS Native account.
[GraphQL: allS3BucketsDetailsFromAws]",
            Position = 0
        )]
        public SwitchParameter Alls3bucketsdetail { get; set; }

        
        // -------------------------------------------------------------------
        // Nativerdsinstance parameter set
        //
        // [GraphQL: awsNativeRdsInstance]
        //
        [Parameter(
            ParameterSetName = "Nativerdsinstance",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Refers to AWS Relational Database Service (RDS) represented by a specific ID. For more information, see https://aws.amazon.com/rds/.
[GraphQL: awsNativeRdsInstance]",
            Position = 0
        )]
        public SwitchParameter Nativerdsinstance { get; set; }

        [Parameter(
            ParameterSetName = "Nativerdsinstance",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"The Rubrik ID for the AWS RDS Instance.
GraphQL argument rdsInstanceRubrikId: UUID!"
        )]
        public System.String? RdsInstanceRubrikId { get; set; }
        
        // -------------------------------------------------------------------
        // Nativerdspointintimerestorewindow parameter set
        //
        // [GraphQL: awsNativeRdsPointInTimeRestoreWindow]
        //
        [Parameter(
            ParameterSetName = "Nativerdspointintimerestorewindow",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Point-in-Time (PiT) restore window of the RDS Instance in the AWS Native account. Refers to the range of time within which the database is available to be restored to a particular point in time. For more information,see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_PIT.html.
[GraphQL: awsNativeRdsPointInTimeRestoreWindow]",
            Position = 0
        )]
        public SwitchParameter Nativerdspointintimerestorewindow { get; set; }

        [Parameter(
            ParameterSetName = "Nativerdspointintimerestorewindow",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Name of the RDS DB Instance
GraphQL argument rdsInstanceName: String!"
        )]
        public System.String? RdsInstanceName { get; set; }
        [Parameter(
            ParameterSetName = "Nativerdspointintimerestorewindow",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"The Rubrik ID for the AWS RDS database.
GraphQL argument rdsDatabaseRubrikId: UUID"
        )]
        public System.String? RdsDatabaseRubrikId { get; set; }
        
        // -------------------------------------------------------------------
        // Rdsinstancedetail parameter set
        //
        // [GraphQL: rdsInstanceDetailsFromAws]
        //
        [Parameter(
            ParameterSetName = "Rdsinstancedetail",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Details of the RDS Instance in the AWS Native account.
[GraphQL: rdsInstanceDetailsFromAws]",
            Position = 0
        )]
        public SwitchParameter Rdsinstancedetail { get; set; }

        
        // -------------------------------------------------------------------
        // Isnativerdsinstancelaunchconfigurationvalid parameter set
        //
        // [GraphQL: isAwsNativeRdsInstanceLaunchConfigurationValid]
        //
        [Parameter(
            ParameterSetName = "Isnativerdsinstancelaunchconfigurationvalid",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Specifies whether the given DbInstance class, storage type, multi-az capability, encryption capability, iops value are supported for the given dbEngine, dbEngineVersion in the specified availability zone. When true, the specification is valid for a RDS Instance and can be used to create a new Instance.
[GraphQL: isAwsNativeRdsInstanceLaunchConfigurationValid]",
            Position = 0
        )]
        public SwitchParameter Isnativerdsinstancelaunchconfigurationvalid { get; set; }

        [Parameter(
            ParameterSetName = "Isnativerdsinstancelaunchconfigurationvalid",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"DB Engine of RDS Instance.
GraphQL argument dbEngine: AwsNativeRdsDbEngine!"
        )]
        public AwsNativeRdsDbEngine? DbEngine { get; set; }
        [Parameter(
            ParameterSetName = "Isnativerdsinstancelaunchconfigurationvalid",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Version of DB engine.
GraphQL argument dbEngineVersion: String!"
        )]
        public System.String? DbEngineVersion { get; set; }
        [Parameter(
            ParameterSetName = "Isnativerdsinstancelaunchconfigurationvalid",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"DB class of the exported RDS DB instance.
GraphQL argument dbClass: AwsNativeRdsDbInstanceClass!"
        )]
        public AwsNativeRdsDbInstanceClass? DbClass { get; set; }
        [Parameter(
            ParameterSetName = "Isnativerdsinstancelaunchconfigurationvalid",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"AZ in which the exported RDS DB instance must be launched.
GraphQL argument primaryAz: String"
        )]
        public System.String? PrimaryAz { get; set; }
        [Parameter(
            ParameterSetName = "Isnativerdsinstancelaunchconfigurationvalid",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Storage type of the exported RDS DB instance.
GraphQL argument storageType: AwsNativeRdsStorageType"
        )]
        public AwsNativeRdsStorageType? StorageType { get; set; }
        [Parameter(
            ParameterSetName = "Isnativerdsinstancelaunchconfigurationvalid",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Whether the exported RDS DB instance is multi-AZ or not.
GraphQL argument isMultiAz: Boolean!"
        )]
        public System.Boolean? IsMultiAz { get; set; }
        [Parameter(
            ParameterSetName = "Isnativerdsinstancelaunchconfigurationvalid",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"KMS Key ID of the exported RDS DB instance.
GraphQL argument kmsKeyId: String"
        )]
        public System.String? KmsKeyId { get; set; }
        [Parameter(
            ParameterSetName = "Isnativerdsinstancelaunchconfigurationvalid",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"IOPs of the exported RDS DB instance.
GraphQL argument iops: Int"
        )]
        public System.Int32? Iops { get; set; }
        
        // -------------------------------------------------------------------
        // Alloptiongroupsbyregion parameter set
        //
        // [GraphQL: allOptionGroupsByRegionFromAws]
        //
        [Parameter(
            ParameterSetName = "Alloptiongroupsbyregion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all RDS option groups in a given region. Refers to settings of how a particular option works for an RDS Instance. For more information, see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_WorkingWithOptionGroups.html.
[GraphQL: allOptionGroupsByRegionFromAws]",
            Position = 0
        )]
        public SwitchParameter Alloptiongroupsbyregion { get; set; }

        [Parameter(
            ParameterSetName = "Alloptiongroupsbyregion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Major version of the option group engine.
GraphQL argument majorEngineVersion: String!"
        )]
        public System.String? MajorEngineVersion { get; set; }
        
        // -------------------------------------------------------------------
        // Alldbparametergroupsbyregion parameter set
        //
        // [GraphQL: allDbParameterGroupsByRegionFromAws]
        //
        [Parameter(
            ParameterSetName = "Alldbparametergroupsbyregion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all DB parameter groups in a given region. Refers to container for engine configuration that applies to one or more DB Instances. For more information, see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_WorkingWithOptionGroups.html.
[GraphQL: allDbParameterGroupsByRegionFromAws]",
            Position = 0
        )]
        public SwitchParameter Alldbparametergroupsbyregion { get; set; }

        [Parameter(
            ParameterSetName = "Alldbparametergroupsbyregion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Type of RDS deployment.
GraphQL argument rdsType: AwsNativeRdsType"
        )]
        public AwsNativeRdsType? RdsType { get; set; }
        
        // -------------------------------------------------------------------
        // Alldbsubnetgroupsbyregion parameter set
        //
        // [GraphQL: allDbSubnetGroupsByRegionFromAws]
        //
        [Parameter(
            ParameterSetName = "Alldbsubnetgroupsbyregion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"All DB subnet groups in a given region. Refers to logical isolation of RDS on a network. For more information, see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_VPC.WorkingWithRDSInstanceinaVPC.html.
[GraphQL: allDbSubnetGroupsByRegionFromAws]",
            Position = 0
        )]
        public SwitchParameter Alldbsubnetgroupsbyregion { get; set; }

        
        // -------------------------------------------------------------------
        // Validatenativerdsinstancenameforexport parameter set
        //
        // [GraphQL: validateAwsNativeRdsInstanceNameForExport]
        //
        [Parameter(
            ParameterSetName = "Validatenativerdsinstancenameforexport",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Validates the name used for an RDS Instance during an export operation. Returns true if the RDS Instance name is valid. Returns false, with an error message, if the RDS Instance name validation fails. Returns false, without an error message for all other failures.
[GraphQL: validateAwsNativeRdsInstanceNameForExport]",
            Position = 0
        )]
        public SwitchParameter Validatenativerdsinstancenameforexport { get; set; }

        
        // -------------------------------------------------------------------
        // Validatenativerdsclusternameforexport parameter set
        //
        // [GraphQL: validateAwsNativeRdsClusterNameForExport]
        //
        [Parameter(
            ParameterSetName = "Validatenativerdsclusternameforexport",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Validates the name used for an RDS cluster during an export operation. Returns true if the RDS cluster name is valid. Returns false, with an error message, if the RDS cluster name validation fails. Returns false, without an error message for all other failures.
[GraphQL: validateAwsNativeRdsClusterNameForExport]",
            Position = 0
        )]
        public SwitchParameter Validatenativerdsclusternameforexport { get; set; }

        [Parameter(
            ParameterSetName = "Validatenativerdsclusternameforexport",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Name of the RDS DB Cluster.
GraphQL argument rdsClusterName: String!"
        )]
        public System.String? RdsClusterName { get; set; }
        
        // -------------------------------------------------------------------
        // Nativerdsexportdefault parameter set
        //
        // [GraphQL: awsNativeRdsExportDefaults]
        //
        [Parameter(
            ParameterSetName = "Nativerdsexportdefault",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Refers to the default values for the export operation of the RDS DB Instance in the AWS Native account.
[GraphQL: awsNativeRdsExportDefaults]",
            Position = 0
        )]
        public SwitchParameter Nativerdsexportdefault { get; set; }

        [Parameter(
            ParameterSetName = "Nativerdsexportdefault",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Specifies whether the export of the instance is manual or Point-in-Time.
GraphQL argument isPointInTime: Boolean!"
        )]
        public System.Boolean? IsPointInTime { get; set; }
        
        // -------------------------------------------------------------------
        // Allec2keypairsbyregion parameter set
        //
        // [GraphQL: allEc2KeyPairsByRegionFromAws]
        //
        [Parameter(
            ParameterSetName = "Allec2keypairsbyregion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all key pairs for a given region. A key pair, consisting of a public key and a private key, is a set of security credentials that you use to prove your identity when connecting to an EC2 instance. For more information, see https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html.
[GraphQL: allEc2KeyPairsByRegionFromAws]",
            Position = 0
        )]
        public SwitchParameter Allec2keypairsbyregion { get; set; }

        
        // -------------------------------------------------------------------
        // Amitypefornativearchivedsnapshotexport parameter set
        //
        // [GraphQL: amiTypeForAwsNativeArchivedSnapshotExport]
        //
        [Parameter(
            ParameterSetName = "Amitypefornativearchivedsnapshotexport",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Amazon Machine Image (AMI) type for export of an archived EC2 Instance snapshot. For more information, see https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instances-and-amis.html.
[GraphQL: amiTypeForAwsNativeArchivedSnapshotExport]",
            Position = 0
        )]
        public SwitchParameter Amitypefornativearchivedsnapshotexport { get; set; }

        [Parameter(
            ParameterSetName = "Amitypefornativearchivedsnapshotexport",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Input for AmiTypeForAwsNativeArchivedSnapshotExport.
GraphQL argument input: AmiTypeForAwsNativeArchivedSnapshotExportInput!"
        )]
        public AmiTypeForAwsNativeArchivedSnapshotExportInput? Input { get; set; }
        
        // -------------------------------------------------------------------
        // Allrdsaurorainstanceclass parameter set
        //
        // [GraphQL: allAwsRdsAuroraInstanceClasses]
        //
        [Parameter(
            ParameterSetName = "Allrdsaurorainstanceclass",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all the database instance classes supported by AWS RDS Aurora databases.
[GraphQL: allAwsRdsAuroraInstanceClasses]",
            Position = 0
        )]
        public SwitchParameter Allrdsaurorainstanceclass { get; set; }

        
        // -------------------------------------------------------------------
        // Allsupportedrdsdatabaseinstanceclass parameter set
        //
        // [GraphQL: allSupportedAwsRdsDatabaseInstanceClasses]
        //
        [Parameter(
            ParameterSetName = "Allsupportedrdsdatabaseinstanceclass",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all the database instance classes supported by AWS RDS database for the provided DB engine and engine version. DB engine version is a optional argument, it can be ignored if we want to retrieve all the supported instance class for a DB engine irrespective of DB engine version.
[GraphQL: allSupportedAwsRdsDatabaseInstanceClasses]",
            Position = 0
        )]
        public SwitchParameter Allsupportedrdsdatabaseinstanceclass { get; set; }

        
        // -------------------------------------------------------------------
        // Computesetting parameter set
        //
        // [GraphQL: awsComputeSettings]
        //
        [Parameter(
            ParameterSetName = "Computesetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieve aws compute settings.
[GraphQL: awsComputeSettings]",
            Position = 0
        )]
        public SwitchParameter Computesetting { get; set; }

        [Parameter(
            ParameterSetName = "Computesetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Corresponds to Compute Setting Id in Rubrik tables
GraphQL argument computeSettingId: UUID!"
        )]
        public System.String? ComputeSettingId { get; set; }
        
        // -------------------------------------------------------------------
        // Allcomputesetting parameter set
        //
        // [GraphQL: allAwsComputeSettings]
        //
        [Parameter(
            ParameterSetName = "Allcomputesetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List all aws compute settings.
[GraphQL: allAwsComputeSettings]",
            Position = 0
        )]
        public SwitchParameter Allcomputesetting { get; set; }

        [Parameter(
            ParameterSetName = "Allcomputesetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Specification on how to filter a list of compute settings.
GraphQL argument filter: [AwsCloudComputeSettingFilterInput!]"
        )]
        public List<AwsCloudComputeSettingFilterInput>? Filter { get; set; }
        [Parameter(
            ParameterSetName = "Allcomputesetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Specifies the context filter to use.
GraphQL argument contextFilter: ContextFilterTypeEnum"
        )]
        public ContextFilterTypeEnum? ContextFilter { get; set; }
        
        // -------------------------------------------------------------------
        // Allcloudaccountswithfeature parameter set
        //
        // [GraphQL: allAwsCloudAccountsWithFeatures]
        //
        [Parameter(
            ParameterSetName = "Allcloudaccountswithfeature",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of active AWS cloud accounts and the features for the accounts. A cloud account is an AWS account added to the Rubrik platform.
[GraphQL: allAwsCloudAccountsWithFeatures]",
            Position = 0
        )]
        public SwitchParameter Allcloudaccountswithfeature { get; set; }

        [Parameter(
            ParameterSetName = "Allcloudaccountswithfeature",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Arguments for get cloud accounts.
GraphQL argument awsCloudAccountsArg: AwsCloudAccountsWithFeaturesInput!"
        )]
        public AwsCloudAccountsWithFeaturesInput? AwsCloudAccountsArg { get; set; }
        
        // -------------------------------------------------------------------
        // Allcloudaccountsfeatureswithexoconfig parameter set
        //
        // [GraphQL: allAwsCloudAccountsFeaturesWithExoConfigs]
        //
        [Parameter(
            ParameterSetName = "Allcloudaccountsfeatureswithexoconfig",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of active AWS cloud account features and the Exocompute mapping information for the accounts. A cloud account is an AWS account added to the Rubrik platform.
[GraphQL: allAwsCloudAccountsFeaturesWithExoConfigs]",
            Position = 0
        )]
        public SwitchParameter Allcloudaccountsfeatureswithexoconfig { get; set; }

        
        // -------------------------------------------------------------------
        // Cloudaccountwithfeature parameter set
        //
        // [GraphQL: awsCloudAccountWithFeatures]
        //
        [Parameter(
            ParameterSetName = "Cloudaccountwithfeature",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of AWS cloud accounts and the features for each account, classified by ID.
[GraphQL: awsCloudAccountWithFeatures]",
            Position = 0
        )]
        public SwitchParameter Cloudaccountwithfeature { get; set; }

        [Parameter(
            ParameterSetName = "Cloudaccountwithfeature",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"The Rubrik ID of the cloud account.
GraphQL argument cloudAccountId: UUID!"
        )]
        public System.String? CloudAccountId { get; set; }
        [Parameter(
            ParameterSetName = "Cloudaccountwithfeature",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Arguments for get cloud account.
GraphQL argument awsCloudAccountArg: AwsCloudAccountWithFeaturesInput!"
        )]
        public AwsCloudAccountWithFeaturesInput? AwsCloudAccountArg { get; set; }
        
        // -------------------------------------------------------------------
        // Cloudaccountlistvpc parameter set
        //
        // [GraphQL: awsCloudAccountListVpcs]
        //
        [Parameter(
            ParameterSetName = "Cloudaccountlistvpc",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a list of virtual private clouds (VPCs) in the specific cloud account.
[GraphQL: awsCloudAccountListVpcs]",
            Position = 0
        )]
        public SwitchParameter Cloudaccountlistvpc { get; set; }

        [Parameter(
            ParameterSetName = "Cloudaccountlistvpc",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"The ID of the cloud account.
GraphQL argument cloudAccountUuid: UUID!"
        )]
        public System.String? CloudAccountUuid { get; set; }
        [Parameter(
            ParameterSetName = "Cloudaccountlistvpc",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"A cloud account feature of Rubrik Security Cloud.
GraphQL argument feature: CloudAccountFeature!"
        )]
        public CloudAccountFeature? Feature { get; set; }
        
        // -------------------------------------------------------------------
        // Cloudaccountlistsubnet parameter set
        //
        // [GraphQL: awsCloudAccountListSubnets]
        //
        [Parameter(
            ParameterSetName = "Cloudaccountlistsubnet",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a list of subnets in the specified cloud account and virtual private cloud (VPC).
[GraphQL: awsCloudAccountListSubnets]",
            Position = 0
        )]
        public SwitchParameter Cloudaccountlistsubnet { get; set; }

        [Parameter(
            ParameterSetName = "Cloudaccountlistsubnet",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"VPC native ID.
GraphQL argument vpcID: String!"
        )]
        public System.String? VpcId { get; set; }
        
        // -------------------------------------------------------------------
        // Cloudaccountlistsecuritygroup parameter set
        //
        // [GraphQL: awsCloudAccountListSecurityGroups]
        //
        [Parameter(
            ParameterSetName = "Cloudaccountlistsecuritygroup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a list of security groups in the specified cloud account and virtual private cloud (VPC).
[GraphQL: awsCloudAccountListSecurityGroups]",
            Position = 0
        )]
        public SwitchParameter Cloudaccountlistsecuritygroup { get; set; }

        
        // -------------------------------------------------------------------
        // Cloudaccountlistkmskey parameter set
        //
        // [GraphQL: AwsCloudAccountListKMSKeys]
        //
        [Parameter(
            ParameterSetName = "Cloudaccountlistkmskey",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: AwsCloudAccountListKMSKeys]",
            Position = 0
        )]
        public SwitchParameter Cloudaccountlistkmskey { get; set; }

        
        // -------------------------------------------------------------------
        // Allexocomputeconfig parameter set
        //
        // [GraphQL: allAwsExocomputeConfigs]
        //
        [Parameter(
            ParameterSetName = "Allexocomputeconfig",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all AWS exocompute configurations filtered by a cloud account ID or a cloud account name prefix.
[GraphQL: allAwsExocomputeConfigs]",
            Position = 0
        )]
        public SwitchParameter Allexocomputeconfig { get; set; }

        [Parameter(
            ParameterSetName = "Allexocomputeconfig",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"A query that searches for Exocompute configurations with an account name or account native ID that is prefixed by the search query.
GraphQL argument awsNativeAccountIdOrNamePrefix: String!"
        )]
        public System.String? AwsNativeAccountIdOrNamePrefix { get; set; }
        
        // -------------------------------------------------------------------
        // Allcloudaccountconfig parameter set
        //
        // [GraphQL: allAwsCloudAccountConfigs]
        //
        [Parameter(
            ParameterSetName = "Allcloudaccountconfig",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all AWS cloud account configurations with the given search query.
[GraphQL: allAwsCloudAccountConfigs]",
            Position = 0
        )]
        public SwitchParameter Allcloudaccountconfig { get; set; }

        
        // -------------------------------------------------------------------
        // Allregion parameter set
        //
        // [GraphQL: allAwsRegions]
        //
        [Parameter(
            ParameterSetName = "Allregion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"All valid AWS regions for this cloud account.
[GraphQL: allAwsRegions]",
            Position = 0
        )]
        public SwitchParameter Allregion { get; set; }

        
        // -------------------------------------------------------------------
        // Allcdmversion parameter set
        //
        // [GraphQL: allAwsCdmVersions]
        //
        [Parameter(
            ParameterSetName = "Allcdmversion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get all Rubrik CDM versions in the AWS marketplace.
[GraphQL: allAwsCdmVersions]",
            Position = 0
        )]
        public SwitchParameter Allcdmversion { get; set; }

        
        // -------------------------------------------------------------------
        // Allinstanceprofilename parameter set
        //
        // [GraphQL: allAwsInstanceProfileNames]
        //
        [Parameter(
            ParameterSetName = "Allinstanceprofilename",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"All Rubrik CC-ES instance profiles in the AWS account.
[GraphQL: allAwsInstanceProfileNames]",
            Position = 0
        )]
        public SwitchParameter Allinstanceprofilename { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "Nativeroot":
                        this.ProcessRecord_Nativeroot();
                        break;
                    case "Nativeaccount":
                        this.ProcessRecord_Nativeaccount();
                        break;
                    case "Nativeec2instance":
                        this.ProcessRecord_Nativeec2instance();
                        break;
                    case "Nativeebsvolume":
                        this.ProcessRecord_Nativeebsvolume();
                        break;
                    case "Natives3bucket":
                        this.ProcessRecord_Natives3bucket();
                        break;
                    case "Nativeec2instancesbyname":
                        this.ProcessRecord_Nativeec2instancesbyname();
                        break;
                    case "Nativeebsvolumesbyname":
                        this.ProcessRecord_Nativeebsvolumesbyname();
                        break;
                    case "Allvpcsbyregion":
                        this.ProcessRecord_Allvpcsbyregion();
                        break;
                    case "Allvpc":
                        this.ProcessRecord_Allvpc();
                        break;
                    case "Isnativeebsvolumesnapshotrestorable":
                        this.ProcessRecord_Isnativeebsvolumesnapshotrestorable();
                        break;
                    case "Allavailabilityzonesbyregion":
                        this.ProcessRecord_Allavailabilityzonesbyregion();
                        break;
                    case "Allkmsencryptionkeysbyregion":
                        this.ProcessRecord_Allkmsencryptionkeysbyregion();
                        break;
                    case "Iss3bucketnameavailable":
                        this.ProcessRecord_Iss3bucketnameavailable();
                        break;
                    case "Alls3bucket":
                        this.ProcessRecord_Alls3bucket();
                        break;
                    case "Alls3bucketsdetail":
                        this.ProcessRecord_Alls3bucketsdetail();
                        break;
                    case "Nativerdsinstance":
                        this.ProcessRecord_Nativerdsinstance();
                        break;
                    case "Nativerdspointintimerestorewindow":
                        this.ProcessRecord_Nativerdspointintimerestorewindow();
                        break;
                    case "Rdsinstancedetail":
                        this.ProcessRecord_Rdsinstancedetail();
                        break;
                    case "Isnativerdsinstancelaunchconfigurationvalid":
                        this.ProcessRecord_Isnativerdsinstancelaunchconfigurationvalid();
                        break;
                    case "Alloptiongroupsbyregion":
                        this.ProcessRecord_Alloptiongroupsbyregion();
                        break;
                    case "Alldbparametergroupsbyregion":
                        this.ProcessRecord_Alldbparametergroupsbyregion();
                        break;
                    case "Alldbsubnetgroupsbyregion":
                        this.ProcessRecord_Alldbsubnetgroupsbyregion();
                        break;
                    case "Validatenativerdsinstancenameforexport":
                        this.ProcessRecord_Validatenativerdsinstancenameforexport();
                        break;
                    case "Validatenativerdsclusternameforexport":
                        this.ProcessRecord_Validatenativerdsclusternameforexport();
                        break;
                    case "Nativerdsexportdefault":
                        this.ProcessRecord_Nativerdsexportdefault();
                        break;
                    case "Allec2keypairsbyregion":
                        this.ProcessRecord_Allec2keypairsbyregion();
                        break;
                    case "Amitypefornativearchivedsnapshotexport":
                        this.ProcessRecord_Amitypefornativearchivedsnapshotexport();
                        break;
                    case "Allrdsaurorainstanceclass":
                        this.ProcessRecord_Allrdsaurorainstanceclass();
                        break;
                    case "Allsupportedrdsdatabaseinstanceclass":
                        this.ProcessRecord_Allsupportedrdsdatabaseinstanceclass();
                        break;
                    case "Computesetting":
                        this.ProcessRecord_Computesetting();
                        break;
                    case "Allcomputesetting":
                        this.ProcessRecord_Allcomputesetting();
                        break;
                    case "Allcloudaccountswithfeature":
                        this.ProcessRecord_Allcloudaccountswithfeature();
                        break;
                    case "Allcloudaccountsfeatureswithexoconfig":
                        this.ProcessRecord_Allcloudaccountsfeatureswithexoconfig();
                        break;
                    case "Cloudaccountwithfeature":
                        this.ProcessRecord_Cloudaccountwithfeature();
                        break;
                    case "Cloudaccountlistvpc":
                        this.ProcessRecord_Cloudaccountlistvpc();
                        break;
                    case "Cloudaccountlistsubnet":
                        this.ProcessRecord_Cloudaccountlistsubnet();
                        break;
                    case "Cloudaccountlistsecuritygroup":
                        this.ProcessRecord_Cloudaccountlistsecuritygroup();
                        break;
                    case "Cloudaccountlistkmskey":
                        this.ProcessRecord_Cloudaccountlistkmskey();
                        break;
                    case "Allexocomputeconfig":
                        this.ProcessRecord_Allexocomputeconfig();
                        break;
                    case "Allcloudaccountconfig":
                        this.ProcessRecord_Allcloudaccountconfig();
                        break;
                    case "Allregion":
                        this.ProcessRecord_Allregion();
                        break;
                    case "Allcdmversion":
                        this.ProcessRecord_Allcdmversion();
                        break;
                    case "Allinstanceprofilename":
                        this.ProcessRecord_Allinstanceprofilename();
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
        protected void ProcessRecord_Nativeroot()
        {
            this._logger.name += " -Nativeroot";
            // Invoke graphql operation awsNativeRoot
            InvokeQueryAwsNativeRoot();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeAccount.
        protected void ProcessRecord_Nativeaccount()
        {
            this._logger.name += " -Nativeaccount";
            // Invoke graphql operation awsNativeAccount
            InvokeQueryAwsNativeAccount();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeEc2Instance.
        protected void ProcessRecord_Nativeec2instance()
        {
            this._logger.name += " -Nativeec2instance";
            // Invoke graphql operation awsNativeEc2Instance
            InvokeQueryAwsNativeEc2Instance();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeEbsVolume.
        protected void ProcessRecord_Nativeebsvolume()
        {
            this._logger.name += " -Nativeebsvolume";
            // Invoke graphql operation awsNativeEbsVolume
            InvokeQueryAwsNativeEbsVolume();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeS3Bucket.
        protected void ProcessRecord_Natives3bucket()
        {
            this._logger.name += " -Natives3bucket";
            // Invoke graphql operation awsNativeS3Bucket
            InvokeQueryAwsNativeS3Bucket();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeEc2InstancesByName.
        protected void ProcessRecord_Nativeec2instancesbyname()
        {
            this._logger.name += " -Nativeec2instancesbyname";
            // Invoke graphql operation awsNativeEc2InstancesByName
            InvokeQueryAwsNativeEc2InstancesByName();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeEbsVolumesByName.
        protected void ProcessRecord_Nativeebsvolumesbyname()
        {
            this._logger.name += " -Nativeebsvolumesbyname";
            // Invoke graphql operation awsNativeEbsVolumesByName
            InvokeQueryAwsNativeEbsVolumesByName();
        }

        // This parameter set invokes a single graphql operation:
        // allVpcsByRegionFromAws.
        protected void ProcessRecord_Allvpcsbyregion()
        {
            this._logger.name += " -Allvpcsbyregion";
            // Invoke graphql operation allVpcsByRegionFromAws
            InvokeQueryAllVpcsByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allVpcsFromAws.
        protected void ProcessRecord_Allvpc()
        {
            this._logger.name += " -Allvpc";
            // Invoke graphql operation allVpcsFromAws
            InvokeQueryAllVpcsFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // isAwsNativeEbsVolumeSnapshotRestorable.
        protected void ProcessRecord_Isnativeebsvolumesnapshotrestorable()
        {
            this._logger.name += " -Isnativeebsvolumesnapshotrestorable";
            // Invoke graphql operation isAwsNativeEbsVolumeSnapshotRestorable
            InvokeQueryIsAwsNativeEbsVolumeSnapshotRestorable();
        }

        // This parameter set invokes a single graphql operation:
        // allAvailabilityZonesByRegionFromAws.
        protected void ProcessRecord_Allavailabilityzonesbyregion()
        {
            this._logger.name += " -Allavailabilityzonesbyregion";
            // Invoke graphql operation allAvailabilityZonesByRegionFromAws
            InvokeQueryAllAvailabilityZonesByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allKmsEncryptionKeysByRegionFromAws.
        protected void ProcessRecord_Allkmsencryptionkeysbyregion()
        {
            this._logger.name += " -Allkmsencryptionkeysbyregion";
            // Invoke graphql operation allKmsEncryptionKeysByRegionFromAws
            InvokeQueryAllKmsEncryptionKeysByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // isAwsS3BucketNameAvailable.
        protected void ProcessRecord_Iss3bucketnameavailable()
        {
            this._logger.name += " -Iss3bucketnameavailable";
            // Invoke graphql operation isAwsS3BucketNameAvailable
            InvokeQueryIsAwsS3BucketNameAvailable();
        }

        // This parameter set invokes a single graphql operation:
        // allS3BucketsFromAws.
        protected void ProcessRecord_Alls3bucket()
        {
            this._logger.name += " -Alls3bucket";
            // Invoke graphql operation allS3BucketsFromAws
            InvokeQueryAllS3BucketsFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allS3BucketsDetailsFromAws.
        protected void ProcessRecord_Alls3bucketsdetail()
        {
            this._logger.name += " -Alls3bucketsdetail";
            // Invoke graphql operation allS3BucketsDetailsFromAws
            InvokeQueryAllS3BucketsDetailsFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeRdsInstance.
        protected void ProcessRecord_Nativerdsinstance()
        {
            this._logger.name += " -Nativerdsinstance";
            // Invoke graphql operation awsNativeRdsInstance
            InvokeQueryAwsNativeRdsInstance();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeRdsPointInTimeRestoreWindow.
        protected void ProcessRecord_Nativerdspointintimerestorewindow()
        {
            this._logger.name += " -Nativerdspointintimerestorewindow";
            // Invoke graphql operation awsNativeRdsPointInTimeRestoreWindow
            InvokeQueryAwsNativeRdsPointInTimeRestoreWindow();
        }

        // This parameter set invokes a single graphql operation:
        // rdsInstanceDetailsFromAws.
        protected void ProcessRecord_Rdsinstancedetail()
        {
            this._logger.name += " -Rdsinstancedetail";
            // Invoke graphql operation rdsInstanceDetailsFromAws
            InvokeQueryRdsInstanceDetailsFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // isAwsNativeRdsInstanceLaunchConfigurationValid.
        protected void ProcessRecord_Isnativerdsinstancelaunchconfigurationvalid()
        {
            this._logger.name += " -Isnativerdsinstancelaunchconfigurationvalid";
            // Invoke graphql operation isAwsNativeRdsInstanceLaunchConfigurationValid
            InvokeQueryIsAwsNativeRdsInstanceLaunchConfigurationValid();
        }

        // This parameter set invokes a single graphql operation:
        // allOptionGroupsByRegionFromAws.
        protected void ProcessRecord_Alloptiongroupsbyregion()
        {
            this._logger.name += " -Alloptiongroupsbyregion";
            // Invoke graphql operation allOptionGroupsByRegionFromAws
            InvokeQueryAllOptionGroupsByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allDbParameterGroupsByRegionFromAws.
        protected void ProcessRecord_Alldbparametergroupsbyregion()
        {
            this._logger.name += " -Alldbparametergroupsbyregion";
            // Invoke graphql operation allDbParameterGroupsByRegionFromAws
            InvokeQueryAllDbParameterGroupsByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allDbSubnetGroupsByRegionFromAws.
        protected void ProcessRecord_Alldbsubnetgroupsbyregion()
        {
            this._logger.name += " -Alldbsubnetgroupsbyregion";
            // Invoke graphql operation allDbSubnetGroupsByRegionFromAws
            InvokeQueryAllDbSubnetGroupsByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // validateAwsNativeRdsInstanceNameForExport.
        protected void ProcessRecord_Validatenativerdsinstancenameforexport()
        {
            this._logger.name += " -Validatenativerdsinstancenameforexport";
            // Invoke graphql operation validateAwsNativeRdsInstanceNameForExport
            InvokeQueryValidateAwsNativeRdsInstanceNameForExport();
        }

        // This parameter set invokes a single graphql operation:
        // validateAwsNativeRdsClusterNameForExport.
        protected void ProcessRecord_Validatenativerdsclusternameforexport()
        {
            this._logger.name += " -Validatenativerdsclusternameforexport";
            // Invoke graphql operation validateAwsNativeRdsClusterNameForExport
            InvokeQueryValidateAwsNativeRdsClusterNameForExport();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeRdsExportDefaults.
        protected void ProcessRecord_Nativerdsexportdefault()
        {
            this._logger.name += " -Nativerdsexportdefault";
            // Invoke graphql operation awsNativeRdsExportDefaults
            InvokeQueryAwsNativeRdsExportDefaults();
        }

        // This parameter set invokes a single graphql operation:
        // allEc2KeyPairsByRegionFromAws.
        protected void ProcessRecord_Allec2keypairsbyregion()
        {
            this._logger.name += " -Allec2keypairsbyregion";
            // Invoke graphql operation allEc2KeyPairsByRegionFromAws
            InvokeQueryAllEc2KeyPairsByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // amiTypeForAwsNativeArchivedSnapshotExport.
        protected void ProcessRecord_Amitypefornativearchivedsnapshotexport()
        {
            this._logger.name += " -Amitypefornativearchivedsnapshotexport";
            // Invoke graphql operation amiTypeForAwsNativeArchivedSnapshotExport
            InvokeQueryAmiTypeForAwsNativeArchivedSnapshotExport();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsRdsAuroraInstanceClasses.
        protected void ProcessRecord_Allrdsaurorainstanceclass()
        {
            this._logger.name += " -Allrdsaurorainstanceclass";
            // Invoke graphql operation allAwsRdsAuroraInstanceClasses
            InvokeQueryAllAwsRdsAuroraInstanceClasses();
        }

        // This parameter set invokes a single graphql operation:
        // allSupportedAwsRdsDatabaseInstanceClasses.
        protected void ProcessRecord_Allsupportedrdsdatabaseinstanceclass()
        {
            this._logger.name += " -Allsupportedrdsdatabaseinstanceclass";
            // Invoke graphql operation allSupportedAwsRdsDatabaseInstanceClasses
            InvokeQueryAllSupportedAwsRdsDatabaseInstanceClasses();
        }

        // This parameter set invokes a single graphql operation:
        // awsComputeSettings.
        protected void ProcessRecord_Computesetting()
        {
            this._logger.name += " -Computesetting";
            // Invoke graphql operation awsComputeSettings
            InvokeQueryAwsComputeSettings();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsComputeSettings.
        protected void ProcessRecord_Allcomputesetting()
        {
            this._logger.name += " -Allcomputesetting";
            // Invoke graphql operation allAwsComputeSettings
            InvokeQueryAllAwsComputeSettings();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsCloudAccountsWithFeatures.
        protected void ProcessRecord_Allcloudaccountswithfeature()
        {
            this._logger.name += " -Allcloudaccountswithfeature";
            // Invoke graphql operation allAwsCloudAccountsWithFeatures
            InvokeQueryAllAwsCloudAccountsWithFeatures();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsCloudAccountsFeaturesWithExoConfigs.
        protected void ProcessRecord_Allcloudaccountsfeatureswithexoconfig()
        {
            this._logger.name += " -Allcloudaccountsfeatureswithexoconfig";
            // Invoke graphql operation allAwsCloudAccountsFeaturesWithExoConfigs
            InvokeQueryAllAwsCloudAccountsFeaturesWithExoConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // awsCloudAccountWithFeatures.
        protected void ProcessRecord_Cloudaccountwithfeature()
        {
            this._logger.name += " -Cloudaccountwithfeature";
            // Invoke graphql operation awsCloudAccountWithFeatures
            InvokeQueryAwsCloudAccountWithFeatures();
        }

        // This parameter set invokes a single graphql operation:
        // awsCloudAccountListVpcs.
        protected void ProcessRecord_Cloudaccountlistvpc()
        {
            this._logger.name += " -Cloudaccountlistvpc";
            // Invoke graphql operation awsCloudAccountListVpcs
            InvokeQueryAwsCloudAccountListVpcs();
        }

        // This parameter set invokes a single graphql operation:
        // awsCloudAccountListSubnets.
        protected void ProcessRecord_Cloudaccountlistsubnet()
        {
            this._logger.name += " -Cloudaccountlistsubnet";
            // Invoke graphql operation awsCloudAccountListSubnets
            InvokeQueryAwsCloudAccountListSubnets();
        }

        // This parameter set invokes a single graphql operation:
        // awsCloudAccountListSecurityGroups.
        protected void ProcessRecord_Cloudaccountlistsecuritygroup()
        {
            this._logger.name += " -Cloudaccountlistsecuritygroup";
            // Invoke graphql operation awsCloudAccountListSecurityGroups
            InvokeQueryAwsCloudAccountListSecurityGroups();
        }

        // This parameter set invokes a single graphql operation:
        // AwsCloudAccountListKMSKeys.
        protected void ProcessRecord_Cloudaccountlistkmskey()
        {
            this._logger.name += " -Cloudaccountlistkmskey";
            // Invoke graphql operation AwsCloudAccountListKMSKeys
            InvokeQueryAwsCloudAccountListKmsKeys();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsExocomputeConfigs.
        protected void ProcessRecord_Allexocomputeconfig()
        {
            this._logger.name += " -Allexocomputeconfig";
            // Invoke graphql operation allAwsExocomputeConfigs
            InvokeQueryAllAwsExocomputeConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsCloudAccountConfigs.
        protected void ProcessRecord_Allcloudaccountconfig()
        {
            this._logger.name += " -Allcloudaccountconfig";
            // Invoke graphql operation allAwsCloudAccountConfigs
            InvokeQueryAllAwsCloudAccountConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsRegions.
        protected void ProcessRecord_Allregion()
        {
            this._logger.name += " -Allregion";
            // Invoke graphql operation allAwsRegions
            InvokeQueryAllAwsRegions();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsCdmVersions.
        protected void ProcessRecord_Allcdmversion()
        {
            this._logger.name += " -Allcdmversion";
            // Invoke graphql operation allAwsCdmVersions
            InvokeQueryAllAwsCdmVersions();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsInstanceProfileNames.
        protected void ProcessRecord_Allinstanceprofilename()
        {
            this._logger.name += " -Allinstanceprofilename";
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            var parameters = "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$dbEngine: AwsNativeRdsDbEngine!,$dbEngineVersion: String!,$dbClass: AwsNativeRdsDbInstanceClass!,$primaryAz: String,$storageType: AwsNativeRdsStorageType,$isMultiAz: Boolean!,$kmsKeyId: String,$iops: Int)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryIsAwsNativeRdsInstanceLaunchConfigurationValid" + parameters + "{" + document + "}",
                OperationName = "QueryIsAwsNativeRdsInstanceLaunchConfigurationValid",
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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