### AddcRecoverySpec
Active Directory Domain Controller recovery specification.

- version: System.Int64
  - Version of the recovery specification (system-managed).
- dnsRecoveryType: DnsRecoveryType
  - DNS recovery type for all DCs.
Uses cdmrestservice.DnsRecoveryType enum. This is a per forest setting.
- customDnsIps: list of System.Strings
  - Custom DNS server IPs.
Used when dns_recovery_type = DNS_RECOVERY_TYPE_CUSTOM_DNS. This is a per
forest setting.
- shouldRebuildGc: System.Boolean
  - Whether to rebuild the global catalog on recovered DCs. This is a per
forest setting.
- shouldResetKerberos: System.Boolean
  - Whether to reset Kerberos tickets. This is a per forest setting.
- winTimeServers: list of System.Strings
  - Windows time server addresses. This is a per forest setting.
- domainSid: System.String
  - Domain SID of the domain containing this DC.
- domainId: System.String
  - ID of the domain containing this DC.
