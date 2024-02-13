### NutanixFileServerParametersInput
Supported in v8.1+
  API credentials to add or update the Nutanix File Server with API integration. Also contains credentials for SMB share access.

- apiCertificate: System.String
  - Supported in v8.1+
      TLS certification to validate the NAS system.
- certificateId: System.String
  - Supported in v8.1+
      ID corresponding to the imported certificate.
- smbCredentials: GenericNasSystemCredentialsInput
  - Supported in v8.1+
      Credentials to access SMB shares.
- apiPassword: System.String
  - Supported in v8.1+
      Password associated with the NAS API user account.
- apiUsername: System.String
  - Supported in v8.1+
      Username to access the vendor-specific NAS API.
- hasSmbSupport: System.Boolean
  - Required. Supported in v8.1+
      Specifies whether to enable SMB for the NAS system.
