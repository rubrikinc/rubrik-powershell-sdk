### GlobalCertificate
Information about a certificate on Rubrik Security Cloud.

- certificateId: System.String
  - The ID of the certificate.
- name: System.String
  - The display name of the certificate.
- description: System.String
  - The description of the certificate.
- hasKey: System.Boolean
  - Specifies whether the certificate has a private key.
- expiringAt: DateTime
  - The expiration date of the certificate.
- certificate: System.String
  - The certificate in raw PEM format.
- issuedTo: System.String
  - To whom the certificate was issued.
- issuedBy: System.String
  - The issuer of the certificate.
- issuedOn: DateTime
  - The date on which the certificate was issued.
- clusters: list of CertificateClusterInfos
  - The Rubrik clusters to which the certificate has been uploaded.
- isCaSigned: System.Boolean
  - Specifies if the certificate is signed by a Certificate Authority.
- status: GlobalCertificateStatus
  - The expiration status of the certificate.
- sha1Fingerprint: System.String
  - The SHA-1 fingerprint of the certificate, in hexadecimal format.
- sha256Fingerprint: System.String
  - The SHA-256 fingerprint of the certificate, in hexadecimal format.
- serialNumber: System.String
  - The serial number of the certificate, in hexadecimal format.
- cdmUsages: list of CdmCertificateUsageInfos
  - The usages for the certificate on Rubrik clusters.
- usages: list of CertificateUsageInfos
  - The usages for the certificate on Rubrik Security Cloud.
- isCdmBorn: System.Boolean
  - Specifies whether the certificate was imported directly from Rubrik CDM.
- certificateFid: System.String
  - The FID of the certificate.
- issuerType: IssuerType
  - Specifies the type of the certificate issuer.
- certificateRotation: CertificateRotation
  - Specifies the certificate rotation details.
- isCa: System.Boolean
  - Specifies whether the certificate is a CA.
- userHasPrivilegeToScheduleRotation: System.Boolean
  - Specifies whether the user has the privilege to schedule a certificate rotation.
- rbsHostUsage: RbsHostUsage
  - Specifies the host that uses this certificate for Rubrik Backup Service (RBS).
- keyType: System.String
  - The cryptographic key type of the certificate (for example, "rsa", "ec").
Empty for legacy certificates whose key metadata was never extracted.
- keyStrength: System.String
  - The cryptographic key strength of the certificate (for example, "2048",
"secp384r1"). Empty for legacy certificates or keys whose strength does
not map to a canonical value.
- org: Org
  - The organization to which the certificate has been assigned.
