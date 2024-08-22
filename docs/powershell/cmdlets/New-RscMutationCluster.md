# New-RscMutationCluster
## Subcommands
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
### deleteclusterroute
Delete an existing route on a Rubrik cluster. Supported in Rubrik CDM v5.0+

- There is a single argument of type DeleteClusterRouteInput.
- Returns System.String.
### generateclusterregistrationtoken
Generate a JWT that can be used to register clusters with Rubrik. If ManagedByRubrikArg is not given, the product type is inferred automatically.

- There is a single argument of type GenerateClusterRegistrationTokenInput.
- Returns ClusterRegistrationToken.
### recovercloud
Recover a Rubrik Cloud Cluster.

- There is a single argument of type RecoverCloudClusterInput.
- Returns CcProvisionJobReply.
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
### requestpersistentexo
Requests a persistent Exocompute clusters for a region configuration in a cloud account.

- There is a single argument of type RequestPersistentExoclusterInput.
- Returns RequestPersistentExoclusterReply.
### setmissingclusterstatus
Update missing cluster connection status.

- There is a single argument of type SetMissingClusterStatusInput.
- Returns SetMissingClusterStatusReply.
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
### updateclustersettings
Update Rubrik CDM cluster settings.

- There is a single argument of type UpdateClusterSettingsInput.
- Returns UpdateClusterSettingsReply.
### updatepreviewerclusterconfig
Update previewer cluster configuration.

- There is a single argument of type PreviewerClusterConfigInput.
- Returns Cluster.
