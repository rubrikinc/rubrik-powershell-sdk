### RestorePostgreSqlDbClusterInput
Input for triggering the  PostgreSQL database cluster restore in the provided host.

- id: System.String
  - Required. The ID of the PostgreSQL database cluster.
- restoreConfig: PostgresDbClusterAutomatedRestoreConfigInput
  - Required. Configuration for PostgreSQL database cluster recovery.
