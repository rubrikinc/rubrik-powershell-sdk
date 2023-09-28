# API Domains and Operations

The RSC API is organized into 52 domain.
Each API domain is a set of related operations.

## Table of Contents

Numbers in parentheses indicate the number queries and mutations in the domain.

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Account (8,1)](#account-domain) | [Cluster (29,9)](#cluster-domain) | [M365 (1,4)](#m365-domain) | [Ransomware (12,1)](#ransomware-domain) | [Sonar (5,0)](#sonar-domain) |
| [Activity series (4,3)](#activity-series-domain) | [Db2 (8,11)](#db2-domain) | [Managed Volume (4,11)](#managed-volume-domain) | [RCS (3,4)](#rcs-domain) | [Storage Arrays (1,4)](#storage-arrays-domain) |
| [AWS (28,33)](#aws-domain) | [Report Download (3,16)](#report-download-domain) | [Mongo (10,10)](#mongo-domain) | [RCV (1,3)](#rcv-domain) | [Tape (0,3)](#tape-domain) |
| [AWS Native (19,8)](#aws-native-domain) | [Microsoft Exchange (7,4)](#microsoft-exchange-domain) | [Mosaic (4,3)](#mosaic-domain) | [Replication (4,5)](#replication-domain) | [Threat (4,3)](#threat-domain) |
| [Azure (42,43)](#azure-domain) | [Fileset (6,6)](#fileset-domain) | [MSSQL (16,17)](#mssql-domain) | [Report (2,9)](#report-domain) | [vSphere vCenter (9,6)](#vsphere-vcenter-domain) |
| [Azure Native (23,8)](#azure-native-domain) | [Google Cloud Platform (16,11)](#google-cloud-platform-domain) | [NAS (8,0)](#nas-domain) | [SAP HANA (8,9)](#sap-hana-domain) | [vSphere (23,8)](#vsphere-domain) |
| [AzureO365 (11,1)](#azureo365-domain) | [Google Cloud Platform Native (7,6)](#google-cloud-platform-native-domain) | [NFS (0,3)](#nfs-domain) | [Service Account (1,4)](#service-account-domain) | [vSphere VM (6,24)](#vsphere-vm-domain) |
| [Cassandra (8,5)](#cassandra-domain) | [Host (6,6)](#host-domain) | [Nutanix (18,25)](#nutanix-domain) | [Sharepoint (8,1)](#sharepoint-domain) | [Webhook (1,5)](#webhook-domain) |
| [Certificates (6,6)](#certificates-domain) | [Hyperv (14,23)](#hyperv-domain) | [O365 (37,31)](#o365-domain) | [SLA (14,9)](#sla-domain) | [Unmatched fields (377)](#unmatched-fields) |
| [Cloud Account (5,2)](#cloud-account-domain) | [Kubernetes (7,7)](#kubernetes-domain) | [Oracle (16,18)](#oracle-domain) | [SMB (2,4)](#smb-domain) | [Skipped fields (19)](#skipped-fields) |
| [Cloud Native (19,13)](#cloud-native-domain) | [LDAP (3,4)](#ldap-domain) | [Policy (6,1)](#policy-domain) | [Snapshot (21,15)](#snapshot-domain) |  |

## Account domain

Domain key: Account

Cmdlets: `New-RscQueryAccount` and `New-RscMutationAccount`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| EnabledFeatures | `New-RscQueryAccount -Operation EnabledFeatures`<BR> | allEnabledFeaturesForAccount |
| Id | `New-RscQueryAccount -Operation Id`<BR> | accountId |
| Lookup | `New-RscQueryAccount -Operation Lookup`<BR> | lookupAccount |
| Owners | `New-RscQueryAccount -Operation Owners`<BR> | allAccountOwners |
| Products | `New-RscQueryAccount -Operation Products`<BR> | allAccountProducts |
| Settings | `New-RscQueryAccount -Operation Settings`<BR> | accountSettings |
| Users | `New-RscQueryAccount -Operation Users`<BR> | allUsersOnAccount |
| WithExocomputeMappings | `New-RscQueryAccount -Operation WithExocomputeMappings`<BR> | allAccountsWithExocomputeMappings |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| DeleteUsers | `New-RscMutationAccount -Operation DeleteUsers`<BR> | deleteUsersFromAccount |

[Go to top](#)
## Activity series domain

Domain key: ActivitySeries

Cmdlets: `New-RscQueryActivitySeries` and `New-RscMutationActivitySeries`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| ActivitySeries | `New-RscQueryActivitySeries -Operation ActivitySeries`<BR> | activitySeries |
| List | `New-RscQueryActivitySeries -Operation List`<BR> | activitySeriesConnection |
| UserFileTimeline | `New-RscQueryActivitySeries -Operation UserFileTimeline`<BR> | userFileActivityTimeline |
| UserTimeline | `New-RscQueryActivitySeries -Operation UserTimeline`<BR> | userActivityTimeline |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| Cancel | `New-RscMutationActivitySeries -Operation Cancel`<BR> | cancelActivitySeries |
| DownloadUserCsv | `New-RscMutationActivitySeries -Operation DownloadUserCsv`<BR> | downloadUserActivityCsv |
| DownloadUserFileCsv | `New-RscMutationActivitySeries -Operation DownloadUserFileCsv`<BR> | downloadUserFileActivityCsv |

[Go to top](#)
## AWS domain

Domain key: Aws

Cmdlets: `New-RscQueryAws` and `New-RscMutationAws`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| ArtifactsToDelete | `New-RscQueryAws -Operation ArtifactsToDelete`<BR> | awsArtifactsToDelete |
| AvailabilityZonesByRegion | `New-RscQueryAws -Operation AvailabilityZonesByRegion`<BR> | allAvailabilityZonesByRegionFromAws |
| CdmVersions | `New-RscQueryAws -Operation CdmVersions`<BR> | allAwsCdmVersions |
| CloudAccountConfigs | `New-RscQueryAws -Operation CloudAccountConfigs`<BR> | allAwsCloudAccountConfigs |
| CloudAccountListSecurityGroups | `New-RscQueryAws -Operation CloudAccountListSecurityGroups`<BR> | awsCloudAccountListSecurityGroups |
| CloudAccountListSubnets | `New-RscQueryAws -Operation CloudAccountListSubnets`<BR> | awsCloudAccountListSubnets |
| CloudAccountListVpcs | `New-RscQueryAws -Operation CloudAccountListVpcs`<BR> | awsCloudAccountListVpcs |
| CloudAccountWithFeatures | `New-RscQueryAws -Operation CloudAccountWithFeatures`<BR> | awsCloudAccountWithFeatures |
| CloudAccountsWithFeatures | `New-RscQueryAws -Operation CloudAccountsWithFeatures`<BR> | allAwsCloudAccountsWithFeatures |
| ComputeSettings | `New-RscQueryAws -Operation ComputeSettings`<BR> | awsComputeSettings |
| DbParameterGroupsByRegion | `New-RscQueryAws -Operation DbParameterGroupsByRegion`<BR> | allDbParameterGroupsByRegionFromAws |
| DbSubnetGroupsByRegion | `New-RscQueryAws -Operation DbSubnetGroupsByRegion`<BR> | allDbSubnetGroupsByRegionFromAws |
| Ec2KeyPairsByRegion | `New-RscQueryAws -Operation Ec2KeyPairsByRegion`<BR> | allEc2KeyPairsByRegionFromAws |
| ExocomputeConfigs | `New-RscQueryAws -Operation ExocomputeConfigs`<BR> | allAwsExocomputeConfigs |
| InstanceProfileNames | `New-RscQueryAws -Operation InstanceProfileNames`<BR> | allAwsInstanceProfileNames |
| IsS3BucketNameAvailable | `New-RscQueryAws -Operation IsS3BucketNameAvailable`<BR> | isAwsS3BucketNameAvailable |
| KmsEncryptionKeysByRegion | `New-RscQueryAws -Operation KmsEncryptionKeysByRegion`<BR> | allKmsEncryptionKeysByRegionFromAws |
| OptionGroupsByRegion | `New-RscQueryAws -Operation OptionGroupsByRegion`<BR> | allOptionGroupsByRegionFromAws |
| PermissionPolicies | `New-RscQueryAws -Operation PermissionPolicies`<BR> | allAwsPermissionPolicies |
| RdsInstanceDetails | `New-RscQueryAws -Operation RdsInstanceDetails`<BR> | rdsInstanceDetailsFromAws |
| Regions | `New-RscQueryAws -Operation Regions`<BR> | allAwsRegions |
| S3BucketStateForRecovery | `New-RscQueryAws -Operation S3BucketStateForRecovery`<BR> | s3BucketStateForRecovery |
| S3Buckets | `New-RscQueryAws -Operation S3Buckets`<BR> | allS3BucketsFromAws |
| S3BucketsDetails | `New-RscQueryAws -Operation S3BucketsDetails`<BR> | allS3BucketsDetailsFromAws |
| SupportedRdsDatabaseInstanceClasses | `New-RscQueryAws -Operation SupportedRdsDatabaseInstanceClasses`<BR> | allSupportedAwsRdsDatabaseInstanceClasses |
| TrustPolicy | `New-RscQueryAws -Operation TrustPolicy`<BR> | awsTrustPolicy |
| Vpcs | `New-RscQueryAws -Operation Vpcs`<BR> | allVpcsFromAws |
| VpcsByRegion | `New-RscQueryAws -Operation VpcsByRegion`<BR> | allVpcsByRegionFromAws |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| AddAuthenticationServerBasedCloudAccount | `New-RscMutationAws -Operation AddAuthenticationServerBasedCloudAccount`<BR> | addAwsAuthenticationServerBasedCloudAccount |
| AddIamUserBasedCloudAccount | `New-RscMutationAws -Operation AddIamUserBasedCloudAccount`<BR> | addAwsIamUserBasedCloudAccount |
| BulkDeleteCloudAccountWithoutCft | `New-RscMutationAws -Operation BulkDeleteCloudAccountWithoutCft`<BR> | bulkDeleteAwsCloudAccountWithoutCft |
| CreateAccount | `New-RscMutationAws -Operation CreateAccount`<BR> | createAwsAccount |
| CreateAutomaticTargetMapping | `New-RscMutationAws -Operation CreateAutomaticTargetMapping`<BR> | createAutomaticAwsTargetMapping |
| CreateCloudNativeStorageSetting | `New-RscMutationAws -Operation CreateCloudNativeStorageSetting`<BR> | createCloudNativeAwsStorageSetting |
| CreateCluster | `New-RscMutationAws -Operation CreateCluster`<BR> | createAwsCluster |
| CreateComputeSetting | `New-RscMutationAws -Operation CreateComputeSetting`<BR> | createAwsComputeSetting |
| CreateExocomputeConfigs | `New-RscMutationAws -Operation CreateExocomputeConfigs`<BR> | createAwsExocomputeConfigs |
| CreateReaderTarget | `New-RscMutationAws -Operation CreateReaderTarget`<BR> | createAwsReaderTarget |
| CreateTarget | `New-RscMutationAws -Operation CreateTarget`<BR> | createAwsTarget |
| DeleteCluster | `New-RscMutationAws -Operation DeleteCluster`<BR> | deleteAwsCluster |
| DeleteComputeSetting | `New-RscMutationAws -Operation DeleteComputeSetting`<BR> | deleteAwsComputeSetting |
| DeleteExocomputeConfigs | `New-RscMutationAws -Operation DeleteExocomputeConfigs`<BR> | deleteAwsExocomputeConfigs |
| FinalizeCloudAccountDeletion | `New-RscMutationAws -Operation FinalizeCloudAccountDeletion`<BR> | finalizeAwsCloudAccountDeletion |
| FinalizeCloudAccountProtection | `New-RscMutationAws -Operation FinalizeCloudAccountProtection`<BR> | finalizeAwsCloudAccountProtection |
| PatchAuthenticationServerBasedCloudAccount | `New-RscMutationAws -Operation PatchAuthenticationServerBasedCloudAccount`<BR> | patchAwsAuthenticationServerBasedCloudAccount |
| PatchIamUserBasedCloudAccount | `New-RscMutationAws -Operation PatchIamUserBasedCloudAccount`<BR> | patchAwsIamUserBasedCloudAccount |
| PrepareCloudAccountDeletion | `New-RscMutationAws -Operation PrepareCloudAccountDeletion`<BR> | prepareAwsCloudAccountDeletion |
| PrepareFeatureUpdateForCloudAccount | `New-RscMutationAws -Operation PrepareFeatureUpdateForCloudAccount`<BR> | prepareFeatureUpdateForAwsCloudAccount |
| RegisterFeatureArtifacts | `New-RscMutationAws -Operation RegisterFeatureArtifacts`<BR> | registerAwsFeatureArtifacts |
| StartExocomputeDisableJob | `New-RscMutationAws -Operation StartExocomputeDisableJob`<BR> | startAwsExocomputeDisableJob |
| UpdateAccount | `New-RscMutationAws -Operation UpdateAccount`<BR> | updateAwsAccount |
| UpdateAutomaticTargetMapping | `New-RscMutationAws -Operation UpdateAutomaticTargetMapping`<BR> | updateAutomaticAwsTargetMapping |
| UpdateCloudAccount | `New-RscMutationAws -Operation UpdateCloudAccount`<BR> | updateAwsCloudAccount |
| UpdateCloudAccountFeature | `New-RscMutationAws -Operation UpdateCloudAccountFeature`<BR> | updateAwsCloudAccountFeature |
| UpdateCloudNativeStorageSetting | `New-RscMutationAws -Operation UpdateCloudNativeStorageSetting`<BR> | updateCloudNativeAwsStorageSetting |
| UpdateComputeSetting | `New-RscMutationAws -Operation UpdateComputeSetting`<BR> | updateAwsComputeSetting |
| UpdateExocomputeConfigs | `New-RscMutationAws -Operation UpdateExocomputeConfigs`<BR> | updateAwsExocomputeConfigs |
| UpdateTarget | `New-RscMutationAws -Operation UpdateTarget`<BR> | updateAwsTarget |
| UpgradeCloudAccountFeaturesWithoutCft | `New-RscMutationAws -Operation UpgradeCloudAccountFeaturesWithoutCft`<BR> | upgradeAwsCloudAccountFeaturesWithoutCft |
| UpgradeIamUserBasedCloudAccountPermissions | `New-RscMutationAws -Operation UpgradeIamUserBasedCloudAccountPermissions`<BR> | upgradeAwsIamUserBasedCloudAccountPermissions |
| ValidateAndCreateCloudAccount | `New-RscMutationAws -Operation ValidateAndCreateCloudAccount`<BR> | validateAndCreateAwsCloudAccount |

[Go to top](#)
## AWS Native domain

Domain key: AwsNative

Cmdlets: `New-RscQueryAwsNative` and `New-RscMutationAwsNative`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| Account | `New-RscQueryAwsNative -Operation Account`<BR> | awsNativeAccount |
| Accounts | `New-RscQueryAwsNative -Operation Accounts`<BR> | awsNativeAccounts |
| AmiTypeForArchivedSnapshotExport | `New-RscQueryAwsNative -Operation AmiTypeForArchivedSnapshotExport`<BR> | amiTypeForAwsNativeArchivedSnapshotExport |
| EbsVolume | `New-RscQueryAwsNative -Operation EbsVolume`<BR> | awsNativeEbsVolume |
| EbsVolumes | `New-RscQueryAwsNative -Operation EbsVolumes`<BR> | awsNativeEbsVolumes |
| EbsVolumesByName | `New-RscQueryAwsNative -Operation EbsVolumesByName`<BR> | awsNativeEbsVolumesByName |
| Ec2Instance | `New-RscQueryAwsNative -Operation Ec2Instance`<BR> | awsNativeEc2Instance |
| Ec2Instances | `New-RscQueryAwsNative -Operation Ec2Instances`<BR> | awsNativeEc2Instances |
| Ec2InstancesByName | `New-RscQueryAwsNative -Operation Ec2InstancesByName`<BR> | awsNativeEc2InstancesByName |
| IsEbsVolumeSnapshotRestorable | `New-RscQueryAwsNative -Operation IsEbsVolumeSnapshotRestorable`<BR> | isAwsNativeEbsVolumeSnapshotRestorable |
| IsRdsInstanceLaunchConfigurationValid | `New-RscQueryAwsNative -Operation IsRdsInstanceLaunchConfigurationValid`<BR> | isAwsNativeRdsInstanceLaunchConfigurationValid |
| RdsExportDefaults | `New-RscQueryAwsNative -Operation RdsExportDefaults`<BR> | awsNativeRdsExportDefaults |
| RdsInstance | `New-RscQueryAwsNative -Operation RdsInstance`<BR> | awsNativeRdsInstance |
| RdsInstances | `New-RscQueryAwsNative -Operation RdsInstances`<BR> | awsNativeRdsInstances |
| RdsPointInTimeRestoreWindow | `New-RscQueryAwsNative -Operation RdsPointInTimeRestoreWindow`<BR> | awsNativeRdsPointInTimeRestoreWindow |
| Root | `New-RscQueryAwsNative -Operation Root`<BR> | awsNativeRoot |
| S3Bucket | `New-RscQueryAwsNative -Operation S3Bucket`<BR> | awsNativeS3Bucket |
| ValidateRdsClusterNameForExport | `New-RscQueryAwsNative -Operation ValidateRdsClusterNameForExport`<BR> | validateAwsNativeRdsClusterNameForExport |
| ValidateRdsInstanceNameForExport | `New-RscQueryAwsNative -Operation ValidateRdsInstanceNameForExport`<BR> | validateAwsNativeRdsInstanceNameForExport |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| ExcludeEbsVolumesFromSnapshot | `New-RscMutationAwsNative -Operation ExcludeEbsVolumesFromSnapshot`<BR> | excludeAwsNativeEbsVolumesFromSnapshot |
| StartAccountDisableJob | `New-RscMutationAwsNative -Operation StartAccountDisableJob`<BR> | startAwsNativeAccountDisableJob |
| StartCreateEbsVolumeSnapshotsJob | `New-RscMutationAwsNative -Operation StartCreateEbsVolumeSnapshotsJob`<BR> | startCreateAwsNativeEbsVolumeSnapshotsJob |
| StartEc2InstanceSnapshotsJob | `New-RscMutationAwsNative -Operation StartEc2InstanceSnapshotsJob`<BR> | startAwsNativeEc2InstanceSnapshotsJob |
| StartExportEbsVolumeSnapshotJob | `New-RscMutationAwsNative -Operation StartExportEbsVolumeSnapshotJob`<BR> | startExportAwsNativeEbsVolumeSnapshotJob |
| StartRdsInstanceSnapshotsJob | `New-RscMutationAwsNative -Operation StartRdsInstanceSnapshotsJob`<BR> | startAwsNativeRdsInstanceSnapshotsJob |
| StartRefreshAccountsJob | `New-RscMutationAwsNative -Operation StartRefreshAccountsJob`<BR> | startRefreshAwsNativeAccountsJob |
| StartRestoreEc2InstanceSnapshotJob | `New-RscMutationAwsNative -Operation StartRestoreEc2InstanceSnapshotJob`<BR> | startRestoreAwsNativeEc2InstanceSnapshotJob |

[Go to top](#)
## Azure domain

Domain key: Azure

Cmdlets: `New-RscQueryAzure` and `New-RscMutationAzure`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| AdDirectories | `New-RscQueryAzure -Operation AdDirectories`<BR> | azureAdDirectories |
| AdDirectory | `New-RscQueryAzure -Operation AdDirectory`<BR> | azureAdDirectory |
| AdObjectsByType | `New-RscQueryAzure -Operation AdObjectsByType`<BR> | azureAdObjectsByType |
| ArmTemplatesByFeature | `New-RscQueryAzure -Operation ArmTemplatesByFeature`<BR> | allAzureArmTemplatesByFeature |
| CdmVersions | `New-RscQueryAzure -Operation CdmVersions`<BR> | allAzureCdmVersions |
| CheckPersistentStorageSubscriptionCanUnmap | `New-RscQueryAzure -Operation CheckPersistentStorageSubscriptionCanUnmap`<BR> | checkAzurePersistentStorageSubscriptionCanUnmap |
| CloudAccountMissingPermissions | `New-RscQueryAzure -Operation CloudAccountMissingPermissions`<BR> | allAzureCloudAccountMissingPermissions |
| CloudAccountPermissionConfig | `New-RscQueryAzure -Operation CloudAccountPermissionConfig`<BR> | azureCloudAccountPermissionConfig |
| CloudAccountSubnetsByRegion | `New-RscQueryAzure -Operation CloudAccountSubnetsByRegion`<BR> | allAzureCloudAccountSubnetsByRegion |
| CloudAccountSubscriptionWithFeatures | `New-RscQueryAzure -Operation CloudAccountSubscriptionWithFeatures`<BR> | azureCloudAccountSubscriptionWithFeatures |
| CloudAccountSubscriptionsByFeature | `New-RscQueryAzure -Operation CloudAccountSubscriptionsByFeature`<BR> | allAzureCloudAccountSubscriptionsByFeature |
| CloudAccountTenant | `New-RscQueryAzure -Operation CloudAccountTenant`<BR> | azureCloudAccountTenant |
| CloudAccountTenantWithExoConfigs | `New-RscQueryAzure -Operation CloudAccountTenantWithExoConfigs`<BR> | azureCloudAccountTenantWithExoConfigs |
| CloudAccountTenants | `New-RscQueryAzure -Operation CloudAccountTenants`<BR> | allAzureCloudAccountTenants |
| DiskEncryptionSetsByRegion | `New-RscQueryAzure -Operation DiskEncryptionSetsByRegion`<BR> | allAzureDiskEncryptionSetsByRegion |
| EncryptionKeys | `New-RscQueryAzure -Operation EncryptionKeys`<BR> | allAzureEncryptionKeys |
| ExocomputeConfigsInAccount | `New-RscQueryAzure -Operation ExocomputeConfigsInAccount`<BR> | allAzureExocomputeConfigsInAccount |
| HostedAzureRegions | `New-RscQueryAzure -Operation HostedAzureRegions`<BR> | allHostedAzureRegions |
| IsStorageAccountNameAvailable | `New-RscQueryAzure -Operation IsStorageAccountNameAvailable`<BR> | isAzureStorageAccountNameAvailable |
| KeyVaultsByRegion | `New-RscQueryAzure -Operation KeyVaultsByRegion`<BR> | allAzureKeyVaultsByRegion |
| ManagedIdentities | `New-RscQueryAzure -Operation ManagedIdentities`<BR> | allAzureManagedIdentities |
| Nsgs | `New-RscQueryAzure -Operation Nsgs`<BR> | allAzureNsgs |
| Regions | `New-RscQueryAzure -Operation Regions`<BR> | azureRegions |
| ResourceGroups | `New-RscQueryAzure -Operation ResourceGroups`<BR> | allResourceGroupsFromAzure |
| SearchAdSnapshot | `New-RscQueryAzure -Operation SearchAdSnapshot`<BR> | searchAzureAdSnapshot |
| SqlDatabase | `New-RscQueryAzure -Operation SqlDatabase`<BR> | azureSqlDatabase |
| SqlDatabaseDbPointInTimeRestoreWindowFromAzure | `New-RscQueryAzure -Operation SqlDatabaseDbPointInTimeRestoreWindowFromAzure`<BR> | azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure |
| SqlDatabaseServer | `New-RscQueryAzure -Operation SqlDatabaseServer`<BR> | azureSqlDatabaseServer |
| SqlDatabaseServerElasticPools | `New-RscQueryAzure -Operation SqlDatabaseServerElasticPools`<BR> | allAzureSqlDatabaseServerElasticPools |
| SqlDatabaseServers | `New-RscQueryAzure -Operation SqlDatabaseServers`<BR> | azureSqlDatabaseServers |
| SqlDatabases | `New-RscQueryAzure -Operation SqlDatabases`<BR> | azureSqlDatabases |
| SqlManagedInstanceDatabase | `New-RscQueryAzure -Operation SqlManagedInstanceDatabase`<BR> | azureSqlManagedInstanceDatabase |
| SqlManagedInstanceDatabases | `New-RscQueryAzure -Operation SqlManagedInstanceDatabases`<BR> | azureSqlManagedInstanceDatabases |
| SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure | `New-RscQueryAzure -Operation SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure`<BR> | azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure |
| SqlManagedInstanceServer | `New-RscQueryAzure -Operation SqlManagedInstanceServer`<BR> | azureSqlManagedInstanceServer |
| SqlManagedInstanceServers | `New-RscQueryAzure -Operation SqlManagedInstanceServers`<BR> | azureSqlManagedInstanceServers |
| StorageAccounts | `New-RscQueryAzure -Operation StorageAccounts`<BR> | azureStorageAccounts |
| Subnets | `New-RscQueryAzure -Operation Subnets`<BR> | azureSubnets |
| SubscriptionWithExocomputeMappings | `New-RscQueryAzure -Operation SubscriptionWithExocomputeMappings`<BR> | allAzureSubscriptionWithExocomputeMappings |
| Subscriptions | `New-RscQueryAzure -Operation Subscriptions`<BR> | azureSubscriptions |
| VNets | `New-RscQueryAzure -Operation VNets`<BR> | azureVNets |
| ValidateCloudAccountExocomputeConfigurations | `New-RscQueryAzure -Operation ValidateCloudAccountExocomputeConfigurations`<BR> | validateAzureCloudAccountExocomputeConfigurations |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| AddCloudAccount | `New-RscMutationAzure -Operation AddCloudAccount`<BR> | addAzureCloudAccount |
| AddCloudAccountExocomputeConfigurations | `New-RscMutationAzure -Operation AddCloudAccountExocomputeConfigurations`<BR> | addAzureCloudAccountExocomputeConfigurations |
| AddCloudAccountWithoutOauth | `New-RscMutationAzure -Operation AddCloudAccountWithoutOauth`<BR> | addAzureCloudAccountWithoutOauth |
| BackupAdDirectory | `New-RscMutationAzure -Operation BackupAdDirectory`<BR> | backupAzureAdDirectory |
| CompleteAdAppSetup | `New-RscMutationAzure -Operation CompleteAdAppSetup`<BR> | completeAzureAdAppSetup |
| CompleteAdAppUpdate | `New-RscMutationAzure -Operation CompleteAdAppUpdate`<BR> | completeAzureAdAppUpdate |
| CompleteCloudAccountOauth | `New-RscMutationAzure -Operation CompleteCloudAccountOauth`<BR> | completeAzureCloudAccountOauth |
| CreateAccount | `New-RscMutationAzure -Operation CreateAccount`<BR> | createAzureAccount |
| CreateAutomaticTargetMapping | `New-RscMutationAzure -Operation CreateAutomaticTargetMapping`<BR> | createAutomaticAzureTargetMapping |
| CreateCloudNativeRcvStorageSetting | `New-RscMutationAzure -Operation CreateCloudNativeRcvStorageSetting`<BR> | createCloudNativeRcvAzureStorageSetting |
| CreateCloudNativeStorageSetting | `New-RscMutationAzure -Operation CreateCloudNativeStorageSetting`<BR> | createCloudNativeAzureStorageSetting |
| CreateCluster | `New-RscMutationAzure -Operation CreateCluster`<BR> | createAzureCluster |
| CreateReaderTarget | `New-RscMutationAzure -Operation CreateReaderTarget`<BR> | createAzureReaderTarget |
| CreateSaasAppAad | `New-RscMutationAzure -Operation CreateSaasAppAad`<BR> | createAzureSaasAppAad |
| CreateTarget | `New-RscMutationAzure -Operation CreateTarget`<BR> | createAzureTarget |
| DeleteAdDirectory | `New-RscMutationAzure -Operation DeleteAdDirectory`<BR> | deleteAzureAdDirectory |
| DeleteCloudAccount | `New-RscMutationAzure -Operation DeleteCloudAccount`<BR> | deleteAzureCloudAccount |
| DeleteCloudAccountExocomputeConfigurations | `New-RscMutationAzure -Operation DeleteCloudAccountExocomputeConfigurations`<BR> | deleteAzureCloudAccountExocomputeConfigurations |
| DeleteCloudAccountWithoutOauth | `New-RscMutationAzure -Operation DeleteCloudAccountWithoutOauth`<BR> | deleteAzureCloudAccountWithoutOauth |
| DeleteCluster | `New-RscMutationAzure -Operation DeleteCluster`<BR> | deleteAzureCluster |
| MapCloudAccountExocomputeSubscription | `New-RscMutationAzure -Operation MapCloudAccountExocomputeSubscription`<BR> | mapAzureCloudAccountExocomputeSubscription |
| MapCloudAccountToPersistentStorageLocation | `New-RscMutationAzure -Operation MapCloudAccountToPersistentStorageLocation`<BR> | mapAzureCloudAccountToPersistentStorageLocation |
| OauthConsentComplete | `New-RscMutationAzure -Operation OauthConsentComplete`<BR> | azureOauthConsentComplete |
| OauthConsentKickoff | `New-RscMutationAzure -Operation OauthConsentKickoff`<BR> | azureOauthConsentKickoff |
| RestoreAdObjectsWithPasswords | `New-RscMutationAzure -Operation RestoreAdObjectsWithPasswords`<BR> | restoreAzureAdObjectsWithPasswords |
| SetCloudAccountCustomerAppCredentials | `New-RscMutationAzure -Operation SetCloudAccountCustomerAppCredentials`<BR> | setAzureCloudAccountCustomerAppCredentials |
| StartAdAppSetup | `New-RscMutationAzure -Operation StartAdAppSetup`<BR> | startAzureAdAppSetup |
| StartAdAppUpdate | `New-RscMutationAzure -Operation StartAdAppUpdate`<BR> | startAzureAdAppUpdate |
| StartCloudAccountOauth | `New-RscMutationAzure -Operation StartCloudAccountOauth`<BR> | startAzureCloudAccountOauth |
| StartDisableCloudAccountJob | `New-RscMutationAzure -Operation StartDisableCloudAccountJob`<BR> | startDisableAzureCloudAccountJob |
| StartExportSqlDatabaseDbJob | `New-RscMutationAzure -Operation StartExportSqlDatabaseDbJob`<BR> | startExportAzureSqlDatabaseDbJob |
| StartExportSqlManagedInstanceDbJob | `New-RscMutationAzure -Operation StartExportSqlManagedInstanceDbJob`<BR> | startExportAzureSqlManagedInstanceDbJob |
| UnmapCloudAccountExocomputeSubscription | `New-RscMutationAzure -Operation UnmapCloudAccountExocomputeSubscription`<BR> | unmapAzureCloudAccountExocomputeSubscription |
| UnmapPersistentStorageSubscription | `New-RscMutationAzure -Operation UnmapPersistentStorageSubscription`<BR> | unmapAzurePersistentStorageSubscription |
| UpdateAccount | `New-RscMutationAzure -Operation UpdateAccount`<BR> | updateAzureAccount |
| UpdateAutomaticTargetMapping | `New-RscMutationAzure -Operation UpdateAutomaticTargetMapping`<BR> | updateAutomaticAzureTargetMapping |
| UpdateCloudAccount | `New-RscMutationAzure -Operation UpdateCloudAccount`<BR> | updateAzureCloudAccount |
| UpdateCloudNativeRcvStorageSetting | `New-RscMutationAzure -Operation UpdateCloudNativeRcvStorageSetting`<BR> | updateCloudNativeRcvAzureStorageSetting |
| UpdateCloudNativeStorageSetting | `New-RscMutationAzure -Operation UpdateCloudNativeStorageSetting`<BR> | updateCloudNativeAzureStorageSetting |
| UpdateCustomerAppPermissionForSql | `New-RscMutationAzure -Operation UpdateCustomerAppPermissionForSql`<BR> | updateCustomerAppPermissionForAzureSql |
| UpdateTarget | `New-RscMutationAzure -Operation UpdateTarget`<BR> | updateAzureTarget |
| UpgradeCloudAccount | `New-RscMutationAzure -Operation UpgradeCloudAccount`<BR> | upgradeAzureCloudAccount |
| UpgradeCloudAccountPermissionsWithoutOauth | `New-RscMutationAzure -Operation UpgradeCloudAccountPermissionsWithoutOauth`<BR> | upgradeAzureCloudAccountPermissionsWithoutOauth |

[Go to top](#)
## Azure Native domain

Domain key: AzureNative

Cmdlets: `New-RscQueryAzureNative` and `New-RscMutationAzureNative`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| AvailabilitySetsByRegionFromAzure | `New-RscQueryAzureNative -Operation AvailabilitySetsByRegionFromAzure`<BR> | allAzureNativeAvailabilitySetsByRegionFromAzure |
| DoesResourceGroupExist | `New-RscQueryAzureNative -Operation DoesResourceGroupExist`<BR> | doesAzureNativeResourceGroupExist |
| ExportCompatibleDiskTypesByRegionFromAzure | `New-RscQueryAzureNative -Operation ExportCompatibleDiskTypesByRegionFromAzure`<BR> | allAzureNativeExportCompatibleDiskTypesByRegionFromAzure |
| ExportCompatibleVmSizesByRegionFromAzure | `New-RscQueryAzureNative -Operation ExportCompatibleVmSizesByRegionFromAzure`<BR> | allAzureNativeExportCompatibleVmSizesByRegionFromAzure |
| IsManagedDiskSnapshotRestorable | `New-RscQueryAzureNative -Operation IsManagedDiskSnapshotRestorable`<BR> | isAzureNativeManagedDiskSnapshotRestorable |
| IsSqlDatabaseSnapshotPersistent | `New-RscQueryAzureNative -Operation IsSqlDatabaseSnapshotPersistent`<BR> | isAzureNativeSqlDatabaseSnapshotPersistent |
| ManagedDisk | `New-RscQueryAzureNative -Operation ManagedDisk`<BR> | azureNativeManagedDisk |
| ManagedDisks | `New-RscQueryAzureNative -Operation ManagedDisks`<BR> | azureNativeManagedDisks |
| ResourceGroup | `New-RscQueryAzureNative -Operation ResourceGroup`<BR> | azureNativeResourceGroup |
| ResourceGroups | `New-RscQueryAzureNative -Operation ResourceGroups`<BR> | azureNativeResourceGroups |
| ResourceGroupsInfoIfExist | `New-RscQueryAzureNative -Operation ResourceGroupsInfoIfExist`<BR> | allAzureNativeResourceGroupsInfoIfExist |
| Root | `New-RscQueryAzureNative -Operation Root`<BR> | azureNativeRoot |
| SecurityGroupsByRegionFromAzure | `New-RscQueryAzureNative -Operation SecurityGroupsByRegionFromAzure`<BR> | allAzureNativeSecurityGroupsByRegionFromAzure |
| StorageAccountsFromAzure | `New-RscQueryAzureNative -Operation StorageAccountsFromAzure`<BR> | allAzureNativeStorageAccountsFromAzure |
| SubnetsByRegionFromAzure | `New-RscQueryAzureNative -Operation SubnetsByRegionFromAzure`<BR> | allAzureNativeSubnetsByRegionFromAzure |
| Subscription | `New-RscQueryAzureNative -Operation Subscription`<BR> | azureNativeSubscription |
| Subscriptions | `New-RscQueryAzureNative -Operation Subscriptions`<BR> | azureNativeSubscriptions |
| ValidateSqlDatabaseDbNameForExport | `New-RscQueryAzureNative -Operation ValidateSqlDatabaseDbNameForExport`<BR> | validateAzureNativeSqlDatabaseDbNameForExport |
| ValidateSqlManagedInstanceDbNameForExport | `New-RscQueryAzureNative -Operation ValidateSqlManagedInstanceDbNameForExport`<BR> | validateAzureNativeSqlManagedInstanceDbNameForExport |
| VirtualMachine | `New-RscQueryAzureNative -Operation VirtualMachine`<BR> | azureNativeVirtualMachine |
| VirtualMachineSizes | `New-RscQueryAzureNative -Operation VirtualMachineSizes`<BR> | allAzureNativeVirtualMachineSizes |
| VirtualMachines | `New-RscQueryAzureNative -Operation VirtualMachines`<BR> | azureNativeVirtualMachines |
| VirtualNetworks | `New-RscQueryAzureNative -Operation VirtualNetworks`<BR> | allAzureNativeVirtualNetworks |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| ExcludeManagedDisksFromSnapshot | `New-RscMutationAzureNative -Operation ExcludeManagedDisksFromSnapshot`<BR> | excludeAzureNativeManagedDisksFromSnapshot |
| StartCreateManagedDiskSnapshotsJob | `New-RscMutationAzureNative -Operation StartCreateManagedDiskSnapshotsJob`<BR> | startCreateAzureNativeManagedDiskSnapshotsJob |
| StartCreateVirtualMachineSnapshotsJob | `New-RscMutationAzureNative -Operation StartCreateVirtualMachineSnapshotsJob`<BR> | startCreateAzureNativeVirtualMachineSnapshotsJob |
| StartDisableSubscriptionProtectionJob | `New-RscMutationAzureNative -Operation StartDisableSubscriptionProtectionJob`<BR> | startDisableAzureNativeSubscriptionProtectionJob |
| StartExportManagedDiskJob | `New-RscMutationAzureNative -Operation StartExportManagedDiskJob`<BR> | startExportAzureNativeManagedDiskJob |
| StartExportVirtualMachineJob | `New-RscMutationAzureNative -Operation StartExportVirtualMachineJob`<BR> | startExportAzureNativeVirtualMachineJob |
| StartRefreshSubscriptionsJob | `New-RscMutationAzureNative -Operation StartRefreshSubscriptionsJob`<BR> | startRefreshAzureNativeSubscriptionsJob |
| StartRestoreVirtualMachineJob | `New-RscMutationAzureNative -Operation StartRestoreVirtualMachineJob`<BR> | startRestoreAzureNativeVirtualMachineJob |

[Go to top](#)
## AzureO365 domain

Domain key: AzureO365

Cmdlets: `New-RscQueryAzureO365` and `New-RscMutationAzureO365`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| CheckNSGOutboundRules | `New-RscQueryAzureO365 -Operation CheckNSGOutboundRules`<BR> | azureO365CheckNSGOutboundRules |
| CheckNetworkSubnet | `New-RscQueryAzureO365 -Operation CheckNetworkSubnet`<BR> | azureO365CheckNetworkSubnet |
| CheckResourceGroupName | `New-RscQueryAzureO365 -Operation CheckResourceGroupName`<BR> | azureO365CheckResourceGroupName |
| CheckStorageAccountAccessibility | `New-RscQueryAzureO365 -Operation CheckStorageAccountAccessibility`<BR> | azureO365CheckStorageAccountAccessibility |
| CheckStorageAccountName | `New-RscQueryAzureO365 -Operation CheckStorageAccountName`<BR> | azureO365CheckStorageAccountName |
| CheckSubscriptionQuota | `New-RscQueryAzureO365 -Operation CheckSubscriptionQuota`<BR> | azureO365CheckSubscriptionQuota |
| CheckVirtualNetworkName | `New-RscQueryAzureO365 -Operation CheckVirtualNetworkName`<BR> | azureO365CheckVirtualNetworkName |
| Exocompute | `New-RscQueryAzureO365 -Operation Exocompute`<BR> | azureO365Exocompute |
| GetAzureHostType | `New-RscQueryAzureO365 -Operation GetAzureHostType`<BR> | azureO365GetAzureHostType |
| GetNetworkSubnetUnusedAddr | `New-RscQueryAzureO365 -Operation GetNetworkSubnetUnusedAddr`<BR> | azureO365GetNetworkSubnetUnusedAddr |
| ValidateUserRoles | `New-RscQueryAzureO365 -Operation ValidateUserRoles`<BR> | azureO365ValidateUserRoles |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| SetupExocompute | `New-RscMutationAzureO365 -Operation SetupExocompute`<BR> | setupAzureO365Exocompute |

[Go to top](#)
## Cassandra domain

Domain key: Cassandra

Cmdlets: `New-RscQueryCassandra` and `New-RscMutationCassandra`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| ColumnFamilies | `New-RscQueryCassandra -Operation ColumnFamilies`<BR> | cassandraColumnFamilies |
| ColumnFamily | `New-RscQueryCassandra -Operation ColumnFamily`<BR> | cassandraColumnFamily |
| ColumnFamilyRecoverableRange | `New-RscQueryCassandra -Operation ColumnFamilyRecoverableRange`<BR> | cassandraColumnFamilyRecoverableRange |
| ColumnFamilySchema | `New-RscQueryCassandra -Operation ColumnFamilySchema`<BR> | cassandraColumnFamilySchema |
| Keyspace | `New-RscQueryCassandra -Operation Keyspace`<BR> | cassandraKeyspace |
| Keyspaces | `New-RscQueryCassandra -Operation Keyspaces`<BR> | cassandraKeyspaces |
| Source | `New-RscQueryCassandra -Operation Source`<BR> | cassandraSource |
| Sources | `New-RscQueryCassandra -Operation Sources`<BR> | cassandraSources |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| BulkDeleteSources | `New-RscMutationCassandra -Operation BulkDeleteSources`<BR> | bulkDeleteCassandraSources |
| CreateSource | `New-RscMutationCassandra -Operation CreateSource`<BR> | createCassandraSource |
| DeleteSource | `New-RscMutationCassandra -Operation DeleteSource`<BR> | deleteCassandraSource |
| RecoverSource | `New-RscMutationCassandra -Operation RecoverSource`<BR> | recoverCassandraSource |
| UpdateSource | `New-RscMutationCassandra -Operation UpdateSource`<BR> | updateCassandraSource |

[Go to top](#)
## Certificates domain

Domain key: Certificate

Cmdlets: `New-RscQueryCertificate` and `New-RscMutationCertificate`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| Certificate | `New-RscQueryCertificate -Operation Certificate`<BR> | certificates |
| Cluster | `New-RscQueryCertificate -Operation Cluster`<BR> | clusterCertificates |
| ClusterWebSigned | `New-RscQueryCertificate -Operation ClusterWebSigned`<BR> | clusterWebSignedCertificate |
| SigningRequest | `New-RscQueryCertificate -Operation SigningRequest`<BR> | certificateSigningRequest |
| SigningRequests | `New-RscQueryCertificate -Operation SigningRequests`<BR> | certificateSigningRequests |
| WithKey | `New-RscQueryCertificate -Operation WithKey`<BR> | certificatesWithKey |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| AddClusterCertificate | `New-RscMutationCertificate -Operation AddClusterCertificate`<BR> | addClusterCertificate |
| Delete | `New-RscMutationCertificate -Operation Delete`<BR> | deleteCertificate |
| SetSso | `New-RscMutationCertificate -Operation SetSso`<BR> | setSsoCertificate |
| SetWebSigned | `New-RscMutationCertificate -Operation SetWebSigned`<BR> | setWebSignedCertificate |
| Update | `New-RscMutationCertificate -Operation Update`<BR> | updateCertificate |
| UpdateHost | `New-RscMutationCertificate -Operation UpdateHost`<BR> | updateCertificateHost |

[Go to top](#)
## Cloud Account domain

Domain key: CloudAccount

Cmdlets: `New-RscQueryCloudAccount` and `New-RscMutationCloudAccount`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| CloudAccount | `New-RscQueryCloudAccount -Operation CloudAccount`<BR> | cloudAccount |
| CurrentFeaturePermissionsFors | `New-RscQueryCloudAccount -Operation CurrentFeaturePermissionsFors`<BR> | allCurrentFeaturePermissionsForCloudAccounts |
| ExocomputeMappings | `New-RscQueryCloudAccount -Operation ExocomputeMappings`<BR> | allCloudAccountExocomputeMappings |
| LatestFeaturePermissionsFors | `New-RscQueryCloudAccount -Operation LatestFeaturePermissionsFors`<BR> | allLatestFeaturePermissionsForCloudAccounts |
| s | `New-RscQueryCloudAccount -Operation s`<BR> | allCloudAccounts |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| MapExocomputeAccount | `New-RscMutationCloudAccount -Operation MapExocomputeAccount`<BR> | mapCloudAccountExocomputeAccount |
| UnmapExocomputeAccount | `New-RscMutationCloudAccount -Operation UnmapExocomputeAccount`<BR> | unmapCloudAccountExocomputeAccount |

[Go to top](#)
## Cloud Native domain

Domain key: CloudNative

Cmdlets: `New-RscQueryCloudNative` and `New-RscMutationCloudNative`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| CheckArchivedSnapshotsLocked | `New-RscQueryCloudNative -Operation CheckArchivedSnapshotsLocked`<BR> | cloudNativeCheckArchivedSnapshotsLocked |
| CheckLabelRuleNameUniqueness | `New-RscQueryCloudNative -Operation CheckLabelRuleNameUniqueness`<BR> | checkCloudNativeLabelRuleNameUniqueness |
| CheckRequiredPermissionsForFeature | `New-RscQueryCloudNative -Operation CheckRequiredPermissionsForFeature`<BR> | cloudNativeCheckRequiredPermissionsForFeature |
| CheckTagRuleNameUniqueness | `New-RscQueryCloudNative -Operation CheckTagRuleNameUniqueness`<BR> | checkCloudNativeTagRuleNameUniqueness |
| CustomerTags | `New-RscQueryCloudNative -Operation CustomerTags`<BR> | cloudNativeCustomerTags |
| FileRecoveryEligibleSnapshots | `New-RscQueryCloudNative -Operation FileRecoveryEligibleSnapshots`<BR> | allCloudNativeFileRecoveryEligibleSnapshots |
| IsFileRecoveryFeasible | `New-RscQueryCloudNative -Operation IsFileRecoveryFeasible`<BR> | isCloudNativeFileRecoveryFeasible |
| LabelKeys | `New-RscQueryCloudNative -Operation LabelKeys`<BR> | allCloudNativeLabelKeys |
| LabelRules | `New-RscQueryCloudNative -Operation LabelRules`<BR> | cloudNativeLabelRules |
| LabelValues | `New-RscQueryCloudNative -Operation LabelValues`<BR> | allCloudNativeLabelValues |
| RbaInstallers | `New-RscQueryCloudNative -Operation RbaInstallers`<BR> | cloudNativeRbaInstallers |
| SnapshotDetailsForRecovery | `New-RscQueryCloudNative -Operation SnapshotDetailsForRecovery`<BR> | cloudNativeSnapshotDetailsForRecovery |
| SnapshotTypeDetails | `New-RscQueryCloudNative -Operation SnapshotTypeDetails`<BR> | cloudNativeSnapshotTypeDetails |
| Snapshots | `New-RscQueryCloudNative -Operation Snapshots`<BR> | cloudNativeSnapshots |
| SqlServerSetupScript | `New-RscQueryCloudNative -Operation SqlServerSetupScript`<BR> | cloudNativeSqlServerSetupScript |
| TagKeys | `New-RscQueryCloudNative -Operation TagKeys`<BR> | allCloudNativeTagKeys |
| TagRules | `New-RscQueryCloudNative -Operation TagRules`<BR> | cloudNativeTagRules |
| TagValues | `New-RscQueryCloudNative -Operation TagValues`<BR> | allCloudNativeTagValues |
| WorkloadVersionedFiles | `New-RscQueryCloudNative -Operation WorkloadVersionedFiles`<BR> | cloudNativeWorkloadVersionedFiles |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| AddSqlServerBackupCredentials | `New-RscMutationCloudNative -Operation AddSqlServerBackupCredentials`<BR> | addCloudNativeSqlServerBackupCredentials |
| CheckRbaConnectivity | `New-RscMutationCloudNative -Operation CheckRbaConnectivity`<BR> | cloudNativeCheckRbaConnectivity |
| ClearSqlServerBackupCredentials | `New-RscMutationCloudNative -Operation ClearSqlServerBackupCredentials`<BR> | clearCloudNativeSqlServerBackupCredentials |
| CreateLabelRule | `New-RscMutationCloudNative -Operation CreateLabelRule`<BR> | createCloudNativeLabelRule |
| CreateTagRule | `New-RscMutationCloudNative -Operation CreateTagRule`<BR> | createCloudNativeTagRule |
| DeleteLabelRule | `New-RscMutationCloudNative -Operation DeleteLabelRule`<BR> | deleteCloudNativeLabelRule |
| DeleteTagRule | `New-RscMutationCloudNative -Operation DeleteTagRule`<BR> | deleteCloudNativeTagRule |
| DownloadFiles | `New-RscMutationCloudNative -Operation DownloadFiles`<BR> | cloudNativeDownloadFiles |
| SetupSqlServerBackup | `New-RscMutationCloudNative -Operation SetupSqlServerBackup`<BR> | setupCloudNativeSqlServerBackup |
| StartSnapshotsIndexJob | `New-RscMutationCloudNative -Operation StartSnapshotsIndexJob`<BR> | startCloudNativeSnapshotsIndexJob |
| UpdateIndexingStatus | `New-RscMutationCloudNative -Operation UpdateIndexingStatus`<BR> | updateCloudNativeIndexingStatus |
| UpdateLabelRule | `New-RscMutationCloudNative -Operation UpdateLabelRule`<BR> | updateCloudNativeLabelRule |
| UpdateTagRule | `New-RscMutationCloudNative -Operation UpdateTagRule`<BR> | updateCloudNativeTagRule |

[Go to top](#)
## Cluster domain

Domain key: Cluster

Cmdlets: `New-RscQueryCluster` and `New-RscMutationCluster`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| Cluster | `New-RscQueryCluster -Operation Cluster`<BR> | cluster |
| Connected | `New-RscQueryCluster -Operation Connected`<BR> | allConnectedClusters |
| DatabaseLogReport | `New-RscQueryCluster -Operation DatabaseLogReport`<BR> | databaseLogReportForCluster |
| DatabaseLogReportingProperties | `New-RscQueryCluster -Operation DatabaseLogReportingProperties`<BR> | databaseLogReportingPropertiesForCluster |
| DefaultGateway | `New-RscQueryCluster -Operation DefaultGateway`<BR> | clusterDefaultGateway |
| Dns | `New-RscQueryCluster -Operation Dns`<BR> | clusterDns |
| FloatingIps | `New-RscQueryCluster -Operation FloatingIps`<BR> | clusterFloatingIps |
| GroupByList | `New-RscQueryCluster -Operation GroupByList`<BR> | clusterGroupByConnection |
| HostFailover | `New-RscQueryCluster -Operation HostFailover`<BR> | hostFailoverCluster |
| Ipmi | `New-RscQueryCluster -Operation Ipmi`<BR> | clusterIpmi |
| Ipv6Mode | `New-RscQueryCluster -Operation Ipv6Mode`<BR> | clusterIpv6Mode |
| IsTotpAckNecessary | `New-RscQueryCluster -Operation IsTotpAckNecessary`<BR> | isTotpAckNecessaryForCluster |
| List | `New-RscQueryCluster -Operation List`<BR> | clusterConnection |
| NetworkInterfaces | `New-RscQueryCluster -Operation NetworkInterfaces`<BR> | clusterNetworkInterfaces |
| Nodes | `New-RscQueryCluster -Operation Nodes`<BR> | clusterNodes |
| NtpServers | `New-RscQueryCluster -Operation NtpServers`<BR> | clusterNtpServers |
| OperationJobProgress | `New-RscQueryCluster -Operation OperationJobProgress`<BR> | clusterOperationJobProgress |
| Proxy | `New-RscQueryCluster -Operation Proxy`<BR> | clusterProxy |
| RegistrationProductInfo | `New-RscQueryCluster -Operation RegistrationProductInfo`<BR> | clusterRegistrationProductInfo |
| ReplicationTargets | `New-RscQueryCluster -Operation ReplicationTargets`<BR> | allClusterReplicationTargets |
| ReportMigrationCount | `New-RscQueryCluster -Operation ReportMigrationCount`<BR> | clusterReportMigrationCount |
| ReportMigrationJobStatus | `New-RscQueryCluster -Operation ReportMigrationJobStatus`<BR> | clusterReportMigrationJobStatus |
| ReportMigrationStatus | `New-RscQueryCluster -Operation ReportMigrationStatus`<BR> | clusterReportMigrationStatus |
| TotpAckStatus | `New-RscQueryCluster -Operation TotpAckStatus`<BR> | allClustersTotpAckStatus |
| TypeList | `New-RscQueryCluster -Operation TypeList`<BR> | clusterTypeList |
| Vlans | `New-RscQueryCluster -Operation Vlans`<BR> | clusterVlans |
| WebCertsAndIpmis | `New-RscQueryCluster -Operation WebCertsAndIpmis`<BR> | allClusterWebCertsAndIpmis |
| Windows | `New-RscQueryCluster -Operation Windows`<BR> | windowsCluster |
| WithUpgradesInfo | `New-RscQueryCluster -Operation WithUpgradesInfo`<BR> | clusterWithUpgradesInfo |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| AddNodesToCloud | `New-RscMutationCluster -Operation AddNodesToCloud`<BR> | addNodesToCloudCluster |
| BulkDeleteFailover | `New-RscMutationCluster -Operation BulkDeleteFailover`<BR> | bulkDeleteFailoverCluster |
| CreateFailover | `New-RscMutationCluster -Operation CreateFailover`<BR> | createFailoverCluster |
| DeleteFailover | `New-RscMutationCluster -Operation DeleteFailover`<BR> | deleteFailoverCluster |
| RecoverCloud | `New-RscMutationCluster -Operation RecoverCloud`<BR> | recoverCloudCluster |
| RegisterCloud | `New-RscMutationCluster -Operation RegisterCloud`<BR> | registerCloudCluster |
| RemoveCdm | `New-RscMutationCluster -Operation RemoveCdm`<BR> | removeCdmCluster |
| UpdateDatabaseLogReportingProperties | `New-RscMutationCluster -Operation UpdateDatabaseLogReportingProperties`<BR> | updateDatabaseLogReportingPropertiesForCluster |
| UpdateFailover | `New-RscMutationCluster -Operation UpdateFailover`<BR> | updateFailoverCluster |

[Go to top](#)
## Db2 domain

Domain key: Db2

Cmdlets: `New-RscQueryDb2` and `New-RscMutationDb2`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| Database | `New-RscQueryDb2 -Operation Database`<BR> | db2Database |
| Databases | `New-RscQueryDb2 -Operation Databases`<BR> | db2Databases |
| Instance | `New-RscQueryDb2 -Operation Instance`<BR> | db2Instance |
| Instances | `New-RscQueryDb2 -Operation Instances`<BR> | db2Instances |
| LogSnapshot | `New-RscQueryDb2 -Operation LogSnapshot`<BR> | db2LogSnapshot |
| LogSnapshots | `New-RscQueryDb2 -Operation LogSnapshots`<BR> | db2LogSnapshots |
| RecoverableRange | `New-RscQueryDb2 -Operation RecoverableRange`<BR> | db2RecoverableRange |
| RecoverableRanges | `New-RscQueryDb2 -Operation RecoverableRanges`<BR> | db2RecoverableRanges |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| AddInstance | `New-RscMutationDb2 -Operation AddInstance`<BR> | addDb2Instance |
| CreateOnDemandBackup | `New-RscMutationDb2 -Operation CreateOnDemandBackup`<BR> | createOnDemandDb2Backup |
| DeleteDatabase | `New-RscMutationDb2 -Operation DeleteDatabase`<BR> | deleteDb2Database |
| DeleteInstance | `New-RscMutationDb2 -Operation DeleteInstance`<BR> | deleteDb2Instance |
| DiscoverInstance | `New-RscMutationDb2 -Operation DiscoverInstance`<BR> | discoverDb2Instance |
| DownloadSnapshot | `New-RscMutationDb2 -Operation DownloadSnapshot`<BR> | downloadDb2Snapshot |
| DownloadSnapshotsForPointInTimeRecovery | `New-RscMutationDb2 -Operation DownloadSnapshotsForPointInTimeRecovery`<BR> | downloadDb2SnapshotsForPointInTimeRecovery |
| ExpireDownloadedSnapshots | `New-RscMutationDb2 -Operation ExpireDownloadedSnapshots`<BR> | expireDownloadedDb2Snapshots |
| PatchDatabase | `New-RscMutationDb2 -Operation PatchDatabase`<BR> | patchDb2Database |
| PatchInstance | `New-RscMutationDb2 -Operation PatchInstance`<BR> | patchDb2Instance |
| RefreshDatabase | `New-RscMutationDb2 -Operation RefreshDatabase`<BR> | refreshDb2Database |

[Go to top](#)
## Report Download domain

Domain key: Download

Cmdlets: `New-RscQueryDownload` and `New-RscMutationDownload`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| CdmUpgradesPdf | `New-RscQueryDownload -Operation CdmUpgradesPdf`<BR> | downloadCdmUpgradesPdf |
| EdVersionList | `New-RscQueryDownload -Operation EdVersionList`<BR> | downloadedVersionList |
| PackageStatus | `New-RscQueryDownload -Operation PackageStatus`<BR> | downloadPackageStatus |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| AuditLogCsvAsync | `New-RscMutationDownload -Operation AuditLogCsvAsync`<BR> | downloadAuditLogCsvAsync |
| ExchangeSnapshot | `New-RscMutationDownload -Operation ExchangeSnapshot`<BR> | downloadExchangeSnapshot |
| FilesetSnapshot | `New-RscMutationDownload -Operation FilesetSnapshot`<BR> | downloadFilesetSnapshot |
| FilesetSnapshotFromLocation | `New-RscMutationDownload -Operation FilesetSnapshotFromLocation`<BR> | downloadFilesetSnapshotFromLocation |
| ObjectFilesCsv | `New-RscMutationDownload -Operation ObjectFilesCsv`<BR> | downloadObjectFilesCsv |
| ObjectsListCsv | `New-RscMutationDownload -Operation ObjectsListCsv`<BR> | downloadObjectsListCsv |
| ReportCsvAsync | `New-RscMutationDownload -Operation ReportCsvAsync`<BR> | downloadReportCsvAsync |
| ReportPdfAsync | `New-RscMutationDownload -Operation ReportPdfAsync`<BR> | downloadReportPdfAsync |
| ResultsCsv | `New-RscMutationDownload -Operation ResultsCsv`<BR> | downloadResultsCsv |
| SapHanaSnapshot | `New-RscMutationDownload -Operation SapHanaSnapshot`<BR> | downloadSapHanaSnapshot |
| SapHanaSnapshotFromLocation | `New-RscMutationDownload -Operation SapHanaSnapshotFromLocation`<BR> | downloadSapHanaSnapshotFromLocation |
| SapHanaSnapshotsForPointInTimeRecovery | `New-RscMutationDownload -Operation SapHanaSnapshotsForPointInTimeRecovery`<BR> | downloadSapHanaSnapshotsForPointInTimeRecovery |
| SnapshotResultsCsv | `New-RscMutationDownload -Operation SnapshotResultsCsv`<BR> | downloadSnapshotResultsCsv |
| ThreatHuntCsv | `New-RscMutationDownload -Operation ThreatHuntCsv`<BR> | downloadThreatHuntCsv |
| VolumeGroupSnapshotFiles | `New-RscMutationDownload -Operation VolumeGroupSnapshotFiles`<BR> | downloadVolumeGroupSnapshotFiles |
| VolumeGroupSnapshotFromLocation | `New-RscMutationDownload -Operation VolumeGroupSnapshotFromLocation`<BR> | downloadVolumeGroupSnapshotFromLocation |

[Go to top](#)
## Microsoft Exchange domain

Domain key: Exchange

Cmdlets: `New-RscQueryExchange` and `New-RscMutationExchange`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| Dag | `New-RscQueryExchange -Operation Dag`<BR> | exchangeDag |
| Dags | `New-RscQueryExchange -Operation Dags`<BR> | exchangeDags |
| Database | `New-RscQueryExchange -Operation Database`<BR> | exchangeDatabase |
| Databases | `New-RscQueryExchange -Operation Databases`<BR> | exchangeDatabases |
| LiveMounts | `New-RscQueryExchange -Operation LiveMounts`<BR> | exchangeLiveMounts |
| Server | `New-RscQueryExchange -Operation Server`<BR> | exchangeServer |
| Servers | `New-RscQueryExchange -Operation Servers`<BR> | exchangeServers |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| BulkUpdateDag | `New-RscMutationExchange -Operation BulkUpdateDag`<BR> | bulkUpdateExchangeDag |
| CreateMount | `New-RscMutationExchange -Operation CreateMount`<BR> | createExchangeMount |
| CreateOnDemandBackup | `New-RscMutationExchange -Operation CreateOnDemandBackup`<BR> | createOnDemandExchangeBackup |
| DeleteSnapshotMount | `New-RscMutationExchange -Operation DeleteSnapshotMount`<BR> | deleteExchangeSnapshotMount |

[Go to top](#)
## Fileset domain

Domain key: Fileset

Cmdlets: `New-RscQueryFileset` and `New-RscMutationFileset`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| Linux | `New-RscQueryFileset -Operation Linux`<BR> | linuxFileset |
| RequestStatus | `New-RscQueryFileset -Operation RequestStatus`<BR> | filesetRequestStatus |
| Share | `New-RscQueryFileset -Operation Share`<BR> | shareFileset |
| Template | `New-RscQueryFileset -Operation Template`<BR> | filesetTemplate |
| Templates | `New-RscQueryFileset -Operation Templates`<BR> | filesetTemplates |
| Windows | `New-RscQueryFileset -Operation Windows`<BR> | windowsFileset |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| BulkCreate | `New-RscMutationFileset -Operation BulkCreate`<BR> | bulkCreateFilesets |
| BulkCreateTemplates | `New-RscMutationFileset -Operation BulkCreateTemplates`<BR> | bulkCreateFilesetTemplates |
| BulkDelete | `New-RscMutationFileset -Operation BulkDelete`<BR> | bulkDeleteFileset |
| BulkDeleteTemplate | `New-RscMutationFileset -Operation BulkDeleteTemplate`<BR> | bulkDeleteFilesetTemplate |
| BulkUpdateTemplate | `New-RscMutationFileset -Operation BulkUpdateTemplate`<BR> | bulkUpdateFilesetTemplate |
| RecoverFiles | `New-RscMutationFileset -Operation RecoverFiles`<BR> | filesetRecoverFiles |

[Go to top](#)
## Google Cloud Platform domain

Domain key: Gcp

Cmdlets: `New-RscQueryGcp` and `New-RscMutationGcp`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| CloudAccountMissingPermissionsForAddition | `New-RscQueryGcp -Operation CloudAccountMissingPermissionsForAddition`<BR> | allGcpCloudAccountMissingPermissionsForAddition |
| CloudAccountProjectsByFeature | `New-RscQueryGcp -Operation CloudAccountProjectsByFeature`<BR> | allGcpCloudAccountProjectsByFeature |
| CloudAccountProjectsForOauth | `New-RscQueryGcp -Operation CloudAccountProjectsForOauth`<BR> | allGcpCloudAccountProjectsForOauth |
| FeaturePermissionsForCloudAccount | `New-RscQueryGcp -Operation FeaturePermissionsForCloudAccount`<BR> | allFeaturePermissionsForGcpCloudAccount |
| GetDefaultCredentialsServiceAccount | `New-RscQueryGcp -Operation GetDefaultCredentialsServiceAccount`<BR> | gcpGetDefaultCredentialsServiceAccount |
| NativeAvailableKmsCryptoKeys | `New-RscQueryGcp -Operation NativeAvailableKmsCryptoKeys`<BR> | allGcpNativeAvailableKmsCryptoKeys |
| NativeCompatibleMachineTypes | `New-RscQueryGcp -Operation NativeCompatibleMachineTypes`<BR> | allGcpNativeCompatibleMachineTypes |
| NativeNetworks | `New-RscQueryGcp -Operation NativeNetworks`<BR> | allGcpNativeNetworks |
| NativeProjectsWithAccessibleNetworks | `New-RscQueryGcp -Operation NativeProjectsWithAccessibleNetworks`<BR> | allGcpNativeProjectsWithAccessibleNetworks |
| NativeRegions | `New-RscQueryGcp -Operation NativeRegions`<BR> | allGcpNativeRegions |
| NativeStoredMachineTypes | `New-RscQueryGcp -Operation NativeStoredMachineTypes`<BR> | allGcpNativeStoredMachineTypes |
| NativeStoredMachineTypesInProject | `New-RscQueryGcp -Operation NativeStoredMachineTypesInProject`<BR> | allGcpNativeStoredMachineTypesInProject |
| NativeStoredNetworkNames | `New-RscQueryGcp -Operation NativeStoredNetworkNames`<BR> | allGcpNativeStoredNetworkNames |
| NativeStoredNetworkNamesInProject | `New-RscQueryGcp -Operation NativeStoredNetworkNamesInProject`<BR> | allGcpNativeStoredNetworkNamesInProject |
| NativeStoredRegions | `New-RscQueryGcp -Operation NativeStoredRegions`<BR> | allGcpNativeStoredRegions |
| NativeStoredRegionsInProject | `New-RscQueryGcp -Operation NativeStoredRegionsInProject`<BR> | allGcpNativeStoredRegionsInProject |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| CloudAccountAddManualAuthProject | `New-RscMutationGcp -Operation CloudAccountAddManualAuthProject`<BR> | gcpCloudAccountAddManualAuthProject |
| CloudAccountAddProjects | `New-RscMutationGcp -Operation CloudAccountAddProjects`<BR> | gcpCloudAccountAddProjects |
| CloudAccountDeleteProjects | `New-RscMutationGcp -Operation CloudAccountDeleteProjects`<BR> | gcpCloudAccountDeleteProjects |
| CloudAccountOauthComplete | `New-RscMutationGcp -Operation CloudAccountOauthComplete`<BR> | gcpCloudAccountOauthComplete |
| CloudAccountOauthInitiate | `New-RscMutationGcp -Operation CloudAccountOauthInitiate`<BR> | gcpCloudAccountOauthInitiate |
| CloudAccountUpgradeProjects | `New-RscMutationGcp -Operation CloudAccountUpgradeProjects`<BR> | gcpCloudAccountUpgradeProjects |
| CreateReaderTarget | `New-RscMutationGcp -Operation CreateReaderTarget`<BR> | createGcpReaderTarget |
| CreateTarget | `New-RscMutationGcp -Operation CreateTarget`<BR> | createGcpTarget |
| SetDefaultServiceAccountJwtConfig | `New-RscMutationGcp -Operation SetDefaultServiceAccountJwtConfig`<BR> | gcpSetDefaultServiceAccountJwtConfig |
| UpdateTarget | `New-RscMutationGcp -Operation UpdateTarget`<BR> | updateGcpTarget |
| UpgradeCloudAccountPermissionsWithoutOauth | `New-RscMutationGcp -Operation UpgradeCloudAccountPermissionsWithoutOauth`<BR> | upgradeGcpCloudAccountPermissionsWithoutOauth |

[Go to top](#)
## Google Cloud Platform Native domain

Domain key: GcpNative

Cmdlets: `New-RscQueryGcpNative` and `New-RscMutationGcpNative`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| Disk | `New-RscQueryGcpNative -Operation Disk`<BR> | gcpNativeDisk |
| Disks | `New-RscQueryGcpNative -Operation Disks`<BR> | gcpNativeDisks |
| GceInstance | `New-RscQueryGcpNative -Operation GceInstance`<BR> | gcpNativeGceInstance |
| GceInstances | `New-RscQueryGcpNative -Operation GceInstances`<BR> | gcpNativeGceInstances |
| Project | `New-RscQueryGcpNative -Operation Project`<BR> | gcpNativeProject |
| Projects | `New-RscQueryGcpNative -Operation Projects`<BR> | gcpNativeProjects |
| StoredDiskLocations | `New-RscQueryGcpNative -Operation StoredDiskLocations`<BR> | gcpNativeStoredDiskLocations |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| DisableProject | `New-RscMutationGcpNative -Operation DisableProject`<BR> | gcpNativeDisableProject |
| ExcludeDisksFromInstanceSnapshot | `New-RscMutationGcpNative -Operation ExcludeDisksFromInstanceSnapshot`<BR> | gcpNativeExcludeDisksFromInstanceSnapshot |
| ExportDisk | `New-RscMutationGcpNative -Operation ExportDisk`<BR> | gcpNativeExportDisk |
| ExportGceInstance | `New-RscMutationGcpNative -Operation ExportGceInstance`<BR> | gcpNativeExportGceInstance |
| RefreshProjects | `New-RscMutationGcpNative -Operation RefreshProjects`<BR> | gcpNativeRefreshProjects |
| RestoreGceInstance | `New-RscMutationGcpNative -Operation RestoreGceInstance`<BR> | gcpNativeRestoreGceInstance |

[Go to top](#)
## Host domain

Domain key: Host

Cmdlets: `New-RscQueryHost` and `New-RscMutationHost`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| Diagnosis | `New-RscQueryHost -Operation Diagnosis`<BR> | hostDiagnosis |
| PhysicalHost | `New-RscQueryHost -Operation PhysicalHost`<BR> | physicalHost |
| PhysicalHosts | `New-RscQueryHost -Operation PhysicalHosts`<BR> | physicalHosts |
| Search | `New-RscQueryHost -Operation Search`<BR> | searchHost |
| Share | `New-RscQueryHost -Operation Share`<BR> | hostShare |
| Shares | `New-RscQueryHost -Operation Shares`<BR> | hostShares |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| BulkDelete | `New-RscMutationHost -Operation BulkDelete`<BR> | bulkDeleteHost |
| BulkRefresh | `New-RscMutationHost -Operation BulkRefresh`<BR> | bulkRefreshHosts |
| BulkRegister | `New-RscMutationHost -Operation BulkRegister`<BR> | bulkRegisterHost |
| BulkUpdate | `New-RscMutationHost -Operation BulkUpdate`<BR> | bulkUpdateHost |
| ChangeVfd | `New-RscMutationHost -Operation ChangeVfd`<BR> | changeVfdOnHost |
| Refresh | `New-RscMutationHost -Operation Refresh`<BR> | refreshHost |

[Go to top](#)
## Hyperv domain

Domain key: Hyperv

Cmdlets: `New-RscQueryHyperv` and `New-RscMutationHyperv`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| Cluster | `New-RscQueryHyperv -Operation Cluster`<BR> | hypervCluster |
| HostAsyncRequestStatus | `New-RscQueryHyperv -Operation HostAsyncRequestStatus`<BR> | hypervHostAsyncRequestStatus |
| Mounts | `New-RscQueryHyperv -Operation Mounts`<BR> | hypervMounts |
| Scvmm | `New-RscQueryHyperv -Operation Scvmm`<BR> | hypervScvmm |
| ScvmmAsyncRequestStatus | `New-RscQueryHyperv -Operation ScvmmAsyncRequestStatus`<BR> | hypervScvmmAsyncRequestStatus |
| Scvmms | `New-RscQueryHyperv -Operation Scvmms`<BR> | hypervScvmms |
| Server | `New-RscQueryHyperv -Operation Server`<BR> | hypervServer |
| Servers | `New-RscQueryHyperv -Operation Servers`<BR> | hypervServers |
| TopLevelDescendants | `New-RscQueryHyperv -Operation TopLevelDescendants`<BR> | hypervTopLevelDescendants |
| UniqueServersCount | `New-RscQueryHyperv -Operation UniqueServersCount`<BR> | uniqueHypervServersCount |
| VirtualMachine | `New-RscQueryHyperv -Operation VirtualMachine`<BR> | hypervVirtualMachine |
| VirtualMachineAsyncRequestStatus | `New-RscQueryHyperv -Operation VirtualMachineAsyncRequestStatus`<BR> | hypervVirtualMachineAsyncRequestStatus |
| VirtualMachines | `New-RscQueryHyperv -Operation VirtualMachines`<BR> | hypervVirtualMachines |
| VmDetail | `New-RscQueryHyperv -Operation VmDetail`<BR> | hypervVmDetail |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| BatchExportVm | `New-RscMutationHyperv -Operation BatchExportVm`<BR> | batchExportHypervVm |
| BatchInstantRecoverVm | `New-RscMutationHyperv -Operation BatchInstantRecoverVm`<BR> | batchInstantRecoverHypervVm |
| BatchMountVm | `New-RscMutationHyperv -Operation BatchMountVm`<BR> | batchMountHypervVm |
| BatchOnDemandBackupVm | `New-RscMutationHyperv -Operation BatchOnDemandBackupVm`<BR> | batchOnDemandBackupHypervVm |
| CreateVirtualMachineSnapshotMount | `New-RscMutationHyperv -Operation CreateVirtualMachineSnapshotMount`<BR> | createHypervVirtualMachineSnapshotMount |
| DeleteAllSnapshots | `New-RscMutationHyperv -Operation DeleteAllSnapshots`<BR> | hypervDeleteAllSnapshots |
| DeleteVirtualMachineSnapshot | `New-RscMutationHyperv -Operation DeleteVirtualMachineSnapshot`<BR> | deleteHypervVirtualMachineSnapshot |
| DeleteVirtualMachineSnapshotMount | `New-RscMutationHyperv -Operation DeleteVirtualMachineSnapshotMount`<BR> | deleteHypervVirtualMachineSnapshotMount |
| DownloadSnapshotFromLocation | `New-RscMutationHyperv -Operation DownloadSnapshotFromLocation`<BR> | downloadHypervSnapshotFromLocation |
| DownloadVirtualMachineSnapshot | `New-RscMutationHyperv -Operation DownloadVirtualMachineSnapshot`<BR> | downloadHypervVirtualMachineSnapshot |
| DownloadVirtualMachineSnapshotFiles | `New-RscMutationHyperv -Operation DownloadVirtualMachineSnapshotFiles`<BR> | downloadHypervVirtualMachineSnapshotFiles |
| ExportVirtualMachine | `New-RscMutationHyperv -Operation ExportVirtualMachine`<BR> | exportHypervVirtualMachine |
| InstantRecoverVirtualMachineSnapshot | `New-RscMutationHyperv -Operation InstantRecoverVirtualMachineSnapshot`<BR> | instantRecoverHypervVirtualMachineSnapshot |
| OnDemandSnapshot | `New-RscMutationHyperv -Operation OnDemandSnapshot`<BR> | hypervOnDemandSnapshot |
| RefreshScvmm | `New-RscMutationHyperv -Operation RefreshScvmm`<BR> | refreshHypervScvmm |
| RefreshServer | `New-RscMutationHyperv -Operation RefreshServer`<BR> | refreshHypervServer |
| RegisterAgentVirtualMachine | `New-RscMutationHyperv -Operation RegisterAgentVirtualMachine`<BR> | registerAgentHypervVirtualMachine |
| RegisterScvmm | `New-RscMutationHyperv -Operation RegisterScvmm`<BR> | registerHypervScvmm |
| RestoreVirtualMachineSnapshotFiles | `New-RscMutationHyperv -Operation RestoreVirtualMachineSnapshotFiles`<BR> | restoreHypervVirtualMachineSnapshotFiles |
| ScvmmDelete | `New-RscMutationHyperv -Operation ScvmmDelete`<BR> | hypervScvmmDelete |
| ScvmmUpdate | `New-RscMutationHyperv -Operation ScvmmUpdate`<BR> | hypervScvmmUpdate |
| UpdateVirtualMachine | `New-RscMutationHyperv -Operation UpdateVirtualMachine`<BR> | updateHypervVirtualMachine |
| UpdateVirtualMachineSnapshotMount | `New-RscMutationHyperv -Operation UpdateVirtualMachineSnapshotMount`<BR> | updateHypervVirtualMachineSnapshotMount |

[Go to top](#)
## Kubernetes domain

Domain key: K8s

Cmdlets: `New-RscQueryK8s` and `New-RscMutationK8s`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| AppManifest | `New-RscQueryK8s -Operation AppManifest`<BR> | k8sAppManifest |
| Cluster | `New-RscQueryK8s -Operation Cluster`<BR> | k8sCluster |
| Clusters | `New-RscQueryK8s -Operation Clusters`<BR> | k8sClusters |
| Namespace | `New-RscQueryK8s -Operation Namespace`<BR> | k8sNamespace |
| Namespaces | `New-RscQueryK8s -Operation Namespaces`<BR> | k8sNamespaces |
| ReplicaSnapshotInfos | `New-RscQueryK8s -Operation ReplicaSnapshotInfos`<BR> | allK8sReplicaSnapshotInfos |
| SnapshotInfo | `New-RscQueryK8s -Operation SnapshotInfo`<BR> | k8sSnapshotInfo |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| ArchiveCluster | `New-RscMutationK8s -Operation ArchiveCluster`<BR> | archiveK8sCluster |
| CreateAgentManifest | `New-RscMutationK8s -Operation CreateAgentManifest`<BR> | createK8sAgentManifest |
| CreateCluster | `New-RscMutationK8s -Operation CreateCluster`<BR> | createK8sCluster |
| CreateNamespaceSnapshots | `New-RscMutationK8s -Operation CreateNamespaceSnapshots`<BR> | createK8sNamespaceSnapshots |
| ExportNamespace | `New-RscMutationK8s -Operation ExportNamespace`<BR> | exportK8sNamespace |
| RefreshCluster | `New-RscMutationK8s -Operation RefreshCluster`<BR> | refreshK8sCluster |
| RestoreNamespace | `New-RscMutationK8s -Operation RestoreNamespace`<BR> | restoreK8sNamespace |

[Go to top](#)
## LDAP domain

Domain key: Ldap

Cmdlets: `New-RscQueryLdap` and `New-RscMutationLdap`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| AuthorizedPrincipalList | `New-RscQueryLdap -Operation AuthorizedPrincipalList`<BR> | ldapAuthorizedPrincipalConnection |
| IntegrationList | `New-RscQueryLdap -Operation IntegrationList`<BR> | ldapIntegrationConnection |
| PrincipalList | `New-RscQueryLdap -Operation PrincipalList`<BR> | ldapPrincipalConnection |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| DeletePrincipals | `New-RscMutationLdap -Operation DeletePrincipals`<BR> | deleteLdapPrincipals |
| RemoveIntegration | `New-RscMutationLdap -Operation RemoveIntegration`<BR> | removeLdapIntegration |
| SetMfaSetting | `New-RscMutationLdap -Operation SetMfaSetting`<BR> | setLdapMfaSetting |
| UpdateIntegration | `New-RscMutationLdap -Operation UpdateIntegration`<BR> | updateLdapIntegration |

[Go to top](#)
## M365 domain

Domain key: M365

Cmdlets: `New-RscQueryM365` and `New-RscMutationM365`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| Regions | `New-RscQueryM365 -Operation Regions`<BR> | m365Regions |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| BackupMailbox | `New-RscMutationM365 -Operation BackupMailbox`<BR> | backupM365Mailbox |
| BackupOnedrive | `New-RscMutationM365 -Operation BackupOnedrive`<BR> | backupM365Onedrive |
| BackupSharepointDrive | `New-RscMutationM365 -Operation BackupSharepointDrive`<BR> | backupM365SharepointDrive |
| BackupTeam | `New-RscMutationM365 -Operation BackupTeam`<BR> | backupM365Team |

[Go to top](#)
## Managed Volume domain

Domain key: ManagedVolume

Cmdlets: `New-RscQueryManagedVolume` and `New-RscMutationManagedVolume`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| InventoryStats | `New-RscQueryManagedVolume -Operation InventoryStats`<BR> | managedVolumeInventoryStats |
| LiveMounts | `New-RscQueryManagedVolume -Operation LiveMounts`<BR> | managedVolumeLiveMounts |
| ManagedVolume | `New-RscQueryManagedVolume -Operation ManagedVolume`<BR> | managedVolume |
| ManagedVolumes | `New-RscQueryManagedVolume -Operation ManagedVolumes`<BR> | managedVolumes |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| Add | `New-RscMutationManagedVolume -Operation Add`<BR> | addManagedVolume |
| BeginSnapshot | `New-RscMutationManagedVolume -Operation BeginSnapshot`<BR> | beginManagedVolumeSnapshot |
| Delete | `New-RscMutationManagedVolume -Operation Delete`<BR> | deleteManagedVolume |
| DeleteSnapshotExport | `New-RscMutationManagedVolume -Operation DeleteSnapshotExport`<BR> | deleteManagedVolumeSnapshotExport |
| DownloadFiles | `New-RscMutationManagedVolume -Operation DownloadFiles`<BR> | downloadManagedVolumeFiles |
| DownloadFromLocation | `New-RscMutationManagedVolume -Operation DownloadFromLocation`<BR> | downloadManagedVolumeFromLocation |
| EndSnapshot | `New-RscMutationManagedVolume -Operation EndSnapshot`<BR> | endManagedVolumeSnapshot |
| ExportSnapshot | `New-RscMutationManagedVolume -Operation ExportSnapshot`<BR> | exportManagedVolumeSnapshot |
| Resize | `New-RscMutationManagedVolume -Operation Resize`<BR> | resizeManagedVolume |
| TakeOnDemandSnapshot | `New-RscMutationManagedVolume -Operation TakeOnDemandSnapshot`<BR> | takeManagedVolumeOnDemandSnapshot |
| Update | `New-RscMutationManagedVolume -Operation Update`<BR> | updateManagedVolume |

[Go to top](#)
## Mongo domain

Domain key: Mongo

Cmdlets: `New-RscQueryMongo` and `New-RscMutationMongo`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| BulkRecoverableRange | `New-RscQueryMongo -Operation BulkRecoverableRange`<BR> | mongodbBulkRecoverableRange |
| BulkRecoverableRanges | `New-RscQueryMongo -Operation BulkRecoverableRanges`<BR> | mongoBulkRecoverableRanges |
| Collection | `New-RscQueryMongo -Operation Collection`<BR> | mongoCollection |
| CollectionRecoverableRange | `New-RscQueryMongo -Operation CollectionRecoverableRange`<BR> | mongodbCollectionRecoverableRange |
| Collections | `New-RscQueryMongo -Operation Collections`<BR> | mongoCollections |
| Database | `New-RscQueryMongo -Operation Database`<BR> | mongoDatabase |
| Databases | `New-RscQueryMongo -Operation Databases`<BR> | mongoDatabases |
| RecoverableRanges | `New-RscQueryMongo -Operation RecoverableRanges`<BR> | mongoRecoverableRanges |
| Source | `New-RscQueryMongo -Operation Source`<BR> | mongoSource |
| Sources | `New-RscQueryMongo -Operation Sources`<BR> | mongoSources |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| AddSource | `New-RscMutationMongo -Operation AddSource`<BR> | addMongoSource |
| AssignSlaToCollection | `New-RscMutationMongo -Operation AssignSlaToCollection`<BR> | assignSlaToMongoDbCollection |
| BulkDeleteSources | `New-RscMutationMongo -Operation BulkDeleteSources`<BR> | bulkDeleteMongodbSources |
| CreateSource | `New-RscMutationMongo -Operation CreateSource`<BR> | createMongodbSource |
| DeleteSource | `New-RscMutationMongo -Operation DeleteSource`<BR> | deleteMongoSource |
| DiscoverSource | `New-RscMutationMongo -Operation DiscoverSource`<BR> | discoverMongoSource |
| PatchSource | `New-RscMutationMongo -Operation PatchSource`<BR> | patchMongoSource |
| RecoverSource | `New-RscMutationMongo -Operation RecoverSource`<BR> | recoverMongoSource |
| RetryAddSource | `New-RscMutationMongo -Operation RetryAddSource`<BR> | retryAddMongoSource |
| UpdateSource | `New-RscMutationMongo -Operation UpdateSource`<BR> | updateMongodbSource |

[Go to top](#)
## Mosaic domain

Domain key: Mosaic

Cmdlets: `New-RscQueryMosaic` and `New-RscMutationMosaic`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| BulkRecoveryRange | `New-RscQueryMosaic -Operation BulkRecoveryRange`<BR> | mosaicBulkRecoveryRange |
| Snapshots | `New-RscQueryMosaic -Operation Snapshots`<BR> | mosaicSnapshots |
| Stores | `New-RscQueryMosaic -Operation Stores`<BR> | mosaicStores |
| Versions | `New-RscQueryMosaic -Operation Versions`<BR> | mosaicVersions |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| AddStore | `New-RscMutationMosaic -Operation AddStore`<BR> | addMosaicStore |
| DeleteStore | `New-RscMutationMosaic -Operation DeleteStore`<BR> | deleteMosaicStore |
| UpdateStore | `New-RscMutationMosaic -Operation UpdateStore`<BR> | updateMosaicStore |

[Go to top](#)
## MSSQL domain

Domain key: Mssql

Cmdlets: `New-RscQueryMssql` and `New-RscMutationMssql`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| AvailabilityGroup | `New-RscQueryMssql -Operation AvailabilityGroup`<BR> | mssqlAvailabilityGroup |
| CdmLogShippingTarget | `New-RscQueryMssql -Operation CdmLogShippingTarget`<BR> | cdmMssqlLogShippingTarget |
| CdmLogShippingTargets | `New-RscQueryMssql -Operation CdmLogShippingTargets`<BR> | cdmMssqlLogShippingTargets |
| CompatibleInstances | `New-RscQueryMssql -Operation CompatibleInstances`<BR> | mssqlCompatibleInstances |
| Database | `New-RscQueryMssql -Operation Database`<BR> | mssqlDatabase |
| DatabaseLiveMounts | `New-RscQueryMssql -Operation DatabaseLiveMounts`<BR> | mssqlDatabaseLiveMounts |
| DatabaseMissedRecoverableRanges | `New-RscQueryMssql -Operation DatabaseMissedRecoverableRanges`<BR> | mssqlDatabaseMissedRecoverableRanges |
| DatabaseMissedSnapshots | `New-RscQueryMssql -Operation DatabaseMissedSnapshots`<BR> | mssqlDatabaseMissedSnapshots |
| DatabaseRestoreEstimate | `New-RscQueryMssql -Operation DatabaseRestoreEstimate`<BR> | mssqlDatabaseRestoreEstimate |
| DatabaseRestoreFiles | `New-RscQueryMssql -Operation DatabaseRestoreFiles`<BR> | allMssqlDatabaseRestoreFiles |
| Databases | `New-RscQueryMssql -Operation Databases`<BR> | mssqlDatabases |
| DefaultProperties | `New-RscQueryMssql -Operation DefaultProperties`<BR> | mssqlDefaultProperties |
| Instance | `New-RscQueryMssql -Operation Instance`<BR> | mssqlInstance |
| LogShippingTargets | `New-RscQueryMssql -Operation LogShippingTargets`<BR> | mssqlLogShippingTargets |
| RecoverableRanges | `New-RscQueryMssql -Operation RecoverableRanges`<BR> | mssqlRecoverableRanges |
| TopLevelDescendants | `New-RscQueryMssql -Operation TopLevelDescendants`<BR> | mssqlTopLevelDescendants |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| AssignSlaDomainProperties | `New-RscMutationMssql -Operation AssignSlaDomainProperties`<BR> | assignMssqlSlaDomainProperties |
| AssignSlaDomainPropertiesAsync | `New-RscMutationMssql -Operation AssignSlaDomainPropertiesAsync`<BR> | assignMssqlSlaDomainPropertiesAsync |
| BrowseDatabaseSnapshot | `New-RscMutationMssql -Operation BrowseDatabaseSnapshot`<BR> | browseMssqlDatabaseSnapshot |
| BulkCreateOnDemandBackup | `New-RscMutationMssql -Operation BulkCreateOnDemandBackup`<BR> | bulkCreateOnDemandMssqlBackup |
| BulkUpdateDbs | `New-RscMutationMssql -Operation BulkUpdateDbs`<BR> | bulkUpdateMssqlDbs |
| CreateLiveMount | `New-RscMutationMssql -Operation CreateLiveMount`<BR> | createMssqlLiveMount |
| CreateLogShippingConfiguration | `New-RscMutationMssql -Operation CreateLogShippingConfiguration`<BR> | createMssqlLogShippingConfiguration |
| CreateOnDemandBackup | `New-RscMutationMssql -Operation CreateOnDemandBackup`<BR> | createOnDemandMssqlBackup |
| DeleteDbSnapshots | `New-RscMutationMssql -Operation DeleteDbSnapshots`<BR> | deleteMssqlDbSnapshots |
| DeleteLiveMount | `New-RscMutationMssql -Operation DeleteLiveMount`<BR> | deleteMssqlLiveMount |
| DownloadDatabaseBackupFiles | `New-RscMutationMssql -Operation DownloadDatabaseBackupFiles`<BR> | downloadMssqlDatabaseBackupFiles |
| DownloadDatabaseFilesFromArchivalLocation | `New-RscMutationMssql -Operation DownloadDatabaseFilesFromArchivalLocation`<BR> | downloadMssqlDatabaseFilesFromArchivalLocation |
| ExportDatabase | `New-RscMutationMssql -Operation ExportDatabase`<BR> | exportMssqlDatabase |
| RestoreDatabase | `New-RscMutationMssql -Operation RestoreDatabase`<BR> | restoreMssqlDatabase |
| TakeLogBackup | `New-RscMutationMssql -Operation TakeLogBackup`<BR> | takeMssqlLogBackup |
| UpdateDefaultProperties | `New-RscMutationMssql -Operation UpdateDefaultProperties`<BR> | updateMssqlDefaultProperties |
| UpdateLogShippingConfiguration | `New-RscMutationMssql -Operation UpdateLogShippingConfiguration`<BR> | updateMssqlLogShippingConfiguration |

[Go to top](#)
## NAS domain

Domain key: Nas

Cmdlets: `New-RscQueryNas` and `New-RscMutationNas`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| Fileset | `New-RscQueryNas -Operation Fileset`<BR> | nasFileset |
| Namespace | `New-RscQueryNas -Operation Namespace`<BR> | nasNamespace |
| Namespaces | `New-RscQueryNas -Operation Namespaces`<BR> | nasNamespaces |
| Share | `New-RscQueryNas -Operation Share`<BR> | nasShare |
| System | `New-RscQueryNas -Operation System`<BR> | nasSystem |
| Systems | `New-RscQueryNas -Operation Systems`<BR> | nasSystems |
| TopLevelDescendants | `New-RscQueryNas -Operation TopLevelDescendants`<BR> | nasTopLevelDescendants |
| Volume | `New-RscQueryNas -Operation Volume`<BR> | nasVolume |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |

[Go to top](#)
## NFS domain

Domain key: Nfs

Cmdlets: `New-RscQueryNfs` and `New-RscMutationNfs`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| CreateReaderTarget | `New-RscMutationNfs -Operation CreateReaderTarget`<BR> | createNfsReaderTarget |
| CreateTarget | `New-RscMutationNfs -Operation CreateTarget`<BR> | createNfsTarget |
| UpdateTarget | `New-RscMutationNfs -Operation UpdateTarget`<BR> | updateNfsTarget |

[Go to top](#)
## Nutanix domain

Domain key: Nutanix

Cmdlets: `New-RscQueryNutanix` and `New-RscMutationNutanix`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| BrowseSnapshot | `New-RscQueryNutanix -Operation BrowseSnapshot`<BR> | nutanixBrowseSnapshot |
| Category | `New-RscQueryNutanix -Operation Category`<BR> | nutanixCategory |
| CategoryValue | `New-RscQueryNutanix -Operation CategoryValue`<BR> | nutanixCategoryValue |
| Cluster | `New-RscQueryNutanix -Operation Cluster`<BR> | nutanixCluster |
| ClusterAsyncRequestStatus | `New-RscQueryNutanix -Operation ClusterAsyncRequestStatus`<BR> | nutanixClusterAsyncRequestStatus |
| ClusterContainers | `New-RscQueryNutanix -Operation ClusterContainers`<BR> | nutanixClusterContainers |
| ClusterNetworks | `New-RscQueryNutanix -Operation ClusterNetworks`<BR> | nutanixClusterNetworks |
| Clusters | `New-RscQueryNutanix -Operation Clusters`<BR> | nutanixClusters |
| Mounts | `New-RscQueryNutanix -Operation Mounts`<BR> | nutanixMounts |
| PrismCentral | `New-RscQueryNutanix -Operation PrismCentral`<BR> | nutanixPrismCentral |
| PrismCentrals | `New-RscQueryNutanix -Operation PrismCentrals`<BR> | nutanixPrismCentrals |
| SearchVm | `New-RscQueryNutanix -Operation SearchVm`<BR> | searchNutanixVm |
| SnapshotDetail | `New-RscQueryNutanix -Operation SnapshotDetail`<BR> | nutanixSnapshotDetail |
| TopLevelDescendants | `New-RscQueryNutanix -Operation TopLevelDescendants`<BR> | nutanixTopLevelDescendants |
| Vm | `New-RscQueryNutanix -Operation Vm`<BR> | nutanixVm |
| VmAsyncRequestStatus | `New-RscQueryNutanix -Operation VmAsyncRequestStatus`<BR> | nutanixVmAsyncRequestStatus |
| VmMissedSnapshots | `New-RscQueryNutanix -Operation VmMissedSnapshots`<BR> | nutanixVmMissedSnapshots |
| Vms | `New-RscQueryNutanix -Operation Vms`<BR> | nutanixVms |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| BatchExportVm | `New-RscMutationNutanix -Operation BatchExportVm`<BR> | batchExportNutanixVm |
| BatchMountVm | `New-RscMutationNutanix -Operation BatchMountVm`<BR> | batchMountNutanixVm |
| BulkOnDemandSnapshotVm | `New-RscMutationNutanix -Operation BulkOnDemandSnapshotVm`<BR> | bulkOnDemandSnapshotNutanixVm |
| CreateCluster | `New-RscMutationNutanix -Operation CreateCluster`<BR> | createNutanixCluster |
| CreateOnDemandBackup | `New-RscMutationNutanix -Operation CreateOnDemandBackup`<BR> | createOnDemandNutanixBackup |
| CreatePrismCentral | `New-RscMutationNutanix -Operation CreatePrismCentral`<BR> | createNutanixPrismCentral |
| DeleteCluster | `New-RscMutationNutanix -Operation DeleteCluster`<BR> | deleteNutanixCluster |
| DeleteMountV1 | `New-RscMutationNutanix -Operation DeleteMountV1`<BR> | deleteNutanixMountV1 |
| DeletePrismCentral | `New-RscMutationNutanix -Operation DeletePrismCentral`<BR> | deleteNutanixPrismCentral |
| DeleteSnapshot | `New-RscMutationNutanix -Operation DeleteSnapshot`<BR> | deleteNutanixSnapshot |
| DeleteSnapshots | `New-RscMutationNutanix -Operation DeleteSnapshots`<BR> | deleteNutanixSnapshots |
| DownloadFilesSnapshot | `New-RscMutationNutanix -Operation DownloadFilesSnapshot`<BR> | downloadFilesNutanixSnapshot |
| DownloadSnapshot | `New-RscMutationNutanix -Operation DownloadSnapshot`<BR> | downloadNutanixSnapshot |
| DownloadVmFromLocation | `New-RscMutationNutanix -Operation DownloadVmFromLocation`<BR> | downloadNutanixVmFromLocation |
| ExportSnapshot | `New-RscMutationNutanix -Operation ExportSnapshot`<BR> | exportNutanixSnapshot |
| MigrateMountV1 | `New-RscMutationNutanix -Operation MigrateMountV1`<BR> | migrateNutanixMountV1 |
| MountSnapshotV1 | `New-RscMutationNutanix -Operation MountSnapshotV1`<BR> | mountNutanixSnapshotV1 |
| PatchMountV1 | `New-RscMutationNutanix -Operation PatchMountV1`<BR> | patchNutanixMountV1 |
| RefreshCluster | `New-RscMutationNutanix -Operation RefreshCluster`<BR> | refreshNutanixCluster |
| RefreshPrismCentral | `New-RscMutationNutanix -Operation RefreshPrismCentral`<BR> | refreshNutanixPrismCentral |
| RegisterAgentVm | `New-RscMutationNutanix -Operation RegisterAgentVm`<BR> | registerAgentNutanixVm |
| RestoreFilesSnapshot | `New-RscMutationNutanix -Operation RestoreFilesSnapshot`<BR> | restoreFilesNutanixSnapshot |
| UpdateCluster | `New-RscMutationNutanix -Operation UpdateCluster`<BR> | updateNutanixCluster |
| UpdatePrismCentral | `New-RscMutationNutanix -Operation UpdatePrismCentral`<BR> | updateNutanixPrismCentral |
| UpdateVm | `New-RscMutationNutanix -Operation UpdateVm`<BR> | updateNutanixVm |

[Go to top](#)
## O365 domain

Domain key: O365

Cmdlets: `New-RscQueryO365` and `New-RscMutationO365`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| AdGroups | `New-RscQueryO365 -Operation AdGroups`<BR> | allO365AdGroups |
| BrowseTeamConvChannels | `New-RscQueryO365 -Operation BrowseTeamConvChannels`<BR> | browseO365TeamConvChannels |
| Calendar | `New-RscQueryO365 -Operation Calendar`<BR> | o365Calendar |
| Groups | `New-RscQueryO365 -Operation Groups`<BR> | o365Groups |
| License | `New-RscQueryO365 -Operation License`<BR> | o365License |
| ListApps | `New-RscQueryO365 -Operation ListApps`<BR> | listO365Apps |
| Mailbox | `New-RscQueryO365 -Operation Mailbox`<BR> | o365Mailbox |
| Mailboxes | `New-RscQueryO365 -Operation Mailboxes`<BR> | o365Mailboxes |
| ObjectAncestors | `New-RscQueryO365 -Operation ObjectAncestors`<BR> | o365ObjectAncestors |
| Onedrive | `New-RscQueryO365 -Operation Onedrive`<BR> | o365Onedrive |
| Onedrives | `New-RscQueryO365 -Operation Onedrives`<BR> | o365Onedrives |
| Org | `New-RscQueryO365 -Operation Org`<BR> | o365Org |
| OrgAtSnappableLevel | `New-RscQueryO365 -Operation OrgAtSnappableLevel`<BR> | o365OrgAtSnappableLevel |
| OrgStatuses | `New-RscQueryO365 -Operation OrgStatuses`<BR> | allO365OrgStatuses |
| OrgSummaries | `New-RscQueryO365 -Operation OrgSummaries`<BR> | o365OrgSummaries |
| Orgs | `New-RscQueryO365 -Operation Orgs`<BR> | o365Orgs |
| ServiceAccount | `New-RscQueryO365 -Operation ServiceAccount`<BR> | o365ServiceAccount |
| ServiceStatus | `New-RscQueryO365 -Operation ServiceStatus`<BR> | o365ServiceStatus |
| SharepointDrive | `New-RscQueryO365 -Operation SharepointDrive`<BR> | o365SharepointDrive |
| SharepointDrives | `New-RscQueryO365 -Operation SharepointDrives`<BR> | o365SharepointDrives |
| SharepointList | `New-RscQueryO365 -Operation SharepointList`<BR> | o365SharepointList |
| SharepointLists | `New-RscQueryO365 -Operation SharepointLists`<BR> | o365SharepointLists |
| SharepointObjectList | `New-RscQueryO365 -Operation SharepointObjectList`<BR> | o365SharepointObjectList |
| SharepointObjects | `New-RscQueryO365 -Operation SharepointObjects`<BR> | o365SharepointObjects |
| SharepointSite | `New-RscQueryO365 -Operation SharepointSite`<BR> | o365SharepointSite |
| SharepointSites | `New-RscQueryO365 -Operation SharepointSites`<BR> | o365SharepointSites |
| Site | `New-RscQueryO365 -Operation Site`<BR> | o365Site |
| Sites | `New-RscQueryO365 -Operation Sites`<BR> | o365Sites |
| StorageStats | `New-RscQueryO365 -Operation StorageStats`<BR> | o365StorageStats |
| SubscriptionsAppTypeCounts | `New-RscQueryO365 -Operation SubscriptionsAppTypeCounts`<BR> | allO365SubscriptionsAppTypeCounts |
| Team | `New-RscQueryO365 -Operation Team`<BR> | o365Team |
| TeamChannels | `New-RscQueryO365 -Operation TeamChannels`<BR> | o365TeamChannels |
| TeamConversationsFolderID | `New-RscQueryO365 -Operation TeamConversationsFolderID`<BR> | o365TeamConversationsFolderID |
| TeamPostedBy | `New-RscQueryO365 -Operation TeamPostedBy`<BR> | o365TeamPostedBy |
| Teams | `New-RscQueryO365 -Operation Teams`<BR> | o365Teams |
| User | `New-RscQueryO365 -Operation User`<BR> | o365User |
| UserObjects | `New-RscQueryO365 -Operation UserObjects`<BR> | o365UserObjects |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| AddOrg | `New-RscMutationO365 -Operation AddOrg`<BR> | addO365Org |
| BackupMailbox | `New-RscMutationO365 -Operation BackupMailbox`<BR> | backupO365Mailbox |
| BackupOnedrive | `New-RscMutationO365 -Operation BackupOnedrive`<BR> | backupO365Onedrive |
| BackupSharePointSite | `New-RscMutationO365 -Operation BackupSharePointSite`<BR> | backupO365SharePointSite |
| BackupSharepointDrive | `New-RscMutationO365 -Operation BackupSharepointDrive`<BR> | backupO365SharepointDrive |
| BackupSharepointList | `New-RscMutationO365 -Operation BackupSharepointList`<BR> | backupO365SharepointList |
| BackupTeam | `New-RscMutationO365 -Operation BackupTeam`<BR> | backupO365Team |
| CreateAppComplete | `New-RscMutationO365 -Operation CreateAppComplete`<BR> | createO365AppComplete |
| CreateAppKickoff | `New-RscMutationO365 -Operation CreateAppKickoff`<BR> | createO365AppKickoff |
| DeleteAzureApp | `New-RscMutationO365 -Operation DeleteAzureApp`<BR> | deleteO365AzureApp |
| DeleteOrg | `New-RscMutationO365 -Operation DeleteOrg`<BR> | deleteO365Org |
| DeleteServiceAccount | `New-RscMutationO365 -Operation DeleteServiceAccount`<BR> | deleteO365ServiceAccount |
| EnableSharePoint | `New-RscMutationO365 -Operation EnableSharePoint`<BR> | enableO365SharePoint |
| EnableTeams | `New-RscMutationO365 -Operation EnableTeams`<BR> | enableO365Teams |
| ExportMailbox | `New-RscMutationO365 -Operation ExportMailbox`<BR> | exportO365Mailbox |
| InsertCustomerApp | `New-RscMutationO365 -Operation InsertCustomerApp`<BR> | insertCustomerO365App |
| OauthConsentComplete | `New-RscMutationO365 -Operation OauthConsentComplete`<BR> | o365OauthConsentComplete |
| OauthConsentKickoff | `New-RscMutationO365 -Operation OauthConsentKickoff`<BR> | o365OauthConsentKickoff |
| PdlGroups | `New-RscMutationO365 -Operation PdlGroups`<BR> | o365PdlGroups |
| RefreshOrg | `New-RscMutationO365 -Operation RefreshOrg`<BR> | refreshO365Org |
| RestoreMailbox | `New-RscMutationO365 -Operation RestoreMailbox`<BR> | restoreO365Mailbox |
| RestoreSnappable | `New-RscMutationO365 -Operation RestoreSnappable`<BR> | restoreO365Snappable |
| RestoreTeamsConversations | `New-RscMutationO365 -Operation RestoreTeamsConversations`<BR> | restoreO365TeamsConversations |
| RestoreTeamsFiles | `New-RscMutationO365 -Operation RestoreTeamsFiles`<BR> | restoreO365TeamsFiles |
| SaaSSetupKickoff | `New-RscMutationO365 -Operation SaaSSetupKickoff`<BR> | o365SaaSSetupKickoff |
| SaasSetupComplete | `New-RscMutationO365 -Operation SaasSetupComplete`<BR> | o365SaasSetupComplete |
| SetServiceAccount | `New-RscMutationO365 -Operation SetServiceAccount`<BR> | setO365ServiceAccount |
| SetupKickoff | `New-RscMutationO365 -Operation SetupKickoff`<BR> | o365SetupKickoff |
| UpdateAppAuthStatus | `New-RscMutationO365 -Operation UpdateAppAuthStatus`<BR> | updateO365AppAuthStatus |
| UpdateAppPermissions | `New-RscMutationO365 -Operation UpdateAppPermissions`<BR> | updateO365AppPermissions |
| UpdateOrgCustomName | `New-RscMutationO365 -Operation UpdateOrgCustomName`<BR> | updateO365OrgCustomName |

[Go to top](#)
## Oracle domain

Domain key: Oracle

Cmdlets: `New-RscQueryOracle` and `New-RscMutationOracle`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| AcoExampleDownloadLink | `New-RscQueryOracle -Operation AcoExampleDownloadLink`<BR> | oracleAcoExampleDownloadLink |
| AcoParameters | `New-RscQueryOracle -Operation AcoParameters`<BR> | oracleAcoParameters |
| DataGuardGroup | `New-RscQueryOracle -Operation DataGuardGroup`<BR> | oracleDataGuardGroup |
| Database | `New-RscQueryOracle -Operation Database`<BR> | oracleDatabase |
| DatabaseLogBackupConfig | `New-RscQueryOracle -Operation DatabaseLogBackupConfig`<BR> | oracleDatabaseLogBackupConfig |
| Databases | `New-RscQueryOracle -Operation Databases`<BR> | oracleDatabases |
| Host | `New-RscQueryOracle -Operation Host`<BR> | oracleHost |
| HostLogBackupConfig | `New-RscQueryOracle -Operation HostLogBackupConfig`<BR> | oracleHostLogBackupConfig |
| LiveMounts | `New-RscQueryOracle -Operation LiveMounts`<BR> | oracleLiveMounts |
| MissedRecoverableRanges | `New-RscQueryOracle -Operation MissedRecoverableRanges`<BR> | oracleMissedRecoverableRanges |
| MissedSnapshots | `New-RscQueryOracle -Operation MissedSnapshots`<BR> | oracleMissedSnapshots |
| PdbDetails | `New-RscQueryOracle -Operation PdbDetails`<BR> | oraclePdbDetails |
| Rac | `New-RscQueryOracle -Operation Rac`<BR> | oracleRac |
| RacLogBackupConfig | `New-RscQueryOracle -Operation RacLogBackupConfig`<BR> | oracleRacLogBackupConfig |
| RecoverableRanges | `New-RscQueryOracle -Operation RecoverableRanges`<BR> | oracleRecoverableRanges |
| TopLevelDescendants | `New-RscQueryOracle -Operation TopLevelDescendants`<BR> | oracleTopLevelDescendants |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| BulkUpdateDatabases | `New-RscMutationOracle -Operation BulkUpdateDatabases`<BR> | bulkUpdateOracleDatabases |
| BulkUpdateHosts | `New-RscMutationOracle -Operation BulkUpdateHosts`<BR> | bulkUpdateOracleHosts |
| BulkUpdateRacs | `New-RscMutationOracle -Operation BulkUpdateRacs`<BR> | bulkUpdateOracleRacs |
| CreatePdbRestore | `New-RscMutationOracle -Operation CreatePdbRestore`<BR> | createOraclePdbRestore |
| DeleteAllDatabaseSnapshots | `New-RscMutationOracle -Operation DeleteAllDatabaseSnapshots`<BR> | deleteAllOracleDatabaseSnapshots |
| DeleteMount | `New-RscMutationOracle -Operation DeleteMount`<BR> | deleteOracleMount |
| DownloadDatabaseSnapshot | `New-RscMutationOracle -Operation DownloadDatabaseSnapshot`<BR> | downloadOracleDatabaseSnapshot |
| ExportDatabase | `New-RscMutationOracle -Operation ExportDatabase`<BR> | exportOracleDatabase |
| ExportTablespace | `New-RscMutationOracle -Operation ExportTablespace`<BR> | exportOracleTablespace |
| InstantRecoverSnapshot | `New-RscMutationOracle -Operation InstantRecoverSnapshot`<BR> | instantRecoverOracleSnapshot |
| MountDatabase | `New-RscMutationOracle -Operation MountDatabase`<BR> | mountOracleDatabase |
| RefreshDatabase | `New-RscMutationOracle -Operation RefreshDatabase`<BR> | refreshOracleDatabase |
| RestoreLogs | `New-RscMutationOracle -Operation RestoreLogs`<BR> | restoreOracleLogs |
| TakeOnDemandDatabaseSnapshot | `New-RscMutationOracle -Operation TakeOnDemandDatabaseSnapshot`<BR> | takeOnDemandOracleDatabaseSnapshot |
| TakeOnDemandLogSnapshot | `New-RscMutationOracle -Operation TakeOnDemandLogSnapshot`<BR> | takeOnDemandOracleLogSnapshot |
| UpdateDataGuardGroup | `New-RscMutationOracle -Operation UpdateDataGuardGroup`<BR> | updateOracleDataGuardGroup |
| ValidateAcoFile | `New-RscMutationOracle -Operation ValidateAcoFile`<BR> | validateOracleAcoFile |
| ValidateDatabaseBackups | `New-RscMutationOracle -Operation ValidateDatabaseBackups`<BR> | validateOracleDatabaseBackups |

[Go to top](#)
## Policy domain

Domain key: Policy

Cmdlets: `New-RscQueryPolicy` and `New-RscMutationPolicy`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| Details | `New-RscQueryPolicy -Operation Details`<BR> | policyDetails |
| Obj | `New-RscQueryPolicy -Operation Obj`<BR> | policyObj |
| ObjectUsages | `New-RscQueryPolicy -Operation ObjectUsages`<BR> | policyObjectUsages |
| Objs | `New-RscQueryPolicy -Operation Objs`<BR> | policyObjs |
| Policies | `New-RscQueryPolicy -Operation Policies`<BR> | policies |
| Policy | `New-RscQueryPolicy -Operation Policy`<BR> | policy |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| Policies | `New-RscMutationPolicy -Operation Policies`<BR> | seedInitialPolicies |

[Go to top](#)
## Ransomware domain

Domain key: Ransomware

Cmdlets: `New-RscQueryRansomware` and `New-RscMutationRansomware`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| DetectionWorkloadLocations | `New-RscQueryRansomware -Operation DetectionWorkloadLocations`<BR> | ransomwareDetectionWorkloadLocations |
| InvestigationAnalysisSummary | `New-RscQueryRansomware -Operation InvestigationAnalysisSummary`<BR> | ransomwareInvestigationAnalysisSummary |
| InvestigationEnablement | `New-RscQueryRansomware -Operation InvestigationEnablement`<BR> | ransomwareInvestigationEnablement |
| InvestigationWorkloadScannedCount | `New-RscQueryRansomware -Operation InvestigationWorkloadScannedCount`<BR> | ransomwareInvestigationWorkloadScannedCount |
| OverallInvestigationSummary | `New-RscQueryRansomware -Operation OverallInvestigationSummary`<BR> | overallRansomwareInvestigationSummary |
| PendingInvestigationResultsCount | `New-RscQueryRansomware -Operation PendingInvestigationResultsCount`<BR> | pendingRansomwareInvestigationResultsCount |
| ProcessedInvestigationWorkloadCount | `New-RscQueryRansomware -Operation ProcessedInvestigationWorkloadCount`<BR> | processedRansomwareInvestigationWorkloadCount |
| ProtectedInvestigationWorkloadCount | `New-RscQueryRansomware -Operation ProtectedInvestigationWorkloadCount`<BR> | protectedRansomwareInvestigationWorkloadCount |
| Result | `New-RscQueryRansomware -Operation Result`<BR> | ransomwareResult |
| ResultOpt | `New-RscQueryRansomware -Operation ResultOpt`<BR> | ransomwareResultOpt |
| Results | `New-RscQueryRansomware -Operation Results`<BR> | ransomwareResults |
| ResultsGrouped | `New-RscQueryRansomware -Operation ResultsGrouped`<BR> | ransomwareResultsGrouped |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| TriggerDetection | `New-RscMutationRansomware -Operation TriggerDetection`<BR> | triggerRansomwareDetection |

[Go to top](#)
## RCS domain

Domain key: Rcs

Cmdlets: `New-RscQueryRcs` and `New-RscMutationRcs`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| ArchivalLocationsConsumptionStats | `New-RscQueryRcs -Operation ArchivalLocationsConsumptionStats`<BR> | rcsArchivalLocationsConsumptionStats |
| Cluster | `New-RscQueryRcs -Operation Cluster`<BR> | clusterCsr |
| Dhcores | `New-RscQueryRcs -Operation Dhcores`<BR> | allDhrcScores |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| CreateAutomaticTargetMapping | `New-RscMutationRcs -Operation CreateAutomaticTargetMapping`<BR> | createAutomaticRcsTargetMapping |
| CreateReaderTarget | `New-RscMutationRcs -Operation CreateReaderTarget`<BR> | createRcsReaderTarget |
| CreateTarget | `New-RscMutationRcs -Operation CreateTarget`<BR> | createRcsTarget |
| UpdateAutomaticTargetMapping | `New-RscMutationRcs -Operation UpdateAutomaticTargetMapping`<BR> | updateRcsAutomaticTargetMapping |

[Go to top](#)
## RCV domain

Domain key: Rcv

Cmdlets: `New-RscQueryRcv` and `New-RscMutationRcv`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| AccountEntitlement | `New-RscQueryRcv -Operation AccountEntitlement`<BR> | rcvAccountEntitlement |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| CreateLocationsFromTemplate | `New-RscMutationRcv -Operation CreateLocationsFromTemplate`<BR> | createRcvLocationsFromTemplate |
| CreatePrivateEndpointApprovalRequest | `New-RscMutationRcv -Operation CreatePrivateEndpointApprovalRequest`<BR> | createRcvPrivateEndpointApprovalRequest |
| UpdateTarget | `New-RscMutationRcv -Operation UpdateTarget`<BR> | updateRcvTarget |

[Go to top](#)
## Replication domain

Domain key: Replication

Cmdlets: `New-RscQueryReplication` and `New-RscMutationReplication`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| IncomingStats | `New-RscQueryReplication -Operation IncomingStats`<BR> | replicationIncomingStats |
| OutgoingStats | `New-RscQueryReplication -Operation OutgoingStats`<BR> | replicationOutgoingStats |
| Pairs | `New-RscQueryReplication -Operation Pairs`<BR> | replicationPairs |
| ValidTargets | `New-RscQueryReplication -Operation ValidTargets`<BR> | allValidReplicationTargets |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| CreatePair | `New-RscMutationReplication -Operation CreatePair`<BR> | createReplicationPair |
| DeletePair | `New-RscMutationReplication -Operation DeletePair`<BR> | deleteReplicationPair |
| DisablePause | `New-RscMutationReplication -Operation DisablePause`<BR> | disableReplicationPause |
| EnablePause | `New-RscMutationReplication -Operation EnablePause`<BR> | enableReplicationPause |
| UpdateTarget | `New-RscMutationReplication -Operation UpdateTarget`<BR> | updateReplicationTarget |

[Go to top](#)
## Report domain

Domain key: Report

Cmdlets: `New-RscQueryReport` and `New-RscMutationReport`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| Data | `New-RscQueryReport -Operation Data`<BR> | reportData |
| Scheduled | `New-RscQueryReport -Operation Scheduled`<BR> | scheduledReport |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| CreateCustom | `New-RscMutationReport -Operation CreateCustom`<BR> | createCustomReport |
| CreateScheduled | `New-RscMutationReport -Operation CreateScheduled`<BR> | createScheduledReport |
| DeleteCustom | `New-RscMutationReport -Operation DeleteCustom`<BR> | deleteCustomReport |
| DeleteScheduled | `New-RscMutationReport -Operation DeleteScheduled`<BR> | deleteScheduledReport |
| SendPdf | `New-RscMutationReport -Operation SendPdf`<BR> | sendPdfReport |
| SendScheduledAsync | `New-RscMutationReport -Operation SendScheduledAsync`<BR> | sendScheduledReportAsync |
| StartClusterMigrationJob | `New-RscMutationReport -Operation StartClusterMigrationJob`<BR> | startClusterReportMigrationJob |
| UpdateCustom | `New-RscMutationReport -Operation UpdateCustom`<BR> | updateCustomReport |
| UpdateScheduled | `New-RscMutationReport -Operation UpdateScheduled`<BR> | updateScheduledReport |

[Go to top](#)
## SAP HANA domain

Domain key: Saphana

Cmdlets: `New-RscQuerySaphana` and `New-RscMutationSaphana`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| Database | `New-RscQuerySaphana -Operation Database`<BR> | sapHanaDatabase |
| Databases | `New-RscQuerySaphana -Operation Databases`<BR> | sapHanaDatabases |
| LogSnapshot | `New-RscQuerySaphana -Operation LogSnapshot`<BR> | sapHanaLogSnapshot |
| LogSnapshots | `New-RscQuerySaphana -Operation LogSnapshots`<BR> | sapHanaLogSnapshots |
| RecoverableRange | `New-RscQuerySaphana -Operation RecoverableRange`<BR> | sapHanaRecoverableRange |
| RecoverableRanges | `New-RscQuerySaphana -Operation RecoverableRanges`<BR> | sapHanaRecoverableRanges |
| System | `New-RscQuerySaphana -Operation System`<BR> | sapHanaSystem |
| Systems | `New-RscQuerySaphana -Operation Systems`<BR> | sapHanaSystems |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| AddSystem | `New-RscMutationSaphana -Operation AddSystem`<BR> | addSapHanaSystem |
| ConfigureRestore | `New-RscMutationSaphana -Operation ConfigureRestore`<BR> | configureSapHanaRestore |
| CreateOnDemandBackup | `New-RscMutationSaphana -Operation CreateOnDemandBackup`<BR> | createOnDemandSapHanaBackup |
| CreateSystemRefresh | `New-RscMutationSaphana -Operation CreateSystemRefresh`<BR> | createSapHanaSystemRefresh |
| DeleteDbSnapshot | `New-RscMutationSaphana -Operation DeleteDbSnapshot`<BR> | deleteSapHanaDbSnapshot |
| DeleteSystem | `New-RscMutationSaphana -Operation DeleteSystem`<BR> | deleteSapHanaSystem |
| ExpireDownloadedSnapshots | `New-RscMutationSaphana -Operation ExpireDownloadedSnapshots`<BR> | expireDownloadedSapHanaSnapshots |
| PatchSystem | `New-RscMutationSaphana -Operation PatchSystem`<BR> | patchSapHanaSystem |
| UnconfigureRestore | `New-RscMutationSaphana -Operation UnconfigureRestore`<BR> | unconfigureSapHanaRestore |

[Go to top](#)
## Service Account domain

Domain key: ServiceAccount

Cmdlets: `New-RscQueryServiceAccount` and `New-RscMutationServiceAccount`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| ServiceAccount | `New-RscQueryServiceAccount -Operation ServiceAccount`<BR> | serviceAccounts |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| Create | `New-RscMutationServiceAccount -Operation Create`<BR> | createServiceAccount |
| Delete | `New-RscMutationServiceAccount -Operation Delete`<BR> | deleteServiceAccountsFromAccount |
| Rotate | `New-RscMutationServiceAccount -Operation Rotate`<BR> | rotateServiceAccountSecret |
| Update | `New-RscMutationServiceAccount -Operation Update`<BR> | updateServiceAccount |

[Go to top](#)
## Sharepoint domain

Domain key: Sharepoint

Cmdlets: `New-RscQuerySharepoint` and `New-RscMutationSharepoint`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| BrowseDrive | `New-RscQuerySharepoint -Operation BrowseDrive`<BR> | browseSharepointDrive |
| BrowseList | `New-RscQuerySharepoint -Operation BrowseList`<BR> | browseSharepointList |
| SiteDescendants | `New-RscQuerySharepoint -Operation SiteDescendants`<BR> | sharepointSiteDescendants |
| SiteExclusions | `New-RscQuerySharepoint -Operation SiteExclusions`<BR> | allSharepointSiteExclusions |
| SiteSearch | `New-RscQuerySharepoint -Operation SiteSearch`<BR> | sharepointSiteSearch |
| SnappableDriveSearch | `New-RscQuerySharepoint -Operation SnappableDriveSearch`<BR> | snappableSharepointDriveSearch |
| SnappableListSearch | `New-RscQuerySharepoint -Operation SnappableListSearch`<BR> | snappableSharepointListSearch |
| SnapshotDriveSearch | `New-RscQuerySharepoint -Operation SnapshotDriveSearch`<BR> | snapshotSharepointDriveSearch |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| ExcludeObjectsFromProtection | `New-RscMutationSharepoint -Operation ExcludeObjectsFromProtection`<BR> | excludeSharepointObjectsFromProtection |

[Go to top](#)
## SLA domain

Domain key: Sla

Cmdlets: `New-RscQuerySla` and `New-RscMutationSla`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| AuditDetail | `New-RscQuerySla -Operation AuditDetail`<BR> | slaAuditDetail |
| ClusterDomains | `New-RscQuerySla -Operation ClusterDomains`<BR> | clusterSlaDomains |
| ClusterGlobals | `New-RscQuerySla -Operation ClusterGlobals`<BR> | allClusterGlobalSlas |
| ConflictObjects | `New-RscQuerySla -Operation ConflictObjects`<BR> | slaConflictObjects |
| CountOfObjectsProtected | `New-RscQuerySla -Operation CountOfObjectsProtected`<BR> | countOfObjectsProtectedBySlas |
| Domain | `New-RscQuerySla -Operation Domain`<BR> | slaDomain |
| Domains | `New-RscQuerySla -Operation Domains`<BR> | slaDomains |
| GlobalFilterList | `New-RscQuerySla -Operation GlobalFilterList`<BR> | globalSlaFilterConnection |
| GlobalStatuses | `New-RscQuerySla -Operation GlobalStatuses`<BR> | globalSlaStatuses |
| ManagedVolume | `New-RscQuerySla -Operation ManagedVolume`<BR> | slaManagedVolume |
| ManagedVolumes | `New-RscQuerySla -Operation ManagedVolumes`<BR> | slaManagedVolumes |
| NcdComplianceData | `New-RscQuerySla -Operation NcdComplianceData`<BR> | allNcdSlaComplianceData |
| SummariesByIds | `New-RscQuerySla -Operation SummariesByIds`<BR> | allSlaSummariesByIds |
| VerifyWithReplicationToCluster | `New-RscQuerySla -Operation VerifyWithReplicationToCluster`<BR> | verifySlaWithReplicationToCluster |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| Assign | `New-RscMutationSla -Operation Assign`<BR> | assignSla |
| AssignRetentionToSnappables | `New-RscMutationSla -Operation AssignRetentionToSnappables`<BR> | assignRetentionSLAToSnappables |
| AssignRetentionToSnapshots | `New-RscMutationSla -Operation AssignRetentionToSnapshots`<BR> | assignRetentionSLAToSnapshots |
| AssignsForSnappableHierarchies | `New-RscMutationSla -Operation AssignsForSnappableHierarchies`<BR> | assignSlasForSnappableHierarchies |
| CreateGlobal | `New-RscMutationSla -Operation CreateGlobal`<BR> | createGlobalSla |
| ExportManagedVolumeSnapshot | `New-RscMutationSla -Operation ExportManagedVolumeSnapshot`<BR> | exportSlaManagedVolumeSnapshot |
| GetPendingAssignments | `New-RscMutationSla -Operation GetPendingAssignments`<BR> | getPendingSlaAssignments |
| Pause | `New-RscMutationSla -Operation Pause`<BR> | pauseSla |
| UpdateGlobal | `New-RscMutationSla -Operation UpdateGlobal`<BR> | updateGlobalSla |

[Go to top](#)
## SMB domain

Domain key: Smb

Cmdlets: `New-RscQuerySmb` and `New-RscMutationSmb`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| Configuration | `New-RscQuerySmb -Operation Configuration`<BR> | smbConfiguration |
| Domains | `New-RscQuerySmb -Operation Domains`<BR> | smbDomains |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| AddAndJoinDomain | `New-RscMutationSmb -Operation AddAndJoinDomain`<BR> | addAndJoinSmbDomain |
| DeleteDomain | `New-RscMutationSmb -Operation DeleteDomain`<BR> | deleteSmbDomain |
| JoinDomain | `New-RscMutationSmb -Operation JoinDomain`<BR> | joinSmbDomain |
| PutConfiguration | `New-RscMutationSmb -Operation PutConfiguration`<BR> | putSmbConfiguration |

[Go to top](#)
## Snapshot domain

Domain key: Snapshot

Cmdlets: `New-RscQuerySnapshot` and `New-RscMutationSnapshot`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| BrowseFileList | `New-RscQuerySnapshot -Operation BrowseFileList`<BR> | browseSnapshotFileConnection |
| EmailSearch | `New-RscQuerySnapshot -Operation EmailSearch`<BR> | snapshotEmailSearch |
| EventSearch | `New-RscQuerySnapshot -Operation EventSearch`<BR> | snapshotEventSearch |
| FilesDelta | `New-RscQuerySnapshot -Operation FilesDelta`<BR> | snapshotFilesDelta |
| FilesDeltaV2 | `New-RscQuerySnapshot -Operation FilesDeltaV2`<BR> | snapshotFilesDeltaV2 |
| Fileset | `New-RscQuerySnapshot -Operation Fileset`<BR> | filesetSnapshot |
| FilesetFiles | `New-RscQuerySnapshot -Operation FilesetFiles`<BR> | filesetSnapshotFiles |
| LegalHoldsForSnappable | `New-RscQuerySnapshot -Operation LegalHoldsForSnappable`<BR> | legalHoldSnapshotsForSnappable |
| OfASnappableList | `New-RscQuerySnapshot -Operation OfASnappableList`<BR> | snapshotOfASnappableConnection |
| OfSnappablesList | `New-RscQuerySnapshot -Operation OfSnappablesList`<BR> | snapshotOfSnappablesConnection |
| OnedriveSearch | `New-RscQuerySnapshot -Operation OnedriveSearch`<BR> | snapshotOnedriveSearch |
| Polaris | `New-RscQuerySnapshot -Operation Polaris`<BR> | polarisSnapshot |
| Pvcs | `New-RscQuerySnapshot -Operation Pvcs`<BR> | allSnapshotPvcs |
| QuarantinedDetailsFors | `New-RscQuerySnapshot -Operation QuarantinedDetailsFors`<BR> | allQuarantinedDetailsForSnapshots |
| Results | `New-RscQuerySnapshot -Operation Results`<BR> | snapshotResults |
| SForUnmanagedObject | `New-RscQuerySnapshot -Operation SForUnmanagedObject`<BR> | snapshotsForUnmanagedObject |
| SnappablesWithLegalHoldsSummary | `New-RscQuerySnapshot -Operation SnappablesWithLegalHoldsSummary`<BR> | snappablesWithLegalHoldSnapshotsSummary |
| Snapshot | `New-RscQuerySnapshot -Operation Snapshot`<BR> | snapshot |
| VappInstantRecoveryOptions | `New-RscQuerySnapshot -Operation VappInstantRecoveryOptions`<BR> | vappSnapshotInstantRecoveryOptions |
| VappTemplateExportOptions | `New-RscQuerySnapshot -Operation VappTemplateExportOptions`<BR> | vappTemplateSnapshotExportOptions |
| sClosestToPointInTime | `New-RscQuerySnapshot -Operation sClosestToPointInTime`<BR> | allSnapshotsClosestToPointInTime |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| BatchQuarantine | `New-RscMutationSnapshot -Operation BatchQuarantine`<BR> | batchQuarantineSnapshot |
| BatchReleaseFromQuarantine | `New-RscMutationSnapshot -Operation BatchReleaseFromQuarantine`<BR> | batchReleaseFromQuarantineSnapshot |
| BulkTierExistings | `New-RscMutationSnapshot -Operation BulkTierExistings`<BR> | bulkTierExistingSnapshots |
| CreateDownloadForVolumeGroup | `New-RscMutationSnapshot -Operation CreateDownloadForVolumeGroup`<BR> | createDownloadSnapshotForVolumeGroup |
| CreateFileset | `New-RscMutationSnapshot -Operation CreateFileset`<BR> | createFilesetSnapshot |
| DeleteCloudWorkload | `New-RscMutationSnapshot -Operation DeleteCloudWorkload`<BR> | deleteCloudWorkloadSnapshot |
| DeleteFilesets | `New-RscMutationSnapshot -Operation DeleteFilesets`<BR> | deleteFilesetSnapshots |
| FilesetDownloadFiles | `New-RscMutationSnapshot -Operation FilesetDownloadFiles`<BR> | filesetDownloadSnapshotFiles |
| FilesetExportFiles | `New-RscMutationSnapshot -Operation FilesetExportFiles`<BR> | filesetExportSnapshotFiles |
| RestoreVolumeGroupFiles | `New-RscMutationSnapshot -Operation RestoreVolumeGroupFiles`<BR> | restoreVolumeGroupSnapshotFiles |
| StartEc2InstanceExportJob | `New-RscMutationSnapshot -Operation StartEc2InstanceExportJob`<BR> | startEc2InstanceSnapshotExportJob |
| StartRecoverS3Job | `New-RscMutationSnapshot -Operation StartRecoverS3Job`<BR> | startRecoverS3SnapshotJob |
| TakeOnDemand | `New-RscMutationSnapshot -Operation TakeOnDemand`<BR> | takeOnDemandSnapshot |
| UploadDatabaseToBlobstore | `New-RscMutationSnapshot -Operation UploadDatabaseToBlobstore`<BR> | uploadDatabaseSnapshotToBlobstore |
| VmwareDownloadFromLocation | `New-RscMutationSnapshot -Operation VmwareDownloadFromLocation`<BR> | vmwareDownloadSnapshotFromLocation |

[Go to top](#)
## Sonar domain

Domain key: Sonar

Cmdlets: `New-RscQuerySonar` and `New-RscMutationSonar`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| ContentReport | `New-RscQuerySonar -Operation ContentReport`<BR> | sonarContentReport |
| Report | `New-RscQuerySonar -Operation Report`<BR> | sonarReport |
| ReportRow | `New-RscQuerySonar -Operation ReportRow`<BR> | sonarReportRow |
| UserGroups | `New-RscQuerySonar -Operation UserGroups`<BR> | sonarUserGroups |
| Users | `New-RscQuerySonar -Operation Users`<BR> | sonarUsers |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |

[Go to top](#)
## Storage Arrays domain

Domain key: Storagearray

Cmdlets: `New-RscQueryStoragearray` and `New-RscMutationStoragearray`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| Storagearray | `New-RscQueryStoragearray -Operation Storagearray`<BR> | allStorageArrays |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| Add | `New-RscMutationStoragearray -Operation Add`<BR> | addStorageArrays |
| Delete | `New-RscMutationStoragearray -Operation Delete`<BR> | deleteStorageArrays |
| Refresh | `New-RscMutationStoragearray -Operation Refresh`<BR> | refreshStorageArrays |
| Update | `New-RscMutationStoragearray -Operation Update`<BR> | updateStorageArrays |

[Go to top](#)
## Tape domain

Domain key: Tape

Cmdlets: `New-RscQueryTape` and `New-RscMutationTape`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| CreateReaderTarget | `New-RscMutationTape -Operation CreateReaderTarget`<BR> | createTapeReaderTarget |
| CreateTarget | `New-RscMutationTape -Operation CreateTarget`<BR> | createTapeTarget |
| UpdateTarget | `New-RscMutationTape -Operation UpdateTarget`<BR> | updateTapeTarget |

[Go to top](#)
## Threat domain

Domain key: Threat

Cmdlets: `New-RscQueryThreat` and `New-RscMutationThreat`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| HuntDetail | `New-RscQueryThreat -Operation HuntDetail`<BR> | threatHuntDetail |
| HuntResult | `New-RscQueryThreat -Operation HuntResult`<BR> | threatHuntResult |
| HuntSummary | `New-RscQueryThreat -Operation HuntSummary`<BR> | threatHuntSummary |
| Hunts | `New-RscQueryThreat -Operation Hunts`<BR> | threatHunts |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| CancelHunt | `New-RscMutationThreat -Operation CancelHunt`<BR> | cancelThreatHunt |
| EnableMonitoring | `New-RscMutationThreat -Operation EnableMonitoring`<BR> | enableThreatMonitoring |
| StartHunt | `New-RscMutationThreat -Operation StartHunt`<BR> | startThreatHunt |

[Go to top](#)
## vSphere vCenter domain

Domain key: Vcenter

Cmdlets: `New-RscQueryVcenter` and `New-RscMutationVcenter`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| AdvancedTagPreview | `New-RscQueryVcenter -Operation AdvancedTagPreview`<BR> | vCenterAdvancedTagPreview |
| HotAddBandwidth | `New-RscQueryVcenter -Operation HotAddBandwidth`<BR> | vCenterHotAddBandwidth |
| HotAddNetwork | `New-RscQueryVcenter -Operation HotAddNetwork`<BR> | vCenterHotAddNetwork |
| HotAddProxy | `New-RscQueryVcenter -Operation HotAddProxy`<BR> | allVcenterHotAddProxyVms |
| List | `New-RscQueryVcenter -Operation List`<BR> | vSphereVCenterConnection |
| Networks | `New-RscQueryVcenter -Operation Networks`<BR> | vCenterNetworks |
| NumProxiesNeeded | `New-RscQueryVcenter -Operation NumProxiesNeeded`<BR> | vCenterNumProxiesNeeded |
| PreAddInfo | `New-RscQueryVcenter -Operation PreAddInfo`<BR> | vCenterPreAddInfo |
| Vcenter | `New-RscQueryVcenter -Operation Vcenter`<BR> | vSphereVCenter |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| Create | `New-RscMutationVcenter -Operation Create`<BR> | createVsphereVcenter |
| Delete | `New-RscMutationVcenter -Operation Delete`<BR> | vsphereDeleteVcenter |
| Refresh | `New-RscMutationVcenter -Operation Refresh`<BR> | refreshVsphereVcenter |
| Update | `New-RscMutationVcenter -Operation Update`<BR> | updateVcenter |
| UpdateHotAddBandwidth | `New-RscMutationVcenter -Operation UpdateHotAddBandwidth`<BR> | updateVcenterHotAddBandwidth |
| UpdateHotAddNetwork | `New-RscMutationVcenter -Operation UpdateHotAddNetwork`<BR> | updateVcenterHotAddNetwork |

[Go to top](#)
## vSphere domain

Domain key: Vsphere

Cmdlets: `New-RscQueryVsphere` and `New-RscMutationVsphere`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| ComputeCluster | `New-RscQueryVsphere -Operation ComputeCluster`<BR> | vSphereComputeCluster |
| ComputeClusters | `New-RscQueryVsphere -Operation ComputeClusters`<BR> | vSphereComputeClusters |
| Datacenter | `New-RscQueryVsphere -Operation Datacenter`<BR> | vSphereDatacenter |
| Datastore | `New-RscQueryVsphere -Operation Datastore`<BR> | vSphereDatastore |
| DatastoreCluster | `New-RscQueryVsphere -Operation DatastoreCluster`<BR> | vSphereDatastoreCluster |
| DatastoreClusters | `New-RscQueryVsphere -Operation DatastoreClusters`<BR> | vSphereDatastoreClusters |
| DatastoreList | `New-RscQueryVsphere -Operation DatastoreList`<BR> | vSphereDatastoreConnection |
| Folder | `New-RscQueryVsphere -Operation Folder`<BR> | vSphereFolder |
| Folders | `New-RscQueryVsphere -Operation Folders`<BR> | vSphereFolders |
| Host | `New-RscQueryVsphere -Operation Host`<BR> | vSphereHost |
| HostDetails | `New-RscQueryVsphere -Operation HostDetails`<BR> | vSphereHostDetails |
| HostList | `New-RscQueryVsphere -Operation HostList`<BR> | vSphereHostConnection |
| HostsByFids | `New-RscQueryVsphere -Operation HostsByFids`<BR> | vSphereHostsByFids |
| LiveMounts | `New-RscQueryVsphere -Operation LiveMounts`<BR> | vSphereLiveMounts |
| Mount | `New-RscQueryVsphere -Operation Mount`<BR> | vSphereMount |
| MountList | `New-RscQueryVsphere -Operation MountList`<BR> | vSphereMountConnection |
| Network | `New-RscQueryVsphere -Operation Network`<BR> | vSphereNetwork |
| ResourcePool | `New-RscQueryVsphere -Operation ResourcePool`<BR> | vSphereResourcePool |
| RootRecoveryHierarchy | `New-RscQueryVsphere -Operation RootRecoveryHierarchy`<BR> | vSphereRootRecoveryHierarchy |
| Tag | `New-RscQueryVsphere -Operation Tag`<BR> | vSphereTag |
| TagCategory | `New-RscQueryVsphere -Operation TagCategory`<BR> | vSphereTagCategory |
| TopLevelDescendantsList | `New-RscQueryVsphere -Operation TopLevelDescendantsList`<BR> | vSphereTopLevelDescendantsConnection |
| VmwareCdpLiveInfo | `New-RscQueryVsphere -Operation VmwareCdpLiveInfo`<BR> | vsphereVmwareCdpLiveInfo |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| BulkOnDemandSnapshot | `New-RscMutationVsphere -Operation BulkOnDemandSnapshot`<BR> | vsphereBulkOnDemandSnapshot |
| CreateAdvancedTag | `New-RscMutationVsphere -Operation CreateAdvancedTag`<BR> | createVsphereAdvancedTag |
| DeleteAdvancedTag | `New-RscMutationVsphere -Operation DeleteAdvancedTag`<BR> | deleteVsphereAdvancedTag |
| DeleteLiveMount | `New-RscMutationVsphere -Operation DeleteLiveMount`<BR> | deleteVsphereLiveMount |
| DownloadVirtualMachineFiles | `New-RscMutationVsphere -Operation DownloadVirtualMachineFiles`<BR> | downloadVsphereVirtualMachineFiles |
| ExportSnapshotToStandaloneHostV2 | `New-RscMutationVsphere -Operation ExportSnapshotToStandaloneHostV2`<BR> | vsphereExportSnapshotToStandaloneHostV2 |
| OnDemandSnapshot | `New-RscMutationVsphere -Operation OnDemandSnapshot`<BR> | vsphereOnDemandSnapshot |
| UpdateAdvancedTag | `New-RscMutationVsphere -Operation UpdateAdvancedTag`<BR> | updateVsphereAdvancedTag |

[Go to top](#)
## vSphere VM domain

Domain key: VsphereVm

Cmdlets: `New-RscQueryVsphereVm` and `New-RscMutationVsphereVm`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| AsyncRequestStatus | `New-RscQueryVsphereVm -Operation AsyncRequestStatus`<BR> | vSphereVMAsyncRequestStatus |
| MissedRecoverableRange | `New-RscQueryVsphereVm -Operation MissedRecoverableRange`<BR> | vsphereVMMissedRecoverableRange |
| New | `New-RscQueryVsphereVm -Operation New`<BR> | vSphereVmNew |
| NewList | `New-RscQueryVsphereVm -Operation NewList`<BR> | vSphereVmNewConnection |
| RecoverableRange | `New-RscQueryVsphereVm -Operation RecoverableRange`<BR> | vsphereVMRecoverableRange |
| RecoverableRangeInBatch | `New-RscQueryVsphereVm -Operation RecoverableRangeInBatch`<BR> | vsphereVMRecoverableRangeInBatch |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| BatchExport | `New-RscMutationVsphereVm -Operation BatchExport`<BR> | vsphereVmBatchExport |
| BatchExportV3 | `New-RscMutationVsphereVm -Operation BatchExportV3`<BR> | vsphereVmBatchExportV3 |
| BatchInPlaceRecovery | `New-RscMutationVsphereVm -Operation BatchInPlaceRecovery`<BR> | vsphereVmBatchInPlaceRecovery |
| DeleteSnapshot | `New-RscMutationVsphereVm -Operation DeleteSnapshot`<BR> | vsphereVmDeleteSnapshot |
| DownloadSnapshot | `New-RscMutationVsphereVm -Operation DownloadSnapshot`<BR> | vsphereVmDownloadSnapshot |
| DownloadSnapshotFiles | `New-RscMutationVsphereVm -Operation DownloadSnapshotFiles`<BR> | vsphereVmDownloadSnapshotFiles |
| ExcludeVmDisks | `New-RscMutationVsphereVm -Operation ExcludeVmDisks`<BR> | vsphereExcludeVmDisks |
| ExportSnapshotV2 | `New-RscMutationVsphereVm -Operation ExportSnapshotV2`<BR> | vsphereVmExportSnapshotV2 |
| ExportSnapshotV3 | `New-RscMutationVsphereVm -Operation ExportSnapshotV3`<BR> | vsphereVmExportSnapshotV3 |
| ExportSnapshotWithDownloadFromCloud | `New-RscMutationVsphereVm -Operation ExportSnapshotWithDownloadFromCloud`<BR> | vsphereVmExportSnapshotWithDownloadFromCloud |
| InitiateBatchInstantRecovery | `New-RscMutationVsphereVm -Operation InitiateBatchInstantRecovery`<BR> | vsphereVmInitiateBatchInstantRecovery |
| InitiateBatchLiveMountV2 | `New-RscMutationVsphereVm -Operation InitiateBatchLiveMountV2`<BR> | vsphereVmInitiateBatchLiveMountV2 |
| InitiateDiskMount | `New-RscMutationVsphereVm -Operation InitiateDiskMount`<BR> | vsphereVmInitiateDiskMount |
| InitiateInPlaceRecovery | `New-RscMutationVsphereVm -Operation InitiateInPlaceRecovery`<BR> | vsphereVmInitiateInPlaceRecovery |
| InitiateInstantRecoveryV2 | `New-RscMutationVsphereVm -Operation InitiateInstantRecoveryV2`<BR> | vsphereVmInitiateInstantRecoveryV2 |
| InitiateLiveMountV2 | `New-RscMutationVsphereVm -Operation InitiateLiveMountV2`<BR> | vsphereVmInitiateLiveMountV2 |
| ListEsxiDatastores | `New-RscMutationVsphereVm -Operation ListEsxiDatastores`<BR> | vsphereVmListEsxiDatastores |
| MountRelocate | `New-RscMutationVsphereVm -Operation MountRelocate`<BR> | vsphereVmMountRelocate |
| MountRelocateV2 | `New-RscMutationVsphereVm -Operation MountRelocateV2`<BR> | vsphereVmMountRelocateV2 |
| PowerOnOffLiveMount | `New-RscMutationVsphereVm -Operation PowerOnOffLiveMount`<BR> | vsphereVmPowerOnOffLiveMount |
| RecoverFiles | `New-RscMutationVsphereVm -Operation RecoverFiles`<BR> | vsphereVmRecoverFiles |
| RecoverFilesNew | `New-RscMutationVsphereVm -Operation RecoverFilesNew`<BR> | vsphereVmRecoverFilesNew |
| RegisterAgent | `New-RscMutationVsphereVm -Operation RegisterAgent`<BR> | vsphereVmRegisterAgent |
| Update | `New-RscMutationVsphereVm -Operation Update`<BR> | updateVsphereVm |

[Go to top](#)
## Webhook domain

Domain key: Webhook

Cmdlets: `New-RscQueryWebhook` and `New-RscMutationWebhook`

### Queries

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| Webhook | `New-RscQueryWebhook -Operation Webhook`<BR> | allWebhooks |

[Go to top](#)
### Mutations

| Operation | Invocation | GraphQL Root Field |
| --- | --- | --- |
| Create | `New-RscMutationWebhook -Operation Create`<BR> | createWebhook |
| Delete | `New-RscMutationWebhook -Operation Delete`<BR> | deleteWebhook |
| Test | `New-RscMutationWebhook -Operation Test`<BR> | testWebhook |
| TestExisting | `New-RscMutationWebhook -Operation TestExisting`<BR> | testExistingWebhook |
| Update | `New-RscMutationWebhook -Operation Update`<BR> | updateWebhook |

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
