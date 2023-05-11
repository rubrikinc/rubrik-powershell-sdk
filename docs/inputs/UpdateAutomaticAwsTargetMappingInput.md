### UpdateAutomaticAwsTargetMappingInput
Input to edit AWS automatic target mapping.

- awsComputeSettingsId: System.String
  - Compute settings ID of the AWS target.
- cloudAccountId: System.String
  - Cloud account ID of the AWS target.
- clusterUuidList: a list of System.Strings
  - List of Rubrik cluster UUIDs.
- id: System.String
  - ID of the AWS target mapping.
- isConsolidationEnabled: System.Boolean
  - Specifies whether consolidation is enabled on the AWS target.
- name: System.String
  - Name of the AWS target mapping.
- proxySettings: ProxySettingsInput
  - Proxy settings of the AWS target.
- storageClass: AwsStorageClass
  - Storage class of the AWS target.
