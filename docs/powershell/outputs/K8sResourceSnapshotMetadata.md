### K8sResourceSnapshotMetadata
Kubernetes workload related app metadata for a snapshot.

- version: System.String
  - The version of Kubernetes resource snapshot metadata format.
- groups: list of ApiGroupToResourcesObjectss
  - Map of API groups to Kubernetes resource objects grouped by resource type in the snapshot.
- noAppMetadata: System.Boolean
  - Boolean flag indicating that the resource snapshot metadata is not available for the snapshot.
