### CreateReplicationPairInput
Request to create a replication pair between two Rubrik clusters.

- sourceGateway: ReplicationGatewayInfo
  - Gateway information of the source cluster when using the NAT setup type.
- targetGateway: ReplicationGatewayInfo
  - Gateway information of the target cluster when using the NAT setup type.
- networkInterface: NetworkInterfaceSelection
  - Network interface names for communication between the source and target clusters. This applies only to the private network setup type.
- sourceClusterUuid: System.String
  - Source Rubrik cluster UUID.
- targetClusterUuid: System.String
  - Target Rubrik cluster UUID.
- setupType: ReplicationSetupType
  - NAT or Private replication setup type.
- useIpv6: System.Boolean
  - Whether to use IPv6 for replication pairing.
