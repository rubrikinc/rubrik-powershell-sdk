### AwsS3BucketRecoveryTargetInput
Destination for one source S3 bucket, and which of its objects to
recover.

- workloadId: System.String
  - Identifier of the source S3 bucket workload. Must refer to a
workload included in this recovery request, which is where the
bucket's snapshot comes from.
- shouldRecoverFullBucket: System.Boolean
  - Recover every object in the bucket. Objects matching regexPatterns
are recovered first, then the rest of the bucket.
- regexPatterns: list of System.Strings
  - Object-key regex patterns. When shouldRecoverFullBucket is false,
these select the objects to recover; when it is true, they only
decide which objects recover first.
- destination: AwsS3BucketDestinationInput
  - Destination for this bucket.
