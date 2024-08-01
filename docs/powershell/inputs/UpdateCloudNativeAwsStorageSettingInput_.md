### UpdateCloudNativeAwsStorageSettingInput
Input to update a storage setting for AWS.

- id: System.String
- name: System.String
- storageClass: AwsStorageClass
- kmsMasterKeyId: System.String
- bucketTags: TagsInput
  - AWS target bucket tags.
- deleteAllBucketTags: System.Boolean
  - Set as true to delete all bucket tags.
