### UpdateGlobalCertificateInput
Input to add a global certificate.

- certificateId: System.String
  - The ID of the global certificate (either the Rubrik Security Cloud ID or the Rubrik CDM certificate ID).
- name: System.String
  - The updated display name of the certificate.
- description: System.String
  - The updated description of the certificate.
- clusters: list of CertificateClusterInputs
  - The Rubrik clusters on which to add the certificate.
