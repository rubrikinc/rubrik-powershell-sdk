### CreateS3BucketInput
Input for creating an AWS S3 bucket.

- awsNativeAccountId: System.String
  - The AWS account in which you want to create the AWS S3 bucket.
- bucketName: System.String
  - The name of the AWS S3 bucket you are creating.
- region: System.String
  - The AWS Region where you want to create the AWS S3 bucket.
- bucketOwnershipControl: BucketOwnershipControls
  - Rules for the AWS S3 bucket ownership.
- tags: list of S3Tags
  - List of tags that you want to apply on the AWS S3 bucket.
- versioningEnabled: System.Boolean
  - Specifies if you want to enable versioning on the AWS S3 bucket.
