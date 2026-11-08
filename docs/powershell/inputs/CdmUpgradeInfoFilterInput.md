### CdmUpgradeInfoFilterInput
Filter input for clusterWithUpgradesInfo. Mirrors CdmUpgradeInfoFilter; defined here to avoid
the circular import between cluster_upgrade_filter.proto and cdmupgradeservice.proto.

- clusterLocation: list of System.Strings
  - Cluster locations to filter by.
- connectionState: list of ClusterStatuss
  - Cluster connection states to filter by.
- downloadedVersion: list of System.Strings
  - Downloaded versions to filter by.
- eosStatus: list of ClusterEosStatuss
  - End-of-support statuses to filter by.
- id: list of System.Strings
  - Cluster UUIDs to filter by.
- installedVersion: list of System.Strings
  - Installed software versions to filter by.
- isAssignedByParentAccount: System.Boolean
  - Filter on shared (parent-assigned) clusters.
- minSoftwareVersion: System.String
  - Minimum software version.
- name: list of System.Strings
  - Cluster names to filter by.
- prechecksStatus: list of PrechecksStatusTypeEnums
  - Prechecks statuses to filter by.
- productType: list of ClusterProductEnums
  - Product types to filter by.
- registrationTime_gt: DateTime
  - Cluster registration time (lower bound).
- registrationTime_lt: DateTime
  - Cluster registration time (upper bound).
- type: list of ClusterTypeEnums
  - Registered cluster types to filter by.
- upgradeJobStatus: list of ClusterJobStatusTypeEnums
  - Upgrade job statuses to filter by.
- upgradeScheduled: System.Boolean
  - Whether an upgrade is scheduled.
- upgradeStatusCategory: list of System.Strings
  - Upgrade status categories to filter by.
- versionStatus: list of VersionStatuss
  - Version statuses to filter by.
