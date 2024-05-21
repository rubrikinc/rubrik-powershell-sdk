### NasSystemUpdateInput
Supported in v7.0+
  v7.0-v8.0: 
  v8.1+: Input for updating a NAS system.

- genericNasSystemParameters: GenericNasSystemParametersInput
  - Supported in v7.0+
      The updated Generic NAS system parameters.
- hostname: System.String
  - Supported in v7.0+
      The updated hostname of the NAS system.
- isIsilonChangelistEnabled: System.Boolean
  - Supported in v7.0+
      Specifies the default Changelist setting for all shares in the Isilon NAS system.
- nasApiCredentials: NasApiCredentialsInput
  - Supported in v7.0+
      The updated API credentials of the NAS system.
- shouldResetGeneratedNamespaceSmbCredentials: System.Boolean
  - Supported in v9.1+
      Optional parameter that specifies whether to remove the system-generated (not user-supplied) SMB credentials in namespaces and recreate them. If this parameter is true, the system-generated SMB credentials in all namespaces are removed. In addition, when the NAS system does not have user-supplied (system level) SMB credentials, new SMB credentials are generated in each namespace that does not have user-supplied (namespace level) SMB credentials. The API credentials must be provided when this parameter is true.
- nasFlashBladeApiCredentials: FlashBladeSystemParametersInput
  - Supported in v8.1+
- smbCredentials: NasShareCredentialsInput
  - Supported in v8.1+
      Optional credentials that will be used to access all the SMB shares on the NAS system unless overridden at the NAS namespace level or at the NAS share level. This is applicable for NetApp and Isilon NAS systems only.
- nutanixFileServerParameters: NutanixFileServerParametersInput
  - Supported in v8.1+
