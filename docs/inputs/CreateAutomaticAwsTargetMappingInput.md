### CreateAutomaticAwsTargetMappingInput
Input for creating an AWS target mapping.

- awsComputeSettingsId: System.String
  - Field for creating AWS compute settings ID.
- bucketPrefix: System.String
  - Field for specifying AWS bucket name.
- cloudAccountId: System.String
  - Field for specifying cloud account ID.
- clusterUuidList: a list of System.Strings
  - Field for specifying list cluster UUID of the target.
- isConsolidationEnabled: System.Boolean
  - Field for specifying whether consolidation is enabled or not.
- kmsMasterKeyId: System.String
  - Field for specifying KMS master key for encryption.
- name: System.String
  - Field for specifying name of the target mapping.
- proxySettings: ProxySettingsInput
  - Field for creating proxy settings.
- region: AwsRegion
  - Field for specifying region of the target.
- rsaKey: System.String
  - Field for specifying RSA key for encryption.
- storageClass: AwsStorageClass
  - Field for specifying storage class of the target.
