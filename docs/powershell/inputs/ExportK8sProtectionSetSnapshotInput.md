### ExportK8sProtectionSetSnapshotInput
Input for exporting a Kubernetes protection set snapshot.

- id: System.String
  - Required. v9.0: The ID of the resource set snapshot to be exported.
v9.1+: The ID of the protection set snapshot to be exported.
- jobConfig: K8sExportParametersInput
  - Required. v9.0: Configuration for the job to export Kubernetes resources from a resource set snapshot.
v9.1+: Configuration for the job to export Kubernetes resources from a protection set snapshot.
