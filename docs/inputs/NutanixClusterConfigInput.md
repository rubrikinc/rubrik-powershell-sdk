### NutanixClusterConfigInput
Supported in v5.0+

- caCerts: System.String
  - Required. Supported in v5.0+
      Concatenated X.509 certificates in Base64 encoded DER format. Each certificate must start with -----BEGIN CERTIFICATE----- and end with -----END CERTIFICATE-----.
- hostname: System.String
  - Required. Supported in v5.0+
      Address for the Prism host. Any Prism Element or Prism central host will do. We will use the highly available IP, if set, and this address, if not, to communicate with the cluster.
- nutanixClusterUuid: System.String
  - Required. Supported in v5.0+
      The UUID of the Nutanix cluster being added. This is required because Prism Central may manage multiple clusters, and we need to differentiate between them.
- password: System.String
  - Required. Supported in v5.0+
- username: System.String
  - Required. Supported in v5.0+
