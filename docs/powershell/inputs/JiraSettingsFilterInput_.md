### JiraSettingsFilterInput
Filter for Jira settings.

- searchTerm: System.String
  - Filter for settings with matching name (sub string).
- actionTypes: list of AppItemActionTypes
  -  Filters settings by the action types that were performed during the specified time.
- actionDate: JiraTimeRangeFilter
  - Filters settings by the action performed on them in the specified time range.
