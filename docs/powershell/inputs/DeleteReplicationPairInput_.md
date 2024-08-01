### DeleteReplicationPairInput
Request to delete an existing replication pairing between two Rubrik clusters. When the replication pairing is deleted, the source Rubrik cluster will no longer replicate data to the target Rubrik cluster.

- forceDelete: System.Boolean
  - Force delete the replication pair. ForceDelete is set to true when the source cluster is not reachable and user wants to delete the replication pair.
- sourceClusterUuid: System.String
  - Source Rubrik cluster UUID.
- targetClusterUuid: System.String
  - Target Rubrik cluster UUID.
