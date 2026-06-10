### AwsExocomputeConfigsDeletionStatusType
DeletionStatus stores the exocompute config id
and corresponding deletion status after a delete
operation is performed.

- exocomputeConfigId: System.String
  - Exocompute configuration ID.
- success: System.Boolean
  - Whether the deletion was successful.
- region: DeletionRegionOneof
  - Region of the deleted exocompute configuration.
