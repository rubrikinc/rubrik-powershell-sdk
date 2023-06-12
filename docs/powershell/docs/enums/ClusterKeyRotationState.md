### ClusterKeyRotationState
The state of the key rotation on the Rubrik cluster.

- CLUSTER_ROTATION_STATE_UNSPECIFIED - Unspecified.
- PENDING_ON_CDM - The rotation is scheduled on the Rubrik cluster.
- CDM_IN_PROGRESS - The rotation is in progress.
- CDM_DONE - The rotation succeeded on all of the nodes on the Rubrik cluster.
- CDM_ABORTED - The rotation was aborted on at least one of the nodes
 on the Rubrik cluster.
- CDM_FAILED - The rotation failed on at least one of the nodes
 on the Rubrik cluster
