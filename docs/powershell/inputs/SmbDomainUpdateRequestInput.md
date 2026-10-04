### SmbDomainUpdateRequestInput
Configuration for updating an SMB domain.

- enableKerberosForSmb: System.Boolean
  - Whether SMB sessions for this domain authenticate over Kerberos instead of NTLM. Pass 'false' to revert the domain to NTLM. Omit to leave unchanged.
- dnsServers: list of System.Strings
  - Updated DNS servers for this AD domain. Pass empty array [] to clear and revert to Rubrik cluster DNS. Omit to leave unchanged.
