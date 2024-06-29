### NasSystemRegisterInput
Supported in v7.0+
  v7.0-v8.0: 
  v8.1+: Input for registering a new NAS System.

- isIsilonChangelistEnabled: System.Boolean
  - Supported in v7.0+
      Specifies the default Changelist setting for all shares in the Isilon NAS system.
- shouldGrantSmbShareRootAccess: System.Boolean
  - Supported in v9.0+
      Optional parameter that specifies whether to grant root user access to SMB shares on Isilon NAS systems. The root user access is granted on first fileset creation for the SMB share. The default value is true. This setting is applicable only when system-generated credentials are used.
- shouldGrantNfsShareRootAccess: System.Boolean
  - Supported in v9.0+
      Optional parameter that specifies whether to grant root client access to NFS shares on Isilon and NetApp NAS systems. The root client access is granted on first fileset creation for the NFS share. The default value is true.
- nasVendorType: NasVendorType
  - Required. Supported in v7.0+
- genericNasSystemParameters: GenericNasSystemParametersInput
  - Supported in v7.0+
- hostname: System.String
  - Required. Supported in v7.0+
- nasFlashBladeApiCredentials: FlashBladeSystemParametersInput
  - Supported in v8.1+
- nasTmpApiCredentials: NasApiCredentialsInput
  - Supported in v7.0+
- nutanixFileServerParameters: NutanixFileServerParametersInput
  - Supported in v8.1+
- smbCredentials: NasShareCredentialsInput
  - Supported in v8.1+
      Optional credentials that will be used to access all the SMB shares on the NAS system unless overridden at the NAS namespace level or at the NAS share level. This is applicable for NetApp and Isilon NAS systems only.
