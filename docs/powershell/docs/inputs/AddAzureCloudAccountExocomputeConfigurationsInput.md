### AddAzureCloudAccountExocomputeConfigurationsInput
Input for adding Exocompute configurations for an Azure Cloud Account.

- cloudAccountId: System.String
  - Rubrik ID of the Azure Cloud Account.
- azureExocomputeRegionConfigs: list of AzureExocomputeAddConfigInputTypes
  - List of Exocompute configurations to be added.
- triggerHealthCheck: System.Boolean
  - Specifies whether to start Exocompute health check.
