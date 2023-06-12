### SourceConfigParams
Configuration Params for the mosaic source object.

- cassandraYaml: list of System.Strings
  - List of cassandra yaml file paths.
- dseYaml: list of System.Strings
  - List of DSE YAML file paths.
- httpsCertificate: System.String
  - Path to https certificate.
- sourceHttpsPort: System.Int32
  - Port number used for https connection.
- jmxUser: System.String
  - JMX Username.
- sourceRpcPort: System.Int32
  - Configured RPC port on source.
- sourceDbUser: System.String
  - Database username.
- sourcePort: System.Int32
  - Configured port on source.
- sslOptions: CassandraSslOptions
  - Source SSL Configuration.
