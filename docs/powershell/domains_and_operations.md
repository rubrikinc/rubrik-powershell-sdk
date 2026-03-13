# Migrating from Domain Cmdlets to `New-RscQuery -Gql`

> **The domain cmdlets (`New-RscQuery<Domain>`, `New-RscMutation<Domain>`)
> are deprecated.** They still work, but new code should use:
> ```powershell
> New-RscQuery -Gql <queryName>
> New-RscMutation -Gql <mutationName>
> ```
> Use `Get-RscCmdlet <keyword>` to search for the GraphQL query name.
> See the [developer manual](developer_manual.md) for details.

This document lists every domain cmdlet and its replacement.

## Table of Contents

Numbers in parentheses indicate the number of queries and mutations in the domain.

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Account (9,14)](#account-domain) | [Cluster (45,23)](#cluster-domain) | [LDAP (3,4)](#ldap-domain) | [Oracle (18,20)](#oracle-domain) | [Snapshot (31,26)](#snapshot-domain) |
| [Active Directory (5,5)](#active-directory-domain) | [Cross Account (1,4)](#cross-account-domain) | [Microsoft 365 (11,4)](#microsoft-365-domain) | [Policy (10,16)](#policy-domain) | [SNMP (1,1)](#snmp-domain) |
| [Activity series (5,3)](#activity-series-domain) | [Db2 (11,13)](#db2-domain) | [Managed Volume (4,12)](#managed-volume-domain) | [Ransomware (9,2)](#ransomware-domain) | [Sonar (2,0)](#sonar-domain) |
| [Archival (14,20)](#archival-domain) | [Report Download (4,23)](#report-download-domain) | [Miscellaneous (240,201)](#miscellaneous-domain) | [RCS (0,4)](#rcs-domain) | [Storage Arrays (1,4)](#storage-arrays-domain) |
| [AWS (36,34)](#aws-domain) | [Microsoft Exchange (7,4)](#microsoft-exchange-domain) | [Mongo (11,13)](#mongo-domain) | [RCV (5,7)](#rcv-domain) | [Syslog (1,4)](#syslog-domain) |
| [AWS Native (22,8)](#aws-native-domain) | [Failover Cluster (5,8)](#failover-cluster-domain) | [Mongo DB (8,6)](#mongo-db-domain) | [Replication (7,6)](#replication-domain) | [Tape (0,3)](#tape-domain) |
| [Azure (60,46)](#azure-domain) | [Fileset (6,10)](#fileset-domain) | [Mosaic (4,3)](#mosaic-domain) | [Report (18,8)](#report-domain) | [Threat (18,7)](#threat-domain) |
| [Azure Native (26,9)](#azure-native-domain) | [Google Cloud Platform (22,14)](#google-cloud-platform-domain) | [Microsoft SQL Server (20,25)](#microsoft-sql-server-domain) | [SAP HANA (8,15)](#sap-hana-domain) | [VMware vSphere vCenter (11,7)](#vmware-vsphere-vcenter-domain) |
| [Azure Office365 (11,1)](#azure-office365-domain) | [Google Cloud Platform Native (8,5)](#google-cloud-platform-native-domain) | [NAS (12,10)](#nas-domain) | [Service Account (2,4)](#service-account-domain) | [VMware (4,1)](#vmware-domain) |
| [Cassandra (8,5)](#cassandra-domain) | [Host (8,10)](#host-domain) | [NAS Cloud Direct (7,0)](#nas-cloud-direct-domain) | [Sharepoint (8,1)](#sharepoint-domain) | [VMware vSphere (26,12)](#vmware-vsphere-domain) |
| [Certificates (11,12)](#certificates-domain) | [Microsoft Hyper-V (16,26)](#microsoft-hyper-v-domain) | [NFS (0,3)](#nfs-domain) | [SLA (15,12)](#sla-domain) | [VMware vSphere VM (8,29)](#vmware-vsphere-vm-domain) |
| [Cloud Account (8,4)](#cloud-account-domain) | [Integration (2,7)](#integration-domain) | [Nutanix (21,30)](#nutanix-domain) | [SMB (2,7)](#smb-domain) | [Webhook (5,12)](#webhook-domain) |
| [Cloud Native (22,15)](#cloud-native-domain) | [Kubernetes (13,24)](#kubernetes-domain) | [Office 365 (42,35)](#office-365-domain) | [Snappable (13,0)](#snappable-domain) |  |

## Account domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryAccount -Operation CurrentUser` | `New-RscQuery -Gql currentUser` | [currentUser](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAccount -Operation CurrentUserLoginContext` | `New-RscQuery -Gql currentUserLoginContext` | [currentUserLoginContext](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAccount -Operation EnabledFeatures` | `New-RscQuery -Gql allEnabledFeaturesForAccount` | [allEnabledFeaturesForAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAccount -Operation Id` | `New-RscQuery -Gql accountId` | [accountId](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAccount -Operation Lookup` | `New-RscQuery -Gql lookupAccount` | [lookupAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAccount -Operation Owners` | `New-RscQuery -Gql allAccountOwners` | [allAccountOwners](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAccount -Operation Products` | `New-RscQuery -Gql allAccountProducts` | [allAccountProducts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAccount -Operation Settings` | `New-RscQuery -Gql accountSettings` | [accountSettings](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAccount -Operation Users` | `New-RscQuery -Gql allUsersOnAccount` | [allUsersOnAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationAccount -Operation CreateOrg` | `New-RscMutation -Gql createOrg` | [createOrg](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAccount -Operation CreateOrgSwitchSession` | `New-RscMutation -Gql createOrgSwitchSession` | [createOrgSwitchSession](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAccount -Operation CreateRole` | `New-RscMutation -Gql createRole` | [createRole](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAccount -Operation CreateUser` | `New-RscMutation -Gql createUser` | [createUser](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAccount -Operation CreateUserWithPassword` | `New-RscMutation -Gql createUserWithPassword` | [createUserWithPassword](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAccount -Operation DeleteOrg` | `New-RscMutation -Gql deleteOrg` | [deleteOrg](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAccount -Operation DeleteRole` | `New-RscMutation -Gql deleteRole` | [deleteRole](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAccount -Operation DeleteTotpConfig` | `New-RscMutation -Gql deleteTotpConfig` | [deleteTotpConfig](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAccount -Operation DeleteTotpConfigs` | `New-RscMutation -Gql deleteTotpConfigs` | [deleteTotpConfigs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAccount -Operation DeleteUsers` | `New-RscMutation -Gql deleteUsersFromAccount` | [deleteUsersFromAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAccount -Operation GenerateTotpSecret` | `New-RscMutation -Gql generateTotpSecret` | [generateTotpSecret](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAccount -Operation MutateRole` | `New-RscMutation -Gql mutateRole` | [mutateRole](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAccount -Operation UpdateOrg` | `New-RscMutation -Gql updateOrg` | [updateOrg](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAccount -Operation UpdateRole` | `New-RscMutation -Gql updateRole` | [updateRole](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Active Directory domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryActiveDirectory -Operation Domain` | `New-RscQuery -Gql activeDirectoryDomain` | [activeDirectoryDomain](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryActiveDirectory -Operation DomainController` | `New-RscQuery -Gql activeDirectoryDomainController` | [activeDirectoryDomainController](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryActiveDirectory -Operation DomainControllers` | `New-RscQuery -Gql activeDirectoryDomainControllers` | [activeDirectoryDomainControllers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryActiveDirectory -Operation Domains` | `New-RscQuery -Gql activeDirectoryDomains` | [activeDirectoryDomains](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryActiveDirectory -Operation SearchSnapshots` | `New-RscQuery -Gql activeDirectorySearchSnapshots` | [activeDirectorySearchSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationActiveDirectory -Operation CreateDownloadFilesJob` | `New-RscMutation -Gql createActiveDirectoryDownloadFilesJob` | [createActiveDirectoryDownloadFilesJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationActiveDirectory -Operation CreateLiveMount` | `New-RscMutation -Gql createActiveDirectoryLiveMount` | [createActiveDirectoryLiveMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationActiveDirectory -Operation CreateUnmount` | `New-RscMutation -Gql createActiveDirectoryUnmount` | [createActiveDirectoryUnmount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationActiveDirectory -Operation ModifyLiveMount` | `New-RscMutation -Gql modifyActiveDirectoryLiveMount` | [modifyActiveDirectoryLiveMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationActiveDirectory -Operation RestoreObjects` | `New-RscMutation -Gql restoreActiveDirectoryObjects` | [restoreActiveDirectoryObjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Activity series domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryActivitySeries -Operation ActivitySeries` | `New-RscQuery -Gql activitySeries` | [activitySeries](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryActivitySeries -Operation List` | `New-RscQuery -Gql activitySeriesConnection` | [activitySeriesConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryActivitySeries -Operation SessionInTimeoutInSeconds` | `New-RscQuery -Gql sessionInactivityTimeoutInSeconds` | [sessionInactivityTimeoutInSeconds](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryActivitySeries -Operation UserFileTimeline` | `New-RscQuery -Gql userFileActivityTimeline` | [userFileActivityTimeline](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryActivitySeries -Operation UserTimeline` | `New-RscQuery -Gql userActivityTimeline` | [userActivityTimeline](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationActivitySeries -Operation Cancel` | `New-RscMutation -Gql cancelActivitySeries` | [cancelActivitySeries](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationActivitySeries -Operation DownloadUserCsv` | `New-RscMutation -Gql downloadUserActivityCsv` | [downloadUserActivityCsv](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationActivitySeries -Operation DownloadUserFileCsv` | `New-RscMutation -Gql downloadUserFileActivityCsv` | [downloadUserFileActivityCsv](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Archival domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryArchival -Operation Entities` | `New-RscQuery -Gql archivalEntities` | [archivalEntities](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryArchival -Operation FailoverGroupLocations` | `New-RscQuery -Gql failoverGroupArchivalLocations` | [failoverGroupArchivalLocations](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryArchival -Operation FeaturePermissionForDataCenterRoleBased` | `New-RscQuery -Gql featurePermissionForDataCenterRoleBasedArchival` | [featurePermissionForDataCenterRoleBasedArchival](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryArchival -Operation HierarchyObjectRecoveryTarget` | `New-RscQuery -Gql hierarchyObjectRecoveryTarget` | [hierarchyObjectRecoveryTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryArchival -Operation IsTotpMandatoryInTargetVersion` | `New-RscQuery -Gql isTotpMandatoryInTargetVersion` | [isTotpMandatoryInTargetVersion](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryArchival -Operation Migration` | `New-RscQuery -Gql archivalMigration` | [archivalMigration](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryArchival -Operation PerObjectInfo` | `New-RscQuery -Gql archivalPerObjectInfo` | [archivalPerObjectInfo](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryArchival -Operation RcsLocationsConsumptionStats` | `New-RscQuery -Gql rcsArchivalLocationsConsumptionStats` | [rcsArchivalLocationsConsumptionStats](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryArchival -Operation ReaderInfo` | `New-RscQuery -Gql archivalReaderInfo` | [archivalReaderInfo](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryArchival -Operation StorageUsage` | `New-RscQuery -Gql archivalStorageUsage` | [archivalStorageUsage](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryArchival -Operation Target` | `New-RscQuery -Gql target` | [target](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryArchival -Operation TargetMapping` | `New-RscQuery -Gql targetMapping` | [targetMapping](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryArchival -Operation TargetMappings` | `New-RscQuery -Gql allTargetMappings` | [allTargetMappings](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryArchival -Operation Targets` | `New-RscQuery -Gql targets` | [targets](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationArchival -Operation CreateGlacierReaderTarget` | `New-RscMutation -Gql createGlacierReaderTarget` | [createGlacierReaderTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationArchival -Operation CreateManualTargetMapping` | `New-RscMutation -Gql createManualTargetMapping` | [createManualTargetMapping](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationArchival -Operation CreateS3CompatibleReaderTarget` | `New-RscMutation -Gql createS3CompatibleReaderTarget` | [createS3CompatibleReaderTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationArchival -Operation CreateS3CompatibleTarget` | `New-RscMutation -Gql createS3CompatibleTarget` | [createS3CompatibleTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationArchival -Operation DeleteTarget` | `New-RscMutation -Gql deleteTarget` | [deleteTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationArchival -Operation DeleteTargetMapping` | `New-RscMutation -Gql deleteTargetMapping` | [deleteTargetMapping](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationArchival -Operation DisableTarget` | `New-RscMutation -Gql disableTarget` | [disableTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationArchival -Operation EnableTarget` | `New-RscMutation -Gql enableTarget` | [enableTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationArchival -Operation FilesetDownloadSnapshotFilesFromLocation` | `New-RscMutation -Gql filesetDownloadSnapshotFilesFromArchivalLocation` | [filesetDownloadSnapshotFilesFromArchivalLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationArchival -Operation FinishMigration` | `New-RscMutation -Gql finishArchivalMigration` | [finishArchivalMigration](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationArchival -Operation PauseTarget` | `New-RscMutation -Gql pauseTarget` | [pauseTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationArchival -Operation PromoteReaderTarget` | `New-RscMutation -Gql promoteReaderTarget` | [promoteReaderTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationArchival -Operation RefreshReaderTarget` | `New-RscMutation -Gql refreshReaderTarget` | [refreshReaderTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationArchival -Operation RegisterMigration` | `New-RscMutation -Gql registerArchivalMigration` | [registerArchivalMigration](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationArchival -Operation ResumeTarget` | `New-RscMutation -Gql resumeTarget` | [resumeTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationArchival -Operation TerminateMigration` | `New-RscMutation -Gql terminateArchivalMigration` | [terminateArchivalMigration](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationArchival -Operation UpdateGlacierTarget` | `New-RscMutation -Gql updateGlacierTarget` | [updateGlacierTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationArchival -Operation UpdateManualTargetMapping` | `New-RscMutation -Gql updateManualTargetMapping` | [updateManualTargetMapping](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationArchival -Operation UpdateS3CompatibleTarget` | `New-RscMutation -Gql updateS3CompatibleTarget` | [updateS3CompatibleTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationArchival -Operation UpgradeCdmManagedTarget` | `New-RscMutation -Gql upgradeCdmManagedTarget` | [upgradeCdmManagedTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## AWS domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryAws -Operation ArtifactsToDelete` | `New-RscQuery -Gql awsArtifactsToDelete` | [awsArtifactsToDelete](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAws -Operation AvailabilityZonesByRegion` | `New-RscQuery -Gql allAvailabilityZonesByRegionFromAws` | [allAvailabilityZonesByRegionFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAws -Operation BatchSupportedRdsDatabaseInstanceClasses` | `New-RscQuery -Gql batchSupportedAwsRdsDatabaseInstanceClasses` | [batchSupportedAwsRdsDatabaseInstanceClasses](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAws -Operation CdmVersions` | `New-RscQuery -Gql allAwsCdmVersions` | [allAwsCdmVersions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAws -Operation CloudAccountConfigs` | `New-RscQuery -Gql allAwsCloudAccountConfigs` | [allAwsCloudAccountConfigs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAws -Operation CloudAccountListSecurityGroups` | `New-RscQuery -Gql awsCloudAccountListSecurityGroups` | [awsCloudAccountListSecurityGroups](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAws -Operation CloudAccountListSubnets` | `New-RscQuery -Gql awsCloudAccountListSubnets` | [awsCloudAccountListSubnets](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAws -Operation CloudAccountListVpcs` | `New-RscQuery -Gql awsCloudAccountListVpcs` | [awsCloudAccountListVpcs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAws -Operation CloudAccountWithFeatures` | `New-RscQuery -Gql awsCloudAccountWithFeatures` | [awsCloudAccountWithFeatures](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAws -Operation CloudAccountsWithFeatures` | `New-RscQuery -Gql allAwsCloudAccountsWithFeatures` | [allAwsCloudAccountsWithFeatures](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAws -Operation DbParameterGroupsByRegion` | `New-RscQuery -Gql allDbParameterGroupsByRegionFromAws` | [allDbParameterGroupsByRegionFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAws -Operation DbSubnetGroupsByRegion` | `New-RscQuery -Gql allDbSubnetGroupsByRegionFromAws` | [allDbSubnetGroupsByRegionFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAws -Operation Ec2InstanceTypesByRegion` | `New-RscQuery -Gql allEc2InstanceTypesByRegionFromAws` | [allEc2InstanceTypesByRegionFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAws -Operation Ec2KeyPairsByRegion` | `New-RscQuery -Gql allEc2KeyPairsByRegionFromAws` | [allEc2KeyPairsByRegionFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAws -Operation EligibleAccountsForMigrationToOrg` | `New-RscQuery -Gql eligibleAccountsForMigrationToAwsOrg` | [eligibleAccountsForMigrationToAwsOrg](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAws -Operation ExocomputeConfigs` | `New-RscQuery -Gql allAwsExocomputeConfigs` | [allAwsExocomputeConfigs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAws -Operation ExocomputeGetClusterConnectionInfo` | `New-RscQuery -Gql awsExocomputeGetClusterConnectionInfo` | [awsExocomputeGetClusterConnectionInfo](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAws -Operation InstanceProfileNames` | `New-RscQuery -Gql allAwsInstanceProfileNames` | [allAwsInstanceProfileNames](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAws -Operation IsS3BucketNameAvailable` | `New-RscQuery -Gql isAwsS3BucketNameAvailable` | [isAwsS3BucketNameAvailable](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAws -Operation KmsEncryptionKeysByRegion` | `New-RscQuery -Gql allKmsEncryptionKeysByRegionFromAws` | [allKmsEncryptionKeysByRegionFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAws -Operation MarketplaceSubscriptionInfo` | `New-RscQuery -Gql awsMarketplaceSubscriptionInfo` | [awsMarketplaceSubscriptionInfo](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAws -Operation OptionGroupsByRegion` | `New-RscQuery -Gql allOptionGroupsByRegionFromAws` | [allOptionGroupsByRegionFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAws -Operation PermissionPolicies` | `New-RscQuery -Gql allAwsPermissionPolicies` | [allAwsPermissionPolicies](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAws -Operation RdsInstanceDetails` | `New-RscQuery -Gql rdsInstanceDetailsFromAws` | [rdsInstanceDetailsFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAws -Operation RegionDetails` | `New-RscQuery -Gql awsRegionDetails` | [awsRegionDetails](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAws -Operation Regions` | `New-RscQuery -Gql allAwsRegions` | [allAwsRegions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAws -Operation S3BucketStateForRecovery` | `New-RscQuery -Gql s3BucketStateForRecovery` | [s3BucketStateForRecovery](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAws -Operation S3Buckets` | `New-RscQuery -Gql allS3BucketsFromAws` | [allS3BucketsFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAws -Operation S3BucketsDetails` | `New-RscQuery -Gql allS3BucketsDetailsFromAws` | [allS3BucketsDetailsFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAws -Operation SupportedEksVersions` | `New-RscQuery -Gql allSupportedAwsEksVersions` | [allSupportedAwsEksVersions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAws -Operation SupportedRdsDatabaseInstanceClasses` | `New-RscQuery -Gql allSupportedAwsRdsDatabaseInstanceClasses` | [allSupportedAwsRdsDatabaseInstanceClasses](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAws -Operation TrustPolicy` | `New-RscQuery -Gql awsTrustPolicy` | [awsTrustPolicy](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAws -Operation ValidateCreateClusterInput` | `New-RscQuery -Gql validateCreateAwsClusterInput` | [validateCreateAwsClusterInput](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAws -Operation ValidatePermissions` | `New-RscQuery -Gql awsValidatePermissions` | [awsValidatePermissions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAws -Operation Vpcs` | `New-RscQuery -Gql allVpcsFromAws` | [allVpcsFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAws -Operation VpcsByRegion` | `New-RscQuery -Gql allVpcsByRegionFromAws` | [allVpcsByRegionFromAws](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationAws -Operation AddAuthenticationServerBasedCloudAccount` | `New-RscMutation -Gql addAwsAuthenticationServerBasedCloudAccount` | [addAwsAuthenticationServerBasedCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAws -Operation AddIamUserBasedCloudAccount` | `New-RscMutation -Gql addAwsIamUserBasedCloudAccount` | [addAwsIamUserBasedCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAws -Operation BulkDeleteCloudAccountWithoutCft` | `New-RscMutation -Gql bulkDeleteAwsCloudAccountWithoutCft` | [bulkDeleteAwsCloudAccountWithoutCft](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAws -Operation CloudAccountsMigrateInitiate` | `New-RscMutation -Gql awsCloudAccountsMigrateInitiate` | [awsCloudAccountsMigrateInitiate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAws -Operation CreateAccount` | `New-RscMutation -Gql createAwsAccount` | [createAwsAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAws -Operation CreateAutomaticTargetMapping` | `New-RscMutation -Gql createAutomaticAwsTargetMapping` | [createAutomaticAwsTargetMapping](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAws -Operation CreateCloudNativeStorageSetting` | `New-RscMutation -Gql createCloudNativeAwsStorageSetting` | [createCloudNativeAwsStorageSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAws -Operation CreateCluster` | `New-RscMutation -Gql createAwsCluster` | [createAwsCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAws -Operation CreateExocomputeConfigs` | `New-RscMutation -Gql createAwsExocomputeConfigs` | [createAwsExocomputeConfigs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAws -Operation CreateReaderTarget` | `New-RscMutation -Gql createAwsReaderTarget` | [createAwsReaderTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAws -Operation CreateTarget` | `New-RscMutation -Gql createAwsTarget` | [createAwsTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAws -Operation DeleteExocomputeConfigs` | `New-RscMutation -Gql deleteAwsExocomputeConfigs` | [deleteAwsExocomputeConfigs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAws -Operation DisconnectExocomputeCluster` | `New-RscMutation -Gql disconnectAwsExocomputeCluster` | [disconnectAwsExocomputeCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAws -Operation ExocomputeClusterConnect` | `New-RscMutation -Gql awsExocomputeClusterConnect` | [awsExocomputeClusterConnect](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAws -Operation FinalizeCloudAccountDeletion` | `New-RscMutation -Gql finalizeAwsCloudAccountDeletion` | [finalizeAwsCloudAccountDeletion](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAws -Operation FinalizeCloudAccountProtection` | `New-RscMutation -Gql finalizeAwsCloudAccountProtection` | [finalizeAwsCloudAccountProtection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAws -Operation PatchAuthenticationServerBasedCloudAccount` | `New-RscMutation -Gql patchAwsAuthenticationServerBasedCloudAccount` | [patchAwsAuthenticationServerBasedCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAws -Operation PatchIamUserBasedCloudAccount` | `New-RscMutation -Gql patchAwsIamUserBasedCloudAccount` | [patchAwsIamUserBasedCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAws -Operation PrepareCloudAccountDeletion` | `New-RscMutation -Gql prepareAwsCloudAccountDeletion` | [prepareAwsCloudAccountDeletion](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAws -Operation PrepareFeatureUpdateForCloudAccount` | `New-RscMutation -Gql prepareFeatureUpdateForAwsCloudAccount` | [prepareFeatureUpdateForAwsCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAws -Operation RegisterFeatureArtifacts` | `New-RscMutation -Gql registerAwsFeatureArtifacts` | [registerAwsFeatureArtifacts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAws -Operation StartExocomputeDisableJob` | `New-RscMutation -Gql startAwsExocomputeDisableJob` | [startAwsExocomputeDisableJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAws -Operation UpdateAccount` | `New-RscMutation -Gql updateAwsAccount` | [updateAwsAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAws -Operation UpdateAutomaticTargetMapping` | `New-RscMutation -Gql updateAutomaticAwsTargetMapping` | [updateAutomaticAwsTargetMapping](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAws -Operation UpdateCloudAccount` | `New-RscMutation -Gql updateAwsCloudAccount` | [updateAwsCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAws -Operation UpdateCloudAccountFeature` | `New-RscMutation -Gql updateAwsCloudAccountFeature` | [updateAwsCloudAccountFeature](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAws -Operation UpdateCloudNativeStorageSetting` | `New-RscMutation -Gql updateCloudNativeAwsStorageSetting` | [updateCloudNativeAwsStorageSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAws -Operation UpdateExocomputeConfigs` | `New-RscMutation -Gql updateAwsExocomputeConfigs` | [updateAwsExocomputeConfigs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAws -Operation UpdateIamPair` | `New-RscMutation -Gql updateAwsIamPair` | [updateAwsIamPair](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAws -Operation UpdateTarget` | `New-RscMutation -Gql updateAwsTarget` | [updateAwsTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAws -Operation UpgradeCloudAccountFeaturesWithoutCft` | `New-RscMutation -Gql upgradeAwsCloudAccountFeaturesWithoutCft` | [upgradeAwsCloudAccountFeaturesWithoutCft](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAws -Operation UpgradeIamUserBasedCloudAccountPermissions` | `New-RscMutation -Gql upgradeAwsIamUserBasedCloudAccountPermissions` | [upgradeAwsIamUserBasedCloudAccountPermissions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAws -Operation ValidateAndCreateCloudAccount` | `New-RscMutation -Gql validateAndCreateAwsCloudAccount` | [validateAndCreateAwsCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAws -Operation ValidateAndInitiateOutpostAccount` | `New-RscMutation -Gql validateAndInitiateAwsOutpostAccount` | [validateAndInitiateAwsOutpostAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## AWS Native domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryAwsNative -Operation Account` | `New-RscQuery -Gql awsNativeAccount` | [awsNativeAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAwsNative -Operation Accounts` | `New-RscQuery -Gql awsNativeAccounts` | [awsNativeAccounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAwsNative -Operation AmiTypeForArchivedSnapshotExport` | `New-RscQuery -Gql amiTypeForAwsNativeArchivedSnapshotExport` | [amiTypeForAwsNativeArchivedSnapshotExport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAwsNative -Operation DynamoDbTable` | `New-RscQuery -Gql awsNativeDynamoDbTable` | [awsNativeDynamoDbTable](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAwsNative -Operation DynamoDbTablePointInTimeRestoreWindow` | `New-RscQuery -Gql awsNativeDynamoDbTablePointInTimeRestoreWindow` | [awsNativeDynamoDbTablePointInTimeRestoreWindow](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAwsNative -Operation EbsVolume` | `New-RscQuery -Gql awsNativeEbsVolume` | [awsNativeEbsVolume](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAwsNative -Operation EbsVolumes` | `New-RscQuery -Gql awsNativeEbsVolumes` | [awsNativeEbsVolumes](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAwsNative -Operation EbsVolumesByName` | `New-RscQuery -Gql awsNativeEbsVolumesByName` | [awsNativeEbsVolumesByName](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAwsNative -Operation Ec2Instance` | `New-RscQuery -Gql awsNativeEc2Instance` | [awsNativeEc2Instance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAwsNative -Operation Ec2Instances` | `New-RscQuery -Gql awsNativeEc2Instances` | [awsNativeEc2Instances](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAwsNative -Operation Ec2InstancesByName` | `New-RscQuery -Gql awsNativeEc2InstancesByName` | [awsNativeEc2InstancesByName](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAwsNative -Operation IsEbsVolumeSnapshotRestorable` | `New-RscQuery -Gql isAwsNativeEbsVolumeSnapshotRestorable` | [isAwsNativeEbsVolumeSnapshotRestorable](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAwsNative -Operation IsRdsInstanceLaunchConfigurationValid` | `New-RscQuery -Gql isAwsNativeRdsInstanceLaunchConfigurationValid` | [isAwsNativeRdsInstanceLaunchConfigurationValid](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAwsNative -Operation RdsExportDefaults` | `New-RscQuery -Gql awsNativeRdsExportDefaults` | [awsNativeRdsExportDefaults](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAwsNative -Operation RdsInstance` | `New-RscQuery -Gql awsNativeRdsInstance` | [awsNativeRdsInstance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAwsNative -Operation RdsInstances` | `New-RscQuery -Gql awsNativeRdsInstances` | [awsNativeRdsInstances](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAwsNative -Operation RdsPointInTimeRestoreWindow` | `New-RscQuery -Gql awsNativeRdsPointInTimeRestoreWindow` | [awsNativeRdsPointInTimeRestoreWindow](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAwsNative -Operation Root` | `New-RscQuery -Gql awsNativeRoot` | [awsNativeRoot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAwsNative -Operation S3Bucket` | `New-RscQuery -Gql awsNativeS3Bucket` | [awsNativeS3Bucket](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAwsNative -Operation ValidateDynamoDbTableNameForRecovery` | `New-RscQuery -Gql validateAwsNativeDynamoDbTableNameForRecovery` | [validateAwsNativeDynamoDbTableNameForRecovery](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAwsNative -Operation ValidateRdsClusterNameForExport` | `New-RscQuery -Gql validateAwsNativeRdsClusterNameForExport` | [validateAwsNativeRdsClusterNameForExport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAwsNative -Operation ValidateRdsInstanceNameForExport` | `New-RscQuery -Gql validateAwsNativeRdsInstanceNameForExport` | [validateAwsNativeRdsInstanceNameForExport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationAwsNative -Operation ExcludeEbsVolumesFromSnapshot` | `New-RscMutation -Gql excludeAwsNativeEbsVolumesFromSnapshot` | [excludeAwsNativeEbsVolumesFromSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAwsNative -Operation StartAccountDisableJob` | `New-RscMutation -Gql startAwsNativeAccountDisableJob` | [startAwsNativeAccountDisableJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAwsNative -Operation StartCreateEbsVolumeSnapshotsJob` | `New-RscMutation -Gql startCreateAwsNativeEbsVolumeSnapshotsJob` | [startCreateAwsNativeEbsVolumeSnapshotsJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAwsNative -Operation StartEc2InstanceSnapshotsJob` | `New-RscMutation -Gql startAwsNativeEc2InstanceSnapshotsJob` | [startAwsNativeEc2InstanceSnapshotsJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAwsNative -Operation StartExportEbsVolumeSnapshotJob` | `New-RscMutation -Gql startExportAwsNativeEbsVolumeSnapshotJob` | [startExportAwsNativeEbsVolumeSnapshotJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAwsNative -Operation StartRdsInstanceSnapshotsJob` | `New-RscMutation -Gql startAwsNativeRdsInstanceSnapshotsJob` | [startAwsNativeRdsInstanceSnapshotsJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAwsNative -Operation StartRefreshAccountsJob` | `New-RscMutation -Gql startRefreshAwsNativeAccountsJob` | [startRefreshAwsNativeAccountsJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAwsNative -Operation StartRestoreEc2InstanceSnapshotJob` | `New-RscMutation -Gql startRestoreAwsNativeEc2InstanceSnapshotJob` | [startRestoreAwsNativeEc2InstanceSnapshotJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Azure domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryAzure -Operation AdDirectories` | `New-RscQuery -Gql azureAdDirectories` | [azureAdDirectories](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation AdDirectory` | `New-RscQuery -Gql azureAdDirectory` | [azureAdDirectory](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation AdObjectsByType` | `New-RscQuery -Gql azureAdObjectsByType` | [azureAdObjectsByType](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation ArmTemplatesByFeature` | `New-RscQuery -Gql allAzureArmTemplatesByFeature` | [allAzureArmTemplatesByFeature](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation AzureRegions` | `New-RscQuery -Gql allAzureRegions` | [allAzureRegions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation AzureStorageAccounts` | `New-RscQuery -Gql allAzureStorageAccounts` | [allAzureStorageAccounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation AzureVnets` | `New-RscQuery -Gql allAzureVnets` | [allAzureVnets](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation BlobContainersByStorageAccount` | `New-RscQuery -Gql allAzureBlobContainersByStorageAccount` | [allAzureBlobContainersByStorageAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation CdmVersions` | `New-RscQuery -Gql allAzureCdmVersions` | [allAzureCdmVersions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation CheckPersistentStorageSubscriptionCanUnmap` | `New-RscQuery -Gql checkAzurePersistentStorageSubscriptionCanUnmap` | [checkAzurePersistentStorageSubscriptionCanUnmap](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation CloudAccountDetailsForFeature` | `New-RscQuery -Gql azureCloudAccountDetailsForFeature` | [azureCloudAccountDetailsForFeature](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation CloudAccountMissingPermissions` | `New-RscQuery -Gql allAzureCloudAccountMissingPermissions` | [allAzureCloudAccountMissingPermissions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation CloudAccountPermissionConfig` | `New-RscQuery -Gql azureCloudAccountPermissionConfig` | [azureCloudAccountPermissionConfig](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation CloudAccountSubnetsByRegion` | `New-RscQuery -Gql allAzureCloudAccountSubnetsByRegion` | [allAzureCloudAccountSubnetsByRegion](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation CloudAccountSubscriptionWithFeatures` | `New-RscQuery -Gql azureCloudAccountSubscriptionWithFeatures` | [azureCloudAccountSubscriptionWithFeatures](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation CloudAccountSubscriptionsByFeature` | `New-RscQuery -Gql allAzureCloudAccountSubscriptionsByFeature` | [allAzureCloudAccountSubscriptionsByFeature](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation CloudAccountTenant` | `New-RscQuery -Gql azureCloudAccountTenant` | [azureCloudAccountTenant](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation CloudAccountTenantWithExoConfigs` | `New-RscQuery -Gql azureCloudAccountTenantWithExoConfigs` | [azureCloudAccountTenantWithExoConfigs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation CloudAccountTenants` | `New-RscQuery -Gql allAzureCloudAccountTenants` | [allAzureCloudAccountTenants](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation DiskEncryptionSetsByRegion` | `New-RscQuery -Gql allAzureDiskEncryptionSetsByRegion` | [allAzureDiskEncryptionSetsByRegion](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation EncryptionKeys` | `New-RscQuery -Gql allAzureEncryptionKeys` | [allAzureEncryptionKeys](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation ExocomputeConfigsInAccount` | `New-RscQuery -Gql allAzureExocomputeConfigsInAccount` | [allAzureExocomputeConfigsInAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation ExocomputeNetworkSetupTemplate` | `New-RscQuery -Gql azureExocomputeNetworkSetupTemplate` | [azureExocomputeNetworkSetupTemplate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation HasRelicAdSnapshot` | `New-RscQuery -Gql hasRelicAzureAdSnapshot` | [hasRelicAzureAdSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation HostedAzureRegions` | `New-RscQuery -Gql allHostedAzureRegions` | [allHostedAzureRegions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation IsStorageAccountNameAvailable` | `New-RscQuery -Gql isAzureStorageAccountNameAvailable` | [isAzureStorageAccountNameAvailable](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation KeyVaultsByRegion` | `New-RscQuery -Gql allAzureKeyVaultsByRegion` | [allAzureKeyVaultsByRegion](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation ListManagementGroupHierarchy` | `New-RscQuery -Gql azureListManagementGroupHierarchy` | [azureListManagementGroupHierarchy](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation ListManagementGroups` | `New-RscQuery -Gql azureListManagementGroups` | [azureListManagementGroups](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation ManagedIdentities` | `New-RscQuery -Gql allAzureManagedIdentities` | [allAzureManagedIdentities](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation MarketplaceTermsInfo` | `New-RscQuery -Gql azureMarketplaceTermsInfo` | [azureMarketplaceTermsInfo](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation Nsgs` | `New-RscQuery -Gql allAzureNsgs` | [allAzureNsgs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation RcvBliMigrationDetails` | `New-RscQuery -Gql rcvAzureBliMigrationDetails` | [rcvAzureBliMigrationDetails](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation Regions` | `New-RscQuery -Gql azureRegions` | [azureRegions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation RegionsWithAzDetails` | `New-RscQuery -Gql allAzureRegionsWithAzDetails` | [allAzureRegionsWithAzDetails](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation ResourceGroups` | `New-RscQuery -Gql azureResourceGroups` | [azureResourceGroups](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation ResourceGroupsFromAzure` | `New-RscQuery -Gql allResourceGroupsFromAzure` | [allResourceGroupsFromAzure](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation SearchAdSnapshot` | `New-RscQuery -Gql searchAzureAdSnapshot` | [searchAzureAdSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation SqlDatabase` | `New-RscQuery -Gql azureSqlDatabase` | [azureSqlDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation SqlDatabaseDbPointInTimeRestoreWindowFromAzure` | `New-RscQuery -Gql azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure` | [azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation SqlDatabaseServer` | `New-RscQuery -Gql azureSqlDatabaseServer` | [azureSqlDatabaseServer](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation SqlDatabaseServerElasticPools` | `New-RscQuery -Gql allAzureSqlDatabaseServerElasticPools` | [allAzureSqlDatabaseServerElasticPools](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation SqlDatabaseServers` | `New-RscQuery -Gql azureSqlDatabaseServers` | [azureSqlDatabaseServers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation SqlDatabases` | `New-RscQuery -Gql azureSqlDatabases` | [azureSqlDatabases](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation SqlManagedInstanceDatabase` | `New-RscQuery -Gql azureSqlManagedInstanceDatabase` | [azureSqlManagedInstanceDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation SqlManagedInstanceDatabases` | `New-RscQuery -Gql azureSqlManagedInstanceDatabases` | [azureSqlManagedInstanceDatabases](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure` | `New-RscQuery -Gql azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure` | [azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation SqlManagedInstanceServer` | `New-RscQuery -Gql azureSqlManagedInstanceServer` | [azureSqlManagedInstanceServer](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation SqlManagedInstanceServers` | `New-RscQuery -Gql azureSqlManagedInstanceServers` | [azureSqlManagedInstanceServers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation StorageAccountContainers` | `New-RscQuery -Gql azureStorageAccountContainers` | [azureStorageAccountContainers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation StorageAccountExcludedContainers` | `New-RscQuery -Gql azureStorageAccountExcludedContainers` | [azureStorageAccountExcludedContainers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation StorageAccounts` | `New-RscQuery -Gql azureStorageAccounts` | [azureStorageAccounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation StorageAccountsByRegion` | `New-RscQuery -Gql allAzureStorageAccountsByRegion` | [allAzureStorageAccountsByRegion](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation Subnets` | `New-RscQuery -Gql azureSubnets` | [azureSubnets](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation SubscriptionWithExocomputeMappings` | `New-RscQuery -Gql allAzureSubscriptionWithExocomputeMappings` | [allAzureSubscriptionWithExocomputeMappings](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation Subscriptions` | `New-RscQuery -Gql azureSubscriptions` | [azureSubscriptions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation SupportedAdRegions` | `New-RscQuery -Gql supportedAzureAdRegions` | [supportedAzureAdRegions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation VNets` | `New-RscQuery -Gql azureVNets` | [azureVNets](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation ValidateCloudAccountExocomputeConfigurations` | `New-RscQuery -Gql validateAzureCloudAccountExocomputeConfigurations` | [validateAzureCloudAccountExocomputeConfigurations](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzure -Operation ValidateCreateClusterInput` | `New-RscQuery -Gql validateCreateAzureClusterInput` | [validateCreateAzureClusterInput](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationAzure -Operation AddCloudAccount` | `New-RscMutation -Gql addAzureCloudAccount` | [addAzureCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation AddCloudAccountExocomputeConfigurations` | `New-RscMutation -Gql addAzureCloudAccountExocomputeConfigurations` | [addAzureCloudAccountExocomputeConfigurations](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation AddCloudAccountWithoutOauth` | `New-RscMutation -Gql addAzureCloudAccountWithoutOauth` | [addAzureCloudAccountWithoutOauth](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation BackupAdDirectory` | `New-RscMutation -Gql backupAzureAdDirectory` | [backupAzureAdDirectory](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation CloudAccountAddWithCustomerAppInitiate` | `New-RscMutation -Gql azureCloudAccountAddWithCustomerAppInitiate` | [azureCloudAccountAddWithCustomerAppInitiate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation CompleteAdAppSetup` | `New-RscMutation -Gql completeAzureAdAppSetup` | [completeAzureAdAppSetup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation CompleteAdAppUpdate` | `New-RscMutation -Gql completeAzureAdAppUpdate` | [completeAzureAdAppUpdate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation CompleteCloudAccountOauth` | `New-RscMutation -Gql completeAzureCloudAccountOauth` | [completeAzureCloudAccountOauth](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation CreateAccount` | `New-RscMutation -Gql createAzureAccount` | [createAzureAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation CreateAutomaticTargetMapping` | `New-RscMutation -Gql createAutomaticAzureTargetMapping` | [createAutomaticAzureTargetMapping](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation CreateCloudNativeRcvStorageSetting` | `New-RscMutation -Gql createCloudNativeRcvAzureStorageSetting` | [createCloudNativeRcvAzureStorageSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation CreateCloudNativeStorageSetting` | `New-RscMutation -Gql createCloudNativeAzureStorageSetting` | [createCloudNativeAzureStorageSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation CreateCluster` | `New-RscMutation -Gql createAzureCluster` | [createAzureCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation CreateReaderTarget` | `New-RscMutation -Gql createAzureReaderTarget` | [createAzureReaderTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation CreateSaasAppAad` | `New-RscMutation -Gql createAzureSaasAppAad` | [createAzureSaasAppAad](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation CreateTarget` | `New-RscMutation -Gql createAzureTarget` | [createAzureTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation DeleteAdDirectory` | `New-RscMutation -Gql deleteAzureAdDirectory` | [deleteAzureAdDirectory](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation DeleteCloudAccount` | `New-RscMutation -Gql deleteAzureCloudAccount` | [deleteAzureCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation DeleteCloudAccountExocomputeConfigurations` | `New-RscMutation -Gql deleteAzureCloudAccountExocomputeConfigurations` | [deleteAzureCloudAccountExocomputeConfigurations](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation DeleteCloudAccountWithoutOauth` | `New-RscMutation -Gql deleteAzureCloudAccountWithoutOauth` | [deleteAzureCloudAccountWithoutOauth](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation ExcludeStorageAccountContainers` | `New-RscMutation -Gql excludeAzureStorageAccountContainers` | [excludeAzureStorageAccountContainers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation GetOrCreateByokApp` | `New-RscMutation -Gql getOrCreateByokAzureApp` | [getOrCreateByokAzureApp](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation MapCloudAccountExocomputeSubscription` | `New-RscMutation -Gql mapAzureCloudAccountExocomputeSubscription` | [mapAzureCloudAccountExocomputeSubscription](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation MapCloudAccountToPersistentStorageLocation` | `New-RscMutation -Gql mapAzureCloudAccountToPersistentStorageLocation` | [mapAzureCloudAccountToPersistentStorageLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation OauthConsentComplete` | `New-RscMutation -Gql azureOauthConsentComplete` | [azureOauthConsentComplete](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation OauthConsentKickoff` | `New-RscMutation -Gql azureOauthConsentKickoff` | [azureOauthConsentKickoff](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation RestoreAdObjectsWithPasswords` | `New-RscMutation -Gql restoreAzureAdObjectsWithPasswords` | [restoreAzureAdObjectsWithPasswords](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation SetCloudAccountCustomerAppCredentials` | `New-RscMutation -Gql setAzureCloudAccountCustomerAppCredentials` | [setAzureCloudAccountCustomerAppCredentials](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation StartAdAppSetup` | `New-RscMutation -Gql startAzureAdAppSetup` | [startAzureAdAppSetup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation StartAdAppUpdate` | `New-RscMutation -Gql startAzureAdAppUpdate` | [startAzureAdAppUpdate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation StartCloudAccountOauth` | `New-RscMutation -Gql startAzureCloudAccountOauth` | [startAzureCloudAccountOauth](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation StartDisableCloudAccountJob` | `New-RscMutation -Gql startDisableAzureCloudAccountJob` | [startDisableAzureCloudAccountJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation StartExportSqlDatabaseDbJob` | `New-RscMutation -Gql startExportAzureSqlDatabaseDbJob` | [startExportAzureSqlDatabaseDbJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation StartExportSqlManagedInstanceDbJob` | `New-RscMutation -Gql startExportAzureSqlManagedInstanceDbJob` | [startExportAzureSqlManagedInstanceDbJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation UnmapCloudAccountExocomputeSubscription` | `New-RscMutation -Gql unmapAzureCloudAccountExocomputeSubscription` | [unmapAzureCloudAccountExocomputeSubscription](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation UnmapPersistentStorageSubscription` | `New-RscMutation -Gql unmapAzurePersistentStorageSubscription` | [unmapAzurePersistentStorageSubscription](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation UpdateAccount` | `New-RscMutation -Gql updateAzureAccount` | [updateAzureAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation UpdateAutomaticTargetMapping` | `New-RscMutation -Gql updateAutomaticAzureTargetMapping` | [updateAutomaticAzureTargetMapping](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation UpdateCloudAccount` | `New-RscMutation -Gql updateAzureCloudAccount` | [updateAzureCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation UpdateCloudNativeRcvStorageSetting` | `New-RscMutation -Gql updateCloudNativeRcvAzureStorageSetting` | [updateCloudNativeRcvAzureStorageSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation UpdateCloudNativeStorageSetting` | `New-RscMutation -Gql updateCloudNativeAzureStorageSetting` | [updateCloudNativeAzureStorageSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation UpdateCustomerAppPermissionForSql` | `New-RscMutation -Gql updateCustomerAppPermissionForAzureSql` | [updateCustomerAppPermissionForAzureSql](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation UpdateTarget` | `New-RscMutation -Gql updateAzureTarget` | [updateAzureTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation UpdateTenantForSubscription` | `New-RscMutation -Gql azureUpdateTenantForSubscription` | [azureUpdateTenantForSubscription](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation UpgradeCloudAccount` | `New-RscMutation -Gql upgradeAzureCloudAccount` | [upgradeAzureCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzure -Operation UpgradeCloudAccountPermissionsWithoutOauth` | `New-RscMutation -Gql upgradeAzureCloudAccountPermissionsWithoutOauth` | [upgradeAzureCloudAccountPermissionsWithoutOauth](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Azure Native domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryAzureNative -Operation AvailabilitySetsByRegionFromAzure` | `New-RscQuery -Gql allAzureNativeAvailabilitySetsByRegionFromAzure` | [allAzureNativeAvailabilitySetsByRegionFromAzure](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzureNative -Operation DoesResourceGroupExist` | `New-RscQuery -Gql doesAzureNativeResourceGroupExist` | [doesAzureNativeResourceGroupExist](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzureNative -Operation ExportCompatibleDiskTypesByRegionFromAzure` | `New-RscQuery -Gql allAzureNativeExportCompatibleDiskTypesByRegionFromAzure` | [allAzureNativeExportCompatibleDiskTypesByRegionFromAzure](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzureNative -Operation ExportCompatibleVmSizesByRegionFromAzure` | `New-RscQuery -Gql allAzureNativeExportCompatibleVmSizesByRegionFromAzure` | [allAzureNativeExportCompatibleVmSizesByRegionFromAzure](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzureNative -Operation IsManagedDiskSnapshotRestorable` | `New-RscQuery -Gql isAzureNativeManagedDiskSnapshotRestorable` | [isAzureNativeManagedDiskSnapshotRestorable](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzureNative -Operation IsSqlDatabaseSnapshotPersistent` | `New-RscQuery -Gql isAzureNativeSqlDatabaseSnapshotPersistent` | [isAzureNativeSqlDatabaseSnapshotPersistent](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzureNative -Operation KeyVaultsByRegionFromAzure` | `New-RscQuery -Gql allAzureNativeKeyVaultsByRegionFromAzure` | [allAzureNativeKeyVaultsByRegionFromAzure](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzureNative -Operation ManagedDisk` | `New-RscQuery -Gql azureNativeManagedDisk` | [azureNativeManagedDisk](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzureNative -Operation ManagedDisks` | `New-RscQuery -Gql azureNativeManagedDisks` | [azureNativeManagedDisks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzureNative -Operation Regions` | `New-RscQuery -Gql azureNativeRegions` | [azureNativeRegions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzureNative -Operation ResourceGroup` | `New-RscQuery -Gql azureNativeResourceGroup` | [azureNativeResourceGroup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzureNative -Operation ResourceGroupForSql` | `New-RscQuery -Gql azureNativeResourceGroupForSql` | [azureNativeResourceGroupForSql](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzureNative -Operation ResourceGroups` | `New-RscQuery -Gql azureNativeResourceGroups` | [azureNativeResourceGroups](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzureNative -Operation ResourceGroupsInfoIfExist` | `New-RscQuery -Gql allAzureNativeResourceGroupsInfoIfExist` | [allAzureNativeResourceGroupsInfoIfExist](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzureNative -Operation Root` | `New-RscQuery -Gql azureNativeRoot` | [azureNativeRoot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzureNative -Operation SecurityGroupsByRegionFromAzure` | `New-RscQuery -Gql allAzureNativeSecurityGroupsByRegionFromAzure` | [allAzureNativeSecurityGroupsByRegionFromAzure](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzureNative -Operation StorageAccountsFromAzure` | `New-RscQuery -Gql allAzureNativeStorageAccountsFromAzure` | [allAzureNativeStorageAccountsFromAzure](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzureNative -Operation SubnetsByRegionFromAzure` | `New-RscQuery -Gql allAzureNativeSubnetsByRegionFromAzure` | [allAzureNativeSubnetsByRegionFromAzure](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzureNative -Operation Subscription` | `New-RscQuery -Gql azureNativeSubscription` | [azureNativeSubscription](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzureNative -Operation Subscriptions` | `New-RscQuery -Gql azureNativeSubscriptions` | [azureNativeSubscriptions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzureNative -Operation ValidateSqlDatabaseDbNameForExport` | `New-RscQuery -Gql validateAzureNativeSqlDatabaseDbNameForExport` | [validateAzureNativeSqlDatabaseDbNameForExport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzureNative -Operation ValidateSqlManagedInstanceDbNameForExport` | `New-RscQuery -Gql validateAzureNativeSqlManagedInstanceDbNameForExport` | [validateAzureNativeSqlManagedInstanceDbNameForExport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzureNative -Operation VirtualMachine` | `New-RscQuery -Gql azureNativeVirtualMachine` | [azureNativeVirtualMachine](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzureNative -Operation VirtualMachineSizes` | `New-RscQuery -Gql allAzureNativeVirtualMachineSizes` | [allAzureNativeVirtualMachineSizes](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzureNative -Operation VirtualMachines` | `New-RscQuery -Gql azureNativeVirtualMachines` | [azureNativeVirtualMachines](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzureNative -Operation VirtualNetworks` | `New-RscQuery -Gql allAzureNativeVirtualNetworks` | [allAzureNativeVirtualNetworks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationAzureNative -Operation ExcludeManagedDisksFromSnapshot` | `New-RscMutation -Gql excludeAzureNativeManagedDisksFromSnapshot` | [excludeAzureNativeManagedDisksFromSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzureNative -Operation StartCreateManagedDiskSnapshotsJob` | `New-RscMutation -Gql startCreateAzureNativeManagedDiskSnapshotsJob` | [startCreateAzureNativeManagedDiskSnapshotsJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzureNative -Operation StartCreateVirtualMachineSnapshotsJob` | `New-RscMutation -Gql startCreateAzureNativeVirtualMachineSnapshotsJob` | [startCreateAzureNativeVirtualMachineSnapshotsJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzureNative -Operation StartDisableSubscriptionProtectionJob` | `New-RscMutation -Gql startDisableAzureNativeSubscriptionProtectionJob` | [startDisableAzureNativeSubscriptionProtectionJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzureNative -Operation StartExportManagedDiskJob` | `New-RscMutation -Gql startExportAzureNativeManagedDiskJob` | [startExportAzureNativeManagedDiskJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzureNative -Operation StartExportVirtualMachineJob` | `New-RscMutation -Gql startExportAzureNativeVirtualMachineJob` | [startExportAzureNativeVirtualMachineJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzureNative -Operation StartRecoverStorageAccountJob` | `New-RscMutation -Gql startRecoverAzureNativeStorageAccountJob` | [startRecoverAzureNativeStorageAccountJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzureNative -Operation StartRefreshSubscriptionsJob` | `New-RscMutation -Gql startRefreshAzureNativeSubscriptionsJob` | [startRefreshAzureNativeSubscriptionsJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationAzureNative -Operation StartRestoreVirtualMachineJob` | `New-RscMutation -Gql startRestoreAzureNativeVirtualMachineJob` | [startRestoreAzureNativeVirtualMachineJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Azure Office365 domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryAzureO365 -Operation CheckNSGOutboundRules` | `New-RscQuery -Gql azureO365CheckNSGOutboundRules` | [azureO365CheckNSGOutboundRules](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzureO365 -Operation CheckNetworkSubnet` | `New-RscQuery -Gql azureO365CheckNetworkSubnet` | [azureO365CheckNetworkSubnet](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzureO365 -Operation CheckResourceGroupName` | `New-RscQuery -Gql azureO365CheckResourceGroupName` | [azureO365CheckResourceGroupName](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzureO365 -Operation CheckStorageAccountAccessibility` | `New-RscQuery -Gql azureO365CheckStorageAccountAccessibility` | [azureO365CheckStorageAccountAccessibility](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzureO365 -Operation CheckStorageAccountName` | `New-RscQuery -Gql azureO365CheckStorageAccountName` | [azureO365CheckStorageAccountName](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzureO365 -Operation CheckSubscriptionQuota` | `New-RscQuery -Gql azureO365CheckSubscriptionQuota` | [azureO365CheckSubscriptionQuota](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzureO365 -Operation CheckVirtualNetworkName` | `New-RscQuery -Gql azureO365CheckVirtualNetworkName` | [azureO365CheckVirtualNetworkName](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzureO365 -Operation Exocompute` | `New-RscQuery -Gql azureO365Exocompute` | [azureO365Exocompute](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzureO365 -Operation GetAzureHostType` | `New-RscQuery -Gql azureO365GetAzureHostType` | [azureO365GetAzureHostType](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzureO365 -Operation GetNetworkSubnetUnusedAddr` | `New-RscQuery -Gql azureO365GetNetworkSubnetUnusedAddr` | [azureO365GetNetworkSubnetUnusedAddr](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryAzureO365 -Operation ValidateUserRoles` | `New-RscQuery -Gql azureO365ValidateUserRoles` | [azureO365ValidateUserRoles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationAzureO365 -Operation SetupExocompute` | `New-RscMutation -Gql setupAzureO365Exocompute` | [setupAzureO365Exocompute](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Cassandra domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryCassandra -Operation ColumnFamilies` | `New-RscQuery -Gql cassandraColumnFamilies` | [cassandraColumnFamilies](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCassandra -Operation ColumnFamily` | `New-RscQuery -Gql cassandraColumnFamily` | [cassandraColumnFamily](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCassandra -Operation ColumnFamilyRecoverableRange` | `New-RscQuery -Gql cassandraColumnFamilyRecoverableRange` | [cassandraColumnFamilyRecoverableRange](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCassandra -Operation ColumnFamilySchema` | `New-RscQuery -Gql cassandraColumnFamilySchema` | [cassandraColumnFamilySchema](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCassandra -Operation Keyspace` | `New-RscQuery -Gql cassandraKeyspace` | [cassandraKeyspace](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCassandra -Operation Keyspaces` | `New-RscQuery -Gql cassandraKeyspaces` | [cassandraKeyspaces](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCassandra -Operation Source` | `New-RscQuery -Gql cassandraSource` | [cassandraSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCassandra -Operation Sources` | `New-RscQuery -Gql cassandraSources` | [cassandraSources](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationCassandra -Operation BulkDeleteSources` | `New-RscMutation -Gql bulkDeleteCassandraSources` | [bulkDeleteCassandraSources](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCassandra -Operation CreateSource` | `New-RscMutation -Gql createCassandraSource` | [createCassandraSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCassandra -Operation DeleteSource` | `New-RscMutation -Gql deleteCassandraSource` | [deleteCassandraSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCassandra -Operation RecoverSource` | `New-RscMutation -Gql recoverCassandraSource` | [recoverCassandraSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCassandra -Operation UpdateSource` | `New-RscMutation -Gql updateCassandraSource` | [updateCassandraSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Certificates domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryCertificate -Operation AssignableGlobalCertificates` | `New-RscQuery -Gql assignableGlobalCertificates` | [assignableGlobalCertificates](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCertificate -Operation Certificates` | `New-RscQuery -Gql certificates` | [certificates](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCertificate -Operation CertificatesWithKey` | `New-RscQuery -Gql certificatesWithKey` | [certificatesWithKey](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCertificate -Operation ClusterCertificates` | `New-RscQuery -Gql clusterCertificates` | [clusterCertificates](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCertificate -Operation ClusterCsr` | `New-RscQuery -Gql clusterCsr` | [clusterCsr](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCertificate -Operation ClusterWebSigned` | `New-RscQuery -Gql clusterWebSignedCertificate` | [clusterWebSignedCertificate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCertificate -Operation GlobalCertificate` | `New-RscQuery -Gql globalCertificate` | [globalCertificate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCertificate -Operation GlobalCertificates` | `New-RscQuery -Gql globalCertificates` | [globalCertificates](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCertificate -Operation Info` | `New-RscQuery -Gql certificateInfo` | [certificateInfo](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCertificate -Operation SigningRequest` | `New-RscQuery -Gql certificateSigningRequest` | [certificateSigningRequest](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCertificate -Operation SigningRequests` | `New-RscQuery -Gql certificateSigningRequests` | [certificateSigningRequests](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationCertificate -Operation AddClusterCertificate` | `New-RscMutation -Gql addClusterCertificate` | [addClusterCertificate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCertificate -Operation AddGlobalCertificate` | `New-RscMutation -Gql addGlobalCertificate` | [addGlobalCertificate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCertificate -Operation Delete` | `New-RscMutation -Gql deleteCertificate` | [deleteCertificate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCertificate -Operation DeleteCsr` | `New-RscMutation -Gql deleteCsr` | [deleteCsr](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCertificate -Operation DeleteGlobalCertificate` | `New-RscMutation -Gql deleteGlobalCertificate` | [deleteGlobalCertificate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCertificate -Operation GenerateCsr` | `New-RscMutation -Gql generateCsr` | [generateCsr](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCertificate -Operation MarkAgentSecondary` | `New-RscMutation -Gql markAgentSecondaryCertificate` | [markAgentSecondaryCertificate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCertificate -Operation SetSso` | `New-RscMutation -Gql setSsoCertificate` | [setSsoCertificate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCertificate -Operation SetWebSigned` | `New-RscMutation -Gql setWebSignedCertificate` | [setWebSignedCertificate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCertificate -Operation Update` | `New-RscMutation -Gql updateCertificate` | [updateCertificate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCertificate -Operation UpdateGlobalCertificate` | `New-RscMutation -Gql updateGlobalCertificate` | [updateGlobalCertificate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCertificate -Operation UpdateHost` | `New-RscMutation -Gql updateCertificateHost` | [updateCertificateHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Cloud Account domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryCloudAccount -Operation CloudAccount` | `New-RscQuery -Gql cloudAccount` | [cloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCloudAccount -Operation CloudAccounts` | `New-RscQuery -Gql allCloudAccounts` | [allCloudAccounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCloudAccount -Operation CurrentFeaturePermissions` | `New-RscQuery -Gql allCurrentFeaturePermissionsForCloudAccounts` | [allCurrentFeaturePermissionsForCloudAccounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCloudAccount -Operation ExocomputeMappings` | `New-RscQuery -Gql allCloudAccountExocomputeMappings` | [allCloudAccountExocomputeMappings](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCloudAccount -Operation IamPairsByAndLocation` | `New-RscQuery -Gql allIamPairsByCloudAccountAndLocation` | [allIamPairsByCloudAccountAndLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCloudAccount -Operation LatestFeaturePermissions` | `New-RscQuery -Gql allLatestFeaturePermissionsForCloudAccounts` | [allLatestFeaturePermissionsForCloudAccounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCloudAccount -Operation ListCertificateUsages` | `New-RscQuery -Gql listCertificateUsagesForCloudAccount` | [listCertificateUsagesForCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCloudAccount -Operation WithExocomputeMappings` | `New-RscQuery -Gql allAccountsWithExocomputeMappings` | [allAccountsWithExocomputeMappings](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationCloudAccount -Operation AssignToCluster` | `New-RscMutation -Gql assignCloudAccountToCluster` | [assignCloudAccountToCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCloudAccount -Operation MapExocomputeAccount` | `New-RscMutation -Gql mapCloudAccountExocomputeAccount` | [mapCloudAccountExocomputeAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCloudAccount -Operation UnmapExocomputeAccount` | `New-RscMutation -Gql unmapCloudAccountExocomputeAccount` | [unmapCloudAccountExocomputeAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCloudAccount -Operation UpdateCertificateUsages` | `New-RscMutation -Gql updateCertificateUsagesForCloudAccount` | [updateCertificateUsagesForCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Cloud Native domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryCloudNative -Operation CheckArchivedSnapshotsLocked` | `New-RscQuery -Gql cloudNativeCheckArchivedSnapshotsLocked` | [cloudNativeCheckArchivedSnapshotsLocked](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCloudNative -Operation CheckLabelRuleNameUniqueness` | `New-RscQuery -Gql checkCloudNativeLabelRuleNameUniqueness` | [checkCloudNativeLabelRuleNameUniqueness](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCloudNative -Operation CheckRequiredPermissionsForFeature` | `New-RscQuery -Gql cloudNativeCheckRequiredPermissionsForFeature` | [cloudNativeCheckRequiredPermissionsForFeature](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCloudNative -Operation CheckTagRuleNameUniqueness` | `New-RscQuery -Gql checkCloudNativeTagRuleNameUniqueness` | [checkCloudNativeTagRuleNameUniqueness](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCloudNative -Operation CustomerTags` | `New-RscQuery -Gql cloudNativeCustomerTags` | [cloudNativeCustomerTags](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCloudNative -Operation FileRecoveryEligibleSnapshots` | `New-RscQuery -Gql allCloudNativeFileRecoveryEligibleSnapshots` | [allCloudNativeFileRecoveryEligibleSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCloudNative -Operation GatewayKmsKeys` | `New-RscQuery -Gql cloudNativeGatewayKmsKeys` | [cloudNativeGatewayKmsKeys](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCloudNative -Operation IsFileRecoveryFeasible` | `New-RscQuery -Gql isCloudNativeFileRecoveryFeasible` | [isCloudNativeFileRecoveryFeasible](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCloudNative -Operation LabelKeys` | `New-RscQuery -Gql allCloudNativeLabelKeys` | [allCloudNativeLabelKeys](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCloudNative -Operation LabelRules` | `New-RscQuery -Gql cloudNativeLabelRules` | [cloudNativeLabelRules](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCloudNative -Operation LabelValues` | `New-RscQuery -Gql allCloudNativeLabelValues` | [allCloudNativeLabelValues](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCloudNative -Operation ObjectStoreSnapshotRegexSearch` | `New-RscQuery -Gql cloudNativeObjectStoreSnapshotRegexSearch` | [cloudNativeObjectStoreSnapshotRegexSearch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCloudNative -Operation RbaInstallers` | `New-RscQuery -Gql cloudNativeRbaInstallers` | [cloudNativeRbaInstallers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCloudNative -Operation SnapshotDetailsForRecovery` | `New-RscQuery -Gql cloudNativeSnapshotDetailsForRecovery` | [cloudNativeSnapshotDetailsForRecovery](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCloudNative -Operation SnapshotTypeDetails` | `New-RscQuery -Gql cloudNativeSnapshotTypeDetails` | [cloudNativeSnapshotTypeDetails](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCloudNative -Operation Snapshots` | `New-RscQuery -Gql cloudNativeSnapshots` | [cloudNativeSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCloudNative -Operation SqlServerSetupScript` | `New-RscQuery -Gql cloudNativeSqlServerSetupScript` | [cloudNativeSqlServerSetupScript](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCloudNative -Operation TagKeys` | `New-RscQuery -Gql allCloudNativeTagKeys` | [allCloudNativeTagKeys](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCloudNative -Operation TagRules` | `New-RscQuery -Gql cloudNativeTagRules` | [cloudNativeTagRules](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCloudNative -Operation TagRulesObjectType` | `New-RscQuery -Gql cloudNativeTagRulesObjectType` | [cloudNativeTagRulesObjectType](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCloudNative -Operation TagValues` | `New-RscQuery -Gql allCloudNativeTagValues` | [allCloudNativeTagValues](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCloudNative -Operation WorkloadVersionedFiles` | `New-RscQuery -Gql cloudNativeWorkloadVersionedFiles` | [cloudNativeWorkloadVersionedFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationCloudNative -Operation AddSqlServerBackupCredentials` | `New-RscMutation -Gql addCloudNativeSqlServerBackupCredentials` | [addCloudNativeSqlServerBackupCredentials](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCloudNative -Operation CheckRbaConnectivity` | `New-RscMutation -Gql cloudNativeCheckRbaConnectivity` | [cloudNativeCheckRbaConnectivity](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCloudNative -Operation ClearSqlServerBackupCredentials` | `New-RscMutation -Gql clearCloudNativeSqlServerBackupCredentials` | [clearCloudNativeSqlServerBackupCredentials](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCloudNative -Operation CreateLabelRule` | `New-RscMutation -Gql createCloudNativeLabelRule` | [createCloudNativeLabelRule](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCloudNative -Operation CreateTagRule` | `New-RscMutation -Gql createCloudNativeTagRule` | [createCloudNativeTagRule](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCloudNative -Operation DeleteLabelRule` | `New-RscMutation -Gql deleteCloudNativeLabelRule` | [deleteCloudNativeLabelRule](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCloudNative -Operation DeleteTagRule` | `New-RscMutation -Gql deleteCloudNativeTagRule` | [deleteCloudNativeTagRule](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCloudNative -Operation DownloadFiles` | `New-RscMutation -Gql cloudNativeDownloadFiles` | [cloudNativeDownloadFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCloudNative -Operation SetGatewayKmsKeys` | `New-RscMutation -Gql setCloudNativeGatewayKmsKeys` | [setCloudNativeGatewayKmsKeys](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCloudNative -Operation SetupSqlServerBackup` | `New-RscMutation -Gql setupCloudNativeSqlServerBackup` | [setupCloudNativeSqlServerBackup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCloudNative -Operation StartSnapshotsIndexJob` | `New-RscMutation -Gql startCloudNativeSnapshotsIndexJob` | [startCloudNativeSnapshotsIndexJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCloudNative -Operation UpdateIndexingStatus` | `New-RscMutation -Gql updateCloudNativeIndexingStatus` | [updateCloudNativeIndexingStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCloudNative -Operation UpdateLabelRule` | `New-RscMutation -Gql updateCloudNativeLabelRule` | [updateCloudNativeLabelRule](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCloudNative -Operation UpdateRootThreatMonitoringEnablement` | `New-RscMutation -Gql updateCloudNativeRootThreatMonitoringEnablement` | [updateCloudNativeRootThreatMonitoringEnablement](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCloudNative -Operation UpdateTagRule` | `New-RscMutation -Gql updateCloudNativeTagRule` | [updateCloudNativeTagRule](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Cluster domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryCluster -Operation CanIgnoreClusterRemovalPrechecks` | `New-RscQuery -Gql canIgnoreClusterRemovalPrechecks` | [canIgnoreClusterRemovalPrechecks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation CheckClusterRuSupport` | `New-RscQuery -Gql checkClusterRuSupport` | [checkClusterRuSupport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation CloudClusterInstanceProperties` | `New-RscQuery -Gql cloudClusterInstanceProperties` | [cloudClusterInstanceProperties](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation CloudClusterNodesInstanceProperties` | `New-RscQuery -Gql cloudClusterNodesInstanceProperties` | [cloudClusterNodesInstanceProperties](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation CloudClusterRecoveryValidation` | `New-RscQuery -Gql cloudClusterRecoveryValidation` | [cloudClusterRecoveryValidation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation CloudDirectClusterEndpoints` | `New-RscQuery -Gql cloudDirectClusterEndpoints` | [cloudDirectClusterEndpoints](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation CloudDirectClusterLambdaConfig` | `New-RscQuery -Gql cloudDirectClusterLambdaConfig` | [cloudDirectClusterLambdaConfig](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation Cluster` | `New-RscQuery -Gql cluster` | [cluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation ClusterList` | `New-RscQuery -Gql allClusterConnection` | [allClusterConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation ComputeClusterStatus` | `New-RscQuery -Gql computeClusterStatus` | [computeClusterStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation Connected` | `New-RscQuery -Gql allConnectedClusters` | [allConnectedClusters](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation Count` | `New-RscQuery -Gql countClusters` | [countClusters](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation DefaultGateway` | `New-RscQuery -Gql clusterDefaultGateway` | [clusterDefaultGateway](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation Dns` | `New-RscQuery -Gql clusterDns` | [clusterDns](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation EncryptionInfo` | `New-RscQuery -Gql clusterEncryptionInfo` | [clusterEncryptionInfo](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation ExocomputeGetClusterConnectionInfo` | `New-RscQuery -Gql exocomputeGetClusterConnectionInfo` | [exocomputeGetClusterConnectionInfo](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation FloatingIps` | `New-RscQuery -Gql clusterFloatingIps` | [clusterFloatingIps](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation GetCdmReleaseDetailsForClusterFromSupportPortal` | `New-RscQuery -Gql getCdmReleaseDetailsForClusterFromSupportPortal` | [getCdmReleaseDetailsForClusterFromSupportPortal](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation GetGroupCountByCdmClusterStatus` | `New-RscQuery -Gql getGroupCountByCdmClusterStatus` | [getGroupCountByCdmClusterStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation GroupByList` | `New-RscQuery -Gql clusterGroupByConnection` | [clusterGroupByConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation Ipmi` | `New-RscQuery -Gql clusterIpmi` | [clusterIpmi](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation Ipv6Mode` | `New-RscQuery -Gql clusterIpv6Mode` | [clusterIpv6Mode](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation IsCloudClusterDiskUpgradeAvailable` | `New-RscQuery -Gql isCloudClusterDiskUpgradeAvailable` | [isCloudClusterDiskUpgradeAvailable](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation IsRemoveClusterTprConfigured` | `New-RscQuery -Gql isRemoveClusterTprConfigured` | [isRemoveClusterTprConfigured](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation IsTotpAckNecessary` | `New-RscQuery -Gql isTotpAckNecessaryForCluster` | [isTotpAckNecessaryForCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation LicensesForClusterProductSummary` | `New-RscQuery -Gql licensesForClusterProductSummary` | [licensesForClusterProductSummary](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation List` | `New-RscQuery -Gql clusterConnection` | [clusterConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation Missing` | `New-RscQuery -Gql allMissingClusters` | [allMissingClusters](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation NetworkInterfaces` | `New-RscQuery -Gql clusterNetworkInterfaces` | [clusterNetworkInterfaces](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation Nodes` | `New-RscQuery -Gql clusterNodes` | [clusterNodes](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation NtpServers` | `New-RscQuery -Gql clusterNtpServers` | [clusterNtpServers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation OperationJobProgress` | `New-RscQuery -Gql clusterOperationJobProgress` | [clusterOperationJobProgress](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation Proxy` | `New-RscQuery -Gql clusterProxy` | [clusterProxy](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation RadarClusterList` | `New-RscQuery -Gql radarClusterConnection` | [radarClusterConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation Refs` | `New-RscQuery -Gql clusterRefs` | [clusterRefs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation RegistrationProductInfo` | `New-RscQuery -Gql clusterRegistrationProductInfo` | [clusterRegistrationProductInfo](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation ReplicationTargets` | `New-RscQuery -Gql allClusterReplicationTargets` | [allClusterReplicationTargets](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation Routes` | `New-RscQuery -Gql clusterRoutes` | [clusterRoutes](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation TotpAckStatus` | `New-RscQuery -Gql allClustersTotpAckStatus` | [allClustersTotpAckStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation TypeList` | `New-RscQuery -Gql clusterTypeList` | [clusterTypeList](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation ValidateClusterLicenseCapacity` | `New-RscQuery -Gql validateClusterLicenseCapacity` | [validateClusterLicenseCapacity](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation Vlans` | `New-RscQuery -Gql clusterVlans` | [clusterVlans](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation WebCertsAndIpmis` | `New-RscQuery -Gql allClusterWebCertsAndIpmis` | [allClusterWebCertsAndIpmis](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation Windows` | `New-RscQuery -Gql windowsCluster` | [windowsCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryCluster -Operation WithUpgradesInfo` | `New-RscQuery -Gql clusterWithUpgradesInfo` | [clusterWithUpgradesInfo](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationCluster -Operation AcknowledgeClusterNotification` | `New-RscMutation -Gql acknowledgeClusterNotification` | [acknowledgeClusterNotification](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCluster -Operation AddClusterNodes` | `New-RscMutation -Gql addClusterNodes` | [addClusterNodes](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCluster -Operation AddClusterRoute` | `New-RscMutation -Gql addClusterRoute` | [addClusterRoute](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCluster -Operation AddNodesToCloud` | `New-RscMutation -Gql addNodesToCloudCluster` | [addNodesToCloudCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCluster -Operation DeleteClusterRoute` | `New-RscMutation -Gql deleteClusterRoute` | [deleteClusterRoute](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCluster -Operation DeleteTerminatedClusterOperationJobData` | `New-RscMutation -Gql deleteTerminatedClusterOperationJobData` | [deleteTerminatedClusterOperationJobData](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCluster -Operation DisconnectExocompute` | `New-RscMutation -Gql disconnectExocomputeCluster` | [disconnectExocomputeCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCluster -Operation ExocomputeClusterConnect` | `New-RscMutation -Gql exocomputeClusterConnect` | [exocomputeClusterConnect](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCluster -Operation GenerateClusterRegistrationToken` | `New-RscMutation -Gql generateClusterRegistrationToken` | [generateClusterRegistrationToken](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCluster -Operation MigrateCloudClusterDisks` | `New-RscMutation -Gql migrateCloudClusterDisks` | [migrateCloudClusterDisks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCluster -Operation RecoverCloud` | `New-RscMutation -Gql recoverCloudCluster` | [recoverCloudCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCluster -Operation RegisterCloud` | `New-RscMutation -Gql registerCloudCluster` | [registerCloudCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCluster -Operation ReleasePersistentExo` | `New-RscMutation -Gql releasePersistentExoclusters` | [releasePersistentExoclusters](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCluster -Operation RemoveCdm` | `New-RscMutation -Gql removeCdmCluster` | [removeCdmCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCluster -Operation RemoveClusterNodes` | `New-RscMutation -Gql removeClusterNodes` | [removeClusterNodes](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCluster -Operation ReplaceClusterNode` | `New-RscMutation -Gql replaceClusterNode` | [replaceClusterNode](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCluster -Operation RequestPersistentExo` | `New-RscMutation -Gql requestPersistentExocluster` | [requestPersistentExocluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCluster -Operation SetMissingClusterStatus` | `New-RscMutation -Gql setMissingClusterStatus` | [setMissingClusterStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCluster -Operation UpdateClusterDefaultAddress` | `New-RscMutation -Gql updateClusterDefaultAddress` | [updateClusterDefaultAddress](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCluster -Operation UpdateClusterNtpServers` | `New-RscMutation -Gql updateClusterNtpServers` | [updateClusterNtpServers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCluster -Operation UpdateClusterPauseStatus` | `New-RscMutation -Gql updateClusterPauseStatus` | [updateClusterPauseStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCluster -Operation UpdateClusterSettings` | `New-RscMutation -Gql updateClusterSettings` | [updateClusterSettings](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCluster -Operation UpdatePreviewerClusterConfig` | `New-RscMutation -Gql updatePreviewerClusterConfig` | [updatePreviewerClusterConfig](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Cross Account domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryCrossAccount -Operation CrossAccountClusters` | `New-RscQuery -Gql allCrossAccountClusters` | [allCrossAccountClusters](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationCrossAccount -Operation AddCrossAccountServiceConsumer` | `New-RscMutation -Gql addCrossAccountServiceConsumer` | [addCrossAccountServiceConsumer](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCrossAccount -Operation CreateCrossAccountPair` | `New-RscMutation -Gql createCrossAccountPair` | [createCrossAccountPair](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCrossAccount -Operation CreateCrossAccountRegOauthPayload` | `New-RscMutation -Gql createCrossAccountRegOauthPayload` | [createCrossAccountRegOauthPayload](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationCrossAccount -Operation DeleteCrossAccountPair` | `New-RscMutation -Gql deleteCrossAccountPair` | [deleteCrossAccountPair](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Db2 domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryDb2 -Operation Database` | `New-RscQuery -Gql db2Database` | [db2Database](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryDb2 -Operation DatabaseJobStatus` | `New-RscQuery -Gql db2DatabaseJobStatus` | [db2DatabaseJobStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryDb2 -Operation Databases` | `New-RscQuery -Gql db2Databases` | [db2Databases](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryDb2 -Operation Instance` | `New-RscQuery -Gql db2Instance` | [db2Instance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryDb2 -Operation Instances` | `New-RscQuery -Gql db2Instances` | [db2Instances](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryDb2 -Operation LogSnapshot` | `New-RscQuery -Gql db2LogSnapshot` | [db2LogSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryDb2 -Operation LogSnapshots` | `New-RscQuery -Gql db2LogSnapshots` | [db2LogSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryDb2 -Operation RecoverDatabaseToEndOfBackup` | `New-RscQuery -Gql recoverDb2DatabaseToEndOfBackup` | [recoverDb2DatabaseToEndOfBackup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryDb2 -Operation RecoverDatabaseToPointInTime` | `New-RscQuery -Gql recoverDb2DatabaseToPointInTime` | [recoverDb2DatabaseToPointInTime](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryDb2 -Operation RecoverableRange` | `New-RscQuery -Gql db2RecoverableRange` | [db2RecoverableRange](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryDb2 -Operation RecoverableRanges` | `New-RscQuery -Gql db2RecoverableRanges` | [db2RecoverableRanges](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationDb2 -Operation AddInstance` | `New-RscMutation -Gql addDb2Instance` | [addDb2Instance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationDb2 -Operation ConfigureRestore` | `New-RscMutation -Gql configureDb2Restore` | [configureDb2Restore](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationDb2 -Operation CreateOnDemandBackup` | `New-RscMutation -Gql createOnDemandDb2Backup` | [createOnDemandDb2Backup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationDb2 -Operation DeleteDatabase` | `New-RscMutation -Gql deleteDb2Database` | [deleteDb2Database](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationDb2 -Operation DeleteInstance` | `New-RscMutation -Gql deleteDb2Instance` | [deleteDb2Instance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationDb2 -Operation DiscoverInstance` | `New-RscMutation -Gql discoverDb2Instance` | [discoverDb2Instance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationDb2 -Operation DownloadSnapshot` | `New-RscMutation -Gql downloadDb2Snapshot` | [downloadDb2Snapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationDb2 -Operation DownloadSnapshotV2` | `New-RscMutation -Gql downloadDb2SnapshotV2` | [downloadDb2SnapshotV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationDb2 -Operation DownloadSnapshotsForPointInTimeRecovery` | `New-RscMutation -Gql downloadDb2SnapshotsForPointInTimeRecovery` | [downloadDb2SnapshotsForPointInTimeRecovery](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationDb2 -Operation ExpireDownloadedSnapshots` | `New-RscMutation -Gql expireDownloadedDb2Snapshots` | [expireDownloadedDb2Snapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationDb2 -Operation PatchDatabase` | `New-RscMutation -Gql patchDb2Database` | [patchDb2Database](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationDb2 -Operation PatchInstance` | `New-RscMutation -Gql patchDb2Instance` | [patchDb2Instance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationDb2 -Operation RefreshDatabase` | `New-RscMutation -Gql refreshDb2Database` | [refreshDb2Database](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Report Download domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryDownload -Operation CdmUpgradesPdf` | `New-RscQuery -Gql downloadCdmUpgradesPdf` | [downloadCdmUpgradesPdf](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryDownload -Operation DownloadedVersionList` | `New-RscQuery -Gql downloadedVersionList` | [downloadedVersionList](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryDownload -Operation PackageStatus` | `New-RscQuery -Gql downloadPackageStatus` | [downloadPackageStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryDownload -Operation TurboThreatHuntCsv` | `New-RscQuery -Gql downloadTurboThreatHuntCsv` | [downloadTurboThreatHuntCsv](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationDownload -Operation ActiveDirectorySnapshotFromLocation` | `New-RscMutation -Gql downloadActiveDirectorySnapshotFromLocation` | [downloadActiveDirectorySnapshotFromLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationDownload -Operation AnomalyDetailsCsv` | `New-RscMutation -Gql downloadAnomalyDetailsCsv` | [downloadAnomalyDetailsCsv](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationDownload -Operation AuditLogCsvAsync` | `New-RscMutation -Gql downloadAuditLogCsvAsync` | [downloadAuditLogCsvAsync](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationDownload -Operation CdmTprConfigurationAsync` | `New-RscMutation -Gql downloadCdmTprConfigurationAsync` | [downloadCdmTprConfigurationAsync](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationDownload -Operation ExchangeSnapshot` | `New-RscMutation -Gql downloadExchangeSnapshot` | [downloadExchangeSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationDownload -Operation ExchangeSnapshotV2` | `New-RscMutation -Gql downloadExchangeSnapshotV2` | [downloadExchangeSnapshotV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationDownload -Operation FilesetSnapshot` | `New-RscMutation -Gql downloadFilesetSnapshot` | [downloadFilesetSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationDownload -Operation FilesetSnapshotFromLocation` | `New-RscMutation -Gql downloadFilesetSnapshotFromLocation` | [downloadFilesetSnapshotFromLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationDownload -Operation FromArchiveV2` | `New-RscMutation -Gql downloadFromArchiveV2` | [downloadFromArchiveV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationDownload -Operation ObjectFilesCsv` | `New-RscMutation -Gql downloadObjectFilesCsv` | [downloadObjectFilesCsv](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationDownload -Operation ObjectsListCsv` | `New-RscMutation -Gql downloadObjectsListCsv` | [downloadObjectsListCsv](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationDownload -Operation OpenstackSnapshotFromLocation` | `New-RscMutation -Gql downloadOpenstackSnapshotFromLocation` | [downloadOpenstackSnapshotFromLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationDownload -Operation ReportCsvAsync` | `New-RscMutation -Gql downloadReportCsvAsync` | [downloadReportCsvAsync](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationDownload -Operation ReportPdfAsync` | `New-RscMutation -Gql downloadReportPdfAsync` | [downloadReportPdfAsync](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationDownload -Operation ResultsCsv` | `New-RscMutation -Gql downloadResultsCsv` | [downloadResultsCsv](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationDownload -Operation SapHanaSnapshot` | `New-RscMutation -Gql downloadSapHanaSnapshot` | [downloadSapHanaSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationDownload -Operation SapHanaSnapshotFromLocation` | `New-RscMutation -Gql downloadSapHanaSnapshotFromLocation` | [downloadSapHanaSnapshotFromLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationDownload -Operation SapHanaSnapshotsForPointInTimeRecovery` | `New-RscMutation -Gql downloadSapHanaSnapshotsForPointInTimeRecovery` | [downloadSapHanaSnapshotsForPointInTimeRecovery](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationDownload -Operation SnapshotResultsCsv` | `New-RscMutation -Gql downloadSnapshotResultsCsv` | [downloadSnapshotResultsCsv](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationDownload -Operation ThreatHuntCsv` | `New-RscMutation -Gql downloadThreatHuntCsv` | [downloadThreatHuntCsv](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationDownload -Operation ThreatHuntV2ResultsCsv` | `New-RscMutation -Gql downloadThreatHuntV2ResultsCsv` | [downloadThreatHuntV2ResultsCsv](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationDownload -Operation VolumeGroupSnapshotFiles` | `New-RscMutation -Gql downloadVolumeGroupSnapshotFiles` | [downloadVolumeGroupSnapshotFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationDownload -Operation VolumeGroupSnapshotFromLocation` | `New-RscMutation -Gql downloadVolumeGroupSnapshotFromLocation` | [downloadVolumeGroupSnapshotFromLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Microsoft Exchange domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryExchange -Operation Dag` | `New-RscQuery -Gql exchangeDag` | [exchangeDag](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryExchange -Operation Dags` | `New-RscQuery -Gql exchangeDags` | [exchangeDags](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryExchange -Operation Database` | `New-RscQuery -Gql exchangeDatabase` | [exchangeDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryExchange -Operation Databases` | `New-RscQuery -Gql exchangeDatabases` | [exchangeDatabases](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryExchange -Operation LiveMounts` | `New-RscQuery -Gql exchangeLiveMounts` | [exchangeLiveMounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryExchange -Operation Server` | `New-RscQuery -Gql exchangeServer` | [exchangeServer](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryExchange -Operation Servers` | `New-RscQuery -Gql exchangeServers` | [exchangeServers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationExchange -Operation BulkUpdateDag` | `New-RscMutation -Gql bulkUpdateExchangeDag` | [bulkUpdateExchangeDag](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationExchange -Operation CreateMount` | `New-RscMutation -Gql createExchangeMount` | [createExchangeMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationExchange -Operation CreateOnDemandBackup` | `New-RscMutation -Gql createOnDemandExchangeBackup` | [createOnDemandExchangeBackup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationExchange -Operation DeleteSnapshotMount` | `New-RscMutation -Gql deleteExchangeSnapshotMount` | [deleteExchangeSnapshotMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Failover Cluster domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryFailoverCluster -Operation App` | `New-RscQuery -Gql failoverClusterApp` | [failoverClusterApp](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryFailoverCluster -Operation Apps` | `New-RscQuery -Gql failoverClusterApps` | [failoverClusterApps](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryFailoverCluster -Operation Host` | `New-RscQuery -Gql hostFailoverCluster` | [hostFailoverCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryFailoverCluster -Operation Hosts` | `New-RscQuery -Gql hostFailoverClusters` | [hostFailoverClusters](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryFailoverCluster -Operation TopLevelDescendants` | `New-RscQuery -Gql failoverClusterTopLevelDescendants` | [failoverClusterTopLevelDescendants](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationFailoverCluster -Operation BulkDelete` | `New-RscMutation -Gql bulkDeleteFailoverCluster` | [bulkDeleteFailoverCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationFailoverCluster -Operation BulkDeleteApp` | `New-RscMutation -Gql bulkDeleteFailoverClusterApp` | [bulkDeleteFailoverClusterApp](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationFailoverCluster -Operation Create` | `New-RscMutation -Gql createFailoverCluster` | [createFailoverCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationFailoverCluster -Operation CreateApp` | `New-RscMutation -Gql createFailoverClusterApp` | [createFailoverClusterApp](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationFailoverCluster -Operation Delete` | `New-RscMutation -Gql deleteFailoverCluster` | [deleteFailoverCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationFailoverCluster -Operation DeleteApp` | `New-RscMutation -Gql deleteFailoverClusterApp` | [deleteFailoverClusterApp](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationFailoverCluster -Operation Update` | `New-RscMutation -Gql updateFailoverCluster` | [updateFailoverCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationFailoverCluster -Operation UpdateApp` | `New-RscMutation -Gql updateFailoverClusterApp` | [updateFailoverClusterApp](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Fileset domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryFileset -Operation Linux` | `New-RscQuery -Gql linuxFileset` | [linuxFileset](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryFileset -Operation RequestStatus` | `New-RscQuery -Gql filesetRequestStatus` | [filesetRequestStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryFileset -Operation Share` | `New-RscQuery -Gql shareFileset` | [shareFileset](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryFileset -Operation Template` | `New-RscQuery -Gql filesetTemplate` | [filesetTemplate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryFileset -Operation Templates` | `New-RscQuery -Gql filesetTemplates` | [filesetTemplates](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryFileset -Operation Windows` | `New-RscQuery -Gql windowsFileset` | [windowsFileset](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationFileset -Operation BulkCreate` | `New-RscMutation -Gql bulkCreateFilesets` | [bulkCreateFilesets](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationFileset -Operation BulkCreateTemplates` | `New-RscMutation -Gql bulkCreateFilesetTemplates` | [bulkCreateFilesetTemplates](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationFileset -Operation BulkDelete` | `New-RscMutation -Gql bulkDeleteFileset` | [bulkDeleteFileset](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationFileset -Operation BulkDeleteTemplate` | `New-RscMutation -Gql bulkDeleteFilesetTemplate` | [bulkDeleteFilesetTemplate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationFileset -Operation BulkGenerateBackupReport` | `New-RscMutation -Gql bulkGenerateFilesetBackupReport` | [bulkGenerateFilesetBackupReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationFileset -Operation BulkUpdateTemplate` | `New-RscMutation -Gql bulkUpdateFilesetTemplate` | [bulkUpdateFilesetTemplate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationFileset -Operation GenerateBackupReport` | `New-RscMutation -Gql generateFilesetBackupReport` | [generateFilesetBackupReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationFileset -Operation RecoverFiles` | `New-RscMutation -Gql filesetRecoverFiles` | [filesetRecoverFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationFileset -Operation RecoverFilesFromArchivalLocation` | `New-RscMutation -Gql filesetRecoverFilesFromArchivalLocation` | [filesetRecoverFilesFromArchivalLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationFileset -Operation Update` | `New-RscMutation -Gql updateFileset` | [updateFileset](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Google Cloud Platform domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryGcp -Operation CloudAccountGetProject` | `New-RscQuery -Gql gcpCloudAccountGetProject` | [gcpCloudAccountGetProject](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryGcp -Operation CloudAccountMissingPermissionsForAddition` | `New-RscQuery -Gql allGcpCloudAccountMissingPermissionsForAddition` | [allGcpCloudAccountMissingPermissionsForAddition](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryGcp -Operation CloudAccountProjectsByFeature` | `New-RscQuery -Gql allGcpCloudAccountProjectsByFeature` | [allGcpCloudAccountProjectsByFeature](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryGcp -Operation CloudAccountProjectsForOauth` | `New-RscQuery -Gql allGcpCloudAccountProjectsForOauth` | [allGcpCloudAccountProjectsForOauth](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryGcp -Operation CloudSqlInstance` | `New-RscQuery -Gql gcpCloudSqlInstance` | [gcpCloudSqlInstance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryGcp -Operation CloudSqlInstances` | `New-RscQuery -Gql gcpCloudSqlInstances` | [gcpCloudSqlInstances](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryGcp -Operation ExocomputeConfigs` | `New-RscQuery -Gql gcpExocomputeConfigs` | [gcpExocomputeConfigs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryGcp -Operation FeaturePermissionsForCloudAccount` | `New-RscQuery -Gql allFeaturePermissionsForGcpCloudAccount` | [allFeaturePermissionsForGcpCloudAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryGcp -Operation GetDefaultCredentialsServiceAccount` | `New-RscQuery -Gql gcpGetDefaultCredentialsServiceAccount` | [gcpGetDefaultCredentialsServiceAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryGcp -Operation GetResourceSetupTemplate` | `New-RscQuery -Gql gcpGetResourceSetupTemplate` | [gcpGetResourceSetupTemplate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryGcp -Operation LatestPermissionsByPermissionsGroup` | `New-RscQuery -Gql allLatestPermissionsByPermissionsGroupGcp` | [allLatestPermissionsByPermissionsGroupGcp](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryGcp -Operation NativeAvailableKmsCryptoKeys` | `New-RscQuery -Gql allGcpNativeAvailableKmsCryptoKeys` | [allGcpNativeAvailableKmsCryptoKeys](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryGcp -Operation NativeCompatibleMachineTypes` | `New-RscQuery -Gql allGcpNativeCompatibleMachineTypes` | [allGcpNativeCompatibleMachineTypes](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryGcp -Operation NativeNetworks` | `New-RscQuery -Gql allGcpNativeNetworks` | [allGcpNativeNetworks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryGcp -Operation NativeProjectsWithAccessibleNetworks` | `New-RscQuery -Gql allGcpNativeProjectsWithAccessibleNetworks` | [allGcpNativeProjectsWithAccessibleNetworks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryGcp -Operation NativeRegions` | `New-RscQuery -Gql allGcpNativeRegions` | [allGcpNativeRegions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryGcp -Operation NativeStoredMachineTypes` | `New-RscQuery -Gql allGcpNativeStoredMachineTypes` | [allGcpNativeStoredMachineTypes](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryGcp -Operation NativeStoredMachineTypesInProject` | `New-RscQuery -Gql allGcpNativeStoredMachineTypesInProject` | [allGcpNativeStoredMachineTypesInProject](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryGcp -Operation NativeStoredNetworkNames` | `New-RscQuery -Gql allGcpNativeStoredNetworkNames` | [allGcpNativeStoredNetworkNames](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryGcp -Operation NativeStoredNetworkNamesInProject` | `New-RscQuery -Gql allGcpNativeStoredNetworkNamesInProject` | [allGcpNativeStoredNetworkNamesInProject](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryGcp -Operation NativeStoredRegions` | `New-RscQuery -Gql allGcpNativeStoredRegions` | [allGcpNativeStoredRegions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryGcp -Operation NativeStoredRegionsInProject` | `New-RscQuery -Gql allGcpNativeStoredRegionsInProject` | [allGcpNativeStoredRegionsInProject](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationGcp -Operation AddCloudAccountManualAuthProject` | `New-RscMutation -Gql addGcpCloudAccountManualAuthProject` | [addGcpCloudAccountManualAuthProject](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationGcp -Operation BulkSetCloudAccountProperties` | `New-RscMutation -Gql gcpBulkSetCloudAccountProperties` | [gcpBulkSetCloudAccountProperties](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationGcp -Operation CloudAccountAddManualAuthProject` | `New-RscMutation -Gql gcpCloudAccountAddManualAuthProject` | [gcpCloudAccountAddManualAuthProject](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationGcp -Operation CloudAccountAddProjects` | `New-RscMutation -Gql gcpCloudAccountAddProjects` | [gcpCloudAccountAddProjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationGcp -Operation CloudAccountDeleteProjectsV2` | `New-RscMutation -Gql gcpCloudAccountDeleteProjectsV2` | [gcpCloudAccountDeleteProjectsV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationGcp -Operation CloudAccountOauthComplete` | `New-RscMutation -Gql gcpCloudAccountOauthComplete` | [gcpCloudAccountOauthComplete](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationGcp -Operation CloudAccountOauthInitiate` | `New-RscMutation -Gql gcpCloudAccountOauthInitiate` | [gcpCloudAccountOauthInitiate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationGcp -Operation CloudAccountUpgradeProjects` | `New-RscMutation -Gql gcpCloudAccountUpgradeProjects` | [gcpCloudAccountUpgradeProjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationGcp -Operation CreateReaderTarget` | `New-RscMutation -Gql createGcpReaderTarget` | [createGcpReaderTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationGcp -Operation CreateTarget` | `New-RscMutation -Gql createGcpTarget` | [createGcpTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationGcp -Operation SetDefaultServiceAccountJwtConfig` | `New-RscMutation -Gql gcpSetDefaultServiceAccountJwtConfig` | [gcpSetDefaultServiceAccountJwtConfig](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationGcp -Operation SetExocomputeConfigs` | `New-RscMutation -Gql setGcpExocomputeConfigs` | [setGcpExocomputeConfigs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationGcp -Operation UpdateTarget` | `New-RscMutation -Gql updateGcpTarget` | [updateGcpTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationGcp -Operation UpgradeCloudAccountPermissionsWithoutOauth` | `New-RscMutation -Gql upgradeGcpCloudAccountPermissionsWithoutOauth` | [upgradeGcpCloudAccountPermissionsWithoutOauth](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Google Cloud Platform Native domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryGcpNative -Operation Disk` | `New-RscQuery -Gql gcpNativeDisk` | [gcpNativeDisk](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryGcpNative -Operation Disks` | `New-RscQuery -Gql gcpNativeDisks` | [gcpNativeDisks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryGcpNative -Operation GceInstance` | `New-RscQuery -Gql gcpNativeGceInstance` | [gcpNativeGceInstance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryGcpNative -Operation GceInstances` | `New-RscQuery -Gql gcpNativeGceInstances` | [gcpNativeGceInstances](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryGcpNative -Operation Project` | `New-RscQuery -Gql gcpNativeProject` | [gcpNativeProject](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryGcpNative -Operation Projects` | `New-RscQuery -Gql gcpNativeProjects` | [gcpNativeProjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryGcpNative -Operation Root` | `New-RscQuery -Gql gcpNativeRoot` | [gcpNativeRoot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryGcpNative -Operation StoredDiskLocations` | `New-RscQuery -Gql gcpNativeStoredDiskLocations` | [gcpNativeStoredDiskLocations](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationGcpNative -Operation ExcludeDisksFromInstanceSnapshot` | `New-RscMutation -Gql gcpNativeExcludeDisksFromInstanceSnapshot` | [gcpNativeExcludeDisksFromInstanceSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationGcpNative -Operation ExportDisk` | `New-RscMutation -Gql gcpNativeExportDisk` | [gcpNativeExportDisk](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationGcpNative -Operation ExportGceInstance` | `New-RscMutation -Gql gcpNativeExportGceInstance` | [gcpNativeExportGceInstance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationGcpNative -Operation RefreshProjects` | `New-RscMutation -Gql gcpNativeRefreshProjects` | [gcpNativeRefreshProjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationGcpNative -Operation RestoreGceInstance` | `New-RscMutation -Gql gcpNativeRestoreGceInstance` | [gcpNativeRestoreGceInstance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Host domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryHost -Operation Diagnosis` | `New-RscQuery -Gql hostDiagnosis` | [hostDiagnosis](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryHost -Operation FailoverGroup` | `New-RscQuery -Gql failoverGroupHosts` | [failoverGroupHosts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryHost -Operation PhysicalHost` | `New-RscQuery -Gql physicalHost` | [physicalHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryHost -Operation PhysicalHosts` | `New-RscQuery -Gql physicalHosts` | [physicalHosts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryHost -Operation RbsNetworkLimit` | `New-RscQuery -Gql hostRbsNetworkLimit` | [hostRbsNetworkLimit](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryHost -Operation Search` | `New-RscQuery -Gql searchHost` | [searchHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryHost -Operation Share` | `New-RscQuery -Gql hostShare` | [hostShare](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryHost -Operation Shares` | `New-RscQuery -Gql hostShares` | [hostShares](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationHost -Operation BulkDelete` | `New-RscMutation -Gql bulkDeleteHost` | [bulkDeleteHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationHost -Operation BulkRefresh` | `New-RscMutation -Gql bulkRefreshHosts` | [bulkRefreshHosts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationHost -Operation BulkRegister` | `New-RscMutation -Gql bulkRegisterHost` | [bulkRegisterHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationHost -Operation BulkRegisterAsync` | `New-RscMutation -Gql bulkRegisterHostAsync` | [bulkRegisterHostAsync](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationHost -Operation BulkRegisterSecondary` | `New-RscMutation -Gql bulkRegisterSecondaryHosts` | [bulkRegisterSecondaryHosts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationHost -Operation BulkUpdate` | `New-RscMutation -Gql bulkUpdateHost` | [bulkUpdateHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationHost -Operation ChangeVfd` | `New-RscMutation -Gql changeVfdOnHost` | [changeVfdOnHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationHost -Operation ClearRbsNetworkLimit` | `New-RscMutation -Gql clearHostRbsNetworkLimit` | [clearHostRbsNetworkLimit](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationHost -Operation Refresh` | `New-RscMutation -Gql refreshHost` | [refreshHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationHost -Operation SetRbsNetworkLimit` | `New-RscMutation -Gql setHostRbsNetworkLimit` | [setHostRbsNetworkLimit](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Microsoft Hyper-V domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryHyperv -Operation Cluster` | `New-RscQuery -Gql hypervCluster` | [hypervCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryHyperv -Operation HostAsyncRequestStatus` | `New-RscQuery -Gql hypervHostAsyncRequestStatus` | [hypervHostAsyncRequestStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryHyperv -Operation Mounts` | `New-RscQuery -Gql hypervMounts` | [hypervMounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryHyperv -Operation Scvmm` | `New-RscQuery -Gql hypervScvmm` | [hypervScvmm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryHyperv -Operation ScvmmAsyncRequestStatus` | `New-RscQuery -Gql hypervScvmmAsyncRequestStatus` | [hypervScvmmAsyncRequestStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryHyperv -Operation Scvmms` | `New-RscQuery -Gql hypervScvmms` | [hypervScvmms](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryHyperv -Operation Server` | `New-RscQuery -Gql hypervServer` | [hypervServer](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryHyperv -Operation Servers` | `New-RscQuery -Gql hypervServers` | [hypervServers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryHyperv -Operation ServersPaginated` | `New-RscQuery -Gql hypervServersPaginated` | [hypervServersPaginated](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryHyperv -Operation TopLevelDescendants` | `New-RscQuery -Gql hypervTopLevelDescendants` | [hypervTopLevelDescendants](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryHyperv -Operation UniqueServersCount` | `New-RscQuery -Gql uniqueHypervServersCount` | [uniqueHypervServersCount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryHyperv -Operation VirtualMachine` | `New-RscQuery -Gql hypervVirtualMachine` | [hypervVirtualMachine](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryHyperv -Operation VirtualMachineAsyncRequestStatus` | `New-RscQuery -Gql hypervVirtualMachineAsyncRequestStatus` | [hypervVirtualMachineAsyncRequestStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryHyperv -Operation VirtualMachineLevelFileInfo` | `New-RscQuery -Gql hypervVirtualMachineLevelFileInfo` | [hypervVirtualMachineLevelFileInfo](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryHyperv -Operation VirtualMachines` | `New-RscQuery -Gql hypervVirtualMachines` | [hypervVirtualMachines](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryHyperv -Operation VmDetail` | `New-RscQuery -Gql hypervVmDetail` | [hypervVmDetail](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationHyperv -Operation BatchExportVm` | `New-RscMutation -Gql batchExportHypervVm` | [batchExportHypervVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationHyperv -Operation BatchInstantRecoverVm` | `New-RscMutation -Gql batchInstantRecoverHypervVm` | [batchInstantRecoverHypervVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationHyperv -Operation BatchMountVm` | `New-RscMutation -Gql batchMountHypervVm` | [batchMountHypervVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationHyperv -Operation BatchOnDemandBackupVm` | `New-RscMutation -Gql batchOnDemandBackupHypervVm` | [batchOnDemandBackupHypervVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationHyperv -Operation CreateVirtualMachineSnapshotDiskMount` | `New-RscMutation -Gql createHypervVirtualMachineSnapshotDiskMount` | [createHypervVirtualMachineSnapshotDiskMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationHyperv -Operation CreateVirtualMachineSnapshotMount` | `New-RscMutation -Gql createHypervVirtualMachineSnapshotMount` | [createHypervVirtualMachineSnapshotMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationHyperv -Operation DeleteAllSnapshots` | `New-RscMutation -Gql hypervDeleteAllSnapshots` | [hypervDeleteAllSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationHyperv -Operation DeleteVirtualMachineSnapshot` | `New-RscMutation -Gql deleteHypervVirtualMachineSnapshot` | [deleteHypervVirtualMachineSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationHyperv -Operation DeleteVirtualMachineSnapshotMount` | `New-RscMutation -Gql deleteHypervVirtualMachineSnapshotMount` | [deleteHypervVirtualMachineSnapshotMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationHyperv -Operation DownloadSnapshotFromLocation` | `New-RscMutation -Gql downloadHypervSnapshotFromLocation` | [downloadHypervSnapshotFromLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationHyperv -Operation DownloadVirtualMachineLevelFiles` | `New-RscMutation -Gql downloadHypervVirtualMachineLevelFiles` | [downloadHypervVirtualMachineLevelFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationHyperv -Operation DownloadVirtualMachineSnapshot` | `New-RscMutation -Gql downloadHypervVirtualMachineSnapshot` | [downloadHypervVirtualMachineSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationHyperv -Operation DownloadVirtualMachineSnapshotFiles` | `New-RscMutation -Gql downloadHypervVirtualMachineSnapshotFiles` | [downloadHypervVirtualMachineSnapshotFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationHyperv -Operation ExportVirtualMachine` | `New-RscMutation -Gql exportHypervVirtualMachine` | [exportHypervVirtualMachine](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationHyperv -Operation InplaceExportVirtualMachine` | `New-RscMutation -Gql inplaceExportHypervVirtualMachine` | [inplaceExportHypervVirtualMachine](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationHyperv -Operation InstantRecoverVirtualMachineSnapshot` | `New-RscMutation -Gql instantRecoverHypervVirtualMachineSnapshot` | [instantRecoverHypervVirtualMachineSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationHyperv -Operation OnDemandSnapshot` | `New-RscMutation -Gql hypervOnDemandSnapshot` | [hypervOnDemandSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationHyperv -Operation RefreshScvmm` | `New-RscMutation -Gql refreshHypervScvmm` | [refreshHypervScvmm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationHyperv -Operation RefreshServer` | `New-RscMutation -Gql refreshHypervServer` | [refreshHypervServer](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationHyperv -Operation RegisterAgentVirtualMachine` | `New-RscMutation -Gql registerAgentHypervVirtualMachine` | [registerAgentHypervVirtualMachine](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationHyperv -Operation RegisterScvmm` | `New-RscMutation -Gql registerHypervScvmm` | [registerHypervScvmm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationHyperv -Operation RestoreVirtualMachineSnapshotFiles` | `New-RscMutation -Gql restoreHypervVirtualMachineSnapshotFiles` | [restoreHypervVirtualMachineSnapshotFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationHyperv -Operation ScvmmDelete` | `New-RscMutation -Gql hypervScvmmDelete` | [hypervScvmmDelete](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationHyperv -Operation ScvmmUpdate` | `New-RscMutation -Gql hypervScvmmUpdate` | [hypervScvmmUpdate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationHyperv -Operation UpdateVirtualMachine` | `New-RscMutation -Gql updateHypervVirtualMachine` | [updateHypervVirtualMachine](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationHyperv -Operation UpdateVirtualMachineSnapshotMount` | `New-RscMutation -Gql updateHypervVirtualMachineSnapshotMount` | [updateHypervVirtualMachineSnapshotMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Integration domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryIntegration -Operation Integration` | `New-RscQuery -Gql integration` | [integration](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryIntegration -Operation Integrations` | `New-RscQuery -Gql allIntegrations` | [allIntegrations](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationIntegration -Operation CreateIntegration` | `New-RscMutation -Gql createIntegration` | [createIntegration](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationIntegration -Operation CreateIntegrations` | `New-RscMutation -Gql createIntegrations` | [createIntegrations](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationIntegration -Operation DeleteIntegration` | `New-RscMutation -Gql deleteIntegration` | [deleteIntegration](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationIntegration -Operation DeleteIntegrations` | `New-RscMutation -Gql deleteIntegrations` | [deleteIntegrations](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationIntegration -Operation EnableIntegration` | `New-RscMutation -Gql enableIntegration` | [enableIntegration](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationIntegration -Operation UpdateIntegration` | `New-RscMutation -Gql updateIntegration` | [updateIntegration](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationIntegration -Operation UpdateIntegrations` | `New-RscMutation -Gql updateIntegrations` | [updateIntegrations](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Kubernetes domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryK8s -Operation AppManifest` | `New-RscQuery -Gql k8sAppManifest` | [k8sAppManifest](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryK8s -Operation Cluster` | `New-RscQuery -Gql kubernetesCluster` | [kubernetesCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryK8s -Operation Clusters` | `New-RscQuery -Gql kubernetesClusters` | [kubernetesClusters](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryK8s -Operation K8sCluster` | `New-RscQuery -Gql k8sCluster` | [k8sCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryK8s -Operation K8sClusters` | `New-RscQuery -Gql k8sClusters` | [k8sClusters](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryK8s -Operation Namespace` | `New-RscQuery -Gql k8sNamespace` | [k8sNamespace](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryK8s -Operation Namespaces` | `New-RscQuery -Gql k8sNamespaces` | [k8sNamespaces](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryK8s -Operation ProtectionSet` | `New-RscQuery -Gql kubernetesProtectionSet` | [kubernetesProtectionSet](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryK8s -Operation ProtectionSetSnapshots` | `New-RscQuery -Gql k8sProtectionSetSnapshots` | [k8sProtectionSetSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryK8s -Operation ProtectionSets` | `New-RscQuery -Gql kubernetesProtectionSets` | [kubernetesProtectionSets](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryK8s -Operation ReplicaSnapshotInfos` | `New-RscQuery -Gql allK8sReplicaSnapshotInfos` | [allK8sReplicaSnapshotInfos](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryK8s -Operation SnapshotInfo` | `New-RscQuery -Gql k8sSnapshotInfo` | [k8sSnapshotInfo](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryK8s -Operation VirtualMachineSnapshots` | `New-RscQuery -Gql kubernetesVirtualMachineSnapshots` | [kubernetesVirtualMachineSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationK8s -Operation AddCluster` | `New-RscMutation -Gql addK8sCluster` | [addK8sCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationK8s -Operation AddProtectionSet` | `New-RscMutation -Gql addK8sProtectionSet` | [addK8sProtectionSet](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationK8s -Operation ArchiveCluster` | `New-RscMutation -Gql archiveK8sCluster` | [archiveK8sCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationK8s -Operation CreateAgentManifest` | `New-RscMutation -Gql createK8sAgentManifest` | [createK8sAgentManifest](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationK8s -Operation CreateCluster` | `New-RscMutation -Gql createK8sCluster` | [createK8sCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationK8s -Operation CreateNamespaceSnapshots` | `New-RscMutation -Gql createK8sNamespaceSnapshots` | [createK8sNamespaceSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationK8s -Operation CreateProtectionSetSnapshot` | `New-RscMutation -Gql createK8sProtectionSetSnapshot` | [createK8sProtectionSetSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationK8s -Operation DeleteCluster` | `New-RscMutation -Gql deleteK8sCluster` | [deleteK8sCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationK8s -Operation DeleteProtectionSet` | `New-RscMutation -Gql deleteK8sProtectionSet` | [deleteK8sProtectionSet](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationK8s -Operation DeleteVmMount` | `New-RscMutation -Gql deleteK8sVmMount` | [deleteK8sVmMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationK8s -Operation DownloadSnapshotFromLocation` | `New-RscMutation -Gql downloadK8sSnapshotFromLocation` | [downloadK8sSnapshotFromLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationK8s -Operation ExportNamespace` | `New-RscMutation -Gql exportK8sNamespace` | [exportK8sNamespace](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationK8s -Operation ExportProtectionSetSnapshot` | `New-RscMutation -Gql exportK8sProtectionSetSnapshot` | [exportK8sProtectionSetSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationK8s -Operation ExportVirtualMachineSnapshot` | `New-RscMutation -Gql exportK8sVirtualMachineSnapshot` | [exportK8sVirtualMachineSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationK8s -Operation GenerateManifest` | `New-RscMutation -Gql generateK8sManifest` | [generateK8sManifest](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationK8s -Operation RefreshCluster` | `New-RscMutation -Gql refreshK8sCluster` | [refreshK8sCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationK8s -Operation RefreshV2Cluster` | `New-RscMutation -Gql refreshK8sV2Cluster` | [refreshK8sV2Cluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationK8s -Operation RegenerateManifest` | `New-RscMutation -Gql regenerateK8sManifest` | [regenerateK8sManifest](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationK8s -Operation RestoreNamespace` | `New-RscMutation -Gql restoreK8sNamespace` | [restoreK8sNamespace](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationK8s -Operation RestoreProtectionSetSnapshot` | `New-RscMutation -Gql restoreK8sProtectionSetSnapshot` | [restoreK8sProtectionSetSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationK8s -Operation StartDiagnosticsJob` | `New-RscMutation -Gql startK8sDiagnosticsJob` | [startK8sDiagnosticsJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationK8s -Operation StartVmMountJob` | `New-RscMutation -Gql startK8sVmMountJob` | [startK8sVmMountJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationK8s -Operation UpdateCluster` | `New-RscMutation -Gql updateK8sCluster` | [updateK8sCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationK8s -Operation UpdateProtectionSet` | `New-RscMutation -Gql updateK8sProtectionSet` | [updateK8sProtectionSet](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## LDAP domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryLdap -Operation AuthorizedPrincipalList` | `New-RscQuery -Gql ldapAuthorizedPrincipalConnection` | [ldapAuthorizedPrincipalConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryLdap -Operation IntegrationList` | `New-RscQuery -Gql ldapIntegrationConnection` | [ldapIntegrationConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryLdap -Operation PrincipalList` | `New-RscQuery -Gql ldapPrincipalConnection` | [ldapPrincipalConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationLdap -Operation DeletePrincipals` | `New-RscMutation -Gql deleteLdapPrincipals` | [deleteLdapPrincipals](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationLdap -Operation RemoveIntegration` | `New-RscMutation -Gql removeLdapIntegration` | [removeLdapIntegration](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationLdap -Operation SetMfaSetting` | `New-RscMutation -Gql setLdapMfaSetting` | [setLdapMfaSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationLdap -Operation UpdateIntegration` | `New-RscMutation -Gql updateLdapIntegration` | [updateLdapIntegration](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Microsoft 365 domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryM365 -Operation BackupStorageLicenseUsage` | `New-RscQuery -Gql m365BackupStorageLicenseUsage` | [m365BackupStorageLicenseUsage](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryM365 -Operation BackupStorageObjectRestorePoints` | `New-RscQuery -Gql m365BackupStorageObjectRestorePoints` | [m365BackupStorageObjectRestorePoints](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryM365 -Operation DayToDayModeStats` | `New-RscQuery -Gql m365DayToDayModeStats` | [m365DayToDayModeStats](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryM365 -Operation DirectoryObjectAttributes` | `New-RscQuery -Gql m365DirectoryObjectAttributes` | [m365DirectoryObjectAttributes](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryM365 -Operation LicenseEntitlement` | `New-RscQuery -Gql m365LicenseEntitlement` | [m365LicenseEntitlement](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryM365 -Operation OnboardingModeBackupStats` | `New-RscQuery -Gql m365OnboardingModeBackupStats` | [m365OnboardingModeBackupStats](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryM365 -Operation OnboardingModeStats` | `New-RscQuery -Gql m365OnboardingModeStats` | [m365OnboardingModeStats](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryM365 -Operation OrgBackupLocations` | `New-RscQuery -Gql m365OrgBackupLocations` | [m365OrgBackupLocations](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryM365 -Operation OrgOperationModes` | `New-RscQuery -Gql m365OrgOperationModes` | [m365OrgOperationModes](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryM365 -Operation Regions` | `New-RscQuery -Gql m365Regions` | [m365Regions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryM365 -Operation SearchBackupStorageObjectRestorePoints` | `New-RscQuery -Gql searchM365BackupStorageObjectRestorePoints` | [searchM365BackupStorageObjectRestorePoints](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationM365 -Operation BackupMailbox` | `New-RscMutation -Gql backupM365Mailbox` | [backupM365Mailbox](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationM365 -Operation BackupOnedrive` | `New-RscMutation -Gql backupM365Onedrive` | [backupM365Onedrive](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationM365 -Operation BackupSharepointDrive` | `New-RscMutation -Gql backupM365SharepointDrive` | [backupM365SharepointDrive](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationM365 -Operation BackupTeam` | `New-RscMutation -Gql backupM365Team` | [backupM365Team](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Managed Volume domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryManagedVolume -Operation InventoryStats` | `New-RscQuery -Gql managedVolumeInventoryStats` | [managedVolumeInventoryStats](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryManagedVolume -Operation LiveMounts` | `New-RscQuery -Gql managedVolumeLiveMounts` | [managedVolumeLiveMounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryManagedVolume -Operation ManagedVolume` | `New-RscQuery -Gql managedVolume` | [managedVolume](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryManagedVolume -Operation ManagedVolumes` | `New-RscQuery -Gql managedVolumes` | [managedVolumes](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationManagedVolume -Operation Add` | `New-RscMutation -Gql addManagedVolume` | [addManagedVolume](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationManagedVolume -Operation BeginSnapshot` | `New-RscMutation -Gql beginManagedVolumeSnapshot` | [beginManagedVolumeSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationManagedVolume -Operation Delete` | `New-RscMutation -Gql deleteManagedVolume` | [deleteManagedVolume](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationManagedVolume -Operation DeleteSnapshotExport` | `New-RscMutation -Gql deleteManagedVolumeSnapshotExport` | [deleteManagedVolumeSnapshotExport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationManagedVolume -Operation DownloadFiles` | `New-RscMutation -Gql downloadManagedVolumeFiles` | [downloadManagedVolumeFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationManagedVolume -Operation DownloadFilesSnapshotFromArchivalLocation` | `New-RscMutation -Gql downloadFilesManagedVolumeSnapshotFromArchivalLocation` | [downloadFilesManagedVolumeSnapshotFromArchivalLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationManagedVolume -Operation DownloadFromLocation` | `New-RscMutation -Gql downloadManagedVolumeFromLocation` | [downloadManagedVolumeFromLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationManagedVolume -Operation EndSnapshot` | `New-RscMutation -Gql endManagedVolumeSnapshot` | [endManagedVolumeSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationManagedVolume -Operation ExportSnapshot` | `New-RscMutation -Gql exportManagedVolumeSnapshot` | [exportManagedVolumeSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationManagedVolume -Operation Resize` | `New-RscMutation -Gql resizeManagedVolume` | [resizeManagedVolume](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationManagedVolume -Operation TakeOnDemandSnapshot` | `New-RscMutation -Gql takeManagedVolumeOnDemandSnapshot` | [takeManagedVolumeOnDemandSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationManagedVolume -Operation Update` | `New-RscMutation -Gql updateManagedVolume` | [updateManagedVolume](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Miscellaneous domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryMisc -Operation ActiveCustomAnalyzers` | `New-RscQuery -Gql activeCustomAnalyzers` | [activeCustomAnalyzers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation Activities` | `New-RscQuery -Gql activities` | [activities](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation AdGroupMembers` | `New-RscQuery -Gql adGroupMembers` | [adGroupMembers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation AdVolumeExports` | `New-RscQuery -Gql adVolumeExports` | [adVolumeExports](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation AgentDeploymentSetting` | `New-RscQuery -Gql agentDeploymentSetting` | [agentDeploymentSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation AgentDeploymentSettings` | `New-RscQuery -Gql allAgentDeploymentSettings` | [allAgentDeploymentSettings](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation AllowedOrgAdminOperations` | `New-RscQuery -Gql allAllowedOrgAdminOperations` | [allAllowedOrgAdminOperations](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation AnalyzerGroups` | `New-RscQuery -Gql analyzerGroups` | [analyzerGroups](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation AnalyzerUsages` | `New-RscQuery -Gql analyzerUsages` | [analyzerUsages](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation AnomalyResultOpt` | `New-RscQuery -Gql anomalyResultOpt` | [anomalyResultOpt](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation AnomalyResults` | `New-RscQuery -Gql anomalyResults` | [anomalyResults](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation AnomalyResultsGrouped` | `New-RscQuery -Gql anomalyResultsGrouped` | [anomalyResultsGrouped](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation AreMultiGeoBackupsEnabled` | `New-RscQuery -Gql areMultiGeoBackupsEnabled` | [areMultiGeoBackupsEnabled](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation AuthorizationsForGlobalResource` | `New-RscQuery -Gql allAuthorizationsForGlobalResource` | [allAuthorizationsForGlobalResource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation AuthorizationsForObject` | `New-RscQuery -Gql allAuthorizationsForObject` | [allAuthorizationsForObject](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation AuthorizationsForObjects` | `New-RscQuery -Gql allAuthorizationsForObjects` | [allAuthorizationsForObjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation AzureResourceGroups` | `New-RscQuery -Gql allAzureResourceGroups` | [allAzureResourceGroups](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation AzureSubnets` | `New-RscQuery -Gql allAzureSubnets` | [allAzureSubnets](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation BackupThrottleSettings` | `New-RscQuery -Gql allBackupThrottleSettings` | [allBackupThrottleSettings](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation BrowseCalendar` | `New-RscQuery -Gql browseCalendar` | [browseCalendar](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation BrowseContacts` | `New-RscQuery -Gql browseContacts` | [browseContacts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation BrowseFolder` | `New-RscQuery -Gql browseFolder` | [browseFolder](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation BrowseOnedrive` | `New-RscQuery -Gql browseOnedrive` | [browseOnedrive](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation BrowseTeamsChannels` | `New-RscQuery -Gql browseTeamsChannels` | [browseTeamsChannels](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation BrowseTeamsDrive` | `New-RscQuery -Gql browseTeamsDrive` | [browseTeamsDrive](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation CcProvisionMetadata` | `New-RscQuery -Gql ccProvisionMetadata` | [ccProvisionMetadata](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation CdmGuestCredentials` | `New-RscQuery -Gql allCdmGuestCredentials` | [allCdmGuestCredentials](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation CdmInventorySubHierarchyRoot` | `New-RscQuery -Gql cdmInventorySubHierarchyRoot` | [cdmInventorySubHierarchyRoot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation CdmOvaDetails` | `New-RscQuery -Gql allCdmOvaDetails` | [allCdmOvaDetails](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation CdmVersionCheck` | `New-RscQuery -Gql cdmVersionCheck` | [cdmVersionCheck](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation CdpVmsInfos` | `New-RscQuery -Gql allCdpVmsInfos` | [allCdpVmsInfos](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation CheckCloudComputeConnectivityJobProgress` | `New-RscQuery -Gql checkCloudComputeConnectivityJobProgress` | [checkCloudComputeConnectivityJobProgress](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation CheckLatestVersionMgmtAppExists` | `New-RscQuery -Gql checkLatestVersionMgmtAppExists` | [checkLatestVersionMgmtAppExists](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation CloudDirectCheckSharePath` | `New-RscQuery -Gql cloudDirectCheckSharePath` | [cloudDirectCheckSharePath](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation CloudDirectGlobalSearch` | `New-RscQuery -Gql cloudDirectGlobalSearch` | [cloudDirectGlobalSearch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation CloudDirectNasBucket` | `New-RscQuery -Gql cloudDirectNasBucket` | [cloudDirectNasBucket](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation CloudDirectNasBuckets` | `New-RscQuery -Gql cloudDirectNasBuckets` | [cloudDirectNasBuckets](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation CloudDirectNasExport` | `New-RscQuery -Gql cloudDirectNasExport` | [cloudDirectNasExport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation CloudDirectNasNamespace` | `New-RscQuery -Gql cloudDirectNasNamespace` | [cloudDirectNasNamespace](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation CloudDirectNasNamespaces` | `New-RscQuery -Gql cloudDirectNasNamespaces` | [cloudDirectNasNamespaces](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation CloudDirectNasShare` | `New-RscQuery -Gql cloudDirectNasShare` | [cloudDirectNasShare](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation CloudDirectShares` | `New-RscQuery -Gql allCloudDirectShares` | [allCloudDirectShares](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation CloudDirectSiteSettings` | `New-RscQuery -Gql cloudDirectSiteSettings` | [cloudDirectSiteSettings](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation CloudDirectSites` | `New-RscQuery -Gql allCloudDirectSites` | [allCloudDirectSites](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation CloudDirectSystems` | `New-RscQuery -Gql cloudDirectSystems` | [cloudDirectSystems](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation ConfiguredGroupMembers` | `New-RscQuery -Gql configuredGroupMembers` | [configuredGroupMembers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation Crawl` | `New-RscQuery -Gql crawl` | [crawl](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation Crawls` | `New-RscQuery -Gql crawls` | [crawls](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation CrossAccountPairs` | `New-RscQuery -Gql crossAccountPairs` | [crossAccountPairs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation CrowdStrikeIngestionStatus` | `New-RscQuery -Gql crowdStrikeIngestionStatus` | [crowdStrikeIngestionStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation CurrentIpAddress` | `New-RscQuery -Gql currentIpAddress` | [currentIpAddress](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation CurrentOrg` | `New-RscQuery -Gql currentOrg` | [currentOrg](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation CurrentOrgAuthDomainConfig` | `New-RscQuery -Gql currentOrgAuthDomainConfig` | [currentOrgAuthDomainConfig](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation CurrentOrgIdentityProviders` | `New-RscQuery -Gql allCurrentOrgIdentityProviders` | [allCurrentOrgIdentityProviders](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation CustomAnalyzer` | `New-RscQuery -Gql customAnalyzer` | [customAnalyzer](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation DashboardSummary` | `New-RscQuery -Gql dashboardSummary` | [dashboardSummary](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation DataPreview` | `New-RscQuery -Gql dataPreview` | [dataPreview](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation DatagovSecDesc` | `New-RscQuery -Gql datagovSecDesc` | [datagovSecDesc](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation DecryptExportUrl` | `New-RscQuery -Gql decryptExportUrl` | [decryptExportUrl](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation DeploymentIpAddresses` | `New-RscQuery -Gql allDeploymentIpAddresses` | [allDeploymentIpAddresses](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation DeploymentVersion` | `New-RscQuery -Gql deploymentVersion` | [deploymentVersion](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation DhrcActiveRecommendations` | `New-RscQuery -Gql allDhrcActiveRecommendations` | [allDhrcActiveRecommendations](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation DhrcLatestMetrics` | `New-RscQuery -Gql allDhrcLatestMetrics` | [allDhrcLatestMetrics](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation DhrcScores` | `New-RscQuery -Gql allDhrcScores` | [allDhrcScores](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation DiffFmd` | `New-RscQuery -Gql diffFmd` | [diffFmd](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation DiscoverNodes` | `New-RscQuery -Gql discoverNodes` | [discoverNodes](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation DiscoveryTimeline` | `New-RscQuery -Gql discoveryTimeline` | [discoveryTimeline](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation DistributionListDigest` | `New-RscQuery -Gql distributionListDigest` | [distributionListDigest](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation DistributionListDigests` | `New-RscQuery -Gql allDistributionListDigests` | [allDistributionListDigests](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation EdgeWindowsToolLink` | `New-RscQuery -Gql edgeWindowsToolLink` | [edgeWindowsToolLink](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation EffectiveRbacPermissions` | `New-RscQuery -Gql allEffectiveRbacPermissions` | [allEffectiveRbacPermissions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation EventDigests` | `New-RscQuery -Gql allEventDigests` | [allEventDigests](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation ExocomputeGetSupportedHealthChecks` | `New-RscQuery -Gql exocomputeGetSupportedHealthChecks` | [exocomputeGetSupportedHealthChecks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation ExocomputeHealthChecks` | `New-RscQuery -Gql exocomputeHealthChecks` | [exocomputeHealthChecks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation ExternalDeploymentName` | `New-RscQuery -Gql externalDeploymentName` | [externalDeploymentName](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation FailedRestoreItemsInfo` | `New-RscQuery -Gql failedRestoreItemsInfo` | [failedRestoreItemsInfo](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation FailoverGroupWorkloads` | `New-RscQuery -Gql failoverGroupWorkloads` | [failoverGroupWorkloads](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation FederatedLoginStatus` | `New-RscQuery -Gql federatedLoginStatus` | [federatedLoginStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation FileActivities` | `New-RscQuery -Gql allFileActivities` | [allFileActivities](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation GeoLocationList` | `New-RscQuery -Gql geoLocationList` | [geoLocationList](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation GetAllRolesInOrgList` | `New-RscQuery -Gql getAllRolesInOrgConnection` | [getAllRolesInOrgConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation GetCdmReleaseDetailsForVersionFromSupportPortal` | `New-RscQuery -Gql getCdmReleaseDetailsForVersionFromSupportPortal` | [getCdmReleaseDetailsForVersionFromSupportPortal](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation GetCdmReleaseDetailsFromSupportPortal` | `New-RscQuery -Gql getCdmReleaseDetailsFromSupportPortal` | [getCdmReleaseDetailsFromSupportPortal](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation GetGroupCountByPrechecksStatus` | `New-RscQuery -Gql getGroupCountByPrechecksStatus` | [getGroupCountByPrechecksStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation GetGroupCountByUpgradeJobStatus` | `New-RscQuery -Gql getGroupCountByUpgradeJobStatus` | [getGroupCountByUpgradeJobStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation GetGroupCountByVersionStatus` | `New-RscQuery -Gql getGroupCountByVersionStatus` | [getGroupCountByVersionStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation GetKorgTaskchainStatus` | `New-RscQuery -Gql getKorgTaskchainStatus` | [getKorgTaskchainStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation GetPermissions` | `New-RscQuery -Gql getPermissions` | [getPermissions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation GetRolesByIds` | `New-RscQuery -Gql getRolesByIds` | [getRolesByIds](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation GetUserDownloads` | `New-RscQuery -Gql getUserDownloads` | [getUserDownloads](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation GlobalFileSearch` | `New-RscQuery -Gql globalFileSearch` | [globalFileSearch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation GlobalLockoutConfig` | `New-RscQuery -Gql globalLockoutConfig` | [globalLockoutConfig](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation GlobalMfaSetting` | `New-RscQuery -Gql globalMfaSetting` | [globalMfaSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation GlobalSearchResults` | `New-RscQuery -Gql globalSearchResults` | [globalSearchResults](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation GroupsInCurrentAndDescendantOrganization` | `New-RscQuery -Gql groupsInCurrentAndDescendantOrganization` | [groupsInCurrentAndDescendantOrganization](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation GuestCredentials` | `New-RscQuery -Gql guestCredentials` | [guestCredentials](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation GuestCredentialsV2` | `New-RscQuery -Gql guestCredentialsV2` | [guestCredentialsV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation HasIdpConfigured` | `New-RscQuery -Gql hasIdpConfigured` | [hasIdpConfigured](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation HelpContentSnippets` | `New-RscQuery -Gql helpContentSnippets` | [helpContentSnippets](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation HierarchyObject` | `New-RscQuery -Gql hierarchyObject` | [hierarchyObject](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation HierarchyObjects` | `New-RscQuery -Gql hierarchyObjects` | [hierarchyObjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation IdentityDataLocationsEncryptionInfo` | `New-RscQuery -Gql identityDataLocationsEncryptionInfo` | [identityDataLocationsEncryptionInfo](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation InstalledVersionList` | `New-RscQuery -Gql installedVersionList` | [installedVersionList](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation InventoryRoot` | `New-RscQuery -Gql inventoryRoot` | [inventoryRoot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation InventorySubHierarchyRoot` | `New-RscQuery -Gql inventorySubHierarchyRoot` | [inventorySubHierarchyRoot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation InventoryWorkloads` | `New-RscQuery -Gql allInventoryWorkloads` | [allInventoryWorkloads](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation InvestigationCsvDownloadLink` | `New-RscQuery -Gql investigationCsvDownloadLink` | [investigationCsvDownloadLink](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation IocFeedEntries` | `New-RscQuery -Gql iocFeedEntries` | [iocFeedEntries](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation IpWhitelist` | `New-RscQuery -Gql ipWhitelist` | [ipWhitelist](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation IpWhitelistEntries` | `New-RscQuery -Gql ipWhitelistEntries` | [ipWhitelistEntries](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation IpWhitelistSettings` | `New-RscQuery -Gql ipWhitelistSettings` | [ipWhitelistSettings](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation IsCloudDirectSharePathValid` | `New-RscQuery -Gql isCloudDirectSharePathValid` | [isCloudDirectSharePathValid](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation IsIpmiEnabled` | `New-RscQuery -Gql isIpmiEnabled` | [isIpmiEnabled](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation IsLoggedIntoRubrikSupportPortal` | `New-RscQuery -Gql isLoggedIntoRubrikSupportPortal` | [isLoggedIntoRubrikSupportPortal](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation IsReplaceNodeTprConfigured` | `New-RscQuery -Gql isReplaceNodeTprConfigured` | [isReplaceNodeTprConfigured](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation IsSfdcReachable` | `New-RscQuery -Gql isSfdcReachable` | [isSfdcReachable](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation IsUpgradeAvailable` | `New-RscQuery -Gql isUpgradeAvailable` | [isUpgradeAvailable](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation IsUpgradeRecommended` | `New-RscQuery -Gql isUpgradeRecommended` | [isUpgradeRecommended](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation IsZrsAvailableForLocation` | `New-RscQuery -Gql isZrsAvailableForLocation` | [isZrsAvailableForLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation Issue` | `New-RscQuery -Gql issue` | [issue](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation Issues` | `New-RscQuery -Gql issues` | [issues](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation IssuesJobIds` | `New-RscQuery -Gql allIssuesJobIds` | [allIssuesJobIds](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation JobInfo` | `New-RscQuery -Gql jobInfo` | [jobInfo](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation KnowledgeBaseArticle` | `New-RscQuery -Gql knowledgeBaseArticle` | [knowledgeBaseArticle](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation LacpConfigurations` | `New-RscQuery -Gql lacpConfigurations` | [lacpConfigurations](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation LambdaSettings` | `New-RscQuery -Gql lambdaSettings` | [lambdaSettings](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation LicensedProducts` | `New-RscQuery -Gql allLicensedProducts` | [allLicensedProducts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation ListAllUploadRecords` | `New-RscQuery -Gql listAllUploadRecords` | [listAllUploadRecords](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation LockoutConfig` | `New-RscQuery -Gql lockoutConfig` | [lockoutConfig](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation MfaSetting` | `New-RscQuery -Gql mfaSetting` | [mfaSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation MicrosoftGroups` | `New-RscQuery -Gql microsoftGroups` | [microsoftGroups](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation MicrosoftSites` | `New-RscQuery -Gql microsoftSites` | [microsoftSites](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation MinimumCdmVersionForFeatureSet` | `New-RscQuery -Gql minimumCdmVersionForFeatureSet` | [minimumCdmVersionForFeatureSet](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation MipLabels` | `New-RscQuery -Gql allMipLabels` | [allMipLabels](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation MysqlDatabase` | `New-RscQuery -Gql mysqlDatabase` | [mysqlDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation MysqlDatabases` | `New-RscQuery -Gql mysqlDatabases` | [mysqlDatabases](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation MysqlInstance` | `New-RscQuery -Gql mysqlInstance` | [mysqlInstance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation MysqlInstanceLiveMounts` | `New-RscQuery -Gql mysqlInstanceLiveMounts` | [mysqlInstanceLiveMounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation MysqlInstances` | `New-RscQuery -Gql mysqlInstances` | [mysqlInstances](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation NetworkThrottle` | `New-RscQuery -Gql networkThrottle` | [networkThrottle](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation NfAnomalyResults` | `New-RscQuery -Gql nfAnomalyResults` | [nfAnomalyResults](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation NfAnomalyResultsGrouped` | `New-RscQuery -Gql nfAnomalyResultsGrouped` | [nfAnomalyResultsGrouped](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation NodeRemovalCancelPermission` | `New-RscQuery -Gql nodeRemovalCancelPermission` | [nodeRemovalCancelPermission](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation NodeToReplace` | `New-RscQuery -Gql nodeToReplace` | [nodeToReplace](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation NodeTunnelStatuses` | `New-RscQuery -Gql nodeTunnelStatuses` | [nodeTunnelStatuses](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation NosqlStorageLocations` | `New-RscQuery -Gql allNosqlStorageLocations` | [allNosqlStorageLocations](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation OauthCodesForEdgeReg` | `New-RscQuery -Gql oauthCodesForEdgeReg` | [oauthCodesForEdgeReg](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation ObjectFiles` | `New-RscQuery -Gql objectFiles` | [objectFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation ObjectTypeAccessSummary` | `New-RscQuery -Gql objectTypeAccessSummary` | [objectTypeAccessSummary](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation ObjectsAlreadyAssignedToOrgs` | `New-RscQuery -Gql allObjectsAlreadyAssignedToOrgs` | [allObjectsAlreadyAssignedToOrgs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation Org` | `New-RscQuery -Gql org` | [org](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation Orgs` | `New-RscQuery -Gql orgs` | [orgs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation OrgsByIds` | `New-RscQuery -Gql allOrgsByIds` | [allOrgsByIds](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation OrgsForPrincipal` | `New-RscQuery -Gql orgsForPrincipal` | [orgsForPrincipal](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation PasskeyConfig` | `New-RscQuery -Gql passkeyConfig` | [passkeyConfig](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation PasskeyInfo` | `New-RscQuery -Gql passkeyInfo` | [passkeyInfo](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation PendingAction` | `New-RscQuery -Gql pendingAction` | [pendingAction](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation PendingActions` | `New-RscQuery -Gql allPendingActions` | [allPendingActions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation PhoenixRolloutProgress` | `New-RscQuery -Gql phoenixRolloutProgress` | [phoenixRolloutProgress](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation PipelineHealthForTimeRange` | `New-RscQuery -Gql pipelineHealthForTimeRange` | [pipelineHealthForTimeRange](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation PolarisInventorySubHierarchyRoot` | `New-RscQuery -Gql polarisInventorySubHierarchyRoot` | [polarisInventorySubHierarchyRoot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation PolicyDetails` | `New-RscQuery -Gql policyDetails` | [policyDetails](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation PolicyObj` | `New-RscQuery -Gql policyObj` | [policyObj](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation PolicyObjs` | `New-RscQuery -Gql policyObjs` | [policyObjs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation PrechecksStatus` | `New-RscQuery -Gql prechecksStatus` | [prechecksStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation PrechecksStatusWithNextJobInfo` | `New-RscQuery -Gql prechecksStatusWithNextJobInfo` | [prechecksStatusWithNextJobInfo](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation PrivateContainerRegistry` | `New-RscQuery -Gql privateContainerRegistry` | [privateContainerRegistry](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation ProductDocumentation` | `New-RscQuery -Gql productDocumentation` | [productDocumentation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation ProtectedObjectsList` | `New-RscQuery -Gql protectedObjectsConnection` | [protectedObjectsConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation ProtectedVolumesCount` | `New-RscQuery -Gql protectedVolumesCount` | [protectedVolumesCount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation QuarantinedDetailsForWorkload` | `New-RscQuery -Gql allQuarantinedDetailsForWorkload` | [allQuarantinedDetailsForWorkload](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation QueryDatastoreFreespaceThresholds` | `New-RscQuery -Gql queryDatastoreFreespaceThresholds` | [queryDatastoreFreespaceThresholds](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation RemovedNodeDetails` | `New-RscQuery -Gql removedNodeDetails` | [removedNodeDetails](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation ResetTypeOfRemovalJob` | `New-RscQuery -Gql resetTypeOfRemovalJob` | [resetTypeOfRemovalJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation RoleTemplates` | `New-RscQuery -Gql roleTemplates` | [roleTemplates](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation RscPermsToCdmInfo` | `New-RscQuery -Gql rscPermsToCdmInfo` | [rscPermsToCdmInfo](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation SaasAppOrganizations` | `New-RscQuery -Gql saasAppOrganizations` | [saasAppOrganizations](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation SaasWorkloadMetadataTypes` | `New-RscQuery -Gql saasWorkloadMetadataTypes` | [saasWorkloadMetadataTypes](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation SalesforceObjects` | `New-RscQuery -Gql salesforceObjects` | [salesforceObjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation ScriptsForManualPermissionValidation` | `New-RscQuery -Gql scriptsForManualPermissionValidation` | [scriptsForManualPermissionValidation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation SearchFileByPrefix` | `New-RscQuery -Gql searchFileByPrefix` | [searchFileByPrefix](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation SelfServeRollingUpgrade` | `New-RscQuery -Gql selfServeRollingUpgrade` | [selfServeRollingUpgrade](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation SigninLogDetails` | `New-RscQuery -Gql signinLogDetails` | [signinLogDetails](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation SigninLogFilterValues` | `New-RscQuery -Gql signinLogFilterValues` | [signinLogFilterValues](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation SigninLogs` | `New-RscQuery -Gql signinLogs` | [signinLogs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation SnoozedDirectories` | `New-RscQuery -Gql snoozedDirectories` | [snoozedDirectories](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation SqlServerSetupScriptsBulk` | `New-RscQuery -Gql sqlServerSetupScriptsBulk` | [sqlServerSetupScriptsBulk](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation SsoGroupAlreadyExists` | `New-RscQuery -Gql ssoGroupAlreadyExists` | [ssoGroupAlreadyExists](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation StaticRoutes` | `New-RscQuery -Gql staticRoutes` | [staticRoutes](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation SupportBundle` | `New-RscQuery -Gql supportBundle` | [supportBundle](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation SupportUserAccesses` | `New-RscQuery -Gql supportUserAccesses` | [supportUserAccesses](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation TableFilters` | `New-RscQuery -Gql tableFilters` | [tableFilters](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation TaskDetailGroupByList` | `New-RscQuery -Gql taskDetailGroupByConnection` | [taskDetailGroupByConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation TaskDetailList` | `New-RscQuery -Gql taskDetailConnection` | [taskDetailConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation Taskchain` | `New-RscQuery -Gql taskchain` | [taskchain](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation TeamChannelNameAvailable` | `New-RscQuery -Gql teamChannelNameAvailable` | [teamChannelNameAvailable](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation TotpConfigStatus` | `New-RscQuery -Gql totpConfigStatus` | [totpConfigStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation TprConfiguration` | `New-RscQuery -Gql tprConfiguration` | [tprConfiguration](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation TprPublicConfiguration` | `New-RscQuery -Gql tprPublicConfiguration` | [tprPublicConfiguration](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation TprRequestDetail` | `New-RscQuery -Gql tprRequestDetail` | [tprRequestDetail](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation TprRequestSummaries` | `New-RscQuery -Gql tprRequestSummaries` | [tprRequestSummaries](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation TprRoleEligibility` | `New-RscQuery -Gql tprRoleEligibility` | [tprRoleEligibility](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation TprRulesMap` | `New-RscQuery -Gql tprRulesMap` | [tprRulesMap](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation TprStatusForNodeRemoval` | `New-RscQuery -Gql tprStatusForNodeRemoval` | [tprStatusForNodeRemoval](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation TunnelStatus` | `New-RscQuery -Gql tunnelStatus` | [tunnelStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation UniqueVcdCount` | `New-RscQuery -Gql uniqueVcdCount` | [uniqueVcdCount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation UnmanagedObjects` | `New-RscQuery -Gql unmanagedObjects` | [unmanagedObjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation UnmanagedObjectsSupportedTypes` | `New-RscQuery -Gql allUnmanagedObjectsSupportedTypes` | [allUnmanagedObjectsSupportedTypes](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation UpgradeStatus` | `New-RscQuery -Gql upgradeStatus` | [upgradeStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation UserActivities` | `New-RscQuery -Gql userActivities` | [userActivities](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation UserAlreadyExists` | `New-RscQuery -Gql userAlreadyExists` | [userAlreadyExists](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation UserAnalyzerAccess` | `New-RscQuery -Gql userAnalyzerAccess` | [userAnalyzerAccess](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation UserAuditList` | `New-RscQuery -Gql userAuditConnection` | [userAuditConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation UserDetail` | `New-RscQuery -Gql userDetail` | [userDetail](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation UserFile` | `New-RscQuery -Gql userFile` | [userFile](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation UserFiles` | `New-RscQuery -Gql allUserFiles` | [allUserFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation UserGroups` | `New-RscQuery -Gql userGroups` | [userGroups](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation UserNotifications` | `New-RscQuery -Gql userNotifications` | [userNotifications](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation UserSessionManagementConfig` | `New-RscQuery -Gql userSessionManagementConfig` | [userSessionManagementConfig](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation UserSettings` | `New-RscQuery -Gql userSettings` | [userSettings](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation UsersInCurrentAndDescendantOrganization` | `New-RscQuery -Gql usersInCurrentAndDescendantOrganization` | [usersInCurrentAndDescendantOrganization](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation UsersOnAccountList` | `New-RscQuery -Gql allUsersOnAccountConnection` | [allUsersOnAccountConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation ValidRegionsForDynamoDbRecovery` | `New-RscQuery -Gql allValidRegionsForDynamoDbRecovery` | [allValidRegionsForDynamoDbRecovery](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation ValidateAdForestTransition` | `New-RscQuery -Gql validateAdForestTransition` | [validateAdForestTransition](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation ValidateIocEntry` | `New-RscQuery -Gql validateIocEntry` | [validateIocEntry](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation ValidateOrgName` | `New-RscQuery -Gql validateOrgName` | [validateOrgName](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation ValidateRdsExportExocomputePort` | `New-RscQuery -Gql validateRdsExportExocomputePort` | [validateRdsExportExocomputePort](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation ValidateRoleName` | `New-RscQuery -Gql validateRoleName` | [validateRoleName](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation ValidateScriptOutputForManualPermissionValidation` | `New-RscQuery -Gql validateScriptOutputForManualPermissionValidation` | [validateScriptOutputForManualPermissionValidation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation VcdOrgs` | `New-RscQuery -Gql vcdOrgs` | [vcdOrgs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation VcdTopLevelDescendants` | `New-RscQuery -Gql vcdTopLevelDescendants` | [vcdTopLevelDescendants](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation VcdVappVms` | `New-RscQuery -Gql vcdVappVms` | [vcdVappVms](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation VcdVapps` | `New-RscQuery -Gql vcdVapps` | [vcdVapps](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation VerifyTotp` | `New-RscQuery -Gql verifyTotp` | [verifyTotp](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation VirtualMachineFiles` | `New-RscQuery -Gql allVirtualMachineFiles` | [allVirtualMachineFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation VmRecoveryJobsInfo` | `New-RscQuery -Gql allVmRecoveryJobsInfo` | [allVmRecoveryJobsInfo](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation VolumeGroupMounts` | `New-RscQuery -Gql volumeGroupMounts` | [volumeGroupMounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation WorkloadAlertSetting` | `New-RscQuery -Gql workloadAlertSetting` | [workloadAlertSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation WorkloadAnomalies` | `New-RscQuery -Gql workloadAnomalies` | [workloadAnomalies](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMisc -Operation WorkloadForeverId` | `New-RscQuery -Gql workloadForeverId` | [workloadForeverId](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationMisc -Operation AddAdGroupsToHierarchy` | `New-RscMutation -Gql addAdGroupsToHierarchy` | [addAdGroupsToHierarchy](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation AddCloudDirectKerberosCredential` | `New-RscMutation -Gql addCloudDirectKerberosCredential` | [addCloudDirectKerberosCredential](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation AddCloudDirectSharesToSystem` | `New-RscMutation -Gql addCloudDirectSharesToSystem` | [addCloudDirectSharesToSystem](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation AddCloudDirectSystem` | `New-RscMutation -Gql addCloudDirectSystem` | [addCloudDirectSystem](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation AddConfiguredGroupToHierarchy` | `New-RscMutation -Gql addConfiguredGroupToHierarchy` | [addConfiguredGroupToHierarchy](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation AddCustomIntelFeed` | `New-RscMutation -Gql addCustomIntelFeed` | [addCustomIntelFeed](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation AddIdentityProvider` | `New-RscMutation -Gql addIdentityProvider` | [addIdentityProvider](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation AddInventoryWorkloads` | `New-RscMutation -Gql addInventoryWorkloads` | [addInventoryWorkloads](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation AddIpWhitelistEntries` | `New-RscMutation -Gql addIpWhitelistEntries` | [addIpWhitelistEntries](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation AddMysqlInstance` | `New-RscMutation -Gql addMysqlInstance` | [addMysqlInstance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation AddRoleAssignments` | `New-RscMutation -Gql addRoleAssignments` | [addRoleAssignments](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation AddVlan` | `New-RscMutation -Gql addVlan` | [addVlan](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation AddVmAppConsistentSpecs` | `New-RscMutation -Gql addVmAppConsistentSpecs` | [addVmAppConsistentSpecs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation AirGapStatus` | `New-RscMutation -Gql airGapStatus` | [airGapStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation ApproveTprRequest` | `New-RscMutation -Gql approveTprRequest` | [approveTprRequest](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation ArchiveCrawl` | `New-RscMutation -Gql archiveCrawl` | [archiveCrawl](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation AssignProtection` | `New-RscMutation -Gql assignProtection` | [assignProtection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation BatchDeassignRoleFromUserGroups` | `New-RscMutation -Gql batchDeassignRoleFromUserGroups` | [batchDeassignRoleFromUserGroups](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation BatchQuarantineOperations` | `New-RscMutation -Gql batchQuarantineOperations` | [batchQuarantineOperations](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation BatchTriggerExocomputeHealthCheck` | `New-RscMutation -Gql batchTriggerExocomputeHealthCheck` | [batchTriggerExocomputeHealthCheck](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation BulkCreateNasFilesets` | `New-RscMutation -Gql bulkCreateNasFilesets` | [bulkCreateNasFilesets](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation BulkUpdateNasNamespaces` | `New-RscMutation -Gql bulkUpdateNasNamespaces` | [bulkUpdateNasNamespaces](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation BulkUpdateSystemConfig` | `New-RscMutation -Gql bulkUpdateSystemConfig` | [bulkUpdateSystemConfig](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation CancelDownloadPackage` | `New-RscMutation -Gql cancelDownloadPackage` | [cancelDownloadPackage](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation CancelScheduledUpgrade` | `New-RscMutation -Gql cancelScheduledUpgrade` | [cancelScheduledUpgrade](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation CancelTaskchain` | `New-RscMutation -Gql cancelTaskchain` | [cancelTaskchain](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation CancelTprRequest` | `New-RscMutation -Gql cancelTprRequest` | [cancelTprRequest](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation ChangeCurrentUserPassword` | `New-RscMutation -Gql changeCurrentUserPassword` | [changeCurrentUserPassword](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation ChangePassword` | `New-RscMutation -Gql changePassword` | [changePassword](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation CloudDirectAddSubdirBackup` | `New-RscMutation -Gql cloudDirectAddSubdirBackup` | [cloudDirectAddSubdirBackup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation CloudDirectSetKerberosEnforceConfig` | `New-RscMutation -Gql cloudDirectSetKerberosEnforceConfig` | [cloudDirectSetKerberosEnforceConfig](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation CloudDirectSetWanThrottleSettings` | `New-RscMutation -Gql cloudDirectSetWanThrottleSettings` | [cloudDirectSetWanThrottleSettings](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation CloudDirectSystemDelete` | `New-RscMutation -Gql cloudDirectSystemDelete` | [cloudDirectSystemDelete](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation CloudDirectSystemRescan` | `New-RscMutation -Gql cloudDirectSystemRescan` | [cloudDirectSystemRescan](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation CloudDirectValidateSubdir` | `New-RscMutation -Gql cloudDirectValidateSubdir` | [cloudDirectValidateSubdir](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation CompleteUploadSession` | `New-RscMutation -Gql completeUploadSession` | [completeUploadSession](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation ConfirmPartUpload` | `New-RscMutation -Gql confirmPartUpload` | [confirmPartUpload](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation CreateAutomatedRestoreMysqldbInstance` | `New-RscMutation -Gql createAutomatedRestoreMysqldbInstance` | [createAutomatedRestoreMysqldbInstance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation CreateCustomAnalyzer` | `New-RscMutation -Gql createCustomAnalyzer` | [createCustomAnalyzer](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation CreateDistributionListDigestBatch` | `New-RscMutation -Gql createDistributionListDigestBatch` | [createDistributionListDigestBatch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation CreateEventDigestBatch` | `New-RscMutation -Gql createEventDigestBatch` | [createEventDigestBatch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation CreateGuestCredential` | `New-RscMutation -Gql createGuestCredential` | [createGuestCredential](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation CreateLegalHold` | `New-RscMutation -Gql createLegalHold` | [createLegalHold](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation CreateOnDemandVolumeGroupBackup` | `New-RscMutation -Gql createOnDemandVolumeGroupBackup` | [createOnDemandVolumeGroupBackup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation CreateSsoUsers` | `New-RscMutation -Gql createSsoUsers` | [createSsoUsers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation CreateVappsInstantRecovery` | `New-RscMutation -Gql createVappsInstantRecovery` | [createVappsInstantRecovery](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation DeactivateCustomAnalyzer` | `New-RscMutation -Gql deactivateCustomAnalyzer` | [deactivateCustomAnalyzer](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation DeleteAdGroupsFromHierarchy` | `New-RscMutation -Gql deleteAdGroupsFromHierarchy` | [deleteAdGroupsFromHierarchy](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation DeleteCephSetting` | `New-RscMutation -Gql deleteCephSetting` | [deleteCephSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation DeleteCloudDirectKerberosCredential` | `New-RscMutation -Gql deleteCloudDirectKerberosCredential` | [deleteCloudDirectKerberosCredential](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation DeleteDistributionListDigestBatch` | `New-RscMutation -Gql deleteDistributionListDigestBatch` | [deleteDistributionListDigestBatch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation DeleteEventDigest` | `New-RscMutation -Gql deleteEventDigest` | [deleteEventDigest](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation DeleteGuestCredentialById` | `New-RscMutation -Gql deleteGuestCredentialById` | [deleteGuestCredentialById](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation DeleteIdentityProviderById` | `New-RscMutation -Gql deleteIdentityProviderById` | [deleteIdentityProviderById](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation DeleteIntelFeed` | `New-RscMutation -Gql deleteIntelFeed` | [deleteIntelFeed](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation DeleteIpWhitelistEntries` | `New-RscMutation -Gql deleteIpWhitelistEntries` | [deleteIpWhitelistEntries](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation DeleteMysqlInstance` | `New-RscMutation -Gql deleteMysqlInstance` | [deleteMysqlInstance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation DeleteMysqldbInstanceLiveMount` | `New-RscMutation -Gql deleteMysqldbInstanceLiveMount` | [deleteMysqldbInstanceLiveMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation DeleteVolumeGroupMount` | `New-RscMutation -Gql deleteVolumeGroupMount` | [deleteVolumeGroupMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation DenyTprRequests` | `New-RscMutation -Gql denyTprRequests` | [denyTprRequests](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation DeregisterPrivateContainerRegistry` | `New-RscMutation -Gql deregisterPrivateContainerRegistry` | [deregisterPrivateContainerRegistry](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation DisableSupportUserAccess` | `New-RscMutation -Gql disableSupportUserAccess` | [disableSupportUserAccess](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation DisableTprOrg` | `New-RscMutation -Gql disableTprOrg` | [disableTprOrg](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation DissolveLegalHold` | `New-RscMutation -Gql dissolveLegalHold` | [dissolveLegalHold](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation EnableAutomaticFmdUpload` | `New-RscMutation -Gql enableAutomaticFmdUpload` | [enableAutomaticFmdUpload](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation EnableDisableAppConsistency` | `New-RscMutation -Gql enableDisableAppConsistency` | [enableDisableAppConsistency](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation EnableSupportUserAccess` | `New-RscMutation -Gql enableSupportUserAccess` | [enableSupportUserAccess](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation EnableTprOrg` | `New-RscMutation -Gql enableTprOrg` | [enableTprOrg](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation ExcludeVmDisks` | `New-RscMutation -Gql excludeVmDisks` | [excludeVmDisks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation ExecuteTprRequests` | `New-RscMutation -Gql executeTprRequests` | [executeTprRequests](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation ExpireSnoozedDirectories` | `New-RscMutation -Gql expireSnoozedDirectories` | [expireSnoozedDirectories](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation GenerateConfigProtectionRestoreForm` | `New-RscMutation -Gql generateConfigProtectionRestoreForm` | [generateConfigProtectionRestoreForm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation GeneratePresignedUrlForDownload` | `New-RscMutation -Gql generatePresignedUrlForDownload` | [generatePresignedUrlForDownload](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation GeneratePresignedUrlForPartUpload` | `New-RscMutation -Gql generatePresignedUrlForPartUpload` | [generatePresignedUrlForPartUpload](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation GenerateSupportBundle` | `New-RscMutation -Gql generateSupportBundle` | [generateSupportBundle](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation GetDownloadUrl` | `New-RscMutation -Gql getDownloadUrl` | [getDownloadUrl](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation HideRevealNasNamespaces` | `New-RscMutation -Gql hideRevealNasNamespaces` | [hideRevealNasNamespaces](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation InitializeUploadSession` | `New-RscMutation -Gql initializeUploadSession` | [initializeUploadSession](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation InstallIoFilter` | `New-RscMutation -Gql installIoFilter` | [installIoFilter](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation InviteSsoGroup` | `New-RscMutation -Gql inviteSsoGroup` | [inviteSsoGroup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation LinuxRbsBulkInstall` | `New-RscMutation -Gql linuxRbsBulkInstall` | [linuxRbsBulkInstall](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation ListCidrsForComputeSetting` | `New-RscMutation -Gql listCidrsForComputeSetting` | [listCidrsForComputeSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation LockCyberRecovery` | `New-RscMutation -Gql lockCyberRecovery` | [lockCyberRecovery](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation LockUsersByAdmin` | `New-RscMutation -Gql lockUsersByAdmin` | [lockUsersByAdmin](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation LogoutFromRubrikSupportPortal` | `New-RscMutation -Gql logoutFromRubrikSupportPortal` | [logoutFromRubrikSupportPortal](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation MakePrimary` | `New-RscMutation -Gql makePrimary` | [makePrimary](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation ManageProtectionForLinkedObjects` | `New-RscMutation -Gql manageProtectionForLinkedObjects` | [manageProtectionForLinkedObjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation MigrateVmDataStore` | `New-RscMutation -Gql migrateVmDataStore` | [migrateVmDataStore](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation ModifyDistributionListDigestBatch` | `New-RscMutation -Gql modifyDistributionListDigestBatch` | [modifyDistributionListDigestBatch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation ModifyEventDigestBatch` | `New-RscMutation -Gql modifyEventDigestBatch` | [modifyEventDigestBatch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation ModifyIdentityProvider` | `New-RscMutation -Gql modifyIdentityProvider` | [modifyIdentityProvider](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation ModifyIpmi` | `New-RscMutation -Gql modifyIpmi` | [modifyIpmi](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation MountDisk` | `New-RscMutation -Gql mountDisk` | [mountDisk](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation NotificationForGetLicense` | `New-RscMutation -Gql notificationForGetLicense` | [notificationForGetLicense](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation PatchMysqlInstance` | `New-RscMutation -Gql patchMysqlInstance` | [patchMysqlInstance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation PitRestoreMysqlInstance` | `New-RscMutation -Gql pitRestoreMysqlInstance` | [pitRestoreMysqlInstance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation ProvisionCloudDirectCloudVm` | `New-RscMutation -Gql provisionCloudDirectCloudVm` | [provisionCloudDirectCloudVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation RecoverCloudDirectMultiPaths` | `New-RscMutation -Gql recoverCloudDirectMultiPaths` | [recoverCloudDirectMultiPaths](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation RecoverCloudDirectNasShare` | `New-RscMutation -Gql recoverCloudDirectNasShare` | [recoverCloudDirectNasShare](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation RecoverCloudDirectPath` | `New-RscMutation -Gql recoverCloudDirectPath` | [recoverCloudDirectPath](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation RefreshDomain` | `New-RscMutation -Gql refreshDomain` | [refreshDomain](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation RefreshGlobalManagerConnectivityStatus` | `New-RscMutation -Gql refreshGlobalManagerConnectivityStatus` | [refreshGlobalManagerConnectivityStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation RefreshMysqlInstance` | `New-RscMutation -Gql refreshMysqlInstance` | [refreshMysqlInstance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation RemoveDisk` | `New-RscMutation -Gql removeDisk` | [removeDisk](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation RemoveInventoryWorkloads` | `New-RscMutation -Gql removeInventoryWorkloads` | [removeInventoryWorkloads](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation RemoveNodeForReplacement` | `New-RscMutation -Gql removeNodeForReplacement` | [removeNodeForReplacement](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation RemovePrivateEndpointList` | `New-RscMutation -Gql removePrivateEndpointConnection` | [removePrivateEndpointConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation RemoveProxyConfig` | `New-RscMutation -Gql removeProxyConfig` | [removeProxyConfig](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation RemoveUploadRecord` | `New-RscMutation -Gql removeUploadRecord` | [removeUploadRecord](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation RemoveVlans` | `New-RscMutation -Gql removeVlans` | [removeVlans](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation ReseedLogShippingSecondary` | `New-RscMutation -Gql reseedLogShippingSecondary` | [reseedLogShippingSecondary](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation ResetAllOrgUsersPasswords` | `New-RscMutation -Gql resetAllOrgUsersPasswords` | [resetAllOrgUsersPasswords](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation ResetUsersPasswordsWithUserIds` | `New-RscMutation -Gql resetUsersPasswordsWithUserIds` | [resetUsersPasswordsWithUserIds](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation ResizeDisk` | `New-RscMutation -Gql resizeDisk` | [resizeDisk](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation ResolveAnomaly` | `New-RscMutation -Gql resolveAnomaly` | [resolveAnomaly](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation ResolveVolumeGroupsConflict` | `New-RscMutation -Gql resolveVolumeGroupsConflict` | [resolveVolumeGroupsConflict](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation RetryBackup` | `New-RscMutation -Gql retryBackup` | [retryBackup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation RetryDownloadPackageJob` | `New-RscMutation -Gql retryDownloadPackageJob` | [retryDownloadPackageJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation RevokeAllOrgRoles` | `New-RscMutation -Gql revokeAllOrgRoles` | [revokeAllOrgRoles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation RunCustomAnalyzer` | `New-RscMutation -Gql runCustomAnalyzer` | [runCustomAnalyzer](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation ScheduleUpgradeBatchJob` | `New-RscMutation -Gql scheduleUpgradeBatchJob` | [scheduleUpgradeBatchJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation SetAnalyzerRisks` | `New-RscMutation -Gql setAnalyzerRisks` | [setAnalyzerRisks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation SetBundleApprovalStatus` | `New-RscMutation -Gql setBundleApprovalStatus` | [setBundleApprovalStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation SetCephSettings` | `New-RscMutation -Gql setCephSettings` | [setCephSettings](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation SetCloudDirectNamespaceOverride` | `New-RscMutation -Gql setCloudDirectNamespaceOverride` | [setCloudDirectNamespaceOverride](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation SetCloudDirectShareExclusions` | `New-RscMutation -Gql setCloudDirectShareExclusions` | [setCloudDirectShareExclusions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation SetCloudDirectSystemOverride` | `New-RscMutation -Gql setCloudDirectSystemOverride` | [setCloudDirectSystemOverride](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation SetCustomerTags` | `New-RscMutation -Gql setCustomerTags` | [setCustomerTags](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation SetDatastoreFreespaceThresholds` | `New-RscMutation -Gql setDatastoreFreespaceThresholds` | [setDatastoreFreespaceThresholds](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation SetIpWhitelistEnabled` | `New-RscMutation -Gql setIpWhitelistEnabled` | [setIpWhitelistEnabled](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation SetIpWhitelistSetting` | `New-RscMutation -Gql setIpWhitelistSetting` | [setIpWhitelistSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation SetMfaSetting` | `New-RscMutation -Gql setMfaSetting` | [setMfaSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation SetPrivateContainerRegistry` | `New-RscMutation -Gql setPrivateContainerRegistry` | [setPrivateContainerRegistry](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation SetSelfServeRollingUpgrade` | `New-RscMutation -Gql setSelfServeRollingUpgrade` | [setSelfServeRollingUpgrade](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation SetTotpConfig` | `New-RscMutation -Gql setTotpConfig` | [setTotpConfig](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation SetUpgradeType` | `New-RscMutation -Gql setUpgradeType` | [setUpgradeType](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation SetUserLevelTotpEnforcement` | `New-RscMutation -Gql setUserLevelTotpEnforcement` | [setUserLevelTotpEnforcement](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation SetUserSessionManagementConfig` | `New-RscMutation -Gql setUserSessionManagementConfig` | [setUserSessionManagementConfig](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation SetWorkloadAlertSetting` | `New-RscMutation -Gql setWorkloadAlertSetting` | [setWorkloadAlertSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation SetupDisk` | `New-RscMutation -Gql setupDisk` | [setupDisk](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation StartCrawl` | `New-RscMutation -Gql startCrawl` | [startCrawl](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation StartDownloadPackageBatchJob` | `New-RscMutation -Gql startDownloadPackageBatchJob` | [startDownloadPackageBatchJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation StartExportRdsInstanceJob` | `New-RscMutation -Gql startExportRdsInstanceJob` | [startExportRdsInstanceJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation StartPeriodicUpgradePrechecksOnDemandJob` | `New-RscMutation -Gql startPeriodicUpgradePrechecksOnDemandJob` | [startPeriodicUpgradePrechecksOnDemandJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation StartUpgradeBatchJob` | `New-RscMutation -Gql startUpgradeBatchJob` | [startUpgradeBatchJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation StartVolumeGroupMount` | `New-RscMutation -Gql startVolumeGroupMount` | [startVolumeGroupMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation StopJobInstance` | `New-RscMutation -Gql stopJobInstance` | [stopJobInstance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation StopJobInstanceFromEventSeries` | `New-RscMutation -Gql stopJobInstanceFromEventSeries` | [stopJobInstanceFromEventSeries](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation SubmitTprRequest` | `New-RscMutation -Gql submitTprRequest` | [submitTprRequest](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation SupportPortalLogin` | `New-RscMutation -Gql supportPortalLogin` | [supportPortalLogin](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation SwitchProductToOnboardingMode` | `New-RscMutation -Gql switchProductToOnboardingMode` | [switchProductToOnboardingMode](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation TriggerBliMigration` | `New-RscMutation -Gql triggerBliMigration` | [triggerBliMigration](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation TriggerCloudComputeConnectivityCheck` | `New-RscMutation -Gql triggerCloudComputeConnectivityCheck` | [triggerCloudComputeConnectivityCheck](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation TriggerExocomputeHealthCheck` | `New-RscMutation -Gql triggerExocomputeHealthCheck` | [triggerExocomputeHealthCheck](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UninstallIoFilter` | `New-RscMutation -Gql uninstallIoFilter` | [uninstallIoFilter](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UnlockUsersByAdmin` | `New-RscMutation -Gql unlockUsersByAdmin` | [unlockUsersByAdmin](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UnmountDisk` | `New-RscMutation -Gql unmountDisk` | [unmountDisk](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UpdateAccountOwner` | `New-RscMutation -Gql updateAccountOwner` | [updateAccountOwner](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UpdateAdGroup` | `New-RscMutation -Gql updateAdGroup` | [updateAdGroup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UpdateAgentDeploymentSetting` | `New-RscMutation -Gql updateAgentDeploymentSetting` | [updateAgentDeploymentSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UpdateAgentDeploymentSettingInBatch` | `New-RscMutation -Gql updateAgentDeploymentSettingInBatch` | [updateAgentDeploymentSettingInBatch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UpdateAgentDeploymentSettingInBatchNew` | `New-RscMutation -Gql updateAgentDeploymentSettingInBatchNew` | [updateAgentDeploymentSettingInBatchNew](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UpdateAuthDomainUsersHiddenStatus` | `New-RscMutation -Gql updateAuthDomainUsersHiddenStatus` | [updateAuthDomainUsersHiddenStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UpdateBackupThrottleSetting` | `New-RscMutation -Gql updateBackupThrottleSetting` | [updateBackupThrottleSetting](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UpdateBackupTriggerForWorkloads` | `New-RscMutation -Gql updateBackupTriggerForWorkloads` | [updateBackupTriggerForWorkloads](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UpdateBadDiskLedStatus` | `New-RscMutation -Gql updateBadDiskLedStatus` | [updateBadDiskLedStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UpdateCloudDirectKerberosCredential` | `New-RscMutation -Gql updateCloudDirectKerberosCredential` | [updateCloudDirectKerberosCredential](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UpdateConfiguredGroup` | `New-RscMutation -Gql updateConfiguredGroup` | [updateConfiguredGroup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UpdateCustomAnalyzer` | `New-RscMutation -Gql updateCustomAnalyzer` | [updateCustomAnalyzer](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UpdateCustomIntelFeed` | `New-RscMutation -Gql updateCustomIntelFeed` | [updateCustomIntelFeed](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UpdateCustomerAppPermissions` | `New-RscMutation -Gql updateCustomerAppPermissions` | [updateCustomerAppPermissions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UpdateDistributionListDigest` | `New-RscMutation -Gql updateDistributionListDigest` | [updateDistributionListDigest](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UpdateDnsServersAndSearchDomains` | `New-RscMutation -Gql updateDnsServersAndSearchDomains` | [updateDnsServersAndSearchDomains](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UpdateEventDigest` | `New-RscMutation -Gql updateEventDigest` | [updateEventDigest](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UpdateFeed` | `New-RscMutation -Gql updateFeed` | [updateFeed](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UpdateFloatingIps` | `New-RscMutation -Gql updateFloatingIps` | [updateFloatingIps](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UpdateGuestCredential` | `New-RscMutation -Gql updateGuestCredential` | [updateGuestCredential](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UpdateInsightState` | `New-RscMutation -Gql updateInsightState` | [updateInsightState](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UpdateIocStatus` | `New-RscMutation -Gql updateIocStatus` | [updateIocStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UpdateIpWhitelist` | `New-RscMutation -Gql updateIpWhitelist` | [updateIpWhitelist](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UpdateIpWhitelistEntry` | `New-RscMutation -Gql updateIpWhitelistEntry` | [updateIpWhitelistEntry](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UpdateLambdaSettings` | `New-RscMutation -Gql updateLambdaSettings` | [updateLambdaSettings](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UpdateLockoutConfig` | `New-RscMutation -Gql updateLockoutConfig` | [updateLockoutConfig](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UpdateManagedIdentities` | `New-RscMutation -Gql updateManagedIdentities` | [updateManagedIdentities](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UpdateManagedIdentitiesAsync` | `New-RscMutation -Gql updateManagedIdentitiesAsync` | [updateManagedIdentitiesAsync](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UpdateNetworkThrottle` | `New-RscMutation -Gql updateNetworkThrottle` | [updateNetworkThrottle](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UpdateProxmoxEnvironment` | `New-RscMutation -Gql updateProxmoxEnvironment` | [updateProxmoxEnvironment](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UpdateProxyConfig` | `New-RscMutation -Gql updateProxyConfig` | [updateProxyConfig](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UpdateRoleAssignments` | `New-RscMutation -Gql updateRoleAssignments` | [updateRoleAssignments](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UpdateSupportUserAccess` | `New-RscMutation -Gql updateSupportUserAccess` | [updateSupportUserAccess](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UpdateTprConfiguration` | `New-RscMutation -Gql updateTprConfiguration` | [updateTprConfiguration](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UpdateTunnelStatus` | `New-RscMutation -Gql updateTunnelStatus` | [updateTunnelStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UpdateVlan` | `New-RscMutation -Gql updateVlan` | [updateVlan](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UpdateVolumeGroup` | `New-RscMutation -Gql updateVolumeGroup` | [updateVolumeGroup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UpdateWhitelistedAnalyzers` | `New-RscMutation -Gql updateWhitelistedAnalyzers` | [updateWhitelistedAnalyzers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UpgradeIoFilter` | `New-RscMutation -Gql upgradeIoFilter` | [upgradeIoFilter](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation UpgradeToRsc` | `New-RscMutation -Gql upgradeToRsc` | [upgradeToRsc](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation ValidateAndSaveCustomerKmsInfo` | `New-RscMutation -Gql validateAndSaveCustomerKmsInfo` | [validateAndSaveCustomerKmsInfo](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation VmMakePrimary` | `New-RscMutation -Gql vmMakePrimary` | [vmMakePrimary](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation WarmSearchCache` | `New-RscMutation -Gql warmSearchCache` | [warmSearchCache](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMisc -Operation WindowsRbsBulkInstall` | `New-RscMutation -Gql windowsRbsBulkInstall` | [windowsRbsBulkInstall](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Mongo domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryMongo -Operation BulkRecoverableRanges` | `New-RscQuery -Gql mongoBulkRecoverableRanges` | [mongoBulkRecoverableRanges](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMongo -Operation Collection` | `New-RscQuery -Gql mongoCollection` | [mongoCollection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMongo -Operation Collections` | `New-RscQuery -Gql mongoCollections` | [mongoCollections](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMongo -Operation Database` | `New-RscQuery -Gql mongoDatabase` | [mongoDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMongo -Operation Databases` | `New-RscQuery -Gql mongoDatabases` | [mongoDatabases](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMongo -Operation GetMissedCollectionSetSnapshots` | `New-RscQuery -Gql getMissedMongoCollectionSetSnapshots` | [getMissedMongoCollectionSetSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMongo -Operation GetMissedOpsManagerManagedSourceSnapshots` | `New-RscQuery -Gql getMissedOpsManagerManagedMongoSourceSnapshots` | [getMissedOpsManagerManagedMongoSourceSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMongo -Operation RecoverableRanges` | `New-RscQuery -Gql mongoRecoverableRanges` | [mongoRecoverableRanges](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMongo -Operation RestoreTargetsForSnapshot` | `New-RscQuery -Gql mongoRestoreTargetsForSnapshot` | [mongoRestoreTargetsForSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMongo -Operation Source` | `New-RscQuery -Gql mongoSource` | [mongoSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMongo -Operation Sources` | `New-RscQuery -Gql mongoSources` | [mongoSources](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationMongo -Operation AddOpsManagerManagedSource` | `New-RscMutation -Gql addOpsManagerManagedMongoSource` | [addOpsManagerManagedMongoSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMongo -Operation AddSource` | `New-RscMutation -Gql addMongoSource` | [addMongoSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMongo -Operation CreateOnDemandDatabaseBackup` | `New-RscMutation -Gql createOnDemandMongoDatabaseBackup` | [createOnDemandMongoDatabaseBackup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMongo -Operation CreateOnDemandDatabaseBackupV2` | `New-RscMutation -Gql createOnDemandMongoDatabaseBackupV2` | [createOnDemandMongoDatabaseBackupV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMongo -Operation CreateOpsManagerManagedSourceOnDemandSnapshot` | `New-RscMutation -Gql createOpsManagerManagedMongoSourceOnDemandSnapshot` | [createOpsManagerManagedMongoSourceOnDemandSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMongo -Operation DeleteSource` | `New-RscMutation -Gql deleteMongoSource` | [deleteMongoSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMongo -Operation DiscoverSource` | `New-RscMutation -Gql discoverMongoSource` | [discoverMongoSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMongo -Operation PatchOpsManagerManagedSource` | `New-RscMutation -Gql patchOpsManagerManagedMongoSource` | [patchOpsManagerManagedMongoSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMongo -Operation PatchSource` | `New-RscMutation -Gql patchMongoSource` | [patchMongoSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMongo -Operation RecoverOpsManagerManagedSource` | `New-RscMutation -Gql recoverOpsManagerManagedMongoSource` | [recoverOpsManagerManagedMongoSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMongo -Operation RecoverSource` | `New-RscMutation -Gql recoverMongoSource` | [recoverMongoSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMongo -Operation RetryAddOpsManagerManagedSource` | `New-RscMutation -Gql retryAddOpsManagerManagedMongoSource` | [retryAddOpsManagerManagedMongoSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMongo -Operation RetryAddSource` | `New-RscMutation -Gql retryAddMongoSource` | [retryAddMongoSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Mongo DB domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryMongoDb -Operation BulkRecoverableRange` | `New-RscQuery -Gql mongodbBulkRecoverableRange` | [mongodbBulkRecoverableRange](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMongoDb -Operation Collection` | `New-RscQuery -Gql mongodbCollection` | [mongodbCollection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMongoDb -Operation CollectionRecoverableRange` | `New-RscQuery -Gql mongodbCollectionRecoverableRange` | [mongodbCollectionRecoverableRange](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMongoDb -Operation Collections` | `New-RscQuery -Gql mongodbCollections` | [mongodbCollections](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMongoDb -Operation Database` | `New-RscQuery -Gql mongodbDatabase` | [mongodbDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMongoDb -Operation Databases` | `New-RscQuery -Gql mongodbDatabases` | [mongodbDatabases](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMongoDb -Operation Source` | `New-RscQuery -Gql mongodbSource` | [mongodbSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMongoDb -Operation Sources` | `New-RscQuery -Gql mongodbSources` | [mongodbSources](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationMongoDb -Operation AssignSlaToCollection` | `New-RscMutation -Gql assignSlaToMongoDbCollection` | [assignSlaToMongoDbCollection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMongoDb -Operation BulkDeleteSources` | `New-RscMutation -Gql bulkDeleteMongodbSources` | [bulkDeleteMongodbSources](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMongoDb -Operation CreateSource` | `New-RscMutation -Gql createMongodbSource` | [createMongodbSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMongoDb -Operation DeleteSource` | `New-RscMutation -Gql deleteMongodbSource` | [deleteMongodbSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMongoDb -Operation RecoverSource` | `New-RscMutation -Gql recoverMongodbSource` | [recoverMongodbSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMongoDb -Operation UpdateSource` | `New-RscMutation -Gql updateMongodbSource` | [updateMongodbSource](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Mosaic domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryMosaic -Operation BulkRecoveryRange` | `New-RscQuery -Gql mosaicBulkRecoveryRange` | [mosaicBulkRecoveryRange](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMosaic -Operation Snapshots` | `New-RscQuery -Gql mosaicSnapshots` | [mosaicSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMosaic -Operation Stores` | `New-RscQuery -Gql mosaicStores` | [mosaicStores](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMosaic -Operation Versions` | `New-RscQuery -Gql mosaicVersions` | [mosaicVersions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationMosaic -Operation AddStore` | `New-RscMutation -Gql addMosaicStore` | [addMosaicStore](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMosaic -Operation DeleteStore` | `New-RscMutation -Gql deleteMosaicStore` | [deleteMosaicStore](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMosaic -Operation UpdateStore` | `New-RscMutation -Gql updateMosaicStore` | [updateMosaicStore](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Microsoft SQL Server domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryMssql -Operation AvailabilityGroup` | `New-RscQuery -Gql mssqlAvailabilityGroup` | [mssqlAvailabilityGroup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMssql -Operation AvailabilityGroupDatabaseVirtualGroups` | `New-RscQuery -Gql mssqlAvailabilityGroupDatabaseVirtualGroups` | [mssqlAvailabilityGroupDatabaseVirtualGroups](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMssql -Operation AvailabilityGroupVirtualGroups` | `New-RscQuery -Gql mssqlAvailabilityGroupVirtualGroups` | [mssqlAvailabilityGroupVirtualGroups](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMssql -Operation CdmLogShippingTarget` | `New-RscQuery -Gql cdmMssqlLogShippingTarget` | [cdmMssqlLogShippingTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMssql -Operation CdmLogShippingTargets` | `New-RscQuery -Gql cdmMssqlLogShippingTargets` | [cdmMssqlLogShippingTargets](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMssql -Operation CompatibleInstances` | `New-RscQuery -Gql mssqlCompatibleInstances` | [mssqlCompatibleInstances](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMssql -Operation Database` | `New-RscQuery -Gql mssqlDatabase` | [mssqlDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMssql -Operation DatabaseLiveMounts` | `New-RscQuery -Gql mssqlDatabaseLiveMounts` | [mssqlDatabaseLiveMounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMssql -Operation DatabaseMissedRecoverableRanges` | `New-RscQuery -Gql mssqlDatabaseMissedRecoverableRanges` | [mssqlDatabaseMissedRecoverableRanges](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMssql -Operation DatabaseMissedSnapshots` | `New-RscQuery -Gql mssqlDatabaseMissedSnapshots` | [mssqlDatabaseMissedSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMssql -Operation DatabaseRestoreEstimate` | `New-RscQuery -Gql mssqlDatabaseRestoreEstimate` | [mssqlDatabaseRestoreEstimate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMssql -Operation DatabaseRestoreFiles` | `New-RscQuery -Gql allMssqlDatabaseRestoreFiles` | [allMssqlDatabaseRestoreFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMssql -Operation Databases` | `New-RscQuery -Gql mssqlDatabases` | [mssqlDatabases](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMssql -Operation DefaultProperties` | `New-RscQuery -Gql mssqlDefaultProperties` | [mssqlDefaultProperties](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMssql -Operation DefaultPropertiesOnCluster` | `New-RscQuery -Gql mssqlDefaultPropertiesOnCluster` | [mssqlDefaultPropertiesOnCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMssql -Operation Instance` | `New-RscQuery -Gql mssqlInstance` | [mssqlInstance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMssql -Operation JobStatus` | `New-RscQuery -Gql mssqlJobStatus` | [mssqlJobStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMssql -Operation LogShippingTargets` | `New-RscQuery -Gql mssqlLogShippingTargets` | [mssqlLogShippingTargets](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMssql -Operation RecoverableRanges` | `New-RscQuery -Gql mssqlRecoverableRanges` | [mssqlRecoverableRanges](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryMssql -Operation TopLevelDescendants` | `New-RscQuery -Gql mssqlTopLevelDescendants` | [mssqlTopLevelDescendants](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationMssql -Operation AddHost` | `New-RscMutation -Gql addMssqlHost` | [addMssqlHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMssql -Operation AssignSlaDomainProperties` | `New-RscMutation -Gql assignMssqlSlaDomainProperties` | [assignMssqlSlaDomainProperties](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMssql -Operation AssignSlaDomainPropertiesAsync` | `New-RscMutation -Gql assignMssqlSlaDomainPropertiesAsync` | [assignMssqlSlaDomainPropertiesAsync](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMssql -Operation BrowseDatabaseSnapshot` | `New-RscMutation -Gql browseMssqlDatabaseSnapshot` | [browseMssqlDatabaseSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMssql -Operation BulkCreateOnDemandBackup` | `New-RscMutation -Gql bulkCreateOnDemandMssqlBackup` | [bulkCreateOnDemandMssqlBackup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMssql -Operation BulkExportDatabases` | `New-RscMutation -Gql bulkExportMssqlDatabases` | [bulkExportMssqlDatabases](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMssql -Operation BulkUpdateAvailabilityGroup` | `New-RscMutation -Gql bulkUpdateMssqlAvailabilityGroup` | [bulkUpdateMssqlAvailabilityGroup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMssql -Operation BulkUpdateDbs` | `New-RscMutation -Gql bulkUpdateMssqlDbs` | [bulkUpdateMssqlDbs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMssql -Operation BulkUpdateInstance` | `New-RscMutation -Gql bulkUpdateMssqlInstance` | [bulkUpdateMssqlInstance](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMssql -Operation BulkUpdatePropertiesOnHost` | `New-RscMutation -Gql bulkUpdateMssqlPropertiesOnHost` | [bulkUpdateMssqlPropertiesOnHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMssql -Operation BulkUpdatePropertiesOnWindowsCluster` | `New-RscMutation -Gql bulkUpdateMssqlPropertiesOnWindowsCluster` | [bulkUpdateMssqlPropertiesOnWindowsCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMssql -Operation CreateLiveMount` | `New-RscMutation -Gql createMssqlLiveMount` | [createMssqlLiveMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMssql -Operation CreateLogShippingConfiguration` | `New-RscMutation -Gql createMssqlLogShippingConfiguration` | [createMssqlLogShippingConfiguration](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMssql -Operation CreateOnDemandBackup` | `New-RscMutation -Gql createOnDemandMssqlBackup` | [createOnDemandMssqlBackup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMssql -Operation DeleteDbSnapshots` | `New-RscMutation -Gql deleteMssqlDbSnapshots` | [deleteMssqlDbSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMssql -Operation DeleteLiveMount` | `New-RscMutation -Gql deleteMssqlLiveMount` | [deleteMssqlLiveMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMssql -Operation DeleteLogShipping` | `New-RscMutation -Gql deleteLogShipping` | [deleteLogShipping](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMssql -Operation DownloadDatabaseBackupFiles` | `New-RscMutation -Gql downloadMssqlDatabaseBackupFiles` | [downloadMssqlDatabaseBackupFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMssql -Operation DownloadDatabaseFilesFromArchivalLocation` | `New-RscMutation -Gql downloadMssqlDatabaseFilesFromArchivalLocation` | [downloadMssqlDatabaseFilesFromArchivalLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMssql -Operation ExportDatabase` | `New-RscMutation -Gql exportMssqlDatabase` | [exportMssqlDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMssql -Operation RestoreDatabase` | `New-RscMutation -Gql restoreMssqlDatabase` | [restoreMssqlDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMssql -Operation TakeLogBackup` | `New-RscMutation -Gql takeMssqlLogBackup` | [takeMssqlLogBackup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMssql -Operation UpdateDefaultProperties` | `New-RscMutation -Gql updateMssqlDefaultProperties` | [updateMssqlDefaultProperties](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMssql -Operation UpdateLogShippingConfiguration` | `New-RscMutation -Gql updateMssqlLogShippingConfiguration` | [updateMssqlLogShippingConfiguration](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationMssql -Operation UpdateLogShippingConfigurationV1` | `New-RscMutation -Gql updateMssqlLogShippingConfigurationV1` | [updateMssqlLogShippingConfigurationV1](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## NAS domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryNas -Operation CloudDirectNasShares` | `New-RscQuery -Gql cloudDirectNasShares` | [cloudDirectNasShares](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryNas -Operation CloudDirectNasSystem` | `New-RscQuery -Gql cloudDirectNasSystem` | [cloudDirectNasSystem](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryNas -Operation CloudDirectNasSystems` | `New-RscQuery -Gql cloudDirectNasSystems` | [cloudDirectNasSystems](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryNas -Operation Fileset` | `New-RscQuery -Gql nasFileset` | [nasFileset](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryNas -Operation Namespace` | `New-RscQuery -Gql nasNamespace` | [nasNamespace](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryNas -Operation Namespaces` | `New-RscQuery -Gql nasNamespaces` | [nasNamespaces](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryNas -Operation Share` | `New-RscQuery -Gql nasShare` | [nasShare](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryNas -Operation Shares` | `New-RscQuery -Gql nasShares` | [nasShares](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryNas -Operation System` | `New-RscQuery -Gql nasSystem` | [nasSystem](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryNas -Operation Systems` | `New-RscQuery -Gql nasSystems` | [nasSystems](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryNas -Operation TopLevelDescendants` | `New-RscQuery -Gql nasTopLevelDescendants` | [nasTopLevelDescendants](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryNas -Operation Volume` | `New-RscQuery -Gql nasVolume` | [nasVolume](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationNas -Operation BulkAddNasShares` | `New-RscMutation -Gql bulkAddNasShares` | [bulkAddNasShares](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationNas -Operation BulkDeleteNasShares` | `New-RscMutation -Gql bulkDeleteNasShares` | [bulkDeleteNasShares](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationNas -Operation BulkDeleteNasSystems` | `New-RscMutation -Gql bulkDeleteNasSystems` | [bulkDeleteNasSystems](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationNas -Operation BulkUpdateNasShares` | `New-RscMutation -Gql bulkUpdateNasShares` | [bulkUpdateNasShares](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationNas -Operation DeleteNasSystem` | `New-RscMutation -Gql deleteNasSystem` | [deleteNasSystem](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationNas -Operation HideRevealNasShares` | `New-RscMutation -Gql hideRevealNasShares` | [hideRevealNasShares](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationNas -Operation RefreshNasSystems` | `New-RscMutation -Gql refreshNasSystems` | [refreshNasSystems](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationNas -Operation RegisterNasSystem` | `New-RscMutation -Gql registerNasSystem` | [registerNasSystem](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationNas -Operation UpdateNasShares` | `New-RscMutation -Gql updateNasShares` | [updateNasShares](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationNas -Operation UpdateNasSystem` | `New-RscMutation -Gql updateNasSystem` | [updateNasSystem](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## NAS Cloud Direct domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryNcd -Operation BackEndCapacity` | `New-RscQuery -Gql ncdBackEndCapacity` | [ncdBackEndCapacity](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryNcd -Operation FrontEndCapacity` | `New-RscQuery -Gql ncdFrontEndCapacity` | [ncdFrontEndCapacity](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryNcd -Operation ObjectProtectionStatus` | `New-RscQuery -Gql ncdObjectProtectionStatus` | [ncdObjectProtectionStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryNcd -Operation ObjectsOverTimeData` | `New-RscQuery -Gql allNcdObjectsOverTimeData` | [allNcdObjectsOverTimeData](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryNcd -Operation TaskData` | `New-RscQuery -Gql allNcdTaskData` | [allNcdTaskData](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryNcd -Operation UsageOverTimeData` | `New-RscQuery -Gql allNcdUsageOverTimeData` | [allNcdUsageOverTimeData](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryNcd -Operation VmImageUrl` | `New-RscQuery -Gql ncdVmImageUrl` | [ncdVmImageUrl](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |

[Go to top](#)
## NFS domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationNfs -Operation CreateReaderTarget` | `New-RscMutation -Gql createNfsReaderTarget` | [createNfsReaderTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationNfs -Operation CreateTarget` | `New-RscMutation -Gql createNfsTarget` | [createNfsTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationNfs -Operation UpdateTarget` | `New-RscMutation -Gql updateNfsTarget` | [updateNfsTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Nutanix domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryNutanix -Operation BrowseSnapshot` | `New-RscQuery -Gql nutanixBrowseSnapshot` | [nutanixBrowseSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryNutanix -Operation Category` | `New-RscQuery -Gql nutanixCategory` | [nutanixCategory](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryNutanix -Operation CategoryValue` | `New-RscQuery -Gql nutanixCategoryValue` | [nutanixCategoryValue](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryNutanix -Operation Cluster` | `New-RscQuery -Gql nutanixCluster` | [nutanixCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryNutanix -Operation ClusterAsyncRequestStatus` | `New-RscQuery -Gql nutanixClusterAsyncRequestStatus` | [nutanixClusterAsyncRequestStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryNutanix -Operation ClusterContainers` | `New-RscQuery -Gql nutanixClusterContainers` | [nutanixClusterContainers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryNutanix -Operation ClusterNetworks` | `New-RscQuery -Gql nutanixClusterNetworks` | [nutanixClusterNetworks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryNutanix -Operation Clusters` | `New-RscQuery -Gql nutanixClusters` | [nutanixClusters](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryNutanix -Operation Mounts` | `New-RscQuery -Gql nutanixMounts` | [nutanixMounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryNutanix -Operation MountsV2` | `New-RscQuery -Gql nutanixMountsV2` | [nutanixMountsV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryNutanix -Operation PrismCentral` | `New-RscQuery -Gql nutanixPrismCentral` | [nutanixPrismCentral](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryNutanix -Operation PrismCentrals` | `New-RscQuery -Gql nutanixPrismCentrals` | [nutanixPrismCentrals](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryNutanix -Operation SearchVm` | `New-RscQuery -Gql searchNutanixVm` | [searchNutanixVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryNutanix -Operation SnapshotDetail` | `New-RscQuery -Gql nutanixSnapshotDetail` | [nutanixSnapshotDetail](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryNutanix -Operation SnapshotVdisks` | `New-RscQuery -Gql nutanixSnapshotVdisks` | [nutanixSnapshotVdisks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryNutanix -Operation TopLevelDescendants` | `New-RscQuery -Gql nutanixTopLevelDescendants` | [nutanixTopLevelDescendants](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryNutanix -Operation VDiskMountableVms` | `New-RscQuery -Gql vDiskMountableNutanixVms` | [vDiskMountableNutanixVms](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryNutanix -Operation Vm` | `New-RscQuery -Gql nutanixVm` | [nutanixVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryNutanix -Operation VmAsyncRequestStatus` | `New-RscQuery -Gql nutanixVmAsyncRequestStatus` | [nutanixVmAsyncRequestStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryNutanix -Operation VmMissedSnapshots` | `New-RscQuery -Gql nutanixVmMissedSnapshots` | [nutanixVmMissedSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryNutanix -Operation Vms` | `New-RscQuery -Gql nutanixVms` | [nutanixVms](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationNutanix -Operation BatchExportVm` | `New-RscMutation -Gql batchExportNutanixVm` | [batchExportNutanixVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationNutanix -Operation BatchMountVm` | `New-RscMutation -Gql batchMountNutanixVm` | [batchMountNutanixVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationNutanix -Operation BulkOnDemandSnapshotVm` | `New-RscMutation -Gql bulkOnDemandSnapshotNutanixVm` | [bulkOnDemandSnapshotNutanixVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationNutanix -Operation CreateCluster` | `New-RscMutation -Gql createNutanixCluster` | [createNutanixCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationNutanix -Operation CreateOnDemandBackup` | `New-RscMutation -Gql createOnDemandNutanixBackup` | [createOnDemandNutanixBackup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationNutanix -Operation CreatePrismCentral` | `New-RscMutation -Gql createNutanixPrismCentral` | [createNutanixPrismCentral](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationNutanix -Operation DeleteCluster` | `New-RscMutation -Gql deleteNutanixCluster` | [deleteNutanixCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationNutanix -Operation DeleteMountV1` | `New-RscMutation -Gql deleteNutanixMountV1` | [deleteNutanixMountV1](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationNutanix -Operation DeletePrismCentral` | `New-RscMutation -Gql deleteNutanixPrismCentral` | [deleteNutanixPrismCentral](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationNutanix -Operation DeleteSnapshot` | `New-RscMutation -Gql deleteNutanixSnapshot` | [deleteNutanixSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationNutanix -Operation DeleteSnapshots` | `New-RscMutation -Gql deleteNutanixSnapshots` | [deleteNutanixSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationNutanix -Operation DownloadFilesSnapshot` | `New-RscMutation -Gql downloadFilesNutanixSnapshot` | [downloadFilesNutanixSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationNutanix -Operation DownloadFilesSnapshotFromArchivalLocation` | `New-RscMutation -Gql downloadFilesNutanixSnapshotFromArchivalLocation` | [downloadFilesNutanixSnapshotFromArchivalLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationNutanix -Operation DownloadSnapshot` | `New-RscMutation -Gql downloadNutanixSnapshot` | [downloadNutanixSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationNutanix -Operation DownloadVdisks` | `New-RscMutation -Gql downloadNutanixVdisks` | [downloadNutanixVdisks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationNutanix -Operation DownloadVmFromLocation` | `New-RscMutation -Gql downloadNutanixVmFromLocation` | [downloadNutanixVmFromLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationNutanix -Operation ExportSnapshot` | `New-RscMutation -Gql exportNutanixSnapshot` | [exportNutanixSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationNutanix -Operation InplaceExportSnapshot` | `New-RscMutation -Gql inplaceExportNutanixSnapshot` | [inplaceExportNutanixSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationNutanix -Operation MigrateMountV1` | `New-RscMutation -Gql migrateNutanixMountV1` | [migrateNutanixMountV1](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationNutanix -Operation MountSnapshotV1` | `New-RscMutation -Gql mountNutanixSnapshotV1` | [mountNutanixSnapshotV1](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationNutanix -Operation MountVdisks` | `New-RscMutation -Gql mountNutanixVdisks` | [mountNutanixVdisks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationNutanix -Operation PatchMountV1` | `New-RscMutation -Gql patchNutanixMountV1` | [patchNutanixMountV1](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationNutanix -Operation RefreshCluster` | `New-RscMutation -Gql refreshNutanixCluster` | [refreshNutanixCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationNutanix -Operation RefreshPrismCentral` | `New-RscMutation -Gql refreshNutanixPrismCentral` | [refreshNutanixPrismCentral](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationNutanix -Operation RegisterAgentVm` | `New-RscMutation -Gql registerAgentNutanixVm` | [registerAgentNutanixVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationNutanix -Operation RestoreFilesSnapshot` | `New-RscMutation -Gql restoreFilesNutanixSnapshot` | [restoreFilesNutanixSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationNutanix -Operation RestoreVmSnapshotFilesFromArchivalLocation` | `New-RscMutation -Gql restoreNutanixVmSnapshotFilesFromArchivalLocation` | [restoreNutanixVmSnapshotFilesFromArchivalLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationNutanix -Operation UpdateCluster` | `New-RscMutation -Gql updateNutanixCluster` | [updateNutanixCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationNutanix -Operation UpdatePrismCentral` | `New-RscMutation -Gql updateNutanixPrismCentral` | [updateNutanixPrismCentral](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationNutanix -Operation UpdateVm` | `New-RscMutation -Gql updateNutanixVm` | [updateNutanixVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Office 365 domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryO365 -Operation AdGroups` | `New-RscQuery -Gql allO365AdGroups` | [allO365AdGroups](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryO365 -Operation BrowseTeamConvChannels` | `New-RscQuery -Gql browseO365TeamConvChannels` | [browseO365TeamConvChannels](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryO365 -Operation Calendar` | `New-RscQuery -Gql o365Calendar` | [o365Calendar](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryO365 -Operation Consumption` | `New-RscQuery -Gql o365Consumption` | [o365Consumption](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryO365 -Operation Groups` | `New-RscQuery -Gql o365Groups` | [o365Groups](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryO365 -Operation HasAccessToObjects` | `New-RscQuery -Gql hasAccessToO365Objects` | [hasAccessToO365Objects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryO365 -Operation License` | `New-RscQuery -Gql o365License` | [o365License](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryO365 -Operation ListApps` | `New-RscQuery -Gql listO365Apps` | [listO365Apps](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryO365 -Operation Mailbox` | `New-RscQuery -Gql o365Mailbox` | [o365Mailbox](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryO365 -Operation Mailboxes` | `New-RscQuery -Gql o365Mailboxes` | [o365Mailboxes](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryO365 -Operation ObjectAncestors` | `New-RscQuery -Gql o365ObjectAncestors` | [o365ObjectAncestors](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryO365 -Operation Onedrive` | `New-RscQuery -Gql o365Onedrive` | [o365Onedrive](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryO365 -Operation Onedrives` | `New-RscQuery -Gql o365Onedrives` | [o365Onedrives](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryO365 -Operation Org` | `New-RscQuery -Gql o365Org` | [o365Org](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryO365 -Operation OrgAtSnappableLevel` | `New-RscQuery -Gql o365OrgAtSnappableLevel` | [o365OrgAtSnappableLevel](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryO365 -Operation OrgStatuses` | `New-RscQuery -Gql allO365OrgStatuses` | [allO365OrgStatuses](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryO365 -Operation OrgSummaries` | `New-RscQuery -Gql o365OrgSummaries` | [o365OrgSummaries](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryO365 -Operation Orgs` | `New-RscQuery -Gql o365Orgs` | [o365Orgs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryO365 -Operation QueryRecoveryAnalysisResult` | `New-RscQuery -Gql queryO365RecoveryAnalysisResult` | [queryO365RecoveryAnalysisResult](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryO365 -Operation ServiceAccount` | `New-RscQuery -Gql o365ServiceAccount` | [o365ServiceAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryO365 -Operation ServiceStatus` | `New-RscQuery -Gql o365ServiceStatus` | [o365ServiceStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryO365 -Operation SharepointDrive` | `New-RscQuery -Gql o365SharepointDrive` | [o365SharepointDrive](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryO365 -Operation SharepointDrives` | `New-RscQuery -Gql o365SharepointDrives` | [o365SharepointDrives](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryO365 -Operation SharepointList` | `New-RscQuery -Gql o365SharepointList` | [o365SharepointList](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryO365 -Operation SharepointLists` | `New-RscQuery -Gql o365SharepointLists` | [o365SharepointLists](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryO365 -Operation SharepointObjectList` | `New-RscQuery -Gql o365SharepointObjectList` | [o365SharepointObjectList](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryO365 -Operation SharepointObjects` | `New-RscQuery -Gql o365SharepointObjects` | [o365SharepointObjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryO365 -Operation SharepointObjectsNew` | `New-RscQuery -Gql o365SharepointObjectsNew` | [o365SharepointObjectsNew](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryO365 -Operation SharepointSite` | `New-RscQuery -Gql o365SharepointSite` | [o365SharepointSite](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryO365 -Operation SharepointSites` | `New-RscQuery -Gql o365SharepointSites` | [o365SharepointSites](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryO365 -Operation Site` | `New-RscQuery -Gql o365Site` | [o365Site](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryO365 -Operation Sites` | `New-RscQuery -Gql o365Sites` | [o365Sites](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryO365 -Operation StorageStats` | `New-RscQuery -Gql o365StorageStats` | [o365StorageStats](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryO365 -Operation SubscriptionsAppTypeCounts` | `New-RscQuery -Gql allO365SubscriptionsAppTypeCounts` | [allO365SubscriptionsAppTypeCounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryO365 -Operation Team` | `New-RscQuery -Gql o365Team` | [o365Team](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryO365 -Operation TeamChannels` | `New-RscQuery -Gql o365TeamChannels` | [o365TeamChannels](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryO365 -Operation TeamConversationsFolderID` | `New-RscQuery -Gql o365TeamConversationsFolderID` | [o365TeamConversationsFolderID](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryO365 -Operation TeamPostedBy` | `New-RscQuery -Gql o365TeamPostedBy` | [o365TeamPostedBy](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryO365 -Operation Teams` | `New-RscQuery -Gql o365Teams` | [o365Teams](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryO365 -Operation User` | `New-RscQuery -Gql o365User` | [o365User](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryO365 -Operation UserObjects` | `New-RscQuery -Gql o365UserObjects` | [o365UserObjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryO365 -Operation UserSelfServiceInfo` | `New-RscQuery -Gql o365UserSelfServiceInfo` | [o365UserSelfServiceInfo](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationO365 -Operation AddOrg` | `New-RscMutation -Gql addO365Org` | [addO365Org](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationO365 -Operation AnalyzeMvb` | `New-RscMutation -Gql analyzeO365Mvb` | [analyzeO365Mvb](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationO365 -Operation BackupMailbox` | `New-RscMutation -Gql backupO365Mailbox` | [backupO365Mailbox](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationO365 -Operation BackupOnedrive` | `New-RscMutation -Gql backupO365Onedrive` | [backupO365Onedrive](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationO365 -Operation BackupSharePointSite` | `New-RscMutation -Gql backupO365SharePointSite` | [backupO365SharePointSite](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationO365 -Operation BackupSharepointDrive` | `New-RscMutation -Gql backupO365SharepointDrive` | [backupO365SharepointDrive](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationO365 -Operation BackupSharepointList` | `New-RscMutation -Gql backupO365SharepointList` | [backupO365SharepointList](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationO365 -Operation BackupTeam` | `New-RscMutation -Gql backupO365Team` | [backupO365Team](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationO365 -Operation CreateAppComplete` | `New-RscMutation -Gql createO365AppComplete` | [createO365AppComplete](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationO365 -Operation CreateAppKickoff` | `New-RscMutation -Gql createO365AppKickoff` | [createO365AppKickoff](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationO365 -Operation DeleteAzureApp` | `New-RscMutation -Gql deleteO365AzureApp` | [deleteO365AzureApp](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationO365 -Operation DeleteOrg` | `New-RscMutation -Gql deleteO365Org` | [deleteO365Org](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationO365 -Operation DeleteServiceAccount` | `New-RscMutation -Gql deleteO365ServiceAccount` | [deleteO365ServiceAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationO365 -Operation EnableSharePoint` | `New-RscMutation -Gql enableO365SharePoint` | [enableO365SharePoint](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationO365 -Operation EnableTeams` | `New-RscMutation -Gql enableO365Teams` | [enableO365Teams](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationO365 -Operation ExportMailbox` | `New-RscMutation -Gql exportO365Mailbox` | [exportO365Mailbox](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationO365 -Operation ExportMailboxV2` | `New-RscMutation -Gql exportO365MailboxV2` | [exportO365MailboxV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationO365 -Operation InsertCustomerApp` | `New-RscMutation -Gql insertCustomerO365App` | [insertCustomerO365App](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationO365 -Operation OauthConsentComplete` | `New-RscMutation -Gql o365OauthConsentComplete` | [o365OauthConsentComplete](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationO365 -Operation OauthConsentKickoff` | `New-RscMutation -Gql o365OauthConsentKickoff` | [o365OauthConsentKickoff](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationO365 -Operation PdlGroups` | `New-RscMutation -Gql o365PdlGroups` | [o365PdlGroups](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationO365 -Operation RefreshOrg` | `New-RscMutation -Gql refreshO365Org` | [refreshO365Org](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationO365 -Operation RestoreFullTeams` | `New-RscMutation -Gql restoreO365FullTeams` | [restoreO365FullTeams](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationO365 -Operation RestoreMailbox` | `New-RscMutation -Gql restoreO365Mailbox` | [restoreO365Mailbox](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationO365 -Operation RestoreMailboxV2` | `New-RscMutation -Gql restoreO365MailboxV2` | [restoreO365MailboxV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationO365 -Operation RestoreSnappable` | `New-RscMutation -Gql restoreO365Snappable` | [restoreO365Snappable](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationO365 -Operation RestoreTeamsConversations` | `New-RscMutation -Gql restoreO365TeamsConversations` | [restoreO365TeamsConversations](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationO365 -Operation RestoreTeamsFiles` | `New-RscMutation -Gql restoreO365TeamsFiles` | [restoreO365TeamsFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationO365 -Operation SaaSSetupKickoff` | `New-RscMutation -Gql o365SaaSSetupKickoff` | [o365SaaSSetupKickoff](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationO365 -Operation SaasSetupComplete` | `New-RscMutation -Gql o365SaasSetupComplete` | [o365SaasSetupComplete](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationO365 -Operation SetServiceAccount` | `New-RscMutation -Gql setO365ServiceAccount` | [setO365ServiceAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationO365 -Operation SetupKickoff` | `New-RscMutation -Gql o365SetupKickoff` | [o365SetupKickoff](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationO365 -Operation UpdateAppAuthStatus` | `New-RscMutation -Gql updateO365AppAuthStatus` | [updateO365AppAuthStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationO365 -Operation UpdateAppPermissions` | `New-RscMutation -Gql updateO365AppPermissions` | [updateO365AppPermissions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationO365 -Operation UpdateOrgCustomName` | `New-RscMutation -Gql updateO365OrgCustomName` | [updateO365OrgCustomName](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Oracle domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryOracle -Operation AcoExampleDownloadLink` | `New-RscQuery -Gql oracleAcoExampleDownloadLink` | [oracleAcoExampleDownloadLink](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryOracle -Operation AcoParameters` | `New-RscQuery -Gql oracleAcoParameters` | [oracleAcoParameters](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryOracle -Operation DataGuardGroup` | `New-RscQuery -Gql oracleDataGuardGroup` | [oracleDataGuardGroup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryOracle -Operation Database` | `New-RscQuery -Gql oracleDatabase` | [oracleDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryOracle -Operation DatabaseAsyncRequestDetails` | `New-RscQuery -Gql oracleDatabaseAsyncRequestDetails` | [oracleDatabaseAsyncRequestDetails](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryOracle -Operation DatabaseLogBackupConfig` | `New-RscQuery -Gql oracleDatabaseLogBackupConfig` | [oracleDatabaseLogBackupConfig](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryOracle -Operation Databases` | `New-RscQuery -Gql oracleDatabases` | [oracleDatabases](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryOracle -Operation Host` | `New-RscQuery -Gql oracleHost` | [oracleHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryOracle -Operation HostLogBackupConfig` | `New-RscQuery -Gql oracleHostLogBackupConfig` | [oracleHostLogBackupConfig](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryOracle -Operation LiveMounts` | `New-RscQuery -Gql oracleLiveMounts` | [oracleLiveMounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryOracle -Operation MissedRecoverableRanges` | `New-RscQuery -Gql oracleMissedRecoverableRanges` | [oracleMissedRecoverableRanges](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryOracle -Operation MissedSnapshots` | `New-RscQuery -Gql oracleMissedSnapshots` | [oracleMissedSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryOracle -Operation PdbDetails` | `New-RscQuery -Gql oraclePdbDetails` | [oraclePdbDetails](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryOracle -Operation Rac` | `New-RscQuery -Gql oracleRac` | [oracleRac](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryOracle -Operation RacLogBackupConfig` | `New-RscQuery -Gql oracleRacLogBackupConfig` | [oracleRacLogBackupConfig](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryOracle -Operation RecoverableRanges` | `New-RscQuery -Gql oracleRecoverableRanges` | [oracleRecoverableRanges](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryOracle -Operation RecoverableRangesMinimal` | `New-RscQuery -Gql oracleRecoverableRangesMinimal` | [oracleRecoverableRangesMinimal](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryOracle -Operation TopLevelDescendants` | `New-RscQuery -Gql oracleTopLevelDescendants` | [oracleTopLevelDescendants](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationOracle -Operation BulkUpdateDatabases` | `New-RscMutation -Gql bulkUpdateOracleDatabases` | [bulkUpdateOracleDatabases](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationOracle -Operation BulkUpdateHosts` | `New-RscMutation -Gql bulkUpdateOracleHosts` | [bulkUpdateOracleHosts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationOracle -Operation BulkUpdateRacs` | `New-RscMutation -Gql bulkUpdateOracleRacs` | [bulkUpdateOracleRacs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationOracle -Operation CreatePdbRestore` | `New-RscMutation -Gql createOraclePdbRestore` | [createOraclePdbRestore](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationOracle -Operation DeleteAllDatabaseSnapshots` | `New-RscMutation -Gql deleteAllOracleDatabaseSnapshots` | [deleteAllOracleDatabaseSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationOracle -Operation DeleteMount` | `New-RscMutation -Gql deleteOracleMount` | [deleteOracleMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationOracle -Operation DownloadDatabaseSnapshot` | `New-RscMutation -Gql downloadOracleDatabaseSnapshot` | [downloadOracleDatabaseSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationOracle -Operation DownloadSnapshotFromLocation` | `New-RscMutation -Gql downloadOracleSnapshotFromLocation` | [downloadOracleSnapshotFromLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationOracle -Operation DownloadSnapshotFromLocationV2` | `New-RscMutation -Gql downloadOracleSnapshotFromLocationV2` | [downloadOracleSnapshotFromLocationV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationOracle -Operation ExportDatabase` | `New-RscMutation -Gql exportOracleDatabase` | [exportOracleDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationOracle -Operation ExportTablespace` | `New-RscMutation -Gql exportOracleTablespace` | [exportOracleTablespace](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationOracle -Operation InstantRecoverSnapshot` | `New-RscMutation -Gql instantRecoverOracleSnapshot` | [instantRecoverOracleSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationOracle -Operation MountDatabase` | `New-RscMutation -Gql mountOracleDatabase` | [mountOracleDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationOracle -Operation RefreshDatabase` | `New-RscMutation -Gql refreshOracleDatabase` | [refreshOracleDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationOracle -Operation RestoreLogs` | `New-RscMutation -Gql restoreOracleLogs` | [restoreOracleLogs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationOracle -Operation TakeOnDemandDatabaseSnapshot` | `New-RscMutation -Gql takeOnDemandOracleDatabaseSnapshot` | [takeOnDemandOracleDatabaseSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationOracle -Operation TakeOnDemandLogSnapshot` | `New-RscMutation -Gql takeOnDemandOracleLogSnapshot` | [takeOnDemandOracleLogSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationOracle -Operation UpdateDataGuardGroup` | `New-RscMutation -Gql updateOracleDataGuardGroup` | [updateOracleDataGuardGroup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationOracle -Operation ValidateAcoFile` | `New-RscMutation -Gql validateOracleAcoFile` | [validateOracleAcoFile](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationOracle -Operation ValidateDatabaseBackups` | `New-RscMutation -Gql validateOracleDatabaseBackups` | [validateOracleDatabaseBackups](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Policy domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryPolicy -Operation CustomTprPolicies` | `New-RscQuery -Gql customTprPolicies` | [customTprPolicies](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryPolicy -Operation HaPolicies` | `New-RscQuery -Gql haPolicies` | [haPolicies](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryPolicy -Operation IsValidTprPolicyName` | `New-RscQuery -Gql isValidTprPolicyName` | [isValidTprPolicyName](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryPolicy -Operation OrgSecurityPolicy` | `New-RscQuery -Gql orgSecurityPolicy` | [orgSecurityPolicy](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryPolicy -Operation PasswordComplexityPolicy` | `New-RscQuery -Gql passwordComplexityPolicy` | [passwordComplexityPolicy](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryPolicy -Operation Policies` | `New-RscQuery -Gql policies` | [policies](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryPolicy -Operation Policy` | `New-RscQuery -Gql policy` | [policy](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryPolicy -Operation PolicyObjectUsages` | `New-RscQuery -Gql policyObjectUsages` | [policyObjectUsages](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryPolicy -Operation TopRiskPolicySummaries` | `New-RscQuery -Gql allTopRiskPolicySummaries` | [allTopRiskPolicySummaries](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryPolicy -Operation TprPolicyDetail` | `New-RscQuery -Gql tprPolicyDetail` | [tprPolicyDetail](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationPolicy -Operation AddPolicyObjects` | `New-RscMutation -Gql addPolicyObjects` | [addPolicyObjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationPolicy -Operation CreatePolicy` | `New-RscMutation -Gql createPolicy` | [createPolicy](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationPolicy -Operation CreateTprPolicy` | `New-RscMutation -Gql createTprPolicy` | [createTprPolicy](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationPolicy -Operation DeactivatePolicy` | `New-RscMutation -Gql deactivatePolicy` | [deactivatePolicy](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationPolicy -Operation DeleteTprPolicy` | `New-RscMutation -Gql deleteTprPolicy` | [deleteTprPolicy](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationPolicy -Operation FailoverHaPolicy` | `New-RscMutation -Gql failoverHaPolicy` | [failoverHaPolicy](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationPolicy -Operation GetHealthMonitorPolicyStatus` | `New-RscMutation -Gql getHealthMonitorPolicyStatus` | [getHealthMonitorPolicyStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationPolicy -Operation RemovePolicyObjects` | `New-RscMutation -Gql removePolicyObjects` | [removePolicyObjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationPolicy -Operation SeedEnabledPolicies` | `New-RscMutation -Gql seedEnabledPolicies` | [seedEnabledPolicies](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationPolicy -Operation SeedInitialPolicies` | `New-RscMutation -Gql seedInitialPolicies` | [seedInitialPolicies](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationPolicy -Operation SetPasswordComplexityPolicy` | `New-RscMutation -Gql setPasswordComplexityPolicy` | [setPasswordComplexityPolicy](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationPolicy -Operation UpdateAutoEnablePolicyClusterConfig` | `New-RscMutation -Gql updateAutoEnablePolicyClusterConfig` | [updateAutoEnablePolicyClusterConfig](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationPolicy -Operation UpdateHealthMonitorPolicyStatus` | `New-RscMutation -Gql updateHealthMonitorPolicyStatus` | [updateHealthMonitorPolicyStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationPolicy -Operation UpdateOrgSecurityPolicy` | `New-RscMutation -Gql updateOrgSecurityPolicy` | [updateOrgSecurityPolicy](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationPolicy -Operation UpdatePolicy` | `New-RscMutation -Gql updatePolicy` | [updatePolicy](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationPolicy -Operation UpdateTprPolicy` | `New-RscMutation -Gql updateTprPolicy` | [updateTprPolicy](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Ransomware domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryRansomware -Operation DetectionWorkloadLocations` | `New-RscQuery -Gql ransomwareDetectionWorkloadLocations` | [ransomwareDetectionWorkloadLocations](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryRansomware -Operation InvestigationAnalysisSummary` | `New-RscQuery -Gql ransomwareInvestigationAnalysisSummary` | [ransomwareInvestigationAnalysisSummary](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryRansomware -Operation InvestigationEnablement` | `New-RscQuery -Gql ransomwareInvestigationEnablement` | [ransomwareInvestigationEnablement](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryRansomware -Operation OverallInvestigationSummary` | `New-RscQuery -Gql overallRansomwareInvestigationSummary` | [overallRansomwareInvestigationSummary](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryRansomware -Operation ProcessedInvestigationWorkloadCount` | `New-RscQuery -Gql processedRansomwareInvestigationWorkloadCount` | [processedRansomwareInvestigationWorkloadCount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryRansomware -Operation Result` | `New-RscQuery -Gql ransomwareResult` | [ransomwareResult](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryRansomware -Operation ResultOpt` | `New-RscQuery -Gql ransomwareResultOpt` | [ransomwareResultOpt](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryRansomware -Operation Results` | `New-RscQuery -Gql ransomwareResults` | [ransomwareResults](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryRansomware -Operation ResultsGrouped` | `New-RscQuery -Gql ransomwareResultsGrouped` | [ransomwareResultsGrouped](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationRansomware -Operation BulkUpdateInvestigationStatus` | `New-RscMutation -Gql bulkUpdateRansomwareInvestigationStatus` | [bulkUpdateRansomwareInvestigationStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationRansomware -Operation TriggerDetection` | `New-RscMutation -Gql triggerRansomwareDetection` | [triggerRansomwareDetection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## RCS domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationRcs -Operation CreateAutomaticRcsTargetMapping` | `New-RscMutation -Gql createAutomaticRcsTargetMapping` | [createAutomaticRcsTargetMapping](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationRcs -Operation CreateRcsReaderTarget` | `New-RscMutation -Gql createRcsReaderTarget` | [createRcsReaderTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationRcs -Operation CreateRcsTarget` | `New-RscMutation -Gql createRcsTarget` | [createRcsTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationRcs -Operation UpdateRcsAutomaticTargetMapping` | `New-RscMutation -Gql updateRcsAutomaticTargetMapping` | [updateRcsAutomaticTargetMapping](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## RCV domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryRcv -Operation AccountEntitlement` | `New-RscQuery -Gql rcvAccountEntitlement` | [rcvAccountEntitlement](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryRcv -Operation AccountEntitlements` | `New-RscQuery -Gql allRcvAccountEntitlements` | [allRcvAccountEntitlements](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryRcv -Operation IsTriggerGrsTprConfigured` | `New-RscQuery -Gql isTriggerRcvGrsTprConfigured` | [isTriggerRcvGrsTprConfigured](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryRcv -Operation MigrationInfo` | `New-RscQuery -Gql allRcvMigrationInfo` | [allRcvMigrationInfo](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryRcv -Operation PrivateEndpointConnections` | `New-RscQuery -Gql allRcvPrivateEndpointConnections` | [allRcvPrivateEndpointConnections](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationRcv -Operation ApprovePrivateEndpoint` | `New-RscMutation -Gql approveRcvPrivateEndpoint` | [approveRcvPrivateEndpoint](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationRcv -Operation CreateLocationsFromTemplate` | `New-RscMutation -Gql createRcvLocationsFromTemplate` | [createRcvLocationsFromTemplate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationRcv -Operation CreatePrivateEndpointApprovalRequest` | `New-RscMutation -Gql createRcvPrivateEndpointApprovalRequest` | [createRcvPrivateEndpointApprovalRequest](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationRcv -Operation UpdateDestinationRoleForMigration` | `New-RscMutation -Gql updateDestinationRoleForRcvMigration` | [updateDestinationRoleForRcvMigration](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationRcv -Operation UpdateEncryptionKeyForMigration` | `New-RscMutation -Gql updateEncryptionKeyForRcvMigration` | [updateEncryptionKeyForRcvMigration](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationRcv -Operation UpdatePrivateEndpoint` | `New-RscMutation -Gql updateRcvPrivateEndpoint` | [updateRcvPrivateEndpoint](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationRcv -Operation UpdateTarget` | `New-RscMutation -Gql updateRcvTarget` | [updateRcvTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Replication domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryReplication -Operation IncomingStats` | `New-RscQuery -Gql replicationIncomingStats` | [replicationIncomingStats](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryReplication -Operation NetworkThrottleBypass` | `New-RscQuery -Gql replicationNetworkThrottleBypass` | [replicationNetworkThrottleBypass](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryReplication -Operation NetworkThrottleBypassById` | `New-RscQuery -Gql replicationNetworkThrottleBypassById` | [replicationNetworkThrottleBypassById](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryReplication -Operation OutgoingStats` | `New-RscQuery -Gql replicationOutgoingStats` | [replicationOutgoingStats](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryReplication -Operation Pairs` | `New-RscQuery -Gql replicationPairs` | [replicationPairs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryReplication -Operation ValidSources` | `New-RscQuery -Gql allValidReplicationSources` | [allValidReplicationSources](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryReplication -Operation ValidTargets` | `New-RscQuery -Gql allValidReplicationTargets` | [allValidReplicationTargets](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationReplication -Operation CreatePair` | `New-RscMutation -Gql createReplicationPair` | [createReplicationPair](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationReplication -Operation DeletePair` | `New-RscMutation -Gql deleteReplicationPair` | [deleteReplicationPair](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationReplication -Operation DisablePause` | `New-RscMutation -Gql disableReplicationPause` | [disableReplicationPause](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationReplication -Operation EnablePause` | `New-RscMutation -Gql enableReplicationPause` | [enableReplicationPause](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationReplication -Operation UpdateNetworkThrottleBypass` | `New-RscMutation -Gql updateReplicationNetworkThrottleBypass` | [updateReplicationNetworkThrottleBypass](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationReplication -Operation UpdateTarget` | `New-RscMutation -Gql updateReplicationTarget` | [updateReplicationTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Report domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryReport -Operation ClusterMigrationCount` | `New-RscQuery -Gql clusterReportMigrationCount` | [clusterReportMigrationCount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryReport -Operation ClusterMigrationJobStatus` | `New-RscQuery -Gql clusterReportMigrationJobStatus` | [clusterReportMigrationJobStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryReport -Operation ClusterMigrationStatus` | `New-RscQuery -Gql clusterReportMigrationStatus` | [clusterReportMigrationStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryReport -Operation Custom` | `New-RscQuery -Gql customReports` | [customReports](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryReport -Operation CustomReports` | `New-RscQuery -Gql allCustomReports` | [allCustomReports](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryReport -Operation Data` | `New-RscQuery -Gql reportData` | [reportData](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryReport -Operation DatabaseLogForCluster` | `New-RscQuery -Gql databaseLogReportForCluster` | [databaseLogReportForCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryReport -Operation DatabaseLogingPropertiesForCluster` | `New-RscQuery -Gql databaseLogReportingPropertiesForCluster` | [databaseLogReportingPropertiesForCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryReport -Operation GenerateCloudDirectTask` | `New-RscQuery -Gql generateCloudDirectTaskReport` | [generateCloudDirectTaskReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryReport -Operation HealthCheckError` | `New-RscQuery -Gql healthCheckErrorReport` | [healthCheckErrorReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryReport -Operation Objects` | `New-RscQuery -Gql reportObjects` | [reportObjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryReport -Operation ScheduledReport` | `New-RscQuery -Gql scheduledReport` | [scheduledReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryReport -Operation ScheduledReports` | `New-RscQuery -Gql scheduledReports` | [scheduledReports](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryReport -Operation SkippedTeamsSite` | `New-RscQuery -Gql skippedTeamsSiteReport` | [skippedTeamsSiteReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryReport -Operation Sonar` | `New-RscQuery -Gql sonarReport` | [sonarReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryReport -Operation SonarContent` | `New-RscQuery -Gql sonarContentReport` | [sonarContentReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryReport -Operation SonarRow` | `New-RscQuery -Gql sonarReportRow` | [sonarReportRow](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryReport -Operation TemplatesByCategories` | `New-RscQuery -Gql allReportTemplatesByCategories` | [allReportTemplatesByCategories](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationReport -Operation CreateScheduled` | `New-RscMutation -Gql createScheduledReport` | [createScheduledReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationReport -Operation DeleteCustom` | `New-RscMutation -Gql deleteCustomReport` | [deleteCustomReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationReport -Operation DeleteScheduledReport` | `New-RscMutation -Gql deleteScheduledReport` | [deleteScheduledReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationReport -Operation SendPdf` | `New-RscMutation -Gql sendPdfReport` | [sendPdfReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationReport -Operation SendScheduledReportAsync` | `New-RscMutation -Gql sendScheduledReportAsync` | [sendScheduledReportAsync](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationReport -Operation StartClusterMigrationJob` | `New-RscMutation -Gql startClusterReportMigrationJob` | [startClusterReportMigrationJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationReport -Operation UpdateDatabaseLogingPropertiesForCluster` | `New-RscMutation -Gql updateDatabaseLogReportingPropertiesForCluster` | [updateDatabaseLogReportingPropertiesForCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationReport -Operation UpdateScheduledReport` | `New-RscMutation -Gql updateScheduledReport` | [updateScheduledReport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## SAP HANA domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQuerySapHana -Operation Database` | `New-RscQuery -Gql sapHanaDatabase` | [sapHanaDatabase](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySapHana -Operation Databases` | `New-RscQuery -Gql sapHanaDatabases` | [sapHanaDatabases](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySapHana -Operation LogSnapshot` | `New-RscQuery -Gql sapHanaLogSnapshot` | [sapHanaLogSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySapHana -Operation LogSnapshots` | `New-RscQuery -Gql sapHanaLogSnapshots` | [sapHanaLogSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySapHana -Operation RecoverableRange` | `New-RscQuery -Gql sapHanaRecoverableRange` | [sapHanaRecoverableRange](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySapHana -Operation RecoverableRanges` | `New-RscQuery -Gql sapHanaRecoverableRanges` | [sapHanaRecoverableRanges](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySapHana -Operation System` | `New-RscQuery -Gql sapHanaSystem` | [sapHanaSystem](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySapHana -Operation Systems` | `New-RscQuery -Gql sapHanaSystems` | [sapHanaSystems](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationSapHana -Operation AddSystem` | `New-RscMutation -Gql addSapHanaSystem` | [addSapHanaSystem](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSapHana -Operation BulkRecoverDatabases` | `New-RscMutation -Gql bulkRecoverSapHanaDatabases` | [bulkRecoverSapHanaDatabases](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSapHana -Operation ConfigureRestore` | `New-RscMutation -Gql configureSapHanaRestore` | [configureSapHanaRestore](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSapHana -Operation CreateOnDemandBackup` | `New-RscMutation -Gql createOnDemandSapHanaBackup` | [createOnDemandSapHanaBackup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSapHana -Operation CreateOnDemandDataBackup` | `New-RscMutation -Gql createOnDemandSapHanaDataBackup` | [createOnDemandSapHanaDataBackup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSapHana -Operation CreateOnDemandStorageSnapshot` | `New-RscMutation -Gql createOnDemandSapHanaStorageSnapshot` | [createOnDemandSapHanaStorageSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSapHana -Operation CreateSystemRefresh` | `New-RscMutation -Gql createSapHanaSystemRefresh` | [createSapHanaSystemRefresh](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSapHana -Operation DeleteDbSnapshot` | `New-RscMutation -Gql deleteSapHanaDbSnapshot` | [deleteSapHanaDbSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSapHana -Operation DeleteSystem` | `New-RscMutation -Gql deleteSapHanaSystem` | [deleteSapHanaSystem](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSapHana -Operation ExpireDownloadedSnapshots` | `New-RscMutation -Gql expireDownloadedSapHanaSnapshots` | [expireDownloadedSapHanaSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSapHana -Operation PatchSystem` | `New-RscMutation -Gql patchSapHanaSystem` | [patchSapHanaSystem](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSapHana -Operation RecoverDatabaseToFullBackup` | `New-RscMutation -Gql recoverSapHanaDatabaseToFullBackup` | [recoverSapHanaDatabaseToFullBackup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSapHana -Operation RecoverDatabaseToPointInTime` | `New-RscMutation -Gql recoverSapHanaDatabaseToPointInTime` | [recoverSapHanaDatabaseToPointInTime](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSapHana -Operation RestoreSystemStorage` | `New-RscMutation -Gql restoreSapHanaSystemStorage` | [restoreSapHanaSystemStorage](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSapHana -Operation UnconfigureRestore` | `New-RscMutation -Gql unconfigureSapHanaRestore` | [unconfigureSapHanaRestore](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Service Account domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryServiceAccount -Operation IsOrgDisabled` | `New-RscQuery -Gql isOrgServiceAccountDisabled` | [isOrgServiceAccountDisabled](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryServiceAccount -Operation ServiceAccount` | `New-RscQuery -Gql serviceAccounts` | [serviceAccounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationServiceAccount -Operation Create` | `New-RscMutation -Gql createServiceAccount` | [createServiceAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationServiceAccount -Operation Delete` | `New-RscMutation -Gql deleteServiceAccountsFromAccount` | [deleteServiceAccountsFromAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationServiceAccount -Operation Rotate` | `New-RscMutation -Gql rotateServiceAccountSecret` | [rotateServiceAccountSecret](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationServiceAccount -Operation Update` | `New-RscMutation -Gql updateServiceAccount` | [updateServiceAccount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Sharepoint domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQuerySharepoint -Operation BrowseDrive` | `New-RscQuery -Gql browseSharepointDrive` | [browseSharepointDrive](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySharepoint -Operation BrowseList` | `New-RscQuery -Gql browseSharepointList` | [browseSharepointList](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySharepoint -Operation SiteDescendants` | `New-RscQuery -Gql sharepointSiteDescendants` | [sharepointSiteDescendants](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySharepoint -Operation SiteExclusions` | `New-RscQuery -Gql allSharepointSiteExclusions` | [allSharepointSiteExclusions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySharepoint -Operation SiteSearch` | `New-RscQuery -Gql sharepointSiteSearch` | [sharepointSiteSearch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySharepoint -Operation SnappableDriveSearch` | `New-RscQuery -Gql snappableSharepointDriveSearch` | [snappableSharepointDriveSearch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySharepoint -Operation SnappableListSearch` | `New-RscQuery -Gql snappableSharepointListSearch` | [snappableSharepointListSearch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySharepoint -Operation SnapshotDriveSearch` | `New-RscQuery -Gql snapshotSharepointDriveSearch` | [snapshotSharepointDriveSearch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationSharepoint -Operation ExcludeObjectsFromProtection` | `New-RscMutation -Gql excludeSharepointObjectsFromProtection` | [excludeSharepointObjectsFromProtection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## SLA domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQuerySla -Operation AuditDetail` | `New-RscQuery -Gql slaAuditDetail` | [slaAuditDetail](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySla -Operation ClusterDomains` | `New-RscQuery -Gql clusterSlaDomains` | [clusterSlaDomains](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySla -Operation ClusterGlobals` | `New-RscQuery -Gql allClusterGlobalSlas` | [allClusterGlobalSlas](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySla -Operation ConflictObjects` | `New-RscQuery -Gql slaConflictObjects` | [slaConflictObjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySla -Operation CountOfObjectsProtected` | `New-RscQuery -Gql countOfObjectsProtectedBySlas` | [countOfObjectsProtectedBySlas](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySla -Operation Domain` | `New-RscQuery -Gql slaDomain` | [slaDomain](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySla -Operation Domains` | `New-RscQuery -Gql slaDomains` | [slaDomains](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySla -Operation DownloadWithReplicationCsv` | `New-RscQuery -Gql downloadSlaWithReplicationCsv` | [downloadSlaWithReplicationCsv](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySla -Operation GlobalFilterList` | `New-RscQuery -Gql globalSlaFilterConnection` | [globalSlaFilterConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySla -Operation GlobalStatuses` | `New-RscQuery -Gql globalSlaStatuses` | [globalSlaStatuses](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySla -Operation ManagedVolume` | `New-RscQuery -Gql slaManagedVolume` | [slaManagedVolume](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySla -Operation ManagedVolumes` | `New-RscQuery -Gql slaManagedVolumes` | [slaManagedVolumes](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySla -Operation NcdComplianceData` | `New-RscQuery -Gql allNcdSlaComplianceData` | [allNcdSlaComplianceData](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySla -Operation SummariesByIds` | `New-RscQuery -Gql allSlaSummariesByIds` | [allSlaSummariesByIds](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySla -Operation VerifyWithReplicationToCluster` | `New-RscQuery -Gql verifySlaWithReplicationToCluster` | [verifySlaWithReplicationToCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationSla -Operation Assign` | `New-RscMutation -Gql assignSla` | [assignSla](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSla -Operation AssignRetentionToSnappables` | `New-RscMutation -Gql assignRetentionSLAToSnappables` | [assignRetentionSLAToSnappables](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSla -Operation AssignRetentionToSnapshots` | `New-RscMutation -Gql assignRetentionSLAToSnapshots` | [assignRetentionSLAToSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSla -Operation AssignsForSnappableHierarchies` | `New-RscMutation -Gql assignSlasForSnappableHierarchies` | [assignSlasForSnappableHierarchies](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSla -Operation CreateGlobal` | `New-RscMutation -Gql createGlobalSla` | [createGlobalSla](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSla -Operation DeleteGlobal` | `New-RscMutation -Gql deleteGlobalSla` | [deleteGlobalSla](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSla -Operation ExportManagedVolumeSnapshot` | `New-RscMutation -Gql exportSlaManagedVolumeSnapshot` | [exportSlaManagedVolumeSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSla -Operation GetPendingAssignments` | `New-RscMutation -Gql getPendingSlaAssignments` | [getPendingSlaAssignments](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSla -Operation Pause` | `New-RscMutation -Gql pauseSla` | [pauseSla](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSla -Operation UpdateGlobal` | `New-RscMutation -Gql updateGlobalSla` | [updateGlobalSla](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSla -Operation UpdatesForMigrationToRcvTarget` | `New-RscMutation -Gql updateSlasForMigrationToRcvTarget` | [updateSlasForMigrationToRcvTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSla -Operation Upgrades` | `New-RscMutation -Gql upgradeSlas` | [upgradeSlas](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## SMB domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQuerySmb -Operation Configuration` | `New-RscQuery -Gql smbConfiguration` | [smbConfiguration](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySmb -Operation Domains` | `New-RscQuery -Gql smbDomains` | [smbDomains](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationSmb -Operation AddAndJoinDomain` | `New-RscMutation -Gql addAndJoinSmbDomain` | [addAndJoinSmbDomain](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSmb -Operation CloudDirectDeleteGlobalUser` | `New-RscMutation -Gql cloudDirectDeleteGlobalSmbUser` | [cloudDirectDeleteGlobalSmbUser](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSmb -Operation CloudDirectSetGlobalAuth` | `New-RscMutation -Gql cloudDirectSetGlobalSmbAuth` | [cloudDirectSetGlobalSmbAuth](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSmb -Operation DeleteDomain` | `New-RscMutation -Gql deleteSmbDomain` | [deleteSmbDomain](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSmb -Operation JoinDomain` | `New-RscMutation -Gql joinSmbDomain` | [joinSmbDomain](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSmb -Operation PutConfiguration` | `New-RscMutation -Gql putSmbConfiguration` | [putSmbConfiguration](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSmb -Operation SetCloudDirectGlobalSettings` | `New-RscMutation -Gql setCloudDirectGlobalSmbSettings` | [setCloudDirectGlobalSmbSettings](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Snappable domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQuerySnappable -Operation CdmHierarchySnappableNew` | `New-RscQuery -Gql cdmHierarchySnappableNew` | [cdmHierarchySnappableNew](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnappable -Operation CdmHierarchySnappablesNew` | `New-RscQuery -Gql cdmHierarchySnappablesNew` | [cdmHierarchySnappablesNew](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnappable -Operation ContactSearch` | `New-RscQuery -Gql snappableContactSearch` | [snappableContactSearch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnappable -Operation EmailSearch` | `New-RscQuery -Gql snappableEmailSearch` | [snappableEmailSearch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnappable -Operation EventSearch` | `New-RscQuery -Gql snappableEventSearch` | [snappableEventSearch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnappable -Operation GroupByList` | `New-RscQuery -Gql snappableGroupByConnection` | [snappableGroupByConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnappable -Operation Hierarchy` | `New-RscQuery -Gql hierarchySnappables` | [hierarchySnappables](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnappable -Operation List` | `New-RscQuery -Gql snappableConnection` | [snappableConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnappable -Operation OnedriveSearch` | `New-RscQuery -Gql snappableOnedriveSearch` | [snappableOnedriveSearch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnappable -Operation Search` | `New-RscQuery -Gql searchSnappableConnection` | [searchSnappableConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnappable -Operation SearchVersionedFiles` | `New-RscQuery -Gql searchSnappableVersionedFiles` | [searchSnappableVersionedFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnappable -Operation TeamsConversationsSearch` | `New-RscQuery -Gql snappableTeamsConversationsSearch` | [snappableTeamsConversationsSearch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnappable -Operation TeamsDriveSearch` | `New-RscQuery -Gql snappableTeamsDriveSearch` | [snappableTeamsDriveSearch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |

[Go to top](#)
## Snapshot domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQuerySnapshot -Operation BrowseFileList` | `New-RscQuery -Gql browseSnapshotFileConnection` | [browseSnapshotFileConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnapshot -Operation ByIds` | `New-RscQuery -Gql allSnapshotsByIds` | [allSnapshotsByIds](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnapshot -Operation ClosestToPointInTime` | `New-RscQuery -Gql allSnapshotsClosestToPointInTime` | [allSnapshotsClosestToPointInTime](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnapshot -Operation CloudDirect` | `New-RscQuery -Gql cloudDirectSnapshot` | [cloudDirectSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnapshot -Operation CloudDirects` | `New-RscQuery -Gql cloudDirectSnapshots` | [cloudDirectSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnapshot -Operation EmailSearch` | `New-RscQuery -Gql snapshotEmailSearch` | [snapshotEmailSearch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnapshot -Operation EventSearch` | `New-RscQuery -Gql snapshotEventSearch` | [snapshotEventSearch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnapshot -Operation FilesDelta` | `New-RscQuery -Gql snapshotFilesDelta` | [snapshotFilesDelta](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnapshot -Operation FilesDeltaV2` | `New-RscQuery -Gql snapshotFilesDeltaV2` | [snapshotFilesDeltaV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnapshot -Operation Fileset` | `New-RscQuery -Gql filesetSnapshot` | [filesetSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnapshot -Operation FilesetFiles` | `New-RscQuery -Gql filesetSnapshotFiles` | [filesetSnapshotFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnapshot -Operation LegalHoldSnappable` | `New-RscQuery -Gql legalHoldSnapshotsForSnappable` | [legalHoldSnapshotsForSnappable](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnapshot -Operation ListDiffFilesFor` | `New-RscQuery -Gql listDiffFilesForSnapshot` | [listDiffFilesForSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnapshot -Operation NewestForCloudDirectObject` | `New-RscQuery -Gql newestSnapshotForCloudDirectObject` | [newestSnapshotForCloudDirectObject](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnapshot -Operation OldestForCloudDirectObject` | `New-RscQuery -Gql oldestSnapshotForCloudDirectObject` | [oldestSnapshotForCloudDirectObject](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnapshot -Operation OnedriveSearch` | `New-RscQuery -Gql snapshotOnedriveSearch` | [snapshotOnedriveSearch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnapshot -Operation Polaris` | `New-RscQuery -Gql polarisSnapshot` | [polarisSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnapshot -Operation PossibleLocationsForObjects` | `New-RscQuery -Gql possibleSnapshotLocationsForObjects` | [possibleSnapshotLocationsForObjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnapshot -Operation Pvcs` | `New-RscQuery -Gql allSnapshotPvcs` | [allSnapshotPvcs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnapshot -Operation QuarantinedDetails` | `New-RscQuery -Gql allQuarantinedDetailsForSnapshots` | [allQuarantinedDetailsForSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnapshot -Operation Results` | `New-RscQuery -Gql snapshotResults` | [snapshotResults](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnapshot -Operation SOfCloudDirectBucket` | `New-RscQuery -Gql snapshotsOfCloudDirectBucket` | [snapshotsOfCloudDirectBucket](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnapshot -Operation SOfCloudDirectShare` | `New-RscQuery -Gql snapshotsOfCloudDirectShare` | [snapshotsOfCloudDirectShare](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnapshot -Operation SnappableList` | `New-RscQuery -Gql snapshotOfASnappableConnection` | [snapshotOfASnappableConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnapshot -Operation SnappablesList` | `New-RscQuery -Gql snapshotOfSnappablesConnection` | [snapshotOfSnappablesConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnapshot -Operation SnappablesWithLegalHoldsSummary` | `New-RscQuery -Gql snappablesWithLegalHoldSnapshotsSummary` | [snappablesWithLegalHoldSnapshotsSummary](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnapshot -Operation Snapshot` | `New-RscQuery -Gql snapshot` | [snapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnapshot -Operation TotalCloudDirectObject` | `New-RscQuery -Gql totalSnapshotsForCloudDirectObject` | [totalSnapshotsForCloudDirectObject](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnapshot -Operation UnmanagedObject` | `New-RscQuery -Gql snapshotsForUnmanagedObject` | [snapshotsForUnmanagedObject](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnapshot -Operation VappInstantRecoveryOptions` | `New-RscQuery -Gql vappSnapshotInstantRecoveryOptions` | [vappSnapshotInstantRecoveryOptions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySnapshot -Operation VappTemplateExportOptions` | `New-RscQuery -Gql vappTemplateSnapshotExportOptions` | [vappTemplateSnapshotExportOptions](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationSnapshot -Operation BatchQuarantine` | `New-RscMutation -Gql batchQuarantineSnapshot` | [batchQuarantineSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSnapshot -Operation BatchReleaseFromQuarantine` | `New-RscMutation -Gql batchReleaseFromQuarantineSnapshot` | [batchReleaseFromQuarantineSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSnapshot -Operation BulkTierExistings` | `New-RscMutation -Gql bulkTierExistingSnapshots` | [bulkTierExistingSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSnapshot -Operation CreateDomainController` | `New-RscMutation -Gql createDomainControllerSnapshot` | [createDomainControllerSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSnapshot -Operation CreateDownloadForVolumeGroup` | `New-RscMutation -Gql createDownloadSnapshotForVolumeGroup` | [createDownloadSnapshotForVolumeGroup](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSnapshot -Operation CreateFileset` | `New-RscMutation -Gql createFilesetSnapshot` | [createFilesetSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSnapshot -Operation CreateOnDemandMysqldbInstance` | `New-RscMutation -Gql createOnDemandMysqldbInstanceSnapshot` | [createOnDemandMysqldbInstanceSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSnapshot -Operation CreateVapps` | `New-RscMutation -Gql createVappSnapshots` | [createVappSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSnapshot -Operation DeleteCloudWorkloadSnapshot` | `New-RscMutation -Gql deleteCloudWorkloadSnapshot` | [deleteCloudWorkloadSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSnapshot -Operation DeleteFilesetSnapshots` | `New-RscMutation -Gql deleteFilesetSnapshots` | [deleteFilesetSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSnapshot -Operation DeleteUnmanageds` | `New-RscMutation -Gql deleteUnmanagedSnapshots` | [deleteUnmanagedSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSnapshot -Operation DeletesOfUnmanagedObjects` | `New-RscMutation -Gql deleteSnapshotsOfUnmanagedObjects` | [deleteSnapshotsOfUnmanagedObjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSnapshot -Operation ExportProxmoxVm` | `New-RscMutation -Gql exportProxmoxVmSnapshot` | [exportProxmoxVmSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSnapshot -Operation FilesetDownloadFiles` | `New-RscMutation -Gql filesetDownloadSnapshotFiles` | [filesetDownloadSnapshotFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSnapshot -Operation FilesetExportFiles` | `New-RscMutation -Gql filesetExportSnapshotFiles` | [filesetExportSnapshotFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSnapshot -Operation RestoreDomainController` | `New-RscMutation -Gql restoreDomainControllerSnapshot` | [restoreDomainControllerSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSnapshot -Operation RestoreOpenstackVmFiles` | `New-RscMutation -Gql restoreOpenstackVmSnapshotFiles` | [restoreOpenstackVmSnapshotFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSnapshot -Operation RestoreVolumeGroupFiles` | `New-RscMutation -Gql restoreVolumeGroupSnapshotFiles` | [restoreVolumeGroupSnapshotFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSnapshot -Operation StartEc2InstanceExportJob` | `New-RscMutation -Gql startEc2InstanceSnapshotExportJob` | [startEc2InstanceSnapshotExportJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSnapshot -Operation StartRecoverS3Job` | `New-RscMutation -Gql startRecoverS3SnapshotJob` | [startRecoverS3SnapshotJob](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSnapshot -Operation TakeCloudDirect` | `New-RscMutation -Gql takeCloudDirectSnapshot` | [takeCloudDirectSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSnapshot -Operation TakeOnDemand` | `New-RscMutation -Gql takeOnDemandSnapshot` | [takeOnDemandSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSnapshot -Operation TakeOnDemandSync` | `New-RscMutation -Gql takeOnDemandSnapshotSync` | [takeOnDemandSnapshotSync](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSnapshot -Operation TakeSaasOnDemand` | `New-RscMutation -Gql takeSaasOnDemandSnapshot` | [takeSaasOnDemandSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSnapshot -Operation UploadDatabaseToBlobstore` | `New-RscMutation -Gql uploadDatabaseSnapshotToBlobstore` | [uploadDatabaseSnapshotToBlobstore](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSnapshot -Operation UploadOnDemand` | `New-RscMutation -Gql uploadSnapshotOnDemand` | [uploadSnapshotOnDemand](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## SNMP domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQuerySnmp -Operation Configurations` | `New-RscQuery -Gql snmpConfigurations` | [snmpConfigurations](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationSnmp -Operation UpdateConfig` | `New-RscMutation -Gql updateSnmpConfig` | [updateSnmpConfig](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Sonar domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQuerySonar -Operation UserGroups` | `New-RscQuery -Gql sonarUserGroups` | [sonarUserGroups](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQuerySonar -Operation Users` | `New-RscQuery -Gql sonarUsers` | [sonarUsers](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |

[Go to top](#)
## Storage Arrays domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryStorageArray -Operation StorageArray` | `New-RscQuery -Gql allStorageArrays` | [allStorageArrays](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationStorageArray -Operation Add` | `New-RscMutation -Gql addStorageArrays` | [addStorageArrays](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationStorageArray -Operation Delete` | `New-RscMutation -Gql deleteStorageArrays` | [deleteStorageArrays](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationStorageArray -Operation Refresh` | `New-RscMutation -Gql refreshStorageArrays` | [refreshStorageArrays](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationStorageArray -Operation Update` | `New-RscMutation -Gql updateStorageArrays` | [updateStorageArrays](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Syslog domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQuerySyslog -Operation ExportRules` | `New-RscQuery -Gql syslogExportRules` | [syslogExportRules](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationSyslog -Operation AddExportRule` | `New-RscMutation -Gql addSyslogExportRule` | [addSyslogExportRule](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSyslog -Operation DeleteExportRule` | `New-RscMutation -Gql deleteSyslogExportRule` | [deleteSyslogExportRule](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSyslog -Operation TestExportRule` | `New-RscMutation -Gql testSyslogExportRule` | [testSyslogExportRule](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationSyslog -Operation UpdateExportRule` | `New-RscMutation -Gql updateSyslogExportRule` | [updateSyslogExportRule](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Tape domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationTape -Operation CreateReaderTarget` | `New-RscMutation -Gql createTapeReaderTarget` | [createTapeReaderTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationTape -Operation CreateTarget` | `New-RscMutation -Gql createTapeTarget` | [createTapeTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationTape -Operation UpdateTarget` | `New-RscMutation -Gql updateTapeTarget` | [updateTapeTarget](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Threat domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryThreat -Operation AnalyticsEnablement` | `New-RscQuery -Gql threatAnalyticsEnablement` | [threatAnalyticsEnablement](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryThreat -Operation Feeds` | `New-RscQuery -Gql threatFeeds` | [threatFeeds](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryThreat -Operation HuntDetail` | `New-RscQuery -Gql threatHuntDetail` | [threatHuntDetail](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryThreat -Operation HuntDetailV2` | `New-RscQuery -Gql threatHuntDetailV2` | [threatHuntDetailV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryThreat -Operation HuntMatchedSnapshots` | `New-RscQuery -Gql threatHuntMatchedSnapshots` | [threatHuntMatchedSnapshots](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryThreat -Operation HuntObjectMetrics` | `New-RscQuery -Gql threatHuntObjectMetrics` | [threatHuntObjectMetrics](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryThreat -Operation HuntResult` | `New-RscQuery -Gql threatHuntResult` | [threatHuntResult](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryThreat -Operation HuntSummary` | `New-RscQuery -Gql threatHuntSummary` | [threatHuntSummary](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryThreat -Operation HuntSummaryV2` | `New-RscQuery -Gql threatHuntSummaryV2` | [threatHuntSummaryV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryThreat -Operation HuntingObjectMatchedFiles` | `New-RscQuery -Gql threatHuntingObjectMatchedFiles` | [threatHuntingObjectMatchedFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryThreat -Operation Hunts` | `New-RscQuery -Gql threatHunts` | [threatHunts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryThreat -Operation MonitoringMatchedFileDetails` | `New-RscQuery -Gql threatMonitoringMatchedFileDetails` | [threatMonitoringMatchedFileDetails](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryThreat -Operation MonitoringMatchedFileDetailsV2` | `New-RscQuery -Gql threatMonitoringMatchedFileDetailsV2` | [threatMonitoringMatchedFileDetailsV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryThreat -Operation MonitoringMatchedFiles` | `New-RscQuery -Gql threatMonitoringMatchedFiles` | [threatMonitoringMatchedFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryThreat -Operation MonitoringMatchedObjects` | `New-RscQuery -Gql threatMonitoringMatchedObjects` | [threatMonitoringMatchedObjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryThreat -Operation MonitoringObjectEnablementStats` | `New-RscQuery -Gql threatMonitoringObjectEnablementStats` | [threatMonitoringObjectEnablementStats](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryThreat -Operation MonitoringObjects` | `New-RscQuery -Gql threatMonitoringObjects` | [threatMonitoringObjects](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryThreat -Operation ValidateBulkHunt` | `New-RscQuery -Gql validateBulkThreatHunt` | [validateBulkThreatHunt](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationThreat -Operation CancelHunt` | `New-RscMutation -Gql cancelThreatHunt` | [cancelThreatHunt](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationThreat -Operation EnableMonitoring` | `New-RscMutation -Gql enableThreatMonitoring` | [enableThreatMonitoring](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationThreat -Operation QuarantineHuntMatches` | `New-RscMutation -Gql quarantineThreatHuntMatches` | [quarantineThreatHuntMatches](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationThreat -Operation StartBulkHunt` | `New-RscMutation -Gql startBulkThreatHunt` | [startBulkThreatHunt](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationThreat -Operation StartHunt` | `New-RscMutation -Gql startThreatHunt` | [startThreatHunt](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationThreat -Operation StartHuntV2` | `New-RscMutation -Gql startThreatHuntV2` | [startThreatHuntV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationThreat -Operation StartTurboHunt` | `New-RscMutation -Gql startTurboThreatHunt` | [startTurboThreatHunt](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## VMware vSphere vCenter domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryVcenter -Operation AdvancedTagPreview` | `New-RscQuery -Gql vCenterAdvancedTagPreview` | [vCenterAdvancedTagPreview](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVcenter -Operation AsyncRequestStatus` | `New-RscQuery -Gql vcenterAsyncRequestStatus` | [vcenterAsyncRequestStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVcenter -Operation HotAddBandwidth` | `New-RscQuery -Gql vCenterHotAddBandwidth` | [vCenterHotAddBandwidth](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVcenter -Operation HotAddNetwork` | `New-RscQuery -Gql vCenterHotAddNetwork` | [vCenterHotAddNetwork](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVcenter -Operation HotAddProxy` | `New-RscQuery -Gql allVcenterHotAddProxyVms` | [allVcenterHotAddProxyVms](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVcenter -Operation HotAddProxyVmsV2` | `New-RscQuery -Gql vCenterHotAddProxyVmsV2` | [vCenterHotAddProxyVmsV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVcenter -Operation List` | `New-RscQuery -Gql vSphereVCenterConnection` | [vSphereVCenterConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVcenter -Operation Networks` | `New-RscQuery -Gql vCenterNetworks` | [vCenterNetworks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVcenter -Operation NumProxiesNeeded` | `New-RscQuery -Gql vCenterNumProxiesNeeded` | [vCenterNumProxiesNeeded](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVcenter -Operation PreAddInfo` | `New-RscQuery -Gql vCenterPreAddInfo` | [vCenterPreAddInfo](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVcenter -Operation Vcenter` | `New-RscQuery -Gql vSphereVCenter` | [vSphereVCenter](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationVcenter -Operation Create` | `New-RscMutation -Gql createVsphereVcenter` | [createVsphereVcenter](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVcenter -Operation Delete` | `New-RscMutation -Gql vsphereDeleteVcenter` | [vsphereDeleteVcenter](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVcenter -Operation Refresh` | `New-RscMutation -Gql refreshVsphereVcenter` | [refreshVsphereVcenter](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVcenter -Operation Update` | `New-RscMutation -Gql updateVcenter` | [updateVcenter](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVcenter -Operation UpdateHotAddBandwidth` | `New-RscMutation -Gql updateVcenterHotAddBandwidth` | [updateVcenterHotAddBandwidth](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVcenter -Operation UpdateHotAddNetwork` | `New-RscMutation -Gql updateVcenterHotAddNetwork` | [updateVcenterHotAddNetwork](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVcenter -Operation UpdateV2` | `New-RscMutation -Gql updateVcenterV2` | [updateVcenterV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## VMware domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryVmware -Operation CdpStateInfos` | `New-RscQuery -Gql allVmwareCdpStateInfos` | [allVmwareCdpStateInfos](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVmware -Operation IsManagementEnabled` | `New-RscQuery -Gql isVMwareManagementEnabled` | [isVMwareManagementEnabled](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVmware -Operation MissedRecoverableRanges` | `New-RscQuery -Gql vmwareMissedRecoverableRanges` | [vmwareMissedRecoverableRanges](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVmware -Operation RecoverableRanges` | `New-RscQuery -Gql vmwareRecoverableRanges` | [vmwareRecoverableRanges](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationVmware -Operation DownloadSnapshotFromLocation` | `New-RscMutation -Gql vmwareDownloadSnapshotFromLocation` | [vmwareDownloadSnapshotFromLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## VMware vSphere domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryVsphere -Operation ComputeCluster` | `New-RscQuery -Gql vSphereComputeCluster` | [vSphereComputeCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVsphere -Operation ComputeClusters` | `New-RscQuery -Gql vSphereComputeClusters` | [vSphereComputeClusters](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVsphere -Operation Datacenter` | `New-RscQuery -Gql vSphereDatacenter` | [vSphereDatacenter](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVsphere -Operation Datastore` | `New-RscQuery -Gql vSphereDatastore` | [vSphereDatastore](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVsphere -Operation DatastoreCluster` | `New-RscQuery -Gql vSphereDatastoreCluster` | [vSphereDatastoreCluster](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVsphere -Operation DatastoreClusters` | `New-RscQuery -Gql vSphereDatastoreClusters` | [vSphereDatastoreClusters](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVsphere -Operation DatastoreList` | `New-RscQuery -Gql vSphereDatastoreConnection` | [vSphereDatastoreConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVsphere -Operation Folder` | `New-RscQuery -Gql vSphereFolder` | [vSphereFolder](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVsphere -Operation Folders` | `New-RscQuery -Gql vSphereFolders` | [vSphereFolders](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVsphere -Operation Host` | `New-RscQuery -Gql vSphereHost` | [vSphereHost](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVsphere -Operation HostDetails` | `New-RscQuery -Gql vSphereHostDetails` | [vSphereHostDetails](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVsphere -Operation HostList` | `New-RscQuery -Gql vSphereHostConnection` | [vSphereHostConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVsphere -Operation HostsByFids` | `New-RscQuery -Gql vSphereHostsByFids` | [vSphereHostsByFids](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVsphere -Operation LiveMounts` | `New-RscQuery -Gql vSphereLiveMounts` | [vSphereLiveMounts](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVsphere -Operation Mount` | `New-RscQuery -Gql vSphereMount` | [vSphereMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVsphere -Operation MountList` | `New-RscQuery -Gql vSphereMountConnection` | [vSphereMountConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVsphere -Operation Network` | `New-RscQuery -Gql vSphereNetwork` | [vSphereNetwork](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVsphere -Operation ResourcePool` | `New-RscQuery -Gql vSphereResourcePool` | [vSphereResourcePool](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVsphere -Operation ResourcePoolWithProvisionOnInfrastructure` | `New-RscQuery -Gql vSphereResourcePoolWithProvisionOnInfrastructure` | [vSphereResourcePoolWithProvisionOnInfrastructure](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVsphere -Operation RootRecoveryHierarchy` | `New-RscQuery -Gql vSphereRootRecoveryHierarchy` | [vSphereRootRecoveryHierarchy](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVsphere -Operation Tag` | `New-RscQuery -Gql vSphereTag` | [vSphereTag](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVsphere -Operation TagCategory` | `New-RscQuery -Gql vSphereTagCategory` | [vSphereTagCategory](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVsphere -Operation TopLevelDescendantsList` | `New-RscQuery -Gql vSphereTopLevelDescendantsConnection` | [vSphereTopLevelDescendantsConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVsphere -Operation TopLevelRecoveryTargets` | `New-RscQuery -Gql vSphereTopLevelRecoveryTargets` | [vSphereTopLevelRecoveryTargets](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVsphere -Operation VmsByFids` | `New-RscQuery -Gql allVsphereVmsByFids` | [allVsphereVmsByFids](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVsphere -Operation VmwareCdpLiveInfo` | `New-RscQuery -Gql vsphereVmwareCdpLiveInfo` | [vsphereVmwareCdpLiveInfo](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationVsphere -Operation BulkOnDemandSnapshot` | `New-RscMutation -Gql vsphereBulkOnDemandSnapshot` | [vsphereBulkOnDemandSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVsphere -Operation CreateAdvancedTag` | `New-RscMutation -Gql createVsphereAdvancedTag` | [createVsphereAdvancedTag](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVsphere -Operation DeleteAdvancedTag` | `New-RscMutation -Gql deleteVsphereAdvancedTag` | [deleteVsphereAdvancedTag](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVsphere -Operation DeleteLiveMount` | `New-RscMutation -Gql deleteVsphereLiveMount` | [deleteVsphereLiveMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVsphere -Operation DownloadVirtualMachineFiles` | `New-RscMutation -Gql downloadVsphereVirtualMachineFiles` | [downloadVsphereVirtualMachineFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVsphere -Operation ExportSnapshotToStandaloneHostV2` | `New-RscMutation -Gql vsphereExportSnapshotToStandaloneHostV2` | [vsphereExportSnapshotToStandaloneHostV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVsphere -Operation OnDemandSnapshot` | `New-RscMutation -Gql vsphereOnDemandSnapshot` | [vsphereOnDemandSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVsphere -Operation SnapshotConsistency` | `New-RscMutation -Gql vsphereSnapshotConsistency` | [vsphereSnapshotConsistency](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVsphere -Operation SnapshotDownloadFilesFromLocation` | `New-RscMutation -Gql vsphereSnapshotDownloadFilesFromLocation` | [vsphereSnapshotDownloadFilesFromLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVsphere -Operation SnapshotRestoreFilesFromLocation` | `New-RscMutation -Gql vsphereSnapshotRestoreFilesFromLocation` | [vsphereSnapshotRestoreFilesFromLocation](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVsphere -Operation UpdateAdvancedTag` | `New-RscMutation -Gql updateVsphereAdvancedTag` | [updateVsphereAdvancedTag](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVsphere -Operation UpdateVmNew` | `New-RscMutation -Gql updateVsphereVmNew` | [updateVsphereVmNew](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## VMware vSphere VM domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryVsphereVm -Operation AsyncRequestStatus` | `New-RscQuery -Gql vSphereVMAsyncRequestStatus` | [vSphereVMAsyncRequestStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVsphereVm -Operation MissedRecoverableRange` | `New-RscQuery -Gql vsphereVMMissedRecoverableRange` | [vsphereVMMissedRecoverableRange](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVsphereVm -Operation New` | `New-RscQuery -Gql vSphereVmNew` | [vSphereVmNew](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVsphereVm -Operation NewList` | `New-RscQuery -Gql vSphereVmNewConnection` | [vSphereVmNewConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVsphereVm -Operation RecoverableRange` | `New-RscQuery -Gql vsphereVMRecoverableRange` | [vsphereVMRecoverableRange](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVsphereVm -Operation RecoverableRangeInBatch` | `New-RscQuery -Gql vsphereVMRecoverableRangeInBatch` | [vsphereVMRecoverableRangeInBatch](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVsphereVm -Operation RecoveryRangeStatuses` | `New-RscQuery -Gql vsphereVmRecoveryRangeStatuses` | [vsphereVmRecoveryRangeStatuses](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryVsphereVm -Operation WithProvisionOnInfrastructure` | `New-RscQuery -Gql vSphereVmWithProvisionOnInfrastructure` | [vSphereVmWithProvisionOnInfrastructure](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationVsphereVm -Operation BatchExport` | `New-RscMutation -Gql vsphereVmBatchExport` | [vsphereVmBatchExport](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVsphereVm -Operation BatchExportV3` | `New-RscMutation -Gql vsphereVmBatchExportV3` | [vsphereVmBatchExportV3](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVsphereVm -Operation BatchInPlaceRecovery` | `New-RscMutation -Gql vsphereVmBatchInPlaceRecovery` | [vsphereVmBatchInPlaceRecovery](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVsphereVm -Operation DeleteSnapshot` | `New-RscMutation -Gql vsphereVmDeleteSnapshot` | [vsphereVmDeleteSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVsphereVm -Operation DownloadSnapshot` | `New-RscMutation -Gql vsphereVmDownloadSnapshot` | [vsphereVmDownloadSnapshot](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVsphereVm -Operation DownloadSnapshotFiles` | `New-RscMutation -Gql vsphereVmDownloadSnapshotFiles` | [vsphereVmDownloadSnapshotFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVsphereVm -Operation ExcludeVmDisks` | `New-RscMutation -Gql vsphereExcludeVmDisks` | [vsphereExcludeVmDisks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVsphereVm -Operation ExportSnapshotV2` | `New-RscMutation -Gql vsphereVmExportSnapshotV2` | [vsphereVmExportSnapshotV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVsphereVm -Operation ExportSnapshotV3` | `New-RscMutation -Gql vsphereVmExportSnapshotV3` | [vsphereVmExportSnapshotV3](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVsphereVm -Operation ExportSnapshotWithDownloadFromCloud` | `New-RscMutation -Gql vsphereVmExportSnapshotWithDownloadFromCloud` | [vsphereVmExportSnapshotWithDownloadFromCloud](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVsphereVm -Operation InitiateBatchInstantRecovery` | `New-RscMutation -Gql vsphereVmInitiateBatchInstantRecovery` | [vsphereVmInitiateBatchInstantRecovery](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVsphereVm -Operation InitiateBatchLiveMountV2` | `New-RscMutation -Gql vsphereVmInitiateBatchLiveMountV2` | [vsphereVmInitiateBatchLiveMountV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVsphereVm -Operation InitiateDiskMount` | `New-RscMutation -Gql vsphereVmInitiateDiskMount` | [vsphereVmInitiateDiskMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVsphereVm -Operation InitiateInPlaceRecovery` | `New-RscMutation -Gql vsphereVmInitiateInPlaceRecovery` | [vsphereVmInitiateInPlaceRecovery](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVsphereVm -Operation InitiateInstantRecoveryV2` | `New-RscMutation -Gql vsphereVmInitiateInstantRecoveryV2` | [vsphereVmInitiateInstantRecoveryV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVsphereVm -Operation InitiateLiveMountV2` | `New-RscMutation -Gql vsphereVmInitiateLiveMountV2` | [vsphereVmInitiateLiveMountV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVsphereVm -Operation ListEsxiDatastores` | `New-RscMutation -Gql vsphereVmListEsxiDatastores` | [vsphereVmListEsxiDatastores](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVsphereVm -Operation MountRelocate` | `New-RscMutation -Gql vsphereVmMountRelocate` | [vsphereVmMountRelocate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVsphereVm -Operation MountRelocateV2` | `New-RscMutation -Gql vsphereVmMountRelocateV2` | [vsphereVmMountRelocateV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVsphereVm -Operation PowerOnOffLiveMount` | `New-RscMutation -Gql vsphereVmPowerOnOffLiveMount` | [vsphereVmPowerOnOffLiveMount](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVsphereVm -Operation RecoverFiles` | `New-RscMutation -Gql vsphereVmRecoverFiles` | [vsphereVmRecoverFiles](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVsphereVm -Operation RecoverFilesNew` | `New-RscMutation -Gql vsphereVmRecoverFilesNew` | [vsphereVmRecoverFilesNew](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVsphereVm -Operation RefreshAgent` | `New-RscMutation -Gql vsphereVmRefreshAgent` | [vsphereVmRefreshAgent](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVsphereVm -Operation RegisterAgent` | `New-RscMutation -Gql vsphereVmRegisterAgent` | [vsphereVmRegisterAgent](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVsphereVm -Operation RegisterAgentWithOrg` | `New-RscMutation -Gql vsphereVmRegisterAgentWithOrg` | [vsphereVmRegisterAgentWithOrg](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVsphereVm -Operation UnregisterAgent` | `New-RscMutation -Gql vsphereVmUnregisterAgent` | [vsphereVmUnregisterAgent](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVsphereVm -Operation Update` | `New-RscMutation -Gql updateVsphereVm` | [updateVsphereVm](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVsphereVm -Operation UpdateAgentCertificate` | `New-RscMutation -Gql vsphereVmUpdateAgentCertificate` | [vsphereVmUpdateAgentCertificate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationVsphereVm -Operation UpdateUnmountTime` | `New-RscMutation -Gql vsphereVmUpdateUnmountTime` | [vsphereVmUpdateUnmountTime](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
## Webhook domain

### Queries

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscQueryWebhook -Operation ById` | `New-RscQuery -Gql webhookById` | [webhookById](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryWebhook -Operation MessageTemplateById` | `New-RscQuery -Gql webhookMessageTemplateById` | [webhookMessageTemplateById](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryWebhook -Operation MessageTemplates` | `New-RscQuery -Gql allWebhookMessageTemplates` | [allWebhookMessageTemplates](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryWebhook -Operation V2` | `New-RscQuery -Gql allWebhooksV2` | [allWebhooksV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscQueryWebhook -Operation Webhook` | `New-RscQuery -Gql allWebhooks` | [allWebhooks](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
### Mutations

| Old (deprecated) | New (recommended) | GraphQL Root Field |
| --- | --- | --- |
| `New-RscMutationWebhook -Operation Create` | `New-RscMutation -Gql createWebhook` | [createWebhook](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationWebhook -Operation CreateV2` | `New-RscMutation -Gql createWebhookV2` | [createWebhookV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationWebhook -Operation Delete` | `New-RscMutation -Gql deleteWebhook` | [deleteWebhook](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationWebhook -Operation DeleteV2` | `New-RscMutation -Gql deleteWebhookV2` | [deleteWebhookV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationWebhook -Operation GeneratePreviewMessageForTemplate` | `New-RscMutation -Gql generatePreviewMessageForWebhookTemplate` | [generatePreviewMessageForWebhookTemplate](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationWebhook -Operation SendTestMessageTo` | `New-RscMutation -Gql sendTestMessageToWebhook` | [sendTestMessageToWebhook](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationWebhook -Operation SendTestMessageToExisting` | `New-RscMutation -Gql sendTestMessageToExistingWebhook` | [sendTestMessageToExistingWebhook](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationWebhook -Operation Test` | `New-RscMutation -Gql testWebhook` | [testWebhook](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationWebhook -Operation TestExisting` | `New-RscMutation -Gql testExistingWebhook` | [testExistingWebhook](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationWebhook -Operation Update` | `New-RscMutation -Gql updateWebhook` | [updateWebhook](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationWebhook -Operation UpdateStatus` | `New-RscMutation -Gql updateWebhookStatus` | [updateWebhookStatus](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |
| `New-RscMutationWebhook -Operation UpdateV2` | `New-RscMutation -Gql updateWebhookV2` | [updateWebhookV2](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/query.doc.html) |

[Go to top](#)
