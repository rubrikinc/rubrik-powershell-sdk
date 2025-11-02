### HostSummary
Supported in v5.0+

- hostname: System.String
  - Required. Supported in v5.0+
Deprecated. Please use 'name' instead.
- id: System.String
  - Required. Supported in v5.0+
v5.0-v5.2:
v5.3+: Unique identifier for host.
- mssqlCbtEffectiveStatus: MssqlCbtEffectiveStatusType
  - Supported in v5.0+
Property that indicates whether CBT is enabled for backups of SQL Server databases on a Windows host. When the value of mssqlCbtEnabled is Default, this property has the same value as the global CBT setting. In all other cases, this property has the same value as mssqlCbtEnabled. To change the global CBT setting, use the SQL Server default property update endpoint.
- mssqlCbtEnabled: MssqlCbtStatusType
  - Supported in v5.0+
Property that indicates whether CBT is enabled for backups of SQL Server databases on a Windows host. Set to Enabled when CBT based backups of SQL Server databases for the specified Windows host is enabled. Set to Disabled when CBT based backups of SQL Server databases for the specified Windows host is turned off. Set to Default when the Windows host inherits the global CBT setting.
- name: System.String
  - Supported in v5.0+
v5.0-v5.2:
v5.3+: IP address or hostname of the host.
- nasBaseConfig: NasBaseConfig
  - Supported in v5.0+
- operatingSystem: System.String
  - Supported in v5.0+
v5.0-v5.2:
v5.3+: Operating system of the host. One of Windows, Linux, AIX, HPUX, and SunOS.
- operatingSystemType: System.String
  - Supported in v5.0+
v5.0-v5.2:
v5.3+: The operating system of the host. Possible choices are Windows, Linux, AIX, HPUX, SunOS.
- organizationId: System.String
  - Supported in v5.0+
The ID of the organization to which the host is assigned (set by envoy).
- organizationName: System.String
  - Supported in v5.0+
The name of the organization to which the host is assigned (set by envoy).
- primaryClusterId: System.String
  - Supported in v5.0+
v5.0-v5.2:
v5.3+: ID of the Rubrik cluster to which the host belongs.
- status: System.String
  - Supported in v5.0+
v5.0-v5.2:
v5.3-v9.1: Specifies the connect status for the host. Status is Refreshing while discovery is running or Connected once discovery was successful and the host is available.
v9.2+: This field is deprecated, use statusEnum field instead.
- alias: System.String
  - Supported in v5.1+
A user-specified string that returns this host in searches.
- hdfsBaseConfig: HdfsBaseConfig
  - Supported in v5.2-v9.1
- isRefreshPaused: System.Boolean
  - Supported in v9.0+
Specifies whether the refresh of host metadata for this host is paused.
- statusEnum: HostRbsConnectionStatus
  - Supported in v9.2+
Specifies the connect status for the host. Status is Refreshing while discovery is running or Connected once discovery was successful and the host is available.
- adDomain: System.String
  - Supported in v9.5
The Active Directory domain name for the host, if applicable.
- volumeGroupInfo: VolumeGroupDetailInfo
  - Supported in v9.2+
Volume Group info for the host if applicable.
- agentId: System.String
  - Supported in v9.1+
ID of the Rubrik Backup Service (RBS) installed on the host.
- agentPrimaryClusterUuid: System.String
  - Supported in v9.4+
UUID of the primary cluster for the agent.
- lastRefreshTimeStamp: System.Int64
  - Supported in v8.1+
Specifies the last refresh epoch time in msec.
