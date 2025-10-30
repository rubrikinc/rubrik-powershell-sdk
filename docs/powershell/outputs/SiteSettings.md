### SiteSettings
Cloud Direct site settings configuration.

- id: System.String
  - The internal identifier for the site settings.
- clusterUuid: System.String
  - The Rubrik cluster UUID for the site.
- cloudDirectId: System.String
  - The Cloud Direct site identifier.
- wanThrottle: WanThrottleSettings
  - WAN throttle settings for the site.
- smbCreds: GlobalSmbAuthSettings
  - SMB authentication settings for the site.
- supportSystemFiles: System.Boolean
  - Whether system files are supported.
- offlineFilesBehaviour: CloudDirectOfflineFilesBehaviour
  - Offline files behavior configuration.
- kdcCredentials: list of KdcCredentials
  - Kerberos Credentials
- kerberosEnforceNfs4: KerberosEnforceType
  - Kerberos enforcement for NFSv4 protocol.
