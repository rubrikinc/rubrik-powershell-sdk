### FilesetRestoreFilesJobConfigInput
Supported in v5.0+

- ignoreErrors: System.Boolean
  - Supported in v5.0+
      Optional field to determine if we should ignore single error during restore. Default value is false.
- excludePaths: list of System.Strings
  - Supported in v9.0, v9.2+
      v9.0: Optional field which excludes the paths specified during recovery.
      v9.2+: Optional field which excludes the paths specified during recovery.
- shouldRecreateDirectoryStructure: System.Boolean
  - Supported in v8.1+
      Optional field that specifies whether to recreate directory structure when using the 'Restore to separate folder' option in the UI.
- restoreConfig: list of FilesetRestorePathPairInputs
  - Required. Supported in v5.0+
      v5.0-v5.3: Absolute file path and restore path if not restored back to itself
      v6.0+: Absolute file path.. and restore path if not restored back to itself.
