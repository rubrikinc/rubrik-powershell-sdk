### PolicyResult
Policy detailed result.

- policy: DSPMPolicy
  - Policy definition.
- violationsSummary: ViolationsSummary
  - Aggregated violations summary for the policy.
- violationNames: list of System.Strings
  - Distinct violation names observed for this policy, sorted
alphabetically. Vendor integration policies (CrowdStrike, Microsoft
Defender) populate per-detection titles here; other policy types
typically have no violation names and yield an empty list.
