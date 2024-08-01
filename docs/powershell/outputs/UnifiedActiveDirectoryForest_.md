### UnifiedActiveDirectoryForest
Consolidated Active Directory Forest information from all the Rubrik clusters.

- name: System.String
  - Name of the Active Directory Forest.
- forests: list of ActiveDirectoryForests
  - All Active Directory Forests with same name.
- unifiedDomains: list of UnifiedActiveDirectoryDomains
  - All Unified Active Directory Domains in the Forest.
