### S3CompatibleArchivalMigrationTarget
Read-only target details for an S3 compatible archival migration.
Does not contain secrets (access_key, secret_key).

- endpoint: System.String
  - Endpoint URL for the target S3 compatible object store.
- useSystemProxy: System.Boolean
  - Whether to use the system proxy for connections.
- bucketPrefix: System.String
  - Bucket prefix for the target location.
- numberOfBuckets: System.Int32
  - Number of buckets for the target location.
- subtype: S3CompatibleSubType
  - Subtype of the S3 compatible storage.
- ibmDetails: IbmCosDetailsOutput
  - IBM COS specific details, if applicable.
