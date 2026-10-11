### PostgresAutomatedRestoreDatabaseDetailsInput
PostgreSQL database-level restore configuration. Applies only when restoreInfo.restoreEntities names PostgreSQL databases rather than the cluster.

- databasePrefixName: System.String
  - Prefix prepended to every restored database name, for example 'restored_'. When unset, databases are restored in place over their existing counterparts.
