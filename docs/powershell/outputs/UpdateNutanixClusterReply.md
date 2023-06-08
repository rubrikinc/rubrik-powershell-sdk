### UpdateNutanixClusterReply
Supported in v5.0+

- caCerts: System.String
  - Required. Supported in v5.0+
  Concatenated X.509 certificates in Base64 encoded DER format. Each certificate must start with -----BEGIN CERTIFICATE----- and end with -----END CERTIFICATE-----.
- connectionStatus: RefreshableObjectConnectionStatus
  - Required. Supported in v5.0+
  Connection status of a Nutanix Cluster.
- nutanixClusterSummary: NutanixClusterSummary
  - 
