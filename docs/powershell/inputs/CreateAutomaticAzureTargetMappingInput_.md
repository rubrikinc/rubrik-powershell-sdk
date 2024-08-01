### CreateAutomaticAzureTargetMappingInput
Input for create an Azure target mapping.

- name: System.String
  - Field for specifying name of the target mapping.
- storageAccountName: System.String
  - Name or prefix of the storage account.
- accessKey: System.String
  - Access key of the Azure target.
- containerNamePrefix: System.String
  - Prefix of the container inside storage account. 
- cloudAccountId: System.String
  - Cloud Account Id of the target subscription.
- instanceType: InstanceTypeEnum
  - Instance type of the Azure target.
- rsaKey: System.String
  - Field for specifying RSA key for encryption.
- computeSettings: AzureCloudComputeSettingsInput
  - Compute settings of the Azure target.
- proxySettings: ProxySettingsInput
  - Field for creating proxy settings.
- clusterUuidList: list of System.Strings
  - Field for specifying list cluster UUID of the target.
- isConsolidationEnabled: System.Boolean
  - Field for specifying whether consolidation is enabled or not.
