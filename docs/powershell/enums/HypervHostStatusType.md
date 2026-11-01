### HypervHostStatusType
Connection status of a Hyper-V hierarchy object (SCVMM, Cluster, or Server).
+ Mirrors snappables_db_query_service.snappablesdbquery.HypervHostStatusType so
+ the V2 converter can populate connectionStatus without pulling in the
+ snappables-db-query-service proto dependency.

- CONNECTED - The hierarchy object is fully connected.
- DISCONNECTED - The hierarchy object is disconnected.
- CONNECTING - The hierarchy object is in the process of connecting.
- PARTIALLYCONNECTED - The hierarchy object is partially connected.
- UNKNOWN - The connection status of the hierarchy object is unknown.
- REFRESHING - The hierarchy object is refreshing its connection.
- DELETING - The hierarchy object is being deleted.
- DELETED - The hierarchy object has been deleted.
