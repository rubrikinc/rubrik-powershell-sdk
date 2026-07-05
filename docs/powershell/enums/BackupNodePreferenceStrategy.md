### BackupNodePreferenceStrategy
Backup node selection strategy for backups in a high-availability cluster.

- BACKUP_NODE_PREFERENCE_STRATEGY_ANY - Allows backups from any node.
- BACKUP_NODE_PREFERENCE_STRATEGY_PREFER_STANDBY - Prefers standby replicas but falls back to the primary node.
- BACKUP_NODE_PREFERENCE_STRATEGY_PRIMARY_ONLY - Takes backups from the primary node only.
- BACKUP_NODE_PREFERENCE_STRATEGY_STANDBY_ONLY - Takes backups from standby replicas only.
