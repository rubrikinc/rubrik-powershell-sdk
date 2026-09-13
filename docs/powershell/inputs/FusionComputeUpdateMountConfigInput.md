### FusionComputeUpdateMountConfigInput
Supported in v9.6+
Configuration for updating a FusionCompute Live Mount.

- shouldForce: System.Boolean
  - Supported in v9.6+
A Boolean that specifies whether to forcibly power down a virtual machine that is already mounted. When this value is 'true', the virtual machine is forcibly powered down. The default value for this Boolean is 'false'.
- shouldPowerOn: System.Boolean
  - Required. Supported in v9.6+
True to power on, false to power off.
