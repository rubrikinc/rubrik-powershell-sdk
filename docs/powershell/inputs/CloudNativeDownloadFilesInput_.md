### CloudNativeDownloadFilesInput
Input required to download indexed cloud-native snapshot files.

- snapshotId: System.String
  - Snapshot ID.
- filePaths: list of System.Strings
  - File/Directory(s) to download.
- snapshotType: SnapshotType
  - Use a snapshot type of source, replicated or archived for recovery.
- fileRecoveryLocationDetails: FileRecoveryLocationDetailsInput
  - Details of the recovery location.
- downloadType: FileDownloadType
  - Type of download (download to cloud or virtual machine) intended.
- exocomputeCloudNativeAccountId: System.String
  - Rubrik ID of the account from which exocompute is launched during recovery. This is only applicable when the snapshot type is archived.
- exocomputeRegion: System.String
  - Cloud account region where Rubrik Exocompute is launched during recovery. This is only applicable when the snapshot type is archived.
