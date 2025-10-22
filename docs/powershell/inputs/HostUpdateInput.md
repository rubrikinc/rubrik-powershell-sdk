### HostUpdateInput
Supported in v5.0+

- compressionEnabled: System.Boolean
  - Supported in v5.0+
- hostVfdDriverInstalled: System.Boolean
  - When VFD is not enabled on the specified Windows host, set this property to false to instruct the Rubrik cluster to remove the VFD driver from a specified Windows host. Before using this property, disable VFD on the specified Windows host by setting the value of HostVfdEnabled to not enabled.
- hostname: System.String
  - Supported in v5.0+
- mssqlCbtDriverInstalled: System.Boolean
  - When CBT is not enabled on the specified Windows host, set this property to false to instruct the Rubrik cluster to remove the CBT driver from a specified Windows host. Before using this property, disable CBT on the specified Windows host by setting the value of mssqlCbtEnabled to not enabled.
- oracleQueryUser: System.String
  - Supported in v5.0+
      Specifies the Oracle username for an account with query privileges. The account must have query privileges for a specified Oracle installation to enable Oracle discovery queries for that installation.
- oracleSysDbaUser: System.String
  - Supported in v5.0+
      v5.0: Specifies the Oracle username for an account with sysdba privileges. The account must have sysdba privileges for a specified Oracle installation to enable backup and recovery of Oracle databases for that installation. This field overrides the configured global sysdba user for the specified Oracle installation.
      v5.1-v5.3: Specifies the Oracle username for an account with sysdba privileges. The account must have sysdba privileges for a specified Oracle installation to enable Oracle discovery queries for that installation. This field overrides the configured global sysdba user for the specified Oracle installation.
      v6.0+: Specifies the Oracle username for an account with sysdba privileges. The account must have sysdba privileges for a specified Oracle installation to enable Oracle discovery queries for that installation. This field overrides the configured global sysdba user for the specified Oracle installation.
- alias: System.String
  - Supported in v5.1+
      A user-specified string that returns this host in searches.
- isOracleHost: System.Boolean
  - Supported in v5.2+
      v5.2-v5.3: A Boolean that specifies whether to discover Oracle information during host refresh. A value of 'true' discovers Oracle information during host refresh.
      v6.0: A Boolean that specifies whether to discover Oracle information during host refresh. A value of 'true' discovers Oracle information during host refresh.
      
      v7.0-v8.0: A Boolean that specifies whether to discover Oracle information during host refresh. A value of 'true' discovers Oracle information during host refresh. 
      
      v8.1: A Boolean that specifies whether to discover Oracle information during host refresh. A value of 'true' discovers Oracle information during host refresh.
      
      v9.0+: A Boolean that specifies whether to discover Oracle information during host refresh. A value of 'true' discovers Oracle information during host refresh.
- isUpdateCertAndAgentIdEnabled: System.Boolean
  - Supported in v7.0+
      v7.0-v9.1: A Boolean that specifies whether to update the Rubrik Backup Agent and agent ID during host edit.  
      
      v9.2+: A Boolean that specifies whether to update the Rubrik Backup Agent and agent ID during host edit.
- isRefreshPaused: System.Boolean
  - Supported in v9.0+
      A Boolean that specifies whether the host refresh is paused or not.
- mssqlSddCertificateId: System.String
  - Supported in v9.3. The certificate ID is the identifier associated with the public key certificate issued by the Certificate Authority (CA) that signed the SQL Server certificate. This ID is used to validate the identity of the SQL Server host during Sensitive Data Discovery.
- oracleSddWalletPath: System.String
  - Supported in v9.3+
      Contains the wallet path on the Oracle host which is used to authenticate the client trying to make remote connections to oracle databases during Sensitive Data Discovery.
- hostVfdEnabled: HostVfdInstallConfig
  - Supported in v5.0+
- mssqlCbtEnabled: MssqlCbtStatusType
  - Supported in v5.0+
- hdfsConfig: HdfsConfigInput
  - Supported in v5.2-v9.1
- mssqlSddUserCredentials: SddUserCredentialsInput
  - Supported in v9.2+
      The user credentials for querying SQL server instance on the host for Sensitive Data Discovery.
- nasConfig: NasConfigInput
  - Supported in v5.0+
- oracleSddUserCredentials: SddUserCredentialsInput
  - Supported in v9.3+
      The user credentials for querying oracle databases on the host for Sensitive Data Discovery.
- oracleSepsSettings: OracleSepsWalletSettingsInput
  - Supported in v9.4+
      Contains Oracle SEPS settings for the host such as enabling or disabling SEPS-based authentication.
