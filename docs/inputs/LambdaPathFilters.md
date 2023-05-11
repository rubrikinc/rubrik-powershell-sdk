### LambdaPathFilters
Parameters to use lambda filters in query.

- enableAbsolutePathCachePreload: System.Boolean
  - Determines if all folders in passed snapshot are queried to build absolute paths from root and used in conjunction with enableAbsolutePaths to return absolute paths from root in QueryV2Reply.
- enableAbsolutePaths: System.Boolean
  - Determines if documents are returned with absolute paths the from root in reply.
- parentFolderIdBatch: a list of System.Strings
  - Retrieves all the folders whose ID's are provided in the list used for generating absolute paths for passed items primarily.
- searchRecurseFolderId: System.String
  - The Folder ID under which recursive search will be performed.
