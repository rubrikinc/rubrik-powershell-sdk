### CalendarSearchFilter
Parameters for calendar event search.

- searchKeywordFilter: CalendarSearchKeywordFilter
- emailAddresses: list of CalendarEmailAddressFilters
  - 
- timerange: TimeRangeFilter
  - Filters on time range.
- searchObjectFilter: CalendarSearchObjectFilter
  - Filters on object type.
- recurrenceFilter: CalendarRecurrenceFilter
  - Filters on recurrence type.
- lambdaFilters: LambdaPathFilters
  - Used for Lambda search/browse, diff/full FMD paths for Calendar.
- skipRifItems: System.Boolean
  - Specifies whether or not to skip items in Recoverable Items Folder.
