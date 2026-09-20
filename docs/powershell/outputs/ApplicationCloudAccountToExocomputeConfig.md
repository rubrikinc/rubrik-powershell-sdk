### ApplicationCloudAccountToExocomputeConfig
Details about an Exocompute configuration.

- applicationCloudAccountId: System.String
  - Application cloud account id for which configs are applicable.
- mappedExocomputeAccount: CloudAccountDetails
  - Mapped Exocompute account details.
- isHost: System.Boolean
  - Specifies whether the cloud account is the host cloud account.
- exocomputeConfigs: list of AwsExocomputeGetConfigurationResponses
  - Details about the Exocompute configurations.
