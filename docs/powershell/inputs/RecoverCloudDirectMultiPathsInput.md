### RecoverCloudDirectMultiPathsInput
Input for recovering NAS Cloud Direct multi-paths.

- snapshotFid: System.String
  - FID of snapshot being restored.
- restorePathPairList: list of NascdRestorePathPairInputs
  - List of restore path pairs. srcPath in NascdRestorePathPairInput should not overlap with each other. All dstPath in restorePathPairList should be the same.
- dstExportId: System.Int32
  - Export ID of NAS Cloud Direct destination share.
- dstExportFid: System.Int32
  - FID of NAS Cloud Direct destination share.
- aclOnly: System.Boolean
  - Whether to restore only ACLs without file content.
