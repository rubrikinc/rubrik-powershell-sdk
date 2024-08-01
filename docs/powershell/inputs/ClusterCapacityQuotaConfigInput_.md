### ClusterCapacityQuotaConfigInput
Configuration details for a cluster capacity quota.

- clusterId: System.String
  - Identifier of the cluster to apply this capacity quota.
- hardLimitGb: System.Int64
  - Hard limit of the quota in gigabytes, representing the maximum allowable capacity.
- softLimitGb: System.Int64
  - Soft limit of the quota in gigabytes, serving as a threshold warning for capacity usage.
- clusterCapacityQuotaType: ClusterCapacityQuotaType
  - Type of capacity quota metric, either 'physical bytes' or 'logical bytes'.
