### CreateNasShareInput
Supported in v8.1+
Input to add a NAS share manually.

- exportPoint: System.String
  - Required. Supported in v8.1+
The NFS export point or SMB share name for the NAS share.
- credentials: NasShareCredentialsInput
  - Supported in v8.1+
Optional credentials to access the NAS share.
- shareType: CreateNasShareInputShareType
  - Required. Supported in v8.1+
The type of NAS share.
