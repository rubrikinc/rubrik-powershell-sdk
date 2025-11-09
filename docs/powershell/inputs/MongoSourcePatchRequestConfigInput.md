### MongoSourcePatchRequestConfigInput
Supported in v8.1+
Configuration for patching a MongoDB source.

- caCertfilePath: System.String
  - Supported in v8.1+
Path to the CA certificate file.
- ignoreSecondaries: list of System.Strings
  - Supported in v8.1+
v8.1-v9.2: List of secondaries that should be ignored.
v9.3+: List of secondary nodes that should be ignored during backup in the format hostname:port.
- sourceDriverPassword: System.String
  - Supported in v8.1+
Password of the mongod driver user account.
- sourceDriverUser: System.String
  - Supported in v8.1+
v8.1-v9.2: Username of mongod driver user account.
v9.3+: Username of the mongod driver user account.
- sslCertificateRequired: MongoSslCertificateRequirement
  - Supported in v8.1+
Specifies whether SSL certificates are required for the connection.
- sslKeyfilePath: System.String
  - Supported in v8.1+
Path to the SSL key file.
- sslCertfilePath: System.String
  - Path to the SSL certificate file.
- mongoClientHosts: list of MongoClientHostInputs
  - List of mongos details hosting the MongoDB deployment. For an existing sharded deployment protected using config server seed nodes, provide the mongos seed nodes for at least one node after installing RBS. This enables the transition to use the recommended approach of protecting the MongoDB workload with a mongos type node.
- sourceAuthenticationType: MongoAuthenticationType
  - Supported in v9.0+
Type of user authentication used when adding the MongoDB cluster.
