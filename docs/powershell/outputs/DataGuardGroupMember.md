### DataGuardGroupMember
Supported in v6.0+

- dbUniqueName: System.String
  - Required. Supported in v6.0+
Unique name of the member Oracle database.
- racId: System.String
  - Supported in v6.0+
Rubrik ID of the RAC on which this database is hosted. This field is empty when the database is not hosted on a RAC environment.
- racName: System.String
  - Supported in v6.0+
Cluster name assigned to the Oracle RAC.
- role: System.String
  - Required. Supported in v6.0+
Current role of the member Oracle database.
- standaloneHostId: System.String
  - Supported in v6.0+
Rubrik ID of the standalone Oracle host on which this database is hosted. This field is empty when the database is not hosted on a standalone system.
- standaloneHostName: System.String
  - Supported in v6.0+
Name of the standalone Oracle database host.
