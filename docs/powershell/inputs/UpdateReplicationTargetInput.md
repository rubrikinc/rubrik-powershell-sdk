### UpdateReplicationTargetInput
Request to update replication target information.

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
  - NAT or private replication setup type.
