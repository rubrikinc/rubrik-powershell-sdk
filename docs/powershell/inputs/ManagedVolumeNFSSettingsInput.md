### ManagedVolumeNFSSettingsInput
Supported in v9.3+
Settings related to NFS for the Managed Volume.

- isTlsEnabled: System.Boolean
  - Supported in v9.7
Specifies whether NFSv4 mounts use TLS (server-authenticated transport encryption). Only valid when version is NFSv4. When absent, defaults to false.
- version: ManagedVolumeNFSVersion
  - Supported in v9.3+
Specifies the NFS version to use.
