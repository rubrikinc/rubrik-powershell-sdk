### NicIpConfig
IP configuration for a NIC at recovery time.

- method: IpAllocationMethod
  - IP allocation method.
- ipv4Address: System.String
  - IPv4 address (required when method is STATIC).
- subnetMask: System.String
  - Subnet mask (required when method is STATIC).
- gateway: System.String
  - Default gateway (required when method is STATIC).
- dnsServers: list of System.Strings
  - DNS server addresses.
