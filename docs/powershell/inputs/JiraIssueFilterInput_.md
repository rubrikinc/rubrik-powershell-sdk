### JiraIssueFilterInput
Filter for Jira issues.

- isRelic: System.Boolean
  - Filters based on whether the issue is a relic.
- assigneeNaturalIds: list of System.Strings
  - Filters issues that are assigned to the specified list of user IDs.
- issueTypeNaturalIds: list of System.Strings
  - Filters issues with the specified list of issue types.
- searchTerm: System.String
  - Filters issues by search term in issue name or summary.
- reporterNaturalIds: list of System.Strings
  - Filters issues with the specified list of reporters.
- componentNaturalIds: list of System.Strings
  - Filters issues with the specified list of components.
- priorityNaturalIds: list of System.Strings
  - Filters issues with the specified list of issue priorities.
- createdDate: JiraTimeRangeFilter
  - Filters issues with a created date in the specified time range.
- updatedDate: JiraTimeRangeFilter
  - Filters issues with an updated date in the specified time range.
- actionTypes: list of AppItemActionTypes
  - Filters issues by the action types that were performed during the specified time.
- actionDate: JiraTimeRangeFilter
  - Filters issues by the action performed on them in the specified time range.
