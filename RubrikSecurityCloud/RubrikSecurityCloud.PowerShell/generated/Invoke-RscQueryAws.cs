// Invoke-RscQueryAws.cs
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
using Rubrik.SecurityCloud.NetSDK.Library.HelperClasses;
using Rubrik.SecurityCloud.Operations;
using GraphQL;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
{
    [Cmdlet(
        "Invoke",
        "RscQueryAws",
        DefaultParameterSetName = "allVpc")
    ]
    public class Invoke_RscQueryAws : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // NativeRoot parameter set
        //
        // GraphQL operation: awsNativeRoot:AwsNativeRoot!
        //
        [Parameter(
            ParameterSetName = "NativeRoot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: awsNativeRoot:AwsNativeRoot!",
            Position = 0
        )]
        public SwitchParameter NativeRoot { get; set; }

        
        // -------------------------------------------------------------------
        // NativeAccount parameter set
        //
        // GraphQL operation: awsNativeAccount(awsNativeAccountRubrikId: UUID!, awsNativeProtectionFeature: AwsNativeProtectionFeature!):AwsNativeAccount!
        //
        [Parameter(
            ParameterSetName = "NativeAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: awsNativeAccount(awsNativeAccountRubrikId: UUID!, awsNativeProtectionFeature: AwsNativeProtectionFeature!):AwsNativeAccount!",
            Position = 0
        )]
        public SwitchParameter NativeAccount { get; set; }

        [Parameter(
            ParameterSetName = "NativeAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument awsNativeAccountRubrikId: UUID!"
        )]
        public System.String? AwsNativeAccountRubrikId { get; set; }
        [Parameter(
            ParameterSetName = "NativeAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument awsNativeProtectionFeature: AwsNativeProtectionFeature!"
        )]
        public AwsNativeProtectionFeature? AwsNativeProtectionFeature { get; set; }
        
        // -------------------------------------------------------------------
        // NativeEc2Instance parameter set
        //
        // GraphQL operation: awsNativeEc2Instance(ec2InstanceRubrikId: UUID!):AwsNativeEc2Instance!
        //
        [Parameter(
            ParameterSetName = "NativeEc2Instance",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: awsNativeEc2Instance(ec2InstanceRubrikId: UUID!):AwsNativeEc2Instance!",
            Position = 0
        )]
        public SwitchParameter NativeEc2Instance { get; set; }

        [Parameter(
            ParameterSetName = "NativeEc2Instance",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument ec2InstanceRubrikId: UUID!"
        )]
        public System.String? Ec2InstanceRubrikId { get; set; }
        
        // -------------------------------------------------------------------
        // NativeEbsVolume parameter set
        //
        // GraphQL operation: awsNativeEbsVolume(ebsVolumeRubrikId: UUID!):AwsNativeEbsVolume!
        //
        [Parameter(
            ParameterSetName = "NativeEbsVolume",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: awsNativeEbsVolume(ebsVolumeRubrikId: UUID!):AwsNativeEbsVolume!",
            Position = 0
        )]
        public SwitchParameter NativeEbsVolume { get; set; }

        [Parameter(
            ParameterSetName = "NativeEbsVolume",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument ebsVolumeRubrikId: UUID!"
        )]
        public System.String? EbsVolumeRubrikId { get; set; }
        
        // -------------------------------------------------------------------
        // NativeS3Bucket parameter set
        //
        // GraphQL operation: awsNativeS3Bucket(s3BucketRubrikId: UUID!):AwsNativeS3Bucket!
        //
        [Parameter(
            ParameterSetName = "NativeS3Bucket",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: awsNativeS3Bucket(s3BucketRubrikId: UUID!):AwsNativeS3Bucket!",
            Position = 0
        )]
        public SwitchParameter NativeS3Bucket { get; set; }

        [Parameter(
            ParameterSetName = "NativeS3Bucket",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument s3BucketRubrikId: UUID!"
        )]
        public System.String? S3BucketRubrikId { get; set; }
        
        // -------------------------------------------------------------------
        // NativeEc2InstancesByName parameter set
        //
        // GraphQL operation: awsNativeEc2InstancesByName(,   first: Int,   after: String,   last: Int,   before: String,   sortBy: AwsNativeEc2InstanceSortFields,   sortOrder: SortOrder,   ec2InstanceName: String!, ):AwsNativeEc2InstanceConnection!
        //
        [Parameter(
            ParameterSetName = "NativeEc2InstancesByName",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: awsNativeEc2InstancesByName(,   first: Int,   after: String,   last: Int,   before: String,   sortBy: AwsNativeEc2InstanceSortFields,   sortOrder: SortOrder,   ec2InstanceName: String!, ):AwsNativeEc2InstanceConnection!",
            Position = 0
        )]
        public SwitchParameter NativeEc2InstancesByName { get; set; }

        [Parameter(
            ParameterSetName = "NativeEc2InstancesByName",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument first: Int"
        )]
        public System.Int32? First { get; set; }
        [Parameter(
            ParameterSetName = "NativeEc2InstancesByName",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument after: String"
        )]
        public System.String? After { get; set; }
        [Parameter(
            ParameterSetName = "NativeEc2InstancesByName",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument last: Int"
        )]
        public System.Int32? Last { get; set; }
        [Parameter(
            ParameterSetName = "NativeEc2InstancesByName",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument before: String"
        )]
        public System.String? Before { get; set; }
        [Parameter(
            ParameterSetName = "NativeEc2InstancesByName",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument sortBy: AwsNativeEc2InstanceSortFields"
        )]
        public AwsNativeEc2InstanceSortFields? SortBy { get; set; }
        [Parameter(
            ParameterSetName = "NativeEc2InstancesByName",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument sortOrder: SortOrder"
        )]
        public SortOrder? SortOrder { get; set; }
        [Parameter(
            ParameterSetName = "NativeEc2InstancesByName",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument ec2InstanceName: String!"
        )]
        public System.String? Ec2InstanceName { get; set; }
        
        // -------------------------------------------------------------------
        // NativeEbsVolumesByName parameter set
        //
        // GraphQL operation: awsNativeEbsVolumesByName(,   first: Int,   after: String,   last: Int,   before: String,   sortBy: AwsNativeEbsVolumeSortFields,   sortOrder: SortOrder,   ebsVolumeName: String!, ):AwsNativeEbsVolumeConnection!
        //
        [Parameter(
            ParameterSetName = "NativeEbsVolumesByName",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: awsNativeEbsVolumesByName(,   first: Int,   after: String,   last: Int,   before: String,   sortBy: AwsNativeEbsVolumeSortFields,   sortOrder: SortOrder,   ebsVolumeName: String!, ):AwsNativeEbsVolumeConnection!",
            Position = 0
        )]
        public SwitchParameter NativeEbsVolumesByName { get; set; }

        [Parameter(
            ParameterSetName = "NativeEbsVolumesByName",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument ebsVolumeName: String!"
        )]
        public System.String? EbsVolumeName { get; set; }
        
        // -------------------------------------------------------------------
        // allVpcsByRegion parameter set
        //
        // GraphQL operation: allVpcsByRegionFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion!):[AwsVpc!]!
        //
        [Parameter(
            ParameterSetName = "allVpcsByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allVpcsByRegionFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion!):[AwsVpc!]!",
            Position = 0
        )]
        public SwitchParameter allVpcsByRegion { get; set; }

        [Parameter(
            ParameterSetName = "allVpcsByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument awsAccountRubrikId: UUID!"
        )]
        public System.String? AwsAccountRubrikId { get; set; }
        [Parameter(
            ParameterSetName = "allVpcsByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument region: AwsNativeRegion!"
        )]
        public AwsNativeRegion? Region { get; set; }
        
        // -------------------------------------------------------------------
        // allVpc parameter set
        //
        // GraphQL operation: allVpcsFromAws(awsAccountRubrikId: UUID):[AwsVpc!]!
        //
        [Parameter(
            ParameterSetName = "allVpc",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allVpcsFromAws(awsAccountRubrikId: UUID):[AwsVpc!]!",
            Position = 0
        )]
        public SwitchParameter allVpc { get; set; }

        
        // -------------------------------------------------------------------
        // isNativeEbsVolumeSnapshotRestorable parameter set
        //
        // GraphQL operation: isAwsNativeEbsVolumeSnapshotRestorable(snapshotId: String!):IsVolumeSnapshotRestorableReply!
        //
        [Parameter(
            ParameterSetName = "isNativeEbsVolumeSnapshotRestorable",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: isAwsNativeEbsVolumeSnapshotRestorable(snapshotId: String!):IsVolumeSnapshotRestorableReply!",
            Position = 0
        )]
        public SwitchParameter isNativeEbsVolumeSnapshotRestorable { get; set; }

        [Parameter(
            ParameterSetName = "isNativeEbsVolumeSnapshotRestorable",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument snapshotId: String!"
        )]
        public System.String? SnapshotId { get; set; }
        
        // -------------------------------------------------------------------
        // allAvailabilityZonesByRegion parameter set
        //
        // GraphQL operation: allAvailabilityZonesByRegionFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion!):[String!]!
        //
        [Parameter(
            ParameterSetName = "allAvailabilityZonesByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allAvailabilityZonesByRegionFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion!):[String!]!",
            Position = 0
        )]
        public SwitchParameter allAvailabilityZonesByRegion { get; set; }

        
        // -------------------------------------------------------------------
        // allKmsEncryptionKeysByRegion parameter set
        //
        // GraphQL operation: allKmsEncryptionKeysByRegionFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion!):[KmsEncryptionKey!]!
        //
        [Parameter(
            ParameterSetName = "allKmsEncryptionKeysByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allKmsEncryptionKeysByRegionFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion!):[KmsEncryptionKey!]!",
            Position = 0
        )]
        public SwitchParameter allKmsEncryptionKeysByRegion { get; set; }

        
        // -------------------------------------------------------------------
        // isS3BucketNameAvailable parameter set
        //
        // GraphQL operation: isAwsS3BucketNameAvailable(bucketName: String!, awsAccountRubrikId: UUID!):Boolean!
        //
        [Parameter(
            ParameterSetName = "isS3BucketNameAvailable",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: isAwsS3BucketNameAvailable(bucketName: String!, awsAccountRubrikId: UUID!):Boolean!",
            Position = 0
        )]
        public SwitchParameter isS3BucketNameAvailable { get; set; }

        [Parameter(
            ParameterSetName = "isS3BucketNameAvailable",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument bucketName: String!"
        )]
        public System.String? BucketName { get; set; }
        
        // -------------------------------------------------------------------
        // allS3Bucket parameter set
        //
        // GraphQL operation: allS3BucketsFromAws(awsAccountRubrikId: UUID!):[String!]!
        //
        [Parameter(
            ParameterSetName = "allS3Bucket",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allS3BucketsFromAws(awsAccountRubrikId: UUID!):[String!]!",
            Position = 0
        )]
        public SwitchParameter allS3Bucket { get; set; }

        
        // -------------------------------------------------------------------
        // NativeRdsInstance parameter set
        //
        // GraphQL operation: awsNativeRdsInstance(rdsInstanceRubrikId: UUID!):AwsNativeRdsInstance!
        //
        [Parameter(
            ParameterSetName = "NativeRdsInstance",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: awsNativeRdsInstance(rdsInstanceRubrikId: UUID!):AwsNativeRdsInstance!",
            Position = 0
        )]
        public SwitchParameter NativeRdsInstance { get; set; }

        [Parameter(
            ParameterSetName = "NativeRdsInstance",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument rdsInstanceRubrikId: UUID!"
        )]
        public System.String? RdsInstanceRubrikId { get; set; }
        
        // -------------------------------------------------------------------
        // NativeRdsPointInTimeRestoreWindow parameter set
        //
        // GraphQL operation: awsNativeRdsPointInTimeRestoreWindow(awsAccountRubrikId: UUID!, region: AwsNativeRegion!, rdsInstanceName: String!):AwsNativeRdsPointInTimeRestoreWindow!
        //
        [Parameter(
            ParameterSetName = "NativeRdsPointInTimeRestoreWindow",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: awsNativeRdsPointInTimeRestoreWindow(awsAccountRubrikId: UUID!, region: AwsNativeRegion!, rdsInstanceName: String!):AwsNativeRdsPointInTimeRestoreWindow!",
            Position = 0
        )]
        public SwitchParameter NativeRdsPointInTimeRestoreWindow { get; set; }

        [Parameter(
            ParameterSetName = "NativeRdsPointInTimeRestoreWindow",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument rdsInstanceName: String!"
        )]
        public System.String? RdsInstanceName { get; set; }
        
        // -------------------------------------------------------------------
        // rdsInstanceDetail parameter set
        //
        // GraphQL operation: rdsInstanceDetailsFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion!, rdsInstanceName: String!):RdsInstanceDetailsFromAws!
        //
        [Parameter(
            ParameterSetName = "rdsInstanceDetail",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: rdsInstanceDetailsFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion!, rdsInstanceName: String!):RdsInstanceDetailsFromAws!",
            Position = 0
        )]
        public SwitchParameter rdsInstanceDetail { get; set; }

        
        // -------------------------------------------------------------------
        // isNativeRdsInstanceLaunchConfigurationValid parameter set
        //
        // GraphQL operation: isAwsNativeRdsInstanceLaunchConfigurationValid(,   awsAccountRubrikId: UUID!,   region: AwsNativeRegion!,   dbEngine: AwsNativeRdsDbEngine!,   dbEngineVersion: String!,   dbClass: AwsNativeRdsDbInstanceClass!,   primaryAz: String,   storageType: AwsNativeRdsStorageType,   isMultiAz: Boolean!,   kmsKeyId: String,   iops: Int, ):Boolean!
        //
        [Parameter(
            ParameterSetName = "isNativeRdsInstanceLaunchConfigurationValid",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: isAwsNativeRdsInstanceLaunchConfigurationValid(,   awsAccountRubrikId: UUID!,   region: AwsNativeRegion!,   dbEngine: AwsNativeRdsDbEngine!,   dbEngineVersion: String!,   dbClass: AwsNativeRdsDbInstanceClass!,   primaryAz: String,   storageType: AwsNativeRdsStorageType,   isMultiAz: Boolean!,   kmsKeyId: String,   iops: Int, ):Boolean!",
            Position = 0
        )]
        public SwitchParameter isNativeRdsInstanceLaunchConfigurationValid { get; set; }

        [Parameter(
            ParameterSetName = "isNativeRdsInstanceLaunchConfigurationValid",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument dbEngine: AwsNativeRdsDbEngine!"
        )]
        public AwsNativeRdsDbEngine? DbEngine { get; set; }
        [Parameter(
            ParameterSetName = "isNativeRdsInstanceLaunchConfigurationValid",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument dbEngineVersion: String!"
        )]
        public System.String? DbEngineVersion { get; set; }
        [Parameter(
            ParameterSetName = "isNativeRdsInstanceLaunchConfigurationValid",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument dbClass: AwsNativeRdsDbInstanceClass!"
        )]
        public AwsNativeRdsDbInstanceClass? DbClass { get; set; }
        [Parameter(
            ParameterSetName = "isNativeRdsInstanceLaunchConfigurationValid",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument primaryAz: String"
        )]
        public System.String? PrimaryAz { get; set; }
        [Parameter(
            ParameterSetName = "isNativeRdsInstanceLaunchConfigurationValid",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument storageType: AwsNativeRdsStorageType"
        )]
        public AwsNativeRdsStorageType? StorageType { get; set; }
        [Parameter(
            ParameterSetName = "isNativeRdsInstanceLaunchConfigurationValid",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument isMultiAz: Boolean!"
        )]
        public System.Boolean? IsMultiAz { get; set; }
        [Parameter(
            ParameterSetName = "isNativeRdsInstanceLaunchConfigurationValid",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument kmsKeyId: String"
        )]
        public System.String? KmsKeyId { get; set; }
        [Parameter(
            ParameterSetName = "isNativeRdsInstanceLaunchConfigurationValid",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument iops: Int"
        )]
        public System.Int32? Iops { get; set; }
        
        // -------------------------------------------------------------------
        // allOptionGroupsByRegion parameter set
        //
        // GraphQL operation: allOptionGroupsByRegionFromAws(,   awsAccountRubrikId: UUID!,   region: AwsNativeRegion!,   dbEngine: AwsNativeRdsDbEngine!,   dbEngineVersion: String!,   majorEngineVersion: String!, ):[OptionGroup!]!
        //
        [Parameter(
            ParameterSetName = "allOptionGroupsByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allOptionGroupsByRegionFromAws(,   awsAccountRubrikId: UUID!,   region: AwsNativeRegion!,   dbEngine: AwsNativeRdsDbEngine!,   dbEngineVersion: String!,   majorEngineVersion: String!, ):[OptionGroup!]!",
            Position = 0
        )]
        public SwitchParameter allOptionGroupsByRegion { get; set; }

        [Parameter(
            ParameterSetName = "allOptionGroupsByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument majorEngineVersion: String!"
        )]
        public System.String? MajorEngineVersion { get; set; }
        
        // -------------------------------------------------------------------
        // allDbParameterGroupsByRegion parameter set
        //
        // GraphQL operation: allDbParameterGroupsByRegionFromAws(,   awsAccountRubrikId: UUID!,   region: AwsNativeRegion!,   dbEngine: AwsNativeRdsDbEngine!,   dbEngineVersion: String!,   rdsType: AwsNativeRdsType, ):[DbParameterGroup!]!
        //
        [Parameter(
            ParameterSetName = "allDbParameterGroupsByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allDbParameterGroupsByRegionFromAws(,   awsAccountRubrikId: UUID!,   region: AwsNativeRegion!,   dbEngine: AwsNativeRdsDbEngine!,   dbEngineVersion: String!,   rdsType: AwsNativeRdsType, ):[DbParameterGroup!]!",
            Position = 0
        )]
        public SwitchParameter allDbParameterGroupsByRegion { get; set; }

        [Parameter(
            ParameterSetName = "allDbParameterGroupsByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument rdsType: AwsNativeRdsType"
        )]
        public AwsNativeRdsType? RdsType { get; set; }
        
        // -------------------------------------------------------------------
        // allDbSubnetGroupsByRegion parameter set
        //
        // GraphQL operation: allDbSubnetGroupsByRegionFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion!):[SubnetGroup!]!
        //
        [Parameter(
            ParameterSetName = "allDbSubnetGroupsByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allDbSubnetGroupsByRegionFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion!):[SubnetGroup!]!",
            Position = 0
        )]
        public SwitchParameter allDbSubnetGroupsByRegion { get; set; }

        
        // -------------------------------------------------------------------
        // validateNativeRdsInstanceNameForExport parameter set
        //
        // GraphQL operation: validateAwsNativeRdsInstanceNameForExport(awsAccountRubrikId: UUID!, region: AwsNativeRegion!, rdsInstanceName: String!):ValidateAwsNativeRdsInstanceNameForExportReply!
        //
        [Parameter(
            ParameterSetName = "validateNativeRdsInstanceNameForExport",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: validateAwsNativeRdsInstanceNameForExport(awsAccountRubrikId: UUID!, region: AwsNativeRegion!, rdsInstanceName: String!):ValidateAwsNativeRdsInstanceNameForExportReply!",
            Position = 0
        )]
        public SwitchParameter validateNativeRdsInstanceNameForExport { get; set; }

        
        // -------------------------------------------------------------------
        // validateNativeRdsClusterNameForExport parameter set
        //
        // GraphQL operation: validateAwsNativeRdsClusterNameForExport(awsAccountRubrikId: UUID!, region: AwsNativeRegion!, rdsClusterName: String!):ValidateAwsNativeRdsClusterNameForExportReply!
        //
        [Parameter(
            ParameterSetName = "validateNativeRdsClusterNameForExport",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: validateAwsNativeRdsClusterNameForExport(awsAccountRubrikId: UUID!, region: AwsNativeRegion!, rdsClusterName: String!):ValidateAwsNativeRdsClusterNameForExportReply!",
            Position = 0
        )]
        public SwitchParameter validateNativeRdsClusterNameForExport { get; set; }

        [Parameter(
            ParameterSetName = "validateNativeRdsClusterNameForExport",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument rdsClusterName: String!"
        )]
        public System.String? RdsClusterName { get; set; }
        
        // -------------------------------------------------------------------
        // NativeRdsExportDefault parameter set
        //
        // GraphQL operation: awsNativeRdsExportDefaults(rdsInstanceRubrikId: UUID!, snapshotId: String, isPointInTime: Boolean!):RdsInstanceExportDefaults!
        //
        [Parameter(
            ParameterSetName = "NativeRdsExportDefault",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: awsNativeRdsExportDefaults(rdsInstanceRubrikId: UUID!, snapshotId: String, isPointInTime: Boolean!):RdsInstanceExportDefaults!",
            Position = 0
        )]
        public SwitchParameter NativeRdsExportDefault { get; set; }

        [Parameter(
            ParameterSetName = "NativeRdsExportDefault",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument isPointInTime: Boolean!"
        )]
        public System.Boolean? IsPointInTime { get; set; }
        
        // -------------------------------------------------------------------
        // allEc2KeyPairsByRegion parameter set
        //
        // GraphQL operation: allEc2KeyPairsByRegionFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion!):[String!]!
        //
        [Parameter(
            ParameterSetName = "allEc2KeyPairsByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allEc2KeyPairsByRegionFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion!):[String!]!",
            Position = 0
        )]
        public SwitchParameter allEc2KeyPairsByRegion { get; set; }

        
        // -------------------------------------------------------------------
        // amiTypeForNativeArchivedSnapshotExport parameter set
        //
        // GraphQL operation: amiTypeForAwsNativeArchivedSnapshotExport(input: AmiTypeForAwsNativeArchivedSnapshotExportInput!):AmiTypeForAwsNativeArchivedSnapshotExportReply!
        //
        [Parameter(
            ParameterSetName = "amiTypeForNativeArchivedSnapshotExport",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: amiTypeForAwsNativeArchivedSnapshotExport(input: AmiTypeForAwsNativeArchivedSnapshotExportInput!):AmiTypeForAwsNativeArchivedSnapshotExportReply!",
            Position = 0
        )]
        public SwitchParameter amiTypeForNativeArchivedSnapshotExport { get; set; }

        [Parameter(
            ParameterSetName = "amiTypeForNativeArchivedSnapshotExport",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument input: AmiTypeForAwsNativeArchivedSnapshotExportInput!"
        )]
        public AmiTypeForAwsNativeArchivedSnapshotExportInput? Input { get; set; }
        
        // -------------------------------------------------------------------
        // ComputeSetting parameter set
        //
        // GraphQL operation: awsComputeSettings(computeSettingId: UUID!):AwsComputeSettings!
        //
        [Parameter(
            ParameterSetName = "ComputeSetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: awsComputeSettings(computeSettingId: UUID!):AwsComputeSettings!",
            Position = 0
        )]
        public SwitchParameter ComputeSetting { get; set; }

        [Parameter(
            ParameterSetName = "ComputeSetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument computeSettingId: UUID!"
        )]
        public System.String? ComputeSettingId { get; set; }
        
        // -------------------------------------------------------------------
        // allComputeSetting parameter set
        //
        // GraphQL operation: allAwsComputeSettings(,   sortBy: AwsCloudComputeSettingQuerySortByField,   sortOrder: SortOrder,   filter: [AwsCloudComputeSettingFilterInput!],   contextFilter: ContextFilterTypeEnum, ):[AwsComputeSettings!]!
        //
        [Parameter(
            ParameterSetName = "allComputeSetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allAwsComputeSettings(,   sortBy: AwsCloudComputeSettingQuerySortByField,   sortOrder: SortOrder,   filter: [AwsCloudComputeSettingFilterInput!],   contextFilter: ContextFilterTypeEnum, ):[AwsComputeSettings!]!",
            Position = 0
        )]
        public SwitchParameter allComputeSetting { get; set; }

        [Parameter(
            ParameterSetName = "allComputeSetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument filter: [AwsCloudComputeSettingFilterInput!]"
        )]
        public List<AwsCloudComputeSettingFilterInput>? Filter { get; set; }
        [Parameter(
            ParameterSetName = "allComputeSetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument contextFilter: ContextFilterTypeEnum"
        )]
        public ContextFilterTypeEnum? ContextFilter { get; set; }
        
        // -------------------------------------------------------------------
        // allCloudAccountsWithFeature parameter set
        //
        // GraphQL operation: allAwsCloudAccountsWithFeatures(awsCloudAccountsArg: AwsCloudAccountsWithFeaturesInput!):[AwsCloudAccountWithFeatures!]!
        //
        [Parameter(
            ParameterSetName = "allCloudAccountsWithFeature",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allAwsCloudAccountsWithFeatures(awsCloudAccountsArg: AwsCloudAccountsWithFeaturesInput!):[AwsCloudAccountWithFeatures!]!",
            Position = 0
        )]
        public SwitchParameter allCloudAccountsWithFeature { get; set; }

        [Parameter(
            ParameterSetName = "allCloudAccountsWithFeature",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument awsCloudAccountsArg: AwsCloudAccountsWithFeaturesInput!"
        )]
        public AwsCloudAccountsWithFeaturesInput? AwsCloudAccountsArg { get; set; }
        
        // -------------------------------------------------------------------
        // CloudAccountWithFeature parameter set
        //
        // GraphQL operation: awsCloudAccountWithFeatures(cloudAccountId: UUID!, awsCloudAccountArg: AwsCloudAccountWithFeaturesInput!):AwsCloudAccountWithFeatures!
        //
        [Parameter(
            ParameterSetName = "CloudAccountWithFeature",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: awsCloudAccountWithFeatures(cloudAccountId: UUID!, awsCloudAccountArg: AwsCloudAccountWithFeaturesInput!):AwsCloudAccountWithFeatures!",
            Position = 0
        )]
        public SwitchParameter CloudAccountWithFeature { get; set; }

        [Parameter(
            ParameterSetName = "CloudAccountWithFeature",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument cloudAccountId: UUID!"
        )]
        public System.String? CloudAccountId { get; set; }
        [Parameter(
            ParameterSetName = "CloudAccountWithFeature",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument awsCloudAccountArg: AwsCloudAccountWithFeaturesInput!"
        )]
        public AwsCloudAccountWithFeaturesInput? AwsCloudAccountArg { get; set; }
        
        // -------------------------------------------------------------------
        // CloudAccountListVpc parameter set
        //
        // GraphQL operation: awsCloudAccountListVpcs(cloudAccountUuid: UUID!, feature: CloudAccountFeature!, region: AwsRegion!):AwsCloudAccountListVpcResponse!
        //
        [Parameter(
            ParameterSetName = "CloudAccountListVpc",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: awsCloudAccountListVpcs(cloudAccountUuid: UUID!, feature: CloudAccountFeature!, region: AwsRegion!):AwsCloudAccountListVpcResponse!",
            Position = 0
        )]
        public SwitchParameter CloudAccountListVpc { get; set; }

        [Parameter(
            ParameterSetName = "CloudAccountListVpc",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument cloudAccountUuid: UUID!"
        )]
        public System.String? CloudAccountUuid { get; set; }
        [Parameter(
            ParameterSetName = "CloudAccountListVpc",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument feature: CloudAccountFeature!"
        )]
        public CloudAccountFeature? Feature { get; set; }
        
        // -------------------------------------------------------------------
        // CloudAccountListSubnet parameter set
        //
        // GraphQL operation: awsCloudAccountListSubnets(,   cloudAccountUuid: UUID!,   feature: CloudAccountFeature!,   region: AwsRegion!,   vpcID: String!, ):AwsCloudAccountListSubnetsResponse!
        //
        [Parameter(
            ParameterSetName = "CloudAccountListSubnet",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: awsCloudAccountListSubnets(,   cloudAccountUuid: UUID!,   feature: CloudAccountFeature!,   region: AwsRegion!,   vpcID: String!, ):AwsCloudAccountListSubnetsResponse!",
            Position = 0
        )]
        public SwitchParameter CloudAccountListSubnet { get; set; }

        [Parameter(
            ParameterSetName = "CloudAccountListSubnet",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument vpcID: String!"
        )]
        public System.String? VpcId { get; set; }
        
        // -------------------------------------------------------------------
        // CloudAccountListSecurityGroup parameter set
        //
        // GraphQL operation: awsCloudAccountListSecurityGroups(,   cloudAccountUuid: UUID!,   feature: CloudAccountFeature!,   region: AwsRegion!,   vpcID: String!, ):AwsCloudAccountListSecurityGroupsResponse!
        //
        [Parameter(
            ParameterSetName = "CloudAccountListSecurityGroup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: awsCloudAccountListSecurityGroups(,   cloudAccountUuid: UUID!,   feature: CloudAccountFeature!,   region: AwsRegion!,   vpcID: String!, ):AwsCloudAccountListSecurityGroupsResponse!",
            Position = 0
        )]
        public SwitchParameter CloudAccountListSecurityGroup { get; set; }

        
        // -------------------------------------------------------------------
        // allExocomputeConfig parameter set
        //
        // GraphQL operation: allAwsExocomputeConfigs(awsNativeAccountIdOrNamePrefix: String!):[AwsExocomputeConfig!]!
        //
        [Parameter(
            ParameterSetName = "allExocomputeConfig",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allAwsExocomputeConfigs(awsNativeAccountIdOrNamePrefix: String!):[AwsExocomputeConfig!]!",
            Position = 0
        )]
        public SwitchParameter allExocomputeConfig { get; set; }

        [Parameter(
            ParameterSetName = "allExocomputeConfig",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument awsNativeAccountIdOrNamePrefix: String!"
        )]
        public System.String? AwsNativeAccountIdOrNamePrefix { get; set; }
        
        // -------------------------------------------------------------------
        // allCloudAccountConfig parameter set
        //
        // GraphQL operation: allAwsCloudAccountConfigs(awsCloudAccountsArg: AwsCloudAccountConfigsInput!):[AwsFeatureConfig!]!
        //
        [Parameter(
            ParameterSetName = "allCloudAccountConfig",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allAwsCloudAccountConfigs(awsCloudAccountsArg: AwsCloudAccountConfigsInput!):[AwsFeatureConfig!]!",
            Position = 0
        )]
        public SwitchParameter allCloudAccountConfig { get; set; }

        
        // -------------------------------------------------------------------
        // allRegion parameter set
        //
        // GraphQL operation: allAwsRegions(cloudAccountId: String!):[AwsCloudAccountRegion!]!
        //
        [Parameter(
            ParameterSetName = "allRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allAwsRegions(cloudAccountId: String!):[AwsCloudAccountRegion!]!",
            Position = 0
        )]
        public SwitchParameter allRegion { get; set; }

        
        // -------------------------------------------------------------------
        // allCdmVersion parameter set
        //
        // GraphQL operation: allAwsCdmVersions(input: AwsCdmVersionRequest!):[AwsCdmVersion!]!
        //
        [Parameter(
            ParameterSetName = "allCdmVersion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allAwsCdmVersions(input: AwsCdmVersionRequest!):[AwsCdmVersion!]!",
            Position = 0
        )]
        public SwitchParameter allCdmVersion { get; set; }

        
        // -------------------------------------------------------------------
        // allInstanceProfileName parameter set
        //
        // GraphQL operation: allAwsInstanceProfileNames(cloudAccountId: String!, region: String!):[String!]!
        //
        [Parameter(
            ParameterSetName = "allInstanceProfileName",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allAwsInstanceProfileNames(cloudAccountId: String!, region: String!):[String!]!",
            Position = 0
        )]
        public SwitchParameter allInstanceProfileName { get; set; }


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
                    case "allVpcsByRegion":
                        this.ProcessRecord_allVpcsByRegion();
                        break;
                    case "allVpc":
                        this.ProcessRecord_allVpc();
                        break;
                    case "isNativeEbsVolumeSnapshotRestorable":
                        this.ProcessRecord_isNativeEbsVolumeSnapshotRestorable();
                        break;
                    case "allAvailabilityZonesByRegion":
                        this.ProcessRecord_allAvailabilityZonesByRegion();
                        break;
                    case "allKmsEncryptionKeysByRegion":
                        this.ProcessRecord_allKmsEncryptionKeysByRegion();
                        break;
                    case "isS3BucketNameAvailable":
                        this.ProcessRecord_isS3BucketNameAvailable();
                        break;
                    case "allS3Bucket":
                        this.ProcessRecord_allS3Bucket();
                        break;
                    case "NativeRdsInstance":
                        this.ProcessRecord_NativeRdsInstance();
                        break;
                    case "NativeRdsPointInTimeRestoreWindow":
                        this.ProcessRecord_NativeRdsPointInTimeRestoreWindow();
                        break;
                    case "rdsInstanceDetail":
                        this.ProcessRecord_rdsInstanceDetail();
                        break;
                    case "isNativeRdsInstanceLaunchConfigurationValid":
                        this.ProcessRecord_isNativeRdsInstanceLaunchConfigurationValid();
                        break;
                    case "allOptionGroupsByRegion":
                        this.ProcessRecord_allOptionGroupsByRegion();
                        break;
                    case "allDbParameterGroupsByRegion":
                        this.ProcessRecord_allDbParameterGroupsByRegion();
                        break;
                    case "allDbSubnetGroupsByRegion":
                        this.ProcessRecord_allDbSubnetGroupsByRegion();
                        break;
                    case "validateNativeRdsInstanceNameForExport":
                        this.ProcessRecord_validateNativeRdsInstanceNameForExport();
                        break;
                    case "validateNativeRdsClusterNameForExport":
                        this.ProcessRecord_validateNativeRdsClusterNameForExport();
                        break;
                    case "NativeRdsExportDefault":
                        this.ProcessRecord_NativeRdsExportDefault();
                        break;
                    case "allEc2KeyPairsByRegion":
                        this.ProcessRecord_allEc2KeyPairsByRegion();
                        break;
                    case "amiTypeForNativeArchivedSnapshotExport":
                        this.ProcessRecord_amiTypeForNativeArchivedSnapshotExport();
                        break;
                    case "ComputeSetting":
                        this.ProcessRecord_ComputeSetting();
                        break;
                    case "allComputeSetting":
                        this.ProcessRecord_allComputeSetting();
                        break;
                    case "allCloudAccountsWithFeature":
                        this.ProcessRecord_allCloudAccountsWithFeature();
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
                    case "allExocomputeConfig":
                        this.ProcessRecord_allExocomputeConfig();
                        break;
                    case "allCloudAccountConfig":
                        this.ProcessRecord_allCloudAccountConfig();
                        break;
                    case "allRegion":
                        this.ProcessRecord_allRegion();
                        break;
                    case "allCdmVersion":
                        this.ProcessRecord_allCdmVersion();
                        break;
                    case "allInstanceProfileName":
                        this.ProcessRecord_allInstanceProfileName();
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
                    "Invoke-RscQueryAws",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(error);
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
        protected void ProcessRecord_allVpcsByRegion()
        {
            this._logger.name += " -allVpcsByRegion";
            // Invoke graphql operation allVpcsByRegionFromAws
            InvokeQueryAllVpcsByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allVpcsFromAws.
        protected void ProcessRecord_allVpc()
        {
            this._logger.name += " -allVpc";
            // Invoke graphql operation allVpcsFromAws
            InvokeQueryAllVpcsFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // isAwsNativeEbsVolumeSnapshotRestorable.
        protected void ProcessRecord_isNativeEbsVolumeSnapshotRestorable()
        {
            this._logger.name += " -isNativeEbsVolumeSnapshotRestorable";
            // Invoke graphql operation isAwsNativeEbsVolumeSnapshotRestorable
            InvokeQueryIsAwsNativeEbsVolumeSnapshotRestorable();
        }

        // This parameter set invokes a single graphql operation:
        // allAvailabilityZonesByRegionFromAws.
        protected void ProcessRecord_allAvailabilityZonesByRegion()
        {
            this._logger.name += " -allAvailabilityZonesByRegion";
            // Invoke graphql operation allAvailabilityZonesByRegionFromAws
            InvokeQueryAllAvailabilityZonesByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allKmsEncryptionKeysByRegionFromAws.
        protected void ProcessRecord_allKmsEncryptionKeysByRegion()
        {
            this._logger.name += " -allKmsEncryptionKeysByRegion";
            // Invoke graphql operation allKmsEncryptionKeysByRegionFromAws
            InvokeQueryAllKmsEncryptionKeysByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // isAwsS3BucketNameAvailable.
        protected void ProcessRecord_isS3BucketNameAvailable()
        {
            this._logger.name += " -isS3BucketNameAvailable";
            // Invoke graphql operation isAwsS3BucketNameAvailable
            InvokeQueryIsAwsS3BucketNameAvailable();
        }

        // This parameter set invokes a single graphql operation:
        // allS3BucketsFromAws.
        protected void ProcessRecord_allS3Bucket()
        {
            this._logger.name += " -allS3Bucket";
            // Invoke graphql operation allS3BucketsFromAws
            InvokeQueryAllS3BucketsFromAws();
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
        protected void ProcessRecord_rdsInstanceDetail()
        {
            this._logger.name += " -rdsInstanceDetail";
            // Invoke graphql operation rdsInstanceDetailsFromAws
            InvokeQueryRdsInstanceDetailsFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // isAwsNativeRdsInstanceLaunchConfigurationValid.
        protected void ProcessRecord_isNativeRdsInstanceLaunchConfigurationValid()
        {
            this._logger.name += " -isNativeRdsInstanceLaunchConfigurationValid";
            // Invoke graphql operation isAwsNativeRdsInstanceLaunchConfigurationValid
            InvokeQueryIsAwsNativeRdsInstanceLaunchConfigurationValid();
        }

        // This parameter set invokes a single graphql operation:
        // allOptionGroupsByRegionFromAws.
        protected void ProcessRecord_allOptionGroupsByRegion()
        {
            this._logger.name += " -allOptionGroupsByRegion";
            // Invoke graphql operation allOptionGroupsByRegionFromAws
            InvokeQueryAllOptionGroupsByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allDbParameterGroupsByRegionFromAws.
        protected void ProcessRecord_allDbParameterGroupsByRegion()
        {
            this._logger.name += " -allDbParameterGroupsByRegion";
            // Invoke graphql operation allDbParameterGroupsByRegionFromAws
            InvokeQueryAllDbParameterGroupsByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allDbSubnetGroupsByRegionFromAws.
        protected void ProcessRecord_allDbSubnetGroupsByRegion()
        {
            this._logger.name += " -allDbSubnetGroupsByRegion";
            // Invoke graphql operation allDbSubnetGroupsByRegionFromAws
            InvokeQueryAllDbSubnetGroupsByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // validateAwsNativeRdsInstanceNameForExport.
        protected void ProcessRecord_validateNativeRdsInstanceNameForExport()
        {
            this._logger.name += " -validateNativeRdsInstanceNameForExport";
            // Invoke graphql operation validateAwsNativeRdsInstanceNameForExport
            InvokeQueryValidateAwsNativeRdsInstanceNameForExport();
        }

        // This parameter set invokes a single graphql operation:
        // validateAwsNativeRdsClusterNameForExport.
        protected void ProcessRecord_validateNativeRdsClusterNameForExport()
        {
            this._logger.name += " -validateNativeRdsClusterNameForExport";
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
        protected void ProcessRecord_allEc2KeyPairsByRegion()
        {
            this._logger.name += " -allEc2KeyPairsByRegion";
            // Invoke graphql operation allEc2KeyPairsByRegionFromAws
            InvokeQueryAllEc2KeyPairsByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // amiTypeForAwsNativeArchivedSnapshotExport.
        protected void ProcessRecord_amiTypeForNativeArchivedSnapshotExport()
        {
            this._logger.name += " -amiTypeForNativeArchivedSnapshotExport";
            // Invoke graphql operation amiTypeForAwsNativeArchivedSnapshotExport
            InvokeQueryAmiTypeForAwsNativeArchivedSnapshotExport();
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
        protected void ProcessRecord_allComputeSetting()
        {
            this._logger.name += " -allComputeSetting";
            // Invoke graphql operation allAwsComputeSettings
            InvokeQueryAllAwsComputeSettings();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsCloudAccountsWithFeatures.
        protected void ProcessRecord_allCloudAccountsWithFeature()
        {
            this._logger.name += " -allCloudAccountsWithFeature";
            // Invoke graphql operation allAwsCloudAccountsWithFeatures
            InvokeQueryAllAwsCloudAccountsWithFeatures();
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
        // allAwsExocomputeConfigs.
        protected void ProcessRecord_allExocomputeConfig()
        {
            this._logger.name += " -allExocomputeConfig";
            // Invoke graphql operation allAwsExocomputeConfigs
            InvokeQueryAllAwsExocomputeConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsCloudAccountConfigs.
        protected void ProcessRecord_allCloudAccountConfig()
        {
            this._logger.name += " -allCloudAccountConfig";
            // Invoke graphql operation allAwsCloudAccountConfigs
            InvokeQueryAllAwsCloudAccountConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsRegions.
        protected void ProcessRecord_allRegion()
        {
            this._logger.name += " -allRegion";
            // Invoke graphql operation allAwsRegions
            InvokeQueryAllAwsRegions();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsCdmVersions.
        protected void ProcessRecord_allCdmVersion()
        {
            this._logger.name += " -allCdmVersion";
            // Invoke graphql operation allAwsCdmVersions
            InvokeQueryAllAwsCdmVersions();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsInstanceProfileNames.
        protected void ProcessRecord_allInstanceProfileName()
        {
            this._logger.name += " -allInstanceProfileName";
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AwsNativeRoot)psObject.BaseObject;
                } else {
                    fields = (AwsNativeRoot)this.Field;
                }
            }
            string document = Query.AwsNativeRoot(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AwsNativeRoot");
            string parameters = "";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAwsNativeRoot" + parameters + "{" + document + "}",
                OperationName = "QueryAwsNativeRoot",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            Task<AwsNativeRoot> task = this._rbkClient.InvokeGenericCallAsync<AwsNativeRoot>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AwsNativeAccount)psObject.BaseObject;
                } else {
                    fields = (AwsNativeAccount)this.Field;
                }
            }
            string document = Query.AwsNativeAccount(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AwsNativeAccount");
            string parameters = "($awsNativeAccountRubrikId: UUID!,$awsNativeProtectionFeature: AwsNativeProtectionFeature!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAwsNativeAccount" + parameters + "{" + document + "}",
                OperationName = "QueryAwsNativeAccount",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AwsNativeAccount> task = this._rbkClient.InvokeGenericCallAsync<AwsNativeAccount>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AwsNativeEc2Instance)psObject.BaseObject;
                } else {
                    fields = (AwsNativeEc2Instance)this.Field;
                }
            }
            string document = Query.AwsNativeEc2Instance(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AwsNativeEc2Instance");
            string parameters = "($ec2InstanceRubrikId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAwsNativeEc2Instance" + parameters + "{" + document + "}",
                OperationName = "QueryAwsNativeEc2Instance",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AwsNativeEc2Instance> task = this._rbkClient.InvokeGenericCallAsync<AwsNativeEc2Instance>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AwsNativeEbsVolume)psObject.BaseObject;
                } else {
                    fields = (AwsNativeEbsVolume)this.Field;
                }
            }
            string document = Query.AwsNativeEbsVolume(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AwsNativeEbsVolume");
            string parameters = "($ebsVolumeRubrikId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAwsNativeEbsVolume" + parameters + "{" + document + "}",
                OperationName = "QueryAwsNativeEbsVolume",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AwsNativeEbsVolume> task = this._rbkClient.InvokeGenericCallAsync<AwsNativeEbsVolume>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AwsNativeS3Bucket)psObject.BaseObject;
                } else {
                    fields = (AwsNativeS3Bucket)this.Field;
                }
            }
            string document = Query.AwsNativeS3Bucket(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AwsNativeS3Bucket");
            string parameters = "($s3BucketRubrikId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAwsNativeS3Bucket" + parameters + "{" + document + "}",
                OperationName = "QueryAwsNativeS3Bucket",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AwsNativeS3Bucket> task = this._rbkClient.InvokeGenericCallAsync<AwsNativeS3Bucket>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AwsNativeEc2InstanceConnection)psObject.BaseObject;
                } else {
                    fields = (AwsNativeEc2InstanceConnection)this.Field;
                }
            }
            string document = Query.AwsNativeEc2InstancesByName(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AwsNativeEc2InstancesByName");
            string parameters = "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AwsNativeEc2InstanceSortFields,$sortOrder: SortOrder,$ec2InstanceName: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAwsNativeEc2InstancesByName" + parameters + "{" + document + "}",
                OperationName = "QueryAwsNativeEc2InstancesByName",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AwsNativeEc2InstanceConnection> task = this._rbkClient.InvokeGenericCallAsync<AwsNativeEc2InstanceConnection>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AwsNativeEbsVolumeConnection)psObject.BaseObject;
                } else {
                    fields = (AwsNativeEbsVolumeConnection)this.Field;
                }
            }
            string document = Query.AwsNativeEbsVolumesByName(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AwsNativeEbsVolumesByName");
            string parameters = "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AwsNativeEbsVolumeSortFields,$sortOrder: SortOrder,$ebsVolumeName: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAwsNativeEbsVolumesByName" + parameters + "{" + document + "}",
                OperationName = "QueryAwsNativeEbsVolumesByName",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AwsNativeEbsVolumeConnection> task = this._rbkClient.InvokeGenericCallAsync<AwsNativeEbsVolumeConnection>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<AwsVpc>)psObject.BaseObject;
                } else {
                    fields = (List<AwsVpc>)this.Field;
                }
            }
            string document = Query.AllVpcsByRegionFromAws(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllVpcsByRegionFromAws");
            string parameters = "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllVpcsByRegionFromAws" + parameters + "{" + document + "}",
                OperationName = "QueryAllVpcsByRegionFromAws",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<AwsVpc>> task = this._rbkClient.InvokeGenericCallAsync<List<AwsVpc>>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<AwsVpc>)psObject.BaseObject;
                } else {
                    fields = (List<AwsVpc>)this.Field;
                }
            }
            string document = Query.AllVpcsFromAws(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllVpcsFromAws");
            string parameters = "($awsAccountRubrikId: UUID)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllVpcsFromAws" + parameters + "{" + document + "}",
                OperationName = "QueryAllVpcsFromAws",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<AwsVpc>> task = this._rbkClient.InvokeGenericCallAsync<List<AwsVpc>>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (IsVolumeSnapshotRestorableReply)psObject.BaseObject;
                } else {
                    fields = (IsVolumeSnapshotRestorableReply)this.Field;
                }
            }
            string document = Query.IsAwsNativeEbsVolumeSnapshotRestorable(ref fields);
            this._input.Initialize(argDefs, fields, "Query.IsAwsNativeEbsVolumeSnapshotRestorable");
            string parameters = "($snapshotId: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryIsAwsNativeEbsVolumeSnapshotRestorable" + parameters + "{" + document + "}",
                OperationName = "QueryIsAwsNativeEbsVolumeSnapshotRestorable",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<IsVolumeSnapshotRestorableReply> task = this._rbkClient.InvokeGenericCallAsync<IsVolumeSnapshotRestorableReply>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<System.String>)psObject.BaseObject;
                } else {
                    fields = (List<System.String>)this.Field;
                }
            }
            string document = Query.AllAvailabilityZonesByRegionFromAws(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAvailabilityZonesByRegionFromAws");
            string parameters = "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAvailabilityZonesByRegionFromAws" + parameters + "{" + document + "}",
                OperationName = "QueryAllAvailabilityZonesByRegionFromAws",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<System.String>> task = this._rbkClient.InvokeGenericCallAsync<List<System.String>>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<KmsEncryptionKey>)psObject.BaseObject;
                } else {
                    fields = (List<KmsEncryptionKey>)this.Field;
                }
            }
            string document = Query.AllKmsEncryptionKeysByRegionFromAws(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllKmsEncryptionKeysByRegionFromAws");
            string parameters = "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllKmsEncryptionKeysByRegionFromAws" + parameters + "{" + document + "}",
                OperationName = "QueryAllKmsEncryptionKeysByRegionFromAws",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<KmsEncryptionKey>> task = this._rbkClient.InvokeGenericCallAsync<List<KmsEncryptionKey>>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (System.Boolean)psObject.BaseObject;
                } else {
                    fields = (System.Boolean)this.Field;
                }
            }
            string document = Query.IsAwsS3BucketNameAvailable(ref fields);
            this._input.Initialize(argDefs, fields, "Query.IsAwsS3BucketNameAvailable");
            string parameters = "($bucketName: String!,$awsAccountRubrikId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryIsAwsS3BucketNameAvailable" + parameters + "{" + document + "}",
                OperationName = "QueryIsAwsS3BucketNameAvailable",
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<System.String>)psObject.BaseObject;
                } else {
                    fields = (List<System.String>)this.Field;
                }
            }
            string document = Query.AllS3BucketsFromAws(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllS3BucketsFromAws");
            string parameters = "($awsAccountRubrikId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllS3BucketsFromAws" + parameters + "{" + document + "}",
                OperationName = "QueryAllS3BucketsFromAws",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<System.String>> task = this._rbkClient.InvokeGenericCallAsync<List<System.String>>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AwsNativeRdsInstance)psObject.BaseObject;
                } else {
                    fields = (AwsNativeRdsInstance)this.Field;
                }
            }
            string document = Query.AwsNativeRdsInstance(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AwsNativeRdsInstance");
            string parameters = "($rdsInstanceRubrikId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAwsNativeRdsInstance" + parameters + "{" + document + "}",
                OperationName = "QueryAwsNativeRdsInstance",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AwsNativeRdsInstance> task = this._rbkClient.InvokeGenericCallAsync<AwsNativeRdsInstance>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // awsNativeRdsPointInTimeRestoreWindow(awsAccountRubrikId: UUID!, region: AwsNativeRegion!, rdsInstanceName: String!): AwsNativeRdsPointInTimeRestoreWindow!
        protected void InvokeQueryAwsNativeRdsPointInTimeRestoreWindow()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("rdsInstanceName", "String!"),
            };
            AwsNativeRdsPointInTimeRestoreWindow? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AwsNativeRdsPointInTimeRestoreWindow)psObject.BaseObject;
                } else {
                    fields = (AwsNativeRdsPointInTimeRestoreWindow)this.Field;
                }
            }
            string document = Query.AwsNativeRdsPointInTimeRestoreWindow(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AwsNativeRdsPointInTimeRestoreWindow");
            string parameters = "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$rdsInstanceName: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAwsNativeRdsPointInTimeRestoreWindow" + parameters + "{" + document + "}",
                OperationName = "QueryAwsNativeRdsPointInTimeRestoreWindow",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AwsNativeRdsPointInTimeRestoreWindow> task = this._rbkClient.InvokeGenericCallAsync<AwsNativeRdsPointInTimeRestoreWindow>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // rdsInstanceDetailsFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion!, rdsInstanceName: String!): RdsInstanceDetailsFromAws!
        protected void InvokeQueryRdsInstanceDetailsFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("rdsInstanceName", "String!"),
            };
            RdsInstanceDetailsFromAws? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (RdsInstanceDetailsFromAws)psObject.BaseObject;
                } else {
                    fields = (RdsInstanceDetailsFromAws)this.Field;
                }
            }
            string document = Query.RdsInstanceDetailsFromAws(ref fields);
            this._input.Initialize(argDefs, fields, "Query.RdsInstanceDetailsFromAws");
            string parameters = "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$rdsInstanceName: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryRdsInstanceDetailsFromAws" + parameters + "{" + document + "}",
                OperationName = "QueryRdsInstanceDetailsFromAws",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<RdsInstanceDetailsFromAws> task = this._rbkClient.InvokeGenericCallAsync<RdsInstanceDetailsFromAws>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (System.Boolean)psObject.BaseObject;
                } else {
                    fields = (System.Boolean)this.Field;
                }
            }
            string document = Query.IsAwsNativeRdsInstanceLaunchConfigurationValid(ref fields);
            this._input.Initialize(argDefs, fields, "Query.IsAwsNativeRdsInstanceLaunchConfigurationValid");
            string parameters = "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$dbEngine: AwsNativeRdsDbEngine!,$dbEngineVersion: String!,$dbClass: AwsNativeRdsDbInstanceClass!,$primaryAz: String,$storageType: AwsNativeRdsStorageType,$isMultiAz: Boolean!,$kmsKeyId: String,$iops: Int)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryIsAwsNativeRdsInstanceLaunchConfigurationValid" + parameters + "{" + document + "}",
                OperationName = "QueryIsAwsNativeRdsInstanceLaunchConfigurationValid",
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<OptionGroup>)psObject.BaseObject;
                } else {
                    fields = (List<OptionGroup>)this.Field;
                }
            }
            string document = Query.AllOptionGroupsByRegionFromAws(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllOptionGroupsByRegionFromAws");
            string parameters = "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$dbEngine: AwsNativeRdsDbEngine!,$dbEngineVersion: String!,$majorEngineVersion: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllOptionGroupsByRegionFromAws" + parameters + "{" + document + "}",
                OperationName = "QueryAllOptionGroupsByRegionFromAws",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<OptionGroup>> task = this._rbkClient.InvokeGenericCallAsync<List<OptionGroup>>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<DbParameterGroup>)psObject.BaseObject;
                } else {
                    fields = (List<DbParameterGroup>)this.Field;
                }
            }
            string document = Query.AllDbParameterGroupsByRegionFromAws(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllDbParameterGroupsByRegionFromAws");
            string parameters = "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$dbEngine: AwsNativeRdsDbEngine!,$dbEngineVersion: String!,$rdsType: AwsNativeRdsType)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllDbParameterGroupsByRegionFromAws" + parameters + "{" + document + "}",
                OperationName = "QueryAllDbParameterGroupsByRegionFromAws",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<DbParameterGroup>> task = this._rbkClient.InvokeGenericCallAsync<List<DbParameterGroup>>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<SubnetGroup>)psObject.BaseObject;
                } else {
                    fields = (List<SubnetGroup>)this.Field;
                }
            }
            string document = Query.AllDbSubnetGroupsByRegionFromAws(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllDbSubnetGroupsByRegionFromAws");
            string parameters = "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllDbSubnetGroupsByRegionFromAws" + parameters + "{" + document + "}",
                OperationName = "QueryAllDbSubnetGroupsByRegionFromAws",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<SubnetGroup>> task = this._rbkClient.InvokeGenericCallAsync<List<SubnetGroup>>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (ValidateAwsNativeRdsInstanceNameForExportReply)psObject.BaseObject;
                } else {
                    fields = (ValidateAwsNativeRdsInstanceNameForExportReply)this.Field;
                }
            }
            string document = Query.ValidateAwsNativeRdsInstanceNameForExport(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ValidateAwsNativeRdsInstanceNameForExport");
            string parameters = "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$rdsInstanceName: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryValidateAwsNativeRdsInstanceNameForExport" + parameters + "{" + document + "}",
                OperationName = "QueryValidateAwsNativeRdsInstanceNameForExport",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<ValidateAwsNativeRdsInstanceNameForExportReply> task = this._rbkClient.InvokeGenericCallAsync<ValidateAwsNativeRdsInstanceNameForExportReply>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (ValidateAwsNativeRdsClusterNameForExportReply)psObject.BaseObject;
                } else {
                    fields = (ValidateAwsNativeRdsClusterNameForExportReply)this.Field;
                }
            }
            string document = Query.ValidateAwsNativeRdsClusterNameForExport(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ValidateAwsNativeRdsClusterNameForExport");
            string parameters = "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$rdsClusterName: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryValidateAwsNativeRdsClusterNameForExport" + parameters + "{" + document + "}",
                OperationName = "QueryValidateAwsNativeRdsClusterNameForExport",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<ValidateAwsNativeRdsClusterNameForExportReply> task = this._rbkClient.InvokeGenericCallAsync<ValidateAwsNativeRdsClusterNameForExportReply>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (RdsInstanceExportDefaults)psObject.BaseObject;
                } else {
                    fields = (RdsInstanceExportDefaults)this.Field;
                }
            }
            string document = Query.AwsNativeRdsExportDefaults(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AwsNativeRdsExportDefaults");
            string parameters = "($rdsInstanceRubrikId: UUID!,$snapshotId: String,$isPointInTime: Boolean!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAwsNativeRdsExportDefaults" + parameters + "{" + document + "}",
                OperationName = "QueryAwsNativeRdsExportDefaults",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<RdsInstanceExportDefaults> task = this._rbkClient.InvokeGenericCallAsync<RdsInstanceExportDefaults>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<System.String>)psObject.BaseObject;
                } else {
                    fields = (List<System.String>)this.Field;
                }
            }
            string document = Query.AllEc2KeyPairsByRegionFromAws(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllEc2KeyPairsByRegionFromAws");
            string parameters = "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllEc2KeyPairsByRegionFromAws" + parameters + "{" + document + "}",
                OperationName = "QueryAllEc2KeyPairsByRegionFromAws",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<System.String>> task = this._rbkClient.InvokeGenericCallAsync<List<System.String>>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AmiTypeForAwsNativeArchivedSnapshotExportReply)psObject.BaseObject;
                } else {
                    fields = (AmiTypeForAwsNativeArchivedSnapshotExportReply)this.Field;
                }
            }
            string document = Query.AmiTypeForAwsNativeArchivedSnapshotExport(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AmiTypeForAwsNativeArchivedSnapshotExport");
            string parameters = "($input: AmiTypeForAwsNativeArchivedSnapshotExportInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAmiTypeForAwsNativeArchivedSnapshotExport" + parameters + "{" + document + "}",
                OperationName = "QueryAmiTypeForAwsNativeArchivedSnapshotExport",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AmiTypeForAwsNativeArchivedSnapshotExportReply> task = this._rbkClient.InvokeGenericCallAsync<AmiTypeForAwsNativeArchivedSnapshotExportReply>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AwsComputeSettings)psObject.BaseObject;
                } else {
                    fields = (AwsComputeSettings)this.Field;
                }
            }
            string document = Query.AwsComputeSettings(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AwsComputeSettings");
            string parameters = "($computeSettingId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAwsComputeSettings" + parameters + "{" + document + "}",
                OperationName = "QueryAwsComputeSettings",
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<AwsComputeSettings>)psObject.BaseObject;
                } else {
                    fields = (List<AwsComputeSettings>)this.Field;
                }
            }
            string document = Query.AllAwsComputeSettings(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAwsComputeSettings");
            string parameters = "($sortBy: AwsCloudComputeSettingQuerySortByField,$sortOrder: SortOrder,$filter: [AwsCloudComputeSettingFilterInput!],$contextFilter: ContextFilterTypeEnum)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAwsComputeSettings" + parameters + "{" + document + "}",
                OperationName = "QueryAllAwsComputeSettings",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<AwsComputeSettings>> task = this._rbkClient.InvokeGenericCallAsync<List<AwsComputeSettings>>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<AwsCloudAccountWithFeatures>)psObject.BaseObject;
                } else {
                    fields = (List<AwsCloudAccountWithFeatures>)this.Field;
                }
            }
            string document = Query.AllAwsCloudAccountsWithFeatures(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAwsCloudAccountsWithFeatures");
            string parameters = "($awsCloudAccountsArg: AwsCloudAccountsWithFeaturesInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAwsCloudAccountsWithFeatures" + parameters + "{" + document + "}",
                OperationName = "QueryAllAwsCloudAccountsWithFeatures",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<AwsCloudAccountWithFeatures>> task = this._rbkClient.InvokeGenericCallAsync<List<AwsCloudAccountWithFeatures>>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AwsCloudAccountWithFeatures)psObject.BaseObject;
                } else {
                    fields = (AwsCloudAccountWithFeatures)this.Field;
                }
            }
            string document = Query.AwsCloudAccountWithFeatures(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AwsCloudAccountWithFeatures");
            string parameters = "($cloudAccountId: UUID!,$awsCloudAccountArg: AwsCloudAccountWithFeaturesInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAwsCloudAccountWithFeatures" + parameters + "{" + document + "}",
                OperationName = "QueryAwsCloudAccountWithFeatures",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AwsCloudAccountWithFeatures> task = this._rbkClient.InvokeGenericCallAsync<AwsCloudAccountWithFeatures>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AwsCloudAccountListVpcResponse)psObject.BaseObject;
                } else {
                    fields = (AwsCloudAccountListVpcResponse)this.Field;
                }
            }
            string document = Query.AwsCloudAccountListVpcs(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AwsCloudAccountListVpcs");
            string parameters = "($cloudAccountUuid: UUID!,$feature: CloudAccountFeature!,$region: AwsRegion!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAwsCloudAccountListVpcs" + parameters + "{" + document + "}",
                OperationName = "QueryAwsCloudAccountListVpcs",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AwsCloudAccountListVpcResponse> task = this._rbkClient.InvokeGenericCallAsync<AwsCloudAccountListVpcResponse>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AwsCloudAccountListSubnetsResponse)psObject.BaseObject;
                } else {
                    fields = (AwsCloudAccountListSubnetsResponse)this.Field;
                }
            }
            string document = Query.AwsCloudAccountListSubnets(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AwsCloudAccountListSubnets");
            string parameters = "($cloudAccountUuid: UUID!,$feature: CloudAccountFeature!,$region: AwsRegion!,$vpcID: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAwsCloudAccountListSubnets" + parameters + "{" + document + "}",
                OperationName = "QueryAwsCloudAccountListSubnets",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AwsCloudAccountListSubnetsResponse> task = this._rbkClient.InvokeGenericCallAsync<AwsCloudAccountListSubnetsResponse>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AwsCloudAccountListSecurityGroupsResponse)psObject.BaseObject;
                } else {
                    fields = (AwsCloudAccountListSecurityGroupsResponse)this.Field;
                }
            }
            string document = Query.AwsCloudAccountListSecurityGroups(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AwsCloudAccountListSecurityGroups");
            string parameters = "($cloudAccountUuid: UUID!,$feature: CloudAccountFeature!,$region: AwsRegion!,$vpcID: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAwsCloudAccountListSecurityGroups" + parameters + "{" + document + "}",
                OperationName = "QueryAwsCloudAccountListSecurityGroups",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AwsCloudAccountListSecurityGroupsResponse> task = this._rbkClient.InvokeGenericCallAsync<AwsCloudAccountListSecurityGroupsResponse>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<AwsExocomputeConfig>)psObject.BaseObject;
                } else {
                    fields = (List<AwsExocomputeConfig>)this.Field;
                }
            }
            string document = Query.AllAwsExocomputeConfigs(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAwsExocomputeConfigs");
            string parameters = "($awsNativeAccountIdOrNamePrefix: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAwsExocomputeConfigs" + parameters + "{" + document + "}",
                OperationName = "QueryAllAwsExocomputeConfigs",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<AwsExocomputeConfig>> task = this._rbkClient.InvokeGenericCallAsync<List<AwsExocomputeConfig>>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<AwsFeatureConfig>)psObject.BaseObject;
                } else {
                    fields = (List<AwsFeatureConfig>)this.Field;
                }
            }
            string document = Query.AllAwsCloudAccountConfigs(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAwsCloudAccountConfigs");
            string parameters = "($awsCloudAccountsArg: AwsCloudAccountConfigsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAwsCloudAccountConfigs" + parameters + "{" + document + "}",
                OperationName = "QueryAllAwsCloudAccountConfigs",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<AwsFeatureConfig>> task = this._rbkClient.InvokeGenericCallAsync<List<AwsFeatureConfig>>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<AwsCloudAccountRegion>)psObject.BaseObject;
                } else {
                    fields = (List<AwsCloudAccountRegion>)this.Field;
                }
            }
            string document = Query.AllAwsRegions(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAwsRegions");
            string parameters = "($cloudAccountId: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAwsRegions" + parameters + "{" + document + "}",
                OperationName = "QueryAllAwsRegions",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<AwsCloudAccountRegion>> task = this._rbkClient.InvokeGenericCallAsync<List<AwsCloudAccountRegion>>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<AwsCdmVersion>)psObject.BaseObject;
                } else {
                    fields = (List<AwsCdmVersion>)this.Field;
                }
            }
            string document = Query.AllAwsCdmVersions(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAwsCdmVersions");
            string parameters = "($input: AwsCdmVersionRequest!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAwsCdmVersions" + parameters + "{" + document + "}",
                OperationName = "QueryAllAwsCdmVersions",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<AwsCdmVersion>> task = this._rbkClient.InvokeGenericCallAsync<List<AwsCdmVersion>>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<System.String>)psObject.BaseObject;
                } else {
                    fields = (List<System.String>)this.Field;
                }
            }
            string document = Query.AllAwsInstanceProfileNames(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAwsInstanceProfileNames");
            string parameters = "($cloudAccountId: String!,$region: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAwsInstanceProfileNames" + parameters + "{" + document + "}",
                OperationName = "QueryAllAwsInstanceProfileNames",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<System.String>> task = this._rbkClient.InvokeGenericCallAsync<List<System.String>>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }


    } // class Invoke_RscQueryAws
}