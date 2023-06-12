### PatchAwsAuthenticationServerBasedCloudAccountInput
Input to update authentication server-based AWS cloud account.

- awsCloudAccountId: System.String
  - Rubrik ID for the AWS cloud account.
- feature: CloudAccountFeature
  - Native protection feature to be updated.
- awsRegions: AwsAuthServerRegionsInput
  - Regions to be updated for the authentication server-based AWS cloud account.
- roleName: AwsAuthServerRoleNameInput
  - Name of the role created on the authentication server for the user account to be used by Rubrik.
- authServerUserClientCertId: AwsAuthServerCertificateIdInput
  - Authentication server's user client certificate to be updated for the authentication server-based AWS cloud account.
- authServerCaCertId: AwsAuthServerCertificateIdInput
  - Authentication server's CA certificate to be updated for authentication server-based AWS cloud account.
