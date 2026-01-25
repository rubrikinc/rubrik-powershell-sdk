### FailoverHaPolicyInput
Input for triggering a failover.

- id: System.String
  - Required. ID of the failover group.
- clusterUuid: System.String
  - Required. UUID used to identify the cluster the request goes to.
- failoverType: FlexmotionFailoverType
  - Required. Failover type.
