### GlobalCertificatesQueryInput
Input to list global certificates.

- searchText: System.String
  - The query to filter the certificates.
- hasKey: System.Boolean
  - Specifies whether to return only the certificates with private keys.
- statuses: list of GlobalCertificateStatuss
  - The status of the certificates.
- clusterIds: list of System.Strings
  - The UUIDs of the Rubrik clusters on which to filter.
- isTrustedAny: System.Boolean
  - Specifies whether the certificate is in the trust store of the Rubrik cluster.
- isRscBorn: System.Boolean
  - Specifies whether to include only certificates imported via RSC.
- isCa: System.Boolean
  - Specifies whether to include only CA certificates.
- issuerTypes: list of IssuerTypes
  - Specifies the certificate issuer types to return.
- renewalStatuses: list of CertificateRotationStatuss
  - Specifies the certificate rotation statuses to retrieve.
- cdmUsages: list of CdmCertificateUsages
  - Specifies the CDM certificate usages to return.
- isRubrikManaged: System.Boolean
  - Specifies whether to include only Rubrik-managed certificates.
- rscUsages: list of CertificateUsages
  - Specifies the RSC certificate usages to return.
- usageLocations: list of CertificateUsageLocations
  - Filters certificates by where they are used.
- keyTypes: list of KeyTypes
  - Filters certificates by cryptographic key type. Empty list applies no
filter.
