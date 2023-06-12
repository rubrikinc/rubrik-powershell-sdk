### OraclePdb
An Oracle Pluggable Database.

- id: System.Int64
  - The Container ID for the Oracle Pluggable Database.
- name: System.String
  - Name of the Pluggable Database.
- dbId: System.Int64
  - The DBID of the Oracle database.
- openMode: OraclePdbOpenMode
  - The open mode of the Pluggable Database.
- isApplicationRoot: System.Boolean
  - Indicates whether the Pluggable Database is the application root.
- isApplicationPdb: System.Boolean
  - Indicates whether the Pluggable Database belongs to an application container.
- applicationRootContainerId: System.Int64
  - The ID of the application container to which the Pluggable Database belongs.
