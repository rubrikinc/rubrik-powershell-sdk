### AddAzureDevOpsCloudAccountInput
Contains parameters to create a new Azure DevOps cloud account configuration.

- organizationNativeId: System.String
  - Azure DevOps organization native identifier. This is the organization name
visible in the Azure DevOps URL (e.g., "my-org" from
https://dev.azure.com/my-org).
- tenantId: System.String
  - Azure AD (Entra ID) tenant identifier. The directory (tenant) ID of the
Azure AD tenant that the Azure DevOps organization is linked to. Can be
found in the Azure portal under Azure Active Directory > Properties.
- backupLocationId: System.String
  - Archival group ID for storing Azure DevOps backups. Required when
storage_type is BYOS; optional when storage_type is RCV (storage is
auto-provisioned). Retrieve the ID by calling the allTargetMappings
GraphQL query and using the id field of the desired TargetMapping.
- backupRegion: System.String
  - Azure region for backup storage (e.g., "eastus", "westus2",
"centralindia"). Required when storage_type is BYOS; optional when
storage_type is RCV. Must match exocompute_region when host_type is
RUBRIK_HOST with BYOS storage.
- exocomputeCloudAccountId: System.String
  - UUID of the Azure cloud account configured for exocompute. This is the
cloud account that provides compute resources for backup and restore
operations. Required when host_type is CUSTOMER_HOST; not needed for
RUBRIK_HOST. Retrieve the ID by calling the
allCloudAccountExocomputeMappings GraphQL query with cloudVendor set to
AZURE, and using the exocomputeCloudAccountId field from the response.
- sessionId: System.String
  - Session ID obtained from the startAzureCloudAccountOauth mutation
(with azureRubrikAppUseCase set to AZURE_DEVOPS). Use the same session
ID that was passed to completeAzureDevOpsOauth.
- featuresWithPermissionsGroups: list of FeatureWithPermissionsGroupss
  - Features with permissions groups to be onboarded.
- hostType: DevopsHostType
  - Type of exocompute host --CUSTOMER_HOST or RUBRIK_HOST.
- storageType: DevOpsStorageType
  - Type of storage --BYOS (Bring Your Own Storage) or RCV (Rubrik Cloud
Vault). BYOS requires backup_location_id and backup_region; RCV
auto-provisions storage.
- exocomputeRegion: System.String
  - Azure region for Rubrik-hosted exocompute (e.g., "eastus", "westus2").
Required when host_type is RUBRIK_HOST. Must match backup_region when
storage_type is BYOS.
