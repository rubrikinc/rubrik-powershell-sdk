### UpdateAutomaticAwsTargetMappingInput
Input to edit AWS automatic target mapping.

- id: System.String
  - ID of the AWS target mapping.
- name: System.String
  - Name of the AWS target mapping.
- cloudAccountId: System.String
  - Cloud account ID of the AWS target.
- storageClass: AwsStorageClass
  - Storage class of the AWS target.
- isConsolidationEnabled: System.Boolean
  - Specifies whether consolidation is enabled on the AWS target.
- proxySettings: ProxySettingsInput
  - Proxy settings of the AWS target.
- clusterUuidList: list of System.Strings
  - List of Rubrik cluster UUIDs.
- awsComputeSettingsId: System.String
  - Compute settings ID of the AWS target.
