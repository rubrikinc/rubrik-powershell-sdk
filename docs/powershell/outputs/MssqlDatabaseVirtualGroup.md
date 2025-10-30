### MssqlDatabaseVirtualGroup
Virtual group object for SQL Server databases.

- name: System.String
  - Name of the virtual group.
- linkedFids: list of System.Strings
  - The list of linked FIDs of AGs that are already linked.
- databases: list of MssqlDatabases
  - List of databases in the virtual group.
- activeDbFid: System.String
  - Forever ID of the active database.
