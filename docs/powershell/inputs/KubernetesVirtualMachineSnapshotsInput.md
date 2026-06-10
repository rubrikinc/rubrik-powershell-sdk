### KubernetesVirtualMachineSnapshotsInput
Input for querying Kubernetes virtual machine snapshots.

- id: System.String
  - Required. ID of the Kubernetes virtual machine.
- limit: System.Int32
  - Maximum number of snapshots to return. Must be positive when supplied. When omitted, all snapshots are returned.
- offset: System.Int32
  - Starting position in the result list (0-based). Use with limit for paging.
