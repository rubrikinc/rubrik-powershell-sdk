### CreateCloudNativeAzureStorageSettingInput
Input for create storage settings for an account.

- azureCloudType: AzureCloudType
  - Cloud type of Azure cloud account.
- cloudAccountId: System.String
  - Cloud Account Id of the target subscription.
- cloudNativeLocTemplateType: CloudNativeLocTemplateType
  - Template type of the storage settings. Must be either SOURCE_REGION or SPECIFIC_REGION.
- cmkInfo: a list of AzureCmkInputs
  - Information about the customer-managed key and key vault.
- containerName: System.String
  - Name of the container inside storage account. This field must be between 3 to 64 characters in length and must start with a letter or number, and can contain only lowercase letters, numbers, and the dash (-) characters.
- name: System.String
  - Name of the storage setting.
- redundancy: AzureRedundancy
  - Redundancy type for the Storage Account. Some examples are: LRS, ZRS, GRS etc. More Info: https://docs.microsoft.com/en-us/azure/storage/common/storage-redundancy.
- storageAccountName: System.String
  - Name or prefix of the storage account. This field can not be empty string and must contain only lowercase letters and numbers. For 'SOURCE_REGION' Template Type, this field must be less than 16 characters. Random UID of eight characters is appended to the prefix to create the actual storage accounts. For 'SPECIFIC_REGION' Template Type, this field must be less than 24 characters.
- storageAccountRegion: AzureRegion
  - Region for the Storage Account. For 'SOURCE_REGION' Template Type, this field will be 'UNKNOWN_AZURE_REGION'. For 'SPECIFIC_REGION' Template Type, this field must be a azure region supporting GPV2, More Info: https://docs.microsoft.com/en-us/azure/storage/common/storage-redundancy#redundancy-in-the-primary-region.
- storageAccountTags: TagsInput
  - Tags of the storage account.
- storageTier: AzureStorageTier
  - Storage Tier for the Storage Account. Only Cool, Hot storage tier are supported for now. More Info: https://docs.microsoft.com/en-us/azure/storage/blobs/storage-blob-storage-tiers.
- subscriptionNativeId: System.String
  - Azure native subscription id.
