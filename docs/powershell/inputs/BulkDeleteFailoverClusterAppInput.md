### BulkDeleteFailoverClusterAppInput
Input for V1BulkDeleteFailoverClusterApp.

- preserveSnapshots: System.Boolean
  - Specifies whether to preserve the snapshots of the fileset that belongs to a failover cluster application. When this value is 'true,' the snapshots are preserved. The default value is 'true'.
- ids: list of System.Strings
  - Required. The ID of each failover cluster application to delete.
