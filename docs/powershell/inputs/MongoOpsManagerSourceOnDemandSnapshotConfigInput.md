### MongoOpsManagerSourceOnDemandSnapshotConfigInput
Supported in v9.3+
Configuration for an on-demand snapshot for a MongoDB source managed by Ops Manager.

- slaId: System.String
  - Required. Supported in v9.3+
ID of the SLA domain to be used for retention of the on-demand snapshot.
- isFullbackup: System.Boolean
  - Supported in v9.3+
Specifies that the on-demand snapshot is for a full backup when true, or an incremental backup when false.
