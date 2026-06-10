# New-RscMutationCluster
## Subcommands
### acknowledgeclusternotification
Acknowledges a cluster notification.

- There is a single argument of type AcknowledgeClusterNotificationInput.
- Returns AcknowledgeClusterNotificationReply.
### addclusternodes
Add nodes to the CDM cluster.

- There is a single argument of type AddClusterNodesInput.
- Returns AddClusterNodesReply.
### addclusterroute
Add a new route config to all hosts in a Rubrik cluster. Supported in Rubrik CDM v5.0+

- There is a single argument of type AddClusterRouteInput.
- Returns AddClusterRouteReply.
### addnodestocloud
Add nodes to cloud cluster.

- There is a single argument of type AddNodesToCloudClusterInput.
- Returns CcProvisionJobReply.
### addpostgresqldb
Create a PostgreSQL database cluster instance

Supported in v9.2+
Start an asynchronous job to create an instance of PostgreSQL database cluster.

- There is a single argument of type AddPostgreSqlDbClusterInput.
- Returns AddPostgreSqlDbClusterReply.
### deleteclusterroute
Delete an existing route on a Rubrik cluster. Supported in Rubrik CDM v5.0+

- There is a single argument of type DeleteClusterRouteInput.
- Returns System.String.
### deletepostgresqldb
Delete a PostgreSQL database cluster

Supported in v9.2+
Initiates a job to delete a PostgreSQL database cluster. GET /postgresql/db_cluster/request/{id} endpoint can be used to monitor the progress of the job.

- There is a single argument of type DeletePostgresDbClusterInput.
- Returns AsyncRequestStatus.
### deletepostgresqldbclusterlivemount
Delete a Live Mount of a PostgreSQL database cluster

Supported in v9.2+
Deletes the Live Mount of a PostgreSQL database cluster associated with the specified ID.

- There is a single argument of type DeletePostgresDbClusterLiveMountInput.
- Returns AsyncRequestStatus.
### deleteterminatedclusteroperationjobdata
Delete the metadata of a Rubrik cluster operation job that is in a terminal state.

- There is a single argument of type DeleteTerminatedClusterOperationJobDataInput.
- Returns DeleteTerminatedClusterOperationJobDataReply.
### disconnectexocompute
Disconnects a customer-managed Exocompute cluster from RSC.

- There is a single argument of type DisconnectExocomputeClusterInput.
- Returns System.String.
### exocomputeclusterconnect
Connects an Exocompute cluster to RSC and retrieves the Kubernetes configuration YAML file.

- There is a single argument of type ExocomputeClusterConnectInput.
- Returns ExocomputeClusterConnectReply.
### generateclusterregistrationtoken
Generate a JWT that can be used to register clusters with Rubrik. If ManagedByRubrikArg is not given, the product type is inferred automatically.

- There is a single argument of type GenerateClusterRegistrationTokenInput.
- Returns ClusterRegistrationToken.
### migratecloudclusterdisks
Migrate the disks on cloud cluster.

- There is a single argument of type MigrateCloudClusterDisksInput.
- Returns CcProvisionJobReply.
### patchpostgresqldb
Update properties of the PostgreSQL database cluster instance

Supported in v9.2+
Start an asynchronous job to update the properties of the PostgreSQL database cluster.

- There is a single argument of type PatchPostgresDbClusterInput.
- Returns PatchPostgresDbClusterResponse.
### pitrestorepostgresqldb
Point-in-time recovery of the specified PostgreSQL database cluster to host

Supported in v9.2+
Initiates a job to export the data and log snapshot to the given host. The GET /postgresql/db_cluster/request/{id} endpoint can be used to monitor the progress of the job.

- There is a single argument of type PitRestorePostgresDbClusterInput.
- Returns PitRestorePostgresDbClusterResponse.
### recovercloud
Recover a Rubrik Cloud Cluster.

- There is a single argument of type RecoverCloudClusterInput.
- Returns CcProvisionJobReply.
### refreshpostgresqldb
Refresh PostgreSQL database cluster metadata

Supported in v9.2+
Initiates a job to refresh metadata of a PostgreSQL database cluster object. The GET /postgresql/db_cluster/request/{id} endpoint can be used to monitor the progress of the job.

- There is a single argument of type RefreshPostgresDbClusterInput.
- Returns AsyncRequestStatus.
### registercloud
Register a cloud cluster.

- There is a single argument of type RegisterCloudClusterInput.
- Returns RegisterCloudClusterReply.
### releasepersistentexo
Releases all the persistent Exocompute clusters for a region configuration in a cloud account.

- There is a single argument of type ReleasePersistentExoclustersInput.
- Returns System.String.
### removecdm
- There are 3 arguments.
    - clusterUUID - System.String: UUID of the Rubrik cluster.
    - isForce - System.Boolean
    - expireInDays - System.Int64: Number of days after which data from Rubrik is removed.
- Returns System.Boolean.
### removeclusternodes
Remove healthy nodes from a cluster.

- There is a single argument of type RemoveClusterNodesInput.
- Returns CcProvisionJobReply.
### replaceclusternode
Replace a removed node with a new node.

- There is a single argument of type ReplaceClusterNodeInput.
- Returns ReplaceClusterNodeReply.
### requestpersistentexo
Requests a persistent Exocompute clusters for a region configuration in a cloud account.

- There is a single argument of type RequestPersistentExoclusterInput.
- Returns RequestPersistentExoclusterReply.
### restorepostgresqldb
Restore of the specified PostgreSQL database cluster to host

Supported in v9.4+
v9.4: Initiates a job to do the restore of the PostgreSQL database cluster in the given host. The GET /postgresql/db_cluster/request/{id} endpoint can be used to monitor the progress of the job.
v9.5+: Initiates a job to restore the PostgreSQL database cluster on the given host. The GET /postgresql/db_cluster/request/{id} endpoint can be used to monitor the progress of the job.

- There is a single argument of type RestorePostgreSqlDbClusterInput.
- Returns RestorePostgreSqlDbClusterReply.
### restorepostgresqldbclustertosnapshot
Mount the specified PostgreSQL database cluster snapshot to host

Supported in v9.2+
Initiates a job to mount the snapshot to the given host. The GET /postgresql/db_cluster/request/{id} endpoint can be used to monitor the progress of the job.

- There is a single argument of type RestorePostgresDbClusterSnapshotInput.
- Returns RestorePostgresDbClusterSnapshotResponse.
### setmissingclusterstatus
Update missing cluster connection status.

- There is a single argument of type SetMissingClusterStatusInput.
- Returns SetMissingClusterStatusReply.
### takeondemandpostgresqldbclustersnapshot
Create an on-demand snapshot for the PostgreSQL database cluster

Supported in v9.2+
Initiates a job to take an on-demand snapshot of a specified PostgreSQL database cluster. You can use the GET /postgresql/db_cluster/request/{id} endpoint to monitor the progress of the job.

- There is a single argument of type TakeOnDemandPostgreSQLDbClusterSnapshotInput.
- Returns AsyncRequestStatus.
### updateclusterdefaultaddress
Update the default address of a Rubrik cluster.

- There is a single argument of type UpdateClusterDefaultAddressInput.
- Returns UpdateClusterDefaultAddressReply.
### updateclusterntpservers
Assign NTP servers to Rubrik cluster

Supported in v5.0+
Assign NTP servers to Rubrik cluster.

- There is a single argument of type UpdateClusterNtpServersInput.
- Returns ResponseSuccess.
### updateclusterpausestatus
Pauses or resumes protection on the Rubrik clusters using the cluster UUIDs.

- There is a single argument of type UpdateClusterPauseStatusInput.
- Returns UpdateClusterPauseStatusReply.
### updateclustersettings
Update Rubrik CDM cluster settings.

- There is a single argument of type UpdateClusterSettingsInput.
- Returns UpdateClusterSettingsReply.
### updatepreviewerclusterconfig
Update previewer cluster configuration.

- There is a single argument of type PreviewerClusterConfigInput.
- Returns Cluster.
