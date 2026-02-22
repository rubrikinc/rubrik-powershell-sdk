### S3CompatibleArchivalMigrationTargetInput
S3CompatibleArchivalMigrationTarget contains the target location
details for migrating to an S3 compatible archival location.

- accessKey: System.String
  - Access Key for accessing S3 compatible storage.
- secretKey: System.String
  - Secret key for accessing the S3 compatible storage.
- endpoint: System.String
  - Endpoint URL of the S3 compatible storage.
- subtype: S3CompatibleSubType
  - Subtype of S3 compatible storage (e.g., DEFAULT, IBM_COS, IRONCLOUD).
- ibmDetails: IbmCosDetailsInput
  - IBM COS specific details, required when subtype is IBM_COS.
