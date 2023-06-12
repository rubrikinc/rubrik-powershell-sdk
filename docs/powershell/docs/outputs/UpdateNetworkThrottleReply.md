### UpdateNetworkThrottleReply
Response to update network throttle.

- defaultThrottleLimit: System.Single
  - Supported in v5.0+
  Default throttle limit for a resource, in Mbps. The throttle limit is precise to two decimal places.
- isEnabled: System.Boolean
  - Required. Supported in v5.0+
  Boolean value that determines whether a throttle limit is enabled.
- scheduledThrottles: list of NetworkThrottleScheduleSummarys
  - Required. Supported in v5.0+
  An array containing all of the scheduled throttle limits for the specified resource.
- networkInterface: System.String
  - Supported in v5.2+
  The network interface where outgoing traffic is throttled.
- archivalThrottlePort: System.Int32
  - Supported in v8.0+
  Network port for archival throttling. This is applicable only when the `resourceId` is `ArchivalEgress`.
- resourceId: NetworkThrottleResourceId
  - Throttle resource: ReplicationEgress or ArchivalEgress.
