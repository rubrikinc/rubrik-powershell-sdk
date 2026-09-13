### MariadbInstanceAppMetadata
MariaDB instance workload related app metadata for a snapshot.

- stats: KosmosDataSnapshotStats
  - The statistics of the MariaDB instance snapshot.
- metadataVersion: System.String
  - The metadata version of the MariaDB instance snapshot.
- snapshotType: MariadbSnapshotType
  - Type of the MariaDB data snapshot. Unspecified for binary-log snapshots.
- databaseIds: list of System.Strings
  - IDs of the MariaDB databases captured in this snapshot.
