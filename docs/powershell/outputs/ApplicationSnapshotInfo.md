### ApplicationSnapshotInfo
ApplicationSnapshotInfo holds the key fields of an
optimized snapshot result. Wraps the relevant fields
from snapshotservice.ClosestSnapshotDetail to avoid
exposing internal deprecated fields via GraphQL.

- snapshotFid: System.String
  - Snapshot ID.
- snapshotDate: DateTime
  - Snapshot creation time.
- snapshotLocation: CloudNativeSnapshotLocationType
  - Location type of the snapshot.
