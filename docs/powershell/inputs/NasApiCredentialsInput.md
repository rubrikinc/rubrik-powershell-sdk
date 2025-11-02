### NasApiCredentialsInput
Supported in v7.0+
v7.0-v8.0:
v8.1+: Credentials to add or update NAS system with API integration.

- apiCertificate: System.String
  - Supported in v7.0+
TLS certification to validate NAS server.
- apiPassword: System.String
  - Supported in v7.0+
Password associated with the NAS API user account.
- apiUsername: System.String
  - Supported in v7.0+
Username to access the vendor-specific NAS API.
- certificateId: System.String
  - Supported in v7.0+
The ID corresponding to the imported certificate.
- areApiCredentialsPermanent: System.Boolean
  - Supported in v9.2+
Optional parameter that specifies whether to use the specified credentials for Isilon/NetApp instead of generating our own.
