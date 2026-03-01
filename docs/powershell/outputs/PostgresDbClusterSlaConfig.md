### PostgresDbClusterSlaConfig
SLA Domain configuration for Postgres DB Cluster.

- logRetention: Duration
  - Specifies the duration for which the Write-Ahead Logging (WAL) logs for the Postgres DB cluster is retained.
- hostLogRetention: Duration
  - Specifies the duration for which the WAL logs will be retained on the source database host before deletion.
