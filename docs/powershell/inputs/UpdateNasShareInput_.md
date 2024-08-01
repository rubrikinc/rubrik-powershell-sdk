### UpdateNasShareInput
Supported in v8.1+
  Input to update a manually added NAS share.

- isIsilonChangelistEnabled: System.Boolean
  - Supported in v8.1+
      Specifies whether the Isilon changelist is enabled for the share.
- exportPoint: System.String
  - Supported in v8.1+
      The NFS export point or SMB share name for the NAS share.
- nasSourceId: System.String
  - Supported in v8.1+
      Managed ID of the NAS system or NAS namespace where shares will be updated.
- credentials: NasShareCredentialsInput
  - Supported in v8.1+
      Optional credentials to access the NAS share.
- id: System.String
  - Required. Supported in v8.1+
      ID of the NAS share that will be updated.
