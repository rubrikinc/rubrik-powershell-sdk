### AzureSqlManagedInstanceServer
Retrieves an Azure SQL Managed Instance Server. Refers to the server the Azure SQL Managed Instance Database is a part of.

- serverName: System.String
  - Name of the Azure SQL Managed Instance Server.
- tags: list of AzureTags
  - List of tags associated with the Azure SQL Managed Instance Server.
- vCoresCount: System.Int32
  - Count of the vCores in the Azure SQL Managed Instance Server.
- backupStorageRedundancy: AzureSqlBackupStorageRedundancyType
  - Type of backup storage redundancy. Examples: LRS, ZRS, GRS.
- storageSizeGib: System.Int64
  - Storage size of the Azure SQL Managed Instance Server, in GiB.
- instancePoolName: System.String
  - Name of the Instance Pool the Azure SQL Managed Instance Server belongs to.
- serviceTier: System.String
  - Service Tier associated with the Azure SQL Managed Instance Server.
- region: AzureNativeRegion
  - Azure region where the Azure SQL Managed Instance Server is located.
- vnetName: System.String
  - Name of the Virtual Network associated with the Azure SQL Managed Instance Server.
- subnetName: System.String
  - Name of the subnet associated with the Azure SQL Managed Instance Server.
- backupSetupSourceObject: PathNode
  - The object from where the setup for performing backups of Azure SQL Managed Instance Databases is inherited.
- authorizedOperations: list of PolarisSnappableAuthorizedOperationsEnums
  - The authorized operations on the object.
- azureNativeResourceGroup: AzureNativeResourceGroup
  - Resource Group of the Azure SQL Managed Instance Server.
- rscNativeObjectPendingSla: CompactSlaDomain
  - SLA Domain assignment which is pending on the Rubrik Security Cloud native objects.
- rscPendingObjectPauseAssignment: PendingObjectPauseAssignmentStatus
  - Object pause pending assignment details for RSC objects.
- id: System.String
  - FID of the hierarchy object.
- name: System.String
  - Name of the hierarchy object.
- objectType: HierarchyObjectTypeEnum
  - Type of this object.
- slaAssignment: SlaAssignmentTypeEnum
  - SLA Domain assignment type for this object.
- effectiveSlaDomain: SlaDomain
  - Effective SLA Domain of the hierarchy object.
- slaPauseStatus: System.Boolean
  - Pause status of the effective SLA Domain of the hierarchy object.
- snapshotDistribution: SnapshotDistribution
  - Distribution of the snapshots of the hierarchy object.
- effectiveRetentionSlaDomain: SlaDomain
  - Effective retention of the SLA Domain of the hierarchy object.
- configuredSlaDomain: SlaDomain
  - SLA Domain configured for the hierarchy object.
- effectiveSlaSourceObject: PathNode
  - Path node of the effective SLA Domain source.
- logicalPath: list of PathNodes
  - Sequential list of the logical ancestors of this object.
- physicalPath: list of PathNodes
  - Sequential list of the physical ancestors of this object.
- numWorkloadDescendants: System.Int32
  - Number of descendant workloads of this object.
- allOrgs: list of Orgs
  - Organizations to which this hierarchy object belongs.
- securityMetadata: SecurityMetadata
  - Security posture metadata.
- objectPauseStatus: ObjectPauseStatus
  - Pause status of the hierarchy object.
