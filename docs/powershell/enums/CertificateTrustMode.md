### CertificateTrustMode
Specifies how the TLS trust anchor for an S3-compatible archival location was chosen.

- CERTIFICATE_TRUST_MODE_TOFU - The Rubrik cluster trusts the certificate captured on first connection.
- CERTIFICATE_TRUST_MODE_DEFAULT - The endpoint is validated against the platform default trust store.
- CERTIFICATE_TRUST_MODE_CUSTOM - The endpoint is validated against an administrator-selected certificate.
