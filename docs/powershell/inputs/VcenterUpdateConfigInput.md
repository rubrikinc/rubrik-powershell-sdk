### VcenterUpdateConfigInput
Input for configuration containing updated vCenter Server information.

- vcenterConfig: VcenterConfigInput
  - Configuration containing a part of updated vCenter Server information.
- shouldUpdateComputeVisibilityFilter: System.Boolean
  - Supported in v9.2+
A Boolean value that determines whether to update compute cluster visibility settings for the vCenter. When this value is `true`, 'computeVisibilityFilter' will be effective. The default value is `true`.
