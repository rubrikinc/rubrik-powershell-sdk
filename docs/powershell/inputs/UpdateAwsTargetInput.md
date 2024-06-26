### UpdateAwsTargetInput
Input to edit AWS target.

- id: System.String
  - Rubrik Security Cloud managed ID of the location to be edited.
- name: System.String
  - Name of the AWS location.
- cloudAccountId: System.String
  - Cloud account ID of the AWS target.
- storageClass: AwsStorageClass
  - Storage class of the AWS target.
- isConsolidationEnabled: System.Boolean
  - Flag to determine if consolidation is enabled.
- proxySettings: ProxySettingsInput
  - Proxy settings of the target.
- awsComputeSettingsId: System.String
  - Compute settings ID of the AWS target.
- cloudComputeSettings: AwsCloudComputeSettingsInput
  - Cloud compute settings of the AWS target.
- computeProxySettings: ProxySettingsInput
  - Compute proxy settings of the AWS target.
- awsRetrievalTier: AwsRetrievalTier
  - Retrieval tier of the AWS target.
- immutabilitySettings: AwsImmutabilitySettings
  - AWS immutability settings.
- s3Endpoint: System.String
  - Optional field for specifying an AWS S3 endpoint, for example a VPC endpoint. When not specified, the default, region-based S3 endpoint is used.
- kmsEndpoint: System.String
  - Optional field for specifying the KMS server endpoint when using KMS-based encryption, for example a VPC endpoint. When not specified, the default, region-based KMS server endpoint is used.
- bypassProxy: System.Boolean
  - Specifies whether the proxy settings should be bypassed for creating this target location.
- awsIamPairId: System.String
  - Internal ID of the AWS IAM pair. This field is required only when editing Data Center AWS role-based archival locations.
