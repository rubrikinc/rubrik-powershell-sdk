### RecoverCloudDirectMultiPathsInput
Input for recovering Cloud Direct multi-paths.

- snapshotFid: System.String
  - FID of snapshot being restored.
- restorePathPairList: list of NascdRestorePathPairInputs
  - List of restore path pairs. srcPath in NascdRestorePathPairInput should not overlap with each other. All dstPath in restorePathPairList should be the same.
- dstExportId: System.Int32
  - Export ID of Cloud Direct destination share.
