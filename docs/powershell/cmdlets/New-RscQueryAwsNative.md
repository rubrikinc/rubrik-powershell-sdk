# New-RscQueryAwsNative
## Subcommands
### account
Returns a single AWS Native account by its Rubrik FID.

- There are 3 arguments.
    - awsNativeAccountRubrikId - System.String: Rubrik FID of the AWS Native account.
    - awsNativeProtectionFeature - AwsNativeProtectionFeature: Protection feature whose workload scopes the account's SLA.
    - includeSecurityMetadata - System.Boolean: Whether to include the object's security metadata in the response.
- Returns AwsNativeAccount.
### accounts
Lists the AWS Native accounts under the AWS-native hierarchy root.

- There are 11 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: An opaque cursor returned from a previous query's endCursor field. Pass this value verbatim to retrieve the next page of results.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: An opaque cursor returned from a previous query's startCursor field. Pass this value verbatim to retrieve the previous page of results.
    - sortBy - AwsNativeAccountSortFields: Field of the account to order the results by. Defaults to the account name.
    - sortOrder - SortOrder: Direction the results are ordered in. Defaults to ascending.
    - accountFilters - AwsNativeAccountFilters: Narrows the results to the accounts matching every filter supplied. Unset returns all non-relic accounts.
    - authorizedOperationFilter - Operation: RBAC operation the caller must be authorized for on each returned account. Defaults to VIEW_INVENTORY.
    - awsNativeProtectionFeature - AwsNativeProtectionFeature: Protection feature the returned accounts must have enabled, and whose workload scopes their SLA. Ignored when awsNativeProtectionFeatures is set.
    - awsNativeProtectionFeatures - list of AwsNativeProtectionFeatures: Protection features the returned accounts must have at least one of enabled. Defaults to awsNativeProtectionFeature alone when unset.
    - includeSecurityMetadata - System.Boolean: Whether to include each object's security metadata in the response.
- Returns AwsNativeAccountConnection.
### amitypeforarchivedsnapshotexport
Returns the Amazon Machine Image (AMI) type to use when exporting an
archived EC2 instance snapshot to a target account and region.

- There is a single argument of type AmiTypeForAwsNativeArchivedSnapshotExportInput.
- Returns AmiTypeForAwsNativeArchivedSnapshotExportReply.
### dynamodbtable
GetAwsNativeDynamoDbTable returns the AWS native DynamoDB table
identified by the request's Rubrik ID.

- There are 2 arguments.
    - dynamoDbTableRubrikId - System.String: Rubrik ID for the AWS DynamoDB table object.
    - includeSecurityMetadata - System.Boolean: Whether to include security metadata on the returned object.
- Returns AwsNativeDynamoDbTable.
### dynamodbtablepointintimerestorewindow
GetAwsNativeDynamoDbTablePointInTimeRestoreWindow returns the
recoverable range for the DynamoDB table identified by its Rubrik ID,
authorizing the caller against the table via authz-service.

- There is a single argument of type System.String.
- Returns AwsNativeDynamoDbTablePointInTimeRestoreWindow.
### ebsvolume
Returns a single AWS Native EBS volume by its Rubrik FID.

- There are 2 arguments.
    - ebsVolumeRubrikId - System.String: Rubrik FID of the EBS volume.
    - includeSecurityMetadata - System.Boolean: Whether to include the object's security metadata in the response.
- Returns AwsNativeEbsVolume.
### ebsvolumes
Lists the AWS Native EBS volumes under the AWS-native hierarchy root.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: An opaque cursor returned from a previous query's endCursor field. Pass this value verbatim to retrieve the next page of results.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: An opaque cursor returned from a previous query's startCursor field. Pass this value verbatim to retrieve the previous page of results.
    - sortBy - AwsNativeEbsVolumeSortFields: Field of the EBS volume to order the results by. Defaults to the volume name.
    - sortOrder - SortOrder: Direction the results are ordered in. Defaults to ascending.
    - ebsVolumeFilters - AwsNativeEbsVolumeFilters: Narrows the results to the EBS volumes matching every filter supplied. Unset returns all non-relic volumes.
    - includeSecurityMetadata - System.Boolean: Whether to include each object's security metadata in the response.
- Returns AwsNativeEbsVolumeConnection.
### ebsvolumesbyname
Lists the AWS Native EBS volumes under the AWS-native hierarchy root
whose name or volume ID matches the given substring.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: An opaque cursor returned from a previous query's endCursor field. Pass this value verbatim to retrieve the next page of results.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: An opaque cursor returned from a previous query's startCursor field. Pass this value verbatim to retrieve the previous page of results.
    - ebsVolumeName - System.String: Case-insensitive substring matched against each EBS volume's name and volume ID.
    - sortBy - AwsNativeEbsVolumeSortFields: Field of the EBS volume to order the results by. Defaults to the volume name.
    - sortOrder - SortOrder: Direction the results are ordered in. Defaults to ascending.
- Returns AwsNativeEbsVolumeConnection.
### ec2instance
Returns a single AWS Native EC2 instance by its Rubrik FID.

- There are 2 arguments.
    - ec2InstanceRubrikId - System.String: Rubrik FID of the EC2 instance.
    - includeSecurityMetadata - System.Boolean: Whether to include the object's security metadata in the response.
- Returns AwsNativeEc2Instance.
### ec2instances
Lists the AWS Native EC2 instances under the AWS-native hierarchy root.

- There are 9 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: An opaque cursor returned from a previous query's endCursor field. Pass this value verbatim to retrieve the next page of results.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: An opaque cursor returned from a previous query's startCursor field. Pass this value verbatim to retrieve the previous page of results.
    - sortBy - AwsNativeEc2InstanceSortFields: Field of the EC2 instance to order the results by. Defaults to the instance name.
    - sortOrder - SortOrder: Direction the results are ordered in. Defaults to ascending.
    - descendantTypeFilter - list of HierarchyObjectTypeEnums: Filter the CDM cloud hosts by workload type: returns only the EC2 instances whose CDM host has a workload of one of these types. No filtering when empty.
    - ec2InstanceFilters - AwsNativeEc2InstanceFilters: Narrows the results to the EC2 instances matching every filter supplied. Unset returns all non-relic instances.
    - includeSecurityMetadata - System.Boolean: Whether to include each object's security metadata in the response.
- Returns AwsNativeEc2InstanceConnection.
### ec2instancesbyname
Lists the AWS Native EC2 instances under the AWS-native hierarchy root
whose name or instance ID matches the given substring.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: An opaque cursor returned from a previous query's endCursor field. Pass this value verbatim to retrieve the next page of results.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: An opaque cursor returned from a previous query's startCursor field. Pass this value verbatim to retrieve the previous page of results.
    - sortBy - AwsNativeEc2InstanceSortFields: Field of the EC2 instance to order the results by. Defaults to the instance name.
    - sortOrder - SortOrder: Direction the results are ordered in. Defaults to ascending.
    - ec2InstanceName - System.String: Case-insensitive substring matched against each EC2 instance's name and instance ID.
    - includeSecurityMetadata - System.Boolean: Whether to include each object's security metadata in the response.
- Returns AwsNativeEc2InstanceConnection.
### isebsvolumesnapshotrestorable
Specified whether an EBS volume is restorable. For an EBS Volume to be restorable, the volume should be able to replace where attached.

- There is a single argument of type System.String.
- Returns IsVolumeSnapshotRestorableReply.
### isrdsinstancelaunchconfigurationvalid
Validates whether the given RDS launch configuration is orderable in AWS.

- There are 11 arguments.
    - awsAccountRubrikId - System.String: Rubrik ID for the AWS Native account.
    - region - AwsNativeRegion: Region in AWS.
    - dbEngine - AwsNativeRdsDbEngine: DB Engine of the RDS Instance.
    - dbEngineVersion - System.String: Version of the DB engine.
    - dbClass - AwsNativeRdsDbInstanceClass: Deprecated DB class enum, used as a fallback when databaseInstanceClass is unset.
    - databaseInstanceClass - System.String: Preferred DB instance class string.
    - primaryAz - System.String: AZ in which the instance would be launched.
    - storageType - AwsNativeRdsStorageType: Storage type of the instance.
    - isMultiAz - System.Boolean: Whether the instance is multi-AZ.
    - kmsKeyId - System.String: KMS Key ID; presence determines whether the instance is treated as encrypted.
    - iops - System.Int32: IOPS of the instance.
- Returns System.Boolean.
### rdsexportdefaults
Refers to the default values for the export operation of the RDS DB Instance in the AWS Native account.

- There are 4 arguments.
    - rdsInstanceRubrikId - System.String: The Rubrik ID for the AWS RDS Instance.
    - snapshotId - System.String: ID of the snapshot if the export is manual.
    - isPointInTime - System.Boolean: Specifies whether the export of the instance is manual or Point-in-Time.
    - isArchivalCopy - System.Boolean: Specifies whether the export of the instance is from an archival copy.
- Returns RdsInstanceExportDefaults.
### rdsexports3buckets
S3 buckets that can hold the output of an RDS recover-to-S3 export, each
with the region it resides in. Only buckets reachable from the specified
AWS account are returned, and that account must have RDS protection
onboarded. A bucket is a valid destination only when its region matches
the region the export writes to, which is why each bucket carries its
region.

- There are 2 arguments.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Restricts the result to buckets residing in this region.
- Returns list of S3BucketDetailss.
### rdsinstance
Returns a single AWS Native RDS instance by its Rubrik FID.

- There are 2 arguments.
    - rdsInstanceRubrikId - System.String: Rubrik FID of the RDS instance.
    - includeSecurityMetadata - System.Boolean: Whether to include the object's security metadata in the response.
- Returns AwsNativeRdsInstance.
### rdsinstances
Lists the AWS Native RDS instances under the AWS-native hierarchy root.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: An opaque cursor returned from a previous query's endCursor field. Pass this value verbatim to retrieve the next page of results.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: An opaque cursor returned from a previous query's startCursor field. Pass this value verbatim to retrieve the previous page of results.
    - sortBy - AwsNativeRdsInstanceSortFields: Field of the RDS instance to order the results by. Defaults to the instance name.
    - sortOrder - SortOrder: Direction the results are ordered in. Defaults to ascending.
    - rdsInstanceFilters - AwsNativeRdsInstanceFilters: Narrows the results to the RDS instances matching every filter supplied. Unset returns all non-relic instances.
    - includeSecurityMetadata - System.Boolean: Whether to include each object's security metadata in the response.
- Returns AwsNativeRdsInstanceConnection.
### rdspointintimerestorewindow
Point-in-Time (PiT) restore window of the RDS Instance in the AWS Native account. Refers to the range of time within which the database is available to be restored to a particular point in time. For more information,see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_PIT.html.

- There are 4 arguments.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
    - rdsInstanceName - System.String: Name of the RDS DB Instance.
    - rdsDatabaseRubrikId - System.String: The Rubrik ID for the AWS RDS database.
- Returns AwsNativeRdsPointInTimeRestoreWindow.
### root
Returns the root of the AWS Native hierarchy.

- The root subcommand takes no arguments.
- Returns AwsNativeRoot.
### s3bucket
GetAwsNativeS3Bucket returns the hierarchy details for a single AWS
native S3 bucket.

- There are 2 arguments.
    - s3BucketRubrikId - System.String: Rubrik ID of the S3 bucket.
    - includeSecurityMetadata - System.Boolean: Whether to include security metadata on the returned object.
- Returns AwsNativeS3Bucket.
### validatedynamodbtablenameforrecovery
ValidateAwsNativeDynamoDbTableNameForRecovery validates the recovery
table name entered by the customer, authorizing the caller against the
AWS Native account and gating on the DynamoDB feature flag.

- There are 3 arguments.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - dynamoDBTableNameForRecovery - System.String: Table name to validate for recovery.
    - region - AwsNativeRegion: Region in AWS.
- Returns ValidateAwsNativeDynamoDbTableNameForRecoveryReply.
### validaterdsclusternameforexport
Validates the name used for an RDS cluster during an export operation. Returns true if the RDS cluster name is
valid. Returns false, with an error message, if the RDS cluster name validation fails. Returns false, without
an error message for all other failures.

- There are 3 arguments.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
    - rdsClusterName - System.String: Name of the RDS DB Cluster.
- Returns ValidateAwsNativeRdsClusterNameForExportReply.
### validaterdsinstancenameforexport
Validates the name used for an RDS Instance during an export operation. Returns true if the RDS Instance name
is valid. Returns false, with an error message, if the RDS Instance name validation fails. Returns false,
without an error message for all other failures.

- There are 3 arguments.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
    - rdsInstanceName - System.String: Name of the RDS DB Instance.
- Returns ValidateAwsNativeRdsInstanceNameForExportReply.
