### ValidatePermissionsForFeatureReply
Specifies the validation results for the
given feature.

- feature: CloudAccountFeature
  - Specifies the feature that is validated.
- status: SuccessStatus
  - Specifies the overall status of the validation request for the
given feature.
- numMissingPermissions: System.Int32
  - Specifies the number of missing permissions for the
given feature.
- roleResults: list of ValidatePermissionsForRoleReplys
  - Specifies the validation results for each of the roles.
