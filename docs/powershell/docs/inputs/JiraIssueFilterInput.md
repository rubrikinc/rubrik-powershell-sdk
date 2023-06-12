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
