### SnapshotConsistencyLevel
Consistency level achieved when a snapshot was taken.

- UNKNOWN_CONSISTENCY_LEVEL - The consistency level of the snapshot is unknown or unspecified.
- SNAPSHOT_CRASH_CONSISTENT - The snapshot is crash consistent: it captures the on-disk state as if
the system had crashed, without flushing in-flight application state.
- SNAPSHOT_APP_CONSISTENT - The snapshot is application consistent: applications were quiesced so
that in-memory and in-flight data was flushed before the snapshot.
