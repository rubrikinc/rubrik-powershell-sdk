### NutanixFileServerParametersInput
API credentials to add or update the Nutanix File Server with API integration. Also contains credentials for SMB share access.

- apiCertificate: System.String
  - TLS certification to validate the NAS system.
- certificateId: System.String
  - ID corresponding to the imported certificate.
- smbCredentials: GenericNasSystemCredentialsInput
  - Credentials to access SMB shares.
- apiPassword: System.String
  - Password associated with the NAS API user account.
- apiUsername: System.String
  - Username to access the vendor-specific NAS API.
- hasSmbSupport: System.Boolean
  - Required. Specifies whether to enable SMB for the NAS system.
