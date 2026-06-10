### IcebergTableSpecificSnapshot
Iceberg table-specific snapshot information. Vendor-neutral: covers Glue, S3 Tables, Dremio, and future external catalogs.

- icebergSnapshotId: System.Int64
  - Native Iceberg snapshot ID - cross-references this Rubrik snapshot with the source Iceberg table's snapshot history.
- icebergSnapshotSize: System.Int64
  - Total logical size at source of all files pointed to by this Iceberg snapshot (data + manifests + manifest list + metadata.json + delete files + puffin/stats). This is the size of the data the user gets back on recovery. Independent of incremental backup state.
- icebergSnapshotFileCount: System.Int64
  - Total number of files pointed to by this Iceberg snapshot at source, across all Iceberg file types: data files (Parquet/ORC/Avro), manifest files, manifest list files, the metadata.json itself, position/equality delete files, and any statistics or puffin files. Independent of incremental backup state.
- bytesCopied: System.Int64
  - Bytes Rubrik actually transferred during this backup (INCREMENTAL - for non-first backups this is the delta only; unchanged files are not re-copied). May be less than icebergSnapshotSize.
- fileCount: System.Int64
  - Number of files Rubrik actually copied during this backup (INCREMENTAL - only files new/changed since the prior backup are counted). May be less than icebergSnapshotFileCount.
- isSnapshotPartial: System.Boolean
  - True when some files failed to copy and the snapshot represents a partial backup. Consumers should treat partial snapshots as best-effort and surface the state to the user.
- snapshotId: System.String
  - ID of the snapshot.
