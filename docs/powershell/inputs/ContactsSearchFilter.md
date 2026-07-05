### ContactsSearchFilter
Parameters for contacts search.

- searchKeywordFilter: ContactsSearchKeywordFilter
  - Filters on keywords.
- searchObjectFilter: ContactsSearchObjectFilter
  - Filters on object type.
- lambdaFilters: LambdaPathFilters
  - Used for Lambda search/browse, diff/full FMD paths for Contact.
- skipRifItems: System.Boolean
  - Specifies whether or not to skip items in Recoverable Items Folder.
- itemId: System.String
  - Optional: filter to a single object by its M365 item ID.
Empty or unset = no filter.
