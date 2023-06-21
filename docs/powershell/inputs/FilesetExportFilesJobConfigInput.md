### FilesetExportFilesJobConfigInput
Supported in v5.0+

- ignoreErrors: System.Boolean
  - Supported in v5.0+
      Optional Boolean value that determines whether or not to ignore errors during an export. By default, this value is set to False. Set this value to True to ignore errors.
- shareId: System.String
  - Supported in v5.0+
      Network share ID.
- exportPathPairs: list of FilesetExportPathPairInputs
  - Required. Supported in v5.0+
      Pairs of source path and destination path.
- hostId: System.String
  - Required. Supported in v5.0+
      Host ID.
