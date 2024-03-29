# New-RscQueryAws
## Subcommands
### artifactstodelete
Retrieves the AWS artifacts that need to be deleted when an account is being deleted.

- There is a single argument of type AwsArtifactsToDeleteInput.
- Returns AwsArtifactsToDelete.
### availabilityzonesbyregion
List of Availability Zones (AZs) in the specified region on the specified AWS Native account.

- There are 2 arguments.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
- Returns list of System.Strings.
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
List of active AWS cloud accounts and the features for the accounts. A cloud account is an AWS account added to the Rubrik platform.

- There is a single argument of type AwsCloudAccountsWithFeaturesInput.
- Returns list of AwsCloudAccountWithFeaturess.
### cloudaccountwithfeatures
List of AWS cloud accounts and the features for each account, classified by ID.

- There are 2 arguments.
    - cloudAccountId - System.String: The Rubrik ID of the cloud account.
    - awsCloudAccountArg - AwsCloudAccountWithFeaturesInput: Arguments for get cloud account.
- Returns AwsCloudAccountWithFeatures.
### computesettings
Retrieve aws compute settings.

- There is a single argument of type System.String.
- Returns AwsComputeSettings.
### dbparametergroupsbyregion
List of all DB parameter groups in a given region. Refers to container for engine configuration that applies to one or more DB Instances. For more information, see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_WorkingWithOptionGroups.html.

- There are 5 arguments.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
    - dbEngine - AwsNativeRdsDbEngine: DB Engine of RDS Instance.
    - dbEngineVersion - System.String: Version of DB engine.
    - rdsType - AwsNativeRdsType: Type of RDS deployment.
- Returns list of DbParameterGroups.
### dbsubnetgroupsbyregion
All DB subnet groups in a given region. Refers to logical isolation of RDS on a network. For more information, see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_VPC.WorkingWithRDSInstanceinaVPC.html.

- There are 2 arguments.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
- Returns list of SubnetGroups.
### ec2keypairsbyregion
List of all key pairs for a given region. A key pair, consisting of a public key and a private key, is a set of security credentials that you use to prove your identity when connecting to an EC2 instance. For more information, see https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html.

- There are 2 arguments.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
- Returns list of System.Strings.
### exocomputeconfigs
List of all AWS exocompute configurations filtered by a cloud account ID or a cloud account name prefix.

- There is a single argument of type System.String.
- Returns list of AwsExocomputeConfigs.
### instanceprofilenames
All Rubrik CC-ES instance profiles in the AWS account.

- There are 2 arguments.
    - cloudAccountId - System.String: Cloud account ID.
    - region - System.String: Region of AWS account.
- Returns list of System.Strings.
### iss3bucketnameavailable
Specifies whether an S3 bucket name is available for use in AWS or not. When true, the bucket name is available for use.

- There are 2 arguments.
    - bucketName - System.String: Name of the AWS S3 bucket.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
- Returns System.Boolean.
### kmsencryptionkeysbyregion
List of encryption keys in the specified region on the specified AWS Native account. All the encrytion keys listed are managed by AWS Key Management System (KMS). For more information, see https://aws.amazon.com/kms/.

- There are 2 arguments.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
- Returns list of KmsEncryptionKeys.
### optiongroupsbyregion
List of all RDS option groups in a given region. Refers to settings of how a particular option works for an RDS Instance. For more information, see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_WorkingWithOptionGroups.html.

- There are 5 arguments.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
    - dbEngine - AwsNativeRdsDbEngine: DB Engine of RDS Instance.
    - dbEngineVersion - System.String: Version of DB engine.
    - majorEngineVersion - System.String: Major version of the option group engine.
- Returns list of OptionGroups.
### permissionpolicies
Retrieves the permissions policy for all the input features along with any AWS-managed policy ARNs which need to be attached to the roles. Each policy document can be used to create an AWS-managed policy which then needs to be attached to corresponding role.

- There is a single argument of type AwsGetPermissionPoliciesInput.
- Returns list of PermissionPolicys.
### rdsinstancedetails
Details of the RDS Instance in the AWS Native account.

- There are 4 arguments.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
    - rdsInstanceName - System.String: Name of the RDS DB Instance
    - rdsDatabaseRubrikId - System.String: The Rubrik ID for the AWS RDS database.
- Returns RdsInstanceDetailsFromAws.
### regions
All valid AWS regions for this cloud account.

- There is a single argument of type System.String.
- Returns list of AwsCloudAccountRegions.
### s3buckets
List of all S3 bucket names across regions for the AWS Native account.

- There is a single argument of type System.String.
- Returns list of System.Strings.
### s3bucketsdetails
List of all S3 bucket details across regions for the AWS Native account.

- There are 2 arguments.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: The region in AWS. If no region is provided, the AWS function will return all buckets.
- Returns list of S3BucketDetailss.
### s3bucketstateforrecovery
Retrieves the versioning and object ACL state of the Amazon S3 bucket, which is required to initiate the recovery process.

- There are 3 arguments.
    - bucketName - System.String: Name of the AWS S3 bucket.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
- Returns GetS3BucketStateForRecoveryReply.
### supportedrdsdatabaseinstanceclasses
List of all the database instance classes supported by AWS RDS database for the provided DB engine and engine version. DB engine version is a optional argument, it can be ignored if we want to retrieve all the supported instance class for a DB engine irrespective of DB engine version.

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
Validates aws cluster create input.

- There is a single argument of type CreateAwsClusterInput.
- Returns ValidationReply.
### vpcs
List of all Virtual Private Clouds (VPCs) in the AWS Native account.

- There is a single argument of type System.String.
- Returns list of AwsVpcs.
### vpcsbyregion
List of all Virtual Private Clouds (VPCs) in the AWS Native account, classified by region.

- There are 2 arguments.
    - awsAccountRubrikId - System.String: Rubrik ID for AWS account.
    - region - AwsNativeRegion: Region in AWS.
- Returns list of AwsVpcs.
