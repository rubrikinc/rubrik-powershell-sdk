### ActiveDirectoryLiveMountConfigInput


- validUsers: list of System.Strings
  - List of valid usernames in the domain that can access the SMB share for this Live Mount.
- validIps: list of System.Strings
  - List of valid SMB host IP addresses that can access the SMB share for this Live Mount.
- password: System.String
  - Password to authenticate the mounting of the share on host.
- domainName: System.String
  - Valid Active Directory domain name for users accessing this Live Mount over SMB.
- subnet: System.String
  - IP subnet specifying an outgoing VLAN interface for a Rubrik node. This is a required value when creating an export on a Rubrik node that has multiple VLAN interfaces.
