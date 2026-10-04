### AzureCosmosNosqlContainer
An Azure Cosmos NoSQL container. Refers to the unit of scalability and the
item namespace within a Cosmos NoSQL database. For more info, see
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
- cosmosDbDatabaseId: System.String
  - Rubrik ID of the Azure Cosmos NoSQL database that owns the container.
- cloudNativeId: System.String
  - Azure resource ID of the Azure Cosmos NoSQL container.
- containerName: System.String
  - Name of the Azure Cosmos NoSQL container.
- databaseName: System.String
  - Name of the Azure Cosmos NoSQL database that owns the container.
- accountName: System.String
  - Name of the Azure Cosmos NoSQL account that owns the container.
- region: AzureNativeRegion
  - Azure region where the Azure Cosmos NoSQL container is located.
- isRelic: System.Boolean
  - Specifies whether the Azure Cosmos NoSQL container is a relic or not. A
container is a relic when it is unprotected or deleted, but the previously
taken snapshots of the container continue to exist within the Rubrik
ecosystem.
- partitionKeyPath: System.String
  - Path of the partition key of the container. Example: /customerId.
- defaultTtlSeconds: System.Int32
  - Time-to-live in seconds applied to items that do not set their own.
- throughputMode: AzureCosmosNosqlThroughputMode
  - How throughput is provisioned for the container.
- throughputScope: AzureCosmosNosqlThroughputScope
  - Level of the Cosmos NoSQL hierarchy that provisions the reported
throughput. A container under a shared-throughput database reports the
database as the scope.
- throughputRuPerSec: System.Int32
  - Provisioned request units per second, at the level named by
throughputScope.
- autoscaleMaxRuPerSec: System.Int32
  - Ceiling for autoscale throughput, in request units per second. Zero when
throughputMode is not autoscale.
- indexingMode: System.String
  - Indexing mode of the container. Examples: consistent, lazy, none.
- isIndexingAutomatic: System.Boolean
  - Specifies whether the container indexes items automatically.
- indexedPathCount: System.Int32
  - Number of included paths in the indexing policy of the container.
- excludedPathCount: System.Int32
  - Number of excluded paths in the indexing policy of the container.
- conflictResolutionMode: System.String
  - Conflict resolution mode of the container. Examples: LastWriterWins,
Custom. Empty when the container reports no conflict resolution policy.
- conflictResolutionPath: System.String
  - Item path compared to resolve conflicts when conflictResolutionMode is
LastWriterWins. Example: /_ts.
- conflictResolutionProcedure: System.String
  - Stored procedure that resolves conflicts when conflictResolutionMode is
Custom.
- uniqueKeyCount: System.Int32
  - Number of unique keys in the unique key policy of the container. Zero when
the container enforces no uniqueness constraint.
- uniqueKeyPaths: System.String
  - Unique key policy of the container, encoded as a single value. A unique key
is itself a list of paths, so the paths within one unique key are joined
with a comma and the unique keys are joined with a semicolon. Example:
/name/first,/name/last;/email.
- backupSetupSourceObject: PathNode
  - The object from where the setup for performing backups of the Azure Cosmos
NoSQL container is inherited.
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
- snapshotConnection: PolarisSnapshotConnection
  - The list of snapshots taken for this workload.
- workloadSnapshotConnection: GenericSnapshotConnection
  - The list of snapshots taken for this workload.
- snapshotGroupByConnection: PolarisSnapshotGroupByConnection
  - Group-by connection for the snapshots of this workload.
- snapshotGroupByNewConnection: PolarisSnapshotGroupByNewConnection
  - Group-by connection for the snapshots of this workload.
- newestSnapshot: PolarisSnapshot
  - The most recent snapshot of this workload.
- oldestSnapshot: PolarisSnapshot
  - The oldest snapshot of this workload.
- onDemandSnapshotCount: System.Int32
  - The number of on-demand snapshots.
- newestIndexedSnapshot: PolarisSnapshot
  - The latest snapshot that is indexed and unexpired, and therefore restorable.
