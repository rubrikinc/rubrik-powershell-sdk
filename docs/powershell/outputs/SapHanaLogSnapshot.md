### SapHanaLogSnapshot
SAP HANA log snapshot object.

- fid: System.String
  - The fid of the SAP HANA snapshot object.
- cdmId: System.String
  - The CDM fid of the SAP HANA snapshot object.
- clusterUuid: System.String
  - UUID of the CDM cluster associated with SAP HANA database.
- internalTimestamp: System.Int64
  - The internal timestamp of the SAP HANA snapshot object.
- isArchived: System.Boolean
  - Specifies the archival status of the SAP HANA snapshot object.
- workloadType: System.String
  - The object type on which snapshot was taken.
- workloadId: System.String
  - The CDM ID of the SAP HANA database on which snapshot was taken.
- date: DateTime
  - The creation date of the snapshot.
- locationMap: System.String
  - Mapping of locations where snapshot is available.
- appMetadata: SapHanaLogSnapshotAppMetadata
  - App metadata of log snapshots in SAP HANA.
