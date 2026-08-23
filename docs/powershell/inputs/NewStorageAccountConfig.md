### NewStorageAccountConfig
New storage account configuration.

- name: System.String
  - The name of the storage account.
- tier: StorageAccountTier
  - The access tier of the storage account (e.g. Hot or Cool).
- sku: StorageAccountSku
  - The SKU / replication type of the storage account (e.g. LRS or GRS).
- storages: list of StorageAccountConfigItems
  - The list of storage accounts within the resource group.
