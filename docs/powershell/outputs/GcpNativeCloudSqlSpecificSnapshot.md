### GcpNativeCloudSqlSpecificSnapshot
Snapshot information specific to the GCP Cloud SQL instance.

- storageSize: System.Int32
  - Size of allocated storage of the Cloud SQL instance in GiB.
- kmsKey: System.String
  - KMS key used for encryption, if any.
- databaseVersion: System.String
  - Database version of the Cloud SQL instance.
- edition: GcpCloudSqlEdition
  - Edition of the Cloud SQL instance.
- instanceTier: System.String
  - Instance tier of the Cloud SQL instance.
- snapshotId: System.String
  - ID of the snapshot.
