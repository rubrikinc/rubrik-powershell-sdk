### GovernanceRecoveryOptionType
Governance-aware classifier configuration for Member, Owner, and RoleAssignment edge restore.

- newGovernanceEndTime: DateTime
  - Caps the expiration of PIM-sourced edges restored via PIM schedule requests. Unset means use the snapshot's original endDateTime, or noExpiration if the snapshot was permanent.
- recoverLinkedCatalogs: System.Boolean
  - Cascades catalog restoration when an access package references a catalog missing in the live tenant. Mirrors recoverLinkedApplication on ServicePrincipalRecoveryOptionType.
