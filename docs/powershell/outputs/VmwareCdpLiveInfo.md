### VmwareCdpLiveInfo
Supported in v5.1+

- currentTime: DateTime
  - Supported in v5.1+
  The time on this node. Computed after computing the live CDP info for the virtual machine.
- localRecoveryPoint: DateTime
  - Supported in v5.1+
  The latest time to which this virtual machine can be recovered locally.
- remoteRecoveryPoint: DateTime
  - Supported in v5.1+
  The latest time to which this virtual machine can be recovered on a remote cluster.
- vmId: System.String
  - Required. Supported in v5.1+
  The ID of the virtual machine that we are getting CDP live fields for.
