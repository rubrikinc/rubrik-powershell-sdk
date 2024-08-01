### SLAUnsyncableReason
Defines a set of reasons due to which an SLA can not be pushed to a cluster

- UNSYNCABLE_REASON_UNSPECIFIED - Default unspecified reason.
- DISCONNECTED - Cluster disconnected from RSC.
- ARCHIVAL_CONFIGURATION - Archival is configured in SLA and cluster is not part of the source cluster list.
- REPLICATION_TARGET - Cluster is configured as replication target in the SLA.
- REPLICATION_PAIR_NOT_EXIST - Replication pairing is not configured between the source cluster and all the corresponding target clusters of the SLA.
- REPLICATION_TARGET_DISCONNECTED - Replication target of SLA is disconnected from RSC.
- ALREADY_SYNCED - The latest version of the SLA is already synced to the cluster.
- CLUSTER_NOT_CONFIGURED_AS_SOURCE - The cluster is not configured as a source in the SLA Domain.
