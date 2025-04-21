### DeleteReplicationPairTprReqChangesTemplate
Template for deleting a replication pair with the quorum authorization request.

- requestedAction: System.String
  - Requested action string.
- replicationPair: TprReplicationPair
  - Details of the replication pair, including the names of the source and target clusters.
- sourceClusterName: System.String
  - Source cluster name.
- targetClusterName: System.String
  - Target cluster name.
- existingConfigDetails: ReplicationPairConfigDetails
  - Existing configuration details JSON string.
- newConfigDetails: ReplicationPairConfigDetails
  - New configuration details JSON string.
- templateName: System.String
  - Name of the requested changes template for quorum authorization.
