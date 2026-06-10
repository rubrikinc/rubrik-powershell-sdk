### UpdateAzureClusterStorageAccountRedundancyInput
Request to initiate a redundancy conversion for a cloud cluster's Azure
storage account.

- cloudAccountId: System.String
  - Azure cloud account ID in RSC.
- clusterUuid: System.String
  - Cluster UUID.
- targetRedundancy: AzureClusterStorageRedundancy
  - Target redundancy type for the storage account.
