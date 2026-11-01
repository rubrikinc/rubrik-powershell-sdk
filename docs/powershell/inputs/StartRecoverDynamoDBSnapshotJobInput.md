### StartRecoverDynamoDBSnapshotJobInput
Input for an on-demand AWS DynamoDB snapshot recovery job.

- workloadId: System.String
  - ID of the DynamoDB table workload.
- snapshotId: System.String
  - ID of the DynamoDB table snapshot to recover.
- recoveryDate: DateTime
  - Recovery date for Point-in-Time recovery of the DynamoDB table. Exactly
one of snapshotId and recoveryDate is required. Supported only for a new
table, and preferRecoveryFromArchivedCopy is ignored when it is set.
- targetAwsAccountRubrikId: System.String
  - Rubrik ID of the AWS account where the DynamoDB table will be recovered.
Defaults to the account of the source table.
- destinationRegion: AwsNativeRegion
  - The AWS region to use for creating the recovered table. For an in-place
recovery, the table in this region is the one that is overwritten, so it
must hold the table being recovered (for a global table, a replica).
- maxRecoveryWcus: System.Int32
  - Write Capacity Units (WCUs) to temporarily provision for the recovery.
Defaults to 1 if omitted, which makes the recovery very slow, so set it
explicitly for any recovery that is not tiny. Optional because the table
can use on-demand billing. For an in-place recovery, the existing table's
capacity is temporarily raised by this many WCUs.
- recoveredTableName: System.String
  - Name of the recovered DynamoDB table. Required, but ignored for an
in-place recovery, which always writes to the source table, and for an
export; send a placeholder.
- exportTags: System.Boolean
  - Flag to apply tags from the original table to the recovered table. Used
for a new-table recovery only, and ignored for a point-in-time recovery
(recoveryDate).
- includeSecondaryIndexes: System.Boolean
  - Flag to create secondary indexes from the original table on the recovered
table. Required, but used for a new-table recovery only; ignored for an
in-place recovery and for an export, so send a placeholder.
- kmsKeyId: System.String
  - KMS Key ID to use for encrypting the recovered table. Used for a
new-table recovery only. If omitted, the recovered table uses the source
table's key when it is recovered in the same region, and an AWS-owned key
when it is recovered to a different region.
- preferRecoveryFromArchivedCopy: System.Boolean
  - Flag to indicate recovery from an archived copy, if available. Ignored
when recoveryDate is set.
- retrievalTier: AwsRetrievalTier
  - AWS Glacier retrieval tier to use when hydrating archived objects for this recovery. Only meaningful when recovering from a Glacier-tier archival location. Defaults to BULK_TIER if omitted.
- restoreDestination: DynamoDbRestoreDestination
  - Sink for the recovery output. Unset is treated as DYNAMODB_RESTORE_DESTINATION_NEW_TABLE (the full-table recovery). A destination other than a new table requires DynamoDB granular recovery to be enabled for the account.
- search: DynamoDbRestoreSearchInput
  - Record selection for a granular recovery. Required for IN_PLACE and
EXPORT_JSON; not supported for NEW_TABLE. Requires DynamoDB granular
recovery to be enabled for the account.
- overwrite: DynamoDbRestoreOverwriteInput
  - In-place overwrite behaviour (mode plus its conditional attribute). The request is rejected unless restoreDestination is DYNAMODB_RESTORE_DESTINATION_IN_PLACE. Requires DynamoDB granular recovery to be enabled for the account.
- ttl: DynamoDbRestoreTtlInput
  - TTL handling for recovered items (handling mode plus optional custom
expiry). The request is rejected unless restoreDestination is
DYNAMODB_RESTORE_DESTINATION_IN_PLACE. Requires DynamoDB granular recovery
to be enabled for the account.
- customAttribute: DynamoDbRestoreCustomAttributeInput
  - Optional custom attribute to stamp on every recovered item. In-place
restores only. Rejected if the name matches a key attribute or the TTL
attribute of the table. Items that already hold a different value for
the attribute are not written and appear in the failed-records report.
Requires DynamoDB granular recovery to be enabled for the account.
- s3ExportTarget: DynamoDbS3ExportTargetInput
  - Customer-owned S3 destination; only used for the EXPORT_S3 recovery destination.
