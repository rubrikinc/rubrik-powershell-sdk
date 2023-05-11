### AwsTargetTemplate
Specific info for AWS Target Template.

- bucketPrefix: System.String
  - AWS target bucket prefix.
- bucketTags: a list of TagObjects
  - AWS target bucket tags.
- cloudAccount: CloudAccount
  - Cloud account details of the AWS target.
- cloudNativeLocTemplateType: CloudNativeLocTemplateType
  - Cloud native template type.
- computeSettings: AwsComputeSettings
  - AWS target compute settings.
- encryptionType: TargetEncryptionTypeEnum
  - AWS target encryption type.
- isConsolidationEnabled: System.Boolean
  - Specifies whether AWS target has consolidation enabled or not.
- kmsMasterKeyId: System.String
  - AWS target KMS master key ID.
- proxySettings: ProxySettings
  - AWS target proxy settings.
- region: AwsRegion
  - AWS target region.
- storageClass: AwsStorageClass
  - AWS target storage class.
- targetType: TargetType
  - The type of this Target.
