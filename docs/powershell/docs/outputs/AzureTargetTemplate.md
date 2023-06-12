### AzureTargetTemplate
Specific info for Azure Target Template.

- storageAccountName: System.String
  - Storage account name of the Azure target.
- containerNamePrefix: System.String
  - Container name prefix of the Azure target.
- instanceType: InstanceTypeEnum
  - Instance type of the Azure target.
- computeSettings: AzureComputeSettings
  - Compute settings of the Azure target.
- proxySettings: ProxySettings
  - Proxy settings of the Azure target.
- isConsolidationEnabled: System.Boolean
  - Specifies whether Azure target has consolidation enabled or not.
- cloudNativeCompanion: AzureCloudNativeTargetCompanion
  - Cloud native companion information of the Azure target.
- cloudAccount: CloudAccount
  - Cloud Account information of the Azure target.
- targetType: TargetType
  - The type of this Target.
