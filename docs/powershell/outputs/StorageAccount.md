### StorageAccount
StorageAccount represents an Azure storage account.

- id: System.String
  - The storage account ID.
- name: System.String
  - The storage account name.
- regionName: System.String
  - The region that the storage account is provisioned in.
- resourceGroup: ResourceGroup
  - The resource group that the storage account is allocated in
- kind: System.String
  - The kind of storage account.
- accessTier: StorageAccountTier
  - The access tier of the storage account, e.g., 'Hot', 'Cold'
- sku: StorageAccountSku
  - The SKU type provides the redundancy information, e.g., 'LRS', 'GRS', 'ZRS'
- networkRuleSet: NetworkRuleSet
  - Network rules for Azure storage account.
- isVersioningEnabled: System.Boolean
  - Specifies if versioning is enabled for the storage account.
