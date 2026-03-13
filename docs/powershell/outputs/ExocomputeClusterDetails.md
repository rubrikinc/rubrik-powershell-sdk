### ExocomputeClusterDetails
Details of the Exocompute cluster.

- clusterNativeId: System.String
  - Native ID of the Exocompute cluster. The native ID would be AKS ID in case of Azure and the cluster ARN in case of AWS.
- clusterStatus: ExoClusterStatus
  - Current status of the Exocompute cluster.
- isExoclusterLongRunning: System.Boolean
  - Specifies if the Exocompute cluster is persistent. Persistent clusters are Exocompute clusters requested by customer.
