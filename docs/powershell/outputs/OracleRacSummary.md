### OracleRacSummary
Supported in v5.0+

- id: System.String
  - Required. Supported in v5.0+
  ID assigned to the Oracle RAC.
- name: System.String
  - Required. Supported in v5.0+
  Cluster name assigned to the Oracle RAC.
- nodeOrder: list of OracleNodeOrders
  - Required. Supported in v5.0+
  Specifies an order for the RAC nodes. Automated Oracle backups use the RAC nodes in the specified order.
- nodes: list of OracleNodePropertiess
  - Required. Supported in v5.0+
  Details of the nodes of this Oracle RAC.
- numDbs: System.Int32
  - Required. Supported in v5.0+
  Count of the number of databases on the Oracle RAC.
- numNodes: System.Int32
  - Required. Supported in v5.0+
  Count of the number of nodes on the Oracle RAC.
- primaryClusterId: System.String
  - Required. Supported in v5.0+
- status: System.String
  - Required. Supported in v5.0+
  Connectivity status of the Oracle RAC.
- shouldDistributeBackupsAutomatically: System.Boolean
  - Supported in v6.0+
  Boolean value that specifies whether the Rubrik cluster should automatically distribute backups across Oracle database instances running on the RAC nodes. By default, backups are run from the first connected node in the RAC priority order.
- hasLogConfigFromSla: System.Boolean
  - Supported in v7.0+
  Boolean value specifying whether the database obtains the log backup configurations from the SLA Domain.
- slaAssignable: SlaAssignable
  - 
