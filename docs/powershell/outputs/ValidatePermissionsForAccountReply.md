### ValidatePermissionsForAccountReply
Specifies the validation results for the
given AWS cloud account.

- cloudAccountId: System.String
  - Specifies the ID of the validated AWS cloud account.
- cloudAccountName: System.String
  - Specifies the name of the validated AWS cloud account.
- cloudAccountNativeId: System.String
  - Specifies the native ID of the validated AWS cloud account.
- status: SuccessStatus
  - Specifies the overall status of the validation for the
given AWS cloud account.
- permissionMissingForSimulation: System.Boolean
  - Represents if the permissions for simulation are missing in
the given AWS cloud account.
- numMissingPermissions: System.Int32
  - Specifies the number of missing permissions for the
given AWS cloud account.
- featureResults: list of ValidatePermissionsForFeatureReplys
  - Specifies the validation results for each of the features.
