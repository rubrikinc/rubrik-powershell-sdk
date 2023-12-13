### GetCertificateInfoReply
Certificate metadata details.

- expiringAt: DateTime
  - The expiration date of the certificate.
- issuedOn: DateTime
  - The date when the certificate was issued.
- certificate: System.String
  - The certificate in x509 PEM format.
- issuedTo: System.String
  - To whom the certificate was issued.
- issuedBy: System.String
  - The issuer of the certificate.
- sha1Fingerprint: System.String
  - The sha-1 fingerprint, in hexadecimal format, of the certificate.
- sha256Fingerprint: System.String
  - The sha-256 fingerprint, in hexadecimal format, of the certificate.
- serialNumber: System.String
  - The serial number in hexadecimal format of the certificate.
