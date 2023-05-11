### GlobalCertificatesQueryInput
Input to list global certificates.

- clusterIds: a list of System.Strings
  - The UUIDs of the Rubrik clusters on which to filter.
- hasKey: System.Boolean
  - Specifies whether to return only the certificates with private keys.
- isTrustedAny: System.Boolean
  - Specifies whether the certificate is in the trust store of the Rubrik cluster.
- searchText: System.String
  - The query to filter the certificates.
- statuses: a list of GlobalCertificateStatuss
  - The status of the certificates.
