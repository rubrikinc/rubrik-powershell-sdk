### ActiveDirectoryModifyLiveMountConfigInput


- validIps: list of System.Strings
  - List of valid SMB host IP addresses that can access the SMB share for this Live Mount.
- password: System.String
  - Password to authenticate mounting the share on a host.
- subnet: System.String
  - IP subnet specifying an outgoing VLAN interface for a Rubrik node. You must provide the IP subnet when creating a Managed Volume on a Rubrik node with multiple VLAN interfaces.
