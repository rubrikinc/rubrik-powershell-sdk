### StartRecoverS3SnapshotJobInput
Input for an on-demand AWS S3 snapshot recovery job.

- destinationBucketArn: System.String
  - ARN of the destination S3 bucket.
- objectKeys: a list of System.Strings
  - List of object keys for granular recovery.
- restoreDate: DateTime
  - Restore date for PiTR recovery of the S3 bucket.
- shouldRecoverFullBucket: System.Boolean
  - Flag to specify full or granular bucket recovery.
- snapshotId: System.String
  - ID of the S3 bucket snapshot to recover.
- workloadId: System.String
  - ID of the S3 bucket workload.
