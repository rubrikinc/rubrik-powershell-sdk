### ValidateRdsExportExocomputePortReq
Parameters for validating exocompute worker security group for RDS export.

- instanceId: System.String
  - Rubrik ID of the RDS instance.
- sourceSnapshotId: System.String
  - Rubrik ID of the source snapshot.
- archivedSnapshotId: System.String
  - Rubrik ID of the archived snapshot.
- destinationRegion: System.String
  - Region to export the RDS instance to.
- targetAwsNativeAccountId: System.String
  - Rubrik ID of the target AWS account.
- port: System.Int64
  - Port used for the RDS instance export.
