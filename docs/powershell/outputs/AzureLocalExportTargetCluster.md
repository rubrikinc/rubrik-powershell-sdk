### AzureLocalExportTargetCluster
An Azure Local cluster eligible as an export destination.

- clusterName: System.String
  - Display name of the destination Azure Local cluster.
- hypervClusterId: System.String
  - RSC object ID of the Hyper-V cluster backing this Azure Local cluster. Identifies
the cluster as an export destination.
- customLocationId: System.String
  - Azure Local custom location ARM ID of the destination cluster.
- subscriptionId: System.String
  - Azure subscription ID of the destination cluster.
- subscriptionName: System.String
  - Display name of the Azure subscription containing the destination cluster.
- region: System.String
  - Azure region of the destination cluster.
- defaultResourceGroup: System.String
  - Resource group of the destination cluster. Used as the export resource group when
none is supplied.
