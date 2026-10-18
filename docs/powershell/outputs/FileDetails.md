### FileDetails
Details of a particular file.

- fileName: System.String
  - Name of the file.
- cleanSnapshotId: System.String
  - Unique identifier of the snapshot holding a clean (non-quarantined)
version of this file. Set only when the request sets
should_include_recovery_info and a retained snapshot holds one.
