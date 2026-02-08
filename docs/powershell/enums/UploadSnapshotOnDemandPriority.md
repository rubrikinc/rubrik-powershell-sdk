### UploadSnapshotOnDemandPriority
Priority level for upload snapshot on demand operation.
Determines the order in which snapshots are uploaded.

- UPLOAD_SNAPSHOT_ON_DEMAND_PRIORITY_UNSPECIFIED - Unspecified priority.
- UPLOAD_BEFORE_ALL - Upload before all other pending snapshots.
- UPLOAD_AFTER_CUSTOM_RETENTION - Upload after any custom retention snapshots, but before others.
- UPLOAD_AFTER_ALL - Upload after all other pending snapshots.
