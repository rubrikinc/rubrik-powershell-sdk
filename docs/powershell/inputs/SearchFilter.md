### SearchFilter
Parameters for mail or folder search.

- searchKeywordFilter: SearchKeywordFilter
  - Keyword filter (subject / folder name) applied to the search.
- emailAddresses: list of EmailAddressFilters
  - Email-address filters (sender / recipient) applied to the search.
- fromTime: DateTime
  - Represents the start time of the search filter.
- untilTime: DateTime
  - Represents the end time of the search filter.
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
- itemId: System.String
  - Optional: filter to a single object by its M365 item ID.
Empty or unset = no filter.
