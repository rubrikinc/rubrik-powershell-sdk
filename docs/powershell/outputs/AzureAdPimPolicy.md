### AzureAdPimPolicy
PIM activation/assignment policy for an Entra ID role.

- activationMaxDurationMinutes: System.Int32
  - Maximum activation duration in minutes.
- requireApprovalToActivate: System.Boolean
  - Whether approval is required to activate the role.
- approvers: list of System.Strings
  - Approver display identifiers (user IDs or group IDs).
- allowPermanentEligibleAssignment: System.Boolean
  - Whether permanent eligible assignments are allowed.
- eligibleAssignmentExpirationDays: System.Int32
  - Eligible assignment expiration in days (0 if permanent).
- allowPermanentActiveAssignment: System.Boolean
  - Whether permanent active assignments are allowed.
- activeAssignmentExpirationDays: System.Int32
  - Active assignment expiration in days (0 if permanent).
- requireMfaOnActiveAssignment: System.Boolean
  - Whether MFA is required on active assignment.
- activationMaxDurationSeconds: System.Int64
  - Maximum activation duration in seconds.
- eligibleAssignmentExpirationSeconds: System.Int64
  - Eligible assignment expiration in seconds (0 if permanent).
- activeAssignmentExpirationSeconds: System.Int64
  - Active assignment expiration in seconds (0 if permanent).
