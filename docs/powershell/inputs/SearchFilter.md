### SearchFilter
Parameters for mail or folder search.

- searchKeywordFilter: SearchKeywordFilter
- emailAddresses: list of EmailAddressFilters
- fromTime: DateTime
- untilTime: DateTime
- searchObjectFilter: SearchObjectFilter
- lambdaFilters: LambdaPathFilters
  - Parameters for using Lambda filters in the query.
- archiveFolderAction: ArchiveFolderAction
  - Specifies actions for the in-place archive folder.
- skipRifItems: System.Boolean
  - Specifies whether to skip items in the Recoverable Items folder.
- useExactVersionMatch: System.Boolean
  - Determines whether you should use a query that is an exact version match.
