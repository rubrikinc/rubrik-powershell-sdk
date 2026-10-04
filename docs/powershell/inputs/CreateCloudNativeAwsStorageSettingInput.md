### CreateCloudNativeAwsStorageSettingInput
Input to create a storage setting for AWS.

- name: System.String
  - Name of the AWS storage setting.
- cloudAccountId: System.String
  - Cloud account ID of the AWS storage setting.
- bucketPrefix: System.String
  - Bucket prefix of the AWS storage setting.
- storageClass: AwsStorageClass
  - Storage class of the AWS storage setting.
- region: AwsRegion
  - Region of the AWS storage setting. Not set for the source region template type.
- kmsMasterKeyId: System.String
  - KMS master key ID of the AWS storage setting.
- awsKmsKey: AwsKmsKeyIdentifierInput
  - AWS KMS key for client-side encryption of the archival target.
- cloudNativeLocTemplateType: CloudNativeLocTemplateType
  - Template type of the storage setting - SOURCE_REGION or SPECIFIC_REGION.
- bucketTags: TagsInput
  - AWS target bucket tags.
