### RscPermsToCdmInfoOut
Synced cluster details for the role.

- totalDisconnectedClusters: System.Int32
  - Total number of disconnected clusters eligible to synchronize roles.
- syncedClusters: SyncedClusterConnection
  - Synced clusters.
- incompatibleClusters: SyncedClusterConnection
  - Incompatible clusters with CDM versions earlier than 9.3.
- removedClusters: SyncedClusterConnection
  - Removed clusters.
