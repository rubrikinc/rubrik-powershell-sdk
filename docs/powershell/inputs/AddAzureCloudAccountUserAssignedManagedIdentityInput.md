### AddAzureCloudAccountUserAssignedManagedIdentityInput
Input to specify the details of the user-assigned managed identity to be used for CLOUD_NATIVE_ARCHIVAL_ENCRYPTION, AZURE_SQL_DB_PROTECTION, or AZURE_POSTGRES_FLEXIBLE_SERVER_PROTECTION feature.

- name: System.String
  - The name of the managed identity.
- resourceGroupName: System.String
  - The name of the resource group of the managed identity.
- principalId: System.String
  - The ID of the service principal object associated with the managed identity.
- region: AzureCloudAccountRegion
  - The region of the managed identity.
