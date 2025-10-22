### AzureEsConfigInput
ES storage for Azure account.

- storageAccount: System.String
  - Storage name in Azure.
- resourceGroup: System.String
  - Storage resource group in Azure.
- storageSecret: System.String
  - Secret key for container.
- containerName: System.String
  - Storage container name in Azure.
- shouldCreateContainer: System.Boolean
  - Whether to create a new container or not.
- enableImmutability: System.Boolean
  - Specifies whether to enable support for immutable filesystem in SDFS.
- managedIdentity: AzureManagedIdentityName
  - Azure managed identity information.
