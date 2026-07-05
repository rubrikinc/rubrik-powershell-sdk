### GlueIcebergInventoryStatsReply
Aggregate counts for the AWS Glue Iceberg inventory card.

- awsAccountsCount: System.Int32
  - AWS native accounts with the Glue Iceberg protection feature enabled.
- catalogsCount: System.Int32
  - Glue Iceberg catalogs visible to the caller.
- databasesCount: System.Int32
  - Glue Iceberg databases visible to the caller.
- tablesTotalCount: System.Int32
  - Glue Iceberg tables visible to the caller.
- tablesProtectedCount: System.Int32
  - Subset of `tablesTotalCount` that are protected by an SLA Domain.
