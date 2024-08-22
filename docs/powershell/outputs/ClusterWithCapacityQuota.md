### ClusterWithCapacityQuota
Information about the Rubrik cluster and any applicable capacity quota for the cluster in the organization.

- quotaOpt: ClusterCapacityQuota
  - The capacity quota that the organization has on the cluster, if it exists.
- currentUsageGb: System.Int64
  - The current physical storage that the organization is using on the cluster, in GB.
- cluster: Cluster
  - Cluster on which the capacity quota is enforced.
