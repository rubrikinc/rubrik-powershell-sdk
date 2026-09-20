### AzureCosmosNosqlAccount
An Azure Cosmos NoSQL account. Refers to the top-level Cosmos NoSQL resource
that owns databases and containers. For more info, see
https://learn.microsoft.com/en-us/azure/cosmos-nosql/introduction.

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
- rscPendingObjectPauseAssignment: PendingObjectPauseAssignmentStatus
  - Object pause pending assignment details for RSC objects.
- cloudNativeId: System.String
  - Azure resource ID of the Azure Cosmos NoSQL account.
- accountName: System.String
  - Name of the Azure Cosmos NoSQL account.
- tags: list of AzureTags
  - List of tags associated with the Azure Cosmos NoSQL account.
- region: AzureNativeRegion
  - Azure region where the Azure Cosmos NoSQL account is located.
- kind: System.String
  - Cosmos NoSQL API kind of the account. Inventory covers the NoSQL API,
reported as GlobalDocumentDB.
- isContinuousBackupEnabled: System.Boolean
  - Specifies whether the account uses a continuous backup policy rather than a
periodic one.
- isPartitionMergeEnabled: System.Boolean
  - Specifies whether partition merge is permitted on the account. This is a
capability flag, not a record of past merges.
- defaultConsistencyLevel: System.String
  - Default consistency level of the account. Examples: Strong,
BoundedStaleness, Session, ConsistentPrefix, Eventual.
- networkAccessMode: AzureCosmosNosqlNetworkAccessMode
  - Reachability of the account, derived from its public network access, IP
rule, virtual network filter and private endpoint settings.
- isLocalAuthDisabled: System.Boolean
  - Specifies whether key-based authentication is turned off, leaving Microsoft
Entra ID as the only way to authenticate.
- publicNetworkAccess: System.String
  - Raw public network access value reported by Azure. This is the audit anchor
for the derived networkAccessMode.
- isServerless: System.Boolean
  - Specifies whether the account has the serverless capability. Serverless
accounts have no provisioned throughput.
- isProtectable: System.Boolean
  - Specifies whether the Azure Cosmos NoSQL account is protectable.
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
- allOrgs: list of Orgs
  - Organizations to which this hierarchy object belongs.
