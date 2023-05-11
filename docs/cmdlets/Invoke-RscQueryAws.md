# Invoke-RscQueryAws
## Subcommands
### CloudAccountListKMSKey
- The Input parameter takes a hashtable with 3 name and value pairs.
    - cloudAccountUuid - System.String: The ID of the cloud account.
    - feature - CloudAccountFeature: A cloud account feature of Rubrik Security Cloud.
    - region - AwsRegion: AWS region argument for archival use case.
- Returns AwsCloudAccountListKMSKeysResponse.
### CloudAccountListSecurityGroup
Retrieves a list of security groups in the specified cloud account and virtual private cloud (VPC).

- The Input parameter takes a hashtable with 4 name and value pairs.
    - cloudAccountUuid - System.String: The ID of the cloud account.
    - feature - CloudAccountFeature: A cloud account feature of Rubrik Security Cloud.
    - region - AwsRegion: AWS region argument for archival use case.
    - vpcID - System.String: VPC native ID.
- Returns AwsCloudAccountListSecurityGroupsResponse.
### CloudAccountListSubnet
Retrieves a list of subnets in the specified cloud account and virtual private cloud (VPC).

- The Input parameter takes a hashtable with 4 name and value pairs.
    - cloudAccountUuid - System.String: The ID of the cloud account.
    - feature - CloudAccountFeature: A cloud account feature of Rubrik Security Cloud.
    - region - AwsRegion: AWS region argument for archival use case.
    - vpcID - System.String: VPC native ID.
- Returns AwsCloudAccountListSubnetsResponse.
### CloudAccountListVpc
Retrieves a list of virtual private clouds (VPCs) in the specific cloud account.

- The Input parameter takes a hashtable with 3 name and value pairs.
    - cloudAccountUuid - System.String: The ID of the cloud account.
    - feature - CloudAccountFeature: A cloud account feature of Rubrik Security Cloud.
    - region - AwsRegion: AWS region argument for archival use case.
- Returns AwsCloudAccountListVpcResponse.
### CloudAccountWithFeature
List of AWS cloud accounts and the features for each account, classified by ID.

- The Input parameter takes a hashtable with 2 name and value pairs.
    - awsCloudAccountArg - AwsCloudAccountWithFeaturesInput: Arguments for get cloud account.
    - cloudAccountId - System.String: The Rubrik ID of the cloud account.
- Returns AwsCloudAccountWithFeatures.
### ComputeSetting
Retrieve aws compute settings.

- The Input parameter takes a single value of type System.String.
- Returns AwsComputeSettings.
### NativeAccount
Refers to the AWS Native account that serves as a container for all your AWS resources. The AWS Native account contains information about the metadata related to the AWS Native resources.

- The Input parameter takes a hashtable with 2 name and value pairs.
    - awsNativeAccountRubrikId - System.String: The Rubrik ID for the AWS Native account.
    - awsNativeProtectionFeature - AwsNativeProtectionFeature: Cloud native protection feature.
- Returns AwsNativeAccount.
### NativeEbsVolume
Refers to the Amazon Elastic Block Store (EBS) Volume represented by a specific ID. For more information, see https://aws.amazon.com/ebs/.

- The Input parameter takes a single value of type System.String.
- Returns AwsNativeEbsVolume.
### NativeEbsVolumesByName
Paginated list of all AWS EBS Volumes by name or substring of name.

- The Input parameter takes a hashtable with 7 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - ebsVolumeName - System.String: The native name for the AWS EBS Volume object.
    - first - System.Int32: Returns the first n elements from the list.
    - last - System.Int32: Returns the last n elements from the list.
    - sortBy - AwsNativeEbsVolumeSortFields: Sort fields for list of AWS EBS volumes.
    - sortOrder - SortOrder: Sorting order for the results.
- Returns AwsNativeEbsVolumeConnection.
### NativeEc2Instance
Refers to Amazon Elastic Compute Cloud (EC2) Instance represented by a specific ID. For more information, see https://aws.amazon.com/ec2/.

- The Input parameter takes a single value of type System.String.
- Returns AwsNativeEc2Instance.
### NativeEc2InstancesByName
Paginated list of all AWS EC2 Instances by name or substring of name.

- The Input parameter takes a hashtable with 7 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - ec2InstanceName - System.String: Native name for the AWS EC2 Instance object.
    - first - System.Int32: Returns the first n elements from the list.
    - last - System.Int32: Returns the last n elements from the list.
    - sortBy - AwsNativeEc2InstanceSortFields: Sort fields for list of AWS EC2 instances.
    - sortOrder - SortOrder: Sorting order for the results.
- Returns AwsNativeEc2InstanceConnection.
### NativeRdsExportDefault
Refers to the default values for the export operation of the RDS DB Instance in the AWS Native account.

- The Input parameter takes a hashtable with 3 name and value pairs.
    - isPointInTime - System.Boolean: Specifies whether the export of the instance is manual or Point-in-Time.
    - rdsInstanceRubrikId - System.String: The Rubrik ID for the AWS RDS Instance.
    - snapshotId - System.String: ID of the snapshot if the export is manual.
- Returns RdsInstanceExportDefaults.
### NativeRdsInstance
Refers to AWS Relational Database Service (RDS) represented by a specific ID. For more information, see https://aws.amazon.com/rds/.

- The Input parameter takes a single value of type System.String.
- Returns AwsNativeRdsInstance.
### NativeRdsPointInTimeRestoreWindow
Point-in-Time (PiT) restore window of the RDS Instance in the AWS Native account. Refers to the range of time within which the database is available to be restored to a particular point in time. For more information,see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_PIT.html.

- The Input parameter takes a hashtable with 4 name and value pairs.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - rdsDatabaseRubrikId - System.String: The Rubrik ID for the AWS RDS database.
    - rdsInstanceName - System.String: Name of the RDS DB Instance
    - region - AwsNativeRegion: Region in AWS.
- Returns AwsNativeRdsPointInTimeRestoreWindow.
### NativeRoot
Root of AWS native hierarchy.

- The NativeRoot subcommand takes no arguments.
- Returns AwsNativeRoot.
### NativeS3Bucket
Represents the Amazon S3 Bucket with a specific ID. For more information, see https://aws.amazon.com/s3/.

- The Input parameter takes a single value of type System.String.
- Returns AwsNativeS3Bucket.
### allAvailabilityZonesByRegion
List of Availability Zones (AZs) in the specified region on the specified AWS Native account.

- The Input parameter takes a hashtable with 2 name and value pairs.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
- Returns a list of System.Strings.
### allCdmVersion
Get all Rubrik CDM versions in the AWS marketplace.

- The Input parameter takes a single value of type AwsCdmVersionRequest.
- Returns a list of AwsCdmVersions.
### allCloudAccountConfig
List of all AWS cloud account configurations with the given search query.

- The Input parameter takes a single value of type AwsCloudAccountConfigsInput.
- Returns a list of AwsFeatureConfigs.
### allCloudAccountsWithFeature
List of active AWS cloud accounts and the features for the accounts. A cloud account is an AWS account added to the Rubrik platform.

- The Input parameter takes a single value of type AwsCloudAccountsWithFeaturesInput.
- Returns a list of AwsCloudAccountWithFeaturess.
### allComputeSetting
List all aws compute settings.

- The Input parameter takes a hashtable with 4 name and value pairs.
    - contextFilter - ContextFilterTypeEnum: Specifies the context filter to use.
    - filter - a list of AwsCloudComputeSettingFilterInputs: Specification on how to filter a list of compute settings.
    - sortBy - AwsCloudComputeSettingQuerySortByField: Specification on how to sort a list of compute settings.
    - sortOrder - SortOrder: Sorting order for the results.
- Returns a list of AwsComputeSettingss.
### allDbParameterGroupsByRegion
List of all DB parameter groups in a given region. Refers to container for engine configuration that applies to one or more DB Instances. For more information, see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_WorkingWithOptionGroups.html.

- The Input parameter takes a hashtable with 5 name and value pairs.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - dbEngine - AwsNativeRdsDbEngine: DB Engine of RDS Instance.
    - dbEngineVersion - System.String: Version of DB engine.
    - rdsType - AwsNativeRdsType: Type of RDS deployment.
    - region - AwsNativeRegion: Region in AWS.
- Returns a list of DbParameterGroups.
### allDbSubnetGroupsByRegion
All DB subnet groups in a given region. Refers to logical isolation of RDS on a network. For more information, see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_VPC.WorkingWithRDSInstanceinaVPC.html.

- The Input parameter takes a hashtable with 2 name and value pairs.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
- Returns a list of SubnetGroups.
### allEc2KeyPairsByRegion
List of all key pairs for a given region. A key pair, consisting of a public key and a private key, is a set of security credentials that you use to prove your identity when connecting to an EC2 instance. For more information, see https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html.

- The Input parameter takes a hashtable with 2 name and value pairs.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
- Returns a list of System.Strings.
### allExocomputeConfig
List of all AWS exocompute configurations filtered by a cloud account ID or a cloud account name prefix.

- The Input parameter takes a single value of type System.String.
- Returns a list of AwsExocomputeConfigs.
### allInstanceProfileName
All Rubrik CC-ES instance profiles in the AWS account.

- The Input parameter takes a hashtable with 2 name and value pairs.
    - cloudAccountId - System.String: Cloud account ID.
    - region - System.String: Region of AWS account.
- Returns a list of System.Strings.
### allKmsEncryptionKeysByRegion
List of encryption keys in the specified region on the specified AWS Native account. All the encrytion keys listed are managed by AWS Key Management System (KMS). For more information, see https://aws.amazon.com/kms/.

- The Input parameter takes a hashtable with 2 name and value pairs.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
- Returns a list of KmsEncryptionKeys.
### allOptionGroupsByRegion
List of all RDS option groups in a given region. Refers to settings of how a particular option works for an RDS Instance. For more information, see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_WorkingWithOptionGroups.html.

- The Input parameter takes a hashtable with 5 name and value pairs.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - dbEngine - AwsNativeRdsDbEngine: DB Engine of RDS Instance.
    - dbEngineVersion - System.String: Version of DB engine.
    - majorEngineVersion - System.String: Major version of the option group engine.
    - region - AwsNativeRegion: Region in AWS.
- Returns a list of OptionGroups.
### allRdsAuroraInstanceClass
List of all the database instance classes supported by AWS RDS Aurora databases.

- The allRdsAuroraInstanceClass subcommand takes no arguments.
- Returns AwsNativeRdsAuroraInstanceClassesReply.
### allRegion
All valid AWS regions for this cloud account.

- The Input parameter takes a single value of type System.String.
- Returns a list of AwsCloudAccountRegions.
### allS3Bucket
List of all S3 bucket names across regions for the AWS Native account.

- The Input parameter takes a single value of type System.String.
- Returns a list of System.Strings.
### allS3BucketsDetail
List of all S3 bucket details across regions for the AWS Native account.

- The Input parameter takes a single value of type System.String.
- Returns a list of S3BucketDetailss.
### allVpc
List of all Virtual Private Clouds (VPCs) in the AWS Native account.

- The Input parameter takes a single value of type System.String.
- Returns a list of AwsVpcs.
### allVpcsByRegion
List of all Virtual Private Clouds (VPCs) in the AWS Native account, classified by region.

- The Input parameter takes a hashtable with 2 name and value pairs.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
- Returns a list of AwsVpcs.
### amiTypeForNativeArchivedSnapshotExport
Amazon Machine Image (AMI) type for export of an archived EC2 Instance snapshot. For more information, see https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instances-and-amis.html.

- The Input parameter takes a single value of type AmiTypeForAwsNativeArchivedSnapshotExportInput.
- Returns AmiTypeForAwsNativeArchivedSnapshotExportReply.
### isNativeEbsVolumeSnapshotRestorable
Specified whether an EBS volume is restorable. For an EBS Volume to be restorable, the volume should be able to replace where attached.

- The Input parameter takes a single value of type System.String.
- Returns IsVolumeSnapshotRestorableReply.
### isNativeRdsInstanceLaunchConfigurationValid
Specifies whether the given DbInstance class, storage type, multi-az capability, encryption capability, iops value are supported for the given dbEngine, dbEngineVersion in the specified availability zone. When true, the specification is valid for a RDS Instance and can be used to create a new Instance.

- The Input parameter takes a hashtable with 10 name and value pairs.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - dbClass - AwsNativeRdsDbInstanceClass: DB class of the exported RDS DB instance.
    - dbEngine - AwsNativeRdsDbEngine: DB Engine of RDS Instance.
    - dbEngineVersion - System.String: Version of DB engine.
    - iops - System.Int32: IOPs of the exported RDS DB instance.
    - isMultiAz - System.Boolean: Whether the exported RDS DB instance is multi-AZ or not.
    - kmsKeyId - System.String: KMS Key ID of the exported RDS DB instance.
    - primaryAz - System.String: AZ in which the exported RDS DB instance must be launched.
    - region - AwsNativeRegion: Region in AWS.
    - storageType - AwsNativeRdsStorageType: Storage type of the exported RDS DB instance.
- Returns System.Boolean.
### isS3BucketNameAvailable
Specifies whether an S3 bucket name is available for use in AWS or not. When true, the bucket name is available for use.

- The Input parameter takes a hashtable with 2 name and value pairs.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - bucketName - System.String: Name of the S3 bucket.
- Returns System.Boolean.
### rdsInstanceDetail
Details of the RDS Instance in the AWS Native account.

- The Input parameter takes a hashtable with 4 name and value pairs.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - rdsDatabaseRubrikId - System.String: The Rubrik ID for the AWS RDS database.
    - rdsInstanceName - System.String: Name of the RDS DB Instance
    - region - AwsNativeRegion: Region in AWS.
- Returns RdsInstanceDetailsFromAws.
### validateNativeRdsClusterNameForExport
Validates the name used for an RDS cluster during an export operation. Returns true if the RDS cluster name is valid. Returns false, with an error message, if the RDS cluster name validation fails. Returns false, without an error message for all other failures.

- The Input parameter takes a hashtable with 3 name and value pairs.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - rdsClusterName - System.String: Name of the RDS DB Cluster.
    - region - AwsNativeRegion: Region in AWS.
- Returns ValidateAwsNativeRdsClusterNameForExportReply.
### validateNativeRdsInstanceNameForExport
Validates the name used for an RDS Instance during an export operation. Returns true if the RDS Instance name is valid. Returns false, with an error message, if the RDS Instance name validation fails. Returns false, without an error message for all other failures.

- The Input parameter takes a hashtable with 3 name and value pairs.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - rdsInstanceName - System.String: Name of the RDS DB Instance
    - region - AwsNativeRegion: Region in AWS.
- Returns ValidateAwsNativeRdsInstanceNameForExportReply.
