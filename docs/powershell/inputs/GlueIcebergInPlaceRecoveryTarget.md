### GlueIcebergInPlaceRecoveryTarget
Recover into a branch on the source table itself.

- branchName: System.String
  - Iceberg branch on the source table to write the recovered snapshot
under. Both null/omitted and empty string mean "write to the main
branch".
