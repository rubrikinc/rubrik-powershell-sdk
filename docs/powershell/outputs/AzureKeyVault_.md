### AzureKeyVault
Details of Azure Key Vault.

- keyVaultName: System.String
  - Name of Key Vault.
- resourceGroupName: System.String
  - Name of resource group in which the Key Vault resides.
- isAccessibleByUserAssignedManagedIdentity: System.Boolean
  - Whether the Key Vault is accessible by the user assigned managed identity. False by default if userAssignedManagedIdentityPrincipalId is not provided.
- isPurgeProtectionEnabled: System.Boolean
  - Determines if the purge protection is enabled for the Key Vault.
