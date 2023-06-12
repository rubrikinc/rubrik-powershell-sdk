### SupportTunnelInfo
Supported in v5.0+

- enabledTime: DateTime
  - Supported in v5.0+
  Time when the tunnel was enabled or omitted when the tunnel is not enabled.
- inactivityTimeoutInSeconds: System.Int64
  - Supported in v5.0+
  Inactivity timeout in seconds or omitted if the tunnel is not enabled.
- isTunnelEnabled: System.Boolean
  - Required. Supported in v5.0+
  True if the support tunnel is enabled on this node. False otherwise.
- lastActivityTime: DateTime
  - Supported in v5.0+
  Time when the tunnel was last used or omitted if the tunnel is not enabled.
- port: System.Int64
  - Supported in v5.0+
  The port used to tunnel traffic. Port number will be deprecated in the future when we transition to new cloud infrastructure that does not rely on unique port numbers.
- errorMessage: System.String
  - Supported in v5.3+
  Error message when unable to open support tunnel.
