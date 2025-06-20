### AzureStorageAccount
An Azure storage account that contains Azure storage data objects including blobs, file shares, queues, tables, and disks. For more information, see https://learn.microsoft.com/en-us/azure/storage/common/storage-account-overview.

- tags: list of AzureTags
  - Tags attached to the storage account.
- isRelic: System.Boolean
  - Specifies whether the storage account is a relic. When the value is true, the storage account is a relic. A storage account is a relic when it is unprotected or deleted, but the previously taken snapshots of the storage account continue to exist within the Rubrik ecosystem.
- cloudNativeId: System.String
  - Native ID of the storage account.
- nativeName: System.String
  - Native name of the storage account.
- region: AzureNativeRegion
  - Region where the storage account is located.
- usedCapacityBytes: System.Int64
  - The used capacity bytes of the storage account.
- accessTier: AzureStorageAccessTier
  - The access tier of the storage account.
- numContainers: System.Int64
  - The number of containers in the storage account.
- numExcludedContainers: System.Int64
  - The number of containers excluded from protection by the customer in the storage account.
- accountKind: AzureStorageAccountKind
  - The Storage Account type.
- isHierarchicalNamespaceEnabled: System.Boolean
  - Specifies whether hierarchical namespace is enabled for the storage account or not. When the value is true, hierarchical namespace is enabled.
- authorizedOperations: list of PolarisSnappableAuthorizedOperationsEnums
  - The authorized operations on the object.
- resourceGroup: AzureNativeResourceGroup
  - Resource Group of the Azure storage account.
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
- snapshotConnection: PolarisSnapshotConnection
  - The list of snapshots taken for this workload.
- workloadSnapshotConnection: GenericSnapshotConnection
  - The list of snapshots taken for this workload.
- snapshotGroupByConnection: PolarisSnapshotGroupByConnection
  - GroupBy connection for the snapshots of this workload.
- snapshotGroupByNewConnection: PolarisSnapshotGroupByNewConnection
  - GroupBy connection for the snapshots of this workload.
- newestSnapshot: PolarisSnapshot
  - The most recent snapshot of this workload.
- oldestSnapshot: PolarisSnapshot
  - The oldest snapshot of this workload.
- onDemandSnapshotCount: System.Int32
  - The number of on-demand snapshots.
- newestIndexedSnapshot: PolarisSnapshot
  - The latest snapshot that is indexed and unexpired, and therefore restorable.
