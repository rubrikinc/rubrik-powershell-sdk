### SearchFilter
Parameters for mail or folder search.

- searchKeywordFilter: SearchKeywordFilter
- emailAddresses: list of EmailAddressFilters
  - 
- fromTime: DateTime
  - Represents the start time of the search filter.
- untilTime: DateTime
- searchObjectFilter: SearchObjectFilter
  - Filters on object type.
- lambdaFilters: LambdaPathFilters
  - Used for Lambda search/browse, diff/full FMD paths for mailbox.
- archiveFolderAction: ArchiveFolderAction
  - Used to identify that how to deal with in-place archive folder.
- skipRifItems: System.Boolean
  - Specifies whether or not to skip items in Recoverable Items Folder.
- useExactVersionMatch: System.Boolean
  - Specifies whether to query items for exact version match.
