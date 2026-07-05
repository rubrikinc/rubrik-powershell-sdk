### CreateOnDemandGlueIcebergTableBackupInput
Input for scheduling an on-demand backup of a Glue Iceberg table.

- sourceTableId: System.String
  - Unique identifier of the Glue Iceberg table to back up.
- retentionSlaId: System.String
  - Optional SLA Domain identifier whose retention rules apply to the
resulting snapshot. Leave empty to use the table's configured SLA
retention.
