### Issue
A high-risk location: a file whose classification results violate one or more
policies, together with the policy and event context for it.

- id: System.String
  - Base64-encoded identifier of the issue.
- latestPolicyObj: PolicyObj
  - The most recent policy object associated with this issue.
- fileResult: FileResult
  - The file that this issue was raised on.
- violations: System.Int32
  - Number of policy violations counted for this issue.
- resolvedTime: System.Int64
  - Time the issue was resolved, in milliseconds since epoch. Zero while open.
- openTime: System.Int64
  - Time the issue was opened, in milliseconds since epoch.
- paginationId: System.String
  - Opaque cursor used to paginate a list of issues.
- events: list of IssueEvents
  - The history of events for this issue.
- policies: list of ClassificationPolicySummarys
  - Summaries of the policies associated with this issue.
