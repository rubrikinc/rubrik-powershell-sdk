### SourceInput
Supported in m3.2.0-m4.2.0
  Source Object.

- async: System.Boolean
  - Supported in m3.2.0-m4.2.0
      m3.2.0-m4.0.1: If the call should be async.
      m4.1.0-m4.2.0: If call should be async.
- cassandraYaml: a list of System.Strings
  - Supported in m3.2.0-m4.2.0
      m3.2.0-m4.0.1: List of cassandra yaml.
      m4.1.0-m4.2.0: List of cassandra yaml files.
- dseYaml: a list of System.Strings
  - Supported in m3.2.0-m4.2.0
      m3.2.0-m4.0.1: List of dse yaml.
      m4.1.0-m4.2.0: List of dse yaml files.
- enableSsl: System.Boolean
  - Supported in m3.2.0-m4.2.0
      Whether ssl enabled.
- httpsCertificate: System.String
  - Supported in m3.2.0-m4.2.0
      m3.2.0-m4.0.1: Https certificate to connect.
      m4.1.0-m4.2.0: HTTPS certificate.
- ignoreSecondaries: a list of System.Strings
  - Supported in m3.2.0-m4.2.0
      Ignore secondaries.
- jmxPassword: System.String
  - Supported in m3.2.0-m4.2.0
      JMX password.
- jmxUser: System.String
  - Supported in m3.2.0-m4.2.0
      JMX user.
- parameterEncoded: System.Boolean
  - Supported in m3.2.0-m4.2.0
      If parameter is encoded.
- sourceAuthKey: System.String
  - Supported in m3.2.0-m4.2.0
      m3.2.0-m4.0.1: Auth key for source.
      m4.1.0-m4.2.0: Source auth key.
- sourceAuthKeyfile: System.String
  - Supported in m3.2.0-m4.2.0
      Auth key file for source.
- sourceAuthPassphrase: System.String
  - Supported in m3.2.0-m4.2.0
      m3.2.0-m4.0.1: Source auth passphrase.
      m4.1.0-m4.2.0: Auth passphrase for source.
- sourceDriverPassword: System.String
  - Supported in m3.2.0-m4.2.0
      Source driver password.
- sourceDriverUser: System.String
  - Supported in m3.2.0-m4.2.0
      Source driver user.
- sourceHttpsPort: System.String
  - Supported in m3.2.0-m4.2.0
      m3.2.0-m4.0.1: Source https port.
      m4.1.0-m4.2.0: Source HTTPS port.
- sourceIp: a list of System.Strings
  - Required. Supported in m3.2.0-m4.2.0
      m3.2.0-m4.0.1: List of source IPs.
      m4.1.0-m4.2.0: Https certificate to connect.
- sourceName: System.String
  - Required. Supported in m3.2.0-m4.2.0
      Name of the source.
- sourcePassword: System.String
  - Supported in m3.2.0-m4.2.0
      Source password.
- sourcePort: System.String
  - Supported in m3.2.0-m4.2.0
      m3.2.0-m4.0.1: Source port number.
      m4.1.0-m4.2.0: Source port.
- sourceRpcPort: System.String
  - Supported in m3.2.0-m4.2.0
      Source rpc port.
- sourceSshPort: System.String
  - Supported in m3.2.0-m4.2.0
      m3.2.0-m4.0.1: Source SSH Port number.
      m4.1.0-m4.2.0: Source SSH port.
- sourceType: SourceSourceType
  - Required. Supported in m3.2.0-m4.2.0
      m3.2.0-m4.0.1: Source type.
      m4.1.0-m4.2.0: Type of the source.
- sourceUser: System.String
  - Supported in m3.2.0-m4.2.0
      m3.2.0-m4.0.1: Source username.
      m4.1.0-m4.2.0: Source user.
- sslCaCerts: System.String
  - Supported in m3.2.0-m4.2.0
      SSD CA certificate.
- sslCertReqs: SourceSslCertReqs
  - Supported in m3.2.0-m4.2.0
      SSL Cert Reqs.
- sslCertfile: System.String
  - Supported in m3.2.0-m4.2.0
      SSL certificate file.
- sslKeyfile: System.String
  - Supported in m3.2.0-m4.2.0
      SSL keyfile.
