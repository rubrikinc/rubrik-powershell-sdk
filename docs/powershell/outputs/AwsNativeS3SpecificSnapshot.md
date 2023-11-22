### AwsNativeS3SpecificSnapshot
AWS S3-specific snapshot information.

- processedObjectCount: System.Int64
  - List of objects successfully backed up.
- failedObjectCount: System.Int64
  - List of objects failed to back up.
- isSnapshotPartial: System.Boolean
  - Verifies if the snapshot is a partial backup.
- snapshotId: System.String
  - ID of the snapshot.
