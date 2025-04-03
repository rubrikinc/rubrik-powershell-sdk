### ReplicationPairConfigDetails
Configuration details about the replication pair of Rubrik clusters.

- setupType: System.String
  - Denotes private IP or NAT configuration.
- sourceGateway: GatewayInfo
  - Source Rubrik cluster gateway information.
- targetGateway: GatewayInfo
  - Target Rubrik cluster gateway information.
- useIpv6: System.Boolean
  - Denotes whether the clusters are connected over IPv6.
- networkInterface: NetworkInterfaceSelectionType
  - Network interface names for communication between the source and target clusters. This only applies to the private network setup type.
- sourceNetworkInterfaceDetails: ClusterNetworkInterfaceDetails
  - Network interface names and types for communication between the source and target clusters. This only applies to the private network setup type.
- targetNetworkInterfaceDetails: ClusterNetworkInterfaceDetails
  - Network interface names and types for communication between the source and target clusters. This only applies to the private network setup type.
