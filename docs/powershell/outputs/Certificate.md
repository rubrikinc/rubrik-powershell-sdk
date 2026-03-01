### Certificate
Certificate information.

- certificateId: System.Int64
  - The ID of the certificate.
- name: System.String
  - The name of the certificate.
- description: System.String
  - The description of the certificate.
- hasKey: System.Boolean
  - Specifies whether the certificate has a private key.
- expiringAt: DateTime
  - The expiration date of the certificate.
- usedBy: list of System.Strings
  - The list of services using this certificate.
- certificate: System.String
  - The certificate in raw PEM format.
