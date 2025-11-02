### CreateOnDemandMongoDatabaseSnapshotInput
Input for creating an on-demand MongoDB backup.

- id: System.String
  - Required. v9.0-v9.2: MongoDB database ID.
v9.3+: Managed ID of the MongoDB database object.
- config: MongoOnDemandDatabaseSnapshotConfigInput
  - Required. Configuration for the on-demand snapshot.
