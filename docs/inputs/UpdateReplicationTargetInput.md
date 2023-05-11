### UpdateReplicationTargetInput
Request to update replication target information.

- setupType: ReplicationSetupType
  - NAT or private replication setup type.
- sourceClusterUuid: System.String
  - Source Rubrik cluster UUID.
- sourceGateway: ReplicationGatewayInfo
  - Gateway information of the source cluster when using the NAT setup type.
- targetClusterUuid: System.String
  - Target Rubrik cluster UUID.
- targetGateway: ReplicationGatewayInfo
  - Gateway information of the target cluster when using the NAT setup type.
