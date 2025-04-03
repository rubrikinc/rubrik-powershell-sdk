### FilesetExportFilesJobConfigInput
Supported in v5.0+

- hostId: System.String
  - Supported in v5.0+
      Host ID.
- ignoreErrors: System.Boolean
  - Supported in v5.0+
      Optional Boolean value that determines whether or not to ignore errors during an export. By default, this value is set to False. Set this value to True to ignore errors.
- shareId: System.String
  - Supported in v5.0+
      Network share ID.
- excludePaths: list of System.Strings
  - Supported in v8.1+
      Optional field which excludes the paths specified during recovery.
- shouldRecreateDirectoryStructure: System.Boolean
  - Supported in v8.1+
      Optional field that specifies whether to recreate directory structure when using the 'Export to host' option in the UI.
- shouldRestoreOnlyAcls: System.Boolean
  - Optional field to determine if only ACLs should be restored during the restore process. The default value is false.
- exportPathPairs: list of FilesetExportPathPairInputs
  - Required. Supported in v5.0+
      Pairs of source path and destination path.
