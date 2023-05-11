### SourceConfigParams
Configuration Params for the mosaic source object.

- cassandraYaml: a list of System.Strings
  - List of cassandra yaml file paths.
- dseYaml: a list of System.Strings
  - List of DSE YAML file paths.
- httpsCertificate: System.String
  - Path to https certificate.
- jmxUser: System.String
  - JMX Username.
- sourceDbUser: System.String
  - Database username.
- sourceHttpsPort: System.Int32
  - Port number used for https connection.
- sourcePort: System.Int32
  - Configured port on source.
- sourceRpcPort: System.Int32
  - Configured RPC port on source.
- sslOptions: CassandraSslOptions
  - Source SSL Configuration.
