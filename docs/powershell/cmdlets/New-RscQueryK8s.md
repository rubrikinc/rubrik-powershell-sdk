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
Summary of a Kubernetes Cluster.

- There is a single argument of type System.String.
- Returns KubernetesCluster.
### clusters
Summary of all Kubernetes Clusters.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns KubernetesClusterConnection.
### k8scluster
- There is a single argument of type System.String.
- Returns K8sCluster.
### k8sclusters
- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns K8sClusterConnection.
### namespace
- There is a single argument of type System.String.
- Returns K8sNamespace.
### namespaces
- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
    - k8sClusterId - System.String: Optional Kubernetes cluster UUID.
- Returns K8sNamespaceConnection.
### protectionset
Summary of a Kubernetes Protection Set.

- There is a single argument of type System.String.
- Returns KubernetesProtectionSet.
### protectionsets
Summary of all Kubernetes Protection Sets.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
    - k8sClusterOptionalId - System.String: Kubernetes cluster optional UUID.
- Returns KubernetesProtectionSetConnection.
### protectionsetsnapshots
Get a list of snapshots of a Kubernetes protection set workload

Supported in v9.1+
Retrieves summary information for each of the snapshots of a specified Kubernetes protection set workload.

- There is a single argument of type QueryK8sSnapshotInput.
- Returns K8sSnapshotSummaryListResponse.
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
### virtualmachinesnapshots
Get a list of snapshots of a Kubernetes virtual machine

Supported in v9.3+
Retrieves summary information for each of the snapshots of a specified Kubernetes virtual machine.

- There is a single argument of type KubernetesVirtualMachineSnapshotsInput.
- Returns KubernetesVirtualMachineSnapshotsReply.
