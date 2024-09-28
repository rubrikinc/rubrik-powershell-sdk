### TprRequestFilterInput
Input for filtering TPR requests.

- timeGt: DateTime
  - Lower time bound for filtering TPR requests.
- timeLt: DateTime
  - Upper time bound for filtering TPR requests.
- statuses: list of TprReqStatuss
  - Statuses for filtering TPR requests.
- orgs: list of System.Strings
  - List of organizations for filtering TPR requests.
- submittedBy: TprSubmittedByUser
  - Filtering TPR requests by users.
