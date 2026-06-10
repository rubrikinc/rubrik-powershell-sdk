### UpgradePathEligibilityReply
Result of an upgrade path eligibility check.

- isEligible: System.Boolean
  - Whether the upgrade path is eligible.
False if any eligibility check fails.
- blockers: list of PathBlockers
  - List of all checks that blocked the upgrade path.
Empty if the path is eligible.
