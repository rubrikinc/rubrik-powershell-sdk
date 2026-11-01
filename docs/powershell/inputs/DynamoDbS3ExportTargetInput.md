### DynamoDbS3ExportTargetInput
DynamoDbS3ExportTargetInput describes the customer-owned S3 destination for an
EXPORT_S3 recovery.

- bucket: System.String
  - Name of the destination S3 bucket.
- prefix: System.String
  - Optional key prefix within the bucket.
- region: AwsNativeRegion
  - AWS region of the destination bucket.
