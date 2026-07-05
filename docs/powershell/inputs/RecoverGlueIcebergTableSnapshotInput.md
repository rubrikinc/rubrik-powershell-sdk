### RecoverGlueIcebergTableSnapshotInput
Request for RecoverGlueIcebergTableSnapshot.

- sourceTableId: System.String
  - Source GlueIcebergTable being recovered from.
- snapshotId: System.String
  - Identifier of the snapshot to recover.
- inPlace: GlueIcebergInPlaceRecoveryTarget
  - Recover into a branch on the source table itself.
- exportToExistingTable: GlueIcebergExportToExistingTableRecoveryTarget
  - Write the snapshot into a different, already-existing Iceberg table.
- exportToNewTable: GlueIcebergExportToNewTableRecoveryTarget
  - Create a new Iceberg table in an existing Glue database and write
the snapshot into it.
