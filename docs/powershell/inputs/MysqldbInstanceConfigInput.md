### MysqldbInstanceConfigInput
Supported in v9.3+
MySQL database instance configuration.

- discoveryInfo: DiscoverableInputInput
  - Required. Supported in v9.3+
- advancedConfigInfo: MysqldbAdvancedConfigInfoInput
  - Supported in v9.6+
- connectionInfo: MysqldbConnectionInfoInput
  - Supported in v9.3+
- haClusterConfig: MysqldbHaClusterConfigInput
  - Optional HA cluster configuration. Providing it marks this instance as an HA cluster; the instance-level connection and advanced settings then act as defaults that each replica can override.
