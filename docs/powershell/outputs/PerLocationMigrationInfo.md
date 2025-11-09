### PerLocationMigrationInfo
Migration information for each location being migrated.

- locationId: System.String
  - ID of the location undergoing migration.
- rcvBucket: System.String
  - AWS bucket corresponding to the target RCV location.
- dataMigratorSpecificInfo: DataMigratorSpecificInfoOneof
  - The migrator info provider.
