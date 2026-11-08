### AwsS3BucketDestinationInput
Destination for this bucket. Exactly one destination must be set.
The choice is per bucket, so one recovery may mix both.

- existingBucket: AwsS3ExistingBucketTargetInput
  - Recover into a pre-existing destination bucket.
- newBucket: AwsS3NewBucketTargetInput
  - Recover into a bucket created by the recovery.
