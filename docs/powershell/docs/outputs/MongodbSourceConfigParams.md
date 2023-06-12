### MongodbSourceConfigParams
Configuration parameters for the MongoDB source object.

- mongodbHosts: list of MongodbHosts
  - List of seed hosts for establishing connection to source cluster.
- ignoreSecondaries: list of MongodbHosts
  - We do not backup the secondary nodes if this configuration is true.
- sourceSshPort: System.Int32
  - SSH Port.
- sourceDbUser: System.String
  - Username for MongoDB source .
- sourceNodeUser: System.String
  - SSH user name for the source nodes.
- sslOptions: MongodbSslOptions
  - SSL configuration for the source cluster.
