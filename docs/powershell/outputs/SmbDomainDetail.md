### SmbDomainDetail
Supported in v5.0+

- isStickySmbService: System.Boolean
  - Required. Supported in v5.0+
A Boolean value that determines whether to run the SMB service when no shares are exposed. When this value is 'true,' the SMB service runs even when no shares are exposed. When this value is 'false,' the SMB service does not run when no shares are exposed.
- name: System.String
  - Required. Supported in v5.0+
Specifies name to identify Active Directory domain for SMB authentication.
- serviceAccount: System.String
  - Supported in v5.0+
Specifies the service principal name (SPN) used for joining the Active Directory domain.
- status: SmbDomainStatus
  - Required. Supported in v5.0+
State of the domain.
- allowTrustedDomain: System.Boolean
  - Supported in v9.5+
A Boolean value that determines whether to allow trusted domains in SMB configuration. When this value is 'true,' trusted domains are allowed. When this value is 'false,' trusted domains are not allowed. The default value is 'false.'
- enableKerberosForSmb: System.Boolean
  - A Boolean value that determines whether SMB sessions for this domain authenticate over Kerberos instead of NTLM. When this value is 'true,' Kerberos is used. When this value is 'false,' NTLM is used. The default value is 'false.'
- dnsServers: list of System.Strings
  - Supported in v9.6+
DNS servers authoritative for this AD domain (max 3, glibc resolver limit). Each must be a usable IPv4 or IPv6 address (not loopback, link-local, multicast, broadcast, or unspecified). Strict tenant isolation: the SMB container resolves this domain via these servers only, no fallback to cluster DNS.
