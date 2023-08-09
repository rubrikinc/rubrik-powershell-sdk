### FlashBladeSystemParametersInput
Supported in v9.0+
  API credentials to add or update the Pure NAS system with API integration. Also contains credentials for SMB share access.

- apiCertificate: System.String
  - Supported in v9.0+
      TLS certification to validate the NAS server.
- certificateId: System.String
  - Supported in v9.0+
      ID corresponding to the imported certificate.
- smbCredentials: GenericNasSystemCredentialsInput
  - Supported in v9.0+
      Credentials to access SMB shares.
- apiToken: System.String
  - Required. Supported in v9.0+
- hasSmbSupport: System.Boolean
  - Required. Supported in v9.0+
      Specifies whether to enable SMB for this NAS system.
