### StartRecoverS3SnapshotJobInput
Input for an on-demand AWS S3 snapshot recovery job.

- workloadId: System.String
  - ID of the S3 bucket workload.
- snapshotId: System.String
  - ID of the S3 bucket snapshot to recover.
- restoreDate: DateTime
  - Restore date for PiTR recovery of the S3 bucket.
- destinationBucketArn: System.String
  - ARN of the destination S3 bucket.
- shouldRecoverFullBucket: System.Boolean
  - Flag to specify full or granular bucket recovery.
- objectKeys: list of System.Strings
  - List of object keys for granular recovery.
- targetAwsAccountRubrikId: System.String
  - Rubrik ID of the AWS account where the S3 bucket will be recovered.
