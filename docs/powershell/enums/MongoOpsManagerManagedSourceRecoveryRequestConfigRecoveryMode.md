### MongoOpsManagerManagedSourceRecoveryRequestConfigRecoveryMode
Recovery mode for a MongoDB source managed by Ops Manager.

- MONGO_OPS_MANAGER_MANAGED_SOURCE_RECOVERY_REQUEST_CONFIG_RECOVERY_MODE_ALL - Every node receives data. This is the default behavior when the recovery mode is omitted.
- MONGO_OPS_MANAGER_MANAGED_SOURCE_RECOVERY_REQUEST_CONFIG_RECOVERY_MODE_CUSTOM - Restores the caller-supplied set of nodes; remaining cluster members resync using MongoDB native replication.
- MONGO_OPS_MANAGER_MANAGED_SOURCE_RECOVERY_REQUEST_CONFIG_RECOVERY_MODE_REACHABLE - Restores only the nodes reachable by the Rubrik Backup Service; remaining cluster members resync using MongoDB native replication.
