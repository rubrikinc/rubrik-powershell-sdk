### QueryCertificatesInput


- description: System.String
  - Search certificates by description.
- expiration: System.String
  - Search certificates by expiration.
- hasKey: System.Boolean
  - Search certificates by whether or not they contain a private key.
- includeExpired: System.Boolean
  - Specifies whether to include expired certificates. The default is false.
- isTrusted: System.Boolean
  - Search certificates according to whether or not they are added to truststore. The default is false.
- name: System.String
  - Search by certificate name.
- excludeUsages: list of ExcludeUsagess
  - Specifies which certificate usages to exclude.
- sortBy: V1QueryCertificatesRequestSortBy
  - Attribute by which the list of certificates is sorted.
- sortOrder: V1QueryCertificatesRequestSortOrder
  - Sort order, either ascending or descending.
- clusterUuid: System.String
  - Required. UUID used to identify the cluster the request goes to.
