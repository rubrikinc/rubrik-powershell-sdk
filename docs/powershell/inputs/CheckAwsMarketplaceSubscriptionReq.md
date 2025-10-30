### CheckAwsMarketplaceSubscriptionReq
Request to check AWS marketplace subscription status.

- cloudAccountId: System.String
  - AWS cloud account ID in RSC.
- region: System.String
  - AWS region.
- cdmVersion: System.String
  - CDM version to check subscription for.
- accountCredentials: AwsAccountCredentials
  - Optional AWS account credentials
(if not provided, will use cloud account credentials).
