### UpdateReplicationTargetInput
Request to update replication target information.

- sourceGateway: ReplicationGatewayInfo
  - Gateway information of the source cluster when using the NAT setup type.
- targetGateway: ReplicationGatewayInfo
  - Gateway information of the target cluster when using the NAT setup type.
- targetNetworkInterface: NetworkInterfaceDetails
  - Network interface for communication between the source and target clusters.
- isCrossAccount: System.Boolean
  - Specifies whether the replication pair is cross-account.
- sourceClusterUuid: System.String
  - Source Rubrik cluster UUID.
- targetClusterUuid: System.String
  - Target Rubrik cluster UUID.
- setupType: ReplicationSetupType
  - NAT or private replication setup type.
