# Invoke-RscQueryAws
## Subcommands
### allavailabilityzonesbyregion
List of Availability Zones (AZs) in the specified region on the specified AWS Native account.

- There are 2 arguments.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
- Returns list of System.Strings.
### allcdmversion
Get all Rubrik CDM versions in the AWS marketplace.

- There is a single argument of type AwsCdmVersionRequest.
- Returns list of AwsCdmVersions.
### allcloudaccountconfig
List of all AWS cloud account configurations with the given search query.

- There is a single argument of type AwsCloudAccountConfigsInput.
- Returns list of AwsFeatureConfigs.
### allcloudaccountsfeatureswithexoconfig
List of active AWS cloud account features and the Exocompute mapping information for the accounts. A cloud account is an AWS account added to the Rubrik platform.

- There is a single argument of type AwsCloudAccountsWithFeaturesInput.
- Returns list of AwsCloudAccountFeaturesWithExoConfigss.
### allcloudaccountswithfeature
List of active AWS cloud accounts and the features for the accounts. A cloud account is an AWS account added to the Rubrik platform.

- There is a single argument of type AwsCloudAccountsWithFeaturesInput.
- Returns list of AwsCloudAccountWithFeaturess.
### allcomputesetting
List all aws compute settings.

- There are 4 arguments.
    - sortBy - AwsCloudComputeSettingQuerySortByField: Specification on how to sort a list of compute settings.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of AwsCloudComputeSettingFilterInputs: Specification on how to filter a list of compute settings.
    - contextFilter - ContextFilterTypeEnum: Specifies the context filter to use.
- Returns list of AwsComputeSettingss.
### alldbparametergroupsbyregion
List of all DB parameter groups in a given region. Refers to container for engine configuration that applies to one or more DB Instances. For more information, see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_WorkingWithOptionGroups.html.

- There are 5 arguments.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
    - dbEngine - AwsNativeRdsDbEngine: DB Engine of RDS Instance.
    - dbEngineVersion - System.String: Version of DB engine.
    - rdsType - AwsNativeRdsType: Type of RDS deployment.
- Returns list of DbParameterGroups.
### alldbsubnetgroupsbyregion
All DB subnet groups in a given region. Refers to logical isolation of RDS on a network. For more information, see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_VPC.WorkingWithRDSInstanceinaVPC.html.

- There are 2 arguments.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
- Returns list of SubnetGroups.
### allec2keypairsbyregion
List of all key pairs for a given region. A key pair, consisting of a public key and a private key, is a set of security credentials that you use to prove your identity when connecting to an EC2 instance. For more information, see https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html.

- There are 2 arguments.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
- Returns list of System.Strings.
### allexocomputeconfig
List of all AWS exocompute configurations filtered by a cloud account ID or a cloud account name prefix.

- There is a single argument of type System.String.
- Returns list of AwsExocomputeConfigs.
### allinstanceprofilename
All Rubrik CC-ES instance profiles in the AWS account.

- There are 2 arguments.
    - cloudAccountId - System.String: Cloud account ID.
    - region - System.String: Region of AWS account.
- Returns list of System.Strings.
### allkmsencryptionkeysbyregion
List of encryption keys in the specified region on the specified AWS Native account. All the encrytion keys listed are managed by AWS Key Management System (KMS). For more information, see https://aws.amazon.com/kms/.

- There are 2 arguments.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
- Returns list of KmsEncryptionKeys.
### alloptiongroupsbyregion
List of all RDS option groups in a given region. Refers to settings of how a particular option works for an RDS Instance. For more information, see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_WorkingWithOptionGroups.html.

- There are 5 arguments.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
    - dbEngine - AwsNativeRdsDbEngine: DB Engine of RDS Instance.
    - dbEngineVersion - System.String: Version of DB engine.
    - majorEngineVersion - System.String: Major version of the option group engine.
- Returns list of OptionGroups.
### allrdsaurorainstanceclass
List of all the database instance classes supported by AWS RDS Aurora databases.

- The allrdsaurorainstanceclass subcommand takes no arguments.
- Returns AwsNativeRdsAuroraInstanceClassesReply.
### allregion
All valid AWS regions for this cloud account.

- There is a single argument of type System.String.
- Returns list of AwsCloudAccountRegions.
### alls3bucket
List of all S3 bucket names across regions for the AWS Native account.

- There is a single argument of type System.String.
- Returns list of System.Strings.
### alls3bucketsdetail
List of all S3 bucket details across regions for the AWS Native account.

- There are 2 arguments.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: The region in AWS. If no region is provided, the AWS function will return all buckets.
- Returns list of S3BucketDetailss.
### allsupportedrdsdatabaseinstanceclass
List of all the database instance classes supported by AWS RDS database for the provided DB engine and engine version. DB engine version is a optional argument, it can be ignored if we want to retrieve all the supported instance class for a DB engine irrespective of DB engine version.

- There are 4 arguments.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
    - dbEngine - AwsNativeRdsDbEngine: DB Engine of RDS Instance.
    - dbEngineVersion - System.String: Version of DB engine.
- Returns list of System.Strings.
### allvpc
List of all Virtual Private Clouds (VPCs) in the AWS Native account.

- There is a single argument of type System.String.
- Returns list of AwsVpcs.
### allvpcsbyregion
List of all Virtual Private Clouds (VPCs) in the AWS Native account, classified by region.

- There are 2 arguments.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
- Returns list of AwsVpcs.
### amitypefornativearchivedsnapshotexport
Amazon Machine Image (AMI) type for export of an archived EC2 Instance snapshot. For more information, see https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instances-and-amis.html.

- There is a single argument of type AmiTypeForAwsNativeArchivedSnapshotExportInput.
- Returns AmiTypeForAwsNativeArchivedSnapshotExportReply.
### cloudaccountlistkmskey
- There are 3 arguments.
    - cloudAccountUuid - System.String: The ID of the cloud account.
    - feature - CloudAccountFeature: A cloud account feature of Rubrik Security Cloud.
    - region - AwsRegion: AWS region argument for archival use case.
- Returns AwsCloudAccountListKMSKeysResponse.
### cloudaccountlistsecuritygroup
Retrieves a list of security groups in the specified cloud account and virtual private cloud (VPC).

- There are 4 arguments.
    - cloudAccountUuid - System.String: The ID of the cloud account.
    - feature - CloudAccountFeature: A cloud account feature of Rubrik Security Cloud.
    - region - AwsRegion: AWS region argument for archival use case.
    - vpcID - System.String: VPC native ID.
- Returns AwsCloudAccountListSecurityGroupsResponse.
### cloudaccountlistsubnet
Retrieves a list of subnets in the specified cloud account and virtual private cloud (VPC).

- There are 4 arguments.
    - cloudAccountUuid - System.String: The ID of the cloud account.
    - feature - CloudAccountFeature: A cloud account feature of Rubrik Security Cloud.
    - region - AwsRegion: AWS region argument for archival use case.
    - vpcID - System.String: VPC native ID.
- Returns AwsCloudAccountListSubnetsResponse.
### cloudaccountlistvpc
Retrieves a list of virtual private clouds (VPCs) in the specific cloud account.

- There are 3 arguments.
    - cloudAccountUuid - System.String: The ID of the cloud account.
    - feature - CloudAccountFeature: A cloud account feature of Rubrik Security Cloud.
    - region - AwsRegion: AWS region argument for archival use case.
- Returns AwsCloudAccountListVpcResponse.
### cloudaccountwithfeature
List of AWS cloud accounts and the features for each account, classified by ID.

- There are 2 arguments.
    - cloudAccountId - System.String: The Rubrik ID of the cloud account.
    - awsCloudAccountArg - AwsCloudAccountWithFeaturesInput: Arguments for get cloud account.
- Returns AwsCloudAccountWithFeatures.
### computesetting
Retrieve aws compute settings.

- There is a single argument of type System.String.
- Returns AwsComputeSettings.
### isnativeebsvolumesnapshotrestorable
Specified whether an EBS volume is restorable. For an EBS Volume to be restorable, the volume should be able to replace where attached.

- There is a single argument of type System.String.
- Returns IsVolumeSnapshotRestorableReply.
### isnativerdsinstancelaunchconfigurationvalid
Specifies whether the given DbInstance class, storage type, multi-az capability, encryption capability, iops value are supported for the given dbEngine, dbEngineVersion in the specified availability zone. When true, the specification is valid for a RDS Instance and can be used to create a new Instance.

- There are 11 arguments.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
    - dbEngine - AwsNativeRdsDbEngine: DB Engine of RDS Instance.
    - dbEngineVersion - System.String: Version of DB engine.
    - dbClass - AwsNativeRdsDbInstanceClass: DB class of the exported RDS DB instance.
    - databaseInstanceClass - System.String: DB class of the exported RDS DB instance. AWS supported instance classes can be found here https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.DBInstanceClass.html#Concepts.DBInstanceClass.Types.
    - primaryAz - System.String: AZ in which the exported RDS DB instance must be launched.
    - storageType - AwsNativeRdsStorageType: Storage type of the exported RDS DB instance.
    - isMultiAz - System.Boolean: Whether the exported RDS DB instance is multi-AZ or not.
    - kmsKeyId - System.String: KMS Key ID of the exported RDS DB instance.
    - iops - System.Int32: IOPs of the exported RDS DB instance.
- Returns System.Boolean.
### iss3bucketnameavailable
Specifies whether an S3 bucket name is available for use in AWS or not. When true, the bucket name is available for use.

- There are 2 arguments.
    - bucketName - System.String: Name of the AWS S3 bucket.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
- Returns System.Boolean.
### nativeaccount
Refers to the AWS Native account that serves as a container for all your AWS resources. The AWS Native account contains information about the metadata related to the AWS Native resources.

- There are 2 arguments.
    - awsNativeAccountRubrikId - System.String: The Rubrik ID for the AWS Native account.
    - awsNativeProtectionFeature - AwsNativeProtectionFeature: Cloud native protection feature.
- Returns AwsNativeAccount.
### nativeebsvolume
Refers to the Amazon Elastic Block Store (EBS) Volume represented by a specific ID. For more information, see https://aws.amazon.com/ebs/.

- There is a single argument of type System.String.
- Returns AwsNativeEbsVolume.
### nativeebsvolumesbyname
Paginated list of all AWS EBS Volumes by name or substring of name.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortBy - AwsNativeEbsVolumeSortFields: Sort fields for list of AWS EBS volumes.
    - sortOrder - SortOrder: Sorting order for the results.
    - ebsVolumeName - System.String: The native name for the AWS EBS Volume object.
- Returns AwsNativeEbsVolumeConnection.
### nativeec2instance
Refers to Amazon Elastic Compute Cloud (EC2) Instance represented by a specific ID. For more information, see https://aws.amazon.com/ec2/.

- There is a single argument of type System.String.
- Returns AwsNativeEc2Instance.
### nativeec2instancesbyname
Paginated list of all AWS EC2 Instances by name or substring of name.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortBy - AwsNativeEc2InstanceSortFields: Sort fields for list of AWS EC2 instances.
    - sortOrder - SortOrder: Sorting order for the results.
    - ec2InstanceName - System.String: Native name for the AWS EC2 Instance object.
- Returns AwsNativeEc2InstanceConnection.
### nativerdsexportdefault
Refers to the default values for the export operation of the RDS DB Instance in the AWS Native account.

- There are 3 arguments.
    - rdsInstanceRubrikId - System.String: The Rubrik ID for the AWS RDS Instance.
    - snapshotId - System.String: ID of the snapshot if the export is manual.
    - isPointInTime - System.Boolean: Specifies whether the export of the instance is manual or Point-in-Time.
- Returns RdsInstanceExportDefaults.
### nativerdsinstance
Refers to AWS Relational Database Service (RDS) represented by a specific ID. For more information, see https://aws.amazon.com/rds/.

- There is a single argument of type System.String.
- Returns AwsNativeRdsInstance.
### nativerdspointintimerestorewindow
Point-in-Time (PiT) restore window of the RDS Instance in the AWS Native account. Refers to the range of time within which the database is available to be restored to a particular point in time. For more information,see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_PIT.html.

- There are 4 arguments.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
    - rdsInstanceName - System.String: Name of the RDS DB Instance
    - rdsDatabaseRubrikId - System.String: The Rubrik ID for the AWS RDS database.
- Returns AwsNativeRdsPointInTimeRestoreWindow.
### nativeroot
Root of AWS native hierarchy.

- The nativeroot subcommand takes no arguments.
- Returns AwsNativeRoot.
### natives3bucket
Represents the Amazon S3 Bucket with a specific ID. For more information, see https://aws.amazon.com/s3/.

- There is a single argument of type System.String.
- Returns AwsNativeS3Bucket.
### rdsinstancedetail
Details of the RDS Instance in the AWS Native account.

- There are 4 arguments.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
    - rdsInstanceName - System.String: Name of the RDS DB Instance
    - rdsDatabaseRubrikId - System.String: The Rubrik ID for the AWS RDS database.
- Returns RdsInstanceDetailsFromAws.
### validatenativerdsclusternameforexport
Validates the name used for an RDS cluster during an export operation. Returns true if the RDS cluster name is valid. Returns false, with an error message, if the RDS cluster name validation fails. Returns false, without an error message for all other failures.

- There are 3 arguments.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
    - rdsClusterName - System.String: Name of the RDS DB Cluster.
- Returns ValidateAwsNativeRdsClusterNameForExportReply.
### validatenativerdsinstancenameforexport
Validates the name used for an RDS Instance during an export operation. Returns true if the RDS Instance name is valid. Returns false, with an error message, if the RDS Instance name validation fails. Returns false, without an error message for all other failures.

- There are 3 arguments.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
    - rdsInstanceName - System.String: Name of the RDS DB Instance
- Returns ValidateAwsNativeRdsInstanceNameForExportReply.
