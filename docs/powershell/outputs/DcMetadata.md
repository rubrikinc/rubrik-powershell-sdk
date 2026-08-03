### DcMetadata
Domain controller identity metadata needed for clean-room forest recovery.

- domainGuid: System.String
  - GUID of the domain.
- dnsForestName: System.String
  - DNS forest name.
- configurationNc: System.String
  - Configuration naming context.
- rootDomain: System.String
  - Root domain name.
- machineDnName: System.String
  - Machine distinguished name.
- computerObjectDn: System.String
  - Computer object distinguished name.
- domainFunctionalLevel: System.Int32
  - Domain functional level.
- forestFunctionalLevel: System.Int32
  - Forest functional level.
- dnsServerForwarders: list of System.Strings
  - DNS server forwarders.
