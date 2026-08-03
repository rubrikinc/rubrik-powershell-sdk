### AwsExocomputeMapParamsInput
AWS-specific options for mapping cloud accounts to an Exocompute account.

- shouldEnableGatewayKeyCreation: System.Boolean
  - Whether to create a gateway encryption key in the source cloud account.
- shouldEnableAutomatedKeySharing: System.Boolean
  - Whether to automate KMS key sharing with the Exocompute account. Implied when shouldEnableGatewayKeyCreation is set.
- gatewayKmsKeyArnByAccount: list of AwsGatewayKmsKeyArnEntryInputs
  - Per manually-onboarded application account: the customer-provided multi-region gateway KMS key ARN. Honored only when shouldEnableGatewayKeyCreation is set; identifies the key RSC is permitted to replicate for automated key sharing.
