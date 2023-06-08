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
