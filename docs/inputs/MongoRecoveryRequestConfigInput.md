### MongoRecoveryRequestConfigInput
Configuration for recovering MongoDB databases or collections from source to target cluster.

- prefix: System.String
  - Prefix for the restored collections.
- restoreDbPassword: System.String
  - Password of the target MongoDB source.
- restoreDbUsername: System.String
  - Username of the target MongoDB source.
- shouldDropExistingCollection: System.Boolean
  - Specifies whether the collection can be dropped because it already exists on the target MongoDB cluster.
- sourceCollectionIds: a list of System.Strings
  - List of MongoDB collection objects.
- sourceDatabaseIds: a list of System.Strings
  - List of MongoDB database objects.
- sourceMongoClusterId: System.String
  - Required. ID of the MongoDB source cluster.
- targetCollectionName: System.String
  - Name of the target collection for recovery.
- targetDatabaseName: System.String
  - Name of the target database for recovery.
- targetMongoClusterId: System.String
  - Required. ID of the MongoDB target cluster.
- versionTime: DateTime
  - Required. Timestamp of the snapshot version to be used for restore.
