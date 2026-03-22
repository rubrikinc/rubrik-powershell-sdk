### ReclaimableClusterStatsFilterInput
Filter input for reclaimable cluster stats query.

- clusterUuids: list of System.Strings
  - List of cluster UUIDs to filter by. If not provided
or empty, returns all clusters (with RBAC filtering).
- minSoftwareVersion: System.String
  - Returns clusters running software version equal to
or greater than the specified version.
