### HostDetail
Supported in v5.0+

- agentId: System.String
  - Supported in v5.0-v9.0
  v5.0-v5.2:
  v5.3-v9.0: ID of the Rubrik Backup Service (RBS) installed on the host.
- compressionEnabled: System.Boolean
  - Supported in v5.0+
  v5.0-v5.2:
  v5.3+: Indicates if compression is enabled while transferring data between the host and the Rubrik cluster.
- isRelic: System.Boolean
  - Required. Supported in v5.0+
  A relic host is deleted, but still may have snapshots associated with its children (e.g. Fileset).
- mssqlCbtDriverInstalled: System.Boolean
  - Required. Supported in v5.0+
  v5.0-v5.2: Boolean value that indicates whether the CBT driver is installed for SQL Server instances on the specified Windows host. Set to true when the CBT driver is installed. Set to false when the CBT driver is not installed
  v5.3: Indicates if the CBT driver is installed for SQL Server instances on the specified Windows host. Set to true when the CBT driver is installed. Set to false when the CBT driver is not installed
  v6.0+: Indicates if the CBT driver is installed for SQL Server instances on the specified Windows host. Set to true when the CBT driver is installed. Set to false when the CBT driver is not installed.
- oracleQueryUser: System.String
  - Supported in v5.0+
  Specifies the Oracle username for an account with query privileges.
- oracleSysDbaUser: System.String
  - Supported in v5.0+
  Specifies the Oracle username for an account with sysdba privileges.
- isOracleHost: System.Boolean
  - Supported in v5.2+
  v5.2: Specifies whether the host is an Oracle host. When the host is an Oracle host, the UI displays the Oracle discovery fields.
  v5.3: Specifies whether this is an Oracle host. This indicates whether to show Oracle discovery fields in the UI.
  v6.0+: Specifies whether this is an Oracle host. This indicates whether to show Oracle discovery fields in the UI.
- isRefreshPaused: System.Boolean
  - Supported in v9.0+
  Specifies whether the refresh of host metadata for this host is paused.
- hostSummary: HostSummary
  - 
- activeDirectoryAdditionalInfo: ActiveDirectoryAdditionalInfo
  - Supported in v9.2+
  v9.2:
  v9.3: Additional Active Directory info for the host if applicable.
- mssqlSddCertificateId: System.String
  - Supported in v9.3
  Specifies the certificate ID corresponding to the public key certificate of the CA that signed the SQL server certificate for Sensitive Data Discovery.
- mssqlSddUsername: System.String
  - Supported in v9.2+
  Specifies the username configured for the SQL server instance for sensitive data discovery.
- hostDomainName: System.String
  - Supported in v9.0+
  v9.0-v9.1: Specify the name of active directory domain.
  v9.2+: (DEPRECATED) This field is deprecate in favor of activeDirectoryAdditionalInfo. Specify the name of active directory domain.
- hostDomainId: System.String
  - Supported in v9.0+
  v9.0-v9.1: Id of the Active Directory Domain if the windows host has domain controller hosted.
  v9.2+: (DEPRECATED) This field is deprecate in favor of activeDirectoryAdditionalInfo. Id of the Active Directory Domain if the windows host has domain controller hosted.
- hostVfdDriverState: HostVfdState
  - 
- hostVfdEnabled: HostVfdInstallConfig
  - 
