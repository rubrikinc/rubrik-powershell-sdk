### UpdateCloudDirectKerberosCredentialInput
Request to update an existing Kerberos credential.

- clusterUuid: System.String
  - NCD cluster UUID.
- credentialId: System.Int32
  - ID of the credential to update.
- username: System.String
  - Username for Kerberos authentication.
- password: System.String
  - Password for Kerberos authentication.
- kdcConfig: KdcConfigInput
  - KDC configuration details.
