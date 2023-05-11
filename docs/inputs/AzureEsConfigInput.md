### AzureEsConfigInput
ES storage for Azure account.

- containerName: System.String
  - Storage container name in Azure.
- enableImmutability: System.Boolean
  - Enable support for immutable filesystem in SDFS.
- resourceGroup: System.String
  - Storage resource group in Azure.
- shouldCreateContainer: System.Boolean
  - Should create a new container or not?
- storageAccount: System.String
  - Storage name in Azure.
- storageSecret: System.String
  - Secret key for container.
