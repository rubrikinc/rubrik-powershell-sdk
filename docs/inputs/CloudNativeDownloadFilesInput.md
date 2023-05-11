### CloudNativeDownloadFilesInput
Input required to download indexed cloud-native snapshot files.

- downloadType: FileDownloadType
  - Type of download (download to cloud or virtual machine) intended.
- exocomputeCloudNativeAccountId: System.String
  - Rubrik ID of the account from which exocompute is launched during recovery. This is only applicable when the snapshot type is archived.
- exocomputeRegion: System.String
  - Cloud account region where Rubrik Exocompute is launched during recovery. This is only applicable when the snapshot type is archived.
- filePaths: a list of System.Strings
  - File/Directory(s) to download.
- fileRecoveryLocationDetails: FileRecoveryLocationDetailsInput
  - Details of the recovery location.
- snapshotId: System.String
  - Snapshot ID.
- snapshotType: SnapshotType
  - Use a snapshot type of source, replicated or archived for recovery.
