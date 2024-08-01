### MssqlAvailabilityGroupVirtualGroup
Virtual group object for SQL Server availability group.

- name: System.String
  - Name of the virtual group.
- linkedFids: list of System.Strings
  - The list of linked FIDs of AGs that are already linked.
- groups: list of MssqlAvailabilityGroups
  - List of availability groups in the virtual group.
