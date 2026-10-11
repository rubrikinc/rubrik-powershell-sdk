### IdentityEventTarget
A single target of the identity event that produced a policy violation.

- identityId: System.String
  - Principal ID of the target.
- identityName: System.String
  - Display name of the target. Empty when the principal cannot be resolved.
- identityType: ViolationPrincipalType
  - Principal type of the target. Falls back to the type recorded on the
event when the principal cannot be resolved.
- privilegeType: PrivilegeType
  - Privilege type of the target identity.
