### AddCloudDirectGenericS3TenantCredentialsInput
Input to add or update tenant credentials for a CloudDirect generic S3 system, matched by name.

- clusterId: System.String
  - NCD cluster ID.
- systemId: System.String
  - Unique identifier of the generic S3 system.
- credentials: list of NcdCredentials
  - Credentials to add or update, matched by name. At least one is required.
