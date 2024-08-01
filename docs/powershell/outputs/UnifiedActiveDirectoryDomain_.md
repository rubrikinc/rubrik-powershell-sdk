### UnifiedActiveDirectoryDomain
Consolidated Active Directory Domain information from all the Rubrik clusters.

- id: System.String
  - Security Identifier (SID) of the Active Directory domain.
- name: System.String
  - Name of the Active Directory domain.
- parentDomainSid: System.String
  - Security Identifier (SID) of the parent Active Directory domain.
- domains: list of ActiveDirectoryDomains
  - All Active Directory Domains with same Security Identifier (SID).
