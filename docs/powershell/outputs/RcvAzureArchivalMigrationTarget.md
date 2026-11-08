### RcvAzureArchivalMigrationTarget
Details of a Rubrik Cloud Vault on Azure archival migration target.
Read-only view that omits secrets, such as the encryption key and the
storage account access key.

- storageAccountName: System.String
  - Name of the storage account provisioned for the target location. Empty
until the storage account has been provisioned.
- container: System.String
  - Blob container holding the migrated data. Matches the source location's
container name.
- region: AzureRegion
  - Azure region in which the target location is provisioned.
- rcvTier: RcsTierEnumType
  - Storage tier of the target location.
- redundancy: RcvRedundancy
  - Storage redundancy of the target location.
