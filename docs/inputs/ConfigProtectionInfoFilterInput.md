### ConfigProtectionInfoFilterInput
Filters for the configuration protection.

- clusterLocation: a list of System.Strings
  - Geolocation address of a Rubrik cluster.
- configProtectionStatus: a list of ConfigProtectionStatuss
  - Status of configuration protection for a cluster.
- connectionState: a list of ClusterStatuss
  - Connection state of a Rubrik cluster.
- id: a list of System.Strings
  - Cluster UUIDs.
- minSoftwareVersion: System.String
  - The version of CDM running on the cluster must be greater than or equal to the version specified by this field.
- name: a list of System.Strings
  - Cluster names.
- productType: a list of ClusterProductEnums
  - Product type of a Rubrik cluster.
- type: a list of ClusterTypeEnums
  - Cluster types.
