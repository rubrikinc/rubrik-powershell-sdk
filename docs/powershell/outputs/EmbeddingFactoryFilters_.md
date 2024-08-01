### EmbeddingFactoryFilters
- extensionWhitelist: list of System.Strings
  - List of file extensions you can use during Retrieval Augmented Generation.
 If this list is null or empty, all file extensions will be usable.
 Elements in the whitelist should be of the format: ".txt".
- modifiedTimeRange: ChatbotTimeRangeFilterType
  - If specified, only include files whose modified time is within this range.
 If the time range is null, files will not be filtered based on modified
 time.
- sensitiveDataPolicyIds: list of System.Strings
  - IDs of Sensitive Data policies used to filter out sensitive content from Retrieval Augmented Generation. If this list is empty, no sensitive data policies will be used
