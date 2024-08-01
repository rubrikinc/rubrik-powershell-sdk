### ActiveDirectorySnapshotBrowse
Entry of a single Active Directory object.

- dn: System.String
  - Supported in v9.0+
  Distinguished name of the Active Directory object.
- dnt: System.Int32
  - Required. Supported in v9.0+
  v9.0: Distinguished Name Tag of the Active Directory Object whose children needs to be enumerated.
  v9.1+: The Distinguished Name Tag (DNT) of the Active Directory object.
- name: System.String
  - Required. Supported in v9.0+
  Name of the Active Directory object.
- description: System.String
  - Required. Supported in v9.0+
  Description of the Active Directory object.
- activeDirectoryObjectType: ActiveDirectoryObjectType
  - Type of the object.
