### SmbDomainUpdateRequestInput
Configuration for updating an SMB domain.

- dnsServers: list of System.Strings
  - Updated DNS servers for this AD domain. Pass empty array [] to clear and revert to Rubrik cluster DNS. Omit to leave unchanged.
