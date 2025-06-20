### CloudDirectNasNamespace
NAS Cloud Direct namespace object.

- clusterUuid: System.String
  - NAS Cloud Direct cluster ID.
- cloudDirectId: System.String
  - UUID of the NAS Cloud Direct namespace on the NCD Cluster.
- systemId: System.String
  - SystemID of the system to which the NAS Cloud Direct namespace belongs.
- namespaceName: System.String
  - Name of the namespace.
- isArchived: System.Boolean
  - Specifies whether the namespace is archived.
- isHidden: System.Boolean
  - Specifies whether the namespace is hidden.
- isStale: System.Boolean
  - Specifies whether the namespace is stale.
- id: System.String
  - Object ID.
- cloudDirectNasSystem: CloudDirectNasSystem
  - The NAS Cloud Direct system to which this NAS namespace belongs.
- descendantConnection: CloudDirectNasNamespaceDescendantTypeConnection
  - List of descendants.
- logicalChildConnection: CloudDirectNasNamespaceLogicalChildTypeConnection
  - List of logical children.
- objectCount: System.Int32
  - Total number of objects in this NAS namespace.
- cluster: Cluster
  - NAS Cloud Direct cluster where this object originated.
- authorizedOperations: list of Operations
  - The authorized operations on the object.
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
