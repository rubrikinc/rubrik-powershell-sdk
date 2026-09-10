### AzureO365ExocomputeConfig
Configuration for provisioning Azure Exocompute resources for Microsoft 365.

- regionName: System.String
  - Azure region name where Exocompute will be provisioned.
- newGroupConfig: GroupConfig
  - Configuration for creating a new Azure resource group.
- existingGroupConfig: GroupConfig
  - Configuration for using an existing Azure resource group.
- newComputeConfig: NewComputeConfig
  - Configuration for creating new AKS compute resources.
- existingComputeConfig: ExistingComputeConfig
  - Configuration for using existing AKS compute resources.
- newStorageAccountConfig: NewStorageAccountConfig
  - Configuration for creating a new Azure storage account.
- existingStorageAccountConfig: ExistingStorageAccountConfig
  - Configuration for using an existing Azure storage account.
