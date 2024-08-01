### JiraIssueChangeDetailsFilter
Filter issue change details.

- assigneeNaturalIds: list of System.Strings
  - Filters issues assigned to the specified list of user IDs.
- issueTypeNaturalIds: list of System.Strings
  - Filters issues with the specified list of issue types.
- reporterNaturalIds: list of System.Strings
  - Filters issues with the specified list of reporters.
- componentNaturalIds: list of System.Strings
  - Filters issues with the specified list of components.
- priorityNaturalIds: list of System.Strings
  - Filters issues with the specified list of issue priorities.
- actionTypes: list of AppItemActionTypes
  - Filters issues that use the action types that were performed during the specified time.
- searchTerm: System.String
  - Filters projects with the matching name (substring).
- createdDate: JiraTimeRangeFilter
  - Filters issues with a created date that occurred during the specified time range.
- updatedDate: JiraTimeRangeFilter
  - Filters issues with an updated date that occurred during the specified time range.
