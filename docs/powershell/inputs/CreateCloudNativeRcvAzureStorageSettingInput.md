### CreateCloudNativeRcvAzureStorageSettingInput
Input for creating Rubrik Cloud Vault Azure storage settings.

- name: System.String
  - Name of the storage setting.
- region: AzureRegion
  - Rubrik Cloud Vault location Azure region. For the source region template type, this field will be 'UNKNOWN_AZURE_REGION'. For the specific region template type, this field must be an supported RCV region.
- rcvRegion: RcsRegionEnumType
  - Rubrik Cloud Vault location region. For the source region template type, this field will be 'UNKNOWN_AZURE_REGION'. For the specific region template type, this field must be an supported RCV region.
- tier: AzureStorageTier
  - Tier for the Rubrik Cloud Vault (RCV) location supports Backup with Azure Cool storage and Archive with Azure Archive storage.
- cloudNativeLocTemplateType: CloudNativeLocTemplateType
  - Template type of the storage settings - SOURCE_REGION or SPECIFIC_REGION.
- redundancy: RcvRedundancy
  - Redundancy for the RCV location.
