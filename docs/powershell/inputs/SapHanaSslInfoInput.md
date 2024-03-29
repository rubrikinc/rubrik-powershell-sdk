### SapHanaSslInfoInput
Supported in v5.3+

- cryptoLibPath: System.String
  - Supported in v7.0+
      Library path for SAP HANA crypto library (libsapcrypto.so).
- hostNameInCertificate: System.String
  - Supported in v7.0+
      Override the hostname used to verify the server's identity.
- shouldEncrypt: System.Boolean
  - Supported in v7.0+
      Specifies whether to encrypt the database connection using SSL/TLS.
- shouldValidateCertificate: System.Boolean
  - Supported in v7.0+
      Specifies whether to validate the SSL certificate of the SAP HANA DB server.
- trustStorePath: System.String
  - Supported in v7.0+
      Path to a trust store file that contains the public certificates of the SAP HANA DB server.
- encryptionProvider: SapHanaSslInfoEncryptionProvider
  - Required. Supported in v5.3+
      The encryption provider for the SAPA HANA system. Possible values are OPENSSL, COMMON_CRYPTO, SAP_CRYPTO.
- keyStorePath: System.String
  - Required. Supported in v5.3+
      The path where the encryption key for the SAP HANA system is stored.
