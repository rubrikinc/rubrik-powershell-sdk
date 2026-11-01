### SmbDomain
SMB domain.

- id: System.String
  - ID of the SMB domain.
- name: System.String
  - Name of the SMB domain.
- domainId: System.String
  - Domain ID of SMB domain.
- accountName: System.String
  - Account name of SMB domain.
- isArchived: System.Boolean
  - Specifies if the SMB domain is archived.
- status: SmbAuthenticationStatus
  - Authentication status of the SMB domain.
- dnsServers: list of System.Strings
  - DNS servers authoritative for this SMB domain. Empty when per-domain DNS is not configured.
- enableKerberosForSmb: System.Boolean
  - Whether SMB sessions for this domain authenticate over Kerberos instead of NTLM. False when not configured.
- cluster: Cluster
  - Cluster of the SMB domain.
