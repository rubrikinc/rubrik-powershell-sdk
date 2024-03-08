### NasSystemRegisterInput
Supported in v7.0+
  v7.0-v8.0: 
  v8.1+: Input for registering a new NAS System.

- genericNasSystemParameters: GenericNasSystemParametersInput
  - Supported in v7.0+
- isIsilonChangelistEnabled: System.Boolean
  - Supported in v7.0+
      Specifies the default Changelist setting for all shares in the Isilon NAS system.
- nasTmpApiCredentials: NasApiCredentialsInput
  - Supported in v7.0+
- nasFlashBladeApiCredentials: FlashBladeSystemParametersInput
  - Supported in v8.1+
- smbCredentials: NasShareCredentialsInput
  - Optional credentials that will be used to access all the SMB shares on the NAS system unless overridden at the NAS namespace level or at the NAS share level. This is applicable for NetApp and Isilon NAS systems only.
- nutanixFileServerParameters: NutanixFileServerParametersInput
  - Supported in v8.1+
- nasVendorType: NasVendorType
  - Required. Supported in v7.0+
- hostname: System.String
  - Required. Supported in v7.0+
