# API Domains and Operations

The RSC API is organized into 50 domain.
Each API domain is a set of related operations.

## Table of Contents

Numbers in parentheses indicate the number queries and mutations in the domain.

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Account (8,1)](#account-domain) | [Report Download (3,16)](#report-download-domain) | [Mongo (10,10)](#mongo-domain) | [RCV (1,3)](#rcv-domain) | [Tape (0,3)](#tape-domain) |
| [Activity series (4,3)](#activity-series-domain) | [Microsoft Exchange (7,4)](#microsoft-exchange-domain) | [Mosaic (4,3)](#mosaic-domain) | [Replication (4,5)](#replication-domain) | [Threat (4,3)](#threat-domain) |
| [AWS (28,33)](#aws-domain) | [Fileset (6,6)](#fileset-domain) | [MSSQL (16,17)](#mssql-domain) | [Report (2,9)](#report-domain) | [vSphere vCenter (9,6)](#vsphere-vcenter-domain) |
| [AWS Native (19,8)](#aws-native-domain) | [Google Cloud Platform (16,11)](#google-cloud-platform-domain) | [NAS (8,0)](#nas-domain) | [SAP HANA (8,9)](#sap-hana-domain) | [vSphere (23,8)](#vsphere-domain) |
| [Azure (65,51)](#azure-domain) | [Google Cloud Platform Native (7,6)](#google-cloud-platform-native-domain) | [NFS (0,3)](#nfs-domain) | [Service Account (1,4)](#service-account-domain) | [vSphere VM (6,24)](#vsphere-vm-domain) |
| [AzureO365 (11,1)](#azureo365-domain) | [Host (6,6)](#host-domain) | [Nutanix (18,25)](#nutanix-domain) | [Sharepoint (8,1)](#sharepoint-domain) | [Webhook (1,5)](#webhook-domain) |
| [Cassandra (8,5)](#cassandra-domain) | [Hyperv (14,23)](#hyperv-domain) | [O365 (37,31)](#o365-domain) | [SLA (14,9)](#sla-domain) | [Unmatched fields (384)](#unmatched-fields) |
| [Certificates (6,6)](#certificates-domain) | [Kubernetes (7,7)](#kubernetes-domain) | [Oracle (16,18)](#oracle-domain) | [SMB (2,4)](#smb-domain) | [Skipped fields (19)](#skipped-fields) |
| [Cloud Native (19,13)](#cloud-native-domain) | [LDAP (3,4)](#ldap-domain) | [Policy (6,1)](#policy-domain) | [Snapshot (21,15)](#snapshot-domain) |  |
| [Cluster (29,9)](#cluster-domain) | [M365 (1,4)](#m365-domain) | [Ransomware (12,1)](#ransomware-domain) | [Sonar (5,0)](#sonar-domain) |  |
| [Db2 (8,11)](#db2-domain) | [Managed Volume (4,11)](#managed-volume-domain) | [RCS (3,4)](#rcs-domain) | [Storage Arrays (1,4)](#storage-arrays-domain) |  |

## Account domain

Domain key: Account , e.g. '`-Domain Account`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| EnabledFeatures | [allEnabledFeaturesForAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Account -Operation EnabledFeatures`<BR>or<BR>`New-RscQuery -GqlQuery allEnabledFeaturesForAccount` |
| Id | [accountId](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Account -Operation Id`<BR>or<BR>`New-RscQuery -GqlQuery accountId` |
| Lookup | [lookupAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Account -Operation Lookup`<BR>or<BR>`New-RscQuery -GqlQuery lookupAccount` |
| Owners | [allAccountOwners](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Account -Operation Owners`<BR>or<BR>`New-RscQuery -GqlQuery allAccountOwners` |
| Products | [allAccountProducts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Account -Operation Products`<BR>or<BR>`New-RscQuery -GqlQuery allAccountProducts` |
| Settings | [accountSettings](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Account -Operation Settings`<BR>or<BR>`New-RscQuery -GqlQuery accountSettings` |
| Users | [allUsersOnAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Account -Operation Users`<BR>or<BR>`New-RscQuery -GqlQuery allUsersOnAccount` |
| WithExocomputeMappings | [allAccountsWithExocomputeMappings](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Account -Operation WithExocomputeMappings`<BR>or<BR>`New-RscQuery -GqlQuery allAccountsWithExocomputeMappings` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| DeleteUsers | [deleteUsersFromAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Account -Operation DeleteUsers`<BR>or<BR>`New-RscMutation -GqlMutation deleteUsersFromAccount` |

[Go to top](#)
## Activity series domain

Domain key: ActivitySeries , e.g. '`-Domain ActivitySeries`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| ActivitySeries | [activitySeries](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain ActivitySeries -Operation ActivitySeries`<BR>or<BR>`New-RscQuery -GqlQuery activitySeries` |
| List | [activitySeriesConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain ActivitySeries -Operation List`<BR>or<BR>`New-RscQuery -GqlQuery activitySeriesConnection` |
| UserFileTimeline | [userFileActivityTimeline](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain ActivitySeries -Operation UserFileTimeline`<BR>or<BR>`New-RscQuery -GqlQuery userFileActivityTimeline` |
| UserTimeline | [userActivityTimeline](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain ActivitySeries -Operation UserTimeline`<BR>or<BR>`New-RscQuery -GqlQuery userActivityTimeline` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| Cancel | [cancelActivitySeries](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain ActivitySeries -Operation Cancel`<BR>or<BR>`New-RscMutation -GqlMutation cancelActivitySeries` |
| DownloadUserCsv | [downloadUserActivityCsv](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain ActivitySeries -Operation DownloadUserCsv`<BR>or<BR>`New-RscMutation -GqlMutation downloadUserActivityCsv` |
| DownloadUserFileCsv | [downloadUserFileActivityCsv](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain ActivitySeries -Operation DownloadUserFileCsv`<BR>or<BR>`New-RscMutation -GqlMutation downloadUserFileActivityCsv` |

[Go to top](#)
## AWS domain

Domain key: Aws , e.g. '`-Domain Aws`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| ArtifactsToDelete | [awsArtifactsToDelete](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Aws -Operation ArtifactsToDelete`<BR>or<BR>`New-RscQuery -GqlQuery awsArtifactsToDelete` |
| AvailabilityZonesByRegion | [allAvailabilityZonesByRegionFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Aws -Operation AvailabilityZonesByRegion`<BR>or<BR>`New-RscQuery -GqlQuery allAvailabilityZonesByRegionFromAws` |
| CdmVersions | [allAwsCdmVersions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Aws -Operation CdmVersions`<BR>or<BR>`New-RscQuery -GqlQuery allAwsCdmVersions` |
| CloudAccountConfigs | [allAwsCloudAccountConfigs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Aws -Operation CloudAccountConfigs`<BR>or<BR>`New-RscQuery -GqlQuery allAwsCloudAccountConfigs` |
| CloudAccountListSecurityGroups | [awsCloudAccountListSecurityGroups](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Aws -Operation CloudAccountListSecurityGroups`<BR>or<BR>`New-RscQuery -GqlQuery awsCloudAccountListSecurityGroups` |
| CloudAccountListSubnets | [awsCloudAccountListSubnets](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Aws -Operation CloudAccountListSubnets`<BR>or<BR>`New-RscQuery -GqlQuery awsCloudAccountListSubnets` |
| CloudAccountListVpcs | [awsCloudAccountListVpcs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Aws -Operation CloudAccountListVpcs`<BR>or<BR>`New-RscQuery -GqlQuery awsCloudAccountListVpcs` |
| CloudAccountWithFeatures | [awsCloudAccountWithFeatures](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Aws -Operation CloudAccountWithFeatures`<BR>or<BR>`New-RscQuery -GqlQuery awsCloudAccountWithFeatures` |
| CloudAccountsWithFeatures | [allAwsCloudAccountsWithFeatures](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Aws -Operation CloudAccountsWithFeatures`<BR>or<BR>`New-RscQuery -GqlQuery allAwsCloudAccountsWithFeatures` |
| ComputeSettings | [awsComputeSettings](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Aws -Operation ComputeSettings`<BR>or<BR>`New-RscQuery -GqlQuery awsComputeSettings` |
| DbParameterGroupsByRegion | [allDbParameterGroupsByRegionFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Aws -Operation DbParameterGroupsByRegion`<BR>or<BR>`New-RscQuery -GqlQuery allDbParameterGroupsByRegionFromAws` |
| DbSubnetGroupsByRegion | [allDbSubnetGroupsByRegionFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Aws -Operation DbSubnetGroupsByRegion`<BR>or<BR>`New-RscQuery -GqlQuery allDbSubnetGroupsByRegionFromAws` |
| Ec2KeyPairsByRegion | [allEc2KeyPairsByRegionFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Aws -Operation Ec2KeyPairsByRegion`<BR>or<BR>`New-RscQuery -GqlQuery allEc2KeyPairsByRegionFromAws` |
| ExocomputeConfigs | [allAwsExocomputeConfigs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Aws -Operation ExocomputeConfigs`<BR>or<BR>`New-RscQuery -GqlQuery allAwsExocomputeConfigs` |
| InstanceProfileNames | [allAwsInstanceProfileNames](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Aws -Operation InstanceProfileNames`<BR>or<BR>`New-RscQuery -GqlQuery allAwsInstanceProfileNames` |
| IsS3BucketNameAvailable | [isAwsS3BucketNameAvailable](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Aws -Operation IsS3BucketNameAvailable`<BR>or<BR>`New-RscQuery -GqlQuery isAwsS3BucketNameAvailable` |
| KmsEncryptionKeysByRegion | [allKmsEncryptionKeysByRegionFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Aws -Operation KmsEncryptionKeysByRegion`<BR>or<BR>`New-RscQuery -GqlQuery allKmsEncryptionKeysByRegionFromAws` |
| OptionGroupsByRegion | [allOptionGroupsByRegionFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Aws -Operation OptionGroupsByRegion`<BR>or<BR>`New-RscQuery -GqlQuery allOptionGroupsByRegionFromAws` |
| PermissionPolicies | [allAwsPermissionPolicies](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Aws -Operation PermissionPolicies`<BR>or<BR>`New-RscQuery -GqlQuery allAwsPermissionPolicies` |
| RdsInstanceDetails | [rdsInstanceDetailsFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Aws -Operation RdsInstanceDetails`<BR>or<BR>`New-RscQuery -GqlQuery rdsInstanceDetailsFromAws` |
| Regions | [allAwsRegions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Aws -Operation Regions`<BR>or<BR>`New-RscQuery -GqlQuery allAwsRegions` |
| S3BucketStateForRecovery | [s3BucketStateForRecovery](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Aws -Operation S3BucketStateForRecovery`<BR>or<BR>`New-RscQuery -GqlQuery s3BucketStateForRecovery` |
| S3Buckets | [allS3BucketsFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Aws -Operation S3Buckets`<BR>or<BR>`New-RscQuery -GqlQuery allS3BucketsFromAws` |
| S3BucketsDetails | [allS3BucketsDetailsFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Aws -Operation S3BucketsDetails`<BR>or<BR>`New-RscQuery -GqlQuery allS3BucketsDetailsFromAws` |
| SupportedRdsDatabaseInstanceClasses | [allSupportedAwsRdsDatabaseInstanceClasses](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Aws -Operation SupportedRdsDatabaseInstanceClasses`<BR>or<BR>`New-RscQuery -GqlQuery allSupportedAwsRdsDatabaseInstanceClasses` |
| TrustPolicy | [awsTrustPolicy](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Aws -Operation TrustPolicy`<BR>or<BR>`New-RscQuery -GqlQuery awsTrustPolicy` |
| Vpcs | [allVpcsFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Aws -Operation Vpcs`<BR>or<BR>`New-RscQuery -GqlQuery allVpcsFromAws` |
| VpcsByRegion | [allVpcsByRegionFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Aws -Operation VpcsByRegion`<BR>or<BR>`New-RscQuery -GqlQuery allVpcsByRegionFromAws` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| AddAuthenticationServerBasedCloudAccount | [addAwsAuthenticationServerBasedCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Aws -Operation AddAuthenticationServerBasedCloudAccount`<BR>or<BR>`New-RscMutation -GqlMutation addAwsAuthenticationServerBasedCloudAccount` |
| AddIamUserBasedCloudAccount | [addAwsIamUserBasedCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Aws -Operation AddIamUserBasedCloudAccount`<BR>or<BR>`New-RscMutation -GqlMutation addAwsIamUserBasedCloudAccount` |
| BulkDeleteCloudAccountWithoutCft | [bulkDeleteAwsCloudAccountWithoutCft](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Aws -Operation BulkDeleteCloudAccountWithoutCft`<BR>or<BR>`New-RscMutation -GqlMutation bulkDeleteAwsCloudAccountWithoutCft` |
| CreateAccount | [createAwsAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Aws -Operation CreateAccount`<BR>or<BR>`New-RscMutation -GqlMutation createAwsAccount` |
| CreateAutomaticTargetMapping | [createAutomaticAwsTargetMapping](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Aws -Operation CreateAutomaticTargetMapping`<BR>or<BR>`New-RscMutation -GqlMutation createAutomaticAwsTargetMapping` |
| CreateCloudNativeStorageSetting | [createCloudNativeAwsStorageSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Aws -Operation CreateCloudNativeStorageSetting`<BR>or<BR>`New-RscMutation -GqlMutation createCloudNativeAwsStorageSetting` |
| CreateCluster | [createAwsCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Aws -Operation CreateCluster`<BR>or<BR>`New-RscMutation -GqlMutation createAwsCluster` |
| CreateComputeSetting | [createAwsComputeSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Aws -Operation CreateComputeSetting`<BR>or<BR>`New-RscMutation -GqlMutation createAwsComputeSetting` |
| CreateExocomputeConfigs | [createAwsExocomputeConfigs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Aws -Operation CreateExocomputeConfigs`<BR>or<BR>`New-RscMutation -GqlMutation createAwsExocomputeConfigs` |
| CreateReaderTarget | [createAwsReaderTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Aws -Operation CreateReaderTarget`<BR>or<BR>`New-RscMutation -GqlMutation createAwsReaderTarget` |
| CreateTarget | [createAwsTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Aws -Operation CreateTarget`<BR>or<BR>`New-RscMutation -GqlMutation createAwsTarget` |
| DeleteCluster | [deleteAwsCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Aws -Operation DeleteCluster`<BR>or<BR>`New-RscMutation -GqlMutation deleteAwsCluster` |
| DeleteComputeSetting | [deleteAwsComputeSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Aws -Operation DeleteComputeSetting`<BR>or<BR>`New-RscMutation -GqlMutation deleteAwsComputeSetting` |
| DeleteExocomputeConfigs | [deleteAwsExocomputeConfigs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Aws -Operation DeleteExocomputeConfigs`<BR>or<BR>`New-RscMutation -GqlMutation deleteAwsExocomputeConfigs` |
| FinalizeCloudAccountDeletion | [finalizeAwsCloudAccountDeletion](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Aws -Operation FinalizeCloudAccountDeletion`<BR>or<BR>`New-RscMutation -GqlMutation finalizeAwsCloudAccountDeletion` |
| FinalizeCloudAccountProtection | [finalizeAwsCloudAccountProtection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Aws -Operation FinalizeCloudAccountProtection`<BR>or<BR>`New-RscMutation -GqlMutation finalizeAwsCloudAccountProtection` |
| PatchAuthenticationServerBasedCloudAccount | [patchAwsAuthenticationServerBasedCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Aws -Operation PatchAuthenticationServerBasedCloudAccount`<BR>or<BR>`New-RscMutation -GqlMutation patchAwsAuthenticationServerBasedCloudAccount` |
| PatchIamUserBasedCloudAccount | [patchAwsIamUserBasedCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Aws -Operation PatchIamUserBasedCloudAccount`<BR>or<BR>`New-RscMutation -GqlMutation patchAwsIamUserBasedCloudAccount` |
| PrepareCloudAccountDeletion | [prepareAwsCloudAccountDeletion](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Aws -Operation PrepareCloudAccountDeletion`<BR>or<BR>`New-RscMutation -GqlMutation prepareAwsCloudAccountDeletion` |
| PrepareFeatureUpdateForCloudAccount | [prepareFeatureUpdateForAwsCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Aws -Operation PrepareFeatureUpdateForCloudAccount`<BR>or<BR>`New-RscMutation -GqlMutation prepareFeatureUpdateForAwsCloudAccount` |
| RegisterFeatureArtifacts | [registerAwsFeatureArtifacts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Aws -Operation RegisterFeatureArtifacts`<BR>or<BR>`New-RscMutation -GqlMutation registerAwsFeatureArtifacts` |
| StartExocomputeDisableJob | [startAwsExocomputeDisableJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Aws -Operation StartExocomputeDisableJob`<BR>or<BR>`New-RscMutation -GqlMutation startAwsExocomputeDisableJob` |
| UpdateAccount | [updateAwsAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Aws -Operation UpdateAccount`<BR>or<BR>`New-RscMutation -GqlMutation updateAwsAccount` |
| UpdateAutomaticTargetMapping | [updateAutomaticAwsTargetMapping](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Aws -Operation UpdateAutomaticTargetMapping`<BR>or<BR>`New-RscMutation -GqlMutation updateAutomaticAwsTargetMapping` |
| UpdateCloudAccount | [updateAwsCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Aws -Operation UpdateCloudAccount`<BR>or<BR>`New-RscMutation -GqlMutation updateAwsCloudAccount` |
| UpdateCloudAccountFeature | [updateAwsCloudAccountFeature](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Aws -Operation UpdateCloudAccountFeature`<BR>or<BR>`New-RscMutation -GqlMutation updateAwsCloudAccountFeature` |
| UpdateCloudNativeStorageSetting | [updateCloudNativeAwsStorageSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Aws -Operation UpdateCloudNativeStorageSetting`<BR>or<BR>`New-RscMutation -GqlMutation updateCloudNativeAwsStorageSetting` |
| UpdateComputeSetting | [updateAwsComputeSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Aws -Operation UpdateComputeSetting`<BR>or<BR>`New-RscMutation -GqlMutation updateAwsComputeSetting` |
| UpdateExocomputeConfigs | [updateAwsExocomputeConfigs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Aws -Operation UpdateExocomputeConfigs`<BR>or<BR>`New-RscMutation -GqlMutation updateAwsExocomputeConfigs` |
| UpdateTarget | [updateAwsTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Aws -Operation UpdateTarget`<BR>or<BR>`New-RscMutation -GqlMutation updateAwsTarget` |
| UpgradeCloudAccountFeaturesWithoutCft | [upgradeAwsCloudAccountFeaturesWithoutCft](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Aws -Operation UpgradeCloudAccountFeaturesWithoutCft`<BR>or<BR>`New-RscMutation -GqlMutation upgradeAwsCloudAccountFeaturesWithoutCft` |
| UpgradeIamUserBasedCloudAccountPermissions | [upgradeAwsIamUserBasedCloudAccountPermissions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Aws -Operation UpgradeIamUserBasedCloudAccountPermissions`<BR>or<BR>`New-RscMutation -GqlMutation upgradeAwsIamUserBasedCloudAccountPermissions` |
| ValidateAndCreateCloudAccount | [validateAndCreateAwsCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Aws -Operation ValidateAndCreateCloudAccount`<BR>or<BR>`New-RscMutation -GqlMutation validateAndCreateAwsCloudAccount` |

[Go to top](#)
## AWS Native domain

Domain key: Awsnative , e.g. '`-Domain Awsnative`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| Account | [awsNativeAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Awsnative -Operation Account`<BR>or<BR>`New-RscQuery -GqlQuery awsNativeAccount` |
| Accounts | [awsNativeAccounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Awsnative -Operation Accounts`<BR>or<BR>`New-RscQuery -GqlQuery awsNativeAccounts` |
| AmiTypeForArchivedSnapshotExport | [amiTypeForAwsNativeArchivedSnapshotExport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Awsnative -Operation AmiTypeForArchivedSnapshotExport`<BR>or<BR>`New-RscQuery -GqlQuery amiTypeForAwsNativeArchivedSnapshotExport` |
| EbsVolume | [awsNativeEbsVolume](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Awsnative -Operation EbsVolume`<BR>or<BR>`New-RscQuery -GqlQuery awsNativeEbsVolume` |
| EbsVolumes | [awsNativeEbsVolumes](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Awsnative -Operation EbsVolumes`<BR>or<BR>`New-RscQuery -GqlQuery awsNativeEbsVolumes` |
| EbsVolumesByName | [awsNativeEbsVolumesByName](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Awsnative -Operation EbsVolumesByName`<BR>or<BR>`New-RscQuery -GqlQuery awsNativeEbsVolumesByName` |
| Ec2Instance | [awsNativeEc2Instance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Awsnative -Operation Ec2Instance`<BR>or<BR>`New-RscQuery -GqlQuery awsNativeEc2Instance` |
| Ec2Instances | [awsNativeEc2Instances](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Awsnative -Operation Ec2Instances`<BR>or<BR>`New-RscQuery -GqlQuery awsNativeEc2Instances` |
| Ec2InstancesByName | [awsNativeEc2InstancesByName](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Awsnative -Operation Ec2InstancesByName`<BR>or<BR>`New-RscQuery -GqlQuery awsNativeEc2InstancesByName` |
| IsEbsVolumeSnapshotRestorable | [isAwsNativeEbsVolumeSnapshotRestorable](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Awsnative -Operation IsEbsVolumeSnapshotRestorable`<BR>or<BR>`New-RscQuery -GqlQuery isAwsNativeEbsVolumeSnapshotRestorable` |
| IsRdsInstanceLaunchConfigurationValid | [isAwsNativeRdsInstanceLaunchConfigurationValid](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Awsnative -Operation IsRdsInstanceLaunchConfigurationValid`<BR>or<BR>`New-RscQuery -GqlQuery isAwsNativeRdsInstanceLaunchConfigurationValid` |
| RdsExportDefaults | [awsNativeRdsExportDefaults](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Awsnative -Operation RdsExportDefaults`<BR>or<BR>`New-RscQuery -GqlQuery awsNativeRdsExportDefaults` |
| RdsInstance | [awsNativeRdsInstance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Awsnative -Operation RdsInstance`<BR>or<BR>`New-RscQuery -GqlQuery awsNativeRdsInstance` |
| RdsInstances | [awsNativeRdsInstances](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Awsnative -Operation RdsInstances`<BR>or<BR>`New-RscQuery -GqlQuery awsNativeRdsInstances` |
| RdsPointInTimeRestoreWindow | [awsNativeRdsPointInTimeRestoreWindow](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Awsnative -Operation RdsPointInTimeRestoreWindow`<BR>or<BR>`New-RscQuery -GqlQuery awsNativeRdsPointInTimeRestoreWindow` |
| Root | [awsNativeRoot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Awsnative -Operation Root`<BR>or<BR>`New-RscQuery -GqlQuery awsNativeRoot` |
| S3Bucket | [awsNativeS3Bucket](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Awsnative -Operation S3Bucket`<BR>or<BR>`New-RscQuery -GqlQuery awsNativeS3Bucket` |
| ValidateRdsClusterNameForExport | [validateAwsNativeRdsClusterNameForExport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Awsnative -Operation ValidateRdsClusterNameForExport`<BR>or<BR>`New-RscQuery -GqlQuery validateAwsNativeRdsClusterNameForExport` |
| ValidateRdsInstanceNameForExport | [validateAwsNativeRdsInstanceNameForExport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Awsnative -Operation ValidateRdsInstanceNameForExport`<BR>or<BR>`New-RscQuery -GqlQuery validateAwsNativeRdsInstanceNameForExport` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| ExcludeEbsVolumesFromSnapshot | [excludeAwsNativeEbsVolumesFromSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Awsnative -Operation ExcludeEbsVolumesFromSnapshot`<BR>or<BR>`New-RscMutation -GqlMutation excludeAwsNativeEbsVolumesFromSnapshot` |
| StartAccountDisableJob | [startAwsNativeAccountDisableJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Awsnative -Operation StartAccountDisableJob`<BR>or<BR>`New-RscMutation -GqlMutation startAwsNativeAccountDisableJob` |
| StartCreateEbsVolumeSnapshotsJob | [startCreateAwsNativeEbsVolumeSnapshotsJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Awsnative -Operation StartCreateEbsVolumeSnapshotsJob`<BR>or<BR>`New-RscMutation -GqlMutation startCreateAwsNativeEbsVolumeSnapshotsJob` |
| StartEc2InstanceSnapshotsJob | [startAwsNativeEc2InstanceSnapshotsJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Awsnative -Operation StartEc2InstanceSnapshotsJob`<BR>or<BR>`New-RscMutation -GqlMutation startAwsNativeEc2InstanceSnapshotsJob` |
| StartExportEbsVolumeSnapshotJob | [startExportAwsNativeEbsVolumeSnapshotJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Awsnative -Operation StartExportEbsVolumeSnapshotJob`<BR>or<BR>`New-RscMutation -GqlMutation startExportAwsNativeEbsVolumeSnapshotJob` |
| StartRdsInstanceSnapshotsJob | [startAwsNativeRdsInstanceSnapshotsJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Awsnative -Operation StartRdsInstanceSnapshotsJob`<BR>or<BR>`New-RscMutation -GqlMutation startAwsNativeRdsInstanceSnapshotsJob` |
| StartRefreshAccountsJob | [startRefreshAwsNativeAccountsJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Awsnative -Operation StartRefreshAccountsJob`<BR>or<BR>`New-RscMutation -GqlMutation startRefreshAwsNativeAccountsJob` |
| StartRestoreEc2InstanceSnapshotJob | [startRestoreAwsNativeEc2InstanceSnapshotJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Awsnative -Operation StartRestoreEc2InstanceSnapshotJob`<BR>or<BR>`New-RscMutation -GqlMutation startRestoreAwsNativeEc2InstanceSnapshotJob` |

[Go to top](#)
## Azure domain

Domain key: Azure , e.g. '`-Domain Azure`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| AdDirectories | [azureAdDirectories](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation AdDirectories`<BR>or<BR>`New-RscQuery -GqlQuery azureAdDirectories` |
| AdDirectory | [azureAdDirectory](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation AdDirectory`<BR>or<BR>`New-RscQuery -GqlQuery azureAdDirectory` |
| AdObjectsByType | [azureAdObjectsByType](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation AdObjectsByType`<BR>or<BR>`New-RscQuery -GqlQuery azureAdObjectsByType` |
| ArmTemplatesByFeature | [allAzureArmTemplatesByFeature](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation ArmTemplatesByFeature`<BR>or<BR>`New-RscQuery -GqlQuery allAzureArmTemplatesByFeature` |
| AzureNativeAvailabilitySetsByRegion | [allAzureNativeAvailabilitySetsByRegionFromAzure](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation AzureNativeAvailabilitySetsByRegion`<BR>or<BR>`New-RscQuery -GqlQuery allAzureNativeAvailabilitySetsByRegionFromAzure` |
| AzureNativeExportCompatibleDiskTypesByRegion | [allAzureNativeExportCompatibleDiskTypesByRegionFromAzure](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation AzureNativeExportCompatibleDiskTypesByRegion`<BR>or<BR>`New-RscQuery -GqlQuery allAzureNativeExportCompatibleDiskTypesByRegionFromAzure` |
| AzureNativeExportCompatibleVmSizesByRegion | [allAzureNativeExportCompatibleVmSizesByRegionFromAzure](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation AzureNativeExportCompatibleVmSizesByRegion`<BR>or<BR>`New-RscQuery -GqlQuery allAzureNativeExportCompatibleVmSizesByRegionFromAzure` |
| AzureNativeSecurityGroupsByRegion | [allAzureNativeSecurityGroupsByRegionFromAzure](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation AzureNativeSecurityGroupsByRegion`<BR>or<BR>`New-RscQuery -GqlQuery allAzureNativeSecurityGroupsByRegionFromAzure` |
| AzureNativeStorageAccounts | [allAzureNativeStorageAccountsFromAzure](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation AzureNativeStorageAccounts`<BR>or<BR>`New-RscQuery -GqlQuery allAzureNativeStorageAccountsFromAzure` |
| AzureNativeSubnetsByRegion | [allAzureNativeSubnetsByRegionFromAzure](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation AzureNativeSubnetsByRegion`<BR>or<BR>`New-RscQuery -GqlQuery allAzureNativeSubnetsByRegionFromAzure` |
| CdmVersions | [allAzureCdmVersions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation CdmVersions`<BR>or<BR>`New-RscQuery -GqlQuery allAzureCdmVersions` |
| CheckPersistentStorageSubscriptionCanUnmap | [checkAzurePersistentStorageSubscriptionCanUnmap](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation CheckPersistentStorageSubscriptionCanUnmap`<BR>or<BR>`New-RscQuery -GqlQuery checkAzurePersistentStorageSubscriptionCanUnmap` |
| CloudAccountMissingPermissions | [allAzureCloudAccountMissingPermissions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation CloudAccountMissingPermissions`<BR>or<BR>`New-RscQuery -GqlQuery allAzureCloudAccountMissingPermissions` |
| CloudAccountPermissionConfig | [azureCloudAccountPermissionConfig](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation CloudAccountPermissionConfig`<BR>or<BR>`New-RscQuery -GqlQuery azureCloudAccountPermissionConfig` |
| CloudAccountSubnetsByRegion | [allAzureCloudAccountSubnetsByRegion](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation CloudAccountSubnetsByRegion`<BR>or<BR>`New-RscQuery -GqlQuery allAzureCloudAccountSubnetsByRegion` |
| CloudAccountSubscriptionWithFeatures | [azureCloudAccountSubscriptionWithFeatures](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation CloudAccountSubscriptionWithFeatures`<BR>or<BR>`New-RscQuery -GqlQuery azureCloudAccountSubscriptionWithFeatures` |
| CloudAccountSubscriptionsByFeature | [allAzureCloudAccountSubscriptionsByFeature](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation CloudAccountSubscriptionsByFeature`<BR>or<BR>`New-RscQuery -GqlQuery allAzureCloudAccountSubscriptionsByFeature` |
| CloudAccountTenant | [azureCloudAccountTenant](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation CloudAccountTenant`<BR>or<BR>`New-RscQuery -GqlQuery azureCloudAccountTenant` |
| CloudAccountTenantWithExoConfigs | [azureCloudAccountTenantWithExoConfigs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation CloudAccountTenantWithExoConfigs`<BR>or<BR>`New-RscQuery -GqlQuery azureCloudAccountTenantWithExoConfigs` |
| CloudAccountTenants | [allAzureCloudAccountTenants](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation CloudAccountTenants`<BR>or<BR>`New-RscQuery -GqlQuery allAzureCloudAccountTenants` |
| DiskEncryptionSetsByRegion | [allAzureDiskEncryptionSetsByRegion](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation DiskEncryptionSetsByRegion`<BR>or<BR>`New-RscQuery -GqlQuery allAzureDiskEncryptionSetsByRegion` |
| DoesNativeResourceGroupExist | [doesAzureNativeResourceGroupExist](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation DoesNativeResourceGroupExist`<BR>or<BR>`New-RscQuery -GqlQuery doesAzureNativeResourceGroupExist` |
| EncryptionKeys | [allAzureEncryptionKeys](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation EncryptionKeys`<BR>or<BR>`New-RscQuery -GqlQuery allAzureEncryptionKeys` |
| ExocomputeConfigsInAccount | [allAzureExocomputeConfigsInAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation ExocomputeConfigsInAccount`<BR>or<BR>`New-RscQuery -GqlQuery allAzureExocomputeConfigsInAccount` |
| HostedAzureRegions | [allHostedAzureRegions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation HostedAzureRegions`<BR>or<BR>`New-RscQuery -GqlQuery allHostedAzureRegions` |
| IsNativeManagedDiskSnapshotRestorable | [isAzureNativeManagedDiskSnapshotRestorable](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation IsNativeManagedDiskSnapshotRestorable`<BR>or<BR>`New-RscQuery -GqlQuery isAzureNativeManagedDiskSnapshotRestorable` |
| IsNativeSqlDatabaseSnapshotPersistent | [isAzureNativeSqlDatabaseSnapshotPersistent](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation IsNativeSqlDatabaseSnapshotPersistent`<BR>or<BR>`New-RscQuery -GqlQuery isAzureNativeSqlDatabaseSnapshotPersistent` |
| IsStorageAccountNameAvailable | [isAzureStorageAccountNameAvailable](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation IsStorageAccountNameAvailable`<BR>or<BR>`New-RscQuery -GqlQuery isAzureStorageAccountNameAvailable` |
| KeyVaultsByRegion | [allAzureKeyVaultsByRegion](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation KeyVaultsByRegion`<BR>or<BR>`New-RscQuery -GqlQuery allAzureKeyVaultsByRegion` |
| ManagedIdentities | [allAzureManagedIdentities](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation ManagedIdentities`<BR>or<BR>`New-RscQuery -GqlQuery allAzureManagedIdentities` |
| NativeManagedDisk | [azureNativeManagedDisk](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation NativeManagedDisk`<BR>or<BR>`New-RscQuery -GqlQuery azureNativeManagedDisk` |
| NativeManagedDisks | [azureNativeManagedDisks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation NativeManagedDisks`<BR>or<BR>`New-RscQuery -GqlQuery azureNativeManagedDisks` |
| NativeResourceGroup | [azureNativeResourceGroup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation NativeResourceGroup`<BR>or<BR>`New-RscQuery -GqlQuery azureNativeResourceGroup` |
| NativeResourceGroups | [azureNativeResourceGroups](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation NativeResourceGroups`<BR>or<BR>`New-RscQuery -GqlQuery azureNativeResourceGroups` |
| NativeResourceGroupsInfoIfExist | [allAzureNativeResourceGroupsInfoIfExist](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation NativeResourceGroupsInfoIfExist`<BR>or<BR>`New-RscQuery -GqlQuery allAzureNativeResourceGroupsInfoIfExist` |
| NativeRoot | [azureNativeRoot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation NativeRoot`<BR>or<BR>`New-RscQuery -GqlQuery azureNativeRoot` |
| NativeSubscription | [azureNativeSubscription](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation NativeSubscription`<BR>or<BR>`New-RscQuery -GqlQuery azureNativeSubscription` |
| NativeSubscriptions | [azureNativeSubscriptions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation NativeSubscriptions`<BR>or<BR>`New-RscQuery -GqlQuery azureNativeSubscriptions` |
| NativeVirtualMachine | [azureNativeVirtualMachine](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation NativeVirtualMachine`<BR>or<BR>`New-RscQuery -GqlQuery azureNativeVirtualMachine` |
| NativeVirtualMachineSizes | [allAzureNativeVirtualMachineSizes](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation NativeVirtualMachineSizes`<BR>or<BR>`New-RscQuery -GqlQuery allAzureNativeVirtualMachineSizes` |
| NativeVirtualMachines | [azureNativeVirtualMachines](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation NativeVirtualMachines`<BR>or<BR>`New-RscQuery -GqlQuery azureNativeVirtualMachines` |
| NativeVirtualNetworks | [allAzureNativeVirtualNetworks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation NativeVirtualNetworks`<BR>or<BR>`New-RscQuery -GqlQuery allAzureNativeVirtualNetworks` |
| Nsgs | [allAzureNsgs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation Nsgs`<BR>or<BR>`New-RscQuery -GqlQuery allAzureNsgs` |
| Regions | [azureRegions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation Regions`<BR>or<BR>`New-RscQuery -GqlQuery azureRegions` |
| ResourceGroups | [allResourceGroupsFromAzure](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation ResourceGroups`<BR>or<BR>`New-RscQuery -GqlQuery allResourceGroupsFromAzure` |
| SearchAdSnapshot | [searchAzureAdSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation SearchAdSnapshot`<BR>or<BR>`New-RscQuery -GqlQuery searchAzureAdSnapshot` |
| SqlDatabase | [azureSqlDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation SqlDatabase`<BR>or<BR>`New-RscQuery -GqlQuery azureSqlDatabase` |
| SqlDatabaseDbPointInTimeRestoreWindowFromAzure | [azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation SqlDatabaseDbPointInTimeRestoreWindowFromAzure`<BR>or<BR>`New-RscQuery -GqlQuery azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure` |
| SqlDatabaseServer | [azureSqlDatabaseServer](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation SqlDatabaseServer`<BR>or<BR>`New-RscQuery -GqlQuery azureSqlDatabaseServer` |
| SqlDatabaseServerElasticPools | [allAzureSqlDatabaseServerElasticPools](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation SqlDatabaseServerElasticPools`<BR>or<BR>`New-RscQuery -GqlQuery allAzureSqlDatabaseServerElasticPools` |
| SqlDatabaseServers | [azureSqlDatabaseServers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation SqlDatabaseServers`<BR>or<BR>`New-RscQuery -GqlQuery azureSqlDatabaseServers` |
| SqlDatabases | [azureSqlDatabases](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation SqlDatabases`<BR>or<BR>`New-RscQuery -GqlQuery azureSqlDatabases` |
| SqlManagedInstanceDatabase | [azureSqlManagedInstanceDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation SqlManagedInstanceDatabase`<BR>or<BR>`New-RscQuery -GqlQuery azureSqlManagedInstanceDatabase` |
| SqlManagedInstanceDatabases | [azureSqlManagedInstanceDatabases](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation SqlManagedInstanceDatabases`<BR>or<BR>`New-RscQuery -GqlQuery azureSqlManagedInstanceDatabases` |
| SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure | [azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure`<BR>or<BR>`New-RscQuery -GqlQuery azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure` |
| SqlManagedInstanceServer | [azureSqlManagedInstanceServer](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation SqlManagedInstanceServer`<BR>or<BR>`New-RscQuery -GqlQuery azureSqlManagedInstanceServer` |
| SqlManagedInstanceServers | [azureSqlManagedInstanceServers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation SqlManagedInstanceServers`<BR>or<BR>`New-RscQuery -GqlQuery azureSqlManagedInstanceServers` |
| StorageAccounts | [azureStorageAccounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation StorageAccounts`<BR>or<BR>`New-RscQuery -GqlQuery azureStorageAccounts` |
| Subnets | [azureSubnets](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation Subnets`<BR>or<BR>`New-RscQuery -GqlQuery azureSubnets` |
| SubscriptionWithExocomputeMappings | [allAzureSubscriptionWithExocomputeMappings](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation SubscriptionWithExocomputeMappings`<BR>or<BR>`New-RscQuery -GqlQuery allAzureSubscriptionWithExocomputeMappings` |
| Subscriptions | [azureSubscriptions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation Subscriptions`<BR>or<BR>`New-RscQuery -GqlQuery azureSubscriptions` |
| VNets | [azureVNets](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation VNets`<BR>or<BR>`New-RscQuery -GqlQuery azureVNets` |
| ValidateCloudAccountExocomputeConfigurations | [validateAzureCloudAccountExocomputeConfigurations](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation ValidateCloudAccountExocomputeConfigurations`<BR>or<BR>`New-RscQuery -GqlQuery validateAzureCloudAccountExocomputeConfigurations` |
| ValidateNativeSqlDatabaseDbNameForExport | [validateAzureNativeSqlDatabaseDbNameForExport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation ValidateNativeSqlDatabaseDbNameForExport`<BR>or<BR>`New-RscQuery -GqlQuery validateAzureNativeSqlDatabaseDbNameForExport` |
| ValidateNativeSqlManagedInstanceDbNameForExport | [validateAzureNativeSqlManagedInstanceDbNameForExport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Azure -Operation ValidateNativeSqlManagedInstanceDbNameForExport`<BR>or<BR>`New-RscQuery -GqlQuery validateAzureNativeSqlManagedInstanceDbNameForExport` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| AddCloudAccount | [addAzureCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation AddCloudAccount`<BR>or<BR>`New-RscMutation -GqlMutation addAzureCloudAccount` |
| AddCloudAccountExocomputeConfigurations | [addAzureCloudAccountExocomputeConfigurations](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation AddCloudAccountExocomputeConfigurations`<BR>or<BR>`New-RscMutation -GqlMutation addAzureCloudAccountExocomputeConfigurations` |
| AddCloudAccountWithoutOauth | [addAzureCloudAccountWithoutOauth](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation AddCloudAccountWithoutOauth`<BR>or<BR>`New-RscMutation -GqlMutation addAzureCloudAccountWithoutOauth` |
| BackupAdDirectory | [backupAzureAdDirectory](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation BackupAdDirectory`<BR>or<BR>`New-RscMutation -GqlMutation backupAzureAdDirectory` |
| CompleteAdAppSetup | [completeAzureAdAppSetup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation CompleteAdAppSetup`<BR>or<BR>`New-RscMutation -GqlMutation completeAzureAdAppSetup` |
| CompleteAdAppUpdate | [completeAzureAdAppUpdate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation CompleteAdAppUpdate`<BR>or<BR>`New-RscMutation -GqlMutation completeAzureAdAppUpdate` |
| CompleteCloudAccountOauth | [completeAzureCloudAccountOauth](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation CompleteCloudAccountOauth`<BR>or<BR>`New-RscMutation -GqlMutation completeAzureCloudAccountOauth` |
| CreateAccount | [createAzureAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation CreateAccount`<BR>or<BR>`New-RscMutation -GqlMutation createAzureAccount` |
| CreateAutomaticTargetMapping | [createAutomaticAzureTargetMapping](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation CreateAutomaticTargetMapping`<BR>or<BR>`New-RscMutation -GqlMutation createAutomaticAzureTargetMapping` |
| CreateCloudNativeRcvStorageSetting | [createCloudNativeRcvAzureStorageSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation CreateCloudNativeRcvStorageSetting`<BR>or<BR>`New-RscMutation -GqlMutation createCloudNativeRcvAzureStorageSetting` |
| CreateCloudNativeStorageSetting | [createCloudNativeAzureStorageSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation CreateCloudNativeStorageSetting`<BR>or<BR>`New-RscMutation -GqlMutation createCloudNativeAzureStorageSetting` |
| CreateCluster | [createAzureCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation CreateCluster`<BR>or<BR>`New-RscMutation -GqlMutation createAzureCluster` |
| CreateReaderTarget | [createAzureReaderTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation CreateReaderTarget`<BR>or<BR>`New-RscMutation -GqlMutation createAzureReaderTarget` |
| CreateSaasAppAad | [createAzureSaasAppAad](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation CreateSaasAppAad`<BR>or<BR>`New-RscMutation -GqlMutation createAzureSaasAppAad` |
| CreateTarget | [createAzureTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation CreateTarget`<BR>or<BR>`New-RscMutation -GqlMutation createAzureTarget` |
| DeleteAdDirectory | [deleteAzureAdDirectory](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation DeleteAdDirectory`<BR>or<BR>`New-RscMutation -GqlMutation deleteAzureAdDirectory` |
| DeleteCloudAccount | [deleteAzureCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation DeleteCloudAccount`<BR>or<BR>`New-RscMutation -GqlMutation deleteAzureCloudAccount` |
| DeleteCloudAccountExocomputeConfigurations | [deleteAzureCloudAccountExocomputeConfigurations](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation DeleteCloudAccountExocomputeConfigurations`<BR>or<BR>`New-RscMutation -GqlMutation deleteAzureCloudAccountExocomputeConfigurations` |
| DeleteCloudAccountWithoutOauth | [deleteAzureCloudAccountWithoutOauth](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation DeleteCloudAccountWithoutOauth`<BR>or<BR>`New-RscMutation -GqlMutation deleteAzureCloudAccountWithoutOauth` |
| DeleteCluster | [deleteAzureCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation DeleteCluster`<BR>or<BR>`New-RscMutation -GqlMutation deleteAzureCluster` |
| ExcludeNativeManagedDisksFromSnapshot | [excludeAzureNativeManagedDisksFromSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation ExcludeNativeManagedDisksFromSnapshot`<BR>or<BR>`New-RscMutation -GqlMutation excludeAzureNativeManagedDisksFromSnapshot` |
| MapCloudAccountExocomputeSubscription | [mapAzureCloudAccountExocomputeSubscription](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation MapCloudAccountExocomputeSubscription`<BR>or<BR>`New-RscMutation -GqlMutation mapAzureCloudAccountExocomputeSubscription` |
| MapCloudAccountToPersistentStorageLocation | [mapAzureCloudAccountToPersistentStorageLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation MapCloudAccountToPersistentStorageLocation`<BR>or<BR>`New-RscMutation -GqlMutation mapAzureCloudAccountToPersistentStorageLocation` |
| OauthConsentComplete | [azureOauthConsentComplete](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation OauthConsentComplete`<BR>or<BR>`New-RscMutation -GqlMutation azureOauthConsentComplete` |
| OauthConsentKickoff | [azureOauthConsentKickoff](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation OauthConsentKickoff`<BR>or<BR>`New-RscMutation -GqlMutation azureOauthConsentKickoff` |
| RestoreAdObjectsWithPasswords | [restoreAzureAdObjectsWithPasswords](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation RestoreAdObjectsWithPasswords`<BR>or<BR>`New-RscMutation -GqlMutation restoreAzureAdObjectsWithPasswords` |
| SetCloudAccountCustomerAppCredentials | [setAzureCloudAccountCustomerAppCredentials](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation SetCloudAccountCustomerAppCredentials`<BR>or<BR>`New-RscMutation -GqlMutation setAzureCloudAccountCustomerAppCredentials` |
| StartAdAppSetup | [startAzureAdAppSetup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation StartAdAppSetup`<BR>or<BR>`New-RscMutation -GqlMutation startAzureAdAppSetup` |
| StartAdAppUpdate | [startAzureAdAppUpdate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation StartAdAppUpdate`<BR>or<BR>`New-RscMutation -GqlMutation startAzureAdAppUpdate` |
| StartCloudAccountOauth | [startAzureCloudAccountOauth](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation StartCloudAccountOauth`<BR>or<BR>`New-RscMutation -GqlMutation startAzureCloudAccountOauth` |
| StartCreateNativeManagedDiskSnapshotsJob | [startCreateAzureNativeManagedDiskSnapshotsJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation StartCreateNativeManagedDiskSnapshotsJob`<BR>or<BR>`New-RscMutation -GqlMutation startCreateAzureNativeManagedDiskSnapshotsJob` |
| StartCreateNativeVirtualMachineSnapshotsJob | [startCreateAzureNativeVirtualMachineSnapshotsJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation StartCreateNativeVirtualMachineSnapshotsJob`<BR>or<BR>`New-RscMutation -GqlMutation startCreateAzureNativeVirtualMachineSnapshotsJob` |
| StartDisableCloudAccountJob | [startDisableAzureCloudAccountJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation StartDisableCloudAccountJob`<BR>or<BR>`New-RscMutation -GqlMutation startDisableAzureCloudAccountJob` |
| StartDisableNativeSubscriptionProtectionJob | [startDisableAzureNativeSubscriptionProtectionJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation StartDisableNativeSubscriptionProtectionJob`<BR>or<BR>`New-RscMutation -GqlMutation startDisableAzureNativeSubscriptionProtectionJob` |
| StartExportNativeManagedDiskJob | [startExportAzureNativeManagedDiskJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation StartExportNativeManagedDiskJob`<BR>or<BR>`New-RscMutation -GqlMutation startExportAzureNativeManagedDiskJob` |
| StartExportNativeVirtualMachineJob | [startExportAzureNativeVirtualMachineJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation StartExportNativeVirtualMachineJob`<BR>or<BR>`New-RscMutation -GqlMutation startExportAzureNativeVirtualMachineJob` |
| StartExportSqlDatabaseDbJob | [startExportAzureSqlDatabaseDbJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation StartExportSqlDatabaseDbJob`<BR>or<BR>`New-RscMutation -GqlMutation startExportAzureSqlDatabaseDbJob` |
| StartExportSqlManagedInstanceDbJob | [startExportAzureSqlManagedInstanceDbJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation StartExportSqlManagedInstanceDbJob`<BR>or<BR>`New-RscMutation -GqlMutation startExportAzureSqlManagedInstanceDbJob` |
| StartRefreshNativeSubscriptionsJob | [startRefreshAzureNativeSubscriptionsJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation StartRefreshNativeSubscriptionsJob`<BR>or<BR>`New-RscMutation -GqlMutation startRefreshAzureNativeSubscriptionsJob` |
| StartRestoreNativeVirtualMachineJob | [startRestoreAzureNativeVirtualMachineJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation StartRestoreNativeVirtualMachineJob`<BR>or<BR>`New-RscMutation -GqlMutation startRestoreAzureNativeVirtualMachineJob` |
| UnmapCloudAccountExocomputeSubscription | [unmapAzureCloudAccountExocomputeSubscription](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation UnmapCloudAccountExocomputeSubscription`<BR>or<BR>`New-RscMutation -GqlMutation unmapAzureCloudAccountExocomputeSubscription` |
| UnmapPersistentStorageSubscription | [unmapAzurePersistentStorageSubscription](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation UnmapPersistentStorageSubscription`<BR>or<BR>`New-RscMutation -GqlMutation unmapAzurePersistentStorageSubscription` |
| UpdateAccount | [updateAzureAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation UpdateAccount`<BR>or<BR>`New-RscMutation -GqlMutation updateAzureAccount` |
| UpdateAutomaticTargetMapping | [updateAutomaticAzureTargetMapping](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation UpdateAutomaticTargetMapping`<BR>or<BR>`New-RscMutation -GqlMutation updateAutomaticAzureTargetMapping` |
| UpdateCloudAccount | [updateAzureCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation UpdateCloudAccount`<BR>or<BR>`New-RscMutation -GqlMutation updateAzureCloudAccount` |
| UpdateCloudNativeRcvStorageSetting | [updateCloudNativeRcvAzureStorageSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation UpdateCloudNativeRcvStorageSetting`<BR>or<BR>`New-RscMutation -GqlMutation updateCloudNativeRcvAzureStorageSetting` |
| UpdateCloudNativeStorageSetting | [updateCloudNativeAzureStorageSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation UpdateCloudNativeStorageSetting`<BR>or<BR>`New-RscMutation -GqlMutation updateCloudNativeAzureStorageSetting` |
| UpdateCustomerAppPermissionForSql | [updateCustomerAppPermissionForAzureSql](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation UpdateCustomerAppPermissionForSql`<BR>or<BR>`New-RscMutation -GqlMutation updateCustomerAppPermissionForAzureSql` |
| UpdateTarget | [updateAzureTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation UpdateTarget`<BR>or<BR>`New-RscMutation -GqlMutation updateAzureTarget` |
| UpgradeCloudAccount | [upgradeAzureCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation UpgradeCloudAccount`<BR>or<BR>`New-RscMutation -GqlMutation upgradeAzureCloudAccount` |
| UpgradeCloudAccountPermissionsWithoutOauth | [upgradeAzureCloudAccountPermissionsWithoutOauth](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Azure -Operation UpgradeCloudAccountPermissionsWithoutOauth`<BR>or<BR>`New-RscMutation -GqlMutation upgradeAzureCloudAccountPermissionsWithoutOauth` |

[Go to top](#)
## AzureO365 domain

Domain key: AzureO365 , e.g. '`-Domain AzureO365`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| CheckNSGOutboundRules | [azureO365CheckNSGOutboundRules](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain AzureO365 -Operation CheckNSGOutboundRules`<BR>or<BR>`New-RscQuery -GqlQuery azureO365CheckNSGOutboundRules` |
| CheckNetworkSubnet | [azureO365CheckNetworkSubnet](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain AzureO365 -Operation CheckNetworkSubnet`<BR>or<BR>`New-RscQuery -GqlQuery azureO365CheckNetworkSubnet` |
| CheckResourceGroupName | [azureO365CheckResourceGroupName](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain AzureO365 -Operation CheckResourceGroupName`<BR>or<BR>`New-RscQuery -GqlQuery azureO365CheckResourceGroupName` |
| CheckStorageAccountAccessibility | [azureO365CheckStorageAccountAccessibility](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain AzureO365 -Operation CheckStorageAccountAccessibility`<BR>or<BR>`New-RscQuery -GqlQuery azureO365CheckStorageAccountAccessibility` |
| CheckStorageAccountName | [azureO365CheckStorageAccountName](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain AzureO365 -Operation CheckStorageAccountName`<BR>or<BR>`New-RscQuery -GqlQuery azureO365CheckStorageAccountName` |
| CheckSubscriptionQuota | [azureO365CheckSubscriptionQuota](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain AzureO365 -Operation CheckSubscriptionQuota`<BR>or<BR>`New-RscQuery -GqlQuery azureO365CheckSubscriptionQuota` |
| CheckVirtualNetworkName | [azureO365CheckVirtualNetworkName](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain AzureO365 -Operation CheckVirtualNetworkName`<BR>or<BR>`New-RscQuery -GqlQuery azureO365CheckVirtualNetworkName` |
| Exocompute | [azureO365Exocompute](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain AzureO365 -Operation Exocompute`<BR>or<BR>`New-RscQuery -GqlQuery azureO365Exocompute` |
| GetAzureHostType | [azureO365GetAzureHostType](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain AzureO365 -Operation GetAzureHostType`<BR>or<BR>`New-RscQuery -GqlQuery azureO365GetAzureHostType` |
| GetNetworkSubnetUnusedAddr | [azureO365GetNetworkSubnetUnusedAddr](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain AzureO365 -Operation GetNetworkSubnetUnusedAddr`<BR>or<BR>`New-RscQuery -GqlQuery azureO365GetNetworkSubnetUnusedAddr` |
| ValidateUserRoles | [azureO365ValidateUserRoles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain AzureO365 -Operation ValidateUserRoles`<BR>or<BR>`New-RscQuery -GqlQuery azureO365ValidateUserRoles` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| SetupExocompute | [setupAzureO365Exocompute](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain AzureO365 -Operation SetupExocompute`<BR>or<BR>`New-RscMutation -GqlMutation setupAzureO365Exocompute` |

[Go to top](#)
## Cassandra domain

Domain key: Cassandra , e.g. '`-Domain Cassandra`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| ColumnFamilies | [cassandraColumnFamilies](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Cassandra -Operation ColumnFamilies`<BR>or<BR>`New-RscQuery -GqlQuery cassandraColumnFamilies` |
| ColumnFamily | [cassandraColumnFamily](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Cassandra -Operation ColumnFamily`<BR>or<BR>`New-RscQuery -GqlQuery cassandraColumnFamily` |
| ColumnFamilyRecoverableRange | [cassandraColumnFamilyRecoverableRange](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Cassandra -Operation ColumnFamilyRecoverableRange`<BR>or<BR>`New-RscQuery -GqlQuery cassandraColumnFamilyRecoverableRange` |
| ColumnFamilySchema | [cassandraColumnFamilySchema](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Cassandra -Operation ColumnFamilySchema`<BR>or<BR>`New-RscQuery -GqlQuery cassandraColumnFamilySchema` |
| Keyspace | [cassandraKeyspace](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Cassandra -Operation Keyspace`<BR>or<BR>`New-RscQuery -GqlQuery cassandraKeyspace` |
| Keyspaces | [cassandraKeyspaces](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Cassandra -Operation Keyspaces`<BR>or<BR>`New-RscQuery -GqlQuery cassandraKeyspaces` |
| Source | [cassandraSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Cassandra -Operation Source`<BR>or<BR>`New-RscQuery -GqlQuery cassandraSource` |
| Sources | [cassandraSources](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Cassandra -Operation Sources`<BR>or<BR>`New-RscQuery -GqlQuery cassandraSources` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| BulkDeleteSources | [bulkDeleteCassandraSources](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Cassandra -Operation BulkDeleteSources`<BR>or<BR>`New-RscMutation -GqlMutation bulkDeleteCassandraSources` |
| CreateSource | [createCassandraSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Cassandra -Operation CreateSource`<BR>or<BR>`New-RscMutation -GqlMutation createCassandraSource` |
| DeleteSource | [deleteCassandraSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Cassandra -Operation DeleteSource`<BR>or<BR>`New-RscMutation -GqlMutation deleteCassandraSource` |
| RecoverSource | [recoverCassandraSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Cassandra -Operation RecoverSource`<BR>or<BR>`New-RscMutation -GqlMutation recoverCassandraSource` |
| UpdateSource | [updateCassandraSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Cassandra -Operation UpdateSource`<BR>or<BR>`New-RscMutation -GqlMutation updateCassandraSource` |

[Go to top](#)
## Certificates domain

Domain key: Certificate , e.g. '`-Domain Certificate`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| Certificate | [certificates](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Certificate -Operation Certificate`<BR>or<BR>`New-RscQuery -GqlQuery certificates` |
| Cluster | [clusterCertificates](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Certificate -Operation Cluster`<BR>or<BR>`New-RscQuery -GqlQuery clusterCertificates` |
| ClusterWebSigned | [clusterWebSignedCertificate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Certificate -Operation ClusterWebSigned`<BR>or<BR>`New-RscQuery -GqlQuery clusterWebSignedCertificate` |
| SigningRequest | [certificateSigningRequest](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Certificate -Operation SigningRequest`<BR>or<BR>`New-RscQuery -GqlQuery certificateSigningRequest` |
| SigningRequests | [certificateSigningRequests](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Certificate -Operation SigningRequests`<BR>or<BR>`New-RscQuery -GqlQuery certificateSigningRequests` |
| WithKey | [certificatesWithKey](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Certificate -Operation WithKey`<BR>or<BR>`New-RscQuery -GqlQuery certificatesWithKey` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| AddClusterCertificate | [addClusterCertificate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Certificate -Operation AddClusterCertificate`<BR>or<BR>`New-RscMutation -GqlMutation addClusterCertificate` |
| Delete | [deleteCertificate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Certificate -Operation Delete`<BR>or<BR>`New-RscMutation -GqlMutation deleteCertificate` |
| SetSso | [setSsoCertificate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Certificate -Operation SetSso`<BR>or<BR>`New-RscMutation -GqlMutation setSsoCertificate` |
| SetWebSigned | [setWebSignedCertificate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Certificate -Operation SetWebSigned`<BR>or<BR>`New-RscMutation -GqlMutation setWebSignedCertificate` |
| Update | [updateCertificate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Certificate -Operation Update`<BR>or<BR>`New-RscMutation -GqlMutation updateCertificate` |
| UpdateHost | [updateCertificateHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Certificate -Operation UpdateHost`<BR>or<BR>`New-RscMutation -GqlMutation updateCertificateHost` |

[Go to top](#)
## Cloud Native domain

Domain key: CloudNative , e.g. '`-Domain CloudNative`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| CheckArchivedSnapshotsLocked | [cloudNativeCheckArchivedSnapshotsLocked](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain CloudNative -Operation CheckArchivedSnapshotsLocked`<BR>or<BR>`New-RscQuery -GqlQuery cloudNativeCheckArchivedSnapshotsLocked` |
| CheckLabelRuleNameUniqueness | [checkCloudNativeLabelRuleNameUniqueness](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain CloudNative -Operation CheckLabelRuleNameUniqueness`<BR>or<BR>`New-RscQuery -GqlQuery checkCloudNativeLabelRuleNameUniqueness` |
| CheckRequiredPermissionsForFeature | [cloudNativeCheckRequiredPermissionsForFeature](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain CloudNative -Operation CheckRequiredPermissionsForFeature`<BR>or<BR>`New-RscQuery -GqlQuery cloudNativeCheckRequiredPermissionsForFeature` |
| CheckTagRuleNameUniqueness | [checkCloudNativeTagRuleNameUniqueness](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain CloudNative -Operation CheckTagRuleNameUniqueness`<BR>or<BR>`New-RscQuery -GqlQuery checkCloudNativeTagRuleNameUniqueness` |
| CustomerTags | [cloudNativeCustomerTags](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain CloudNative -Operation CustomerTags`<BR>or<BR>`New-RscQuery -GqlQuery cloudNativeCustomerTags` |
| FileRecoveryEligibleSnapshots | [allCloudNativeFileRecoveryEligibleSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain CloudNative -Operation FileRecoveryEligibleSnapshots`<BR>or<BR>`New-RscQuery -GqlQuery allCloudNativeFileRecoveryEligibleSnapshots` |
| IsFileRecoveryFeasible | [isCloudNativeFileRecoveryFeasible](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain CloudNative -Operation IsFileRecoveryFeasible`<BR>or<BR>`New-RscQuery -GqlQuery isCloudNativeFileRecoveryFeasible` |
| LabelKeys | [allCloudNativeLabelKeys](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain CloudNative -Operation LabelKeys`<BR>or<BR>`New-RscQuery -GqlQuery allCloudNativeLabelKeys` |
| LabelRules | [cloudNativeLabelRules](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain CloudNative -Operation LabelRules`<BR>or<BR>`New-RscQuery -GqlQuery cloudNativeLabelRules` |
| LabelValues | [allCloudNativeLabelValues](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain CloudNative -Operation LabelValues`<BR>or<BR>`New-RscQuery -GqlQuery allCloudNativeLabelValues` |
| RbaInstallers | [cloudNativeRbaInstallers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain CloudNative -Operation RbaInstallers`<BR>or<BR>`New-RscQuery -GqlQuery cloudNativeRbaInstallers` |
| SnapshotDetailsForRecovery | [cloudNativeSnapshotDetailsForRecovery](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain CloudNative -Operation SnapshotDetailsForRecovery`<BR>or<BR>`New-RscQuery -GqlQuery cloudNativeSnapshotDetailsForRecovery` |
| SnapshotTypeDetails | [cloudNativeSnapshotTypeDetails](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain CloudNative -Operation SnapshotTypeDetails`<BR>or<BR>`New-RscQuery -GqlQuery cloudNativeSnapshotTypeDetails` |
| Snapshots | [cloudNativeSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain CloudNative -Operation Snapshots`<BR>or<BR>`New-RscQuery -GqlQuery cloudNativeSnapshots` |
| SqlServerSetupScript | [cloudNativeSqlServerSetupScript](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain CloudNative -Operation SqlServerSetupScript`<BR>or<BR>`New-RscQuery -GqlQuery cloudNativeSqlServerSetupScript` |
| TagKeys | [allCloudNativeTagKeys](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain CloudNative -Operation TagKeys`<BR>or<BR>`New-RscQuery -GqlQuery allCloudNativeTagKeys` |
| TagRules | [cloudNativeTagRules](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain CloudNative -Operation TagRules`<BR>or<BR>`New-RscQuery -GqlQuery cloudNativeTagRules` |
| TagValues | [allCloudNativeTagValues](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain CloudNative -Operation TagValues`<BR>or<BR>`New-RscQuery -GqlQuery allCloudNativeTagValues` |
| WorkloadVersionedFiles | [cloudNativeWorkloadVersionedFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain CloudNative -Operation WorkloadVersionedFiles`<BR>or<BR>`New-RscQuery -GqlQuery cloudNativeWorkloadVersionedFiles` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| AddSqlServerBackupCredentials | [addCloudNativeSqlServerBackupCredentials](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain CloudNative -Operation AddSqlServerBackupCredentials`<BR>or<BR>`New-RscMutation -GqlMutation addCloudNativeSqlServerBackupCredentials` |
| CheckRbaConnectivity | [cloudNativeCheckRbaConnectivity](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain CloudNative -Operation CheckRbaConnectivity`<BR>or<BR>`New-RscMutation -GqlMutation cloudNativeCheckRbaConnectivity` |
| ClearSqlServerBackupCredentials | [clearCloudNativeSqlServerBackupCredentials](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain CloudNative -Operation ClearSqlServerBackupCredentials`<BR>or<BR>`New-RscMutation -GqlMutation clearCloudNativeSqlServerBackupCredentials` |
| CreateLabelRule | [createCloudNativeLabelRule](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain CloudNative -Operation CreateLabelRule`<BR>or<BR>`New-RscMutation -GqlMutation createCloudNativeLabelRule` |
| CreateTagRule | [createCloudNativeTagRule](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain CloudNative -Operation CreateTagRule`<BR>or<BR>`New-RscMutation -GqlMutation createCloudNativeTagRule` |
| DeleteLabelRule | [deleteCloudNativeLabelRule](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain CloudNative -Operation DeleteLabelRule`<BR>or<BR>`New-RscMutation -GqlMutation deleteCloudNativeLabelRule` |
| DeleteTagRule | [deleteCloudNativeTagRule](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain CloudNative -Operation DeleteTagRule`<BR>or<BR>`New-RscMutation -GqlMutation deleteCloudNativeTagRule` |
| DownloadFiles | [cloudNativeDownloadFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain CloudNative -Operation DownloadFiles`<BR>or<BR>`New-RscMutation -GqlMutation cloudNativeDownloadFiles` |
| SetupSqlServerBackup | [setupCloudNativeSqlServerBackup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain CloudNative -Operation SetupSqlServerBackup`<BR>or<BR>`New-RscMutation -GqlMutation setupCloudNativeSqlServerBackup` |
| StartSnapshotsIndexJob | [startCloudNativeSnapshotsIndexJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain CloudNative -Operation StartSnapshotsIndexJob`<BR>or<BR>`New-RscMutation -GqlMutation startCloudNativeSnapshotsIndexJob` |
| UpdateIndexingStatus | [updateCloudNativeIndexingStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain CloudNative -Operation UpdateIndexingStatus`<BR>or<BR>`New-RscMutation -GqlMutation updateCloudNativeIndexingStatus` |
| UpdateLabelRule | [updateCloudNativeLabelRule](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain CloudNative -Operation UpdateLabelRule`<BR>or<BR>`New-RscMutation -GqlMutation updateCloudNativeLabelRule` |
| UpdateTagRule | [updateCloudNativeTagRule](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain CloudNative -Operation UpdateTagRule`<BR>or<BR>`New-RscMutation -GqlMutation updateCloudNativeTagRule` |

[Go to top](#)
## Cluster domain

Domain key: Cluster , e.g. '`-Domain Cluster`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| Cluster | [cluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Cluster -Operation Cluster`<BR>or<BR>`New-RscQuery -GqlQuery cluster` |
| Connected | [allConnectedClusters](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Cluster -Operation Connected`<BR>or<BR>`New-RscQuery -GqlQuery allConnectedClusters` |
| DatabaseLogReport | [databaseLogReportForCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Cluster -Operation DatabaseLogReport`<BR>or<BR>`New-RscQuery -GqlQuery databaseLogReportForCluster` |
| DatabaseLogReportingProperties | [databaseLogReportingPropertiesForCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Cluster -Operation DatabaseLogReportingProperties`<BR>or<BR>`New-RscQuery -GqlQuery databaseLogReportingPropertiesForCluster` |
| DefaultGateway | [clusterDefaultGateway](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Cluster -Operation DefaultGateway`<BR>or<BR>`New-RscQuery -GqlQuery clusterDefaultGateway` |
| Dns | [clusterDns](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Cluster -Operation Dns`<BR>or<BR>`New-RscQuery -GqlQuery clusterDns` |
| FloatingIps | [clusterFloatingIps](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Cluster -Operation FloatingIps`<BR>or<BR>`New-RscQuery -GqlQuery clusterFloatingIps` |
| GroupByList | [clusterGroupByConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Cluster -Operation GroupByList`<BR>or<BR>`New-RscQuery -GqlQuery clusterGroupByConnection` |
| HostFailover | [hostFailoverCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Cluster -Operation HostFailover`<BR>or<BR>`New-RscQuery -GqlQuery hostFailoverCluster` |
| Ipmi | [clusterIpmi](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Cluster -Operation Ipmi`<BR>or<BR>`New-RscQuery -GqlQuery clusterIpmi` |
| Ipv6Mode | [clusterIpv6Mode](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Cluster -Operation Ipv6Mode`<BR>or<BR>`New-RscQuery -GqlQuery clusterIpv6Mode` |
| IsTotpAckNecessary | [isTotpAckNecessaryForCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Cluster -Operation IsTotpAckNecessary`<BR>or<BR>`New-RscQuery -GqlQuery isTotpAckNecessaryForCluster` |
| List | [clusterConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Cluster -Operation List`<BR>or<BR>`New-RscQuery -GqlQuery clusterConnection` |
| NetworkInterfaces | [clusterNetworkInterfaces](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Cluster -Operation NetworkInterfaces`<BR>or<BR>`New-RscQuery -GqlQuery clusterNetworkInterfaces` |
| Nodes | [clusterNodes](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Cluster -Operation Nodes`<BR>or<BR>`New-RscQuery -GqlQuery clusterNodes` |
| NtpServers | [clusterNtpServers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Cluster -Operation NtpServers`<BR>or<BR>`New-RscQuery -GqlQuery clusterNtpServers` |
| OperationJobProgress | [clusterOperationJobProgress](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Cluster -Operation OperationJobProgress`<BR>or<BR>`New-RscQuery -GqlQuery clusterOperationJobProgress` |
| Proxy | [clusterProxy](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Cluster -Operation Proxy`<BR>or<BR>`New-RscQuery -GqlQuery clusterProxy` |
| RegistrationProductInfo | [clusterRegistrationProductInfo](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Cluster -Operation RegistrationProductInfo`<BR>or<BR>`New-RscQuery -GqlQuery clusterRegistrationProductInfo` |
| ReplicationTargets | [allClusterReplicationTargets](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Cluster -Operation ReplicationTargets`<BR>or<BR>`New-RscQuery -GqlQuery allClusterReplicationTargets` |
| ReportMigrationCount | [clusterReportMigrationCount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Cluster -Operation ReportMigrationCount`<BR>or<BR>`New-RscQuery -GqlQuery clusterReportMigrationCount` |
| ReportMigrationJobStatus | [clusterReportMigrationJobStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Cluster -Operation ReportMigrationJobStatus`<BR>or<BR>`New-RscQuery -GqlQuery clusterReportMigrationJobStatus` |
| ReportMigrationStatus | [clusterReportMigrationStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Cluster -Operation ReportMigrationStatus`<BR>or<BR>`New-RscQuery -GqlQuery clusterReportMigrationStatus` |
| TotpAckStatus | [allClustersTotpAckStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Cluster -Operation TotpAckStatus`<BR>or<BR>`New-RscQuery -GqlQuery allClustersTotpAckStatus` |
| TypeList | [clusterTypeList](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Cluster -Operation TypeList`<BR>or<BR>`New-RscQuery -GqlQuery clusterTypeList` |
| Vlans | [clusterVlans](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Cluster -Operation Vlans`<BR>or<BR>`New-RscQuery -GqlQuery clusterVlans` |
| WebCertsAndIpmis | [allClusterWebCertsAndIpmis](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Cluster -Operation WebCertsAndIpmis`<BR>or<BR>`New-RscQuery -GqlQuery allClusterWebCertsAndIpmis` |
| Windows | [windowsCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Cluster -Operation Windows`<BR>or<BR>`New-RscQuery -GqlQuery windowsCluster` |
| WithUpgradesInfo | [clusterWithUpgradesInfo](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Cluster -Operation WithUpgradesInfo`<BR>or<BR>`New-RscQuery -GqlQuery clusterWithUpgradesInfo` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| AddNodesToCloud | [addNodesToCloudCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Cluster -Operation AddNodesToCloud`<BR>or<BR>`New-RscMutation -GqlMutation addNodesToCloudCluster` |
| BulkDeleteFailover | [bulkDeleteFailoverCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Cluster -Operation BulkDeleteFailover`<BR>or<BR>`New-RscMutation -GqlMutation bulkDeleteFailoverCluster` |
| CreateFailover | [createFailoverCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Cluster -Operation CreateFailover`<BR>or<BR>`New-RscMutation -GqlMutation createFailoverCluster` |
| DeleteFailover | [deleteFailoverCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Cluster -Operation DeleteFailover`<BR>or<BR>`New-RscMutation -GqlMutation deleteFailoverCluster` |
| RecoverCloud | [recoverCloudCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Cluster -Operation RecoverCloud`<BR>or<BR>`New-RscMutation -GqlMutation recoverCloudCluster` |
| RegisterCloud | [registerCloudCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Cluster -Operation RegisterCloud`<BR>or<BR>`New-RscMutation -GqlMutation registerCloudCluster` |
| RemoveCdm | [removeCdmCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Cluster -Operation RemoveCdm`<BR>or<BR>`New-RscMutation -GqlMutation removeCdmCluster` |
| UpdateDatabaseLogReportingProperties | [updateDatabaseLogReportingPropertiesForCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Cluster -Operation UpdateDatabaseLogReportingProperties`<BR>or<BR>`New-RscMutation -GqlMutation updateDatabaseLogReportingPropertiesForCluster` |
| UpdateFailover | [updateFailoverCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Cluster -Operation UpdateFailover`<BR>or<BR>`New-RscMutation -GqlMutation updateFailoverCluster` |

[Go to top](#)
## Db2 domain

Domain key: Db2 , e.g. '`-Domain Db2`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| Database | [db2Database](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Db2 -Operation Database`<BR>or<BR>`New-RscQuery -GqlQuery db2Database` |
| Databases | [db2Databases](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Db2 -Operation Databases`<BR>or<BR>`New-RscQuery -GqlQuery db2Databases` |
| Instance | [db2Instance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Db2 -Operation Instance`<BR>or<BR>`New-RscQuery -GqlQuery db2Instance` |
| Instances | [db2Instances](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Db2 -Operation Instances`<BR>or<BR>`New-RscQuery -GqlQuery db2Instances` |
| LogSnapshot | [db2LogSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Db2 -Operation LogSnapshot`<BR>or<BR>`New-RscQuery -GqlQuery db2LogSnapshot` |
| LogSnapshots | [db2LogSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Db2 -Operation LogSnapshots`<BR>or<BR>`New-RscQuery -GqlQuery db2LogSnapshots` |
| RecoverableRange | [db2RecoverableRange](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Db2 -Operation RecoverableRange`<BR>or<BR>`New-RscQuery -GqlQuery db2RecoverableRange` |
| RecoverableRanges | [db2RecoverableRanges](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Db2 -Operation RecoverableRanges`<BR>or<BR>`New-RscQuery -GqlQuery db2RecoverableRanges` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| AddInstance | [addDb2Instance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Db2 -Operation AddInstance`<BR>or<BR>`New-RscMutation -GqlMutation addDb2Instance` |
| CreateOnDemandBackup | [createOnDemandDb2Backup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Db2 -Operation CreateOnDemandBackup`<BR>or<BR>`New-RscMutation -GqlMutation createOnDemandDb2Backup` |
| DeleteDatabase | [deleteDb2Database](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Db2 -Operation DeleteDatabase`<BR>or<BR>`New-RscMutation -GqlMutation deleteDb2Database` |
| DeleteInstance | [deleteDb2Instance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Db2 -Operation DeleteInstance`<BR>or<BR>`New-RscMutation -GqlMutation deleteDb2Instance` |
| DiscoverInstance | [discoverDb2Instance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Db2 -Operation DiscoverInstance`<BR>or<BR>`New-RscMutation -GqlMutation discoverDb2Instance` |
| DownloadSnapshot | [downloadDb2Snapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Db2 -Operation DownloadSnapshot`<BR>or<BR>`New-RscMutation -GqlMutation downloadDb2Snapshot` |
| DownloadSnapshotsForPointInTimeRecovery | [downloadDb2SnapshotsForPointInTimeRecovery](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Db2 -Operation DownloadSnapshotsForPointInTimeRecovery`<BR>or<BR>`New-RscMutation -GqlMutation downloadDb2SnapshotsForPointInTimeRecovery` |
| ExpireDownloadedSnapshots | [expireDownloadedDb2Snapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Db2 -Operation ExpireDownloadedSnapshots`<BR>or<BR>`New-RscMutation -GqlMutation expireDownloadedDb2Snapshots` |
| PatchDatabase | [patchDb2Database](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Db2 -Operation PatchDatabase`<BR>or<BR>`New-RscMutation -GqlMutation patchDb2Database` |
| PatchInstance | [patchDb2Instance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Db2 -Operation PatchInstance`<BR>or<BR>`New-RscMutation -GqlMutation patchDb2Instance` |
| RefreshDatabase | [refreshDb2Database](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Db2 -Operation RefreshDatabase`<BR>or<BR>`New-RscMutation -GqlMutation refreshDb2Database` |

[Go to top](#)
## Report Download domain

Domain key: Download , e.g. '`-Domain Download`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| CdmUpgradesPdf | [downloadCdmUpgradesPdf](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Download -Operation CdmUpgradesPdf`<BR>or<BR>`New-RscQuery -GqlQuery downloadCdmUpgradesPdf` |
| EdVersionList | [downloadedVersionList](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Download -Operation EdVersionList`<BR>or<BR>`New-RscQuery -GqlQuery downloadedVersionList` |
| PackageStatus | [downloadPackageStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Download -Operation PackageStatus`<BR>or<BR>`New-RscQuery -GqlQuery downloadPackageStatus` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| AuditLogCsvAsync | [downloadAuditLogCsvAsync](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Download -Operation AuditLogCsvAsync`<BR>or<BR>`New-RscMutation -GqlMutation downloadAuditLogCsvAsync` |
| ExchangeSnapshot | [downloadExchangeSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Download -Operation ExchangeSnapshot`<BR>or<BR>`New-RscMutation -GqlMutation downloadExchangeSnapshot` |
| FilesetSnapshot | [downloadFilesetSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Download -Operation FilesetSnapshot`<BR>or<BR>`New-RscMutation -GqlMutation downloadFilesetSnapshot` |
| FilesetSnapshotFromLocation | [downloadFilesetSnapshotFromLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Download -Operation FilesetSnapshotFromLocation`<BR>or<BR>`New-RscMutation -GqlMutation downloadFilesetSnapshotFromLocation` |
| ObjectFilesCsv | [downloadObjectFilesCsv](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Download -Operation ObjectFilesCsv`<BR>or<BR>`New-RscMutation -GqlMutation downloadObjectFilesCsv` |
| ObjectsListCsv | [downloadObjectsListCsv](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Download -Operation ObjectsListCsv`<BR>or<BR>`New-RscMutation -GqlMutation downloadObjectsListCsv` |
| ReportCsvAsync | [downloadReportCsvAsync](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Download -Operation ReportCsvAsync`<BR>or<BR>`New-RscMutation -GqlMutation downloadReportCsvAsync` |
| ReportPdfAsync | [downloadReportPdfAsync](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Download -Operation ReportPdfAsync`<BR>or<BR>`New-RscMutation -GqlMutation downloadReportPdfAsync` |
| ResultsCsv | [downloadResultsCsv](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Download -Operation ResultsCsv`<BR>or<BR>`New-RscMutation -GqlMutation downloadResultsCsv` |
| SapHanaSnapshot | [downloadSapHanaSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Download -Operation SapHanaSnapshot`<BR>or<BR>`New-RscMutation -GqlMutation downloadSapHanaSnapshot` |
| SapHanaSnapshotFromLocation | [downloadSapHanaSnapshotFromLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Download -Operation SapHanaSnapshotFromLocation`<BR>or<BR>`New-RscMutation -GqlMutation downloadSapHanaSnapshotFromLocation` |
| SapHanaSnapshotsForPointInTimeRecovery | [downloadSapHanaSnapshotsForPointInTimeRecovery](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Download -Operation SapHanaSnapshotsForPointInTimeRecovery`<BR>or<BR>`New-RscMutation -GqlMutation downloadSapHanaSnapshotsForPointInTimeRecovery` |
| SnapshotResultsCsv | [downloadSnapshotResultsCsv](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Download -Operation SnapshotResultsCsv`<BR>or<BR>`New-RscMutation -GqlMutation downloadSnapshotResultsCsv` |
| ThreatHuntCsv | [downloadThreatHuntCsv](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Download -Operation ThreatHuntCsv`<BR>or<BR>`New-RscMutation -GqlMutation downloadThreatHuntCsv` |
| VolumeGroupSnapshotFiles | [downloadVolumeGroupSnapshotFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Download -Operation VolumeGroupSnapshotFiles`<BR>or<BR>`New-RscMutation -GqlMutation downloadVolumeGroupSnapshotFiles` |
| VolumeGroupSnapshotFromLocation | [downloadVolumeGroupSnapshotFromLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Download -Operation VolumeGroupSnapshotFromLocation`<BR>or<BR>`New-RscMutation -GqlMutation downloadVolumeGroupSnapshotFromLocation` |

[Go to top](#)
## Microsoft Exchange domain

Domain key: Exchange , e.g. '`-Domain Exchange`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| Dag | [exchangeDag](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Exchange -Operation Dag`<BR>or<BR>`New-RscQuery -GqlQuery exchangeDag` |
| Dags | [exchangeDags](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Exchange -Operation Dags`<BR>or<BR>`New-RscQuery -GqlQuery exchangeDags` |
| Database | [exchangeDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Exchange -Operation Database`<BR>or<BR>`New-RscQuery -GqlQuery exchangeDatabase` |
| Databases | [exchangeDatabases](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Exchange -Operation Databases`<BR>or<BR>`New-RscQuery -GqlQuery exchangeDatabases` |
| LiveMounts | [exchangeLiveMounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Exchange -Operation LiveMounts`<BR>or<BR>`New-RscQuery -GqlQuery exchangeLiveMounts` |
| Server | [exchangeServer](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Exchange -Operation Server`<BR>or<BR>`New-RscQuery -GqlQuery exchangeServer` |
| Servers | [exchangeServers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Exchange -Operation Servers`<BR>or<BR>`New-RscQuery -GqlQuery exchangeServers` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| BulkUpdateDag | [bulkUpdateExchangeDag](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Exchange -Operation BulkUpdateDag`<BR>or<BR>`New-RscMutation -GqlMutation bulkUpdateExchangeDag` |
| CreateMount | [createExchangeMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Exchange -Operation CreateMount`<BR>or<BR>`New-RscMutation -GqlMutation createExchangeMount` |
| CreateOnDemandBackup | [createOnDemandExchangeBackup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Exchange -Operation CreateOnDemandBackup`<BR>or<BR>`New-RscMutation -GqlMutation createOnDemandExchangeBackup` |
| DeleteSnapshotMount | [deleteExchangeSnapshotMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Exchange -Operation DeleteSnapshotMount`<BR>or<BR>`New-RscMutation -GqlMutation deleteExchangeSnapshotMount` |

[Go to top](#)
## Fileset domain

Domain key: Fileset , e.g. '`-Domain Fileset`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| Linux | [linuxFileset](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Fileset -Operation Linux`<BR>or<BR>`New-RscQuery -GqlQuery linuxFileset` |
| RequestStatus | [filesetRequestStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Fileset -Operation RequestStatus`<BR>or<BR>`New-RscQuery -GqlQuery filesetRequestStatus` |
| Share | [shareFileset](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Fileset -Operation Share`<BR>or<BR>`New-RscQuery -GqlQuery shareFileset` |
| Template | [filesetTemplate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Fileset -Operation Template`<BR>or<BR>`New-RscQuery -GqlQuery filesetTemplate` |
| Templates | [filesetTemplates](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Fileset -Operation Templates`<BR>or<BR>`New-RscQuery -GqlQuery filesetTemplates` |
| Windows | [windowsFileset](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Fileset -Operation Windows`<BR>or<BR>`New-RscQuery -GqlQuery windowsFileset` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| BulkCreate | [bulkCreateFilesets](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Fileset -Operation BulkCreate`<BR>or<BR>`New-RscMutation -GqlMutation bulkCreateFilesets` |
| BulkCreateTemplates | [bulkCreateFilesetTemplates](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Fileset -Operation BulkCreateTemplates`<BR>or<BR>`New-RscMutation -GqlMutation bulkCreateFilesetTemplates` |
| BulkDelete | [bulkDeleteFileset](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Fileset -Operation BulkDelete`<BR>or<BR>`New-RscMutation -GqlMutation bulkDeleteFileset` |
| BulkDeleteTemplate | [bulkDeleteFilesetTemplate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Fileset -Operation BulkDeleteTemplate`<BR>or<BR>`New-RscMutation -GqlMutation bulkDeleteFilesetTemplate` |
| BulkUpdateTemplate | [bulkUpdateFilesetTemplate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Fileset -Operation BulkUpdateTemplate`<BR>or<BR>`New-RscMutation -GqlMutation bulkUpdateFilesetTemplate` |
| RecoverFiles | [filesetRecoverFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Fileset -Operation RecoverFiles`<BR>or<BR>`New-RscMutation -GqlMutation filesetRecoverFiles` |

[Go to top](#)
## Google Cloud Platform domain

Domain key: Gcp , e.g. '`-Domain Gcp`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| CloudAccountMissingPermissionsForAddition | [allGcpCloudAccountMissingPermissionsForAddition](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Gcp -Operation CloudAccountMissingPermissionsForAddition`<BR>or<BR>`New-RscQuery -GqlQuery allGcpCloudAccountMissingPermissionsForAddition` |
| CloudAccountProjectsByFeature | [allGcpCloudAccountProjectsByFeature](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Gcp -Operation CloudAccountProjectsByFeature`<BR>or<BR>`New-RscQuery -GqlQuery allGcpCloudAccountProjectsByFeature` |
| CloudAccountProjectsForOauth | [allGcpCloudAccountProjectsForOauth](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Gcp -Operation CloudAccountProjectsForOauth`<BR>or<BR>`New-RscQuery -GqlQuery allGcpCloudAccountProjectsForOauth` |
| FeaturePermissionsForCloudAccount | [allFeaturePermissionsForGcpCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Gcp -Operation FeaturePermissionsForCloudAccount`<BR>or<BR>`New-RscQuery -GqlQuery allFeaturePermissionsForGcpCloudAccount` |
| GetDefaultCredentialsServiceAccount | [gcpGetDefaultCredentialsServiceAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Gcp -Operation GetDefaultCredentialsServiceAccount`<BR>or<BR>`New-RscQuery -GqlQuery gcpGetDefaultCredentialsServiceAccount` |
| NativeAvailableKmsCryptoKeys | [allGcpNativeAvailableKmsCryptoKeys](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Gcp -Operation NativeAvailableKmsCryptoKeys`<BR>or<BR>`New-RscQuery -GqlQuery allGcpNativeAvailableKmsCryptoKeys` |
| NativeCompatibleMachineTypes | [allGcpNativeCompatibleMachineTypes](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Gcp -Operation NativeCompatibleMachineTypes`<BR>or<BR>`New-RscQuery -GqlQuery allGcpNativeCompatibleMachineTypes` |
| NativeNetworks | [allGcpNativeNetworks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Gcp -Operation NativeNetworks`<BR>or<BR>`New-RscQuery -GqlQuery allGcpNativeNetworks` |
| NativeProjectsWithAccessibleNetworks | [allGcpNativeProjectsWithAccessibleNetworks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Gcp -Operation NativeProjectsWithAccessibleNetworks`<BR>or<BR>`New-RscQuery -GqlQuery allGcpNativeProjectsWithAccessibleNetworks` |
| NativeRegions | [allGcpNativeRegions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Gcp -Operation NativeRegions`<BR>or<BR>`New-RscQuery -GqlQuery allGcpNativeRegions` |
| NativeStoredMachineTypes | [allGcpNativeStoredMachineTypes](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Gcp -Operation NativeStoredMachineTypes`<BR>or<BR>`New-RscQuery -GqlQuery allGcpNativeStoredMachineTypes` |
| NativeStoredMachineTypesInProject | [allGcpNativeStoredMachineTypesInProject](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Gcp -Operation NativeStoredMachineTypesInProject`<BR>or<BR>`New-RscQuery -GqlQuery allGcpNativeStoredMachineTypesInProject` |
| NativeStoredNetworkNames | [allGcpNativeStoredNetworkNames](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Gcp -Operation NativeStoredNetworkNames`<BR>or<BR>`New-RscQuery -GqlQuery allGcpNativeStoredNetworkNames` |
| NativeStoredNetworkNamesInProject | [allGcpNativeStoredNetworkNamesInProject](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Gcp -Operation NativeStoredNetworkNamesInProject`<BR>or<BR>`New-RscQuery -GqlQuery allGcpNativeStoredNetworkNamesInProject` |
| NativeStoredRegions | [allGcpNativeStoredRegions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Gcp -Operation NativeStoredRegions`<BR>or<BR>`New-RscQuery -GqlQuery allGcpNativeStoredRegions` |
| NativeStoredRegionsInProject | [allGcpNativeStoredRegionsInProject](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Gcp -Operation NativeStoredRegionsInProject`<BR>or<BR>`New-RscQuery -GqlQuery allGcpNativeStoredRegionsInProject` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| CloudAccountAddManualAuthProject | [gcpCloudAccountAddManualAuthProject](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Gcp -Operation CloudAccountAddManualAuthProject`<BR>or<BR>`New-RscMutation -GqlMutation gcpCloudAccountAddManualAuthProject` |
| CloudAccountAddProjects | [gcpCloudAccountAddProjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Gcp -Operation CloudAccountAddProjects`<BR>or<BR>`New-RscMutation -GqlMutation gcpCloudAccountAddProjects` |
| CloudAccountDeleteProjects | [gcpCloudAccountDeleteProjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Gcp -Operation CloudAccountDeleteProjects`<BR>or<BR>`New-RscMutation -GqlMutation gcpCloudAccountDeleteProjects` |
| CloudAccountOauthComplete | [gcpCloudAccountOauthComplete](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Gcp -Operation CloudAccountOauthComplete`<BR>or<BR>`New-RscMutation -GqlMutation gcpCloudAccountOauthComplete` |
| CloudAccountOauthInitiate | [gcpCloudAccountOauthInitiate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Gcp -Operation CloudAccountOauthInitiate`<BR>or<BR>`New-RscMutation -GqlMutation gcpCloudAccountOauthInitiate` |
| CloudAccountUpgradeProjects | [gcpCloudAccountUpgradeProjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Gcp -Operation CloudAccountUpgradeProjects`<BR>or<BR>`New-RscMutation -GqlMutation gcpCloudAccountUpgradeProjects` |
| CreateReaderTarget | [createGcpReaderTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Gcp -Operation CreateReaderTarget`<BR>or<BR>`New-RscMutation -GqlMutation createGcpReaderTarget` |
| CreateTarget | [createGcpTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Gcp -Operation CreateTarget`<BR>or<BR>`New-RscMutation -GqlMutation createGcpTarget` |
| SetDefaultServiceAccountJwtConfig | [gcpSetDefaultServiceAccountJwtConfig](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Gcp -Operation SetDefaultServiceAccountJwtConfig`<BR>or<BR>`New-RscMutation -GqlMutation gcpSetDefaultServiceAccountJwtConfig` |
| UpdateTarget | [updateGcpTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Gcp -Operation UpdateTarget`<BR>or<BR>`New-RscMutation -GqlMutation updateGcpTarget` |
| UpgradeCloudAccountPermissionsWithoutOauth | [upgradeGcpCloudAccountPermissionsWithoutOauth](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Gcp -Operation UpgradeCloudAccountPermissionsWithoutOauth`<BR>or<BR>`New-RscMutation -GqlMutation upgradeGcpCloudAccountPermissionsWithoutOauth` |

[Go to top](#)
## Google Cloud Platform Native domain

Domain key: GcpNative , e.g. '`-Domain GcpNative`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| Disk | [gcpNativeDisk](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain GcpNative -Operation Disk`<BR>or<BR>`New-RscQuery -GqlQuery gcpNativeDisk` |
| Disks | [gcpNativeDisks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain GcpNative -Operation Disks`<BR>or<BR>`New-RscQuery -GqlQuery gcpNativeDisks` |
| GceInstance | [gcpNativeGceInstance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain GcpNative -Operation GceInstance`<BR>or<BR>`New-RscQuery -GqlQuery gcpNativeGceInstance` |
| GceInstances | [gcpNativeGceInstances](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain GcpNative -Operation GceInstances`<BR>or<BR>`New-RscQuery -GqlQuery gcpNativeGceInstances` |
| Project | [gcpNativeProject](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain GcpNative -Operation Project`<BR>or<BR>`New-RscQuery -GqlQuery gcpNativeProject` |
| Projects | [gcpNativeProjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain GcpNative -Operation Projects`<BR>or<BR>`New-RscQuery -GqlQuery gcpNativeProjects` |
| StoredDiskLocations | [gcpNativeStoredDiskLocations](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain GcpNative -Operation StoredDiskLocations`<BR>or<BR>`New-RscQuery -GqlQuery gcpNativeStoredDiskLocations` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| DisableProject | [gcpNativeDisableProject](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain GcpNative -Operation DisableProject`<BR>or<BR>`New-RscMutation -GqlMutation gcpNativeDisableProject` |
| ExcludeDisksFromInstanceSnapshot | [gcpNativeExcludeDisksFromInstanceSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain GcpNative -Operation ExcludeDisksFromInstanceSnapshot`<BR>or<BR>`New-RscMutation -GqlMutation gcpNativeExcludeDisksFromInstanceSnapshot` |
| ExportDisk | [gcpNativeExportDisk](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain GcpNative -Operation ExportDisk`<BR>or<BR>`New-RscMutation -GqlMutation gcpNativeExportDisk` |
| ExportGceInstance | [gcpNativeExportGceInstance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain GcpNative -Operation ExportGceInstance`<BR>or<BR>`New-RscMutation -GqlMutation gcpNativeExportGceInstance` |
| RefreshProjects | [gcpNativeRefreshProjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain GcpNative -Operation RefreshProjects`<BR>or<BR>`New-RscMutation -GqlMutation gcpNativeRefreshProjects` |
| RestoreGceInstance | [gcpNativeRestoreGceInstance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain GcpNative -Operation RestoreGceInstance`<BR>or<BR>`New-RscMutation -GqlMutation gcpNativeRestoreGceInstance` |

[Go to top](#)
## Host domain

Domain key: Host , e.g. '`-Domain Host`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| Diagnosis | [hostDiagnosis](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Host -Operation Diagnosis`<BR>or<BR>`New-RscQuery -GqlQuery hostDiagnosis` |
| PhysicalHost | [physicalHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Host -Operation PhysicalHost`<BR>or<BR>`New-RscQuery -GqlQuery physicalHost` |
| PhysicalHosts | [physicalHosts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Host -Operation PhysicalHosts`<BR>or<BR>`New-RscQuery -GqlQuery physicalHosts` |
| Search | [searchHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Host -Operation Search`<BR>or<BR>`New-RscQuery -GqlQuery searchHost` |
| Share | [hostShare](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Host -Operation Share`<BR>or<BR>`New-RscQuery -GqlQuery hostShare` |
| Shares | [hostShares](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Host -Operation Shares`<BR>or<BR>`New-RscQuery -GqlQuery hostShares` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| BulkDelete | [bulkDeleteHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Host -Operation BulkDelete`<BR>or<BR>`New-RscMutation -GqlMutation bulkDeleteHost` |
| BulkRefresh | [bulkRefreshHosts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Host -Operation BulkRefresh`<BR>or<BR>`New-RscMutation -GqlMutation bulkRefreshHosts` |
| BulkRegister | [bulkRegisterHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Host -Operation BulkRegister`<BR>or<BR>`New-RscMutation -GqlMutation bulkRegisterHost` |
| BulkUpdate | [bulkUpdateHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Host -Operation BulkUpdate`<BR>or<BR>`New-RscMutation -GqlMutation bulkUpdateHost` |
| ChangeVfd | [changeVfdOnHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Host -Operation ChangeVfd`<BR>or<BR>`New-RscMutation -GqlMutation changeVfdOnHost` |
| Refresh | [refreshHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Host -Operation Refresh`<BR>or<BR>`New-RscMutation -GqlMutation refreshHost` |

[Go to top](#)
## Hyperv domain

Domain key: Hyperv , e.g. '`-Domain Hyperv`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| Cluster | [hypervCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Hyperv -Operation Cluster`<BR>or<BR>`New-RscQuery -GqlQuery hypervCluster` |
| HostAsyncRequestStatus | [hypervHostAsyncRequestStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Hyperv -Operation HostAsyncRequestStatus`<BR>or<BR>`New-RscQuery -GqlQuery hypervHostAsyncRequestStatus` |
| Mounts | [hypervMounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Hyperv -Operation Mounts`<BR>or<BR>`New-RscQuery -GqlQuery hypervMounts` |
| Scvmm | [hypervScvmm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Hyperv -Operation Scvmm`<BR>or<BR>`New-RscQuery -GqlQuery hypervScvmm` |
| ScvmmAsyncRequestStatus | [hypervScvmmAsyncRequestStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Hyperv -Operation ScvmmAsyncRequestStatus`<BR>or<BR>`New-RscQuery -GqlQuery hypervScvmmAsyncRequestStatus` |
| Scvmms | [hypervScvmms](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Hyperv -Operation Scvmms`<BR>or<BR>`New-RscQuery -GqlQuery hypervScvmms` |
| Server | [hypervServer](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Hyperv -Operation Server`<BR>or<BR>`New-RscQuery -GqlQuery hypervServer` |
| Servers | [hypervServers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Hyperv -Operation Servers`<BR>or<BR>`New-RscQuery -GqlQuery hypervServers` |
| TopLevelDescendants | [hypervTopLevelDescendants](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Hyperv -Operation TopLevelDescendants`<BR>or<BR>`New-RscQuery -GqlQuery hypervTopLevelDescendants` |
| UniqueServersCount | [uniqueHypervServersCount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Hyperv -Operation UniqueServersCount`<BR>or<BR>`New-RscQuery -GqlQuery uniqueHypervServersCount` |
| VirtualMachine | [hypervVirtualMachine](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Hyperv -Operation VirtualMachine`<BR>or<BR>`New-RscQuery -GqlQuery hypervVirtualMachine` |
| VirtualMachineAsyncRequestStatus | [hypervVirtualMachineAsyncRequestStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Hyperv -Operation VirtualMachineAsyncRequestStatus`<BR>or<BR>`New-RscQuery -GqlQuery hypervVirtualMachineAsyncRequestStatus` |
| VirtualMachines | [hypervVirtualMachines](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Hyperv -Operation VirtualMachines`<BR>or<BR>`New-RscQuery -GqlQuery hypervVirtualMachines` |
| VmDetail | [hypervVmDetail](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Hyperv -Operation VmDetail`<BR>or<BR>`New-RscQuery -GqlQuery hypervVmDetail` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| BatchExportVm | [batchExportHypervVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Hyperv -Operation BatchExportVm`<BR>or<BR>`New-RscMutation -GqlMutation batchExportHypervVm` |
| BatchInstantRecoverVm | [batchInstantRecoverHypervVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Hyperv -Operation BatchInstantRecoverVm`<BR>or<BR>`New-RscMutation -GqlMutation batchInstantRecoverHypervVm` |
| BatchMountVm | [batchMountHypervVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Hyperv -Operation BatchMountVm`<BR>or<BR>`New-RscMutation -GqlMutation batchMountHypervVm` |
| BatchOnDemandBackupVm | [batchOnDemandBackupHypervVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Hyperv -Operation BatchOnDemandBackupVm`<BR>or<BR>`New-RscMutation -GqlMutation batchOnDemandBackupHypervVm` |
| CreateVirtualMachineSnapshotMount | [createHypervVirtualMachineSnapshotMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Hyperv -Operation CreateVirtualMachineSnapshotMount`<BR>or<BR>`New-RscMutation -GqlMutation createHypervVirtualMachineSnapshotMount` |
| DeleteAllSnapshots | [hypervDeleteAllSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Hyperv -Operation DeleteAllSnapshots`<BR>or<BR>`New-RscMutation -GqlMutation hypervDeleteAllSnapshots` |
| DeleteVirtualMachineSnapshot | [deleteHypervVirtualMachineSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Hyperv -Operation DeleteVirtualMachineSnapshot`<BR>or<BR>`New-RscMutation -GqlMutation deleteHypervVirtualMachineSnapshot` |
| DeleteVirtualMachineSnapshotMount | [deleteHypervVirtualMachineSnapshotMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Hyperv -Operation DeleteVirtualMachineSnapshotMount`<BR>or<BR>`New-RscMutation -GqlMutation deleteHypervVirtualMachineSnapshotMount` |
| DownloadSnapshotFromLocation | [downloadHypervSnapshotFromLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Hyperv -Operation DownloadSnapshotFromLocation`<BR>or<BR>`New-RscMutation -GqlMutation downloadHypervSnapshotFromLocation` |
| DownloadVirtualMachineSnapshot | [downloadHypervVirtualMachineSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Hyperv -Operation DownloadVirtualMachineSnapshot`<BR>or<BR>`New-RscMutation -GqlMutation downloadHypervVirtualMachineSnapshot` |
| DownloadVirtualMachineSnapshotFiles | [downloadHypervVirtualMachineSnapshotFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Hyperv -Operation DownloadVirtualMachineSnapshotFiles`<BR>or<BR>`New-RscMutation -GqlMutation downloadHypervVirtualMachineSnapshotFiles` |
| ExportVirtualMachine | [exportHypervVirtualMachine](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Hyperv -Operation ExportVirtualMachine`<BR>or<BR>`New-RscMutation -GqlMutation exportHypervVirtualMachine` |
| InstantRecoverVirtualMachineSnapshot | [instantRecoverHypervVirtualMachineSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Hyperv -Operation InstantRecoverVirtualMachineSnapshot`<BR>or<BR>`New-RscMutation -GqlMutation instantRecoverHypervVirtualMachineSnapshot` |
| OnDemandSnapshot | [hypervOnDemandSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Hyperv -Operation OnDemandSnapshot`<BR>or<BR>`New-RscMutation -GqlMutation hypervOnDemandSnapshot` |
| RefreshScvmm | [refreshHypervScvmm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Hyperv -Operation RefreshScvmm`<BR>or<BR>`New-RscMutation -GqlMutation refreshHypervScvmm` |
| RefreshServer | [refreshHypervServer](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Hyperv -Operation RefreshServer`<BR>or<BR>`New-RscMutation -GqlMutation refreshHypervServer` |
| RegisterAgentVirtualMachine | [registerAgentHypervVirtualMachine](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Hyperv -Operation RegisterAgentVirtualMachine`<BR>or<BR>`New-RscMutation -GqlMutation registerAgentHypervVirtualMachine` |
| RegisterScvmm | [registerHypervScvmm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Hyperv -Operation RegisterScvmm`<BR>or<BR>`New-RscMutation -GqlMutation registerHypervScvmm` |
| RestoreVirtualMachineSnapshotFiles | [restoreHypervVirtualMachineSnapshotFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Hyperv -Operation RestoreVirtualMachineSnapshotFiles`<BR>or<BR>`New-RscMutation -GqlMutation restoreHypervVirtualMachineSnapshotFiles` |
| ScvmmDelete | [hypervScvmmDelete](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Hyperv -Operation ScvmmDelete`<BR>or<BR>`New-RscMutation -GqlMutation hypervScvmmDelete` |
| ScvmmUpdate | [hypervScvmmUpdate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Hyperv -Operation ScvmmUpdate`<BR>or<BR>`New-RscMutation -GqlMutation hypervScvmmUpdate` |
| UpdateVirtualMachine | [updateHypervVirtualMachine](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Hyperv -Operation UpdateVirtualMachine`<BR>or<BR>`New-RscMutation -GqlMutation updateHypervVirtualMachine` |
| UpdateVirtualMachineSnapshotMount | [updateHypervVirtualMachineSnapshotMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Hyperv -Operation UpdateVirtualMachineSnapshotMount`<BR>or<BR>`New-RscMutation -GqlMutation updateHypervVirtualMachineSnapshotMount` |

[Go to top](#)
## Kubernetes domain

Domain key: K8s , e.g. '`-Domain K8s`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| AppManifest | [k8sAppManifest](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain K8s -Operation AppManifest`<BR>or<BR>`New-RscQuery -GqlQuery k8sAppManifest` |
| Cluster | [k8sCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain K8s -Operation Cluster`<BR>or<BR>`New-RscQuery -GqlQuery k8sCluster` |
| Clusters | [k8sClusters](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain K8s -Operation Clusters`<BR>or<BR>`New-RscQuery -GqlQuery k8sClusters` |
| Namespace | [k8sNamespace](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain K8s -Operation Namespace`<BR>or<BR>`New-RscQuery -GqlQuery k8sNamespace` |
| Namespaces | [k8sNamespaces](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain K8s -Operation Namespaces`<BR>or<BR>`New-RscQuery -GqlQuery k8sNamespaces` |
| ReplicaSnapshotInfos | [allK8sReplicaSnapshotInfos](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain K8s -Operation ReplicaSnapshotInfos`<BR>or<BR>`New-RscQuery -GqlQuery allK8sReplicaSnapshotInfos` |
| SnapshotInfo | [k8sSnapshotInfo](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain K8s -Operation SnapshotInfo`<BR>or<BR>`New-RscQuery -GqlQuery k8sSnapshotInfo` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| ArchiveCluster | [archiveK8sCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain K8s -Operation ArchiveCluster`<BR>or<BR>`New-RscMutation -GqlMutation archiveK8sCluster` |
| CreateAgentManifest | [createK8sAgentManifest](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain K8s -Operation CreateAgentManifest`<BR>or<BR>`New-RscMutation -GqlMutation createK8sAgentManifest` |
| CreateCluster | [createK8sCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain K8s -Operation CreateCluster`<BR>or<BR>`New-RscMutation -GqlMutation createK8sCluster` |
| CreateNamespaceSnapshots | [createK8sNamespaceSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain K8s -Operation CreateNamespaceSnapshots`<BR>or<BR>`New-RscMutation -GqlMutation createK8sNamespaceSnapshots` |
| ExportNamespace | [exportK8sNamespace](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain K8s -Operation ExportNamespace`<BR>or<BR>`New-RscMutation -GqlMutation exportK8sNamespace` |
| RefreshCluster | [refreshK8sCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain K8s -Operation RefreshCluster`<BR>or<BR>`New-RscMutation -GqlMutation refreshK8sCluster` |
| RestoreNamespace | [restoreK8sNamespace](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain K8s -Operation RestoreNamespace`<BR>or<BR>`New-RscMutation -GqlMutation restoreK8sNamespace` |

[Go to top](#)
## LDAP domain

Domain key: Ldap , e.g. '`-Domain Ldap`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| AuthorizedPrincipalList | [ldapAuthorizedPrincipalConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Ldap -Operation AuthorizedPrincipalList`<BR>or<BR>`New-RscQuery -GqlQuery ldapAuthorizedPrincipalConnection` |
| IntegrationList | [ldapIntegrationConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Ldap -Operation IntegrationList`<BR>or<BR>`New-RscQuery -GqlQuery ldapIntegrationConnection` |
| PrincipalList | [ldapPrincipalConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Ldap -Operation PrincipalList`<BR>or<BR>`New-RscQuery -GqlQuery ldapPrincipalConnection` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| DeletePrincipals | [deleteLdapPrincipals](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Ldap -Operation DeletePrincipals`<BR>or<BR>`New-RscMutation -GqlMutation deleteLdapPrincipals` |
| RemoveIntegration | [removeLdapIntegration](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Ldap -Operation RemoveIntegration`<BR>or<BR>`New-RscMutation -GqlMutation removeLdapIntegration` |
| SetMfaSetting | [setLdapMfaSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Ldap -Operation SetMfaSetting`<BR>or<BR>`New-RscMutation -GqlMutation setLdapMfaSetting` |
| UpdateIntegration | [updateLdapIntegration](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Ldap -Operation UpdateIntegration`<BR>or<BR>`New-RscMutation -GqlMutation updateLdapIntegration` |

[Go to top](#)
## M365 domain

Domain key: M365 , e.g. '`-Domain M365`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| Regions | [m365Regions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain M365 -Operation Regions`<BR>or<BR>`New-RscQuery -GqlQuery m365Regions` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| BackupMailbox | [backupM365Mailbox](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain M365 -Operation BackupMailbox`<BR>or<BR>`New-RscMutation -GqlMutation backupM365Mailbox` |
| BackupOnedrive | [backupM365Onedrive](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain M365 -Operation BackupOnedrive`<BR>or<BR>`New-RscMutation -GqlMutation backupM365Onedrive` |
| BackupSharepointDrive | [backupM365SharepointDrive](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain M365 -Operation BackupSharepointDrive`<BR>or<BR>`New-RscMutation -GqlMutation backupM365SharepointDrive` |
| BackupTeam | [backupM365Team](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain M365 -Operation BackupTeam`<BR>or<BR>`New-RscMutation -GqlMutation backupM365Team` |

[Go to top](#)
## Managed Volume domain

Domain key: ManagedVolume , e.g. '`-Domain ManagedVolume`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| InventoryStats | [managedVolumeInventoryStats](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain ManagedVolume -Operation InventoryStats`<BR>or<BR>`New-RscQuery -GqlQuery managedVolumeInventoryStats` |
| LiveMounts | [managedVolumeLiveMounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain ManagedVolume -Operation LiveMounts`<BR>or<BR>`New-RscQuery -GqlQuery managedVolumeLiveMounts` |
| ManagedVolume | [managedVolume](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain ManagedVolume -Operation ManagedVolume`<BR>or<BR>`New-RscQuery -GqlQuery managedVolume` |
| ManagedVolumes | [managedVolumes](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain ManagedVolume -Operation ManagedVolumes`<BR>or<BR>`New-RscQuery -GqlQuery managedVolumes` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| Add | [addManagedVolume](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain ManagedVolume -Operation Add`<BR>or<BR>`New-RscMutation -GqlMutation addManagedVolume` |
| BeginSnapshot | [beginManagedVolumeSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain ManagedVolume -Operation BeginSnapshot`<BR>or<BR>`New-RscMutation -GqlMutation beginManagedVolumeSnapshot` |
| Delete | [deleteManagedVolume](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain ManagedVolume -Operation Delete`<BR>or<BR>`New-RscMutation -GqlMutation deleteManagedVolume` |
| DeleteSnapshotExport | [deleteManagedVolumeSnapshotExport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain ManagedVolume -Operation DeleteSnapshotExport`<BR>or<BR>`New-RscMutation -GqlMutation deleteManagedVolumeSnapshotExport` |
| DownloadFiles | [downloadManagedVolumeFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain ManagedVolume -Operation DownloadFiles`<BR>or<BR>`New-RscMutation -GqlMutation downloadManagedVolumeFiles` |
| DownloadFromLocation | [downloadManagedVolumeFromLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain ManagedVolume -Operation DownloadFromLocation`<BR>or<BR>`New-RscMutation -GqlMutation downloadManagedVolumeFromLocation` |
| EndSnapshot | [endManagedVolumeSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain ManagedVolume -Operation EndSnapshot`<BR>or<BR>`New-RscMutation -GqlMutation endManagedVolumeSnapshot` |
| ExportSnapshot | [exportManagedVolumeSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain ManagedVolume -Operation ExportSnapshot`<BR>or<BR>`New-RscMutation -GqlMutation exportManagedVolumeSnapshot` |
| Resize | [resizeManagedVolume](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain ManagedVolume -Operation Resize`<BR>or<BR>`New-RscMutation -GqlMutation resizeManagedVolume` |
| TakeOnDemandSnapshot | [takeManagedVolumeOnDemandSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain ManagedVolume -Operation TakeOnDemandSnapshot`<BR>or<BR>`New-RscMutation -GqlMutation takeManagedVolumeOnDemandSnapshot` |
| Update | [updateManagedVolume](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain ManagedVolume -Operation Update`<BR>or<BR>`New-RscMutation -GqlMutation updateManagedVolume` |

[Go to top](#)
## Mongo domain

Domain key: Mongo , e.g. '`-Domain Mongo`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| BulkRecoverableRange | [mongodbBulkRecoverableRange](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Mongo -Operation BulkRecoverableRange`<BR>or<BR>`New-RscQuery -GqlQuery mongodbBulkRecoverableRange` |
| BulkRecoverableRanges | [mongoBulkRecoverableRanges](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Mongo -Operation BulkRecoverableRanges`<BR>or<BR>`New-RscQuery -GqlQuery mongoBulkRecoverableRanges` |
| Collection | [mongoCollection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Mongo -Operation Collection`<BR>or<BR>`New-RscQuery -GqlQuery mongoCollection` |
| CollectionRecoverableRange | [mongodbCollectionRecoverableRange](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Mongo -Operation CollectionRecoverableRange`<BR>or<BR>`New-RscQuery -GqlQuery mongodbCollectionRecoverableRange` |
| Collections | [mongoCollections](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Mongo -Operation Collections`<BR>or<BR>`New-RscQuery -GqlQuery mongoCollections` |
| Database | [mongoDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Mongo -Operation Database`<BR>or<BR>`New-RscQuery -GqlQuery mongoDatabase` |
| Databases | [mongoDatabases](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Mongo -Operation Databases`<BR>or<BR>`New-RscQuery -GqlQuery mongoDatabases` |
| RecoverableRanges | [mongoRecoverableRanges](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Mongo -Operation RecoverableRanges`<BR>or<BR>`New-RscQuery -GqlQuery mongoRecoverableRanges` |
| Source | [mongoSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Mongo -Operation Source`<BR>or<BR>`New-RscQuery -GqlQuery mongoSource` |
| Sources | [mongoSources](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Mongo -Operation Sources`<BR>or<BR>`New-RscQuery -GqlQuery mongoSources` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| AddSource | [addMongoSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Mongo -Operation AddSource`<BR>or<BR>`New-RscMutation -GqlMutation addMongoSource` |
| AssignSlaToCollection | [assignSlaToMongoDbCollection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Mongo -Operation AssignSlaToCollection`<BR>or<BR>`New-RscMutation -GqlMutation assignSlaToMongoDbCollection` |
| BulkDeleteSources | [bulkDeleteMongodbSources](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Mongo -Operation BulkDeleteSources`<BR>or<BR>`New-RscMutation -GqlMutation bulkDeleteMongodbSources` |
| CreateSource | [createMongodbSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Mongo -Operation CreateSource`<BR>or<BR>`New-RscMutation -GqlMutation createMongodbSource` |
| DeleteSource | [deleteMongoSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Mongo -Operation DeleteSource`<BR>or<BR>`New-RscMutation -GqlMutation deleteMongoSource` |
| DiscoverSource | [discoverMongoSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Mongo -Operation DiscoverSource`<BR>or<BR>`New-RscMutation -GqlMutation discoverMongoSource` |
| PatchSource | [patchMongoSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Mongo -Operation PatchSource`<BR>or<BR>`New-RscMutation -GqlMutation patchMongoSource` |
| RecoverSource | [recoverMongoSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Mongo -Operation RecoverSource`<BR>or<BR>`New-RscMutation -GqlMutation recoverMongoSource` |
| RetryAddSource | [retryAddMongoSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Mongo -Operation RetryAddSource`<BR>or<BR>`New-RscMutation -GqlMutation retryAddMongoSource` |
| UpdateSource | [updateMongodbSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Mongo -Operation UpdateSource`<BR>or<BR>`New-RscMutation -GqlMutation updateMongodbSource` |

[Go to top](#)
## Mosaic domain

Domain key: Mosaic , e.g. '`-Domain Mosaic`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| BulkRecoveryRange | [mosaicBulkRecoveryRange](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Mosaic -Operation BulkRecoveryRange`<BR>or<BR>`New-RscQuery -GqlQuery mosaicBulkRecoveryRange` |
| Snapshots | [mosaicSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Mosaic -Operation Snapshots`<BR>or<BR>`New-RscQuery -GqlQuery mosaicSnapshots` |
| Stores | [mosaicStores](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Mosaic -Operation Stores`<BR>or<BR>`New-RscQuery -GqlQuery mosaicStores` |
| Versions | [mosaicVersions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Mosaic -Operation Versions`<BR>or<BR>`New-RscQuery -GqlQuery mosaicVersions` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| AddStore | [addMosaicStore](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Mosaic -Operation AddStore`<BR>or<BR>`New-RscMutation -GqlMutation addMosaicStore` |
| DeleteStore | [deleteMosaicStore](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Mosaic -Operation DeleteStore`<BR>or<BR>`New-RscMutation -GqlMutation deleteMosaicStore` |
| UpdateStore | [updateMosaicStore](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Mosaic -Operation UpdateStore`<BR>or<BR>`New-RscMutation -GqlMutation updateMosaicStore` |

[Go to top](#)
## MSSQL domain

Domain key: Mssql , e.g. '`-Domain Mssql`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| AvailabilityGroup | [mssqlAvailabilityGroup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Mssql -Operation AvailabilityGroup`<BR>or<BR>`New-RscQuery -GqlQuery mssqlAvailabilityGroup` |
| CdmLogShippingTarget | [cdmMssqlLogShippingTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Mssql -Operation CdmLogShippingTarget`<BR>or<BR>`New-RscQuery -GqlQuery cdmMssqlLogShippingTarget` |
| CdmLogShippingTargets | [cdmMssqlLogShippingTargets](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Mssql -Operation CdmLogShippingTargets`<BR>or<BR>`New-RscQuery -GqlQuery cdmMssqlLogShippingTargets` |
| CompatibleInstances | [mssqlCompatibleInstances](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Mssql -Operation CompatibleInstances`<BR>or<BR>`New-RscQuery -GqlQuery mssqlCompatibleInstances` |
| Database | [mssqlDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Mssql -Operation Database`<BR>or<BR>`New-RscQuery -GqlQuery mssqlDatabase` |
| DatabaseLiveMounts | [mssqlDatabaseLiveMounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Mssql -Operation DatabaseLiveMounts`<BR>or<BR>`New-RscQuery -GqlQuery mssqlDatabaseLiveMounts` |
| DatabaseMissedRecoverableRanges | [mssqlDatabaseMissedRecoverableRanges](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Mssql -Operation DatabaseMissedRecoverableRanges`<BR>or<BR>`New-RscQuery -GqlQuery mssqlDatabaseMissedRecoverableRanges` |
| DatabaseMissedSnapshots | [mssqlDatabaseMissedSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Mssql -Operation DatabaseMissedSnapshots`<BR>or<BR>`New-RscQuery -GqlQuery mssqlDatabaseMissedSnapshots` |
| DatabaseRestoreEstimate | [mssqlDatabaseRestoreEstimate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Mssql -Operation DatabaseRestoreEstimate`<BR>or<BR>`New-RscQuery -GqlQuery mssqlDatabaseRestoreEstimate` |
| DatabaseRestoreFiles | [allMssqlDatabaseRestoreFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Mssql -Operation DatabaseRestoreFiles`<BR>or<BR>`New-RscQuery -GqlQuery allMssqlDatabaseRestoreFiles` |
| Databases | [mssqlDatabases](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Mssql -Operation Databases`<BR>or<BR>`New-RscQuery -GqlQuery mssqlDatabases` |
| DefaultProperties | [mssqlDefaultProperties](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Mssql -Operation DefaultProperties`<BR>or<BR>`New-RscQuery -GqlQuery mssqlDefaultProperties` |
| Instance | [mssqlInstance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Mssql -Operation Instance`<BR>or<BR>`New-RscQuery -GqlQuery mssqlInstance` |
| LogShippingTargets | [mssqlLogShippingTargets](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Mssql -Operation LogShippingTargets`<BR>or<BR>`New-RscQuery -GqlQuery mssqlLogShippingTargets` |
| RecoverableRanges | [mssqlRecoverableRanges](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Mssql -Operation RecoverableRanges`<BR>or<BR>`New-RscQuery -GqlQuery mssqlRecoverableRanges` |
| TopLevelDescendants | [mssqlTopLevelDescendants](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Mssql -Operation TopLevelDescendants`<BR>or<BR>`New-RscQuery -GqlQuery mssqlTopLevelDescendants` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| AssignSlaDomainProperties | [assignMssqlSlaDomainProperties](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Mssql -Operation AssignSlaDomainProperties`<BR>or<BR>`New-RscMutation -GqlMutation assignMssqlSlaDomainProperties` |
| AssignSlaDomainPropertiesAsync | [assignMssqlSlaDomainPropertiesAsync](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Mssql -Operation AssignSlaDomainPropertiesAsync`<BR>or<BR>`New-RscMutation -GqlMutation assignMssqlSlaDomainPropertiesAsync` |
| BrowseDatabaseSnapshot | [browseMssqlDatabaseSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Mssql -Operation BrowseDatabaseSnapshot`<BR>or<BR>`New-RscMutation -GqlMutation browseMssqlDatabaseSnapshot` |
| BulkCreateOnDemandBackup | [bulkCreateOnDemandMssqlBackup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Mssql -Operation BulkCreateOnDemandBackup`<BR>or<BR>`New-RscMutation -GqlMutation bulkCreateOnDemandMssqlBackup` |
| BulkUpdateDbs | [bulkUpdateMssqlDbs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Mssql -Operation BulkUpdateDbs`<BR>or<BR>`New-RscMutation -GqlMutation bulkUpdateMssqlDbs` |
| CreateLiveMount | [createMssqlLiveMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Mssql -Operation CreateLiveMount`<BR>or<BR>`New-RscMutation -GqlMutation createMssqlLiveMount` |
| CreateLogShippingConfiguration | [createMssqlLogShippingConfiguration](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Mssql -Operation CreateLogShippingConfiguration`<BR>or<BR>`New-RscMutation -GqlMutation createMssqlLogShippingConfiguration` |
| CreateOnDemandBackup | [createOnDemandMssqlBackup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Mssql -Operation CreateOnDemandBackup`<BR>or<BR>`New-RscMutation -GqlMutation createOnDemandMssqlBackup` |
| DeleteDbSnapshots | [deleteMssqlDbSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Mssql -Operation DeleteDbSnapshots`<BR>or<BR>`New-RscMutation -GqlMutation deleteMssqlDbSnapshots` |
| DeleteLiveMount | [deleteMssqlLiveMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Mssql -Operation DeleteLiveMount`<BR>or<BR>`New-RscMutation -GqlMutation deleteMssqlLiveMount` |
| DownloadDatabaseBackupFiles | [downloadMssqlDatabaseBackupFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Mssql -Operation DownloadDatabaseBackupFiles`<BR>or<BR>`New-RscMutation -GqlMutation downloadMssqlDatabaseBackupFiles` |
| DownloadDatabaseFilesFromArchivalLocation | [downloadMssqlDatabaseFilesFromArchivalLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Mssql -Operation DownloadDatabaseFilesFromArchivalLocation`<BR>or<BR>`New-RscMutation -GqlMutation downloadMssqlDatabaseFilesFromArchivalLocation` |
| ExportDatabase | [exportMssqlDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Mssql -Operation ExportDatabase`<BR>or<BR>`New-RscMutation -GqlMutation exportMssqlDatabase` |
| RestoreDatabase | [restoreMssqlDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Mssql -Operation RestoreDatabase`<BR>or<BR>`New-RscMutation -GqlMutation restoreMssqlDatabase` |
| TakeLogBackup | [takeMssqlLogBackup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Mssql -Operation TakeLogBackup`<BR>or<BR>`New-RscMutation -GqlMutation takeMssqlLogBackup` |
| UpdateDefaultProperties | [updateMssqlDefaultProperties](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Mssql -Operation UpdateDefaultProperties`<BR>or<BR>`New-RscMutation -GqlMutation updateMssqlDefaultProperties` |
| UpdateLogShippingConfiguration | [updateMssqlLogShippingConfiguration](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Mssql -Operation UpdateLogShippingConfiguration`<BR>or<BR>`New-RscMutation -GqlMutation updateMssqlLogShippingConfiguration` |

[Go to top](#)
## NAS domain

Domain key: Nas , e.g. '`-Domain Nas`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| Fileset | [nasFileset](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Nas -Operation Fileset`<BR>or<BR>`New-RscQuery -GqlQuery nasFileset` |
| Namespace | [nasNamespace](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Nas -Operation Namespace`<BR>or<BR>`New-RscQuery -GqlQuery nasNamespace` |
| Namespaces | [nasNamespaces](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Nas -Operation Namespaces`<BR>or<BR>`New-RscQuery -GqlQuery nasNamespaces` |
| Share | [nasShare](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Nas -Operation Share`<BR>or<BR>`New-RscQuery -GqlQuery nasShare` |
| System | [nasSystem](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Nas -Operation System`<BR>or<BR>`New-RscQuery -GqlQuery nasSystem` |
| Systems | [nasSystems](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Nas -Operation Systems`<BR>or<BR>`New-RscQuery -GqlQuery nasSystems` |
| TopLevelDescendants | [nasTopLevelDescendants](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Nas -Operation TopLevelDescendants`<BR>or<BR>`New-RscQuery -GqlQuery nasTopLevelDescendants` |
| Volume | [nasVolume](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Nas -Operation Volume`<BR>or<BR>`New-RscQuery -GqlQuery nasVolume` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |

[Go to top](#)
## NFS domain

Domain key: Nfs , e.g. '`-Domain Nfs`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| CreateReaderTarget | [createNfsReaderTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Nfs -Operation CreateReaderTarget`<BR>or<BR>`New-RscMutation -GqlMutation createNfsReaderTarget` |
| CreateTarget | [createNfsTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Nfs -Operation CreateTarget`<BR>or<BR>`New-RscMutation -GqlMutation createNfsTarget` |
| UpdateTarget | [updateNfsTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Nfs -Operation UpdateTarget`<BR>or<BR>`New-RscMutation -GqlMutation updateNfsTarget` |

[Go to top](#)
## Nutanix domain

Domain key: Nutanix , e.g. '`-Domain Nutanix`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| BrowseSnapshot | [nutanixBrowseSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Nutanix -Operation BrowseSnapshot`<BR>or<BR>`New-RscQuery -GqlQuery nutanixBrowseSnapshot` |
| Category | [nutanixCategory](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Nutanix -Operation Category`<BR>or<BR>`New-RscQuery -GqlQuery nutanixCategory` |
| CategoryValue | [nutanixCategoryValue](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Nutanix -Operation CategoryValue`<BR>or<BR>`New-RscQuery -GqlQuery nutanixCategoryValue` |
| Cluster | [nutanixCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Nutanix -Operation Cluster`<BR>or<BR>`New-RscQuery -GqlQuery nutanixCluster` |
| ClusterAsyncRequestStatus | [nutanixClusterAsyncRequestStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Nutanix -Operation ClusterAsyncRequestStatus`<BR>or<BR>`New-RscQuery -GqlQuery nutanixClusterAsyncRequestStatus` |
| ClusterContainers | [nutanixClusterContainers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Nutanix -Operation ClusterContainers`<BR>or<BR>`New-RscQuery -GqlQuery nutanixClusterContainers` |
| ClusterNetworks | [nutanixClusterNetworks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Nutanix -Operation ClusterNetworks`<BR>or<BR>`New-RscQuery -GqlQuery nutanixClusterNetworks` |
| Clusters | [nutanixClusters](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Nutanix -Operation Clusters`<BR>or<BR>`New-RscQuery -GqlQuery nutanixClusters` |
| Mounts | [nutanixMounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Nutanix -Operation Mounts`<BR>or<BR>`New-RscQuery -GqlQuery nutanixMounts` |
| PrismCentral | [nutanixPrismCentral](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Nutanix -Operation PrismCentral`<BR>or<BR>`New-RscQuery -GqlQuery nutanixPrismCentral` |
| PrismCentrals | [nutanixPrismCentrals](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Nutanix -Operation PrismCentrals`<BR>or<BR>`New-RscQuery -GqlQuery nutanixPrismCentrals` |
| SearchVm | [searchNutanixVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Nutanix -Operation SearchVm`<BR>or<BR>`New-RscQuery -GqlQuery searchNutanixVm` |
| SnapshotDetail | [nutanixSnapshotDetail](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Nutanix -Operation SnapshotDetail`<BR>or<BR>`New-RscQuery -GqlQuery nutanixSnapshotDetail` |
| TopLevelDescendants | [nutanixTopLevelDescendants](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Nutanix -Operation TopLevelDescendants`<BR>or<BR>`New-RscQuery -GqlQuery nutanixTopLevelDescendants` |
| Vm | [nutanixVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Nutanix -Operation Vm`<BR>or<BR>`New-RscQuery -GqlQuery nutanixVm` |
| VmAsyncRequestStatus | [nutanixVmAsyncRequestStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Nutanix -Operation VmAsyncRequestStatus`<BR>or<BR>`New-RscQuery -GqlQuery nutanixVmAsyncRequestStatus` |
| VmMissedSnapshots | [nutanixVmMissedSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Nutanix -Operation VmMissedSnapshots`<BR>or<BR>`New-RscQuery -GqlQuery nutanixVmMissedSnapshots` |
| Vms | [nutanixVms](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Nutanix -Operation Vms`<BR>or<BR>`New-RscQuery -GqlQuery nutanixVms` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| BatchExportVm | [batchExportNutanixVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Nutanix -Operation BatchExportVm`<BR>or<BR>`New-RscMutation -GqlMutation batchExportNutanixVm` |
| BatchMountVm | [batchMountNutanixVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Nutanix -Operation BatchMountVm`<BR>or<BR>`New-RscMutation -GqlMutation batchMountNutanixVm` |
| BulkOnDemandSnapshotVm | [bulkOnDemandSnapshotNutanixVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Nutanix -Operation BulkOnDemandSnapshotVm`<BR>or<BR>`New-RscMutation -GqlMutation bulkOnDemandSnapshotNutanixVm` |
| CreateCluster | [createNutanixCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Nutanix -Operation CreateCluster`<BR>or<BR>`New-RscMutation -GqlMutation createNutanixCluster` |
| CreateOnDemandBackup | [createOnDemandNutanixBackup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Nutanix -Operation CreateOnDemandBackup`<BR>or<BR>`New-RscMutation -GqlMutation createOnDemandNutanixBackup` |
| CreatePrismCentral | [createNutanixPrismCentral](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Nutanix -Operation CreatePrismCentral`<BR>or<BR>`New-RscMutation -GqlMutation createNutanixPrismCentral` |
| DeleteCluster | [deleteNutanixCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Nutanix -Operation DeleteCluster`<BR>or<BR>`New-RscMutation -GqlMutation deleteNutanixCluster` |
| DeleteMountV1 | [deleteNutanixMountV1](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Nutanix -Operation DeleteMountV1`<BR>or<BR>`New-RscMutation -GqlMutation deleteNutanixMountV1` |
| DeletePrismCentral | [deleteNutanixPrismCentral](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Nutanix -Operation DeletePrismCentral`<BR>or<BR>`New-RscMutation -GqlMutation deleteNutanixPrismCentral` |
| DeleteSnapshot | [deleteNutanixSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Nutanix -Operation DeleteSnapshot`<BR>or<BR>`New-RscMutation -GqlMutation deleteNutanixSnapshot` |
| DeleteSnapshots | [deleteNutanixSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Nutanix -Operation DeleteSnapshots`<BR>or<BR>`New-RscMutation -GqlMutation deleteNutanixSnapshots` |
| DownloadFilesSnapshot | [downloadFilesNutanixSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Nutanix -Operation DownloadFilesSnapshot`<BR>or<BR>`New-RscMutation -GqlMutation downloadFilesNutanixSnapshot` |
| DownloadSnapshot | [downloadNutanixSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Nutanix -Operation DownloadSnapshot`<BR>or<BR>`New-RscMutation -GqlMutation downloadNutanixSnapshot` |
| DownloadVmFromLocation | [downloadNutanixVmFromLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Nutanix -Operation DownloadVmFromLocation`<BR>or<BR>`New-RscMutation -GqlMutation downloadNutanixVmFromLocation` |
| ExportSnapshot | [exportNutanixSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Nutanix -Operation ExportSnapshot`<BR>or<BR>`New-RscMutation -GqlMutation exportNutanixSnapshot` |
| MigrateMountV1 | [migrateNutanixMountV1](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Nutanix -Operation MigrateMountV1`<BR>or<BR>`New-RscMutation -GqlMutation migrateNutanixMountV1` |
| MountSnapshotV1 | [mountNutanixSnapshotV1](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Nutanix -Operation MountSnapshotV1`<BR>or<BR>`New-RscMutation -GqlMutation mountNutanixSnapshotV1` |
| PatchMountV1 | [patchNutanixMountV1](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Nutanix -Operation PatchMountV1`<BR>or<BR>`New-RscMutation -GqlMutation patchNutanixMountV1` |
| RefreshCluster | [refreshNutanixCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Nutanix -Operation RefreshCluster`<BR>or<BR>`New-RscMutation -GqlMutation refreshNutanixCluster` |
| RefreshPrismCentral | [refreshNutanixPrismCentral](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Nutanix -Operation RefreshPrismCentral`<BR>or<BR>`New-RscMutation -GqlMutation refreshNutanixPrismCentral` |
| RegisterAgentVm | [registerAgentNutanixVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Nutanix -Operation RegisterAgentVm`<BR>or<BR>`New-RscMutation -GqlMutation registerAgentNutanixVm` |
| RestoreFilesSnapshot | [restoreFilesNutanixSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Nutanix -Operation RestoreFilesSnapshot`<BR>or<BR>`New-RscMutation -GqlMutation restoreFilesNutanixSnapshot` |
| UpdateCluster | [updateNutanixCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Nutanix -Operation UpdateCluster`<BR>or<BR>`New-RscMutation -GqlMutation updateNutanixCluster` |
| UpdatePrismCentral | [updateNutanixPrismCentral](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Nutanix -Operation UpdatePrismCentral`<BR>or<BR>`New-RscMutation -GqlMutation updateNutanixPrismCentral` |
| UpdateVm | [updateNutanixVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Nutanix -Operation UpdateVm`<BR>or<BR>`New-RscMutation -GqlMutation updateNutanixVm` |

[Go to top](#)
## O365 domain

Domain key: O365 , e.g. '`-Domain O365`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| AdGroups | [allO365AdGroups](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain O365 -Operation AdGroups`<BR>or<BR>`New-RscQuery -GqlQuery allO365AdGroups` |
| BrowseTeamConvChannels | [browseO365TeamConvChannels](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain O365 -Operation BrowseTeamConvChannels`<BR>or<BR>`New-RscQuery -GqlQuery browseO365TeamConvChannels` |
| Calendar | [o365Calendar](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain O365 -Operation Calendar`<BR>or<BR>`New-RscQuery -GqlQuery o365Calendar` |
| Groups | [o365Groups](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain O365 -Operation Groups`<BR>or<BR>`New-RscQuery -GqlQuery o365Groups` |
| License | [o365License](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain O365 -Operation License`<BR>or<BR>`New-RscQuery -GqlQuery o365License` |
| ListApps | [listO365Apps](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain O365 -Operation ListApps`<BR>or<BR>`New-RscQuery -GqlQuery listO365Apps` |
| Mailbox | [o365Mailbox](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain O365 -Operation Mailbox`<BR>or<BR>`New-RscQuery -GqlQuery o365Mailbox` |
| Mailboxes | [o365Mailboxes](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain O365 -Operation Mailboxes`<BR>or<BR>`New-RscQuery -GqlQuery o365Mailboxes` |
| ObjectAncestors | [o365ObjectAncestors](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain O365 -Operation ObjectAncestors`<BR>or<BR>`New-RscQuery -GqlQuery o365ObjectAncestors` |
| Onedrive | [o365Onedrive](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain O365 -Operation Onedrive`<BR>or<BR>`New-RscQuery -GqlQuery o365Onedrive` |
| Onedrives | [o365Onedrives](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain O365 -Operation Onedrives`<BR>or<BR>`New-RscQuery -GqlQuery o365Onedrives` |
| Org | [o365Org](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain O365 -Operation Org`<BR>or<BR>`New-RscQuery -GqlQuery o365Org` |
| OrgAtSnappableLevel | [o365OrgAtSnappableLevel](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain O365 -Operation OrgAtSnappableLevel`<BR>or<BR>`New-RscQuery -GqlQuery o365OrgAtSnappableLevel` |
| OrgStatuses | [allO365OrgStatuses](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain O365 -Operation OrgStatuses`<BR>or<BR>`New-RscQuery -GqlQuery allO365OrgStatuses` |
| OrgSummaries | [o365OrgSummaries](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain O365 -Operation OrgSummaries`<BR>or<BR>`New-RscQuery -GqlQuery o365OrgSummaries` |
| Orgs | [o365Orgs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain O365 -Operation Orgs`<BR>or<BR>`New-RscQuery -GqlQuery o365Orgs` |
| ServiceAccount | [o365ServiceAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain O365 -Operation ServiceAccount`<BR>or<BR>`New-RscQuery -GqlQuery o365ServiceAccount` |
| ServiceStatus | [o365ServiceStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain O365 -Operation ServiceStatus`<BR>or<BR>`New-RscQuery -GqlQuery o365ServiceStatus` |
| SharepointDrive | [o365SharepointDrive](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain O365 -Operation SharepointDrive`<BR>or<BR>`New-RscQuery -GqlQuery o365SharepointDrive` |
| SharepointDrives | [o365SharepointDrives](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain O365 -Operation SharepointDrives`<BR>or<BR>`New-RscQuery -GqlQuery o365SharepointDrives` |
| SharepointList | [o365SharepointList](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain O365 -Operation SharepointList`<BR>or<BR>`New-RscQuery -GqlQuery o365SharepointList` |
| SharepointLists | [o365SharepointLists](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain O365 -Operation SharepointLists`<BR>or<BR>`New-RscQuery -GqlQuery o365SharepointLists` |
| SharepointObjectList | [o365SharepointObjectList](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain O365 -Operation SharepointObjectList`<BR>or<BR>`New-RscQuery -GqlQuery o365SharepointObjectList` |
| SharepointObjects | [o365SharepointObjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain O365 -Operation SharepointObjects`<BR>or<BR>`New-RscQuery -GqlQuery o365SharepointObjects` |
| SharepointSite | [o365SharepointSite](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain O365 -Operation SharepointSite`<BR>or<BR>`New-RscQuery -GqlQuery o365SharepointSite` |
| SharepointSites | [o365SharepointSites](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain O365 -Operation SharepointSites`<BR>or<BR>`New-RscQuery -GqlQuery o365SharepointSites` |
| Site | [o365Site](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain O365 -Operation Site`<BR>or<BR>`New-RscQuery -GqlQuery o365Site` |
| Sites | [o365Sites](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain O365 -Operation Sites`<BR>or<BR>`New-RscQuery -GqlQuery o365Sites` |
| StorageStats | [o365StorageStats](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain O365 -Operation StorageStats`<BR>or<BR>`New-RscQuery -GqlQuery o365StorageStats` |
| SubscriptionsAppTypeCounts | [allO365SubscriptionsAppTypeCounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain O365 -Operation SubscriptionsAppTypeCounts`<BR>or<BR>`New-RscQuery -GqlQuery allO365SubscriptionsAppTypeCounts` |
| Team | [o365Team](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain O365 -Operation Team`<BR>or<BR>`New-RscQuery -GqlQuery o365Team` |
| TeamChannels | [o365TeamChannels](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain O365 -Operation TeamChannels`<BR>or<BR>`New-RscQuery -GqlQuery o365TeamChannels` |
| TeamConversationsFolderID | [o365TeamConversationsFolderID](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain O365 -Operation TeamConversationsFolderID`<BR>or<BR>`New-RscQuery -GqlQuery o365TeamConversationsFolderID` |
| TeamPostedBy | [o365TeamPostedBy](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain O365 -Operation TeamPostedBy`<BR>or<BR>`New-RscQuery -GqlQuery o365TeamPostedBy` |
| Teams | [o365Teams](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain O365 -Operation Teams`<BR>or<BR>`New-RscQuery -GqlQuery o365Teams` |
| User | [o365User](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain O365 -Operation User`<BR>or<BR>`New-RscQuery -GqlQuery o365User` |
| UserObjects | [o365UserObjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain O365 -Operation UserObjects`<BR>or<BR>`New-RscQuery -GqlQuery o365UserObjects` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| AddOrg | [addO365Org](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain O365 -Operation AddOrg`<BR>or<BR>`New-RscMutation -GqlMutation addO365Org` |
| BackupMailbox | [backupO365Mailbox](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain O365 -Operation BackupMailbox`<BR>or<BR>`New-RscMutation -GqlMutation backupO365Mailbox` |
| BackupOnedrive | [backupO365Onedrive](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain O365 -Operation BackupOnedrive`<BR>or<BR>`New-RscMutation -GqlMutation backupO365Onedrive` |
| BackupSharePointSite | [backupO365SharePointSite](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain O365 -Operation BackupSharePointSite`<BR>or<BR>`New-RscMutation -GqlMutation backupO365SharePointSite` |
| BackupSharepointDrive | [backupO365SharepointDrive](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain O365 -Operation BackupSharepointDrive`<BR>or<BR>`New-RscMutation -GqlMutation backupO365SharepointDrive` |
| BackupSharepointList | [backupO365SharepointList](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain O365 -Operation BackupSharepointList`<BR>or<BR>`New-RscMutation -GqlMutation backupO365SharepointList` |
| BackupTeam | [backupO365Team](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain O365 -Operation BackupTeam`<BR>or<BR>`New-RscMutation -GqlMutation backupO365Team` |
| CreateAppComplete | [createO365AppComplete](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain O365 -Operation CreateAppComplete`<BR>or<BR>`New-RscMutation -GqlMutation createO365AppComplete` |
| CreateAppKickoff | [createO365AppKickoff](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain O365 -Operation CreateAppKickoff`<BR>or<BR>`New-RscMutation -GqlMutation createO365AppKickoff` |
| DeleteAzureApp | [deleteO365AzureApp](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain O365 -Operation DeleteAzureApp`<BR>or<BR>`New-RscMutation -GqlMutation deleteO365AzureApp` |
| DeleteOrg | [deleteO365Org](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain O365 -Operation DeleteOrg`<BR>or<BR>`New-RscMutation -GqlMutation deleteO365Org` |
| DeleteServiceAccount | [deleteO365ServiceAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain O365 -Operation DeleteServiceAccount`<BR>or<BR>`New-RscMutation -GqlMutation deleteO365ServiceAccount` |
| EnableSharePoint | [enableO365SharePoint](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain O365 -Operation EnableSharePoint`<BR>or<BR>`New-RscMutation -GqlMutation enableO365SharePoint` |
| EnableTeams | [enableO365Teams](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain O365 -Operation EnableTeams`<BR>or<BR>`New-RscMutation -GqlMutation enableO365Teams` |
| ExportMailbox | [exportO365Mailbox](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain O365 -Operation ExportMailbox`<BR>or<BR>`New-RscMutation -GqlMutation exportO365Mailbox` |
| InsertCustomerApp | [insertCustomerO365App](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain O365 -Operation InsertCustomerApp`<BR>or<BR>`New-RscMutation -GqlMutation insertCustomerO365App` |
| OauthConsentComplete | [o365OauthConsentComplete](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain O365 -Operation OauthConsentComplete`<BR>or<BR>`New-RscMutation -GqlMutation o365OauthConsentComplete` |
| OauthConsentKickoff | [o365OauthConsentKickoff](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain O365 -Operation OauthConsentKickoff`<BR>or<BR>`New-RscMutation -GqlMutation o365OauthConsentKickoff` |
| PdlGroups | [o365PdlGroups](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain O365 -Operation PdlGroups`<BR>or<BR>`New-RscMutation -GqlMutation o365PdlGroups` |
| RefreshOrg | [refreshO365Org](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain O365 -Operation RefreshOrg`<BR>or<BR>`New-RscMutation -GqlMutation refreshO365Org` |
| RestoreMailbox | [restoreO365Mailbox](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain O365 -Operation RestoreMailbox`<BR>or<BR>`New-RscMutation -GqlMutation restoreO365Mailbox` |
| RestoreSnappable | [restoreO365Snappable](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain O365 -Operation RestoreSnappable`<BR>or<BR>`New-RscMutation -GqlMutation restoreO365Snappable` |
| RestoreTeamsConversations | [restoreO365TeamsConversations](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain O365 -Operation RestoreTeamsConversations`<BR>or<BR>`New-RscMutation -GqlMutation restoreO365TeamsConversations` |
| RestoreTeamsFiles | [restoreO365TeamsFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain O365 -Operation RestoreTeamsFiles`<BR>or<BR>`New-RscMutation -GqlMutation restoreO365TeamsFiles` |
| SaaSSetupKickoff | [o365SaaSSetupKickoff](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain O365 -Operation SaaSSetupKickoff`<BR>or<BR>`New-RscMutation -GqlMutation o365SaaSSetupKickoff` |
| SaasSetupComplete | [o365SaasSetupComplete](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain O365 -Operation SaasSetupComplete`<BR>or<BR>`New-RscMutation -GqlMutation o365SaasSetupComplete` |
| SetServiceAccount | [setO365ServiceAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain O365 -Operation SetServiceAccount`<BR>or<BR>`New-RscMutation -GqlMutation setO365ServiceAccount` |
| SetupKickoff | [o365SetupKickoff](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain O365 -Operation SetupKickoff`<BR>or<BR>`New-RscMutation -GqlMutation o365SetupKickoff` |
| UpdateAppAuthStatus | [updateO365AppAuthStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain O365 -Operation UpdateAppAuthStatus`<BR>or<BR>`New-RscMutation -GqlMutation updateO365AppAuthStatus` |
| UpdateAppPermissions | [updateO365AppPermissions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain O365 -Operation UpdateAppPermissions`<BR>or<BR>`New-RscMutation -GqlMutation updateO365AppPermissions` |
| UpdateOrgCustomName | [updateO365OrgCustomName](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain O365 -Operation UpdateOrgCustomName`<BR>or<BR>`New-RscMutation -GqlMutation updateO365OrgCustomName` |

[Go to top](#)
## Oracle domain

Domain key: Oracle , e.g. '`-Domain Oracle`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| AcoExampleDownloadLink | [oracleAcoExampleDownloadLink](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Oracle -Operation AcoExampleDownloadLink`<BR>or<BR>`New-RscQuery -GqlQuery oracleAcoExampleDownloadLink` |
| AcoParameters | [oracleAcoParameters](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Oracle -Operation AcoParameters`<BR>or<BR>`New-RscQuery -GqlQuery oracleAcoParameters` |
| DataGuardGroup | [oracleDataGuardGroup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Oracle -Operation DataGuardGroup`<BR>or<BR>`New-RscQuery -GqlQuery oracleDataGuardGroup` |
| Database | [oracleDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Oracle -Operation Database`<BR>or<BR>`New-RscQuery -GqlQuery oracleDatabase` |
| DatabaseLogBackupConfig | [oracleDatabaseLogBackupConfig](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Oracle -Operation DatabaseLogBackupConfig`<BR>or<BR>`New-RscQuery -GqlQuery oracleDatabaseLogBackupConfig` |
| Databases | [oracleDatabases](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Oracle -Operation Databases`<BR>or<BR>`New-RscQuery -GqlQuery oracleDatabases` |
| Host | [oracleHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Oracle -Operation Host`<BR>or<BR>`New-RscQuery -GqlQuery oracleHost` |
| HostLogBackupConfig | [oracleHostLogBackupConfig](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Oracle -Operation HostLogBackupConfig`<BR>or<BR>`New-RscQuery -GqlQuery oracleHostLogBackupConfig` |
| LiveMounts | [oracleLiveMounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Oracle -Operation LiveMounts`<BR>or<BR>`New-RscQuery -GqlQuery oracleLiveMounts` |
| MissedRecoverableRanges | [oracleMissedRecoverableRanges](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Oracle -Operation MissedRecoverableRanges`<BR>or<BR>`New-RscQuery -GqlQuery oracleMissedRecoverableRanges` |
| MissedSnapshots | [oracleMissedSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Oracle -Operation MissedSnapshots`<BR>or<BR>`New-RscQuery -GqlQuery oracleMissedSnapshots` |
| PdbDetails | [oraclePdbDetails](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Oracle -Operation PdbDetails`<BR>or<BR>`New-RscQuery -GqlQuery oraclePdbDetails` |
| Rac | [oracleRac](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Oracle -Operation Rac`<BR>or<BR>`New-RscQuery -GqlQuery oracleRac` |
| RacLogBackupConfig | [oracleRacLogBackupConfig](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Oracle -Operation RacLogBackupConfig`<BR>or<BR>`New-RscQuery -GqlQuery oracleRacLogBackupConfig` |
| RecoverableRanges | [oracleRecoverableRanges](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Oracle -Operation RecoverableRanges`<BR>or<BR>`New-RscQuery -GqlQuery oracleRecoverableRanges` |
| TopLevelDescendants | [oracleTopLevelDescendants](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Oracle -Operation TopLevelDescendants`<BR>or<BR>`New-RscQuery -GqlQuery oracleTopLevelDescendants` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| BulkUpdateDatabases | [bulkUpdateOracleDatabases](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Oracle -Operation BulkUpdateDatabases`<BR>or<BR>`New-RscMutation -GqlMutation bulkUpdateOracleDatabases` |
| BulkUpdateHosts | [bulkUpdateOracleHosts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Oracle -Operation BulkUpdateHosts`<BR>or<BR>`New-RscMutation -GqlMutation bulkUpdateOracleHosts` |
| BulkUpdateRacs | [bulkUpdateOracleRacs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Oracle -Operation BulkUpdateRacs`<BR>or<BR>`New-RscMutation -GqlMutation bulkUpdateOracleRacs` |
| CreatePdbRestore | [createOraclePdbRestore](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Oracle -Operation CreatePdbRestore`<BR>or<BR>`New-RscMutation -GqlMutation createOraclePdbRestore` |
| DeleteAllDatabaseSnapshots | [deleteAllOracleDatabaseSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Oracle -Operation DeleteAllDatabaseSnapshots`<BR>or<BR>`New-RscMutation -GqlMutation deleteAllOracleDatabaseSnapshots` |
| DeleteMount | [deleteOracleMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Oracle -Operation DeleteMount`<BR>or<BR>`New-RscMutation -GqlMutation deleteOracleMount` |
| DownloadDatabaseSnapshot | [downloadOracleDatabaseSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Oracle -Operation DownloadDatabaseSnapshot`<BR>or<BR>`New-RscMutation -GqlMutation downloadOracleDatabaseSnapshot` |
| ExportDatabase | [exportOracleDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Oracle -Operation ExportDatabase`<BR>or<BR>`New-RscMutation -GqlMutation exportOracleDatabase` |
| ExportTablespace | [exportOracleTablespace](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Oracle -Operation ExportTablespace`<BR>or<BR>`New-RscMutation -GqlMutation exportOracleTablespace` |
| InstantRecoverSnapshot | [instantRecoverOracleSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Oracle -Operation InstantRecoverSnapshot`<BR>or<BR>`New-RscMutation -GqlMutation instantRecoverOracleSnapshot` |
| MountDatabase | [mountOracleDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Oracle -Operation MountDatabase`<BR>or<BR>`New-RscMutation -GqlMutation mountOracleDatabase` |
| RefreshDatabase | [refreshOracleDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Oracle -Operation RefreshDatabase`<BR>or<BR>`New-RscMutation -GqlMutation refreshOracleDatabase` |
| RestoreLogs | [restoreOracleLogs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Oracle -Operation RestoreLogs`<BR>or<BR>`New-RscMutation -GqlMutation restoreOracleLogs` |
| TakeOnDemandDatabaseSnapshot | [takeOnDemandOracleDatabaseSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Oracle -Operation TakeOnDemandDatabaseSnapshot`<BR>or<BR>`New-RscMutation -GqlMutation takeOnDemandOracleDatabaseSnapshot` |
| TakeOnDemandLogSnapshot | [takeOnDemandOracleLogSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Oracle -Operation TakeOnDemandLogSnapshot`<BR>or<BR>`New-RscMutation -GqlMutation takeOnDemandOracleLogSnapshot` |
| UpdateDataGuardGroup | [updateOracleDataGuardGroup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Oracle -Operation UpdateDataGuardGroup`<BR>or<BR>`New-RscMutation -GqlMutation updateOracleDataGuardGroup` |
| ValidateAcoFile | [validateOracleAcoFile](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Oracle -Operation ValidateAcoFile`<BR>or<BR>`New-RscMutation -GqlMutation validateOracleAcoFile` |
| ValidateDatabaseBackups | [validateOracleDatabaseBackups](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Oracle -Operation ValidateDatabaseBackups`<BR>or<BR>`New-RscMutation -GqlMutation validateOracleDatabaseBackups` |

[Go to top](#)
## Policy domain

Domain key: Policy , e.g. '`-Domain Policy`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| Details | [policyDetails](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Policy -Operation Details`<BR>or<BR>`New-RscQuery -GqlQuery policyDetails` |
| Obj | [policyObj](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Policy -Operation Obj`<BR>or<BR>`New-RscQuery -GqlQuery policyObj` |
| ObjectUsages | [policyObjectUsages](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Policy -Operation ObjectUsages`<BR>or<BR>`New-RscQuery -GqlQuery policyObjectUsages` |
| Objs | [policyObjs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Policy -Operation Objs`<BR>or<BR>`New-RscQuery -GqlQuery policyObjs` |
| Policies | [policies](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Policy -Operation Policies`<BR>or<BR>`New-RscQuery -GqlQuery policies` |
| Policy | [policy](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Policy -Operation Policy`<BR>or<BR>`New-RscQuery -GqlQuery policy` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| Policies | [seedInitialPolicies](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Policy -Operation Policies`<BR>or<BR>`New-RscMutation -GqlMutation seedInitialPolicies` |

[Go to top](#)
## Ransomware domain

Domain key: Ransomware , e.g. '`-Domain Ransomware`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| DetectionWorkloadLocations | [ransomwareDetectionWorkloadLocations](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Ransomware -Operation DetectionWorkloadLocations`<BR>or<BR>`New-RscQuery -GqlQuery ransomwareDetectionWorkloadLocations` |
| InvestigationAnalysisSummary | [ransomwareInvestigationAnalysisSummary](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Ransomware -Operation InvestigationAnalysisSummary`<BR>or<BR>`New-RscQuery -GqlQuery ransomwareInvestigationAnalysisSummary` |
| InvestigationEnablement | [ransomwareInvestigationEnablement](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Ransomware -Operation InvestigationEnablement`<BR>or<BR>`New-RscQuery -GqlQuery ransomwareInvestigationEnablement` |
| InvestigationWorkloadScannedCount | [ransomwareInvestigationWorkloadScannedCount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Ransomware -Operation InvestigationWorkloadScannedCount`<BR>or<BR>`New-RscQuery -GqlQuery ransomwareInvestigationWorkloadScannedCount` |
| OverallInvestigationSummary | [overallRansomwareInvestigationSummary](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Ransomware -Operation OverallInvestigationSummary`<BR>or<BR>`New-RscQuery -GqlQuery overallRansomwareInvestigationSummary` |
| PendingInvestigationResultsCount | [pendingRansomwareInvestigationResultsCount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Ransomware -Operation PendingInvestigationResultsCount`<BR>or<BR>`New-RscQuery -GqlQuery pendingRansomwareInvestigationResultsCount` |
| ProcessedInvestigationWorkloadCount | [processedRansomwareInvestigationWorkloadCount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Ransomware -Operation ProcessedInvestigationWorkloadCount`<BR>or<BR>`New-RscQuery -GqlQuery processedRansomwareInvestigationWorkloadCount` |
| ProtectedInvestigationWorkloadCount | [protectedRansomwareInvestigationWorkloadCount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Ransomware -Operation ProtectedInvestigationWorkloadCount`<BR>or<BR>`New-RscQuery -GqlQuery protectedRansomwareInvestigationWorkloadCount` |
| Result | [ransomwareResult](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Ransomware -Operation Result`<BR>or<BR>`New-RscQuery -GqlQuery ransomwareResult` |
| ResultOpt | [ransomwareResultOpt](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Ransomware -Operation ResultOpt`<BR>or<BR>`New-RscQuery -GqlQuery ransomwareResultOpt` |
| Results | [ransomwareResults](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Ransomware -Operation Results`<BR>or<BR>`New-RscQuery -GqlQuery ransomwareResults` |
| ResultsGrouped | [ransomwareResultsGrouped](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Ransomware -Operation ResultsGrouped`<BR>or<BR>`New-RscQuery -GqlQuery ransomwareResultsGrouped` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| TriggerDetection | [triggerRansomwareDetection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Ransomware -Operation TriggerDetection`<BR>or<BR>`New-RscMutation -GqlMutation triggerRansomwareDetection` |

[Go to top](#)
## RCS domain

Domain key: Rcs , e.g. '`-Domain Rcs`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| ArchivalLocationsConsumptionStats | [rcsArchivalLocationsConsumptionStats](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Rcs -Operation ArchivalLocationsConsumptionStats`<BR>or<BR>`New-RscQuery -GqlQuery rcsArchivalLocationsConsumptionStats` |
| Cluster | [clusterCsr](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Rcs -Operation Cluster`<BR>or<BR>`New-RscQuery -GqlQuery clusterCsr` |
| Dhcores | [allDhrcScores](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Rcs -Operation Dhcores`<BR>or<BR>`New-RscQuery -GqlQuery allDhrcScores` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| CreateAutomaticTargetMapping | [createAutomaticRcsTargetMapping](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Rcs -Operation CreateAutomaticTargetMapping`<BR>or<BR>`New-RscMutation -GqlMutation createAutomaticRcsTargetMapping` |
| CreateReaderTarget | [createRcsReaderTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Rcs -Operation CreateReaderTarget`<BR>or<BR>`New-RscMutation -GqlMutation createRcsReaderTarget` |
| CreateTarget | [createRcsTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Rcs -Operation CreateTarget`<BR>or<BR>`New-RscMutation -GqlMutation createRcsTarget` |
| UpdateAutomaticTargetMapping | [updateRcsAutomaticTargetMapping](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Rcs -Operation UpdateAutomaticTargetMapping`<BR>or<BR>`New-RscMutation -GqlMutation updateRcsAutomaticTargetMapping` |

[Go to top](#)
## RCV domain

Domain key: Rcv , e.g. '`-Domain Rcv`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| AccountEntitlement | [rcvAccountEntitlement](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Rcv -Operation AccountEntitlement`<BR>or<BR>`New-RscQuery -GqlQuery rcvAccountEntitlement` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| CreateLocationsFromTemplate | [createRcvLocationsFromTemplate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Rcv -Operation CreateLocationsFromTemplate`<BR>or<BR>`New-RscMutation -GqlMutation createRcvLocationsFromTemplate` |
| CreatePrivateEndpointApprovalRequest | [createRcvPrivateEndpointApprovalRequest](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Rcv -Operation CreatePrivateEndpointApprovalRequest`<BR>or<BR>`New-RscMutation -GqlMutation createRcvPrivateEndpointApprovalRequest` |
| UpdateTarget | [updateRcvTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Rcv -Operation UpdateTarget`<BR>or<BR>`New-RscMutation -GqlMutation updateRcvTarget` |

[Go to top](#)
## Replication domain

Domain key: Replication , e.g. '`-Domain Replication`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| IncomingStats | [replicationIncomingStats](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Replication -Operation IncomingStats`<BR>or<BR>`New-RscQuery -GqlQuery replicationIncomingStats` |
| OutgoingStats | [replicationOutgoingStats](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Replication -Operation OutgoingStats`<BR>or<BR>`New-RscQuery -GqlQuery replicationOutgoingStats` |
| Pairs | [replicationPairs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Replication -Operation Pairs`<BR>or<BR>`New-RscQuery -GqlQuery replicationPairs` |
| ValidTargets | [allValidReplicationTargets](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Replication -Operation ValidTargets`<BR>or<BR>`New-RscQuery -GqlQuery allValidReplicationTargets` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| CreatePair | [createReplicationPair](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Replication -Operation CreatePair`<BR>or<BR>`New-RscMutation -GqlMutation createReplicationPair` |
| DeletePair | [deleteReplicationPair](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Replication -Operation DeletePair`<BR>or<BR>`New-RscMutation -GqlMutation deleteReplicationPair` |
| DisablePause | [disableReplicationPause](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Replication -Operation DisablePause`<BR>or<BR>`New-RscMutation -GqlMutation disableReplicationPause` |
| EnablePause | [enableReplicationPause](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Replication -Operation EnablePause`<BR>or<BR>`New-RscMutation -GqlMutation enableReplicationPause` |
| UpdateTarget | [updateReplicationTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Replication -Operation UpdateTarget`<BR>or<BR>`New-RscMutation -GqlMutation updateReplicationTarget` |

[Go to top](#)
## Report domain

Domain key: Report , e.g. '`-Domain Report`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| Data | [reportData](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Report -Operation Data`<BR>or<BR>`New-RscQuery -GqlQuery reportData` |
| Scheduled | [scheduledReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Report -Operation Scheduled`<BR>or<BR>`New-RscQuery -GqlQuery scheduledReport` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| CreateCustom | [createCustomReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Report -Operation CreateCustom`<BR>or<BR>`New-RscMutation -GqlMutation createCustomReport` |
| CreateScheduled | [createScheduledReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Report -Operation CreateScheduled`<BR>or<BR>`New-RscMutation -GqlMutation createScheduledReport` |
| DeleteCustom | [deleteCustomReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Report -Operation DeleteCustom`<BR>or<BR>`New-RscMutation -GqlMutation deleteCustomReport` |
| DeleteScheduled | [deleteScheduledReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Report -Operation DeleteScheduled`<BR>or<BR>`New-RscMutation -GqlMutation deleteScheduledReport` |
| SendPdf | [sendPdfReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Report -Operation SendPdf`<BR>or<BR>`New-RscMutation -GqlMutation sendPdfReport` |
| SendScheduledAsync | [sendScheduledReportAsync](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Report -Operation SendScheduledAsync`<BR>or<BR>`New-RscMutation -GqlMutation sendScheduledReportAsync` |
| StartClusterMigrationJob | [startClusterReportMigrationJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Report -Operation StartClusterMigrationJob`<BR>or<BR>`New-RscMutation -GqlMutation startClusterReportMigrationJob` |
| UpdateCustom | [updateCustomReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Report -Operation UpdateCustom`<BR>or<BR>`New-RscMutation -GqlMutation updateCustomReport` |
| UpdateScheduled | [updateScheduledReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Report -Operation UpdateScheduled`<BR>or<BR>`New-RscMutation -GqlMutation updateScheduledReport` |

[Go to top](#)
## SAP HANA domain

Domain key: Saphana , e.g. '`-Domain Saphana`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| Database | [sapHanaDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Saphana -Operation Database`<BR>or<BR>`New-RscQuery -GqlQuery sapHanaDatabase` |
| Databases | [sapHanaDatabases](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Saphana -Operation Databases`<BR>or<BR>`New-RscQuery -GqlQuery sapHanaDatabases` |
| LogSnapshot | [sapHanaLogSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Saphana -Operation LogSnapshot`<BR>or<BR>`New-RscQuery -GqlQuery sapHanaLogSnapshot` |
| LogSnapshots | [sapHanaLogSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Saphana -Operation LogSnapshots`<BR>or<BR>`New-RscQuery -GqlQuery sapHanaLogSnapshots` |
| RecoverableRange | [sapHanaRecoverableRange](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Saphana -Operation RecoverableRange`<BR>or<BR>`New-RscQuery -GqlQuery sapHanaRecoverableRange` |
| RecoverableRanges | [sapHanaRecoverableRanges](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Saphana -Operation RecoverableRanges`<BR>or<BR>`New-RscQuery -GqlQuery sapHanaRecoverableRanges` |
| System | [sapHanaSystem](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Saphana -Operation System`<BR>or<BR>`New-RscQuery -GqlQuery sapHanaSystem` |
| Systems | [sapHanaSystems](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Saphana -Operation Systems`<BR>or<BR>`New-RscQuery -GqlQuery sapHanaSystems` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| AddSystem | [addSapHanaSystem](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Saphana -Operation AddSystem`<BR>or<BR>`New-RscMutation -GqlMutation addSapHanaSystem` |
| ConfigureRestore | [configureSapHanaRestore](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Saphana -Operation ConfigureRestore`<BR>or<BR>`New-RscMutation -GqlMutation configureSapHanaRestore` |
| CreateOnDemandBackup | [createOnDemandSapHanaBackup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Saphana -Operation CreateOnDemandBackup`<BR>or<BR>`New-RscMutation -GqlMutation createOnDemandSapHanaBackup` |
| CreateSystemRefresh | [createSapHanaSystemRefresh](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Saphana -Operation CreateSystemRefresh`<BR>or<BR>`New-RscMutation -GqlMutation createSapHanaSystemRefresh` |
| DeleteDbSnapshot | [deleteSapHanaDbSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Saphana -Operation DeleteDbSnapshot`<BR>or<BR>`New-RscMutation -GqlMutation deleteSapHanaDbSnapshot` |
| DeleteSystem | [deleteSapHanaSystem](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Saphana -Operation DeleteSystem`<BR>or<BR>`New-RscMutation -GqlMutation deleteSapHanaSystem` |
| ExpireDownloadedSnapshots | [expireDownloadedSapHanaSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Saphana -Operation ExpireDownloadedSnapshots`<BR>or<BR>`New-RscMutation -GqlMutation expireDownloadedSapHanaSnapshots` |
| PatchSystem | [patchSapHanaSystem](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Saphana -Operation PatchSystem`<BR>or<BR>`New-RscMutation -GqlMutation patchSapHanaSystem` |
| UnconfigureRestore | [unconfigureSapHanaRestore](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Saphana -Operation UnconfigureRestore`<BR>or<BR>`New-RscMutation -GqlMutation unconfigureSapHanaRestore` |

[Go to top](#)
## Service Account domain

Domain key: ServiceAccount , e.g. '`-Domain ServiceAccount`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| ServiceAccount | [serviceAccounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain ServiceAccount -Operation ServiceAccount`<BR>or<BR>`New-RscQuery -GqlQuery serviceAccounts` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| Create | [createServiceAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain ServiceAccount -Operation Create`<BR>or<BR>`New-RscMutation -GqlMutation createServiceAccount` |
| Delete | [deleteServiceAccountsFromAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain ServiceAccount -Operation Delete`<BR>or<BR>`New-RscMutation -GqlMutation deleteServiceAccountsFromAccount` |
| Rotate | [rotateServiceAccountSecret](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain ServiceAccount -Operation Rotate`<BR>or<BR>`New-RscMutation -GqlMutation rotateServiceAccountSecret` |
| Update | [updateServiceAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain ServiceAccount -Operation Update`<BR>or<BR>`New-RscMutation -GqlMutation updateServiceAccount` |

[Go to top](#)
## Sharepoint domain

Domain key: Sharepoint , e.g. '`-Domain Sharepoint`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| BrowseDrive | [browseSharepointDrive](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Sharepoint -Operation BrowseDrive`<BR>or<BR>`New-RscQuery -GqlQuery browseSharepointDrive` |
| BrowseList | [browseSharepointList](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Sharepoint -Operation BrowseList`<BR>or<BR>`New-RscQuery -GqlQuery browseSharepointList` |
| SiteDescendants | [sharepointSiteDescendants](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Sharepoint -Operation SiteDescendants`<BR>or<BR>`New-RscQuery -GqlQuery sharepointSiteDescendants` |
| SiteExclusions | [allSharepointSiteExclusions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Sharepoint -Operation SiteExclusions`<BR>or<BR>`New-RscQuery -GqlQuery allSharepointSiteExclusions` |
| SiteSearch | [sharepointSiteSearch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Sharepoint -Operation SiteSearch`<BR>or<BR>`New-RscQuery -GqlQuery sharepointSiteSearch` |
| SnappableDriveSearch | [snappableSharepointDriveSearch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Sharepoint -Operation SnappableDriveSearch`<BR>or<BR>`New-RscQuery -GqlQuery snappableSharepointDriveSearch` |
| SnappableListSearch | [snappableSharepointListSearch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Sharepoint -Operation SnappableListSearch`<BR>or<BR>`New-RscQuery -GqlQuery snappableSharepointListSearch` |
| SnapshotDriveSearch | [snapshotSharepointDriveSearch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Sharepoint -Operation SnapshotDriveSearch`<BR>or<BR>`New-RscQuery -GqlQuery snapshotSharepointDriveSearch` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| ExcludeObjectsFromProtection | [excludeSharepointObjectsFromProtection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Sharepoint -Operation ExcludeObjectsFromProtection`<BR>or<BR>`New-RscMutation -GqlMutation excludeSharepointObjectsFromProtection` |

[Go to top](#)
## SLA domain

Domain key: Sla , e.g. '`-Domain Sla`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| AuditDetail | [slaAuditDetail](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Sla -Operation AuditDetail`<BR>or<BR>`New-RscQuery -GqlQuery slaAuditDetail` |
| ClusterDomains | [clusterSlaDomains](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Sla -Operation ClusterDomains`<BR>or<BR>`New-RscQuery -GqlQuery clusterSlaDomains` |
| ClusterGlobals | [allClusterGlobalSlas](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Sla -Operation ClusterGlobals`<BR>or<BR>`New-RscQuery -GqlQuery allClusterGlobalSlas` |
| ConflictObjects | [slaConflictObjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Sla -Operation ConflictObjects`<BR>or<BR>`New-RscQuery -GqlQuery slaConflictObjects` |
| CountOfObjectsProtected | [countOfObjectsProtectedBySlas](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Sla -Operation CountOfObjectsProtected`<BR>or<BR>`New-RscQuery -GqlQuery countOfObjectsProtectedBySlas` |
| Domain | [slaDomain](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Sla -Operation Domain`<BR>or<BR>`New-RscQuery -GqlQuery slaDomain` |
| Domains | [slaDomains](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Sla -Operation Domains`<BR>or<BR>`New-RscQuery -GqlQuery slaDomains` |
| GlobalFilterList | [globalSlaFilterConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Sla -Operation GlobalFilterList`<BR>or<BR>`New-RscQuery -GqlQuery globalSlaFilterConnection` |
| GlobalStatuses | [globalSlaStatuses](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Sla -Operation GlobalStatuses`<BR>or<BR>`New-RscQuery -GqlQuery globalSlaStatuses` |
| ManagedVolume | [slaManagedVolume](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Sla -Operation ManagedVolume`<BR>or<BR>`New-RscQuery -GqlQuery slaManagedVolume` |
| ManagedVolumes | [slaManagedVolumes](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Sla -Operation ManagedVolumes`<BR>or<BR>`New-RscQuery -GqlQuery slaManagedVolumes` |
| NcdComplianceData | [allNcdSlaComplianceData](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Sla -Operation NcdComplianceData`<BR>or<BR>`New-RscQuery -GqlQuery allNcdSlaComplianceData` |
| SummariesByIds | [allSlaSummariesByIds](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Sla -Operation SummariesByIds`<BR>or<BR>`New-RscQuery -GqlQuery allSlaSummariesByIds` |
| VerifyWithReplicationToCluster | [verifySlaWithReplicationToCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Sla -Operation VerifyWithReplicationToCluster`<BR>or<BR>`New-RscQuery -GqlQuery verifySlaWithReplicationToCluster` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| Assign | [assignSla](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Sla -Operation Assign`<BR>or<BR>`New-RscMutation -GqlMutation assignSla` |
| AssignRetentionToSnappables | [assignRetentionSLAToSnappables](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Sla -Operation AssignRetentionToSnappables`<BR>or<BR>`New-RscMutation -GqlMutation assignRetentionSLAToSnappables` |
| AssignRetentionToSnapshots | [assignRetentionSLAToSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Sla -Operation AssignRetentionToSnapshots`<BR>or<BR>`New-RscMutation -GqlMutation assignRetentionSLAToSnapshots` |
| AssignsForSnappableHierarchies | [assignSlasForSnappableHierarchies](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Sla -Operation AssignsForSnappableHierarchies`<BR>or<BR>`New-RscMutation -GqlMutation assignSlasForSnappableHierarchies` |
| CreateGlobal | [createGlobalSla](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Sla -Operation CreateGlobal`<BR>or<BR>`New-RscMutation -GqlMutation createGlobalSla` |
| ExportManagedVolumeSnapshot | [exportSlaManagedVolumeSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Sla -Operation ExportManagedVolumeSnapshot`<BR>or<BR>`New-RscMutation -GqlMutation exportSlaManagedVolumeSnapshot` |
| GetPendingAssignments | [getPendingSlaAssignments](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Sla -Operation GetPendingAssignments`<BR>or<BR>`New-RscMutation -GqlMutation getPendingSlaAssignments` |
| Pause | [pauseSla](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Sla -Operation Pause`<BR>or<BR>`New-RscMutation -GqlMutation pauseSla` |
| UpdateGlobal | [updateGlobalSla](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Sla -Operation UpdateGlobal`<BR>or<BR>`New-RscMutation -GqlMutation updateGlobalSla` |

[Go to top](#)
## SMB domain

Domain key: Smb , e.g. '`-Domain Smb`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| Configuration | [smbConfiguration](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Smb -Operation Configuration`<BR>or<BR>`New-RscQuery -GqlQuery smbConfiguration` |
| Domains | [smbDomains](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Smb -Operation Domains`<BR>or<BR>`New-RscQuery -GqlQuery smbDomains` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| AddAndJoinDomain | [addAndJoinSmbDomain](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Smb -Operation AddAndJoinDomain`<BR>or<BR>`New-RscMutation -GqlMutation addAndJoinSmbDomain` |
| DeleteDomain | [deleteSmbDomain](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Smb -Operation DeleteDomain`<BR>or<BR>`New-RscMutation -GqlMutation deleteSmbDomain` |
| JoinDomain | [joinSmbDomain](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Smb -Operation JoinDomain`<BR>or<BR>`New-RscMutation -GqlMutation joinSmbDomain` |
| PutConfiguration | [putSmbConfiguration](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Smb -Operation PutConfiguration`<BR>or<BR>`New-RscMutation -GqlMutation putSmbConfiguration` |

[Go to top](#)
## Snapshot domain

Domain key: Snapshot , e.g. '`-Domain Snapshot`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| BrowseFileList | [browseSnapshotFileConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Snapshot -Operation BrowseFileList`<BR>or<BR>`New-RscQuery -GqlQuery browseSnapshotFileConnection` |
| EmailSearch | [snapshotEmailSearch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Snapshot -Operation EmailSearch`<BR>or<BR>`New-RscQuery -GqlQuery snapshotEmailSearch` |
| EventSearch | [snapshotEventSearch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Snapshot -Operation EventSearch`<BR>or<BR>`New-RscQuery -GqlQuery snapshotEventSearch` |
| FilesDelta | [snapshotFilesDelta](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Snapshot -Operation FilesDelta`<BR>or<BR>`New-RscQuery -GqlQuery snapshotFilesDelta` |
| FilesDeltaV2 | [snapshotFilesDeltaV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Snapshot -Operation FilesDeltaV2`<BR>or<BR>`New-RscQuery -GqlQuery snapshotFilesDeltaV2` |
| Fileset | [filesetSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Snapshot -Operation Fileset`<BR>or<BR>`New-RscQuery -GqlQuery filesetSnapshot` |
| FilesetFiles | [filesetSnapshotFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Snapshot -Operation FilesetFiles`<BR>or<BR>`New-RscQuery -GqlQuery filesetSnapshotFiles` |
| LegalHoldsForSnappable | [legalHoldSnapshotsForSnappable](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Snapshot -Operation LegalHoldsForSnappable`<BR>or<BR>`New-RscQuery -GqlQuery legalHoldSnapshotsForSnappable` |
| OfASnappableList | [snapshotOfASnappableConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Snapshot -Operation OfASnappableList`<BR>or<BR>`New-RscQuery -GqlQuery snapshotOfASnappableConnection` |
| OfSnappablesList | [snapshotOfSnappablesConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Snapshot -Operation OfSnappablesList`<BR>or<BR>`New-RscQuery -GqlQuery snapshotOfSnappablesConnection` |
| OnedriveSearch | [snapshotOnedriveSearch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Snapshot -Operation OnedriveSearch`<BR>or<BR>`New-RscQuery -GqlQuery snapshotOnedriveSearch` |
| Polaris | [polarisSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Snapshot -Operation Polaris`<BR>or<BR>`New-RscQuery -GqlQuery polarisSnapshot` |
| Pvcs | [allSnapshotPvcs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Snapshot -Operation Pvcs`<BR>or<BR>`New-RscQuery -GqlQuery allSnapshotPvcs` |
| QuarantinedDetailsFors | [allQuarantinedDetailsForSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Snapshot -Operation QuarantinedDetailsFors`<BR>or<BR>`New-RscQuery -GqlQuery allQuarantinedDetailsForSnapshots` |
| Results | [snapshotResults](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Snapshot -Operation Results`<BR>or<BR>`New-RscQuery -GqlQuery snapshotResults` |
| SForUnmanagedObject | [snapshotsForUnmanagedObject](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Snapshot -Operation SForUnmanagedObject`<BR>or<BR>`New-RscQuery -GqlQuery snapshotsForUnmanagedObject` |
| SnappablesWithLegalHoldsSummary | [snappablesWithLegalHoldSnapshotsSummary](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Snapshot -Operation SnappablesWithLegalHoldsSummary`<BR>or<BR>`New-RscQuery -GqlQuery snappablesWithLegalHoldSnapshotsSummary` |
| Snapshot | [snapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Snapshot -Operation Snapshot`<BR>or<BR>`New-RscQuery -GqlQuery snapshot` |
| VappInstantRecoveryOptions | [vappSnapshotInstantRecoveryOptions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Snapshot -Operation VappInstantRecoveryOptions`<BR>or<BR>`New-RscQuery -GqlQuery vappSnapshotInstantRecoveryOptions` |
| VappTemplateExportOptions | [vappTemplateSnapshotExportOptions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Snapshot -Operation VappTemplateExportOptions`<BR>or<BR>`New-RscQuery -GqlQuery vappTemplateSnapshotExportOptions` |
| sClosestToPointInTime | [allSnapshotsClosestToPointInTime](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Snapshot -Operation sClosestToPointInTime`<BR>or<BR>`New-RscQuery -GqlQuery allSnapshotsClosestToPointInTime` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| BatchQuarantine | [batchQuarantineSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Snapshot -Operation BatchQuarantine`<BR>or<BR>`New-RscMutation -GqlMutation batchQuarantineSnapshot` |
| BatchReleaseFromQuarantine | [batchReleaseFromQuarantineSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Snapshot -Operation BatchReleaseFromQuarantine`<BR>or<BR>`New-RscMutation -GqlMutation batchReleaseFromQuarantineSnapshot` |
| BulkTierExistings | [bulkTierExistingSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Snapshot -Operation BulkTierExistings`<BR>or<BR>`New-RscMutation -GqlMutation bulkTierExistingSnapshots` |
| CreateDownloadForVolumeGroup | [createDownloadSnapshotForVolumeGroup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Snapshot -Operation CreateDownloadForVolumeGroup`<BR>or<BR>`New-RscMutation -GqlMutation createDownloadSnapshotForVolumeGroup` |
| CreateFileset | [createFilesetSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Snapshot -Operation CreateFileset`<BR>or<BR>`New-RscMutation -GqlMutation createFilesetSnapshot` |
| DeleteCloudWorkload | [deleteCloudWorkloadSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Snapshot -Operation DeleteCloudWorkload`<BR>or<BR>`New-RscMutation -GqlMutation deleteCloudWorkloadSnapshot` |
| DeleteFilesets | [deleteFilesetSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Snapshot -Operation DeleteFilesets`<BR>or<BR>`New-RscMutation -GqlMutation deleteFilesetSnapshots` |
| FilesetDownloadFiles | [filesetDownloadSnapshotFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Snapshot -Operation FilesetDownloadFiles`<BR>or<BR>`New-RscMutation -GqlMutation filesetDownloadSnapshotFiles` |
| FilesetExportFiles | [filesetExportSnapshotFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Snapshot -Operation FilesetExportFiles`<BR>or<BR>`New-RscMutation -GqlMutation filesetExportSnapshotFiles` |
| RestoreVolumeGroupFiles | [restoreVolumeGroupSnapshotFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Snapshot -Operation RestoreVolumeGroupFiles`<BR>or<BR>`New-RscMutation -GqlMutation restoreVolumeGroupSnapshotFiles` |
| StartEc2InstanceExportJob | [startEc2InstanceSnapshotExportJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Snapshot -Operation StartEc2InstanceExportJob`<BR>or<BR>`New-RscMutation -GqlMutation startEc2InstanceSnapshotExportJob` |
| StartRecoverS3Job | [startRecoverS3SnapshotJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Snapshot -Operation StartRecoverS3Job`<BR>or<BR>`New-RscMutation -GqlMutation startRecoverS3SnapshotJob` |
| TakeOnDemand | [takeOnDemandSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Snapshot -Operation TakeOnDemand`<BR>or<BR>`New-RscMutation -GqlMutation takeOnDemandSnapshot` |
| UploadDatabaseToBlobstore | [uploadDatabaseSnapshotToBlobstore](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Snapshot -Operation UploadDatabaseToBlobstore`<BR>or<BR>`New-RscMutation -GqlMutation uploadDatabaseSnapshotToBlobstore` |
| VmwareDownloadFromLocation | [vmwareDownloadSnapshotFromLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Snapshot -Operation VmwareDownloadFromLocation`<BR>or<BR>`New-RscMutation -GqlMutation vmwareDownloadSnapshotFromLocation` |

[Go to top](#)
## Sonar domain

Domain key: Sonar , e.g. '`-Domain Sonar`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| ContentReport | [sonarContentReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Sonar -Operation ContentReport`<BR>or<BR>`New-RscQuery -GqlQuery sonarContentReport` |
| Report | [sonarReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Sonar -Operation Report`<BR>or<BR>`New-RscQuery -GqlQuery sonarReport` |
| ReportRow | [sonarReportRow](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Sonar -Operation ReportRow`<BR>or<BR>`New-RscQuery -GqlQuery sonarReportRow` |
| UserGroups | [sonarUserGroups](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Sonar -Operation UserGroups`<BR>or<BR>`New-RscQuery -GqlQuery sonarUserGroups` |
| Users | [sonarUsers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Sonar -Operation Users`<BR>or<BR>`New-RscQuery -GqlQuery sonarUsers` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |

[Go to top](#)
## Storage Arrays domain

Domain key: Storagearray , e.g. '`-Domain Storagearray`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| Storagearray | [allStorageArrays](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Storagearray -Operation Storagearray`<BR>or<BR>`New-RscQuery -GqlQuery allStorageArrays` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| Add | [addStorageArrays](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Storagearray -Operation Add`<BR>or<BR>`New-RscMutation -GqlMutation addStorageArrays` |
| Delete | [deleteStorageArrays](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Storagearray -Operation Delete`<BR>or<BR>`New-RscMutation -GqlMutation deleteStorageArrays` |
| Refresh | [refreshStorageArrays](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Storagearray -Operation Refresh`<BR>or<BR>`New-RscMutation -GqlMutation refreshStorageArrays` |
| Update | [updateStorageArrays](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Storagearray -Operation Update`<BR>or<BR>`New-RscMutation -GqlMutation updateStorageArrays` |

[Go to top](#)
## Tape domain

Domain key: Tape , e.g. '`-Domain Tape`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| CreateReaderTarget | [createTapeReaderTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Tape -Operation CreateReaderTarget`<BR>or<BR>`New-RscMutation -GqlMutation createTapeReaderTarget` |
| CreateTarget | [createTapeTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Tape -Operation CreateTarget`<BR>or<BR>`New-RscMutation -GqlMutation createTapeTarget` |
| UpdateTarget | [updateTapeTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Tape -Operation UpdateTarget`<BR>or<BR>`New-RscMutation -GqlMutation updateTapeTarget` |

[Go to top](#)
## Threat domain

Domain key: Threat , e.g. '`-Domain Threat`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| HuntDetail | [threatHuntDetail](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Threat -Operation HuntDetail`<BR>or<BR>`New-RscQuery -GqlQuery threatHuntDetail` |
| HuntResult | [threatHuntResult](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Threat -Operation HuntResult`<BR>or<BR>`New-RscQuery -GqlQuery threatHuntResult` |
| HuntSummary | [threatHuntSummary](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Threat -Operation HuntSummary`<BR>or<BR>`New-RscQuery -GqlQuery threatHuntSummary` |
| Hunts | [threatHunts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Threat -Operation Hunts`<BR>or<BR>`New-RscQuery -GqlQuery threatHunts` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| CancelHunt | [cancelThreatHunt](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Threat -Operation CancelHunt`<BR>or<BR>`New-RscMutation -GqlMutation cancelThreatHunt` |
| EnableMonitoring | [enableThreatMonitoring](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Threat -Operation EnableMonitoring`<BR>or<BR>`New-RscMutation -GqlMutation enableThreatMonitoring` |
| StartHunt | [startThreatHunt](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Threat -Operation StartHunt`<BR>or<BR>`New-RscMutation -GqlMutation startThreatHunt` |

[Go to top](#)
## vSphere vCenter domain

Domain key: Vcenter , e.g. '`-Domain Vcenter`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| AdvancedTagPreview | [vCenterAdvancedTagPreview](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Vcenter -Operation AdvancedTagPreview`<BR>or<BR>`New-RscQuery -GqlQuery vCenterAdvancedTagPreview` |
| HotAddBandwidth | [vCenterHotAddBandwidth](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Vcenter -Operation HotAddBandwidth`<BR>or<BR>`New-RscQuery -GqlQuery vCenterHotAddBandwidth` |
| HotAddNetwork | [vCenterHotAddNetwork](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Vcenter -Operation HotAddNetwork`<BR>or<BR>`New-RscQuery -GqlQuery vCenterHotAddNetwork` |
| HotAddProxy | [allVcenterHotAddProxyVms](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Vcenter -Operation HotAddProxy`<BR>or<BR>`New-RscQuery -GqlQuery allVcenterHotAddProxyVms` |
| List | [vSphereVCenterConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Vcenter -Operation List`<BR>or<BR>`New-RscQuery -GqlQuery vSphereVCenterConnection` |
| Networks | [vCenterNetworks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Vcenter -Operation Networks`<BR>or<BR>`New-RscQuery -GqlQuery vCenterNetworks` |
| NumProxiesNeeded | [vCenterNumProxiesNeeded](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Vcenter -Operation NumProxiesNeeded`<BR>or<BR>`New-RscQuery -GqlQuery vCenterNumProxiesNeeded` |
| PreAddInfo | [vCenterPreAddInfo](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Vcenter -Operation PreAddInfo`<BR>or<BR>`New-RscQuery -GqlQuery vCenterPreAddInfo` |
| Vcenter | [vSphereVCenter](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Vcenter -Operation Vcenter`<BR>or<BR>`New-RscQuery -GqlQuery vSphereVCenter` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| Create | [createVsphereVcenter](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Vcenter -Operation Create`<BR>or<BR>`New-RscMutation -GqlMutation createVsphereVcenter` |
| Delete | [vsphereDeleteVcenter](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Vcenter -Operation Delete`<BR>or<BR>`New-RscMutation -GqlMutation vsphereDeleteVcenter` |
| Refresh | [refreshVsphereVcenter](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Vcenter -Operation Refresh`<BR>or<BR>`New-RscMutation -GqlMutation refreshVsphereVcenter` |
| Update | [updateVcenter](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Vcenter -Operation Update`<BR>or<BR>`New-RscMutation -GqlMutation updateVcenter` |
| UpdateHotAddBandwidth | [updateVcenterHotAddBandwidth](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Vcenter -Operation UpdateHotAddBandwidth`<BR>or<BR>`New-RscMutation -GqlMutation updateVcenterHotAddBandwidth` |
| UpdateHotAddNetwork | [updateVcenterHotAddNetwork](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Vcenter -Operation UpdateHotAddNetwork`<BR>or<BR>`New-RscMutation -GqlMutation updateVcenterHotAddNetwork` |

[Go to top](#)
## vSphere domain

Domain key: Vsphere , e.g. '`-Domain Vsphere`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| ComputeCluster | [vSphereComputeCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Vsphere -Operation ComputeCluster`<BR>or<BR>`New-RscQuery -GqlQuery vSphereComputeCluster` |
| ComputeClusters | [vSphereComputeClusters](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Vsphere -Operation ComputeClusters`<BR>or<BR>`New-RscQuery -GqlQuery vSphereComputeClusters` |
| Datacenter | [vSphereDatacenter](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Vsphere -Operation Datacenter`<BR>or<BR>`New-RscQuery -GqlQuery vSphereDatacenter` |
| Datastore | [vSphereDatastore](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Vsphere -Operation Datastore`<BR>or<BR>`New-RscQuery -GqlQuery vSphereDatastore` |
| DatastoreCluster | [vSphereDatastoreCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Vsphere -Operation DatastoreCluster`<BR>or<BR>`New-RscQuery -GqlQuery vSphereDatastoreCluster` |
| DatastoreClusters | [vSphereDatastoreClusters](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Vsphere -Operation DatastoreClusters`<BR>or<BR>`New-RscQuery -GqlQuery vSphereDatastoreClusters` |
| DatastoreList | [vSphereDatastoreConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Vsphere -Operation DatastoreList`<BR>or<BR>`New-RscQuery -GqlQuery vSphereDatastoreConnection` |
| Folder | [vSphereFolder](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Vsphere -Operation Folder`<BR>or<BR>`New-RscQuery -GqlQuery vSphereFolder` |
| Folders | [vSphereFolders](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Vsphere -Operation Folders`<BR>or<BR>`New-RscQuery -GqlQuery vSphereFolders` |
| Host | [vSphereHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Vsphere -Operation Host`<BR>or<BR>`New-RscQuery -GqlQuery vSphereHost` |
| HostDetails | [vSphereHostDetails](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Vsphere -Operation HostDetails`<BR>or<BR>`New-RscQuery -GqlQuery vSphereHostDetails` |
| HostList | [vSphereHostConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Vsphere -Operation HostList`<BR>or<BR>`New-RscQuery -GqlQuery vSphereHostConnection` |
| HostsByFids | [vSphereHostsByFids](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Vsphere -Operation HostsByFids`<BR>or<BR>`New-RscQuery -GqlQuery vSphereHostsByFids` |
| LiveMounts | [vSphereLiveMounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Vsphere -Operation LiveMounts`<BR>or<BR>`New-RscQuery -GqlQuery vSphereLiveMounts` |
| Mount | [vSphereMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Vsphere -Operation Mount`<BR>or<BR>`New-RscQuery -GqlQuery vSphereMount` |
| MountList | [vSphereMountConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Vsphere -Operation MountList`<BR>or<BR>`New-RscQuery -GqlQuery vSphereMountConnection` |
| Network | [vSphereNetwork](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Vsphere -Operation Network`<BR>or<BR>`New-RscQuery -GqlQuery vSphereNetwork` |
| ResourcePool | [vSphereResourcePool](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Vsphere -Operation ResourcePool`<BR>or<BR>`New-RscQuery -GqlQuery vSphereResourcePool` |
| RootRecoveryHierarchy | [vSphereRootRecoveryHierarchy](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Vsphere -Operation RootRecoveryHierarchy`<BR>or<BR>`New-RscQuery -GqlQuery vSphereRootRecoveryHierarchy` |
| Tag | [vSphereTag](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Vsphere -Operation Tag`<BR>or<BR>`New-RscQuery -GqlQuery vSphereTag` |
| TagCategory | [vSphereTagCategory](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Vsphere -Operation TagCategory`<BR>or<BR>`New-RscQuery -GqlQuery vSphereTagCategory` |
| TopLevelDescendantsList | [vSphereTopLevelDescendantsConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Vsphere -Operation TopLevelDescendantsList`<BR>or<BR>`New-RscQuery -GqlQuery vSphereTopLevelDescendantsConnection` |
| VmwareCdpLiveInfo | [vsphereVmwareCdpLiveInfo](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Vsphere -Operation VmwareCdpLiveInfo`<BR>or<BR>`New-RscQuery -GqlQuery vsphereVmwareCdpLiveInfo` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| BulkOnDemandSnapshot | [vsphereBulkOnDemandSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Vsphere -Operation BulkOnDemandSnapshot`<BR>or<BR>`New-RscMutation -GqlMutation vsphereBulkOnDemandSnapshot` |
| CreateAdvancedTag | [createVsphereAdvancedTag](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Vsphere -Operation CreateAdvancedTag`<BR>or<BR>`New-RscMutation -GqlMutation createVsphereAdvancedTag` |
| DeleteAdvancedTag | [deleteVsphereAdvancedTag](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Vsphere -Operation DeleteAdvancedTag`<BR>or<BR>`New-RscMutation -GqlMutation deleteVsphereAdvancedTag` |
| DeleteLiveMount | [deleteVsphereLiveMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Vsphere -Operation DeleteLiveMount`<BR>or<BR>`New-RscMutation -GqlMutation deleteVsphereLiveMount` |
| DownloadVirtualMachineFiles | [downloadVsphereVirtualMachineFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Vsphere -Operation DownloadVirtualMachineFiles`<BR>or<BR>`New-RscMutation -GqlMutation downloadVsphereVirtualMachineFiles` |
| ExportSnapshotToStandaloneHostV2 | [vsphereExportSnapshotToStandaloneHostV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Vsphere -Operation ExportSnapshotToStandaloneHostV2`<BR>or<BR>`New-RscMutation -GqlMutation vsphereExportSnapshotToStandaloneHostV2` |
| OnDemandSnapshot | [vsphereOnDemandSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Vsphere -Operation OnDemandSnapshot`<BR>or<BR>`New-RscMutation -GqlMutation vsphereOnDemandSnapshot` |
| UpdateAdvancedTag | [updateVsphereAdvancedTag](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Vsphere -Operation UpdateAdvancedTag`<BR>or<BR>`New-RscMutation -GqlMutation updateVsphereAdvancedTag` |

[Go to top](#)
## vSphere VM domain

Domain key: VsphereVm , e.g. '`-Domain VsphereVm`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| AsyncRequestStatus | [vSphereVMAsyncRequestStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain VsphereVm -Operation AsyncRequestStatus`<BR>or<BR>`New-RscQuery -GqlQuery vSphereVMAsyncRequestStatus` |
| MissedRecoverableRange | [vsphereVMMissedRecoverableRange](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain VsphereVm -Operation MissedRecoverableRange`<BR>or<BR>`New-RscQuery -GqlQuery vsphereVMMissedRecoverableRange` |
| New | [vSphereVmNew](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain VsphereVm -Operation New`<BR>or<BR>`New-RscQuery -GqlQuery vSphereVmNew` |
| NewList | [vSphereVmNewConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain VsphereVm -Operation NewList`<BR>or<BR>`New-RscQuery -GqlQuery vSphereVmNewConnection` |
| RecoverableRange | [vsphereVMRecoverableRange](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain VsphereVm -Operation RecoverableRange`<BR>or<BR>`New-RscQuery -GqlQuery vsphereVMRecoverableRange` |
| RecoverableRangeInBatch | [vsphereVMRecoverableRangeInBatch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain VsphereVm -Operation RecoverableRangeInBatch`<BR>or<BR>`New-RscQuery -GqlQuery vsphereVMRecoverableRangeInBatch` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| BatchExport | [vsphereVmBatchExport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain VsphereVm -Operation BatchExport`<BR>or<BR>`New-RscMutation -GqlMutation vsphereVmBatchExport` |
| BatchExportV3 | [vsphereVmBatchExportV3](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain VsphereVm -Operation BatchExportV3`<BR>or<BR>`New-RscMutation -GqlMutation vsphereVmBatchExportV3` |
| BatchInPlaceRecovery | [vsphereVmBatchInPlaceRecovery](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain VsphereVm -Operation BatchInPlaceRecovery`<BR>or<BR>`New-RscMutation -GqlMutation vsphereVmBatchInPlaceRecovery` |
| DeleteSnapshot | [vsphereVmDeleteSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain VsphereVm -Operation DeleteSnapshot`<BR>or<BR>`New-RscMutation -GqlMutation vsphereVmDeleteSnapshot` |
| DownloadSnapshot | [vsphereVmDownloadSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain VsphereVm -Operation DownloadSnapshot`<BR>or<BR>`New-RscMutation -GqlMutation vsphereVmDownloadSnapshot` |
| DownloadSnapshotFiles | [vsphereVmDownloadSnapshotFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain VsphereVm -Operation DownloadSnapshotFiles`<BR>or<BR>`New-RscMutation -GqlMutation vsphereVmDownloadSnapshotFiles` |
| ExcludeVmDisks | [vsphereExcludeVmDisks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain VsphereVm -Operation ExcludeVmDisks`<BR>or<BR>`New-RscMutation -GqlMutation vsphereExcludeVmDisks` |
| ExportSnapshotV2 | [vsphereVmExportSnapshotV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain VsphereVm -Operation ExportSnapshotV2`<BR>or<BR>`New-RscMutation -GqlMutation vsphereVmExportSnapshotV2` |
| ExportSnapshotV3 | [vsphereVmExportSnapshotV3](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain VsphereVm -Operation ExportSnapshotV3`<BR>or<BR>`New-RscMutation -GqlMutation vsphereVmExportSnapshotV3` |
| ExportSnapshotWithDownloadFromCloud | [vsphereVmExportSnapshotWithDownloadFromCloud](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain VsphereVm -Operation ExportSnapshotWithDownloadFromCloud`<BR>or<BR>`New-RscMutation -GqlMutation vsphereVmExportSnapshotWithDownloadFromCloud` |
| InitiateBatchInstantRecovery | [vsphereVmInitiateBatchInstantRecovery](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain VsphereVm -Operation InitiateBatchInstantRecovery`<BR>or<BR>`New-RscMutation -GqlMutation vsphereVmInitiateBatchInstantRecovery` |
| InitiateBatchLiveMountV2 | [vsphereVmInitiateBatchLiveMountV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain VsphereVm -Operation InitiateBatchLiveMountV2`<BR>or<BR>`New-RscMutation -GqlMutation vsphereVmInitiateBatchLiveMountV2` |
| InitiateDiskMount | [vsphereVmInitiateDiskMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain VsphereVm -Operation InitiateDiskMount`<BR>or<BR>`New-RscMutation -GqlMutation vsphereVmInitiateDiskMount` |
| InitiateInPlaceRecovery | [vsphereVmInitiateInPlaceRecovery](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain VsphereVm -Operation InitiateInPlaceRecovery`<BR>or<BR>`New-RscMutation -GqlMutation vsphereVmInitiateInPlaceRecovery` |
| InitiateInstantRecoveryV2 | [vsphereVmInitiateInstantRecoveryV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain VsphereVm -Operation InitiateInstantRecoveryV2`<BR>or<BR>`New-RscMutation -GqlMutation vsphereVmInitiateInstantRecoveryV2` |
| InitiateLiveMountV2 | [vsphereVmInitiateLiveMountV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain VsphereVm -Operation InitiateLiveMountV2`<BR>or<BR>`New-RscMutation -GqlMutation vsphereVmInitiateLiveMountV2` |
| ListEsxiDatastores | [vsphereVmListEsxiDatastores](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain VsphereVm -Operation ListEsxiDatastores`<BR>or<BR>`New-RscMutation -GqlMutation vsphereVmListEsxiDatastores` |
| MountRelocate | [vsphereVmMountRelocate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain VsphereVm -Operation MountRelocate`<BR>or<BR>`New-RscMutation -GqlMutation vsphereVmMountRelocate` |
| MountRelocateV2 | [vsphereVmMountRelocateV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain VsphereVm -Operation MountRelocateV2`<BR>or<BR>`New-RscMutation -GqlMutation vsphereVmMountRelocateV2` |
| PowerOnOffLiveMount | [vsphereVmPowerOnOffLiveMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain VsphereVm -Operation PowerOnOffLiveMount`<BR>or<BR>`New-RscMutation -GqlMutation vsphereVmPowerOnOffLiveMount` |
| RecoverFiles | [vsphereVmRecoverFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain VsphereVm -Operation RecoverFiles`<BR>or<BR>`New-RscMutation -GqlMutation vsphereVmRecoverFiles` |
| RecoverFilesNew | [vsphereVmRecoverFilesNew](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain VsphereVm -Operation RecoverFilesNew`<BR>or<BR>`New-RscMutation -GqlMutation vsphereVmRecoverFilesNew` |
| RegisterAgent | [vsphereVmRegisterAgent](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain VsphereVm -Operation RegisterAgent`<BR>or<BR>`New-RscMutation -GqlMutation vsphereVmRegisterAgent` |
| Update | [updateVsphereVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain VsphereVm -Operation Update`<BR>or<BR>`New-RscMutation -GqlMutation updateVsphereVm` |

[Go to top](#)
## Webhook domain

Domain key: Webhook , e.g. '`-Domain Webhook`'

### Queries

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| Webhook | [allWebhooks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscQuery -Domain Webhook -Operation Webhook`<BR>or<BR>`New-RscQuery -GqlQuery allWebhooks` |

[Go to top](#)
### Mutations

| Operation | GraphQL Root Field | Invocation |
| --------- | ------------------ | ---------- |
| Create | [createWebhook](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Webhook -Operation Create`<BR>or<BR>`New-RscMutation -GqlMutation createWebhook` |
| Delete | [deleteWebhook](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Webhook -Operation Delete`<BR>or<BR>`New-RscMutation -GqlMutation deleteWebhook` |
| Test | [testWebhook](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Webhook -Operation Test`<BR>or<BR>`New-RscMutation -GqlMutation testWebhook` |
| TestExisting | [testExistingWebhook](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Webhook -Operation TestExisting`<BR>or<BR>`New-RscMutation -GqlMutation testExistingWebhook` |
| Update | [updateWebhook](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) | `New-RscMutation -Domain Webhook -Operation Update`<BR>or<BR>`New-RscMutation -GqlMutation updateWebhook` |

[Go to top](#)

## Unmatched fields

- allInventoryWorkloads
- lambdaSettings
- userSettings
- allDeploymentIpAddresses
- anomalyResultOpt
- anomalyResults
- anomalyResultsGrouped
- nfAnomalyResults
- nfAnomalyResultsGrouped
- allVmRecoveryJobsInfo
- allCdpVmsInfos
- isZrsAvailableForLocation
- taskDetailConnection
- taskDetailGroupByConnection
- tunnelStatus
- cdmVersionCheck
- minimumCdmVersionForFeatureSet
- radarClusterConnection
- discoverNodes
- nodeRemovalCancelPermission
- nodeToReplace
- installedVersionList
- geoLocationList
- getGroupCountByCdmClusterStatus
- getGroupCountByUpgradeJobStatus
- getGroupCountByPrechecksStatus
- getGroupCountByVersionStatus
- supportBundle
- cloudAccount
- allCloudAccounts
- checkCloudComputeConnectivityJobProgress
- networkThrottle
- target
- targetMapping
- allTargetMappings
- allTargets
- targets
- allNosqlStorageLocations
- archivalStorageUsage
- allDhrcActiveRecommendations
- allDhrcLatestMetrics
- allLatestFeaturePermissionsForCloudAccounts
- allCurrentFeaturePermissionsForCloudAccounts
- allCloudAccountExocomputeMappings
- crawls
- crawl
- analyzerGroups
- activeCustomAnalyzers
- customAnalyzer
- analyzerUsages
- allIssuesJobIds
- discoveryTimeline
- issue
- issues
- datagovSecDesc
- dashboardSummary
- objectFiles
- userDetail
- userAnalyzerAccess
- userActivities
- allFileActivities
- allTopRiskPolicySummaries
- allEventDigests
- failoverClusterTopLevelDescendants
- failoverClusterApp
- failoverClusterApps
- tableFilters
- globalFileSearch
- protectedObjectsConnection
- hierarchyObject
- hierarchyObjects
- inventorySubHierarchyRoot
- cdmInventorySubHierarchyRoot
- polarisInventorySubHierarchyRoot
- inventoryRoot
- allUnmanagedObjectsSupportedTypes
- globalSearchResults
- hierarchySnappables
- cdmHierarchySnappableNew
- cdmHierarchySnappablesNew
- searchSnappableVersionedFiles
- allIntegrations
- integration
- diffFmd
- searchFileByPrefix
- workloadAlertSetting
- pipelineHealthForTimeRange
- investigationCsvDownloadLink
- workloadAnomalies
- allQuarantinedDetailsForWorkload
- currentIpAddress
- ipWhitelist
- orgSecurityPolicy
- orgsForPrincipal
- validateOrgName
- currentOrgAuthDomainConfig
- org
- currentOrg
- allOrgsByIds
- orgs
- allObjectsAlreadyAssignedToOrgs
- allAllowedOrgAdminOperations
- userNotifications
- snmpConfigurations
- syslogExportRules
- snappableEmailSearch
- snappableOnedriveSearch
- snappableTeamsDriveSearch
- snappableTeamsConversationsSearch
- snappableEventSearch
- snappableContactSearch
- browseFolder
- browseCalendar
- browseContacts
- browseOnedrive
- browseTeamsDrive
- browseTeamsChannels
- getKorgTaskchainStatus
- phoenixRolloutProgress
- areMultiGeoBackupsEnabled
- teamChannelNameAvailable
- decryptExportUrl
- maxProtectedAppsCount
- configuredGroupMembers
- allPendingActions
- pendingAction
- deploymentVersion
- externalDeploymentName
- userGroups
- getRolesByIds
- getAllRolesInOrgConnection
- roleTemplates
- getPermissions
- allEffectiveRbacPermissions
- allAuthorizationsForGlobalResource
- allAuthorizationsForObject
- allAuthorizationsForObjects
- dummyFieldWithAdminOnlyTag
- allCurrentOrgIdentityProviders
- hasIdpConfigured
- federatedLoginStatus
- helpContentSnippets
- productDocumentation
- knowledgeBaseArticle
- snappableGroupByConnection
- snappableConnection
- searchSnappableConnection
- unmanagedObjects
- currentUserLoginContext
- currentUser
- allUsersOnAccountConnection
- usersInCurrentAndDescendantOrganization
- groupsInCurrentAndDescendantOrganization
- getUserDownloads
- totpConfigStatus
- mfaSetting
- globalMfaSetting
- allLicensedProducts
- licensesForClusterProductSummary
- validateClusterLicenseCapacity
- lockoutConfig
- globalLockoutConfig
- oauthCodesForEdgeReg
- userSessionManagementConfig
- passwordComplexityPolicy
- userAuditConnection
- uniqueVcdCount
- volumeGroupMounts
- isVMwareManagementEnabled
- guestCredentials
- guestCredentialsV2
- allCdmGuestCredentials
- allVirtualMachineFiles
- computeClusterStatus
- queryDatastoreFreespaceThresholds
- vcdVappVms
- allVmwareCdpStateInfos
- upgradeStatus
- prechecksStatus
- prechecksStatusWithNextJobInfo
- isLoggedIntoRubrikSupportPortal
- getCdmReleaseDetailsForClusterFromSupportPortal
- getCdmReleaseDetailsForVersionFromSupportPortal
- getCdmReleaseDetailsFromSupportPortal
- isUpgradeAvailable
- isUpgradeRecommended
- isSfdcReachable
- isTotpMandatoryInTargetVersion
- allCdmOvaDetails
- edgeWindowsToolLink
- allCloudDirectSites
- cloudDirectSystems
- allCloudDirectShares
- ncdFrontEndCapacity
- ncdBackEndCapacity
- ncdObjectProtectionStatus
- allNcdUsageOverTimeData
- allNcdObjectsOverTimeData
- allNcdTaskData
- supportUserAccesses
- cloudDirectNasExport
- addInventoryWorkloads
- removeInventoryWorkloads
- updateLambdaSettings
- notificationForGetLicense
- startExportRdsInstanceJob
- assignProtection
- generateCsr
- deleteCsr
- addVmAppConsistentSpecs
- enableDisableAppConsistency
- mountDisk
- unmountDisk
- removeCloudClusterNodes
- updateTunnelStatus
- updateClusterDefaultAddress
- refreshGlobalManagerConnectivityStatus
- updateBadDiskLedStatus
- updateHealthMonitorPolicyStatus
- getHealthMonitorPolicyStatus
- resizeDisk
- updateClusterLocation
- updateClusterNtpServers
- addVlan
- removeVlans
- updateDnsServersAndSearchDomains
- updateFloatingIps
- updateProxyConfig
- removeProxyConfig
- setupDisk
- removeDisk
- addClusterNodes
- removeClusterNodes
- replaceClusterNode
- removeNodeForReplacement
- updateClusterSettings
- modifyIpmi
- generateSupportBundle
- generateConfigProtectionRestoreForm
- createManualTargetMapping
- updateManualTargetMapping
- triggerCloudComputeConnectivityCheck
- deleteTargetMapping
- createS3CompatibleTarget
- updateS3CompatibleTarget
- updateGlacierTarget
- createGlacierReaderTarget
- createS3CompatibleReaderTarget
- deleteTarget
- pauseTarget
- resumeTarget
- disableTarget
- enableTarget
- upgradeCdmManagedTarget
- refreshReaderTarget
- promoteReaderTarget
- updateNetworkThrottle
- removePrivateEndpointConnection
- listCidrsForComputeSetting
- mapCloudAccountExocomputeAccount
- unmapCloudAccountExocomputeAccount
- triggerExocomputeHealthCheck
- setCustomerTags
- startCrawl
- archiveCrawl
- createCustomAnalyzer
- deactivateCustomAnalyzer
- runCustomAnalyzer
- updateCustomAnalyzer
- setAnalyzerRisks
- createPolicy
- updatePolicy
- deactivatePolicy
- addPolicyObjects
- removePolicyObjects
- updateWhitelistedAnalyzers
- updatePreviewerClusterConfig
- updateAutoEnablePolicyClusterConfig
- updateEventDigest
- deleteEventDigest
- deleteFailoverClusterApp
- bulkDeleteFailoverClusterApp
- createFailoverClusterApp
- updateFailoverClusterApp
- bulkCreateNasFilesets
- stopJobInstance
- stopJobInstanceFromEventSeries
- retryBackup
- createIntegration
- createIntegrations
- updateIntegration
- updateIntegrations
- deleteIntegration
- deleteIntegrations
- enableAutomaticFmdUpload
- setWorkloadAlertSetting
- updateIpWhitelist
- setIpWhitelistEnabled
- reseedLogShippingSecondary
- deleteLogShipping
- updateOrgSecurityPolicy
- createOrgSwitchSession
- createOrg
- updateOrg
- deleteOrg
- addAdGroupsToHierarchy
- deleteAdGroupsFromHierarchy
- addConfiguredGroupToHierarchy
- updateConfiguredGroup
- warmSearchCache
- cancelTaskchain
- validateAndSaveCustomerKmsInfo
- registerNasSystem
- updateNasSystem
- deleteNasSystem
- bulkDeleteNasSystems
- refreshNasSystems
- updateNasShares
- hideRevealNasShares
- hideRevealNasNamespaces
- updateSnmpConfig
- addSyslogExportRule
- updateSyslogExportRule
- deleteSyslogExportRule
- testSyslogExportRule
- updateRoleAssignments
- addRoleAssignments
- revokeAllOrgRoles
- batchDeassignRoleFromUserGroups
- inviteSsoGroup
- createRole
- mutateRole
- updateRole
- deleteRole
- createUser
- createUserWithPassword
- changePassword
- updateAccountOwner
- getDownloadUrl
- generateTotpSecret
- setTotpConfig
- deleteTotpConfig
- deleteTotpConfigs
- setUserLevelTotpEnforcement
- setMfaSetting
- generateClusterRegistrationToken
- updateLockoutConfig
- lockUsersByAdmin
- unlockUsersByAdmin
- updateAuthDomainUsersHiddenStatus
- upgradeToRsc
- resetUsersPasswordsWithUserIds
- resetAllOrgUsersPasswords
- setPasswordComplexityPolicy
- updateInsightState
- createVappsInstantRecovery
- updateVolumeGroup
- createOnDemandVolumeGroupBackup
- startVolumeGroupMount
- deleteVolumeGroupMount
- excludeVmDisks
- createGuestCredential
- updateGuestCredential
- deleteGuestCredentialById
- setDatastoreFreespaceThresholds
- upgradeIoFilter
- installIoFilter
- uninstallIoFilter
- retryDownloadPackageJob
- startDownloadPackageBatchJob
- startUpgradeBatchJob
- scheduleUpgradeBatchJob
- cancelScheduledUpgrade
- cancelDownloadPackage
- startPeriodicUpgradePrechecksOnDemandJob
- supportPortalLogin
- logoutFromRubrikSupportPortal
- setUpgradeType
- resolveVolumeGroupsConflict
- enableSupportUserAccess
- disableSupportUserAccess
- updateSupportUserAccess
- recoverCloudDirectPath
- recoverCloudDirectMultiPaths

[Go to top](#)

## Skipped fields

- allAwsComputeSettings
- allAzureRegions
- allAzureResourceGroups
- allAzureStorageAccounts
- allAzureSubnets
- allAzureVnets
- allClusterConnection
- azureResourceGroups
- deleteMongodbSource
- hostFailoverClusters
- mongodbCollection
- mongodbCollections
- mongodbDatabase
- mongodbDatabases
- mongodbSource
- mongodbSources
- recoverMongodbSource
- scheduledReports
- seedEnabledPolicies

[Go to top](#)
