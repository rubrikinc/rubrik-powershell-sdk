### UpdateCloudNativeRcvAzureStorageSettingInput
Input for updating an existing Rubrik Cloud Vault Azure storage setting.

- id: System.String
  - ID for the storage setting.
- name: System.String
  - Name of the storage setting.
- redundancyOpt: RcvRedundancy
  - Redundancy to which RCV Azure CNP location is to be updated.
- updateChildVaultsOpt: System.Boolean
  - Whether to update child vaults along with parent vault. Child vaults will not be updated if this field is not set to true.
