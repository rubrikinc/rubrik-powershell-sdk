### UpdateAutomaticAzureTargetMappingInput
Input to edit Azure automatic target mapping.

- id: System.String
  - ID of the Azure target mapping.
- name: System.String
  - Name of the Azure target mapping.
- storageAccountName: System.String
  - Storage account name of the Azure archival target.
- accessKey: System.String
  - Access key of the Azure target.
- cloudAccountId: System.String
  - Cloud account ID of the Azure target.
- computeSettings: AzureCloudComputeSettingsInput
  - Compute settings of the Azure target.
- proxySettings: ProxySettingsInput
  - Proxy settings of the Azure target.
- clusterUuidList: list of System.Strings
  - List of Rubrik cluster UUIDs.
- isConsolidationEnabled: System.Boolean
  - Specifies whether consolidation is enabled on the Azure target.
