# New-RscQueryK8s
## Subcommands
### appmanifest
Kubernetes Rubrik Backup Service manifest.

- There are 5 arguments.
    - app - System.String: Name of the Kubernetes Rubrik Backup Service app.
    - version - System.String: The current Kubernetes Rubrik Backup Service version.
    - retrieveLatestVersion - System.Boolean: Retrieve the manifest for the latest version.
    - targetVersion - System.String: The optional target version for upgrade of Rubrik Kubernetes Agent. If not specified, the latest compatible version is used.
    - k8sClusterId - System.String: Optional Kubernetes cluster UUID.
- Returns K8sAppManifest.
### cluster
- There is a single argument of type System.String.
- Returns K8sCluster.
### clusters
- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns K8sClusterConnection.
### namespace
- There is a single argument of type System.String.
- Returns K8sNamespace.
### namespaces
- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
    - k8sClusterId - System.String: Optional Kubernetes cluster UUID.
- Returns K8sNamespaceConnection.
### replicasnapshotinfos
Information of all replicas for a Kubernetes snapshot.

- There are 2 arguments.
    - snapshotId - System.String: The snapshot ID.
    - snappableId - System.String: The FID of the workload.
- Returns list of ReplicatedSnapshotInfos.
### snapshotinfo
Kubernetes snapshot information.

- There are 3 arguments.
    - snapshotId - System.String: The snapshot UUID.
    - namespaceId - System.String: The FID of the Kubernetes Namespace.
    - isReplica - System.Boolean: Specifies if the snapshot is a replica snapshot.
- Returns K8sSnapshotInfo.
