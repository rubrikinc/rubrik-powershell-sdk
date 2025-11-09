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
- hostVfdDriverState: HostVfdState
  - Required. Supported in v5.0+
v5.0-v6.0: Specifies the installation status of the VFD driver on a Windows host. The value is 'NotInstalled' when the driver is absent. The value is 'Installed' when the driver is present. The value is 'RestartRequred' when the driver is present but requires a restart of the Windows host in order to function.
v7.0+: Specifies the installation status of the VFD driver on a Windows host. The value is - 'NotInstalled' when the driver is absent. - 'Installed' when the driver is present. - 'InstalledButRestartRequred' when the driver is present but requires a restart of the Windows host. - 'InstalledButTwoRestartsRequred' when the driver is updated but requires two restarts of the Window host. - 'UninstalledButRestartRequired' when the driver is uninstalled but requires a restart of the Windows host to remove the driver.
- hostVfdEnabled: HostVfdInstallConfig
  - Supported in v5.0+
Specifies the status of VFD-based volume backups on Windows hosts. The value is 'Enabled' when VFD-based volume backups are enabled. The value is 'Disabled' when VFD-based volume backups are disabled.
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
- osInstallationTypeOpt: System.String
  - Supported in v9.4+
Specifies the Windows installation type (e.g., "Server", "Client"). Only applicable to Windows hosts; null for non-Windows hosts.
- oracleSepsSettings: OracleSepsWalletSettings
  - Supported in v9.4+
Oracle SEPS settings for the host.
- activeDirectoryAdditionalInfo: ActiveDirectoryAdditionalInfo
  - Supported in v9.2+
v9.2:
v9.3+: Additional Active Directory info for the host if applicable.
- mssqlSddCertificateId: System.String
  - Supported in v9.2+
Specifies the certificate ID corresponding to the public key certificate of the CA that signed the SQL server certificate for Sensitive Data Discovery.
- oracleSddWalletPath: System.String
  - Supported in v9.3+
Specifies the wallet path on the Oracle host which is used to authenticate remote connections to oracle databases during Sensitive Data Discovery.
- shouldOracleSddThroughRba: System.Boolean
  - Supported in v9.4+
A Boolean flag that specifies whether to perform the Data Discovery and Classification data acquisition workflow for Oracle host through RBA.
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
- shouldMssqlSddThroughRba: System.Boolean
  - Supported in v9.4+
A Boolean flag that specifies whether to perform the Data Discovery and Classification data acquisition workflow for SQL Server host through RBA.
- oracleSddUsername: System.String
  - Supported in v9.3+
Specifies the username configured for the Oracle host for sensitive data discovery.
