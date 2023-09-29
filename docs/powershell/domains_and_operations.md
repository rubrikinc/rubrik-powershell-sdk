# API Domains and Operations

The RSC API is organized into 52 domain.
Each API domain is a set of related operations.

## Table of Contents

Numbers in parentheses indicate the number queries and mutations in the domain.

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Account (7,1)](#account-domain) | [Cluster (29,9)](#cluster-domain) | [Microsoft 365 (1,4)](#microsoft-365-domain) | [Ransomware (12,1)](#ransomware-domain) | [Sonar (5,0)](#sonar-domain) |
| [Activity series (4,3)](#activity-series-domain) | [Db2 (8,11)](#db2-domain) | [Managed Volume (4,11)](#managed-volume-domain) | [RCS (3,4)](#rcs-domain) | [Storage Arrays (1,4)](#storage-arrays-domain) |
| [AWS (28,33)](#aws-domain) | [Report Download (3,16)](#report-download-domain) | [Mongo DB (10,10)](#mongo-db-domain) | [RCV (1,3)](#rcv-domain) | [Tape (0,3)](#tape-domain) |
| [AWS Native (19,8)](#aws-native-domain) | [Microsoft Exchange (7,4)](#microsoft-exchange-domain) | [Mosaic (4,3)](#mosaic-domain) | [Replication (4,5)](#replication-domain) | [Threat (4,3)](#threat-domain) |
| [Azure (42,43)](#azure-domain) | [Fileset (6,6)](#fileset-domain) | [Microsoft SQL Server (16,17)](#microsoft-sql-server-domain) | [Report (2,9)](#report-domain) | [VMware vSphere vCenter (9,6)](#vmware-vsphere-vcenter-domain) |
| [Azure Native (23,8)](#azure-native-domain) | [Google Cloud Platform (16,11)](#google-cloud-platform-domain) | [NAS (8,0)](#nas-domain) | [SAP HANA (8,9)](#sap-hana-domain) | [VMware vSphere (23,8)](#vmware-vsphere-domain) |
| [Azure Office365 (11,1)](#azure-office365-domain) | [Google Cloud Platform Native (7,6)](#google-cloud-platform-native-domain) | [NFS (0,3)](#nfs-domain) | [Service Account (1,4)](#service-account-domain) | [VMware vSphere VM (6,24)](#vmware-vsphere-vm-domain) |
| [Cassandra (8,5)](#cassandra-domain) | [Host (6,6)](#host-domain) | [Nutanix (18,25)](#nutanix-domain) | [Sharepoint (8,1)](#sharepoint-domain) | [Webhook (1,5)](#webhook-domain) |
| [Certificates (6,6)](#certificates-domain) | [Microsoft Hyper-V (14,23)](#microsoft-hyper-v-domain) | [Office 365 (37,31)](#office-365-domain) | [SLA (14,9)](#sla-domain) |  |
| [Cloud Account (4,2)](#cloud-account-domain) | [Kubernetes (7,7)](#kubernetes-domain) | [Oracle (16,18)](#oracle-domain) | [SMB (2,4)](#smb-domain) |  |
| [Cloud Native (19,13)](#cloud-native-domain) | [LDAP (3,4)](#ldap-domain) | [Policy (6,1)](#policy-domain) | [Snapshot (21,15)](#snapshot-domain) |  |

## Account domain

Domain key: Account

Cmdlets: `New-RscQueryAccount` and `New-RscMutationAccount`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| EnabledFeatures |  | `New-RscQueryAccount -Operation EnabledFeatures`<BR> | [allEnabledFeaturesForAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Id |  | `New-RscQueryAccount -Operation Id`<BR> | [accountId](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Lookup |  | `New-RscQueryAccount -Operation Lookup`<BR> | [lookupAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Owners |  | `New-RscQueryAccount -Operation Owners`<BR> | [allAccountOwners](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Products |  | `New-RscQueryAccount -Operation Products`<BR> | [allAccountProducts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Settings |  | `New-RscQueryAccount -Operation Settings`<BR> | [accountSettings](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Users |  | `New-RscQueryAccount -Operation Users`<BR> | [allUsersOnAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| DeleteUsers |  | `New-RscMutationAccount -Operation DeleteUsers`<BR> | [deleteUsersFromAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Activity series domain

Domain key: ActivitySeries

Cmdlets: `New-RscQueryActivitySeries` and `New-RscMutationActivitySeries`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| ActivitySeries |  | `New-RscQueryActivitySeries -Operation ActivitySeries`<BR> | [activitySeries](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| List |  | `New-RscQueryActivitySeries -Operation List`<BR> | [activitySeriesConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UserFileTimeline |  | `New-RscQueryActivitySeries -Operation UserFileTimeline`<BR> | [userFileActivityTimeline](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UserTimeline |  | `New-RscQueryActivitySeries -Operation UserTimeline`<BR> | [userActivityTimeline](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Cancel |  | `New-RscMutationActivitySeries -Operation Cancel`<BR> | [cancelActivitySeries](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DownloadUserCsv |  | `New-RscMutationActivitySeries -Operation DownloadUserCsv`<BR> | [downloadUserActivityCsv](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DownloadUserFileCsv |  | `New-RscMutationActivitySeries -Operation DownloadUserFileCsv`<BR> | [downloadUserFileActivityCsv](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## AWS domain

Domain key: Aws

Cmdlets: `New-RscQueryAws` and `New-RscMutationAws`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| ArtifactsToDelete |  | `New-RscQueryAws -Operation ArtifactsToDelete`<BR> | [awsArtifactsToDelete](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| AvailabilityZonesByRegion |  | `New-RscQueryAws -Operation AvailabilityZonesByRegion`<BR> | [allAvailabilityZonesByRegionFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CdmVersions |  | `New-RscQueryAws -Operation CdmVersions`<BR> | [allAwsCdmVersions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountConfigs |  | `New-RscQueryAws -Operation CloudAccountConfigs`<BR> | [allAwsCloudAccountConfigs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountListSecurityGroups |  | `New-RscQueryAws -Operation CloudAccountListSecurityGroups`<BR> | [awsCloudAccountListSecurityGroups](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountListSubnets |  | `New-RscQueryAws -Operation CloudAccountListSubnets`<BR> | [awsCloudAccountListSubnets](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountListVpcs |  | `New-RscQueryAws -Operation CloudAccountListVpcs`<BR> | [awsCloudAccountListVpcs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountWithFeatures |  | `New-RscQueryAws -Operation CloudAccountWithFeatures`<BR> | [awsCloudAccountWithFeatures](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountsWithFeatures |  | `New-RscQueryAws -Operation CloudAccountsWithFeatures`<BR> | [allAwsCloudAccountsWithFeatures](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ComputeSettings |  | `New-RscQueryAws -Operation ComputeSettings`<BR> | [awsComputeSettings](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DbParameterGroupsByRegion |  | `New-RscQueryAws -Operation DbParameterGroupsByRegion`<BR> | [allDbParameterGroupsByRegionFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DbSubnetGroupsByRegion |  | `New-RscQueryAws -Operation DbSubnetGroupsByRegion`<BR> | [allDbSubnetGroupsByRegionFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Ec2KeyPairsByRegion |  | `New-RscQueryAws -Operation Ec2KeyPairsByRegion`<BR> | [allEc2KeyPairsByRegionFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExocomputeConfigs |  | `New-RscQueryAws -Operation ExocomputeConfigs`<BR> | [allAwsExocomputeConfigs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| InstanceProfileNames |  | `New-RscQueryAws -Operation InstanceProfileNames`<BR> | [allAwsInstanceProfileNames](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| IsS3BucketNameAvailable |  | `New-RscQueryAws -Operation IsS3BucketNameAvailable`<BR> | [isAwsS3BucketNameAvailable](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| KmsEncryptionKeysByRegion |  | `New-RscQueryAws -Operation KmsEncryptionKeysByRegion`<BR> | [allKmsEncryptionKeysByRegionFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| OptionGroupsByRegion |  | `New-RscQueryAws -Operation OptionGroupsByRegion`<BR> | [allOptionGroupsByRegionFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PermissionPolicies |  | `New-RscQueryAws -Operation PermissionPolicies`<BR> | [allAwsPermissionPolicies](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RdsInstanceDetails |  | `New-RscQueryAws -Operation RdsInstanceDetails`<BR> | [rdsInstanceDetailsFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Regions |  | `New-RscQueryAws -Operation Regions`<BR> | [allAwsRegions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| S3BucketStateForRecovery |  | `New-RscQueryAws -Operation S3BucketStateForRecovery`<BR> | [s3BucketStateForRecovery](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| S3Buckets |  | `New-RscQueryAws -Operation S3Buckets`<BR> | [allS3BucketsFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| S3BucketsDetails |  | `New-RscQueryAws -Operation S3BucketsDetails`<BR> | [allS3BucketsDetailsFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SupportedRdsDatabaseInstanceClasses |  | `New-RscQueryAws -Operation SupportedRdsDatabaseInstanceClasses`<BR> | [allSupportedAwsRdsDatabaseInstanceClasses](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TrustPolicy |  | `New-RscQueryAws -Operation TrustPolicy`<BR> | [awsTrustPolicy](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Vpcs |  | `New-RscQueryAws -Operation Vpcs`<BR> | [allVpcsFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| VpcsByRegion |  | `New-RscQueryAws -Operation VpcsByRegion`<BR> | [allVpcsByRegionFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AddAuthenticationServerBasedCloudAccount |  | `New-RscMutationAws -Operation AddAuthenticationServerBasedCloudAccount`<BR> | [addAwsAuthenticationServerBasedCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| AddIamUserBasedCloudAccount |  | `New-RscMutationAws -Operation AddIamUserBasedCloudAccount`<BR> | [addAwsIamUserBasedCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BulkDeleteCloudAccountWithoutCft |  | `New-RscMutationAws -Operation BulkDeleteCloudAccountWithoutCft`<BR> | [bulkDeleteAwsCloudAccountWithoutCft](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateAccount |  | `New-RscMutationAws -Operation CreateAccount`<BR> | [createAwsAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateAutomaticTargetMapping |  | `New-RscMutationAws -Operation CreateAutomaticTargetMapping`<BR> | [createAutomaticAwsTargetMapping](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateCloudNativeStorageSetting |  | `New-RscMutationAws -Operation CreateCloudNativeStorageSetting`<BR> | [createCloudNativeAwsStorageSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateCluster |  | `New-RscMutationAws -Operation CreateCluster`<BR> | [createAwsCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateComputeSetting |  | `New-RscMutationAws -Operation CreateComputeSetting`<BR> | [createAwsComputeSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateExocomputeConfigs |  | `New-RscMutationAws -Operation CreateExocomputeConfigs`<BR> | [createAwsExocomputeConfigs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateReaderTarget |  | `New-RscMutationAws -Operation CreateReaderTarget`<BR> | [createAwsReaderTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateTarget |  | `New-RscMutationAws -Operation CreateTarget`<BR> | [createAwsTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteCluster |  | `New-RscMutationAws -Operation DeleteCluster`<BR> | [deleteAwsCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteComputeSetting |  | `New-RscMutationAws -Operation DeleteComputeSetting`<BR> | [deleteAwsComputeSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteExocomputeConfigs |  | `New-RscMutationAws -Operation DeleteExocomputeConfigs`<BR> | [deleteAwsExocomputeConfigs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| FinalizeCloudAccountDeletion |  | `New-RscMutationAws -Operation FinalizeCloudAccountDeletion`<BR> | [finalizeAwsCloudAccountDeletion](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| FinalizeCloudAccountProtection |  | `New-RscMutationAws -Operation FinalizeCloudAccountProtection`<BR> | [finalizeAwsCloudAccountProtection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PatchAuthenticationServerBasedCloudAccount |  | `New-RscMutationAws -Operation PatchAuthenticationServerBasedCloudAccount`<BR> | [patchAwsAuthenticationServerBasedCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PatchIamUserBasedCloudAccount |  | `New-RscMutationAws -Operation PatchIamUserBasedCloudAccount`<BR> | [patchAwsIamUserBasedCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PrepareCloudAccountDeletion |  | `New-RscMutationAws -Operation PrepareCloudAccountDeletion`<BR> | [prepareAwsCloudAccountDeletion](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PrepareFeatureUpdateForCloudAccount |  | `New-RscMutationAws -Operation PrepareFeatureUpdateForCloudAccount`<BR> | [prepareFeatureUpdateForAwsCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RegisterFeatureArtifacts |  | `New-RscMutationAws -Operation RegisterFeatureArtifacts`<BR> | [registerAwsFeatureArtifacts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartExocomputeDisableJob |  | `New-RscMutationAws -Operation StartExocomputeDisableJob`<BR> | [startAwsExocomputeDisableJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateAccount |  | `New-RscMutationAws -Operation UpdateAccount`<BR> | [updateAwsAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateAutomaticTargetMapping |  | `New-RscMutationAws -Operation UpdateAutomaticTargetMapping`<BR> | [updateAutomaticAwsTargetMapping](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateCloudAccount |  | `New-RscMutationAws -Operation UpdateCloudAccount`<BR> | [updateAwsCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateCloudAccountFeature |  | `New-RscMutationAws -Operation UpdateCloudAccountFeature`<BR> | [updateAwsCloudAccountFeature](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateCloudNativeStorageSetting |  | `New-RscMutationAws -Operation UpdateCloudNativeStorageSetting`<BR> | [updateCloudNativeAwsStorageSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateComputeSetting |  | `New-RscMutationAws -Operation UpdateComputeSetting`<BR> | [updateAwsComputeSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateExocomputeConfigs |  | `New-RscMutationAws -Operation UpdateExocomputeConfigs`<BR> | [updateAwsExocomputeConfigs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateTarget |  | `New-RscMutationAws -Operation UpdateTarget`<BR> | [updateAwsTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpgradeCloudAccountFeaturesWithoutCft |  | `New-RscMutationAws -Operation UpgradeCloudAccountFeaturesWithoutCft`<BR> | [upgradeAwsCloudAccountFeaturesWithoutCft](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpgradeIamUserBasedCloudAccountPermissions |  | `New-RscMutationAws -Operation UpgradeIamUserBasedCloudAccountPermissions`<BR> | [upgradeAwsIamUserBasedCloudAccountPermissions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ValidateAndCreateCloudAccount |  | `New-RscMutationAws -Operation ValidateAndCreateCloudAccount`<BR> | [validateAndCreateAwsCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## AWS Native domain

Domain key: AwsNative

Cmdlets: `New-RscQueryAwsNative` and `New-RscMutationAwsNative`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Account |  | `New-RscQueryAwsNative -Operation Account`<BR> | [awsNativeAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Accounts |  | `New-RscQueryAwsNative -Operation Accounts`<BR> | [awsNativeAccounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| AmiTypeForArchivedSnapshotExport |  | `New-RscQueryAwsNative -Operation AmiTypeForArchivedSnapshotExport`<BR> | [amiTypeForAwsNativeArchivedSnapshotExport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| EbsVolume |  | `New-RscQueryAwsNative -Operation EbsVolume`<BR> | [awsNativeEbsVolume](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| EbsVolumes |  | `New-RscQueryAwsNative -Operation EbsVolumes`<BR> | [awsNativeEbsVolumes](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| EbsVolumesByName |  | `New-RscQueryAwsNative -Operation EbsVolumesByName`<BR> | [awsNativeEbsVolumesByName](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Ec2Instance |  | `New-RscQueryAwsNative -Operation Ec2Instance`<BR> | [awsNativeEc2Instance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Ec2Instances |  | `New-RscQueryAwsNative -Operation Ec2Instances`<BR> | [awsNativeEc2Instances](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Ec2InstancesByName |  | `New-RscQueryAwsNative -Operation Ec2InstancesByName`<BR> | [awsNativeEc2InstancesByName](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| IsEbsVolumeSnapshotRestorable |  | `New-RscQueryAwsNative -Operation IsEbsVolumeSnapshotRestorable`<BR> | [isAwsNativeEbsVolumeSnapshotRestorable](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| IsRdsInstanceLaunchConfigurationValid |  | `New-RscQueryAwsNative -Operation IsRdsInstanceLaunchConfigurationValid`<BR> | [isAwsNativeRdsInstanceLaunchConfigurationValid](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RdsExportDefaults |  | `New-RscQueryAwsNative -Operation RdsExportDefaults`<BR> | [awsNativeRdsExportDefaults](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RdsInstance |  | `New-RscQueryAwsNative -Operation RdsInstance`<BR> | [awsNativeRdsInstance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RdsInstances |  | `New-RscQueryAwsNative -Operation RdsInstances`<BR> | [awsNativeRdsInstances](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RdsPointInTimeRestoreWindow |  | `New-RscQueryAwsNative -Operation RdsPointInTimeRestoreWindow`<BR> | [awsNativeRdsPointInTimeRestoreWindow](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Root |  | `New-RscQueryAwsNative -Operation Root`<BR> | [awsNativeRoot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| S3Bucket |  | `New-RscQueryAwsNative -Operation S3Bucket`<BR> | [awsNativeS3Bucket](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ValidateRdsClusterNameForExport |  | `New-RscQueryAwsNative -Operation ValidateRdsClusterNameForExport`<BR> | [validateAwsNativeRdsClusterNameForExport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ValidateRdsInstanceNameForExport |  | `New-RscQueryAwsNative -Operation ValidateRdsInstanceNameForExport`<BR> | [validateAwsNativeRdsInstanceNameForExport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| ExcludeEbsVolumesFromSnapshot |  | `New-RscMutationAwsNative -Operation ExcludeEbsVolumesFromSnapshot`<BR> | [excludeAwsNativeEbsVolumesFromSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartAccountDisableJob |  | `New-RscMutationAwsNative -Operation StartAccountDisableJob`<BR> | [startAwsNativeAccountDisableJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartCreateEbsVolumeSnapshotsJob |  | `New-RscMutationAwsNative -Operation StartCreateEbsVolumeSnapshotsJob`<BR> | [startCreateAwsNativeEbsVolumeSnapshotsJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartEc2InstanceSnapshotsJob |  | `New-RscMutationAwsNative -Operation StartEc2InstanceSnapshotsJob`<BR> | [startAwsNativeEc2InstanceSnapshotsJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartExportEbsVolumeSnapshotJob |  | `New-RscMutationAwsNative -Operation StartExportEbsVolumeSnapshotJob`<BR> | [startExportAwsNativeEbsVolumeSnapshotJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartRdsInstanceSnapshotsJob |  | `New-RscMutationAwsNative -Operation StartRdsInstanceSnapshotsJob`<BR> | [startAwsNativeRdsInstanceSnapshotsJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartRefreshAccountsJob |  | `New-RscMutationAwsNative -Operation StartRefreshAccountsJob`<BR> | [startRefreshAwsNativeAccountsJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartRestoreEc2InstanceSnapshotJob |  | `New-RscMutationAwsNative -Operation StartRestoreEc2InstanceSnapshotJob`<BR> | [startRestoreAwsNativeEc2InstanceSnapshotJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Azure domain

Domain key: Azure

Cmdlets: `New-RscQueryAzure` and `New-RscMutationAzure`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AdDirectories |  | `New-RscQueryAzure -Operation AdDirectories`<BR> | [azureAdDirectories](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| AdDirectory |  | `New-RscQueryAzure -Operation AdDirectory`<BR> | [azureAdDirectory](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| AdObjectsByType |  | `New-RscQueryAzure -Operation AdObjectsByType`<BR> | [azureAdObjectsByType](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ArmTemplatesByFeature |  | `New-RscQueryAzure -Operation ArmTemplatesByFeature`<BR> | [allAzureArmTemplatesByFeature](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CdmVersions |  | `New-RscQueryAzure -Operation CdmVersions`<BR> | [allAzureCdmVersions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CheckPersistentStorageSubscriptionCanUnmap |  | `New-RscQueryAzure -Operation CheckPersistentStorageSubscriptionCanUnmap`<BR> | [checkAzurePersistentStorageSubscriptionCanUnmap](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountMissingPermissions |  | `New-RscQueryAzure -Operation CloudAccountMissingPermissions`<BR> | [allAzureCloudAccountMissingPermissions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountPermissionConfig |  | `New-RscQueryAzure -Operation CloudAccountPermissionConfig`<BR> | [azureCloudAccountPermissionConfig](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountSubnetsByRegion |  | `New-RscQueryAzure -Operation CloudAccountSubnetsByRegion`<BR> | [allAzureCloudAccountSubnetsByRegion](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountSubscriptionWithFeatures |  | `New-RscQueryAzure -Operation CloudAccountSubscriptionWithFeatures`<BR> | [azureCloudAccountSubscriptionWithFeatures](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountSubscriptionsByFeature |  | `New-RscQueryAzure -Operation CloudAccountSubscriptionsByFeature`<BR> | [allAzureCloudAccountSubscriptionsByFeature](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountTenant |  | `New-RscQueryAzure -Operation CloudAccountTenant`<BR> | [azureCloudAccountTenant](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountTenantWithExoConfigs |  | `New-RscQueryAzure -Operation CloudAccountTenantWithExoConfigs`<BR> | [azureCloudAccountTenantWithExoConfigs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountTenants |  | `New-RscQueryAzure -Operation CloudAccountTenants`<BR> | [allAzureCloudAccountTenants](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DiskEncryptionSetsByRegion |  | `New-RscQueryAzure -Operation DiskEncryptionSetsByRegion`<BR> | [allAzureDiskEncryptionSetsByRegion](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| EncryptionKeys |  | `New-RscQueryAzure -Operation EncryptionKeys`<BR> | [allAzureEncryptionKeys](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExocomputeConfigsInAccount |  | `New-RscQueryAzure -Operation ExocomputeConfigsInAccount`<BR> | [allAzureExocomputeConfigsInAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| HostedAzureRegions |  | `New-RscQueryAzure -Operation HostedAzureRegions`<BR> | [allHostedAzureRegions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| IsStorageAccountNameAvailable |  | `New-RscQueryAzure -Operation IsStorageAccountNameAvailable`<BR> | [isAzureStorageAccountNameAvailable](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| KeyVaultsByRegion |  | `New-RscQueryAzure -Operation KeyVaultsByRegion`<BR> | [allAzureKeyVaultsByRegion](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ManagedIdentities |  | `New-RscQueryAzure -Operation ManagedIdentities`<BR> | [allAzureManagedIdentities](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Nsgs |  | `New-RscQueryAzure -Operation Nsgs`<BR> | [allAzureNsgs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Regions |  | `New-RscQueryAzure -Operation Regions`<BR> | [azureRegions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ResourceGroups |  | `New-RscQueryAzure -Operation ResourceGroups`<BR> | [allResourceGroupsFromAzure](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SearchAdSnapshot |  | `New-RscQueryAzure -Operation SearchAdSnapshot`<BR> | [searchAzureAdSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SqlDatabase |  | `New-RscQueryAzure -Operation SqlDatabase`<BR> | [azureSqlDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SqlDatabaseDbPointInTimeRestoreWindowFromAzure |  | `New-RscQueryAzure -Operation SqlDatabaseDbPointInTimeRestoreWindowFromAzure`<BR> | [azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SqlDatabaseServer |  | `New-RscQueryAzure -Operation SqlDatabaseServer`<BR> | [azureSqlDatabaseServer](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SqlDatabaseServerElasticPools |  | `New-RscQueryAzure -Operation SqlDatabaseServerElasticPools`<BR> | [allAzureSqlDatabaseServerElasticPools](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SqlDatabaseServers |  | `New-RscQueryAzure -Operation SqlDatabaseServers`<BR> | [azureSqlDatabaseServers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SqlDatabases |  | `New-RscQueryAzure -Operation SqlDatabases`<BR> | [azureSqlDatabases](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SqlManagedInstanceDatabase |  | `New-RscQueryAzure -Operation SqlManagedInstanceDatabase`<BR> | [azureSqlManagedInstanceDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SqlManagedInstanceDatabases |  | `New-RscQueryAzure -Operation SqlManagedInstanceDatabases`<BR> | [azureSqlManagedInstanceDatabases](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure |  | `New-RscQueryAzure -Operation SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure`<BR> | [azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SqlManagedInstanceServer |  | `New-RscQueryAzure -Operation SqlManagedInstanceServer`<BR> | [azureSqlManagedInstanceServer](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SqlManagedInstanceServers |  | `New-RscQueryAzure -Operation SqlManagedInstanceServers`<BR> | [azureSqlManagedInstanceServers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StorageAccounts |  | `New-RscQueryAzure -Operation StorageAccounts`<BR> | [azureStorageAccounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Subnets |  | `New-RscQueryAzure -Operation Subnets`<BR> | [azureSubnets](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SubscriptionWithExocomputeMappings |  | `New-RscQueryAzure -Operation SubscriptionWithExocomputeMappings`<BR> | [allAzureSubscriptionWithExocomputeMappings](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Subscriptions |  | `New-RscQueryAzure -Operation Subscriptions`<BR> | [azureSubscriptions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| VNets |  | `New-RscQueryAzure -Operation VNets`<BR> | [azureVNets](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ValidateCloudAccountExocomputeConfigurations |  | `New-RscQueryAzure -Operation ValidateCloudAccountExocomputeConfigurations`<BR> | [validateAzureCloudAccountExocomputeConfigurations](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AddCloudAccount |  | `New-RscMutationAzure -Operation AddCloudAccount`<BR> | [addAzureCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| AddCloudAccountExocomputeConfigurations |  | `New-RscMutationAzure -Operation AddCloudAccountExocomputeConfigurations`<BR> | [addAzureCloudAccountExocomputeConfigurations](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| AddCloudAccountWithoutOauth |  | `New-RscMutationAzure -Operation AddCloudAccountWithoutOauth`<BR> | [addAzureCloudAccountWithoutOauth](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BackupAdDirectory |  | `New-RscMutationAzure -Operation BackupAdDirectory`<BR> | [backupAzureAdDirectory](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CompleteAdAppSetup |  | `New-RscMutationAzure -Operation CompleteAdAppSetup`<BR> | [completeAzureAdAppSetup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CompleteAdAppUpdate |  | `New-RscMutationAzure -Operation CompleteAdAppUpdate`<BR> | [completeAzureAdAppUpdate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CompleteCloudAccountOauth |  | `New-RscMutationAzure -Operation CompleteCloudAccountOauth`<BR> | [completeAzureCloudAccountOauth](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateAccount |  | `New-RscMutationAzure -Operation CreateAccount`<BR> | [createAzureAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateAutomaticTargetMapping |  | `New-RscMutationAzure -Operation CreateAutomaticTargetMapping`<BR> | [createAutomaticAzureTargetMapping](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateCloudNativeRcvStorageSetting |  | `New-RscMutationAzure -Operation CreateCloudNativeRcvStorageSetting`<BR> | [createCloudNativeRcvAzureStorageSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateCloudNativeStorageSetting |  | `New-RscMutationAzure -Operation CreateCloudNativeStorageSetting`<BR> | [createCloudNativeAzureStorageSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateCluster |  | `New-RscMutationAzure -Operation CreateCluster`<BR> | [createAzureCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateReaderTarget |  | `New-RscMutationAzure -Operation CreateReaderTarget`<BR> | [createAzureReaderTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateSaasAppAad |  | `New-RscMutationAzure -Operation CreateSaasAppAad`<BR> | [createAzureSaasAppAad](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateTarget |  | `New-RscMutationAzure -Operation CreateTarget`<BR> | [createAzureTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteAdDirectory |  | `New-RscMutationAzure -Operation DeleteAdDirectory`<BR> | [deleteAzureAdDirectory](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteCloudAccount |  | `New-RscMutationAzure -Operation DeleteCloudAccount`<BR> | [deleteAzureCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteCloudAccountExocomputeConfigurations |  | `New-RscMutationAzure -Operation DeleteCloudAccountExocomputeConfigurations`<BR> | [deleteAzureCloudAccountExocomputeConfigurations](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteCloudAccountWithoutOauth |  | `New-RscMutationAzure -Operation DeleteCloudAccountWithoutOauth`<BR> | [deleteAzureCloudAccountWithoutOauth](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteCluster |  | `New-RscMutationAzure -Operation DeleteCluster`<BR> | [deleteAzureCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| MapCloudAccountExocomputeSubscription |  | `New-RscMutationAzure -Operation MapCloudAccountExocomputeSubscription`<BR> | [mapAzureCloudAccountExocomputeSubscription](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| MapCloudAccountToPersistentStorageLocation |  | `New-RscMutationAzure -Operation MapCloudAccountToPersistentStorageLocation`<BR> | [mapAzureCloudAccountToPersistentStorageLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| OauthConsentComplete |  | `New-RscMutationAzure -Operation OauthConsentComplete`<BR> | [azureOauthConsentComplete](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| OauthConsentKickoff |  | `New-RscMutationAzure -Operation OauthConsentKickoff`<BR> | [azureOauthConsentKickoff](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RestoreAdObjectsWithPasswords |  | `New-RscMutationAzure -Operation RestoreAdObjectsWithPasswords`<BR> | [restoreAzureAdObjectsWithPasswords](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SetCloudAccountCustomerAppCredentials |  | `New-RscMutationAzure -Operation SetCloudAccountCustomerAppCredentials`<BR> | [setAzureCloudAccountCustomerAppCredentials](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartAdAppSetup |  | `New-RscMutationAzure -Operation StartAdAppSetup`<BR> | [startAzureAdAppSetup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartAdAppUpdate |  | `New-RscMutationAzure -Operation StartAdAppUpdate`<BR> | [startAzureAdAppUpdate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartCloudAccountOauth |  | `New-RscMutationAzure -Operation StartCloudAccountOauth`<BR> | [startAzureCloudAccountOauth](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartDisableCloudAccountJob |  | `New-RscMutationAzure -Operation StartDisableCloudAccountJob`<BR> | [startDisableAzureCloudAccountJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartExportSqlDatabaseDbJob |  | `New-RscMutationAzure -Operation StartExportSqlDatabaseDbJob`<BR> | [startExportAzureSqlDatabaseDbJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartExportSqlManagedInstanceDbJob |  | `New-RscMutationAzure -Operation StartExportSqlManagedInstanceDbJob`<BR> | [startExportAzureSqlManagedInstanceDbJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UnmapCloudAccountExocomputeSubscription |  | `New-RscMutationAzure -Operation UnmapCloudAccountExocomputeSubscription`<BR> | [unmapAzureCloudAccountExocomputeSubscription](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UnmapPersistentStorageSubscription |  | `New-RscMutationAzure -Operation UnmapPersistentStorageSubscription`<BR> | [unmapAzurePersistentStorageSubscription](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateAccount |  | `New-RscMutationAzure -Operation UpdateAccount`<BR> | [updateAzureAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateAutomaticTargetMapping |  | `New-RscMutationAzure -Operation UpdateAutomaticTargetMapping`<BR> | [updateAutomaticAzureTargetMapping](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateCloudAccount |  | `New-RscMutationAzure -Operation UpdateCloudAccount`<BR> | [updateAzureCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateCloudNativeRcvStorageSetting |  | `New-RscMutationAzure -Operation UpdateCloudNativeRcvStorageSetting`<BR> | [updateCloudNativeRcvAzureStorageSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateCloudNativeStorageSetting |  | `New-RscMutationAzure -Operation UpdateCloudNativeStorageSetting`<BR> | [updateCloudNativeAzureStorageSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateCustomerAppPermissionForSql |  | `New-RscMutationAzure -Operation UpdateCustomerAppPermissionForSql`<BR> | [updateCustomerAppPermissionForAzureSql](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateTarget |  | `New-RscMutationAzure -Operation UpdateTarget`<BR> | [updateAzureTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpgradeCloudAccount |  | `New-RscMutationAzure -Operation UpgradeCloudAccount`<BR> | [upgradeAzureCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpgradeCloudAccountPermissionsWithoutOauth |  | `New-RscMutationAzure -Operation UpgradeCloudAccountPermissionsWithoutOauth`<BR> | [upgradeAzureCloudAccountPermissionsWithoutOauth](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Azure Native domain

Domain key: AzureNative

Cmdlets: `New-RscQueryAzureNative` and `New-RscMutationAzureNative`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AvailabilitySetsByRegionFromAzure |  | `New-RscQueryAzureNative -Operation AvailabilitySetsByRegionFromAzure`<BR> | [allAzureNativeAvailabilitySetsByRegionFromAzure](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DoesResourceGroupExist |  | `New-RscQueryAzureNative -Operation DoesResourceGroupExist`<BR> | [doesAzureNativeResourceGroupExist](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExportCompatibleDiskTypesByRegionFromAzure |  | `New-RscQueryAzureNative -Operation ExportCompatibleDiskTypesByRegionFromAzure`<BR> | [allAzureNativeExportCompatibleDiskTypesByRegionFromAzure](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExportCompatibleVmSizesByRegionFromAzure |  | `New-RscQueryAzureNative -Operation ExportCompatibleVmSizesByRegionFromAzure`<BR> | [allAzureNativeExportCompatibleVmSizesByRegionFromAzure](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| IsManagedDiskSnapshotRestorable |  | `New-RscQueryAzureNative -Operation IsManagedDiskSnapshotRestorable`<BR> | [isAzureNativeManagedDiskSnapshotRestorable](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| IsSqlDatabaseSnapshotPersistent |  | `New-RscQueryAzureNative -Operation IsSqlDatabaseSnapshotPersistent`<BR> | [isAzureNativeSqlDatabaseSnapshotPersistent](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ManagedDisk |  | `New-RscQueryAzureNative -Operation ManagedDisk`<BR> | [azureNativeManagedDisk](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ManagedDisks |  | `New-RscQueryAzureNative -Operation ManagedDisks`<BR> | [azureNativeManagedDisks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ResourceGroup |  | `New-RscQueryAzureNative -Operation ResourceGroup`<BR> | [azureNativeResourceGroup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ResourceGroups |  | `New-RscQueryAzureNative -Operation ResourceGroups`<BR> | [azureNativeResourceGroups](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ResourceGroupsInfoIfExist |  | `New-RscQueryAzureNative -Operation ResourceGroupsInfoIfExist`<BR> | [allAzureNativeResourceGroupsInfoIfExist](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Root |  | `New-RscQueryAzureNative -Operation Root`<BR> | [azureNativeRoot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SecurityGroupsByRegionFromAzure |  | `New-RscQueryAzureNative -Operation SecurityGroupsByRegionFromAzure`<BR> | [allAzureNativeSecurityGroupsByRegionFromAzure](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StorageAccountsFromAzure |  | `New-RscQueryAzureNative -Operation StorageAccountsFromAzure`<BR> | [allAzureNativeStorageAccountsFromAzure](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SubnetsByRegionFromAzure |  | `New-RscQueryAzureNative -Operation SubnetsByRegionFromAzure`<BR> | [allAzureNativeSubnetsByRegionFromAzure](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Subscription |  | `New-RscQueryAzureNative -Operation Subscription`<BR> | [azureNativeSubscription](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Subscriptions |  | `New-RscQueryAzureNative -Operation Subscriptions`<BR> | [azureNativeSubscriptions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ValidateSqlDatabaseDbNameForExport |  | `New-RscQueryAzureNative -Operation ValidateSqlDatabaseDbNameForExport`<BR> | [validateAzureNativeSqlDatabaseDbNameForExport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ValidateSqlManagedInstanceDbNameForExport |  | `New-RscQueryAzureNative -Operation ValidateSqlManagedInstanceDbNameForExport`<BR> | [validateAzureNativeSqlManagedInstanceDbNameForExport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| VirtualMachine |  | `New-RscQueryAzureNative -Operation VirtualMachine`<BR> | [azureNativeVirtualMachine](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| VirtualMachineSizes |  | `New-RscQueryAzureNative -Operation VirtualMachineSizes`<BR> | [allAzureNativeVirtualMachineSizes](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| VirtualMachines |  | `New-RscQueryAzureNative -Operation VirtualMachines`<BR> | [azureNativeVirtualMachines](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| VirtualNetworks |  | `New-RscQueryAzureNative -Operation VirtualNetworks`<BR> | [allAzureNativeVirtualNetworks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| ExcludeManagedDisksFromSnapshot |  | `New-RscMutationAzureNative -Operation ExcludeManagedDisksFromSnapshot`<BR> | [excludeAzureNativeManagedDisksFromSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartCreateManagedDiskSnapshotsJob |  | `New-RscMutationAzureNative -Operation StartCreateManagedDiskSnapshotsJob`<BR> | [startCreateAzureNativeManagedDiskSnapshotsJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartCreateVirtualMachineSnapshotsJob |  | `New-RscMutationAzureNative -Operation StartCreateVirtualMachineSnapshotsJob`<BR> | [startCreateAzureNativeVirtualMachineSnapshotsJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartDisableSubscriptionProtectionJob |  | `New-RscMutationAzureNative -Operation StartDisableSubscriptionProtectionJob`<BR> | [startDisableAzureNativeSubscriptionProtectionJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartExportManagedDiskJob |  | `New-RscMutationAzureNative -Operation StartExportManagedDiskJob`<BR> | [startExportAzureNativeManagedDiskJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartExportVirtualMachineJob |  | `New-RscMutationAzureNative -Operation StartExportVirtualMachineJob`<BR> | [startExportAzureNativeVirtualMachineJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartRefreshSubscriptionsJob |  | `New-RscMutationAzureNative -Operation StartRefreshSubscriptionsJob`<BR> | [startRefreshAzureNativeSubscriptionsJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartRestoreVirtualMachineJob |  | `New-RscMutationAzureNative -Operation StartRestoreVirtualMachineJob`<BR> | [startRestoreAzureNativeVirtualMachineJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Azure Office365 domain

Domain key: AzureO365

Cmdlets: `New-RscQueryAzureO365` and `New-RscMutationAzureO365`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| CheckNSGOutboundRules |  | `New-RscQueryAzureO365 -Operation CheckNSGOutboundRules`<BR> | [azureO365CheckNSGOutboundRules](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CheckNetworkSubnet |  | `New-RscQueryAzureO365 -Operation CheckNetworkSubnet`<BR> | [azureO365CheckNetworkSubnet](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CheckResourceGroupName |  | `New-RscQueryAzureO365 -Operation CheckResourceGroupName`<BR> | [azureO365CheckResourceGroupName](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CheckStorageAccountAccessibility |  | `New-RscQueryAzureO365 -Operation CheckStorageAccountAccessibility`<BR> | [azureO365CheckStorageAccountAccessibility](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CheckStorageAccountName |  | `New-RscQueryAzureO365 -Operation CheckStorageAccountName`<BR> | [azureO365CheckStorageAccountName](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CheckSubscriptionQuota |  | `New-RscQueryAzureO365 -Operation CheckSubscriptionQuota`<BR> | [azureO365CheckSubscriptionQuota](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CheckVirtualNetworkName |  | `New-RscQueryAzureO365 -Operation CheckVirtualNetworkName`<BR> | [azureO365CheckVirtualNetworkName](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Exocompute |  | `New-RscQueryAzureO365 -Operation Exocompute`<BR> | [azureO365Exocompute](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| GetAzureHostType |  | `New-RscQueryAzureO365 -Operation GetAzureHostType`<BR> | [azureO365GetAzureHostType](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| GetNetworkSubnetUnusedAddr |  | `New-RscQueryAzureO365 -Operation GetNetworkSubnetUnusedAddr`<BR> | [azureO365GetNetworkSubnetUnusedAddr](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ValidateUserRoles |  | `New-RscQueryAzureO365 -Operation ValidateUserRoles`<BR> | [azureO365ValidateUserRoles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| SetupExocompute |  | `New-RscMutationAzureO365 -Operation SetupExocompute`<BR> | [setupAzureO365Exocompute](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Cassandra domain

Domain key: Cassandra

Cmdlets: `New-RscQueryCassandra` and `New-RscMutationCassandra`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| ColumnFamilies |  | `New-RscQueryCassandra -Operation ColumnFamilies`<BR> | [cassandraColumnFamilies](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ColumnFamily |  | `New-RscQueryCassandra -Operation ColumnFamily`<BR> | [cassandraColumnFamily](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ColumnFamilyRecoverableRange |  | `New-RscQueryCassandra -Operation ColumnFamilyRecoverableRange`<BR> | [cassandraColumnFamilyRecoverableRange](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ColumnFamilySchema |  | `New-RscQueryCassandra -Operation ColumnFamilySchema`<BR> | [cassandraColumnFamilySchema](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Keyspace |  | `New-RscQueryCassandra -Operation Keyspace`<BR> | [cassandraKeyspace](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Keyspaces |  | `New-RscQueryCassandra -Operation Keyspaces`<BR> | [cassandraKeyspaces](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Source |  | `New-RscQueryCassandra -Operation Source`<BR> | [cassandraSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Sources |  | `New-RscQueryCassandra -Operation Sources`<BR> | [cassandraSources](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| BulkDeleteSources |  | `New-RscMutationCassandra -Operation BulkDeleteSources`<BR> | [bulkDeleteCassandraSources](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateSource |  | `New-RscMutationCassandra -Operation CreateSource`<BR> | [createCassandraSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteSource |  | `New-RscMutationCassandra -Operation DeleteSource`<BR> | [deleteCassandraSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RecoverSource |  | `New-RscMutationCassandra -Operation RecoverSource`<BR> | [recoverCassandraSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateSource |  | `New-RscMutationCassandra -Operation UpdateSource`<BR> | [updateCassandraSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Certificates domain

Domain key: Certificate

Cmdlets: `New-RscQueryCertificate` and `New-RscMutationCertificate`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Certificate |  | `New-RscQueryCertificate -Operation Certificate`<BR> | [certificates](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Cluster |  | `New-RscQueryCertificate -Operation Cluster`<BR> | [clusterCertificates](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ClusterWebSigned |  | `New-RscQueryCertificate -Operation ClusterWebSigned`<BR> | [clusterWebSignedCertificate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SigningRequest |  | `New-RscQueryCertificate -Operation SigningRequest`<BR> | [certificateSigningRequest](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SigningRequests |  | `New-RscQueryCertificate -Operation SigningRequests`<BR> | [certificateSigningRequests](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| WithKey |  | `New-RscQueryCertificate -Operation WithKey`<BR> | [certificatesWithKey](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AddClusterCertificate |  | `New-RscMutationCertificate -Operation AddClusterCertificate`<BR> | [addClusterCertificate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Delete |  | `New-RscMutationCertificate -Operation Delete`<BR> | [deleteCertificate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SetSso |  | `New-RscMutationCertificate -Operation SetSso`<BR> | [setSsoCertificate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SetWebSigned |  | `New-RscMutationCertificate -Operation SetWebSigned`<BR> | [setWebSignedCertificate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Update |  | `New-RscMutationCertificate -Operation Update`<BR> | [updateCertificate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateHost |  | `New-RscMutationCertificate -Operation UpdateHost`<BR> | [updateCertificateHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Cloud Account domain

Domain key: CloudAccount

Cmdlets: `New-RscQueryCloudAccount` and `New-RscMutationCloudAccount`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| CloudAccount |  | `New-RscQueryCloudAccount -Operation CloudAccount`<BR> | [cloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CurrentFeaturePermissions |  | `New-RscQueryCloudAccount -Operation CurrentFeaturePermissions`<BR> | [allCurrentFeaturePermissionsForCloudAccounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExocomputeMappings |  | `New-RscQueryCloudAccount -Operation ExocomputeMappings`<BR> | [allCloudAccountExocomputeMappings](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| LatestFeaturePermissions |  | `New-RscQueryCloudAccount -Operation LatestFeaturePermissions`<BR> | [allLatestFeaturePermissionsForCloudAccounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| MapExocomputeAccount |  | `New-RscMutationCloudAccount -Operation MapExocomputeAccount`<BR> | [mapCloudAccountExocomputeAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UnmapExocomputeAccount |  | `New-RscMutationCloudAccount -Operation UnmapExocomputeAccount`<BR> | [unmapCloudAccountExocomputeAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Cloud Native domain

Domain key: CloudNative

Cmdlets: `New-RscQueryCloudNative` and `New-RscMutationCloudNative`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| CheckArchivedSnapshotsLocked |  | `New-RscQueryCloudNative -Operation CheckArchivedSnapshotsLocked`<BR> | [cloudNativeCheckArchivedSnapshotsLocked](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CheckLabelRuleNameUniqueness |  | `New-RscQueryCloudNative -Operation CheckLabelRuleNameUniqueness`<BR> | [checkCloudNativeLabelRuleNameUniqueness](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CheckRequiredPermissionsForFeature |  | `New-RscQueryCloudNative -Operation CheckRequiredPermissionsForFeature`<BR> | [cloudNativeCheckRequiredPermissionsForFeature](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CheckTagRuleNameUniqueness |  | `New-RscQueryCloudNative -Operation CheckTagRuleNameUniqueness`<BR> | [checkCloudNativeTagRuleNameUniqueness](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CustomerTags |  | `New-RscQueryCloudNative -Operation CustomerTags`<BR> | [cloudNativeCustomerTags](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| FileRecoveryEligibleSnapshots |  | `New-RscQueryCloudNative -Operation FileRecoveryEligibleSnapshots`<BR> | [allCloudNativeFileRecoveryEligibleSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| IsFileRecoveryFeasible |  | `New-RscQueryCloudNative -Operation IsFileRecoveryFeasible`<BR> | [isCloudNativeFileRecoveryFeasible](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| LabelKeys |  | `New-RscQueryCloudNative -Operation LabelKeys`<BR> | [allCloudNativeLabelKeys](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| LabelRules |  | `New-RscQueryCloudNative -Operation LabelRules`<BR> | [cloudNativeLabelRules](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| LabelValues |  | `New-RscQueryCloudNative -Operation LabelValues`<BR> | [allCloudNativeLabelValues](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RbaInstallers |  | `New-RscQueryCloudNative -Operation RbaInstallers`<BR> | [cloudNativeRbaInstallers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SnapshotDetailsForRecovery |  | `New-RscQueryCloudNative -Operation SnapshotDetailsForRecovery`<BR> | [cloudNativeSnapshotDetailsForRecovery](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SnapshotTypeDetails |  | `New-RscQueryCloudNative -Operation SnapshotTypeDetails`<BR> | [cloudNativeSnapshotTypeDetails](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Snapshots |  | `New-RscQueryCloudNative -Operation Snapshots`<BR> | [cloudNativeSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SqlServerSetupScript |  | `New-RscQueryCloudNative -Operation SqlServerSetupScript`<BR> | [cloudNativeSqlServerSetupScript](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TagKeys |  | `New-RscQueryCloudNative -Operation TagKeys`<BR> | [allCloudNativeTagKeys](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TagRules |  | `New-RscQueryCloudNative -Operation TagRules`<BR> | [cloudNativeTagRules](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TagValues |  | `New-RscQueryCloudNative -Operation TagValues`<BR> | [allCloudNativeTagValues](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| WorkloadVersionedFiles |  | `New-RscQueryCloudNative -Operation WorkloadVersionedFiles`<BR> | [cloudNativeWorkloadVersionedFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AddSqlServerBackupCredentials |  | `New-RscMutationCloudNative -Operation AddSqlServerBackupCredentials`<BR> | [addCloudNativeSqlServerBackupCredentials](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CheckRbaConnectivity |  | `New-RscMutationCloudNative -Operation CheckRbaConnectivity`<BR> | [cloudNativeCheckRbaConnectivity](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ClearSqlServerBackupCredentials |  | `New-RscMutationCloudNative -Operation ClearSqlServerBackupCredentials`<BR> | [clearCloudNativeSqlServerBackupCredentials](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateLabelRule |  | `New-RscMutationCloudNative -Operation CreateLabelRule`<BR> | [createCloudNativeLabelRule](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateTagRule |  | `New-RscMutationCloudNative -Operation CreateTagRule`<BR> | [createCloudNativeTagRule](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteLabelRule |  | `New-RscMutationCloudNative -Operation DeleteLabelRule`<BR> | [deleteCloudNativeLabelRule](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteTagRule |  | `New-RscMutationCloudNative -Operation DeleteTagRule`<BR> | [deleteCloudNativeTagRule](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DownloadFiles |  | `New-RscMutationCloudNative -Operation DownloadFiles`<BR> | [cloudNativeDownloadFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SetupSqlServerBackup |  | `New-RscMutationCloudNative -Operation SetupSqlServerBackup`<BR> | [setupCloudNativeSqlServerBackup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartSnapshotsIndexJob |  | `New-RscMutationCloudNative -Operation StartSnapshotsIndexJob`<BR> | [startCloudNativeSnapshotsIndexJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateIndexingStatus |  | `New-RscMutationCloudNative -Operation UpdateIndexingStatus`<BR> | [updateCloudNativeIndexingStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateLabelRule |  | `New-RscMutationCloudNative -Operation UpdateLabelRule`<BR> | [updateCloudNativeLabelRule](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateTagRule |  | `New-RscMutationCloudNative -Operation UpdateTagRule`<BR> | [updateCloudNativeTagRule](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Cluster domain

Domain key: Cluster

Cmdlets: `New-RscQueryCluster` and `New-RscMutationCluster`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Cluster |  | `New-RscQueryCluster -Operation Cluster`<BR> | [cluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Connected |  | `New-RscQueryCluster -Operation Connected`<BR> | [allConnectedClusters](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DatabaseLogReport |  | `New-RscQueryCluster -Operation DatabaseLogReport`<BR> | [databaseLogReportForCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DatabaseLogReportingProperties |  | `New-RscQueryCluster -Operation DatabaseLogReportingProperties`<BR> | [databaseLogReportingPropertiesForCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DefaultGateway |  | `New-RscQueryCluster -Operation DefaultGateway`<BR> | [clusterDefaultGateway](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Dns |  | `New-RscQueryCluster -Operation Dns`<BR> | [clusterDns](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| FloatingIps |  | `New-RscQueryCluster -Operation FloatingIps`<BR> | [clusterFloatingIps](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| GroupByList |  | `New-RscQueryCluster -Operation GroupByList`<BR> | [clusterGroupByConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| HostFailover |  | `New-RscQueryCluster -Operation HostFailover`<BR> | [hostFailoverCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Ipmi |  | `New-RscQueryCluster -Operation Ipmi`<BR> | [clusterIpmi](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Ipv6Mode |  | `New-RscQueryCluster -Operation Ipv6Mode`<BR> | [clusterIpv6Mode](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| IsTotpAckNecessary |  | `New-RscQueryCluster -Operation IsTotpAckNecessary`<BR> | [isTotpAckNecessaryForCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| List |  | `New-RscQueryCluster -Operation List`<BR> | [clusterConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| NetworkInterfaces |  | `New-RscQueryCluster -Operation NetworkInterfaces`<BR> | [clusterNetworkInterfaces](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Nodes |  | `New-RscQueryCluster -Operation Nodes`<BR> | [clusterNodes](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| NtpServers |  | `New-RscQueryCluster -Operation NtpServers`<BR> | [clusterNtpServers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| OperationJobProgress |  | `New-RscQueryCluster -Operation OperationJobProgress`<BR> | [clusterOperationJobProgress](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Proxy |  | `New-RscQueryCluster -Operation Proxy`<BR> | [clusterProxy](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RegistrationProductInfo |  | `New-RscQueryCluster -Operation RegistrationProductInfo`<BR> | [clusterRegistrationProductInfo](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ReplicationTargets |  | `New-RscQueryCluster -Operation ReplicationTargets`<BR> | [allClusterReplicationTargets](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ReportMigrationCount |  | `New-RscQueryCluster -Operation ReportMigrationCount`<BR> | [clusterReportMigrationCount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ReportMigrationJobStatus |  | `New-RscQueryCluster -Operation ReportMigrationJobStatus`<BR> | [clusterReportMigrationJobStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ReportMigrationStatus |  | `New-RscQueryCluster -Operation ReportMigrationStatus`<BR> | [clusterReportMigrationStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TotpAckStatus |  | `New-RscQueryCluster -Operation TotpAckStatus`<BR> | [allClustersTotpAckStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TypeList |  | `New-RscQueryCluster -Operation TypeList`<BR> | [clusterTypeList](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Vlans |  | `New-RscQueryCluster -Operation Vlans`<BR> | [clusterVlans](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| WebCertsAndIpmis |  | `New-RscQueryCluster -Operation WebCertsAndIpmis`<BR> | [allClusterWebCertsAndIpmis](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Windows |  | `New-RscQueryCluster -Operation Windows`<BR> | [windowsCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| WithUpgradesInfo |  | `New-RscQueryCluster -Operation WithUpgradesInfo`<BR> | [clusterWithUpgradesInfo](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AddNodesToCloud |  | `New-RscMutationCluster -Operation AddNodesToCloud`<BR> | [addNodesToCloudCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BulkDeleteFailover |  | `New-RscMutationCluster -Operation BulkDeleteFailover`<BR> | [bulkDeleteFailoverCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateFailover |  | `New-RscMutationCluster -Operation CreateFailover`<BR> | [createFailoverCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteFailover |  | `New-RscMutationCluster -Operation DeleteFailover`<BR> | [deleteFailoverCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RecoverCloud |  | `New-RscMutationCluster -Operation RecoverCloud`<BR> | [recoverCloudCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RegisterCloud |  | `New-RscMutationCluster -Operation RegisterCloud`<BR> | [registerCloudCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RemoveCdm |  | `New-RscMutationCluster -Operation RemoveCdm`<BR> | [removeCdmCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateDatabaseLogReportingProperties |  | `New-RscMutationCluster -Operation UpdateDatabaseLogReportingProperties`<BR> | [updateDatabaseLogReportingPropertiesForCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateFailover |  | `New-RscMutationCluster -Operation UpdateFailover`<BR> | [updateFailoverCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Db2 domain

Domain key: Db2

Cmdlets: `New-RscQueryDb2` and `New-RscMutationDb2`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Database |  | `New-RscQueryDb2 -Operation Database`<BR> | [db2Database](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Databases |  | `New-RscQueryDb2 -Operation Databases`<BR> | [db2Databases](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Instance |  | `New-RscQueryDb2 -Operation Instance`<BR> | [db2Instance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Instances |  | `New-RscQueryDb2 -Operation Instances`<BR> | [db2Instances](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| LogSnapshot |  | `New-RscQueryDb2 -Operation LogSnapshot`<BR> | [db2LogSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| LogSnapshots |  | `New-RscQueryDb2 -Operation LogSnapshots`<BR> | [db2LogSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RecoverableRange |  | `New-RscQueryDb2 -Operation RecoverableRange`<BR> | [db2RecoverableRange](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RecoverableRanges |  | `New-RscQueryDb2 -Operation RecoverableRanges`<BR> | [db2RecoverableRanges](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AddInstance |  | `New-RscMutationDb2 -Operation AddInstance`<BR> | [addDb2Instance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateOnDemandBackup |  | `New-RscMutationDb2 -Operation CreateOnDemandBackup`<BR> | [createOnDemandDb2Backup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteDatabase |  | `New-RscMutationDb2 -Operation DeleteDatabase`<BR> | [deleteDb2Database](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteInstance |  | `New-RscMutationDb2 -Operation DeleteInstance`<BR> | [deleteDb2Instance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DiscoverInstance |  | `New-RscMutationDb2 -Operation DiscoverInstance`<BR> | [discoverDb2Instance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DownloadSnapshot |  | `New-RscMutationDb2 -Operation DownloadSnapshot`<BR> | [downloadDb2Snapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DownloadSnapshotsForPointInTimeRecovery |  | `New-RscMutationDb2 -Operation DownloadSnapshotsForPointInTimeRecovery`<BR> | [downloadDb2SnapshotsForPointInTimeRecovery](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExpireDownloadedSnapshots |  | `New-RscMutationDb2 -Operation ExpireDownloadedSnapshots`<BR> | [expireDownloadedDb2Snapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PatchDatabase |  | `New-RscMutationDb2 -Operation PatchDatabase`<BR> | [patchDb2Database](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PatchInstance |  | `New-RscMutationDb2 -Operation PatchInstance`<BR> | [patchDb2Instance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RefreshDatabase |  | `New-RscMutationDb2 -Operation RefreshDatabase`<BR> | [refreshDb2Database](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Report Download domain

Domain key: Download

Cmdlets: `New-RscQueryDownload` and `New-RscMutationDownload`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| CdmUpgradesPdf |  | `New-RscQueryDownload -Operation CdmUpgradesPdf`<BR> | [downloadCdmUpgradesPdf](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| EdVersionList |  | `New-RscQueryDownload -Operation EdVersionList`<BR> | [downloadedVersionList](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PackageStatus |  | `New-RscQueryDownload -Operation PackageStatus`<BR> | [downloadPackageStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AuditLogCsvAsync |  | `New-RscMutationDownload -Operation AuditLogCsvAsync`<BR> | [downloadAuditLogCsvAsync](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExchangeSnapshot |  | `New-RscMutationDownload -Operation ExchangeSnapshot`<BR> | [downloadExchangeSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| FilesetSnapshot |  | `New-RscMutationDownload -Operation FilesetSnapshot`<BR> | [downloadFilesetSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| FilesetSnapshotFromLocation |  | `New-RscMutationDownload -Operation FilesetSnapshotFromLocation`<BR> | [downloadFilesetSnapshotFromLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ObjectFilesCsv |  | `New-RscMutationDownload -Operation ObjectFilesCsv`<BR> | [downloadObjectFilesCsv](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ObjectsListCsv |  | `New-RscMutationDownload -Operation ObjectsListCsv`<BR> | [downloadObjectsListCsv](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ReportCsvAsync |  | `New-RscMutationDownload -Operation ReportCsvAsync`<BR> | [downloadReportCsvAsync](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ReportPdfAsync |  | `New-RscMutationDownload -Operation ReportPdfAsync`<BR> | [downloadReportPdfAsync](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ResultsCsv |  | `New-RscMutationDownload -Operation ResultsCsv`<BR> | [downloadResultsCsv](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SapHanaSnapshot |  | `New-RscMutationDownload -Operation SapHanaSnapshot`<BR> | [downloadSapHanaSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SapHanaSnapshotFromLocation |  | `New-RscMutationDownload -Operation SapHanaSnapshotFromLocation`<BR> | [downloadSapHanaSnapshotFromLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SapHanaSnapshotsForPointInTimeRecovery |  | `New-RscMutationDownload -Operation SapHanaSnapshotsForPointInTimeRecovery`<BR> | [downloadSapHanaSnapshotsForPointInTimeRecovery](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SnapshotResultsCsv |  | `New-RscMutationDownload -Operation SnapshotResultsCsv`<BR> | [downloadSnapshotResultsCsv](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ThreatHuntCsv |  | `New-RscMutationDownload -Operation ThreatHuntCsv`<BR> | [downloadThreatHuntCsv](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| VolumeGroupSnapshotFiles |  | `New-RscMutationDownload -Operation VolumeGroupSnapshotFiles`<BR> | [downloadVolumeGroupSnapshotFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| VolumeGroupSnapshotFromLocation |  | `New-RscMutationDownload -Operation VolumeGroupSnapshotFromLocation`<BR> | [downloadVolumeGroupSnapshotFromLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Microsoft Exchange domain

Domain key: Exchange

Cmdlets: `New-RscQueryExchange` and `New-RscMutationExchange`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Dag |  | `New-RscQueryExchange -Operation Dag`<BR> | [exchangeDag](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Dags |  | `New-RscQueryExchange -Operation Dags`<BR> | [exchangeDags](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Database |  | `New-RscQueryExchange -Operation Database`<BR> | [exchangeDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Databases |  | `New-RscQueryExchange -Operation Databases`<BR> | [exchangeDatabases](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| LiveMounts |  | `New-RscQueryExchange -Operation LiveMounts`<BR> | [exchangeLiveMounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Server |  | `New-RscQueryExchange -Operation Server`<BR> | [exchangeServer](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Servers |  | `New-RscQueryExchange -Operation Servers`<BR> | [exchangeServers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| BulkUpdateDag |  | `New-RscMutationExchange -Operation BulkUpdateDag`<BR> | [bulkUpdateExchangeDag](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateMount |  | `New-RscMutationExchange -Operation CreateMount`<BR> | [createExchangeMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateOnDemandBackup |  | `New-RscMutationExchange -Operation CreateOnDemandBackup`<BR> | [createOnDemandExchangeBackup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteSnapshotMount |  | `New-RscMutationExchange -Operation DeleteSnapshotMount`<BR> | [deleteExchangeSnapshotMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Fileset domain

Domain key: Fileset

Cmdlets: `New-RscQueryFileset` and `New-RscMutationFileset`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Linux |  | `New-RscQueryFileset -Operation Linux`<BR> | [linuxFileset](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RequestStatus |  | `New-RscQueryFileset -Operation RequestStatus`<BR> | [filesetRequestStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Share |  | `New-RscQueryFileset -Operation Share`<BR> | [shareFileset](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Template |  | `New-RscQueryFileset -Operation Template`<BR> | [filesetTemplate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Templates |  | `New-RscQueryFileset -Operation Templates`<BR> | [filesetTemplates](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Windows |  | `New-RscQueryFileset -Operation Windows`<BR> | [windowsFileset](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| BulkCreate |  | `New-RscMutationFileset -Operation BulkCreate`<BR> | [bulkCreateFilesets](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BulkCreateTemplates |  | `New-RscMutationFileset -Operation BulkCreateTemplates`<BR> | [bulkCreateFilesetTemplates](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BulkDelete |  | `New-RscMutationFileset -Operation BulkDelete`<BR> | [bulkDeleteFileset](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BulkDeleteTemplate |  | `New-RscMutationFileset -Operation BulkDeleteTemplate`<BR> | [bulkDeleteFilesetTemplate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BulkUpdateTemplate |  | `New-RscMutationFileset -Operation BulkUpdateTemplate`<BR> | [bulkUpdateFilesetTemplate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RecoverFiles |  | `New-RscMutationFileset -Operation RecoverFiles`<BR> | [filesetRecoverFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Google Cloud Platform domain

Domain key: Gcp

Cmdlets: `New-RscQueryGcp` and `New-RscMutationGcp`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| CloudAccountMissingPermissionsForAddition |  | `New-RscQueryGcp -Operation CloudAccountMissingPermissionsForAddition`<BR> | [allGcpCloudAccountMissingPermissionsForAddition](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountProjectsByFeature |  | `New-RscQueryGcp -Operation CloudAccountProjectsByFeature`<BR> | [allGcpCloudAccountProjectsByFeature](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountProjectsForOauth |  | `New-RscQueryGcp -Operation CloudAccountProjectsForOauth`<BR> | [allGcpCloudAccountProjectsForOauth](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| FeaturePermissionsForCloudAccount |  | `New-RscQueryGcp -Operation FeaturePermissionsForCloudAccount`<BR> | [allFeaturePermissionsForGcpCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| GetDefaultCredentialsServiceAccount |  | `New-RscQueryGcp -Operation GetDefaultCredentialsServiceAccount`<BR> | [gcpGetDefaultCredentialsServiceAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| NativeAvailableKmsCryptoKeys |  | `New-RscQueryGcp -Operation NativeAvailableKmsCryptoKeys`<BR> | [allGcpNativeAvailableKmsCryptoKeys](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| NativeCompatibleMachineTypes |  | `New-RscQueryGcp -Operation NativeCompatibleMachineTypes`<BR> | [allGcpNativeCompatibleMachineTypes](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| NativeNetworks |  | `New-RscQueryGcp -Operation NativeNetworks`<BR> | [allGcpNativeNetworks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| NativeProjectsWithAccessibleNetworks |  | `New-RscQueryGcp -Operation NativeProjectsWithAccessibleNetworks`<BR> | [allGcpNativeProjectsWithAccessibleNetworks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| NativeRegions |  | `New-RscQueryGcp -Operation NativeRegions`<BR> | [allGcpNativeRegions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| NativeStoredMachineTypes |  | `New-RscQueryGcp -Operation NativeStoredMachineTypes`<BR> | [allGcpNativeStoredMachineTypes](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| NativeStoredMachineTypesInProject |  | `New-RscQueryGcp -Operation NativeStoredMachineTypesInProject`<BR> | [allGcpNativeStoredMachineTypesInProject](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| NativeStoredNetworkNames |  | `New-RscQueryGcp -Operation NativeStoredNetworkNames`<BR> | [allGcpNativeStoredNetworkNames](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| NativeStoredNetworkNamesInProject |  | `New-RscQueryGcp -Operation NativeStoredNetworkNamesInProject`<BR> | [allGcpNativeStoredNetworkNamesInProject](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| NativeStoredRegions |  | `New-RscQueryGcp -Operation NativeStoredRegions`<BR> | [allGcpNativeStoredRegions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| NativeStoredRegionsInProject |  | `New-RscQueryGcp -Operation NativeStoredRegionsInProject`<BR> | [allGcpNativeStoredRegionsInProject](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| CloudAccountAddManualAuthProject |  | `New-RscMutationGcp -Operation CloudAccountAddManualAuthProject`<BR> | [gcpCloudAccountAddManualAuthProject](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountAddProjects |  | `New-RscMutationGcp -Operation CloudAccountAddProjects`<BR> | [gcpCloudAccountAddProjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountDeleteProjects |  | `New-RscMutationGcp -Operation CloudAccountDeleteProjects`<BR> | [gcpCloudAccountDeleteProjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountOauthComplete |  | `New-RscMutationGcp -Operation CloudAccountOauthComplete`<BR> | [gcpCloudAccountOauthComplete](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountOauthInitiate |  | `New-RscMutationGcp -Operation CloudAccountOauthInitiate`<BR> | [gcpCloudAccountOauthInitiate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CloudAccountUpgradeProjects |  | `New-RscMutationGcp -Operation CloudAccountUpgradeProjects`<BR> | [gcpCloudAccountUpgradeProjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateReaderTarget |  | `New-RscMutationGcp -Operation CreateReaderTarget`<BR> | [createGcpReaderTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateTarget |  | `New-RscMutationGcp -Operation CreateTarget`<BR> | [createGcpTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SetDefaultServiceAccountJwtConfig |  | `New-RscMutationGcp -Operation SetDefaultServiceAccountJwtConfig`<BR> | [gcpSetDefaultServiceAccountJwtConfig](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateTarget |  | `New-RscMutationGcp -Operation UpdateTarget`<BR> | [updateGcpTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpgradeCloudAccountPermissionsWithoutOauth |  | `New-RscMutationGcp -Operation UpgradeCloudAccountPermissionsWithoutOauth`<BR> | [upgradeGcpCloudAccountPermissionsWithoutOauth](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Google Cloud Platform Native domain

Domain key: GcpNative

Cmdlets: `New-RscQueryGcpNative` and `New-RscMutationGcpNative`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Disk |  | `New-RscQueryGcpNative -Operation Disk`<BR> | [gcpNativeDisk](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Disks |  | `New-RscQueryGcpNative -Operation Disks`<BR> | [gcpNativeDisks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| GceInstance |  | `New-RscQueryGcpNative -Operation GceInstance`<BR> | [gcpNativeGceInstance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| GceInstances |  | `New-RscQueryGcpNative -Operation GceInstances`<BR> | [gcpNativeGceInstances](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Project |  | `New-RscQueryGcpNative -Operation Project`<BR> | [gcpNativeProject](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Projects |  | `New-RscQueryGcpNative -Operation Projects`<BR> | [gcpNativeProjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StoredDiskLocations |  | `New-RscQueryGcpNative -Operation StoredDiskLocations`<BR> | [gcpNativeStoredDiskLocations](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| DisableProject |  | `New-RscMutationGcpNative -Operation DisableProject`<BR> | [gcpNativeDisableProject](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExcludeDisksFromInstanceSnapshot |  | `New-RscMutationGcpNative -Operation ExcludeDisksFromInstanceSnapshot`<BR> | [gcpNativeExcludeDisksFromInstanceSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExportDisk |  | `New-RscMutationGcpNative -Operation ExportDisk`<BR> | [gcpNativeExportDisk](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExportGceInstance |  | `New-RscMutationGcpNative -Operation ExportGceInstance`<BR> | [gcpNativeExportGceInstance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RefreshProjects |  | `New-RscMutationGcpNative -Operation RefreshProjects`<BR> | [gcpNativeRefreshProjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RestoreGceInstance |  | `New-RscMutationGcpNative -Operation RestoreGceInstance`<BR> | [gcpNativeRestoreGceInstance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Host domain

Domain key: Host

Cmdlets: `New-RscQueryHost` and `New-RscMutationHost`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Diagnosis |  | `New-RscQueryHost -Operation Diagnosis`<BR> | [hostDiagnosis](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PhysicalHost |  | `New-RscQueryHost -Operation PhysicalHost`<BR> | [physicalHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PhysicalHosts |  | `New-RscQueryHost -Operation PhysicalHosts`<BR> | [physicalHosts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Search |  | `New-RscQueryHost -Operation Search`<BR> | [searchHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Share |  | `New-RscQueryHost -Operation Share`<BR> | [hostShare](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Shares |  | `New-RscQueryHost -Operation Shares`<BR> | [hostShares](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| BulkDelete |  | `New-RscMutationHost -Operation BulkDelete`<BR> | [bulkDeleteHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BulkRefresh |  | `New-RscMutationHost -Operation BulkRefresh`<BR> | [bulkRefreshHosts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BulkRegister |  | `New-RscMutationHost -Operation BulkRegister`<BR> | [bulkRegisterHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BulkUpdate |  | `New-RscMutationHost -Operation BulkUpdate`<BR> | [bulkUpdateHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ChangeVfd |  | `New-RscMutationHost -Operation ChangeVfd`<BR> | [changeVfdOnHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Refresh |  | `New-RscMutationHost -Operation Refresh`<BR> | [refreshHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Microsoft Hyper-V domain

Domain key: Hyperv

Cmdlets: `New-RscQueryHyperv` and `New-RscMutationHyperv`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Cluster |  | `New-RscQueryHyperv -Operation Cluster`<BR> | [hypervCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| HostAsyncRequestStatus |  | `New-RscQueryHyperv -Operation HostAsyncRequestStatus`<BR> | [hypervHostAsyncRequestStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Mounts |  | `New-RscQueryHyperv -Operation Mounts`<BR> | [hypervMounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Scvmm |  | `New-RscQueryHyperv -Operation Scvmm`<BR> | [hypervScvmm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ScvmmAsyncRequestStatus |  | `New-RscQueryHyperv -Operation ScvmmAsyncRequestStatus`<BR> | [hypervScvmmAsyncRequestStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Scvmms |  | `New-RscQueryHyperv -Operation Scvmms`<BR> | [hypervScvmms](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Server |  | `New-RscQueryHyperv -Operation Server`<BR> | [hypervServer](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Servers |  | `New-RscQueryHyperv -Operation Servers`<BR> | [hypervServers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TopLevelDescendants |  | `New-RscQueryHyperv -Operation TopLevelDescendants`<BR> | [hypervTopLevelDescendants](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UniqueServersCount |  | `New-RscQueryHyperv -Operation UniqueServersCount`<BR> | [uniqueHypervServersCount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| VirtualMachine |  | `New-RscQueryHyperv -Operation VirtualMachine`<BR> | [hypervVirtualMachine](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| VirtualMachineAsyncRequestStatus |  | `New-RscQueryHyperv -Operation VirtualMachineAsyncRequestStatus`<BR> | [hypervVirtualMachineAsyncRequestStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| VirtualMachines |  | `New-RscQueryHyperv -Operation VirtualMachines`<BR> | [hypervVirtualMachines](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| VmDetail |  | `New-RscQueryHyperv -Operation VmDetail`<BR> | [hypervVmDetail](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| BatchExportVm |  | `New-RscMutationHyperv -Operation BatchExportVm`<BR> | [batchExportHypervVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BatchInstantRecoverVm |  | `New-RscMutationHyperv -Operation BatchInstantRecoverVm`<BR> | [batchInstantRecoverHypervVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BatchMountVm |  | `New-RscMutationHyperv -Operation BatchMountVm`<BR> | [batchMountHypervVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BatchOnDemandBackupVm |  | `New-RscMutationHyperv -Operation BatchOnDemandBackupVm`<BR> | [batchOnDemandBackupHypervVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateVirtualMachineSnapshotMount |  | `New-RscMutationHyperv -Operation CreateVirtualMachineSnapshotMount`<BR> | [createHypervVirtualMachineSnapshotMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteAllSnapshots |  | `New-RscMutationHyperv -Operation DeleteAllSnapshots`<BR> | [hypervDeleteAllSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteVirtualMachineSnapshot |  | `New-RscMutationHyperv -Operation DeleteVirtualMachineSnapshot`<BR> | [deleteHypervVirtualMachineSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteVirtualMachineSnapshotMount |  | `New-RscMutationHyperv -Operation DeleteVirtualMachineSnapshotMount`<BR> | [deleteHypervVirtualMachineSnapshotMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DownloadSnapshotFromLocation |  | `New-RscMutationHyperv -Operation DownloadSnapshotFromLocation`<BR> | [downloadHypervSnapshotFromLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DownloadVirtualMachineSnapshot |  | `New-RscMutationHyperv -Operation DownloadVirtualMachineSnapshot`<BR> | [downloadHypervVirtualMachineSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DownloadVirtualMachineSnapshotFiles |  | `New-RscMutationHyperv -Operation DownloadVirtualMachineSnapshotFiles`<BR> | [downloadHypervVirtualMachineSnapshotFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExportVirtualMachine |  | `New-RscMutationHyperv -Operation ExportVirtualMachine`<BR> | [exportHypervVirtualMachine](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| InstantRecoverVirtualMachineSnapshot |  | `New-RscMutationHyperv -Operation InstantRecoverVirtualMachineSnapshot`<BR> | [instantRecoverHypervVirtualMachineSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| OnDemandSnapshot |  | `New-RscMutationHyperv -Operation OnDemandSnapshot`<BR> | [hypervOnDemandSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RefreshScvmm |  | `New-RscMutationHyperv -Operation RefreshScvmm`<BR> | [refreshHypervScvmm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RefreshServer |  | `New-RscMutationHyperv -Operation RefreshServer`<BR> | [refreshHypervServer](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RegisterAgentVirtualMachine |  | `New-RscMutationHyperv -Operation RegisterAgentVirtualMachine`<BR> | [registerAgentHypervVirtualMachine](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RegisterScvmm |  | `New-RscMutationHyperv -Operation RegisterScvmm`<BR> | [registerHypervScvmm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RestoreVirtualMachineSnapshotFiles |  | `New-RscMutationHyperv -Operation RestoreVirtualMachineSnapshotFiles`<BR> | [restoreHypervVirtualMachineSnapshotFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ScvmmDelete |  | `New-RscMutationHyperv -Operation ScvmmDelete`<BR> | [hypervScvmmDelete](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ScvmmUpdate |  | `New-RscMutationHyperv -Operation ScvmmUpdate`<BR> | [hypervScvmmUpdate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateVirtualMachine |  | `New-RscMutationHyperv -Operation UpdateVirtualMachine`<BR> | [updateHypervVirtualMachine](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateVirtualMachineSnapshotMount |  | `New-RscMutationHyperv -Operation UpdateVirtualMachineSnapshotMount`<BR> | [updateHypervVirtualMachineSnapshotMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Kubernetes domain

Domain key: K8s

Cmdlets: `New-RscQueryK8s` and `New-RscMutationK8s`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AppManifest |  | `New-RscQueryK8s -Operation AppManifest`<BR> | [k8sAppManifest](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Cluster |  | `New-RscQueryK8s -Operation Cluster`<BR> | [k8sCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Clusters |  | `New-RscQueryK8s -Operation Clusters`<BR> | [k8sClusters](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Namespace |  | `New-RscQueryK8s -Operation Namespace`<BR> | [k8sNamespace](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Namespaces |  | `New-RscQueryK8s -Operation Namespaces`<BR> | [k8sNamespaces](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ReplicaSnapshotInfos |  | `New-RscQueryK8s -Operation ReplicaSnapshotInfos`<BR> | [allK8sReplicaSnapshotInfos](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SnapshotInfo |  | `New-RscQueryK8s -Operation SnapshotInfo`<BR> | [k8sSnapshotInfo](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| ArchiveCluster |  | `New-RscMutationK8s -Operation ArchiveCluster`<BR> | [archiveK8sCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateAgentManifest |  | `New-RscMutationK8s -Operation CreateAgentManifest`<BR> | [createK8sAgentManifest](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateCluster |  | `New-RscMutationK8s -Operation CreateCluster`<BR> | [createK8sCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateNamespaceSnapshots |  | `New-RscMutationK8s -Operation CreateNamespaceSnapshots`<BR> | [createK8sNamespaceSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExportNamespace |  | `New-RscMutationK8s -Operation ExportNamespace`<BR> | [exportK8sNamespace](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RefreshCluster |  | `New-RscMutationK8s -Operation RefreshCluster`<BR> | [refreshK8sCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RestoreNamespace |  | `New-RscMutationK8s -Operation RestoreNamespace`<BR> | [restoreK8sNamespace](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## LDAP domain

Domain key: Ldap

Cmdlets: `New-RscQueryLdap` and `New-RscMutationLdap`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AuthorizedPrincipalList |  | `New-RscQueryLdap -Operation AuthorizedPrincipalList`<BR> | [ldapAuthorizedPrincipalConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| IntegrationList |  | `New-RscQueryLdap -Operation IntegrationList`<BR> | [ldapIntegrationConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PrincipalList |  | `New-RscQueryLdap -Operation PrincipalList`<BR> | [ldapPrincipalConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| DeletePrincipals |  | `New-RscMutationLdap -Operation DeletePrincipals`<BR> | [deleteLdapPrincipals](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RemoveIntegration |  | `New-RscMutationLdap -Operation RemoveIntegration`<BR> | [removeLdapIntegration](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SetMfaSetting |  | `New-RscMutationLdap -Operation SetMfaSetting`<BR> | [setLdapMfaSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateIntegration |  | `New-RscMutationLdap -Operation UpdateIntegration`<BR> | [updateLdapIntegration](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Microsoft 365 domain

Domain key: M365

Cmdlets: `New-RscQueryM365` and `New-RscMutationM365`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Regions |  | `New-RscQueryM365 -Operation Regions`<BR> | [m365Regions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| BackupMailbox |  | `New-RscMutationM365 -Operation BackupMailbox`<BR> | [backupM365Mailbox](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BackupOnedrive |  | `New-RscMutationM365 -Operation BackupOnedrive`<BR> | [backupM365Onedrive](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BackupSharepointDrive |  | `New-RscMutationM365 -Operation BackupSharepointDrive`<BR> | [backupM365SharepointDrive](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BackupTeam |  | `New-RscMutationM365 -Operation BackupTeam`<BR> | [backupM365Team](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Managed Volume domain

Domain key: ManagedVolume

Cmdlets: `New-RscQueryManagedVolume` and `New-RscMutationManagedVolume`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| InventoryStats |  | `New-RscQueryManagedVolume -Operation InventoryStats`<BR> | [managedVolumeInventoryStats](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| LiveMounts |  | `New-RscQueryManagedVolume -Operation LiveMounts`<BR> | [managedVolumeLiveMounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ManagedVolume |  | `New-RscQueryManagedVolume -Operation ManagedVolume`<BR> | [managedVolume](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ManagedVolumes |  | `New-RscQueryManagedVolume -Operation ManagedVolumes`<BR> | [managedVolumes](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Add |  | `New-RscMutationManagedVolume -Operation Add`<BR> | [addManagedVolume](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BeginSnapshot |  | `New-RscMutationManagedVolume -Operation BeginSnapshot`<BR> | [beginManagedVolumeSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Delete |  | `New-RscMutationManagedVolume -Operation Delete`<BR> | [deleteManagedVolume](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteSnapshotExport |  | `New-RscMutationManagedVolume -Operation DeleteSnapshotExport`<BR> | [deleteManagedVolumeSnapshotExport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DownloadFiles |  | `New-RscMutationManagedVolume -Operation DownloadFiles`<BR> | [downloadManagedVolumeFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DownloadFromLocation |  | `New-RscMutationManagedVolume -Operation DownloadFromLocation`<BR> | [downloadManagedVolumeFromLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| EndSnapshot |  | `New-RscMutationManagedVolume -Operation EndSnapshot`<BR> | [endManagedVolumeSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExportSnapshot |  | `New-RscMutationManagedVolume -Operation ExportSnapshot`<BR> | [exportManagedVolumeSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Resize |  | `New-RscMutationManagedVolume -Operation Resize`<BR> | [resizeManagedVolume](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TakeOnDemandSnapshot |  | `New-RscMutationManagedVolume -Operation TakeOnDemandSnapshot`<BR> | [takeManagedVolumeOnDemandSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Update |  | `New-RscMutationManagedVolume -Operation Update`<BR> | [updateManagedVolume](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Mongo DB domain

Domain key: Mongo

Cmdlets: `New-RscQueryMongo` and `New-RscMutationMongo`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| BulkRecoverableRange |  | `New-RscQueryMongo -Operation BulkRecoverableRange`<BR> | [mongodbBulkRecoverableRange](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BulkRecoverableRanges |  | `New-RscQueryMongo -Operation BulkRecoverableRanges`<BR> | [mongoBulkRecoverableRanges](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Collection |  | `New-RscQueryMongo -Operation Collection`<BR> | [mongoCollection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CollectionRecoverableRange |  | `New-RscQueryMongo -Operation CollectionRecoverableRange`<BR> | [mongodbCollectionRecoverableRange](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Collections |  | `New-RscQueryMongo -Operation Collections`<BR> | [mongoCollections](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Database |  | `New-RscQueryMongo -Operation Database`<BR> | [mongoDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Databases |  | `New-RscQueryMongo -Operation Databases`<BR> | [mongoDatabases](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RecoverableRanges |  | `New-RscQueryMongo -Operation RecoverableRanges`<BR> | [mongoRecoverableRanges](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Source |  | `New-RscQueryMongo -Operation Source`<BR> | [mongoSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Sources |  | `New-RscQueryMongo -Operation Sources`<BR> | [mongoSources](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AddSource |  | `New-RscMutationMongo -Operation AddSource`<BR> | [addMongoSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| AssignSlaToCollection |  | `New-RscMutationMongo -Operation AssignSlaToCollection`<BR> | [assignSlaToMongoDbCollection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BulkDeleteSources |  | `New-RscMutationMongo -Operation BulkDeleteSources`<BR> | [bulkDeleteMongodbSources](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateSource |  | `New-RscMutationMongo -Operation CreateSource`<BR> | [createMongodbSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteSource |  | `New-RscMutationMongo -Operation DeleteSource`<BR> | [deleteMongoSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DiscoverSource |  | `New-RscMutationMongo -Operation DiscoverSource`<BR> | [discoverMongoSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PatchSource |  | `New-RscMutationMongo -Operation PatchSource`<BR> | [patchMongoSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RecoverSource |  | `New-RscMutationMongo -Operation RecoverSource`<BR> | [recoverMongoSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RetryAddSource |  | `New-RscMutationMongo -Operation RetryAddSource`<BR> | [retryAddMongoSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateSource |  | `New-RscMutationMongo -Operation UpdateSource`<BR> | [updateMongodbSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Mosaic domain

Domain key: Mosaic

Cmdlets: `New-RscQueryMosaic` and `New-RscMutationMosaic`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| BulkRecoveryRange |  | `New-RscQueryMosaic -Operation BulkRecoveryRange`<BR> | [mosaicBulkRecoveryRange](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Snapshots |  | `New-RscQueryMosaic -Operation Snapshots`<BR> | [mosaicSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Stores |  | `New-RscQueryMosaic -Operation Stores`<BR> | [mosaicStores](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Versions |  | `New-RscQueryMosaic -Operation Versions`<BR> | [mosaicVersions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AddStore |  | `New-RscMutationMosaic -Operation AddStore`<BR> | [addMosaicStore](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteStore |  | `New-RscMutationMosaic -Operation DeleteStore`<BR> | [deleteMosaicStore](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateStore |  | `New-RscMutationMosaic -Operation UpdateStore`<BR> | [updateMosaicStore](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Microsoft SQL Server domain

Domain key: Mssql

Cmdlets: `New-RscQueryMssql` and `New-RscMutationMssql`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AvailabilityGroup |  | `New-RscQueryMssql -Operation AvailabilityGroup`<BR> | [mssqlAvailabilityGroup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CdmLogShippingTarget |  | `New-RscQueryMssql -Operation CdmLogShippingTarget`<BR> | [cdmMssqlLogShippingTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CdmLogShippingTargets |  | `New-RscQueryMssql -Operation CdmLogShippingTargets`<BR> | [cdmMssqlLogShippingTargets](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CompatibleInstances |  | `New-RscQueryMssql -Operation CompatibleInstances`<BR> | [mssqlCompatibleInstances](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Database |  | `New-RscQueryMssql -Operation Database`<BR> | [mssqlDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DatabaseLiveMounts |  | `New-RscQueryMssql -Operation DatabaseLiveMounts`<BR> | [mssqlDatabaseLiveMounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DatabaseMissedRecoverableRanges |  | `New-RscQueryMssql -Operation DatabaseMissedRecoverableRanges`<BR> | [mssqlDatabaseMissedRecoverableRanges](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DatabaseMissedSnapshots |  | `New-RscQueryMssql -Operation DatabaseMissedSnapshots`<BR> | [mssqlDatabaseMissedSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DatabaseRestoreEstimate |  | `New-RscQueryMssql -Operation DatabaseRestoreEstimate`<BR> | [mssqlDatabaseRestoreEstimate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DatabaseRestoreFiles |  | `New-RscQueryMssql -Operation DatabaseRestoreFiles`<BR> | [allMssqlDatabaseRestoreFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Databases |  | `New-RscQueryMssql -Operation Databases`<BR> | [mssqlDatabases](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DefaultProperties |  | `New-RscQueryMssql -Operation DefaultProperties`<BR> | [mssqlDefaultProperties](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Instance |  | `New-RscQueryMssql -Operation Instance`<BR> | [mssqlInstance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| LogShippingTargets |  | `New-RscQueryMssql -Operation LogShippingTargets`<BR> | [mssqlLogShippingTargets](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RecoverableRanges |  | `New-RscQueryMssql -Operation RecoverableRanges`<BR> | [mssqlRecoverableRanges](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TopLevelDescendants |  | `New-RscQueryMssql -Operation TopLevelDescendants`<BR> | [mssqlTopLevelDescendants](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AssignSlaDomainProperties |  | `New-RscMutationMssql -Operation AssignSlaDomainProperties`<BR> | [assignMssqlSlaDomainProperties](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| AssignSlaDomainPropertiesAsync |  | `New-RscMutationMssql -Operation AssignSlaDomainPropertiesAsync`<BR> | [assignMssqlSlaDomainPropertiesAsync](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BrowseDatabaseSnapshot |  | `New-RscMutationMssql -Operation BrowseDatabaseSnapshot`<BR> | [browseMssqlDatabaseSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BulkCreateOnDemandBackup |  | `New-RscMutationMssql -Operation BulkCreateOnDemandBackup`<BR> | [bulkCreateOnDemandMssqlBackup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BulkUpdateDbs |  | `New-RscMutationMssql -Operation BulkUpdateDbs`<BR> | [bulkUpdateMssqlDbs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateLiveMount |  | `New-RscMutationMssql -Operation CreateLiveMount`<BR> | [createMssqlLiveMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateLogShippingConfiguration |  | `New-RscMutationMssql -Operation CreateLogShippingConfiguration`<BR> | [createMssqlLogShippingConfiguration](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateOnDemandBackup |  | `New-RscMutationMssql -Operation CreateOnDemandBackup`<BR> | [createOnDemandMssqlBackup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteDbSnapshots |  | `New-RscMutationMssql -Operation DeleteDbSnapshots`<BR> | [deleteMssqlDbSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteLiveMount |  | `New-RscMutationMssql -Operation DeleteLiveMount`<BR> | [deleteMssqlLiveMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DownloadDatabaseBackupFiles |  | `New-RscMutationMssql -Operation DownloadDatabaseBackupFiles`<BR> | [downloadMssqlDatabaseBackupFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DownloadDatabaseFilesFromArchivalLocation |  | `New-RscMutationMssql -Operation DownloadDatabaseFilesFromArchivalLocation`<BR> | [downloadMssqlDatabaseFilesFromArchivalLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExportDatabase |  | `New-RscMutationMssql -Operation ExportDatabase`<BR> | [exportMssqlDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RestoreDatabase |  | `New-RscMutationMssql -Operation RestoreDatabase`<BR> | [restoreMssqlDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TakeLogBackup |  | `New-RscMutationMssql -Operation TakeLogBackup`<BR> | [takeMssqlLogBackup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateDefaultProperties |  | `New-RscMutationMssql -Operation UpdateDefaultProperties`<BR> | [updateMssqlDefaultProperties](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateLogShippingConfiguration |  | `New-RscMutationMssql -Operation UpdateLogShippingConfiguration`<BR> | [updateMssqlLogShippingConfiguration](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## NAS domain

Domain key: Nas

Cmdlets: `New-RscQueryNas` and `New-RscMutationNas`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Fileset |  | `New-RscQueryNas -Operation Fileset`<BR> | [nasFileset](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Namespace |  | `New-RscQueryNas -Operation Namespace`<BR> | [nasNamespace](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Namespaces |  | `New-RscQueryNas -Operation Namespaces`<BR> | [nasNamespaces](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Share |  | `New-RscQueryNas -Operation Share`<BR> | [nasShare](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| System |  | `New-RscQueryNas -Operation System`<BR> | [nasSystem](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Systems |  | `New-RscQueryNas -Operation Systems`<BR> | [nasSystems](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TopLevelDescendants |  | `New-RscQueryNas -Operation TopLevelDescendants`<BR> | [nasTopLevelDescendants](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Volume |  | `New-RscQueryNas -Operation Volume`<BR> | [nasVolume](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

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
| CreateReaderTarget |  | `New-RscMutationNfs -Operation CreateReaderTarget`<BR> | [createNfsReaderTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateTarget |  | `New-RscMutationNfs -Operation CreateTarget`<BR> | [createNfsTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateTarget |  | `New-RscMutationNfs -Operation UpdateTarget`<BR> | [updateNfsTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Nutanix domain

Domain key: Nutanix

Cmdlets: `New-RscQueryNutanix` and `New-RscMutationNutanix`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| BrowseSnapshot |  | `New-RscQueryNutanix -Operation BrowseSnapshot`<BR> | [nutanixBrowseSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Category |  | `New-RscQueryNutanix -Operation Category`<BR> | [nutanixCategory](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CategoryValue |  | `New-RscQueryNutanix -Operation CategoryValue`<BR> | [nutanixCategoryValue](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Cluster |  | `New-RscQueryNutanix -Operation Cluster`<BR> | [nutanixCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ClusterAsyncRequestStatus |  | `New-RscQueryNutanix -Operation ClusterAsyncRequestStatus`<BR> | [nutanixClusterAsyncRequestStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ClusterContainers |  | `New-RscQueryNutanix -Operation ClusterContainers`<BR> | [nutanixClusterContainers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ClusterNetworks |  | `New-RscQueryNutanix -Operation ClusterNetworks`<BR> | [nutanixClusterNetworks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Clusters |  | `New-RscQueryNutanix -Operation Clusters`<BR> | [nutanixClusters](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Mounts |  | `New-RscQueryNutanix -Operation Mounts`<BR> | [nutanixMounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PrismCentral |  | `New-RscQueryNutanix -Operation PrismCentral`<BR> | [nutanixPrismCentral](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PrismCentrals |  | `New-RscQueryNutanix -Operation PrismCentrals`<BR> | [nutanixPrismCentrals](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SearchVm |  | `New-RscQueryNutanix -Operation SearchVm`<BR> | [searchNutanixVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SnapshotDetail |  | `New-RscQueryNutanix -Operation SnapshotDetail`<BR> | [nutanixSnapshotDetail](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TopLevelDescendants |  | `New-RscQueryNutanix -Operation TopLevelDescendants`<BR> | [nutanixTopLevelDescendants](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Vm |  | `New-RscQueryNutanix -Operation Vm`<BR> | [nutanixVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| VmAsyncRequestStatus |  | `New-RscQueryNutanix -Operation VmAsyncRequestStatus`<BR> | [nutanixVmAsyncRequestStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| VmMissedSnapshots |  | `New-RscQueryNutanix -Operation VmMissedSnapshots`<BR> | [nutanixVmMissedSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Vms |  | `New-RscQueryNutanix -Operation Vms`<BR> | [nutanixVms](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| BatchExportVm |  | `New-RscMutationNutanix -Operation BatchExportVm`<BR> | [batchExportNutanixVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BatchMountVm |  | `New-RscMutationNutanix -Operation BatchMountVm`<BR> | [batchMountNutanixVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BulkOnDemandSnapshotVm |  | `New-RscMutationNutanix -Operation BulkOnDemandSnapshotVm`<BR> | [bulkOnDemandSnapshotNutanixVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateCluster |  | `New-RscMutationNutanix -Operation CreateCluster`<BR> | [createNutanixCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateOnDemandBackup |  | `New-RscMutationNutanix -Operation CreateOnDemandBackup`<BR> | [createOnDemandNutanixBackup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreatePrismCentral |  | `New-RscMutationNutanix -Operation CreatePrismCentral`<BR> | [createNutanixPrismCentral](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteCluster |  | `New-RscMutationNutanix -Operation DeleteCluster`<BR> | [deleteNutanixCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteMountV1 |  | `New-RscMutationNutanix -Operation DeleteMountV1`<BR> | [deleteNutanixMountV1](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeletePrismCentral |  | `New-RscMutationNutanix -Operation DeletePrismCentral`<BR> | [deleteNutanixPrismCentral](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteSnapshot |  | `New-RscMutationNutanix -Operation DeleteSnapshot`<BR> | [deleteNutanixSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteSnapshots |  | `New-RscMutationNutanix -Operation DeleteSnapshots`<BR> | [deleteNutanixSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DownloadFilesSnapshot |  | `New-RscMutationNutanix -Operation DownloadFilesSnapshot`<BR> | [downloadFilesNutanixSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DownloadSnapshot |  | `New-RscMutationNutanix -Operation DownloadSnapshot`<BR> | [downloadNutanixSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DownloadVmFromLocation |  | `New-RscMutationNutanix -Operation DownloadVmFromLocation`<BR> | [downloadNutanixVmFromLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExportSnapshot |  | `New-RscMutationNutanix -Operation ExportSnapshot`<BR> | [exportNutanixSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| MigrateMountV1 |  | `New-RscMutationNutanix -Operation MigrateMountV1`<BR> | [migrateNutanixMountV1](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| MountSnapshotV1 |  | `New-RscMutationNutanix -Operation MountSnapshotV1`<BR> | [mountNutanixSnapshotV1](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PatchMountV1 |  | `New-RscMutationNutanix -Operation PatchMountV1`<BR> | [patchNutanixMountV1](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RefreshCluster |  | `New-RscMutationNutanix -Operation RefreshCluster`<BR> | [refreshNutanixCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RefreshPrismCentral |  | `New-RscMutationNutanix -Operation RefreshPrismCentral`<BR> | [refreshNutanixPrismCentral](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RegisterAgentVm |  | `New-RscMutationNutanix -Operation RegisterAgentVm`<BR> | [registerAgentNutanixVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RestoreFilesSnapshot |  | `New-RscMutationNutanix -Operation RestoreFilesSnapshot`<BR> | [restoreFilesNutanixSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateCluster |  | `New-RscMutationNutanix -Operation UpdateCluster`<BR> | [updateNutanixCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdatePrismCentral |  | `New-RscMutationNutanix -Operation UpdatePrismCentral`<BR> | [updateNutanixPrismCentral](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateVm |  | `New-RscMutationNutanix -Operation UpdateVm`<BR> | [updateNutanixVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Office 365 domain

Domain key: O365

Cmdlets: `New-RscQueryO365` and `New-RscMutationO365`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AdGroups |  | `New-RscQueryO365 -Operation AdGroups`<BR> | [allO365AdGroups](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BrowseTeamConvChannels |  | `New-RscQueryO365 -Operation BrowseTeamConvChannels`<BR> | [browseO365TeamConvChannels](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Calendar |  | `New-RscQueryO365 -Operation Calendar`<BR> | [o365Calendar](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Groups |  | `New-RscQueryO365 -Operation Groups`<BR> | [o365Groups](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| License |  | `New-RscQueryO365 -Operation License`<BR> | [o365License](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ListApps |  | `New-RscQueryO365 -Operation ListApps`<BR> | [listO365Apps](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Mailbox |  | `New-RscQueryO365 -Operation Mailbox`<BR> | [o365Mailbox](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Mailboxes |  | `New-RscQueryO365 -Operation Mailboxes`<BR> | [o365Mailboxes](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ObjectAncestors |  | `New-RscQueryO365 -Operation ObjectAncestors`<BR> | [o365ObjectAncestors](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Onedrive |  | `New-RscQueryO365 -Operation Onedrive`<BR> | [o365Onedrive](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Onedrives |  | `New-RscQueryO365 -Operation Onedrives`<BR> | [o365Onedrives](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Org |  | `New-RscQueryO365 -Operation Org`<BR> | [o365Org](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| OrgAtSnappableLevel |  | `New-RscQueryO365 -Operation OrgAtSnappableLevel`<BR> | [o365OrgAtSnappableLevel](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| OrgStatuses |  | `New-RscQueryO365 -Operation OrgStatuses`<BR> | [allO365OrgStatuses](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| OrgSummaries |  | `New-RscQueryO365 -Operation OrgSummaries`<BR> | [o365OrgSummaries](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Orgs |  | `New-RscQueryO365 -Operation Orgs`<BR> | [o365Orgs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ServiceAccount |  | `New-RscQueryO365 -Operation ServiceAccount`<BR> | [o365ServiceAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ServiceStatus |  | `New-RscQueryO365 -Operation ServiceStatus`<BR> | [o365ServiceStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SharepointDrive |  | `New-RscQueryO365 -Operation SharepointDrive`<BR> | [o365SharepointDrive](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SharepointDrives |  | `New-RscQueryO365 -Operation SharepointDrives`<BR> | [o365SharepointDrives](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SharepointList |  | `New-RscQueryO365 -Operation SharepointList`<BR> | [o365SharepointList](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SharepointLists |  | `New-RscQueryO365 -Operation SharepointLists`<BR> | [o365SharepointLists](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SharepointObjectList |  | `New-RscQueryO365 -Operation SharepointObjectList`<BR> | [o365SharepointObjectList](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SharepointObjects |  | `New-RscQueryO365 -Operation SharepointObjects`<BR> | [o365SharepointObjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SharepointSite |  | `New-RscQueryO365 -Operation SharepointSite`<BR> | [o365SharepointSite](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SharepointSites |  | `New-RscQueryO365 -Operation SharepointSites`<BR> | [o365SharepointSites](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Site |  | `New-RscQueryO365 -Operation Site`<BR> | [o365Site](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Sites |  | `New-RscQueryO365 -Operation Sites`<BR> | [o365Sites](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StorageStats |  | `New-RscQueryO365 -Operation StorageStats`<BR> | [o365StorageStats](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SubscriptionsAppTypeCounts |  | `New-RscQueryO365 -Operation SubscriptionsAppTypeCounts`<BR> | [allO365SubscriptionsAppTypeCounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Team |  | `New-RscQueryO365 -Operation Team`<BR> | [o365Team](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TeamChannels |  | `New-RscQueryO365 -Operation TeamChannels`<BR> | [o365TeamChannels](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TeamConversationsFolderID |  | `New-RscQueryO365 -Operation TeamConversationsFolderID`<BR> | [o365TeamConversationsFolderID](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TeamPostedBy |  | `New-RscQueryO365 -Operation TeamPostedBy`<BR> | [o365TeamPostedBy](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Teams |  | `New-RscQueryO365 -Operation Teams`<BR> | [o365Teams](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| User |  | `New-RscQueryO365 -Operation User`<BR> | [o365User](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UserObjects |  | `New-RscQueryO365 -Operation UserObjects`<BR> | [o365UserObjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AddOrg |  | `New-RscMutationO365 -Operation AddOrg`<BR> | [addO365Org](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BackupMailbox |  | `New-RscMutationO365 -Operation BackupMailbox`<BR> | [backupO365Mailbox](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BackupOnedrive |  | `New-RscMutationO365 -Operation BackupOnedrive`<BR> | [backupO365Onedrive](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BackupSharePointSite |  | `New-RscMutationO365 -Operation BackupSharePointSite`<BR> | [backupO365SharePointSite](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BackupSharepointDrive |  | `New-RscMutationO365 -Operation BackupSharepointDrive`<BR> | [backupO365SharepointDrive](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BackupSharepointList |  | `New-RscMutationO365 -Operation BackupSharepointList`<BR> | [backupO365SharepointList](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BackupTeam |  | `New-RscMutationO365 -Operation BackupTeam`<BR> | [backupO365Team](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateAppComplete |  | `New-RscMutationO365 -Operation CreateAppComplete`<BR> | [createO365AppComplete](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateAppKickoff |  | `New-RscMutationO365 -Operation CreateAppKickoff`<BR> | [createO365AppKickoff](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteAzureApp |  | `New-RscMutationO365 -Operation DeleteAzureApp`<BR> | [deleteO365AzureApp](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteOrg |  | `New-RscMutationO365 -Operation DeleteOrg`<BR> | [deleteO365Org](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteServiceAccount |  | `New-RscMutationO365 -Operation DeleteServiceAccount`<BR> | [deleteO365ServiceAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| EnableSharePoint |  | `New-RscMutationO365 -Operation EnableSharePoint`<BR> | [enableO365SharePoint](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| EnableTeams |  | `New-RscMutationO365 -Operation EnableTeams`<BR> | [enableO365Teams](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExportMailbox |  | `New-RscMutationO365 -Operation ExportMailbox`<BR> | [exportO365Mailbox](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| InsertCustomerApp |  | `New-RscMutationO365 -Operation InsertCustomerApp`<BR> | [insertCustomerO365App](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| OauthConsentComplete |  | `New-RscMutationO365 -Operation OauthConsentComplete`<BR> | [o365OauthConsentComplete](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| OauthConsentKickoff |  | `New-RscMutationO365 -Operation OauthConsentKickoff`<BR> | [o365OauthConsentKickoff](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PdlGroups |  | `New-RscMutationO365 -Operation PdlGroups`<BR> | [o365PdlGroups](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RefreshOrg |  | `New-RscMutationO365 -Operation RefreshOrg`<BR> | [refreshO365Org](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RestoreMailbox |  | `New-RscMutationO365 -Operation RestoreMailbox`<BR> | [restoreO365Mailbox](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RestoreSnappable |  | `New-RscMutationO365 -Operation RestoreSnappable`<BR> | [restoreO365Snappable](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RestoreTeamsConversations |  | `New-RscMutationO365 -Operation RestoreTeamsConversations`<BR> | [restoreO365TeamsConversations](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RestoreTeamsFiles |  | `New-RscMutationO365 -Operation RestoreTeamsFiles`<BR> | [restoreO365TeamsFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SaaSSetupKickoff |  | `New-RscMutationO365 -Operation SaaSSetupKickoff`<BR> | [o365SaaSSetupKickoff](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SaasSetupComplete |  | `New-RscMutationO365 -Operation SaasSetupComplete`<BR> | [o365SaasSetupComplete](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SetServiceAccount |  | `New-RscMutationO365 -Operation SetServiceAccount`<BR> | [setO365ServiceAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SetupKickoff |  | `New-RscMutationO365 -Operation SetupKickoff`<BR> | [o365SetupKickoff](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateAppAuthStatus |  | `New-RscMutationO365 -Operation UpdateAppAuthStatus`<BR> | [updateO365AppAuthStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateAppPermissions |  | `New-RscMutationO365 -Operation UpdateAppPermissions`<BR> | [updateO365AppPermissions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateOrgCustomName |  | `New-RscMutationO365 -Operation UpdateOrgCustomName`<BR> | [updateO365OrgCustomName](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Oracle domain

Domain key: Oracle

Cmdlets: `New-RscQueryOracle` and `New-RscMutationOracle`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AcoExampleDownloadLink |  | `New-RscQueryOracle -Operation AcoExampleDownloadLink`<BR> | [oracleAcoExampleDownloadLink](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| AcoParameters |  | `New-RscQueryOracle -Operation AcoParameters`<BR> | [oracleAcoParameters](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DataGuardGroup |  | `New-RscQueryOracle -Operation DataGuardGroup`<BR> | [oracleDataGuardGroup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Database |  | `New-RscQueryOracle -Operation Database`<BR> | [oracleDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DatabaseLogBackupConfig |  | `New-RscQueryOracle -Operation DatabaseLogBackupConfig`<BR> | [oracleDatabaseLogBackupConfig](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Databases |  | `New-RscQueryOracle -Operation Databases`<BR> | [oracleDatabases](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Host |  | `New-RscQueryOracle -Operation Host`<BR> | [oracleHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| HostLogBackupConfig |  | `New-RscQueryOracle -Operation HostLogBackupConfig`<BR> | [oracleHostLogBackupConfig](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| LiveMounts |  | `New-RscQueryOracle -Operation LiveMounts`<BR> | [oracleLiveMounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| MissedRecoverableRanges |  | `New-RscQueryOracle -Operation MissedRecoverableRanges`<BR> | [oracleMissedRecoverableRanges](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| MissedSnapshots |  | `New-RscQueryOracle -Operation MissedSnapshots`<BR> | [oracleMissedSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PdbDetails |  | `New-RscQueryOracle -Operation PdbDetails`<BR> | [oraclePdbDetails](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Rac |  | `New-RscQueryOracle -Operation Rac`<BR> | [oracleRac](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RacLogBackupConfig |  | `New-RscQueryOracle -Operation RacLogBackupConfig`<BR> | [oracleRacLogBackupConfig](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RecoverableRanges |  | `New-RscQueryOracle -Operation RecoverableRanges`<BR> | [oracleRecoverableRanges](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TopLevelDescendants |  | `New-RscQueryOracle -Operation TopLevelDescendants`<BR> | [oracleTopLevelDescendants](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| BulkUpdateDatabases |  | `New-RscMutationOracle -Operation BulkUpdateDatabases`<BR> | [bulkUpdateOracleDatabases](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BulkUpdateHosts |  | `New-RscMutationOracle -Operation BulkUpdateHosts`<BR> | [bulkUpdateOracleHosts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BulkUpdateRacs |  | `New-RscMutationOracle -Operation BulkUpdateRacs`<BR> | [bulkUpdateOracleRacs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreatePdbRestore |  | `New-RscMutationOracle -Operation CreatePdbRestore`<BR> | [createOraclePdbRestore](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteAllDatabaseSnapshots |  | `New-RscMutationOracle -Operation DeleteAllDatabaseSnapshots`<BR> | [deleteAllOracleDatabaseSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteMount |  | `New-RscMutationOracle -Operation DeleteMount`<BR> | [deleteOracleMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DownloadDatabaseSnapshot |  | `New-RscMutationOracle -Operation DownloadDatabaseSnapshot`<BR> | [downloadOracleDatabaseSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExportDatabase |  | `New-RscMutationOracle -Operation ExportDatabase`<BR> | [exportOracleDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExportTablespace |  | `New-RscMutationOracle -Operation ExportTablespace`<BR> | [exportOracleTablespace](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| InstantRecoverSnapshot |  | `New-RscMutationOracle -Operation InstantRecoverSnapshot`<BR> | [instantRecoverOracleSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| MountDatabase |  | `New-RscMutationOracle -Operation MountDatabase`<BR> | [mountOracleDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RefreshDatabase |  | `New-RscMutationOracle -Operation RefreshDatabase`<BR> | [refreshOracleDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RestoreLogs |  | `New-RscMutationOracle -Operation RestoreLogs`<BR> | [restoreOracleLogs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TakeOnDemandDatabaseSnapshot |  | `New-RscMutationOracle -Operation TakeOnDemandDatabaseSnapshot`<BR> | [takeOnDemandOracleDatabaseSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TakeOnDemandLogSnapshot |  | `New-RscMutationOracle -Operation TakeOnDemandLogSnapshot`<BR> | [takeOnDemandOracleLogSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateDataGuardGroup |  | `New-RscMutationOracle -Operation UpdateDataGuardGroup`<BR> | [updateOracleDataGuardGroup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ValidateAcoFile |  | `New-RscMutationOracle -Operation ValidateAcoFile`<BR> | [validateOracleAcoFile](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ValidateDatabaseBackups |  | `New-RscMutationOracle -Operation ValidateDatabaseBackups`<BR> | [validateOracleDatabaseBackups](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Policy domain

Domain key: Policy

Cmdlets: `New-RscQueryPolicy` and `New-RscMutationPolicy`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Details |  | `New-RscQueryPolicy -Operation Details`<BR> | [policyDetails](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Obj |  | `New-RscQueryPolicy -Operation Obj`<BR> | [policyObj](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ObjectUsages |  | `New-RscQueryPolicy -Operation ObjectUsages`<BR> | [policyObjectUsages](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Objs |  | `New-RscQueryPolicy -Operation Objs`<BR> | [policyObjs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Policies |  | `New-RscQueryPolicy -Operation Policies`<BR> | [policies](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Policy |  | `New-RscQueryPolicy -Operation Policy`<BR> | [policy](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Policies |  | `New-RscMutationPolicy -Operation Policies`<BR> | [seedInitialPolicies](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Ransomware domain

Domain key: Ransomware

Cmdlets: `New-RscQueryRansomware` and `New-RscMutationRansomware`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| DetectionWorkloadLocations |  | `New-RscQueryRansomware -Operation DetectionWorkloadLocations`<BR> | [ransomwareDetectionWorkloadLocations](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| InvestigationAnalysisSummary |  | `New-RscQueryRansomware -Operation InvestigationAnalysisSummary`<BR> | [ransomwareInvestigationAnalysisSummary](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| InvestigationEnablement |  | `New-RscQueryRansomware -Operation InvestigationEnablement`<BR> | [ransomwareInvestigationEnablement](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| InvestigationWorkloadScannedCount |  | `New-RscQueryRansomware -Operation InvestigationWorkloadScannedCount`<BR> | [ransomwareInvestigationWorkloadScannedCount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| OverallInvestigationSummary |  | `New-RscQueryRansomware -Operation OverallInvestigationSummary`<BR> | [overallRansomwareInvestigationSummary](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PendingInvestigationResultsCount |  | `New-RscQueryRansomware -Operation PendingInvestigationResultsCount`<BR> | [pendingRansomwareInvestigationResultsCount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ProcessedInvestigationWorkloadCount |  | `New-RscQueryRansomware -Operation ProcessedInvestigationWorkloadCount`<BR> | [processedRansomwareInvestigationWorkloadCount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ProtectedInvestigationWorkloadCount |  | `New-RscQueryRansomware -Operation ProtectedInvestigationWorkloadCount`<BR> | [protectedRansomwareInvestigationWorkloadCount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Result |  | `New-RscQueryRansomware -Operation Result`<BR> | [ransomwareResult](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ResultOpt |  | `New-RscQueryRansomware -Operation ResultOpt`<BR> | [ransomwareResultOpt](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Results |  | `New-RscQueryRansomware -Operation Results`<BR> | [ransomwareResults](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ResultsGrouped |  | `New-RscQueryRansomware -Operation ResultsGrouped`<BR> | [ransomwareResultsGrouped](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| TriggerDetection |  | `New-RscMutationRansomware -Operation TriggerDetection`<BR> | [triggerRansomwareDetection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## RCS domain

Domain key: Rcs

Cmdlets: `New-RscQueryRcs` and `New-RscMutationRcs`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| ArchivalLocationsConsumptionStats |  | `New-RscQueryRcs -Operation ArchivalLocationsConsumptionStats`<BR> | [rcsArchivalLocationsConsumptionStats](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Cluster |  | `New-RscQueryRcs -Operation Cluster`<BR> | [clusterCsr](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Dhcores |  | `New-RscQueryRcs -Operation Dhcores`<BR> | [allDhrcScores](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| CreateAutomaticTargetMapping |  | `New-RscMutationRcs -Operation CreateAutomaticTargetMapping`<BR> | [createAutomaticRcsTargetMapping](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateReaderTarget |  | `New-RscMutationRcs -Operation CreateReaderTarget`<BR> | [createRcsReaderTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateTarget |  | `New-RscMutationRcs -Operation CreateTarget`<BR> | [createRcsTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateAutomaticTargetMapping |  | `New-RscMutationRcs -Operation UpdateAutomaticTargetMapping`<BR> | [updateRcsAutomaticTargetMapping](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## RCV domain

Domain key: Rcv

Cmdlets: `New-RscQueryRcv` and `New-RscMutationRcv`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AccountEntitlement |  | `New-RscQueryRcv -Operation AccountEntitlement`<BR> | [rcvAccountEntitlement](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| CreateLocationsFromTemplate |  | `New-RscMutationRcv -Operation CreateLocationsFromTemplate`<BR> | [createRcvLocationsFromTemplate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreatePrivateEndpointApprovalRequest |  | `New-RscMutationRcv -Operation CreatePrivateEndpointApprovalRequest`<BR> | [createRcvPrivateEndpointApprovalRequest](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateTarget |  | `New-RscMutationRcv -Operation UpdateTarget`<BR> | [updateRcvTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Replication domain

Domain key: Replication

Cmdlets: `New-RscQueryReplication` and `New-RscMutationReplication`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| IncomingStats |  | `New-RscQueryReplication -Operation IncomingStats`<BR> | [replicationIncomingStats](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| OutgoingStats |  | `New-RscQueryReplication -Operation OutgoingStats`<BR> | [replicationOutgoingStats](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Pairs |  | `New-RscQueryReplication -Operation Pairs`<BR> | [replicationPairs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ValidTargets |  | `New-RscQueryReplication -Operation ValidTargets`<BR> | [allValidReplicationTargets](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| CreatePair |  | `New-RscMutationReplication -Operation CreatePair`<BR> | [createReplicationPair](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeletePair |  | `New-RscMutationReplication -Operation DeletePair`<BR> | [deleteReplicationPair](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DisablePause |  | `New-RscMutationReplication -Operation DisablePause`<BR> | [disableReplicationPause](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| EnablePause |  | `New-RscMutationReplication -Operation EnablePause`<BR> | [enableReplicationPause](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateTarget |  | `New-RscMutationReplication -Operation UpdateTarget`<BR> | [updateReplicationTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Report domain

Domain key: Report

Cmdlets: `New-RscQueryReport` and `New-RscMutationReport`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Data |  | `New-RscQueryReport -Operation Data`<BR> | [reportData](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Scheduled |  | `New-RscQueryReport -Operation Scheduled`<BR> | [scheduledReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| CreateCustom |  | `New-RscMutationReport -Operation CreateCustom`<BR> | [createCustomReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateScheduled |  | `New-RscMutationReport -Operation CreateScheduled`<BR> | [createScheduledReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteCustom |  | `New-RscMutationReport -Operation DeleteCustom`<BR> | [deleteCustomReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteScheduled |  | `New-RscMutationReport -Operation DeleteScheduled`<BR> | [deleteScheduledReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SendPdf |  | `New-RscMutationReport -Operation SendPdf`<BR> | [sendPdfReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SendScheduledAsync |  | `New-RscMutationReport -Operation SendScheduledAsync`<BR> | [sendScheduledReportAsync](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartClusterMigrationJob |  | `New-RscMutationReport -Operation StartClusterMigrationJob`<BR> | [startClusterReportMigrationJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateCustom |  | `New-RscMutationReport -Operation UpdateCustom`<BR> | [updateCustomReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateScheduled |  | `New-RscMutationReport -Operation UpdateScheduled`<BR> | [updateScheduledReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## SAP HANA domain

Domain key: SapHana

Cmdlets: `New-RscQuerySapHana` and `New-RscMutationSapHana`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Database |  | `New-RscQuerySapHana -Operation Database`<BR> | [sapHanaDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Databases |  | `New-RscQuerySapHana -Operation Databases`<BR> | [sapHanaDatabases](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| LogSnapshot |  | `New-RscQuerySapHana -Operation LogSnapshot`<BR> | [sapHanaLogSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| LogSnapshots |  | `New-RscQuerySapHana -Operation LogSnapshots`<BR> | [sapHanaLogSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RecoverableRange |  | `New-RscQuerySapHana -Operation RecoverableRange`<BR> | [sapHanaRecoverableRange](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RecoverableRanges |  | `New-RscQuerySapHana -Operation RecoverableRanges`<BR> | [sapHanaRecoverableRanges](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| System |  | `New-RscQuerySapHana -Operation System`<BR> | [sapHanaSystem](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Systems |  | `New-RscQuerySapHana -Operation Systems`<BR> | [sapHanaSystems](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AddSystem |  | `New-RscMutationSapHana -Operation AddSystem`<BR> | [addSapHanaSystem](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ConfigureRestore |  | `New-RscMutationSapHana -Operation ConfigureRestore`<BR> | [configureSapHanaRestore](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateOnDemandBackup |  | `New-RscMutationSapHana -Operation CreateOnDemandBackup`<BR> | [createOnDemandSapHanaBackup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateSystemRefresh |  | `New-RscMutationSapHana -Operation CreateSystemRefresh`<BR> | [createSapHanaSystemRefresh](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteDbSnapshot |  | `New-RscMutationSapHana -Operation DeleteDbSnapshot`<BR> | [deleteSapHanaDbSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteSystem |  | `New-RscMutationSapHana -Operation DeleteSystem`<BR> | [deleteSapHanaSystem](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExpireDownloadedSnapshots |  | `New-RscMutationSapHana -Operation ExpireDownloadedSnapshots`<BR> | [expireDownloadedSapHanaSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PatchSystem |  | `New-RscMutationSapHana -Operation PatchSystem`<BR> | [patchSapHanaSystem](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UnconfigureRestore |  | `New-RscMutationSapHana -Operation UnconfigureRestore`<BR> | [unconfigureSapHanaRestore](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Service Account domain

Domain key: ServiceAccount

Cmdlets: `New-RscQueryServiceAccount` and `New-RscMutationServiceAccount`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| ServiceAccount |  | `New-RscQueryServiceAccount -Operation ServiceAccount`<BR> | [serviceAccounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Create |  | `New-RscMutationServiceAccount -Operation Create`<BR> | [createServiceAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Delete |  | `New-RscMutationServiceAccount -Operation Delete`<BR> | [deleteServiceAccountsFromAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Rotate |  | `New-RscMutationServiceAccount -Operation Rotate`<BR> | [rotateServiceAccountSecret](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Update |  | `New-RscMutationServiceAccount -Operation Update`<BR> | [updateServiceAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Sharepoint domain

Domain key: Sharepoint

Cmdlets: `New-RscQuerySharepoint` and `New-RscMutationSharepoint`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| BrowseDrive |  | `New-RscQuerySharepoint -Operation BrowseDrive`<BR> | [browseSharepointDrive](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BrowseList |  | `New-RscQuerySharepoint -Operation BrowseList`<BR> | [browseSharepointList](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SiteDescendants |  | `New-RscQuerySharepoint -Operation SiteDescendants`<BR> | [sharepointSiteDescendants](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SiteExclusions |  | `New-RscQuerySharepoint -Operation SiteExclusions`<BR> | [allSharepointSiteExclusions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SiteSearch |  | `New-RscQuerySharepoint -Operation SiteSearch`<BR> | [sharepointSiteSearch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SnappableDriveSearch |  | `New-RscQuerySharepoint -Operation SnappableDriveSearch`<BR> | [snappableSharepointDriveSearch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SnappableListSearch |  | `New-RscQuerySharepoint -Operation SnappableListSearch`<BR> | [snappableSharepointListSearch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SnapshotDriveSearch |  | `New-RscQuerySharepoint -Operation SnapshotDriveSearch`<BR> | [snapshotSharepointDriveSearch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| ExcludeObjectsFromProtection |  | `New-RscMutationSharepoint -Operation ExcludeObjectsFromProtection`<BR> | [excludeSharepointObjectsFromProtection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## SLA domain

Domain key: Sla

Cmdlets: `New-RscQuerySla` and `New-RscMutationSla`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AuditDetail |  | `New-RscQuerySla -Operation AuditDetail`<BR> | [slaAuditDetail](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ClusterDomains |  | `New-RscQuerySla -Operation ClusterDomains`<BR> | [clusterSlaDomains](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ClusterGlobals |  | `New-RscQuerySla -Operation ClusterGlobals`<BR> | [allClusterGlobalSlas](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ConflictObjects |  | `New-RscQuerySla -Operation ConflictObjects`<BR> | [slaConflictObjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CountOfObjectsProtected |  | `New-RscQuerySla -Operation CountOfObjectsProtected`<BR> | [countOfObjectsProtectedBySlas](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Domain |  | `New-RscQuerySla -Operation Domain`<BR> | [slaDomain](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Domains |  | `New-RscQuerySla -Operation Domains`<BR> | [slaDomains](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| GlobalFilterList |  | `New-RscQuerySla -Operation GlobalFilterList`<BR> | [globalSlaFilterConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| GlobalStatuses |  | `New-RscQuerySla -Operation GlobalStatuses`<BR> | [globalSlaStatuses](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ManagedVolume |  | `New-RscQuerySla -Operation ManagedVolume`<BR> | [slaManagedVolume](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ManagedVolumes |  | `New-RscQuerySla -Operation ManagedVolumes`<BR> | [slaManagedVolumes](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| NcdComplianceData |  | `New-RscQuerySla -Operation NcdComplianceData`<BR> | [allNcdSlaComplianceData](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SummariesByIds |  | `New-RscQuerySla -Operation SummariesByIds`<BR> | [allSlaSummariesByIds](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| VerifyWithReplicationToCluster |  | `New-RscQuerySla -Operation VerifyWithReplicationToCluster`<BR> | [verifySlaWithReplicationToCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Assign |  | `New-RscMutationSla -Operation Assign`<BR> | [assignSla](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| AssignRetentionToSnappables |  | `New-RscMutationSla -Operation AssignRetentionToSnappables`<BR> | [assignRetentionSLAToSnappables](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| AssignRetentionToSnapshots |  | `New-RscMutationSla -Operation AssignRetentionToSnapshots`<BR> | [assignRetentionSLAToSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| AssignsForSnappableHierarchies |  | `New-RscMutationSla -Operation AssignsForSnappableHierarchies`<BR> | [assignSlasForSnappableHierarchies](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateGlobal |  | `New-RscMutationSla -Operation CreateGlobal`<BR> | [createGlobalSla](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExportManagedVolumeSnapshot |  | `New-RscMutationSla -Operation ExportManagedVolumeSnapshot`<BR> | [exportSlaManagedVolumeSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| GetPendingAssignments |  | `New-RscMutationSla -Operation GetPendingAssignments`<BR> | [getPendingSlaAssignments](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Pause |  | `New-RscMutationSla -Operation Pause`<BR> | [pauseSla](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateGlobal |  | `New-RscMutationSla -Operation UpdateGlobal`<BR> | [updateGlobalSla](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## SMB domain

Domain key: Smb

Cmdlets: `New-RscQuerySmb` and `New-RscMutationSmb`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Configuration |  | `New-RscQuerySmb -Operation Configuration`<BR> | [smbConfiguration](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Domains |  | `New-RscQuerySmb -Operation Domains`<BR> | [smbDomains](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AddAndJoinDomain |  | `New-RscMutationSmb -Operation AddAndJoinDomain`<BR> | [addAndJoinSmbDomain](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteDomain |  | `New-RscMutationSmb -Operation DeleteDomain`<BR> | [deleteSmbDomain](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| JoinDomain |  | `New-RscMutationSmb -Operation JoinDomain`<BR> | [joinSmbDomain](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PutConfiguration |  | `New-RscMutationSmb -Operation PutConfiguration`<BR> | [putSmbConfiguration](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Snapshot domain

Domain key: Snapshot

Cmdlets: `New-RscQuerySnapshot` and `New-RscMutationSnapshot`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| BrowseFileList |  | `New-RscQuerySnapshot -Operation BrowseFileList`<BR> | [browseSnapshotFileConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ClosestToPointInTime |  | `New-RscQuerySnapshot -Operation ClosestToPointInTime`<BR> | [allSnapshotsClosestToPointInTime](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| EmailSearch |  | `New-RscQuerySnapshot -Operation EmailSearch`<BR> | [snapshotEmailSearch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| EventSearch |  | `New-RscQuerySnapshot -Operation EventSearch`<BR> | [snapshotEventSearch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| FilesDelta |  | `New-RscQuerySnapshot -Operation FilesDelta`<BR> | [snapshotFilesDelta](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| FilesDeltaV2 |  | `New-RscQuerySnapshot -Operation FilesDeltaV2`<BR> | [snapshotFilesDeltaV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Fileset |  | `New-RscQuerySnapshot -Operation Fileset`<BR> | [filesetSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| FilesetFiles |  | `New-RscQuerySnapshot -Operation FilesetFiles`<BR> | [filesetSnapshotFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| LegalHoldSnappable |  | `New-RscQuerySnapshot -Operation LegalHoldSnappable`<BR> | [legalHoldSnapshotsForSnappable](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| OnedriveSearch |  | `New-RscQuerySnapshot -Operation OnedriveSearch`<BR> | [snapshotOnedriveSearch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Polaris |  | `New-RscQuerySnapshot -Operation Polaris`<BR> | [polarisSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Pvcs |  | `New-RscQuerySnapshot -Operation Pvcs`<BR> | [allSnapshotPvcs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| QuarantinedDetails |  | `New-RscQuerySnapshot -Operation QuarantinedDetails`<BR> | [allQuarantinedDetailsForSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Results |  | `New-RscQuerySnapshot -Operation Results`<BR> | [snapshotResults](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SnappableList |  | `New-RscQuerySnapshot -Operation SnappableList`<BR> | [snapshotOfASnappableConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SnappablesList |  | `New-RscQuerySnapshot -Operation SnappablesList`<BR> | [snapshotOfSnappablesConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| SnappablesWithLegalHoldsSummary |  | `New-RscQuerySnapshot -Operation SnappablesWithLegalHoldsSummary`<BR> | [snappablesWithLegalHoldSnapshotsSummary](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Snapshot |  | `New-RscQuerySnapshot -Operation Snapshot`<BR> | [snapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UnmanagedObject |  | `New-RscQuerySnapshot -Operation UnmanagedObject`<BR> | [snapshotsForUnmanagedObject](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| VappInstantRecoveryOptions |  | `New-RscQuerySnapshot -Operation VappInstantRecoveryOptions`<BR> | [vappSnapshotInstantRecoveryOptions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| VappTemplateExportOptions |  | `New-RscQuerySnapshot -Operation VappTemplateExportOptions`<BR> | [vappTemplateSnapshotExportOptions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| BatchQuarantine |  | `New-RscMutationSnapshot -Operation BatchQuarantine`<BR> | [batchQuarantineSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BatchReleaseFromQuarantine |  | `New-RscMutationSnapshot -Operation BatchReleaseFromQuarantine`<BR> | [batchReleaseFromQuarantineSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BulkTierExistings |  | `New-RscMutationSnapshot -Operation BulkTierExistings`<BR> | [bulkTierExistingSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateDownloadForVolumeGroup |  | `New-RscMutationSnapshot -Operation CreateDownloadForVolumeGroup`<BR> | [createDownloadSnapshotForVolumeGroup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateFileset |  | `New-RscMutationSnapshot -Operation CreateFileset`<BR> | [createFilesetSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteCloudWorkload |  | `New-RscMutationSnapshot -Operation DeleteCloudWorkload`<BR> | [deleteCloudWorkloadSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteFilesets |  | `New-RscMutationSnapshot -Operation DeleteFilesets`<BR> | [deleteFilesetSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| FilesetDownloadFiles |  | `New-RscMutationSnapshot -Operation FilesetDownloadFiles`<BR> | [filesetDownloadSnapshotFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| FilesetExportFiles |  | `New-RscMutationSnapshot -Operation FilesetExportFiles`<BR> | [filesetExportSnapshotFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RestoreVolumeGroupFiles |  | `New-RscMutationSnapshot -Operation RestoreVolumeGroupFiles`<BR> | [restoreVolumeGroupSnapshotFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartEc2InstanceExportJob |  | `New-RscMutationSnapshot -Operation StartEc2InstanceExportJob`<BR> | [startEc2InstanceSnapshotExportJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartRecoverS3Job |  | `New-RscMutationSnapshot -Operation StartRecoverS3Job`<BR> | [startRecoverS3SnapshotJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TakeOnDemand |  | `New-RscMutationSnapshot -Operation TakeOnDemand`<BR> | [takeOnDemandSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UploadDatabaseToBlobstore |  | `New-RscMutationSnapshot -Operation UploadDatabaseToBlobstore`<BR> | [uploadDatabaseSnapshotToBlobstore](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| VmwareDownloadFromLocation |  | `New-RscMutationSnapshot -Operation VmwareDownloadFromLocation`<BR> | [vmwareDownloadSnapshotFromLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Sonar domain

Domain key: Sonar

Cmdlets: `New-RscQuerySonar` and `New-RscMutationSonar`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| ContentReport |  | `New-RscQuerySonar -Operation ContentReport`<BR> | [sonarContentReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Report |  | `New-RscQuerySonar -Operation Report`<BR> | [sonarReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ReportRow |  | `New-RscQuerySonar -Operation ReportRow`<BR> | [sonarReportRow](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UserGroups |  | `New-RscQuerySonar -Operation UserGroups`<BR> | [sonarUserGroups](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Users |  | `New-RscQuerySonar -Operation Users`<BR> | [sonarUsers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

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
| StorageArray |  | `New-RscQueryStorageArray -Operation StorageArray`<BR> | [allStorageArrays](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Add |  | `New-RscMutationStorageArray -Operation Add`<BR> | [addStorageArrays](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Delete |  | `New-RscMutationStorageArray -Operation Delete`<BR> | [deleteStorageArrays](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Refresh |  | `New-RscMutationStorageArray -Operation Refresh`<BR> | [refreshStorageArrays](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Update |  | `New-RscMutationStorageArray -Operation Update`<BR> | [updateStorageArrays](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

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
| CreateReaderTarget |  | `New-RscMutationTape -Operation CreateReaderTarget`<BR> | [createTapeReaderTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateTarget |  | `New-RscMutationTape -Operation CreateTarget`<BR> | [createTapeTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateTarget |  | `New-RscMutationTape -Operation UpdateTarget`<BR> | [updateTapeTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Threat domain

Domain key: Threat

Cmdlets: `New-RscQueryThreat` and `New-RscMutationThreat`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| HuntDetail |  | `New-RscQueryThreat -Operation HuntDetail`<BR> | [threatHuntDetail](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| HuntResult |  | `New-RscQueryThreat -Operation HuntResult`<BR> | [threatHuntResult](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| HuntSummary |  | `New-RscQueryThreat -Operation HuntSummary`<BR> | [threatHuntSummary](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Hunts |  | `New-RscQueryThreat -Operation Hunts`<BR> | [threatHunts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| CancelHunt |  | `New-RscMutationThreat -Operation CancelHunt`<BR> | [cancelThreatHunt](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| EnableMonitoring |  | `New-RscMutationThreat -Operation EnableMonitoring`<BR> | [enableThreatMonitoring](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| StartHunt |  | `New-RscMutationThreat -Operation StartHunt`<BR> | [startThreatHunt](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## VMware vSphere vCenter domain

Domain key: Vcenter

Cmdlets: `New-RscQueryVcenter` and `New-RscMutationVcenter`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AdvancedTagPreview |  | `New-RscQueryVcenter -Operation AdvancedTagPreview`<BR> | [vCenterAdvancedTagPreview](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| HotAddBandwidth |  | `New-RscQueryVcenter -Operation HotAddBandwidth`<BR> | [vCenterHotAddBandwidth](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| HotAddNetwork |  | `New-RscQueryVcenter -Operation HotAddNetwork`<BR> | [vCenterHotAddNetwork](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| HotAddProxy |  | `New-RscQueryVcenter -Operation HotAddProxy`<BR> | [allVcenterHotAddProxyVms](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| List |  | `New-RscQueryVcenter -Operation List`<BR> | [vSphereVCenterConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Networks |  | `New-RscQueryVcenter -Operation Networks`<BR> | [vCenterNetworks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| NumProxiesNeeded |  | `New-RscQueryVcenter -Operation NumProxiesNeeded`<BR> | [vCenterNumProxiesNeeded](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PreAddInfo |  | `New-RscQueryVcenter -Operation PreAddInfo`<BR> | [vCenterPreAddInfo](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Vcenter |  | `New-RscQueryVcenter -Operation Vcenter`<BR> | [vSphereVCenter](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Create |  | `New-RscMutationVcenter -Operation Create`<BR> | [createVsphereVcenter](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Delete |  | `New-RscMutationVcenter -Operation Delete`<BR> | [vsphereDeleteVcenter](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Refresh |  | `New-RscMutationVcenter -Operation Refresh`<BR> | [refreshVsphereVcenter](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Update |  | `New-RscMutationVcenter -Operation Update`<BR> | [updateVcenter](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateHotAddBandwidth |  | `New-RscMutationVcenter -Operation UpdateHotAddBandwidth`<BR> | [updateVcenterHotAddBandwidth](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateHotAddNetwork |  | `New-RscMutationVcenter -Operation UpdateHotAddNetwork`<BR> | [updateVcenterHotAddNetwork](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## VMware vSphere domain

Domain key: Vsphere

Cmdlets: `New-RscQueryVsphere` and `New-RscMutationVsphere`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| ComputeCluster |  | `New-RscQueryVsphere -Operation ComputeCluster`<BR> | [vSphereComputeCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ComputeClusters |  | `New-RscQueryVsphere -Operation ComputeClusters`<BR> | [vSphereComputeClusters](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Datacenter |  | `New-RscQueryVsphere -Operation Datacenter`<BR> | [vSphereDatacenter](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Datastore |  | `New-RscQueryVsphere -Operation Datastore`<BR> | [vSphereDatastore](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DatastoreCluster |  | `New-RscQueryVsphere -Operation DatastoreCluster`<BR> | [vSphereDatastoreCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DatastoreClusters |  | `New-RscQueryVsphere -Operation DatastoreClusters`<BR> | [vSphereDatastoreClusters](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DatastoreList |  | `New-RscQueryVsphere -Operation DatastoreList`<BR> | [vSphereDatastoreConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Folder |  | `New-RscQueryVsphere -Operation Folder`<BR> | [vSphereFolder](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Folders |  | `New-RscQueryVsphere -Operation Folders`<BR> | [vSphereFolders](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Host |  | `New-RscQueryVsphere -Operation Host`<BR> | [vSphereHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| HostDetails |  | `New-RscQueryVsphere -Operation HostDetails`<BR> | [vSphereHostDetails](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| HostList |  | `New-RscQueryVsphere -Operation HostList`<BR> | [vSphereHostConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| HostsByFids |  | `New-RscQueryVsphere -Operation HostsByFids`<BR> | [vSphereHostsByFids](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| LiveMounts |  | `New-RscQueryVsphere -Operation LiveMounts`<BR> | [vSphereLiveMounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Mount |  | `New-RscQueryVsphere -Operation Mount`<BR> | [vSphereMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| MountList |  | `New-RscQueryVsphere -Operation MountList`<BR> | [vSphereMountConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Network |  | `New-RscQueryVsphere -Operation Network`<BR> | [vSphereNetwork](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ResourcePool |  | `New-RscQueryVsphere -Operation ResourcePool`<BR> | [vSphereResourcePool](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RootRecoveryHierarchy |  | `New-RscQueryVsphere -Operation RootRecoveryHierarchy`<BR> | [vSphereRootRecoveryHierarchy](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Tag |  | `New-RscQueryVsphere -Operation Tag`<BR> | [vSphereTag](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TagCategory |  | `New-RscQueryVsphere -Operation TagCategory`<BR> | [vSphereTagCategory](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TopLevelDescendantsList |  | `New-RscQueryVsphere -Operation TopLevelDescendantsList`<BR> | [vSphereTopLevelDescendantsConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| VmwareCdpLiveInfo |  | `New-RscQueryVsphere -Operation VmwareCdpLiveInfo`<BR> | [vsphereVmwareCdpLiveInfo](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| BulkOnDemandSnapshot |  | `New-RscMutationVsphere -Operation BulkOnDemandSnapshot`<BR> | [vsphereBulkOnDemandSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| CreateAdvancedTag |  | `New-RscMutationVsphere -Operation CreateAdvancedTag`<BR> | [createVsphereAdvancedTag](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteAdvancedTag |  | `New-RscMutationVsphere -Operation DeleteAdvancedTag`<BR> | [deleteVsphereAdvancedTag](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteLiveMount |  | `New-RscMutationVsphere -Operation DeleteLiveMount`<BR> | [deleteVsphereLiveMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DownloadVirtualMachineFiles |  | `New-RscMutationVsphere -Operation DownloadVirtualMachineFiles`<BR> | [downloadVsphereVirtualMachineFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExportSnapshotToStandaloneHostV2 |  | `New-RscMutationVsphere -Operation ExportSnapshotToStandaloneHostV2`<BR> | [vsphereExportSnapshotToStandaloneHostV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| OnDemandSnapshot |  | `New-RscMutationVsphere -Operation OnDemandSnapshot`<BR> | [vsphereOnDemandSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| UpdateAdvancedTag |  | `New-RscMutationVsphere -Operation UpdateAdvancedTag`<BR> | [updateVsphereAdvancedTag](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## VMware vSphere VM domain

Domain key: VsphereVm

Cmdlets: `New-RscQueryVsphereVm` and `New-RscMutationVsphereVm`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| AsyncRequestStatus |  | `New-RscQueryVsphereVm -Operation AsyncRequestStatus`<BR> | [vSphereVMAsyncRequestStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| MissedRecoverableRange |  | `New-RscQueryVsphereVm -Operation MissedRecoverableRange`<BR> | [vsphereVMMissedRecoverableRange](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| New |  | `New-RscQueryVsphereVm -Operation New`<BR> | [vSphereVmNew](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| NewList |  | `New-RscQueryVsphereVm -Operation NewList`<BR> | [vSphereVmNewConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RecoverableRange |  | `New-RscQueryVsphereVm -Operation RecoverableRange`<BR> | [vsphereVMRecoverableRange](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RecoverableRangeInBatch |  | `New-RscQueryVsphereVm -Operation RecoverableRangeInBatch`<BR> | [vsphereVMRecoverableRangeInBatch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| BatchExport |  | `New-RscMutationVsphereVm -Operation BatchExport`<BR> | [vsphereVmBatchExport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BatchExportV3 |  | `New-RscMutationVsphereVm -Operation BatchExportV3`<BR> | [vsphereVmBatchExportV3](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| BatchInPlaceRecovery |  | `New-RscMutationVsphereVm -Operation BatchInPlaceRecovery`<BR> | [vsphereVmBatchInPlaceRecovery](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DeleteSnapshot |  | `New-RscMutationVsphereVm -Operation DeleteSnapshot`<BR> | [vsphereVmDeleteSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DownloadSnapshot |  | `New-RscMutationVsphereVm -Operation DownloadSnapshot`<BR> | [vsphereVmDownloadSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| DownloadSnapshotFiles |  | `New-RscMutationVsphereVm -Operation DownloadSnapshotFiles`<BR> | [vsphereVmDownloadSnapshotFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExcludeVmDisks |  | `New-RscMutationVsphereVm -Operation ExcludeVmDisks`<BR> | [vsphereExcludeVmDisks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExportSnapshotV2 |  | `New-RscMutationVsphereVm -Operation ExportSnapshotV2`<BR> | [vsphereVmExportSnapshotV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExportSnapshotV3 |  | `New-RscMutationVsphereVm -Operation ExportSnapshotV3`<BR> | [vsphereVmExportSnapshotV3](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ExportSnapshotWithDownloadFromCloud |  | `New-RscMutationVsphereVm -Operation ExportSnapshotWithDownloadFromCloud`<BR> | [vsphereVmExportSnapshotWithDownloadFromCloud](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| InitiateBatchInstantRecovery |  | `New-RscMutationVsphereVm -Operation InitiateBatchInstantRecovery`<BR> | [vsphereVmInitiateBatchInstantRecovery](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| InitiateBatchLiveMountV2 |  | `New-RscMutationVsphereVm -Operation InitiateBatchLiveMountV2`<BR> | [vsphereVmInitiateBatchLiveMountV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| InitiateDiskMount |  | `New-RscMutationVsphereVm -Operation InitiateDiskMount`<BR> | [vsphereVmInitiateDiskMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| InitiateInPlaceRecovery |  | `New-RscMutationVsphereVm -Operation InitiateInPlaceRecovery`<BR> | [vsphereVmInitiateInPlaceRecovery](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| InitiateInstantRecoveryV2 |  | `New-RscMutationVsphereVm -Operation InitiateInstantRecoveryV2`<BR> | [vsphereVmInitiateInstantRecoveryV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| InitiateLiveMountV2 |  | `New-RscMutationVsphereVm -Operation InitiateLiveMountV2`<BR> | [vsphereVmInitiateLiveMountV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| ListEsxiDatastores |  | `New-RscMutationVsphereVm -Operation ListEsxiDatastores`<BR> | [vsphereVmListEsxiDatastores](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| MountRelocate |  | `New-RscMutationVsphereVm -Operation MountRelocate`<BR> | [vsphereVmMountRelocate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| MountRelocateV2 |  | `New-RscMutationVsphereVm -Operation MountRelocateV2`<BR> | [vsphereVmMountRelocateV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| PowerOnOffLiveMount |  | `New-RscMutationVsphereVm -Operation PowerOnOffLiveMount`<BR> | [vsphereVmPowerOnOffLiveMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RecoverFiles |  | `New-RscMutationVsphereVm -Operation RecoverFiles`<BR> | [vsphereVmRecoverFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RecoverFilesNew |  | `New-RscMutationVsphereVm -Operation RecoverFilesNew`<BR> | [vsphereVmRecoverFilesNew](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| RegisterAgent |  | `New-RscMutationVsphereVm -Operation RegisterAgent`<BR> | [vsphereVmRegisterAgent](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Update |  | `New-RscMutationVsphereVm -Operation Update`<BR> | [updateVsphereVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Webhook domain

Domain key: Webhook

Cmdlets: `New-RscQueryWebhook` and `New-RscMutationWebhook`

### Queries

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Webhook |  | `New-RscQueryWebhook -Operation Webhook`<BR> | [allWebhooks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Operation | Description | Invocation | GraphQL Root Field |
| --- | --- | --- | --- |
| Create |  | `New-RscMutationWebhook -Operation Create`<BR> | [createWebhook](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Delete |  | `New-RscMutationWebhook -Operation Delete`<BR> | [deleteWebhook](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Test |  | `New-RscMutationWebhook -Operation Test`<BR> | [testWebhook](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| TestExisting |  | `New-RscMutationWebhook -Operation TestExisting`<BR> | [testExistingWebhook](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| Update |  | `New-RscMutationWebhook -Operation Update`<BR> | [updateWebhook](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
