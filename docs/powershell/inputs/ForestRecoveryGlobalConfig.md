### ForestRecoveryGlobalConfig
ForestRecoveryGlobalConfig contains forest-level settings for recovery.

- forestId: System.String
  - Root domain SID of the forest to recover.
- dnsRecoveryType: DnsRecoveryType
  - DNS recovery type for all DCs.
Uses cdmrestservice.DnsRecoveryType enum.
- customDnsIps: list of System.Strings
  - Custom DNS server IPs (optional).
Used when dns_recovery_type = DNS_RECOVERY_TYPE_CUSTOM_DNS.
- shouldRebuildGc: System.Boolean
  - Whether to rebuild global catalog on recovered DCs.
- shouldResetKerberos: System.Boolean
  - Whether to reset Kerberos tickets.
- winTimeServers: list of System.Strings
  - Windows time server addresses (optional).
