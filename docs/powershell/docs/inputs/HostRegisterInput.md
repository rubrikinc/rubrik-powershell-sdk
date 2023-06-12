### HostRegisterInput
Supported in v5.0+

- hasAgent: System.Boolean
  - Supported in v5.0+
- nasConfig: NasConfigInput
  - Supported in v5.0+
- oracleQueryUser: System.String
  - Supported in v5.0+
      Specifies the Oracle username for an account with query privileges. The account must have query privileges for a specified Oracle installation to enable Oracle discovery queries for that installation.
- oracleSysDbaUser: System.String
  - Supported in v5.0+
      v5.0: Specifies the Oracle username for an account with sysdba privileges. The account must have sysdba privileges for a specified Oracle installation to enable backup and recovery of Oracle databases for that installation. This field overrides the configured global sysdba user for the specified Oracle installation.
      v5.1+: Specifies the Oracle username for an account with sysdba privileges. The account must have sysdba privileges for a specified Oracle installation to enable Oracle discovery queries for that installation. This field overrides the configured global sysdba user for the specified Oracle installation.
- organizationId: System.String
  - Supported in v5.0+
      The ID of the organization to which the host is assigned.
- alias: System.String
  - Supported in v5.1+
      A user-specified string that returns this host in searches.
- hdfsConfig: HdfsConfigInput
  - Supported in v5.2+
- isOracleHost: System.Boolean
  - Supported in v5.2+
      A Boolean that specifies whether to discover Oracle information at registration. A value of 'true' discovers Oracle information at registration.
- hostname: System.String
  - Required. Supported in v5.0+
