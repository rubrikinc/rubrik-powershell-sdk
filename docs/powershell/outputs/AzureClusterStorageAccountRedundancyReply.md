### AzureClusterStorageAccountRedundancyReply
Reply with the current redundancy and conversion status of a cloud
cluster's Azure storage account.

- storageAccountName: System.String
  - Name of the storage account.
- resourceGroup: System.String
  - Resource group of the storage account.
- currentRedundancy: AzureClusterStorageRedundancy
  - Current redundancy of the storage account.
- conversionStatus: AzureStorageAccountConversionStatus
  - Status of an ongoing redundancy conversion, if any.
- targetRedundancy: AzureClusterStorageRedundancy
  - Target redundancy of the ongoing conversion (set when conversionStatus
is not NONE).
- failureReason: System.String
  - Failure reason if conversionStatus is FAILED.
