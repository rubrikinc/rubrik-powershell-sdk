### UpdateNetworkThrottleInput
Input to update network throttle.

- clusterUuid: System.String
  - Required. UUID used to identify the cluster the request goes to.
- id: System.String
  - Required. ID assigned to a network throttle object.
- throttleUpdate: NetworkThrottleUpdateInput
  - Required. Configuration changes to apply to a specified network throttle object. Unspecified values are left unchanged.
