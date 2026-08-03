### SidPolicyHitsSummary
Summary of sensitive data discovery policy for a given security identifier.

- principal: System.String
  - Principal for which this summary is generated.
- summary: list of PolicyHitsSummarys
  - Per-policy hit summaries for the principal.
- analyzerNames: list of System.Strings
  - Names of analyzers contributing to the policy hits for the principal.
