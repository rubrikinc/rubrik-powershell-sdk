### KosmosTopologyReplicaStatus
Status of a replica within a Kosmos HA topology.

- UNSPECIFIED - Status could not be determined or is unrecognized.
- ACTIVE - Replica is participating in the HA cluster and reachable.
- DISCONNECTED - Replica is part of the cluster but currently unreachable.
- REMOVED - Replica has been removed from the cluster.
- VALIDATION_FAILED - Replica failed validation (e.g. version mismatch, replication lag
exceeded). See status_messages on KosmosTopologyReplicaInfo for the
specific failure reasons.
- PENDING_DISCOVERY - Topology discovery for the replica is still in progress.
- PENDING_REMOVAL - Replica removal has been requested but is not yet complete.
