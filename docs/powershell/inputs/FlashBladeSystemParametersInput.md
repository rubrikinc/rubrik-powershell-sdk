### FlashBladeSystemParametersInput
Supported in v8.1+
  API credentials to add or update the Pure NAS system with API integration. Also contains credentials for SMB share access.

- apiCertificate: System.String
  - Supported in v8.1+
      TLS certification to validate the NAS server.
- certificateId: System.String
  - Supported in v8.1+
      ID corresponding to the imported certificate.
- apiToken: System.String
  - Required. Supported in v8.1+
- hasSmbSupport: System.Boolean
  - Required. Supported in v8.1+
      Specifies whether to enable SMB for this NAS system.
- smbCredentials: GenericNasSystemCredentialsInput
  - Supported in v8.1+
      Credentials to access SMB shares.
