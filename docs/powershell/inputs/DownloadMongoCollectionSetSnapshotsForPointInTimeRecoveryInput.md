### DownloadMongoCollectionSetSnapshotsForPointInTimeRecoveryInput
Input for downloading MongoDB collection set snapshots for a point in time recovery.

- id: System.String
  - Required. ID of the MongoDB collection set.
- userNote: System.String
  - User note to associate with audits.
- downloadConfig: MongoSnapshotDownloadRequestInput
  - Required. Object containing information required for downloading snapshots for a point in time recovery. The object includes the point in time and the location for the snapshots to be downloaded.
