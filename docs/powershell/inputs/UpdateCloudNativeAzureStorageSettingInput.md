### UpdateCloudNativeAzureStorageSettingInput
Input for updating azure storage settings. Specify old value of the property if no change is intended on the property.

- id: System.String
  - ID for the storage setting.
- name: System.String
  - Name of the storage setting.
- storageAccountTags: TagsInput
  - Tags for the storage account. Old tags are removed and new tags are applied.
- storageTier: AzureStorageTier
  - Storage tier for the storage account.
- cmkInfo: list of AzureCmkInputs
  - Information about the customer-managed key and key vault.
- networkAccessType: AzureStorageAccountNetworkAccess
  - Information about the network access type of the storage account.
