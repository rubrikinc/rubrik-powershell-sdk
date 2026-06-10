### UpdateAzureDevOpsCloudAccountInput
Contains parameters to update an existing Azure DevOps cloud account
configuration.

- organizationId: System.String
  - RSC-assigned UUID of the Azure DevOps organization to update.
- backupLocationId: System.String
  - Archival group ID for storing Azure DevOps backups. Retrieve the ID by
calling the allTargetMappings GraphQL query and using the id field of
the desired TargetMapping.
- backupRegion: System.String
  - Azure region for backup storage (e.g., "eastus", "westus2"). See
addAzureDevOpsCloudAccount for details.
- exocomputeCloudAccountId: System.String
  - UUID of the Azure cloud account configured for exocompute. Retrieve the
ID by calling the allCloudAccountExocomputeMappings GraphQL query with
cloudVendor set to AZURE.
- hostType: DevopsHostType
  - Type of exocompute host --CUSTOMER_HOST or RUBRIK_HOST.
- storageType: DevOpsStorageType
  - Type of storage --BYOS (Bring Your Own Storage) or RCV (Rubrik Cloud
Vault).
- exocomputeRegion: System.String
  - Azure region for Rubrik-hosted exocompute (e.g., "eastus", "westus2").
