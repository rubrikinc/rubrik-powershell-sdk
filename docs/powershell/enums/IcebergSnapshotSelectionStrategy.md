### IcebergSnapshotSelectionStrategy
Strategy for choosing which native Iceberg snapshot a backup captures.

- ICEBERG_SNAPSHOT_LATEST - Back up the table's latest snapshot by commit time (default).
- ICEBERG_SNAPSHOT_LATEST_COMPACTED - Back up the newest compacted (overwrite) snapshot.
- ICEBERG_SNAPSHOT_LATEST_TAGGED - Back up the newest snapshot whose tag ref name matches tag_regex (RE2).
