### MongoClusterRecoveryRequestConfigInput
Supported in v9.6+
Configuration for MongoDB databases or collections cluster-level recovery from source to target cluster. This is a destructive action since it drops every user database on the target and overwrites cluster-wide config collection.

- restoreThrottleInBytesPerSecond: System.Int64
  - Supported in v9.6+
Rate limit restore data ingestion on target MongoDB cluster.
- sourceMongoClusterId: System.String
  - Required. Supported in v9.6+
Managed ID of the MongoDB source cluster.
- isRestoreWithIndex: System.Boolean
  - Supported in v9.6+
Boolean flag to restore MongoDB collections with index.
- restoreDbPassword: System.String
  - Supported in v9.6+
Password of the target MongoDB source.
- adminDbSnapshotTime: DateTime
  - Supported in v9.6+
Timestamp of the admin database snapshot to use. Omit this field to skip admin database recovery.
- sourceDatabaseIds: list of System.Strings
  - Supported in v9.6+
Managed IDs of the MongoDB database objects.
- sourceCollectionIds: list of System.Strings
  - Supported in v9.6+
Managed IDs of the MongoDB collection objects.
- configdbSnapshotTime: DateTime
  - Supported in v9.6+
Timestamp of the config database snapshot to use. Omit this field to skip config database recovery.
- restoreDbUsername: System.String
  - Supported in v9.6+
Username of the target MongoDB source.
- targetDatabaseName: System.String
  - Supported in v9.6+
Name of the target database for recovery.
- shouldDropExistingCollection: System.Boolean
  - Supported in v9.6+
Specifies whether the collection can be dropped if it already exists on the source MongoDB cluster.
- targetCollectionName: System.String
  - Supported in v9.6+
Name of the target collection for recovery.
- prefix: System.String
  - Supported in v9.6+
Prefix for the restored collections.
- targetMongoClusterId: System.String
  - Required. Supported in v9.6+
Managed ID of the MongoDB target cluster.
- isRestoreFromCdm: System.Boolean
  - Supported in v9.6+
Boolean flag to restore collections and databases by connecting directly to MongoDB from the Rubrik cluster.
- targetAuthenticationType: MongoAuthenticationType
  - Supported in v9.6+
Type of user authentication used when recovering to a target MongoDB cluster. If no option is provided, the one used while adding the target source is used.
- versionTime: DateTime
  - Supported in v9.6+
Timestamp of the snapshot version used to restore the user databases. Omit this field to skip user database recovery.
