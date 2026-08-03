### AwsEsConfigInput
ES storage for AWS account.

- bucketName: System.String
  - Bucket name in AWS.
- shouldCreateBucket: System.Boolean
  - Whether RSC should create the S3 bucket. This field is no longer honored.
- enableObjectLock: System.Boolean
  - Enable object locking on bucket.
- enableImmutability: System.Boolean
  - Enable immutability on rubrik filesystem.
