### CheckArchivedSnapshotsLockedReply
Archived snapshot locking related details for a workload.

- invalidSnapshotIds: a list of System.Strings
  - Snapshot IDs are not valid for checking if they are locked. Snapshots which do not have unexpired archival copy are considered invalid.
- lockedSnapshotIds: a list of System.Strings
  - Snapshot IDs for which the archived copy is locked.
- unlockedSnapshotIds: a list of System.Strings
  - Snapshot IDs for which the archived copy is not locked.
