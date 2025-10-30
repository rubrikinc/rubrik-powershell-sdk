### UpdateMountConfigInput
Supported in v5.0+

- shouldForce: System.Boolean
  - Supported in v5.2+
      A Boolean that specifies whether to forcibly power down a virtual machine that is already mounted with Storage vMotion. When this value is 'true', the virtual machine is forcibly powered down. The default value for this Boolean is 'false'.
- powerStatus: System.Boolean
  - Required. True to power on, false to power off.
