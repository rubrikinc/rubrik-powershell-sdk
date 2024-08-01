### CreateVsphereVcenterReply
Supported in v5.3+

- id: System.String
  - Required. Supported in v5.3+
  The ID of the vCenter server that controls the management of the virtual machine whose metadata will be refreshed.
- isVmc: System.Boolean
  - Required. Specifies whether the new vCenter is a VMC instance.
- isHotAddProxyEnabledForOnPremVcenter: System.Boolean
  - Supported in v7.0+ An optional field that specifies whether HotAdd transport mode is enabled for On-Premise vCenter. When this value is `true`, HotAdd transport mode is enabled for this vCenter. When this value is `false`, HotAdd transport mode is not enabled for this vCenter. When this value is not specified, it indicates that this is an VMC vCenter.
- asyncRequestStatus: AsyncRequestStatus
  - Required. Supported in v5.3+
