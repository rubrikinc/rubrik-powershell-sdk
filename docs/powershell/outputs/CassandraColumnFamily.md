### CassandraColumnFamily
Cassandra Column Family information.

- clusterUuid: System.String
  - UUID of the Mosaic cluster.
- backupCount: System.Int32
  - Number of backups for the column family.
- protectionDate: System.String
  - Date that effective SLA was assigned / inherited.
- backupParams: CassandraBackupParams
  - Backup Params of the source.
- isRelic: System.Boolean
  - Is the source object a relic.
- authorizedOperations: list of PolarisObjectAuthorizedOperationsEnums
  - The authorized operations on the object.
- id: System.String
  - The source object ID.
- source: CassandraSource
  - Parent source connection.
- keyspace: CassandraKeyspace
  - Parent keyspace connection.
- cluster: Cluster
  - Mosaic cluster information.
- snapshots: MosaicSnapshotConnection
  - The list of snapshots taken for this workload.
- snapshotGroupBys: MosaicSnapshotGroupByTypeConnection
  - GroupBy connection for this workload's snapshots.
- newestSnapshot: MosaicSnapshot
  - The most recent snapshot of this workload.
- oldestSnapshot: MosaicSnapshot
  - The oldest snapshot of this workload.
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
- securityMetadata: SecurityMetadata
  - Security posture metadata.
- rscNativeObjectPendingSla: CompactSlaDomain
  - SLA Domain assignment which is pending on the Rubrik Security Cloud native objects.
