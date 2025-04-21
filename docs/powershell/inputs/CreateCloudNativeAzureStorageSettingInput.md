### CreateCloudNativeAzureStorageSettingInput
Input for create storage settings for an account.

- name: System.String
  - Name of the storage setting.
- cloudAccountId: System.String
  - Cloud Account Id of the target subscription.
- storageAccountName: System.String
  - Name or prefix of the storage account. This field can not be empty string and must contain only lowercase letters and numbers. For 'SOURCE_REGION' Template Type, this field must be less than 16 characters. Random UID of eight characters is appended to the prefix to create the actual storage accounts. For 'SPECIFIC_REGION' Template Type, this field must be less than 24 characters.
- containerName: System.String
  - Name of the container inside storage account. This field must be between 3 to 64 characters in length and must start with a letter or number, and can contain only lowercase letters, numbers, and the dash (-) characters.
- storageAccountTags: TagsInput
  - Tags of the storage account.
- storageAccountRegion: AzureRegion
  - Region for the Storage Account. For 'SOURCE_REGION' Template Type, this field will be 'UNKNOWN_AZURE_REGION'. For 'SPECIFIC_REGION' Template Type, this field must be a azure region supporting GPV2, More Info: https://docs.microsoft.com/en-us/azure/storage/common/storage-redundancy#redundancy-in-the-primary-region.
- storageTier: AzureStorageTier
  - Storage Tier for the Storage Account. Only Cool, Hot storage tier are supported for now. More Info: https://docs.microsoft.com/en-us/azure/storage/blobs/storage-blob-storage-tiers.
- redundancy: AzureRedundancy
  - Redundancy type for the Storage Account. Some examples are: LRS, ZRS, GRS etc. More Info: https://docs.microsoft.com/en-us/azure/storage/common/storage-redundancy.
- subscriptionNativeId: System.String
  - Azure native subscription id.
- cloudNativeLocTemplateType: CloudNativeLocTemplateType
  - Template type of the storage settings. Must be either SOURCE_REGION or SPECIFIC_REGION.
- cmkInfo: list of AzureCmkInputs
  - Information about the customer-managed key and key vault.
- networkAccessType: AzureStorageAccountNetworkAccess
  - Information about the network access type of the storage account.
- azureCloudType: AzureCloudType
  - Cloud type of Azure cloud account.
