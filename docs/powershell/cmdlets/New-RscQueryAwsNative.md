# New-RscQueryAwsNative
## Subcommands
### account
Refers to the AWS Native account that serves as a container for all your AWS resources. The AWS Native account contains information about the metadata related to the AWS Native resources.

- There are 2 arguments.
    - awsNativeAccountRubrikId - System.String: The Rubrik ID for the AWS Native account.
    - awsNativeProtectionFeature - AwsNativeProtectionFeature: Cloud native protection feature.
- Returns AwsNativeAccount.
### accounts
Paginated list of all AWS Native accounts.

- There are 9 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortBy - AwsNativeAccountSortFields: Sort fields for list of AWS accounts.
    - sortOrder - SortOrder: Sorts the order of results.
    - accountFilters - AwsNativeAccountFilters
    - authorizedOperationFilter - Operation
    - awsNativeProtectionFeature - AwsNativeProtectionFeature: Cloud native protection feature.
- Returns AwsNativeAccountConnection.
### amitypeforarchivedsnapshotexport
Amazon Machine Image (AMI) type for export of an archived EC2 Instance snapshot. For more information, see https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instances-and-amis.html.

- There is a single argument of type AmiTypeForAwsNativeArchivedSnapshotExportInput.
- Returns AmiTypeForAwsNativeArchivedSnapshotExportReply.
### ebsvolume
Refers to the Amazon Elastic Block Store (EBS) Volume represented by a specific ID. For more information, see https://aws.amazon.com/ebs/.

- There are 2 arguments.
    - ebsVolumeRubrikId - System.String: Rubrik ID for the AWS EBS Volume object.
    - includeSecurityMetadata - System.Boolean: Filter to include the security metadata.
- Returns AwsNativeEbsVolume.
### ebsvolumes
Paginated list of all AWS EBS Volumes.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortBy - AwsNativeEbsVolumeSortFields: Sort fields for list of AWS EBS volumes.
    - sortOrder - SortOrder: Sorts the order of results.
    - ebsVolumeFilters - AwsNativeEbsVolumeFilters: Filter for EBS volumes.
    - includeSecurityMetadata - System.Boolean: Filter to include the security metadata.
- Returns AwsNativeEbsVolumeConnection.
### ebsvolumesbyname
Paginated list of all AWS EBS Volumes by name or substring of name.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortBy - AwsNativeEbsVolumeSortFields: Sort fields for list of AWS EBS volumes.
    - sortOrder - SortOrder: Sorts the order of results.
    - ebsVolumeName - System.String: The native name for the AWS EBS Volume object.
- Returns AwsNativeEbsVolumeConnection.
### ec2instance
Refers to Amazon Elastic Compute Cloud (EC2) Instance represented by a specific ID. For more information, see https://aws.amazon.com/ec2/.

- There are 2 arguments.
    - ec2InstanceRubrikId - System.String: Rubrik ID for the AWS EC2 Instance.
    - includeSecurityMetadata - System.Boolean: Filter to include the security metadata.
- Returns AwsNativeEc2Instance.
### ec2instances
Paginated list of all AWS EC2 Instances.

- There are 9 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortBy - AwsNativeEc2InstanceSortFields: Sort fields for list of AWS EC2 instances.
    - sortOrder - SortOrder: Sorts the order of results.
    - descendantTypeFilter - list of HierarchyObjectTypeEnums: Filter the CDM cloud hosts by workload type.
    - ec2InstanceFilters - AwsNativeEc2InstanceFilters: Filter for EC2 instances.
    - includeSecurityMetadata - System.Boolean: Filter to include the security metadata.
- Returns AwsNativeEc2InstanceConnection.
### ec2instancesbyname
Paginated list of all AWS EC2 Instances by name or substring of name.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortBy - AwsNativeEc2InstanceSortFields: Sort fields for list of AWS EC2 instances.
    - sortOrder - SortOrder: Sorts the order of results.
    - ec2InstanceName - System.String: Native name for the AWS EC2 Instance object.
- Returns AwsNativeEc2InstanceConnection.
### isebsvolumesnapshotrestorable
Specified whether an EBS volume is restorable. For an EBS Volume to be restorable, the volume should be able to replace where attached.

- There is a single argument of type System.String.
- Returns IsVolumeSnapshotRestorableReply.
### isrdsinstancelaunchconfigurationvalid
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
### rdsexportdefaults
Refers to the default values for the export operation of the RDS DB Instance in the AWS Native account.

- There are 3 arguments.
    - rdsInstanceRubrikId - System.String: The Rubrik ID for the AWS RDS Instance.
    - snapshotId - System.String: ID of the snapshot if the export is manual.
    - isPointInTime - System.Boolean: Specifies whether the export of the instance is manual or Point-in-Time.
- Returns RdsInstanceExportDefaults.
### rdsinstance
Refers to AWS Relational Database Service (RDS) represented by a specific ID. For more information, see https://aws.amazon.com/rds/.

- There are 2 arguments.
    - rdsInstanceRubrikId - System.String: The Rubrik ID for the AWS RDS Instance.
    - includeSecurityMetadata - System.Boolean: Filter to include the security metadata.
- Returns AwsNativeRdsInstance.
### rdsinstances
Paginated list of AWS RDS Instances on AWS Native account.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortBy - AwsNativeRdsInstanceSortFields: Sort fields for list of AWS RDS instances.
    - sortOrder - SortOrder: Sorts the order of results.
    - rdsInstanceFilters - AwsNativeRdsInstanceFilters: Filter for RDS instances.
    - includeSecurityMetadata - System.Boolean: Filter to include the security metadata.
- Returns AwsNativeRdsInstanceConnection.
### rdspointintimerestorewindow
Point-in-Time (PiT) restore window of the RDS Instance in the AWS Native account. Refers to the range of time within which the database is available to be restored to a particular point in time. For more information,see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_PIT.html.

- There are 4 arguments.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
    - rdsInstanceName - System.String: Name of the RDS DB Instance
    - rdsDatabaseRubrikId - System.String: The Rubrik ID for the AWS RDS database.
- Returns AwsNativeRdsPointInTimeRestoreWindow.
### root
Root of AWS native hierarchy.

- The root subcommand takes no arguments.
- Returns AwsNativeRoot.
### s3bucket
Represents the Amazon S3 Bucket with a specific ID. For more information, see https://aws.amazon.com/s3/.

- There are 2 arguments.
    - s3BucketRubrikId - System.String: Rubrik ID for the AWS S3 bucket object.
    - includeSecurityMetadata - System.Boolean: Filter to include the security metadata.
- Returns AwsNativeS3Bucket.
### validaterdsclusternameforexport
Validates the name used for an RDS cluster during an export operation. Returns true if the RDS cluster name is valid. Returns false, with an error message, if the RDS cluster name validation fails. Returns false, without an error message for all other failures.

- There are 3 arguments.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
    - rdsClusterName - System.String: Name of the RDS DB Cluster.
- Returns ValidateAwsNativeRdsClusterNameForExportReply.
### validaterdsinstancenameforexport
Validates the name used for an RDS Instance during an export operation. Returns true if the RDS Instance name is valid. Returns false, with an error message, if the RDS Instance name validation fails. Returns false, without an error message for all other failures.

- There are 3 arguments.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
    - rdsInstanceName - System.String: Name of the RDS DB Instance
- Returns ValidateAwsNativeRdsInstanceNameForExportReply.
