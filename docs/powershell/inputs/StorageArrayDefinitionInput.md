### StorageArrayDefinitionInput
Supported in v5.0+

- arrayType: StorageArrayType
  - Required. Supported in v5.0+
- caCerts: System.String
  - Supported in v5.0+
A digital certificate, or concatenated chain of digital certificates, that permits verification of the public key certificate of the storage array. Each certificate must be an X.509 certificate in Base64 encoded DER format and must start with -----BEGIN CERTIFICATE----- and end with -----END CERTIFICATE-----.
- hostname: System.String
  - Required. Supported in v5.0+
Resolvable hostname or IPv4 address of the storage array.
- password: System.String
  - Required. Supported in v5.0+
- username: System.String
  - Required. Supported in v5.0+
- certificateId: System.String
  - Supported in v6.0+
The ID corresponding to the imported certificate.
