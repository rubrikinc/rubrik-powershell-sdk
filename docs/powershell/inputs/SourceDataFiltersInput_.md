### SourceDataFiltersInput
- modifiedTimeRange: ChatbotTimeRangeFilterInput
  - If specified, only include files whose modified time is within this range.
 If the time range is null, files will not be filtered based on modified
 time.
- sensitiveDataPolicyIds: list of System.Strings
  - IDs of Sensitive Data policies used to filter sensitive content from Retrieval Augmented Generation. If this list is empty, no sensitive data policies will be used.
- extensionWhitelist: list of System.Strings
  - List of file extensions you can use during Retrieval Augmented Generation. If this list is empty, all file extensions will be usable. Elements in the whitelist should be of the format: '.txt'.
