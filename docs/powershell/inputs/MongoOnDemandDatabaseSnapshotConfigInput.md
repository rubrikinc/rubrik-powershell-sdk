### MongoOnDemandDatabaseSnapshotConfigInput
Supported in v9.0+
  On-demand snapshot configuration for a MongoDB database.

- isFullbackup: System.Boolean
  - Required. Supported in v9.0+
      Specifies that the on-demand snapshot is for a full backup, when true, or incremental, when false.
- slaId: System.String
  - Required. Supported in v9.0+
      ID of the SLA Domain assigned to the database object.
