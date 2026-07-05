### CalendarSearchFilter
Parameters for calendar event search.

- searchKeywordFilter: CalendarSearchKeywordFilter
  - Keyword filter (event / calendar name) applied to the search.
- emailAddresses: list of CalendarEmailAddressFilters
  - Email-address filters (organizer / attendee) applied to the search.
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
- itemId: System.String
  - Optional: filter to a single object by its M365 item ID.
Empty or unset = no filter.
