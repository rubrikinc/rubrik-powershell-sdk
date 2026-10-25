### CdmUpgradeInfoFilterInput
Input to filter clusters for the CDM upgrade info list.

- clusterLocation: list of System.Strings
  - Location of cluster.
- connectionState: list of ClusterStatuss
  - Connection status of the Rubrik cluster.
- downloadedVersion: list of System.Strings
  - Cluster software version greater than or equal to.
- eosStatus: list of ClusterEosStatuss
  - End of support status of the Rubrik cluster.
- id: list of System.Strings
  - Cluster UUIDs.
- installedVersion: list of System.Strings
  - Cluster software version greater than or equal to.
- isAssignedByParentAccount: System.Boolean
  - Filter on shared (parent-assigned) Rubrik clusters. When true, return only shared
Rubrik clusters; when false, exclude them; omit for no filter.
- minSoftwareVersion: System.String
  - Cluster software version greater than or equal to.
- name: list of System.Strings
  - Cluster names.
- prechecksStatus: list of PrechecksStatusTypeEnums
  - Prechecks status of cluster.
- productType: list of ClusterProductEnums
  - Product type of Rubrik cluster.
- registrationTime_gt: DateTime
  - Cluster registration time greater than.
- registrationTime_lt: DateTime
  - Cluster registration time less than.
- type: list of ClusterTypeEnums
  - Cluster types.
- upgradeJobStatus: list of ClusterJobStatusTypeEnums
  - Cluster upgrade job status.
- upgradeScheduled: System.Boolean
  - Whether an upgrade is scheduled.
- upgradeStatusCategory: list of System.Strings
  - Upgrade status categories for filtering clusters. Valid values are defined in the GPS service.
- versionStatus: list of VersionStatuss
  - Version status of the cluster.
