### K8sSnapshotInfo
Response of the query that retrieves the Kubernetes snapshot information.

- namespace: System.String
  - Kubernetes namespace name.
- expirationTime: DateTime
  - Expiration time of the snapshot.
- isArchived: System.Boolean
  - Specifies whether the snapshot is archived.
- pvcList: list of PvcInformations
  - List of information about PVCs in the namespace.
- snapshotTime: DateTime
  - Creation time of the snapshot.
