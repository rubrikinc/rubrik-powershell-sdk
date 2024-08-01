### ClustersWithSlaSwitchInfo
Response containing information about SLA Domains per cluster, switch-related information, and some aggregated data.

- info: list of ClusterWithSlaInfos
  - Information related to SLA Domains for each cluster.
- ineligibleSlasReason: list of SlaMigrationIneligibilityReasons
  - Unique reasons describing why certain SLA Domains are not eligible for switch.
- switchEligibleSlaCount: System.Int32
  - Total number of SLA Domains eligible for switch across all Rubrik clusters.
- pendingSwitchSlaCount: System.Int32
  - Total number of SLA Domains pending for switch across all Rubrik clusters.
- totalSwitchedSlaCount: System.Int32
  - Total number of successfully switched SLA Domains across all Rubrik clusters.
