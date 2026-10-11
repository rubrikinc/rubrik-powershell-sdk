### ValidatePermissionsForAccountReq
Specifies the request parameters to validate
the permissions for the given AWS cloud account.

- cloudAccountId: System.String
  - Specifies the ID of the AWS cloud account to be validated.
- featureReqs: list of ValidatePermissionsForFeatureReqs
  - Specifies the requests for each of the features
to validate.
- regions: list of System.Strings
  - Specifies the AWS regions to validate the permissions in. When empty,
the permissions are validated without any region context.
