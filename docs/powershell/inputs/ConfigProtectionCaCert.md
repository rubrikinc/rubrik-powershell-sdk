### ConfigProtectionCaCert
Information about CA certificate. Provide uuid of the certificate on the cluster to use an existing certificate. Otherwise, provide the certificate details to create a new certificate on the cluster.

- uuid: System.String
  - ID of the CA certificate.
- name: System.String
  - Name of the CA certificate.
- description: System.String
  - Description of the CA certificate.
- certificate: System.String
  - Content of the CA certificate.
- caProvider: CaCertProviderType
  - CA certificate provider type.
