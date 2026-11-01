# New-RscQueryAws
## Subcommands
### artifactstodelete
Retrieves the AWS artifacts that need to be deleted when an account is being
deleted.

- There is a single argument of type AwsArtifactsToDeleteInput.
- Returns AwsArtifactsToDelete.
### availabilityzonesbyregion
Lists the availability zones of a region, as seen by an AWS Native
account. Different accounts can see different zones in the same region.

- There are 3 arguments.
    - awsAccountRubrikId - System.String: Rubrik FID of the AWS Native account.
    - region - AwsNativeRegion: Region to list the availability zones of.
    - feature - CloudAccountFeature: Cloud account feature whose role is used to read AWS.
- Returns list of System.Strings.
### batchsupportedrdsdatabaseinstanceclasses
BatchSupportedAwsRdsDatabaseInstanceClasses returns the list of
supported DB instance classes for multiple engine/version combinations
in a single batch request.

- There are 3 arguments.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
    - requests - list of RdsInstanceClassRequests: Engine and version combinations to look up.
- Returns list of RdsInstanceClassBatchResults.
### cdmversions
Get all Rubrik CDM versions in the AWS marketplace.

- There is a single argument of type AwsCdmVersionRequest.
- Returns list of AwsCdmVersions.
### cloudaccountconfigs
List of all AWS cloud account configurations with the given search query.

- There is a single argument of type AwsCloudAccountConfigsInput.
- Returns list of AwsFeatureConfigs.
### cloudaccountlistsecuritygroups
Retrieves a list of security groups in the specified cloud account and virtual private cloud (VPC).

- There are 4 arguments.
    - cloudAccountUuid - System.String: The ID of the cloud account.
    - feature - CloudAccountFeature: A cloud account feature of Rubrik Security Cloud.
    - region - AwsRegion: AWS region argument for archival use case.
    - vpcID - System.String: VPC native ID.
- Returns AwsCloudAccountListSecurityGroupsResponse.
### cloudaccountlistsubnets
Retrieves a list of subnets in the specified cloud account and virtual private cloud (VPC).

- There are 4 arguments.
    - cloudAccountUuid - System.String: The ID of the cloud account.
    - feature - CloudAccountFeature: A cloud account feature of Rubrik Security Cloud.
    - region - AwsRegion: AWS region argument for archival use case.
    - vpcID - System.String: VPC native ID.
- Returns AwsCloudAccountListSubnetsResponse.
### cloudaccountlistvpcs
Retrieves a list of virtual private clouds (VPCs) in the specific cloud account.

- There are 3 arguments.
    - cloudAccountUuid - System.String: The ID of the cloud account.
    - feature - CloudAccountFeature: A cloud account feature of Rubrik Security Cloud.
    - region - AwsRegion: AWS region argument for archival use case.
- Returns AwsCloudAccountListVpcResponse.
### cloudaccountswithfeatures
List of active AWS cloud accounts and the features for the accounts. A
cloud account is an AWS account added to the Rubrik platform.

- There is a single argument of type AwsCloudAccountsWithFeaturesInput.
- Returns list of AwsCloudAccountWithFeaturess.
### cloudaccountwithfeatures
List of AWS cloud accounts and the features for each account, classified by ID.

- There are 2 arguments.
    - cloudAccountId - System.String: The UUID of the AWS cloud account to fetch.
    - awsCloudAccountArg - AwsCloudAccountWithFeaturesInput: Arguments for getting the AWS cloud account with features.
- Returns AwsCloudAccountWithFeatures.
### dbparametergroupsbyregion
ListDbParameterGroups returns the RDS DB parameter groups available in
the given region of an AWS Native account.

- There are 5 arguments.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
    - dbEngine - AwsNativeRdsDbEngine: Database engine of the RDS instance.
    - dbEngineVersion - System.String: Database engine version of the RDS instance.
    - rdsType - AwsNativeRdsType: Type of the RDS instance. Defaults to a regular RDS instance.
- Returns list of DbParameterGroups.
### dbsubnetgroupsbyregion
ListDbSubnetGroups returns the RDS DB subnet groups available in the
given region of an AWS Native account.

- There are 2 arguments.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
- Returns list of SubnetGroups.
### ec2instancetypesbyregion
Lists the EC2 instance types available to an AWS Native account in a
region, optionally scoped to a single AWS Outpost. An account that has
not granted the permission to read instance-type offerings from AWS gets
the full static list of known instance-type names instead.

- There are 3 arguments.
    - awsAccountRubrikId - System.String: Rubrik FID of the AWS Native account.
    - region - AwsNativeRegion: Region to list the instance types of.
    - outpostArn - System.String: ARN of the Outpost to scope the listing to.
- Returns list of AwsNativeEc2InstanceTypeOfferings.
### ec2keypairsbyregion
List of all key pairs for a given region. A key pair, consisting of a
public key and a private key, is a set of security credentials that you
use to prove your identity when connecting to an EC2 instance. For more
information, see
https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html.

- There are 2 arguments.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
- Returns list of System.Strings.
### eligibleaccountsformigrationtoorg
Retrieves the list of accounts eligible for migration to an AWS organization.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: An opaque cursor returned from a previous query's endCursor field. Pass this value verbatim to retrieve the next page of results.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: An opaque cursor returned from a previous query's startCursor field. Pass this value verbatim to retrieve the previous page of results.
    - awsOrganizationUuid - System.String: The ID of the AWS organization.
- Returns AwsCloudAccountConnection.
### exocomputeconfigs
List of all AWS exocompute configurations filtered by a cloud account ID or a cloud account
name prefix. When an operation is supplied, the returned accounts are scoped to those the
caller can perform that operation on.

- There are 2 arguments.
    - awsNativeAccountIdOrNamePrefix - System.String: Native account ID or account name prefix used to filter
the AWS exocompute configurations to return.
    - operation - Operation: Operation used to scope the returned accounts to those the caller can perform
that operation on.
- Returns list of AwsExocomputeConfigs.
### exocomputegetclusterconnectioninfo
Obtains the connection command and yaml which can be used to connect a
customer-managed cluster to RSC.

- There is a single argument of type AwsExocomputeGetClusterConnectionInput.
- Returns AwsExocomputeGetClusterConnectionInfoReply.
### instanceprofilenames
All Rubrik CC-ES instance profiles in the AWS account.

- There are 2 arguments.
    - cloudAccountId - System.String: Cloud account ID.
    - region - System.String: Region of AWS account.
- Returns list of System.Strings.
### iss3bucketnameavailable
Specifies whether an S3 bucket name is available for use in AWS or not.
When true, the bucket name is available for use.

- There are 3 arguments.
    - bucketName - System.String: Name of the AWS S3 bucket.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - feature - CloudAccountFeature: Cloud account feature whose IAM role is assumed to answer the query. Defaults to S3 protection.
- Returns System.Boolean.
### kmsencryptionkeysbyregion
List of encryption keys in the specified region on the specified AWS Native account. All the encrytion keys listed are managed by AWS Key Management System (KMS). For more information, see https://aws.amazon.com/kms/.

- There are 3 arguments.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
    - feature - CloudAccountFeature: Cloud account feature to filter encryption keys for accounts that support per-feature IAM roles.
- Returns list of KmsEncryptionKeys.
### latestpermissionsbypermissionsgroup
Retrieves the latest permissions required for each of the provided
features. Permissions for each feature are grouped by permissions group.

- There are 2 arguments.
    - features - list of CloudAccountFeatures: Cloud account features.
    - serviceType - AwsCloudAccountServiceType: Service type of the AWS cloud account.
- Returns list of AwsFeaturePermissionss.
### marketplacesubscriptioninfo
Check AWS marketplace subscription status for a given CDM version.

- There is a single argument of type CheckAwsMarketplaceSubscriptionReq.
- Returns CheckAwsMarketplaceSubscriptionReply.
### optiongroupsbyregion
List of all RDS option groups in a given region. Refers to settings of how a particular option works for an
RDS Instance. For more information, see
https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_WorkingWithOptionGroups.html.

- There are 5 arguments.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
    - dbEngine - AwsNativeRdsDbEngine: DB Engine of RDS Instance.
    - majorEngineVersion - System.String: Major version of the option group engine.
    - dbEngineVersion - System.String: DB engine version of the option group engine. Unused by the resolver.
- Returns list of OptionGroups.
### permissiondiff
Compares an AWS cloud account's deployed permissions against the latest
permission model, per feature, permissions group and IAM role.

- There are 4 arguments.
    - cloudAccountId - System.String: AWS cloud account to compare.
    - features - list of CloudAccountFeatures: Features to compare. Empty compares every feature a
permissions update would apply.
    - targetPermissionsGroups - list of AwsPermissionDiffTargets: Permissions group selection to compare
against instead of the one the account holds.
    - includeExisting - System.Boolean: Also return grants that are not changing.
- Returns AwsPermissionDiff.
### permissionpolicies
Retrieves the permissions policy for all the input features along with any AWS-managed policy ARNs which need to be attached to the roles. Each policy document can be used to create an AWS-managed policy which then needs to be attached to corresponding role.

- There is a single argument of type AwsGetPermissionPoliciesInput.
- Returns list of PermissionPolicys.
### rdsinstancedetails
Details of the RDS Instance in the AWS Native account.

- There are 4 arguments.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
    - rdsInstanceName - System.String: Name of the RDS DB Instance.
    - rdsDatabaseRubrikId - System.String: The Rubrik ID for the AWS RDS database.
- Returns RdsInstanceDetailsFromAws.
### regiondetails
Retrieve the AWS regions and availability zones.

- There is a single argument of type AwsRegionDetailsReq.
- Returns AwsRegionDetailsReply.
### regions
All valid AWS regions for this cloud account.

- There is a single argument of type System.String.
- Returns list of AwsCloudAccountRegions.
### s3buckets
List of all S3 bucket names across regions for the AWS Native account.

- There is a single argument of type System.String.
- Returns list of System.Strings.
### s3bucketsdetails
ListS3BucketsDetails lists all the s3 bucket details across regions.

- There are 2 arguments.
    - awsAccountRubrikId - System.String: Rubrik FID of the AWS Native account.
    - region - AwsNativeRegion: Region to restrict the listing to. All regions when omitted.
- Returns list of S3BucketDetailss.
### s3bucketstateforrecovery
Retrieves the versioning and object ACL state of the Amazon S3 bucket,
which is required to initiate the recovery process.

- There are 3 arguments.
    - bucketName - System.String: Name of the AWS S3 bucket.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
- Returns GetS3BucketStateForRecoveryReply.
### supportedeksversions
List of all the AWS EKS versions supported by Rubrik.

- The supportedeksversions subcommand takes no arguments.
- Returns list of System.Strings.
### supportedrdsdatabaseinstanceclasses
List of all the database instance classes supported by AWS RDS database
for the provided DB engine and engine version. DB engine version is a
optional argument, it can be ignored if we want to retrieve all the
supported instance class for a DB engine irrespective of DB engine version.

- There are 4 arguments.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
    - dbEngine - AwsNativeRdsDbEngine: DB Engine of RDS Instance.
    - dbEngineVersion - System.String: Version of DB engine.
- Returns list of System.Strings.
### trustpolicy
Retrieves the AWS trust policy that will be attached with each role (cross-account, exocompute, etc.) in the customer's environment.

- There is a single argument of type AwsTrustPolicyInput.
- Returns AwsTrustPolicy.
### validatecreateclusterinput
Validates AWS cluster create input.

- There is a single argument of type CreateAwsClusterInput.
- Returns ValidationReply.
### validatepermissions
AwsValidatePermissions validates the permissions for the
given AWS cloud accounts.

- There is a single argument of type AwsValidatePermissionsReq.
- Returns AwsValidatePermissionsReply.
### vpcs
Lists the persisted Virtual Private Clouds (VPCs) of every AWS Native
account the caller can view, optionally scoped to a single account.
Subnets and security groups are not returned.

- There is a single argument of type System.String.
- Returns list of AwsVpcs.
### vpcsbyregion
Lists the Virtual Private Clouds (VPCs) of an AWS Native account in a
region, read directly from AWS.

- There are 3 arguments.
    - awsAccountRubrikId - System.String: Rubrik FID of the AWS Native account.
    - region - AwsNativeRegion: Region to list the VPCs of.
    - feature - CloudAccountFeature: Cloud account feature whose role is used to read AWS.
- Returns list of AwsVpcs.
