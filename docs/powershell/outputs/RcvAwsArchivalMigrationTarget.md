### RcvAwsArchivalMigrationTarget
Details of a Rubrik Cloud Vault on AWS archival migration target. Read-only
view that omits secrets, such as the encryption key, and internal IAM
identifiers.

- bucket: System.String
  - Name of the S3 bucket provisioned for the target location. Empty until
the bucket has been provisioned.
- region: AwsRegion
  - AWS region in which the target location is provisioned.
- rcvTier: RcsTierEnumType
  - Storage tier of the target location.
- redundancy: RcvRedundancy
  - Storage redundancy of the target location.
