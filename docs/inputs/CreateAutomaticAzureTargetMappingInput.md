### CreateAutomaticAzureTargetMappingInput
Input for create an Azure target mapping.

- accessKey: System.String
  - Access key of the Azure target.
- cloudAccountId: System.String
  - Cloud Account Id of the target subscription.
- clusterUuidList: a list of System.Strings
  - Field for specifying list cluster UUID of the target.
- computeSettings: AzureCloudComputeSettingsInput
  - Compute settings of the Azure target.
- containerNamePrefix: System.String
  - Prefix of the container inside storage account. 
- instanceType: InstanceTypeEnum
  - Instance type of the Azure target.
- isConsolidationEnabled: System.Boolean
  - Field for specifying whether consolidation is enabled or not.
- name: System.String
  - Field for specifying name of the target mapping.
- proxySettings: ProxySettingsInput
  - Field for creating proxy settings.
- rsaKey: System.String
  - Field for specifying RSA key for encryption.
- storageAccountName: System.String
  - Name or prefix of the storage account.
