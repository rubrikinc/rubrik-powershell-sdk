### MongoOpsManagerSourceOnDemandSnapshotConfigInput
Supported in v9.3+
  v9.3-v9.4: Configuration for an on-demand snapshot for an OpsManager managed MongoDB source.
  v9.5: Configuration for an on-demand snapshot for a MongoDB source managed by Ops Manager.

- isFullbackup: System.Boolean
  - Supported in v9.3+
      v9.3-v9.4: Specifies that the on-demand snapshot is for a full backup, when true, or incremental, when false.
      v9.5: Specifies that the on-demand snapshot is for a full backup when true, or incremental when false.
- slaId: System.String
  - Required. Supported in v9.3+
      ID of the SLA domain to be used for retention of the on-demand snapshot.
