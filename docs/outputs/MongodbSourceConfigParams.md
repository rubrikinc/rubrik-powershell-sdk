### MongodbSourceConfigParams
Configuration parameters for the MongoDB source object.

- ignoreSecondaries: a list of MongodbHosts
  - We do not backup the secondary nodes if this configuration is true.
- mongodbHosts: a list of MongodbHosts
  - List of seed hosts for establishing connection to source cluster.
- sourceDbUser: System.String
  - Username for MongoDB source .
- sourceNodeUser: System.String
  - SSH user name for the source nodes.
- sourceSshPort: System.Int32
  - SSH Port.
- sslOptions: MongodbSslOptions
  - SSL configuration for the source cluster.
