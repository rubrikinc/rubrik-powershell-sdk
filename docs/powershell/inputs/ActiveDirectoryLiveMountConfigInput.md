### ActiveDirectoryLiveMountConfigInput
Configuration for creating Active Directory Live Mount.

- validUsers: list of System.Strings
  - Supported in v9.0+
      List of valid usernames in the domain that can access the SMB share for this Live Mount.
- validIps: list of System.Strings
  - Supported in v9.0+
      List of valid SMB host IP addresses that can access the SMB share for this Live Mount.
- password: System.String
  - Supported in v9.0+
      Password to authenticate the mounting of the share on host.
- domainName: System.String
  - Supported in v9.0+
      Valid Active Directory domain name for users accessing this Live Mount over SMB.
- subnet: System.String
  - Supported in v9.0+
      IP subnet specifying an outgoing VLAN interface for a Rubrik node. This is a required value when creating an export on a Rubrik node that has multiple VLAN interfaces.
- shouldMountVhdx: System.Boolean
  - Specifies whether the Virtual Hard Disk Extended (VHDX) must be mounted during export.
