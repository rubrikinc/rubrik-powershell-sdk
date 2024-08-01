### ClusterCapacityQuota
Cluster capacity quota.

- orgId: System.String
  - Organization on which the capacity quota is enforced.
- hardLimitGb: System.Int64
  - Hard limit of the capacity quota (in gigabytes).
- softLimitGb: System.Int64
  - Soft limit of the capacity quota (in gigabytes).
- currentUsageGb: System.Int64
  - The organization's current usage on the cluster.
- usageComputedAt: DateTime
  - The time at which the current usage was computed. If null, the usage has not been computed yet.
- clusterCapacityQuotaType: ClusterCapacityQuotaType
  - The type of capacity quota, either physical or logical bytes.
- cluster: Cluster
  - Cluster on which the capacity quota is enforced.
