### CreateOnDemandS3TablesIcebergTableBackupInput
Input for scheduling an on-demand backup of an S3 Tables Iceberg table.

- sourceTableId: System.String
  - Unique identifier of the S3 Tables Iceberg table to back up.
- retentionSlaId: System.String
  - Optional SLA Domain identifier whose retention rules apply to the
resulting snapshot. Leave empty to use the table's configured SLA
retention.
