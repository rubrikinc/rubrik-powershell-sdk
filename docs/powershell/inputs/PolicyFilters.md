### PolicyFilters
Policy-level filter criteria shared across policy violation queries.

- policySeverities: list of ViolationSeveritys
  - List of policy severities to filter by.
- policyCategories: list of Categorys
  - List of policy categories to filter by.
- policyTypes: list of PolicyTypes
  - List of policy types to filter by.
- includeDeletedPolicies: System.Boolean
  - Include deleted policies.
- policyFrameworks: list of System.Strings
  - Filter by compliance frameworks (e.g., "NIST_CSF", "CIS_CONTROLS", "SOC2").
