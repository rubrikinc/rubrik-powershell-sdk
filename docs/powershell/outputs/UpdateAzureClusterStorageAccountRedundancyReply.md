### UpdateAzureClusterStorageAccountRedundancyReply
Reply after initiating a storage account redundancy conversion.

- storageAccountName: System.String
  - Name of the storage account being migrated.
- resourceGroup: System.String
  - Resource group of the storage account.
- currentRedundancy: AzureClusterStorageRedundancy
  - Current redundancy of the storage account before conversion.
- targetRedundancy: AzureClusterStorageRedundancy
  - Target redundancy requested.
