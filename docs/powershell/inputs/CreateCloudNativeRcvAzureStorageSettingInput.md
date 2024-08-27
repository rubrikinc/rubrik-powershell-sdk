### CreateCloudNativeRcvAzureStorageSettingInput
Input for creating Rubrik Cloud Vault Azure storage settings.

- name: System.String
  - Name of the storage setting.
- region: AzureRegion
  - Rubrik Cloud Vault location region. For source region template type, this field will be 'UNKNOWN_AZURE_REGION'. For specific region template type, this field must be an Azure region supported for RCV in COOL tier.
- tier: AzureStorageTier
  - Tier for the Rubrik Cloud Vault (RCV) location supports Backup with Azure Cool storage and Archive with Azure Archive storage.
- cloudNativeLocTemplateType: CloudNativeLocTemplateType
  - Template type of the storage settings - SOURCE_REGION or SPECIFIC_REGION.
- redundancy: RcvRedundancy
  - Redundancy for the RCV location.
