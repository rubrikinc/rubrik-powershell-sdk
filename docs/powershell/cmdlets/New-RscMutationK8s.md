# New-RscMutationK8s
## Subcommands
### addcluster
Add a Kubernetes cluster

Supported in v9.0+
Adds a Kubernetes cluster to the Rubrik cluster.

- There is a single argument of type AddK8sClusterInput.
- Returns K8sClusterSummary.
### addprotectionset
Add a Kubernetes protection set

Supported in v9.1+
Adds a Kubernetes protection set to the Rubrik cluster.

- There is a single argument of type AddK8sProtectionSetInput.
- Returns K8sProtectionSetSummary.
### archivecluster
Archive a Kubernetes cluster.

- There is a single argument of type ArchiveK8sClusterInput.
- Returns ArchiveK8sClusterReply.
### createagentmanifest
Create a Rubrik Kubernetes agent manifest.

- There is a single argument of type CreateK8sAgentManifestInput.
- Returns CreateK8sAgentManifestReply.
### createcluster
Add a Kubernetes cluster.

- There is a single argument of type CreateK8sClusterInput.
- Returns CreateK8sClusterReply.
### createnamespacesnapshots
Snapshot Kubernetes namespace.

- There is a single argument of type CreateK8sNamespaceSnapshotsInput.
- Returns list of CreateOnDemandJobReplys.
### createprotectionsetsnapshot
Initiate an on-demand backup for Kubernetes protection set workload

Supported in v9.1+
Creates an on-demand backup request for the specified Kubernetes protection set workload.

- There is a single argument of type CreateK8sProtectionSetSnapshotInput.
- Returns AsyncRequestStatus.
### deletecluster
Delete a Kubernetes cluster

Supported in v9.0+
Deletes a Kubernetes cluster by specifying the cluster ID.

- There is a single argument of type DeleteK8sClusterInput.
- Returns AsyncRequestStatus.
### deleteprotectionset
Delete a Kubernetes protection set

Supported in v9.1+
Deletes a Kubernetes protection set by specifying the protection set ID.

- There is a single argument of type DeleteK8sProtectionSetInput.
- Returns ResponseSuccess.
### downloadsnapshotfromlocation
Download a snapshot from a remote target

Supported in v9.3+
Initiates a job to download a snapshot from the specified location when the snapshot does not exist locally. The specified location has to be a remote target connected to this Rubrik cluster. If no SLA Domain is selected, the snapshot is retained forever.

- There is a single argument of type DownloadK8sSnapshotFromLocationInput.
- Returns AsyncRequestStatus.
### exportnamespace
Export Kubernetes namespace snapshot.

- There is a single argument of type ExportK8sNamespaceInput.
- Returns CreateOnDemandJobReply.
### exportprotectionsetsnapshot
v9.0: Create a job to export a Kubernetes resource set snapshot
v9.1+: Create a job to export a Kubernetes protection set snapshot

Supported in v9.0+
v9.0: Launches a job to export the Kubernetes resources from a resource set snapshot to a new namespace in a target Kubernetes cluster. The target namespace should not exist before the export.
v9.1+: Launches a job to export the Kubernetes resources from a protection set snapshot to a new namespace in a target Kubernetes cluster. The target namespace should not exist before the export.

- There is a single argument of type ExportK8sProtectionSetSnapshotInput.
- Returns AsyncRequestStatus.
### refreshcluster
Refresh resources of a Kubernetes cluster.

- There is a single argument of type RefreshK8sClusterInput.
- Returns CreateOnDemandJobReply.
### refreshv2cluster
Initiate an on-demand refresh for a Kubernetes cluster

Supported in v9.0+
Initiates an on-demand refresh request for the specified Kubernetes cluster.

- There is a single argument of type RefreshK8sV2ClusterInput.
- Returns AsyncRequestStatus.
### restorenamespace
Restores Kubernetes namespace snapshot.

- There is a single argument of type RestoreK8sNamespaceInput.
- Returns CreateOnDemandJobReply.
### restoreprotectionsetsnapshot
v9.0: Create a job to restore a Kubernetes resource set snapshot
v9.1+: Create a job to restore a Kubernetes protection set snapshot

Supported in v9.0+
v9.0: Launches a job to restore the Kubernetes resources from a resource set snapshot to its original resource set. The target namespace must exist before the restore.
v9.1+: Launches a job to restore the Kubernetes resources from a protection set snapshot to its original protection set. The target namespace must exist before the restore.

- There is a single argument of type CreateK8sRestoreJobInput.
- Returns AsyncRequestStatus.
### updatecluster
Update a Kubernetes cluster

Supported in v9.1+
Updates a Kubernetes cluster with the specified properties.

- There is a single argument of type UpdateK8sClusterInput.
- Returns ResponseSuccess.
### updateprotectionset
Update a Kubernetes protection set

Supported in v9.1+
Updates a Kubernetes protection set with the specified properties.

- There is a single argument of type UpdateK8sProtectionSetInput.
- Returns ResponseSuccess.
