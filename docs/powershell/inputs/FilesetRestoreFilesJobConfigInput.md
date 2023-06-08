### FilesetRestoreFilesJobConfigInput
Supported in v5.0+

- ignoreErrors: System.Boolean
  - Supported in v5.0+
      Optional field to determine if we should ignore single error during restore. Default value is false.
- restoreConfig: list of FilesetRestorePathPairInputs
  - Required. Supported in v5.0+
      v5.0-v5.3: Absolute file path and restore path if not restored back to itself
      v6.0+: Absolute file path.. and restore path if not restored back to itself.
