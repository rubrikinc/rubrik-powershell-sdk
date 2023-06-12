### CertificateImportRequestInput
Supported in v5.1+

- csrId: System.String
  - Supported in v5.1+
      ID of the certificate signing request (CSR) associated with the imported certificate.
- description: System.String
  - Supported in v5.1+
      User-friendly description for the certificate.
- privateKey: System.String
  - Supported in v5.2+
      The private key, in PEM format, to be imported. If a private key is provided using this field instead of the pemFile field, the import fails if the private key is not successfully parsed.
- isTrusted: System.Boolean
  - Supported in v7.0+
      A Boolean value specifying whether the certificate should be added to the trust store. When the value is 'true' the certificate is added to the trust store. when the value is 'false', the certificate is not added to trust store.
- name: System.String
  - Required. Supported in v5.1+
      Display name for the certificate.
- pemFile: System.String
  - Required. Supported in v5.1+
      The certificates, and optionally private key to be imported, in PEM format.
