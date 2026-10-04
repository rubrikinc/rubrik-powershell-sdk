### UpdateCloudNativeAwsStorageSettingInput
Input to update a storage setting for AWS.

- id: System.String
  - ID of the AWS storage setting.
- name: System.String
  - Name of the AWS storage setting.
- storageClass: AwsStorageClass
  - Storage class of the AWS storage setting.
- kmsMasterKeyId: System.String
  - KMS master key ID of the AWS storage setting.
- bucketTags: TagsInput
  - AWS target bucket tags.
- deleteAllBucketTags: System.Boolean
  - Set as true to delete all bucket tags.
