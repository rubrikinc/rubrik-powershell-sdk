### MysqldbConnectionInfoInput
Supported in v9.3+
Login details for accessing the MySQL instance.

- socketFilePath: System.String
  - Supported in v9.4+
Unix socket file path for the MySQL instance.
- systemUsername: System.String
  - Required. Supported in v9.3+
Username for accessing the OS user.
- authenticationType: MysqldbAuthenticationType
  - Supported in v9.4+
Authentication type for accessing the instance.
- bindIpAddress: System.String
  - Supported in v9.3+
Bind IP address of the instance.
- sslConfig: MysqldbSslConfigInput
  - Supported in v9.4+
SSL configuration of the MySQL instance.
- password: System.String
  - Required. Supported in v9.3+
Password for accessing the instance.
- username: System.String
  - Required. Supported in v9.3+
Username for accessing the instance.
