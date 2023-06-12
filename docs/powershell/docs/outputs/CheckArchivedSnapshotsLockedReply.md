### CheckArchivedSnapshotsLockedReply
Archived snapshot locking related details for a workload.

- lockedSnapshotIds: list of System.Strings
  - Snapshot IDs for which the archived copy is locked.
- unlockedSnapshotIds: list of System.Strings
  - Snapshot IDs for which the archived copy is not locked.
- invalidSnapshotIds: list of System.Strings
  - Snapshot IDs are not valid for checking if they are locked. Snapshots which do not have unexpired archival copy are considered invalid.
