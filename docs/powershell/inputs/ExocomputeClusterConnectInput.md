### ExocomputeClusterConnectInput
Input to connect a customer-managed cluster to RSC and retrieve a configuration YAML file for the customer to run.

- clusterName: System.String
  - Name of the customer-managed cluster.
- exocomputeConfigId: System.String
  - Exocompute configuration ID retrieved after setting up Exocompute for regions.
- cloudType: CloudType
  - Cloud type for which you are launching an Exocompute cluster.
