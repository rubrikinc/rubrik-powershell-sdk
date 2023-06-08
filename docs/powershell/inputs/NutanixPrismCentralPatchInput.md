### NutanixPrismCentralPatchInput
Input for patching the Nutanix Prism Central.

- caCerts: System.String
  - Concatenated X.509 certificates in Base64 encoded DER format. Each certificate must start with -----BEGIN CERTIFICATE----- and end with -----END CERTIFICATE-----.
- configuredSlaDomainId: System.String
  - ID of the SLA Domain that is configured for this Nutanix Prism Central. Existing snapshots of the object will be retained with the configuration of specified SLA Domain.
- hostname: System.String
  - Hostname for the Nutanix Prism Central used for all the cluster connections.
- password: System.String
  - Password for the Nutanix Prism Central used for all the cluster connections.
- username: System.String
  - Username for the Nutanix Prism Central used for all the cluster connections.
