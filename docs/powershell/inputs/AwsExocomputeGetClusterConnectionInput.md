### AwsExocomputeGetClusterConnectionInput
Input to obtain the connection command and yaml which can be used to connect a customer-managed cluster to RSC.

- clusterName: System.String
  - Name of the customer managed cluster.
- exocomputeConfigId: System.String
  - Exocompute Configuration ID obtained after configuring the Exocompute for regions.
- clusterUuid: System.String
  - Deprecated, use clusterName instead. UUID of the customer-managed Exocompute cluster.
