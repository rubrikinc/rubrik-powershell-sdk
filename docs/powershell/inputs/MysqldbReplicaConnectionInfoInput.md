### MysqldbReplicaConnectionInfoInput
Per-replica connection and authentication settings for a replica in an HA MySQL cluster. Reuses the instance-level MysqldbConnectionInfo so a replica fully specifies its own connection; portNumber is carried separately because it is replica ADDRESSING (co-located replicas share a host and differ only by port), not a credential.

- portNumber: System.Int32
  - Port for this replica's MySQL server. Multiple replicas can share a host (each on a different port). Required when authenticationType is TCPBased.
- mysqlBinaryPath: System.String
  - Per-replica path to the directory containing MySQL client binaries (mysql, mysqlbinlog, and so on).
- connectionInfo: MysqldbConnectionInfoInput
  - Required. Connection and authentication settings for this replica.
