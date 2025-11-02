### NutanixClusterPatchInput
Supported in v5.0+

- caCerts: System.String
  - Supported in v5.0+
Concatenated X.509 certificates in Base64 encoded DER format. Each certificate must start with -----BEGIN CERTIFICATE----- and end with -----END CERTIFICATE-----.
- configuredSlaDomainId: System.String
  - Supported in v5.0+
v5.0-v5.1: ID of the SLA Domain that is configured for this Nutanix Cluster.
v5.2+: ID of the SLA Domain that is configured for this Nutanix Cluster. Existing snapshots of the object will be retained with the configuration of specified SLA Domain.
- hostname: System.String
  - Supported in v5.0+
Address for the Prism host. Any Prism Element or Prism central host will do. We will use the highly available IP, if set, and this address, if not, to communicate with the cluster.
- password: System.String
  - Supported in v5.0+
- username: System.String
  - Supported in v5.0+
- snapshotConsistencyMandate: CdmNutanixSnapshotConsistencyMandate
  - Supported in v9.1+
Consistency level mandated for this Nutanix cluster.
