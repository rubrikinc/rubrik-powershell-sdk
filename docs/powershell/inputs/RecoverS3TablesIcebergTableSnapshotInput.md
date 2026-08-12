### RecoverS3TablesIcebergTableSnapshotInput
Request for RecoverS3TablesIcebergTableSnapshot.

- sourceTableId: System.String
  - Source S3 Tables Iceberg table being recovered from. Requiredness left
unset to mirror RecoverGlueIcebergTableSnapshotReq exactly.
- snapshotId: System.String
  - Identifier of the snapshot to recover.
- inPlace: S3TablesIcebergInPlaceRecoveryTarget
  - Recover into a branch on the source table itself.
- exportToExistingTable: S3TablesIcebergExportToExistingTableRecoveryTarget
  - Write the snapshot into a different, already-existing Iceberg table.
- exportToNewTable: S3TablesIcebergExportToNewTableRecoveryTarget
  - Create a new Iceberg table in an existing S3 Tables namespace and
write the snapshot into it.
