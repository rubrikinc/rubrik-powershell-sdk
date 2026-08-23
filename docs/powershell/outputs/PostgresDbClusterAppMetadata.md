### PostgresDbClusterAppMetadata
PostgreSQL DB cluster workload related app metadata for a snapshot.

- stats: KosmosDataSnapshotStats
  - The statistics of the PostgreSQL DB cluster snapshot.
- backupSource: System.String
  - For a PostgreSQL high availability (HA) snapshot, specifies the name of the
replica that the snapshot was backed up from, based on the current topology.
Returns null for non-HA clusters, log snapshots, older snapshots without a
replica ID, or when the topology is unavailable.
