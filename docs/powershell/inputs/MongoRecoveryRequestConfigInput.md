### MongoRecoveryRequestConfigInput
Configuration for recovering MongoDB databases or collections from source to target cluster.

- prefix: System.String
  - Supported in v9.0+
      Prefix for the restored collections.
- restoreDbPassword: System.String
  - Supported in v9.0+
      Password of the target MongoDB source.
- restoreDbUsername: System.String
  - Supported in v9.0+
      Username of the target MongoDB source.
- shouldDropExistingCollection: System.Boolean
  - Specifies whether the collection can be dropped because it already exists on the target MongoDB cluster.
- sourceCollectionIds: list of System.Strings
  - Supported in v9.0+
      List of MongoDB collection objects.
- sourceDatabaseIds: list of System.Strings
  - Supported in v9.0+
      List of MongoDB database objects.
- targetCollectionName: System.String
  - Supported in v9.0+
      Name of the target collection for recovery.
- targetDatabaseName: System.String
  - Supported in v9.0+
      Name of the target database for recovery.
- versionTime: DateTime
  - Required. Supported in v9.0+
      Timestamp of the snapshot version to be used for restore.
- sourceMongoClusterId: System.String
  - Required. Supported in v9.0+
      ID of the MongoDB source cluster.
- targetMongoClusterId: System.String
  - Required. Supported in v9.0+
      ID of the MongoDB target cluster.