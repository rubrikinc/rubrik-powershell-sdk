### UpdateAutomaticAzureTargetMappingInput
Input to edit Azure automatic target mapping.

- accessKey: System.String
  - Access key of the Azure target.
- cloudAccountId: System.String
  - Cloud account ID of the Azure target.
- clusterUuidList: a list of System.Strings
  - List of Rubrik cluster UUIDs.
- computeSettings: AzureCloudComputeSettingsInput
  - Compute settings of the Azure target.
- id: System.String
  - ID of the Azure target mapping.
- isConsolidationEnabled: System.Boolean
  - Specifies whether consolidation is enabled on the Azure target.
- name: System.String
  - Name of the Azure target mapping.
- proxySettings: ProxySettingsInput
  - Proxy settings of the Azure target.
- storageAccountName: System.String
  - Storage account name of the Azure archival target.
