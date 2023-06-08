### VcdClusterPatchInput
Supported in v5.0+

- caCerts: System.String
  - Supported in v5.0+
      Concatenated X.509 certificates in Base64 encoded DER format. Each certificate must start with -----BEGIN CERTIFICATE----- and end with -----END CERTIFICATE-----.
- configuredSlaDomainId: System.String
  - Supported in v5.0+
      v5.0-v5.1: 
      v5.2+: Assign this Vcd Cluster to the given SLA Domain. Existing snapshots of the object will be retained with the configuration of specified SLA Domain.
- hostname: System.String
  - Supported in v5.0+
- password: System.String
  - Supported in v5.0+
- username: System.String
  - Supported in v5.0+
