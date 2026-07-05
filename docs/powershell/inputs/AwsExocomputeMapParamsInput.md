### AwsExocomputeMapParamsInput
AWS-specific options for mapping cloud accounts to an Exocompute account.

- shouldEnableGatewayKeyCreation: System.Boolean
  - Whether to create a gateway encryption key in the source cloud account.
- shouldEnableAutomatedKeySharing: System.Boolean
  - Whether to automate KMS key sharing with the Exocompute account. Implied when shouldEnableGatewayKeyCreation is set.
