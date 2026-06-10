### RscPermsToCdmInfoOut
Synced cluster details for the role.

- totalDisconnectedClusters: System.Int32
  - Total number of disconnected clusters eligible to synchronize roles.
- syncedClusters: SyncedClusterConnection
  - Synced clusters.
- removedClusters: SyncedClusterConnection
  - Removed clusters.
- incompatibleClusters: SyncedClusterConnection
  - Incompatible clusters with CDM versions earlier than 9.3.
