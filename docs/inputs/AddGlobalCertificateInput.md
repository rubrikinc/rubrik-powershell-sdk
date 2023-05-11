### AddGlobalCertificateInput
Input to add a global certificate.

- certificate: System.String
  - The certificate in x509 PEM format.
- clusters: a list of CertificateClusterInputs
  - The clusters on which to add the certificate.
- csrId: System.Int64
  - The CSR corresponding to the certificate, if applicable.
- description: System.String
  - The description of the certificate.
- name: System.String
  - The display name of the certificate.
- privateKey: System.String
  - The private key of the certificate.
