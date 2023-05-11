# Invoke-RscMutateCluster
## Subcommands
### AddNodesToCloud
Add nodes to cloud cluster.

- The Input parameter takes a single value of type AddNodesToCloudClusterInput.
- Returns CcProvisionJobReply.
### ArchiveK8s
Archive a Kubernetes cluster.

- The Input parameter takes a single value of type ArchiveK8sClusterInput.
- Returns ArchiveK8sClusterReply.
### BulkDeleteFailover
Delete the provided failover clusters

Supported in v5.3+
Delete the provided failover clusters.

- The Input parameter takes a single value of type BulkDeleteFailoverClusterInput.
- Returns ResponseSuccess.
### CreateFailover
Create a failover cluster

Supported in v5.2+
Create a failover cluster.

- The Input parameter takes a single value of type CreateFailoverClusterInput.
- Returns CreateFailoverClusterReply.
### CreateK8s
Add a Kubernetes cluster.

- The Input parameter takes a single value of type CreateK8sClusterInput.
- Returns CreateK8sClusterReply.
### DeleteFailover
Delete a failover cluster

Supported in v5.2+
Delete a failover cluster.

- The Input parameter takes a single value of type DeleteFailoverClusterInput.
- Returns ResponseSuccess.
### RefreshK8s
Refresh resources of a Kubernetes cluster.

- The Input parameter takes a single value of type RefreshK8sClusterInput.
- Returns CreateOnDemandJobReply.
### RegisterCloud
Register a cloud cluster.

- The Input parameter takes a single value of type RegisterCloudClusterInput.
- Returns RegisterCloudClusterReply.
### RemoveCdm
- The Input parameter takes a hashtable with 3 name and value pairs.
    - clusterUUID - System.String: UUID of the Rubrik cluster.
    - expireInDays - System.Int64: Number of days after which data from Rubrik is removed.
    - isForce - System.Boolean
- Returns System.Boolean.
### UpdateFailover
Update a failover cluster

Supported in v5.2+
Update failover cluster with specified properties.

- The Input parameter takes a single value of type UpdateFailoverClusterInput.
- Returns UpdateFailoverClusterReply.
