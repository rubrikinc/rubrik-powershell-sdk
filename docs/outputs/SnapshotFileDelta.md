### SnapshotFileDelta
Snapshot file or directory and its delta information.

- childrenDeltas: a list of SnapshotDeltas
  - This field is non-empty for directories only. It contains the consolidated delta information of the subdirectories.
- file: SnapshotFile
  - Information about the file or directory such as the path and last modified date.
- previousSnapshotQuarantineInfo: QuarantineInfo
  - Quarantine information for a path in the previous snapshot.
- selfDeltas: a list of SnapshotDeltas
  - This field is empty for directories. It contains the delta information of the file.
