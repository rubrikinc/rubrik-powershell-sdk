### UpdateAzureTargetInput
Input to edit Azure target.

- accessKey: System.String
  - Access key of the Azure target.
- bypassProxy: System.Boolean
  - Specifies whether the proxy settings should be bypassed for creating this target location.
- cloudAccountId: System.String
  - Cloud account ID of the Azure target.
- computeSettings: AzureCloudComputeSettingsInput
  - Compute settings of the Azure target.
- id: System.String
  - Id of the Azure target to be edited.
- immutabilitySettings: AzureImmutabilitySettings
  - Immutability settings of the Azure target.
- isConsolidationEnabled: System.Boolean
  - Flag to determine if consolidation is enabled in the Azure target.
- name: System.String
  - Name of the Azure target.
- proxySettings: ProxySettingsInput
  - Proxy settings of the Azure target.
- retrievalTier: AzureRetrievalTier
  - Retrieval tier to use for retrieving data from archive storage.
- storageAccountName: System.String
  - Storage account name of the Azure target.
