### PostgresDBClusterConfigInput
Supported in v9.2+
PostgreSQL database cluster configuration.

- systemUsername: System.String
  - Required. Supported in v9.2+
Username for accessing the OS user.
- loginInfo: PostgresLoginInfoInput
  - Supported in v9.2+
- discoveryInfo: DiscoverableInputInput
  - Required. Supported in v9.2+
- haClusterConfig: PostgresHaClusterConfigInput
  - Supported in v9.6+
Optional HA cluster configuration for multi-host setups.
