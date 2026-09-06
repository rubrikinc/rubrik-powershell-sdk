### MysqldbInstanceAppMetadata
MySQL instance workload related app metadata for a snapshot.

- stats: KosmosDataSnapshotStats
  - The statistics of the MySQL instance snapshot.
- metadataVersion: System.String
  - The metadata version of the MySQL instance snapshot.
- databaseCdmIds: list of System.Strings
  - The CDM internal IDs of the databases in the MySQL instance snapshot.
- hasCapturedSchemas: System.Boolean
  - Whether the MySQL instance snapshot has captured per-database schema
available for replay at restore time.
- backupSource: System.String
  - For a MySQL high availability (HA) instance snapshot, specifies the name
of the replica that the snapshot was backed up from, based on the current
topology. Returns null for non-HA instances, log snapshots, older
snapshots without a replica ID, or when the topology is unavailable.
