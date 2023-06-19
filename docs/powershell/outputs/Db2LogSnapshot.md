### Db2LogSnapshot
Db2 log snapshot object.

- fid: System.String
  - The Rubrik FID of the Db2 snapshot object.
- cdmId: System.String
  - The CDM fid of the Db2 snapshot object.
- clusterUuid: System.String
  - UUID of the CDM cluster associated with Db2 workload.
- internalTimestamp: System.Int64
  - The internal time stamp of the Db2 snapshot object.
- isArchived: System.Boolean
  - Boolean for archival status of the Db2 snapshot object.
- workloadType: System.String
  - The workload type on which snapshot was taken.
- workloadId: System.String
  - The Rubrik fid of the workload on which snapshot was taken.
- date: DateTime
  - The creation date of the snapshot.
- appMetadata: Db2LogSnapshotAppMetadata
  - App metadata of log snapshots in Db2.
