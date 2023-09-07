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
  - The FID of the hierarchy object.
- name: System.String
  - The name of the hierarchy object.
- objectType: HierarchyObjectTypeEnum
  - The type of this object.
- slaAssignment: SlaAssignmentTypeEnum
  - The SLA Domain assignment type for this object.
- effectiveSlaDomain: SlaDomain
  - The effective SLA Domain of the hierarchy object.
- slaPauseStatus: System.Boolean
  - The pause status of the effective SLA Domain of the hierarchy object.
- snapshotDistribution: SnapshotDistribution
  - The distribution of the snapshots of the hierarchy object.
- effectiveRetentionSlaDomain: SlaDomain
  - The effective retention of the SLA Domain of the hierarchy object.
- configuredSlaDomain: SlaDomain
  - The SLA Domain configured for the hierarchy object.
- effectiveSlaSourceObject: PathNode
  - The path node of the effective SLA Domain source.
- logicalPath: list of PathNodes
  - A sequential list of this object's logical ancestors.
- physicalPath: list of PathNodes
  - A sequential list of this object's physical ancestors.
- numWorkloadDescendants: System.Int32
  - The number of descendant workloads of this object.
- allOrgs: list of Orgs
  - The organizations to which this hierarchy object belongs.
- cluster: Cluster
  - Rubrik cluster where this object originated.
- primaryClusterLocation: DataLocation
  - The source cluster of this object. Returned as a data location because there is no guarantee that Rubrik has knowledge about the source cluster.
- pendingSla: SlaDomain
  - SLA Domain assignment of the object during the process of being communicated over to Rubrik CDM.
- pendingObjectDeletionStatus: PendingSnapshotsOfObjectDeletion
  - Mapping from objectID to pending object deletion status.
- replicatedObjects: list of CdmHierarchyObjects
  - Objects either replicated by this object or related to this object by replication.
- latestUserNote: LatestUserNote
  - Latest User note information.
- replicatedObjectCount: System.Int32
  - The number of objects either replicated by this object or related to this object by replication.
- authorizedOperations: list of Operations
  - The authorized operations on the object.