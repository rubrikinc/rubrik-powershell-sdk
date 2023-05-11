### UpdateKmipServerInput
Input required to update a KMIP server on multiple Rubrik clusters.

- clusterIds: a list of System.Strings
  - IDs of the Rubrik clusters.
- polarisCertId: System.Int32
  - ID of the global certificate. If the certificate is not on the specified Rubrik clusters, it will be imported.
- port: System.Int32
  - Port number of the KMIP server.
- serverAddress: System.String
  - Address of the KMIP server to update.
