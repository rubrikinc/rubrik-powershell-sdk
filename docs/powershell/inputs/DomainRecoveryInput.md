### DomainRecoveryInput
DomainRecoveryInput contains all recovery configurations for a single domain.
Groups DC recovery and host promotion configurations with shared domain credentials.

- domainSid: System.String
  - SID of the domain (Active Directory Security Identifier, e.g. "S-1-5-21-...").
- username: System.String
  - Username with domain admin privileges (optional).
Deprecated for DC recovery.
- password: System.String
  - Password for the specified user (optional).
Deprecated for DC recovery.
- dcConfigs: list of DomainControllerRecoveryInputs
  - List of domain controllers to recover in this domain.
- hostPromotionConfigs: list of HostPromotionInputs
  - List of hosts to promote to DCs in this domain (optional).
