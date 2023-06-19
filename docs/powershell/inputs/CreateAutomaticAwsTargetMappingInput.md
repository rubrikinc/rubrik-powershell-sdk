### CreateAutomaticAwsTargetMappingInput
Input for creating an AWS target mapping.

- name: System.String
  - Field for specifying name of the target mapping.
- cloudAccountId: System.String
  - Field for specifying cloud account ID.
- bucketPrefix: System.String
  - Field for specifying AWS bucket name.
- storageClass: AwsStorageClass
  - Field for specifying storage class of the target.
- region: AwsRegion
  - Field for specifying region of the target.
- kmsMasterKeyId: System.String
  - Field for specifying KMS master key for encryption.
- rsaKey: System.String
  - Field for specifying RSA key for encryption.
- isConsolidationEnabled: System.Boolean
  - Field for specifying whether consolidation is enabled or not.
- proxySettings: ProxySettingsInput
  - Field for creating proxy settings.
- clusterUuidList: list of System.Strings
  - Field for specifying list cluster UUID of the target.
- awsComputeSettingsId: System.String
  - Field for creating AWS compute settings ID.
