### MongoSourceAddRequestConfigInput
Supported in v8.1+
Configuration for adding a MongoDB source.

- caCertfilePath: System.String
  - Supported in v8.1+
Path to the CA certificate file.
- ignoreSecondaries: list of System.Strings
  - Supported in v8.1+
v8.1-v9.2: List of secondaries that should be ignored.
v9.3+: List of secondary nodes that should be ignored during backup in the format hostname:port.
- mongoClientHosts: list of MongoClientHostInputs
  - Required. Supported in v8.1+
v8.1-v9.2: List of host details where MongoDB is hosted.
v9.3+: List of host details where MongoDB is hosted. For Replica Set deployments, enter details for at least 1 Rubrik Backup Service host to add to the MongoDB cluster nodes. For Sharded Cluster deployments, enter details for at least 1 of the configuration servers.
- mongoType: MongoType
  - Required. Supported in v8.1+
v8.1-v9.2: Type of MongoDB cluster.
v9.3+: Type of the MongoDB deployment.
- sourceDriverPassword: System.String
  - Supported in v8.1+
Password of the mongod driver user account.
- sourceDriverUser: System.String
  - Supported in v8.1+
v8.1-v9.2: Username of mongod driver user account.
v9.3+: Username of the mongod driver user account.
- sourceName: System.String
  - Required. Supported in v8.1+
v8.1-v9.2: Name of the MongoDB cluster.
v9.3+: Unique name of the MongoDB source which will act as an identifier for Rubrik.
- sslCertificateRequired: MongoSslCertificateRequirement
  - Supported in v8.1+
Specifies whether SSL certificates are required for the connection.
- sslKeyfilePath: System.String
  - Supported in v8.1+
Path to the SSL key file.
- sslCertfilePath: System.String
  - Path to the SSL certificate file.
- sourceAuthenticationType: MongoAuthenticationType
  - Supported in v9.0+
Type of user authentication used when adding the MongoDB cluster.
