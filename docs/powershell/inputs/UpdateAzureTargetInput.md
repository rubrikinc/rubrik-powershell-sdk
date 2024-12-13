### UpdateAzureTargetInput
Input to edit Azure target.

- id: System.String
  - Id of the Azure target to be edited.
- name: System.String
  - Name of the Azure target.
- storageAccountName: System.String
  - Storage account name of the Azure target.
- accessKey: System.String
  - Access key of the Azure target.
- cloudAccountId: System.String
  - Cloud account ID of the Azure target.
- computeSettings: AzureCloudComputeSettingsInput
  - Compute settings of the Azure target.
- computeProxySettings: ProxySettingsInput
  - Compute proxy settings of the Azure target.
- proxySettings: ProxySettingsInput
  - Proxy settings of the Azure target.
- isConsolidationEnabled: System.Boolean
  - Flag to determine if consolidation is enabled in the Azure target.
- immutabilitySettings: AzureImmutabilitySettings
  - Immutability settings of the Azure target.
- retrievalTier: AzureRetrievalTier
  - Retrieval tier to use for retrieving data from archive storage.
- bypassProxy: System.Boolean
  - Specifies whether the proxy settings should be bypassed for creating this target location.
