### ClusterInfoWithNotSyncableReasons
Describes a single cluster by its UUID and name and a list of reasons due to which given SLA can not be pushed to this cluster.

- clusterUuid: System.String
  - UUID of the Rubrik cluster.
- clusterName: System.String
  - Name of the Rubrik cluster.
- unsyncableReasons: list of SLAUnsyncableReasons
  - List of reasons due to which SLA can't be pushed to this cluster.
- clusterVersion: System.String
  - CDM version of the Rubrik cluster.
