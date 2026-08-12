### S3TablesIcebergInventoryStatsReply
Aggregate counts for the AWS S3 Tables Iceberg inventory card. Field
names + int32 type mirror GetGlueIcebergInventoryStatsReply field-for-field;
the only deliberate rename is databases_count -> namespaces_count (S3
Tables vendor terminology).

- awsAccountsCount: System.Int32
  - AWS native accounts with the S3 Tables Iceberg protection feature enabled.
- catalogsCount: System.Int32
  - S3 Tables Iceberg catalogs (== table-buckets) visible to the caller.
- namespacesCount: System.Int32
  - S3 Tables Iceberg namespaces visible to the caller.
- tablesTotalCount: System.Int32
  - S3 Tables Iceberg tables visible to the caller.
- tablesProtectedCount: System.Int32
  - Subset of `tablesTotalCount` that are protected by an SLA Domain.
