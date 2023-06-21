### AddAwsAuthenticationServerBasedCloudAccountInput
Input to add authentication server-based AWS cloud account for native protection.

- cloudType: AwsCloudType
  - AWS C2S/SC2S cloud type to which the AWS account belongs.
- awsAccountName: System.String
  - C2S mission name or SC2S account name.
- awsRegions: list of AwsAuthServerBasedCloudAccountRegions
  - List of SC2S/C2S AWS regions for the cloud account. By default, all regions will be added.
- features: list of CloudAccountFeatures
  - List of features to be enabled for cloud native protection.
- nativeId: System.String
  - Native ID of the cloud account. Native ID is required only while adding a feature to an existing cloud account.
- agencyName: System.String
  - Name of the agency that provisioned the AWS C2S/SC2S account. Agency name is required only while adding a new AWS cloud account.
- roleName: System.String
  - Name of the role created on the authentication server to enable cloud-native protection for the AWS cloud account. Role name is required only while adding a new AWS cloud account.
- authServerHostName: System.String
  - Hostname of the authentication server. Hostname is required only while adding a new AWS cloud account.
- authServerUserClientCertId: AwsAuthServerCertificateIdInput
  - Certificate ID for authentication server user client certificate. Client certificate is required only while adding a new AWS cloud account.
- authServerCaCertId: AwsAuthServerCertificateIdInput
  - Certificate ID for authentication server CA certificate. If a CA certificate ID is not provided, authentication server will be trusted on first use.
- awsCaCertId: AwsAuthServerCertificateIdInput
  - Certificate ID for AWS CA certificate. If a CA certificate ID is not provided, AWS server will be trusted on first use.
