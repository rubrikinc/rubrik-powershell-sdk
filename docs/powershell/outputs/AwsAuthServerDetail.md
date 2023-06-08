### AwsAuthServerDetail
Details of AWS authentication server-based cloud account.

- agency: System.String
  - Agency name for the feature.
- roleName: System.String
  - Role name for the feature.
- authServerHostName: System.String
  - Host name of the authentication server.
- authServerUserClientCertId: System.Int64
  - Client's TLS Certificate ID for the authentication server.
- authServerCaCertId: System.Int64
  - CA certificate ID for the authentication server.
- authServerAwsRegions: list of AwsAuthServerBasedCloudAccountRegions
  - List of AWS secret regions.
