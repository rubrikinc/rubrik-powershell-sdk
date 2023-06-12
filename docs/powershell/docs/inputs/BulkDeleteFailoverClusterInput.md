### BulkDeleteFailoverClusterInput
Input for V1BulkDeleteFailoverCluster.

- preserveSnapshots: System.Boolean
  - Specifies whether to preserve the fileset snapshots that belong to a failover cluster. When this value is 'true', the snapshots are preserved. The default value is 'true'.
- ids: list of System.Strings
  - Required. The ID of each failover cluster to delete.
