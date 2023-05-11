### AzureCloudAccountFeatureDetail
Azure Cloud Account Feature details.

- feature: CloudAccountFeature
  - A feature refers to a Rubrik protection feature. For example: Virtual Machine and Disk Protection, Storage, Exocompute, etc.
- persistentStorage: PersistentStorage
  - Persistent storage configured for the feature. It is null for features other than Azure SQL DB and Azure SQL MI.
- regions: a list of AzureCloudAccountRegions
  - Azure regions.
- resourceGroup: AzureResourceGroup
  - Resource group for the feature.
- role: AzureRole
  - Role details for the feature.
- status: CloudAccountStatus
  - Specifies the state of an Azure cloud account in Rubrik environment. For example, Refreshed, Disconnected, etc. A cloud account can only be in one state at a time.
- userAssignedManagedIdentity: AzureUserAssignedManagedIdentity
  - User assigned managed identity for encryption feature. It is null for features other than Cloud Native Archival Encryption.
