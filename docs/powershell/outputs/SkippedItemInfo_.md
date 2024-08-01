### SkippedItemInfo
Represents a single skipped item for a specific M365 snapshot taken by Rubrik.

- itemId: System.String
  - The ID of the skipped item.
- itemName: System.String
  - The name of the skipped item.
- itemMetadata: System.String
  - The metadata of the skipped item.
- sizeInBytes: System.Int64
  - The size of the skipped item in bytes.
- createSnapshotNum: System.Int32
  - The snapshot number when the skipped item was created.
- createTimeInMillis: System.Int64
  - The time when the skipped item was created in milliseconds.
- errorType: System.String
  - The type of error encountered while processing the skipped item.
- errorMsg: System.String
  - The error message associated with the skipped item.
- isDeleted: System.Boolean
  - Indicates whether the skipped item has been deleted.
- itemType: System.String
  - The type of the skipped item.
