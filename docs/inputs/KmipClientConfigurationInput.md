### KmipClientConfigurationInput
Supported in v5.0+

- clientCertificate: System.String
  - Supported in v5.0-v5.1
      X.509 certificate in Base64 encoded DER format. This certificate should be trusted by the KMIP server. The certificate should start with -----BEGIN CERTIFICATE-----
- clientCertificateId: System.String
  - Supported in v5.2+
      The ID of an imported certificate in the CDM certificate management table.
- password: System.String
  - Supported in v5.0+
      v5.0-v5.2: password for the KMIP server
      v5.3+: The password for the KMIP server.
- username: System.String
  - Required. Supported in v5.0+
      v5.0-v5.2: username for the KMIP server
      v5.3+: The username for the KMIP server.
