### RcvAwsArchivalMigrationTargetInput
Configuration for a Rubrik Cloud Vault on AWS archival location to
migrate data into. Supplied when registering an archival migration whose
target is a Rubrik-managed AWS S3 location.

- region: AwsRegion
  - AWS region in which the Rubrik Cloud Vault bucket is provisioned for the
migration target.
- rcvTier: RcsTierEnumType
  - Storage tier of the Rubrik Cloud Vault location.
- redundancy: RcvRedundancy
  - Storage redundancy of the Rubrik Cloud Vault location.
- encryptionKeyInDer: System.String
  - RSA encryption key, in DER format, used to encrypt data stored at the
target location.
