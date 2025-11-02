### NutanixPrismCentralConfigInput
Input for the Nutanix Prism Central configuration parameters.

- caCerts: System.String
  - Required. Supported in v9.0+
Concatenated X.509 certificates in Base64 encoded DER format. Each certificate must start with -----BEGIN CERTIFICATE----- and end with -----END CERTIFICATE-----.
- hostname: System.String
  - Required. Supported in v9.0+
Hostname for the Nutanix Prism Central that we use for all the cluster connections.
- password: System.String
  - Required. Supported in v9.0+
Password for the Nutanix Prism Central that we use for all the cluster connections.
- username: System.String
  - Required. Supported in v9.0+
Username for the Nutanix Prism Central that we use for all the cluster connections.
