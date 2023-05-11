### UpdateGlobalCertificateInput
Input to add a global certificate.

- certificateId: System.String
  - The ID of the global certificate (either the RSC ID or the Rubrik CDM certificate ID).
- clusters: a list of CertificateClusterInputs
  - The clusters on which to add the certificate.
- description: System.String
  - The updated description of the certificate.
- name: System.String
  - The updated display name of the certificate.
