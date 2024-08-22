### AzureCloudComputeSettingsInput
Cloud compute settings input for the Azure archival target.

- appId: System.String
  - Client ID of the Application.
- appSecretKey: System.String
  - Client secret key of the Application.
- region: AzureRegion
  - Name of the Azure region.
- generalPurposeStorageName: System.String
  - Storage account name of the Azure target.
- generalPurposeStorageContainer: System.String
  - Storage container name of the Azure target.
- resourceGroup: System.String
  - Resource Group of the Azure target.
- virtualNetworkId: System.String
  - Virtual Network ID of the Azure target.
- subnetId: System.String
  - Subnet ID of the Azure target.
- securityGroupId: System.String
  - Security Group ID of the Azure target.
- computeProxySettings: ProxySettingsInput
  - Compute proxy settings of the Azure target.
- cloudAccountId: System.String
  - Cloud account ID of the Azure target.
- subscriptionId: System.String
  - Subscription ID of the Azure target that hosts the compute resources. If subscriptionId is provided then there is noneed to specify cloudAccountId.
