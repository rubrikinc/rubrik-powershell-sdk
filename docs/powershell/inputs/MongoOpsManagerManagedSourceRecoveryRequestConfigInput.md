### MongoOpsManagerManagedSourceRecoveryRequestConfigInput
Supported in v9.3+
Configuration for recovering a MongoDB source managed by Ops Manager from a source to a target cluster.

- sourceMongoClusterId: System.String
  - Required. Supported in v9.3+
Managed ID of the MongoDB source cluster.
- restoreTime: DateTime
  - Required. Time of the source cluster to which the target cluster should be restored, using the ISO8601 format 2016-01-01T01:23:45.678. The restore will happen to the latest available snapshot before the specified time.
- oplogDumpDirPath: System.String
  - Path where Rubrik will dump oplogs for Point-in-Time Recovery. Rubrik expects that the path is accessible by the Rubrik cluster, the MongoDB OpsManager Backup Agent, and the MongoDB OpsManager Automation Agent. This is a mandatory field for Point-in-Time Recovery. The Recovery API will fail if this path is left empty for Point-in-Time Recovery.
- targetMongoClusterId: System.String
  - Required. Supported in v9.3+
Managed ID of the MongoDB target cluster.
