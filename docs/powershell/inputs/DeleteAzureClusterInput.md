### DeleteAzureClusterInput
DeleteAzureClusterInput for Azure account.

- cloudAccountId: System.String
  - Cloud account ID.
- numNodes: System.Int32
  - Number of nodes in the existing cluster.
- resourceGroupName: System.String
  - Azure resource group name.
- networkResourceGroup: System.String
  - Azure network resource group name.
- isEsType: System.Boolean
  - If cluster is ES or disk based.
- storageAccount: System.String
  - Storage account in Azure.
- containerName: System.String
  - Storage container in Azure.
- storageResourceGroup: System.String
  - Storage resource group in Azure.
- isNewContainer: System.Boolean
  - Is it an existing customer container or a new container created by ccprovision?
- clusterUuid: System.String
  - UUID of CDM cluster.
