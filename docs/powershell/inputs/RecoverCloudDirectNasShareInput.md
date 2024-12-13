### RecoverCloudDirectNasShareInput
Input for recovering NAS Cloud Direct share.

- srcShareName: System.String
  - Name of the source NAS Cloud Direct share.
- snapshotFid: System.String
  - FID of the snapshot being restored from.
- restorePathPairList: list of NascdRestorePathPairInputs
  - List of restore path pairs. srcPath in NascdRestorePathPairInput should not overlap with each other. All dstPath in restorePathPairList should be the same.
- destShareFid: System.String
  - FID of the NAS Cloud Direct share we are restoring to.
