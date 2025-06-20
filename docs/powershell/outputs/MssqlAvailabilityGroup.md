### MssqlAvailabilityGroup
SQL Server always on availability group.

- copyOnly: System.Boolean
  - CopyOnly flag of the availability group.
- logBackupFrequencyInSeconds: System.Int64
  - Number of seconds between two log backups. When the value is set to 0, log backups are not enabled. When the value is set to -1, the default log backup frequency of the Rubrik cluster is used. When the value is set to -2, the log backup frequency is derived from the SLA Domain.
- logBackupRetentionInHours: System.Int32
  - Number of hours to retain a log backup. When the value is set to -1, the Rubrik cluster retains the log backup until the database snapshots that precede the log backup have expired. When the value is set to -2, the default log backup retention of the Rubrik cluster is used. When the value is set to -3, the log backup retention is derived from the SLA Domain.
- hostLogRetention: System.Int64
  - Interval, in seconds, between the deletion of archived log files whose 'nextTime' field specifies a time longer than this interval. To specify an interval, enter a positive integer. To immediately delete archived log files regardless of age, specify an interval of -1. To preserve all archived log files, specify an interval of -2.
- hasLogConfigFromSla: System.Boolean
  - Boolean flag indicating if the availability group derives log backup configurations from SLA.
- instances: list of MssqlInstances
  - The list of instances associated with an availability group.
- descendantConnection: MssqlAvailabilityGroupDescendantTypeConnection
  - List of descendants.
- logicalChildConnection: MssqlAvailabilityGroupLogicalChildTypeConnection
  - List of logical children.
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
- cdmPendingObjectPauseAssignment: PendingObjectPauseAssignmentStatus
  - Object pause pending assignment details for CDM objects.
- authorizedOperations: list of Operations
  - The authorized operations on the object.
