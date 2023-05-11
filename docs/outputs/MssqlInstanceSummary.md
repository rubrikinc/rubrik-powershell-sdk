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
- configuredSlaDomainType: System.String
  - Supported in v5.2+
  Specifies whether the SLA Domain is used for protection or retention.
- id: System.String
  - Required. Supported in v5.0+
- internalTimestamp: System.Int64
  - Supported in v5.0+
- isRetentionLocked: System.Boolean
  - Supported in v5.1+
  Boolean value that identifies a Retention Lock SLA Domain. Value is true when the SLA Domain assigned to the instance is Retention Locked and false when it is not.
- mssqlNonSlaProperties: MssqlNonSlaProperties
  - 
- mssqlSlaRelatedProperties: MssqlSlaRelatedProperties
  - 
- name: System.String
  - Supported in v5.0+
- primaryClusterId: System.String
  - Required. Supported in v5.0+
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
- rootProperties: MssqlRootProperties
  - Required. Supported in v5.0+
- unprotectableReasonsV50: a list of MssqlUnprotectableReasons
  - A list of reasons that all the SQL Server databases in a SQL Server instance cannot be protected by Rubrik.
- unprotectableReasonsV51: a list of System.Strings
  - A list of reasons that all the SQL Server databases in a SQL Server instance cannot be protected by the Rubrik CDM.
- unprotectableReasonsV52: a list of System.Strings
  - A list of reasons that all the SQL Server databases in a SQL Server instance cannot be protected by the Rubrik CDM.
- unprotectableReasonsV53: a list of System.Strings
  - A list of reasons that all the SQL Server databases in a SQL Server instance cannot be protected by the Rubrik CDM.
- unprotectableReasonsV60: a list of System.Strings
  - A list of reasons that all the SQL Server databases in a SQL Server instance cannot be protected by the Rubrik CDM.
- unprotectableReasonsV70: a list of System.Strings
  - A list of reasons that all the SQL Server databases in a SQL Server instance cannot be protected by the Rubrik CDM.
- unprotectableReasonsV80: a list of System.Strings
  - A list of reasons that all the SQL Server databases in a SQL Server instance cannot be protected by the Rubrik CDM.
- unprotectableReasonsV81: a list of System.Strings
  - A list of reasons that all the SQL Server databases in a SQL Server instance cannot be protected by the Rubrik CDM.
- unprotectableReasonsV90: a list of System.Strings
  - A list of reasons that all the SQL Server databases in a SQL Server instance cannot be protected by the Rubrik CDM.
- version: System.String
  - Supported in v5.0+
