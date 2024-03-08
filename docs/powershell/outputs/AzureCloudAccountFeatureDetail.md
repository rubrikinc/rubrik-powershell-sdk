### AzureCloudAccountFeatureDetail
Azure Cloud Account Feature details.

- feature: CloudAccountFeature
  - A feature refers to a Rubrik protection feature. For example: Virtual Machine and Disk Protection, Storage, Exocompute, etc.
- status: CloudAccountStatus
  - Specifies the state of an Azure cloud account in Rubrik environment. For example, Refreshed, Disconnected, etc. A cloud account can only be in one state at a time.
- regions: list of AzureCloudAccountRegions
  - Azure regions.
- customerFeatureId: System.String
  - Customer feature UUID.
- userAssignedManagedIdentity: AzureUserAssignedManagedIdentity
  - User assigned managed identity for encryption feature. It is null for features other than Cloud Native Archival Encryption.
- persistentStorage: PersistentStorage
  - Persistent storage configured for the feature. It is null for features other than Azure SQL DB and Azure SQL MI.
- resourceGroup: AzureResourceGroup
  - Resource group for the feature.
- role: AzureRole
  - Role details for the feature.
- roles: list of AzureRoles
  - Role details for the feature.
