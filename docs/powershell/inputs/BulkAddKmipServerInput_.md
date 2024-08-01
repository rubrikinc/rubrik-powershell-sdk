### BulkAddKmipServerInput
Input required to add a KMIP server to multiple Rubrik clusters.

- clusterIds: list of System.Strings
  - IDs of the Rubrik clusters.
- serverAddress: System.String
  - Address of the KMIP server.
- port: System.Int32
  - Port number of the KMIP server.
- polarisCertId: System.Int32
  - ID of the global certificate. If the certificate is not on the specified clusters, it will be imported.
- polarisCertFid: System.String
  - FID of the global certificate. If the certificate is not on the specified clusters, it will be imported.
