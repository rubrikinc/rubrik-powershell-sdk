### GenericNasSystemParametersInput
Supported in v7.0+
v7.0-v8.0:
v8.1+: Protocol support and SMB credentials for a NAS system.

- hasNfsSupport: System.Boolean
  - Required. Supported in v7.0+
Specifies whether to enable NFS for this server.
- hasSmbSupport: System.Boolean
  - Required. Supported in v7.0+
Specifies whether to enable SMB for this server.
- smbCredentials: GenericNasSystemCredentialsInput
  - Supported in v7.0+
The credentials to access SMB server.
- nfsPseudoFsPrefix: System.String
  - The NFSv4 pseudo-filesystem prefix removed from the mountd export paths, which are used to derive the NFSv4-accessible paths. Defaults to an empty string when not set, meaning no prefix is removed.
