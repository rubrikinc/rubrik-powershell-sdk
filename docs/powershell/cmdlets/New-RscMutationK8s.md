# New-RscMutationK8s
## Subcommands
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
Snapshot Kubernetes Namespace.

- There is a single argument of type CreateK8sNamespaceSnapshotsInput.
- Returns list of CreateOnDemandJobReplys.
### exportnamespace
Export Kubernetes Namespace snapshot.

- There is a single argument of type ExportK8sNamespaceInput.
- Returns CreateOnDemandJobReply.
### refreshcluster
Refresh resources of a Kubernetes cluster.

- There is a single argument of type RefreshK8sClusterInput.
- Returns CreateOnDemandJobReply.
### restorenamespace
Restores Kubernetes namespace snapshot.

- There is a single argument of type RestoreK8sNamespaceInput.
- Returns CreateOnDemandJobReply.
