### SnapMirrorCloudRestorePathPairInput
Supported in v7.0+
  v7.0-v8.0: 
  v8.1+: Input to restore a file from a SnapMirror Cloud snapshot.

- dstPath: System.String
  - Supported in v7.0+
      Absolute path to the restore or export destination for files and folders.
- srcPath: System.String
  - Required. Supported in v7.0+
      Path relative to the root of the NAS share of the files/folders to restore or export.
