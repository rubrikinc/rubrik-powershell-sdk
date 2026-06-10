### AzureAdEmAssignmentPolicy
Entitlement Management assignment policy.

- displayName: System.String
  - Human-readable name of the assignment policy.
- description: System.String
  - Description of the assignment policy.
- isAccessReviewRequired: System.Boolean
  - Specifies whether periodic access reviews are required.
- isApprovalRequired: System.Boolean
  - Specifies whether approval is required for requests.
- isJustificationRequired: System.Boolean
  - Specifies whether requestors must provide a justification.
- expiration: AzureAdEmExpiration
  - Expiration settings for assignments granted by this policy.
- whoCanRequestAccess: list of System.Strings
  - Who can request access (Self, Admin, Manager).
- allowedTargetScope: EmAllowedTargetScope
  - Scope of who can get access.
- specificAllowedTargets: list of System.Strings
  - If allowed_target_scopes is specific objects, this provides the list.
