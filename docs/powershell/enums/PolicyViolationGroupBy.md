### PolicyViolationGroupBy
Grouping mode for the CSV export, mirroring the violations list UI's
group-by selector.

- POLICY_VIOLATION_GROUP_BY_UNSPECIFIED - Unspecified grouping; treated as POLICY_VIOLATION_GROUP_BY_NONE.
- POLICY_VIOLATION_GROUP_BY_NONE - No grouping; export the flat list of violations.
- POLICY_VIOLATION_GROUP_BY_POLICY - Group violations by policy (one section per policy).
- POLICY_VIOLATION_GROUP_BY_RESOURCE - Group violations by resource (one section per resource / identity).
