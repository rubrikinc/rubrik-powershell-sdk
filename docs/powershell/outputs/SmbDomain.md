### SmbDomain
SMB domain.

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
- id: System.String
  - ID of the SMB domain.
- cluster: Cluster
  - Cluster of the SMB domain.
