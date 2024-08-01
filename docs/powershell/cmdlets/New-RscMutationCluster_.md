# New-RscMutationCluster
## Subcommands
### addclusternodes
Add nodes to the CDM cluster.

- There is a single argument of type AddClusterNodesInput.
- Returns AddClusterNodesReply.
### addclusterroute
Add a new route config to all hosts

Supported in v5.0+
Add a new route config to all hosts.

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
### bulkrotateclusterencryptionkey
Perform a one-time data-at-rest encryption key rotation for multiple Rubrik clusters in bulk.

- There is a single argument of type BulkRotateClusterEncryptionKeyInput.
- Returns BulkRotateClusterEncryptionKeyReply.
### createmulticlusterpc
Create a Multi Cluster Prism Central object with the corresponding configuration parameters and the CDM-PrismElement mapping provided by the user.

- There is a single argument of type CreateMultiClusterPcInput.
- Returns BatchAsyncRequestStatus.
### deleteclusterroute
Delete an existing route

Supported in v5.0+
Delete an existing route that was configured.

- There is a single argument of type DeleteClusterRouteInput.
- Returns System.String.
### deletemulticlusterpc
Delete a Multi-cluster Prism Central object.

- There is a single argument of type DeleteMultiClusterPcInput.
- Returns BatchAsyncRequestStatus.
### deletepostgresqldb
Delete a PostgreSQL database cluster

Supported in v9.2+
Initiates a job to delete a PostgreSQL database cluster. GET /postgresql/db_cluster/request/{id} endpoint can be used to monitor the progress of the job.

- There is a single argument of type DeletePostgresDbClusterInput.
- Returns AsyncRequestStatus.
### deletepostgresqldbclusterlivemount
Deletes the live mount of PostgreSQL database cluster for the specified live mount FID.

- There is a single argument of type DeletePostgresDbClusterLiveMountInput.
- Returns AsyncRequestStatus.
### deleteterminatedclusteroperationjobdata
Delete the metadata of a Rubrik cluster operation job that is in a terminal state.

- There is a single argument of type DeleteTerminatedClusterOperationJobDataInput.
- Returns DeleteTerminatedClusterOperationJobDataReply.
### generateclusterregistrationtoken
Generate a JWT that can be used to register clusters with Rubrik. If ManagedByRubrikArg is not given, the product type is inferred automatically.

- There is a single argument of type GenerateClusterRegistrationTokenInput.
- Returns ClusterRegistrationToken.
### patchpostgresqldb
Update properties of the PostgreSQL database cluster instance

Supported in v9.2+
Start an asynchronous job to update the properties of the PostgreSQL database cluster.

- There is a single argument of type PatchPostgresDbClusterInput.
- Returns PatchPostgresDbClusterResponse.
### pauseclusteralerts
Pause alerts from a Rubrik cluster.

- There is a single argument of type PauseClusterAlertsInput.
- Returns System.String.
### pingmulticlusterpc
Connectivity status and details of the provided Nutanix Prism Central

Supported in v9.1+
Check connectivity status to the Nutanix Prism Central host and details of the included Prism Elements.

- There is a single argument of type PingMultiClusterPcInput.
- Returns PingMultiClusterPcReply.
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
### refreshmulticlusterpc
Refresh a Multi-cluster Prism Central object.

- There is a single argument of type RefreshMultiClusterPcInput.
- Returns BatchAsyncRequestStatus.
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
### resetnewmigrationclustersinfo
Reset information about newly added Rubrik clusters for RSC migration

- The resetnewmigrationclustersinfo subcommand takes no arguments.
- Returns ResetNewMigrationClustersInfoReply.
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
### syncrotateclusterencryptionkey
Perform a one-time key rotation on a Rubrik cluster.

- There is a single argument of type SyncRotateClusterEncryptionKeyInput.
- Returns System.String.
### takeondemandpostgresqldbclustersnapshot
Create an on-demand snapshot for the PostgreSQL database cluster

Supported in v9.2+
Initiates a job to take an on-demand snapshot of a specified PostgreSQL  database cluster. You can use the GET /postgresql/db_cluster/request/{id} endpoint  to monitor the progress of the job.

- There is a single argument of type TakeOnDemandPostgreSQLDbClusterSnapshotInput.
- Returns AsyncRequestStatus.
### unpauseclusteralerts
Resume alerts from a Rubrik cluster.

- There is a single argument of type UnpauseClusterAlertsInput.
- Returns System.String.
### updateclustercapacityquotasfororg
Updates the cluster capacity quotas of an organization to match the provided configurations.

- There is a single argument of type UpdateClusterCapacityQuotasForOrgInput.
- Returns System.String.
### updateclusterdefaultaddress
Update the default address of a Rubrik cluster.

- There is a single argument of type UpdateClusterDefaultAddressInput.
- Returns UpdateClusterDefaultAddressReply.
### updateclusterlocation
- There are 2 arguments.
    - clusterUuid - System.String: The Rubrik cluster ID.
    - clusterLocation - ClusterLocationEdit
- Returns Cluster.
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
### updateclusterregisteredmode
Update the registered mode of a Rubrik cluster.

- There is a single argument of type UpdateClusterRegisteredModeInput.
- Returns UpdateClusterRegisteredModeReply.
### updateclustersettings
Update Rubrik CDM cluster settings.

- There is a single argument of type UpdateClusterSettingsInput.
- Returns UpdateClusterSettingsReply.
### updateclusterthriftauthtoken
Update Rubrik CDM cluster thrift token for cross-account replication target.

- There is a single argument of type UpdateClusterThriftAuthTokenInput.
- Returns ResponseSuccess.
### updatemulticlusterpc
Update a Multi Cluster Prism Central object with the corresponding configuration parameters and a modified CDM-PrismElement mapping provided by the user.

- There is a single argument of type UpdateMultiClusterPcInput.
- Returns UpdateMultiClusterPcReply.
### updatepreviewerclusterconfig
Update previewer cluster configuration.

- There is a single argument of type PreviewerClusterConfigInput.
- Returns Cluster.
