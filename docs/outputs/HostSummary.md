### HostSummary
Supported in v5.0+

- alias: System.String
  - Supported in v5.1+
  A user-specified string that returns this host in searches.
- hdfsBaseConfig: HdfsBaseConfig
  - Supported in v5.2+
- hostname: System.String
  - Required. Supported in v5.0+
  Deprecated. Please use 'name' instead.
- id: System.String
  - Required. Supported in v5.0+
  v5.0-v5.2: 
  v5.3+: Unique identifier for host.
- mssqlCbtEffectiveStatus: MssqlCbtEffectiveStatusType
  - 
- mssqlCbtEnabled: MssqlCbtStatusType
  - 
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
  v5.3+: Specifies the connect status for the host. Status is Refreshing while discovery is running or Connected once discovery was successful and the host is available.
