# Invoke-RscMutateCluster
## Subcommands
### Addnodestocloud
Add nodes to cloud cluster.

- There is a single argument of type AddNodesToCloudClusterInput.
- Returns CcProvisionJobReply.
### Archivek8s
Archive a Kubernetes cluster.

- There is a single argument of type ArchiveK8sClusterInput.
- Returns ArchiveK8sClusterReply.
### Bulkdeletefailover
Delete the provided failover clusters

Supported in v5.3+
Delete the provided failover clusters.

- There is a single argument of type BulkDeleteFailoverClusterInput.
- Returns ResponseSuccess.
### Createfailover
Create a failover cluster

Supported in v5.2+
Create a failover cluster.

- There is a single argument of type CreateFailoverClusterInput.
- Returns CreateFailoverClusterReply.
### Createk8s
Add a Kubernetes cluster.

- There is a single argument of type CreateK8sClusterInput.
- Returns CreateK8sClusterReply.
### Deletefailover
Delete a failover cluster

Supported in v5.2+
Delete a failover cluster.

- There is a single argument of type DeleteFailoverClusterInput.
- Returns ResponseSuccess.
### Recovercloud
Recover a Rubrik Cloud Cluster.

- There is a single argument of type RecoverCloudClusterInput.
- Returns CcProvisionJobReply.
### Refreshk8s
Refresh resources of a Kubernetes cluster.

- There is a single argument of type RefreshK8sClusterInput.
- Returns CreateOnDemandJobReply.
### Registercloud
Register a cloud cluster.

- There is a single argument of type RegisterCloudClusterInput.
- Returns RegisterCloudClusterReply.
### Removecdm
- There are 3 arguments.
    - clusterUUID - System.String: UUID of the Rubrik cluster.
    - isForce - System.Boolean
    - expireInDays - System.Int64: Number of days after which data from Rubrik is removed.
- Returns System.Boolean.
### Updatefailover
Update a failover cluster

Supported in v5.2+
Update failover cluster with specified properties.

- There is a single argument of type UpdateFailoverClusterInput.
- Returns UpdateFailoverClusterReply.
