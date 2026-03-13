### ReclaimableClusterStatsData
Reclaimable cluster stats data for a single cluster.

- clusterUuid: System.String
  - UUID of the cluster.
- relicStorage: System.Int64
  - Storage taken by relic objects (in bytes).
- downloadedSnapshotsStorage: System.Int64
  - Storage taken by downloaded snapshots (in bytes).
- totalUsedStorage: System.Int64
  - Total used storage (in bytes).
- totalCapacity: System.Int64
  - Total capacity (in bytes).
- otherStorage: System.Int64
  - Other storage (calculated as total_used_storage - relic_storage -
downloaded_snapshots_storage, in bytes).
- clusterName: System.String
  - Name of the cluster.
