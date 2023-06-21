### AddGlobalCertificateInput
Input to add a global certificate.

- name: System.String
  - The display name of the certificate.
- description: System.String
  - The description of the certificate.
- csrId: System.Int64
  - The CSR corresponding to the certificate, if applicable.
- privateKey: System.String
  - The private key of the certificate.
- certificate: System.String
  - The certificate in x509 PEM format.
- clusters: list of CertificateClusterInputs
  - The clusters on which to add the certificate.
