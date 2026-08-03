### FileInfo
Represents the OneDrive file to be restored.

- fileId: System.String
  - ID of the file.
- fileName: System.String
  - Name of the file.
- fileSnapshotsToRestore: list of FileSnapshotInfos
  - Snapshots of the file to restore.
- channelInfo: TeamsChannelInfo
  - Teams channel the file belongs to, if any.
