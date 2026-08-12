### S3TablesIcebergExportToNewTableRecoveryTarget
Create a new Iceberg table in an existing S3 Tables namespace and write
the snapshot into it.

- destTableBucketId: System.String
  - FID of the destination S3 Tables Iceberg catalog (== table-bucket).
- destNamespaceId: System.String
  - FID of the destination S3 Tables Iceberg namespace under which the new
table will be created.
- destTableName: System.String
  - Name of the new Iceberg table to create.
