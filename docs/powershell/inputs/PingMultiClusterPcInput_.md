### PingMultiClusterPcInput
Input for checking the connection status of the Multi Cluster Nutanix Prism Central clusters.

- cdmClusterId: System.String
  - Required. UUID used to identify the cluster the request goes to.
- id: System.String
  - ID of the Nutanix Prism Central.
- username: System.String
  - Username for the Nutanix Prism Central used for all the cluster connections.
- password: System.String
  - Password for the Nutanix Prism Central used for all the cluster connections.
- hostname: System.String
  - Hostname for the Nutanix Prism Central used for all the cluster connections.
- caCerts: System.String
  - Concatenated X.509 certificates in Base64 encoded DER format. Each certificate must start with -----BEGIN CERTIFICATE----- and end with -----END CERTIFICATE-----.
- nutanixClusters: list of System.Strings
  - The list of Nutanix Clusters to protect as part of the given Nutanix Prism Central object.
