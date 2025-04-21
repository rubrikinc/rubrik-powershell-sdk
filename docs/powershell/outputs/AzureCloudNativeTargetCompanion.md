### AzureCloudNativeTargetCompanion
Azure native archival specific fields for Azure Target Template.

- cloudNativeLocTemplateType: CloudNativeLocTemplateType
  - Template type of the storage settings. Must be either SOURCE_REGION or SPECIFIC_REGION.
- storageAccountTags: list of TagObjects
  - Tags for the Storage Account.
- storageAccountRegion: AzureRegion
  - Region for the Storage Account. All the storage accounts created are General Purpose V2 Storage Account. GPV2 accounts are supported only in certain regions. List of Supported Regions: https://docs.microsoft.com/en-us/azure/storage/common/storage-redundancy#redundancy-in-the-primary-region.
- storageTier: AzureStorageTier
  - Storage Tier for the Storage Account. Only Cool, Hot storage tier are supported for now. More Info: https://docs.microsoft.com/en-us/azure/storage/blobs/storage-blob-storage-tiers.
- redundancy: AzureRedundancy
  - Redundancy type for the Storage Account. Some examples are: LRS, ZRS, GRS etc. More Info: https://docs.microsoft.com/en-us/azure/storage/common/storage-redundancy.
- subscriptionNativeId: System.String
  - Native ID of the Azure subscription.
- cmkInfo: list of AzureCmks
  - List of configured customer managed keys per region.
- networkAccessType: AzureStorageAccountNetworkAccess
  - Information about the network access type of the storage account.
