### MssqlHost
Microsoft SQL Host.

- cdmId: System.String
  - ID associated with the Microsoft SQL Host in CDM.
- physicalHostMetadata: PhysicalHostMetadata
  - Metadata of the underlying physical host.
- descendantConnection: MssqlHostDescendantTypeConnection
  - List of descendants.
- physicalChildConnection: MssqlHostPhysicalChildTypeConnection
  - List of physical children.
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
  - Sequential list of this object's logical ancestors.
- physicalPath: list of PathNodes
  - Sequential list of this object's physical ancestors.
- numWorkloadDescendants: System.Int32
  - Number of descendant workloads of this object.
- allOrgs: list of Orgs
  - Organizations to which this hierarchy object belongs.
- securityMetadata: SecurityMetadata
  - Security posture metadata.
- cluster: Cluster
  - Rubrik cluster where this object originated.
- primaryClusterLocation: DataLocation
  - The source cluster of this object. Returned as a data location because there is no guarantee that Rubrik has knowledge about the source cluster.
- pendingSla: SlaDomain
  - SLA Domain assignment of the object during the process of being communicated over to Rubrik CDM.
- pendingObjectDeletionStatus: PendingSnapshotsOfObjectDeletion
  - Mapping from object ID to pending object deletion status.
- replicatedObjects: list of CdmHierarchyObjects
  - Objects either replicated by this object or related to this object by replication.
- crossAccountReplicatedObjectInfos: list of CrossAccountReplicatedObjectInfos
  - Cross-account objects either replicated by this object or related to this object by replication.
- latestUserNote: LatestUserNote
  - Latest user note information.
- replicatedObjectCount: System.Int32
  - The number of objects either replicated by this object or related to this object by replication.
- authorizedOperations: list of Operations
  - The authorized operations on the object.