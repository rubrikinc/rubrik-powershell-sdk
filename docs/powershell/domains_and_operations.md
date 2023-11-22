# API Domains and Operations

The RSC API is organized into 52 domain.
Each API domain is a set of related operations.

## Table of Contents

Numbers in parentheses indicate the number queries and mutations in the domain.

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Account (7,1)](#account-domain) | [Cluster (29,9)](#cluster-domain) | [Microsoft 365 (1,4)](#microsoft-365-domain) | [Ransomware (12,1)](#ransomware-domain) | [Sonar (5,0)](#sonar-domain) |
| [Activity series (4,3)](#activity-series-domain) | [Db2 (9,11)](#db2-domain) | [Managed Volume (4,11)](#managed-volume-domain) | [RCS (3,4)](#rcs-domain) | [Storage Arrays (1,4)](#storage-arrays-domain) |
| [AWS (28,32)](#aws-domain) | [Report Download (3,17)](#report-download-domain) | [Mongo DB (10,10)](#mongo-db-domain) | [RCV (2,3)](#rcv-domain) | [Tape (0,3)](#tape-domain) |
| [AWS Native (19,8)](#aws-native-domain) | [Microsoft Exchange (7,4)](#microsoft-exchange-domain) | [Mosaic (4,3)](#mosaic-domain) | [Replication (4,5)](#replication-domain) | [Threat (4,3)](#threat-domain) |
| [Azure (44,42)](#azure-domain) | [Fileset (6,6)](#fileset-domain) | [Microsoft SQL Server (16,17)](#microsoft-sql-server-domain) | [Report (2,9)](#report-domain) | [VMware vSphere vCenter (9,6)](#vmware-vsphere-vcenter-domain) |
| [Azure Native (23,8)](#azure-native-domain) | [Google Cloud Platform (16,11)](#google-cloud-platform-domain) | [NAS (8,0)](#nas-domain) | [SAP HANA (8,9)](#sap-hana-domain) | [VMware vSphere (23,8)](#vmware-vsphere-domain) |
| [Azure Office365 (11,1)](#azure-office365-domain) | [Google Cloud Platform Native (7,6)](#google-cloud-platform-native-domain) | [NFS (0,3)](#nfs-domain) | [Service Account (1,4)](#service-account-domain) | [VMware vSphere VM (6,24)](#vmware-vsphere-vm-domain) |
| [Cassandra (8,5)](#cassandra-domain) | [Host (6,6)](#host-domain) | [Nutanix (18,25)](#nutanix-domain) | [Sharepoint (8,1)](#sharepoint-domain) | [Webhook (1,5)](#webhook-domain) |
| [Certificates (6,6)](#certificates-domain) | [Microsoft Hyper-V (14,23)](#microsoft-hyper-v-domain) | [Office 365 (37,31)](#office-365-domain) | [SLA (14,9)](#sla-domain) |  |
| [Cloud Account (4,2)](#cloud-account-domain) | [Kubernetes (7,7)](#kubernetes-domain) | [Oracle (16,18)](#oracle-domain) | [SMB (2,4)](#smb-domain) |  |
| [Cloud Native (19,13)](#cloud-native-domain) | [LDAP (3,4)](#ldap-domain) | [Policy (6,1)](#policy-domain) | [Snapshot (21,17)](#snapshot-domain) |  |

## Account domain

Domain key: Account

Cmdlets: `New-RscQueryAccount` and `New-RscMutationAccount`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| EnabledFeatures | Provides a list of all features enabled for the Rubrik account. | `New-RscQueryAccount -Operation EnabledFeatures`<BR> | [allEnabledFeaturesForAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Id | Account ID. | `New-RscQueryAccount -Operation Id`<BR> | [accountId](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Lookup | Retrieve account information. | `New-RscQueryAccount -Operation Lookup`<BR> | [lookupAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Owners | List of account owners. | `New-RscQueryAccount -Operation Owners`<BR> | [allAccountOwners](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Products | N/A | `New-RscQueryAccount -Operation Products`<BR> | [allAccountProducts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Settings | This endpoint is deprecated. | `New-RscQueryAccount -Operation Settings`<BR> | [accountSettings](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Users | All the users on the current account. | `New-RscQueryAccount -Operation Users`<BR> | [allUsersOnAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| DeleteUsers | N/A | `New-RscMutationAccount -Operation DeleteUsers`<BR> | [deleteUsersFromAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Activity series domain

Domain key: ActivitySeries

Cmdlets: `New-RscQueryActivitySeries` and `New-RscMutationActivitySeries`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| ActivitySeries | Retrieve an activity series. | `New-RscQueryActivitySeries -Operation ActivitySeries`<BR> | [activitySeries](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| List | Paginated list of event series objects. Each page of the results will include at most 50 entries unless otherwise specified using the first parameter. Query the pageInfo.hasNextPage field to know whether all objects were returned. | `New-RscQueryActivitySeries -Operation List`<BR> | [activitySeriesConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UserFileTimeline | N/A | `New-RscQueryActivitySeries -Operation UserFileTimeline`<BR> | [userFileActivityTimeline](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UserTimeline | N/A | `New-RscQueryActivitySeries -Operation UserTimeline`<BR> | [userActivityTimeline](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Cancel | Cancel an activity series. | `New-RscMutationActivitySeries -Operation Cancel`<BR> | [cancelActivitySeries](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DownloadUserCsv | Schedule a download CSV job for a user's activity. | `New-RscMutationActivitySeries -Operation DownloadUserCsv`<BR> | [downloadUserActivityCsv](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DownloadUserFileCsv | Schedule a download CSV job for user activity on a specific file. | `New-RscMutationActivitySeries -Operation DownloadUserFileCsv`<BR> | [downloadUserFileActivityCsv](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## AWS domain

Domain key: Aws

Cmdlets: `New-RscQueryAws` and `New-RscMutationAws`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| ArtifactsToDelete | Retrieves the AWS artifacts that need to be deleted when an account is being deleted. | `New-RscQueryAws -Operation ArtifactsToDelete`<BR> | [awsArtifactsToDelete](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| AvailabilityZonesByRegion | List of Availability Zones (AZs) in the specified region on the specified AWS Native account. | `New-RscQueryAws -Operation AvailabilityZonesByRegion`<BR> | [allAvailabilityZonesByRegionFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CdmVersions | Get all Rubrik CDM versions in the AWS marketplace. | `New-RscQueryAws -Operation CdmVersions`<BR> | [allAwsCdmVersions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountConfigs | List of all AWS cloud account configurations with the given search query. | `New-RscQueryAws -Operation CloudAccountConfigs`<BR> | [allAwsCloudAccountConfigs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountListSecurityGroups | Retrieves a list of security groups in the specified cloud account and virtual private cloud (VPC). | `New-RscQueryAws -Operation CloudAccountListSecurityGroups`<BR> | [awsCloudAccountListSecurityGroups](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountListSubnets | Retrieves a list of subnets in the specified cloud account and virtual private cloud (VPC). | `New-RscQueryAws -Operation CloudAccountListSubnets`<BR> | [awsCloudAccountListSubnets](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountListVpcs | Retrieves a list of virtual private clouds (VPCs) in the specific cloud account. | `New-RscQueryAws -Operation CloudAccountListVpcs`<BR> | [awsCloudAccountListVpcs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountWithFeatures | List of AWS cloud accounts and the features for each account, classified by ID. | `New-RscQueryAws -Operation CloudAccountWithFeatures`<BR> | [awsCloudAccountWithFeatures](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountsWithFeatures | List of active AWS cloud accounts and the features for the accounts. A cloud account is an AWS account added to the Rubrik platform. | `New-RscQueryAws -Operation CloudAccountsWithFeatures`<BR> | [allAwsCloudAccountsWithFeatures](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ComputeSettings | Retrieve aws compute settings. | `New-RscQueryAws -Operation ComputeSettings`<BR> | [awsComputeSettings](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DbParameterGroupsByRegion | List of all DB parameter groups in a given region. Refers to container for engine configuration that applies to one or more DB Instances. For more information, see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_WorkingWithOptionGroups.html. | `New-RscQueryAws -Operation DbParameterGroupsByRegion`<BR> | [allDbParameterGroupsByRegionFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DbSubnetGroupsByRegion | All DB subnet groups in a given region. Refers to logical isolation of RDS on a network. For more information, see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_VPC.WorkingWithRDSInstanceinaVPC.html. | `New-RscQueryAws -Operation DbSubnetGroupsByRegion`<BR> | [allDbSubnetGroupsByRegionFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Ec2KeyPairsByRegion | List of all key pairs for a given region. A key pair, consisting of a public key and a private key, is a set of security credentials that you use to prove your identity when connecting to an EC2 instance. For more information, see https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html. | `New-RscQueryAws -Operation Ec2KeyPairsByRegion`<BR> | [allEc2KeyPairsByRegionFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExocomputeConfigs | List of all AWS exocompute configurations filtered by a cloud account ID or a cloud account name prefix. | `New-RscQueryAws -Operation ExocomputeConfigs`<BR> | [allAwsExocomputeConfigs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| InstanceProfileNames | All Rubrik CC-ES instance profiles in the AWS account. | `New-RscQueryAws -Operation InstanceProfileNames`<BR> | [allAwsInstanceProfileNames](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| IsS3BucketNameAvailable | Specifies whether an S3 bucket name is available for use in AWS or not. When true, the bucket name is available for use. | `New-RscQueryAws -Operation IsS3BucketNameAvailable`<BR> | [isAwsS3BucketNameAvailable](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| KmsEncryptionKeysByRegion | List of encryption keys in the specified region on the specified AWS Native account. All the encrytion keys listed are managed by AWS Key Management System (KMS). For more information, see https://aws.amazon.com/kms/. | `New-RscQueryAws -Operation KmsEncryptionKeysByRegion`<BR> | [allKmsEncryptionKeysByRegionFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| OptionGroupsByRegion | List of all RDS option groups in a given region. Refers to settings of how a particular option works for an RDS Instance. For more information, see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_WorkingWithOptionGroups.html. | `New-RscQueryAws -Operation OptionGroupsByRegion`<BR> | [allOptionGroupsByRegionFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PermissionPolicies | Retrieves the permissions policy for all the input features along with any AWS-managed policy ARNs which need to be attached to the roles. Each policy document can be used to create an AWS-managed policy which then needs to be attached to corresponding role. | `New-RscQueryAws -Operation PermissionPolicies`<BR> | [allAwsPermissionPolicies](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RdsInstanceDetails | Details of the RDS Instance in the AWS Native account. | `New-RscQueryAws -Operation RdsInstanceDetails`<BR> | [rdsInstanceDetailsFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Regions | All valid AWS regions for this cloud account. | `New-RscQueryAws -Operation Regions`<BR> | [allAwsRegions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| S3BucketStateForRecovery | Retrieves the versioning and object ACL state of the Amazon S3 bucket, which is required to initiate the recovery process. | `New-RscQueryAws -Operation S3BucketStateForRecovery`<BR> | [s3BucketStateForRecovery](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| S3Buckets | List of all S3 bucket names across regions for the AWS Native account. | `New-RscQueryAws -Operation S3Buckets`<BR> | [allS3BucketsFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| S3BucketsDetails | List of all S3 bucket details across regions for the AWS Native account. | `New-RscQueryAws -Operation S3BucketsDetails`<BR> | [allS3BucketsDetailsFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SupportedRdsDatabaseInstanceClasses | List of all the database instance classes supported by AWS RDS database for the provided DB engine and engine version. DB engine version is a optional argument, it can be ignored if we want to retrieve all the supported instance class for a DB engine irrespective of DB engine version. | `New-RscQueryAws -Operation SupportedRdsDatabaseInstanceClasses`<BR> | [allSupportedAwsRdsDatabaseInstanceClasses](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TrustPolicy | Retrieves the AWS trust policy that will be attached with each role (cross-account, exocompute, etc.) in the customer's environment. | `New-RscQueryAws -Operation TrustPolicy`<BR> | [awsTrustPolicy](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Vpcs | List of all Virtual Private Clouds (VPCs) in the AWS Native account. | `New-RscQueryAws -Operation Vpcs`<BR> | [allVpcsFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| VpcsByRegion | List of all Virtual Private Clouds (VPCs) in the AWS Native account, classified by region. | `New-RscQueryAws -Operation VpcsByRegion`<BR> | [allVpcsByRegionFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AddAuthenticationServerBasedCloudAccount | Validates and adds an authentication server-based AWS cloud account. When validation succeeds, the AWS cloud account is added and the features specified in the request are enabled. When validation fails, an error is not returned, but the cause of the failure is specified in the "message" field of the response object. | `New-RscMutationAws -Operation AddAuthenticationServerBasedCloudAccount`<BR> | [addAwsAuthenticationServerBasedCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| AddIamUserBasedCloudAccount | Adds an IAM user-based AWS cloud account and enables the features specified in the input after successful validation of the request. | `New-RscMutationAws -Operation AddIamUserBasedCloudAccount`<BR> | [addAwsIamUserBasedCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BulkDeleteCloudAccountWithoutCft | Deletes specified AWS cloud accounts without using CloudFormation Template (CFT). | `New-RscMutationAws -Operation BulkDeleteCloudAccountWithoutCft`<BR> | [bulkDeleteAwsCloudAccountWithoutCft](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateAccount | N/A | `New-RscMutationAws -Operation CreateAccount`<BR> | [createAwsAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateAutomaticTargetMapping | N/A | `New-RscMutationAws -Operation CreateAutomaticTargetMapping`<BR> | [createAutomaticAwsTargetMapping](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateCloudNativeStorageSetting | N/A | `New-RscMutationAws -Operation CreateCloudNativeStorageSetting`<BR> | [createCloudNativeAwsStorageSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateCluster | Create a Rubrik Cloud Cluster on AWS. | `New-RscMutationAws -Operation CreateCluster`<BR> | [createAwsCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateComputeSetting | N/A | `New-RscMutationAws -Operation CreateComputeSetting`<BR> | [createAwsComputeSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateExocomputeConfigs | Create AWS Exocompute configs. | `New-RscMutationAws -Operation CreateExocomputeConfigs`<BR> | [createAwsExocomputeConfigs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateReaderTarget | Create a reader type for AWS archival location on a Rubrik cluster. | `New-RscMutationAws -Operation CreateReaderTarget`<BR> | [createAwsReaderTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateTarget | N/A | `New-RscMutationAws -Operation CreateTarget`<BR> | [createAwsTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteComputeSetting | N/A | `New-RscMutationAws -Operation DeleteComputeSetting`<BR> | [deleteAwsComputeSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteExocomputeConfigs | Deletes AWS Exocompute configs. | `New-RscMutationAws -Operation DeleteExocomputeConfigs`<BR> | [deleteAwsExocomputeConfigs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| FinalizeCloudAccountDeletion | Process and finalize deletion of cloud account is the last step in deletion of a feature from cloud account. This endpoint is a MUST for deletion of disconnected features. | `New-RscMutationAws -Operation FinalizeCloudAccountDeletion`<BR> | [finalizeAwsCloudAccountDeletion](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| FinalizeCloudAccountProtection | Process cloud account. This is the second step after validate and create in addition of a feature for cloud account.The CloudFormation stack should be created after this step using the CloudFormation URL provided in the first step. | `New-RscMutationAws -Operation FinalizeCloudAccountProtection`<BR> | [finalizeAwsCloudAccountProtection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PatchAuthenticationServerBasedCloudAccount | Updates authentication server-based AWS cloud account. Use this mutation to update account details related to role name, certificates, features. The mutation can update one or more certificates associated to an account in a single request. All input fields except account identifier are optional so that any combination of account attributes can be updated in a single call. If none of the optional fields are provided in the input then no updates are performed, and the response does not contain any error message. | `New-RscMutationAws -Operation PatchAuthenticationServerBasedCloudAccount`<BR> | [patchAwsAuthenticationServerBasedCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PatchIamUserBasedCloudAccount | Updates IAM user-based AWS cloud account. Use this mutation to update account details access/secret keys, role ARN and regions. All input fields except account ID are optional so that any combination of account attributes can be updated in a single call. If none of the optional fields are provided in the input then no updates are performed, and the response does not contain any error message. | `New-RscMutationAws -Operation PatchIamUserBasedCloudAccount`<BR> | [patchAwsIamUserBasedCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PrepareCloudAccountDeletion | Prepare deletion of cloud account. This is the first step to delete AWS cloud account. It generated template for deletion of cloud account and does not change any state of account. | `New-RscMutationAws -Operation PrepareCloudAccountDeletion`<BR> | [prepareAwsCloudAccountDeletion](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PrepareFeatureUpdateForCloudAccount | Prepare manual update features to latest version. | `New-RscMutationAws -Operation PrepareFeatureUpdateForCloudAccount`<BR> | [prepareFeatureUpdateForAwsCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RegisterFeatureArtifacts | Registers the AWS account artifacts such as roles in RSC backend while onboarding AWS account in manual flow. | `New-RscMutationAws -Operation RegisterFeatureArtifacts`<BR> | [registerAwsFeatureArtifacts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartExocomputeDisableJob | Starts a job to disable AWS Exocompute feature. When complete, the job will disable exocompute feature for the specified AWS Native account. | `New-RscMutationAws -Operation StartExocomputeDisableJob`<BR> | [startAwsExocomputeDisableJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateAccount | N/A | `New-RscMutationAws -Operation UpdateAccount`<BR> | [updateAwsAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateAutomaticTargetMapping | N/A | `New-RscMutationAws -Operation UpdateAutomaticTargetMapping`<BR> | [updateAutomaticAwsTargetMapping](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateCloudAccount | Update properties for a given AWS cloud account. | `New-RscMutationAws -Operation UpdateCloudAccount`<BR> | [updateAwsCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateCloudAccountFeature | Updates regions, stack ARN, and role ARN for a feature for a given cloud account. | `New-RscMutationAws -Operation UpdateCloudAccountFeature`<BR> | [updateAwsCloudAccountFeature](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateCloudNativeStorageSetting | N/A | `New-RscMutationAws -Operation UpdateCloudNativeStorageSetting`<BR> | [updateCloudNativeAwsStorageSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateComputeSetting | N/A | `New-RscMutationAws -Operation UpdateComputeSetting`<BR> | [updateAwsComputeSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateExocomputeConfigs | Update AWS Exocompute configs. | `New-RscMutationAws -Operation UpdateExocomputeConfigs`<BR> | [updateAwsExocomputeConfigs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateTarget | N/A | `New-RscMutationAws -Operation UpdateTarget`<BR> | [updateAwsTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpgradeCloudAccountFeaturesWithoutCft | Updates status of AWS cloud account features to connected if they are in update permissions state. This mutation should be used with caution. It should be invoked only after the latest required permissions are granted to the AWS cloud account user used by Rubrik. This mutation does not verify if the required permissions are actually granted to the user or not. Its usage is restricted to only IAM user-based and authentication server-based AWS cloud accounts. | `New-RscMutationAws -Operation UpgradeCloudAccountFeaturesWithoutCft`<BR> | [upgradeAwsCloudAccountFeaturesWithoutCft](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpgradeIamUserBasedCloudAccountPermissions | Set IAM user-based AWS account features status to Connected from Update Permissions state. It should be used by caution from cloud accounts only after latest required permissions are granted to authorized IAM user. | `New-RscMutationAws -Operation UpgradeIamUserBasedCloudAccountPermissions`<BR> | [upgradeAwsIamUserBasedCloudAccountPermissions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ValidateAndCreateCloudAccount | Validate and create AWS cloud account. If validation fails, no error is returned and the cause is present in the "message" field of return object or within admin/child accounts of return object. In case validation succeeds, it initiates creation of AWS cloud account. This is the first step to set up native protection. | `New-RscMutationAws -Operation ValidateAndCreateCloudAccount`<BR> | [validateAndCreateAwsCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## AWS Native domain

Domain key: AwsNative

Cmdlets: `New-RscQueryAwsNative` and `New-RscMutationAwsNative`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Account | Refers to the AWS Native account that serves as a container for all your AWS resources. The AWS Native account contains information about the metadata related to the AWS Native resources. | `New-RscQueryAwsNative -Operation Account`<BR> | [awsNativeAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Accounts | Paginated list of all AWS Native accounts. | `New-RscQueryAwsNative -Operation Accounts`<BR> | [awsNativeAccounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| AmiTypeForArchivedSnapshotExport | Amazon Machine Image (AMI) type for export of an archived EC2 Instance snapshot. For more information, see https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instances-and-amis.html. | `New-RscQueryAwsNative -Operation AmiTypeForArchivedSnapshotExport`<BR> | [amiTypeForAwsNativeArchivedSnapshotExport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| EbsVolume | Refers to the Amazon Elastic Block Store (EBS) Volume represented by a specific ID. For more information, see https://aws.amazon.com/ebs/. | `New-RscQueryAwsNative -Operation EbsVolume`<BR> | [awsNativeEbsVolume](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| EbsVolumes | Paginated list of all AWS EBS Volumes. | `New-RscQueryAwsNative -Operation EbsVolumes`<BR> | [awsNativeEbsVolumes](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| EbsVolumesByName | Paginated list of all AWS EBS Volumes by name or substring of name. | `New-RscQueryAwsNative -Operation EbsVolumesByName`<BR> | [awsNativeEbsVolumesByName](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Ec2Instance | Refers to Amazon Elastic Compute Cloud (EC2) Instance represented by a specific ID. For more information, see https://aws.amazon.com/ec2/. | `New-RscQueryAwsNative -Operation Ec2Instance`<BR> | [awsNativeEc2Instance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Ec2Instances | Paginated list of all AWS EC2 Instances. | `New-RscQueryAwsNative -Operation Ec2Instances`<BR> | [awsNativeEc2Instances](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Ec2InstancesByName | Paginated list of all AWS EC2 Instances by name or substring of name. | `New-RscQueryAwsNative -Operation Ec2InstancesByName`<BR> | [awsNativeEc2InstancesByName](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| IsEbsVolumeSnapshotRestorable | Specified whether an EBS volume is restorable. For an EBS Volume to be restorable, the volume should be able to replace where attached. | `New-RscQueryAwsNative -Operation IsEbsVolumeSnapshotRestorable`<BR> | [isAwsNativeEbsVolumeSnapshotRestorable](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| IsRdsInstanceLaunchConfigurationValid | Specifies whether the given DbInstance class, storage type, multi-az capability, encryption capability, iops value are supported for the given dbEngine, dbEngineVersion in the specified availability zone. When true, the specification is valid for a RDS Instance and can be used to create a new Instance. | `New-RscQueryAwsNative -Operation IsRdsInstanceLaunchConfigurationValid`<BR> | [isAwsNativeRdsInstanceLaunchConfigurationValid](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RdsExportDefaults | Refers to the default values for the export operation of the RDS DB Instance in the AWS Native account. | `New-RscQueryAwsNative -Operation RdsExportDefaults`<BR> | [awsNativeRdsExportDefaults](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RdsInstance | Refers to AWS Relational Database Service (RDS) represented by a specific ID. For more information, see https://aws.amazon.com/rds/. | `New-RscQueryAwsNative -Operation RdsInstance`<BR> | [awsNativeRdsInstance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RdsInstances | Paginated list of AWS RDS Instances on AWS Native account. | `New-RscQueryAwsNative -Operation RdsInstances`<BR> | [awsNativeRdsInstances](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RdsPointInTimeRestoreWindow | Point-in-Time (PiT) restore window of the RDS Instance in the AWS Native account. Refers to the range of time within which the database is available to be restored to a particular point in time. For more information,see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_PIT.html. | `New-RscQueryAwsNative -Operation RdsPointInTimeRestoreWindow`<BR> | [awsNativeRdsPointInTimeRestoreWindow](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Root | Root of AWS native hierarchy. | `New-RscQueryAwsNative -Operation Root`<BR> | [awsNativeRoot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| S3Bucket | Represents the Amazon S3 Bucket with a specific ID. For more information, see https://aws.amazon.com/s3/. | `New-RscQueryAwsNative -Operation S3Bucket`<BR> | [awsNativeS3Bucket](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ValidateRdsClusterNameForExport | Validates the name used for an RDS cluster during an export operation. Returns true if the RDS cluster name is valid. Returns false, with an error message, if the RDS cluster name validation fails. Returns false, without an error message for all other failures. | `New-RscQueryAwsNative -Operation ValidateRdsClusterNameForExport`<BR> | [validateAwsNativeRdsClusterNameForExport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ValidateRdsInstanceNameForExport | Validates the name used for an RDS Instance during an export operation. Returns true if the RDS Instance name is valid. Returns false, with an error message, if the RDS Instance name validation fails. Returns false, without an error message for all other failures. | `New-RscQueryAwsNative -Operation ValidateRdsInstanceNameForExport`<BR> | [validateAwsNativeRdsInstanceNameForExport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| ExcludeEbsVolumesFromSnapshot | Mark AWS Native EBS Volumes to be excluded from EC2 Instance snapshot. By default, all EBS Volumes are marked as included. | `New-RscMutationAwsNative -Operation ExcludeEbsVolumesFromSnapshot`<BR> | [excludeAwsNativeEbsVolumesFromSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartAccountDisableJob | Starts a job to disable a specific AWS Native account. When complete, the job will disable protection for the specified AWS Native account. | `New-RscMutationAwsNative -Operation StartAccountDisableJob`<BR> | [startAwsNativeAccountDisableJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartCreateEbsVolumeSnapshotsJob | Start job to create snapshots of EBS Volumes with given IDs. When completed, this will start taking an on-demand snapshot of the selected EBS Volumes  as per the SLA Policy assigned to the respective volumes. | `New-RscMutationAwsNative -Operation StartCreateEbsVolumeSnapshotsJob`<BR> | [startCreateAwsNativeEbsVolumeSnapshotsJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartEc2InstanceSnapshotsJob | Start an on demand create snapshot job for AWS EC2 Instances.When completed, this will start taking an on-demand snapshot of the selected EC2 Instances  as per the SLA Policy assigned to the respective instances. | `New-RscMutationAwsNative -Operation StartEc2InstanceSnapshotsJob`<BR> | [startAwsNativeEc2InstanceSnapshotsJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartExportEbsVolumeSnapshotJob | Start a job to export EBS Volume. The job creates a new EBS Volume with the same properties as that of the snapshot that is exported. | `New-RscMutationAwsNative -Operation StartExportEbsVolumeSnapshotJob`<BR> | [startExportAwsNativeEbsVolumeSnapshotJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartRdsInstanceSnapshotsJob | Start job to create snapshots of RDS Instance with given IDs. When completed, this will start taking an on-demand snapshot of the selected RDS Instances  as per the SLA Policy assigned to the respective instances. | `New-RscMutationAwsNative -Operation StartRdsInstanceSnapshotsJob`<BR> | [startAwsNativeRdsInstanceSnapshotsJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartRefreshAccountsJob | Start an on demand job to refresh AWS accounts. The job updates the Rubrik platform with changes to the AWS Native accounts. | `New-RscMutationAwsNative -Operation StartRefreshAccountsJob`<BR> | [startRefreshAwsNativeAccountsJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartRestoreEc2InstanceSnapshotJob | Start an on demand restore snapshot job for AWS EC2 Instance. When completed, this will replace the original EC2 Instance with the selected snapshot. | `New-RscMutationAwsNative -Operation StartRestoreEc2InstanceSnapshotJob`<BR> | [startRestoreAwsNativeEc2InstanceSnapshotJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Azure domain

Domain key: Azure

Cmdlets: `New-RscQueryAzure` and `New-RscMutationAzure`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AdDirectories | Lists all Azure AD directories for the account. | `New-RscQueryAzure -Operation AdDirectories`<BR> | [azureAdDirectories](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| AdDirectory | Details of the Azure AD corresponding to the workload ID. | `New-RscQueryAzure -Operation AdDirectory`<BR> | [azureAdDirectory](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| AdObjectsByType | Details of the Azure AD objects corresponding to the type. | `New-RscQueryAzure -Operation AdObjectsByType`<BR> | [azureAdObjectsByType](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ArmTemplatesByFeature | Retrieve ARM templates for role definition and role assignment. | `New-RscQueryAzure -Operation ArmTemplatesByFeature`<BR> | [allAzureArmTemplatesByFeature](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CdmVersions | Get all Rubrik CDM versions in the Azure marketplace. | `New-RscQueryAzure -Operation CdmVersions`<BR> | [allAzureCdmVersions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CheckPersistentStorageSubscriptionCanUnmap | Checks if we can unmap the archival location from the subscription. | `New-RscQueryAzure -Operation CheckPersistentStorageSubscriptionCanUnmap`<BR> | [checkAzurePersistentStorageSubscriptionCanUnmap](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountMissingPermissions | Retrieves a list of all the missing permissions on Azure subscriptions that are a part of the Azure Cloud Account. | `New-RscQueryAzure -Operation CloudAccountMissingPermissions`<BR> | [allAzureCloudAccountMissingPermissions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountPermissionConfig | Retrieves the configuration consisting of role permissions and feature policy version required for Azure subscription setup. Features refer to the Polaris features that the customer wants to be enabled on the cloud account. | `New-RscQueryAzure -Operation CloudAccountPermissionConfig`<BR> | [azureCloudAccountPermissionConfig](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountSubnetsByRegion | Retrieves all subnets in the specified region and subscription. Subnets allow you to choose IP address range of your choice. For more information, see https://docs.microsoft.com/en-us/azure/virtual-network/network-overview#virtual-network-and-subnets. | `New-RscQueryAzure -Operation CloudAccountSubnetsByRegion`<BR> | [allAzureCloudAccountSubnetsByRegion](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountSubscriptionWithFeatures | Retrieves the details of the Azure cloud account. | `New-RscQueryAzure -Operation CloudAccountSubscriptionWithFeatures`<BR> | [azureCloudAccountSubscriptionWithFeatures](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountSubscriptionsByFeature | Retrieves a list of all Azure Subscriptions with feature details such as feature, status, and regions. | `New-RscQueryAzure -Operation CloudAccountSubscriptionsByFeature`<BR> | [allAzureCloudAccountSubscriptionsByFeature](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountTenant | Retrieves the details of the Azure tenant and all the subscriptions of the tenant, for a feature. | `New-RscQueryAzure -Operation CloudAccountTenant`<BR> | [azureCloudAccountTenant](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountTenantWithExoConfigs | Retrieves details about the Azure cloud account tenant including the Exocompute configurations for the tenant subscriptions, for a specified feature. | `New-RscQueryAzure -Operation CloudAccountTenantWithExoConfigs`<BR> | [azureCloudAccountTenantWithExoConfigs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountTenants | Retrieves a list of all the Azure tenants and tenant subscriptions for features. The list can be filtered by feature status, subscription native ID, and subscription name. | `New-RscQueryAzure -Operation CloudAccountTenants`<BR> | [allAzureCloudAccountTenants](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DiskEncryptionSetsByRegion | List of all Azure Disk Encryption Sets in a region. | `New-RscQueryAzure -Operation DiskEncryptionSetsByRegion`<BR> | [allAzureDiskEncryptionSetsByRegion](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| EncryptionKeys | List of all Encryption Keys in an Azure Key Vault. | `New-RscQueryAzure -Operation EncryptionKeys`<BR> | [allAzureEncryptionKeys](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExocomputeConfigsInAccount | Retrieves a list of Azure Exocompute configurations filtered by a cloud account ID or a search query. | `New-RscQueryAzure -Operation ExocomputeConfigsInAccount`<BR> | [allAzureExocomputeConfigsInAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| HasRelicAdSnapshot | Checks if Microsoft Entra ID has relic snapshots. | `New-RscQueryAzure -Operation HasRelicAdSnapshot`<BR> | [hasRelicAzureAdSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| HostedAzureRegions | Lists all Azure regions supported by the Rubrik-Hosted SaaS protection. | `New-RscQueryAzure -Operation HostedAzureRegions`<BR> | [allHostedAzureRegions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| IsStorageAccountNameAvailable | Specifies whether the given storage account name is valid and available in Azure to be assigned to a new storage account. When the value is true, the specified account name is available in Azure. | `New-RscQueryAzure -Operation IsStorageAccountNameAvailable`<BR> | [isAzureStorageAccountNameAvailable](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| KeyVaultsByRegion | List of all Azure Key Vaults in a region. | `New-RscQueryAzure -Operation KeyVaultsByRegion`<BR> | [allAzureKeyVaultsByRegion](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ManagedIdentities | List all managed identities for Azure resources. | `New-RscQueryAzure -Operation ManagedIdentities`<BR> | [allAzureManagedIdentities](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Nsgs | Get all available network security groups for Azure. | `New-RscQueryAzure -Operation Nsgs`<BR> | [allAzureNsgs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Regions | Gets the Azure regions for the given subscription. | `New-RscQueryAzure -Operation Regions`<BR> | [azureRegions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ResourceGroups | Retrieves a list og all resource groups in the specified account. | `New-RscQueryAzure -Operation ResourceGroups`<BR> | [allResourceGroupsFromAzure](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SearchAdSnapshot | Search for azureAdObjects in a snapshot. | `New-RscQueryAzure -Operation SearchAdSnapshot`<BR> | [searchAzureAdSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SqlDatabase | Retrieves an Azure SQL Database. Refers to the fully managed SQL database built for the cloud. For more information, see https://azure.microsoft.com/en-us/products/azure-sql/database/. | `New-RscQueryAzure -Operation SqlDatabase`<BR> | [azureSqlDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SqlDatabaseDbPointInTimeRestoreWindowFromAzure | Point-in-Time (PiT) restore window of the Azure SQL Database instance in the Azure native account. Refers to the range of time within which the database is available to be restored to a particular point in time. For more information, see https://azure.microsoft.com/en-in/blog/azure-sql-database-point-in-time-restore/. | `New-RscQueryAzure -Operation SqlDatabaseDbPointInTimeRestoreWindowFromAzure`<BR> | [azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SqlDatabaseServer | Retrieves an Azure SQL Database Server. Refers to the server that contains the Azure SQL Databases. For more information, see https://docs.microsoft.com/en-us/azure/azure-sql/database/logical-servers. | `New-RscQueryAzure -Operation SqlDatabaseServer`<BR> | [azureSqlDatabaseServer](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SqlDatabaseServerElasticPools | Retrieves the list of elastic pools available for a SQL Database Server.For more information, see https://docs.microsoft.com/en-us/azure/azure-sql/database/elastic-pool-overview. | `New-RscQueryAzure -Operation SqlDatabaseServerElasticPools`<BR> | [allAzureSqlDatabaseServerElasticPools](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SqlDatabaseServers | Retrieves a paginated list of all Azure SQL Database Servers. | `New-RscQueryAzure -Operation SqlDatabaseServers`<BR> | [azureSqlDatabaseServers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SqlDatabases | Retrieves a paginated list of all Azure SQL Databases. | `New-RscQueryAzure -Operation SqlDatabases`<BR> | [azureSqlDatabases](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SqlManagedInstanceDatabase | Retrieves an Azure SQL Managed Instance Database. Refers to the database engine compatible with the latest SQL Server (Enterprise Edition) database engine. For more information, see https://docs.microsoft.com/en-us/azure/azure-sql/managed-instance/sql-managed-instance-paas-overview. | `New-RscQueryAzure -Operation SqlManagedInstanceDatabase`<BR> | [azureSqlManagedInstanceDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SqlManagedInstanceDatabases | Retrieves a paginated list of all Azure SQL Managed Instance Databases. | `New-RscQueryAzure -Operation SqlManagedInstanceDatabases`<BR> | [azureSqlManagedInstanceDatabases](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure | Point-in-Time (PiT) restore window of the Azure SQL Managed Instance database in the Azure native account. Refers to the range of time within which the database is available to be restored to a particular point in time. For more information, see https://docs.microsoft.com/en-us/azure/azure-sql/managed-instance/point-in-time-restore?tabs=azure-portal. | `New-RscQueryAzure -Operation SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure`<BR> | [azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SqlManagedInstanceServer | Retrieves an Azure SQL Managed Instance Server. Refers to the server the Azure SQL Managed Instance Database is a part of. | `New-RscQueryAzure -Operation SqlManagedInstanceServer`<BR> | [azureSqlManagedInstanceServer](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SqlManagedInstanceServers | Retrieves a paginated list of all Azure SQL Managed Instance Servers. | `New-RscQueryAzure -Operation SqlManagedInstanceServers`<BR> | [azureSqlManagedInstanceServers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StorageAccounts | Gets the storage accounts for the given subscription. | `New-RscQueryAzure -Operation StorageAccounts`<BR> | [azureStorageAccounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StorageAccountsByRegion | List all Azure storage accounts by region. | `New-RscQueryAzure -Operation StorageAccountsByRegion`<BR> | [allAzureStorageAccountsByRegion](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Subnets | Gets the subnets for the given subscription. | `New-RscQueryAzure -Operation Subnets`<BR> | [azureSubnets](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SubscriptionWithExocomputeMappings | Retrieves a list of all Azure subscriptions with Exocompute subscription mapping. | `New-RscQueryAzure -Operation SubscriptionWithExocomputeMappings`<BR> | [allAzureSubscriptionWithExocomputeMappings](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Subscriptions | Gets the subscriptions for the given Azure tenant. | `New-RscQueryAzure -Operation Subscriptions`<BR> | [azureSubscriptions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| VNets | Gets the VNets for the given subscription. | `New-RscQueryAzure -Operation VNets`<BR> | [azureVNets](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ValidateCloudAccountExocomputeConfigurations | Validates if Azure subnets are correctly configured for running Azure Kubernetes Service (AKS) Clusters. When correctly configured, the Azure subnets allow the required region-specific outbound connectivity and do not overlap with Azure restricted IP Address Space. | `New-RscQueryAzure -Operation ValidateCloudAccountExocomputeConfigurations`<BR> | [validateAzureCloudAccountExocomputeConfigurations](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AddCloudAccount | Add the Azure Subscriptions cloud account for the given feature. | `New-RscMutationAzure -Operation AddCloudAccount`<BR> | [addAzureCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| AddCloudAccountExocomputeConfigurations | Add Exocompute configurations for an Azure Cloud Account. | `New-RscMutationAzure -Operation AddCloudAccountExocomputeConfigurations`<BR> | [addAzureCloudAccountExocomputeConfigurations](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| AddCloudAccountWithoutOauth | Add the Azure Subscription cloud account for the given feature without OAuth. | `New-RscMutationAzure -Operation AddCloudAccountWithoutOauth`<BR> | [addAzureCloudAccountWithoutOauth](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BackupAdDirectory | Backs up the Azure AD directory. | `New-RscMutationAzure -Operation BackupAdDirectory`<BR> | [backupAzureAdDirectory](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CompleteAdAppSetup | Completes the creation flow for an Azure AD app. | `New-RscMutationAzure -Operation CompleteAdAppSetup`<BR> | [completeAzureAdAppSetup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CompleteAdAppUpdate | Completes an update to the Azure AD directory app. | `New-RscMutationAzure -Operation CompleteAdAppUpdate`<BR> | [completeAzureAdAppUpdate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CompleteCloudAccountOauth | Complete the Azure OAuth flow and pass the authorization code. | `New-RscMutationAzure -Operation CompleteCloudAccountOauth`<BR> | [completeAzureCloudAccountOauth](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateAccount | N/A | `New-RscMutationAzure -Operation CreateAccount`<BR> | [createAzureAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateAutomaticTargetMapping | N/A | `New-RscMutationAzure -Operation CreateAutomaticTargetMapping`<BR> | [createAutomaticAzureTargetMapping](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateCloudNativeRcvStorageSetting | Create Rubrik Cloud Vault storage settings for archiving azure cloud native protected objects. | `New-RscMutationAzure -Operation CreateCloudNativeRcvStorageSetting`<BR> | [createCloudNativeRcvAzureStorageSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateCloudNativeStorageSetting | Creates Storage Settings for the archival of azure cloud native protected objects | `New-RscMutationAzure -Operation CreateCloudNativeStorageSetting`<BR> | [createCloudNativeAzureStorageSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateCluster | Create a Rubrik Cloud Cluster on Azure. | `New-RscMutationAzure -Operation CreateCluster`<BR> | [createAzureCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateReaderTarget | Creates reader type for Azure archival location on a CDM cluster. | `New-RscMutationAzure -Operation CreateReaderTarget`<BR> | [createAzureReaderTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateSaasAppAad | Create or get an Azure AAD application. | `New-RscMutationAzure -Operation CreateSaasAppAad`<BR> | [createAzureSaasAppAad](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateTarget | Creates an Azure archival target on the Rubrik cluster. | `New-RscMutationAzure -Operation CreateTarget`<BR> | [createAzureTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteAdDirectory | Deletes an Azure AD directory. | `New-RscMutationAzure -Operation DeleteAdDirectory`<BR> | [deleteAzureAdDirectory](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteCloudAccount | Delete the Azure Subscriptions cloud account for the given feature. | `New-RscMutationAzure -Operation DeleteCloudAccount`<BR> | [deleteAzureCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteCloudAccountExocomputeConfigurations | Delete Exocompute configurations for an Azure Cloud Account. | `New-RscMutationAzure -Operation DeleteCloudAccountExocomputeConfigurations`<BR> | [deleteAzureCloudAccountExocomputeConfigurations](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteCloudAccountWithoutOauth | Delete the Azure Subscriptions cloud account for the given feature without OAuth. | `New-RscMutationAzure -Operation DeleteCloudAccountWithoutOauth`<BR> | [deleteAzureCloudAccountWithoutOauth](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| MapCloudAccountExocomputeSubscription | Map Azure cloud accounts to an Exocompute subscription. | `New-RscMutationAzure -Operation MapCloudAccountExocomputeSubscription`<BR> | [mapAzureCloudAccountExocomputeSubscription](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| MapCloudAccountToPersistentStorageLocation | Map Azure cloud accounts to a persistent storage location. | `New-RscMutationAzure -Operation MapCloudAccountToPersistentStorageLocation`<BR> | [mapAzureCloudAccountToPersistentStorageLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| OauthConsentComplete | Completes an OAuth consent flow for Azure resource access. | `New-RscMutationAzure -Operation OauthConsentComplete`<BR> | [azureOauthConsentComplete](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| OauthConsentKickoff | Kicks off an OAuth consent flow for Azure resource access. | `New-RscMutationAzure -Operation OauthConsentKickoff`<BR> | [azureOauthConsentKickoff](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RestoreAdObjectsWithPasswords | Restores the Azure AD directory with multiple passwords. | `New-RscMutationAzure -Operation RestoreAdObjectsWithPasswords`<BR> | [restoreAzureAdObjectsWithPasswords](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SetCloudAccountCustomerAppCredentials | Set credentials for the customer application, for the tenant domain name. | `New-RscMutationAzure -Operation SetCloudAccountCustomerAppCredentials`<BR> | [setAzureCloudAccountCustomerAppCredentials](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartAdAppSetup | Initiates the Azure AD app creation workflow. | `New-RscMutationAzure -Operation StartAdAppSetup`<BR> | [startAzureAdAppSetup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartAdAppUpdate | Initiates an update to the Azure AD directory app. | `New-RscMutationAzure -Operation StartAdAppUpdate`<BR> | [startAzureAdAppUpdate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartCloudAccountOauth | Initiates a session before doing Azure OAuth flow. If a custom app is configured for the tenant, the client ID of the custom app is returned. Otherwise, the client ID of the default app is returned. | `New-RscMutationAzure -Operation StartCloudAccountOauth`<BR> | [startAzureCloudAccountOauth](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartDisableCloudAccountJob | Start on-demand jobs to disable the feature for the given Azure Cloud Accounts. When completed, the status of cloud account feature will change to Disabled and the feature will become eligible to be deleted. | `New-RscMutationAzure -Operation StartDisableCloudAccountJob`<BR> | [startDisableAzureCloudAccountJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartExportSqlDatabaseDbJob | Start a job to export Azure SQL Database. The job creates a new Azure SQL Database with the same properties as that of the instance that is exported. | `New-RscMutationAzure -Operation StartExportSqlDatabaseDbJob`<BR> | [startExportAzureSqlDatabaseDbJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartExportSqlManagedInstanceDbJob | Start a job to export Azure SQL Managed Instance database. The job creates a new Azure SQL Managed Instance database with the same properties as that of the instance that is exported. | `New-RscMutationAzure -Operation StartExportSqlManagedInstanceDbJob`<BR> | [startExportAzureSqlManagedInstanceDbJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UnmapCloudAccountExocomputeSubscription | Unmap Azure cloud accounts from the mapped Exocompute subscription. | `New-RscMutationAzure -Operation UnmapCloudAccountExocomputeSubscription`<BR> | [unmapAzureCloudAccountExocomputeSubscription](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UnmapPersistentStorageSubscription | Unmaps the archival location from the subscription. | `New-RscMutationAzure -Operation UnmapPersistentStorageSubscription`<BR> | [unmapAzurePersistentStorageSubscription](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateAccount | N/A | `New-RscMutationAzure -Operation UpdateAccount`<BR> | [updateAzureAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateAutomaticTargetMapping | N/A | `New-RscMutationAzure -Operation UpdateAutomaticTargetMapping`<BR> | [updateAutomaticAzureTargetMapping](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateCloudAccount | Update names of the Azure Subscriptions cloud account and regions for the given feature. | `New-RscMutationAzure -Operation UpdateCloudAccount`<BR> | [updateAzureCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateCloudNativeRcvStorageSetting | Updates an existing Rubrik Cloud Vault Storage Settings for the archival of azure cloud native protected objects. | `New-RscMutationAzure -Operation UpdateCloudNativeRcvStorageSetting`<BR> | [updateCloudNativeRcvAzureStorageSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateCloudNativeStorageSetting | N/A | `New-RscMutationAzure -Operation UpdateCloudNativeStorageSetting`<BR> | [updateCloudNativeAzureStorageSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateCustomerAppPermissionForSql | Updates the Azure app for the specified account in an idempotent manner to support Azure SQL Database and  Managed Instance Database authentication. | `New-RscMutationAzure -Operation UpdateCustomerAppPermissionForSql`<BR> | [updateCustomerAppPermissionForAzureSql](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateTarget | N/A | `New-RscMutationAzure -Operation UpdateTarget`<BR> | [updateAzureTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpgradeCloudAccount | Update permissions of the Azure Subscriptions cloud account for given feature. | `New-RscMutationAzure -Operation UpgradeCloudAccount`<BR> | [upgradeAzureCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpgradeCloudAccountPermissionsWithoutOauth | Set Azure Cloud Account feature status to Connected from Update Permissions state without any permission validation. It should be used by caution from cloud accounts which have been set up without using OAuth, only after adding the latest permissions that are required. | `New-RscMutationAzure -Operation UpgradeCloudAccountPermissionsWithoutOauth`<BR> | [upgradeAzureCloudAccountPermissionsWithoutOauth](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Azure Native domain

Domain key: AzureNative

Cmdlets: `New-RscQueryAzureNative` and `New-RscMutationAzureNative`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AvailabilitySetsByRegionFromAzure | Retrieves all availability sets in the specified region, resource group, and subscription. An availability set is a logical grouping of VMs to facilitate redundancy and availability. For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/availability-set-overview. | `New-RscQueryAzureNative -Operation AvailabilitySetsByRegionFromAzure`<BR> | [allAzureNativeAvailabilitySetsByRegionFromAzure](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DoesResourceGroupExist | Checks if a resource group with the specified name exists in the specified account. | `New-RscQueryAzureNative -Operation DoesResourceGroupExist`<BR> | [doesAzureNativeResourceGroupExist](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExportCompatibleDiskTypesByRegionFromAzure | Retrieves all supported disk types when exporting a specific snapshot. Not all disk types are supported in all the regions. For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/disks-types. | `New-RscQueryAzureNative -Operation ExportCompatibleDiskTypesByRegionFromAzure`<BR> | [allAzureNativeExportCompatibleDiskTypesByRegionFromAzure](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExportCompatibleVmSizesByRegionFromAzure | Retrieves all supported virtual machine (VM) sizes when exporting a particular snapshot. Not all VM sizes are supported in all the regions. For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/sizes. | `New-RscQueryAzureNative -Operation ExportCompatibleVmSizesByRegionFromAzure`<BR> | [allAzureNativeExportCompatibleVmSizesByRegionFromAzure](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| IsManagedDiskSnapshotRestorable | Specifies whether the Managed Disk snapshot is restorable or not. A managed disk is restorable when the restore settings of the Managed Disk are configured on the Azure portal and on the Rubrik platform. When the value is true, the managed disk snapshot is restorable. | `New-RscQueryAzureNative -Operation IsManagedDiskSnapshotRestorable`<BR> | [isAzureNativeManagedDiskSnapshotRestorable](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| IsSqlDatabaseSnapshotPersistent | Checks if an Azure SQL Database Snapshot or an Azure SQL Managed Instance Database Snapshot is a persistent snapshot. | `New-RscQueryAzureNative -Operation IsSqlDatabaseSnapshotPersistent`<BR> | [isAzureNativeSqlDatabaseSnapshotPersistent](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ManagedDisk | Retrieves an Azure Native Managed Disk that refers to the block storage designed to be used with Azure Virtual Machines. Some examples are: ultra disks, premium solid-state drives (SSD), standard SSDs, and standard hard disk drives (HDD). For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/managed-disks-overview. | `New-RscQueryAzureNative -Operation ManagedDisk`<BR> | [azureNativeManagedDisk](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ManagedDisks | Retrieves a paginated list of all Azure Native Managed Disks. | `New-RscQueryAzureNative -Operation ManagedDisks`<BR> | [azureNativeManagedDisks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ResourceGroup | Retrieves an Azure Native Resource Group. Refers to a collection of resources in which multiple Azure services can reside. | `New-RscQueryAzureNative -Operation ResourceGroup`<BR> | [azureNativeResourceGroup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ResourceGroups | Retrieves a paginated list of all Azure Native Resource Groups. | `New-RscQueryAzureNative -Operation ResourceGroups`<BR> | [azureNativeResourceGroups](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ResourceGroupsInfoIfExist | Retrieves a list of resource groups with the specified names which exist in the specified account. | `New-RscQueryAzureNative -Operation ResourceGroupsInfoIfExist`<BR> | [allAzureNativeResourceGroupsInfoIfExist](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Root | Root of Azure native hierarchy. | `New-RscQueryAzureNative -Operation Root`<BR> | [azureNativeRoot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SecurityGroupsByRegionFromAzure | Retrieves all security groups in the specified region and subscription. Security groups enable you to configure network security as a natural extension of an application's structure, allowing you to group virtual machines and define network security policies based on those groups. For more information, see https://docs.microsoft.com/en-us/azure/virtual-network/application-security-groups. | `New-RscQueryAzureNative -Operation SecurityGroupsByRegionFromAzure`<BR> | [allAzureNativeSecurityGroupsByRegionFromAzure](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StorageAccountsFromAzure | Retrieves list of all storage Accounts in a subscription. | `New-RscQueryAzureNative -Operation StorageAccountsFromAzure`<BR> | [allAzureNativeStorageAccountsFromAzure](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SubnetsByRegionFromAzure | Retrieves all subnets in the specified region and subscription. Subnets allow you to choose IP address range of your choice. For more information, see https://docs.microsoft.com/en-us/azure/virtual-network/network-overview#virtual-network-and-subnets. | `New-RscQueryAzureNative -Operation SubnetsByRegionFromAzure`<BR> | [allAzureNativeSubnetsByRegionFromAzure](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Subscription | Retrieves an Azure Native Subscription. Refers to the logical entity that provides entitlement to deploy and consume Azure resources. | `New-RscQueryAzureNative -Operation Subscription`<BR> | [azureNativeSubscription](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Subscriptions | Retrieves a paginated list of all Azure Native Subscriptions. | `New-RscQueryAzureNative -Operation Subscriptions`<BR> | [azureNativeSubscriptions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ValidateSqlDatabaseDbNameForExport | Validates the name used for an Sql Database during an export operation. Returns true if the database name is valid. Returns false, with an error message, if the database name validation fails. Returns false, without an error message for all other failures. | `New-RscQueryAzureNative -Operation ValidateSqlDatabaseDbNameForExport`<BR> | [validateAzureNativeSqlDatabaseDbNameForExport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ValidateSqlManagedInstanceDbNameForExport | Validates the name used for an Managed Instance Database during an export operation. Returns true if the database name is valid. Returns false, with an error message, if the database name validation fails. Returns false, without an error message for all other failures. | `New-RscQueryAzureNative -Operation ValidateSqlManagedInstanceDbNameForExport`<BR> | [validateAzureNativeSqlManagedInstanceDbNameForExport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| VirtualMachine | Retrieves an Azure Virtual Machine that refers to the Azure infrastructure as a service (IaaS) used to deploy persistent VMs. For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/. | `New-RscQueryAzureNative -Operation VirtualMachine`<BR> | [azureNativeVirtualMachine](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| VirtualMachineSizes | Retrieves all virtual machine (VM) sizes in the subscriptions protected by Rubrik that have been configured for protection. For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/sizes. | `New-RscQueryAzureNative -Operation VirtualMachineSizes`<BR> | [allAzureNativeVirtualMachineSizes](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| VirtualMachines | Retrieves a paginated list of all Azure Virtual Machines (VMs). | `New-RscQueryAzureNative -Operation VirtualMachines`<BR> | [azureNativeVirtualMachines](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| VirtualNetworks | Retrieves all virtual networks (VNets) in the protected subscriptions. VNet enables secure communication with other VNets, the internet, and on-premise networks. For more information, see https://docs.microsoft.com/en-us/azure/virtual-network/virtual-networks-overview. | `New-RscQueryAzureNative -Operation VirtualNetworks`<BR> | [allAzureNativeVirtualNetworks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| ExcludeManagedDisksFromSnapshot | Exclude the Managed Disks from snapshots, for the specified virtual machines. | `New-RscMutationAzureNative -Operation ExcludeManagedDisksFromSnapshot`<BR> | [excludeAzureNativeManagedDisksFromSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartCreateManagedDiskSnapshotsJob | Start a job to create snapshots of the Azure Native Managed Disks identified by the given IDs. When started, this will start taking an on-demand snapshot of the selected disks as per the SLA Policy assigned to the respective disks. | `New-RscMutationAzureNative -Operation StartCreateManagedDiskSnapshotsJob`<BR> | [startCreateAzureNativeManagedDiskSnapshotsJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartCreateVirtualMachineSnapshotsJob | Start a job to create a snapshot for the Azure Native virtual machine identified by the IDs. When started, this will start taking an on-demand snapshot of the selected VMs as per the SLA Policy assigned to the respective VMs. | `New-RscMutationAzureNative -Operation StartCreateVirtualMachineSnapshotsJob`<BR> | [startCreateAzureNativeVirtualMachineSnapshotsJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartDisableSubscriptionProtectionJob | Start a job to disable protection for a specified Azure subscription. | `New-RscMutationAzureNative -Operation StartDisableSubscriptionProtectionJob`<BR> | [startDisableAzureNativeSubscriptionProtectionJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartExportManagedDiskJob | Start a job to export the specified Azure Native Managed Disks to the desired destination. | `New-RscMutationAzureNative -Operation StartExportManagedDiskJob`<BR> | [startExportAzureNativeManagedDiskJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartExportVirtualMachineJob | Start a job to export the Azure native virtual machine for a specified snapshot to a specified destination. | `New-RscMutationAzureNative -Operation StartExportVirtualMachineJob`<BR> | [startExportAzureNativeVirtualMachineJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartRefreshSubscriptionsJob | Start a job to refresh Azure Native subscription for the given subscription IDs. When started, this job will update the Rubrik platform with any changes that have been done on Azure for the respective subscription. | `New-RscMutationAzureNative -Operation StartRefreshSubscriptionsJob`<BR> | [startRefreshAzureNativeSubscriptionsJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartRestoreVirtualMachineJob | Start a job to restore Azure Native virtual machine with the selected snapshot. When started, this will replace the original VM with the selected snapshot. | `New-RscMutationAzureNative -Operation StartRestoreVirtualMachineJob`<BR> | [startRestoreAzureNativeVirtualMachineJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Azure Office365 domain

Domain key: AzureO365

Cmdlets: `New-RscQueryAzureO365` and `New-RscMutationAzureO365`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| CheckNSGOutboundRules | Checks the NSG Outbound rules of the Azure resources. | `New-RscQueryAzureO365 -Operation CheckNSGOutboundRules`<BR> | [azureO365CheckNSGOutboundRules](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CheckNetworkSubnet | Checks the network subnet of the Azure resources. | `New-RscQueryAzureO365 -Operation CheckNetworkSubnet`<BR> | [azureO365CheckNetworkSubnet](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CheckResourceGroupName | Checks the resource group name. | `New-RscQueryAzureO365 -Operation CheckResourceGroupName`<BR> | [azureO365CheckResourceGroupName](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CheckStorageAccountAccessibility | Checks the accessibility of the storage account. | `New-RscQueryAzureO365 -Operation CheckStorageAccountAccessibility`<BR> | [azureO365CheckStorageAccountAccessibility](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CheckStorageAccountName | Checks the storage account name. | `New-RscQueryAzureO365 -Operation CheckStorageAccountName`<BR> | [azureO365CheckStorageAccountName](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CheckSubscriptionQuota | Checks the Azure subscription quota. | `New-RscQueryAzureO365 -Operation CheckSubscriptionQuota`<BR> | [azureO365CheckSubscriptionQuota](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CheckVirtualNetworkName | Checks the virtual network name. | `New-RscQueryAzureO365 -Operation CheckVirtualNetworkName`<BR> | [azureO365CheckVirtualNetworkName](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Exocompute | Gets the exocompute details of the given cluster. | `New-RscQueryAzureO365 -Operation Exocompute`<BR> | [azureO365Exocompute](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| GetAzureHostType | Retrieves the AzureHostType of the account. | `New-RscQueryAzureO365 -Operation GetAzureHostType`<BR> | [azureO365GetAzureHostType](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| GetNetworkSubnetUnusedAddr | Retrieves the unused addresses available in a subnet. | `New-RscQueryAzureO365 -Operation GetNetworkSubnetUnusedAddr`<BR> | [azureO365GetNetworkSubnetUnusedAddr](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ValidateUserRoles | Validates the user roles in the subscription. | `New-RscQueryAzureO365 -Operation ValidateUserRoles`<BR> | [azureO365ValidateUserRoles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| SetupExocompute | Sets up Exocompute for an O365 subscription. | `New-RscMutationAzureO365 -Operation SetupExocompute`<BR> | [setupAzureO365Exocompute](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Cassandra domain

Domain key: Cassandra

Cmdlets: `New-RscQueryCassandra` and `New-RscMutationCassandra`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| ColumnFamilies | Paginated list of cassandra column families. | `New-RscQueryCassandra -Operation ColumnFamilies`<BR> | [cassandraColumnFamilies](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ColumnFamily | Details of a cassandra column family. | `New-RscQueryCassandra -Operation ColumnFamily`<BR> | [cassandraColumnFamily](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ColumnFamilyRecoverableRange | Get Recoverable Range of a Cassandra Column Family. | `New-RscQueryCassandra -Operation ColumnFamilyRecoverableRange`<BR> | [cassandraColumnFamilyRecoverableRange](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ColumnFamilySchema | Get Schema of a Cassandra Column Family. | `New-RscQueryCassandra -Operation ColumnFamilySchema`<BR> | [cassandraColumnFamilySchema](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Keyspace | Details of a cassandra keyspace. | `New-RscQueryCassandra -Operation Keyspace`<BR> | [cassandraKeyspace](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Keyspaces | Paginated list of cassandra keyspaces. | `New-RscQueryCassandra -Operation Keyspaces`<BR> | [cassandraKeyspaces](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Source | Details of a cassandra source. | `New-RscQueryCassandra -Operation Source`<BR> | [cassandraSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Sources | Paginated list of cassandra sources. | `New-RscQueryCassandra -Operation Sources`<BR> | [cassandraSources](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| BulkDeleteSources | Bulk Delete cassandra sources. | `New-RscMutationCassandra -Operation BulkDeleteSources`<BR> | [bulkDeleteCassandraSources](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateSource | Create a cassandra source. | `New-RscMutationCassandra -Operation CreateSource`<BR> | [createCassandraSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteSource | Delete a cassandra source. | `New-RscMutationCassandra -Operation DeleteSource`<BR> | [deleteCassandraSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RecoverSource | Recover a cassandra source. | `New-RscMutationCassandra -Operation RecoverSource`<BR> | [recoverCassandraSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateSource | Update a cassandra source. | `New-RscMutationCassandra -Operation UpdateSource`<BR> | [updateCassandraSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Certificates domain

Domain key: Certificate

Cmdlets: `New-RscQueryCertificate` and `New-RscMutationCertificate`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Certificate | Browse certificates. | `New-RscQueryCertificate -Operation Certificate`<BR> | [certificates](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Cluster | Get all certificates  
  
Supported in v5.1+  
Get all certificates. | `New-RscQueryCertificate -Operation Cluster`<BR> | [clusterCertificates](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ClusterWebSigned | Get the signed certificate for Web server  
  
Supported in v5.2+  
If the web server uses a signed certificate, fetch it. | `New-RscQueryCertificate -Operation ClusterWebSigned`<BR> | [clusterWebSignedCertificate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SigningRequest | Get Certificate Signing Request (CSR). | `New-RscQueryCertificate -Operation SigningRequest`<BR> | [certificateSigningRequest](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SigningRequests | Browse Certificate Signing Requests (CSRs). | `New-RscQueryCertificate -Operation SigningRequests`<BR> | [certificateSigningRequests](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| WithKey | Certificates having private key. | `New-RscQueryCertificate -Operation WithKey`<BR> | [certificatesWithKey](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AddClusterCertificate | Import a certificate  
  
Supported in v5.1+  
Import a certificate. | `New-RscMutationCertificate -Operation AddClusterCertificate`<BR> | [addClusterCertificate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Delete | Delete Certificate. | `New-RscMutationCertificate -Operation Delete`<BR> | [deleteCertificate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SetSso | Set User defined SSO certs. | `New-RscMutationCertificate -Operation SetSso`<BR> | [setSsoCertificate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SetWebSigned | Set a signed certificate for Web server  
  
Supported in v5.3+  
Setting the given certificate for each node's web server to use. | `New-RscMutationCertificate -Operation SetWebSigned`<BR> | [setWebSignedCertificate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Update | Edit Certificate. | `New-RscMutationCertificate -Operation Update`<BR> | [updateCertificate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateHost | N/A | `New-RscMutationCertificate -Operation UpdateHost`<BR> | [updateCertificateHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Cloud Account domain

Domain key: CloudAccount

Cmdlets: `New-RscQueryCloudAccount` and `New-RscMutationCloudAccount`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| CloudAccount | N/A | `New-RscQueryCloudAccount -Operation CloudAccount`<BR> | [cloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CurrentFeaturePermissions | Current permissions are the set of permissions the client has given to Rubrik. This will retrieve permissions for all the features currently active in the account. If these permissions are older than the latest set of permissions we require, the account will go in Update Permissions state | `New-RscQueryCloudAccount -Operation CurrentFeaturePermissions`<BR> | [allCurrentFeaturePermissionsForCloudAccounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExocomputeMappings | List the mappings from accounts to Exocompute cloud accounts with specified filters. | `New-RscQueryCloudAccount -Operation ExocomputeMappings`<BR> | [allCloudAccountExocomputeMappings](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| LatestFeaturePermissions | Latest Permissions are the most recent set of permissions we require for a feature. This will retrieve the permissions for all the features currently active in the accounts along with the features passed in the call. | `New-RscQueryCloudAccount -Operation LatestFeaturePermissions`<BR> | [allLatestFeaturePermissionsForCloudAccounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| MapExocomputeAccount | Map cloud accounts to an Exocompute account. | `New-RscMutationCloudAccount -Operation MapExocomputeAccount`<BR> | [mapCloudAccountExocomputeAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UnmapExocomputeAccount | Unmap cloud accounts from the mapped Exocompute account. | `New-RscMutationCloudAccount -Operation UnmapExocomputeAccount`<BR> | [unmapCloudAccountExocomputeAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Cloud Native domain

Domain key: CloudNative

Cmdlets: `New-RscQueryCloudNative` and `New-RscMutationCloudNative`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| CheckArchivedSnapshotsLocked | Archived snapshot locking related details for a workload. If no snapshots IDs are passed, all the expired source snapshots and the source snapshots that have a unexpired archival copy will be checked. | `New-RscQueryCloudNative -Operation CheckArchivedSnapshotsLocked`<BR> | [cloudNativeCheckArchivedSnapshotsLocked](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CheckLabelRuleNameUniqueness | Check if label rule name is unique or not | `New-RscQueryCloudNative -Operation CheckLabelRuleNameUniqueness`<BR> | [checkCloudNativeLabelRuleNameUniqueness](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CheckRequiredPermissionsForFeature | Queries whether Polaris has the required permissions for a particular feature. | `New-RscQueryCloudNative -Operation CheckRequiredPermissionsForFeature`<BR> | [cloudNativeCheckRequiredPermissionsForFeature](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CheckTagRuleNameUniqueness | Check if tag rule name is unique or not | `New-RscQueryCloudNative -Operation CheckTagRuleNameUniqueness`<BR> | [checkCloudNativeTagRuleNameUniqueness](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CustomerTags | Retrieves the list of all customer-specified tags and the corresponding value indicating whether resource tags should be overridden by customer-specified tags for a specific cloud type. | `New-RscQueryCloudNative -Operation CustomerTags`<BR> | [cloudNativeCustomerTags](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| FileRecoveryEligibleSnapshots | List of snapshots for which file recovery is feasible. | `New-RscQueryCloudNative -Operation FileRecoveryEligibleSnapshots`<BR> | [allCloudNativeFileRecoveryEligibleSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| IsFileRecoveryFeasible | List of snapshots with their file recovery feasibility status | `New-RscQueryCloudNative -Operation IsFileRecoveryFeasible`<BR> | [isCloudNativeFileRecoveryFeasible](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| LabelKeys | List of cloud native label keys matched by substring. | `New-RscQueryCloudNative -Operation LabelKeys`<BR> | [allCloudNativeLabelKeys](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| LabelRules | Cloud native label rules. | `New-RscQueryCloudNative -Operation LabelRules`<BR> | [cloudNativeLabelRules](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| LabelValues | List of cloud native label values matched by substring. | `New-RscQueryCloudNative -Operation LabelValues`<BR> | [allCloudNativeLabelValues](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RbaInstallers | Fetches the URLs for the windows, linux and debian RBA installers. | `New-RscQueryCloudNative -Operation RbaInstallers`<BR> | [cloudNativeRbaInstallers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SnapshotDetailsForRecovery | Details of snapshot types available for recovery. | `New-RscQueryCloudNative -Operation SnapshotDetailsForRecovery`<BR> | [cloudNativeSnapshotDetailsForRecovery](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SnapshotTypeDetails | Details of the available snapshot types. | `New-RscQueryCloudNative -Operation SnapshotTypeDetails`<BR> | [cloudNativeSnapshotTypeDetails](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Snapshots | List of all files and directories in a given path with the given prefix in name. | `New-RscQueryCloudNative -Operation Snapshots`<BR> | [cloudNativeSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SqlServerSetupScript | Returns the script to setup backup for a SQL Server database. | `New-RscQueryCloudNative -Operation SqlServerSetupScript`<BR> | [cloudNativeSqlServerSetupScript](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TagKeys | List of cloud native tag keys matched by substring. | `New-RscQueryCloudNative -Operation TagKeys`<BR> | [allCloudNativeTagKeys](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TagRules | Cloud native tag rules. | `New-RscQueryCloudNative -Operation TagRules`<BR> | [cloudNativeTagRules](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TagValues | List of cloud native tag values matched by substring. | `New-RscQueryCloudNative -Operation TagValues`<BR> | [allCloudNativeTagValues](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| WorkloadVersionedFiles | List all files and directories in a given snappable with the given prefix in name. | `New-RscQueryCloudNative -Operation WorkloadVersionedFiles`<BR> | [cloudNativeWorkloadVersionedFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AddSqlServerBackupCredentials | Add credentials for the user in the databases with authorization to perform backups. | `New-RscMutationCloudNative -Operation AddSqlServerBackupCredentials`<BR> | [addCloudNativeSqlServerBackupCredentials](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CheckRbaConnectivity | Check Rubrik Backup Agent (RBA) connectivity for the VMs. | `New-RscMutationCloudNative -Operation CheckRbaConnectivity`<BR> | [cloudNativeCheckRbaConnectivity](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ClearSqlServerBackupCredentials | Clear credentials for the user with authorization to perform database backups. Credentials are cleared from the object to which they were assigned directly. | `New-RscMutationCloudNative -Operation ClearSqlServerBackupCredentials`<BR> | [clearCloudNativeSqlServerBackupCredentials](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateLabelRule | Create cloud native label rule | `New-RscMutationCloudNative -Operation CreateLabelRule`<BR> | [createCloudNativeLabelRule](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateTagRule | Create cloud native tag rule | `New-RscMutationCloudNative -Operation CreateTagRule`<BR> | [createCloudNativeTagRule](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteLabelRule | Delete cloud native label rule. | `New-RscMutationCloudNative -Operation DeleteLabelRule`<BR> | [deleteCloudNativeLabelRule](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteTagRule | Delete cloud native tag rule. | `New-RscMutationCloudNative -Operation DeleteTagRule`<BR> | [deleteCloudNativeTagRule](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DownloadFiles | Download files from a cloud-native snapshot to a cloud download location or a virtual machine. | `New-RscMutationCloudNative -Operation DownloadFiles`<BR> | [cloudNativeDownloadFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SetupSqlServerBackup | Setup backups on the SQL Server databases using the admin credentials. | `New-RscMutationCloudNative -Operation SetupSqlServerBackup`<BR> | [setupCloudNativeSqlServerBackup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartSnapshotsIndexJob | Create index of cloudnative snapshots | `New-RscMutationCloudNative -Operation StartSnapshotsIndexJob`<BR> | [startCloudNativeSnapshotsIndexJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateIndexingStatus | Update indexing status for cloudnative snappables | `New-RscMutationCloudNative -Operation UpdateIndexingStatus`<BR> | [updateCloudNativeIndexingStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateLabelRule | Update cloud native label rule | `New-RscMutationCloudNative -Operation UpdateLabelRule`<BR> | [updateCloudNativeLabelRule](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateTagRule | Update cloud native tag rule | `New-RscMutationCloudNative -Operation UpdateTagRule`<BR> | [updateCloudNativeTagRule](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Cluster domain

Domain key: Cluster

Cmdlets: `New-RscQueryCluster` and `New-RscMutationCluster`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Cluster | A cluster object. | `New-RscQueryCluster -Operation Cluster`<BR> | [cluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Connected | List all connected clusters. | `New-RscQueryCluster -Operation Connected`<BR> | [allConnectedClusters](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DatabaseLogReport | Get the database log backup delay information  
  
Supported in v5.3+  
v5.3:   
v6.0+: Get the database log backup delay information. | `New-RscQueryCluster -Operation DatabaseLogReport`<BR> | [databaseLogReportForCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DatabaseLogReportingProperties | Get the database log backup report properties  
  
Supported in v5.3+  
Get the properties for the database (SQL and Oracle) log backup delay email notification creation. The properties are logDelayThresholdInMin and logDelayNotificationFrequencyInMin. | `New-RscQueryCluster -Operation DatabaseLogReportingProperties`<BR> | [databaseLogReportingPropertiesForCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DefaultGateway | Get current default gateway  
  
Supported in v5.0+  
Get current default gateway. | `New-RscQueryCluster -Operation DefaultGateway`<BR> | [clusterDefaultGateway](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Dns | Rubrik cluster DNS information. | `New-RscQueryCluster -Operation Dns`<BR> | [clusterDns](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| FloatingIps | Get a list of a cluster's always-available Ips  
  
Supported in v5.0+  
Get a list of a cluster's always-available Ips. | `New-RscQueryCluster -Operation FloatingIps`<BR> | [clusterFloatingIps](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| GroupByList | N/A | `New-RscQueryCluster -Operation GroupByList`<BR> | [clusterGroupByConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| HostFailover | Get details of the given host failover cluster. | `New-RscQueryCluster -Operation HostFailover`<BR> | [hostFailoverCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Ipmi | Get IPMI details  
  
Supported in v5.0+  
get IPMI details of availability and enabled access in the cluster. | `New-RscQueryCluster -Operation Ipmi`<BR> | [clusterIpmi](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Ipv6Mode | Rubrik cluster IPv6 mode. | `New-RscQueryCluster -Operation Ipv6Mode`<BR> | [clusterIpv6Mode](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| IsTotpAckNecessary | Checks whether acknowledgement of the Time-based, One-Time Password (TOTP) mandate is required for upgrading the Rubrik cluster version. | `New-RscQueryCluster -Operation IsTotpAckNecessary`<BR> | [isTotpAckNecessaryForCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| List | List of the available cluster objects. | `New-RscQueryCluster -Operation List`<BR> | [clusterConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| NetworkInterfaces | Get network interfaces for a Rubrik Cluster cluster  
  
Supported in v5.0+  
Retrieves network interfaces(including VLANs) on bond0/bond1. | `New-RscQueryCluster -Operation NetworkInterfaces`<BR> | [clusterNetworkInterfaces](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Nodes | Get list of nodes in this Rubrik cluster  
  
Supported in v5.0+  
Returns the list of all Rubrik nodes. | `New-RscQueryCluster -Operation Nodes`<BR> | [clusterNodes](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| NtpServers | Get NTP Servers  
  
Supported in v5.0+  
Retrieve a list of the NTP servers assigned to the Rubrik cluster. Encryption keys are not reported. | `New-RscQueryCluster -Operation NtpServers`<BR> | [clusterNtpServers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| OperationJobProgress | Get updates on the job progress of the Rubrik cluster operation. | `New-RscQueryCluster -Operation OperationJobProgress`<BR> | [clusterOperationJobProgress](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Proxy | Rubrik cluster proxy information. | `New-RscQueryCluster -Operation Proxy`<BR> | [clusterProxy](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RegistrationProductInfo | Info about the cluster product types the user is entitled to. | `New-RscQueryCluster -Operation RegistrationProductInfo`<BR> | [clusterRegistrationProductInfo](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ReplicationTargets | All replication targets for a cluster. | `New-RscQueryCluster -Operation ReplicationTargets`<BR> | [allClusterReplicationTargets](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ReportMigrationCount | Retrieve the counts of the Rubrik cluster reports migration. | `New-RscQueryCluster -Operation ReportMigrationCount`<BR> | [clusterReportMigrationCount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ReportMigrationJobStatus | Retrieve the status of the cluster report migration job. | `New-RscQueryCluster -Operation ReportMigrationJobStatus`<BR> | [clusterReportMigrationJobStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ReportMigrationStatus | Retrieve details of the Rubrik clusters' reports migration. | `New-RscQueryCluster -Operation ReportMigrationStatus`<BR> | [clusterReportMigrationStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TotpAckStatus | Checks whether acknowledgement of the Time-based, One-Time Password (TOTP) mandate is required for upgrading the Rubrik cluster version. | `New-RscQueryCluster -Operation TotpAckStatus`<BR> | [allClustersTotpAckStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TypeList | N/A | `New-RscQueryCluster -Operation TypeList`<BR> | [clusterTypeList](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Vlans | Rubrik cluster VLAN information. | `New-RscQueryCluster -Operation Vlans`<BR> | [clusterVlans](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| WebCertsAndIpmis | Get web server certificate and IPMI details for multiple clusters. | `New-RscQueryCluster -Operation WebCertsAndIpmis`<BR> | [allClusterWebCertsAndIpmis](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Windows | A Windows Cluster. | `New-RscQueryCluster -Operation Windows`<BR> | [windowsCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| WithUpgradesInfo | N/A | `New-RscQueryCluster -Operation WithUpgradesInfo`<BR> | [clusterWithUpgradesInfo](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AddNodesToCloud | Add nodes to cloud cluster. | `New-RscMutationCluster -Operation AddNodesToCloud`<BR> | [addNodesToCloudCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BulkDeleteFailover | Delete the provided failover clusters  
  
Supported in v5.3+  
Delete the provided failover clusters. | `New-RscMutationCluster -Operation BulkDeleteFailover`<BR> | [bulkDeleteFailoverCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateFailover | Create a failover cluster  
  
Supported in v5.2+  
Create a failover cluster. | `New-RscMutationCluster -Operation CreateFailover`<BR> | [createFailoverCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteFailover | Delete a failover cluster  
  
Supported in v5.2+  
Delete a failover cluster. | `New-RscMutationCluster -Operation DeleteFailover`<BR> | [deleteFailoverCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RecoverCloud | Recover a Rubrik Cloud Cluster. | `New-RscMutationCluster -Operation RecoverCloud`<BR> | [recoverCloudCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RegisterCloud | Register a cloud cluster. | `New-RscMutationCluster -Operation RegisterCloud`<BR> | [registerCloudCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RemoveCdm | N/A | `New-RscMutationCluster -Operation RemoveCdm`<BR> | [removeCdmCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateDatabaseLogReportingProperties | Update the database log backup report properties  
  
Supported in v5.3+  
Update the properties for the database (SQL and Oracle) log backup delay email notification creation. The properties are logDelayThresholdInMin and logDelayNotificationFrequencyInMin. | `New-RscMutationCluster -Operation UpdateDatabaseLogReportingProperties`<BR> | [updateDatabaseLogReportingPropertiesForCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateFailover | Update a failover cluster  
  
Supported in v5.2+  
Update failover cluster with specified properties. | `New-RscMutationCluster -Operation UpdateFailover`<BR> | [updateFailoverCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Db2 domain

Domain key: Db2

Cmdlets: `New-RscQueryDb2` and `New-RscMutationDb2`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Database | Details of a db2 database for a given fid. | `New-RscQueryDb2 -Operation Database`<BR> | [db2Database](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DatabaseJobStatus | Retrieve the status of a Db2 database job request  
  
Supported in v8.0+  
Retrieve details about a Db2 database-related request which includes the status of the database-related job. | `New-RscQueryDb2 -Operation DatabaseJobStatus`<BR> | [db2DatabaseJobStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Databases | Connection of filtered db2 databases based on specific filters. | `New-RscQueryDb2 -Operation Databases`<BR> | [db2Databases](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Instance | Details of a db2 instance for a given fid. | `New-RscQueryDb2 -Operation Instance`<BR> | [db2Instance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Instances | Connection of filtered db2 instances based on specific filters. | `New-RscQueryDb2 -Operation Instances`<BR> | [db2Instances](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| LogSnapshot | Details of a Db2 log snapshot for a given fid. | `New-RscQueryDb2 -Operation LogSnapshot`<BR> | [db2LogSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| LogSnapshots | Connection of all log snapshots for Db2. | `New-RscQueryDb2 -Operation LogSnapshots`<BR> | [db2LogSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RecoverableRange | Details of a Db2 recoverable range for a given fid. | `New-RscQueryDb2 -Operation RecoverableRange`<BR> | [db2RecoverableRange](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RecoverableRanges | Connection of all recoverable ranges for Db2. | `New-RscQueryDb2 -Operation RecoverableRanges`<BR> | [db2RecoverableRanges](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AddInstance | Mutation to add a new Db2 instance. | `New-RscMutationDb2 -Operation AddInstance`<BR> | [addDb2Instance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateOnDemandBackup | Create on demand database snapshot  
  
Supported in v8.0+  
Initiates a job to take an on demand, full snapshot of a specified Db2 database object. Use the GET /db2/db/request/{id} endpoint to monitor the progress of the job. | `New-RscMutationDb2 -Operation CreateOnDemandBackup`<BR> | [createOnDemandDb2Backup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteDatabase | Delete Db2 database  
  
Supported in v8.1+  
Deletes a Db2 database. | `New-RscMutationDb2 -Operation DeleteDatabase`<BR> | [deleteDb2Database](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteInstance | Mutation to delete existing Db2 instance. | `New-RscMutationDb2 -Operation DeleteInstance`<BR> | [deleteDb2Instance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DiscoverInstance | On-demand discovery of a Db2 instance  
  
Supported in v7.0+  
Initiates an on-demand job to discover a Db2 instance. | `New-RscMutationDb2 -Operation DiscoverInstance`<BR> | [discoverDb2Instance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DownloadSnapshot | Download Db2 database snapshot from archive  
  
Supported in v8.0+  
Downloads a specific Db2 database snapshot from the specified archival location. | `New-RscMutationDb2 -Operation DownloadSnapshot`<BR> | [downloadDb2Snapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DownloadSnapshotsForPointInTimeRecovery | Download Db2 database snapshots from archive for a point in time recovery  
  
Supported in v8.0+  
Downloads the most recent full snapshot and the log snapshots taken after the full snapshot, required for the point in time recovery of a Db2 database. | `New-RscMutationDb2 -Operation DownloadSnapshotsForPointInTimeRecovery`<BR> | [downloadDb2SnapshotsForPointInTimeRecovery](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExpireDownloadedSnapshots | Expire downloaded snapshots of a Db2 database  
  
Supported in v8.0+  
Requests an asynchronous job to expire all downloaded data and log snapshots. You can specify a begin time or an end time or both to provide a time range to expire only the downloaded data and log snapshots that were taken within the specified time range. The time is relative to when the snapshot was originally taken, not when it was downloaded. You can also configure a flag to expire only the log snapshots. | `New-RscMutationDb2 -Operation ExpireDownloadedSnapshots`<BR> | [expireDownloadedDb2Snapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PatchDatabase | Update a Db2 database  
  
Supported in v9.0+  
Updating a Db2 database involves modifying the metadata associated with the Db2 database using the provided input values. | `New-RscMutationDb2 -Operation PatchDatabase`<BR> | [patchDb2Database](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PatchInstance | Mutation to update an existing Db2 instance. | `New-RscMutationDb2 -Operation PatchInstance`<BR> | [patchDb2Instance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RefreshDatabase | On-demand refresh of a Db2 database  
  
Supported in v8.1+  
Initiates an on-demand job to refresh a Db2 database. Currently, this is allowed only for Db2 HADR databases. | `New-RscMutationDb2 -Operation RefreshDatabase`<BR> | [refreshDb2Database](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Report Download domain

Domain key: Download

Cmdlets: `New-RscQueryDownload` and `New-RscMutationDownload`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| CdmUpgradesPdf | Download cdm upgrades table pdf. | `New-RscQueryDownload -Operation CdmUpgradesPdf`<BR> | [downloadCdmUpgradesPdf](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| EdVersionList | N/A | `New-RscQueryDownload -Operation EdVersionList`<BR> | [downloadedVersionList](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PackageStatus | Get Status of download package job. | `New-RscQueryDownload -Operation PackageStatus`<BR> | [downloadPackageStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| ActiveDirectorySnapshotFromLocation | Download a snapshot from a remote target  
  
Supported in v9.0+  
Initiates a job to download a snapshot from the specified location when the snapshot does not exist locally. The specified location has to be a remote target connected to this Rubrik cluster. If an SLA Domain is not provided, the snapshot will be retained forever. | `New-RscMutationDownload -Operation ActiveDirectorySnapshotFromLocation`<BR> | [downloadActiveDirectorySnapshotFromLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| AuditLogCsvAsync | Download audit log in CSV format asynchronously. | `New-RscMutationDownload -Operation AuditLogCsvAsync`<BR> | [downloadAuditLogCsvAsync](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExchangeSnapshot | Download exchange database snapshot from archive  
  
Supported in v8.0+  
Downloads a Microsoft Exchange database snapshot from the specified archival location. | `New-RscMutationDownload -Operation ExchangeSnapshot`<BR> | [downloadExchangeSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| FilesetSnapshot | N/A | `New-RscMutationDownload -Operation FilesetSnapshot`<BR> | [downloadFilesetSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| FilesetSnapshotFromLocation | Download a snapshot from a replication target  
  
Supported in v7.0+  
Initiates a job to download a snapshot from the specified location when the snapshot does not exist locally. The specified location has to be a replication target connected to this Rubrik cluster. If an SLA Domain is not provided, the snapshot will be retained forever. | `New-RscMutationDownload -Operation FilesetSnapshotFromLocation`<BR> | [downloadFilesetSnapshotFromLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ObjectFilesCsv | Schedule a download CSV job for cross object files. | `New-RscMutationDownload -Operation ObjectFilesCsv`<BR> | [downloadObjectFilesCsv](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ObjectsListCsv | Schedule a download CSV job for objects list. | `New-RscMutationDownload -Operation ObjectsListCsv`<BR> | [downloadObjectsListCsv](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ReportCsvAsync | Download a report in CSV format asynchronously. | `New-RscMutationDownload -Operation ReportCsvAsync`<BR> | [downloadReportCsvAsync](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ReportPdfAsync | Download a report asynchronously in PDF format. | `New-RscMutationDownload -Operation ReportPdfAsync`<BR> | [downloadReportPdfAsync](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ResultsCsv | Download file results in CSV format. | `New-RscMutationDownload -Operation ResultsCsv`<BR> | [downloadResultsCsv](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SapHanaSnapshot | Download SAP HANA database snapshot from archive  
  
Supported in v8.0+  
Downloads a specific SAP HANA database snapshot from the specified archival location. | `New-RscMutationDownload -Operation SapHanaSnapshot`<BR> | [downloadSapHanaSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SapHanaSnapshotFromLocation | Download a snapshot from the remote location  
  
Supported in v8.1+  
Initiates a job to download a snapshot from the specified location when the snapshot does not exist locally. The specified location can be replication target or archival location. If SLA Domain is not selected, the snapshot will be retained forever. | `New-RscMutationDownload -Operation SapHanaSnapshotFromLocation`<BR> | [downloadSapHanaSnapshotFromLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SapHanaSnapshotsForPointInTimeRecovery | Download SAP HANA database snapshots from archive for a point in time recovery  
  
Supported in v8.0+  
Downloads the most recent full snapshot and the log snapshots taken after the full snapshot, required for the point in time recovery of an SAP HANA database. | `New-RscMutationDownload -Operation SapHanaSnapshotsForPointInTimeRecovery`<BR> | [downloadSapHanaSnapshotsForPointInTimeRecovery](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SnapshotResultsCsv | Download snapshot policy results in CSV format. | `New-RscMutationDownload -Operation SnapshotResultsCsv`<BR> | [downloadSnapshotResultsCsv](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ThreatHuntCsv | Download threat hunt result in CSV format. | `New-RscMutationDownload -Operation ThreatHuntCsv`<BR> | [downloadThreatHuntCsv](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| VolumeGroupSnapshotFiles | Download files from Volume Group snapshot  
  
Supported in v5.0+  
Create a download files request. | `New-RscMutationDownload -Operation VolumeGroupSnapshotFiles`<BR> | [downloadVolumeGroupSnapshotFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| VolumeGroupSnapshotFromLocation | Download a snapshot from a replication target  
  
Supported in v7.0+  
Initiates a job to download a snapshot from the specified location when the snapshot does not exist locally. The specified location has to be a replication target connected to this Rubrik cluster. If an SLA Domain is not provided, the snapshot will be retained forever. | `New-RscMutationDownload -Operation VolumeGroupSnapshotFromLocation`<BR> | [downloadVolumeGroupSnapshotFromLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Microsoft Exchange domain

Domain key: Exchange

Cmdlets: `New-RscQueryExchange` and `New-RscMutationExchange`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Dag | Details of an Exchange DAG for a given fid. | `New-RscQueryExchange -Operation Dag`<BR> | [exchangeDag](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Dags | Connection of filtered Exchange DAGs based on specific filters. | `New-RscQueryExchange -Operation Dags`<BR> | [exchangeDags](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Database | Details of an Exchange Database for a given fid. | `New-RscQueryExchange -Operation Database`<BR> | [exchangeDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Databases | Connection of filtered Exchange Databases based on specific filters. | `New-RscQueryExchange -Operation Databases`<BR> | [exchangeDatabases](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| LiveMounts | Paginated list of Exchange Database live mounts. | `New-RscQueryExchange -Operation LiveMounts`<BR> | [exchangeLiveMounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Server | Details of an Exchange Server for a given fid. | `New-RscQueryExchange -Operation Server`<BR> | [exchangeServer](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Servers | Connection of filtered Exchange Servers based on specific filters. | `New-RscQueryExchange -Operation Servers`<BR> | [exchangeServers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| BulkUpdateDag | Update multiple Exchange DAGs  
  
Supported in v8.0+  
Update multiple Exchange DAGs with the specified properties. | `New-RscMutationExchange -Operation BulkUpdateDag`<BR> | [bulkUpdateExchangeDag](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateMount | Create a request to mount a Microsoft Exchange database snapshot  
  
Supported in v8.0+  
Create a request to mount a Microsoft Exchange database snapshot. | `New-RscMutationExchange -Operation CreateMount`<BR> | [createExchangeMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateOnDemandBackup | Take an on-demand backup of a Microsoft Exchange database  
  
Supported in v8.0+  
Takes an on-demand backup of a Microsoft Exchange database. The forceFullSnapshot property can be set to true to force a full snapshot. To check the result of the request, poll /exchange/request/{id}. | `New-RscMutationExchange -Operation CreateOnDemandBackup`<BR> | [createOnDemandExchangeBackup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteSnapshotMount | Request to delete a mount for the Microsoft Exchange database snapshot  
  
Supported in v8.0+  
Request to delete a mount for Microsoft Exchange database snapshot. | `New-RscMutationExchange -Operation DeleteSnapshotMount`<BR> | [deleteExchangeSnapshotMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Fileset domain

Domain key: Fileset

Cmdlets: `New-RscQueryFileset` and `New-RscMutationFileset`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Linux | Information about a Linux fileset. | `New-RscQueryFileset -Operation Linux`<BR> | [linuxFileset](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RequestStatus | Get details about an async request  
  
Supported in v5.0+  
Get details about a fileset related async request. | `New-RscQueryFileset -Operation RequestStatus`<BR> | [filesetRequestStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Share | Information about a NAS share fileset. | `New-RscQueryFileset -Operation Share`<BR> | [shareFileset](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Template | N/A | `New-RscQueryFileset -Operation Template`<BR> | [filesetTemplate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Templates | Get a summary of all fileset templates. | `New-RscQueryFileset -Operation Templates`<BR> | [filesetTemplates](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Windows | Information about a Windows fileset. | `New-RscQueryFileset -Operation Windows`<BR> | [windowsFileset](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| BulkCreate | N/A | `New-RscMutationFileset -Operation BulkCreate`<BR> | [bulkCreateFilesets](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BulkCreateTemplates | N/A | `New-RscMutationFileset -Operation BulkCreateTemplates`<BR> | [bulkCreateFilesetTemplates](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BulkDelete | Delete filesets  
  
Supported in v5.0+  
Delete filesets by specifying the fileset IDs. | `New-RscMutationFileset -Operation BulkDelete`<BR> | [bulkDeleteFileset](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BulkDeleteTemplate | Delete fileset templates  
  
Supported in v5.0+  
Deletes specfied fileset templates. Detaches and retains all associated filesets as independent filesets with the existing values. | `New-RscMutationFileset -Operation BulkDeleteTemplate`<BR> | [bulkDeleteFilesetTemplate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BulkUpdateTemplate | Modify fileset templates  
  
Supported in v5.0+  
Modify the values of specified fileset templates. | `New-RscMutationFileset -Operation BulkUpdateTemplate`<BR> | [bulkUpdateFilesetTemplate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RecoverFiles | Create restore job to restore multiple files/directories  
  
Supported in v5.0+  
Initiate a job to copy one or more file or folder from a fileset backup to the source host. Returns the job instance ID. | `New-RscMutationFileset -Operation RecoverFiles`<BR> | [filesetRecoverFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Google Cloud Platform domain

Domain key: Gcp

Cmdlets: `New-RscQueryGcp` and `New-RscMutationGcp`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| CloudAccountMissingPermissionsForAddition | Check GCP projects permissions for addition. | `New-RscQueryGcp -Operation CloudAccountMissingPermissionsForAddition`<BR> | [allGcpCloudAccountMissingPermissionsForAddition](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountProjectsByFeature | List of GCP projects configured for a feature. | `New-RscQueryGcp -Operation CloudAccountProjectsByFeature`<BR> | [allGcpCloudAccountProjectsByFeature](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountProjectsForOauth | List of GCP projects to add after successful authorization. | `New-RscQueryGcp -Operation CloudAccountProjectsForOauth`<BR> | [allGcpCloudAccountProjectsForOauth](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| FeaturePermissionsForCloudAccount | List of permissions required to enable the given feature. | `New-RscQueryGcp -Operation FeaturePermissionsForCloudAccount`<BR> | [allFeaturePermissionsForGcpCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| GetDefaultCredentialsServiceAccount | Returns the service account corresponding to global credentials. Return empty string if global credentials are absent | `New-RscQueryGcp -Operation GetDefaultCredentialsServiceAccount`<BR> | [gcpGetDefaultCredentialsServiceAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| NativeAvailableKmsCryptoKeys | List of GCP KMS Crypto keys accessible in the provided region. | `New-RscQueryGcp -Operation NativeAvailableKmsCryptoKeys`<BR> | [allGcpNativeAvailableKmsCryptoKeys](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| NativeCompatibleMachineTypes | List of compatible machine types for instance. | `New-RscQueryGcp -Operation NativeCompatibleMachineTypes`<BR> | [allGcpNativeCompatibleMachineTypes](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| NativeNetworks | List of networks available in a GCP project along with subnetworks and firewall rules. | `New-RscQueryGcp -Operation NativeNetworks`<BR> | [allGcpNativeNetworks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| NativeProjectsWithAccessibleNetworks | List of all the GCP projects with accessible networks in this service project. | `New-RscQueryGcp -Operation NativeProjectsWithAccessibleNetworks`<BR> | [allGcpNativeProjectsWithAccessibleNetworks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| NativeRegions | List of regions available to a GCP project along with zones. | `New-RscQueryGcp -Operation NativeRegions`<BR> | [allGcpNativeRegions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| NativeStoredMachineTypes | List of all the distinct machine types of the GCP instances stored with Polaris. | `New-RscQueryGcp -Operation NativeStoredMachineTypes`<BR> | [allGcpNativeStoredMachineTypes](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| NativeStoredMachineTypesInProject | List of all the distinct machine types of the GCP instances stored with Polaris. | `New-RscQueryGcp -Operation NativeStoredMachineTypesInProject`<BR> | [allGcpNativeStoredMachineTypesInProject](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| NativeStoredNetworkNames | List of all the distinct network names of the GCP instances stored with Polaris. | `New-RscQueryGcp -Operation NativeStoredNetworkNames`<BR> | [allGcpNativeStoredNetworkNames](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| NativeStoredNetworkNamesInProject | List of all the distinct network names of the GCP instances stored with Polaris. | `New-RscQueryGcp -Operation NativeStoredNetworkNamesInProject`<BR> | [allGcpNativeStoredNetworkNamesInProject](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| NativeStoredRegions | List of all the distinct regions of the GCP instances stored with Polaris. | `New-RscQueryGcp -Operation NativeStoredRegions`<BR> | [allGcpNativeStoredRegions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| NativeStoredRegionsInProject | List of all the distinct regions of the GCP instances stored with Polaris. | `New-RscQueryGcp -Operation NativeStoredRegionsInProject`<BR> | [allGcpNativeStoredRegionsInProject](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| CloudAccountAddManualAuthProject | Adds a new cloud account for the GCP project which is not already added. | `New-RscMutationGcp -Operation CloudAccountAddManualAuthProject`<BR> | [gcpCloudAccountAddManualAuthProject](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountAddProjects | Add cloud account for GCP projects for the given features. | `New-RscMutationGcp -Operation CloudAccountAddProjects`<BR> | [gcpCloudAccountAddProjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountDeleteProjects | Delete cloud account for the given GCP project cloud account IDs and feature. | `New-RscMutationGcp -Operation CloudAccountDeleteProjects`<BR> | [gcpCloudAccountDeleteProjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountOauthComplete | Complete the OAuth flow and pass the authorization code. | `New-RscMutationGcp -Operation CloudAccountOauthComplete`<BR> | [gcpCloudAccountOauthComplete](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountOauthInitiate | Initiate a session before doing Gcp OAuth flow. | `New-RscMutationGcp -Operation CloudAccountOauthInitiate`<BR> | [gcpCloudAccountOauthInitiate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountUpgradeProjects | Upgrade cloud account for the given GCP project cloud account IDs and feature. | `New-RscMutationGcp -Operation CloudAccountUpgradeProjects`<BR> | [gcpCloudAccountUpgradeProjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateReaderTarget | Creates reader type for GCP archival location on a CDM cluster. | `New-RscMutationGcp -Operation CreateReaderTarget`<BR> | [createGcpReaderTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateTarget | N/A | `New-RscMutationGcp -Operation CreateTarget`<BR> | [createGcpTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SetDefaultServiceAccountJwtConfig | Sets the default GCP service account authorization key. | `New-RscMutationGcp -Operation SetDefaultServiceAccountJwtConfig`<BR> | [gcpSetDefaultServiceAccountJwtConfig](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateTarget | N/A | `New-RscMutationGcp -Operation UpdateTarget`<BR> | [updateGcpTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpgradeCloudAccountPermissionsWithoutOauth | Set GCP Cloud Account feature status to Connected from Update Permissions state without any permission validation. It should be used by caution from cloud accounts which have been set up without using OAuth, only after adding the latest permissions that are required. | `New-RscMutationGcp -Operation UpgradeCloudAccountPermissionsWithoutOauth`<BR> | [upgradeGcpCloudAccountPermissionsWithoutOauth](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Google Cloud Platform Native domain

Domain key: GcpNative

Cmdlets: `New-RscQueryGcpNative` and `New-RscMutationGcpNative`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Disk | Get details of a GCP Disk | `New-RscQueryGcpNative -Operation Disk`<BR> | [gcpNativeDisk](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Disks | List of GCP disks. | `New-RscQueryGcpNative -Operation Disks`<BR> | [gcpNativeDisks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| GceInstance | Get details of a GCE Instance | `New-RscQueryGcpNative -Operation GceInstance`<BR> | [gcpNativeGceInstance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| GceInstances | List of GCE instances. | `New-RscQueryGcpNative -Operation GceInstances`<BR> | [gcpNativeGceInstances](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Project | Get details of a GCP Project | `New-RscQueryGcpNative -Operation Project`<BR> | [gcpNativeProject](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Projects | List of GCP projects. | `New-RscQueryGcpNative -Operation Projects`<BR> | [gcpNativeProjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StoredDiskLocations | lists distinct regions and zones of the GCP disks stored with Polaris | `New-RscQueryGcpNative -Operation StoredDiskLocations`<BR> | [gcpNativeStoredDiskLocations](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| DisableProject | Triggers GCP native disable project job for the given project ID. | `New-RscMutationGcpNative -Operation DisableProject`<BR> | [gcpNativeDisableProject](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExcludeDisksFromInstanceSnapshot | N/A | `New-RscMutationGcpNative -Operation ExcludeDisksFromInstanceSnapshot`<BR> | [gcpNativeExcludeDisksFromInstanceSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExportDisk | Triggers GCP native export disk job for the given disk snapshot. | `New-RscMutationGcpNative -Operation ExportDisk`<BR> | [gcpNativeExportDisk](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExportGceInstance | Triggers GCP native export instance job for the given GCE instance. | `New-RscMutationGcpNative -Operation ExportGceInstance`<BR> | [gcpNativeExportGceInstance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RefreshProjects | Trigger GCP native refresh project job for the given project IDs | `New-RscMutationGcpNative -Operation RefreshProjects`<BR> | [gcpNativeRefreshProjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RestoreGceInstance | Triggers GCP native restore instance job for the given snapshot Rubrik ID. | `New-RscMutationGcpNative -Operation RestoreGceInstance`<BR> | [gcpNativeRestoreGceInstance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Host domain

Domain key: Host

Cmdlets: `New-RscQueryHost` and `New-RscMutationHost`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Diagnosis | Get host availability statuses  
  
Supported in v5.0+  
Retrieve the availability status for each host registered with a specified Rubrik CDM instance. | `New-RscQueryHost -Operation Diagnosis`<BR> | [hostDiagnosis](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PhysicalHost | N/A | `New-RscQueryHost -Operation PhysicalHost`<BR> | [physicalHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PhysicalHosts | Get list of physical hosts. | `New-RscQueryHost -Operation PhysicalHosts`<BR> | [physicalHosts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Search | N/A | `New-RscQueryHost -Operation Search`<BR> | [searchHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Share | N/A | `New-RscQueryHost -Operation Share`<BR> | [hostShare](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Shares | Get all host shares. | `New-RscQueryHost -Operation Shares`<BR> | [hostShares](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| BulkDelete | N/A | `New-RscMutationHost -Operation BulkDelete`<BR> | [bulkDeleteHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BulkRefresh | Refresh multiple hosts with a single request. | `New-RscMutationHost -Operation BulkRefresh`<BR> | [bulkRefreshHosts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BulkRegister | Register hosts  
  
Supported in v5.0+  
Register hosts with Rubrik clusters. | `New-RscMutationHost -Operation BulkRegister`<BR> | [bulkRegisterHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BulkUpdate | N/A | `New-RscMutationHost -Operation BulkUpdate`<BR> | [bulkUpdateHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ChangeVfd | Install or uninstall volume filter driver on hosts. | `New-RscMutationHost -Operation ChangeVfd`<BR> | [changeVfdOnHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Refresh | N/A | `New-RscMutationHost -Operation Refresh`<BR> | [refreshHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Microsoft Hyper-V domain

Domain key: Hyperv

Cmdlets: `New-RscQueryHyperv` and `New-RscMutationHyperv`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Cluster | Details of the given Hyper-V Cluster. | `New-RscQueryHyperv -Operation Cluster`<BR> | [hypervCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| HostAsyncRequestStatus | Get Hyper-V host async request  
  
Supported in v5.0+  
Get details about a Hyper-V host related async request. | `New-RscQueryHyperv -Operation HostAsyncRequestStatus`<BR> | [hypervHostAsyncRequestStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Mounts | HyperV Live Mount Connection. | `New-RscQueryHyperv -Operation Mounts`<BR> | [hypervMounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Scvmm | Details of the given Hyper-V SCVMM. | `New-RscQueryHyperv -Operation Scvmm`<BR> | [hypervScvmm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ScvmmAsyncRequestStatus | Get Hyper-V SCVMM async request  
  
Supported in v5.0+  
Get details about a Hyper-V SCVMM related async request. | `New-RscQueryHyperv -Operation ScvmmAsyncRequestStatus`<BR> | [hypervScvmmAsyncRequestStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Scvmms | Paginated list of HyperV SCVMMs. | `New-RscQueryHyperv -Operation Scvmms`<BR> | [hypervScvmms](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Server | Details of the given Hyper-V Server. | `New-RscQueryHyperv -Operation Server`<BR> | [hypervServer](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Servers | Get summary of all the Hyper-V hosts  
  
Supported in v5.0+  
Get summary of all the Hyper-V hosts. | `New-RscQueryHyperv -Operation Servers`<BR> | [hypervServers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TopLevelDescendants | Paginated list of the highest-level HyperV Objects accessible by the current user. | `New-RscQueryHyperv -Operation TopLevelDescendants`<BR> | [hypervTopLevelDescendants](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UniqueServersCount | Count of unique HyperV Servers. | `New-RscQueryHyperv -Operation UniqueServersCount`<BR> | [uniqueHypervServersCount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| VirtualMachine | Details of the given Hyper-V Virtual Machine. | `New-RscQueryHyperv -Operation VirtualMachine`<BR> | [hypervVirtualMachine](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| VirtualMachineAsyncRequestStatus | Get VM async request details  
  
Supported in v5.0+  
Get details about a Hyper-V vm related async request. | `New-RscQueryHyperv -Operation VirtualMachineAsyncRequestStatus`<BR> | [hypervVirtualMachineAsyncRequestStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| VirtualMachines | Paginated list of HyperV Virtual Machines. | `New-RscQueryHyperv -Operation VirtualMachines`<BR> | [hypervVirtualMachines](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| VmDetail | HyperV Virtual Machine detail from CDM. | `New-RscQueryHyperv -Operation VmDetail`<BR> | [hypervVmDetail](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| BatchExportVm | Exports a snapshot from each member of a set of virtual machines  
  
Supported in v7.0+  
Export a snapshot from each member of a set of virtual machines. | `New-RscMutationHyperv -Operation BatchExportVm`<BR> | [batchExportHypervVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BatchInstantRecoverVm | Instantly recovers snapshots from multiple virtual machines  
  
Supported in v7.0+  
Instantly recovers a batch of snapshots from a group of specified virtual machines. | `New-RscMutationHyperv -Operation BatchInstantRecoverVm`<BR> | [batchInstantRecoverHypervVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BatchMountVm | Mount snapshots from multiple virtual machines  
  
Supported in v7.0+  
Mounts a batch of snapshots from a group of specified virtual machines. | `New-RscMutationHyperv -Operation BatchMountVm`<BR> | [batchMountHypervVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BatchOnDemandBackupVm | Takes bulk on-demand backup of Hyper-V virtual machines  
  
Supported in v9.0+  
Takes on-demand backup of multiple specified Hyper-V virtual machines. | `New-RscMutationHyperv -Operation BatchOnDemandBackupVm`<BR> | [batchOnDemandBackupHypervVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateVirtualMachineSnapshotMount | Create a live mount request  
  
Supported in v5.0+  
Create a live mount request with given configuration. | `New-RscMutationHyperv -Operation CreateVirtualMachineSnapshotMount`<BR> | [createHypervVirtualMachineSnapshotMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteAllSnapshots | Delete all snapshots of VM  
  
Supported in v5.0+  
Delete all snapshots of a virtual machine. | `New-RscMutationHyperv -Operation DeleteAllSnapshots`<BR> | [hypervDeleteAllSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteVirtualMachineSnapshot | Delete VM snapshot  
  
Supported in v5.0+  
Delete a snapshot by expiring it. Snapshot is expired only if it is a manual snapshot or a snapshot of an unprotected vm. | `New-RscMutationHyperv -Operation DeleteVirtualMachineSnapshot`<BR> | [deleteHypervVirtualMachineSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteVirtualMachineSnapshotMount | Requst to delete a live mount  
  
Supported in v5.0+  
Create a request to delete a live mount. | `New-RscMutationHyperv -Operation DeleteVirtualMachineSnapshotMount`<BR> | [deleteHypervVirtualMachineSnapshotMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DownloadSnapshotFromLocation | Download a snapshot from a replication target  
  
Supported in v7.0+  
Initiates a job to download a snapshot from the specified location when the snapshot does not exist locally. The specified location has to be a replication target connected to this Rubrik cluster. If an SLA Domain is not provided, the snapshot will be retained forever. | `New-RscMutationHyperv -Operation DownloadSnapshotFromLocation`<BR> | [downloadHypervSnapshotFromLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DownloadVirtualMachineSnapshot | Creates a download from archival request  
  
Supported in v5.0+  
Download a snapshot from archival. | `New-RscMutationHyperv -Operation DownloadVirtualMachineSnapshot`<BR> | [downloadHypervVirtualMachineSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DownloadVirtualMachineSnapshotFiles | Download files from a Hyper-V VM backup  
  
Supported in v5.0+  
Start an asynchronous job to download multiple files and folders from a specified Hyper-V VM backup. The response returns an asynchrounous request ID. Get the URL for downloading the ZIP file including the specific files/folders by sending a GET request to 'hyperv/vm/request/{id}'. | `New-RscMutationHyperv -Operation DownloadVirtualMachineSnapshotFiles`<BR> | [downloadHypervVirtualMachineSnapshotFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExportVirtualMachine | Export VM snapshot  
  
Supported in v5.0+  
Export snapshot of a vm. | `New-RscMutationHyperv -Operation ExportVirtualMachine`<BR> | [exportHypervVirtualMachine](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| InstantRecoverVirtualMachineSnapshot | Creates an instant recover request that restores a target VM from the given Rubrik-hosted-snapshot  
  
Supported in v5.0+  
The VM will be started with networking enabled. If the VM does not exist anymore, a new VM will be created. | `New-RscMutationHyperv -Operation InstantRecoverVirtualMachineSnapshot`<BR> | [instantRecoverHypervVirtualMachineSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| OnDemandSnapshot | Create on-demand VM snapshot  
  
Supported in v5.0+  
Create an on-demand snapshot for the given VM ID. | `New-RscMutationHyperv -Operation OnDemandSnapshot`<BR> | [hypervOnDemandSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RefreshScvmm | Refresh a given HyperV SCVMM. | `New-RscMutationHyperv -Operation RefreshScvmm`<BR> | [refreshHypervScvmm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RefreshServer | Refresh Hyper-V host metadata  
  
Supported in v5.0+  
Create a job to refresh the metadata for the specified Hyper-V host. | `New-RscMutationHyperv -Operation RefreshServer`<BR> | [refreshHypervServer](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RegisterAgentVirtualMachine | Register the agent installed in VM  
  
Supported in v5.0+  
Register the agent that installed in VM. | `New-RscMutationHyperv -Operation RegisterAgentVirtualMachine`<BR> | [registerAgentHypervVirtualMachine](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RegisterScvmm | Register HyperV SCVMM to Rubrik Cluster. | `New-RscMutationHyperv -Operation RegisterScvmm`<BR> | [registerHypervScvmm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RestoreVirtualMachineSnapshotFiles | Restore files from snapshot  
  
Supported in v5.0+  
Restore files from a snapshot to the original source location. | `New-RscMutationHyperv -Operation RestoreVirtualMachineSnapshotFiles`<BR> | [restoreHypervVirtualMachineSnapshotFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ScvmmDelete | Delete a given HyperV SCVMM. | `New-RscMutationHyperv -Operation ScvmmDelete`<BR> | [hypervScvmmDelete](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ScvmmUpdate | Update properties for a given HyperV SCVMM. | `New-RscMutationHyperv -Operation ScvmmUpdate`<BR> | [hypervScvmmUpdate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateVirtualMachine | Update VM  
  
Supported in v5.0+  
Update VM with specified properties. | `New-RscMutationHyperv -Operation UpdateVirtualMachine`<BR> | [updateHypervVirtualMachine](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateVirtualMachineSnapshotMount | Power a Live Mount on and off  
  
Supported in v5.0+  
Power a specified Live Mount virtual machine on or off. Pass **_true_** to power the virtual machine on and pass **_false_** to power the virtual machine off. | `New-RscMutationHyperv -Operation UpdateVirtualMachineSnapshotMount`<BR> | [updateHypervVirtualMachineSnapshotMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Kubernetes domain

Domain key: K8s

Cmdlets: `New-RscQueryK8s` and `New-RscMutationK8s`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AppManifest | Kubernetes Rubrik Backup Service manifest. | `New-RscQueryK8s -Operation AppManifest`<BR> | [k8sAppManifest](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Cluster | N/A | `New-RscQueryK8s -Operation Cluster`<BR> | [k8sCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Clusters | N/A | `New-RscQueryK8s -Operation Clusters`<BR> | [k8sClusters](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Namespace | N/A | `New-RscQueryK8s -Operation Namespace`<BR> | [k8sNamespace](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Namespaces | N/A | `New-RscQueryK8s -Operation Namespaces`<BR> | [k8sNamespaces](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ReplicaSnapshotInfos | Information of all replicas for a Kubernetes snapshot. | `New-RscQueryK8s -Operation ReplicaSnapshotInfos`<BR> | [allK8sReplicaSnapshotInfos](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SnapshotInfo | Kubernetes snapshot information. | `New-RscQueryK8s -Operation SnapshotInfo`<BR> | [k8sSnapshotInfo](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| ArchiveCluster | Archive a Kubernetes cluster. | `New-RscMutationK8s -Operation ArchiveCluster`<BR> | [archiveK8sCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateAgentManifest | Create a Rubrik Kubernetes agent manifest. | `New-RscMutationK8s -Operation CreateAgentManifest`<BR> | [createK8sAgentManifest](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateCluster | Add a Kubernetes cluster. | `New-RscMutationK8s -Operation CreateCluster`<BR> | [createK8sCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateNamespaceSnapshots | Snapshot Kubernetes Namespace. | `New-RscMutationK8s -Operation CreateNamespaceSnapshots`<BR> | [createK8sNamespaceSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExportNamespace | Export Kubernetes Namespace snapshot. | `New-RscMutationK8s -Operation ExportNamespace`<BR> | [exportK8sNamespace](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RefreshCluster | Refresh resources of a Kubernetes cluster. | `New-RscMutationK8s -Operation RefreshCluster`<BR> | [refreshK8sCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RestoreNamespace | Restores Kubernetes namespace snapshot. | `New-RscMutationK8s -Operation RestoreNamespace`<BR> | [restoreK8sNamespace](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## LDAP domain

Domain key: Ldap

Cmdlets: `New-RscQueryLdap` and `New-RscMutationLdap`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AuthorizedPrincipalList | Browse LDAP-authorized principals. | `New-RscQueryLdap -Operation AuthorizedPrincipalList`<BR> | [ldapAuthorizedPrincipalConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| IntegrationList | Browse LDAP integrations. | `New-RscQueryLdap -Operation IntegrationList`<BR> | [ldapIntegrationConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PrincipalList | Search LDAP Principals. | `New-RscQueryLdap -Operation PrincipalList`<BR> | [ldapPrincipalConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| DeletePrincipals | N/A | `New-RscMutationLdap -Operation DeletePrincipals`<BR> | [deleteLdapPrincipals](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RemoveIntegration | Remove LDAP integration. | `New-RscMutationLdap -Operation RemoveIntegration`<BR> | [removeLdapIntegration](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SetMfaSetting | Update the MFA settings for the given LDAP integration. Return true when the operation succeeds. | `New-RscMutationLdap -Operation SetMfaSetting`<BR> | [setLdapMfaSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateIntegration | Mutate LDAP integration. | `New-RscMutationLdap -Operation UpdateIntegration`<BR> | [updateLdapIntegration](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Microsoft 365 domain

Domain key: M365

Cmdlets: `New-RscQueryM365` and `New-RscMutationM365`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Regions | Retrieves the M365 regions for the organization. | `New-RscQueryM365 -Operation Regions`<BR> | [m365Regions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| BackupMailbox | Backup mailbox workload. | `New-RscMutationM365 -Operation BackupMailbox`<BR> | [backupM365Mailbox](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BackupOnedrive | Take on-demand snapshot for Onedrive. | `New-RscMutationM365 -Operation BackupOnedrive`<BR> | [backupM365Onedrive](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BackupSharepointDrive | Take on-demand snapshot for Sharepoint drive. | `New-RscMutationM365 -Operation BackupSharepointDrive`<BR> | [backupM365SharepointDrive](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BackupTeam | Take on-demand snapshot for Teams. | `New-RscMutationM365 -Operation BackupTeam`<BR> | [backupM365Team](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Managed Volume domain

Domain key: ManagedVolume

Cmdlets: `New-RscQueryManagedVolume` and `New-RscMutationManagedVolume`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| InventoryStats | Aggregated inventory information for Managed Volume. | `New-RscQueryManagedVolume -Operation InventoryStats`<BR> | [managedVolumeInventoryStats](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| LiveMounts | Paginated list of Live Mounts. | `New-RscQueryManagedVolume -Operation LiveMounts`<BR> | [managedVolumeLiveMounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ManagedVolume | Details of a Managed Volume Object. | `New-RscQueryManagedVolume -Operation ManagedVolume`<BR> | [managedVolume](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ManagedVolumes | Paginated list of Managed Volumes. | `New-RscQueryManagedVolume -Operation ManagedVolumes`<BR> | [managedVolumes](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Add | Create a Managed Volume  
  
Supported in v7.0+  
v7.0: Initiates an asynchronous job to create a Managed Volume stack.  
v8.0+: Start an asynchronous job to create a Managed Volume stack. | `New-RscMutationManagedVolume -Operation Add`<BR> | [addManagedVolume](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BeginSnapshot | Begin Managed Volume snapshot  
  
Supported in v7.0+  
Opens the Managed Volume for writes. All data written to the Managed Volume until the next end-snapshot call will be part of this snapshot. | `New-RscMutationManagedVolume -Operation BeginSnapshot`<BR> | [beginManagedVolumeSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Delete | Delete a Managed Volume  
  
Supported in v7.0+  
Delete a Managed Volume. | `New-RscMutationManagedVolume -Operation Delete`<BR> | [deleteManagedVolume](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteSnapshotExport | Delete an exported Managed Volume snapshot  
  
Supported in v7.0+  
Deletes an exported Managed Volume snapshot, identified by the snapshot ID. | `New-RscMutationManagedVolume -Operation DeleteSnapshotExport`<BR> | [deleteManagedVolumeSnapshotExport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DownloadFiles | Download files from a managed volume backup  
  
Supported in v5.0+  
Start an asynchronous job to download multiple files and folders from a specified managed volume backup. The response returns an asynchronous request ID. Get the URL for downloading the ZIP file including the specific files/folders by sending a GET request to 'managed-volume/request/{id}'. | `New-RscMutationManagedVolume -Operation DownloadFiles`<BR> | [downloadManagedVolumeFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DownloadFromLocation | Download a snapshot from a remote target  
  
Supported in v7.0+  
Initiates a job to download a snapshot from the specified  
location when the snapshot does not exist locally.  
The specified location has to be a remote target connected to this Rubrik cluster. | `New-RscMutationManagedVolume -Operation DownloadFromLocation`<BR> | [downloadManagedVolumeFromLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| EndSnapshot | End Managed Volume snapshot  
  
Supported in v7.0+  
Close a Managed Volume for writes. A snapshot will be created containing all writes since the last begin-snapshot call. | `New-RscMutationManagedVolume -Operation EndSnapshot`<BR> | [endManagedVolumeSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExportSnapshot | Create a request to export a snapshot  
  
Supported in v5.0+  
Export a managed volume snapshot as a share. | `New-RscMutationManagedVolume -Operation ExportSnapshot`<BR> | [exportManagedVolumeSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Resize | Resize managed volume  
  
Supported in v5.3+  
Resize the managed volume to a larger size. Once a volume size has been increased, it can not be decreased. | `New-RscMutationManagedVolume -Operation Resize`<BR> | [resizeManagedVolume](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TakeOnDemandSnapshot | Take an on-demand snapshot of an SLA Managed Volume  
  
Supported in v5.3+  
Create a job for an on-demand snapshot of an SLA Managed Volume. The response returns a request ID. To see the status of the request, poll 'managed-volume/request/{id}' with the request ID obtained in the response. | `New-RscMutationManagedVolume -Operation TakeOnDemandSnapshot`<BR> | [takeManagedVolumeOnDemandSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Update | Mutation to update an existing Managed Volume. | `New-RscMutationManagedVolume -Operation Update`<BR> | [updateManagedVolume](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Mongo DB domain

Domain key: Mongo

Cmdlets: `New-RscQueryMongo` and `New-RscMutationMongo`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| BulkRecoverableRange | Recoverable range for multiple Management Objects on NoSQL cluster. | `New-RscQueryMongo -Operation BulkRecoverableRange`<BR> | [mongodbBulkRecoverableRange](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BulkRecoverableRanges | Provides the bulk recoverable range for MongoDB object recovery, including data and log snapshots. | `New-RscQueryMongo -Operation BulkRecoverableRanges`<BR> | [mongoBulkRecoverableRanges](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Collection | Provides details for a MongoDB collection identified by the fid. | `New-RscQueryMongo -Operation Collection`<BR> | [mongoCollection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CollectionRecoverableRange | Recoverable Range of a MongoDB collection on NoSQL cluster. | `New-RscQueryMongo -Operation CollectionRecoverableRange`<BR> | [mongodbCollectionRecoverableRange](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Collections | Paginated list of MongoDB collections. | `New-RscQueryMongo -Operation Collections`<BR> | [mongoCollections](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Database | Provides details for a MongoDB database identified by the fid. | `New-RscQueryMongo -Operation Database`<BR> | [mongoDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Databases | Paginated list of MongoDB databases. | `New-RscQueryMongo -Operation Databases`<BR> | [mongoDatabases](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RecoverableRanges | Provides the point in time range for MongoDB object recovery. | `New-RscQueryMongo -Operation RecoverableRanges`<BR> | [mongoRecoverableRanges](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Source | Provides details for the MongoDB source cluster identified by the fid. | `New-RscQueryMongo -Operation Source`<BR> | [mongoSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Sources | Paginated list of MongoDB sources. | `New-RscQueryMongo -Operation Sources`<BR> | [mongoSources](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AddSource | Add a new MongoDB source  
  
Supported in v8.1+  
Adds a new MongoDB source to the Rubrik Cluster. | `New-RscMutationMongo -Operation AddSource`<BR> | [addMongoSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| AssignSlaToCollection | Assign SLA Domain to MongoDB collection objects  
  
Supported in v8.1+  
Assigns SLA Domain to the given MongoDB collection objects. | `New-RscMutationMongo -Operation AssignSlaToCollection`<BR> | [assignSlaToMongoDbCollection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BulkDeleteSources | Bulk Delete Sources  
  
Supported in m3.2.0-m4.2.0. | `New-RscMutationMongo -Operation BulkDeleteSources`<BR> | [bulkDeleteMongodbSources](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateSource | Register a new MongoDB source to NoSQL cluster.   
For MongoDB, the term "source" is usually used for either a replica set or a sharded cluster.  
For more info on MongoDB cluster, refer to: https://docs.mongodb.com/manual/introduction/. | `New-RscMutationMongo -Operation CreateSource`<BR> | [createMongodbSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteSource | Delete a MongoDB source  
  
Supported in v8.1+  
Deletes a specific MongoDB source. | `New-RscMutationMongo -Operation DeleteSource`<BR> | [deleteMongoSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DiscoverSource | Discover a MongoDB source on-demand  
  
Supported in v8.1+  
Initiates an on-demand job to discover a MongoDB source. | `New-RscMutationMongo -Operation DiscoverSource`<BR> | [discoverMongoSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PatchSource | Edit a MongoDB source  
  
Supported in v8.1+  
Edits the properties of a MongoDB source. Hosts, name, and type of MongoDB cannot be changed once added. | `New-RscMutationMongo -Operation PatchSource`<BR> | [patchMongoSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RecoverSource | Recover a MongoDB source from Rubrik CDM cluster. | `New-RscMutationMongo -Operation RecoverSource`<BR> | [recoverMongoSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RetryAddSource | Update a MongoDB source  
  
Supported in v8.1+  
Updates a MongoDB source details. You can use this endpoint for updating MongoDB source details when the request to add a source fails. | `New-RscMutationMongo -Operation RetryAddSource`<BR> | [retryAddMongoSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateSource | Modifies configuration for a registered MongoDB source in NoSQL cluster. | `New-RscMutationMongo -Operation UpdateSource`<BR> | [updateMongodbSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Mosaic domain

Domain key: Mosaic

Cmdlets: `New-RscQueryMosaic` and `New-RscMutationMosaic`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| BulkRecoveryRange | Get recoverable range for multiple Management Objects. | `New-RscQueryMosaic -Operation BulkRecoveryRange`<BR> | [mosaicBulkRecoveryRange](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Snapshots | List snapshots of a mosaic object. | `New-RscQueryMosaic -Operation Snapshots`<BR> | [mosaicSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Stores | List all stores on mosaic cluster. | `New-RscQueryMosaic -Operation Stores`<BR> | [mosaicStores](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Versions | List versions of a mosaic object. | `New-RscQueryMosaic -Operation Versions`<BR> | [mosaicVersions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AddStore | Add a New Store  
  
Supported in m3.2.0-m4.2.0  
Add a new store to Mosaic cluster. | `New-RscMutationMosaic -Operation AddStore`<BR> | [addMosaicStore](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteStore | Remove the store by store_name  
  
Supported in m3.2.0-m4.2.0  
Remove a store from Mosaic cluster. | `New-RscMutationMosaic -Operation DeleteStore`<BR> | [deleteMosaicStore](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateStore | Modify a store  
  
Supported in m3.2.0-m4.2.0. | `New-RscMutationMosaic -Operation UpdateStore`<BR> | [updateMosaicStore](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Microsoft SQL Server domain

Domain key: Mssql

Cmdlets: `New-RscQueryMssql` and `New-RscMutationMssql`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AvailabilityGroup | A Microsoft SQL Availability Group. | `New-RscQueryMssql -Operation AvailabilityGroup`<BR> | [mssqlAvailabilityGroup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CdmLogShippingTarget | A single Microsoft SQL log shipping target. | `New-RscQueryMssql -Operation CdmLogShippingTarget`<BR> | [cdmMssqlLogShippingTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CdmLogShippingTargets | Paginated list of Microsoft SQL log shipping target. | `New-RscQueryMssql -Operation CdmLogShippingTargets`<BR> | [cdmMssqlLogShippingTargets](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CompatibleInstances | Returns all compatible instances for export for the specified recovery time. | `New-RscQueryMssql -Operation CompatibleInstances`<BR> | [mssqlCompatibleInstances](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Database | A Microsoft SQL Database. | `New-RscQueryMssql -Operation Database`<BR> | [mssqlDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DatabaseLiveMounts | Paginated list of Microsoft SQL Database live mounts. | `New-RscQueryMssql -Operation DatabaseLiveMounts`<BR> | [mssqlDatabaseLiveMounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DatabaseMissedRecoverableRanges | List of missed recoverable ranges for a Microsoft SQL Database. | `New-RscQueryMssql -Operation DatabaseMissedRecoverableRanges`<BR> | [mssqlDatabaseMissedRecoverableRanges](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DatabaseMissedSnapshots | List of missed snapshots for a Microsoft SQL Database. | `New-RscQueryMssql -Operation DatabaseMissedSnapshots`<BR> | [mssqlDatabaseMissedSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DatabaseRestoreEstimate | Returns a size estimate for a restore, export, or mount. | `New-RscQueryMssql -Operation DatabaseRestoreEstimate`<BR> | [mssqlDatabaseRestoreEstimate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DatabaseRestoreFiles | Provides a list of database files to be restored for the specified restore or export operation. | `New-RscQueryMssql -Operation DatabaseRestoreFiles`<BR> | [allMssqlDatabaseRestoreFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Databases | Paginated list of Microsoft SQL Databases. | `New-RscQueryMssql -Operation Databases`<BR> | [mssqlDatabases](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DefaultProperties | The current default properties for Microsoft SQL databases. | `New-RscQueryMssql -Operation DefaultProperties`<BR> | [mssqlDefaultProperties](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Instance | A Microsoft SQL Instance. | `New-RscQueryMssql -Operation Instance`<BR> | [mssqlInstance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| LogShippingTargets | List of filtered Microsoft SQL log shipping targets. | `New-RscQueryMssql -Operation LogShippingTargets`<BR> | [mssqlLogShippingTargets](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RecoverableRanges | List of recoverable ranges for a Microsoft SQL Database. | `New-RscQueryMssql -Operation RecoverableRanges`<BR> | [mssqlRecoverableRanges](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TopLevelDescendants | Paginated list of the highest-level Microsoft SQL Objects accessible by the current user. | `New-RscQueryMssql -Operation TopLevelDescendants`<BR> | [mssqlTopLevelDescendants](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AssignSlaDomainProperties | Assign SLA domain properties to Mssql objects. | `New-RscMutationMssql -Operation AssignSlaDomainProperties`<BR> | [assignMssqlSlaDomainProperties](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| AssignSlaDomainPropertiesAsync | Assign SLA domain properties to Mssql objects. | `New-RscMutationMssql -Operation AssignSlaDomainPropertiesAsync`<BR> | [assignMssqlSlaDomainPropertiesAsync](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BrowseDatabaseSnapshot | List snapshots and logs from a Mssql Database. This endpoint is only used to fetch data, but uses a mutation instead of a query due to limitations with the CDM API. | `New-RscMutationMssql -Operation BrowseDatabaseSnapshot`<BR> | [browseMssqlDatabaseSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BulkCreateOnDemandBackup | Take a bulk on-demand backup of a Microsoft SQL Database. | `New-RscMutationMssql -Operation BulkCreateOnDemandBackup`<BR> | [bulkCreateOnDemandMssqlBackup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BulkUpdateDbs | Update multiple Microsoft SQL databases with the specified properties. | `New-RscMutationMssql -Operation BulkUpdateDbs`<BR> | [bulkUpdateMssqlDbs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateLiveMount | Create live mount of a Microsoft SQL Database. | `New-RscMutationMssql -Operation CreateLiveMount`<BR> | [createMssqlLiveMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateLogShippingConfiguration | Create log shipping configuration of a Microsoft SQL Database. | `New-RscMutationMssql -Operation CreateLogShippingConfiguration`<BR> | [createMssqlLogShippingConfiguration](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateOnDemandBackup | Take an on-demand backup of a Microsoft SQL Database | `New-RscMutationMssql -Operation CreateOnDemandBackup`<BR> | [createOnDemandMssqlBackup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteDbSnapshots | Delete snapshots of a Microsoft SQL Database. | `New-RscMutationMssql -Operation DeleteDbSnapshots`<BR> | [deleteMssqlDbSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteLiveMount | Delete a Live Mount of a SQL Server database  
  
Supported in v5.0+  
Create an async request to delete a Live Mount of a SQL Server database. Poll the task status by using /mssql/request/{id}. | `New-RscMutationMssql -Operation DeleteLiveMount`<BR> | [deleteMssqlLiveMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DownloadDatabaseBackupFiles | Downloads a list of snapshot and log backups from a Microsoft SQL database  
  
Supported in v5.2+  
Downloads a list of snapshot and log backups from a Microsoft SQL database. | `New-RscMutationMssql -Operation DownloadDatabaseBackupFiles`<BR> | [downloadMssqlDatabaseBackupFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DownloadDatabaseFilesFromArchivalLocation | Download Microsoft SQL Database backup files from archival location. | `New-RscMutationMssql -Operation DownloadDatabaseFilesFromArchivalLocation`<BR> | [downloadMssqlDatabaseFilesFromArchivalLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExportDatabase | Create a request to export a Microsoft SQL database. | `New-RscMutationMssql -Operation ExportDatabase`<BR> | [exportMssqlDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RestoreDatabase | Create a request to restore a Microsoft SQL database. | `New-RscMutationMssql -Operation RestoreDatabase`<BR> | [restoreMssqlDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TakeLogBackup | Take an on-demand log backup for a Microsoft SQL database. | `New-RscMutationMssql -Operation TakeLogBackup`<BR> | [takeMssqlLogBackup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateDefaultProperties | Update the default properties for Microsoft SQL databases. | `New-RscMutationMssql -Operation UpdateDefaultProperties`<BR> | [updateMssqlDefaultProperties](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateLogShippingConfiguration | Update log shipping configuration of a Microsoft SQL Database. | `New-RscMutationMssql -Operation UpdateLogShippingConfiguration`<BR> | [updateMssqlLogShippingConfiguration](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## NAS domain

Domain key: Nas

Cmdlets: `New-RscQueryNas` and `New-RscMutationNas`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Fileset | A NAS Fileset. | `New-RscQueryNas -Operation Fileset`<BR> | [nasFileset](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Namespace | A NAS Namespace. | `New-RscQueryNas -Operation Namespace`<BR> | [nasNamespace](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Namespaces | Paginated list of NAS Namespaces. | `New-RscQueryNas -Operation Namespaces`<BR> | [nasNamespaces](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Share | A NAS Share. | `New-RscQueryNas -Operation Share`<BR> | [nasShare](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| System | A NAS System. | `New-RscQueryNas -Operation System`<BR> | [nasSystem](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Systems | Paginated list of NAS Systems. | `New-RscQueryNas -Operation Systems`<BR> | [nasSystems](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TopLevelDescendants | Paginated list of the highest-level NAS Objects accessible by the current user. | `New-RscQueryNas -Operation TopLevelDescendants`<BR> | [nasTopLevelDescendants](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Volume | A NAS Volume. | `New-RscQueryNas -Operation Volume`<BR> | [nasVolume](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |

[Go to top](#)
## NFS domain

Domain key: Nfs

Cmdlets: `New-RscQueryNfs` and `New-RscMutationNfs`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| CreateReaderTarget | Creates reader type for NFS archival location on a CDM cluster. | `New-RscMutationNfs -Operation CreateReaderTarget`<BR> | [createNfsReaderTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateTarget | N/A | `New-RscMutationNfs -Operation CreateTarget`<BR> | [createNfsTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateTarget | N/A | `New-RscMutationNfs -Operation UpdateTarget`<BR> | [updateNfsTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Nutanix domain

Domain key: Nutanix

Cmdlets: `New-RscQueryNutanix` and `New-RscMutationNutanix`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| BrowseSnapshot | v5.0-v8.0: Lists all files in VM snapshot  
v8.1+: Lists all files in virtual machine snapshot  
  
Supported in v5.0+  
Lists all files and directories in a given path. | `New-RscQueryNutanix -Operation BrowseSnapshot`<BR> | [nutanixBrowseSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Category | Details of the given category. | `New-RscQueryNutanix -Operation Category`<BR> | [nutanixCategory](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CategoryValue | Details of the given category value. | `New-RscQueryNutanix -Operation CategoryValue`<BR> | [nutanixCategoryValue](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Cluster | A Nutanix Cluster. | `New-RscQueryNutanix -Operation Cluster`<BR> | [nutanixCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ClusterAsyncRequestStatus | Get Nutanix cluster async request  
  
Supported in v5.0+  
Get details about a Nutanix cluster-related async request. | `New-RscQueryNutanix -Operation ClusterAsyncRequestStatus`<BR> | [nutanixClusterAsyncRequestStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ClusterContainers | Get list of containers on this cluster  
  
Supported in v5.0+  
Query the nutanix cluster to get the list of containers, used for export purposes. | `New-RscQueryNutanix -Operation ClusterContainers`<BR> | [nutanixClusterContainers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ClusterNetworks | Get list of networks on this cluster  
  
Supported in v8.1+  
Retrieves the list of networks by querying the Nutanix cluster. The list of networks is used for restore purposes. | `New-RscQueryNutanix -Operation ClusterNetworks`<BR> | [nutanixClusterNetworks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Clusters | Paginated list of Nutanix Clusters. | `New-RscQueryNutanix -Operation Clusters`<BR> | [nutanixClusters](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Mounts | Nutanix Live Mount Connection. | `New-RscQueryNutanix -Operation Mounts`<BR> | [nutanixMounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PrismCentral | Details of the given Prism Central. | `New-RscQueryNutanix -Operation PrismCentral`<BR> | [nutanixPrismCentral](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PrismCentrals | Paginated list of Nutanix Prism Central objects. | `New-RscQueryNutanix -Operation PrismCentrals`<BR> | [nutanixPrismCentrals](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SearchVm | v5.0-v8.0: Search for file in Nutanix VM  
v8.1+: Search for file in Nutanix virtual machine  
  
Supported in v5.0+  
Search for a file within the Nutanix Virtual Machine. Search via full path prefix or filename prefix. | `New-RscQueryNutanix -Operation SearchVm`<BR> | [searchNutanixVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SnapshotDetail | Supported in v5.0+. Get Nutanix virtual machine snapshot details.  
 Retrieve detailed information about a snapshot. | `New-RscQueryNutanix -Operation SnapshotDetail`<BR> | [nutanixSnapshotDetail](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TopLevelDescendants | Paginated list of the highest-level Nutanix Objects accessible by the current user. | `New-RscQueryNutanix -Operation TopLevelDescendants`<BR> | [nutanixTopLevelDescendants](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Vm | A Nutanix Virtual Machine. | `New-RscQueryNutanix -Operation Vm`<BR> | [nutanixVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| VmAsyncRequestStatus | v5.0-v8.0: Get VM async request details  
v8.1+: Get virtual machine async request details  
  
Supported in v5.0+  
v5.0-v8.0: Get details about a Nutanix VM-related async request.  
v8.1+: Get details about a Nutanix virtual machine-related async request. | `New-RscQueryNutanix -Operation VmAsyncRequestStatus`<BR> | [nutanixVmAsyncRequestStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| VmMissedSnapshots | v5.0-v8.0: Get details about missed snapshots for a VM  
v8.1+: Get details about missed snapshots for a virtual machine  
  
Supported in v5.0+  
v5.0-v8.0: Retrieve the time of the day when the snapshots were missed specific to a vm.  
v8.1+: Retrieve the time of the day when the snapshots were missed specific to a virtual machine. | `New-RscQueryNutanix -Operation VmMissedSnapshots`<BR> | [nutanixVmMissedSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Vms | Paginated list of Nutanix Virtual Machines. | `New-RscQueryNutanix -Operation Vms`<BR> | [nutanixVms](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| BatchExportVm | Exports a snapshot from each member of a set of virtual machines  
  
Supported in v7.0+  
Export a snapshot from each member of a set of virtual machines. | `New-RscMutationNutanix -Operation BatchExportVm`<BR> | [batchExportNutanixVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BatchMountVm | Mount snapshots from multiple virtual machines  
  
Supported in v7.0+  
Mounts a batch of snapshots from a group of specified virtual machines. | `New-RscMutationNutanix -Operation BatchMountVm`<BR> | [batchMountNutanixVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BulkOnDemandSnapshotVm | Take an on-demand snapshot for selected Nutanix virtual machines  
  
Supported in v9.0+  
Take bulk backups for multiple Nutanix virtual machines. | `New-RscMutationNutanix -Operation BulkOnDemandSnapshotVm`<BR> | [bulkOnDemandSnapshotNutanixVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateCluster | Add Nutanix cluster  
  
Supported in v5.0+  
Create a Nutanix cluster object by providing an address and account credentials for Prism. Initiates an asynchronous job to establish a connection with the cluster and retrieve all metadata. Use GET /nutanix_cluster/{id}/status to check status. | `New-RscMutationNutanix -Operation CreateCluster`<BR> | [createNutanixCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateOnDemandBackup | v5.0-v8.0: Create on-demand VM snapshot  
v8.1+: Create on-demand virtual machine snapshot  
  
Supported in v5.0+  
v5.0-v5.3: Create an on-demand snapshot for the given VM ID  
v6.0-v8.0: Create an on-demand snapshot for the given VM ID.  
v8.1+: Create an on-demand snapshot for the given virtual machine ID. | `New-RscMutationNutanix -Operation CreateOnDemandBackup`<BR> | [createOnDemandNutanixBackup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreatePrismCentral | Add Nutanix Prism Central and it's corresponding Prism Elements  
  
Supported in v9.0+  
Create a Nutanix Prism Central object and refresh the Prism Elements present in it. | `New-RscMutationNutanix -Operation CreatePrismCentral`<BR> | [createNutanixPrismCentral](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteCluster | Remove Nutanix cluster  
  
Supported in v5.0+  
Initiates an asynchronous job to remove a Nutanix cluster object. The Nutanix cluster cannot have VMs mounted through the Rubrik cluster. | `New-RscMutationNutanix -Operation DeleteCluster`<BR> | [deleteNutanixCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteMountV1 | Remove a Live Mount of a Nutanix virtual machine snapshot  
  
Supported in v6.0+  
Initiates a request to remove a Live Mount of a Nutanix virtual machine snapshot identified by the ID of the Live Mount. | `New-RscMutationNutanix -Operation DeleteMountV1`<BR> | [deleteNutanixMountV1](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeletePrismCentral | Remove Nutanix Prism Central  
  
Supported in v9.0+  
Initiates an asynchronous job to remove a Nutanix Prism Central object. The Nutanix Clusters attached to the Prism Central cannot have Virtual Machines mounted through the Rubrik cluster. | `New-RscMutationNutanix -Operation DeletePrismCentral`<BR> | [deleteNutanixPrismCentral](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteSnapshot | v5.0-v8.0: Delete VM snapshot  
v8.1+: Delete virtual machine snapshot  
  
Supported in v5.0+  
v5.0-v8.0: Delete a snapshot by expiring it. Snapshot is expired only if it is a manual snapshot or a snapshot of an unprotected vm.  
v8.1+: Delete a snapshot by expiring it. Snapshot is expired only if it is a manual snapshot or a snapshot of an unprotected virtual machine. | `New-RscMutationNutanix -Operation DeleteSnapshot`<BR> | [deleteNutanixSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteSnapshots | v5.0-v8.0: Delete all snapshots of VM  
v8.1+: Delete all snapshots of virtual machine  
  
Supported in v5.0+  
Delete all snapshots of a virtual machine. | `New-RscMutationNutanix -Operation DeleteSnapshots`<BR> | [deleteNutanixSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DownloadFilesSnapshot | v5.0-v8.0: Download files from a Nutanix VM backup  
v8.1+: Download files from a Nutanix virtual machine backup  
  
Supported in v5.0+  
v5.0-v8.0: Start an asynchronous job to download multiple files and folders from a specified Nutanix VM backup. The response returns an asynchronous request ID. Get the URL for downloading the zip file including the specific files/folders by sending a GET request to 'nutanix/vm/request/{id}'.  
v8.1+: Start an asynchronous job to download multiple files and folders from a specified Nutanix virtual machine backup. The response returns an asynchronous request ID. Get the URL for downloading the zip file including the specific files/folders by sending a GET request to 'nutanix/vm/request/{id}'. | `New-RscMutationNutanix -Operation DownloadFilesSnapshot`<BR> | [downloadFilesNutanixSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DownloadSnapshot | Creates a download from archival request  
  
Supported in v5.0+  
Download a snapshot from archival. | `New-RscMutationNutanix -Operation DownloadSnapshot`<BR> | [downloadNutanixSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DownloadVmFromLocation | Download a snapshot from a replication target  
  
Supported in v7.0+  
Initiates a job to download a snapshot from the specified location when the snapshot does not exist locally. The specified location has to be a replication target connected to this Rubrik cluster. If an SLA Domain is not provided, the snapshot will be retained forever. | `New-RscMutationNutanix -Operation DownloadVmFromLocation`<BR> | [downloadNutanixVmFromLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExportSnapshot | v5.0-v8.0: Export VM snapshot  
v8.1+: Export virtual machine snapshot  
  
Supported in v5.0+  
v5.0-v8.0: Export snapshot of a vm.  
v8.1+: Export snapshot of a virtual machine. | `New-RscMutationNutanix -Operation ExportSnapshot`<BR> | [exportNutanixSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| MigrateMountV1 | Relocate a Nutanix virtual machine to another storage container  
  
Supported in v6.0+  
Initiate a request to migrate the virtual disks of a specified Nutanix Live Mount to another storage container. The destination storage container has been specified when the Live Mount was created. The Live Mount will be deleted when the relocation succeeds. | `New-RscMutationNutanix -Operation MigrateMountV1`<BR> | [migrateNutanixMountV1](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| MountSnapshotV1 | Initiate a Live Mount of a Nutanix virtual machine snapshot  
  
Supported in v6.0+  
Initiates a request to perform a Live Mount of a Nutanix virtual machine snapshot identified by the snapshot ID. | `New-RscMutationNutanix -Operation MountSnapshotV1`<BR> | [mountNutanixSnapshotV1](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PatchMountV1 | Change Nutanix Live Mount power status  
  
Supported in v6.0+  
Changes the power status of a mounted Nutanix virtual machine. | `New-RscMutationNutanix -Operation PatchMountV1`<BR> | [patchNutanixMountV1](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RefreshCluster | Refresh Nutanix cluster metadata  
  
Supported in v5.0+  
Create a job to refresh the metadata for the specified Nutanix cluster. | `New-RscMutationNutanix -Operation RefreshCluster`<BR> | [refreshNutanixCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RefreshPrismCentral | Refresh Nutanix Prism Central metadata  
  
Supported in v9.0+  
Initiates a job to refresh the metadata for the specified Nutanix Prism Central and all its associated clusters. | `New-RscMutationNutanix -Operation RefreshPrismCentral`<BR> | [refreshNutanixPrismCentral](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RegisterAgentVm | v5.0-v8.0: Register the agent installed on the Nutanix VM  
v8.1+: Register the agent installed on the Nutanix virtual machine  
  
Supported in v5.0+  
v5.0-v5.3: Register the agent installed on the Nutanix VM  
v6.0-v8.0: Register the agent installed on the Nutanix VM.  
v8.1+: Register the agent installed on the Nutanix virtual machine. | `New-RscMutationNutanix -Operation RegisterAgentVm`<BR> | [registerAgentNutanixVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RestoreFilesSnapshot | Restore files  
  
Supported in v5.0+  
Restore files from a snapshot to the source Nutanix virtual machine. | `New-RscMutationNutanix -Operation RestoreFilesSnapshot`<BR> | [restoreFilesNutanixSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateCluster | Patch Nutanix cluster  
  
Supported in v5.0+  
Patch the host, credentials, and/or CA certs of the specified Nutanix cluster object. | `New-RscMutationNutanix -Operation UpdateCluster`<BR> | [updateNutanixCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdatePrismCentral | Patch Nutanix Prism Central  
  
Supported in v9.0+  
Patch the host and credentials of Nutanix Prism Central. | `New-RscMutationNutanix -Operation UpdatePrismCentral`<BR> | [updateNutanixPrismCentral](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateVm | v5.0-v8.0: Patch VM  
v8.1+: Patch virtual machine  
  
Supported in v5.0+  
v5.0-v5.3: Patch VM with specified properties  
v6.0-v8.0: Patch VM with specified properties.  
v8.1+: Patch virtual machine with specified properties. | `New-RscMutationNutanix -Operation UpdateVm`<BR> | [updateNutanixVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Office 365 domain

Domain key: O365

Cmdlets: `New-RscQueryO365` and `New-RscMutationO365`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AdGroups | All AD Groups belonging to the O365 organization. | `New-RscQueryO365 -Operation AdGroups`<BR> | [allO365AdGroups](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BrowseTeamConvChannels | Browse channels in a Teams conversations snapshot. | `New-RscQueryO365 -Operation BrowseTeamConvChannels`<BR> | [browseO365TeamConvChannels](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Calendar | Details of the Exchange calendar pertaining to the snappable ID. | `New-RscQueryO365 -Operation Calendar`<BR> | [o365Calendar](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Groups | List of O365 Groups in the O365Org. | `New-RscQueryO365 -Operation Groups`<BR> | [o365Groups](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| License | Retrieve o365 licence details. | `New-RscQueryO365 -Operation License`<BR> | [o365License](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ListApps | Lists the O365 apps. | `New-RscQueryO365 -Operation ListApps`<BR> | [listO365Apps](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Mailbox | Details for the Exchange mailbox corresponding to the snappable ID. | `New-RscQueryO365 -Operation Mailbox`<BR> | [o365Mailbox](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Mailboxes | List of Mailboxes in the O365Org. | `New-RscQueryO365 -Operation Mailboxes`<BR> | [o365Mailboxes](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ObjectAncestors | N/A | `New-RscQueryO365 -Operation ObjectAncestors`<BR> | [o365ObjectAncestors](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Onedrive | Details for the OneDrive corresponding to the snappable ID. | `New-RscQueryO365 -Operation Onedrive`<BR> | [o365Onedrive](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Onedrives | List of Onedrives in the O365Org. | `New-RscQueryO365 -Operation Onedrives`<BR> | [o365Onedrives](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Org | Details of the O365Org. | `New-RscQueryO365 -Operation Org`<BR> | [o365Org](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| OrgAtSnappableLevel | Details of the O365Org at snappable level, given the snappable type. | `New-RscQueryO365 -Operation OrgAtSnappableLevel`<BR> | [o365OrgAtSnappableLevel](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| OrgStatuses | Gets the status of each org in the account. | `New-RscQueryO365 -Operation OrgStatuses`<BR> | [allO365OrgStatuses](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| OrgSummaries | N/A | `New-RscQueryO365 -Operation OrgSummaries`<BR> | [o365OrgSummaries](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Orgs | All O365 orgs for the account. | `New-RscQueryO365 -Operation Orgs`<BR> | [o365Orgs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ServiceAccount | Gets the service account for the given org. | `New-RscQueryO365 -Operation ServiceAccount`<BR> | [o365ServiceAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ServiceStatus | Returns the service status of the O365 service running on MSFT server. | `New-RscQueryO365 -Operation ServiceStatus`<BR> | [o365ServiceStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SharepointDrive | Details for the SharePoint drive corresponding to the snappable ID. | `New-RscQueryO365 -Operation SharepointDrive`<BR> | [o365SharepointDrive](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SharepointDrives | List of sharepoint drives (document libraries) in the O365Org. | `New-RscQueryO365 -Operation SharepointDrives`<BR> | [o365SharepointDrives](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SharepointList | Details for the SharePoint list corresponding to the snappable ID. | `New-RscQueryO365 -Operation SharepointList`<BR> | [o365SharepointList](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SharepointLists | Paginated list of sharepoint lists in the O365Org. | `New-RscQueryO365 -Operation SharepointLists`<BR> | [o365SharepointLists](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SharepointObjectList | Returns the sharepoint objects after filtering on the object types and includeEntireHierarchy. | `New-RscQueryO365 -Operation SharepointObjectList`<BR> | [o365SharepointObjectList](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SharepointObjects | N/A | `New-RscQueryO365 -Operation SharepointObjects`<BR> | [o365SharepointObjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SharepointSite | Details for the SharePoint site corresponding to the site ID. | `New-RscQueryO365 -Operation SharepointSite`<BR> | [o365SharepointSite](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SharepointSites | Paginated list of sharepoint sites in the O365Org. | `New-RscQueryO365 -Operation SharepointSites`<BR> | [o365SharepointSites](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Site | Details for the SharePoint site corresponding to the snappable ID. | `New-RscQueryO365 -Operation Site`<BR> | [o365Site](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Sites | List of sites in the O365Org. | `New-RscQueryO365 -Operation Sites`<BR> | [o365Sites](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StorageStats | Returns the storage stats of an O365 org. | `New-RscQueryO365 -Operation StorageStats`<BR> | [o365StorageStats](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SubscriptionsAppTypeCounts | Returns the total number of apps of each type, for each O365 org. | `New-RscQueryO365 -Operation SubscriptionsAppTypeCounts`<BR> | [allO365SubscriptionsAppTypeCounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Team | Details for the team corresponding to the snappable ID. | `New-RscQueryO365 -Operation Team`<BR> | [o365Team](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TeamChannels | List of Channels for the O365Team. | `New-RscQueryO365 -Operation TeamChannels`<BR> | [o365TeamChannels](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TeamConversationsFolderID | ID for the conversations folder in the Team's Group Mailbox. | `New-RscQueryO365 -Operation TeamConversationsFolderID`<BR> | [o365TeamConversationsFolderID](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TeamPostedBy | Users who have posted in a team. | `New-RscQueryO365 -Operation TeamPostedBy`<BR> | [o365TeamPostedBy](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Teams | List of O365 Teams in the O365Org. | `New-RscQueryO365 -Operation Teams`<BR> | [o365Teams](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| User | Details for the O365 user corresponding to the ID. | `New-RscQueryO365 -Operation User`<BR> | [o365User](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UserObjects | Name, id, object type, and mail address of user descendant object. | `New-RscQueryO365 -Operation UserObjects`<BR> | [o365UserObjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AddOrg | Adds an O365 org to the account. | `New-RscMutationO365 -Operation AddOrg`<BR> | [addO365Org](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BackupMailbox | Backup mailbox workload. | `New-RscMutationO365 -Operation BackupMailbox`<BR> | [backupO365Mailbox](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BackupOnedrive | Take on-demand snapshot for Onedrive. | `New-RscMutationO365 -Operation BackupOnedrive`<BR> | [backupO365Onedrive](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BackupSharePointSite | Take on-demand snapshot for a SharePoint site. | `New-RscMutationO365 -Operation BackupSharePointSite`<BR> | [backupO365SharePointSite](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BackupSharepointDrive | Take on-demand snapshot for Sharepoint drive. | `New-RscMutationO365 -Operation BackupSharepointDrive`<BR> | [backupO365SharepointDrive](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BackupSharepointList | Take on-demand snapshot for SharePoint list. | `New-RscMutationO365 -Operation BackupSharepointList`<BR> | [backupO365SharepointList](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BackupTeam | Take on-demand snapshot for Teams. | `New-RscMutationO365 -Operation BackupTeam`<BR> | [backupO365Team](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateAppComplete | Completes the creation flow for an O365 Azure AD App. | `New-RscMutationO365 -Operation CreateAppComplete`<BR> | [createO365AppComplete](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateAppKickoff | Kicks off the creation flow for an O365 Azure AD App. | `New-RscMutationO365 -Operation CreateAppKickoff`<BR> | [createO365AppKickoff](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteAzureApp | Deletes an O365 Azure AD App from the account. | `New-RscMutationO365 -Operation DeleteAzureApp`<BR> | [deleteO365AzureApp](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteOrg | Deletes an O365 org from the account. | `New-RscMutationO365 -Operation DeleteOrg`<BR> | [deleteO365Org](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteServiceAccount | Deletes the service account for an org. | `New-RscMutationO365 -Operation DeleteServiceAccount`<BR> | [deleteO365ServiceAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| EnableSharePoint | Enables SharePoint protection in the exocompute cluster. | `New-RscMutationO365 -Operation EnableSharePoint`<BR> | [enableO365SharePoint](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| EnableTeams | Enables Teams protection in the exocompute cluster. | `New-RscMutationO365 -Operation EnableTeams`<BR> | [enableO365Teams](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExportMailbox | Exports an Exchange mailbox. | `New-RscMutationO365 -Operation ExportMailbox`<BR> | [exportO365Mailbox](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| InsertCustomerApp | Inserts a Customer-hosted O365 Azure AD App. | `New-RscMutationO365 -Operation InsertCustomerApp`<BR> | [insertCustomerO365App](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| OauthConsentComplete | Completes the OAuth consent flow for an O365 Azure AD App. | `New-RscMutationO365 -Operation OauthConsentComplete`<BR> | [o365OauthConsentComplete](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| OauthConsentKickoff | Kicks off the OAuth consent flow for an O365 Azure AD App. | `New-RscMutationO365 -Operation OauthConsentKickoff`<BR> | [o365OauthConsentKickoff](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PdlGroups | Retrieve or create the groups corresponding to the preferred data location and workload pairings for use in role creation. | `New-RscMutationO365 -Operation PdlGroups`<BR> | [o365PdlGroups](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RefreshOrg | Refreshes an O365 org. | `New-RscMutationO365 -Operation RefreshOrg`<BR> | [refreshO365Org](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RestoreMailbox | Restores an Exchange mailbox. | `New-RscMutationO365 -Operation RestoreMailbox`<BR> | [restoreO365Mailbox](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RestoreSnappable | Restores an O365 snappable. | `New-RscMutationO365 -Operation RestoreSnappable`<BR> | [restoreO365Snappable](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RestoreTeamsConversations | Restore Team conversations. | `New-RscMutationO365 -Operation RestoreTeamsConversations`<BR> | [restoreO365TeamsConversations](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RestoreTeamsFiles | Restore Team files. | `New-RscMutationO365 -Operation RestoreTeamsFiles`<BR> | [restoreO365TeamsFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SaaSSetupKickoff | N/A | `New-RscMutationO365 -Operation SaaSSetupKickoff`<BR> | [o365SaaSSetupKickoff](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SaasSetupComplete | Completes a Rubrik-Hosted setup flow. | `New-RscMutationO365 -Operation SaasSetupComplete`<BR> | [o365SaasSetupComplete](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SetServiceAccount | Sets the service account for the org. | `New-RscMutationO365 -Operation SetServiceAccount`<BR> | [setO365ServiceAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SetupKickoff | Kicks off an O365 subscription setup flow. | `New-RscMutationO365 -Operation SetupKickoff`<BR> | [o365SetupKickoff](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateAppAuthStatus | Update O365 App authentication status to applicable app version. | `New-RscMutationO365 -Operation UpdateAppAuthStatus`<BR> | [updateO365AppAuthStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateAppPermissions | Update O365 Azure app permission in Azure AD portal. | `New-RscMutationO365 -Operation UpdateAppPermissions`<BR> | [updateO365AppPermissions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateOrgCustomName | Update the custom name for an O365 Organization. | `New-RscMutationO365 -Operation UpdateOrgCustomName`<BR> | [updateO365OrgCustomName](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Oracle domain

Domain key: Oracle

Cmdlets: `New-RscQueryOracle` and `New-RscMutationOracle`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AcoExampleDownloadLink | Link to download the Advanced Recovery Options example file  
  
Supported in v5.3+  
Link to download the Advanced Recovery Options example file which can be used to customize Oracle recoveries. | `New-RscQueryOracle -Operation AcoExampleDownloadLink`<BR> | [oracleAcoExampleDownloadLink](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| AcoParameters | List of supported Advanced Cloning Options  
  
Supported in v6.0+  
Get the list of supported Advanced Cloning Options (ACO) parameters. | `New-RscQueryOracle -Operation AcoParameters`<BR> | [oracleAcoParameters](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DataGuardGroup | An Oracle Data Guard Group. | `New-RscQueryOracle -Operation DataGuardGroup`<BR> | [oracleDataGuardGroup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Database | An Oracle Database. | `New-RscQueryOracle -Operation Database`<BR> | [oracleDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DatabaseLogBackupConfig | Oracle log backup configuration for an Oracle Database. | `New-RscQueryOracle -Operation DatabaseLogBackupConfig`<BR> | [oracleDatabaseLogBackupConfig](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Databases | Paginated list of Oracle Databases. | `New-RscQueryOracle -Operation Databases`<BR> | [oracleDatabases](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Host | An Oracle Host. | `New-RscQueryOracle -Operation Host`<BR> | [oracleHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| HostLogBackupConfig | Oracle Log backup configuration for Oracle Host. | `New-RscQueryOracle -Operation HostLogBackupConfig`<BR> | [oracleHostLogBackupConfig](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| LiveMounts | Paginated list of Oracle Live Mounts. | `New-RscQueryOracle -Operation LiveMounts`<BR> | [oracleLiveMounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| MissedRecoverableRanges | Get missed recoverable ranges of a Oracle database  
  
Supported in v5.0+  
Retrieve a list of missed recoverable ranges for a Oracle database. For each run of one type of error, the first and last occurrence of the error are given. | `New-RscQueryOracle -Operation MissedRecoverableRanges`<BR> | [oracleMissedRecoverableRanges](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| MissedSnapshots | Get missed snapshots for an Oracle database  
  
Supported in v5.0+  
Retrieve summary information about the missed snapshots of an Oracle database. | `New-RscQueryOracle -Operation MissedSnapshots`<BR> | [oracleMissedSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PdbDetails | Get PDB details  
  
Supported in v8.0+  
Retrieves information about available pluggable databases (PDBs) for a given recovery point. | `New-RscQueryOracle -Operation PdbDetails`<BR> | [oraclePdbDetails](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Rac | An Oracle Real Application Cluster. | `New-RscQueryOracle -Operation Rac`<BR> | [oracleRac](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RacLogBackupConfig | Oracle log backup configuration for an Oracle RAC. | `New-RscQueryOracle -Operation RacLogBackupConfig`<BR> | [oracleRacLogBackupConfig](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RecoverableRanges | Get recoverable ranges of a Oracle database  
  
Supported in v5.0+  
Retrieve the recoverable ranges for a specified Oracle database. A begin and/or end timestamp can be provided to retrieve only the ranges that fall within the window. | `New-RscQueryOracle -Operation RecoverableRanges`<BR> | [oracleRecoverableRanges](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TopLevelDescendants | Paginated list of the highest-level Oracle Objects accessible by the current user. | `New-RscQueryOracle -Operation TopLevelDescendants`<BR> | [oracleTopLevelDescendants](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| BulkUpdateDatabases | Update Oracle Databases  
  
Supported in v5.2+  
Update the properties of the objects that represent the specified Oracle Databases. | `New-RscMutationOracle -Operation BulkUpdateDatabases`<BR> | [bulkUpdateOracleDatabases](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BulkUpdateHosts | Update Oracle Hosts  
  
Supported in v5.2+  
Update properties to Oracle Host objects. | `New-RscMutationOracle -Operation BulkUpdateHosts`<BR> | [bulkUpdateOracleHosts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BulkUpdateRacs | Update Oracle RACs  
  
Supported in v5.2+  
Update the properties of the objects that represent the specified Oracle RAC. | `New-RscMutationOracle -Operation BulkUpdateRacs`<BR> | [bulkUpdateOracleRacs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreatePdbRestore | Restore PDBs on an Oracle database  
  
Supported in v8.0+  
Initiates an asynchronous request to restore PDBs on an Oracle database from a specified snapshot or timestamp. | `New-RscMutationOracle -Operation CreatePdbRestore`<BR> | [createOraclePdbRestore](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteAllDatabaseSnapshots | Delete Oracle database snapshots  
  
Supported in v5.0+  
Delete all snapshots for a specified Oracle database object. For the operation to succeed the referenced database must not be assigned to an SLA Domain. | `New-RscMutationOracle -Operation DeleteAllDatabaseSnapshots`<BR> | [deleteAllOracleDatabaseSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteMount | Delete an Oracle database Live Mount  
  
Supported in v5.0+  
Request an asynchronous job to delete a specified Live Mount of an Oracle database snapshot. Poll the job status by using /oracle/request/{id}. | `New-RscMutationOracle -Operation DeleteMount`<BR> | [deleteOracleMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DownloadDatabaseSnapshot | Download Oracle snapshot from cloud  
  
Supported in v5.0+  
Create an asynchronous job to download an Oracle database snapshot and associated logs using the snapshot ID. The response includes the ID of the asynchronous job request. To see the status of the request, poll /oracle/request/{id}. | `New-RscMutationOracle -Operation DownloadDatabaseSnapshot`<BR> | [downloadOracleDatabaseSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExportDatabase | Export an Oracle database  
  
Supported in v5.0+  
Request an asynchronous job to export an Oracle database from a specified snapshot or timestamp. | `New-RscMutationOracle -Operation ExportDatabase`<BR> | [exportOracleDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExportTablespace | Export an Oracle tablespace  
  
Supported in v5.0+  
Request an asynchronous job to export an Oracle tablespace from a specified snapshot or timestamp. | `New-RscMutationOracle -Operation ExportTablespace`<BR> | [exportOracleTablespace](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| InstantRecoverSnapshot | Instant recovery of a database  
  
Supported in v5.0+  
Creates an instant recover request that restores a target database from the given snapshot. | `New-RscMutationOracle -Operation InstantRecoverSnapshot`<BR> | [instantRecoverOracleSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| MountDatabase | Live Mount an Oracle database snapshot  
  
Supported in v5.0+  
Create an asynchronous job to Live Mount an Oracle database from a snapshot. | `New-RscMutationOracle -Operation MountDatabase`<BR> | [mountOracleDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RefreshDatabase | Refresh an Oracle database  
  
Supported in v6.0+  
Starts an asynchronous job to refresh the Oracle database metadata by querying the database instances on all the underlying hosts. | `New-RscMutationOracle -Operation RefreshDatabase`<BR> | [refreshOracleDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RestoreLogs | Restore archive logs of an Oracle database  
  
Supported in v6.0+  
v6.0: Create an asynchronous job to restore archive logs of an Oracle database.  
v7.0+: Starts an asynchronous job to restore archive logs of an Oracle database. | `New-RscMutationOracle -Operation RestoreLogs`<BR> | [restoreOracleLogs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TakeOnDemandDatabaseSnapshot | On-demand backup of an Oracle database  
  
Supported in v5.0+  
Create an asynchronous job for an on-demand snapshot of an Oracle database. The response includes an ID for the asynchronous job request. To see the status of the request, poll /oracle/request/{id}. | `New-RscMutationOracle -Operation TakeOnDemandDatabaseSnapshot`<BR> | [takeOnDemandOracleDatabaseSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TakeOnDemandLogSnapshot | On-demand log backup for an Oracle database log  
  
Supported in v5.0+  
Create an asynchronous job for an on-demand backup of an Oracle database log. The response includes an ID for the asynchronous job request.  To see the status of the request, poll /oracle/request/{id}. | `New-RscMutationOracle -Operation TakeOnDemandLogSnapshot`<BR> | [takeOnDemandOracleLogSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateDataGuardGroup | Update an Oracle Data Guard group  
  
Supported in v6.0+  
Update properties of an Oracle Data Guard group object. | `New-RscMutationOracle -Operation UpdateDataGuardGroup`<BR> | [updateOracleDataGuardGroup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ValidateAcoFile | Validate Oracle ACO file  
  
Supported in v6.0+  
Validate the provided Oracle ACO (Advanced Cloning Options) file. | `New-RscMutationOracle -Operation ValidateAcoFile`<BR> | [validateOracleAcoFile](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ValidateDatabaseBackups | Validate Oracle database backups  
  
Supported in v5.3+  
Queue a job to validate Oracle backups for a database snapshot or a specified timestamp. | `New-RscMutationOracle -Operation ValidateDatabaseBackups`<BR> | [validateOracleDatabaseBackups](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Policy domain

Domain key: Policy

Cmdlets: `New-RscQueryPolicy` and `New-RscMutationPolicy`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Details | Returns active policies for an account. | `New-RscQueryPolicy -Operation Details`<BR> | [policyDetails](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Obj | Returns details for one policy object. | `New-RscQueryPolicy -Operation Obj`<BR> | [policyObj](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ObjectUsages | Returns the policies assigned to each object. | `New-RscQueryPolicy -Operation ObjectUsages`<BR> | [policyObjectUsages](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Objs | Returns status for all objects at a specified timestamp. | `New-RscQueryPolicy -Operation Objs`<BR> | [policyObjs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Policies | Returns active policies for an account. | `New-RscQueryPolicy -Operation Policies`<BR> | [policies](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Policy | Returns detailed policy information. | `New-RscQueryPolicy -Operation Policy`<BR> | [policy](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Policies | DEPRECATED (use seedEnabledPolicies instead) Seed account with initial policies. | `New-RscMutationPolicy -Operation Policies`<BR> | [seedInitialPolicies](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Ransomware domain

Domain key: Ransomware

Cmdlets: `New-RscQueryRansomware` and `New-RscMutationRansomware`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| DetectionWorkloadLocations | Get the list of workload locations on which Ransomware Investigation has run. | `New-RscQueryRansomware -Operation DetectionWorkloadLocations`<BR> | [ransomwareDetectionWorkloadLocations](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| InvestigationAnalysisSummary | Get a per day summary of the radar analysis results from start day to end day. | `New-RscQueryRansomware -Operation InvestigationAnalysisSummary`<BR> | [ransomwareInvestigationAnalysisSummary](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| InvestigationEnablement | Get the enablement status of entities on which Ransomware Monitoring can be enabled. | `New-RscQueryRansomware -Operation InvestigationEnablement`<BR> | [ransomwareInvestigationEnablement](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| InvestigationWorkloadScannedCount | Get the total number of times that Radar has scanned a workload. | `New-RscQueryRansomware -Operation InvestigationWorkloadScannedCount`<BR> | [ransomwareInvestigationWorkloadScannedCount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| OverallInvestigationSummary | Overall ransomware investigation summary. | `New-RscQueryRansomware -Operation OverallInvestigationSummary`<BR> | [overallRansomwareInvestigationSummary](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PendingInvestigationResultsCount | Get information about workloads passing through the Radar pipeline. | `New-RscQueryRansomware -Operation PendingInvestigationResultsCount`<BR> | [pendingRansomwareInvestigationResultsCount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ProcessedInvestigationWorkloadCount | Get the number of workloads that have passed through the Radar pipeline in the past 24 hours. | `New-RscQueryRansomware -Operation ProcessedInvestigationWorkloadCount`<BR> | [processedRansomwareInvestigationWorkloadCount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ProtectedInvestigationWorkloadCount | Get the total number of workloads protected by Radar. | `New-RscQueryRansomware -Operation ProtectedInvestigationWorkloadCount`<BR> | [protectedRansomwareInvestigationWorkloadCount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Result | Result of the Ransomware Investigation. | `New-RscQueryRansomware -Operation Result`<BR> | [ransomwareResult](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ResultOpt | Optional result of the Ransomware Investigation. | `New-RscQueryRansomware -Operation ResultOpt`<BR> | [ransomwareResultOpt](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Results | Results for Ransomware Investigations. | `New-RscQueryRansomware -Operation Results`<BR> | [ransomwareResults](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ResultsGrouped | Results for the Ransomware Investigations grouped by an argument. | `New-RscQueryRansomware -Operation ResultsGrouped`<BR> | [ransomwareResultsGrouped](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| TriggerDetection | Trigger detect ransomware job for given snapshot. | `New-RscMutationRansomware -Operation TriggerDetection`<BR> | [triggerRansomwareDetection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## RCS domain

Domain key: Rcs

Cmdlets: `New-RscQueryRcs` and `New-RscMutationRcs`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| ArchivalLocationsConsumptionStats | RCS Azure archival location consumption stats. | `New-RscQueryRcs -Operation ArchivalLocationsConsumptionStats`<BR> | [rcsArchivalLocationsConsumptionStats](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Cluster | Get the cluster certificate signing request  
  
Supported in v7.0+  
Returns the certificate signing request generated from the private key of the Rubrik cluster. | `New-RscQueryRcs -Operation Cluster`<BR> | [clusterCsr](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Dhcores | DHRC scores for the requested categories and time span. | `New-RscQueryRcs -Operation Dhcores`<BR> | [allDhrcScores](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| CreateAutomaticTargetMapping | N/A | `New-RscMutationRcs -Operation CreateAutomaticTargetMapping`<BR> | [createAutomaticRcsTargetMapping](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateReaderTarget | Creates reader type for RCS Azure archival location on a CDM cluster. | `New-RscMutationRcs -Operation CreateReaderTarget`<BR> | [createRcsReaderTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateTarget | N/A | `New-RscMutationRcs -Operation CreateTarget`<BR> | [createRcsTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateAutomaticTargetMapping | Update RCS automatic target mapping. | `New-RscMutationRcs -Operation UpdateAutomaticTargetMapping`<BR> | [updateRcsAutomaticTargetMapping](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## RCV domain

Domain key: Rcv

Cmdlets: `New-RscQueryRcv` and `New-RscMutationRcv`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AccountEntitlement | Rubrik Cloud Vault (RCV) Account entitlement details. | `New-RscQueryRcv -Operation AccountEntitlement`<BR> | [rcvAccountEntitlement](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| AccountEntitlements | Rubrik Cloud Vault (RCV) account entitlements with their respective order numbers. | `New-RscQueryRcv -Operation AccountEntitlements`<BR> | [allRcvAccountEntitlements](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| CreateLocationsFromTemplate | Creates Rubrik Cloud Vault locations from given location template. | `New-RscMutationRcv -Operation CreateLocationsFromTemplate`<BR> | [createRcvLocationsFromTemplate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreatePrivateEndpointApprovalRequest | Create RCV private endpoint approval request. | `New-RscMutationRcv -Operation CreatePrivateEndpointApprovalRequest`<BR> | [createRcvPrivateEndpointApprovalRequest](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateTarget | Updates the Rubrik Cloud Vault archival location. | `New-RscMutationRcv -Operation UpdateTarget`<BR> | [updateRcvTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Replication domain

Domain key: Replication

Cmdlets: `New-RscQueryReplication` and `New-RscMutationReplication`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| IncomingStats | Get a time series of total incoming bandwidth to the replication clusters. | `New-RscQueryReplication -Operation IncomingStats`<BR> | [replicationIncomingStats](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| OutgoingStats | Get the time series of total outgoing bandwidth from the replication clusters. | `New-RscQueryReplication -Operation OutgoingStats`<BR> | [replicationOutgoingStats](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Pairs | List of all replication pair Rubrik clusters. | `New-RscQueryReplication -Operation Pairs`<BR> | [replicationPairs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ValidTargets | List all valid replication target clusters. | `New-RscQueryReplication -Operation ValidTargets`<BR> | [allValidReplicationTargets](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| CreatePair | Creates replication pairing between two Rubrik clusters. | `New-RscMutationReplication -Operation CreatePair`<BR> | [createReplicationPair](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeletePair | Deletes replication pairing between two Rubrik clusters. | `New-RscMutationReplication -Operation DeletePair`<BR> | [deleteReplicationPair](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DisablePause | A single Rubrik cluster can be the replication target for multiple source Rubrik clusters. For each source cluster specified, this resumes replication from that source cluster to the target cluster. | `New-RscMutationReplication -Operation DisablePause`<BR> | [disableReplicationPause](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| EnablePause | A single Rubrik cluster can be the replication target for multiple source Rubrik clusters. For each source cluster specified, this pauses replication from that source cluster to the target cluster. | `New-RscMutationReplication -Operation EnablePause`<BR> | [enableReplicationPause](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateTarget | Update the setup information, address, username, and password for the replication target. | `New-RscMutationReplication -Operation UpdateTarget`<BR> | [updateReplicationTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Report domain

Domain key: Report

Cmdlets: `New-RscQueryReport` and `New-RscMutationReport`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Data | N/A | `New-RscQueryReport -Operation Data`<BR> | [reportData](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Scheduled | Retrieve details of a scheduled report. | `New-RscQueryReport -Operation Scheduled`<BR> | [scheduledReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| CreateCustom | Create a custom report. | `New-RscMutationReport -Operation CreateCustom`<BR> | [createCustomReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateScheduled | Create a scheduled report. | `New-RscMutationReport -Operation CreateScheduled`<BR> | [createScheduledReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteCustom | Delete a custom report. | `New-RscMutationReport -Operation DeleteCustom`<BR> | [deleteCustomReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteScheduled | Delete a scheduled report. | `New-RscMutationReport -Operation DeleteScheduled`<BR> | [deleteScheduledReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SendPdf | DHRC PDF report generation. | `New-RscMutationReport -Operation SendPdf`<BR> | [sendPdfReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SendScheduledAsync | Send a scheduled report now asynchronously via email. | `New-RscMutationReport -Operation SendScheduledAsync`<BR> | [sendScheduledReportAsync](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartClusterMigrationJob | Start a job to migrate reports from Rubrik cluster to RSC. | `New-RscMutationReport -Operation StartClusterMigrationJob`<BR> | [startClusterReportMigrationJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateCustom | Update a custom report. | `New-RscMutationReport -Operation UpdateCustom`<BR> | [updateCustomReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateScheduled | Update a scheduled report. | `New-RscMutationReport -Operation UpdateScheduled`<BR> | [updateScheduledReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## SAP HANA domain

Domain key: SapHana

Cmdlets: `New-RscQuerySapHana` and `New-RscMutationSapHana`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Database | Details of a SAP HANA database for a given FID. | `New-RscQuerySapHana -Operation Database`<BR> | [sapHanaDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Databases | Connection of filtered SAP HANA databases based on specific filters. | `New-RscQuerySapHana -Operation Databases`<BR> | [sapHanaDatabases](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| LogSnapshot | Details of a SAP HANA log snapshot for a given FID. | `New-RscQuerySapHana -Operation LogSnapshot`<BR> | [sapHanaLogSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| LogSnapshots | Connection of all log snapshots for SAP HANA. | `New-RscQuerySapHana -Operation LogSnapshots`<BR> | [sapHanaLogSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RecoverableRange | Details of a SAP HANA recoverable range for a given FID. | `New-RscQuerySapHana -Operation RecoverableRange`<BR> | [sapHanaRecoverableRange](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RecoverableRanges | Connection of all recoverable ranges for SAP HANA. | `New-RscQuerySapHana -Operation RecoverableRanges`<BR> | [sapHanaRecoverableRanges](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| System | Details of a SAP HANA system for a given FID. | `New-RscQuerySapHana -Operation System`<BR> | [sapHanaSystem](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Systems | Connection of filtered SAP HANA systems based on specific filters. | `New-RscQuerySapHana -Operation Systems`<BR> | [sapHanaSystems](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AddSystem | Add a SAP HANA system  
  
Supported in v5.3+  
Add a SAP HANA system to the Rubrik cluster. | `New-RscMutationSapHana -Operation AddSystem`<BR> | [addSapHanaSystem](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ConfigureRestore | Configure the target database for system copy restore  
  
Supported in v6.0+  
Initiates a job to configure the specified target database for a system copy restore by sending metadata about the source database. System copy restore in SAP HANA is done across different databases. | `New-RscMutationSapHana -Operation ConfigureRestore`<BR> | [configureSapHanaRestore](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateOnDemandBackup | Create on demand database snapshot  
  
Supported in v5.3+  
Initiates a job to take an on demand full snapshot of a specified SAP HANA database object. The GET /sap_hana/db/request/{id} endpoint can be used to monitor the progress of the job. | `New-RscMutationSapHana -Operation CreateOnDemandBackup`<BR> | [createOnDemandSapHanaBackup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateSystemRefresh | Refresh SAP HANA system metadata  
  
Supported in v5.3+  
Initiates a job to refresh metadata of a SAP HANA system object. The GET /sap_hana/system/request/{id} endpoint can be used to monitor the progress of the job. | `New-RscMutationSapHana -Operation CreateSystemRefresh`<BR> | [createSapHanaSystemRefresh](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteDbSnapshot | Delete a particular full snapshot of a SAP HANA database  
  
Supported in v5.3+  
Initiates a request to delete a particular full snapshot of a SAP HANA database. If the log retention period for the database is still in effect, the snapshot will be deleted when the log retention period ends. | `New-RscMutationSapHana -Operation DeleteDbSnapshot`<BR> | [deleteSapHanaDbSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteSystem | Delete a SAP HANA system  
  
Supported in v5.3+  
Initiates a job to delete a SAP HANA system object. GET /sap_hana/system/request/{id} endpoint can be used to monitor the progress of the job. | `New-RscMutationSapHana -Operation DeleteSystem`<BR> | [deleteSapHanaSystem](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExpireDownloadedSnapshots | Expire downloaded snapshots of an SAP HANA database  
  
Supported in v8.0+  
Requests an asynchronous job to expire all downloaded data and log snapshots. You can specify a begin time or an end time or both to provide a time range to expire only the downloaded data and log snapshots that were taken within the specified time range. The time is relative to when the snapshot was originally taken, not when it was downloaded. You can also configure a flag to expire only the log snapshots. | `New-RscMutationSapHana -Operation ExpireDownloadedSnapshots`<BR> | [expireDownloadedSapHanaSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PatchSystem | v5.3-v8.1: Update the SLA Domain for a SAP HANA system  
v9.0+: Update the system properties of the SAP HANA system  
  
Supported in v5.3+  
v5.3-v8.1: Update the SLA Domain that is configured for a SAP HANA system.  
v9.0+: Update the system properties for the SAP HANA system. | `New-RscMutationSapHana -Operation PatchSystem`<BR> | [patchSapHanaSystem](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UnconfigureRestore | Reset the configuration for system copy restore on target database  
  
Supported in v6.0+  
Initiates a job to reset the configuration for the system copy restore on the specified target database. System copy restore in SAP HANA is done across different databases. | `New-RscMutationSapHana -Operation UnconfigureRestore`<BR> | [unconfigureSapHanaRestore](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Service Account domain

Domain key: ServiceAccount

Cmdlets: `New-RscQueryServiceAccount` and `New-RscMutationServiceAccount`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| ServiceAccount | Browse service accounts. | `New-RscQueryServiceAccount -Operation ServiceAccount`<BR> | [serviceAccounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Create | Create a service account. | `New-RscMutationServiceAccount -Operation Create`<BR> | [createServiceAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Delete | Delete specified service accounts. | `New-RscMutationServiceAccount -Operation Delete`<BR> | [deleteServiceAccountsFromAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Rotate | Rotate service account secret. | `New-RscMutationServiceAccount -Operation Rotate`<BR> | [rotateServiceAccountSecret](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Update | Update the specified service account. | `New-RscMutationServiceAccount -Operation Update`<BR> | [updateServiceAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Sharepoint domain

Domain key: Sharepoint

Cmdlets: `New-RscQuerySharepoint` and `New-RscMutationSharepoint`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| BrowseDrive | Browse SharePoint  drive files and folders. | `New-RscQuerySharepoint -Operation BrowseDrive`<BR> | [browseSharepointDrive](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BrowseList | Browse list objects. | `New-RscQuerySharepoint -Operation BrowseList`<BR> | [browseSharepointList](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SiteDescendants | Browse site and descendants objects. | `New-RscQuerySharepoint -Operation SiteDescendants`<BR> | [sharepointSiteDescendants](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SiteExclusions | Sharepoint site objects excluded from protection. | `New-RscQuerySharepoint -Operation SiteExclusions`<BR> | [allSharepointSiteExclusions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SiteSearch | Search site and descendant objects. | `New-RscQuerySharepoint -Operation SiteSearch`<BR> | [sharepointSiteSearch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SnappableDriveSearch | N/A | `New-RscQuerySharepoint -Operation SnappableDriveSearch`<BR> | [snappableSharepointDriveSearch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SnappableListSearch | Search list objects. | `New-RscQuerySharepoint -Operation SnappableListSearch`<BR> | [snappableSharepointListSearch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SnapshotDriveSearch | N/A | `New-RscQuerySharepoint -Operation SnapshotDriveSearch`<BR> | [snapshotSharepointDriveSearch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| ExcludeObjectsFromProtection | Exclude Sharepoint site objects from protection. | `New-RscMutationSharepoint -Operation ExcludeObjectsFromProtection`<BR> | [excludeSharepointObjectsFromProtection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## SLA domain

Domain key: Sla

Cmdlets: `New-RscQuerySla` and `New-RscMutationSla`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AuditDetail | List of audit details for a given SLA Domain. | `New-RscQuerySla -Operation AuditDetail`<BR> | [slaAuditDetail](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ClusterDomains | Returns paginated list of SLA domains that were created on Rubrik CDM. | `New-RscQuerySla -Operation ClusterDomains`<BR> | [clusterSlaDomains](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ClusterGlobals | Global SLA Domains protecting at least one object on the specified Rubrik cluster. | `New-RscQuerySla -Operation ClusterGlobals`<BR> | [allClusterGlobalSlas](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ConflictObjects | Conflicting objects for an SLA Domain assignment. | `New-RscQuerySla -Operation ConflictObjects`<BR> | [slaConflictObjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CountOfObjectsProtected | The number of objects protected by the SLA Domains. | `New-RscQuerySla -Operation CountOfObjectsProtected`<BR> | [countOfObjectsProtectedBySlas](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Domain | Query that retrieves an SLA Domain. | `New-RscQuerySla -Operation Domain`<BR> | [slaDomain](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Domains | Retrieves a list of SLA Domains. | `New-RscQuerySla -Operation Domains`<BR> | [slaDomains](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| GlobalFilterList | Retrieves a list of SLA Domains. | `New-RscQuerySla -Operation GlobalFilterList`<BR> | [globalSlaFilterConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| GlobalStatuses | Status on the clusters where global SLA is synced. | `New-RscQuerySla -Operation GlobalStatuses`<BR> | [globalSlaStatuses](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ManagedVolume | Details of a SLA Managed Volume object. | `New-RscQuerySla -Operation ManagedVolume`<BR> | [slaManagedVolume](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ManagedVolumes | Paginated list of SLA Managed Volumes. | `New-RscQuerySla -Operation ManagedVolumes`<BR> | [slaManagedVolumes](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| NcdComplianceData | NAS Cloud Direct SLA Domain compliance data for the requested clusters. | `New-RscQuerySla -Operation NcdComplianceData`<BR> | [allNcdSlaComplianceData](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SummariesByIds | List of SLA Domain summaries for the given IDs. | `New-RscQuerySla -Operation SummariesByIds`<BR> | [allSlaSummariesByIds](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| VerifyWithReplicationToCluster | Verify for a Rubrik cluster if it is replication target in any SLA Domain. | `New-RscQuerySla -Operation VerifyWithReplicationToCluster`<BR> | [verifySlaWithReplicationToCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Assign | Endpoint to assign SLA Domain. | `New-RscMutationSla -Operation Assign`<BR> | [assignSla](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| AssignRetentionToSnappables | Endpoint to assign retention SLA Domain to workloads. | `New-RscMutationSla -Operation AssignRetentionToSnappables`<BR> | [assignRetentionSLAToSnappables](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| AssignRetentionToSnapshots | Endpoint to assign retention SLA Domain to snapshots. | `New-RscMutationSla -Operation AssignRetentionToSnapshots`<BR> | [assignRetentionSLAToSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| AssignsForSnappableHierarchies | Assign SLA Domain to workloads with multiple hierarchies. | `New-RscMutationSla -Operation AssignsForSnappableHierarchies`<BR> | [assignSlasForSnappableHierarchies](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateGlobal | Create SLA Domain. | `New-RscMutationSla -Operation CreateGlobal`<BR> | [createGlobalSla](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExportManagedVolumeSnapshot | Create a request to export a snapshot and mount it on a host  
  
Supported in v5.3+  
Export a managed volume snapshot as a share and mount it on a given host. | `New-RscMutationSla -Operation ExportManagedVolumeSnapshot`<BR> | [exportSlaManagedVolumeSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| GetPendingAssignments | Get pending SLA Domain assignments on selected managed objects  
  
Supported in v5.2+  
Retrieve the details of pending SLA Domain assignments on the given managed objects. For objects with pending assignments, return the SLA Domain that is pending. For objects without pending assignments, return the current SLA Domain information. Explicitly list invalid object IDs. | `New-RscMutationSla -Operation GetPendingAssignments`<BR> | [getPendingSlaAssignments](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Pause | Pause or resume SLA Domain on the given Rubrik clusters. | `New-RscMutationSla -Operation Pause`<BR> | [pauseSla](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateGlobal | Update SLA Domain. | `New-RscMutationSla -Operation UpdateGlobal`<BR> | [updateGlobalSla](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## SMB domain

Domain key: Smb

Cmdlets: `New-RscQuerySmb` and `New-RscMutationSmb`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Configuration | Get SMB configuration  
  
Supported in v5.0+  
Get SMB configuration. | `New-RscQuerySmb -Operation Configuration`<BR> | [smbConfiguration](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Domains | Paginated list of SMB domains. | `New-RscQuerySmb -Operation Domains`<BR> | [smbDomains](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AddAndJoinDomain | Add a new domain  
  
Supported in v5.0+  
Add a new domain manually and join Active Directory. | `New-RscMutationSmb -Operation AddAndJoinDomain`<BR> | [addAndJoinSmbDomain](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteDomain | Delete Active Directory from Rubrik  
  
Supported in v5.0+  
Delete Active Directory from Rubrik. | `New-RscMutationSmb -Operation DeleteDomain`<BR> | [deleteSmbDomain](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| JoinDomain | Join Active Directory  
  
Supported in v5.0+  
Join Active Directory. | `New-RscMutationSmb -Operation JoinDomain`<BR> | [joinSmbDomain](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PutConfiguration | SMB configuration  
  
Supported in v5.0+  
SMB configuration. | `New-RscMutationSmb -Operation PutConfiguration`<BR> | [putSmbConfiguration](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Snapshot domain

Domain key: Snapshot

Cmdlets: `New-RscQuerySnapshot` and `New-RscMutationSnapshot`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| BrowseFileList | Returns a list files whose name is prefixed by the query in the given snapshot. | `New-RscQuerySnapshot -Operation BrowseFileList`<BR> | [browseSnapshotFileConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ClosestToPointInTime | Details of the unexpired snapshot closest to the specified point in time for each provided workload ID. | `New-RscQuerySnapshot -Operation ClosestToPointInTime`<BR> | [allSnapshotsClosestToPointInTime](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| EmailSearch | N/A | `New-RscQuerySnapshot -Operation EmailSearch`<BR> | [snapshotEmailSearch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| EventSearch | N/A | `New-RscQuerySnapshot -Operation EventSearch`<BR> | [snapshotEventSearch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| FilesDelta | Browse or search the given path for files and directories along with their deltas in a given snapshot. | `New-RscQuerySnapshot -Operation FilesDelta`<BR> | [snapshotFilesDelta](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| FilesDeltaV2 | Browse or search the given path for files and directories along with their deltas in a given snapshot. | `New-RscQuerySnapshot -Operation FilesDeltaV2`<BR> | [snapshotFilesDeltaV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Fileset | N/A | `New-RscQuerySnapshot -Operation Fileset`<BR> | [filesetSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| FilesetFiles | Lists all files and directories in a given path  
  
Supported in v5.0+  
Lists all files and directories in a given path. | `New-RscQuerySnapshot -Operation FilesetFiles`<BR> | [filesetSnapshotFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| LegalHoldSnappable | List of legal hold snapshots for a workload. | `New-RscQuerySnapshot -Operation LegalHoldSnappable`<BR> | [legalHoldSnapshotsForSnappable](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| OnedriveSearch | N/A | `New-RscQuerySnapshot -Operation OnedriveSearch`<BR> | [snapshotOnedriveSearch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Polaris | Returns the RSC snapshot according to ID. | `New-RscQuerySnapshot -Operation Polaris`<BR> | [polarisSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Pvcs | All PVCs in a snapshot. | `New-RscQuerySnapshot -Operation Pvcs`<BR> | [allSnapshotPvcs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| QuarantinedDetails | Quarantine details of all snapshots. | `New-RscQuerySnapshot -Operation QuarantinedDetails`<BR> | [allQuarantinedDetailsForSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Results | Returns snapshot results for a workload. | `New-RscQuerySnapshot -Operation Results`<BR> | [snapshotResults](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SnappableList | Returns a list of snapshots for a workload. | `New-RscQuerySnapshot -Operation SnappableList`<BR> | [snapshotOfASnappableConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SnappablesList | Returns list of snapshots for a list of workloads. | `New-RscQuerySnapshot -Operation SnappablesList`<BR> | [snapshotOfSnappablesConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SnappablesWithLegalHoldsSummary | List of workloads with legal hold snapshots. | `New-RscQuerySnapshot -Operation SnappablesWithLegalHoldsSummary`<BR> | [snappablesWithLegalHoldSnapshotsSummary](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Snapshot | Returns a single snapshot by snapshot forever UUID and cluster UUID. In case cluster UUID is not provided, the snapshot forever UUID is used to resolve it. Cluster UUID is beneficial for fetching the same snapshot in a different replication target Rubrik cluster. | `New-RscQuerySnapshot -Operation Snapshot`<BR> | [snapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UnmanagedObject | List of snapshots for unmanaged objects. | `New-RscQuerySnapshot -Operation UnmanagedObject`<BR> | [snapshotsForUnmanagedObject](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| VappInstantRecoveryOptions | Options for instantly recovering a vApp snapshot. | `New-RscQuerySnapshot -Operation VappInstantRecoveryOptions`<BR> | [vappSnapshotInstantRecoveryOptions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| VappTemplateExportOptions | Export options for a vApp snapshot template. | `New-RscQuerySnapshot -Operation VappTemplateExportOptions`<BR> | [vappTemplateSnapshotExportOptions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| BatchQuarantine | Batch quarantine snapshots. | `New-RscMutationSnapshot -Operation BatchQuarantine`<BR> | [batchQuarantineSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BatchReleaseFromQuarantine | Release snapshots from quarantine. | `New-RscMutationSnapshot -Operation BatchReleaseFromQuarantine`<BR> | [batchReleaseFromQuarantineSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BulkTierExistings | Bulk tier existing snapshots to cold storage  
  
Supported in v6.0+  
Schedules a job to tier existing snapshots of the specified objects to cold storage. | `New-RscMutationSnapshot -Operation BulkTierExistings`<BR> | [bulkTierExistingSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateDomainController | On-demand snapshot of an Active Directory Domain Controller  
  
Supported in v9.0+  
Initiates an on-demand snapshot job of a specified Active Directory Domain Controller. | `New-RscMutationSnapshot -Operation CreateDomainController`<BR> | [createDomainControllerSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateDownloadForVolumeGroup | Creates a download from archival request  
  
Supported in v5.0+  
Download a snapshot from archival. | `New-RscMutationSnapshot -Operation CreateDownloadForVolumeGroup`<BR> | [createDownloadSnapshotForVolumeGroup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateFileset | N/A | `New-RscMutationSnapshot -Operation CreateFileset`<BR> | [createFilesetSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteCloudWorkload | Deletes the Rubrik Security Cloud on-demand snapshot by ID. | `New-RscMutationSnapshot -Operation DeleteCloudWorkload`<BR> | [deleteCloudWorkloadSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteFilesets | N/A | `New-RscMutationSnapshot -Operation DeleteFilesets`<BR> | [deleteFilesetSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| FilesetDownloadFiles | Download files from a fileset backup  
  
Supported in v5.0+  
Start an asynchronous job to download multiple files and folders from a specified fileset backup. The response returns an asynchronous request ID. Get the URL for downloading the ZIP file including the specific files/folders by sending a GET request to 'fileset/request/{id}'. | `New-RscMutationSnapshot -Operation FilesetDownloadFiles`<BR> | [filesetDownloadSnapshotFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| FilesetExportFiles | Create an export job to export multiple files or directories  
  
Supported in v5.0+  
Starts a job that exports one or more files or folders from a fileset backup to the destination host. Returns the job status as of the job creation time. This job status includes the job ID. | `New-RscMutationSnapshot -Operation FilesetExportFiles`<BR> | [filesetExportSnapshotFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RestoreDomainController | Initiate Active Directory restore job  
  
Supported in v9.0+  
Initiates a job to restore Active Directory snapshots to their corresponding Domain Controllers or alternate hosts. Returns the job instance ID. | `New-RscMutationSnapshot -Operation RestoreDomainController`<BR> | [restoreDomainControllerSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RestoreVolumeGroupFiles | Restore files from the Volume Group snapshot  
  
Supported in v5.0+  
Restore filess to the original Host. | `New-RscMutationSnapshot -Operation RestoreVolumeGroupFiles`<BR> | [restoreVolumeGroupSnapshotFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartEc2InstanceExportJob | Starts a job to export an EC2 Instance snapshot. The job creates a new EC2 Instance with the same properties as that of the snapshot that is exported. | `New-RscMutationSnapshot -Operation StartEc2InstanceExportJob`<BR> | [startEc2InstanceSnapshotExportJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartRecoverS3Job | Starts an on-demand snapshot recovery job for the specified AWS S3 bucket. Returns the ID of the taskchain initiated for the recovery job. | `New-RscMutationSnapshot -Operation StartRecoverS3Job`<BR> | [startRecoverS3SnapshotJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TakeOnDemand | Triggers on-demand snapshot for the given workloads. | `New-RscMutationSnapshot -Operation TakeOnDemand`<BR> | [takeOnDemandSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UploadDatabaseToBlobstore | Start a job to upload a database snapshot to a target blobstore. | `New-RscMutationSnapshot -Operation UploadDatabaseToBlobstore`<BR> | [uploadDatabaseSnapshotToBlobstore](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| VmwareDownloadFromLocation | N/A | `New-RscMutationSnapshot -Operation VmwareDownloadFromLocation`<BR> | [vmwareDownloadSnapshotFromLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Sonar domain

Domain key: Sonar

Cmdlets: `New-RscQuerySonar` and `New-RscMutationSonar`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| ContentReport | Returns groupBy results for SonarContentReport. | `New-RscQuerySonar -Operation ContentReport`<BR> | [sonarContentReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Report | Returns groupBy for SonarReport. | `New-RscQuerySonar -Operation Report`<BR> | [sonarReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ReportRow | Returns rows for SonarReport table. | `New-RscQuerySonar -Operation ReportRow`<BR> | [sonarReportRow](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UserGroups | N/A | `New-RscQuerySonar -Operation UserGroups`<BR> | [sonarUserGroups](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Users | N/A | `New-RscQuerySonar -Operation Users`<BR> | [sonarUsers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |

[Go to top](#)
## Storage Arrays domain

Domain key: StorageArray

Cmdlets: `New-RscQueryStorageArray` and `New-RscMutationStorageArray`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| StorageArray | Summary of all storage arrays  
  
Supported in v5.0+  
Retrieve the host IP and username for all storage arrays. | `New-RscQueryStorageArray -Operation StorageArray`<BR> | [allStorageArrays](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Add | Add storage arrays to Rubrik clusters. | `New-RscMutationStorageArray -Operation Add`<BR> | [addStorageArrays](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Delete | Delete storage arrays from Rubrik clusters. | `New-RscMutationStorageArray -Operation Delete`<BR> | [deleteStorageArrays](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Refresh | Refresh storage arrays in Rubrik clusters. | `New-RscMutationStorageArray -Operation Refresh`<BR> | [refreshStorageArrays](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Update | Update storage arrays in Rubrik clusters. | `New-RscMutationStorageArray -Operation Update`<BR> | [updateStorageArrays](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Tape domain

Domain key: Tape

Cmdlets: `New-RscQueryTape` and `New-RscMutationTape`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| CreateReaderTarget | Creates a reader location for a Tape archival location on a CDM cluster. | `New-RscMutationTape -Operation CreateReaderTarget`<BR> | [createTapeReaderTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateTarget | Creates Tape archival location on a CDM cluster. | `New-RscMutationTape -Operation CreateTarget`<BR> | [createTapeTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateTarget | Update Tape archival location on a CDM cluster. | `New-RscMutationTape -Operation UpdateTarget`<BR> | [updateTapeTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Threat domain

Domain key: Threat

Cmdlets: `New-RscQueryThreat` and `New-RscMutationThreat`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| HuntDetail | The details of a threat hunt. | `New-RscQueryThreat -Operation HuntDetail`<BR> | [threatHuntDetail](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| HuntResult | The results of the Threat Hunt. | `New-RscQueryThreat -Operation HuntResult`<BR> | [threatHuntResult](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| HuntSummary | The summary of a threat hunt. | `New-RscQueryThreat -Operation HuntSummary`<BR> | [threatHuntSummary](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Hunts | List of Threat Hunts. | `New-RscQueryThreat -Operation Hunts`<BR> | [threatHunts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| CancelHunt | Cancel an in-progress threat hunt. | `New-RscMutationThreat -Operation CancelHunt`<BR> | [cancelThreatHunt](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| EnableMonitoring | Enable or disable Threat Monitoring on a Rubrik cluster. | `New-RscMutationThreat -Operation EnableMonitoring`<BR> | [enableThreatMonitoring](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartHunt | Start a threat hunt on a cluster. | `New-RscMutationThreat -Operation StartHunt`<BR> | [startThreatHunt](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## VMware vSphere vCenter domain

Domain key: Vcenter

Cmdlets: `New-RscQueryVcenter` and `New-RscMutationVcenter`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AdvancedTagPreview | Preview list of virtual machines of a proposed filter condition  
  
Supported in v7.0+  
Preview list of virtual machines of a proposed filter condition. The result might not be accurate if new virtual machines were added after last vCenter refresh. | `New-RscQueryVcenter -Operation AdvancedTagPreview`<BR> | [vCenterAdvancedTagPreview](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| HotAddBandwidth | Get the ingest and export bandwidth limits for HotAdd with the vCenter  
  
Supported in v5.3+  
Get the ingest and export bandwidth limits in Mbps when using HotAdd with the vCenter. These limits are shared across all HotAdd proxies for the Center. | `New-RscQueryVcenter -Operation HotAddBandwidth`<BR> | [vCenterHotAddBandwidth](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| HotAddNetwork | Retrieve the user-configured network for HotAdd operations  
  
Supported in v5.3+  
Retrieve the user-configured network for HotAdd backup and recovery operations on VMware on AWS. | `New-RscQueryVcenter -Operation HotAddNetwork`<BR> | [vCenterHotAddNetwork](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| HotAddProxy | Get a list of HotAdd proxy virtual machines  
  
Supported in v5.3+  
Retrieve summary information for all HotAdd proxy virtual machines. | `New-RscQueryVcenter -Operation HotAddProxy`<BR> | [allVcenterHotAddProxyVms](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| List | N/A | `New-RscQueryVcenter -Operation List`<BR> | [vSphereVCenterConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Networks | Get the user-configured networks in the vCenter  
  
Supported in v5.3+  
Get the names and IDs of the user configured networks in the vCenter. This information enables users to choose a desired network for backups to go through for VMware Cloud on AWS setups. | `New-RscQueryVcenter -Operation Networks`<BR> | [vCenterNetworks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| NumProxiesNeeded | Get the number of HotAdd proxies needed for the vCenter  
  
Supported in v5.3+  
Get the number of HotAdd proxies that need to be deployed to the vCenter to support the maximum number of ingest jobs. | `New-RscQueryVcenter -Operation NumProxiesNeeded`<BR> | [vCenterNumProxiesNeeded](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PreAddInfo | Get preAddInfo for a vcenter. | `New-RscQueryVcenter -Operation PreAddInfo`<BR> | [vCenterPreAddInfo](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Vcenter | N/A | `New-RscQueryVcenter -Operation Vcenter`<BR> | [vSphereVCenter](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Create | Add a vCenter server. | `New-RscMutationVcenter -Operation Create`<BR> | [createVsphereVcenter](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Delete | Remove vCenter Server  
  
Supported in v5.0+  
Initiates an asynchronous job to remove a vCenter Server object. The vCenter Server cannot have VMs mounted through the Rubrik cluster. | `New-RscMutationVcenter -Operation Delete`<BR> | [vsphereDeleteVcenter](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Refresh | Refresh vCenter Server metadata  
  
Supported in v5.0+  
Create a job to refresh the metadata for the specified vCenter Server. | `New-RscMutationVcenter -Operation Refresh`<BR> | [refreshVsphereVcenter](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Update | Update vCenter Server  
  
Supported in v5.0+  
Update the address, username and password of the specified vCenter Server object. | `New-RscMutationVcenter -Operation Update`<BR> | [updateVcenter](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateHotAddBandwidth | Set the ingest and export bandwidth limits for HotAdd with the vCenter  
  
Supported in v5.3+  
Set the ingest and export bandwidth limits in Mbps when using HotAdd with the vCenter. These limits are shared across all HotAdd proxies for the Center. | `New-RscMutationVcenter -Operation UpdateHotAddBandwidth`<BR> | [updateVcenterHotAddBandwidth](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateHotAddNetwork | Set the user-configured network for HotAdd backup and recovery  
  
Supported in v5.3+  
Set the user-configured network for HotAdd backup and recovery operations on VMware on AWS. | `New-RscMutationVcenter -Operation UpdateHotAddNetwork`<BR> | [updateVcenterHotAddNetwork](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## VMware vSphere domain

Domain key: Vsphere

Cmdlets: `New-RscQueryVsphere` and `New-RscMutationVsphere`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| ComputeCluster | N/A | `New-RscQueryVsphere -Operation ComputeCluster`<BR> | [vSphereComputeCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ComputeClusters | Query compute clusters | `New-RscQueryVsphere -Operation ComputeClusters`<BR> | [vSphereComputeClusters](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Datacenter | N/A | `New-RscQueryVsphere -Operation Datacenter`<BR> | [vSphereDatacenter](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Datastore | Vsphere datastore based on id passed in. | `New-RscQueryVsphere -Operation Datastore`<BR> | [vSphereDatastore](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DatastoreCluster | Vsphere datastore cluster based on id passed in. | `New-RscQueryVsphere -Operation DatastoreCluster`<BR> | [vSphereDatastoreCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DatastoreClusters | Query vSphere datastore clusters. | `New-RscQueryVsphere -Operation DatastoreClusters`<BR> | [vSphereDatastoreClusters](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DatastoreList | N/A | `New-RscQueryVsphere -Operation DatastoreList`<BR> | [vSphereDatastoreConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Folder | N/A | `New-RscQueryVsphere -Operation Folder`<BR> | [vSphereFolder](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Folders | Get all the vSphere folders. | `New-RscQueryVsphere -Operation Folders`<BR> | [vSphereFolders](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Host | N/A | `New-RscQueryVsphere -Operation Host`<BR> | [vSphereHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| HostDetails | Get details of a ESXi hypervisor  
  
Supported in v5.0+  
Get details of a ESXi hypervisor. | `New-RscQueryVsphere -Operation HostDetails`<BR> | [vSphereHostDetails](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| HostList | N/A | `New-RscQueryVsphere -Operation HostList`<BR> | [vSphereHostConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| HostsByFids | All of the VSphere hosts based on fids passed in. | `New-RscQueryVsphere -Operation HostsByFids`<BR> | [vSphereHostsByFids](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| LiveMounts | List of vSphere Live Mounts. | `New-RscQueryVsphere -Operation LiveMounts`<BR> | [vSphereLiveMounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Mount | Get a vSphere Live Mount by id | `New-RscQueryVsphere -Operation Mount`<BR> | [vSphereMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| MountList | vSphere Live Mount Connection | `New-RscQueryVsphere -Operation MountList`<BR> | [vSphereMountConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Network | N/A | `New-RscQueryVsphere -Operation Network`<BR> | [vSphereNetwork](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ResourcePool | N/A | `New-RscQueryVsphere -Operation ResourcePool`<BR> | [vSphereResourcePool](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RootRecoveryHierarchy | The root hierarchy for VMware export, which includes VMware compute clusters and standalone hosts. | `New-RscQueryVsphere -Operation RootRecoveryHierarchy`<BR> | [vSphereRootRecoveryHierarchy](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Tag | N/A | `New-RscQueryVsphere -Operation Tag`<BR> | [vSphereTag](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TagCategory | N/A | `New-RscQueryVsphere -Operation TagCategory`<BR> | [vSphereTagCategory](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TopLevelDescendantsList | N/A | `New-RscQueryVsphere -Operation TopLevelDescendantsList`<BR> | [vSphereTopLevelDescendantsConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| VmwareCdpLiveInfo | N/A | `New-RscQueryVsphere -Operation VmwareCdpLiveInfo`<BR> | [vsphereVmwareCdpLiveInfo](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| BulkOnDemandSnapshot | Trigger a bulk on demand snapshot. | `New-RscMutationVsphere -Operation BulkOnDemandSnapshot`<BR> | [vsphereBulkOnDemandSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateAdvancedTag | Create a multi-tag filter for vSphere tags  
  
Supported in v7.0+  
Create a filter consisting of vSphere tags joined with logical operators. | `New-RscMutationVsphere -Operation CreateAdvancedTag`<BR> | [createVsphereAdvancedTag](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteAdvancedTag | Remove the multi-tag filter  
  
Supported in v7.0+  
Remove the multi-tag filter. | `New-RscMutationVsphere -Operation DeleteAdvancedTag`<BR> | [deleteVsphereAdvancedTag](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteLiveMount | Delete a Live Mount VM  
  
Supported in v5.0+  
Create a request to delete a Live Mount virtual machine. | `New-RscMutationVsphere -Operation DeleteLiveMount`<BR> | [deleteVsphereLiveMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DownloadVirtualMachineFiles | Download Virtual Machine files from a snapshot  
  
Supported in v9.0+  
Start an asynchronous job to download multiple Virtual Machine files, such as .vmdk, .vmx, and .nvram files, from the specified Virtual Machine snapshot. | `New-RscMutationVsphere -Operation DownloadVirtualMachineFiles`<BR> | [downloadVsphereVirtualMachineFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExportSnapshotToStandaloneHostV2 | Export snapshot of a virtual machine to standalone ESXi server. | `New-RscMutationVsphere -Operation ExportSnapshotToStandaloneHostV2`<BR> | [vsphereExportSnapshotToStandaloneHostV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| OnDemandSnapshot | N/A | `New-RscMutationVsphere -Operation OnDemandSnapshot`<BR> | [vsphereOnDemandSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateAdvancedTag | Update the multi-tag filter  
  
Supported in v7.0+  
Updates the name, condition, and description of the specified multi-tag filter. | `New-RscMutationVsphere -Operation UpdateAdvancedTag`<BR> | [updateVsphereAdvancedTag](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## VMware vSphere VM domain

Domain key: VsphereVm

Cmdlets: `New-RscQueryVsphereVm` and `New-RscMutationVsphereVm`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AsyncRequestStatus | N/A | `New-RscQueryVsphereVm -Operation AsyncRequestStatus`<BR> | [vSphereVMAsyncRequestStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| MissedRecoverableRange | N/A | `New-RscQueryVsphereVm -Operation MissedRecoverableRange`<BR> | [vsphereVMMissedRecoverableRange](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| New | N/A | `New-RscQueryVsphereVm -Operation New`<BR> | [vSphereVmNew](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| NewList | N/A | `New-RscQueryVsphereVm -Operation NewList`<BR> | [vSphereVmNewConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RecoverableRange | N/A | `New-RscQueryVsphereVm -Operation RecoverableRange`<BR> | [vsphereVMRecoverableRange](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RecoverableRangeInBatch | N/A | `New-RscQueryVsphereVm -Operation RecoverableRangeInBatch`<BR> | [vsphereVMRecoverableRangeInBatch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| BatchExport | Create a mass export for a group of virtual machines. | `New-RscMutationVsphereVm -Operation BatchExport`<BR> | [vsphereVmBatchExport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BatchExportV3 | Create a batch export for a group of virtual machines with datastore cluster support. | `New-RscMutationVsphereVm -Operation BatchExportV3`<BR> | [vsphereVmBatchExportV3](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BatchInPlaceRecovery | Supported in v6.0+. Export a snapshot each from a set of virtual machines. | `New-RscMutationVsphereVm -Operation BatchInPlaceRecovery`<BR> | [vsphereVmBatchInPlaceRecovery](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteSnapshot | Designate a snapshot as expired and available for garbage collection. The snapshot must be an on-demand snapshot or a snapshot from a virtual machine that is not assigned to an SLA Domain. | `New-RscMutationVsphereVm -Operation DeleteSnapshot`<BR> | [vsphereVmDeleteSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DownloadSnapshot | Download snapshot from archive  
  
Supported in v5.0+  
Provides a method for retrieving a snapshot, that is not available locally, from an archival location. | `New-RscMutationVsphereVm -Operation DownloadSnapshot`<BR> | [vsphereVmDownloadSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DownloadSnapshotFiles | Download files from snapshot. | `New-RscMutationVsphereVm -Operation DownloadSnapshotFiles`<BR> | [vsphereVmDownloadSnapshotFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExcludeVmDisks | Exclude or include virtual disks during snapshot. | `New-RscMutationVsphereVm -Operation ExcludeVmDisks`<BR> | [vsphereExcludeVmDisks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExportSnapshotV2 | Create a vSphere Export from a snapshot or a point-in-time. | `New-RscMutationVsphereVm -Operation ExportSnapshotV2`<BR> | [vsphereVmExportSnapshotV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExportSnapshotV3 | Create a vSphere Export from a snapshot or a point-in-time with datastore cluster and virtual disk mapping support. | `New-RscMutationVsphereVm -Operation ExportSnapshotV3`<BR> | [vsphereVmExportSnapshotV3](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExportSnapshotWithDownloadFromCloud | Download a snapshot from an archival location, then export a virtual machine using the downloaded snapshot  
  
Supported in v5.3+  
Download a snapshot from an archival location and then export a virtual machine using the downloaded snapshot. | `New-RscMutationVsphereVm -Operation ExportSnapshotWithDownloadFromCloud`<BR> | [vsphereVmExportSnapshotWithDownloadFromCloud](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| InitiateBatchInstantRecovery | Initiate a mass instant recovery for a group of VMs. | `New-RscMutationVsphereVm -Operation InitiateBatchInstantRecovery`<BR> | [vsphereVmInitiateBatchInstantRecovery](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| InitiateBatchLiveMountV2 | Initiate a mass live mount for a group of VMs. | `New-RscMutationVsphereVm -Operation InitiateBatchLiveMountV2`<BR> | [vsphereVmInitiateBatchLiveMountV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| InitiateDiskMount | Attaching disks from a snapshot to an existing virtual machine  
  
Supported in v5.0+  
Requests a snapshot mount to attach disks to an existing virtual machine. | `New-RscMutationVsphereVm -Operation InitiateDiskMount`<BR> | [vsphereVmInitiateDiskMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| InitiateInPlaceRecovery | Trigger an in-place recovery from a snapshot or point-in-time. | `New-RscMutationVsphereVm -Operation InitiateInPlaceRecovery`<BR> | [vsphereVmInitiateInPlaceRecovery](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| InitiateInstantRecoveryV2 | Instantly recover a vSphere virtual machine from a snapshot or point-in-time. | `New-RscMutationVsphereVm -Operation InitiateInstantRecoveryV2`<BR> | [vsphereVmInitiateInstantRecoveryV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| InitiateLiveMountV2 | Create a vSphere Live Mount from a snapshot or point-in-time. | `New-RscMutationVsphereVm -Operation InitiateLiveMountV2`<BR> | [vsphereVmInitiateLiveMountV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ListEsxiDatastores | List ESXi datastores  
  
Supported in v5.0+  
Retrieve a list of the datastores for a specified ESXi host. | `New-RscMutationVsphereVm -Operation ListEsxiDatastores`<BR> | [vsphereVmListEsxiDatastores](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| MountRelocate | Relocate a virtual machine to another datastore  
  
Supported in v5.0+  
Run storage VMotion to relocate a specified Live Mount into another data store. | `New-RscMutationVsphereVm -Operation MountRelocate`<BR> | [vsphereVmMountRelocate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| MountRelocateV2 | Create a Live Mount migration to a datastore or datastore cluster with virtual disk mapping support. | `New-RscMutationVsphereVm -Operation MountRelocateV2`<BR> | [vsphereVmMountRelocateV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PowerOnOffLiveMount | Power a Live Mount on and off  
  
Supported in v5.0+  
Power a specified Live Mount virtual machine on or off. Pass **_true_** to power the virtual machine on and pass **_false_** to power the virtual machine off. | `New-RscMutationVsphereVm -Operation PowerOnOffLiveMount`<BR> | [vsphereVmPowerOnOffLiveMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RecoverFiles | Restores multiple files/directories from snapshot. | `New-RscMutationVsphereVm -Operation RecoverFiles`<BR> | [vsphereVmRecoverFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RecoverFilesNew | Restores multiple files/directories from snapshot. | `New-RscMutationVsphereVm -Operation RecoverFilesNew`<BR> | [vsphereVmRecoverFilesNew](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RegisterAgent | Register Rubrik Backup Service  
  
Supported in v5.0+  
Register the Rubrik Backup Service that is running on a specified host with the specified Rubrik cluster. | `New-RscMutationVsphereVm -Operation RegisterAgent`<BR> | [vsphereVmRegisterAgent](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Update | Update VM  
  
Supported in v5.0+  
Update a virtual machine with specified properties. Use the guestCredential field to update the guest credential for a specified virtual machine. | `New-RscMutationVsphereVm -Operation Update`<BR> | [updateVsphereVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Webhook domain

Domain key: Webhook

Cmdlets: `New-RscQueryWebhook` and `New-RscMutationWebhook`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Webhook | All webhooks in the account. | `New-RscQueryWebhook -Operation Webhook`<BR> | [allWebhooks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Create | Create a webhook. | `New-RscMutationWebhook -Operation Create`<BR> | [createWebhook](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Delete | Delete a webhook. | `New-RscMutationWebhook -Operation Delete`<BR> | [deleteWebhook](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Test | Test a webhook configuration. | `New-RscMutationWebhook -Operation Test`<BR> | [testWebhook](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TestExisting | Test an existing webhook. | `New-RscMutationWebhook -Operation TestExisting`<BR> | [testExistingWebhook](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Update | Update a webhook. | `New-RscMutationWebhook -Operation Update`<BR> | [updateWebhook](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
