### SapHanaSslInformation
Information required to connect to SAP HANA database over SSL.

- cryptoLibPath: System.String
  - Library path for SAP HANA crypto library (libsapcrypto.so).
- encryptionProvider: SapHanaEncryptionProvider
  - The encryption provider for the SAPA HANA system.
- hostNameInCertificate: System.String
  - Override the hostname used to verify the server's identity.
- keyStorePath: System.String
  - The path where the encryption key for the SAP HANA system is stored.
- shouldEncrypt: System.Boolean
  - Specifies whether to encrypt the database connection using SSL/TLS.
- shouldValidateCertificate: System.Boolean
  - Specifies whether to validate the SSL certificate of the SAP HANA DB server.
- trustStorePath: System.String
  - Path to a trust store file that contains the public certificates of the SAP HANA DB server.
