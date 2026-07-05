### MongoOpsManagerManagedSourceRecoveryRequestConfigInput
Supported in v9.3+
Configuration for recovering a MongoDB source managed by Ops Manager from a source to a target cluster.

- recoveryMode: MongoOpsManagerManagedSourceRecoveryRequestConfigRecoveryMode
  - Supported in v9.6+
Recovery mode. Defaults to All (every node receives data) when omitted, preserving the historical behavior. Reachable and Custom are not yet generally available in Ops Manager — use only when specifically advised by Rubrik Support. Reachable restores only RBS-reachable nodes; remaining cluster members resync using MongoDB native replication. Custom restores the caller-supplied node set; remaining cluster members resync.
- sourceMongoClusterId: System.String
  - Required. Supported in v9.3+
Managed ID of the MongoDB source cluster.
- restoreTime: DateTime
  - Required. Time of the source cluster to which the target cluster should be restored, using the ISO8601 format 2016-01-01T01:23:45.678. The restore will happen to the latest available snapshot before the specified time.
- customNodes: list of MongoOpsManagerCustomNodeConfigInputs
  - Supported in v9.6+
Required when recoveryMode is Custom. Each entry identifies a Rubrik-registered host (by hostId) and the mongod port. Listed nodes get the RESTORE role; remaining cluster members receive the RESYNC role. Ignored when recoveryMode is All or Reachable.
- oplogDumpDirPath: System.String
  - Path where Rubrik will dump oplogs for Point-in-Time Recovery. Rubrik expects that the path is accessible by the Rubrik cluster, the MongoDB OpsManager Backup Agent, and the MongoDB OpsManager Automation Agent. This is a mandatory field for Point-in-Time Recovery. The Recovery API will fail if this path is left empty for Point-in-Time Recovery.
- targetMongoClusterId: System.String
  - Required. Supported in v9.3+
Managed ID of the MongoDB target cluster.
