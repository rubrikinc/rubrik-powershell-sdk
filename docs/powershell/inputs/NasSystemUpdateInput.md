### NasSystemUpdateInput
Supported in v7.0+
  v7.0-v8.0: 
  v8.1+: Input for updating a NAS system.

- hostname: System.String
  - Supported in v7.0+
      The updated hostname of the NAS system.
- isIsilonChangelistEnabled: System.Boolean
  - Supported in v7.0+
      Specifies the default Changelist setting for all shares in the Isilon NAS system.
- shouldResetGeneratedNamespaceSmbCredentials: System.Boolean
  - Supported in v8.1+
      Optional parameter that specifies whether to remove the system-generated (not user-supplied) SMB credentials in namespaces and recreate them. If this parameter is true, the system-generated SMB credentials in all namespaces are removed. In addition, when the NAS system does not have user-supplied (system level) SMB credentials, new SMB credentials are generated in each namespace that does not have user-supplied (namespace level) SMB credentials. The API credentials must be provided when this parameter is true.
- shouldGrantSmbShareRootAccess: System.Boolean
  - Supported in v8.1+
      Optional parameter that specifies whether to grant root user access to SMB shares on Isilon NAS systems. The root user access is granted on first fileset creation for the SMB share. The default value is true. This setting is applicable only when system-generated credentials are used.
- isNetAppMetroClusterEnabled: System.Boolean
  - Supported in v9.4+
      Enables the Metro Cluster feature for the NetApp NAS system. If the NetApp cluster is operating in the Metro Cluster environment and this flag is not enabled, the NAS protections on this NAS system will not seamlessly move when switchover or switchback occurs.
- shouldGrantNfsShareRootAccess: System.Boolean
  - Supported in v8.1+
      Optional parameter that specifies whether to grant root client access to NFS shares on Isilon and NetApp NAS systems. The root client access is granted on first fileset creation for the NFS share. The default value is true.
- genericNasSystemParameters: GenericNasSystemParametersInput
  - Supported in v7.0+
      The updated Generic NAS system parameters.
- nasApiCredentials: NasApiCredentialsInput
  - Supported in v7.0+
      The updated API credentials of the NAS system.
- nasFlashBladeApiCredentials: FlashBladeSystemParametersInput
  - Supported in v8.1+
- nutanixFileServerParameters: NutanixFileServerParametersInput
  - Supported in v8.1+
- smbCredentials: NasShareCredentialsInput
  - Supported in v8.1+
      Optional credentials that will be used to access all the SMB shares on the NAS system unless overridden at the NAS namespace level or at the NAS share level. This is applicable for NetApp and Isilon NAS systems only.
