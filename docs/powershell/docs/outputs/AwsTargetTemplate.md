### AwsTargetTemplate
Specific info for AWS Target Template.

- bucketPrefix: System.String
  - AWS target bucket prefix.
- region: AwsRegion
  - AWS target region.
- storageClass: AwsStorageClass
  - AWS target storage class.
- computeSettings: AwsComputeSettings
  - AWS target compute settings.
- proxySettings: ProxySettings
  - AWS target proxy settings.
- encryptionType: TargetEncryptionTypeEnum
  - AWS target encryption type.
- kmsMasterKeyId: System.String
  - AWS target KMS master key ID.
- isConsolidationEnabled: System.Boolean
  - Specifies whether AWS target has consolidation enabled or not.
- cloudNativeLocTemplateType: CloudNativeLocTemplateType
  - Cloud native template type.
- bucketTags: list of TagObjects
  - AWS target bucket tags.
- cloudAccount: CloudAccount
  - Cloud account details of the AWS target.
- targetType: TargetType
  - The type of this Target.
