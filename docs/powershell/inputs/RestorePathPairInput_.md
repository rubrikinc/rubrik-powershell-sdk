### RestorePathPairInput
Supported in v5.0+

- restorePath: System.String
  - Supported in v5.0+
      v5.0-v7.0: Directory of the folder to copy files into. If this is empty, file will be restored back into original directory.
      v8.0+: Path of the destination folder where the files will be restored. When not configured, the files are restored to the original source folder.
- path: System.String
  - Required. Supported in v5.0+
      v5.0-v5.3: Original file path to be restored
      v6.0-v7.0: Original file path to be restored.
      v8.0+: Path of the original file to be restored.
