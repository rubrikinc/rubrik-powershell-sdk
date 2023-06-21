### Db2InstanceSummary
Supported in v7.0+

- databaseIds: list of System.Strings
  - Required. Supported in v7.0+
  List of IDs of databases present in this Db2 instance.
- hostIds: list of System.Strings
  - Required. Supported in v7.0+
  v7.0: List of hosts that are a part of this Db2 instance.
  v8.0+: A list of IDs of the hosts that are part of this Db2 instance.
- id: System.String
  - Required. Supported in v7.0+
  ID of the Db2 instance.
- lastRefreshTime: System.String
  - Required. Supported in v7.0+
  UTC timestamp of the most recent Db2 instance refresh job.
- name: System.String
  - Required. Supported in v7.0+
  Name of the Db2 instance.
- primaryClusterUuid: System.String
  - Required. Supported in v7.0+
  ID of the CDM cluster that protects the Db2 instance.
- protectionDate: System.String
  - Required. Supported in v7.0+
  UTC timestamp of the most recent Db2 instance refresh job.
- slaDomainId: System.String
  - Required. Supported in v7.0+
  SLA Domain ID assigned to the Db2 instance.
- slaType: System.String
  - Required. Supported in v7.0+
  Type of the SLA Domain assigned to the Db2 instance.
- statusMessage: System.String
  - Required. Supported in v7.0+
  Status messsage of the most recent Db2 instance refresh job.
- username: System.String
  - Required. Supported in v7.0+
  Username provided by the user that will be used while interacting with Db2 system.
- hostNames: list of System.Strings
  - Supported in v8.0+
  A list of names of the hosts that are part of this Db2 instance.
- isArchived: System.Boolean
  - Supported in v8.0+
  Specifies whether a Db2 instance is archived.
- relicDatabaseIds: list of System.Strings
  - Supported in v8.0+
  List of relic database IDs present in this Db2 instance.
- hadrDatabaseIds: list of System.Strings
  - Supported in v8.1+
  List of HADR database IDs present in this Db2 instance.
- status: Db2InstanceSummaryStatus
  - Supported in v7.0+
  Status of the most recent Db2 instance refresh job.
