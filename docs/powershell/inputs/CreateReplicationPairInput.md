### CreateReplicationPairInput
Request to create a replication pair between two Rubrik clusters.

- sourceGateway: ReplicationGatewayInfo
  - Gateway information of the source cluster when using the NAT setup type.
- targetGateway: ReplicationGatewayInfo
  - Gateway information of the target cluster when using the NAT setup type.
- targetNetworkInterface: NetworkInterfaceDetails
  - Network interface for communication between the source and target clusters.
- isCrossAccount: System.Boolean
  - Deprecated: The field is set automatically according to the Rubrik CDM cluster involved in replication pairing.
- sourceClusterUuid: System.String
  - Source Rubrik cluster UUID.
- targetClusterUuid: System.String
  - Target Rubrik cluster UUID.
- setupType: ReplicationSetupType
  - NAT or Private replication setup type.
