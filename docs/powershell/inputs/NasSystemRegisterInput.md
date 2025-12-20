### NasSystemRegisterInput
Supported in v7.0+
v7.0-v8.0:
v8.1+: Input for registering a new NAS System.

- genericNasSystemParameters: GenericNasSystemParametersInput
  - Supported in v7.0+
- hostname: System.String
  - Required. Supported in v7.0+
- isIsilonChangelistEnabled: System.Boolean
  - Supported in v7.0+
Specifies the default Changelist setting for all shares in the Isilon NAS system.
- nasTmpApiCredentials: NasApiCredentialsInput
  - Supported in v7.0+
- nasVendorType: NasVendorType
  - Required. Supported in v7.0+
- shouldGrantSmbShareRootAccess: System.Boolean
  - Supported in v8.1+
Optional parameter that specifies whether to grant root user access to SMB shares on Isilon NAS systems. The root user access is granted on first fileset creation for the SMB share. The default value is true. This setting is applicable only when system-generated credentials are used.
- shouldAllowDuplicateSystemsWithSameIp: System.Boolean
  - Optional parameter that specifies whether to allow registering a NAS system which has the same IP address as an existing NAS system. The default value is false. This setting is expected to be used judiciously, primarily for Azure Files and similar hosted file systems where multiple NAS devices can have same IP address.
- nasFlashBladeApiCredentials: FlashBladeSystemParametersInput
  - Supported in v8.1+
- isNetAppMetroClusterEnabled: System.Boolean
  - Supported in v8.1, v9.1+
v8.1: Enables the Metro Cluster feature for the NetApp NAS system. If the NetApp cluster is operating in the Metro Cluster environment and this flag is not enabled, the NAS protections on this NAS system will not seamlessly move when switchover or switchback occurs.
v9.1+: Enables the Metro Cluster feature for the NetApp NAS system. If the NetApp cluster is operating in the Metro Cluster environment and this flag is not enabled, the NAS protections on this NAS system will not seamlessly move when switchover or switchback occurs.
- smbCredentials: NasShareCredentialsInput
  - Supported in v8.1+
Optional credentials that will be used to access all the SMB shares on the NAS system unless overridden at the NAS namespace level or at the NAS share level. This is applicable for NetApp and Isilon NAS systems only.
- nutanixFileServerParameters: NutanixFileServerParametersInput
  - Supported in v8.1+
- shouldGrantNfsShareRootAccess: System.Boolean
  - Supported in v8.1+
Optional parameter that specifies whether to grant root client access to NFS shares on Isilon and NetApp NAS systems. The root client access is granted on first fileset creation for the NFS share. The default value is true.
