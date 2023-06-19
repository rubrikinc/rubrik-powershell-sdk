### ConfigProtectionInfoFilterInput
Filters for the configuration protection.

- id: list of System.Strings
  - Cluster UUIDs.
- name: list of System.Strings
  - Cluster names.
- type: list of ClusterTypeEnums
  - Cluster types.
- minSoftwareVersion: System.String
  - The version of CDM running on the cluster must be greater than or equal to the version specified by this field.
- clusterLocation: list of System.Strings
  - Geolocation address of a Rubrik cluster.
- connectionState: list of ClusterStatuss
  - Connection state of a Rubrik cluster.
- productType: list of ClusterProductEnums
  - Product type of a Rubrik cluster.
- configProtectionStatus: list of ConfigProtectionStatuss
  - Status of configuration protection for a cluster.
