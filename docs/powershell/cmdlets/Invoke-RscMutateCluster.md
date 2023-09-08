# Invoke-RscMutateCluster
## Subcommands
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
### recovercloud
Recover a Rubrik Cloud Cluster.

- There is a single argument of type RecoverCloudClusterInput.
- Returns CcProvisionJobReply.
### refreshk8s
Refresh resources of a Kubernetes cluster.

- There is a single argument of type RefreshK8sClusterInput.
- Returns CreateOnDemandJobReply.
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
### updatedatabaselogreportingproperties
Update the database log backup report properties

Supported in v5.3+
Update the properties for the database (SQL and Oracle) log backup delay email notification creation. The properties are logDelayThresholdInMin and logDelayNotificationFrequencyInMin.

- There is a single argument of type UpdateDatabaseLogReportingPropertiesForClusterInput.
- Returns DbLogReportProperties.
### updatefailover
Update a failover cluster

Supported in v5.2+
Update failover cluster with specified properties.

- There is a single argument of type UpdateFailoverClusterInput.
- Returns UpdateFailoverClusterReply.
