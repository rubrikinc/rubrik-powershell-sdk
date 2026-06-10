### DownloadResultsCsvFiltersInput


- analyzerGroupIds: list of System.Strings
  - The analyzer groups used to filter either browse directory or list file results.
- browseDirectorySnappablePath: SnappablePathInput
  - The path for a browse directory results CSV download.
- listFileResultsSnappablePaths: list of SnappablePathInputs
  - Object FID and optional path for list file results CSV download.
- listFileResultsSnappableTypes: list of System.Strings
  - 
- listFileResultsSearchText: System.String
  - Search text for filtering file results by path in CSV download.
- whitelistEnabled: System.Boolean
  - Whether to include whitelists in the results.
- fileType: FileCountType
  - The type of files to include in the CSV.
- policyViolationId: System.String
  - The policy violation ID.
