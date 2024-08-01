### ReplicationTargetSummary
Supported in v5.0+

- id: System.String
  - Required. Supported in v5.0+
  v5.0-v5.2: 
  v5.3+: The Managed ID of the target Rubrik cluster. A Managed ID represents the UUID and type of the object.
- replicationSetup: System.String
  - Required. Supported in v5.0+
  v5.0-v5.2: 
  v5.3+: Replication network configuration type. Currently 'NAT', 'Private Network', and 'Polaris' are available.
- targetClusterAddress: System.String
  - Supported in v5.0+
  v5.0-v5.2: 
  v5.3+: The IP address of a node on the replication target Rubrik cluster.
- targetClusterName: System.String
  - Supported in v5.0+
  v5.0-v5.2: 
  v5.3+: The cluster name of the target Rubrik cluster.
- targetClusterUuid: System.String
  - Supported in v5.0+
  v5.0-v5.2: 
  v5.3+: The UUID of the target Rubrik cluster.
- isRetentionLockEnabledLocation: System.Boolean
  - Supported in v5.1+: Indicates location is Write Once Read Many (WORM) SLA Domain enabled. When this value is 'true', a WORM SLA Domain exists that replicates to the target Rubrik cluster. A WORM SLA Domain is a SLA Domain that guarantees snapshots derived from the SLA Domain do not expire before the mandatory retention period.
- isReplicationTargetPauseEnabled: System.Boolean
  - Supported in v5.2+: Indicates whether the local target Rubrik cluster has paused replication from the source Rubrik cluster using source specific replication pause.
- targetGateway: NatGatewayInfo
  - Supported in v5.0+
  v5.0-v5.2: 
  v5.3+: The network gateway on the target Rubrik cluster for NAT network configurations.
