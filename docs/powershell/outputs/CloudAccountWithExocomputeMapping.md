### CloudAccountWithExocomputeMapping
Account with Exocompute mapping, if present.

- applicationAccount: CloudAccountDetails
  - Cloud account details.
- exocomputeAccount: CloudAccountDetails
  - Mapped Exocompute account details.
- exocomputeMappableRegions: list of AwsCloudAccountRegions
  - AWS regions that have protected objects.
- hasCloudDiscovery: System.Boolean
  - Indicates whether cloud discovery is enabled for this account.
- kmsSharingMode: KmsSharingMode
  - Live automated-KMS sharing mode of the account's active exocompute mapping.
UNSPECIFIED when the account has no active mapping or the mapping is not KMS
enabled; SHARING_ONLY or SHARING_AND_GATEWAY when automated KMS is live.
