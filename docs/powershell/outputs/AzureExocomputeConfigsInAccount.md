### AzureExocomputeConfigsInAccount
Azure Exocompute configurations in an Azure subscription.

- azureCloudAccount: AzureCloudAccountSubscriptionDetail
  - Account details.
- featureDetails: AzureCloudAccountFeatureDetail
  - Feature details.
- exocomputeEligibleRegions: list of AzureCloudAccountRegions
  - List of regions for which Exocompute can be configured.
- configs: list of AzureExocomputeGetConfigResponses
  - Azure Exocompute configurations.
- globalRegionConfigs: list of AzureExocomputeGetConfigResponses
  - Azure Exocompute global optional configurations.
