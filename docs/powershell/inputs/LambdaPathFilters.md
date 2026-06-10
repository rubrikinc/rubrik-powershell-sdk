### LambdaPathFilters
NOTE: This filter is used only for Lambda related use-cases. Avoid using
this filter for other use-cases.

- enableAbsolutePaths: System.Boolean
  - Determines if documents are returned with absolute paths from the root
in reply.
- enableAbsolutePathCachePreload: System.Boolean
  - Determines if all folders in passed snapshot are queried to build
absolute paths from root and used in conjunction with enableAbsolutePaths
to return absolute paths from root in QueryV2Reply.
- parentFolderIdBatch: list of System.Strings
  - Retrieves all the folders whose identifiers are provided in the list.
- searchRecurseFolderId: System.String
  - The folder under which recursive search will be performed.
- includeAncestors: System.Boolean
  - Determines if ancestors are included in the search results.
