### AddcRecoverySpecType
Active Directory Domain Controller recovery specification.

- appId: System.String
  - ID of the recovery plan.
- snappableId: System.String
  - ID of the workload.
- version: System.Int64
  - Version of the recovery specification.
- userData: System.String
  - Script to run on the recovered domain controller after reboot.
- recoveryPointOpt: System.Int64
  - Recovery point of the workload.
- customDnsIps: list of System.Strings
  - Custom DNS server IPs (used when dnsRecoveryType is DNS_RECOVERY_TYPE_CUSTOM_DNS).
- shouldRebuildGc: System.Boolean
  - Whether to rebuild global catalog on recovered domain controllers.
- shouldResetKerberos: System.Boolean
  - Whether to reset Kerberos tickets.
- winTimeServers: list of System.Strings
  - Windows time server addresses.
- domainSid: System.String
  - Domain SID of the domain containing this domain controller.
- domainId: System.String
  - FID of the domain containing this domain controller.
- dnsRecoveryType: DnsRecoveryType
  - DNS recovery type for all domain controllers.
