### AddClusterCertificateReply
Supported in v5.1+

- certId: System.String
  - Required. Supported in v5.1+
ID of the certificate.
- description: System.String
  - Supported in v5.1+
User-friendly description for the certificate.
- expiration: DateTime
  - Supported in v5.1+
The expiration date for the certificate.
- hasKey: System.Boolean
  - Required. Supported in v5.1+
v5.1-v6.0: A Boolean value that specifies whether or not the certificate is associated with a stored private key. When this value is 'true,' the private key for the certificate is stored. When this value is 'false,' the private key for the certificate is not stored.
v7.0+: A Boolean value specifying whether the certificate is be added to the trust store. When the value is 'true' the certificate is added to the trust store. when the value is 'false', the certificate is not added to trust store.
- name: System.String
  - Required. Supported in v5.1+
Display name for the certificate.
- pemFile: System.String
  - Required. Supported in v5.1+
The certificates, in PEM format.
- usedBy: System.String
  - Required. Supported in v5.1+
A list of components using the certificate.
- isTrusted: System.Boolean
  - Supported in v7.0+
A Boolean value that specifies whether or not the certificate is added to the trust store. when the value is 'true,' the certificate is added to the trust store. when this value is 'false,' the certificate is not added to trust store.
- isInternal: System.Boolean
  - Supported in v9.4+
A Boolean value that indicates whether the certificate is for internal system use only.
