### OracleHostSummary
Supported in v5.0+

- hasLogConfigFromSla: System.Boolean
  - Supported in v7.0+
  Boolean value specifying whether the database obtains the log backup configurations from the SLA Domain.
- hostId: System.String
  - Supported in v8.1+
  ID assigned to the host.
- id: System.String
  - Required. Supported in v5.0+
  ID assigned to the standalone Oracle host.
- infraPath: a list of ManagedHierarchyObjectAncestors
  - Required. Supported in v5.0+
  An array that contains information about the objects in the infrastructure path of a specified Oracle database.
- name: System.String
  - Required. Supported in v5.0+
  Hostname of the standalone Oracle host.
- numDbs: System.Int32
  - Required. Supported in v5.0+
  Count of the number of databases on the Oracle RAC.
- primaryClusterId: System.String
  - Required. Supported in v5.0+
- slaAssignable: SlaAssignable
  - 
- status: System.String
  - Required. Supported in v5.0+
  Connectivity status of the Oracle RAC.
