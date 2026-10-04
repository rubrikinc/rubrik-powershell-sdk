### AzureCosmosNosqlDatabase
An Azure Cosmos NoSQL database. Refers to the container namespace within a
Cosmos NoSQL account. For more info, see
https://learn.microsoft.com/en-us/azure/cosmos-nosql/resource-model.

- id: System.String
  - ID of the hierarchy object.
- name: System.String
  - Name of the hierarchy object.
- objectType: HierarchyObjectTypeEnum
  - Type of this object.
- slaAssignment: SlaAssignmentTypeEnum
  - SLA Domain assignment type for this object.
- logicalPath: list of PathNodes
  - Sequential list of the logical ancestors of this object.
- physicalPath: list of PathNodes
  - Sequential list of the physical ancestors of this object.
- effectiveSlaSourceObject: PathNode
  - Path node of the effective SLA Domain source.
- securityMetadata: SecurityMetadata
  - Security posture metadata.
- cosmosDbAccountId: System.String
  - Rubrik ID of the Azure Cosmos NoSQL account that owns the database.
- cloudNativeId: System.String
  - Azure resource ID of the Azure Cosmos NoSQL database.
- databaseName: System.String
  - Name of the Azure Cosmos NoSQL database.
- region: AzureNativeRegion
  - Azure region where the Azure Cosmos NoSQL database is located.
- throughputMode: AzureCosmosNosqlThroughputMode
  - How throughput is provisioned for the database. Populated only when
throughput is provisioned at the database level and shared across its
containers.
- throughputRuPerSec: System.Int32
  - Provisioned request units per second shared across the containers of the
database.
- autoscaleMaxRuPerSec: System.Int32
  - Ceiling for autoscale throughput, in request units per second. Zero when
throughputMode is not autoscale.
- isProtectable: System.Boolean
  - Specifies whether the Azure Cosmos NoSQL database is protectable.
- authorizedOperations: list of Operations
  - The authorized operations on the object.
- slaPauseStatus: System.Boolean
  - Pause status of the effective SLA Domain of the hierarchy object.
- effectiveSlaDomain: SlaDomain
  - Effective SLA Domain of the hierarchy object.
- effectiveRetentionSlaDomain: SlaDomain
  - Effective retention of the SLA Domain of the hierarchy object.
- configuredSlaDomain: SlaDomain
  - SLA Domain configured for the hierarchy object.
- rscNativeObjectPendingSla: CompactSlaDomain
  - SLA Domain assignment which is pending on the Rubrik Security Cloud native objects.
- rscPendingObjectPauseAssignment: PendingObjectPauseAssignmentStatus
  - Pending pause or unpause assignment for RSC-native objects.
- snapshotDistribution: SnapshotDistribution
  - Distribution of the snapshots of the hierarchy object.
- numWorkloadDescendants: System.Int32
  - Number of descendant workloads of this object.
- allTags: list of AssignedRscTags
  - RSC tags to which this hierarchy object is assigned.
- objectPauseStatus: ObjectPauseStatus
  - Pause status of the hierarchy object.
- objectBackupWindow: ObjectBackupWindowStatus
  - Object-level backup window status of the hierarchy object.
- legallyHeldSnapshotCount: System.Int32
  - Number of snapshots on legal hold for this object.
- futureLegalHoldInfo: FutureLegalHoldInfo
  - Future legal hold rule configured for this object, if any.
- allOrgs: list of Orgs
  - Organizations to which this hierarchy object belongs.
