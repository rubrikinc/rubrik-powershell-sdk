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
  - Supported in v9.0+
- nasVendorType: NasVendorType
  - Required. Supported in v7.0+
- hostname: System.String
  - Required. Supported in v7.0+
