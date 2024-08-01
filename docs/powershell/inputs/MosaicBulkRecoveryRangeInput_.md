### MosaicBulkRecoveryRangeInput
Input for querying NoSQL protection recoverable range for objects in bulk.

- clusterUuid: System.String
  - Required. UUID used to identify the cluster the request goes to.
- recoveryRangeData: MosaicBulkRecoverableRangeRequestInput
  - Required. Retrieve Recoverable Range required for Restore operation.
