### ClosestSnapshotSearchResult
The result of a search for an unexpired snapshot closest to a point in time for a specific workload.

- snappableId: System.String
  - The workload's ID.
- snapshot: ClosestSnapshotDetail
  - The snapshot closest to the point in time.
- error: SnapshotSearchError
  - An error which occurred during the search.
