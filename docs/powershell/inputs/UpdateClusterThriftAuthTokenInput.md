### UpdateClusterThriftAuthTokenInput
Input for updating the Rubrik CDM cluster thrift auth token.

- clusterUuid: System.String
  - Required. UUID used to identify the cluster the request goes to.
- id: System.String
  - Required. Cluster UUID of the peer cluster.
- sendToken: ThriftAuthTokenInput
  - Required. Token to send to peer cluster for thrift authentication.
