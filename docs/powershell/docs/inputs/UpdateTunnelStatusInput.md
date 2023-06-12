### UpdateTunnelStatusInput
Input for enabling or disabling the SSH Tunnel for Support Access.

- clusterUuid: System.String
  - Required. UUID used to identify the cluster the request goes to.
- config: UpdateSupportTunnelConfigInput
  - Required. The support tunnel parameters.
- id: System.String
  - Required. ID of the node add the tunnel to (this must be the current node id or *me*).
