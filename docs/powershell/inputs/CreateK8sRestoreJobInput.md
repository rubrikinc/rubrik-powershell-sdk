### CreateK8sRestoreJobInput


- id: System.String
  - Required. v9.0: The ID of the resource set snapshot to be restored.
      v9.1+: The ID of the protection set snapshot to be restored.
- jobConfig: K8sRestoreParametersInput
  - Required. v9.0: Configuration for restoring Kubernetes resources from a resource set snapshot using a job.
      v9.1+: Configuration for restoring Kubernetes resources from a protection set snapshot using a job.
