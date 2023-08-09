# Invoke-RscMutateCluster
## Subcommands
### addk8s
Add a Kubernetes cluster

Supported in v9.0+
Adds a Kubernetes cluster to the Rubrik cluster.

- There is a single argument of type AddK8sClusterInput.
- Returns K8sClusterSummary.
### addnodestocloud
Add nodes to cloud cluster.

- There is a single argument of type AddNodesToCloudClusterInput.
- Returns CcProvisionJobReply.
### archivek8s
Archive a Kubernetes cluster.

- There is a single argument of type ArchiveK8sClusterInput.
- Returns ArchiveK8sClusterReply.
### bulkdeletefailover
Delete the provided failover clusters

Supported in v5.3+
Delete the provided failover clusters.

- There is a single argument of type BulkDeleteFailoverClusterInput.
- Returns ResponseSuccess.
### createfailover
Create a failover cluster

Supported in v5.2+
Create a failover cluster.

- There is a single argument of type CreateFailoverClusterInput.
- Returns CreateFailoverClusterReply.
### createk8s
Add a Kubernetes cluster.

- There is a single argument of type CreateK8sClusterInput.
- Returns CreateK8sClusterReply.
### deletefailover
Delete a failover cluster

Supported in v5.2+
Delete a failover cluster.

- There is a single argument of type DeleteFailoverClusterInput.
- Returns ResponseSuccess.
### deletek8s
Delete a Kubernetes cluster

Supported in v9.0+
Deletes a Kubernetes cluster by specifying the cluster ID.

- There is a single argument of type DeleteK8sClusterInput.
- Returns AsyncRequestStatus.
### recovercloud
Recover a Rubrik Cloud Cluster.

- There is a single argument of type RecoverCloudClusterInput.
- Returns CcProvisionJobReply.
### refreshk8s
Refresh resources of a Kubernetes cluster.

- There is a single argument of type RefreshK8sClusterInput.
- Returns CreateOnDemandJobReply.
### refreshk8sv2
Initiate an on-demand refresh for a Kubernetes cluster

Supported in v9.0+
Initiates an on-demand refresh request for the specified Kubernetes cluster.

- There is a single argument of type RefreshK8sV2ClusterInput.
- Returns AsyncRequestStatus.
### registercloud
Register a cloud cluster.

- There is a single argument of type RegisterCloudClusterInput.
- Returns RegisterCloudClusterReply.
### removecdm
- There are 3 arguments.
    - clusterUUID - System.String: UUID of the Rubrik cluster.
    - isForce - System.Boolean
    - expireInDays - System.Int64: Number of days after which data from Rubrik is removed.
- Returns System.Boolean.
### updatefailover
Update a failover cluster

Supported in v5.2+
Update failover cluster with specified properties.

- There is a single argument of type UpdateFailoverClusterInput.
- Returns UpdateFailoverClusterReply.
