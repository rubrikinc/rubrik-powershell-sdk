### UpdateGitHubCloudAccountInput
Request message for UpdateGitHubCloudAccount.

- organizationId: System.String
  - RSC-assigned UUID of the GitHub organization to update.
- archivalGroupId: System.String
  - Archival group ID for storing GitHub backups. Retrieve the ID by calling
the allTargetMappings GraphQL query and using the id field of the desired
TargetMapping.
- exocomputeCloudAccountId: System.String
  - UUID of the cloud account configured for exocompute. Retrieve the ID by
calling the allCloudAccountExocomputeMappings GraphQL query and using the
exocomputeCloudAccountId field from the response.
- hostType: DevopsHostType
  - Type of exocompute host --CUSTOMER_HOST or RUBRIK_HOST.
- storageType: DevOpsStorageType
  - Type of storage --BYOS (Bring Your Own Storage) or RCV (Rubrik Cloud
Vault).
- exocomputeRegion: System.String
  - Region for Rubrik-hosted exocompute (e.g., "eastus", "westus2"). Required
when host_type is RUBRIK_HOST.
