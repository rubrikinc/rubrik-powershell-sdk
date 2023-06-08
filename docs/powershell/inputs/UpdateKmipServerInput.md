### UpdateKmipServerInput
Input required to update a KMIP server on multiple Rubrik clusters.

- clusterIds: list of System.Strings
  - IDs of the Rubrik clusters.
- serverAddress: System.String
  - Address of the KMIP server to update.
- port: System.Int32
  - Port number of the KMIP server.
- polarisCertId: System.Int32
  - ID of the global certificate. If the certificate is not on the specified Rubrik clusters, it will be imported.
