### ValidatePermissionsForRoleReply
Specifies the validation results for the given role.

- role: RoleType
  - Specifies the validated role type.
- roleArn: System.String
  - The ARN of the role.
- status: SuccessStatus
  - Specifies the overall status of the validation request for the
given role.
- numMissingPermissions: System.Int32
  - Specifies the number of missing permissions for the
given role.
- actionResults: list of SimulationResults
  - Specifies the validation results for each of the actions.
