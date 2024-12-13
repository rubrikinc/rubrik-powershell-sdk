### PhysicalHostMetadata
Metadata details of a Physical Host.

- cdmId: System.String
  - ID of the physical host in the Rubrik cluster.
- ipAddresses: list of System.Strings
  - IP addresses associated with the Physical Host.
- osName: System.String
  - The name of the Physical Host's operating system.
- connectionStatus: HostConnectionStatus
  - The connection status of the Physical Host.
- isArchived: System.Boolean
  - Whether the Physical Host is archived.
- mssqlSddDetail: MssqlSddDetail
  - Specifies the MSSQL SDD details.
- oracleSddDetail: OracleSddDetail
  - Specifies the Oracle database Sensitive Data Monitoring details.
- osType: GuestOsType
  - The operating system type of the physical host.
- defaultCbt: System.Boolean
  - Default CBT status of this Physical Host.
- cbtStatus: System.String
  - CBT status of this Physical Host.
