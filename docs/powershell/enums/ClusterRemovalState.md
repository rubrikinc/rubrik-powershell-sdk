### ClusterRemovalState
Cluster removal state.

- REGISTERED - Initial state of the cluster.
- DISCONNECTING - Cluster moves to a DisconnectingStatus state when a disconnect is initiated.
- WAITING_FOR_DATA_DELETION - Cluster is waiting for table clean up to complete.
- DATA_DELETING - Cleanup of table is in progress.
- UNREGISTERED - Cluster moves to a Unregistered state when deletion is complete.
- FAILED - Cluster moves to a Failed state when it is unable to disconnect.
