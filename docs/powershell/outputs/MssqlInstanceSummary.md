### MssqlInstanceSummary
Supported in v5.0+

- clusterInstanceAddress: System.String
  - Supported in v5.0+
  The address of the instance in a Windows server failover cluster, populated only if it belongs to one.
- configuredSlaDomainId: System.String
  - Supported in v5.0+
  SLA Domain ID assigned to instance.
- configuredSlaDomainName: System.String
  - Supported in v5.0+
  SLA Domain name assigned to instance.
- id: System.String
  - Required. Supported in v5.0+
- internalTimestamp: System.Int64
  - Supported in v5.0+
- name: System.String
  - Supported in v5.0+
- primaryClusterId: System.String
  - Required. Supported in v5.0+
- rootProperties: MssqlRootProperties
  - Required. Supported in v5.0+
- version: System.String
  - Supported in v5.0+
- isRetentionLocked: System.Boolean
  - Supported in v5.1+
  Boolean value that identifies a Retention Lock SLA Domain. Value is true when the SLA Domain assigned to the instance is Retention Locked and false when it is not.
- configuredSlaDomainType: System.String
  - Supported in v5.2+
  Specifies whether the SLA Domain is used for protection or retention.
- mssqlNonSlaProperties: MssqlNonSlaProperties
  - 
- mssqlSlaRelatedProperties: MssqlSlaRelatedProperties
  - 
- protectionDateV50: System.String
  - 
- protectionDateV51: System.String
  - 
- protectionDateV52: System.String
  - 
- protectionDateV53: System.String
  - 
- protectionDateV60: DateTime
  - 
- protectionDateV70: DateTime
  - 
- protectionDateV80: DateTime
  - 
- protectionDateV81: DateTime
  - 
- protectionDateV90: DateTime
  - 
- unprotectableReasonsV50: list of MssqlUnprotectableReasons
  - A list of reasons that all the SQL Server databases in a SQL Server instance cannot be protected by Rubrik.
- unprotectableReasonsV51: list of System.Strings
  - A list of reasons that all the SQL Server databases in a SQL Server instance cannot be protected by the Rubrik CDM.
- unprotectableReasonsV52: list of System.Strings
  - A list of reasons that all the SQL Server databases in a SQL Server instance cannot be protected by the Rubrik CDM.
- unprotectableReasonsV53: list of System.Strings
  - A list of reasons that all the SQL Server databases in a SQL Server instance cannot be protected by the Rubrik CDM.
- unprotectableReasonsV60: list of System.Strings
  - A list of reasons that all the SQL Server databases in a SQL Server instance cannot be protected by the Rubrik CDM.
- unprotectableReasonsV70: list of System.Strings
  - A list of reasons that all the SQL Server databases in a SQL Server instance cannot be protected by the Rubrik CDM.
- unprotectableReasonsV80: list of System.Strings
  - A list of reasons that all the SQL Server databases in a SQL Server instance cannot be protected by the Rubrik CDM.
- unprotectableReasonsV81: list of System.Strings
  - A list of reasons that all the SQL Server databases in a SQL Server instance cannot be protected by the Rubrik CDM.
- unprotectableReasonsV90: list of System.Strings
  - A list of reasons that all the SQL Server databases in a SQL Server instance cannot be protected by the Rubrik CDM.
- protectionDateV91: DateTime
  - 
- unprotectableReasonsV91: list of System.Strings
  - A list of reasons that all the SQL Server databases in a SQL Server instance cannot be protected by the Rubrik CDM.
