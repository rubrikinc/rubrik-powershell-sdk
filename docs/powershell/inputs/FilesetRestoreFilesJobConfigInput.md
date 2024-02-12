### FilesetRestoreFilesJobConfigInput
Supported in v5.0+

- ignoreErrors: System.Boolean
  - Supported in v5.0+
      Optional field to determine if we should ignore single error during restore. Default value is false.
- shouldRecreateDirectoryStructure: System.Boolean
  - Supported in v8.1, v9.1+
      v8.1: Optional field that specifies whether to recreate directory structure when using the 'Restore to separate folder' option in the UI.
      v9.1+: Optional field that specifies whether to recreate directory structure when using the 'Restore to separate folder' option in the UI.
- restoreConfig: list of FilesetRestorePathPairInputs
  - Required. Supported in v5.0+
      v5.0-v5.3: Absolute file path and restore path if not restored back to itself
      v6.0+: Absolute file path.. and restore path if not restored back to itself.
