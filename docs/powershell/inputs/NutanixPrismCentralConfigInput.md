### NutanixPrismCentralConfigInput
Input for the Nutanix Prism Central configuration parameters.

- caCerts: System.String
  - Required. Concatenated X.509 certificates in Base64 encoded DER format. Each certificate must start with -----BEGIN CERTIFICATE----- and end with -----END CERTIFICATE-----.
- hostname: System.String
  - Required. Hostname for the Nutanix Prism Central that we use for all the cluster connections.
- password: System.String
  - Required. Password for the Nutanix Prism Central that we use for all the cluster connections.
- username: System.String
  - Required. Username for the Nutanix Prism Central that we use for all the cluster connections.
