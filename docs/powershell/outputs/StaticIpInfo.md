### StaticIpInfo
Supported in v5.3+
Information about static IP configuration.

- dnsServers: list of System.Strings
  - Supported in v5.3+
DNS Servers for the specified IP addresses.
- gateway: System.String
  - Supported in v5.3+
Gateway for the specified IP addresses.
- ipAddresses: list of System.Strings
  - Required. Supported in v5.3+
IP addresses and ranges, separated by commas.
- subnetMask: System.String
  - Required. Supported in v5.3+
Subnet mask for the specified IP addresses.
